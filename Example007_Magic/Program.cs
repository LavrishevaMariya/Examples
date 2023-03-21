// Console.Clear();
// //Console.SetCursorPosition(10, 4);
// //Console.WriteLine("+");

// int xa = 30, ya = 1,
//     xb = 1, yb = 30,
//     xc = 80, yc = 30;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");


// int x = xa, y = xb;

// int count = 0;

// while (count < 10000)
// {
//     int what = new Random().Next(0, 3); //[0,3) 0,1,2
//     if (what == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2; 
//     }

//     if (what == 1)
//     {
//         x = (x + xb) / 2;
    //     y = (y + yb) / 2;
    // }

    // if (what == 2)
    // {
    //     x = (x + xc) / 2;
    //     y = (y + yc) / 2;
    // }

    // Console.SetCursorPosition(x, y);
    // Console.WriteLine("+");
    // count++;
// }


// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10,100); // создание рандомной переменной в диапазоне 
// int a1 = number / 10; //нашли первую цифру в числе (убираем вторую цифру в числе)
// int a2 = number % 10; // нашли вторую цифру в числе (убираем первую цифру в числе )
// if(a1>a2)
// {
//     Console.WriteLine("Первая цифра в числе" + number + " больше - "+ a1);
// }
// else
// {
//     Console.WriteLine("Вторая цифра в числе " + number + " больше - " +a2);
// }

