namespace Problem017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            
            Console.WriteLine(sol.solution(10,3));
        }
    }

    public class Solution
    {
        int j = 0;
        public int solution(int n, int k)
        {
            int answer = 0;
            int ggoChi = 12000;
            int drink = 2000;

            answer = ggoChi * n + drink * k;
            if (n >= 10)
            {
                for (int i = 10; i <= n; i+=10)
                {
                    j++;
                }
                answer -= drink * j;
            }
            return answer;
        }
    }
}
