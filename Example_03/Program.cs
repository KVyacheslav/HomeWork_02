using System;

namespace Example_03
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

            Console.WriteLine("Имя первого сотрудника: " + name1);
            Console.WriteLine("Возраст первого сотрудника: " + age1);
            Console.WriteLine("Рост первого сотрудника: " + height1);
            Console.WriteLine("Балл по русскому языку: " + russianScore1);
            Console.WriteLine("Балл по истории: " + historyScore1);
            Console.WriteLine("Балл по математике: " + mathScore1);
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

            string pattern = "Имя первого сотрудника: {0}\n" +
                             "Возраст первого сотрудника: {1}\n" +
                             "Рост первого сотрудника: {2}\n" +
                             "Балл по русскому языку: {3}\n" +
                             "Балл по истории: {4}\n" +
                             "Балл по математике: {5}\n" +
                             "Средний балл по 3-м предметам {6}-го сотрудника: {7}";
            Console.WriteLine(pattern, name2, age2, height2,
                              russianScore2, historyScore2, mathScore2, count, averageScore2);
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

            Console.WriteLine($"Имя первого сотрудника: {name3}\n");
            Console.WriteLine($"Возраст первого сотрудника: {age3}\n");
            Console.WriteLine($"Рост первого сотрудника: {height3}\n");
            Console.WriteLine($"Балл по русскому языку: {russianScore3}\n");
            Console.WriteLine($"Балл по истории: {historyScore3}\n");
            Console.WriteLine($"Балл по математике: {mathScore3}\n");
            Console.WriteLine($"Средний балл по 3-м предметам {count}-го сотрудника: {averageScore3}");
            Console.WriteLine();
        }
    }
}
