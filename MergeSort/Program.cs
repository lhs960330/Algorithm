namespace MergeSort
{
    internal class Program
    {
        static void Main( string [] args )
        {
            int [] arr = { 12, 1, 30, 20, 11, 14 };

            MergeSort(arr, 0, arr.Length - 1);

            foreach ( int i in arr )
            {
                Console.Write(i + " ");
            }

        }

        static void MergeSort( int [] arr, int start, int end )
        {
            if ( start >= end ) return;

            int mid = ( start + end ) / 2;  // 배열의 가운데 부분

            MergeSort(arr, start, mid);     // 왼쪽 반을 재귀적으로 정렬
            MergeSort(arr, mid + 1, end);   // 오른쪽 반을 재귀적으로 정렬
            Merg(arr, start, mid, end);     // 정렬된 왼,오른쪽 배열 병합
        }
        
        static void Merg( int [] arr, int start, int mid, int end )
        {
            int [] sortedArr = new int [end - start + 1];   // 현재 들어온 배열의 크기 
            int sortedIndex = 0;                                      // sortedArr의 현재 저장한 위치 
            int startIndex = start;                         // 왼쪽 배열 시작 위치 
            int endIndex = mid + 1;                         // 오른쪽 배열 시작위치

            // 왼,오른쪽 배열을 비교하며 작은 값을 sortedArr에 저장
            while ( startIndex <= mid && endIndex <= end )
            {
                if ( arr [startIndex] < arr [endIndex] )
                    sortedArr [sortedIndex++] = arr [startIndex++];
                else
                    sortedArr [sortedIndex++] = arr [endIndex++];
            }

            // 만약 남아있는 데이터가 있을 경우
            while ( startIndex <= mid )
                sortedArr [sortedIndex++] = arr [startIndex++];
            while ( endIndex <= end )
                sortedArr [sortedIndex++] = arr [endIndex++];

            // 병합된 배열을 arr에 복사
            for ( int i = 0; i < sortedArr.Length; i++ )
                arr [start + i] = sortedArr [i];
        }
    }
}
