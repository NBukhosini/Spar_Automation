using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.DevTools.V118.Profiler;

namespace Appium.Pages
{
    public class ProfilePage
    {
        //Create an instance of a class type (this can be equivalent to string/bool/integer)
        ProfilePageElements ProfileElements;
        public ProfilePage(AndroidDriver driver)
        {
            //We are initiating a class instance, so that it doesn't return null each time you call it.
            //More of like uyinikeza uPetrol imoto ukuze isebenze :)
            ProfileElements = new ProfilePageElements(driver);
        }
//Check if profile tab options are visible
     public void GotoProfile()
        {
            ProfileElements.ProfileButton.Click();
        }

        public bool IsProfileButtonVisible()
        {
            return ProfileElements.ProfileButton.Displayed;        
        }
        public bool IsSavedCardsVisible()
        {
            return ProfileElements.SavedCards.Displayed;
                    
        }
        public bool IsSavedLocationsVisible()
        {
            return ProfileElements.SavedLocations.Displayed;        
        }
        public bool IsFAQVisible()
        {
            return ProfileElements.FAQ.Displayed;        
        }
        public bool IsAboutSpar2uVisible()
        {
            return ProfileElements.AboutSpar2u.Displayed;        
        }
        public bool IsSparTCsVisible()
        {
            return ProfileElements.SparTCs.Displayed;        
        }
        public bool IsTopsTCVisible()
        {
            return ProfileElements.TopsTC.Displayed;        
        }
        public bool IsPrivacyPolicyVisible()
        {
            return ProfileElements.PrivacyPolicy.Displayed;        
        }
         public bool IsHelpAndSupportVisible()
        {
            return ProfileElements.HelpAndSupport.Displayed;        
        }

//Open profile option to edit

         public void OpenProfileScreen()
        {
            ProfileElements.ViewProfile.Click();        
        }
    
   // Profile fields description

            public bool IsPersonaldetailsDescVisibile()
        {
            return ProfileElements.PersonaldetailsDesc.Displayed;        
        }
            public bool IsNameDescVisibile()
        {
            return ProfileElements.NameDesc.Displayed;        
        }
            public bool IsSurnameDescVisibile()
        {
            return ProfileElements.SurnameDesc.Displayed;        
        }
            public bool IsIdNumberDescVisibile()
        {
            return ProfileElements.IdNumberDesc.Displayed;        
        }
            public bool IsphoneNumberDescVisibile()
        {
            return ProfileElements.phoneNumberDesc.Displayed;        
        }
            public bool IsEmailAddressDescVisibile()
        {
            return ProfileElements.EmailAddressDesc.Displayed;        
        }
    
    
  public void Gohome()
     {
        
            ProfileElements.HomeButton.Click();

 }



  public void InvalidNameTextBoxchar()
        {
            Thread.Sleep(10000);
            ProfileElements.NameTextBox.Clear();
            Thread.Sleep(10000);
            ProfileElements.NameTextBoxEmpty.SendKeys("Nduduzo1");
            Thread.Sleep(10000);
            
            
           

        }
          public void EmptyNameTextbox()
        {
            Thread.Sleep(10000);
            ProfileElements.NameTextBox.Clear();
            
           

        }
    public bool IsInvalidNameinputerrorVisibile()
        {
            return ProfileElements.InvalidNameinput.Displayed;        
        }
   public bool IsEmptynameFielderrorVisibile()
        {
            return ProfileElements.EmptyNameTxtbox.Displayed;        
        }
        public string InvalidNameError()
        {
            var invalidNmError =  ProfileElements.InvalidNameinput.Text;    
            return invalidNmError;
        }
          public string EmptyNameTextboxError()
        {
            var EmptyNmError =  ProfileElements.EmptyNameTxtbox.Text;    
            return EmptyNmError;
        }
   
    }

