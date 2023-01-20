// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день
// недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: "); // Вывод в консоль
int num = Convert.ToInt32(Console.ReadLine()); // Ввод числа

if (num == 1)// если
    {
        Console.WriteLine("Нет");
    }
else if (num == 2)// также если
    {
        Console.WriteLine("Нет");
    }
else if (num == 3)
    {
        Console.WriteLine("Нет");
    }
else if (num == 4)
    {
        Console.WriteLine("Нет");
    }
else if (num == 5)
    {
        Console.WriteLine("Нет");
    }
else if (num == 6)
    {
        Console.WriteLine("Да");
    }
else if (num == 7)
    {
        Console.WriteLine("Да");
    }
else 
    {
        Console.WriteLine("Такого дня не существует!");
    }
