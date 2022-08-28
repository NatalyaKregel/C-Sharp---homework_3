// Задача 21. Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// x = sqrt((Xb-Xa)^2+(Yb-Ya)^2+(Zb-Za)^2)

Console.WriteLine("Введите координты точки A: ");
int Xa = Convert.ToInt32(Console.ReadLine());
int Ya = Convert.ToInt32(Console.ReadLine());
int Za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координты точки B: ");
int Xb = Convert.ToInt32(Console.ReadLine());
int Yb = Convert.ToInt32(Console.ReadLine());
int Zb = Convert.ToInt32(Console.ReadLine());

double RealDistance;

double Distance (int Xa, int Xb, int Ya, int Yb, int Za, int Zb)
{
    double D = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2));
    return D;  
}

RealDistance = Distance (Xa, Xb, Ya, Yb, Za, Zb);

Console.Write("Расстояние между двумя точками: ");
Console.Write("{0: 0.00}",RealDistance); // Выводим значение до 2х знаков
