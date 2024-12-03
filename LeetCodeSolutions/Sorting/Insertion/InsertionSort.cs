

namespace LeetCodeSolutions.Sorting.Insertion;

public static class InsertionSort
{
    /// <summary>
    /// First member of the list or array accepts as sorted
    /// From the send member of list compears with the other members. 
    /// Time complexity  O(n²)
    /// </summary>
    /// <param name="list"></param>
    public static void Sort(List<int> list)
    {
        //int[] array = { 12, 11, 13, 5, 6 }; 

        int lenght = list.Count;
        int target = list.Count - 1;

        for (int i = 1; i < lenght; i++)
        {
            int key = list[i]; //The current number
            int j = i - 1;

            //Put the key in to subset 
            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j--;
            }
            list[j + 1] = key; // Put the key to right place

        }


        Print(list);
    }


    public static void Print(List<int> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine($"Sorted List: {item}");
        }

    }

    public static void SortFromTheEnd()
    {
        List<int> arr = [2, 4, 6, 8, 3];
        int n = arr.Count; //Dizi boyutu

        int valueToInsert = arr[n - 1];//sagdaki en uc degeri kaydet
        int i = n - 2;

        while (i >= 0 && arr[i] > valueToInsert)
        {
            arr[i+1] = arr[i];
            PrintArray(arr);
            i--;
        }
        arr[i+1] = valueToInsert;
        PrintArray(arr);
    }
    static void PrintArray(List<int> arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}
