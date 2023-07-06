// array[i] = Math.Round((rnd.NextDouble() - 0.5) * 2 * deviation, 2); //диапазон deviation от нуля
// array[i] = Math.Round(rnd.NextDouble() + rnd.Next(min, max), 2); // double только дробная часть
// array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2); // вариант с отрезком min - max !!!

// Задача 38

// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// double[] CraeteArray(int size)
// {
// return new double[size];
// }
// void FillArray(double[] array)
// {
// int min = -2;
// int max = 4;
// Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
// }
// }

// void PrintArray(double[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// }
// double Diff (double[] array)
// {
// double max = array[0];
// double min = array[0];
// for (int i = 1; i < array.Length; i++)
// {
// if (array[i] > max) max = array[i];
// else if (array[i] < min) min = array[i];
// }
// return Math.Round(max - min, 2);
// }

// int pos = InputNum("Введите размер массива: ");
// double[] myArray = CraeteArray(pos);
// FillArray(myArray);
// PrintArray(myArray);

// double difference = Diff(myArray);
// Console.WriteLine(difference);

// Переворот массива - основной метод

// void ReverseArray(int[] array)
// {
// for (int i = 0; i < array.Length / 2; i++)
// {
// int temp = array[i];
// array[i] = array[array.Length - 1 - i];
// array[array.Length - 1 - i] = temp;
// }
// }

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// bool Pif(int a, int b, int c)
// {
// if(a+b<c && b+c<a && c+a<b) return true;
// return false;
// }

// int num=InputNum("Введите число a: ");
// int num1=InputNum("Введите число b: ");
// int num2=InputNum("Введите число c: ");
// bool check = Pif(num, num1,num2);
// Console.WriteLine(check);

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// ************************************
// Вариант с массивом

// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[] Division (int num)
// {
// int temp = num;
// int index = 0;
// int res = num;
// while(temp != 0)
// {
// temp = temp / 2;
// index++;
// }
// int[] array = new int[index];
// for (int i = 0; i < array.Length; i++)
// {
// res = num % 2;
// num = num / 2;
// array[i] = res;
// }
// return array;
// }

// void RevArray(int[] array)
// {
// for (int i = 0; i < array.Length / 2; i++)
// {
// int temp = array[i];
// array[i] = array[array.Length - 1 - i];
// array[array.Length - 1 - i] = temp;
// }
// }
// void PrintArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i]);
// }
// Console.WriteLine();
// }

// int number = InputNum("Введите число: ");
// int[] myArray = Division(number);
// PrintArray(myArray);
// RevArray(myArray);
// PrintArray(myArray);

// ****************************************************
// Вариант со строкой

// Console.Clear();
// System.Console.WriteLine("число: ");
// int num = int.Parse(Console.ReadLine());
// string count = "";

// while (num > 0)
// {
// count = num % 2 + count;
// num = num / 2;
// }
// System.Console.WriteLine(count);

// ********************************************
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// void Fibonacci(int num)
// {
// int first = 0;
// int second = 1;
// int res = 0;
// if (num == 1) Console.Write(first);
// else Console.Write(first);
// for (int i = 0; i < num -1; i++)
// {
// res = second;
// second = first + second;
// first = res;
// Console.Write(" "+res);
// }
// }


// int number = InputNum("Введите целое число: ");
// Fibonacci(number);


// ********************************************
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] A = {3, 4, 5, 6};
// Console.WriteLine(String.Join(" ", A));
// int[] C = new int[A.Length];

// for (int i = 0; i < C.Length; i++)
// {
// C[i] = A[i];
// }

// Console.WriteLine(String.Join(" ", C));
// A[2] = 10;
// Console.WriteLine(String.Join(" ", A));
// Console.WriteLine(String.Join(" ", C));
/*
int[C] = A; // та же ссылка на массив А
// если менять А, то ищменится и С
*/

// ********************************************
// S_E_M_I_N_A_R_007
// ********************************************

// Двоичная запись числа в строку

