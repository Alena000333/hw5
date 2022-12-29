// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateRandomArray (int size)
{
int[] myArray = new int[size];
for(int i=0;i<size;i++)
{
myArray[i] = new Random().Next(100,1000);
}
return myArray;
}

void ShowArray (int[] array)
{
Console.WriteLine("Полученный массив ->:");
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i]+" ");
}
Console.WriteLine();
}
Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateRandomArray(lenght));

int CountPolValue (int[] array)
{
int count = 0;
for(int i = 0; i< array.Length; i++ )
{

if (array[i]%2==0){
count++;
}
else{
count+=0;
}
}
return count;
}

int result = CountPolValue(CreateRandomArray (lenght));
Console.WriteLine($"количество четных чисел = {result}");