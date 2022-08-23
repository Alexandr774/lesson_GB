// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("введите координаты 1 точки");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты 2 точки");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

double result = FindDistanceBetweenPoints(xa, ya, za, xb, yb, zb);
Console.WriteLine(result);

double FindDistanceBetweenPoints(int Fx, int Fy, int Fz, int Sx, int Sy, int Sz)
{

    double result = Math. Sqrt(Math. Pow(Fx - Sx, 2)+ Math. Pow(Fy - Sy, 2)+ Math. Pow(Fz - Sz, 2));
    return result;
}

