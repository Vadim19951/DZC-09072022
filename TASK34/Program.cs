int[] array = new int[8];

int count = 0;

FillArray(array);
PrinArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
} 
Console.WriteLine("Колличество четных чисел в массиве равно " + count);


void PrinArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FillArray(int[]array)
{
for(int i = 0; i < array.Length; i++ )
{
     array[i] = new Random().Next(99, 1000);
}
}