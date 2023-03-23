using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class EvenArray
    {
        public static int[] GetFirstEvenNumbers( int count )
        {
            int[] array = new int[count];
            for ( int i = 0; i < count; i++ )
            {
                array[i] = ( i + 1 ) * 2;
            }
            return array;
        }

        public static int[] GetFirstEvenNumbersForOneLine( int count ) // я в абалдуе с этого метода решения)))
        {
            return Enumerable.Range( 1, count ).Select( x => x * 2 ).ToArray(); // до LINQ ещё не дошел и методов расширения
        }
    }
}
