// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число N: "); // Вывод в консоль
int num = Convert.ToInt32(Console.ReadLine()); // Ввод числа
int num1 = 0;
if (99 < num && num < 1000 )
    {
        System.Console.WriteLine("Всё хорошо");
        num = num % 100;
        num1 = num % 10;
        num = (num-num1)/10;
        Console.WriteLine(num);
    }
else
    {
        System.Console.WriteLine("Вы ввелти не трехзначное число");
    }

