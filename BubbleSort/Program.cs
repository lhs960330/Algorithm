namespace BubbleSort
{
    internal class Program
    {
        static void Main( string [] args )
        {
            int [] arr = { 12, 1, 30, 20, 11, 14 };
            arr = BubbleSort(arr);
            foreach ( int i in arr )
            {
                Console.WriteLine(i);
            }
        }

        static int [] BubbleSort( int [] arr )
        {
            int temp = 0;
            for ( int i = 0; i < arr.Length; i++ )  // i는 전체 패스를 위한 반복
            {
                for ( int j = 1; j < arr.Length - i; j++ )  // j는 비교하는 인덱스
                {
                    if ( arr [j - 1] > arr [j] )
                    {
                        // 교환
                        temp = arr [j - 1];
                        arr [j - 1] = arr [j];
                        arr [j] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
