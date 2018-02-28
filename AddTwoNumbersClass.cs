using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class AddTwoNumbersClass
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head=new ListNode(0) ;
            ListNode currentNode = head;
            int flag = 0;//判断两数相加是否大于等于10
            int sum = 0;//计算两数相加之和
            while (l1.next != null&& l2.next != null)
            {
                sum = l1.val + l2.val;
                int x = sum % 10 + flag;


                currentNode.next  = new ListNode(sum % 10 + flag); ;
               
                if (sum >= 10)
                    flag = 1;
                else
                    flag = 0;
                l1 = l1.next;
                l2 = l2.next;
                currentNode = currentNode.next;
            }

            while (l1.next != null)
            {
                currentNode = new ListNode(l1.val + flag);
                flag = 0;
                currentNode = currentNode.next;
                l1 = l1.next;
            }
            while (l2.next != null)
            {
                currentNode = new ListNode(l2.val + flag);
                flag = 0;
                currentNode = currentNode.next;
                l2 = l2.next;
            }
            return head.next;
        }
    }
}
