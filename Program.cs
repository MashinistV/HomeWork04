// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
// int numberA;
// int numberB;
// Console.Write("Введите первое число: ");

// while (!int.TryParse(Console.ReadLine(), out numberA))
// {
//     Console.WriteLine("Вы ввели не число");
//     Console.Write("Введите число: ");
// }

// Console.Write("Введите второе число: ");

// while (!int.TryParse(Console.ReadLine(), out numberB))
// {
//     Console.WriteLine("Вы ввели не число");
//     Console.Write("Введите число: ");
// }

// int Method(int NumberA, int NumberB)
// {
//     int result = NumberA;
    
//     for (int i = 1; i < NumberB; i++)
//     {
//         result = result * NumberA;
//     }
//     Console.WriteLine($"Число {NumberA} в степени {NumberB} равно {result}");
//     return result;
// }

// Method(numberA, numberB);

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// int number = ReadInt();
// Console.WriteLine($"Сумма цифер в числе {number} рано: {Sum(number)}");

// int ReadInt()
// {
//     Console.Write("Введите число: ");
//     int number;

//     while (!int.TryParse(Console.ReadLine(), out number))
//     {
//         Console.WriteLine("Вы ввели не число");
//         Console.Write("Введите число: ");
//     }

//     return number;
// }

// int Sum (int number)
// {
//     int sum = number % 10;
    
//     while (number > 0)
//     {
//         number = number / 10;
//         sum = sum + number % 10;
//     }

//     return sum;
// }

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Method();

int[] Method()
{
    Random random = new Random();
    int index = 0;
    int[] array = new int[8];

    for (index = 0; index < 8; index++)
    {
        array[index] = random.Next(0, 9);
        Console.Write($"{array[index]} ");
    }
    
    return array;
}