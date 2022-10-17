using NUnit.Framework;
using SeleniumWebAutomation.Models;
using SeleniumWebAutomation.Steps.BaseSteps;
using TechTalk.SpecFlow;

namespace SeleniumWebAutomation.Steps
{
    [Binding,Scope(Feature ="N11")]
    public class N11Steps : BaseStep
    {
        N11Model model = new N11Model();

        [StepDefinition(@"N11 sitesi acilir")]
        public void OpenPage()
        {
            model.OpenPage("https://www.n11.com/");
        }

        [StepDefinition(@"Anasayfanin acildigi kontrol edilir")]
        public void AnasayfaKontrol()
        {
            Assert.AreEqual(model.AnasayfaKontrol(), 9);
        }

        [StepDefinition(@"Urun arama alanina csv dosyasinda ki veri yazilir ve klavyeden enter tusuna basilir")]
        public void UrunArama()
        {
            model.UrunArama(@"C:\Users\autum\Desktop\n11Deneme.csv");
        }
        
        [StepDefinition(@"Listelenen urunlerin arasindan rastgele bir urun secilir")]
        public void UrunSecme()
        {
            model.UrunSecme();
        }
        
        [StepDefinition(@"Sepete ekle butonuna basilir")]
        public void SepeteEkle()
        {
            model.SepeteEkle();
        }
        
        [StepDefinition(@"Sayfanin sag ust kisminda bulunan sepet ikonunda ki deger kontrol edilir")]
        public void IkonKontrol()
        {
            Assert.AreEqual(model.IkonKontrol(), "1");
        }
        
        [StepDefinition(@"Sepet ikonuna tiklanir")]
        public void IkonTiklama()
        {
            model.IkonTiklama();
        }
        
        [StepDefinition(@"Urun miktari 1 adet arttirilir")]
        public void UrunAdet()
        {
            model.UrunAdet();
        }
        
        [StepDefinition(@"Adet kontrolu yapilir")]
        public void AdetKontrol()
        {
            Assert.IsTrue(model.AdetKontrol().Contains("Sipariş Tutarı (2 ürün)"));
        }
        
        [StepDefinition(@"Urun silinir")]
        public void UrunSil()
        {
            model.UrunSil();
        }
        
        [StepDefinition(@"Sepetin bos oldugu kontrol edilir")]
        public void SepetKontrol()
        {
            Assert.IsTrue(model.SepetKontrol().Equals("Sepetin Boş Görünüyor"));
        }

    }
}
