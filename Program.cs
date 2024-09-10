using System;

public class Program
{
    public static void Main(string[] args)
    {
        //2 for loop-erov , depq erb arden isk dasavorvaca
        int[] arr = { 2, 3, 5, 6, 9 };
        //int[] arr = { 5, 9, 3, 2, 6 };
        int len = arr.Length;
        int temp;
        foreach (int a in arr)
        {
            System.Console.WriteLine(a);
        }
        for (int i = 0; i < len - 1; i++)
        {
            if (arr[i] > arr[++i])
            {
                break;
            }
            return;
        }


        for (int i = 1; i < len; i++)
        {
            temp = arr[i];

            int j;

            for (j = i - 1; j >= 0 && arr[j] > temp; j--)
            {
                arr[j + 1] = arr[j];

            }
            arr[j + 1] = temp;

        }
        foreach (int a in arr)
        {
            System.Console.WriteLine(a);
        }

        //while loop-ov
        //int[] arr = { 5, 9, 3, 2, 6 };
        //int len = arr.Length;

        //for (int i = 1; i < len; i++)
        //{
        //    int temp = arr[i];
        //    int j = i - 1;
        //    while (j >= 0 && arr[j] > temp)
        //    {
        //        arr[j + 1] = arr[j];
        //        j--;
        //    }
        //    arr[j + 1] = temp;
        //}

        //foreach (int a in arr)
        //{
        //    System.Console.WriteLine(a);
        //}

    }
}


