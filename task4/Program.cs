// Напишите программу, которая на вход принимает одно число(N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите положительное целое число N: ");
int numN = int.Parse(Console.ReadLine());

int count = -numN;
if (numN > 0)
{
while (count <= numN)
{
    Console.Write(count+" ");
    count++;
}
}
else
{
    Console.WriteLine("Введено отрицательное число");
}