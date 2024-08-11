namespace Problem002
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 5일
        /// 사이트: 프로그래머스
        /// 문제명: 나머지 구하기
        /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120810
        /// </summary>
        public class Solution
        {
            public int Solutions(int num1, int num2)
            {
                int answer;
                answer = num1 % num2;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.Solutions(10, 3));
        }
    }
}
