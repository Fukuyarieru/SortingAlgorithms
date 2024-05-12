public class Program
{
    public static void Main(string[] args)
    {
        int[]arr={3,2,1};
        PrintArr(SortingAlgorithms.BubbleSort(arr));
        PrintArr(SortingAlgorithms.SelectionSort(arr));
    }
    public static void PrintArr(int[]arr)
    {
        for(int i=0;i<arr.Length-1;i++)
            Console.Write(arr[0]+", ");
        Console.WriteLine(arr[arr.Length-1]);
    }
}