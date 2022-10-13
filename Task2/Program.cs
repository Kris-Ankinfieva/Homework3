// Программа, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


const int x = 0;
const int y = 1;
const int z = 2;

int Prompt(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] InputPoint(int point)
{
    int[] answer = new int[3];

    answer[x] = Prompt($" Введите x {point} -> ");
    answer[y] = Prompt($" Введите y {point} -> ");
    answer[z] = Prompt($" Введите Z {point} -> ");

    return answer;
}

double Power2(int arg)
{
    return Math.Pow(arg, 2);
}

int[] p1 = InputPoint(1);
int[] p2 = InputPoint(2);

double lenght = Math.Sqrt(Power2(p1[x] - p2[x]) + Power2(p1[y] - p2[y]) + Power2(p1[z] - p2[z]));

Console.WriteLine($"{lenght:f2}");