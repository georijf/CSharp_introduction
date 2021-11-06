using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        #region Lesson 1
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Здравствуйте, как Вас зовут?");
        //    string name = Console.ReadLine();
        //    Console.WriteLine($"Очень приятно, {name}! Кстати, сегодня {DateTime.Now}");
        //}






        //static void Main(string[] args)
        //{
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        if (i % 3 == 0 && i % 5 == 0)
        //        {
        //            Console.WriteLine("FizzBuzz");
        //        }
        //        else if (i % 3 == 0)
        //        {
        //            Console.WriteLine("Fizz");
        //        }
        //        else if (i % 5 == 0)
        //        {
        //            Console.WriteLine("Buzz");
        //        }
        //        else
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}
        #endregion

        #region Lesson 2

        //static void Main(string[] args)
        //{
        //    Console.Write("Введите минимальную температуру за сутки: ");
        //    string minTempStr = Console.ReadLine();
        //    Console.Write("Введите максимальную температуру за сутки: ");
        //    string maxTempStr = Console.ReadLine();

        //    bool isValidMinTemp = float.TryParse(minTempStr, out float minTemp);
        //    bool isValidMaxTemp = float.TryParse(maxTempStr, out float maxTemp);

        //    if (isValidMinTemp && isValidMaxTemp)
        //    {
        //        Console.WriteLine($"Среднесуточная температура равна {(minTemp + maxTemp) / 2}");
        //    }
        //    else if (!isValidMinTemp)
        //    {
        //        Console.WriteLine("Введено некорректное значение минимальной температуры. Невозможно вычислить среднесуточную температуру.");
        //    }
        //    else if (!isValidMaxTemp)
        //    {
        //        Console.WriteLine("Введено некорректное значение максимальной температуры. Невозможно вычислить среднесуточную температуру.");
        //    }
        //    Console.ReadKey();
        //}





        //static void Main(string[] args)
        //{
        //    Console.Write("Введите целое число: ");
        //    string inputValue = Console.ReadLine();
        //    bool isValid = int.TryParse(inputValue, out int number);

        //    if (!isValid)
        //    {
        //        Console.WriteLine("Введено некорректное число.");
        //        Console.ReadKey();
        //        return;
        //    }

        //    if ((number % 2) == 0)
        //    {
        //        Console.WriteLine($"{number} - чётное число.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} не является чётным числом.");
        //    }
        //    Console.ReadKey();
        //}














        //static void Main(string[] args)
        //{
        //    string storeName = "\"Мясная лавка\"";
        //    string tin = "123456789";
        //    string address = "628600, г. Нижневартовск, ул. Мира, д.17";
        //    int shift = 15;
        //    int receiptNumber = 28;
        //    DateTime date = new DateTime(2021, 10, 2, 11, 41, 0);
        //    string cashier = "Иванов Иван Иванович";

        //    (string title, double price, double quantity, double vat)[] purchases =
        //    {
        //        ("Масло оливковое, шт", 260.00, 1, 0.1),
        //        ("Молоко, шт", 58.00, 1, 0.1),
        //        ("Гель для мытья посуды, шт", 116.00, 1, 0.1),
        //        ("Яблоки, кг", 115.00, 0.736, 0.1)
        //    };

        //    Итоговая сумма
        //    double result = 0.0;

        //    Console.WriteLine($"{"",37} {storeName}");
        //    Console.WriteLine($"{"",38}ИНН {tin}");
        //    Console.WriteLine($"{"",-41}Магазин");
        //    Console.WriteLine($"{address,65}");
        //    Console.WriteLine($"{"",-35}Кассовый чек. Приход");
        //    Console.WriteLine($"Смена: {shift}");
        //    Console.WriteLine($"Чек №: {receiptNumber} {"",42} Кассир: {cashier}");
        //    Console.WriteLine($"{date}");
        //    Console.WriteLine(("").PadRight(90, '-'));

        //    Console.WriteLine($"№{"",-5}{"Наименование",-43}{"Цена за ед.",-19}{"Кол.",-17}Сумма \n");


        //    for (int i = 0; i < purchases.Length; i++)
        //    {
        //        double sum = purchases[i].quantity * purchases[i].price; //Стоимость позиции
        //        Console.WriteLine($"{i + 1}. {purchases[i].title,-43}{purchases[i].price,10:f2}{purchases[i].quantity,16:f3}{sum,18:f2}");


        //        Console.WriteLine($"{"",-5}НДС {purchases[i].vat:p0}{purchases[i].vat * sum,78:f2}");
        //        result += sum;
        //    }

        //    Console.WriteLine(("").PadRight(90, '-')); //метод заполнения строки
        //    Console.WriteLine($"Итого{result,85:f2}");
        //    Console.WriteLine(("").PadRight(90, '-'));

        //    Console.ReadKey();
        //}




        //static void Main(string[] args)
        //{
        //    Console.Write("Введите порядковый номер текущего месяца: ");
        //    string inputMonth = Console.ReadLine();
        //    Console.Write("Введите среднюю температуру: ");
        //    string inputTemp = Console.ReadLine();

        //    bool isValidMonth = int.TryParse(inputMonth, out int monthNumber);
        //    isValidMonth = isValidMonth || (monthNumber < 1 || monthNumber > 12);
        //    bool isValidTemp = float.TryParse(inputTemp, out float averageTemp);

        //    if (!isValidMonth || !isValidTemp)
        //    {
        //        Console.WriteLine("Введены некорректные данные, повторите попытку.");
        //        Console.ReadKey();
        //        return;
        //    }

        //    bool isWinterMonth = (monthNumber == 12) || (monthNumber == 1) || (monthNumber == 2);
        //    if (isWinterMonth && averageTemp > 0)
        //    {
        //        Console.WriteLine("Дождливая зима");
        //    }
        //    Console.ReadKey();
        //}
        #endregion

        #region Lesson 3
        static void Main(string[] args)
        {
            int nextString = 0;
            int[,] array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = nextString + 1;
                    Console.WriteLine($"{new string(' ', nextString)}{array[i, j]}");
                    nextString++;
                }
            }
        }

        static void Main(string[] args)
        {
            var phoneBook = new string[,]
            {
            {"Иванов А.П.", "89475688156"},
            {"Сидоров П.К.", "89487264871"},
            {"Петров М.У.", "89743542194"},
            {"Конев М.Н.", "87358941573"},
            {"Анисова Д.С.", "89753495815"},
            };
            for (var i = 0; i < phoneBook.GetLength(0); i++)
            {
                for (var j = 0; j < phoneBook.GetLength(1); j++)
                    Console.Write(phoneBook[i, j] + "\t");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.Write("Введите строку");
            string str = Console.ReadLine();
            Console.Write("Ваша строка в обратном порядке:");
            string reverseStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i]; // переворачиваем строку
            }
            Console.WriteLine(reverseStr);
            Console.ReadKey();
        }
        #endregion
    }
}












