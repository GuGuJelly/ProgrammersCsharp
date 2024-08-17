namespace Problem012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num_list = { 1, 2, 3, 4, 5 };
            Solution s = new Solution();
            foreach (int num in s.solution(num_list)) 
            { 
                Console.WriteLine(num);
            }

        }
    }

    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            int[] answer = new int[num_list.Length];
            int j = 0;
            for (int i = num_list.Length - 1; i >= 0; i--)
            {
                answer[j] = num_list[i];
                j++;
            }
            return answer;
        }
    }
}
