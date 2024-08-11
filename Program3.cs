namespace Problem003
{
    internal class Program
    {
        /// <summary>
        /// 2024년 8월 5일
        /// 사이트: 프로그래머스
        /// 문제명: 두수의 곱
        /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120804
        /// </summary>
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = 0;
                if ((num1 < 0 || num1 > 100) || (num2 < 0 || num2 > 100))
                {
                    Console.WriteLine("잘못된 범위의 숫자를 입력했습니다");
                    answer = 0;
                    return answer;
                }
                answer = num1 * num2;
                return answer;
            }
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution(200, 2));
        }
    }
}
