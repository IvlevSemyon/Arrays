using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class IndexMaxValue
    {
        public static int MaxIndex( double[] array )
        {
            int maxIndex = 0;
            if ( array.Length != 0 )
            {
                var maxValue = array.Min();
                for ( int i = 0; i < array.Length; i++ )
                {
                    if ( array[i] > maxValue )
                    {
                        maxIndex = i;
                        maxValue = array[i];
                    }
                }
                return maxIndex;
            }
            else
                return -1;
        }
    }
}
