using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main( string[] args )
        {
            var array = new int[5];

            for ( int i = 0; i < array.Length; i++ )
                array[i] = (i + 1) * (i + 1);

            foreach(var item in array)
                Console.WriteLine(item);
        }
    }
}
