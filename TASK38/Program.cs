int[] array = new int[8];

double result = 0;

FillArray(array);
PrinArray(array);

Console.WriteLine();

double maxNumber = array[0];
double minNumber = array[0];

for(int i = 0; i < array.Length; i++)
{
    if(array[i] < minNumber)
    {
        minNumber = array[i];
    }
  if(array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
}

result = maxNumber - minNumber;

Console.WriteLine("Получили минимальное число, равное: " + minNumber);
Console.WriteLine("Получили максимальное число, равное: " + maxNumber);
Console.WriteLine();
Console.WriteLine("Разница между ними составляет: " + result);

void PrinArray(int[]array)
{  
    Console.Write("Получили заданный массив: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

void FillArray(int[]array)



{
for(int i = 0; i < array.Length; i++ )
{
     array[i] = new Random().Next(1, 10);
}
}

