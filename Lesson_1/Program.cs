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
        //static void Main(string[] args)
        //{
        //    int nextString = 0;
        //    int[,] array = new int[5, 5];
        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {
        //            array[i, j] = nextString + 1;
        //            Console.WriteLine($"{new string(' ', nextString)}{array[i, j]}");
        //            nextString++;
        //        }
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    var phoneBook = new string[,]
        //    {
        //    {"Иванов А.П.", "89475688156"},
        //    {"Сидоров П.К.", "89487264871"},
        //    {"Петров М.У.", "89743542194"},
        //    {"Конев М.Н.", "87358941573"},
        //    {"Анисова Д.С.", "89753495815"},
        //    };
        //    for (var i = 0; i < phoneBook.GetLength(0); i++)
        //    {
        //        for (var j = 0; j < phoneBook.GetLength(1); j++)
        //            Console.Write(phoneBook[i, j] + "\t");
        //        Console.WriteLine();
        //    }
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    Console.Write("Введите строку");
        //    string str = Console.ReadLine();
        //    Console.Write("Ваша строка в обратном порядке:");
        //    string reverseStr = "";
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        reverseStr += str[i]; // переворачиваем строку
        //    }
        //    Console.WriteLine(reverseStr);
        //    Console.ReadKey();
        //}
        #endregion

        #region Lesson 4
        enum Seasons
        {
            None = 0,
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            Console.WriteLine(GetFullName("Сергей", "Гудовщиков", "Константинович"));
            Console.WriteLine(GetFullName("Максим", "Селезнёв", "Олегович"));
            Console.WriteLine(GetFullName("Константин", "Попов", "Михаилович"));
            Console.WriteLine();

            Console.WriteLine("Задание №2");
            Console.Write("Введите набор чисел, разделенных пробелом: ");
            Console.WriteLine(GetSum(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Задание №3");
            Console.Write("Введите порядковый номер месяца: ");
            int number;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 1 || number > 12)
                {
                    Console.Write("Ошибка. Введите число от 1 до 12: ");
                }
            } while (number < 1 || number > 12);
            Seasons season = GetSeason(number);
            Console.WriteLine("Время года: " + GetSeasonStr(season));
            Console.WriteLine();

            Console.WriteLine("Задание №4");
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число Фибоначчи: " + Fibonachi(n));
            Console.ReadKey();

         
        }

        static string GetFullName(string firstName, string lastName, string patronymic) // Метод задания №1
        {
            return $"{lastName} {firstName} {patronymic}";
        }


        static int GetSum(string inputLine) //Метод задания №2
        {
            int sum = 0;

            string[] numbers = inputLine.Split(' ');
            string number = " ";
            for (int i = 0; i <= inputLine.Length; i++)
            {
                if (i == inputLine.Length || inputLine[i] == ' ')
                {
                    if (number != " ")
                    {
                        sum += Convert.ToInt32(number);
                        number = " ";
                    }
                }
                else
                {
                    number += inputLine[i];
                }
            }
            return sum;
        }


        static Seasons GetSeason(int number) //Метод задания №3
        {
            Seasons season = Seasons.None;
            switch (number)
            {
                case 12:
                case 1:
                case 2:
                    season = Seasons.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    season = Seasons.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    season = Seasons.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    season = Seasons.Autumn;
                    break;
            }
            return season;
        }
        static string GetSeasonStr(Seasons season)
        {
            string seasonStr = "";
            switch (season)
            {
                case Seasons.Winter:
                    seasonStr = "Зима";
                    break;
                case Seasons.Spring:
                    seasonStr = "Весна";
                    break;
                case Seasons.Summer:
                    seasonStr = "Лето";
                    break;
                case Seasons.Autumn:
                    seasonStr = "Осень";
                    break;
            }
            return seasonStr;
        }


        static int Fibonachi(int n) //метод задания №4
        {
            return Fibonachi(n, out _);
        }
        static int Fibonachi(int n, out int f1)
        {
            f1 = 0;
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int f2; //Число Фибоначчи n - 2
                f1 = Fibonachi(n - 1, out f2); //Число Фибоначчи n - 1
                return f1 + f2;
            }
        }
        #endregion
    }
}
        












