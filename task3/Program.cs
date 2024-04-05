// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int i = 0;
PrintReverseArr(array, i);

void PrintReverseArr(int[] arr, int index)
{
    if (index > arr.Length - 1)
        return;
    PrintReverseArr(arr, index + 1);
    System.Console.Write($"{arr[index]} ");
}