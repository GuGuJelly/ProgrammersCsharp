namespace Problem018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.solution(7,15));
        }
    }

    public class Solution
    {
        public int solution(int n, int t)
        {
            int answer = 0;
            if (t >=1 || t <= 15)
            {
                for (int i = 1; i <= t; i++)
                {
                    n = 2 * n;
                    answer = n;
                }
            }else 
                return answer;

            return answer;
        }
    }
}
