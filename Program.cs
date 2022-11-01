/*Console.Write("Input first number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"my first number is {num}");*/
//here i can commented

// Здание 1. Напишите программу, которая на вход принимает число и выдает его квадрат
/*Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine($"Quad of {num} is -> {result}");*/

//Задача 2.напишите программу которая на вход принимает два числа и проверяет являтся ли первое число квадратом второго. 
//Задача 3. Напишите программу, котрая на вход принимает одно число N, а навыходе все целые числа в промежутке от -N до N.
//Задача 4. Напишите программу которая на вход дает трехзначное число,а на выход последнюю цифру данного числа (чтобы решить задачу будем делить число на 10)

// 9/4==1 (остаток от деления), 12/4=3

//Задача 3
/*Console.WriteLine("Input number ");
int num = Convert.ToInt32 (Console.ReadLine());
int current = num * (-1);
while (current <= num)
{ 
    Console.Write(current + " ");
    current++;
}*/

//Задача 4
/*Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32 (Console.ReadLine());
int current = num % 10;
Console.Write(current);*/

/*Console.WriteLine("Input first number ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Input second number ");
int num2 = Convert.ToInt32 (Console.ReadLine());
int quad2 = num2 * num2;
if (num1==quad2)
{
    Console.WriteLine($"{num1} является квадратом {num2}");
}
else Console.WriteLine($"{num1} не является квадратом {num2}");*/

//Домашняя задача номер 1

/*Console.WriteLine("Input first number ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Input second number ");
int num2 = Convert.ToInt32 (Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"{num1} больше {num2}");
}
else Console.WriteLine($"{num1} меньше {num2}");*/

/* Задача 2
Console.WriteLine("Input first number ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Input second number ");
int num2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Input third number ");
int num3 = Convert.ToInt32 (Console.ReadLine());
if (num1 > num2 & num1>num3)
    Console.WriteLine("Максимальное число:" +num1);
else    
    if (num2 > num1 & num2>num3)
    Console.WriteLine("Максимальное число:" +num2);
    else
    Console.WriteLine("Максимальное число:" +num3);

Console.WriteLine("Максимальное число");*/

/*Задача 3
Console.WriteLine("Input number ");
int num = Convert.ToInt32 (Console.ReadLine());
if (num % 2==0)
    Console.WriteLine("Является четным:" +num);
else
    Console.WriteLine("Является нечетным:" +num);*/



/*Задача 4
Console.Write("Write number 1: ");
        int N = Convert.ToInt32 (Console.ReadLine());
        int m = 1;
        for (int i = m; i <= N; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
        */
