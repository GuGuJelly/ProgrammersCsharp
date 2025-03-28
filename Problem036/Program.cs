using System.Collections.Generic;

namespace Problem036
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(12345));
        }
    }

    class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            while (n > 0) 
            {
                answer += n % 10;
                n = n / 10;
            }

            return answer;
        }
    }
}
