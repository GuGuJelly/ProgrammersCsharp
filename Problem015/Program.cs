using System.Security.Cryptography.X509Certificates;

namespace Problem015
{
    /// <summary>
    /// 분수의 덧셈
    /// 2024년 8월 23일
    /// 프로그래머스
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.solution(999,999,999,999);
        }
    }

    public class Solution
    {
        public int[] solution(int denum1, int num1, int denum2, int num2)
        {
            int[] answer = new int[2];
            int maxNum = 0;// 기약분수로 약분할 숫자

            //분자
            answer[0] = (num1 * denum2) + (num2 * denum1);
            // 분모
            answer[1] = num1 * num2;


            // 기약분수 만들 숫자를 분자or분모 숫자에 같을 때까지
            // i=1 부터 돌려서
            // answer[0]과 answer[1]이 동시에 0이 되는 i를 찾아서
            // maxNum에 대입
            for (int i = 1; i <= answer[1]; i++)
            {
                if (answer[0] % i == 0 && answer[1] % i == 0)
                {
                    maxNum = i;
                }
            }

            // i 값을 찾았으면 바로 분모와 분자에 나눠주기
            answer[0] = answer[0] / maxNum;
            answer[1] = answer[1] / maxNum;

            foreach (int i in answer)
            {
                Console.Write($"{i}");
            }
            return answer;
        }
        
    }
}
