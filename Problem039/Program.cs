namespace Problem039
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(300));
        }
    }

    class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            int number = 0;

            for (int i = 1;i<=n;i++)
            {
                if (i*i==n)
                {
                    answer = 1;
                    number++;
                    break;
                } else if (number <= 0)
                {
                    answer = 2;
                }
            }

            return answer;
        }
    }
}