    public class ProfilePageElements
    {
        AndroidDriver _driver;
        public ProfilePageElements(AndroidDriver driver)
        {
            _driver = driver;
        }
      // Profile section elements
       public WebElement HomeButton => _driver.FindElement(By.XPath("//android.widget.TextView[@text=\"Home\"]"));
        public WebElement ProfileButton => _driver.FindElement(MobileBy.AccessibilityId(", Profile"));
        public WebElement ViewProfile => _driver.FindElement(MobileBy.XPath("//android.view.ViewGroup[@content-desc=\", Profile\"]/android.view.ViewGroup"));
        public WebElement SavedCards => _driver.FindElement(MobileBy.XPath("//android.view.ViewGroup[@content-desc=\", Saved Cards\"]/android.view.ViewGroup"));
        public WebElement SavedLocations => _driver.FindElement(MobileBy.XPath("//android.view.ViewGroup[@content-desc=\", Saved Locations\"]/android.view.ViewGroup"));
        public WebElement FAQ => _driver.FindElement(MobileBy.XPath("//android.view.ViewGroup[@content-desc=\", FAQ's\"]/android.view.ViewGroup"));
        public WebElement AboutSpar2u => _driver.FindElement(MobileBy.XPath("//android.view.ViewGroup[@content-desc=\", About SPAR2U\"]/android.view.ViewGroup"));
        public WebElement SparTCs => _driver.FindElement(MobileBy.XPath("//android.view.ViewGroup[@content-desc=\", SPAR Terms & Conditions\"]/android.view.ViewGroup"));
        public WebElement TopsTC => _driver.FindElement(MobileBy.XPath("//android.view.ViewGroup[@content-desc=\", TOPS Terms & Conditions\"]/android.view.ViewGroup"));
        public WebElement PrivacyPolicy => _driver.FindElement(MobileBy.XPath("//android.view.ViewGroup[@content-desc=\", Privacy Policy\"]/android.view.ViewGroup"));
        public WebElement HelpAndSupport => _driver.FindElement(MobileBy.XPath("//android.view.ViewGroup[@content-desc=\", Help and Support\"]/android.view.ViewGroup"));
        public WebElement LogOut => _driver.FindElement(MobileBy.XPath("//android.view.ViewGroup[@content-desc=\", Log Out\"]/android.view.ViewGroup"));
   
//Profile details page elements 

//Personal Details Fields description elements
public WebElement PersonaldetailsDesc => _driver.FindElement(MobileBy.XPath("//android.widget.TextView[@text=\"Personal Details\"]"));
public WebElement NameDesc => _driver.FindElement(MobileBy.XPath("//android.widget.TextView[@text=\"Name*\"]"));
public WebElement SurnameDesc => _driver.FindElement(MobileBy.XPath("//android.widget.TextView[@text=\"Surname*\"]"));
public WebElement IdNumberDesc => _driver.FindElement(MobileBy.XPath("//android.widget.TextView[@text=\"ID number\"]"));
public WebElement phoneNumberDesc => _driver.FindElement(MobileBy.XPath("//android.widget.TextView[@text=\"Phone number*\"]"));
public WebElement EmailAddressDesc => _driver.FindElement(MobileBy.XPath("//android.widget.TextView[@text=\"Email Address*\"]"));
      

//Feilds Testbox and button elements

public WebElement NameTextBox => _driver.FindElement(MobileBy.XPath("//android.widget.EditText[@text=\"Nduduzo\"]"));
public WebElement NameTextBoxEmpty => _driver.FindElement(MobileBy.XPath("//android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[1]"));
public WebElement SurnameTextBox => _driver.FindElement(MobileBy.XPath("//android.widget.EditText[@text=\"Bukhosini\"]"));
public WebElement IdNumberTextBox => _driver.FindElement(MobileBy.XPath("//android.widget.EditText[@text=\"9207045685080\"]"));
public WebElement phoneNumberTextBox => _driver.FindElement(MobileBy.XPath("//android.widget.EditText[@text=\"+27614360281\"]"));
public WebElement EmailAddressTextBox => _driver.FindElement(MobileBy.XPath("//android.widget.EditText[@text=\"nduduzo@plusnarrative.com\"]"));
 public WebElement InvalidNameinput => _driver.FindElement(MobileBy.XPath("//android.widget.TextView[@text=\"Invalid Name input\"]"));  
 public WebElement EmptyNameTxtbox => _driver.FindElement(MobileBy.XPath("//android.widget.TextView[@text=\"Name is a required field\"]"));  


    }
}
















        //=> is a shorthand for instead of doing this
        /*
        public WebElement HomeButton {
            get{
                return _driver.FindElement(By.XPath(homeBtn));
            }
        }
        */