using System;

public class Program
{
    public static void Main(string[] args)
    {
        //int[] arr = { 25, 885, 3, 43, 0, 24, 45 };
        //int len = arr.Length;
        //foreach (int i in arr)
        //{
        //    System.Console.Write(i + " ");
        //}

        //bubble sort
        //for (int i = 0; i < len - 1; i++)
        //{
        //    for (int j = 0; j < len - i - 1; j++)
        //    {
        //        if (arr[j] > arr[j + 1])
        //        {
        //            int tm = arr[j];
        //            arr[j] = arr[j + 1];
        //            arr[j + 1] = tm;
        //        }
        //    }
        //}

        //selection sort
        //int current_min;
        //int tmp;
        //int index =0;
        //for(int i = 0; i < len; i++)
        //{
        //    current_min = arr[i];
        //    for(int j = i; j < len; j++)
        //    {
        //        if (current_min > arr[j])
        //        {
        //            current_min = arr[j];
        //            index = j;
        //        }
        //    }
        //    tmp = arr[i];
        //    arr[i] = current_min;
        //    arr[index] = tmp;
        //}

        int[] arr = { 25, 885, 3, 43, 0, 24, 45 };
        int  n = arr.Length;
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }

        //shell sort
        //for (int gap = n / 2; gap > 0; gap /= 2)
        //{
        //    for (int i = gap; i < n; i += 1)
        //    {
        //        int temp = arr[i];
        //        int j;

        //        for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
        //            arr[j] = arr[j - gap];

        //        arr[j] = temp;
        //    }
        //}

        //heap sort 
        //static void Heapify(int[] arr, int n, int i)
        //{
        //    int max = i;
        //    int l = 2 * i + 1;
        //    int r = 2 * i + 2;

        //    if (l < n && arr[l] > arr[max])
        //    {
        //        max = l;
        //    }

        //    if (r < n && arr[r] > arr[max])
        //    {
        //        max = r;
        //    }

        //    if (max != i)
        //    {
        //        int temp = arr[i];
        //        arr[i] = arr[max];
        //        arr[max] = temp;
        //        Heapify(arr, n, max);
        //    }
        //}

        //static int[] Sort(int[] arr)
        //{
        //    int n = arr.Length;

        //    for (int i = n / 2; i >= 0; i--)
        //    {
        //        Heapify(arr, n, i);
        //    }

        //    for (int i = n - 1; i > 0; i--)
        //    {
        //        int temp = arr[i];
        //        arr[i] = arr[0];
        //        arr[0] = temp;
        //        Heapify(arr, i, 0);
        //    }
        //    return arr;
        //}
        //Sort(arr);


        //merge sort
//        using System;

//class Program
//    {
//        public static void Sort(int[] array)
//        {
//            if (array.Length < 2) return;
//            int mid = array.Length / 2;
//            int[] left = new int[mid];
//            int[] right = new int[array.Length - mid];

//            Array.Copy(array, 0, left, 0, mid);
//            Array.Copy(array, mid, right, 0, array.Length - mid);

//            Sort(left);
//            Sort(right);
//            Merge(array, left, right);
//        }

//        private static void Merge(int[] array, int[] left, int[] right)
//        {
//            int i = 0, j = 0, k = 0;

//            while (i < left.Length && j < right.Length)
//            {
//                if (left[i] <= right[j])
//                {
//                    array[k++] = left[i++];
//                }
//                else
//                {
//                    array[k++] = right[j++];
//                }
//            }

//            while (i < left.Length)
//            {
//                array[k++] = left[i++];
//            }

//            while (j < right.Length)
//            {
//                array[k++] = right[j++];
//            }
//        }

//        static void Main()
//        {
//            int[] array = { 38, 27, 43, 3, 9, 82, 10 };
//            Sort(array);
//            Console.WriteLine(string.Join(", ", array));
//        }
//    }



    //quick sort
    //        using System;
    //        using System.Collections.Generic;
    //        using System.Linq;
    //        using System.Text;

    //namespace Quick_Sort
    //{
    //    class Program
    //    {
    //        private static void Quick_Sort(int[] arr, int left, int right)
    //        {
    //            if (left < right)
    //            {
    //                int pivot = Partition(arr, left, right);

    //                if (pivot > 1)
    //                {
    //                    Quick_Sort(arr, left, pivot - 1);
    //                }
    //                if (pivot + 1 < right)
    //                {
    //                    Quick_Sort(arr, pivot + 1, right);
    //                }
    //            }
    //        }

    //        private static int Partition(int[] arr, int left, int right)
    //        {
    //            int pivot = arr[left];

    //            while (true)
    //            {
    //                while (arr[left] < pivot)
    //                {
    //                    left++;
    //                }

    //                while (arr[right] > pivot)
    //                {
    //                    right--;
    //                }

    //                if (left < right)
    //                {
    //                    if (arr[left] == arr[right]) return right;

    //                    int temp = arr[left];
    //                    arr[left] = arr[right];
    //                    arr[right] = temp;
    //                }
    //                else
    //                {
    //                    return right;
    //                }
    //            }
    //        }

    //        static void Main(string[] args)
    //        {
    //            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

    //            Console.WriteLine("Original array : ");
    //            foreach (var item in arr)
    //            {
    //                Console.Write(" " + item);
    //            }
    //            Console.WriteLine();

    //            // Call Quick Sort to sort the array
    //            Quick_Sort(arr, 0, arr.Length - 1);

    //            Console.WriteLine();
    //            Console.WriteLine("Sorted array : ");

    //            foreach (var item in arr)
    //            {
    //                Console.Write(" " + item);
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}




    System.Console.Write("\n");
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
    }
}