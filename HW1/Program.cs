// Написать программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
Console.WriteLine(num1);
else
    if (num2 > num1)
        Console.WriteLine(num2);

// Написать программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Input number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine($"maks number = {max}");








    



