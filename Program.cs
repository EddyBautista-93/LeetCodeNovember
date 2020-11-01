namespace LeetCodeNovember
{
    internal class Program
    {
        // November 1st - Convert Binary Number in a Linked List to IntegerConvert Binary Number in a Linked List to Integer

        //Given head which is a reference node to a singly-linked list. The value of each node in the linked list is either 0 or 1.
        //The linked list holds the binary representation of a number.

        //Return the decimal value of the number in the linked list.

        //Constraints:

        // -The Linked List is not empty.
        // -Number of nodes will not exceed 30.
        // -Each node's value is either 0 or 1.

        //todo
        //--Traverse the linked list and store all values in a string or array. convert the values obtained to decimal value.
        //--You can solve the problem in O(1) memory using bits operation.use shift left operation( << ) and or operation( | ) to get the decimal value in one operation.
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

       

        private static void Main(string[] args)
        {
            var curr = head;
            int length = 0;
            while (curr != null)
            {
                length++;
                curr = curr.next;
            }

            int res = 0;
            int i = 1;
            curr = head;
            while (curr != null)
            {
                res |= (curr.val << (length - i++));
                curr = curr.next;
            }

            return res;
        }
    }
}