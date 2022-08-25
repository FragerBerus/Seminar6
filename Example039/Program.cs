// Задача 39:
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
// Лучше выносить размер массива в отдельную переменную,
// чтобы не вычислять каждый раз array.Length
int[] Array = new int[size];
for (int i = 0; i < size; i++)  // Вместо size можно указать
                                // array.Length/ Это одно и тоже
{
    Array[i] = new Random().Next(11); // Выборка от 0 до 10 [0, 10]
}
Console.WriteLine($"Array: [{String.Join("; ", Array)}]");
// String.Join соединяет массив в формат строки
// ПЕРЕВОРОТ МАССИВА
// Способ №1
// Создать новый массив и записать элементы в обратном порядке
int lastIndex = size - 1;   // Индекс самого последнего элемента
                            // массива
int[] resultArray = new int[size];
for (int i = 0; i < size; i++)
{
    resultArray[i] = Array[lastIndex - i];
}
Console.WriteLine($"resultArray: [{String.Join("; ", resultArray)}]");
// Способ №2 (методов)
int[] array = GetArray(10, 0, 10);
Console.WriteLine($"Исходный случайный массив: [{String.Join("; ", array)}]");

int[] reversArray=CopyArray(array);
Console.WriteLine($"Реверсивный массив методом копирования: [{String.Join("; ", reversArray)}]");

ReverseArray(array);
Console.WriteLine($"Реверсивный массив методом замены: [{String.Join("; ", array)}]");

int[] GetArray(int size, int minValue, int maxValue) 
// Метод заполнения массива, где size -длина массива, minValue -
// минимальное число, maxValue - максимальное число
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
    res[i] = new Random().Next(minValue, maxValue + 1); // [0;11) => [0;10]
}
return res;
}

void ReverseArray(int[] inArray)    // Метод переворота массива
// путем замены в нем элементов
{
for (int i = 0; i < inArray.Length / 2; i++)
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - i - 1];
inArray[inArray.Length - i - 1] = temp;
}
}

int[] CopyArray(int[] inArray) // Метод копирования массива 
// в реверсивном виде (обратный массив)
{
int[] result = new int[inArray.Length];
for (int i = 0; i < inArray.Length; i++)
{
result[i] = inArray[inArray.Length - 1 - i];

}
return result;
}