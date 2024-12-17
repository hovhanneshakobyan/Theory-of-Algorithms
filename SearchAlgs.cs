using System;

public class SearchAlgs
{
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 2, 4, 8, 12, 16, 18, 20, 22, 24, 26, 28, 30, 34, 36, 38 };
        Console.WriteLine(JumpSearch(arr, 26));
        Console.WriteLine(ExponentialSearch(arr, 18));
    }

    public static int InterpolationSearch(int[] arr, int searchable)
    {
        int l = 0;
        int h = arr.Length - 1;
        int pos = (int)Math.Floor(l + ((double)((searchable - arr[l]) * (h - l)) / (arr[h] - arr[l]))));

        while (l < h)
        {
            Console.WriteLine(pos + " : pos");
            Console.WriteLine("-> -> ->");
            Console.WriteLine(l + " " + h);

            if (arr[pos] == searchable)
            {
                return pos;
            }
            else if (arr[pos] > searchable)
            {
                Console.WriteLine(h + ": old h");
                h = pos;
                Console.WriteLine(h + ": new h");

                pos = (int)Math.Floor(l + ((double)((searchable - arr[l]) * (h - l)) / (arr[h] - arr[l])) - 1);
            }
            else
            {
                Console.WriteLine(l + ": old l");
                l = pos;
                Console.WriteLine(l + ": new l");
                pos = (int)Math.Floor(l + ((double)((searchable - arr[l]) * (h - l)) / (arr[h] - arr[l])) + 1);
            }
        }

        return -1;
    }

    public static int SquareDigits(int n)
    {
        string a = "";
        foreach (char ch in n.ToString())
        {
            a += ((ch - '0') * (ch - '0')).ToString();
        }
        return int.Parse(a);
    }

    public static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    public static int LinearSearch(int[] arr, int searchable)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == searchable)
            {
                return i;
            }
        }
        return -1;
    }

    public static int LinearSearchWithIndexes(int[] arr, int searchable, int start, int end)
    {
        for (int i = start; i < end; i++)
        {
            if (arr[i] == searchable)
            {
                return i;
            }
        }
        return -1;
    }

    public static int BinarySearch(int[] arr, int searchable)
    {
        int low = 0;
        int high = arr.Length - 1;
        int mid = (arr.Length - 1) / 2;

        while (true)
        {
            if (arr[mid] == searchable)
            {
                return mid;
            }
            else if (searchable > arr[mid])
            {
                low = mid;
                mid = (low + high) / 2;
            }
            else
            {
                high = mid;
                mid = (low + high) / 2;
            }
        }
    }

    public static int BinarySearchWithIndex(int[] arr, int high, int searchable)
    {
        int low = 0;
        int mid = high / 2;

        while (true)
        {
            if (arr[mid] == searchable)
            {
                return mid;
            }
            else if (searchable > arr[mid])
            {
                low = mid;
                mid = (low + high) / 2;
            }
            else
            {
                high = mid;
                mid = (low + high) / 2;
            }
        }
    }

    public static int TernarySearch(int[] arr, int searchable)
    {
        int l = 0;
        int r = arr.Length - 1;
        int mid1 = l + (r - l) / 3;
        int mid2 = r - (r - l) / 3;

        while (l < r)
        {
            if (arr[mid1] == searchable)
            {
                return mid1;
            }
            else if (arr[mid2] == searchable)
            {
                return mid2;
            }
            else if (searchable < arr[mid1])
            {
                r = mid1;
                mid1 = l + (r - l) / 3;
                mid2 = r - (r - l) / 3;
            }
            else if (searchable > arr[mid2])
            {
                l = mid2;
                mid1 = l + (r - l) / 3;
                mid2 = r - (r - l) / 3;
            }
            else
            {
                l = mid1;
                r = mid2;
                mid1 = l + (r - l) / 3;
                mid2 = r - (r - l) / 3;
            }
        }

        return -1;
    }

    public static int JumpSearch(int[] arr, int searchable)
    {
        int jumpSize = (int)Math.Floor(Math.Sqrt(arr.Length));
        int temp = 0;
        while (searchable > arr[jumpSize])
        {
            temp = jumpSize;
            jumpSize += jumpSize;
        }
        return LinearSearchWithIndexes(arr, searchable, temp, jumpSize);
    }

    public static int ExponentialSearch(int[] arr, int searchable)
    {
        int h = 0;

        if (arr[h] == searchable)
        {
            return h;
        }
        h = 1;
        while (h < arr.Length - 1 && arr[h] < searchable)
        {
            h = h * 2;
        }

        return Array.BinarySearch(arr, h / 2, Math.Min(h, arr.Length - 1), searchable);
    }
}
