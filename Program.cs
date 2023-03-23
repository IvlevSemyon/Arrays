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
            int count = int.Parse( Console.ReadLine() );

            Console.WriteLine();

            //int[] array = EvenArray.GetFirstEvenNumbersForOneLine( count );
            var array = new int[count];

            FirstStep.SquareArray( ref array );

            foreach(var item in array)
                Console.WriteLine(item);
        }
    }
}
