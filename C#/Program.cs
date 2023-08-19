// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine( "Введите первое целое число");
int a = Convert.ToInt32( Console.ReadLine ( ));
int max = a;
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32( Console.ReadLine ( ));

if (max > b) 
    {
        Console.WriteLine( $"Максимальное число равно {a}");
    }
else if (b > max)
    Console.WriteLine( $"Максимальное число равно {b}");
else 
    Console.WriteLine( "Первое и второе число равны");

