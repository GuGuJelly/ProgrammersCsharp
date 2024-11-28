namespace Problem023
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int element in sol.solution(numbers, 1, 3))
            {
                Console.WriteLine(element);
            }
        }
    }


    public class Solution
    {
        public int[] solution(int[] numbers, int num1, int num2)
        {
            int[] answer = new int[num2 - num1 + 1]; // 결과 배열 크기 설정

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = numbers[num1 + i]; // numbers 배열에서 num1부터 복사
            }
            return answer;
        }
    }

}
