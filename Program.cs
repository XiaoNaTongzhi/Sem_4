
// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// // и возводит число A в натуральную степень B.

// Console.Write($"Введи число: ");
// double a = double.Parse(Console.ReadLine()!);
// Console.Write($"В какую степень возвести: ");
// int b = int.Parse(Console.ReadLine()!);

// double res = GetPow(a, b);
// Console.WriteLine ($"Ответ: {res}");

// double GetPow(double num, int pow)
// {
//     double result = Math.Pow(num, pow);
//     return result;
// }





// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.


// Console.Write($"Введи число: ");
// string sa = (Console.ReadLine()!);
// int a = int.Parse(sa);

// int [] numbers = new int [sa.Length];
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = a % 10;
//     a = a / 10;
// }

// int sum = GetSum(numbers);

// int GetSum(int[] array)
// {
//     int result = 0;
//     for (int p = 0; p < array.Length; p++)
//     {
//     result += array[p];
//     }
//     return result;
// }

// Console.WriteLine($"Все цифры числа {sa} (в обратном порядке): " + (String.Join(", ", numbers))); 
// Console.WriteLine($"Сумма цифр числа {sa}: {sum}"); 



// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов 
// и выводит их на экран.

// int[] array = new int[8];
// FillArray(array);
// Console.WriteLine(String.Join(", ", array));

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 10);
//     }
// }







// ___________________________________________________________________________
// // РАБОТА С МАССИВАМИ (ЛЕКЦИИ 2 И 3)
// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);

// void FillArray(int[] collection)
// {
//     for (int index = 0; index < collection.Length ; index++)
//     {
//     array[index] = new Random().Next(1,10);
//     }
// }

// void PrintArray(int[] coll)
// {
//    for (int position = 0; position < coll.Length ; position++)
//    {
//     Console.Write($"{coll[position]} ");
//    }
// }

// ***
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// _____________________________________________________________
// С СЕМИНАРА

// ЗАПОЛНИТЬ МАССИВ СЛУЧАЙНЫМИ ЧИСЛАМИ

// int[] ar = FillArray();
// PrintArray(ar);

// int[] FillArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }



// void PrintArray(int [] arr)
// {
//    for (int p = 0; p <= arr.Length; p++)
//     {
//         Console.Write($"{array[p]} ");
//     } 
// }



// // НА ВХОД ЧИСЛО N, ПРОИЗВЕДЕНИЕ ОТ 1 ДО N

// Console.Write("Введи число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write($"Произведение чисел от 1 до {n} -> {Multiply(n)}");

// int Multiply(int number)
// {
//     int result = 1;
//     for (int a = 1; a <= number; a++)
//     {
//        result = result * a;
//     }
//     return result;
// }


//// НА ВХОД ЧИСЛО, СЧИТАТЬ КОЛ-ВО ЦИФР

// Console.Write("Введи число: ");
// string number = Console.ReadLine()!;
// Console.Write($"В числе {number} {Count(number)} цифр.");

// int Count(string n)
// {
//     int result = n.Length;
//     return result;
// }


// // // ____________________________
// // // С 3-й лекции.

// // // for (int i = 2; i <= 10; i++)
// // // {
// // //     for (int j = 2; j <= 10; j++)
// // //     {
// // //         Console.WriteLine($"{i} x {j} = {i * j}");
// // //     }
// // //     Console.WriteLine();
// // // }
// // //_______________________________________


// // string text = "Надо заменить пробелы разграничителями в этом тексте.";

// // string Replace(string text, char oldValue, char newValue)
// // // Возвращаться будет строка
// // // Метод назовём "Замена"
// // // На ввод: сам текст, что заменить и на что заменить
// // {
// //  string result = string.Empty; // в переменную "результат" для начала записываем пустую строку

// // int length = text.Length;

// // for (int i = 0; i < length; i++)
// // {
// //     if (text[i] == oldValue) result = result + $"{newValue}";
// //     else result = result + $"{text[i]}";
// // }

// //  return result;
// // }

// // string newText = Replace (text, ' ', '|');
// // Console.WriteLine(newText);

// // //_____________________________

// int[] arr = { 4, 7, 3, 0, 8, 2, 4, 9 }; // ввели массив

// void PrintArray(int[] array)            // подпрограмма для вывода на экран
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)         // подпрограмма для сортировки
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);
