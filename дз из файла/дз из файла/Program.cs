using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_из_файла
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.1");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n / 3600 + " полных часов прошло");
            int minut = ((n % 3600) / 60);
            Console.WriteLine(minut + " полных минут прошло");
            int second = ((n % 3600) % 60);
            Console.WriteLine(second + " полных секунд прошло");


            Console.WriteLine("1.2");
            double a12 = 534 / 130;
            Console.WriteLine(Math.Floor(a12));


            Console.WriteLine("1.3");
            int n12 = int.Parse(Console.ReadLine());
            if (n % 12 == 0)
            {
                n = 1;
            }
            else
            {
                n++;

            }
            Console.WriteLine(n12);

            Console.WriteLine("1.4");
            int num14 = int.Parse(Console.ReadLine());
            int a14 = num14 / 10;           // кол-во десятков 
            int b14 = num14 % 10;              //единицы
            Console.WriteLine("Кол-во десятков " + a14);
            Console.WriteLine("Кол-во единиц " + b14);
            Console.WriteLine("Сумма его цифр " + (a14 + b14));
            Console.WriteLine("Кол-во десятков " + (a14 * b14));



            Console.WriteLine("1.5");
            int num15 = int.Parse(Console.ReadLine());
            int a15 = num15 / 100;
            int b15 = num15 % 100 / 10;
            int c15 = num15 % 10;
            int numexit = b15 * 100 + c15 * 10 + a15;   // конечный номер
            Console.WriteLine(numexit);


            Console.WriteLine("1.6");
            
            int a = 2; // число 2 является последней цифрой
            int b = 3;
            int c = 7;
            int x = b * 100 + c * 10 + a;
           
            Console.WriteLine(x);


            Console.WriteLine("1.7");
            int a1a2 = int.Parse(Console.ReadLine());
            int b1b2 = int.Parse(Console.ReadLine());
            int a1 = a1a2 / 10;
            int a2 = a1a2 % 10;
            int b1 = b1b2 / 10;
            int b2 = b1b2 % 10;
            int suma1b1 = a1 + b1;
            int suma2b2 = a2 + b2;
            Console.WriteLine("Число десятков " + suma1b1 + ", число единиц " + suma2b2);

            Console.WriteLine("1.9");
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine(A | B);
            Console.WriteLine(A & B);
            Console.WriteLine(B | C);

            Console.WriteLine("1.10");
            bool X = bool.Parse(Console.ReadLine());
            bool Y = bool.Parse(Console.ReadLine());
            bool Z = bool.Parse(Console.ReadLine());
            Console.WriteLine("a) " + (!(X | Y) & (!X | !Z)));
            Console.WriteLine("б) " + (!(!X & Y) | (X & !Z)));
            Console.WriteLine("в " + (X | (!Y) & !(X | (!Z))));




        }
    }
}
