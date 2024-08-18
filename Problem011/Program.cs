namespace Problem011
{
    internal class Program
    {
        /// <summary>
        /// 프로그래머스: 배열 원소의 길이
        /// 풀이날짜: 2024년 8월 18일
        /// 작성자: 황규호
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] strlist = { "We", "are", "the", "world!" };
            Solution s = new Solution();
            s.solution(strlist);
        }

        public class Solution
        {
            public int[] solution(string[] strlist)
            {
                
                int[] answer = new int[strlist.Length];
                for (int i = 0 ; i< strlist.Length ; i++) 
                {
                    answer[i]=strlist[i].Length;
                }

                foreach (int a in answer) 
                {
                    Console.Write($"{a} ");
                }

                return answer;
            }
        }
    }


}
