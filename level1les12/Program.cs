using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] UFO(int N, int[] data, bool octal)
        {
            int[] Not = { 0, 0 };
            foreach (int i in data)
            {
                if (i < 0)
                {
                    Console.WriteLine("Initial conditions is not correct");
                    return Not;
                }
             
            }
            int b,ost,N10;
            N10 =0;
            int[] UFOresult = new int[data.Length];
            if (octal)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    while (data[i] > 0)
                    {
                        b = (int)Math.Log10(data[i]);
                        ost = data[i] / (int)Math.Pow(10, b);
                        N10 = N10 + ost * (int)Math.Pow(8, (int)Math.Log10(data[i]));
                        data[i] = data[i] - ost * (int)Math.Pow(10, (int)Math.Log10(data[i]));
                        UFOresult[i] = N10;
                        //Console.WriteLine(ost + "=число разряда " + +N10 + " " + data[i]);
                    }
                    N10 = 0;
                    //Console.WriteLine(" ");
                }
            }

            if (!octal)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    //string dataToString = Convert.ToString(0xFDA1, 10);
                    //int g = Convert.ToInt32(dataToString);
                    //if (g != data[i]) UFOresult[i] = Convert.ToInt32(dataToString);
                    //else
                    // {
                    while (data[i] > 0)
                    {
                        b = (int)Math.Log10(data[i]);
                        ost = data[i] / (int)Math.Pow(10, b);
                        N10 = N10 + ost * (int)Math.Pow(16, (int)Math.Log10(data[i]));
                        data[i] = data[i] - ost * (int)Math.Pow(10, (int)Math.Log10(data[i]));
                        UFOresult[i] = N10;
                       // Console.WriteLine(ost + "=число разряда " + +N10 + " " + data[i]);
                    }
                    N10 = 0;
                    //Console.WriteLine(" ");
                    //}
                }

            }
            return UFOresult;
        }

        //static void Main(string[] args)
        //{


        //    //int data1 = 0xFDA1;
        //    //double c = Math.Log10(data1);
        //    //string s = Convert.ToString(data1+ " "+c);
        //    //Console.WriteLine(s);

        //    int[] data = { 0, 1777 };
        //    bool octal = false;
        //    int[] UFOresult = UFO(data.Length, data, !octal);
        //    foreach (int c in UFOresult) Console.Write(c + " ");


        //}
    }
}
