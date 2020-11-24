using System;
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

        public static string HighAndLow(string numbers)
        {
            int[] numArray = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int max = numArray.Max();
            int min = numArray.Min();
            string maxMinString = max + " " + min;
            return maxMinString;

           // codewars solution
            //   var parsed = numbers.Split().Select(int.Parse);
            //return parsed.Max() + " " + parsed.Min();

        }


        private static void Main(string[] args)
        {
            // IsAnagram("Buckethead", "DeathCubeK");
            HighAndLow("1 2 3 4 5");
            HighAndLow("1 2 -3 4 5");
            HighAndLow("1 9 3 4 -5");
        }
    }
}