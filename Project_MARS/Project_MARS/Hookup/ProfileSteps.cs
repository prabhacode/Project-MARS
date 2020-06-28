using Project_MARS.Specflow.Helpers;
using Project_MARS.Specflow.Pages;
using System;
using TechTalk.SpecFlow;

namespace Project_MARS.Hookup
{
    [Binding]
    public class ProfileSteps:Drivers
    {
        [Given(@"I have logged into the portal successfully (.*),(.*)")]
        public void GivenIHaveLoggedIntoThePortalSuccessfully(string username, string password)
        {
            Initialize();
            SignIn.Login(username, password);
        }

        [Given(@"I add Availability, Hours, Earn Target and Description (.*)")]
        public void GivenIAddAvailabilityHoursEarnTargetAndDescription(string description)
        {
            Profile.Availability();
            Profile.Hours();
            Profile.EarnTarget();
            Profile.AddDescription(description);
        }


        [Given(@"I add Languages, Skills, Education and Certifications (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*)")]
        public void GivenIAddLanguagesSkillsEducationAndCertifications(string language, string languagelevel, string skill, string skilllevel, string university, string degree, string country, string title, string eduyear, string certificate, string certifiedfrom, string certyear)
        {
            Profile.AddLanguage(language, languagelevel);
            Profile.AddSkill(skill, skilllevel);
            Profile.AddEducation(university,degree, country, title, eduyear);
            Profile.AddCertifications(certificate, certifiedfrom, certyear);
        }

        
        [Given(@"I edit Languages and Skills (.*),(.*)")]
        public void GivenIEditLanguagesAndSkills(string EditLanguage, string EditSkill)
        {
            Profile.EditLanguage(EditLanguage);
            Profile.EditSkill(EditSkill);
        }
  
        
        [Given(@"I add Languages, Skills, Education and Certifications with null input")]
        public void GivenIAddLanguagesSkillsEducationAndCertificationsWithNullInput()
        {
            Profile.NullInputLanguage();
            Profile.NullInputSkill();
            Profile.NullInputEducation();
            Profile.NullInputCertifications();
        }
  
        
        [Then(@"The Record should be added successfully")]
        public void ThenTheRecordShouldBeAddedSuccessfully()
        {
            Close();
        }
 
        
        [Then(@"The Record should be edited successfully")]
        public void ThenTheRecordShouldBeEditedSuccessfully()
        {
            Close();
        }
 
        
        [Then(@"I should get the error message to the enter details")]
        public void ThenIShouldGetTheErrorMessageToTheEnterDetails()
        {
            Close();
        }
    }
}
