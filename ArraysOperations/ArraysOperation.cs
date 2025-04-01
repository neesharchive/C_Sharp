using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOperations
{

    internal class ArraysOperation
    {

        static void MatrixMult(int[,] a, int[,] b)
        {
            int rowspan1 = a.GetLength(0);
            int colspan1 = a.GetLength(1);
            int rowspan2 = b.GetLength(0);
            int colspan2 = b.GetLength(1);

            if (colspan1 != rowspan2)
            {
                Console.WriteLine("Matrix multiplication not possible: column count of A must match row count of B.");
                return;
            }

            int[,] result = new int[rowspan1, colspan2];

            for (int i = 0; i < rowspan1; i++)
            {
                for (int j = 0; j < colspan2; j++)
                {
                    for (int k = 0; k < colspan1; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            // Print matrix nicely
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void getelements(int[] a)
        {
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
        static void getelements(int[,] a)
        {
            foreach(int i in a)
            {
                Console.WriteLine($"{i}");
            }
        }
        static void getelements(int[][] a)
        {
            foreach (int[] i in a)
            {
                foreach(int j in i)
                {
                    Console.WriteLine($"{j} ");

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            Console.WriteLine("This is a normal 1D array");
            Console.WriteLine("with length= "+array1.Length);
            getelements(array1);


            int[,] twoDarr = new int[3, 4]
            { {  1, 2, 3,4 }, {  2, 3, 4,5 }, {3,4,5,6}};
            Console.WriteLine("\nThis is a 2D array:\n");
            getelements(twoDarr);
            
            int[][]threeDJacked = new int[3][];
            threeDJacked[0] = new int[] { 1 };
            threeDJacked[1] = new int[]{ 2,3};
            threeDJacked[2] = new int[]{ 3,4,5};

            Console.WriteLine("\nThis is a jagged array\n");
            getelements(threeDJacked);















            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine();
            Array.Reverse(arr);

            getelements(arr);

            int[,] a = new int[,]{ {1,2 },{ 2, 3 } };
            int[,] b= new int[,] { { 1,2 },{2,3 } };

            MatrixMult(a, b); 
            



            Console.Read();







        }
    }
}
