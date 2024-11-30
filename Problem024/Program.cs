namespace Problem024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] array = { 149, 180, 192, 170 };
            Console.WriteLine($"{sol.solution(array,170)}");
        }
    }
    public class Solution
    {
        public int solution(int[] array, int height)
        {
            int answer = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (height < array[i])
                {
                    answer++;
                }
            }

            return answer;
        }
    }

}
