namespace Problem025
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] numbers = { 1,2,3,4,5 };
            foreach (int number in sol.solution(numbers)) 
            {
                Console.Write($"{number} ");
            }
        }
    }
    public class Solution
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                answer[i] = numbers[i]*2;
            }

            return answer;
        }
    }

}

