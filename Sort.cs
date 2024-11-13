using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProject
{
    public class Sort
    {
        public static void MergeSort(int[] arr)
        {
            /*
             * 1. if the size of arr is two or greater split arr into two sub arrays, 
             *    store the left half in array a, store the right half in array b
             * 2. recursively sort array a
             * 3. recursively sort array b
             * 4. merge a and b into arr
             */

            // your code for steps 1 & 2in
            if (arr.Length > 1)
            {
                int[] a = new int[arr.Length / 2];
                int[] b = new int[arr.Length - arr.Length / 2];
                // your code here to populate a and b
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = arr[i];
                }
                for (int i = a.Length; i < arr.Length; i++)
                {
                    b[i-a.Length] = arr[i];
                }
                //Program.Print(a);
                //Program.Print(b);
                MergeSort(a);
                MergeSort(b);

                Merge(a, b, arr);
            }
        }
        public static void Merge(int[] c, int left, int mid, int right)
        {
            int[] m = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0; // i for left half, j for right half, k for array m
            while (i <= mid & j <= right)
            {
                if (c[i] < c[j])
                    m[k++] = c[i++];
                else
                    m[k++] = c[j++];
            }
            while (i <= mid)
                m[k++] = c[i++];

            while (j <= right)
                m[k++] = c[j++];

            for (int l = 0; l < m.Length; l++)
            {
                c[left + l] = m[l];
            }
        }
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
