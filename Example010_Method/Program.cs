// int[] array= {1, 2, 31, 18, 41, 15, 6, 17, 18}; 

// int n = array.Length;
// int find = 18;

// int index = 0;

// while(index < n)
// {

//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     // index = index +1;
//     index++;
// }

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0; //тут как за индекс выступило
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find )
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //создали новую позицию, чтобы сюда можно было добавить значение
    while( index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}



int[] array = new int[10];

FillArray(array); //тут как бы дали значения в массив, какие-то числа
array[4] = 4;
array[6] = 15;//Тут просто ввели новые значения от себя и это будут цифры под определенным индексом, который так же вписали в []

PrintArray(array); //тут эти числа распечатывваем 
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);