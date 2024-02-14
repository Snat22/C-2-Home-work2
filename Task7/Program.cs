// Task7
// Given an array of integers. If it contains two adjacent elements of the same sign, print these numbers.
// If there are no adjacent elements of the same sign, do not print anything. If there are several such pairs of neighbors, print the last pair.

// Дан массив целых чисел. Если он содержит два соседних элемента одного знака, выведите эти числа.
// Если нет соседних элементов одного знака, ничего не выводить. Если таких пар соседей несколько, выведите последнюю пару.

// Массив дода мешавад. Охирон ду Элементе ки хардуш позитив(аз нол калон ададхо) ё ҳардуш негитаван(аз нол хурд ададхо) чопшон кнен!

int n = int.Parse(Console.ReadLine());
int [] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int a = 0; 
int b = 0;
for (int i = 1; i < n - 1; i++)
{
    if ((arr[i] > 0 && arr[i+1] > 0) || (arr[i] < 0 && arr[i + 1] < 0))
    {
         b = arr[i+1];
         a = arr[i];
    }

}
            System.Console.WriteLine($"{a} {b}");

// 7
// 1 -2 -2 3 -3 -3 4