Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int x = 2;
if (n < 2)
{

    Console.WriteLine("Ошибка!");

}
else
{

    while (x < n + 1)
    {

        Console.WriteLine(x);
        x = x + 2;
    }

}
