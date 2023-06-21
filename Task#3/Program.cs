// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int Enter(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void inTheCube (int num)
{

for (int i = 1; i <= num; i++)
{
    int cube = i*i*i;
    System.Console.WriteLine($"Число {i} в кубе = {cube}\n");
}

}

int num= Enter("Введите число: ");
inTheCube(num);
