// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear(); //очистка консоли
Console.WriteLine("Введите цифру которую хотите проверить: "); //вывод сообщение 
int num = Convert.ToInt32(Console.ReadLine()); //ввод числа
int rev = 0;
int temp = num;
while(num > 0)
{
    int dig = num % 10;
    rev = rev * 10 + dig;
    num = num / 10;
}
if (temp == rev)
{
    Console.WriteLine("Это палиндром!");
}
else
{
    Console.WriteLine("Это не палиндром!");
}