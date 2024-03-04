//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

System.Console.WriteLine ("Enter number :");

string number = Console.ReadLine();
int number1 = int.Parse (number);


if (number1 % 2 == 1)

    Console.WriteLine($"Number {number1} is odd");

else

    Console.WriteLine($"Number {number1} is even");
