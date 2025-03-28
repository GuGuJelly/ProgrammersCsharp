using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace Problem035
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();


            Console.WriteLine(string.Join(", ", solution.solution(3, [4, 5, 6, 7, 8, 9, 10, 11, 12])));
        }
    }

    class Solution
    {
        public int[] solution(int n, int[] numlist)
        {
            int[] answer = new int[] { };
            List<int> list = new List<int>();
            for (int i = 0; i < numlist.Length; i++)
            {
                if (numlist[i] % n == 0)
                {
                    list.Add(numlist[i]);
                }
            }

            answer = list.ToArray();

            return answer;
        }
    }
}

