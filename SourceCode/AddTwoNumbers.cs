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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        int sum = 0;
        
        ListNode ori = new();
        ListNode res = ori;
        
        while (l1 != null || l2 != null || sum != 0)
        {
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }
            
            ListNode newNode = new();
            
            newNode.val = sum % 10;
            res.next = newNode;
            res = newNode;
            
            sum /= 10;
        }
        
        return ori.next;
    }
}
