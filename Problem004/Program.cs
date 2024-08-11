namespace Problem004
{
    internal class Program
    {
        /// <summary>
        /// 프로그래머스
        /// 2024년 8월 11일
        /// 나이 출력
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution(20));
        }
    }

    public class Solution
    {
        public int solution(int age)
        {
            int answer = 0;
            for (int i = 0; i < age; i++)
            {
                answer = 2022 - i;
            }
            return answer;
        }
    }
}
