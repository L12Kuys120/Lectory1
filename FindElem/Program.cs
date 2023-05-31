// See https://aka.ms/new-console-template for more information
int FindElem(int[] collection, int find)
{
    int length = collection.Length;
    int index = 0;
    int position = -1;

    while(index < length)
    {
        if(collection[index] == find) 
        {
            position = index;
            break;
        }
    }
}
