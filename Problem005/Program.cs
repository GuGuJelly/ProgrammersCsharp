namespace Problem005
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /// <summary>
            /// 프로그래머스
            /// 2024년 8월 11일
            /// 몫 구하기
            /// </summary>
            /// <param name="args"></param>
            Solution s = new Solution();
            Console.WriteLine(s.solution(10,3));
        }
    }

    public class Solution
    {
        public int solution(int num1, int num2)
        {
            int answer = 0;
            answer = num1 / num2;

            return answer;
        }
    }
}
