/*
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
PrintArray(array);*/

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;

}

int length = Prompt("Введите число");