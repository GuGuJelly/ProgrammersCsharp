namespace Problem026
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics.Tracing;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.solution("Nice to meet you"));
        }
    }

    public class Solution
    {
        public string solution(string my_string)
        {
            string answer = "";
            string[] arr = my_string.Split('a', 'e', 'i', 'u', 'o');

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].TrimEnd();
            }

            answer = string.Join("",arr);


            return answer;
        }
    }
}

