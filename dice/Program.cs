using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
                while (true) { 
                    Console.WriteLine("賭けるソシーを設定してください(数字のみ)");  

                    //ソシーの入力
                    int input = int.Parse(Console.ReadLine());
                    int point = input;

                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("あなたが賭けたソシー：" + point);

                    //出目の決定
                    Random rnd = new Random();
                    int d1 = rnd.Next(1, 7);
                    int d2 = rnd.Next(1, 7);
                    int d3 = rnd.Next(1, 7);

                    Console.WriteLine("出目１：" +d1);
                    Console.WriteLine("出目２：" + d2);
                    Console.WriteLine("出目３：" + d3);

                    if (d1 == 1 && d2 == 1 && d3 == 1)
                    {
                        //ピンゾロ
                        point *= 5;
                        Console.WriteLine("ピンゾロ");
                    } else if (d1 == d2 && d2 == d3)
                    {
                        //ゾロ目
                        point *= 3;
                        Console.WriteLine("ゾロ目");
                    }
                    else if ((d1 == 4 && d2 == 5 && d3 == 6) || (d1 == 4 && d2 == 6 && d3 == 5) || (d1 == 5 && d2 == 4 && d3 == 6) || (d1 == 5 && d2 == 6 && d3 == 4) || (d1 == 6 && d2 == 4 && d3 == 5) || (d1 == 6 && d2 == 5 && d3 == 4))
                    {
                        //シゴロ
                        point *= 2;
                        Console.WriteLine("シゴロ");
                    }
                    else if (d1 == d2) 
                    {
                        point += d3;
                        Console.WriteLine(d3);
                    }
                    else if (d1 == d3)
                    {
                        point += d2;
                        Console.WriteLine(d2);
                    }
                    else if (d2 == d3)
                    {
                        point += d1;
                        Console.WriteLine(d1);
                    }
                    else if ((d1 == 1 && d2 == 2 && d3 == 3) || (d1 == 1 && d2 == 3 && d3 == 2) || (d1 == 2 && d2 == 1 && d3 == 3) || (d1 == 2 && d2 == 3 && d3 == 1) || (d1 == 3 && d2 == 1 && d3 == 2) || (d1 == 3 && d2 == 2 && d3 == 1))
                    {
                        //ヒフミ
                        point -= point * 3;
                        Console.WriteLine("ヒフミ");
                    }
                    else
                    {
                        point -= point * 2;
                        Console.WriteLine("役なし");
                    }

                    Console.WriteLine("-------------------------------------------");

                    Console.WriteLine("獲得ソシー：" + point);

                    if (point < -25)
                    {
                        Console.WriteLine("圧倒的敗北！　1050年地下行き！！");
                        break;
                    } else if (point > 10 && (input * 2) <= point ){
                        Console.WriteLine("祝！　圧倒的大勝利！！");
                        break;
                    }
            }
        }
    }
}
