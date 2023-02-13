// int[] array1={1,2,5,4,7,12,14};
// int n= array1.Length;
// int index = 0;
// int find= int.Parse(Console.ReadLine());
// while (index < n)
// {
//     if(array1[index]==find)
//     {
//     Console.WriteLine(index);
//     }
//     index++;
// }
void FillArray(int[]collection)
{
    int length= collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index]= new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index= 0;
    int position=0;
    while(index<count)
    {
        
        if(collection[index]==find)
        {
            position=index;
            break;
        }
        index++;

    }
    return position;
}
int[]array =new int[10];
FillArray(array);
array[4]=8;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,8);
Console.WriteLine(pos);
