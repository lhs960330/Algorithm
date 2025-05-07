namespace QuickSort
{
    internal class Program
    {
        static void Main( string [] args )
        {
            int [] arr = { 12, 1, 30, 20, 11, 14 };

            QuickSort(arr, 0, arr.Length - 1);

            foreach ( int i in arr )
            {
                Console.Write(i + " ");
            }
        }

        static void QuickSort( int [] arr, int left, int right )
        {
            if ( left >= right ) return; // 정렬할 구간이 1개 이하면 종료

            // 피벗 분할
            int pivot = Partition(arr, left, right);

            QuickSort(arr, left, pivot - 1);    // 왼쪽부분
            QuickSort(arr, pivot + 1, right);   // 오른쪽 부분
        }
        static int Partition( int [] arr, int left, int right )
        {
            int pivot = arr [left]; // 첫 원소를 피벗으로 잡는다.
            int i = left + 1;       // 피벗보다 작은 값들의 위치

            for ( int j = left + 1; j <= right; j++ )
            {
                if ( arr [j] < pivot ) // 피벗보다 작으면 왼쪽으로 보내준다.
                {
                    Swap(arr, i, j);
                    i++;
                }
            }
            Swap(arr, left, i - 1); // 피벗과 작은값의 끝부분과 자리 교체
            return i - 1;           // 피벗의 최종 위치 반환
        }
        static void Swap( int [] arr, int x, int y )
        {
            int temp = arr [x];
            arr [x] = arr [y];
            arr [y] = temp;
        }
    }
}
