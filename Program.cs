using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine machine = new CoffeeMachine (2000, 200, 100, 100);

            while (true)
            {
                Console.WriteLine("\n==============================");
                Console.WriteLine(" Welcome to Coffee Machine ");
                Console.WriteLine("==============================");
                Console.WriteLine("1. กาแฟดำ");
                Console.WriteLine("2. มอคค่า");
                Console.WriteLine("3. ลาเต้");
                Console.WriteLine("4. ช็อคโกแลต");
                Console.WriteLine("5. แสดงวัตถุดิบ");
                Console.WriteLine("6. เติมวัตถุดิบ");
                Console.WriteLine("0. ออกจากโปรแกรม");
                Console.Write("เลือกเมนู: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        machine.MakeBlackCoffee();
                        break;
                    case "2":
                        machine.MakeMocha();
                        break;
                    case "3":
                        machine.MakeLatte();
                        break;
                    case "4":
                        machine.MakeChocolate();
                        break;
                    case "5":
                        machine.ShowStock();
                        break;
                    case "6":
                        machine.Refill();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("เลือกเมนูไม่ถูกต้อง");
                        break;
                }
            }
        }
    }
}