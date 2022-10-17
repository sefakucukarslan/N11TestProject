using OpenQA.Selenium;
using SeleniumWebAutomation.WebDriver;
using System;
using System.Collections.ObjectModel;

namespace SeleniumWebAutomation.Models
{
    public class N11Model
    {
        public void OpenPage(string url)
        {
            Driver.GoToUrl(url);            
        }
        
        public int AnasayfaKontrol()
        {
            ReadOnlyCollection<IWebElement> elements = Driver.FindElementsXpath("//li[@class='catMenuItem']");
            return elements.Count;
        }

        public void UrunArama(string filePath)
        {
            Driver.FindElementId("searchData").SendKeys(Driver.FileRead(filePath));
            Driver.FindElementId("searchData").SendKeys(Keys.Enter);
        }

        public void UrunSecme()
        {
            Driver.ElementIsVisible(By.XPath("//li[@class='column ']"),5);
            ReadOnlyCollection<IWebElement> products = Driver.FindElementsXpath("//li[@class='column ']");
            int count = products.Count;
            Random random = new Random();
            int rnd = random.Next(count);
            Driver.MoveToElement(products[rnd]);
            products[rnd].Click();
        }

        public void SepeteEkle()
        {
            Driver.NewTab();
            Driver.Wait(3);
            Driver.FindElementXpath("//div[@id='shareWinTooltipClose']").Click();
            Driver.FindElementXpath("//div[@class='product-add-cart']/button").Click();
            
        }

        public string IkonKontrol()
        {
            return Driver.FindElementXpath("//span[@class='basketTotalNum']").Text;
        }

        public void IkonTiklama()
        {
            Driver.FindElementXpath("//div[@class='myBasketHolder']").Click();
        }

        public void UrunAdet()
        {
            Driver.FindElementXpath("//span[@class='btn btnBlack']").Click();
            Driver.FindElementXpath("//span[@class='spinnerUp spinnerArrow']").Click();
        }

        public string AdetKontrol()
        {
            return Driver.FindElementXpath("//div[@class='dtl product-total']/span[1]").Text;
            
        }

        public void UrunSil()
        {
            Driver.FindElementXpath("//span[@class='removeProd svgIcon svgIcon_trash']").Click();
            Driver.FindElementId("deleteBtnDFLB").Click();
        }

        public string SepetKontrol()
        {
            return Driver.FindElementXpath("//h2[text()='Sepetin Boş Görünüyor']").Text;
        }
    }
}
