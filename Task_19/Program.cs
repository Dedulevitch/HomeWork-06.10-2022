/* // Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
9229  */

Console.WriteLine("Напишите число: ");
string myArray = Console.ReadLine();
if (myArray[0] == myArray[4] && myArray[1] == myArray[3])
{
    Console.Write("Палиндром");
}
else
{
    Console.Write("Не палиндром");
}
 

















