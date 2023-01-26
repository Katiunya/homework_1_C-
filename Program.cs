/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.Write("Input your first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine($"max = {num_1}, min ={num_2}");
}
if (num_1 < num_2)
{
    Console.WriteLine($"max = {num_2}, min = {num_1}");
}
else
    Console.WriteLine($"{num_2} равно {num_1}");


// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.  

Console.Write("Input your first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your third number: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2 & number_1 > number_3)
{
    Console.WriteLine($"{number_1} - максимальное!");
}
if (number_2 > number_1 & number_2 > number_3)
{
    Console.WriteLine($"{number_2} - максимальное!");
}
else
    Console.WriteLine($"{number_3} - максимальное!");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).   

Console.Write("Input your number D: ");
int num_D = Convert.ToInt32(Console.ReadLine());

if (num_D % 2 == 0)
{
    Console.WriteLine("Да!");
}
else
    Console.WriteLine("Нет!");

*/
// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input your number N: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= num)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}    