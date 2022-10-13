// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Не применять строки!

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputNumber(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool VerificationNumbers(int numbers)
{
    if (numbers < 10000)
    {
        Console.WriteLine("Введите число более пяти символов");
        return false;
    }
    return true;
}

bool IsPalindrome(int number)
{
    int initialNumber = number;
    int reverse = 0;
    while (number > 0)
    {
        int value = number % 10;
        reverse = reverse * 10 + value;
        number /= 10;
    }
    return initialNumber == reverse;
}

int numbers = InputNumber("Введите число -> ");
if (!VerificationNumbers(numbers))
{
    return;
}
if (IsPalindrome(numbers))
{
    Console.WriteLine($"Число {numbers} полиндромом");
}
else
{
    Console.WriteLine($"Число {numbers} не полиндром");
}
