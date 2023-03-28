namespace AlgorithamPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] array = { 4, 10, 15, 25, 30, 49, 61, 80, 110, 120 };  //=0th + last/2=
            //  int target = 25;
            ////  BinarySearch binarysearch = new BinarySearch();
            //  int index= BinarySearch.BinarySearchDemo(array, target);
            //  Console.WriteLine(index);
            //  if(index<0)
            //  {
            //      Console.WriteLine($"{target} is not found");
            //  }
            //  else
            //  {
            //      Console.WriteLine($"{target} is found at index: {index}");
            //  }


            int[] arr2 = { 32, 12, 9, 65, 24, 5 };
            MergeSort.Sort(arr2, 0, arr2.Length - 1);
            MergeSort.PrintArray(arr2);

        }

    }
}