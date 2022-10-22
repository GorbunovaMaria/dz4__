/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*
double FindDegree (double a ,double b)
{
return Math.Pow(a, b);                  
}
Console.WriteLine("Введите число");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень");
double b = Convert.ToDouble(Console.ReadLine());


double result = FindDegree(a,b);
Console.WriteLine($"число {a} в степени {b} -> {result}");*/



/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
/*
int[] CreateRandomArray(int size)
{
    int [] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(size + 1);
    }
    return myArray;
}

void ShowArray (int[]array)    //покажи массив
{
    Console.WriteLine("Получившийся массив ->");
    for (int i = 0; i<array.Length; i++)
    {
    Console.Write(array[i]+ " " );
    }      
}  

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(a);
ShowArray (myArray);*/

 /* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
/*
 int SumNumber(int numberN)
 {  
 int stringN = Convert.ToString(numberN).Length;
 int dig = 0;
 int result = 0;

 for (int i = 0; i < stringN; i++)
 {
 dig = numberN % 10;
 result = result + dig;
 
 numberN = numberN / 10;
}
 return result;
}
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(numberN);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}");