/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var answerHead = new ListNode(0);
        var answer = answerHead;
        var node1Valid = true;
        var node2Valid = true;
        int sum = 0;
        int carry = 0;
        
        while (node1Valid || node2Valid) {
            if (node1Valid && node2Valid) {
                sum = l1.val + l2.val + carry;
            }
            else {
                if (node1Valid) {
                    sum = l1.val + carry;
                }
                else if (node2Valid) {
                    sum = l2.val + carry;
                }
            }
            
            if (sum > 9) {
                carry = 1;
                sum -= 10;
            }
            else {
                carry = 0;
            }
 
            answer.val = sum;
            
            if (l1 != null) {
                l1 =  l1.next;
            }
            
            if (l2 != null) {
                l2 = l2.next;
            }
            
            if (l1 == null) {
                node1Valid = false;
            }
            
            if (l2 == null) {
                node2Valid = false;
            }
            
            if (l1 != null || l2 != null) {
                answer.next = new ListNode(0);
                answer = answer.next;
            }
        }  // end while
        
        if (carry == 1) {
            answer.next = new ListNode(0);
            answer = answer.next;
            answer.val = carry;
        }
        
        return  answerHead;
    }
}  // end class Solution
