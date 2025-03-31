namespace Problem041
{
    class Program
    {
        /// <summary>
        /// 프로그래머스에 등록된 내 풀이
        /// </summary>
        public static void Main()
        {
            // *을 몇층까지 찍을건지 나타내는 반복문
            for (int i = 1; i <= n; i++)
            {
                // 10을 넘기면 멈춤
                if (n > 10)
                {
                    break;
                }
                // *을 가로로 몇개 찍을건지 나타내는 반복문
                // 위 반복문의 i개 만큼 찍는다는 표시
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
