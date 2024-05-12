public partial class SortingAlgorithms
{
    public static int[] BubbleSort(int[] original)
    {
        int[] arr = new int[original.Length];
        int temp;
        for (int limiter = 1; limiter < arr.Length; limiter++)
        {
            for (int second = 0; second <= limiter; second++)
            {
                for (int first = 0; first < second; first++)
                {
                    if (arr[first] > arr[second])
                    {
                        //Program.DebugArr(arr);
                        temp = arr[first];
                        arr[first] = arr[second];
                        arr[second] = temp;
                    }

                }

            }

        }
        return arr;
    }
}