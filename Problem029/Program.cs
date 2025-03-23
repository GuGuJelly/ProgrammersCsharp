namespace Problem029
{
    using System;
    using System.Runtime.InteropServices.Marshalling;

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.Solution29(15));
        }
    }

    class Solution
    {
        public int Solution29(int n) 
        {
            int answer = 0; // 피자의 수

            if (n % 7  == 0)
            {
                answer = n / 7;
            }
            else if (n % 7 > 0)
            {
                answer = n / 7 + 1;
            }
                return answer;
        }
    }
}
