// Напишите программу вычисления модуля числа.
Console.WriteLine("Введите число: ");
int numN = int.Parse(Console.ReadLine());

if (numN > 0)
{
    Console.WriteLine($"Модуль числа {numN} равен {numN} ");
}
else
{
    Console.WriteLine($"Модуль числа {numN} равен {-numN} ");
}
