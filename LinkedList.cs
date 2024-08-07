//1290. Convert Binary Number in a Linked List to Integer
using System.Runtime.InteropServices;

namespace DaySeven
{
  public static class LinkedList
  {
    public static int GetDecimalValue(ListNode head)
    {
      int sum = 0;
 
        while(head != null){
            sum = sum * 2 + head.val;
            head = head.next;
        }

        return sum;
    }
  }

  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
      this.val = val;
      this.next = next;
    }
  }
}