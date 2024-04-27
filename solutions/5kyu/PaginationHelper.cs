/*

PaginationHelper (https://www.codewars.com/kata/515bb423de843ea99400000a/train/csharp)

For this exercise you will be strengthening your page-fu mastery. You will complete the PaginationHelper class, 
which is a utility class helpful for querying paging information related to an array.

The class is designed to take in an array of values and an integer indicating how many items will be allowed per each page. 
The types of values contained within the collection/array are not relevant.

The following are some examples of how this class is used:

var helper = new PaginationHelper<char>(new List<char>{'a', 'b', 'c', 'd', 'e', 'f'}, 4);
helper.PageCount; // should == 2
helper.ItemCount; // should == 6
helper.PageItemCount(0); // should == 4
helper.PageItemCount(1); // last page - should == 2
helper.PageItemCount(2); // should == -1 since the page is invalid

// pageIndex takes an item index and returns the page that it belongs on
helper.PageIndex(5); // should == 1 (zero based index)
helper.PageIndex(2); // should == 0
helper.PageIndex(20); // should == -1
helper.PageIndex(-10); // should == -1

*/

using System;
using System.Collections.Generic;

public class PaginationHelper<T>
{
  private IList<T> collection;
  private int itemsPerPage;
  
  public PaginationHelper(IList<T> collection, int itemsPerPage)
  {
    this.collection = collection;
    this.itemsPerPage = itemsPerPage;
  }

  public int ItemCount
  {
    get
    {
      return collection.Count;
    }
  }

  public int PageCount
  {
    get
    {
      int remainder = ItemCount % itemsPerPage;
      return remainder == 0 ? (ItemCount / itemsPerPage) : (ItemCount / itemsPerPage + 1);
    }
  }

  public int PageItemCount(int pageIndex)
  {
    if ((pageIndex + 1) > PageCount || pageIndex < 0) return -1;
    if ((pageIndex + 1) < PageCount) return itemsPerPage;
    return ItemCount - ((PageCount - 1) * itemsPerPage);
  }

  public int PageIndex(int itemIndex)
  {
    if (itemIndex < 0 || itemIndex >= ItemCount) return -1;
    return itemIndex / itemsPerPage;
  }
}
