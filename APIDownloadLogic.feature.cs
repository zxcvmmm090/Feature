﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Philips.Tonic.APITests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class APIDownloadLogicFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "APIDownloadLogic.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "APIDownloadLogic", "This Api\'s is used get Firmware of devices and therapy download Time", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "APIDownloadLogic")))
            {
                global::Philips.Tonic.APITests.Features.APIDownloadLogicFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetDownloadModelByInteractionId")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDownloadLogic")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetDownloadModelByInteractionId")]
        public void GetDownloadModelByInteractionId()
        {
            string[] tagsOfScenario = new string[] {
                    "UserAuthentication",
                    "GetDownloadModelByInteractionId"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetDownloadModelByInteractionId", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
testRunner.Given("I create a first patient details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
testRunner.And("try to DownloadTherapyData \"\\Philips.Tonic.APITests\\TestData\\EDFData\\Trilogy.txt\"" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
testRunner.And("GetDownloadModelByInteractionId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void GetPatientDownloadFirmware(string device, string firmware, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UserAuthentication",
                    "GetPatientDownloadFirmware"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("device", device);
            argumentsOfScenario.Add("firmware", firmware);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetPatientDownloadFirmware", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 12
testRunner.Given("I create a first patient details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
testRunner.And("Download thearpy data  \"\\Philips.Tonic.APITests\\TestData\\EDFData\\Trilogy.txt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
testRunner.And(string.Format("GetPatientDownloadFirmware of \"{0}\" and verify \"{1}\"", device, firmware), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetPatientDownloadFirmware: trilogy_100")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDownloadLogic")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetPatientDownloadFirmware")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "trilogy_100")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:device", "trilogy_100")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:firmware", "14.2.04")]
        public void GetPatientDownloadFirmware_Trilogy_100()
        {
#line 11
this.GetPatientDownloadFirmware("trilogy_100", "14.2.04", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetLastEdfTimestampUtc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDownloadLogic")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetLastEdfTimestampUtc")]
        public void GetLastEdfTimestampUtc()
        {
            string[] tagsOfScenario = new string[] {
                    "UserAuthentication",
                    "GetLastEdfTimestampUtc"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetLastEdfTimestampUtc", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 21
testRunner.Given("I create a first patient details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
testRunner.And("try to DownloadTherapyData \"\\Philips.Tonic.APITests\\TestData\\EDFData\\Trilogy.txt\"" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
testRunner.And("GetLastEdfTimestampUtc \"4/5/2023 6:55:34 AM\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetLatestAppSessionId")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDownloadLogic")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetLatestAppSessionId")]
        public void GetLatestAppSessionId()
        {
            string[] tagsOfScenario = new string[] {
                    "UserAuthentication",
                    "GetLatestAppSessionId"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetLatestAppSessionId", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 27
testRunner.Given("I create a first patient details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 28
testRunner.And("try to DownloadTherapyData \"\\Philips.Tonic.APITests\\TestData\\EDFData\\Trilogy.txt\"" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
testRunner.And("GetLatestAppSessionId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetDeviceFirmwareVersion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDownloadLogic")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("authorization")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UnauthorizedUser")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetDeviceFirmwareVersion")]
        public void GetDeviceFirmwareVersion()
        {
            string[] tagsOfScenario = new string[] {
                    "UserAuthentication",
                    "authorization",
                    "UnauthorizedUser",
                    "GetDeviceFirmwareVersion"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetDeviceFirmwareVersion", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 33
testRunner.Given("I create a first patient details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
testRunner.And("Download thearpy data  \"\\Philips.Tonic.APITests\\TestData\\RemstarData\\Remstar.txt\"" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
testRunner.And("GetDeviceFirmwareVersion and verify \"B3.04f\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetFirmwareFromSerialNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDownloadLogic")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetFirmwareFromSerialNumber")]
        public void GetFirmwareFromSerialNumber()
        {
            string[] tagsOfScenario = new string[] {
                    "UserAuthentication",
                    "GetFirmwareFromSerialNumber"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetFirmwareFromSerialNumber", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 39
testRunner.Given("I create a first patient details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 40
testRunner.And("Download thearpy data  \"\\Philips.Tonic.APITests\\TestData\\EDFData\\Trilogy.txt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
testRunner.And("GetFirmwareFromSerialNumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void GetFirmwareFromSerialNumberWithRemstar(string firmware, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "UserAuthentication",
                    "GetFirmwareFromSerialNumberwithRemstar"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("firmware", firmware);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetFirmwareFromSerialNumber with Remstar", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 45
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 46
testRunner.Given("I create a first patient details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 47
testRunner.And("Download thearpy data  \"\\Philips.Tonic.APITests\\TestData\\RemstarData\\Remstar.txt\"" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
testRunner.And(string.Format("GetFirmwareFromSerialNumber verify \"{0}\"", firmware), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetFirmwareFromSerialNumber with Remstar: 3.04")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDownloadLogic")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetFirmwareFromSerialNumberwithRemstar")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "3.04")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:firmware", "3.04")]
        public void GetFirmwareFromSerialNumberWithRemstar_3_04()
        {
#line 45
this.GetFirmwareFromSerialNumberWithRemstar("3.04", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
