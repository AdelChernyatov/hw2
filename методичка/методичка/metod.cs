using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace методичка
{


    //Упражнение 3.1 тип данных(перечисление)
    enum bank_account
    {
        Saving, Current,
        Anothercard = 1
    }
    //Упражнение 3.2 структура данных
    struct credit //конструктор
    {
        public string number;
        public string type;
        public string balance;
        public void DisplayInfo()
        {
            Console.WriteLine($"Number:{number}, Type: {type}, Balance {balance}");
        }
    }
    //Упражнение 3.3 структура данных + тип данных(перечисление)
    enum university
    {
        КГУ, КХТИ, КАИ
    }
    struct work
    {
        public string name;
        public string university;
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, University: {university}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 3.1");
            bank_account num;
            num = bank_account.Anothercard;
            Console.WriteLine((int)num);
            Console.WriteLine(" 3.2");
            credit card;
            card.number = "425453434";
            card.type = "credit";
            card.balance = "50000";
            card.DisplayInfo();
            Console.WriteLine(" 3.3");
            work worker;
            worker.name = "Dima"; ;
            worker.university = Convert.ToString(university.КХТИ);
            worker.DisplayInfo();
            work worker_2;
            worker_2.name = "Генадий";
            worker_2.university = Convert.ToString(university.КГУ);
            worker_2.DisplayInfo();
            work worker_3;
            worker_3.name = "Марина";
            worker_3.university = Convert.ToString(university.КАИ);
            worker_3.DisplayInfo();

        }
    }







}
