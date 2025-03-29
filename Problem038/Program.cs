namespace Problem038
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(100));
        }
    }

    class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            int number = 1;
            while (number <= n) 
            {
                if (n % number <= 0)
                {
                    answer++;
                }
                number++;
            }
            return answer;
        }
    }
}
