Feature: N11

N11 Page Tests

@tag1
Scenario: N11PageControl
	* N11 sitesi acilir
	* Anasayfanin acildigi kontrol edilir
	* Urun arama alanina csv dosyasinda ki veri yazilir ve klavyeden enter tusuna basilir
	* Listelenen urunlerin arasindan rastgele bir urun secilir
	* Sepete ekle butonuna basilir
	* Sayfanin sag ust kisminda bulunan sepet ikonunda ki deger kontrol edilir
	* Sepet ikonuna tiklanir
	* Urun miktari 1 adet arttirilir
	* Adet kontrolu yapilir
	* Urun silinir
	* Sepetin bos oldugu kontrol edilir