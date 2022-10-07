/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

//способ1

Console.WriteLine("Введите пятизначное число: "); 
int num = int.Parse(Console.ReadLine()!);
if(num>=10000 && num<=99999){
    if((num/10000 == num%10) && (num/1000%10 == num%100/10)){
        Console.WriteLine("Введенное число палиндром");
    }
    else{
        Console.WriteLine("Введенное число не является палиндромом");
    }
}
else{
    Console.WriteLine("Введенно не пятизначное число");
}

//способ2

Console.WriteLine("Введите пятизначное число: ");
String X = Console.ReadLine()!;
if(X.Length == 5){
    if(X[0]==X[4] && X[1]==X[3]){
        Console.WriteLine("Введенное число палиндром");
    }
    else{
        Console.WriteLine("Введенное число не является палиндромом");
    }
    }
else{
    Console.WriteLine("Введено не пятизначное число");
}

/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координаты первой точки: ");
Console.WriteLine("x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки: ");
Console.WriteLine("x2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("z2: ");
int z2 = int.Parse(Console.ReadLine()!);
double result = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2));
Console.WriteLine($"{result:f2}");

/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
