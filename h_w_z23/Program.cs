// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear(); //очистка консоли

Console.Write("Введите число: "); //вывод сообщение 
int num = Convert.ToInt32(Console.ReadLine()); //ввод числа
int i = 1;
while (i <= num)
{
    Console.Write($"{Math.Pow((i),3)}, ");
    i++;
}