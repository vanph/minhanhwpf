﻿// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// MICROSOFT LIMITED PUBLIC LICENSE version 1.1 (MS-LPL, http://go.microsoft.com/?linkid=9791213.)
//
//Copyright (C) Microsoft Corporation.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;

namespace Yield
{
    class Yield
    {
        public static class NumberList
        {
            // Create an array of integers.
            public static int[] ints = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };

            // Define a property that returns only the even numbers.
            public static IEnumerable<int> GetEven()
            {
                // Use yield to return the even numbers in the list.
                foreach (int i in ints)
                    if (i % 2 == 0)
                        yield return i;
            }

            // Define a property that returns only the even numbers.
            public static IEnumerable<int> GetOdd()
            {
                // Use yield to return only the odd numbers.
                foreach (int i in ints)
                    if (i % 2 == 1)
                        yield return i;
            }

           
            public static IEnumerable<int> GetUnreasonable()
            {
                // Use yield to return only the odd numbers.
                foreach (int i in ints)
                    if (i % int.MaxValue == 0)
                        yield return i;
            }
        }

        static void Main(string[] args)
        {
            LocalExtensionsTest.Test();
            //GalaxyClass.ShowGalaxies();
          
            //// Display the even numbers.
            //Console.WriteLine("Even numbers");
            //foreach (int i in NumberList.GetEven())
            //    Console.WriteLine(i);

            //// Display the odd numbers.
            //Console.WriteLine("Odd numbers");
            //foreach (int i in NumberList.GetOdd())
            //    Console.WriteLine(i);

            //// Display the odd numbers.
            //Console.WriteLine("Unreasonable numbers");
            //var unreasonableNumbers = NumberList.GetUnreasonable();
            //foreach (int i in unreasonableNumbers)
            //    Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}

