// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int Prompt(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int num = Prompt("Введите число: ");

for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}