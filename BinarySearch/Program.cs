namespace BinarySearch
{
    internal class Program
    {
        static void Main( string [] args )
        {
            int [] arr = { 1, 3, 10, 14, 20, 30 };

            int search = BinartSearch(arr, 20);

            Console.WriteLine(search);
        }

        static int BinartSearch( int [] arr, int target )
        {
            int left = 0;
            int right = arr.Length - 1;

            while ( left <= right )
            {
                
                int mid = left + ( right - left ) / 2;
                if ( target == arr [mid] )
                    return mid;
                if ( target < arr [mid] )
                {
                    right = mid - 1;
                }
                else if ( target > arr [mid] )
                {
                    left = mid + 1;
                }

            }
            return -1;
        }
    }
}
