namespace Problem022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,1,3,3,5,6 };
            Solution sol = new Solution();
            
            Console.WriteLine(sol.solution(array,3));
        }
    }

    public class Solution
    {
        public int solution(int[] array, int n)
        {
            int answer = 0;

            foreach (int a in array) 
            {
                if (a-n==0)
                {
                    answer += 1;
                }
            }

            return answer;
        }
    }


}
