using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class CoffeeMachine
    {
        int water;
        int coffee;
        int milk;
        int chocolate;

        public CoffeeMachine(int water, int coffee, int milk, int chocolate)
        {
            this.water = water;
            this.coffee = coffee;
            this.milk = milk;
            this.chocolate = chocolate;
        }

        // ===== เมนูเครื่องดื่ม =====
        public void MakeBlackCoffee()
        {
            if (CheckIngredient(300, 20, 0, 0))
            {
                UseIngredient(300, 20, 0, 0);
                Console.WriteLine(" กำลังชงกาแฟดำ...");
            }
        }

        public void MakeMocha()
        {
            if (CheckIngredient(300, 20, 0, 10))
            {
                UseIngredient(300, 20, 0, 10);
                Console.WriteLine(" กำลังชงมอคค่า...");
            }
        }

        public void MakeLatte()
        {
            if (CheckIngredient(300, 20, 10, 0))
            {
                UseIngredient(300, 20, 10, 0);
                Console.WriteLine(" กำลังชงลาเต้...");
            }
        }

        public void MakeChocolate()
        {
            if (CheckIngredient(300, 0, 0, 20))
            {
                UseIngredient(300, 0, 0, 20);
                Console.WriteLine(" กำลังชงช็อคโกแลต...");
            }
        }

        // ===== ตรวจสอบวัตถุดิบ =====
        private bool CheckIngredient(int w, int c, int m, int ch)
        {
            if (water < w || coffee < c || milk < m || chocolate < ch)
            {
                Console.WriteLine(" วัตถุดิบไม่เพียงพอ");
                ShowStock();
                return false;
            }
            return true;
        }

        // ===== ใช้วัตถุดิบ =====
        private void UseIngredient(int w, int c, int m, int ch)
        {
            water -= w;
            coffee -= c;
            milk -= m;
            chocolate -= ch;
        }

        // ===== แสดงสต็อก =====
        public void ShowStock()
        {
            Console.WriteLine("\nวัตถุดิบคงเหลือ");
            Console.WriteLine($"น้ำ: {water} g");
            Console.WriteLine($"กาแฟ: {coffee} g");
            Console.WriteLine($"นม: {milk} g");
            Console.WriteLine($"ช็อคโกแลต: {chocolate} g");
        }

        // ===== เติมวัตถุดิบ =====
        public void Refill()
        {
            Console.Write("เติมน้ำ(g): ");
            water += int.Parse(Console.ReadLine());

            Console.Write("เติมกาแฟ(g): ");
            coffee += int.Parse(Console.ReadLine());

            Console.Write("เติมนม(g): ");
            milk += int.Parse(Console.ReadLine());

            Console.Write("เติมช็อคโกแลต(g): ");
            chocolate += int.Parse(Console.ReadLine());

            Console.WriteLine(" เติมวัตถุดิบเรียบร้อย");
            ShowStock();
        }
    }
}