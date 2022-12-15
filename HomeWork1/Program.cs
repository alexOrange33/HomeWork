Console.Clear();
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine()!);

if(num1 == num2)
{
    Console.Write($"Числа равны: {num1} = {num2}");
}
else
{
    if(num1>num2)
    {
        Console.Write($"max = {num1}, min = {num2}");
    }
    else
    {
        Console.Write($"max = {num2}, min = {num1}");
    }
}