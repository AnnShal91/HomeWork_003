// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


void Polindrom (string number)
{
    if(number.Length == 5)
        Polindrom(number);
        else Console.Write("Uncorrect number");

    if(number[0] == number[4] && number[1]== number[3])
    {
        Console.Write("Yes,your number is a polindrom");
    }
    else
    {
        Console.Write("No,your number is not a polindrom");

    }

}



Console.Write("Input fivedigit number:  ");
var number = Convert.ToString(Console.ReadLine());
Polindrom(number);




/*
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance(double x, double y, double z, double x1, double y1, double z1)


{
     double num = 0;
     num = (x1-x)*(x1-x) + (y1-y)*(y1-y)+ (z1-z)*(z1-z);
     num = Math.Sqrt(num);
    
    return num;

}

Console.Write("Coordinate x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Coordinate y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Coordinate z: ");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("Coordinate x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Coordinate y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Coordinate z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

double findDistance = FindDistance(x, y, z, x1, y1, z1);
Console.WriteLine(findDistance);

*/


/*

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void ShowNumbers(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count, 3);
        count++;
        Console.Write(n + " ");
    }

} 
Console.Write("INPUT NUMBER: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number);
*/