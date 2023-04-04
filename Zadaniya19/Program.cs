// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите пятизначное число: ");
int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(fiveDigitNumber);
if (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
{
    Console.WriteLine("Да, оно полиндром");    
}
else
{
    Console.WriteLine("Нет, оно не полиндром");
}