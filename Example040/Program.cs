// Задача 40:
// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
Console.Clear();
float[] Triangle = new float[3];
Console.WriteLine("Введите длины сторон треугольника: ");
for (int i = 0; i < 3; i++)
{
    Triangle[i] = float.Parse(Console.ReadLine());
}
    if (Triangle[0] < (Triangle[1] + Triangle[2]) &&
        Triangle[1] < (Triangle[0] + Triangle[2]) &&
        Triangle[2] < (Triangle[0] + Triangle[1]))
{
    Console.WriteLine($"Треугольник со сторонами {Triangle[0]}, {Triangle[1]}, {Triangle[2]} может существовать.");
}
else
{
    Console.WriteLine($"Треугольник со сторонами {Triangle[0]}, {Triangle[1]}, {Triangle[2]} не может существовать.");
}