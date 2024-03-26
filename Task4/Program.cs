// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую

Console.WriteLine("Введите натуральное число N: "); 
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= n)
{
    Console.Write(i);
    Console.Write(", ");
    i = i+1;
}