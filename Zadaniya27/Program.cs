// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
string number = Console.ReadLine();
int SumNumbers = 0;

for (int i = 0; i < number.Length; i++)
{
    string str = Convert.ToString(number[1]);
    int number1 = Convert.ToInt32(str);
    SumNumbers = SumNumbers + number1;
}
Console.Write(SumNumbers);