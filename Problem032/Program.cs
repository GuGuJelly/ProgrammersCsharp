namespace Problem032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution([1,2,3,4,5]));
        }
    }

    class Solution
    {
        public int solution(int[] numbers)
        {
            int answer = 0;
           
            Array.Sort(numbers);
            answer = numbers[numbers.Length - 1] * numbers[numbers.Length - 2];

            return answer;
        }
    }
}
