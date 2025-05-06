namespace InsertionSort
{
    internal class Program
    {
        static void Main( string [] args )
        {
            int [] arr = { 12, 1, 30, 20, 11, 14 };

            InsertionSort(arr);

            foreach ( int i in arr )
            {
                Console.Write(i + " ");
            }
        }

        static int [] InsertionSort( int [] array )
        {
            //  1. 두번째 원소 부터 시작하여, 해당 값을 temp에 지정
            for ( int index = 1; index < array.Length; index++ ) 
            {
              
                int temp = array [index]; 

                int prev = index - 1;
                // 2. temp 보다 큰값을 왼쪽에서부터 오른쪽으로 한 칸씩 이동
                while ( prev >= 0 && array [prev] > temp )
                {
                    array [prev + 1] = array [prev];
                    prev--;
                }

                // 3. 반복
                array [prev + 1] = temp;
            }

            return array;
        }
    }
}
