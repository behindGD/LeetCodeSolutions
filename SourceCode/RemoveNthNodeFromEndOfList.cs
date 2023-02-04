/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head == null) return head;
        
        ListNode curr = head;
        ListNode temp = curr;
        ListNode res = curr;
        
        int count = 0;

        while (temp != null)
        {
            count++;
            temp = temp.next;
        }

        if (count == 1 || count == n) return res.next;
        
        while (head != null)
        {
            if (count == n + 1)
            {
                curr.next = head.next.next;
                break;
            }

            count--;
            curr = head.next;
            head = head.next;
        }

        return res;
    }
}
