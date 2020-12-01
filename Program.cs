using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNovember
{
    internal class Program
    {
        // Code Explanation: For best practice I created a seperate method tool in order to lower case
        // the string and and use ling method orderby to arrange the string , then call the method in the
        // IsAnagram
        //

        // public static bool IsAnagram(string test, string original)
        // {
        //     return SortLower(test) == SortLower(original);
        // }
        //
        // public static string SortLower(string str)
        // {
        //     return String.Concat(str.ToLower().OrderBy(c => c));
        // }
        //

        //In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
        //
        //Example:
        //
        //Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
        //Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
        //Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"

        // Code Explanation: First thing i want to to do is split the string into a number arrray using linq.
        // then use the built in max and min methods to grab both values

        // public static string HighAndLow(string numbers)
        // {
        //     int[] numArray = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        //     int max = numArray.Max();
        //     int min = numArray.Min();
        //     string maxMinString = max + " " + min;
        //     return maxMinString;
        //
        //    // codewars solution
        //     //   var parsed = numbers.Split().Select(int.Parse);
        //     //return parsed.Max() + " " + parsed.Min();
        //
        // }

        // Data Reverse

        // A stream of data is received and needs to be reversed.
        // 
        // Each segment is 8 bits long, meaning the order of these segments needs to be reversed, for example:
        // 
        // 11111111  00000000  00001111  10101010
        //  (byte1)   (byte2)   (byte3)   (byte4)
        // should become:
        // 
        // 10101010  00001111  00000000  11111111
        //  (byte4)   (byte3)   (byte2)   (byte1)
        // The total number of bits will always be a multiple of 8.
        // 
        // The data is given in an array as such:
        // 
        // [1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,1,0,1,0,1,0]

        //public static int[] DataReverse(int[] data)
        //{
        //    int[] bits = data;
        //
        //    for (int i = 0; i < data.Length; i += 8)
        //    {
        //        Array.Reverse(bits, i, 8);
        //    }
        //
        //    Array.Reverse(bits);
        //
        //    return bits;
        //}

        // Sorted? yes? no? how?

        // Complete the method which accepts an array of integers, and returns one of the following:
        // 
        // "yes, ascending" - if the numbers in the array are sorted in an ascending order
        // "yes, descending" - if the numbers in the array are sorted in a descending order
        // "no" - otherwise
        // You can assume the array will always be valid, and there will always be one correct answer.

        // code exp : Set the return conditions as vars and using linq to get the list in asc and 
        // dsc order, if the sequence matches return the correct string
        //public static string IsSortedAndHow(int[] array)
        //{
        //    string yesAsc = "yes, ascending";
        //    string yesDsc = "yes, descending";
        //    string otherwise = "no";
        //
        //    var orderByAsc = array.OrderBy(a => a);
        //    var orderByDsc = array.OrderByDescending(a => a);
        //
        //    if (array.SequenceEqual(orderByAsc))
        //    {
        //        return yesAsc;
        //    }
        //    else if (array.SequenceEqual(orderByDsc))
        //    {
        //        return yesDsc;
        //    }
        //    else
        //    {
        //        return otherwise;
        //    }
        //    // shorter way to write it
        // if (array.OrderBy(a => a).SequenceEqual(array)) return "yes, ascending";
        // if (array.OrderByDescending(a => a).SequenceEqual(array)) return "yes, descending";
        // return "no";

        //}
        //Array.diff

        //your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

        //It should remove all values from list a, which are present in list b.
        //
        //Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
        //If a value is present in b, all of its occurrences must be removed from the other:
        //
        //Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }

        private static void Main(string[] args)
        {
             //IsSortedAndHow(new[] { 1, 2 }); // asc 
             //IsSortedAndHow(new[] { 15, 7, 3, -8 }); dsc
             //IsSortedAndHow(new[] { 4, 2, 20}); //otherwise
        }
    }
}