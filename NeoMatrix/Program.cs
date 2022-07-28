using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NeoMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Matrix matrix;
            for (int i = 0; i < 60; i++)
            {
                matrix = new Matrix(i * 2);
                new Thread(matrix.Move).Start();
            }
            Console.ReadLine();
        }
    }
}
