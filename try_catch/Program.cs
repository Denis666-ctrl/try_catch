using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите первое число: ");
            double x = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double y = int.Parse(Console.ReadLine());

            double result = x / y;
            Console.WriteLine($"{x}/{y}={result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: Деление на ноль невозможно.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите корректное целое число.");
        }
        finally
        {
            Console.WriteLine("Программа завершила выполнение.");
        }
    }
}
