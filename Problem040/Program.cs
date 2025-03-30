namespace Problem040
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(150000));
        }
    }

    /// <summary>
    /// 버전 문제로 when절이 안먹히는 풀이
    /// </summary>
    class Solution
    {
        public float solution(float price)
        {
            float answer = 0;
            switch (price)
            {
                case float n when n >= 100000 && n < 300000:
                    answer = price - price * 0.05f;
                    break;

                case float n when n >= 300000 && n < 500000:
                    answer = price - price * 0.1f;
                    break;

                case float n when n >= 500000:
                    answer = price - price * 0.2f;
                    break;
                    
                default:
                    answer = price;
                    break;
            }

            return answer;
        }
    }
}
