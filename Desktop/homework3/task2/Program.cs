// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int aa = Promt ("Введите координату aa: ");
int ab = Promt ("Введите координату ab: "); 
int ac = Promt ("Введите координату ac: "); 
int ba = Promt ("Введите координату ba: "); 
int bb = Promt("Введите координату bb: ");
int bc = Promt("Введите координату bc: ");
double distance = point (aa, ab, ac, ba, bb, bc);
Console.WriteLine(distance);

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double point (int aa, int ab, int ac, int ba, int bb, int bc)    
{
double distance = Math.Sqrt((ba-aa)*(ba-aa)+(bb-ab)*(bb-ab)+(bc-ac)*(bc-ac));
return distance;
}



