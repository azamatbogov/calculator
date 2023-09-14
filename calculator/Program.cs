using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double result = 0;
bool exit = false;
double num1 = 0;
double num2 = 0;

while (!exit)
{
    Console.WriteLine("Выберите операцию:");
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычитание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возведение в степень");
    Console.WriteLine("6. Квадратный корень");
    Console.WriteLine("7. 1% от числа");
    Console.WriteLine("8. Факториал");
    Console.WriteLine("9. Выйти из программы");

    int choice;
    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 9)
    {
        Console.WriteLine("Введите правильный номер операции (1-9).");
    }

    if (choice >= 1 && choice <= 8)
    {
        Console.Write("Введите первое число: ");
        num1 = double.Parse(Console.ReadLine());

        if (choice < 5)
        {
            Console.Write("Введите второе число: ");
            num2 = double.Parse(Console.ReadLine());
        }

        if (choice == 4 && num2 == 0)
        {
            Console.WriteLine("Деление на ноль невозможно.");
            continue;
        }
    }

    if (choice == 1)
        result = num1 + num2;
    else if (choice == 2)
        result = num1 - num2;
    else if (choice == 3)
        result = num1 * num2;
    else if (choice == 4)
        result = num1 / num2;
    else if (choice == 5)
    {
        Console.Write("Введите степень: ");
        int power = int.Parse(Console.ReadLine());
        double tempResult = 1;
        int i = 0;
        do
        {
            tempResult *= num1;
            i++;
        } while (i < power);
        result = tempResult;
    }
    else if (choice == 6)
        result = Math.Sqrt(num1);
    else if (choice == 7)
        result = num1 / 100;
    else if (choice == 8)
    {
        double factorial = 1;
        int j = 1;
        do
        {
            factorial *= j;
            j++;
        } while (j <= num1);
        result = factorial;
    }
    else if (choice == 9)
        exit = true;

    if (!exit)
        Console.WriteLine("Результат: " + result);
}