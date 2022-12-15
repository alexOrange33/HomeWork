Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine()!);

if(num1 == num2)
{
    Console.Write($"{num1} = {num2}");
}
else
{
    if(num1>num2)
    {
        Console.Write($"{num1}>{num2}");
    }
    else
    {
        Console.Write($"{num2}>{num1}");
    }
}