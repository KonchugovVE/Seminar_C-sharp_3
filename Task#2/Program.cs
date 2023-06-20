// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53





void EnterArray(string text)
{
    string[] coordinateAxes = { "x", "y", "z" };

    int[] myArray = new int[3];

    for (int i = 0; i < coordinateAxes.Length; i++)
    {
        System.Console.Write($"\n{text} {coordinateAxes[i]}: ");
        myArray[i] = int.Parse(Console.ReadLine());
    }
    return new myArray[];
}

int distance(int[] pointA, int[] pointB)
{
    int summ = 0;

    for (int i = 0; i < 3; i++)
    {
        int diff = pointB[i] - pointA[i];
        summ = summ + diff * diff;

    }
    int distance = Convert.ToInt32(Math.Sqrt(summ));
    return distance;
}

int[] pointA = new int[3];

int[] pointB = new int[3];

System.Console.WriteLine("Введите координаты точки А ");

pointA = EnterArray("Введите значение оси кординат ");

System.Console.WriteLine("Введите координаты точки B ");

pointB = EnterArray("Введите значение оси кординат ");

System.Console.WriteLine($"Растояние между точками = {distance(pointA, pointB)}");
