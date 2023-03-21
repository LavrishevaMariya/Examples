// void Method1()
// {
//     Console.WriteLine("Автор- Мария ");
// }
// Method1();

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения ");
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "новый текст");

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// string Method4(int count, string text) //тип аргумента и имя аругмента
// {
//     int i = 0;
//     string result = string.Empty; //возвращаемое значение
    
//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result; //и возвращаем уже результат котрый нам нужен
// // }

// string Method4(int count, string text) //тип аргумента и имя аругмента
// {
//     string result = string.Empty; //возвращаемое значение
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result; //и возвращаем уже результат котрый нам нужен
// }
// string res =  Method4(10, "asf");
// Console.WriteLine(res); // тут мы этот результат уже выводим

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//     Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// работа с текстом 
// дан текст, все пробелы заменить на черточки, маленькие буквы к заменить на большие К, а большие С заменить на маленькие с.

// string text = "- Я думаю, -сказал князь, улыбаясь, - что "
//            +" ежели бы вас послали вместо нашего милого Винценгероде,"
//            +" вы бы взяли приступом согласие прусского короля."
//            +" Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012345
// s[3] // r

// string Replace(string text, char OldValue, char NewValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for(int i = 0; i < length; i++)
//     {
//         if(text[i] == OldValue) result = result + $"{NewValue}"; //нужно не забывать упоминать куда мы присваиваем определенное значение, которое сейчас получим
//         else result = result + $"{text[i]}"; // если аргумент text, то и обращаться нужно конечно же к text.
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '-');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'с' , 'С');
// Console.WriteLine(newText);


// int[] arr = {1,5,4,3,2,6,7,1,1};

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for( int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)  //чтобы уравновесить(?) значение где i+1, потом j даст общее кол-во элементов.
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;

//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array [minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);


int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for( int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)  //чтобы уравновесить(?) значение где i+1, потом j даст общее кол-во элементов.
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
        if(array[j] > array[maxPosition]) maxPosition = j;
            
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array [maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
