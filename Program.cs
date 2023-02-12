// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число"); // Предложение ввести трехзначное число.

int.TryParse(Console.ReadLine(), out int number); // Считывание числа и передача его переменной number.

int[] digitArray = DigitToArray(3); // Задание метода DigitToArray : int - возвращаемый тип данных, DigitToArray - название метода, (3) - лист параметров.

int[] DigitToArray(int length) // Тело метода с листом параметра length равного 3.
{
    digitArray = new int [length]; // Создание массива digitArray длиной length элементов (length = 3, по листу параметров).

    int oldNumber = number; // Сохрание исходного числа number для дальнейшего вывода его на печать.

    int absolute = Math.Abs(number); // Берем модуль числа number для проверки его на трехнзачность.

    if (absolute <= 99 || absolute >= 1000) // Проверка чичла number на трехзначность.
    {
        System.Console.WriteLine("Вы ввели не трехзначное число");
    }    

    else // Если число трехзначное, переводим его в массив.
    {
        System.Console.WriteLine("Вы ввели трехзначное число");

        for (int i = length - 1; i >= 0; i--) // Перевод числа number в массив digitArray.
        {
            digitArray[i] = number % 10;

            number = (number - digitArray[i]) / 10;
        } 

        System.Console.WriteLine($"Вторая цифра числа {oldNumber} это {digitArray[1]}"); // Вывод результата на печать.
    }

    return digitArray;
}


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число"); 

int.TryParse(Console.ReadLine(), out int number);

TherdDigit(number);

void TherdDigit(int number)
{
    int absolute = Math.Abs(number);

    int oldNumber = number;

    int count = 0;

    if (absolute >= -99 && absolute <= 99)
    {
        Console.WriteLine($"В числе {number} третья цифра отсутствует");
    }

    else
    {
        while (absolute > 0)
        {
            absolute = absolute / 10;
            count++;
        }

        int[] digitArray = new int[count];

        for (int i = count - 1; i >= 0; i--)
        {
            digitArray[i] = number % 10;
            number = (number - digitArray[i]) / 10;
        }

        Console.WriteLine($"Третья цифра числа {oldNumber} равна " + digitArray[2]);
    }
}

// ///////////////////////////////////////////////////////////////////////////

// // Задача 15: Напишите программу, которая принимает на вход цифру, 
// // обозначающую день недели, и проверяет, является ли этот день выходным.

// // 6 -> да
// // 7 -> да
// // 1 -> нет

Console.WriteLine("Введите цифру обозначающую день недели"); 

int.TryParse(Console.ReadLine(), out int number);

DayOfWeek();

void DayOfWeek()
{
    switch (number)
    {
        case 1:
        {
            Console.WriteLine("Понедельник - будний день");
            break;
        }
        
        case 2:
        {
            Console.WriteLine("Вторник - будний день");
            break;
        }

        case 3:
        {
            Console.WriteLine("Среда - будний день");
            break;
        }

        case 4:
        {
            Console.WriteLine("Четверг - будний день");
            break;
        }

        case 5:
        {
            Console.WriteLine("Пятница - будний день");
            break;
        }

        case 6:
        {
            Console.WriteLine("Суббота - выходной день");
            break;
        }

        case 7:
        {
            Console.WriteLine("Воскресенье - выходной день");
            break;
        }

        default:
            Console.WriteLine("Нет такого дня недели");
            break;
    }
}
  
