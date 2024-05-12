    public partial class SortingAlgorithms
    {
        public static int[] BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        if (arr[k] > arr[j])
                        {
                            temp = arr[k];
                            arr[k] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            return arr;
        }
    }