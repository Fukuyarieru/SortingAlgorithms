public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 3, 2, 1, 4, 21 };
        DebugArr(arr);



        arr = GenerateRandomArr(10, 0, 10);
        DebugArr(arr);
        SortingAlgorithms.BubbleSort(arr);
        DebugArr(arr);
    }
    public static void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            Console.Write(arr[i] + ", ");
        Console.WriteLine(arr[arr.Length - 1]);
    }
    public static string VisualizeArr(int[] arr)
    {
        string str = "";
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i]; j++)
                str += "[]";
            str += "\n";
        }
        return str;
    }
    public static void DebugArr(int[] arr)
    {
        PrintArr(arr);
        Console.WriteLine(VisualizeArr(arr));
        Console.WriteLine();
    }
    public static int[] GenerateRandomArr(int ArrSize,int LowLim, int HighLim)
    {
        Random rnd = new Random();
        int[] arr = new int[ArrSize];
        for (int i = 0;i < arr.Length;i++)
            arr[i] = rnd.Next(LowLim,HighLim);
        return arr;
    }
}