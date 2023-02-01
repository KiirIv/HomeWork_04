/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("введите первое число");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

Console.WriteLine("введите второе число");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

Console.WriteLine($"{a} в степени {b} = " + Math.Pow(a, b));