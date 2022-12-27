// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ThirdDigit = 0;

if (number < 0)
{
    number = - number;
} 

if (number < 100)
{
    Console.WriteLine("третьей цифры нет!");
}
while (number >= 1000)
{
    number = number / 10;
}

if (number >= 100 && number <= 999)
{
    ThirdDigit = number % 10;
    Console.WriteLine($"Третья цифра {ThirdDigit}");
}
