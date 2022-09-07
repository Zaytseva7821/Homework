// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Простое решение:

// System.Console.WriteLine("Введите координаты точки A:");
// System.Console.WriteLine("Введите значение x");
// int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите значение y");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите значение z");
// int z1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координаты точки B:");
// System.Console.WriteLine("Введите значение x");
// int x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите значение y");
// int y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите значение z");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
// System.Console.WriteLine(distance);

// Решение через массив:

System.Console.WriteLine("Введите координаты точки A, записывая значения осей в разных строках:");
int i = 0;
int[] CoordA = new int[3];
while (i<3)
{
    CoordA[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
System.Console.WriteLine("Введите координаты точки Б, записывая значения осей в разных строках:");
i = 0;
int[] CoordB = new int[3];
while (i<3)
{
    CoordB[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
double distance = Math.Sqrt(Math.Pow(CoordB[0]-CoordA[0],2)+Math.Pow(CoordB[1]-CoordA[1],2)+Math.Pow(CoordB[2]-CoordA[2],2));
System.Console.WriteLine(distance);
