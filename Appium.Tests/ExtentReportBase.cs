using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;

public class ExtentReportBase
{
    protected static ExtentReports extent;
    protected static ExtentTest test;

    [OneTimeSetUp]
    public void Setup()
    {
        string path = "/Users/nduduzobukhosini/Downloads/appiumtest-main/Appium.Tests/ExtentReport.html"; // Specify your report path
        var htmlReporter = new ExtentHtmlReporter(path);
        extent = new ExtentReports();
        extent.AttachReporter(htmlReporter);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        extent.Flush();
    }
}
