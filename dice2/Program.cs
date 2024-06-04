using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result= "";
            int count = 0;
               while(true) {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("半か丁か！");
                    Console.WriteLine("※半(奇数)なら「H」、丁(偶数)なら「T」と半角大文字入力してね");

                    string input = Console.ReadLine();

                    if(input != "H" && input != "T")
                    {
                        Console.WriteLine("【警告】入力値が正しゅうございやせん！");
                        Console.WriteLine("もう一度、正しく入力しておくんなさい");
                        continue;
                    }

                    Random rnd = new Random();
                    int d1 = rnd.Next(1, 7);
                    int d2 = rnd.Next(1, 7);

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("出目壱：" + d1);
                Console.WriteLine("出目弐：" + d2);

                if ((d1 + d2) % 2 == 0)
                {
                    Console.WriteLine("丁！！！！");
                    result = "T";
                }
                else
                {
                    Console.WriteLine("半！！！！");
                    result = "H";
                }

                if (input == result)
                {
                    Console.WriteLine("見事なお手前で");
                }
                else {
                    Console.WriteLine("お客さん有馬記念出てはったん？");
                }
                Console.WriteLine("-------------------------------------------");
                count++;
                if (count > 10)
                {
                    break;
                }
            }

            Console.WriteLine("またお越しやすm(_ _ m)");

        }
    }
}
