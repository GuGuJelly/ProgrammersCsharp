namespace Problem033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Solution
    {
        public int solution(int[] sides)
        {
            int answer = 0;

            Array.Sort(sides);
            if (sides[2] < sides[0] + sides[1])
            {
                answer = 1;
            }else
                answer = 2;

                return answer;
        }
    }
}
