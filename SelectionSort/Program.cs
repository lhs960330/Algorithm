namespace SelectionSort
{
    internal class Program
    {
        static void Main( string [] args )
        {
            int [] arr = { 12, 1, 30, 20, 11, 14 };

            SelectionSort(arr);

            foreach ( int i in arr )
            {
                Console.Write(i + " ");
            }
        }

        static int [] SelectionSort( int [] arr )
        {
            int indexMin = 0;
            int temp = 0;
            for ( int i = 0; i < arr.Length - 1; i++ )// [1] 정렬되지 않은 부분의 첫 원소 선택
            {
                indexMin = i;
                for ( int j = i + 1; j < arr.Length; j++ )
                {
                    if ( arr [j] < arr [indexMin] ) // [2] 나머지 원소 중에서 가장 작은 값을 찾음
                        indexMin = j;              
                }
                // [3] 찾은 최소값을 현재 위치(i)와 교환
                temp = arr [indexMin];
                arr [indexMin] = arr [i];
                arr [i] = temp;
            }
            return arr;
        }
    }
}
