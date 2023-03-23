using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class FirstStep
    {
        internal static void SquareArray( ref int[] array )
        {
            for ( int i = 0; i < array.Length; i++ )
                array[i] = ( i + 1 ) * ( i + 1 );
        }
    }
}
