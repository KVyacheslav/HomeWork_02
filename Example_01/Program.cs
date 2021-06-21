using System;

namespace Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.Write($"Введите имя {++count}-го сотрудника: ");
            string name1 = Console.ReadLine();
            Console.Write($"Введите возраст {count}-го сотрудника: ");
            byte age1 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите рост {count}-го сотрудника в сантиметрах, округлив предварительно: ");
            byte height1 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите количество баллов {count}-го сотрудника по русскому языку: ");
            byte russianScore1 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите количество баллов {count}-го сотрудника по истории: ");
            byte historyScore1 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите количество баллов {count}-го сотрудника по математике: ");
            byte mathScore1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            Console.Write($"Введите имя {++count}-го сотрудника: ");
            string name2 = Console.ReadLine();
            Console.Write($"Введите возраст {count}-го сотрудника: ");
            byte age2 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите рост {count}-го сотрудника в сантиметрах, округлив предварительно: ");
            byte height2 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите количество баллов {count}-го сотрудника по русскому языку: ");
            byte russianScore2 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите количество баллов {count}-го сотрудника по истории: ");
            byte historyScore2 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите количество баллов {count}-го сотрудника по математике: ");
            byte mathScore2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();

            Console.Write($"Введите имя {++count}-го сотрудника: ");
            string name3 = Console.ReadLine();
            Console.Write($"Введите возраст {count}-го сотрудника: ");
            byte age3 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите рост {count}-го сотрудника в сантиметрах, округлив предварительно: ");
            byte height3 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите количество баллов {count}-го сотрудника по русскому языку: ");
            byte russianScore3 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите количество баллов {count}-го сотрудника по истории: ");
            byte historyScore3 = Convert.ToByte(Console.ReadLine());
            Console.Write($"Введите количество баллов {count}-го сотрудника по математике: ");
            byte mathScore3 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
        }
    }
}
