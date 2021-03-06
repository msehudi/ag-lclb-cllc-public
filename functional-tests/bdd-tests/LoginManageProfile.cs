﻿using Xunit;
using Xunit.Gherkin.Quick;

/*
Feature: LoginManageProfile
    As a business user
    I want to manage my account after log in

Scenario: Manage Account Profile
    Given I am logged in to the dashboard as a private corporation
    And I click on the button for my user account
    And I click on the link for Manage account  
    And I review the account profile for a private corporation
    And I click on the link for Edit Account Profile
    And the correct data is displayed for a private corporation account profile
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./LoginManageProfile.feature")]
    [Collection("Liquor")]
    public sealed class LoginManageProfile : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LogInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLiquorOne();

            CheckFeatureFlagsLGIN();

            CheckFeatureFlagsIN();

            CheckFeatureFlagsLicenseeChanges();

            CheckFeatureFlagsSecurityScreening();

            CheckFeatureLEConnections();

            IgnoreSynchronizationFalse();

            CarlaLogin(businessType);
        }
    }
}