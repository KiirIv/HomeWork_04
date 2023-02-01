/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] arr = new int[8];
Random rand = new Random();

void PrintArray(int[] array)
{
    Console.Write("[");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = rand.Next(30); // макс значение элемента в массиве
        Console.Write($" {array[i]}, ");

    }
    Console.Write("]");

}
PrintArray(arr);