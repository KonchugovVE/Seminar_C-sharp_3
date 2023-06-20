// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Enter(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool fiveDigitTest(int num)
{
    if (num < 10000 || num > 99999)
    {
        System.Console.WriteLine("Введенное число не соответствует условию, повторите ввод!");
        return false;
       
    }
    return true;
}

int num = Enter("Введите пятизначное число: ");

if (fiveDigitTest(num))
{
    if (num / 10000 == num % 10 || num / 1000 % 10 == num / 10 % 10)
{
    System.Console.WriteLine($"Число {num} является палиндромом");
    return;
}
System.Console.WriteLine($"Число {num} не является палиндромом");
}
