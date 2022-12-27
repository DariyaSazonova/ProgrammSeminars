// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначиное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)

{
int seconddigit = number % 100;
int finaldigit = seconddigit / 10;
Console.WriteLine($"вторая цифра в трехзначном числе: {finaldigit}");
}

else

{
    Console.WriteLine("число не является трехзначным");
}