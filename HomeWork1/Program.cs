Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if(num%2 == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}