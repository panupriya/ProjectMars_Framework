﻿using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

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

        //Edit language
        //Language to be edited
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")]
        private IWebElement LangToSel { get; set; }

        //Click on edit language button
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")]
        private IWebElement EditLangBtn { get; set; }

        //Click on update language
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        private IWebElement UpdateLangBtn { get; set; }

        //Edit Skill
        //Skill to be edited
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")]
        private IWebElement SkillToSel { get; set; }
        //Click on edit skill button
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")]
        private IWebElement EditSkill { get; set; }

        //Click on updatete skill
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]")]
        private IWebElement UpdateSkillBtn { get; set; }

        //Edit education
        //Education to edit
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]")]
        private IWebElement EduToSel { get; set; }

        //Click on edit education button
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i")]
        private IWebElement EditEduBtn { get; set; }

        //Click on update education
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")]
        private IWebElement UpdateEduBtn { get; set; }


        //Edit certification
        //Certification to edit
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]")]
        private IWebElement CertiToSel { get; set; }

        //Click on edit certification button
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i")]
        private IWebElement EditCertiBtn { get; set; }

        //Click on update certification
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]")]
        private IWebElement UpdateCertiBtn { get; set; }

        //Delete Action
        //Delete language
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")]
        private IWebElement DeleteLangBtn { get; set; }

        //Delete skill
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")]
        private IWebElement DeleteSkillBtn { get; set; }

        //Delete Education
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i")]
        private IWebElement DeleteEduBtn { get; set; }

        //Delete Certification
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]")]
        private IWebElement DeleteCertiBtn { get; set; }


        #endregion

        //Enter Profile Details
        internal void EnterProfile()
        {
            //Populate the excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            #region profile details
            try
            {
                //Click on availability edit
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i", 10000);
                AvailabilityTimeEdit.Click();

                //Click on availability dropdown
                AvailabilityTime.Click();

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "availabiltyType", 10000);
                //select availability time
                new SelectElement(AvailabilityTime).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime"));
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter Availability Type", ex.Message);
            }

            try
            {
                //click on hour edit
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i", 10000);
                HourEdit.Click();

                //click on houredit dropdown
                AvailabilityHour.Click();

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "availabiltyHour", 10000);
                //select availability hour
                new SelectElement(AvailabilityHour).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Hours"));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter Availability Hours", ex.Message);
            }


            try
            {
                //click on Target edit
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i", 10000);
                SalaryEdit.Click();

                //click on Target salary dropdown
                SalarySelect.Click();

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "availabiltyTarget", 10000);
                //select salary
                new SelectElement(SalarySelect).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "EarnTarget"));
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter Earn Target", ex.Message);
            }

            //Click on location
            // Location.Click();
            #endregion


            #region AddLanguage
            try
            {

                //Click on language add new
                LangBtn.Click();
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 10000);
                AddNewLangBtn.Click();

                //Add new language
                AddLangText.Click();
                ChooseLang.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));

                //Select language level
                ChooseLevel.Click();
                new SelectElement(ChooseLevel).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "LanguageLevel"));

                //Add Language
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='Add']", 10000);
                AddLang.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter/add Language", ex.Message);
            }
            #endregion

            #region AddSkills
            try
            {
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
                new SelectElement(AddSkillLevel).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SkillLevel"));

                //Click on add skill
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='Add']", 10000);
                AddSkillBtn.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter/add Skills", ex.Message);
            }
            #endregion

            #region AddEducation
            try
            {
                //Click on Education button
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
                EducationBtn.Click();

                //Click on add new education
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 10000);
                AddNewEducationBtn.Click();

                //Choose country
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "country", 10000);
                SelectCountry.Click();
                new SelectElement(SelectCountry).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Country"));

                //Choose title
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "title", 10000);
                SelectTitle.Click();
                new SelectElement(SelectTitle).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

                //Choose year
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "yearOfGraduation", 10000);
                YearOfGraduation.Click();
                new SelectElement(YearOfGraduation).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "YearOfGraduation"));

                //Choose institute name
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "instituteName", 10000);
                InstitName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));

                //Choose degree
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "degree", 10000);
                Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));

                //Click on add education
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='Add']", 10000);
                AddEdu.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter/add Education", ex.Message);
            }
            #endregion


            #region AddCertification
            try
            {
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
                new SelectElement(CertiYear).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "YearOfCertification")); ;

                //Click on add certification
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='Add']", 10000);
                AddCerBtn.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter/add Certificate", ex.Message);
            }
            #endregion

            #region AddDescription
            try
            {
                //Click on edit Description
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 10000);
                DescriptionEdit.Click();

                //Click on Description Text and clear the details
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 10000);
                Thread.Sleep(1000);
                DescriptionBox.Clear();
                DescriptionBox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

                //Click on Save button
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 10000);
                SaveDescription.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to Enter Description", ex.Message);
            }
            #endregion
        }

        //Verifiy Profile details
        internal void VerifyProfile()
        {
            // Populate data saved in Excel
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            // Refresh the page
            GlobalDefinitions.driver.Navigate().Refresh();


            #region Verify profile details

            //verify language
            try
            {
                //Verify Language Name
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10000);
                LangBtn.Click();
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                var lastRowLanguageName = GlobalDefinitions.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowLanguageName, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Language")));

                //Verify Language Level
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowLanguageLevel = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowLanguageLevel, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "LanguageLevel")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Language", ex.Message);
            }

            //verify skill
            try
            {

                //Jump to Skill tab

                //Click on skill
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);
                SkillBtn.Click();

                //Verify Skill Name
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                var lastRowSkillName = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowSkillName, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Skill")));

                //Verify Skill Level
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowSkillLevel = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowSkillLevel, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "SkillLevel")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Skills", ex.Message);
            }

            //verify education
            try
            {
                //Jump to Education tab
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
                EducationBtn.Click();

                //Verify Education Country
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                var lastRowEducationCountry = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowEducationCountry, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Country")));

                //Verify Education Name
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowEducationName = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowEducationName, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "University")));

                //Verify Education Title
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]", 10000);
                var lastRowEducationTitle = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]")).Text;
                Assert.That(lastRowEducationTitle, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Title")));

                //Verify Education Degree
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]", 10000);
                var lastRowEducationDegree = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]")).Text;
                Assert.That(lastRowEducationDegree, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Degree")));

                //Verify Education Graduation Year
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]", 10000);
                var lastRowEducationGraduationYear = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]")).Text;
                Assert.That(lastRowEducationGraduationYear, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "YearOfGraduation")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Education", ex.Message);
            }

            //verify certification
            try
            {

                //Jump to Certification tab
                
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);
                CertificationBtn.Click();

                //Verify Certificate Name
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                var lastRowCertificateName = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowCertificateName, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate")));

                //Verify Certificate Issuing Place
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowCertificateFrom = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowCertificateFrom, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom")));

                //Verify Certificate Year
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]", 10000);
                var lastRowCertificateYear = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]")).Text;
                Assert.That(lastRowCertificateYear, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "YearOfCertification")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Certification", ex.Message);
            }

            //Verify Description
            try
            {
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span", 10000);
                var description = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;
                Assert.That(description, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Description")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Description", ex.Message);
            }
            #endregion


        }

        //Edit Profile
        internal void EditProfile()
        {
            // Populate data saved in Excel
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            // Refresh the page
            GlobalDefinitions.driver.Navigate().Refresh();

            #region Edit profile
            //Edit hours
            try
            {

                //click on hour edit
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i", 10000);
                HourEdit.Click();

                //click on houredit dropdown
                AvailabilityHour.Click();

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "availabiltyHour", 10000);
                //select availability hour
                new SelectElement(AvailabilityHour).SelectByText(GlobalDefinitions.ExcelLib.ReadData(3, "Hours"));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to edit Availability Hours", ex.Message);
            }

            //Edit language
            try
            {
                //Click on language
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10000);
                LangBtn.Click();

                //Click on language to edit
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                LangToSel.Click();

                //Click on edit language button
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i", 10000);
                EditLangBtn.Click();

                //Update the language
                //Update language level
                ChooseLevel.Click();
                new SelectElement(ChooseLevel).SelectByText(GlobalDefinitions.ExcelLib.ReadData(3, "LanguageLevel"));

                //Click on update
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]", 10000);
                UpdateLangBtn.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to edit Language", ex.Message);
            }

            //Edit Skill
            try
            {
                //Click on skill
                //Click on skill
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);
                SkillBtn.Click();

                //Click on skill to be edited
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                SkillToSel.Click();

                //Click on Edit skill
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i", 10000);
                EditSkill.Click();

                //Edit the skill
                //Add skill level
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "level", 10000);
                AddSkillLevel.Click();
                new SelectElement(AddSkillLevel).SelectByText(GlobalDefinitions.ExcelLib.ReadData(3, "SkillLevel"));

                //Click on update
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]", 10000);
                UpdateSkillBtn.Click();

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to edit Skill", ex.Message);
            }

               //Edit Education

            try
            {
                //Click on education
                //Click on Education button
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
                EducationBtn.Click();

                //Click on education to be edit
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                EduToSel.Click();

                //Click on edit education button
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i", 10000);
                EditEduBtn.Click();

                //Update education
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "title", 10000);
                SelectTitle.Click();
                new SelectElement(SelectTitle).SelectByText(GlobalDefinitions.ExcelLib.ReadData(3, "Title"));

                //Click on update education button 
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]", 10000);
            
                UpdateEduBtn.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to edit Education", ex.Message);
            }

            //Edit certification
            try
            {
                //Click on certification
                //Click on Certifications
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);
                CertificationBtn.Click();

                //Click on certification to be edit
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                CertiToSel.Click();

                //Click on edit certification button
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i", 10000);
                EditCertiBtn.Click();

                //Update certification
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "certificationYear", 10000);
                CertiYear.Click();
                new SelectElement(CertiYear).SelectByText(GlobalDefinitions.ExcelLib.ReadData(3, "YearOfCertification")); ;

                //Click on update certification button            
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]", 10000);
                UpdateCertiBtn.Click();
            }

            catch (Exception ex)
            {
                Assert.Fail("Test failed to edit Certification", ex.Message);
            }

            //Edit Description
            try
            {
                //Click on edit Description
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 10000);
                DescriptionEdit.Click();

                //Click on Description Text and clear the details
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 10000);
                Thread.Sleep(1000);
                DescriptionBox.Clear();
                DescriptionBox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Description"));

                //Click on Save button
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 10000);
                SaveDescription.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to Edit Description", ex.Message);
            }
            #endregion

        }


        //Verify edited profile
        internal void VerifyEditedProfile()
        {
            // Populate data saved in Excel
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            // Refresh the page
            GlobalDefinitions.driver.Navigate().Refresh();

            #region verify edited profile details
            //verify updated language
            try
            {
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10000);
                LangBtn.Click();
                //Verify Language Level
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowLanguageLevel = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowLanguageLevel, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(3, "LanguageLevel")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to update Language", ex.Message);
            }

            //Verify updated skill
            try
            {

                //Jump to Skill tab

                //Click on skill
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);
                SkillBtn.Click();

                //Verify Skill Level
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 10000);
                var lastRowSkillLevel = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowSkillLevel, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(3, "SkillLevel")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify updated Skills", ex.Message);
            }



            //verify updated education
            try
            {
                //Jump to Education tab
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
                EducationBtn.Click();

                //Verify Education Title
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]", 10000);
                var lastRowEducationTitle = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]")).Text;
                Assert.That(lastRowEducationTitle, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(3, "Title")));
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Updating Education", ex.Message);
            }

            //verify updated certification
            //verify certification
            try
            {

                //Jump to Certification tab
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);
                CertificationBtn.Click();

                //Verify Certificate Year
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]", 10000);
                var lastRowCertificateYear = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[3]")).Text;
                Assert.That(lastRowCertificateYear, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(3, "YearOfCertification")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Certification", ex.Message);
            }

            //Verify edited description
            try
            {
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span", 10000);
                var description = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;
                Assert.That(description, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(3, "Description")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Description", ex.Message);
            }
            #endregion

        }



        //Delete Profile Details
        internal void DeleteProfile()
        {


               // Populate data saved in Excel
               GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

               // Refresh the page
               GlobalDefinitions.driver.Navigate().Refresh();
               #region Delete profile details

                //Delete Language
            
               try
               {
                 //Click on language
                 GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10000);
                 LangBtn.Click();

                 //Click on language to delete
                 GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                 LangToSel.Click();

                 //Click on delete language
                 GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 20000);
                 DeleteLangBtn.Click();
               }
               catch (Exception ex)
               {
                 Assert.Fail("Test failed to delete Language", ex.Message);
               }

               //Delete Skill
            
               try
               {
                
                 //Click on skill
                 GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10000);
                 SkillBtn.Click();

                 //Click on skill to be deleted
                 GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                 SkillToSel.Click();

                 //Click on Delete skill
                 GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 20000);
                 DeleteSkillBtn.Click();
               
               }
               catch (Exception ex)
               {
                 Assert.Fail("Test failed to Delete Skill", ex.Message);
               }
                  Thread.Sleep(1000);

                //Delete Education
                try
                {
                  //Click on education
                  //Click on Education button
                  GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 10000);
                  EducationBtn.Click();

                   //Click on education to be deleted
                   GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                   EduToSel.Click();

                   //Click on  delete education button
                   GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i", 20000);
                   DeleteEduBtn.Click();

               
                }
                catch (Exception ex)
                {
                  Assert.Fail("Test failed to delete Education", ex.Message);
                }

               //Delete Certification
            
               try
               {
                 //Click on certification
                 //Click on Certifications
                 GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 10000);
                 CertificationBtn.Click();

                 //Click on certification to be deleted
                 GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]", 10000);
                 CertiToSel.Click();

                 //Click on delete certification button
                 GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]", 20000);
                 DeleteCertiBtn.Click();

               }

                catch (Exception ex)
               {
                Assert.Fail("Test failed to delete Certification", ex.Message);
               }
                #endregion
        }
    }
}