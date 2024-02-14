// Task2
// Given an array of integers. Print product of array elements.

// Дан массив целых чисел. Вывести произведение элементов массива

// Зарби элементҳои массивро дар шакли зер чоп кунед

int n = int.Parse(Console.ReadLine());
int [] arr = new int[n];
int sum = 1;
for (int i = 0; i < n; i++)
{
   arr[i] = Convert.ToInt32(Console.ReadLine());
   sum *= arr[i];
}

for (int i = 0; i < n - 1; i++)
{
        System.Console.Write($"{arr[i]} * ");

}
System.Console.WriteLine($"{arr[n - 1]} = {sum}");