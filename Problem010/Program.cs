namespace Problem010
{
    internal class Program
    {
        /// <summary>
        /// 프로그래머스
        /// 두 수의 합
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution(3,5));
        }
    }

    public class Solution
    {
        public int solution(int num1, int num2)
        {
            int answer = -1;
            answer = num1 + num2;
            return answer;
        }
    }
}
