namespace Problem014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string str1 = "ppprrrogrammers";
            string str2 = "pppp";
            Console.WriteLine($"{s.solution(str1, str2)}");
        }
    }

    public class Solution
    {
        public int solution(string str1, string str2)
        {
            int answer = 0;
            //str1 = "";
            //str2 = "";
            switch (str1.Contains(str2))
            {
                case true:
                    answer = 1;
                    break;
                case false:
                    answer = 2;
                    break;
            }

            //str1.Contains(str2);
            return answer;
        }
    }
}
