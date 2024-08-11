namespace Problem007
{
    internal class Program
    {
        /// <summary>
        /// 프로그래머스
        /// 2024년 8월 11일
        /// 두 수의 나눗셈
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution(10,3));
        }
    }

    public class Solution
    {
        public int solution(int num1, int num2)
        {
            return (int)((num1 / (double)num2) * 1000);
        }
    }
}
