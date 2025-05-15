namespace DFS
{
    internal class Program
    {
        static void Main( string [] args )
        {
            bool [,] graph = new bool [5, 5]
            {
                //0     1     2     3     4
                {false, true, false, false, true}, // 0
                {true, false, true, false, false}, // 1
                {false, true, false, true,  true}, // 2
                {false, false, true, false, false},// 3
                {true, false, true, false, false}, // 4
            };
            /*( 0 )
              /   \
            ( 1 )(4)
              \   /
              ( 2 )
                |
              ( 3 )*/

            DFS(graph, 0, out bool [] visited, out int [] parents);
            Console.WriteLine("방문한 정점:");
            for ( int i = 0; i < visited.Length; i++ )
            {
                if ( visited [i] )
                    Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("부모 노드 정보:");
            for ( int i = 0; i < parents.Length; i++ )
            {
                Console.WriteLine($"노드 {i} → 부모: {parents [i]}");
            }
        }
        static void DFS( bool [,] graph, int start, out bool [] visited, out int [] parents )
        {
            int size = graph.GetLength(0);
            visited = new bool [size];
            parents = new int [size];

            for ( int i = 0; i < size; i++ )
            {
                visited [i] = false;
                parents [i] = -1;
            }

            SearchNode(graph, start, visited, parents);
        }
        private static void SearchNode( bool [,] graph, int vertex, bool [] visited, int [] parents )
        {
            int size = graph.GetLength(0);
            visited [vertex] = true;
            for ( int i = 0; i < size; i++ )
            {
                if ( graph [vertex, i] &&     // 연결되어 있는 정점이며,
                    !visited [i] )            // 방문한적 없는 정점
                {
                    parents [i] = vertex;
                    SearchNode(graph, i, visited, parents);
                }
            }
        }
    }
}
