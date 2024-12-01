namespace Problem027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();

            foreach (int element in sol.solution(15))
            {
                Console.WriteLine(element);
            }
        }
    }
    public class Solution
    {
        public int[] solution(int n)
        {
            int size = (n + 1) / 2;
            int[] answer = new int[size];

            for (int i = 0; i < size; i++ )
            {
                answer[i] = 2*i + 1;
            }

            return answer;
        }
    }

}
