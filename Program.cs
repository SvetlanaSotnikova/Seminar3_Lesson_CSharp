//Task_1. Напишите прграмму, которая по заданному номеру четверти показывает диапозон возможных координат точек в этой четверти (x и у)
/* void WriteRange(int quadinat) {
    if (quadinat < 1 || quadinat > 4) Console.WriteLine("Uncorrect data!");
    else if (quadinat == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quadinat == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quadinat == 3) Console.WriteLine("x < 0 and y < 0");
    else Console.WriteLine("x < 0 and y > 0");
}

Console.Write("Input a num of quardinat: ");
int quad = Convert.ToInt32(Console.ReadLine());

WriteRange(quad); 
*/

//Task_2. Напишите программу, которая принимает на вход число N выдает квадраты чисел от 1 до N
/* void WriteQrt(int num) {
    int i = 1;
    while (i < num) { 
        Console.Write(Math.Pow(i, 2) + " ");
        i++; }
}
Console.Write("num = ");
int num = Convert.ToInt32(Console.ReadLine()); 

WriteQrt(num); */

//Task_3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

double GetDot(double x1, double y1, double X2, double y2) {
   
    double deltaX = X2 - x1;
    double deltaY = y2 - y1;

    return Math.Sqrt((deltaX * deltaX)+(deltaY*deltaY)); 
}
Console.Write("X1 = ");
double x1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("y1 = ");
double y1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("X2 = ");
double x2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("y2 = ");
double y2 = Convert.ToInt32(Console.ReadLine()); 

double res = GetDot(x1,y1,x2,y2);
Console.WriteLine($"Distance between points is : {res}");
