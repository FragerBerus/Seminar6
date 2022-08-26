// Задача 41:
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();
Console.Write("Введите количество первых чисел Фибоначчи: ");
int quantity = Convert.ToInt32(Console.ReadLine());
int[] ArrayFibonachi = new int[quantity];
ArrayFibonachi[0] = 0;
if (quantity != 1)
{
    ArrayFibonachi[1] = 1;
    if (2 < quantity)
    {
        for (int i = 2; i < quantity; i++)
        {
            ArrayFibonachi[i] = ArrayFibonachi[i - 2] + ArrayFibonachi[i - 1];
        }
        Console.WriteLine($"Первые {quantity} чисел Фибоначии: [{String.Join("; ", ArrayFibonachi)}].");
    }
    else
    {
        if (quantity == 2)
        {
            Console.WriteLine("Первые 2 числа Фибоначчи: [0; 1].");
        }
    }
}
else
{
    Console.WriteLine($"Первые 2 числа Фибоначии всегда известны. Введите другое число.");
}