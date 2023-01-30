// // Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число: ");

string numberStr1 =Console.ReadLine();
int a = Convert.ToInt32 (numberStr1);

System.Console.WriteLine("Введите второе число: ");

string numberStr2 =Console.ReadLine();
int b = Convert.ToInt32 (numberStr2);

if (a-b>0)
{
    System.Console.WriteLine($"max = {a}");
}
else
{
    System.Console.WriteLine($"max = {b}");
}