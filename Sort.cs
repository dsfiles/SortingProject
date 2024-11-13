using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProject
{
    public class Sort
    {

        public static void QuickSort(int[] arr)
        {
            if (arr.Length > 1) // continues to sort only if the array size is 2 or above
            {
                // Creates a temporary array to store rearranged numbers using the pivot
                int[] temp = new int[arr.Length];

                // Chooses the last number in arr as the pivot
                int pivot = arr[arr.Length - 1];

                int i = 0, l = 0, r = arr.Length - 1;

                while (i < arr.Length)
                {
                    // Compares each number in arr to the pivot. If the number is greater or equal to the pivot,
                    // place the number in array temp starting from the last position. The pivot will be placed
                    // at the correct position.
                    if (arr[i] >= pivot)
                    {
                        temp[r--] = arr[i++];
                    }
                    else
                    // Places the numbers that are less than the pivot in the first positition and continues
                    // untill the position just before the pivot.
                    {
                        temp[l++] = arr[i++];
                    }
                }
                //Program.Print(temp);

                // Array x = [ 5, 1, 2, 4, 6, 3 ], array temp: [ 1, 2, 3, 6, 4, 5]. Index l becomes the index of pivot
                // after the while loop, l is also equal to the length of array with numbers that are less than the pivot

                // Creates an array to store the numbers less than the pivot
                int p = l; // p is the pivot position
                int[] lower = new int[p];

                // Creates an array to store the numbers greater than the pivot, and the pivot itself
                int[] higher = new int[arr.Length - p - 1];

                for (int j = 0; j < p; j++)
                {
                    lower[j] = temp[j];
                }

                for (int j = p + 1; j < arr.Length; j++)
                {
                    higher[j - p - 1] = temp[j];
                }

                QuickSort(lower); // Sorts array lower recursively
                QuickSort(higher); // Sorts array higher recursively

                // Combines arrays lower, pivot, and higher into the final sorted array
                for (int j = 0; j < lower.Length; j++)
                {
                    arr[j] = lower[j];
                }
                for (int j = higher.Length - 1; j >= 0; j--)
                {
                    arr[arr.Length - higher.Length + j] = higher[j];
                }
                arr[p] = pivot; // Places the pivot back to the correct position in arr
            }
        }
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
        public static void MergeSort2(int[] arr)
        {
            MergeSort(0, arr.Length-1, arr);
        }
        public static void MergeSort(int left, int right, int[] arr)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(left, mid, arr);
                MergeSort(mid + 1, right, arr);

                Merge(left, mid, right, arr);
            }

        }
        public static void Merge(int left, int mid, int right, int[] c)
        {
            int[] m = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0; // i for left half, j for right half, k for array m
            while (i <= mid & j <= right)  {
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
