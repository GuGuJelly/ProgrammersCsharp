namespace Problem019
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] answer = [1, 2, 3, 4, 5];


            foreach (int result in sol.solution(answer))
            {
                Console.Write($"[{result}]");
            }
        }
    }

    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            int[] answer = new int[2];

            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i <= num_list.Length - 1; i++)
            {
                if (num_list[i] % 2 == 0)
                {
                    evenCount++;
                }
                else if (num_list[i] % 2 != 0)
                {
                    oddCount++;
                }
            }

            answer[0] = evenCount;
            answer[1] = oddCount;

            return answer;
        }
    }
}