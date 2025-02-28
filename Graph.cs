namespace BellmanFord;

public class Graph
{
    private int Cities;
    private List<Edge> Routes;
    private string[] CityNames = { "İstanbul", "Ankara", "Bursa", "Adana", "Erzurum", "Diyarbakır" };

    public Graph(int cities)
    {
        Cities = cities;
        Routes = new List<Edge>();
    }

    public void AddRoute(int source, int destination, int distance)
    {
        Routes.Add(new Edge(source, destination, distance));
    }

    public void BellmanFord(int startCity)
    {
        int[] distance = new int[Cities];
        for (int i = 0; i < Cities; i++)
            distance[i] = int.MaxValue;
        distance[startCity] = 0;

        for (int i = 1; i < Cities; i++)
        {
            foreach (var route in Routes)
            {
                if (distance[route.Source] != int.MaxValue && 
                    distance[route.Source] + route.Distance < distance[route.Destination])
                {
                    distance[route.Destination] = distance[route.Source] + route.Distance;
                }
            }
        }

        foreach (var route in Routes)
        {
            if (distance[route.Source] != int.MaxValue && 
                distance[route.Source] + route.Distance < distance[route.Destination])
            {
                Console.WriteLine("Sistem negatif ağırlıklı bir döngü içeriyor!");
                return;
            }
        }

        Console.WriteLine("Şehirlerden en kısa mesafeler:");
        for (int i = 0; i < Cities; i++)
        {
            Console.WriteLine($"{CityNames[i]}: {distance[i]}");
        }
    }
}