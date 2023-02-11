Console.Write("Введите число a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
double b = double.Parse(Console.ReadLine());


if (a < b)
  {
  double Result2 = a;
   double Result = b;
     Console.Write("Максимальное число - "); Console.WriteLine(Result);
     Console.Write("Минимальное число - "); Console.WriteLine(Result2);
  }
  else
  {
    double Result = a;
    double Result2 = b;

    Console.Write("Максимальное число - "); Console.WriteLine(Result);
    Console.Write("Минимальное число - "); Console.WriteLine(Result2);
  }
