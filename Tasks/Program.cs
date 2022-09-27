/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/


Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());

int GetSum(int x) {
int sum = 0;
for (int i = 0; i <= x; i++) {
    sum += i;
}

return sum;
}

Console.WriteLine(GetSum(x));