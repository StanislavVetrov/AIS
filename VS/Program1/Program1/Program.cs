using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sitetcki

{

    public class Class1

    {

        static void Main(string[] args)

        {

        }

        [Test]

        public void test_1_Open_site()
            //Открытие сайта
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://s22930.nubex.ru/";            
            Assert.IsTrue(true);

        }

        [Test]

        public void test_2_Fill_Review_Form()
            //Заполнение формы Отзыва
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://s22930.nubex.ru/";
            Assert.IsTrue(true);

            IWebElement LinkOtziv = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/ul/li[7]/a"));
            LinkOtziv.Click();

            IWebElement Name = driver.FindElement(By.Name("form_data[1]"));
            Name.SendKeys("Станислав");
            String Name1 = Name.GetAttribute("value");
            Assert.AreEqual(Name1, "Станислав");
                      
            IWebElement FieldPhone = driver.FindElement(By.XPath("//*[@id=\"form_4977\"]/form/div[1]/div[2]/input"));
            FieldPhone.SendKeys("8-633-50547");

            IWebElement FieldEmail = driver.FindElement(By.XPath("//*[@id=\"form_4977\"]/form/div[1]/div[3]/input"));
            FieldEmail.SendKeys("IloveMinecraft@gmail.com");

            IWebElement FieldReview = driver.FindElement(By.XPath("//*[@id=\"form_4977\"]/form/div[1]/div[4]/textarea"));
            FieldReview.SendKeys("Сайт хороший! Сервис отличный! Отдыхаем не первый раз, пока все нравится!");

            IWebElement Submit = driver.FindElement(By.XPath("//*[@id=\"form_4977\"]/form/div[2]/button"));
            Submit.Click();

            IWebElement MainPage = driver.FindElement(By.XPath("/ html / body / div[2] / div / div / div[1] / div / span[1] / a"));
            MainPage.Click();

        }

        [Test]

        public void test_3_Fill_Booking_Form()
            //Заполнение формы Бронирования
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://s22930.nubex.ru/";
            Assert.IsTrue(true);
            IWebElement bron = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/ul/li[5]/a"));
            bron.Click();

            IWebElement Name = driver.FindElement(By.Name("form_data[1]"));
            Name.SendKeys("Stas");
            Assert.IsTrue(true);
            String Name1 = Name.GetAttribute("value");
            Assert.AreEqual(Name1, "Stas");
            
            IWebElement Mail = driver.FindElement(By.Name("form_data[2]"));
            Mail.SendKeys("MyPochta@mail.ru");            
            
            IWebElement Phone = driver.FindElement(By.XPath("//*[@id=\"form_4855\"]/form/div[1]/div[3]/input"));
            Phone.SendKeys("4912454545");                       
          
            IWebElement FieldCottadge = driver.FindElement(By.XPath("//*[@id=\"form_4855\"]/form/div[1]/div[4]/div[2]/select/option[3]"));
            FieldCottadge.Click();

            IWebElement Checkbox = driver.FindElement(By.XPath("//*[@id=\"form_4855\"]/form/div[1]/div[6]/div/label"));
            Checkbox.Click();
                        
            IWebElement FieldComments = driver.FindElement(By.XPath("//*[@id=\"form_4855\"]/form/div[1]/div[5]/textarea"));

            FieldComments.SendKeys("Hello World!");

            IWebElement RadioButt = driver.FindElement(By.XPath("//*[@id=\"form_4855\"]/form/div[1]/div[7]/div[3]/label/input"));
            RadioButt.Click();

            IWebElement Date = driver.FindElement(By.Name("calendar"));
            Date.SendKeys("04062019");

            IWebElement Submit = driver.FindElement(By.Name("btn-send"));
            Submit.Click();



        }

        [Test]

        public void test_4_Tabs_Switching()
         // Переключение между вкладками
        {      
                           
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://s22930.nubex.ru/";            
            Assert.IsTrue(true);
            
            IWebElement CottageGreenPage = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[7]/div/div/div/div/div[1]/div/a"));
            CottageGreenPage.Click();
                                                                
            IWebElement MainPage = driver.FindElement(By.XPath("/ html / body / div[2] / div / div / div[1] / div / span[1] / a"));
            MainPage.Click();

            IWebElement CottageLongPage = driver.FindElement(By.XPath("/ html / body / div[2] / div / div / div[7] / div / div / div / div / div[2] / div / a"));
            CottageLongPage.Click();

            IWebElement SomeHowNewLinkToMainPage = driver.FindElement(By.XPath("/ html / body / div[1] / div[2] / div / div / div[2] / a"));
            SomeHowNewLinkToMainPage.Click();

            IWebElement CottageSouthPage = driver.FindElement(By.XPath("/ html / body / div[2] / div / div / div[7] / div / div / div / div / div[3] / div / a"));
            CottageSouthPage.Click();

            IWebElement SomeHowNewLinkToMainPage2 = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/a"));
            SomeHowNewLinkToMainPage2.Click();



        }

        [Test]

        public void test_5_Fill_Form_With_Mistake()
            //Попытка заполнить форму с неправильным форматом почты
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://s22930.nubex.ru/";            

            IWebElement LinkOtziv = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/ul/li[7]/a"));
            LinkOtziv.Click();

            IWebElement FieldName = driver.FindElement(By.XPath("//*[@id=\"form_4977\"]/form/div[1]/div[1]/input"));
            FieldName.SendKeys("Иван");

            IWebElement FieldPhone = driver.FindElement(By.XPath("//*[@id=\"form_4977\"]/form/div[1]/div[2]/input"));
            FieldPhone.SendKeys("8-920-555-33-33");


            IWebElement FieldEmail = driver.FindElement(By.XPath("//*[@id=\"form_4977\"]/form/div[1]/div[3]/input"));
            FieldEmail.SendKeys("IvanovII@майл.ру");

            IWebElement FieldReview = driver.FindElement(By.XPath("//*[@id=\"form_4977\"]/form/div[1]/div[4]/textarea"));
            FieldReview.SendKeys("Сайт замечательный, все удобно и понятно! Уже завтра едем отдыхать =)");

            IWebElement Submit = driver.FindElement(By.XPath("//*[@id=\"form_4977\"]/form/div[2]/button"));
            Submit.Click();
        }

    }

}