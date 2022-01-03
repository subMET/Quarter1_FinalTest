void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] CreateRandomArray(int n, int min, int max)
{
    int[] resultArray = new int[n];
    for (int i = 0; i < n; i++)
    {
        resultArray[i] = new Random().Next(min, max);
    }
    return resultArray;
}

int[] EvenPartOfArray(int[] sourceArray)
{
    int length = sourceArray.Length;
    int[] bufferArray = new int[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (sourceArray[i]%2 == 0) 
        {
            bufferArray[count] = sourceArray[i];
            count++;
        }
    }
    if (count == 0)
    {
        int[] emptyArray = new int[0];
        return emptyArray;
    }
    int[] resultArray = new int[count];
    for (int i = 0; i < count; i++)
    {
        resultArray[i] = bufferArray[i];
    }
    return resultArray;
} 

int[] randomArray = CreateRandomArray(10,1,8);
PrintArray(randomArray);
int[] evenArray = EvenPartOfArray(randomArray);
PrintArray(evenArray);