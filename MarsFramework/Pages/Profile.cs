using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace MarsFramework
{
    internal class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on availability Edit button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")]
        private IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }


        //Click on hour Edit button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        private IWebElement HourEdit { get; set; }



        //Click on Availability hour dropdown
        [FindsBy(How = How.Name, Using = "availabiltyHour")]
        private IWebElement AvailabilityHour { get; set; }

        //Click on salary Edit button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")]
        private IWebElement SalaryEdit { get; set; }

        //Click on salary dropdown
        [FindsBy(How = How.Name, Using = "availabiltyTarget")]
        private IWebElement SalarySelect { get; set; }

        ////Click on Location
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[1]/span/strong")]
        //private IWebElement Location { get; set; }


        //Click on language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")]
        private IWebElement LangBtn { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement ChooseLang { get; set; }

        //Select language level
        [FindsBy(How = How.Name, Using = "level")]
        private IWebElement ChooseLevel { get; set; }

        //Click on Add Language
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddLang { get; set; }


        //Click on skill
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")]
        private IWebElement SkillBtn { get; set; }

        //Click on add new skill
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Click on skill test box
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement AddSkillBox { get; set; }

        //Enter skill on the box
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement AddSkill { get; set; }

        //Click skill level dropdown
        [FindsBy(How = How.Name, Using = "level")]
        private IWebElement AddSkillLevel { get; set; }

        //Click on add skill
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddSkillBtn { get; set; }

        //Click on Education button
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")]
        private IWebElement EducationBtn { get; set; }

        //Click on add new education
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducationBtn { get; set; }

        //Choose country
        [FindsBy(How = How.Name, Using = "country")]
        private IWebElement SelectCountry { get; set; }

        //Choose title
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement SelectTitle { get; set; }

        //Choose year
        [FindsBy(How = How.Name, Using = "yearOfGraduation")]
        private IWebElement YearOfGraduation { get; set; }

        //Choose institute name
        [FindsBy(How = How.Name, Using = "instituteName")]
        private IWebElement InstitName { get; set; }

        //Choose degree
        [FindsBy(How = How.Name, Using = "degree")]
        private IWebElement Degree { get; set; }

        //Click on add education
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddEdu { get; set; }

        //Click on Certifications
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")]
        private IWebElement CertificationBtn { get; set; }

        //Click on add new certifications
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCertiBtn { get; set; }

        //Input Certification
        [FindsBy(How = How.Name, Using = "certificationName")]
        private IWebElement CertifiBtn { get; set; }

        [FindsBy(How = How.Name, Using = "certificationName")]
        private IWebElement CertifiName { get; set; }

        //Input certification from
        [FindsBy(How = How.Name, Using = "certificationFrom")]
        private IWebElement CertiFromBtn { get; set; }

        [FindsBy(How = How.Name, Using = "certificationFrom")]
        private IWebElement CertifiFrom { get; set; }

        //Select year from drop down
        [FindsBy(How = How.Name, Using = "certificationYear")]
        private IWebElement CertiYear { get; set; }

        //Click on add certification

        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddCerBtn { get; set; }

        //Click on discription edit button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        private IWebElement DescriptionEdit { get; set; }

        //Click on Description Text and enter the details
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")]
        private IWebElement DescriptionBox { get; set; }

        //Click on Save button

        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        private IWebElement SaveDescription { get; set; }


        #endregion

        internal void EnterProfile()
        {
            //Populate the excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            //Click on availability edit
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i", 10000);
            AvailabilityTimeEdit.Click();

            //Click on availability dropdown
            AvailabilityTime.Click();

            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "availabiltyType", 10000);
            //select availability time
            new SelectElement(GlobalDefinitions.driver.FindElement(By.Name("availabiltyType"))).SelectByText("Full Time");

            //click on hour edit
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i", 10000);
            HourEdit.Click();

            //click on houredit dropdown
            AvailabilityHour.Click();

            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "availabiltyHour", 10000);
            //select availability hour
            new SelectElement(GlobalDefinitions.driver.FindElement(By.Name("availabiltyHour"))).SelectByText("More than 30hours a week");

            //click on Target edit
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i", 10000);
            SalaryEdit.Click();

            //click on Target salary dropdown
            SalarySelect.Click();

            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "availabiltyTarget", 10000);
            //select salary
            new SelectElement(GlobalDefinitions.driver.FindElement(By.Name("availabiltyTarget"))).SelectByText("More than $1000 per month");

            //Click on location
            // Location.Click();

            //Click on language add new
            LangBtn.Click();
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 10000);
            AddNewLangBtn.Click();

            //Add new language
            AddLangText.Click();
            ChooseLang.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));

            //Select language level
            ChooseLevel.Click();
            new SelectElement(GlobalDefinitions.driver.FindElement(By.Name("level"))).SelectByText("Conversational");

            //Add Language
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='Add']", 10000);
            AddLang.Click();

            //Click on skill
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);
            SkillBtn.Click();

            //Click on add new skill
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 10000);
            AddNewSkillBtn.Click();

            //Add new skill

            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "name", 10000);
            AddSkillBox.Click();
            AddSkill.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));

            //Add skill level
            AddSkillLevel.Click();
            new SelectElement(GlobalDefinitions.driver.FindElement(By.Name("level"))).SelectByText("Beginner");

            //Click on add skill
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='Add']", 10000);
            AddSkillBtn.Click();

            //Click on Education button
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
            EducationBtn.Click();

            //Click on add new education
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 10000);
            AddNewEducationBtn.Click();

            //Choose country
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "country", 10000);
            SelectCountry.Click();
            new SelectElement(GlobalDefinitions.driver.FindElement(By.Name("country"))).SelectByText("India");

            //Choose title
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "title", 10000);
            SelectTitle.Click();
            new SelectElement(GlobalDefinitions.driver.FindElement(By.Name("title"))).SelectByText("B.Tech");

            //Choose year
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "yearOfGraduation", 10000);
            YearOfGraduation.Click();
            new SelectElement(GlobalDefinitions.driver.FindElement(By.Name("yearOfGraduation"))).SelectByText("2011");

            //Choose institute name
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "instituteName", 10000);
            InstitName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));

            //Choose degree
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "degree", 10000);
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));

            //Click on add education
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='Add']", 10000);
            AddEdu.Click();


            //Click on Certifications
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);
            CertificationBtn.Click();

            //Click on add new certifications
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div", 10000);
            AddNewCertiBtn.Click();

            //Input Certification
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "certificationName", 10000);
            CertifiBtn.Click();
            CertifiName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));

            //Input certification from
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "certificationFrom", 10000);
            CertiFromBtn.Click();
            CertifiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom"));

            //Select year from drop down
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "certificationYear", 10000);
            CertiYear.Click();
            new SelectElement(GlobalDefinitions.driver.FindElement(By.Name("certificationYear"))).SelectByText("2020");

            //Click on add certification
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='Add']", 10000);
            AddCerBtn.Click();


            //Click on edit Description
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 10000);
            DescriptionEdit.Click();

            //Click on Description Text and enter the details
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 10000);
            DescriptionBox.Clear();
            DescriptionBox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            //Click on Save button
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 10000);

            SaveDescription.Click();
        }

        internal void EditProfile()
        {

        }
        internal void DeleteProfile()
        {
            
        }
    }
}