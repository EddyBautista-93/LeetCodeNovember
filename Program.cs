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

        public static bool IsAnagram(string test, string original)
        {
            return SortLower(test) == SortLower(original);
        }

        public static string SortLower(string str)
        {
            return String.Concat(str.ToLower().OrderBy(c => c));
        }

        private static void Main(string[] args)
        {
            IsAnagram("Buckethead", "DeathCubeK");
        }
    }
}