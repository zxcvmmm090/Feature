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
    public partial class APIDeviceManagmentFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "APIDeviceManagment.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "APIDeviceManagment", "\tIn order to manage devices associated with patients\r\n\tAs a user of Tonic\r\n\tI wan" +
                    "t to be able to assign, unassign, and manage devices as they relate to patients", ProgrammingLanguage.CSharp, featureTags);
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "APIDeviceManagment")))
            {
                global::Philips.Tonic.APITests.Features.APIDeviceManagmentFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Upsert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("POST")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Upsert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("deviceAssignment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        public void Upsert()
        {
            string[] tagsOfScenario = new string[] {
                    "POST",
                    "Upsert",
                    "deviceAssignment",
                    "UserAuthentication"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Upsert", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given("I am an authorized user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
  testRunner.When("I create a new patient details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
   testRunner.And("I create a generic device", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
   testRunner.And("assign the generic device to the patient", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
  testRunner.Then("the device will be included in the device list for the patient", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Unassign")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("POST")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Unassign")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("deviceUnAssignment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        public void Unassign()
        {
            string[] tagsOfScenario = new string[] {
                    "POST",
                    "Unassign",
                    "deviceUnAssignment",
                    "UserAuthentication"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Unassign", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 16
 testRunner.Given("I am an authorized user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 17
  testRunner.When("I create a new patient details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
   testRunner.And("I create a generic device", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
   testRunner.And("assign the generic device to the patient", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
   testRunner.And("unassign the generic device to the patient", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
  testRunner.Then("the device will be not be included in the device list for the patient", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetDevicesByPatientId")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetDevicesByPatientId")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        public void GetDevicesByPatientId()
        {
            string[] tagsOfScenario = new string[] {
                    "GetDevicesByPatientId",
                    "UserAuthentication"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetDevicesByPatientId", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
testRunner.Given("GetDevicesByPatientId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetLastAssignedDeviceSerial")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetLastAssignedDeviceSerial")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        public void GetLastAssignedDeviceSerial()
        {
            string[] tagsOfScenario = new string[] {
                    "GetLastAssignedDeviceSerial",
                    "UserAuthentication"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetLastAssignedDeviceSerial", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 29
testRunner.Given("GetLastAssignedDeviceSerial", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetSerialNumbersByPatientId")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetSerialNumbersByPatientId")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        public void GetSerialNumbersByPatientId()
        {
            string[] tagsOfScenario = new string[] {
                    "GetSerialNumbersByPatientId",
                    "UserAuthentication"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetSerialNumbersByPatientId", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
testRunner.Given("GetSerialNumbersByPatientId", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetDevicesByPatientIdOrderedByStartDate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetDevicesByPatientIdOrderedByStartDate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        public void GetDevicesByPatientIdOrderedByStartDate()
        {
            string[] tagsOfScenario = new string[] {
                    "GetDevicesByPatientIdOrderedByStartDate",
                    "UserAuthentication"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetDevicesByPatientIdOrderedByStartDate", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 37
testRunner.Given("GetDevicesByPatientIdOrderedByStartDate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetPatientIdOnAssignedDevice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetPatientIdOnAssignedDevice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        public void GetPatientIdOnAssignedDevice()
        {
            string[] tagsOfScenario = new string[] {
                    "GetPatientIdOnAssignedDevice",
                    "UserAuthentication"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetPatientIdOnAssignedDevice", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 40
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 41
testRunner.Given("GetPatientIdOnAssignedDevice", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void GetDeviceByInteractionId(string device_Family, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GetDeviceByInteractionId",
                    "UserAuthentication"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("device_family", device_Family);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetDeviceByInteractionId", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 44
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 45
testRunner.Given(string.Format("GetDeviceByInteractionId \"{0}\"", device_Family), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetDeviceByInteractionId: NirvanaSeries")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetDeviceByInteractionId")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "NirvanaSeries")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:device_family", "NirvanaSeries")]
        public void GetDeviceByInteractionId_NirvanaSeries()
        {
#line 44
this.GetDeviceByInteractionId("NirvanaSeries", ((string[])(null)));
#line hidden
        }
        
        public virtual void GetDevicesByPatientIdAndSerialNo(string device_Family, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GetDevicesByPatientIdAndSerialNo",
                    "UserAuthentication"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("device_family", device_Family);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetDevicesByPatientIdAndSerialNo", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 52
testRunner.Given(string.Format("GetDevicesByPatientIdAndSerialNo \"{0}\"", device_Family), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("GetDevicesByPatientIdAndSerialNo: NirvanaSeries")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("GetDevicesByPatientIdAndSerialNo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "NirvanaSeries")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:device_family", "NirvanaSeries")]
        public void GetDevicesByPatientIdAndSerialNo_NirvanaSeries()
        {
#line 51
this.GetDevicesByPatientIdAndSerialNo("NirvanaSeries", ((string[])(null)));
#line hidden
        }
        
        public virtual void IsCoughAssistDevice(string description, string dsn, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "IsCoughAssistDevice",
                    "UserAuthentication"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("description", description);
            argumentsOfScenario.Add("dsn", dsn);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("IsCoughAssistDevice", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 59
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 60
testRunner.Given(string.Format("IsCoughAssistDevice \"{0}\"", dsn), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("IsCoughAssistDevice: Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("IsCoughAssistDevice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "GeorgiaNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:dsn", "1024")]
        public void IsCoughAssistDevice_Variant0()
        {
#line 59
this.IsCoughAssistDevice("GeorgiaNumber", "1024", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("IsCoughAssistDevice: Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("IsCoughAssistDevice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "GeorgiaNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:dsn", "~0013")]
        public void IsCoughAssistDevice_Variant1()
        {
#line 59
this.IsCoughAssistDevice("GeorgiaNumber", "~0013", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("IsCoughAssistDevice: Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("IsCoughAssistDevice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "GeorgiaNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:dsn", "~14359")]
        public void IsCoughAssistDevice_Variant2()
        {
#line 59
this.IsCoughAssistDevice("GeorgiaNumber", "~14359", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("IsCoughAssistDevice: Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("IsCoughAssistDevice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "GeorgiaNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:dsn", "~0021606")]
        public void IsCoughAssistDevice_Variant3()
        {
#line 59
this.IsCoughAssistDevice("GeorgiaNumber", "~0021606", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("IsCoughAssistDevice: Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("IsCoughAssistDevice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "GeorgiaNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:dsn", "~0020025")]
        public void IsCoughAssistDevice_Variant4()
        {
#line 59
this.IsCoughAssistDevice("GeorgiaNumber", "~0020025", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("IsCoughAssistDevice: Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("IsCoughAssistDevice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "NonGeorgiaNumber")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:dsn", "85644484845454")]
        public void IsCoughAssistDevice_Variant5()
        {
#line 59
this.IsCoughAssistDevice("NonGeorgiaNumber", "85644484845454", ((string[])(null)));
#line hidden
        }
        
        public virtual void IsSerialNumberCompatibleWithDevice(string device_Family, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore",
                    "IsSerialNumberCompatibleWithDevice",
                    "UserAuthentication",
                    "prescriptionUpdate"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("device_family", device_Family);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("IsSerialNumberCompatibleWithDevice", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 73
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 74
testRunner.Given(string.Format("IsSerialNumberCompatibleWithDevice \"{0}\"", device_Family), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("IsSerialNumberCompatibleWithDevice: merlinn")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("IsSerialNumberCompatibleWithDevice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("prescriptionUpdate")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "merlinn")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:device_family", "merlinn")]
        public void IsSerialNumberCompatibleWithDevice_Merlinn()
        {
#line 73
this.IsSerialNumberCompatibleWithDevice("merlinn", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidateSerialNumberEx(string device_Family, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ValidateSerialNumberEx",
                    "UserAuthentication"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("device_family", device_Family);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ValidateSerialNumberEx", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 80
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 81
testRunner.Given(string.Format("ValidateSerialNumberEx \"{0}\"", device_Family), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ValidateSerialNumberEx: trilogy_o2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "APIDeviceManagment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ValidateSerialNumberEx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("UserAuthentication")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "trilogy_o2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:device_family", "trilogy_o2")]
        public void ValidateSerialNumberEx_Trilogy_O2()
        {
#line 80
this.ValidateSerialNumberEx("trilogy_o2", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
