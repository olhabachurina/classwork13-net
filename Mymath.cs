﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork13_net
{
    public delegate void MyDelegate(int n1, int n2);
    internal class MyMath
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public MyMath()
        {
        }
        public void Sum(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        public void Min(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }
        public void Mul(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }
    }
}