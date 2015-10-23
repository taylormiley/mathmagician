using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Mathmagician
{
    public class NaturalNumbers
    {
        protected int first;
        protected int increment;

        public NaturalNumbers()
        {
            first = 1;
            increment = 1;
        }

        public virtual int GetNext(int x)
        {
            return x+increment;
        }

        public virtual int GetFirst()
        {
            return first;
        }

        public int[] GetSequence()
        {
            return GetSequence(10);
        }

        public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }

        public string ToString(int[] array)
        {
            /*
            string output = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array.Last())
                {
                    output += array[i].ToString();
                } else
                {
                    output += array[i].ToString() + " ";
                }
                
                //output += array[i].ToString() + " ";
            }*/
            string output = String.Join(" ", array);
            return output;
        }
    }
}
