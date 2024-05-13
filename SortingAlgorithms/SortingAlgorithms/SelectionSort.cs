public partial class SortingAlgorithms
{
    public static int[] SelectionSort(int[] arr)
    {
        int found = 0;
        int foundindex = 0;
        for (int index = 0; index < arr.Length; index++)
        {
            //Program.DebugArr(arr);
            for (int pointer = index; pointer < arr.Length; pointer++)
            {
                if (found < arr[index])
                {
                    found = arr[index];
                    foundindex = index;
                }
            }
            if (arr[index] < found)
            {
                arr[foundindex] = arr[index];
                arr[index] = found;
            }
            found = 0;
        }
        return arr;
    }
}
