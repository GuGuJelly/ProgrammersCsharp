namespace Problem021
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            Console.WriteLine(sol.solution("Icecream"));
        }
    }

    public class Solution
    {
        public int solution(string message)
        {
            int answer = 0;

            answer = message.Length*2;

            return answer;
        }
    }

}
