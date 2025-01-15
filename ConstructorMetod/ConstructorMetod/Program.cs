

using ConstructorMetod;

Baby yenidogan = new Baby();

Console.WriteLine($"Yeni doğan bilgisi :\n\nİsim = {yenidogan.Isim}\n\nSoyisim = {yenidogan.Soyisim}\n\nDoğum Tarihi = {yenidogan.DogumTarihi}");

Baby yenidogan2 = new Baby("Yılmaz", "Çınar");

Console.WriteLine($"Yeni doğan bilgisi :\n\nİsim = {yenidogan2.Isim}\n\nSoyisim = {yenidogan2.Soyisim}\n\nDoğum Tarihi = {yenidogan2.DogumTarihi}");