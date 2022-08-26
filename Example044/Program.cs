// Задача 44:
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Числа Фибоначчи начинаются с 1. Не с 0.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();
Console.Write("Введите количество чисел Фибоначчи: ");
int countFibonachi = Convert.ToInt32(Console.ReadLine());
if (countFibonachi < 2)
{
    Console.WriteLine("Введено неверное количество чисел");
    return; //Завершает прогрмму
}
int firstElement = 0;
int secondElement = 1;
Console.Write($"Числа Фибоныччи: {firstElement} ");    // i = 1
Console.Write($"{secondElement} ");   // i = 2
for (int i = 3; i <= countFibonachi ; i++)
{
    int nextElement = firstElement + secondElement;
    Console.Write($"{nextElement} ");
    firstElement = secondElement;
    secondElement = nextElement;
} 