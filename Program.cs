using BellmanFord;

Graph g = new Graph(6); // 6 şehir

// Türkiye'deki bazı şehirler arasındaki mesafeler (örnek veriler)
g.AddRoute(0, 1, 450);  // İstanbul - Ankara
g.AddRoute(0, 2, 330);  // İstanbul - Bursa
g.AddRoute(1, 3, 500);  // Ankara - Adana
g.AddRoute(1, 4, 650);  // Ankara - Erzurum
g.AddRoute(2, 3, 700);  // Bursa - Adana
g.AddRoute(3, 4, 300);  // Adana - Erzurum
g.AddRoute(4, 5, 900);  // Erzurum - Diyarbakır
g.AddRoute(3, 5, 350);  // Adana - Diyarbakır

g.BellmanFord(0); // İstanbul'dan başlıyoruz