namespace Problem009
{
    internal class Program
    {
        /// <summary>
        /// 프로그래머스
        /// 2024년 8월 11일
        /// 각도기
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution(90));
        }
    }

    public class Solution
    {
        public int solution(int angle)
        {
            int answer = 0;
            if (angle > 0 && angle < 90)
            {
                answer = 1;
            }
            else if (angle == 90)
            {
                answer = 2;
            }
            else if (angle > 90 && angle < 180)
            {
                answer = 3;
            }
            else if (angle == 180)
            {
                answer = 4;
            }
            return answer;
        }
    }
}
