
using AutoIt;
using AutoItX3Lib;
using MarsFramework.Config;
using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.IO;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region Initialize web elements
        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//input[@value='']")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement Servicetyp { get; set; }
       
        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement LocationSel { get; set; }


        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }
        

        //Select days Mon
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[2]")]
        private IWebElement Mon { get; set; }

        //Select days Tuesday
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[3]")]
        private IWebElement Tue { get; set; }

        //Select days Wednesday
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[4]")]
        private IWebElement Wed { get; set; }

        //Select days Thursday
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[5]")]
        private IWebElement Thurs { get; set; }



        //Storing the starttime from drop down
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")]
        private IWebElement StartTimeM { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[2]")]
        private IWebElement StartTimeDropDownM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input")]
        private IWebElement StartTimeT { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[3]")]
        private IWebElement StartTimeDropDownT { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")]
        private IWebElement StartTimeW { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[4]")]
        private IWebElement StartTimeDropDownW { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input")]
        private IWebElement StartTimeTh { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[5]")]
        private IWebElement StartTimeDropDownTh { get; set; }




        //Storing the Endtime from drop down
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")]
        private IWebElement EndTimeM { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[2]")]
        private IWebElement EndTimeDropDownM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input")]
        private IWebElement EndTimeT { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[3]")]
        private IWebElement EndTimeDropDownT { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input")]
        private IWebElement EndTimeW { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[4]")]
        private IWebElement EndTimeDropDownW { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input")]
        private IWebElement EndTimeTh { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[5]")]
        private IWebElement EndTimeDropDownTh { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        private IWebElement SkillExchange { get; set; }

        // Add Work Samples
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement FileUpload { get; set; }


        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement HiddenOpt { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //Validate share skill details
        //Click on manage listing
        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[2]/button[2]")]
        private IWebElement ManageLis { get; set; }

        #endregion

        #region Enter share skill
        //Add share skill details
        internal void EnterShareSkill()
        {
            //Populate the excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            
            try
            {

                //Click on Share skill button
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "LinkText", "Share Skill", 10000);
                ShareSkillButton.Click();

                //Enter the Title in textbox
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "title", 10000);
                Title.Click();
                Title.Clear();
                Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

                //Enter the Description in textbox
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "description", 10000);
                Description.Click();
                Description.Clear();
                Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

                //Select catagory from drop down
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "categoryId", 10000);
                CategoryDropDown.Click();
                new SelectElement(CategoryDropDown).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

                //Select catagory from drop down
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "Name", "subcategoryId", 10000);
                SubCategoryDropDown.Click();
                new SelectElement(SubCategoryDropDown).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));

                //Enter Tag names in textbox
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='']", 10000);
                Tags.Click();
                Tags.Clear();
                Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
                Tags.SendKeys(Keys.Enter);

                //Select service type
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']", 10000);
                ServiceTypeOptions.Click();
                Servicetyp.Click();

                //Select the Location Type
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']", 10000);
                LocationTypeOption.Click();
                LocationSel.Click();

                //Add start date
                StartDateDropDown.Click();
                // StartDateDropDown.Clear();
                StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));

                //Add End date
                EndDateDropDown.Click();
                //EndDateDropDown.Clear();
                EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));


                //Select available day
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]", 10000);
                Days.Click();
                
                Mon.Click();
                Tue.Click();
                Wed.Click();
                Thurs.Click();

                //Select start time and enter the time
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input", 10000);
                StartTimeM.Click();

                StartTimeDropDownM.Click();

                StartTimeM.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input", 10000);
                StartTimeT.Click();

                StartTimeDropDownT.Click();

                StartTimeT.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input", 10000);
                StartTimeW.Click();

                StartTimeDropDownW.Click();

                StartTimeW.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input", 10000);
                StartTimeTh.Click();

                StartTimeDropDownTh.Click();

                StartTimeTh.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")).ToString("hh:mmtt"));



                //Select end time from box
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input", 10000);
                EndTimeM.Click();

                EndTimeDropDownM.Click();

                EndTimeM.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input", 10000);
                EndTimeT.Click();

                EndTimeDropDownT.Click();

                EndTimeT.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input", 10000);
                EndTimeW.Click();

                EndTimeDropDownW.Click();

                EndTimeW.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")).ToString("hh:mmtt"));

                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input", 10000);
                EndTimeTh.Click();

                EndTimeDropDownTh.Click();

                EndTimeTh.SendKeys(DateTime.Parse(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")).ToString("hh:mmtt"));
                Thread.Sleep(1000);

                //Click on Skill trade option
                SkillTradeOption.Click();

                //Add Skill exchange tag
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input", 10000);
                SkillExchange.Click();
                SkillExchange.Clear();
                SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
                SkillExchange.SendKeys(Keys.Enter);

                //Upload File


                FileUpload.Click();

                AutoItX3 autoIt = new AutoItX3();
                AutoItX.WinWait("Open", "File Upload", 1);
                autoIt.WinActivate("Open");
                Thread.Sleep(2000);
                var SampleWorkPath = MarsResource.SampleWorkPath;
                autoIt.Send(Path.GetFullPath(SampleWorkPath));
                Thread.Sleep(2000);
                autoIt.Send("{Enter}");
                Thread.Sleep(2000);

                //Select option Active or Hidden
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']", 10000);
                ActiveOption.Click();
                HiddenOpt.Click();

                //Click on save button
                GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//input[@value='Save']", 10000);
                Save.Click();
            }

            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter Skill details", ex.Message);
            }
        }

        #endregion


        #region Validate share skill
        //Verify Share skill

        internal void VerifySkill()
        {

            //Populate the excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            
            //Verify share skill details
            GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[2]/button[2]", 10000);
            ManageLis.Click();
            try
            {
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]", 10000);
                var categorycheck = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]")).GetAttribute("textContent");
                Assert.That(categorycheck, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Category")));

               GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]", 10000);
                var titlecheck = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")).GetAttribute("textContent");
                Assert.That(titlecheck, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Title")));
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Share skill added successfully");
            }
            catch (Exception ex)
            {
                Assert.Fail("verify the share skill page failed", ex.Message);
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Share skill not added");

            }
        }
        #endregion
    }
}
