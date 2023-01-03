// Напишите программу, которая по заданному номеру четверти показывает 
// диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine("введите номер четверти, от 1 до 4");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 4)
{
    Console.Write("Это не номер чеверти!");
    return;
}

if ( number == 1 )
{
    Console.Write("X > 0; Y > 0");
}
if ( number == 2 )
{
    Console.Write("X < 0; Y > 0");
}
if ( number == 3 )
{
    Console.Write("X < 0; Y < 0");
}
if ( number == 4 )
{
    Console.Write("X > 0; Y < 0");
}
