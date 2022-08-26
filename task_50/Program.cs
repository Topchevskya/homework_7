// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)


Console.Write("Введите номер строки: ");
int positionRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int positionColumn = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[5, 7];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
if (positionRows < 0 || positionRows > array.GetLength(0) || positionColumn < 0 || positionColumn > array.GetLength(1))
{
    Console.WriteLine($"{positionRows}, {positionColumn} -> Такого числа в массиве нет");
}
else
{
    Console.WriteLine($"{positionRows}, {positionColumn} -> {array[positionRows, positionColumn]}");
}