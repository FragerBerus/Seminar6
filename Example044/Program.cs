// Задача 44:
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Числа Фибоначчи начинаются с 1. Не с 0.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();
int countFibonachi = 10;
int firstElement = 0;
int secondElement = 1;
Console.WriteLine(firstElement);    // i = 1
Console.WriteLine(secondElement);   // i = 2
for (int i = 3; i <= countFibonachi ; i++)
{
    int nextElement = firstElement + secondElement;
    Console.WriteLine(nextElement);
    firstElement = secondElement;
    secondElement = nextElement;
} 