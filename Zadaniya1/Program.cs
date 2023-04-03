//Задача 2: Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 < number2)
{
    Console.WriteLine("Болшое число " + number2);
    Console.Write("Меншее число " + number1);
}
else if (number1 > number2)
{
    Console.WriteLine("Болшое число " + number1);
    Console.Write("Меншее число " + number2);
}
