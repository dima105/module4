
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 31)
{
    Console.WriteLine($"Число в промежутке от 0 до 30.");
}
else if (number > 30 && number < 61)
{
    Console.WriteLine($"Число в промежутке от 31 до 60.");
}
else if (number > 60 && number < 91)
{
    Console.WriteLine($"Число в промежутке от 61 до 90."); ; ;
}
else if (number > 90 || number < 0)
{
    Console.WriteLine($"Я такого числа не знаю."); ; ;
}
