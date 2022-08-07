/* TASK1 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

 double Degree (double x, double y)
 {
   double degree = 1;
   for(int i=0; i<y; i++)
         degree = degree*x;
   
    return degree;
   }
   

Console.Write("Enter the positive number: ");
double Number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the degree: ");
double Number2 = Convert.ToDouble(Console.ReadLine());
double ans = Degree(Number1, Number2);
Console.Write($"{Number1} ^ {Number2} = {ans} ");*/

/* TASK2 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int NumberSum(int x) 
{
   int result = 0, ost=0;
   while (x!=0)
   {
      ost = x%10;
      x = x/10;
      result = result+ost;
   }
   return result;
}

Console.Write("Enter the positive number: ");
int x = Convert.ToInt32(Console.ReadLine());
int res = NumberSum(x);
Console.Write($"sum = {res} ");*/

/* TASK3 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */

 int [] Array = new int[8];
void PrintArray (int [] array)
{
   int count = array.Length;
   for (int i = 0; i < count; i++)
   {
      Console.Write("Enter the positive number: ");
      int a = Convert.ToInt32(Console.ReadLine());
      
   }
   Console.Write( "$ array[count] ");
}
   PrintArray(Array);
  
 