int[] array = new int[8];

int sum = 0;

FillArray(array);
PrinArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0)
    {
        sum = sum + array[i];
    }
} 
Console.WriteLine();
Console.WriteLine("Сумма чисел на нечетных позициях в массиве равна " + sum);


void PrinArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FillArray(int[]array)