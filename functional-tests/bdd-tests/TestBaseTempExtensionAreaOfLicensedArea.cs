﻿using System;
using OpenQA.Selenium;
using Protractor;
using Xunit.Gherkin.Quick;

namespace bdd_tests
{
    public abstract partial class TestBase : Feature, IDisposable
    {
        [And(@"I submit a temporary extension of licensed area application")]
        public void TempExtensionAreaApplication()
        {
            /* 
            Page Title: Temporary Extension of Licensed Area
            */

            // create test data
            var description = "Test automation event details";
            var capacity = "99999";

            // enter the event details
            var uiEventDetails = ngDriver.FindElement(By.CssSelector("textarea#description2"));
            uiEventDetails.SendKeys(description);

            // add a date from
            NgWebElement uiDateFrom = null;
            for (var i = 0; i < 10; i++)
                try
                {
                    var names = ngDriver.FindElements(By.CssSelector("input#tempDateFrom"));
                    if (names.Count > 0)
                    {
                        uiDateFrom = names[0];
                        break;
                    }
                }
                catch (Exception)
                {
                }
            uiDateFrom.Click();

            // select the date
            SharedCalendarDate();

            // add a date to
            NgWebElement uiDateTo = null;
            for (var i = 0; i < 10; i++)
                try
                {
                    var names = ngDriver.FindElements(By.CssSelector("input#tempDateTo"));
                    if (names.Count > 0)
                    {
                        uiDateTo = names[0];
                        break;
                    }
                }
                catch (Exception)
                {
                }
            uiDateTo.Click();

            // select the date
            SharedCalendarDate();

            // upload a floor plan document
            FileUpload("floor_plan.pdf", "(//input[@type='file'])[2]");

            // enter the capacity
            var uiCapacity = ngDriver.FindElement(By.CssSelector("input[formcontrolname = 'capacity']"));
            uiCapacity.SendKeys(capacity);

            // select authorizedToSubmit checkbox
            var uiAuthorizedToSubmit = ngDriver.FindElement(By.Id("authorizedToSubmit"));
            uiAuthorizedToSubmit.Click();

            // select signatureAgreement checkbox
            var uiSignatureAgreement = ngDriver.FindElement(By.Id("signatureAgreement"));
            uiSignatureAgreement.Click();

            // click on the Submit & Pay button
            ClickOnSubmitButton();

            // pay for the structural change application
            MakePayment();
        }
    }
}