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
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            
        ListNode res=new ListNode(0);
        ListNode cur = res;
        int carry = 0;
        while(l1!=null||l2!=null)
        {
            
            int num1 = l1==null?0:l1.val;
            int num2 = l2==null?0:l2.val;
            int sum = num1+num2+carry;
            carry = sum/10;
            cur.next = new ListNode(sum % 10);
            cur = cur.next;
            l1=l1==null?null:l1.next;
            l2=l2==null?null:l2.next;
        }
        if(carry==1)
        {
            cur.next = new ListNode(1);
        }
       return res.next;
    }


}