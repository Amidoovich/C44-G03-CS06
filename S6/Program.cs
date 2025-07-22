using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

namespace S6
{
    internal class Program
    {

        #region Methods
        public static void IncrementVriableBy10(int Num1)
        {
            Num1 += 10;
        }
        public static void IncrementVriableBy10(ref int Num1)
        {
            Num1 += 10;
        }
        public static int SumArray(int[] Arr)
        {
            int Sum = 0;
            Arr = new int[] {10,20,30,40};
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        public static int SumArray(ref int[] Arr)
        {
            int Sum = 0;
            Arr = new int[] { 10, 20, 30, 40 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        public static void SumSub(int Num1, int Num2,out int Sum, out int Sub)
        {
            Sum = Num1 + Num2;
            Sub = Num1 - Num2;
        }
        public static int SumOfIndividualDigitsOfNumber(int Num)
        {
            int Sum = 0;
            while (Num != 0)
            {
                Sum += (Num % 10);
                Num /= 10;
            }
            return Sum;
           }
        public static bool IsPrime(int Num)
        {
            if (Num < 2)
                return false;
            for (int i = 2; i < Num; i++)
            {
                if (Num % i == 0)
                    return false;
            }
            return true;

        }
        public static void MinMaxArray(ref int[] Arr , ref int Max , ref int min )
        {
            if(Arr.Length == 0)
                return;
            else
            {
                Max = Arr[0];
                min = Arr[0];
                for (int i = 0; i<Arr.Length;i++)
                {
                    if (Max < Arr[i])
                        Max = Arr[i];
                    if(min > Arr[i])
                        min = Arr[i];
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {

            #region Q1 Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            #region Passing by value
            // in this example we pass a copy of value of variable Then the increment ocuured on the variable in stak fram in the method  not on A 
            //int A = 20;
            //IncrementVriableBy10(A);
            //Console.WriteLine(A);
            #endregion
            #region passing by reference  
            // in this example we pass the A By Ref not the copy of the the increment ocuured on A 
            //int A = 20;
            //IncrementVriableBy10(ref A);
            //Console.WriteLine(A);
            #endregion

            #endregion
            #region Q2 Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //int[] Numbers = { 1, 2, 3 };
            #region passing By Value
            // in this example we pass the address of Numbers Array then we make array Arr to point on the same object that Number array point it when change that the Arr to point in another object the Number doesn't point on it then the method give the sum of new object but the values in Number array doesn't change
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region Passing By Reference
            // in this example we pass the address of Numbers Array then we change that the numbers Array to point on the new object then the method give the sum of new object and values in Number array changed
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #endregion
            #region Q3 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //bool IsParse1,IsParse2;
            //int Num1,Num2;
            //do
            //{
            //    Console.Write("please enter the Number the first number : ");
            //    IsParse1 = int.TryParse(Console.ReadLine(), out Num1);
            //    Console.Write("please enter the Number the Second number : ");
            //    IsParse2 = int.TryParse(Console.ReadLine(), out Num2);
            //} while (!IsParse1 || !IsParse2);
            //SumSub(Num1, Num2, out int Sum, out int Sub);
            //Console.WriteLine($"the sum is {Sum} and the sub is {Sub}");
            #endregion
            #region Q4 Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //bool IsParse;
            //int Num;
            //do
            //{
            //    Console.Write("please enter the Number : ");
            //    IsParse = int.TryParse(Console.ReadLine(), out Num);

            //} while (!IsParse);
            //Console.WriteLine($"The sum of the digits of the number {Num} is: {SumOfIndividualDigitsOfNumber(Num)}");

            #endregion
            #region Q5 Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //bool IsParse;
            //int Num;
            //do
            //{
            //    Console.Write("please enter the Number : ");
            //    IsParse = int.TryParse(Console.ReadLine(), out Num);

            //} while (!IsParse);
            //Console.WriteLine(IsPrime(Num));
            #endregion
            #region Q6 Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] Numbers = {1,2,3,7,5,6,9,8};
            //int Max = 0,Min = 0;
            //MinMaxArray(ref Numbers, ref Max,ref Min);
            //Console.WriteLine($"the max value is {Max}");
            //Console.WriteLine($"the min value is {Min}");
            #endregion 


        }
    }
}
