// Задача 45:
// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];
for (int i = 0; i < size; i++)  // Вместо size можно указать
                                // array.Length Это одно и тоже,
{                               // но меленнее.
    Array[i] = new Random().Next(11); // Выборка от 0 до 10 [0, 10]
}
Console.WriteLine($"Array: [{String.Join("; ", Array)}]");
int[] ArrayDouble = CopyArray(Array);
Console.WriteLine($"Копия массива Array: [{String.Join("; ", ArrayDouble)}]");
int[] CopyArray(int[] inArray)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = inArray[i];

    }
    return result;
}