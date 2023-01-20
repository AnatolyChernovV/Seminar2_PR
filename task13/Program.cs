// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число N: "); // Вывод в консоль
int num = Convert.ToInt32(Console.ReadLine()); // Ввод числа
int num1 = 0;
if (99 < num && num < 1000)
{
    System.Console.WriteLine("Всё хорошо");
    num = num % 10;
    // num1 = num % 10;
    // num = (num-num1)/10;
    Console.WriteLine(num);
            
    
}
else
    if (1000 < num && num < 10000)
                     {
                     System.Console.WriteLine("Всё хорошо");
                     num = num % 100;
                     num1 = num % 10;
                     num = (num - num1) / 10;
                     Console.WriteLine(num);
                     }
    else
        if (10000 < num)
                     {
                     System.Console.WriteLine("Всё хорошо");
                     num = num % 1000;
                     num1 = num % 100;
                     num = (num - num1) / 100;
                     Console.WriteLine(num);
                     }
else
    {
        System.Console.WriteLine("третьей цифры нет");
    }

