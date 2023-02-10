//int N;
//Console.WriteLine("Введите N= ");
//N = int.Parse(Console.ReadLine());
//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
  //  3 -> Среда 
    // 5 -> Пятница

//int index;
//index = -N;

//while(index<=N)
//{
//    Console.WriteLine(index);
//    index=index+1;
//}

//Console.WriteLine("End");
//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
//    4 -> 16 
 //   -3 -> 9 
 //   -7 -> 49

// Console.WriteLine("Введите N= ");
// double N = double.Parse(Console.ReadLine());
// Console.WriteLine(N*N);


// 4. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//     3 -> Среда 
//     5 -> Пятница

Console.WriteLine("Введите N= ");
int N = int.Parse(Console.ReadLine());
if(N==1)
{
    Console.WriteLine("Понедельник");
}
if(N==2)
{
    Console.WriteLine("Вторник");
}
if(N==3)
{
    Console.WriteLine("Среда");
}
if(N==4)
{
    Console.WriteLine("Четверг");
}
if(N==5)
{
    Console.WriteLine("Пятница");
}
if(N==6)
{
    Console.WriteLine("Суббота");
}
if(N==7)
{
    Console.WriteLine("Вокресенье");
}
if(N>8)
{
    Console.WriteLine("Число кривое");
}
