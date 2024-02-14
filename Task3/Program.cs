// Task3
// Given an array of integers. Print the index of the largest element in the array.

// Дан массив целых чисел. Выведите индекс самого большого элемента массива.

// Массив дода шуда аст. Элементи калонтаринро индексашро бароред.

int n = int.Parse(Console.ReadLine());
int [] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
   
}
System.Console.Write("The bigest index of Elemnt is : ");
Array.Sort(arr);
System.Console.WriteLine(n - 1);