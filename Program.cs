﻿using System;

namespace GregoryDoud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(PseudoRandom.GetInt());
            for(int idx = 0; idx < 10; idx++) {
                Console.WriteLine(PseudoRandom.GetInt(10));
            }
        }
    }
}
