# 🎶 Sanatçı LINQ Sorguları Projesi

Bu proje, C# dilinde LINQ kullanarak Türk müzik sanatçılarına ait veriler üzerinde çeşitli sorgular gerçekleştirmeyi amaçlamaktadır. Her sanatçı bir nesne olarak tanımlanır ve liste üzerinden LINQ ile filtreleme, sıralama ve analiz işlemleri yapılır.

## 📌 Proje Özeti

- Sanatçı verilerini nesne listesi olarak tanımlama
- LINQ ile veri filtreleme, sıralama ve analiz
- Konsol ekranında anlamlı çıktılar üretme

## 🛠️ Kullanılan Teknolojiler

- C# Programlama Dili
- .NET Core Console App
- Visual Studio IDE

## 🚀 Kurulum ve Çalıştırma

1. Visual Studio'da yeni bir **Console App (.NET Core)** projesi oluştur.
2. `Program.cs` dosyasındaki varsayılan kodu sil.
3. Sana verilen tam kodu yapıştır.
4. **F5** tuşuna basarak projeyi çalıştır.

## 📋 Uygulama Özellikleri

Aşağıdaki sorgular LINQ ile gerçekleştirilir:

- Adı “S” harfi ile başlayan sanatçılar
- Albüm satışları 10 milyonun üzerinde olanlar
- 2000 yılı öncesi çıkış yapmış ve pop müzik yapan sanatçılar (çıkış yılına göre sıralı, alfabetik)
- En çok albüm satan sanatçı
- En yeni ve en eski çıkış yapan sanatçılar

## 🧪 Örnek Çıktı

```text
Adı 'S' ile başlayan şarkıcılar:
- Sezen Aksu
- Sertab Erener
- Sıla
- Serdar Ortaç

Albüm satışları 10 milyon'un üzerinde olanlar:
- Ajda Pekkan (20 milyon)
- Sezen Aksu (20 milyon)
- Tarkan (15 milyon)

2000 yılı öncesi çıkış yapmış ve pop müzik yapanlar:
- 1968: Ajda Pekkan
- 1975: Sezen Aksu
- 1992: Tarkan
- 1994: Sertab Erener
- 1994: Serdar Ortaç
- 1997: Gülben Ergen
- 1999: Funda Arar

En çok albüm satan şarkıcı: Ajda Pekkan (20 milyon)
En yeni çıkış yapan şarkıcı: Sıla (2007)
En eski çıkış yapan şarkıcı: Ajda Pekkan (1968)
