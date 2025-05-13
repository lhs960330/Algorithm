using System.Collections.Generic;
using System.Globalization;

namespace HeapSort
{
    internal class Program
    {
        static void Main( string [] args )
        {
            int [] arr = { 12, 1, 30, 20, 11, 14 };

            HeapSort(arr);

            foreach ( int i in arr )
            {
                Console.Write(i + " ");
            }

        }
        static void HeapSort( int [] arr )
        {
            int n = arr.Length;
            // 1. 주어진 배열을 max Heap으로 변환
            // 마지막 부모노드부터 역순으로 Heapify를 호출
            for ( int i = n / 2 - 1; i >= 0; i-- )
            {
                Heapify(arr, n, i);
            }
            // 2. 루트(최대값)를 배열 끝으로 보내고 줄어든 힙에서 다시 Heapify를 반복
            for ( int i = arr.Length - 1; i > 0; i-- )
            {
                // 루트와 현재 범위의 마지막 요소 교환 
                int temp = arr [0];
                arr [0] = arr [i];
                arr [i] = temp;
                // 남은 힙에서 루트가 바뀌었으므로 다시 Heapify
                Heapify(arr, i, 0); // i는 줄어든 크기, 0은 루트 인덱스
            }
        }

        // 특정 노드(rootIndex)를 기준으로 Max Heap 성질을 유지하도록 조정
        static void Heapify( int [] arr, int heapSize, int rootIndex )
        {
            int left = 2 * rootIndex + 1;       // 왼쪽 자식 노드 인덱스
            int right = 2 * rootIndex + 2;      // 오른쪽 자식 노드 인덱스
            int max = rootIndex;                // 가장 큰 값이여야되지만 초기값은 루트로 가정
            
            // 왼쪽 자식이 존재, 그 값이 현재 max 보다 크면 max 갱신
            if ( left < heapSize && arr [left] > arr [max] )
            {
                max = left;
            }

            // 오른쪽 자식이 존재, 그 값이 현재 max보다 크면 max 갱신
            if ( right < heapSize && arr [right] > arr [max] )
            {
                max = right;
            }

            // max가 루트가 아니면 교환이 필요함
            if ( max != rootIndex )
            {
                int temp = arr [rootIndex];
                arr [rootIndex] = arr [max];
                arr [max] = temp;

                // 바뀐 자식 노드를 다시 Heapify
                Heapify(arr, heapSize, max);
            }
        }
    }
}
