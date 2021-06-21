using System;

namespace Example_02
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
            byte averageScore1 = (byte)((russianScore1 + historyScore1 + mathScore1) / 3);

            Console.WriteLine("Средний балл по 3-м предметам " + count + "-го сотрудника: " + averageScore1);

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
            byte averageScore2 = (byte)((russianScore2 + historyScore2 + mathScore2) / 3);

            string pattern = "Средний балл по 3-м предметам {0}-го сотрудника: {1}";
            Console.WriteLine(pattern, count, averageScore2);
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
            byte averageScore3 = (byte)((russianScore3 + historyScore3 + mathScore3) / 3);

            Console.WriteLine($"Средний балл по 3-м предметам {count}-го сотрудника: {averageScore3}");
            Console.WriteLine();
        }
    }
}
