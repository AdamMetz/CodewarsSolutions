/*

Simple assembler interpreter (https://www.codewars.com/kata/58e24788e24ddee28e000053/train/csharp)

We want to create a simple interpreter of assembler which will support the following instructions:

mov x y - copies y (either a constant value or the content of a register) into register x
inc x - increases the content of the register x by one
dec x - decreases the content of the register x by one
jnz x y - jumps to an instruction y steps away (positive means forward, negative means backward, y can be a register or a constant), but only if x (a constant or a register) is not zero
Register names are alphabetical (letters only). Constants are always integers (positive or negative).

Note: the jnz instruction moves relative to itself. For example, an offset of -1 would continue at the previous instruction, while an offset of 2 would skip over the next instruction.

The function will take an input list with the sequence of the program instructions and will execute them. The program ends when there are no more instructions to execute, then it returns a dictionary (a table in COBOL) with the contents of the registers.

Also, every inc/dec/jnz on a register will always be preceeded by a mov on the register first, so you don't need to worry about uninitialized registers.

Example
["mov a 5"; "inc a"; "dec a"; "dec a"; "jnz a -1"; "inc a"]

visualized:

mov a 5
inc a
dec a
dec a
jnz a -1
inc a
The above code will:

set register a to 5,
increase its value by 1,
decrease its value by 2,
then decrease its value until it is zero (jnz a -1 jumps to the previous instruction if a is not zero)
and then increase its value by 1, leaving register a at 1
So, the function should return:

new Dictionary<string, int> { { "a" , 1 } };

*/

using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
    public static class SimpleAssembler
    {
        public static Dictionary<string, int> Interpret(string[] program)
        {
            Dictionary<string, int> registers = new Dictionary<string, int>();

            for (int i = 0; i < program.Length; i++)
            {
                string[] instructionParts = program[i].Split(" ");

                string instruction = instructionParts[0];
                string register = instructionParts[1];

                int val = 0;
                if (instructionParts.Length == 3)
                {
                    if (Char.IsLetter(instructionParts[2][0]))
                    {
                        val = registers[instructionParts[2]];
                    }
                    else
                    {
                        val = Int32.Parse(instructionParts[2]);
                    }
                }

                switch (instruction)
                {
                    case "mov":
                        registers[register] = val;
                        break;
                    case "inc":
                        registers[register]++;
                        break;
                    case "dec":
                        registers[register]--;
                        break;
                    case "jnz":
                        if (Char.IsLetter(register[0]))
                        {
                            if (registers[register] != 0) i += (val - 1);
                        }
                        else
                        {
                            if (Int32.Parse(register) != 0) i += (val - 1);
                        }
                        break;
                    default:
                        throw new ArgumentException("Invalid instruction.");
                }
            }
            return registers;
        }
    }
}
