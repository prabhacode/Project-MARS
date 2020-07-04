using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project_MARS.Specflow.Helpers;
using Project_MARS.Specflow.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Project_MARS.Hookup
{
    [Binding]
    public class LanguageSteps : Drivers
    {
        [Given(@"I click on the Language tab")]
        public void GivenIClickOnTheLanguageTab()
        {
            Profile.LanguagesTab.Click();
        }

        [Given(@"I click on Add New button of Language tab")]
        public void GivenIClickOnAddNewButtonOfLanguageTab()
        {
            Profile.AddnewLanguageButton.Click();
        }

        [Given(@"I enter the language details (.*),(.*)")]
        public void GivenIEnterTheLanguageDetails(string language, string languagelevel)
        {
            TurnOnWait();
            Profile.AddLanguageText.SendKeys(language);
            SelectElement selectElement = new SelectElement(Profile.SelectLanguageLevel);
            selectElement.SelectByText(languagelevel);
        }

        [Given(@"I click on Edit button of Language tab")]
        public void GivenIClickOnEditButtonOfLanguageTab()
        {
            Profile.EditLanguageIcon.Click();
        }

        [Given(@"I edit the language details (.*)")]
        public void GivenIEditTheLanguageDetails(string EditLanguage)
        {
            TurnOnWait();
            Profile.EditLanguageText.Clear();
            Profile.EditLanguageText.SendKeys(EditLanguage);
        }

        [Given(@"I click on Delete button of Language tab")]
        public void GivenIClickOnDeleteButtonOfLanguageTab()
        {
            Profile.DeleteLanguageButton.Click();
        }

        [Then(@"I click on Add button of Language tab")]
        public void ThenIClickOnAddButtonOfLanguageTab()
        {
            Profile.AddLanguagebutton.Click();
        }

        [Then(@"I validate that the new language has been added successfully (.*)")]
        public void ThenIValidateThatTheNewLanguageHasBeenAddedSuccessfully(string language)
        {
            //verify the add success confirmation flash message
            Thread.Sleep(1000);
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                Assert.IsTrue(message.Contains(language + " " + "has been added to your languages"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        [Then(@"I click on the Update button of Language tab")]
        public void ThenIClickOnTheUpdateButtonOfLanguageTab()
        {
            Profile.UpdateLanguageButton.Click();
        }

        [Then(@"I validate that the language has been edited successfully (.*)")]
        public void ThenIValidateThatTheLanguageHasBeenEditedSuccessfully(string Editlanguage)
        {
            //verify the edit success confirmation flash message
            Thread.Sleep(1000);
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                Assert.IsTrue(message.Contains(Editlanguage + " " + "has been updated to your languages"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        [Then(@"I validate that the language has been deleted successfully")]
        public void ThenIValidateThatTheLanguageHasBeenDeletedSuccessfully()
        {
            //verify the delete success confirmation flash message
            Thread.Sleep(1000);
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                Assert.IsTrue(message.Contains("has been deleted from your languages"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

    }
}

