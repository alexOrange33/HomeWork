Console.Clear();
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine()!);

double max = num1;
if(max<num2)
{
    max = num2;
}
if(max<num3)
{
    max = num3;
}
Console.Write(max);