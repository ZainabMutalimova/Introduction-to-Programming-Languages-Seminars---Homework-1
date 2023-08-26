Console.WriteLine("Упражненеи № 1");

Console.WriteLine("Ввведите первое число:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Первое число: {x}");
Console.WriteLine("Ввведите второе число:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Второе число: {y}");
if (y < x)
{
    Console.WriteLine($"Первое число больше и равно: {x}.");
}
else
{
    Console.WriteLine($"Второе число больше и равно: {y}.");
}

Console.WriteLine("Упражненеи № 2");

Console.WriteLine("Ввведите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Первое число: {a}");
Console.WriteLine("Ввведите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Второе число: {b}");
Console.WriteLine("Ввведите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"третье число: {c}");
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine($"Максимальное число: {max}.");

Console.WriteLine("Упражненеи № 3");

Console.WriteLine("Ввведите число:");
int d = Convert.ToInt32(Console.ReadLine());
if (d % 2 == 0)
{ Console.WriteLine($"Введенное число четное"); }
else
{ Console.WriteLine($"Введенное число нечетное"); }

Console.WriteLine("Упражненеи № 4");

Console.WriteLine("Ввведите число:");
int e = Convert.ToInt32(Console.ReadLine());
int f = 2;
if (e > 0)
{
    while (f <= e)
    {
        Console.Write(f + " ");
        f = f + 2;
    }
}
else { Console.WriteLine("Ввведенное число меньше 0");}