// Task8
// Given an array of integers. Element numbering starts at 0. Print indexes of odd elements.

// ан массив целых чисел. Нумерация элементов начинается с 0. Показать индексы
// все нечетные элементы. Вывести индексы всех нечетных элементов.

// Массиви ададҳо дода шудааст. Рақамгузории элементҳо аз 0 оғоз мешавад.
// Индексҳои ҳамаи элементҳои тоқро чоп кунед. Индексҳои ҳамаи элементҳои тоқа чоп кунед.

int n = int.Parse(Console.ReadLine());
int [] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine();
for (int i = 0; i < n; i++)
{
    if (arr[i]%2!=0)System.Console.WriteLine(i);
}