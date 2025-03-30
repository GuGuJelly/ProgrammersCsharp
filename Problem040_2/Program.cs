namespace Problem040_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(150000));
        }
    }
 
    class Solution
    {
        public int solution(int price)
        {
            int answer = 0;

            float answerFloat = (float)answer;
            if (price >= 100000 && price < 300000)
            {
                answerFloat = price - price * (0.05f);
            }else if (price >= 300000 && price < 500000)
            {
                answerFloat = price - price * (0.1f);
            }else if (price >= 500000)
            {
                answerFloat = price - price * (0.2f);
            }else
                answerFloat = price;

            answer = (int)answerFloat;
                return answer;
        }
    }
}
