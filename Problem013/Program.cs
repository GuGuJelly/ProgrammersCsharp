namespace Problem013
{
    internal class Program
    {
        /// <summary>
        /// 문제: 문자 반복 출력하기
        /// 사이트: 프로그래머스
        /// 날짜: 2024년 8월 18일
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string my_string = "Hello";
            Console.WriteLine(s.solution(my_string, 3));
        }
    }

    public class Solution
    {
        public string solution(string my_string, int n)
        {
            string answer = string.Empty;
            
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < n; j++) 
                {
                    answer += my_string.Substring(i, 1);
                }
            }
            return answer;
        }
    }
}
