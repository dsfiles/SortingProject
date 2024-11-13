using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProject
{
    public class Sort
    {
        public static void Merge(int[] a, int[] b, int[] c)
        {
            int i = 0, j = 0, k = 0; // index i for a, j for b, k for c
            /* 
            while( both a and b are not empty ){
                read the smaller number and store it in array c
            }*/
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    c[k++] = a[i++];
                }
                else
                {
                    c[k++] = b[j++];
                }
            }
            /*
            while( a is not empty){
                read all the numbes from a into c
            } */
            while (i < a.Length)
            {
                c[k++] = a[i++];
            }
            /*
            while( b is not empty){
                read all the numbes from b into c
            } */
            while (j < b.Length)
            {
                c[k++] = b[j++];
            }
        }
    }
}
