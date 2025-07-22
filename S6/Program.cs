namespace S6
{
    internal class Program
    {
        // types of methods 
        // 1. class member function [static class]
        // 2. object member function [non-static class]
        // Employee => static print , Non-static Select
        //Employee.print
        //Employee Emp01 = new Employee();
        //Emp01.Select
        #region Methods
        public static void PrintShape(int Count = 5, string Pattern = ":(")
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Pattern);
            }
        }
        public static void Swap(int X,int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        public static void Swap(ref int X,ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        public static int SumArray(int[] Arr)
        {
            int Sum = 0;
            //Arr[0] = 100;
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
            //Arr[0] = 100;
            Arr = new int[] { 10, 20, 30, 40 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Array
            #region 1D Array
            #region Example 01
            //int[] Numbers;
            //Numbers = new int[3];

            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);


            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank);

            //for (int i = 0; i < 3; i++) 
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //foreach (int i in Numbers) 
            //{
            //    Console.WriteLine(i);
            //}


            #endregion
            #region Array Creation Ways
            //int[] Numbers01 = new int[3];
            //int[] Numbers02 =  new int[3] { 1, 2, 3} ;
            //int[] Numbers03 =  new int[] { 1, 2, 3} ;
            //int[] Numbers04 = { 1, 2, 3} ;
            #endregion

            #endregion
            #region 2D Array [Rectangular]

            //int[,] Marks = new int[2, 5] { { 100, 90, 30, 50, 40 }, { 20, 10, 68, 77, 80 } };
            //Marks[0, 0] = 100;
            //Marks[0, 1] = 90;
            //Marks[0, 2] = 40;
            //Marks[0, 3] = 80;
            //Marks[0, 4] = 60;
            //Marks[1, 0] = 99;
            //Marks[1, 1] = 80;
            //Marks[1, 2] = 44;
            //Marks[1, 3] = 40;
            //Marks[1, 4] = 98;

            //Console.WriteLine(Marks.Length);
            //Console.WriteLine(Marks.Rank);
            //Console.WriteLine(Marks.GetLength(0));
            //Console.WriteLine(Marks.GetLength(1));

            //int[,] Marks = new int[2, 5];

            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"the grades of student Number {i + 1}");
            //    for (int j = 0; j < Marks.GetLength(1); /*j++*/)
            //    {
            //        Console.Write($"Subject Number {j + 1} : ");
            //        bool IsParse = int.TryParse(Console.ReadLine(), out Marks[i, j]);
            //        if (IsParse)
            //            j++;
            //    }
            //    Console.WriteLine("===============================");
            //}
            //// print
            //Console.Clear();
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"the grades of student Number {i + 1}");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Subject Number {j + 1} : {Marks[i, j]}");

            //    }
            //    Console.WriteLine("===============================");
            //}
            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    Console.WriteLine(Marks[i / Marks.GetLength(1),i % Marks.GetLength(1)]);
            //}

            #endregion
            #region Jagged Array
            //int[][] JaggedArr = new int[3][];
            //JaggedArr[0] = new int[3] {1,2,3};
            //JaggedArr[1] = new int[2] {1,2};
            //JaggedArr[2] = new int[1] {1};

            ////JaggedArr[0][1] = 5;
            //for (int i = 0; i<JaggedArr.Length; i++)
            //{
            //    for (int j = 0; j < JaggedArr[i].Length; j++)
            //    {
            //        Console.Write($"{JaggedArr[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Array Methods
            //int[] Numbers = { 5, 3, 2, 4, 5 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //Console.WriteLine("After Sorting");
            //Array.Sort(Numbers);
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //Console.WriteLine("After Reversing");
            //Array.Reverse(Numbers);
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //Console.WriteLine("After Clearing");
            //Array.  Clear(Numbers,2,2);
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Console.WriteLine(Array.IndexOf(Numbers,5));
            //Console.WriteLine(Array.LastIndexOf(Numbers,5));
            //Console.WriteLine(Array.IndexOf(Numbers,4));

            //Array.Resize(ref Numbers, 10);


            #endregion
            #endregion
            #region Functions
            #region Functions Prototype
            //PrintShape(10,":(");
            //PrintShape(Pattern: ":(", Count: 10);

            //PrintShape(10,"123");
            //PrintShape(Pattern:"+L+");
            //PrintShape(Pattern:@"Welcomwe Mostafa \Hello Amr");
            //PrintShape(Pattern:@"/*\");

            #endregion
            #region Function Parameters [Value Type]
            #region Passing by Value

            //int A = 9;
            //int B = 4;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine("After Swaping");
            //Swap(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion
            #region Passing by Refrence
            //int A = 9;
            //int B = 4;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Console.WriteLine("After Swaping");
            //Swap(ref A,ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion
            #endregion
            #region Functions Parameters [Reference Type]
            #region Example 01
            #region Passing By Value
            //int[] Numbers = {1,2,3};

            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region Passing By Reference 
            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion

            #endregion
            #region Example 02
            #region Passing By Value
            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region Passing By Reference
            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #endregion
            #endregion
            #endregion

        }
    }
}
