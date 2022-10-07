﻿/*Задача 19
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

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
