
int[] array = new int[10];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
    
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while(index < length)
    {
        Console.Write(collection[index]);
        index++;
    }

}

FillArray(array);
PrintArray(array);