// Task9
// Given an integer array. Print all odd element from a to b.

// Дан целочисленный массив. Выведите все нечетные элементы от a до b.

// Хамаи элементхои токи массивро аз а то b чоп кунед.

int n = int.Parse(Console.ReadLine());
int [] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine("Write a number az kujo to kujora elementxoi toqsha girem : ");
int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine("Elementxoi toqi massiv :");
for (int i = a; i <= b; i++)
{
    if (arr[i]%2!=0)System.Console.Write($"{arr[i]}  ");
}

