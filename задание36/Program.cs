// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int SumValue (int[] array)
{
int sum = 0;
for(int i = 0; i< array.Length; i++ )
{

if (i%2!=0){
sum+=i;
}
else{
sum+=0;
}
}
return sum;
}

int result = SumValue(CreateRandomArray (lenght));
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {result}");