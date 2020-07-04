using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project_MARS.Specflow.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Project_MARS.Specflow.Pages
{
    class Profile : Drivers
    {
        public static IWebElement ProfileTab => driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]"));

        //Languages tab
        public static IWebElement LanguagesTab => driver.FindElement(By.XPath("//a[text()='Languages']"));
        public static IWebElement AddnewLanguageButton => driver.FindElement(By.XPath("//*[contains(@class, 'ui teal button ')]"));
        public static IWebElement AddLanguageText => driver.FindElement(By.XPath("//input[@type='text'][@placeholder='Add Language']"));
        public static IWebElement SelectLanguageLevel => driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
        public static IWebElement AddLanguagebutton => driver.FindElement(By.XPath("//input[@class='ui teal button']"));
        public static IWebElement CancelLanguageButton => driver.FindElement(By.XPath("//input[@class='ui button']"));
        public static IWebElement EditLanguageIcon => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//i[@class='outline write icon']"));
        public static IWebElement EditLanguageText => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        public static IWebElement UpdateLanguageButton => driver.FindElement(By.XPath("//input[@class='ui teal button']"));
        public static IWebElement DeleteLanguageButton => driver.FindElement(By.XPath("//i[@class='remove icon']"));


        //Skills tab
        public static IWebElement SkillsTab => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
        public static IWebElement AddnewSkillButton => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        public static IWebElement AddSkillText => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public static IWebElement SelectSkillLevel => driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
        public static IWebElement AddSkillbutton => driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[contains(@class,'ui teal button')]"));
        public static IWebElement EditSkillIcon => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='outline write icon']"));
        public static IWebElement EditSkillText => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        public static IWebElement UpdateSkillButton => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//input[@class='ui teal button']"));
        public static IWebElement DeleteSkillButton => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//tbody[1]//tr[1]//td[3]//span[2]//i[1]"));

        //Education Tab
        public static IWebElement EducationTab => driver.FindElement(By.XPath("//a[@class='item'][contains(text(),'Education')]"));
        public static IWebElement AddNewEducationButton => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]"));
        public static IWebElement UniversityTextBox => driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
        public static IWebElement CountryOfUniversity => driver.FindElement(By.XPath("//select[@name='country']"));
        public static IWebElement Title => driver.FindElement(By.XPath("//select[@name='title']"));
        public static IWebElement Degree => driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
        public static IWebElement YearOfGraduation => driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
        public static IWebElement AddEducationButton => driver.FindElement(By.XPath("//div[@class='sixteen wide field']//input[contains(@class,'ui teal button')]"));

        //Certifications Tab
        public static IWebElement CertificationsTab => driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
        public static IWebElement AddNewCertificationsButton => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]"));
        public static IWebElement CertificateTextBox => driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
        public static IWebElement CertifiedFrom => driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
        public static IWebElement CertifiedYear => driver.FindElement(By.XPath("//select[@name='certificationYear']"));
        public static IWebElement AddCertificationsButton => driver.FindElement(By.XPath("//div[@class='five wide field']//input[contains(@class,'ui teal button')]"));

        //Description
        public static IWebElement DescriptionIcon => driver.FindElement(By.XPath("//i[@class='outline write icon']"));

        public static IWebElement DescriptionText = driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));

        public static IWebElement SaveDescriptionButton => driver.FindElement(By.XPath("//div[@class='ui twelve wide column']//button[@class='ui teal button'][text()='Save']"));


       

        //Adding description
        public static void AddDescription(String description)
        {
            //click edit icon of description
            driver.FindElement(By.XPath("//i[@class='outline write icon']")).Click();

            //Description Textbox
            IWebElement descriptionText = driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
            descriptionText.Click();
            descriptionText.Clear();
            descriptionText.SendKeys(description);

            //click save button
            driver.FindElement(By.XPath("//div[@class='ui twelve wide column']//button[@class='ui teal button'][text()='Save']")).Click();

        }

        public static void AddLanguage(String language, String languageLevel)
        {
            Assert.AreEqual(true, ProfileTab.Displayed);
            ProfileTab.Click();

            Assert.AreEqual(true, LanguagesTab.Displayed);
            LanguagesTab.Click();

            Assert.AreEqual(true, AddnewLanguageButton.Displayed);
            AddnewLanguageButton.Click();

            Assert.AreEqual(true, AddLanguageText.Displayed);
            AddLanguageText.SendKeys(language);

            //Selecting Language level from dropdown
            Assert.AreEqual(true, SelectLanguageLevel.Displayed);
            SelectElement selectElement = new SelectElement(SelectLanguageLevel);
            selectElement.SelectByText(languageLevel);

            Assert.AreEqual(true, AddLanguagebutton.Displayed);
            AddLanguagebutton.Click();
            Thread.Sleep(1000);

            //verify the success confirmation flash message
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                TurnOnWait();
                Assert.IsTrue(message.Contains("added"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }           
        }

        public static void EditLanguage(String EditLanguage)
        {
            Assert.AreEqual(true, LanguagesTab.Displayed);
            LanguagesTab.Click();

            Assert.AreEqual(true, EditLanguageIcon.Displayed);
            EditLanguageIcon.Click();

            Assert.AreEqual(true, EditLanguageText.Displayed);
            EditLanguageText.Clear();
            EditLanguageText.SendKeys(EditLanguage);

            Assert.AreEqual(true, UpdateLanguageButton.Displayed);
            UpdateLanguageButton.Click();
            Thread.Sleep(1000);

            //verify the success confirmation flash message
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                Assert.IsTrue(message.Contains("updated"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        public static void NullInputLanguage()
        {
            Assert.AreEqual(true, LanguagesTab.Displayed);
            LanguagesTab.Click();

            Assert.AreEqual(true, AddnewLanguageButton.Displayed);
            AddnewLanguageButton.Click();

            Assert.AreEqual(true, AddLanguagebutton.Displayed);
            AddLanguagebutton.Click();
            Thread.Sleep(1000);

            //verify the error flash message
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                TurnOnWait();
                Assert.IsTrue(message.Contains("enter"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        public static void AddSkill(String skill, String skillLevel)
        {
            Assert.AreEqual(true, SkillsTab.Displayed);
            SkillsTab.Click();

            Assert.AreEqual(true, AddnewSkillButton.Displayed);
            AddnewSkillButton.Click();

            Assert.AreEqual(true, AddSkillText.Displayed);
            AddSkillText.SendKeys(skill);

            //Selecting Skill level from dropdown
            Assert.AreEqual(true, SelectSkillLevel.Displayed);
            SelectElement selectElement = new SelectElement(SelectSkillLevel);
            selectElement.SelectByText(skillLevel);

            Assert.AreEqual(true, AddSkillbutton.Displayed);
            AddSkillbutton.Click();
            Thread.Sleep(1000);

            //verify the success confirmation flash message
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                TurnOnWait();
                Assert.IsTrue(message.Contains("added"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        public static void EditSkill(String EditSkill)
        {
            Assert.AreEqual(true, SkillsTab.Displayed);
            SkillsTab.Click();

            Assert.AreEqual(true, EditSkillIcon.Displayed);
            EditSkillIcon.Click();

            Assert.AreEqual(true, EditSkillText.Displayed);
            EditSkillText.Clear();
            EditSkillText.SendKeys(EditSkill);

            Assert.AreEqual(true, UpdateSkillButton.Displayed);
            UpdateSkillButton.Click();
            Thread.Sleep(1000);

            //verify the success confirmation flash message
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                TurnOnWait();
                Assert.IsTrue(message.Contains("updated"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        public static void NullInputSkill()
        {
            Assert.AreEqual(true, SkillsTab.Displayed);
            SkillsTab.Click();

            Assert.AreEqual(true, AddnewSkillButton.Displayed);
            AddnewSkillButton.Click();

            Assert.AreEqual(true, AddSkillbutton.Displayed);
            AddSkillbutton.Click();
            Thread.Sleep(1000);

            //verify the error flash message
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                TurnOnWait();
                Assert.IsTrue(message.Contains("enter"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

        public static void AddEducation(String university, String degree, String Country, String title, String EduYear)
        {
            Assert.AreEqual(true, EducationTab.Displayed);
            EducationTab.Click();
            TurnOnWait();

            Assert.AreEqual(true, AddNewEducationButton.Displayed);
            AddNewEducationButton.Click();

            Assert.AreEqual(true, UniversityTextBox.Displayed);
            UniversityTextBox.SendKeys(university);

            //Selecting Country from dropdown
            Assert.AreEqual(true, CountryOfUniversity.Displayed);
            var SelectCountry = new SelectElement(CountryOfUniversity);
            SelectCountry.SelectByText(Country);

            //Selecting Title from dropdown
            Assert.AreEqual(true, Title.Displayed);
            var SelectTitle = new SelectElement(Title);
            SelectTitle.SelectByText(title);

            Degree.SendKeys(degree);

            //Selecting Year from dropdown
            Assert.AreEqual(true, YearOfGraduation.Displayed);
            var SelectYear = new SelectElement(YearOfGraduation);
            SelectYear.SelectByText(EduYear);

            Assert.AreEqual(true, AddEducationButton.Displayed);
            AddEducationButton.Click();
            Thread.Sleep(1000);

            //verify the success confirmation flash message
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                Assert.IsTrue(message.Contains("added"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }
        public static void NullInputEducation()
        {
            Assert.AreEqual(true, EducationTab.Displayed);
            EducationTab.Click();

            Assert.AreEqual(true, AddNewEducationButton.Displayed);
            AddNewEducationButton.Click();

            Assert.AreEqual(true, AddEducationButton.Displayed);
            AddEducationButton.Click();
            Thread.Sleep(1000);

            //verify the error flash message
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                Assert.IsTrue(message.Contains("enter"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }


        public static void AddCertifications(String certificate, String certifiedfrom, String certyear)
        {
            Assert.AreEqual(true, CertificationsTab.Displayed);
            CertificationsTab.Click();

            Assert.AreEqual(true, AddNewCertificationsButton.Displayed);
            AddNewCertificationsButton.Click();

            Assert.AreEqual(true, CertificateTextBox.Displayed);
            CertificateTextBox.SendKeys(certificate);

            Assert.AreEqual(true, CertifiedFrom.Displayed);
            CertifiedFrom.SendKeys(certifiedfrom);

            //Selecting Year from dropdown
            Assert.AreEqual(true, CertifiedYear.Displayed);
            var SelectYear = new SelectElement(CertifiedYear);
            SelectYear.SelectByText(certyear);

            Assert.AreEqual(true, AddCertificationsButton.Displayed);
            AddCertificationsButton.Click();
            Thread.Sleep(1000);

            //verify the success confirmation flash message
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                Assert.IsTrue(message.Contains("added"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }
        public static void NullInputCertifications()
        {
            Assert.AreEqual(true, CertificationsTab.Displayed);
            CertificationsTab.Click();

            Assert.AreEqual(true, AddNewCertificationsButton.Displayed);
            AddNewCertificationsButton.Click();

            Assert.AreEqual(true, AddCertificationsButton.Displayed);
            AddCertificationsButton.Click();
            Thread.Sleep(1000);

            //verify the error flash message
            var message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            try
            {
                Assert.IsTrue(message.Contains("enter"));
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }      
    }
}
