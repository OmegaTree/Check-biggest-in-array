using System;
using System.Diagnostics;
using System.Threading;

namespace Check_biggest_array
{
    class Program
    {
        static void Main(string[] args)
        {
            long[,] arr = new long[1001, 1001];
            Random rnd = new Random();
            Stopwatch stopWatch = new Stopwatch();
            long arrLength = 0;
            long row = 0;
            stopWatch.Start();
            for (int i = 1; i != 1001; i++)
            {
                Console.WriteLine("Array row: " + i);
                for (int n = 1; n != 1001; n++)
                {
                    arr[i, n] = rnd.Next() % 2;
                    if (arr[i, 1] == 0)
                    {
                        for (int zer = 1; zer != 1001; zer++)
                        {
                            arr[i, zer] = 0;
                        }
                    }
                }
            }
            stopWatch.Stop();
            Console.WriteLine("Array generation took: " + stopWatch.ElapsedMilliseconds.ToString() + " milliseconds");
            for (int number = 1; number != 1001; number++)
            {
                string sArr = "";
                for (int n = 1; n != 1001; n++)
                {
                    sArr += arr[number, n] + " ";
                }
                //Console.WriteLine(sArr);
            }
            stopWatch.Reset();
            stopWatch.Start();
            for (int number = 1; number != 101; number++)
            {
                string arrString = "";
                long rowNumber = 0;
                long rowLength = 0;
                for (int n = 1; n != 1001; n++)
                {
                    arrString = arr[number, n].ToString();
                    rowNumber += long.Parse(arrString);
                    rowLength = rowNumber;
                    if (rowLength > arrLength)
                    {
                        arrLength = rowLength;
                        row = number;
                    }
                }
            }
            stopWatch.Stop();
            Console.WriteLine("The longest row up to 100 is row:" + row + " with " + arrLength + " in length");
            Console.WriteLine("Time to check: " + stopWatch.ElapsedMilliseconds.ToString() + "milliseconds");
            stopWatch.Reset();
            stopWatch.Start();
            for (int number = 1; number != 501; number++)
            {
                string arrString = "";
                long rowNumber = 0;
                long rowLength = 0;
                for (int n = 1; n != 1001; n++)
                {
                    arrString = arr[number, n].ToString();
                    rowNumber += long.Parse(arrString);
                    rowLength = rowNumber;
                    if (rowLength > arrLength)
                    {
                        arrLength = rowLength;
                        row = number;
                    }
                }
            }
            stopWatch.Stop();
            Console.WriteLine("The longest row up to 500 is row:" + row + " with " + arrLength + " in length");
            Console.WriteLine("Time to check: " + stopWatch.ElapsedMilliseconds.ToString() + "milliseconds");
            stopWatch.Reset();
            stopWatch.Start();
            for (int number = 1; number != 1001; number++)
            {
                string arrString = "";
                long rowNumber = 0;
                long rowLength = 0;
                for (int n = 1; n != 1001; n++)
                {
                    arrString = arr[number, n].ToString();
                    rowNumber += long.Parse(arrString);
                    rowLength = rowNumber;
                    if (rowLength > arrLength)
                    {
                        arrLength = rowLength;
                        row = number;
                    }
                }
            }
            stopWatch.Stop();
            Console.WriteLine("The longest row in the array is row: " + row + " with " + arrLength + " in length");
            Console.WriteLine("Time to check: " + stopWatch.ElapsedMilliseconds.ToString() + "milliseconds");
        }
    }
}
