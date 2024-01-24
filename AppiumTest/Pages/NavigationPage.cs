using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Appium.Pages
{
    public class NavigationPage
    {
        //Create an instance of a class type (this can be equivalent to string/bool/integer)
        NavigationPageElements NavigationElements;
        public NavigationPage(AndroidDriver driver)
        {
            //We are initiating a class instance, so that it doesn't return null each time you call it.
            //More of like uyinikeza uPetrol imoto ukuze isebenze :)
            NavigationElements = new NavigationPageElements(driver);
        }

        public void GotoHome()
        {
            NavigationElements.HomeButton.Click();
        }
        public bool IsHomeButtonVisible()
        {
            return NavigationElements.HomeButton.Displayed;        
        }
             public bool IsShopByCategoryVisible()
        {
            return NavigationElements.ShopByCategory.Displayed;        
        }
              public bool IsFavouritesVisible()
        {
            return NavigationElements.FavouritesButton.Displayed;        
        }
   
   
    }

    internal class NavigationPageElements
    {
        AndroidDriver _driver;
        public NavigationPageElements(AndroidDriver driver)
        {
            _driver = driver;
        }
        private const string homeBtn = "//android.widget.TextView[@text=\"Home\"]";
        private const string FavourateBtn = "//android.widget.TextView[@text=\"Search\"]";
        private const string FavouritesBtn = "Favourites";
        private const string ShopByCat = "//android.widget.TextView[@text=\"Shop by Category\"]";

        //=> is a shorthand for instead of doing this
        /*
        public WebElement HomeButton {
            get{
                return _driver.FindElement(By.XPath(homeBtn));
            }
        }
        */
        public WebElement HomeButton => _driver.FindElement(By.XPath(homeBtn));
        public WebElement ShopByCategory => _driver.FindElement(By.XPath(ShopByCat));
         public WebElement FavouritesButton => _driver.FindElement(MobileBy.AccessibilityId("Favourites"));

    }
}
