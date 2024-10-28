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
        static void Heapify(int[] arr, int n, int i)
        {
            int max = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l] > arr[max])
            {
                max = l;
            }

            if (r < n && arr[r] > arr[max])
            {
                max = r;
            }

            if (max != i)
            {
                int temp = arr[i];
                arr[i] = arr[max];
                arr[max] = temp;
                Heapify(arr, n, max);
            }
        }

        static int[] Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[i];
                arr[i] = arr[0];
                arr[0] = temp;
                Heapify(arr, i, 0);
            }
            return arr;
        }
        Sort(arr);

        //
        //        using System;
        //        using System.Collections.Generic;

        //class Program
        //    {
        //        static void Main()
        //        {
        //            List<double> a = new List<double> { 2, 4, 3, 1, -6, 5, 8.7, 11, -7 };
        //            List<double> sortedArray = MergeSort(a);
        //            Console.WriteLine(string.Join(", ", sortedArray));
        //        }

        //        static List<double> MergeSort(List<double> arr)
        //        {
        //            int n = arr.Count;
        //            if (n <= 1)
        //            {
        //                return arr;
        //            }
        //            int mid = n / 2;
        //            List<double> left = MergeSort(arr.GetRange(0, mid));
        //            List<double> right = MergeSort(arr.GetRange(mid, n - mid));
        //            return Merge(left, right);
        //        }

        //        static List<double> Merge(List<double> left, List<double> right)
        //        {
        //            int i = 0, j = 0;
        //            List<double> arr = new List<double>();

        //            while (i < left.Count && j < right.Count)
        //            {
        //                if (left[i] < right[j])
        //                {
        //                    arr.Add(left[i]);
        //                    i++;
        //                }
        //                else
        //                {
        //                    arr.Add(right[j]);
        //                    j++;
        //                }
        //            }
        //            arr.AddRange(left.GetRange(i, left.Count - i));
        //            arr.AddRange(right.GetRange(j, right.Count - j));
        //            return arr;
        //        }
        //    }

//        using System;

//class Program
//    {
//        static int Partition(double[] arr, int l, int r)
//        {
//            int i = l;
//            int j = r;
//            double pointer = arr[(l + r) / 2];
//            while (i < j)
//            {
//                while (arr[i] < pointer)
//                {
//                    i++;
//                }
//                while (arr[j] > pointer)
//                {
//                    j--;
//                }
//                if (i >= j)
//                {
//                    break;
//                }
//                // Swap
//                double temp = arr[i];
//                arr[i] = arr[j];
//                arr[j] = temp;
//                i++;
//                j--;
//            }
//            return j;
//        }

//        static void Quick(double[] arr, int l, int r)
//        {
//            if (l < r)
//            {
//                int q = Partition(arr, l, r);
//                Quick(arr, l, q);
//                Quick(arr, q + 1, r);
//            }
//        }

//        static void Main()
//        {
//            double[] a = { 2, 4, 3, 1, -6, 5, 8.7, 11, -7 };
//            Quick(a, 0, a.Length - 1);
//            Console.WriteLine(string.Join(", ", a));
//        }
//    }




    System.Console.Write("\n");
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
    }
}