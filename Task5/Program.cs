// Task5
// Given an array of integers. Print the index of the smallest element in the array.

// Дан массив целых чисел. Выведите индекс наименьшего элемента в массиве.

// Элементи хурдтарина индексша чоп кнен.

int n = int.Parse(Console.ReadLine());
int [] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine()); 
}
System.Console.WriteLine();
Array.Sort(arr);

System.Console.WriteLine(arr[0]);