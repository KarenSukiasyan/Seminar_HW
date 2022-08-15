// Напишите программу,которая принимает на вход
// три числа и выдаёт максимальное значение.

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


// Напишите программу, которая на вход принимает число и выдаёт, является ли число четным.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0)
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("Odd number");
}

// Напишите программу, которая на вход принимает одно число(N), а на выходе
//  показывает все целые числа от -N до N.

Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());
int B = -N;
while (B <= N)
{
    Console.Write(B+ " ");
    B++;
}


// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num <= 999)
{
    Console.Write("Last number: " + Math.Abs(num) % 10);
}
else 
{
    Console.WriteLine("The entered number is not three digits");
}

// Напишите программу, которая принимает на вход два числа и выдаёт какое число больше.

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





    



