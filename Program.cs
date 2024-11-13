namespace SortingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] a = { 1, 3, 5, 7 };
            //int[] b = { 2, 4, 6, 8, 10, 20 };
            //int[] c = new int[a.Length + b.Length];
            //Sort.Merge(a, b, c);
            //Console.WriteLine("after merging:");
            //Print(c);

            int[] arr = { 2, 1, 5, 40, -10};
            Print(arr);
            Sort.MergeSort(arr);
            Console.WriteLine("after arr is sorted using MergeSort:");
            Print(arr);
            int[] arr2 = { 2, 1, 5, 40, -10, 99, -100};
            Sort.MergeSort(0, arr2.Length - 1, arr2);
            Print(arr2);
        }

        public static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
