CarRacing – Basit Mobil Araba Yarışı Oyunu
Bu proje, yeğenlerim için eğlenceli ve kolay oynanabilir bir mobil araba yarışı oyunu geliştirmek amacıyla hazırlanmıştır.
Unity kullanılarak oluşturulan oyun, temel dokunmatik kontroller, basit engel sistemi ve skor takibi içerir.
Kod odaklı, sade ve anlaşılır bir yapıya sahiptir.
Proje Özeti
CarRacing; oyuncunun sağ–sol yönlerde hareket ederek engellerden kaçtığı, skorun zamanla arttığı ve çarpışma sonrası oyun sonu ekranının görüntülendiği bir sonsuz koşu türü araba yarışıdır.
Bu repo, sadece oyunda kullanılan temel C# scriptlerini içerir.
Grafikler, sesler veya diğer Unity varlıkları paylaşılmamıştır.
Öne Çıkan Özellikler
Basit ve anlaşılır oyuncu kontrol sistemi
Zamanla zorlaşan engel mekanizması
Skor artışı ve yüksek skor kaydı
Oyun sonu yönetimi
Dokunmatik uyumlu hareket kontrolleri
Temiz ve bölümlenmiş C# kod yapısı
Script Yapısı
Proje aşağıdaki temel C# dosyalarından oluşur:
Script Adı	Açıklama
GameManager.cs	Skor, zorluk, oyun sonu ve ses yönetimi
PlayerController.cs	Oyuncu hareketi (klavye + dokunmatik)
ObstacleSpawner.cs	Engel oluşturma sistemi
ObstacleMovement.cs	Engellerin ilerlemesi ve yok edilmesi
CameraShake.cs	Çarpışma sonrası kamera sallanması
Her bir script bağımsızdır ve kolayca başka projelere uyarlanabilir.
Nasıl Çalıştırılır
Unity'yi açın.
Yeni bir 2D proje oluşturun.
Bu repodaki C# dosyalarını projenizdeki Assets klasörüne ekleyin.
Engel prefab’ları, oyuncu ve kamera ayarlarını kendi projenize göre düzenleyin.
GameManager prefab’ını sahneye yerleştirin ve gerekli referansları bağlayın.
Oyunu çalıştırarak kontrol, engel ve skor sistemini test edebilirsiniz.
Teknolojiler
Unity 2D
C#
Basit mobil kontrol sistemi
PlayerPrefs ile skor kaydı
Geliştirici
Ebru Razi
Bu proje, oyun geliştirmeyi öğrenme sürecimde ve çocuklar için basit oyunlar hazırlarken oluşturduğum özel bir çalışma olarak geliştirilmiştir. Kodlar açık şekilde paylaşılmıştır ve dileyenler tarafından incelenebilir veya geliştirilebilir.
