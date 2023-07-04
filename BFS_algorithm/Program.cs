using algorithm_with_graphs;

Graph graph = new Graph();

graph.AddVertex(1);
graph.AddVertex(2);
graph.AddVertex(3);
graph.AddVertex(4);
graph.AddVertex(5);

graph.AddEdge(1, 2, 10);
graph.AddEdge(1, 3, 5);
graph.AddEdge(2, 4, 8);
graph.AddEdge(3, 4, 7);
graph.AddEdge(4, 5, 3);

graph.PrintGraph();