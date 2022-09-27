/*
Задача 28: Напишите программу, которая принимает на вход 
число N и M и выдаёт произведение чисел от M до N.
2,4 -> 24 
1,5 -> 120
*/
Console.Clear();
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine());

if (n < 0) n = - n;
if (m < 0) m = - m;
if (n > m) {
    int x = n;
    n = m;
    m = x;
}

int count = 1;

for (int i = n; i <= m; i++) {
    count = count * i;
}

//int value = Math.Pow(n, count);
Console.WriteLine(count);

