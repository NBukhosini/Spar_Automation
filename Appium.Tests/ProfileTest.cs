using Appium.Elements;
using Appium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;


namespace HomePageTest.Tests
{
    public class ProfileTest : ExtentReportBase
    {
        private AndroidDriver _driver;
        ProfilePage Profile;

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

            Profile = new ProfilePage(_driver);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }

        [Test, Order(10)]
        public void WhenAppLoadsThenGotoHome()
        {
            Profile.GotoProfile();
            Assert.That(Profile.IsProfileButtonVisible(), Is.True);
        }
        [Test, Order(11)]
        public void CheckProfilePageOptions()
        {
            Profile.GotoProfile();
            Assert.That(Profile.IsSavedCardsVisible(), Is.True);
            Assert.That(Profile.IsSavedLocationsVisible(), Is.True);
            Assert.That(Profile.IsFAQVisible(), Is.True);
            Assert.That(Profile.IsAboutSpar2uVisible(), Is.True);
            Assert.That(Profile.IsSparTCsVisible(), Is.True);
            Assert.That(Profile.IsTopsTCVisible(), Is.True);
            Assert.That(Profile.IsPrivacyPolicyVisible(), Is.True);
            Assert.That(Profile.IsHelpAndSupportVisible(), Is.True);
           
        }
         [Test, Order(12)]
        public void OpenProfileDetails()
        {
            Profile.GotoProfile();
            Profile.OpenProfileScreen();
            Assert.That(Profile.IsPersonaldetailsDescVisibile(), Is.True);
            Assert.That(Profile.IsNameDescVisibile(), Is.True);
            Assert.That(Profile.IsSurnameDescVisibile(), Is.True);
            Assert.That(Profile.IsIdNumberDescVisibile(), Is.True);
            Assert.That(Profile.IsphoneNumberDescVisibile(), Is.True);
            Assert.That(Profile.IsEmailAddressDescVisibile(), Is.True);
            Profile.Gohome();

        }

        [Test, Order(13)]
        public void FirstnameInvalidCharactors()
        {
            Profile.GotoProfile();
            Profile.OpenProfileScreen();
            Profile.InvalidNameTextBoxchar();
            Assert.That(Profile.IsInvalidNameinputerrorVisibile(), Is.True);
            Assert.That(Profile.InvalidNameError().Equals("Invalid Name input"));
            Profile.Gohome();
           
        }

                [Test, Order(14)]
        public void EmptyFirstnameTxtbox()
        {
            
            Profile.GotoProfile();
            Profile.OpenProfileScreen();
            Profile.EmptyNameTextbox();
            Assert.That(Profile.IsEmptynameFielderrorVisibile(), Is.True);
            Assert.That(Profile.EmptyNameTextboxError().Equals("Name is a required field"));
            Profile.Gohome();
           
        }
    }

    //Download dotnet sdk (.net8)
    //When you go back to visual studio code, you will get a pop to install a C# language.
}