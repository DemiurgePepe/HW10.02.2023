// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите n= ");
// int n = int.Parse(Console.ReadLine());
// if(n>999 || n<100)
// {
//     Console.WriteLine("Кривое число");
// }
// else
// {
//     Console.WriteLine(((n/10%10)));
// }

// // Решение преподователя 
// int promt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }


// int number = promt("Введите трехзначное число");
// if (number<100 || number>=1000)
// {
//     Console.WriteLine("Вы ввели не трехзначное число, повторите попытку");
//     return;
// }
// Console.WriteLine($"Введённое число '{number}'");
// int secondRank= number /10 %10;
// Console.WriteLine($"Вторая цифра'{secondRank}' ");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// void 

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int promt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int GetTHIRDNumber(int number)
// {
//     while (number>999)
//     {
//         number /=10;
//     }
//     return number%10;
// }
// bool Validate(int number)
// {
//     if(number<100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }
// int number=promt("Введите число= ");
// if(Validate(number))
// {
//     Console.WriteLine(GetTHIRDNumber(number));
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// string [] array= {"Нет такого дня","Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};

// Console.WriteLine("Введите день недели чтобы узнать является ли он выходным: ");
// int number = int.Parse(Console.ReadLine());
// int index = Array.IndexOf(array);

// if(num==6 || array[number]==7)
// {
//     Console.WriteLine("Выходной");
// }
// else
// {
//     Console.WriteLine("Будний день");
// }
// ### Сбился и не доконца понял как сделать задание, хотел решить через массив, но что то я упустил. Подскажите пожалуйста. 


// int promt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// bool isWeekend(int weekDay)
// {
//     if(weekDay>5)
//     {
//         return true;
//     }
//     return false;
// }
// bool validate(int number)
// {
//     if(number>0 && number<=7)
//     {
//         return true;
//     }
//     Console.WriteLine("В неделе всего 7 дней");
//     return false;
// }
// int weekDay = promt("Введите день недели: ");

// if (validate(weekDay))
// {
//     if(isWeekend(weekDay))
//     {
//         Console.WriteLine("Это выходной");
//     }
//     else
//     {
//         Console.WriteLine("Тяжёлые будни");
//     }
// }