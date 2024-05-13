public partial class SortingAlgorithms
{
    public static int[] BubbleSort(int[] arr)
    {
        int temp;
        for (int limiter = 1; limiter < arr.Length; limiter++)
        {
            //Program.DebugArr(arr);
            for (int second = 0; second <= limiter; second++)
            {
                for (int first = 0; first < second; first++)
                {
                    if (arr[first] > arr[second])
                    {
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