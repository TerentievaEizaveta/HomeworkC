//Домашняя работа 2

/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.*/
 
 /*
 Console.Clear();
 Console.Write("Input a number ");
 int num=Convert.ToInt32(Console.ReadLine());
 if (num < 99 || num >1000) Console.Write("Error: three-digit number was expected");

 int CutNumber(int num)
 {
    int dec=(num%100)/10;
    return dec;
 }

Console.Write(CutNumber(num));
*/

/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.*/

// ПЕРВЫЙ СПОСОБ РЕШЕНИЯ (Математическая функция)
/*
Console.Clear();
Console.Write("Input a number ");
int num=Convert.ToInt32(Console.ReadLine());
int count=0;

int NumberOfDigits(int num)
{    
    while  (num > 0)
    {
        num=num/10;
        count++;
    }
    return count;
}

int CutNum(int num)
{
    NumberOfDigits(num);
    int ThirdDigit = (num/Convert.ToInt32 (Math.Pow(10,count-3))) %10;
    return ThirdDigit;
}

if (num > 99) Console.WriteLine(CutNum(num));
else Console.WriteLine("There is no third digit");

*/

// ВТОРОЙ СПОСОБ   (Использование массива)
/*
Console.Clear();
Console.Write("Input a number ");
int num=Convert.ToInt32(Console.ReadLine());
int count=0;
int i=0;

int Array(int num)
{
     int num1=num; // иначе цикл вернет 0 в num 
     while  (num1 > 0)
    {
        num1=num1/10;
        count++;
    }
    if (count > 2)
    {   
        int length=count;
        int [] numbers =new int[length];
        while (i<length)
        {
            numbers[length-i-1]= num%10;
            num=num/10;
            i=i+1;   
        }
        return numbers[2];
    }
    else return -1;
}
if (Array(num)==-1) Console.WriteLine("There is no third digit");
else Console.WriteLine(Array(num));
*/ 

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
*/
/*
Console.Clear();
Console.Write("Enter the number of the day of the week ");
int num=Convert.ToInt32(Console.ReadLine());
int Day(int num)
{
    if (num >0 && num<6) return 1;
    else if (num ==6 || num ==7) return 2;
    else return -1;
}
if (Day(num) ==1) Console.WriteLine("No");
if (Day(num) ==-1) Console.WriteLine("Error: incorrect input");
if (Day(num) ==2) Console.WriteLine("Yes");
*/