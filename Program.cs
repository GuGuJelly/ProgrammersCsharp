namespace Problem001
{
    /// <summary>
    /// 2024년 8월 5일 
    /// 사이트: 프로그래머스
    /// 문제명: 숫자 비교하기
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120807
    /// </summary>
    internal class Program
    {
        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = 0;
                if ((num1 >= 0 && num1 <= 10000) && (num2 >= 0 && num2 <= 10000) ) 
                {
                    if (num1 == num2)
                    {
                        answer = 1;
                    }
                    else if (num1 != num2) 
                    {
                        answer = -1;
                    }
                }else if ((num1 < 0 || num1 > 10000) || (num2 < 0 || num2 > 10000))
                {
                    Console.WriteLine("범위에 맞는 숫자를 입력해주세요");
                    answer = 0;
                }
                return answer;
            }
        }

        /* 프로그래머스에 입력한 코드
         * public class Solution {
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
         * 
         * */
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution(100, 100));
        }
    }
}
