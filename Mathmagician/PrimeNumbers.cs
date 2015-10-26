﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class PrimeNumbers : NaturalNumbers
    {
        public PrimeNumbers()
        {
            first = 2;
            increment = 2;
        }

        public bool isPrime(int x)
        {
            for (int i = 2; i < (x / 2); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        new public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());

            if (output.Count < length)
            {
                output.Add(3);
            }

            int counter = 5;
            while (output.Count < length)
            {
                if (isPrime(counter))
                {
                    output.Add(counter);
                    counter += 2;
                }
                else
                {
                    counter += 2;
                }
            }
            return output.ToArray();
        }
    }
}