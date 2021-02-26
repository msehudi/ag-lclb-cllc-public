﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using Xunit;
using Xunit.Abstractions;
using Xunit.Gherkin.Quick;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace bdd_tests
{
    public abstract partial class TestBase : Feature, IDisposable
    {
        [And(@"I complete the All Ages Liquor Free Event request")]
        public void AllAgesLiquorFreeEvent()
        {
            /* 
            Page Title: All Ages Liquor Free Event
            */

            // create test data
            string eventName = "Test Event";
            string eventNote = "Sample test event note.";
            string contactName = "Contact Name";
            string contactPhoneNumber = "(222) 222-2222";
            string contactEmail = "test@automation.com";

            // enter the event name
            NgWebElement uiEventName = ngDriver.FindElement(By.CssSelector("input[formcontrolname='eventName']"));
            uiEventName.SendKeys(eventName);

            // enter the event note
            NgWebElement uiEventNote = ngDriver.FindElement(By.CssSelector("textarea[formcontrolname='eventTypeDescription']"));
            uiEventNote.SendKeys(eventNote);

            // enter the contact name
            NgWebElement uiContactName = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactName']"));
            uiContactName.SendKeys(contactName);

            // enter the contact phone number
            NgWebElement uiContactPhone = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactPhone']"));
            uiContactPhone.SendKeys(contactPhoneNumber);

            // select end date
            NgWebElement uiEndDate1 = ngDriver.FindElement(By.CssSelector("input[formcontrolname='endDate']"));
            uiEndDate1.Click();

            // click on the next button
            NgWebElement uiOpenCalendarNext = ngDriver.FindElement(By.CssSelector(".mat-calendar .mat-calendar-next-button"));
            JavaScriptClick(uiOpenCalendarNext);

            // select start date
            NgWebElement uiStartDate1 = ngDriver.FindElement(By.CssSelector("input[formcontrolname='startDate']"));
            uiStartDate1.Click();

            try
            {
                NgWebElement uiStartDate2 = ngDriver.FindElement(By.CssSelector(".mat-calendar-body-cell-content.mat-calendar-body-today"));
                uiStartDate2.Click();
            }
            catch
            {
                // retry if failed once
                NgWebElement uiStartDate2 = ngDriver.FindElement(By.CssSelector(".mat-calendar-body-cell-content.mat-calendar-body-today"));
                uiStartDate2.Click();
            }

            // enter the contact email
            NgWebElement uiContactEmail = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactEmail']"));
            uiContactEmail.SendKeys(contactEmail);

            // confirm the contact email
            NgWebElement uiContactEmailConfirmation = ngDriver.FindElement(By.CssSelector("input[formcontrolname='contactEmailConfirmation']"));
            uiContactEmailConfirmation.SendKeys(contactEmail);

            // decrement event start hour
            NgWebElement uiEventStartHour = ngDriver.FindElement(By.CssSelector("[formcontrolname='startTime'] .ngb-tp-hour [type='button'] span.bottom"));
            JavaScriptClick(uiEventStartHour);

            // decrement event start minute
            NgWebElement uiEventStartMinute = ngDriver.FindElement(By.CssSelector("[formcontrolname='startTime'] .ngb-tp-minute span.ngb-tp-chevron.bottom"));
            JavaScriptClick(uiEventStartMinute);

            // decrement event end hour
            NgWebElement uiEventEndHour = ngDriver.FindElement(By.CssSelector("[formcontrolname='endTime'] .ngb-tp-hour [type='button'] span.bottom"));
            JavaScriptClick(uiEventEndHour);

            // decrement event end minute
            NgWebElement uiEventEndMinute = ngDriver.FindElement(By.CssSelector("[formcontrolname='endTime'] .ngb-tp-minute [type='button'] span.bottom"));
            JavaScriptClick(uiEventEndMinute);

            // select agreement checkbox
            NgWebElement uiAgreement = ngDriver.FindElement(By.CssSelector("mat-checkbox.mat-checkbox[formcontrolname='isAgreement1']"));
            uiAgreement.Click();

            // select review checkbox
            NgWebElement uiReview = ngDriver.FindElement(By.CssSelector("mat-checkbox.mat-checkbox[formcontrolname='isAgreement2']"));
            uiReview.Click();
        }
   }
}
