
namespace algorithm_with_graphs
{
    internal class Graph
    {
        Dictionary<int, Dictionary<int, int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<int, Dictionary<int, int>>() { };
        }

        public void  AddVertex(int vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new Dictionary<int, int>();
            }
        }

        public void AddEdge(int sourse, int destination, int weight)
        {
            if (!adjacencyList.ContainsKey(sourse))
            {
                adjacencyList[sourse] = new Dictionary<int, int>();
            }

            if (!adjacencyList.ContainsKey(destination))
            {
                adjacencyList[destination] = new Dictionary<int, int>();
            }

            adjacencyList[sourse][destination] = weight;
            /* adjacencyList[destination][sourse] = weight;*/ // якщо граф НЕ направлений, цей рядок повинен бути закоментований або видалений
        }

        public void PrintGraph()
        {
            foreach (var vertex in adjacencyList.Keys)
            {
                Console.Write(vertex + ": ");

                foreach (var neighbor in adjacencyList[vertex])
                {
                    Console.Write(neighbor.Key + "(" + neighbor.Value + ") ");
                }
                Console.WriteLine();
            }
        }
    }
}
