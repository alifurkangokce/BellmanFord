namespace BellmanFord;

public class Edge
{
    public int Source, Destination, Distance;
    public Edge(int source, int destination, int distance)
    {
        Source = source;
        Destination = destination;
        Distance = distance;
    }
}