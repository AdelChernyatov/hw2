using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    class Program
    {
        static void Main(string[] args)
        {
            // классная работа
            Console.WriteLine("1");
            Console.WriteLine("min значение типа sbyte " + sbyte.MinValue);
            Console.WriteLine("max значение типа sbyte " + sbyte.MaxValue);
            Console.WriteLine("min значение типа byte " + byte.MinValue);
            Console.WriteLine("max значение типа byte " + byte.MaxValue);
            Console.WriteLine("max значение типа short " + short.MaxValue);
            Console.WriteLine("min значение типа short " + short.MinValue);
            Console.WriteLine("min значение типа ushort " + ushort.MinValue);
            Console.WriteLine("max значение типа ushort " + ushort.MaxValue);
            Console.WriteLine("min значение типа int " + int.MinValue);
            Console.WriteLine("max значение типа int " + int.MaxValue);
            Console.WriteLine("min значение типа uint" + uint.MinValue);
            Console.WriteLine("max значение типа uint " + uint.MaxValue);
            Console.WriteLine("min значение типа long " + long.MinValue);
            Console.WriteLine("max значение типа long " + long.MaxValue);
            Console.WriteLine("max значение типа ulong " + ulong.MaxValue);
            Console.WriteLine("min значение типа ulong " + ulong.MinValue);
            Console.WriteLine("min значение типа float " + float.MinValue);
            Console.WriteLine("max значение типа float " + float.MaxValue);
            Console.WriteLine("max значение типа double " + double.MaxValue);
            Console.WriteLine("min значение типа double " + double.MinValue);
            Console.WriteLine("max значение типа decimal " + decimal.MaxValue);
            Console.WriteLine("min значение типа decimal " + decimal.MinValue);
            // задание 2
            Console.WriteLine("2");
            string name = Console.ReadLine();
            string town = Console.ReadLine();
            string age = Console.ReadLine();
            string PIN = Console.ReadLine();
            Console.WriteLine("Имя " + name + "\n" + "Город " + town + "\n" + "Возраст " + age + "\n" + "ПИН-КОД " + PIN + "\n");
            //задание 3
            Console.WriteLine("3");
            Console.WriteLine("Введите строчные буквы");
            string letter = Console.ReadLine();
            string letterUP = letter.ToUpper();
            Console.WriteLine(letterUP);
            Console.WriteLine("Введите прописные буквы ");
            string letterlow = Console.ReadLine();
            string letterLOW = letterlow.ToLower();
            Console.WriteLine(letterLOW);
            //задание 4
            Console.WriteLine("4");
            string str = Console.ReadLine();
            string newstr = "";
            foreach (var ind in str)
            {
                if (char.IsUpper(ind))
                {
                    newstr += char.ToLower(ind);
                }
                else
                {
                    newstr += char.ToUpper(ind);
                }
            }
            Console.WriteLine(newstr + "\n");
            //задание 5
            Console.WriteLine("5");
            double speed = double.Parse(Console.ReadLine());    // км/ч
            double speed2 = Math.Floor(speed / 3.6 * 100);          // округление вних к бесконечности
            Console.WriteLine("скорость в метрах в сек " + speed2);
            //задание 6
            Console.WriteLine("6");
            Console.WriteLine("Введите возраст отца");
            int age1 = int.Parse(Console.ReadLine());    //возраст отца
            Console.WriteLine("Введите возраст сына");
            int age2 = int.Parse(Console.ReadLine());             //возраст сына
            int sum = Math.Abs(age1 - age2 * 2);
            int j = 0;
            int g = 0;
            if (age1 > age2 * 2)
            {
                for (int i = 0; age2 * 2 < age1; i++)
                {
                    age1++;
                    age2++;
                    j++;

                }
                Console.WriteLine("Отец будет старше в два раза сына через " + j);
            }
            else
            {
                for (int h = 0; age2 * 2 > age1; h++)
                {
                    age1--;
                    age2--;
                    g++;
                }
                Console.WriteLine("Отец был старше сына в два раза " + g + " лет назад");
            }
            //задание 7
            Console.WriteLine("7");
            double normPrice = int.Parse(Console.ReadLine());
            double salePrice = int.Parse(Console.ReadLine());
            double holidayPrice = int.Parse(Console.ReadLine());

            if (salePrice == 0)
            {
                Console.WriteLine("Покупка виски не покроет расходы на отпуск");
            }
            else
            {
                double sum7 = Math.Floor(holidayPrice / (normPrice * 0.01 * salePrice));
                Console.WriteLine("Придется купить " + sum7 + " бутылок");
            }

        }
    }
}
