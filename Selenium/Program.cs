// See https://aka.ms/new-console-template for more information

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using System.Reflection.Emit;

// declaring driver object 
WebDriver driver = new ChromeDriver();
String url = "https://qfreeaccountssjc1.az1.qualtrics.com/jfe/form/SV_9Thsa3b7oDBtKDk";

// navigate to the url 
driver.Navigate().GoToUrl(url);


Console.WriteLine("First question");
// find element 

driver.FindElement(By.XPath("//*[@id='QR~QID1']")).SendKeys("User 1");
Thread.Sleep(1000);

// find button 
Console.WriteLine("Second question");
driver.FindElement(By.XPath("//*[@id='QID6-1-label']")).Click();
Thread.Sleep(1000);

// text element 
Console.WriteLine("Third question");
driver.FindElement(By.Name("QR~QID7~TEXT")).SendKeys("Gabriela: Working at first internship. Kahnishga: Eating ice cream and completing my Arangetram with my sister. Milagros: Going to Europe, Germany");
Thread.Sleep(1000);

// text button 
Console.WriteLine("Fourth question");
driver.FindElement(By.XPath("//*[@id=\'QID2-9-label\']")).Click();
Thread.Sleep(1000);
// multiple choice 
Console.WriteLine("Fifth question");

Random random = new Random();
int test = random.Next(0, 3);
Console.WriteLine(test);
Boolean otherClicked = false;
if (test == 0)
{
    driver.FindElement(By.XPath("//*[@id=\'QID4-1-label\']")).Click();

    driver.FindElement(By.XPath("//*[@id=\'QID4-2-label\']")).Click();
    driver.FindElement(By.XPath("//*[@id=\'QID4-3-label\']")).Click();

}
else if (test == 1)
{
    driver.FindElement(By.XPath("//*[@id=\'QID4-5-label\']")).Click();
    driver.FindElement(By.XPath("//*[@id=\'QID4-7-label\']")).Click();
    driver.FindElement(By.XPath("//*[@id=\'QID4-6-label\']")).Click();

    
} else if (test == 2)
{
    driver.FindElement(By.XPath("//*[@id=\'QID4-8-label\']")).Click();
    otherClicked = true;
}
if (otherClicked)
{
    driver.FindElement(By.Name("QR~QID8~TEXT")).SendKeys("Mathematics");
}
else
{
    driver.FindElement(By.Name("QR~QID8~TEXT")).SendKeys("None");

}

Console.WriteLine("Last question");
driver.FindElement(By.XPath("//*[@id=\'QR~QID9\']")).SendKeys("user1@email.com");






/*

Random rnd = new Random();

int dice = rnd.Next(1, 8);

String first = "'//*[@id=\\'QID4-";
String second = "label\']'";

driver.FindElement(By.XPath(first + dice + second)).Click();
/*
driver.FindElement(By.XPath("//*[@id=\'QID4-2-label\']")).Click();
driver.FindElement(By.XPath("//*[@id=\'QID4-3-label\']")).Click();
driver.FindElement(By.XPath("//*[@id=\'QID4-5-label\']")).Click();
driver.FindElement(By.XPath("//*[@id=\'QID4-7-label\']")).Click();
driver.FindElement(By.XPath("//*[@id=\'QID4-8-label\']")).Click();


Thread.Sleep(1000);
// other question
Console.WriteLine("Sixth question - Other");
Boolean otherClicked = false;
//the click line with the other btn xpath
otherClicked = true;
if (otherClicked)
{
    driver.FindElement(By.Name("QR~QID8~TEXT")).SendKeys("Mathematics");
}

driver.FindElement(By.XPath("//*[@id=\'QR~QID1\']")).SendKeys("email here");

Console.WriteLine("Seventh question");
Thread.Sleep(2000);
*/

