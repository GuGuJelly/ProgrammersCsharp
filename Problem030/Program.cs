namespace Problem030
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(4,12));
        }
    }

    class Solution
    {
        public int solution(int slice, int n)
        {
            int answer = 0;
            
            if (n % slice == 0)
            {
                answer = n / slice;
            } 
            else 
                answer = n / slice + 1;
            

            return answer;
        }
    }
}
