// Task10
// Given an integer array of size N. Print all contained in given array are odd numbers in square.

// Дан целочисленный массив размера N.
// Выведите все содержащиеся в данном массиве нечетные числа в квадрате.

// Бо назардошти массиви бутуни андозаи N. Ҳама ададҳои тоқи дар ин массив мавҷудбударо квадратошонро чоп кунед.
int n = int.Parse(Console.ReadLine());
int [] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine();
for (int i = 0; i < n; i++)
{
    if (arr[i]%2!=0)
    {
        System.Console.WriteLine(arr[i] * arr[i]);
    }
}
