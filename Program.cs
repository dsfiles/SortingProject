namespace SortingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 5, 4};
            Print(arr);
            int[] a = { 1, 3, 5, 7 };
            int[] b = { 2, 4, 6, 8 };
            int[] c = new int[a.Length + b.Length];
            Merge(a, b, c);
            Console.WriteLine("after merging:");
            Print(c);
        }

        static void Merge(int[] a, int[] b, int[] c) {
            int i = 0, j = 0, k = 0; // index i for a, j for b, k for c

            /* your code
            while( both a and b are not empty ){
                read the smaller number and store it in array c
            }*/
            while (i < a.Length && j < b.Length) {
                if (a[i] < b[j])
                {
                    c[k] = a[i];
                    i++;
                    k++;
                }
                else
                {
                    c[k] = b[j];
                    j++; 
                    k++;
                }
            }



            /*
            while( a is not empty){
                read all the numbes from a into c
            }

            while( b is not empty){
                read all the numbes from b into c
            }
            */
        }


        static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
