﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите координату X: "); 
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y: "); 
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");
}
else
{
    if (X > 0 && Y < 0)
    {
        Console.WriteLine("Точка находится во второй координатной четверти");
    }
    else
    {
        if (X < 0 && Y < 0)
        {
            Console.WriteLine("Точка находится в третьей координатной четверти");
        }
        else
        {
            if (X < 0 && Y > 0)
            {
                Console.WriteLine("Точка находится в четвертой координатной четверти");
            }
            else
            {
                Console.WriteLine("Точка находится на оси координат");
 
            }
        }
    }
}



