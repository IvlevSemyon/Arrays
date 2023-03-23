using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Count
    {
        public static int GetElementCount( int[] items, int itemToCount )
        {
            var result = 0;
            for ( int i = 0; i < items.Length; i++ )
            {
                if ( items[i] == itemToCount )
                    result++;
            }
            return result;
        }
    }
}
