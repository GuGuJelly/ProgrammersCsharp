namespace Problem031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution("apple", "a"));
        }
    }

    class Solution
    {
        public string solution(string my_string, string letter)
        {
            string answer = "";
            answer = my_string.Replace(letter,"");


            return answer;
        }
    }
}
