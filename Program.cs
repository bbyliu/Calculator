Console.WriteLine("1. Сложить два числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");

while (true)
{
    double a;
    double b;
    double operation;
    char numb;

    Console.WriteLine("Выберите операцию: ");
    numb = Convert.ToChar(Console.ReadLine());
    if (numb == '9')
    {
        Environment.Exit(0);
    }

    Console.WriteLine("Введите первое число: ");
    a = Convert.ToDouble(Console.ReadLine());


    if (numb == '1')
    {
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToDouble(Console.ReadLine());

        operation = a + b;
        Console.WriteLine(operation);
    }
    else if (numb == '2')
    {
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToDouble(Console.ReadLine());

        operation = a - b;
        Console.WriteLine(operation);
    }
    else if (numb == '3')
    {
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToDouble(Console.ReadLine());

        operation = a * b;
        Console.WriteLine(operation);
    }
    else if (numb == '4')
    {
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToDouble(Console.ReadLine());

        operation = a / b;
        Console.WriteLine(operation);
    }

    else if (numb == '5')
    {
        Console.WriteLine("Введите степень: ");
        b = Convert.ToInt32(Console.ReadLine());

        operation = Math.Pow(a, b);
        Console.WriteLine(operation);
    }

    else if (numb == '6')
    {
        operation = Math.Sqrt(a);
        Console.WriteLine(operation);
    }

    else if (numb == '7')
    {
        operation = (a * 1) / 100 ;
        Console.WriteLine(operation);
    }

    else if (numb == '8')
    {
        long h = 1;
        for(int i = 1; i <=a; i++)
        {
            h *= i;
        }
        Console.WriteLine(h);
    }
}








