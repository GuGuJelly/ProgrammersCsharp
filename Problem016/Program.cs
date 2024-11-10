using System;
using System.Runtime.CompilerServices;

namespace Problem016
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine($"Jona의 문자열을 뒤집어서 {solution.solution("Jona")}로 만들었습니다");
        }
    }

    public class Solution
    {
        public string solution(string my_string)
        {
            string answer = "";
            string reverseStr = "";

            for (int i = my_string.Length - 1; i >= 0; i--)
            {
                reverseStr += my_string[i];
            }

            answer = reverseStr;
            return answer;
        }
    }
}
