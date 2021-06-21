using System;

namespace Example_04
{
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Параметры запуска.</param>
        static void Main(string[] args)
        {
            // Количество сотрудников изначально
            int count = 0;

            /*
             * Ввод данных:
             * имя,
             * возраст,
             * рост,
             * баллы по русскому языку,
             * баллы по истории,
             * баллы по математике.
             */

            // Данные для первого сотрудника
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

            // Расчет среднего арифметического бала для 1-го сотрудника
            byte averageScore1 = (byte)((russianScore1 + historyScore1 + mathScore1) / 3);

            Console.WriteLine();

            // Данные для второго сотрудника
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

            // Расчет среднего арифметического бала для 2-го сотрудника
            byte averageScore2 = (byte)((russianScore2 + historyScore2 + mathScore2) / 3);

            // Создание паттерна для вывода информации 2-го сотрудника
            string pattern = "Информация о 2-м сотруднике\n" +
                             "Имя сотрудника:         {0}\n" +
                             "Возраст сотрудника:     {1}\n" +
                             "Рост сотрудника:        {2}\n" +
                             "Балл по русскому языку: {3}\n" +
                             "Балл по истории:        {4}\n" +
                             "Балл по математике:     {5}\n" +
                             "Средний балл:           {6}\n";

            Console.WriteLine();

            // Данные для третьего сотрудника
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

            // Расчет среднего арифметического бала для 3-го сотрудника
            byte averageScore3 = (byte)((russianScore3 + historyScore3 + mathScore3) / 3);

            Console.WriteLine();

            /*
             * Вывод информации на экран:
             * номер сотрудника
             * имя,
             * возраст,
             * рост,
             * баллы по русскому языку,
             * баллы по истории,
             * баллы по математике,
             * средний аремфетический балл
             */

            // Вывод информации 1-го сотрудника на экран, используя обычный вывод на консоль
            Console.WriteLine("Информация о 1-м сотруднике");
            Console.WriteLine("Имя сотрудника:         " + name1);
            Console.WriteLine("Возраст сотрудника:     " + age1);
            Console.WriteLine("Рост сотрудника:        " + height1);
            Console.WriteLine("Балл по русскому языку: " + russianScore1);
            Console.WriteLine("Балл по истории:        " + historyScore1);
            Console.WriteLine("Балл по математике:     " + mathScore1);
            Console.WriteLine("Средний балл:           " + averageScore1 + '\n');


            // Вывод информации 2-го сотрудника, используя обычное форматирование
            Console.WriteLine(pattern, name2, age2, height2, russianScore2,
                    historyScore2, mathScore2, averageScore2);

            // Вывод информации 3-го сотрудника, используя интерполяцию
            Console.WriteLine($"Информация о 3-м сотруднике");
            Console.WriteLine($"Имя сотрудника:         {name3}");
            Console.WriteLine($"Возраст сотрудника:     {age3}");
            Console.WriteLine($"Рост сотрудника:        {height3}");
            Console.WriteLine($"Балл по русскому языку: {russianScore3}");
            Console.WriteLine($"Балл по истории:        {historyScore3}");
            Console.WriteLine($"Балл по математике:     {mathScore3}");
            Console.WriteLine($"Средний балл:           {averageScore3}\n");
        }
    }
}
