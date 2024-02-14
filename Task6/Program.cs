// Task6
// Given an array. Determine how many elements in this array that are strictly greater than both of their neighbors.

// Дан массив. Определите, сколько элементов в этом массиве строго больше обоих своих соседей .

// Массив дода мешавад. Муайян кунед, ки чанд элементи ин массив аз ҳарду ҳамсояаш бузургтар аст.

int n = int.Parse(Console.ReadLine());
int [] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int cnt = 0;
for (int i = 1; i < n - 1; i++)
{
    if (arr[i] > arr[i+1] || arr[i] > arr[i - 1])
    {
        cnt++;
    }
}
System.Console.WriteLine();
System.Console.WriteLine(cnt);