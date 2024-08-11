namespace Problem008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 프로그래머스
            /// 2024년 8월 11일
            /// 배열의 평균값
            /// </summary>
            /// <param name="args"></param>
            Solution s = new Solution();
            int[] array = { 3, 5, 7, 1, 2, 5, 8, 9 };
            Console.WriteLine(s.solution(array));
        }
    }

    public class Solution
    {
        public double solution(int[] numbers)
        {
            double answer = 0;
            double[] array = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = numbers[i];
            }

            for (int j = 0; j < array.Length; j++)
            {
                answer = answer + array[j];
            }
            return answer / array.Length;
        }
    }
}
