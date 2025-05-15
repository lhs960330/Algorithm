namespace BFS
{
    internal class Program
    {
        static void Main( string [] args )
        {
            Console.WriteLine("Hello, World!");
        }
        static void BFS( bool [,] graph, int start, out bool [] visited, out int [] parents )
        {
            int size = graph.GetLength(0);
            visited = new bool [size];
            parents = new int [size];

            for ( int i = 0; i < size; i++ )
            {
                // 초기화
                visited [i] = false;
                parents [i] = -1;
            }

            Queue<int> queue = new Queue<int>();

            // 시작 정점을 queue에 저장하여 방문처리
            queue.Enqueue(start);
            visited [start] = true;

            // queue가 0이면 멈추게
            while ( queue.Count > 0 )
            {
                // queue에서 현재 위치로 설정
                int next = queue.Dequeue();

                for ( int i = 0; i < size; i++ )
                {
                    if ( graph [next, i] &&       // 연결되어 있는 정점이며,
                        !visited [i] )            // 방문한적 없는 정점
                    {
                        visited [i] = true;
                        parents [i] = next;
                        queue.Enqueue(i);
                    }
                }
            }
        }
    }
}
