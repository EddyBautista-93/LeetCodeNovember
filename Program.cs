using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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
    //    public class ListNode
    //    {
    //        public int val;
    //        public ListNode next;
    //
    //        public ListNode(int val = 0, ListNode next = null)
    //        {
    //            this.val = val;
    //            this.next = next;
    //        }
    //    }

        //  private var curr = head;
        //  private int length = 0;
        //   while (curr != null)
        //   {
        //       length++;
        //       curr = curr.next;
        //   }
        //
        //   int res = 0;
        //   int i = 1;
        //   curr = head;
        //           while (curr != null)
        //           {
        //               res |= (curr.val << (length - i++));
        //               curr = curr.next;
        //           }
        //   
        //   return res;


        //  November 2nd
        //Algorithm of Insertion Sort: Array
        // return the sorted array
        //static int[] InsertionSort(int[] inputArray)
        //{
        //    for(int i = 0; i < inputArray.Length - 1; i++)
        //    {
        //        for(int j = i + 1; j > 0; j--)
        //        {
        //            if(inputArray[j - 1] > inputArray[j])
        //            {
        //                int temp = inputArray[j - 1];
        //                inputArray[j - 1] = inputArray[j];
        //                inputArray[j] = temp;
        //            }
        //        }
        //    }
        //    return inputArray;
        //}
        //public static void PrintIntegerArray(int[] array)
        //{
        //    foreach (int i in array)
        //    {
        //        Console.Write(i.ToString() + "  ");
        //    }
        //}
        //public static int[] FoldArray(int[] array, int runs)
        //{
        //    int length = array.Length / 2;

        //    // take array method = he Take() method extracts the first n elements (where n is a parameter to the method) from the beginning of the target sequence and returns a new sequence containing only the elements taken.

        //    var folded =  array.Take(length).Zip(array.Reverse().Take(length), (a, b) => a + b);

        //    if (array.Length % 2 == 1)
        //    {
        //        folded = folded.Concat(new int[] { array[length] });
        //    }

        //    runs--;

        //    return runs == 0 ? folded.ToArray() : FoldArray(folded.ToArray(), runs);

        //}
        // using generic type 
        // Quick Fibanaci sequence - iterative approach
        // public static void fibinacciIterative(int length)
        // {
        //     int a = 0, b = 1, c = 0;
        //     Console.WriteLine("{0} {1}", a, b);
        //     for(int i = 2; i < length; i++)
        //     {
        //         c = a + b;
        //         Console.Write(" {0}", c);
        //         a = b;
        //         b = c;
        //     }
        // }
        //   public static string RemoveUrlAnchor(string url)
        //   {
        //       string removedAnchor = url.Substring(0, url.LastIndexOf('#'));
        //       Console.WriteLine(removedAnchor);
        //       return removedAnchor;
        //   }

        public static string BreakCamelCase(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            StringBuilder sb = new StringBuilder();
            foreach(var c in str)
            {
                if (char.IsUpper(c))
                    sb.Append(' ');

                sb.Append(c);
            }
            return sb.ToString();
        }

        public static int RoundToNext5(int n)
        {
            while (n % 5 != 0) n++;
            Console.WriteLine(n);
            return n;
        }
    

            private static void Main(string[] args)
            {
            RoundToNext5(6);
            RoundToNext5(2);



        }
    }
}