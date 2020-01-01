using System;

namespace BaseBallGameFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] defenderNumber = new int[3];
            int defenderNumberIndex = 0;

            while (defenderNumberIndex < 3)
            {
                defenderNumber[defenderNumberIndex] = random.Next(0, 10);
                bool hasDuplicate = false;

                for (int i= 0; i < defenderNumberIndex; i++)
                {
                    if (defenderNumber[i] == defenderNumber[defenderNumberIndex])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }
                if (!hasDuplicate)
                {
                    defenderNumberIndex++;
                }
            }
            int strikeCount = 0;
            int ballCount = 0;
            while (strikeCount<3)
            {  
                Console.WriteLine("---------------BaseBall Game--------------");
                Console.WriteLine(">Defender selected number");
            
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(defenderNumber[j]);
                }
                Console.WriteLine(" ");

                int[] striker = new int[3];

                for (int k = 0; k < 3; k++)
                {
                    Console.Write(k + 1);
                    Console.WriteLine("번째 숫자를 입력하세요.");
                    striker[k] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine(">Striker selected number");
                for (int l = 0; l < 3; l++)
                {
                    Console.WriteLine(striker[l]);
                }

                Console.WriteLine(" ");

                for (int numberindex = 0; numberindex < 3; numberindex++)
                {  
                    if (defenderNumber[numberindex] == striker[numberindex])
                    {
                    strikeCount = strikeCount + 1;
                    }
                }
                if (defenderNumber[0] == striker[1] || defenderNumber[0] == striker[2])
                {
                ballCount = ballCount + 1;
                }
                if (defenderNumber[1] == striker[0] || defenderNumber[1] == striker[2])
                {
                ballCount = ballCount + 1;
                }
                if (defenderNumber[2] == striker[1] || defenderNumber[2] == striker[0])
                {
                ballCount = ballCount + 1;
                }
                   
                Console.WriteLine("Strike : ");
                Console.WriteLine(strikeCount);
                Console.WriteLine("Ball : ");
                Console.WriteLine(ballCount);
                Console.WriteLine("Out : ");
                Console.WriteLine(3 - strikeCount - ballCount);
            }
            
            Console.WriteLine("맞았습니다!");
         
        }
    }
}
