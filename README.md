Bağış ve Yardım Takip Sistemi Proje Raporu Proje Özeti Bu proje, bağışçıların ve ihtiyaç sahiplerinin yönetimini kolaylaştırmak amacıyla geliştirilmiş bir Windows Forms uygulamasıdır. Sistem, bağışçı bilgileri, ihtiyaç sahipleri ve bağışlanan ürünlerin takibini merkezi bir yapıda sunmaktadır.

Proje Amacı Bağışçı bilgilerinin düzenli şekilde kaydedilmesi ve yönetilmesi

İhtiyaç sahiplerinin bilgilerinin sistematik olarak saklanması

Bağışlanan ürünlerin detaylı takibi

Kullanıcı dostu bir arayüz ile tüm bu işlemlerin kolayca yapılabilmesi

Sistem Özellikleri

Bağışçı Yönetimi Modülü (Form1) Veri Alanları: ID, Ad, Soyad, Telefon, E-Mail, Adres
Fonksiyonlar:

Yeni bağışçı ekleme

Bağışçı listesini görüntüleme

Örnek verilerle başlangıç veri seti oluşturma

İhtiyaç Sahibi Yönetimi Modülü (Form4) Veri Alanları: ID, Ad, Soyad, İhtiyaç Türü, Detay, Öncelik, Durum
Fonksiyonlar:

Yeni ihtiyaç sahibi ekleme

İhtiyaç listesini görüntüleme

Örnek verilerle başlangıç veri seti oluşturma

Ürün Yönetimi Modülü (Form6) Veri Alanları: ID, Ürün Türü, Detay, Miktar, Bağışçı, Tarih
Fonksiyonlar:

Yeni ürün ekleme

Ürün listesini görüntüleme

Örnek verilerle başlangıç veri seti oluşturma

Ana Menü (Form5) Fonksiyonlar:
Diğer modüllere geçiş butonları

Kullanıcı dostu arayüz

Teknik Detaylar Kullanılan Teknolojiler Programlama Dili: C#

Platform: Windows Forms

IDE: Visual Studio

Veri Yapısı Veriler şu anda textbox'lar aracılığıyla tutulmaktadır

Her modül kendi içinde verileri dikey olarak listeler şekilde saklamaktadır

Kullanıcı Arayüzü Her formda ilgili verilerin listelendiği bir tablo benzeri yapı bulunmaktadır

Yeni veri eklemek için giriş alanları ve butonlar mevcuttur

Temiz ve anlaşılır bir tasarım kullanılmıştır

Sistem Akış Diyagramı Kullanıcı ana menüden (Form5) bir modül seçer

Seçilen modül açılır (Form1, Form4 veya Form6)

Kullanıcı mevcut verileri görüntüleyebilir veya yeni veri ekleyebilir

İşlemler tamamlandığında ana menüye dönülür

Geliştirme Süreci İhtiyaç Analizi: Sistem gereksinimleri belirlendi

Tasarım: Formlar ve veri yapıları tasarlandı

Kodlama: C# ile Windows Forms uygulaması geliştirildi

Test: Fonksiyonlar test edildi ve hatalar giderildi

Dokümantasyon: Bu rapor ve kod içi yorumlar oluşturuldu

Kullanım Kılavuzu Uygulama başlatıldığında ana menü (Form5) açılır

Yönetmek istediğiniz modülü seçin (Bağışçı, İhtiyaç Sahibi veya Ürün)

Açılan pencerede mevcut kayıtları görebilirsiniz

Yeni kayıt eklemek için ilgili alanları doldurup "Ekle" butonuna basın

İşlemleriniz bittiğinde pencereleri kapatarak ana menüye dönebilirsiniz

Sonuç ve Öneriler Bu proje, temel bağış ve yardım takip işlemlerini gerçekleştirebilen bir sistem sunmaktadır. İleriki aşamalarda:

Veritabanı entegrasyonu yapılabilir

Raporlama özellikleri eklenebilir

Kullanıcı giriş sistemi ile yetkilendirme sağlanabilir

Daha gelişmiş arama ve filtreleme özellikleri eklenebilir
