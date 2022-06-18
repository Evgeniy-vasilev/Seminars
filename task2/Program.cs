// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine("Введите номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine());
if (daynumber > 0 && daynumber < 8)
{
    if (daynumber == 1) Console.WriteLine("Понедельник");
    if (daynumber == 2) Console.WriteLine("Вторник");
    if (daynumber == 3) Console.WriteLine("Среда");
    if (daynumber == 4) Console.WriteLine("Четверг");
    if (daynumber == 5) Console.WriteLine("Пятница");
    if (daynumber == 6) Console.WriteLine("Суббота");
    if (daynumber == 7) Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Неверный номер дня недели");
}
