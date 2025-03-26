using System.ComponentModel.DataAnnotations;

namespace Problem034
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(["a","b","c"], ["com","b","d","p","c"]));
        }
    }

    class Solution
    {
        public int solution(string[] s1, string[] s2)
        {
            int answer = 0;

            for (int i = 0; i < s1.Length ; i++)
            {
                for (int j = 0; j < s2.Length ; j++)
                {
                    if (string.Equals(s1[i], s2[j]))
                    {
                        answer++;
                    }
                }
            }

            return answer;
        }
    }
}
