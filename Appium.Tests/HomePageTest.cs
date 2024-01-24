using Appium.Elements;
using Appium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace HomePageTest.Tests
{
    public class HomePageTest
    {
        private AndroidDriver _driver;
        NavigationPage Navigate;

        [OneTimeSetUp]
        public void SetUp()
        {
            var serverUri = new Uri(Environment.GetEnvironmentVariable("APPIUM_HOST") ?? "http://127.0.0.1:4723/");
            var driverOptions = new AppiumOptions()
            {
                AutomationName = AutomationName.AndroidUIAutomator2,
                PlatformName = "Android",
                DeviceName = "Android Emulator",
            };

            driverOptions.AddAdditionalAppiumOption("appPackage", "com.plusnarrative.spar2u");
            driverOptions.AddAdditionalAppiumOption("appActivity", ".MainActivity");
            // NoReset assumes the app com.google.android is preinstalled on the emulator
            driverOptions.AddAdditionalAppiumOption("noReset", true);

            _driver = new AndroidDriver(serverUri, driverOptions, TimeSpan.FromSeconds(180));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Navigate = new NavigationPage(_driver);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }

        [Test, Order(10)]
        public void WhenAppLoadsThenGotoHome()
        {
            Navigate.GotoHome();
            Assert.That(Navigate.IsHomeButtonVisible(), Is.True);
        }
   [Test, Order(11)]
        public void CheckforHomescreenObjects()
        {
            Navigate.GotoHome();
            Assert.That(Navigate.IsHomeButtonVisible(), Is.True);
            Assert.That(Navigate.IsShopByCategoryVisible(), Is.True);
        }
         [Test, Order(12)]
         public void Favouritesbuttuncheck()
     {
            Navigate.GotoHome();
            Assert.That(Navigate.IsFavouritesVisible, Is.True);
         }

        // [Test, Order(30)]
        // public void UserToEnterRandomTextOnTheEditor()
        // {
        //     var editText = _driver.FindElement(By.Id(Elements.TextEditorId));
        //     var randomText = "Nduduzo Was Here";
        //     editText.SendKeys(randomText);
        //     Assert.That(editText.Text, Is.EqualTo("Buy 101 devices"));
        // }
    }

    //Download dotnet sdk (.net8)
   
    //When you go back to visual studio code, you will get a pop to install a C# language.
    
}
