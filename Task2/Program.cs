/*
Задача 26: Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
// Проверить больше 10 цифр
*/

Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());

int Numbers (int x) {
    int result = 0;
    if (x == 0) result = 1;
    for (int i = 1; i < x; i++) {
        if (x / i >= 1) { 
            result += 1;
            i = i * 10;
        }
    }
    return result;
}
Console.WriteLine($"В веденном числе {Numbers(x)} цифр(а)");