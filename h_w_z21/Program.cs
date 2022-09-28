// Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// AB = √(xb - xa)^2 + (yb - ya)^2 + (zb - za)^2

Console.Clear(); //очистка консоли
Console.WriteLine("Введите координаты первой точки: "); //вывод сообщение 
double[] p1 = new double[3] {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())}; //ввод трех чисел первой точки
Console.WriteLine("Введите координаты первой точки: "); //вывод сообщение 
double[] p2 = new double[3] {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())}; //ввод трех чисел второй точки

double distance = Math.Pow((p2[0]-p1[0]),2) + Math.Pow((p2[1]-p1[1]),2) + Math.Pow((p2[2]-p1[2]),2);

Console.WriteLine(distance);









