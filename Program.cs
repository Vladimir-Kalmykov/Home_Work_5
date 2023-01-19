// Задача №1.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
 
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int count = 0;
// for (int i = 0; i < numbers.Length; i++)
// if (numbers[i] % 2 == 0)
// count++;
// Console.WriteLine($"всего {count} чётных чисел");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + ",");
//     }
//     Console.WriteLine();
// }

// Задача №2.Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int sum = 0;

// for (int i = 0; i < numbers.Length; i+=2)
//     sum = sum + numbers[i];
//     Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.WriteLine();
// }

// Задача №3. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// int N = 10;
// int[] array = new int[N];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 10);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();

// int j = array.Length - 1;
// for (int i = 0; i < (array.Length + 1) / 2; i++)
// {
//     Console.Write(array[i] * array[j] + " ");
//     j--;
// }