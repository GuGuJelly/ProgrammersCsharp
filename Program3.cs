namespace Probliem003
{
    internal class Program
    {
        /// <summary>
        /// 프로그래머스
        /// 2024년 8월 11일
        /// 숫자 비교하기
        /// </summary>
        /// <param name="args"></param>ㅍ
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution(3, 100));
        }
    }

    public class Solution
    {
        public int solution(int num1, int num2)
        {
            int answer = 0;
            if (num1 == num2)
            {
                answer = 1;
            }
            else if (num1 != num2)
            {
                answer = -1;
            }
            else if ((num1 < 0 || num1 > 10000) || (num2 < 0 || num2 > 10000))
            {
                Console.WriteLine("범위에 맞는 숫자를 입력해주세요");
                answer = 0;
            }
            return answer;
        }
    }
}
