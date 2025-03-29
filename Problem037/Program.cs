namespace Problem037
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(string.Join(", ", solution.solution(1100)));
        }
    }

    class Solution
    {
        public int[] solution(int money)
        {
            int[] answer = new int[2];

            answer[0] = money / 5500;
            answer[1] = money - (answer[0] * 5500);

            return answer;
        }
    }

}