// int num = int.Parse(Console.ReadLine()!);

// string bin = String.Empty;

// while (num != 0)
// {
// bin = num % 2 + bin; // заполнение строки в обратном порядке
// num /= 2;
// }

// ********************************************

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int cols)
// {
// return new int[rows, cols];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// for (int j = 0; j < array.GetLength(1); j++)
// array[i, j] = rnd.Next(min, max + 1);
// }

// void Print2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// Console.Write($"{array[i, j]}\t"); // табуляция для вывода столбцами.
// Console.WriteLine();
// }
// }
// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);

// ********************************************

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int cols)
// {
// return new int[rows, cols];
// }

// void Fill2DArray(int[,] array)
// {

// for (int i = 0; i < array.GetLength(0); i++)
// for (int j = 0; j < array.GetLength(1); j++)
// array[i, j] = i + j;
// }

// void Print2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// Console.Write($"{array[i, j]}\t"); // табуляция для вывода столбцами.
// Console.WriteLine();
// }
// }
// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");


// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray);
// Print2DArray(myArray);

// ********************************************
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int cols)
// {
// return new int[rows, cols];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// for (int j = 0; j < array.GetLength(1); j++)
// array[i, j] = rnd.Next(min, max + 1);
// }

// void Replace(int[,] array)
// {
// for
// (int i = 0; i < array.GetLength(0); i++)
// {
// if (i % 2 == 0 && i > 0)
// for (int j = 0; j < array.GetLength(1); j++)
// if (j % 2 == 0 && j > 0)
// array[i, j] = array[i, j] * array[i, j];
// }
// }

// void Print2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// Console.Write($"{array[i, j]}\t");
// Console.WriteLine();
// }
// Console.WriteLine();
// }

// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Replace(myArray);
// Print2DArray(myArray);

// ********************************************
// Задача 51: Задайте двумерный массив. Найдите сумму элементов главной диагонали.

// Вариант с двумя циклами

// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int cols)
// {
// return new int[rows, cols];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// for (int j = 0; j < array.GetLength(1); j++)
// array[i, j] = rnd.Next(min, max + 1);
// }

// void Sum (int[,] array)
// {
// int res = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// if (i == j)
// res = array[i,j] + res;
// }
// }
// Console.WriteLine(res);
// }

// void Print2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// Console.Write($"{array[i, j]}\t");
// Console.WriteLine();
// }
// Console.WriteLine();
// }

// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine("Сумма равна: ");
// Sum(myArray);

// ********************************************
// Вариант с одним циклом
// int InputNum(string message)
// {
// Console.Write(message);
// return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int cols)
// {
// return new int[rows, cols];
// }
// void Fill2DArray(int[,] array, int min, int max)
// {
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// for (int j = 0; j < array.GetLength(1); j++)
// array[i, j] = rnd.Next(min, max + 1);
// }

// void Print2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// Console.Write($"{array[i, j]}\t");
// Console.WriteLine();
// }
// }
// int SumDiag(int[,] array)
// {
// int sum = 0;
// int temp = array.GetLength(1);
// if (array.GetLength(0) < array.GetLength(1))
// temp = array.GetLength(0);
// for (int i = 0; i < temp; i++)
// {
// sum += array[i, i];
// }
// return sum;
// }

// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение диапазона: ");
// int maxValue = InputNum("Введите максимальное значение диапазона: ");

// int[,] myArray = Create2DArray(rows, columns);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// int result = SumDiag(myArray);
// Console.WriteLine(result);

// ********************************************
// Как поменять значения ячеек архива без temp

// int[] array = {1, 2, 3, 4, 5};
// System.Console.WriteLine(String.Join(" ", array));

// for (int i = 0; i < array.Length / 2; i++)
// {
// array[i] = array[i] + array[array.Length - 1- i];
// array[array.Length - 1- i] = array[i] - array[array.Length - 1- i];
// array[i] = array[i] - array[array.Length - 1- i];
// }

// System.Console.WriteLine(String.Join(" ", array));

// ********************************************

