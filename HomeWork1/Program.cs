Console.Clear();
Console.Write("Введите число ");
double num = Convert.ToDouble(Console.ReadLine()!);
int a = 1;

if(num<=-2 || num>=2)//проверка на промежуток в котором нет результатов
{
if(num>0)//определение в какую сторону от 0 идти
{
while(a<=num)// проход если число положительное
{
    if(a%2 == 0)//вывод только четных значений
    {
        Console.Write($"{a} ");
    }
    a++;
}
}
else
{ 
while(a>=num)//проход если число отрицательное
    {
    if(a%2 == 0 && a!=0)//вывод только четных значений и исключение 0
    {
        Console.Write($"{a} ");
    }
    a--;
    }
    
}
}
else
{
    Console.Write("Таких чисел нет");
}
