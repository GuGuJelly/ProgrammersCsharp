namespace Problem042
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(2));
        }
    }

    class Solution
    {
        public int solution(int hp)
        {
            int answer = 0;

            // 장군개미의 공격력: 5
            // 병정개미의 공격력: 3
            // 일개민의 공격력 : 1
            // 체력 23의 여치를 사냥하려고 하면, 일개미 23마리 나가는 것도 가능하지만
            // 장군개미 4마리와 병정개미 한마리를 데리고 가면 더 적은 병력으로 사냥 가능
            // 이처럼 병력 수를 최적화 시키는 프로그램을 짜라.

            int a = 0; // 몫
            int b = 0; // 나머지

            if (hp == 1)
            {
                answer = 1;
                
            }else if (hp == 2)
            {
                answer = 2;
            }
            else if (hp == 3)
            {
                answer = 1;
            }
            else if (hp == 4)
            {
                answer = 2;
            }
            else if (hp >= 5)
            {
                a = hp / 5;
                if (hp % 5 != 0)
                {
                    if (hp % 5 == 2)
                    {
                        b = 2;
                    }
                    else if (hp % 5 == 1)
                    {
                        b = 1;
                    }
                    else if (hp % 5 == 4)
                    {
                        b = 2;
                    } else if (hp % 5 == 3)
                    {
                        b = 1;
                    }
                }
                answer = a + b;
            }

                return answer;
        }
    }
}
