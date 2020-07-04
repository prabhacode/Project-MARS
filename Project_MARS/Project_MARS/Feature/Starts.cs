//using OpenQA.Selenium;
//using Project_MARS.Specflow.Helpers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using TechTalk.SpecFlow;

//namespace Project_MARS.Feature
//{
//    [Binding]
//    public sealed class Starts:Drivers
//    {
//        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

//        [BeforeFeature]
//        public void Login(String username, String password)
//        {

//            NavigateUrl();

//            //Clicking SignIn button
//            driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();

//            //Enter Username
//            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys(username);

//            //Enter Password
//            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys(password);

//            //Clicking Login Button
//            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
//            //Drivers.TurnOnWait();
//            //  Assert.That(Drivers.driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]")).Text, Is.EqualTo("Profile"));
//        }

//        [AfterFeature]
//        public void AfterScenario()
//        {
//            Close();
//        }
//    }
//}
