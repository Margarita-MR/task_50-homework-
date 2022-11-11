// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

// 1. Ввод строки и строчки

int line = ReadInt("Введите № строки: ");
int column = ReadInt("Введите № столбца: ");

// 2. Задание массива рандомно

int [,] a = new int[5, 5];
Random random = new Random();
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.Next(10);
    }

} 
// 3. Печать результата

void Printlc(int[,] a)
{
   for (int i = 0; i < a.GetLength(0); i++)
   {
      for (int j = 0; j < a.GetLength(1); j++)
      {
          Console.Write(a[i, j] + " ");
      }
       Console.WriteLine();
   }
}
Printlc(a);

// 4. Условие
if (line < a.GetLength(0) && column < a.GetLength(1)) Console.WriteLine(a[line, column]);
else Console.WriteLine($"{line} {","} {column} -> такого числа в массиве нет");

// 5. Считывание строки
int ReadInt(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}
