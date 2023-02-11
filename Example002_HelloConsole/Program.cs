Console.Write("Введите число a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
double c = double.Parse(Console.ReadLine());
double d = 0;


if (a > b)
{
    d = a;


}
else
{
    d = b;

}

if (d > c)
{
    d = d;
}
else
{
    d = c;
}
double Result = d;

Console.WriteLine("Максимальное число - "); Console.Write(Result);