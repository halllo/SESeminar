//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneratedTests {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.5.3130.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class PurchaseScenarioTests : VsTestClassBase {
        
        public PurchaseScenarioTests() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "30000");
        }
        
        #region Expect Delegates
        public delegate void LoginSuccessfulDelegate1(string obj_p1);
        
        public delegate void UnknownUserDelegate1(string obj_p1);
        
        public delegate void PurchaseSuccessfulDelegate1(string arg1_p1, string arg2_p2);
        
        public delegate void PurchaseFailedDelegate1(string arg1_p1, string arg2_p2, string arg3_p3);
        #endregion
        
        #region Event Metadata
        static System.Reflection.EventInfo LoginSuccessfulInfo = TestManagerHelpers.GetEventInfo(typeof(TestAdapter.SystemUnderTest), "LoginSuccessful");
        
        static System.Reflection.EventInfo PurchaseSuccessfulInfo = TestManagerHelpers.GetEventInfo(typeof(TestAdapter.SystemUnderTest), "PurchaseSuccessful");
        
        static System.Reflection.EventInfo UnknownUserInfo = TestManagerHelpers.GetEventInfo(typeof(TestAdapter.SystemUnderTest), "UnknownUser");
        
        static System.Reflection.EventInfo PurchaseFailedInfo = TestManagerHelpers.GetEventInfo(typeof(TestAdapter.SystemUnderTest), "PurchaseFailed");
        #endregion
        
        #region Test Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize() {
            this.InitializeTestManager();
            this.Manager.Subscribe(LoginSuccessfulInfo, null);
            this.Manager.Subscribe(PurchaseFailedInfo, null);
            this.Manager.Subscribe(PurchaseSuccessfulInfo, null);
            this.Manager.Subscribe(UnknownUserInfo, null);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestCleanup() {
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void PurchaseScenarioTestsS0() {
            this.Manager.BeginTest("PurchaseScenarioTestsS0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call Login(\"admin\",\"geheim\")\'");
            TestAdapter.SystemUnderTest.Login("admin", "geheim");
            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return Login\'");
            this.Manager.Comment("reaching state \'S22\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS0LoginSuccessfulChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S33\'");
                this.Manager.Comment("executing step \'call Purchase(\"admin\",\"pc\")\'");
                TestAdapter.SystemUnderTest.Purchase("admin", "pc");
                this.Manager.Comment("reaching state \'S44\'");
                this.Manager.Comment("checking step \'return Purchase\'");
                this.Manager.Comment("reaching state \'S55\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.PurchaseSuccessfulInfo, null, new PurchaseSuccessfulDelegate1(this.PurchaseScenarioTestsS0PurchaseSuccessfulChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S66\'");
                    this.Manager.Comment("executing step \'call Logout(\"admin\")\'");
                    TestAdapter.SystemUnderTest.Logout("admin");
                    this.Manager.Comment("reaching state \'S75\'");
                    this.Manager.Comment("checking step \'return Logout\'");
                    this.Manager.Comment("reaching state \'S81\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.PurchaseSuccessfulInfo, null, new PurchaseSuccessfulDelegate1(this.PurchaseScenarioTestsS0PurchaseSuccessfulChecker)));
                }
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS0LoginSuccessfulChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void PurchaseScenarioTestsS0LoginSuccessfulChecker(string obj_p1) {
            this.Manager.Comment("checking step \'event LoginSuccessful(\"admin\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "admin", obj_p1, "obj_p1 of LoginSuccessful, state S22");
        }
        
        private void PurchaseScenarioTestsS0PurchaseSuccessfulChecker(string arg1_p1, string arg2_p2) {
            this.Manager.Comment("checking step \'event PurchaseSuccessful(\"admin\",\"pc\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "admin", arg1_p1, "arg1_p1 of PurchaseSuccessful, state S55");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "pc", arg2_p2, "arg2_p2 of PurchaseSuccessful, state S55");
        }
        #endregion
        
        #region Test Starting in S10
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void PurchaseScenarioTestsS10() {
            this.Manager.BeginTest("PurchaseScenarioTestsS10");
            this.Manager.Comment("reaching state \'S10\'");
            this.Manager.Comment("executing step \'call Login(\"manuel\",\"geheim\")\'");
            TestAdapter.SystemUnderTest.Login("manuel", "geheim");
            this.Manager.Comment("reaching state \'S11\'");
            this.Manager.Comment("checking step \'return Login\'");
            this.Manager.Comment("reaching state \'S27\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.UnknownUserInfo, null, new UnknownUserDelegate1(this.PurchaseScenarioTestsS10UnknownUserChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S38\'");
                this.Manager.Comment("executing step \'call Purchase(\"manuel\",\"pc\")\'");
                TestAdapter.SystemUnderTest.Purchase("manuel", "pc");
                this.Manager.Comment("reaching state \'S49\'");
                this.Manager.Comment("checking step \'return Purchase\'");
                this.Manager.Comment("reaching state \'S60\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS10PurchaseFailedChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S70\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS10PurchaseFailedChecker)));
                }
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.UnknownUserInfo, null, new UnknownUserDelegate1(this.PurchaseScenarioTestsS10UnknownUserChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void PurchaseScenarioTestsS10UnknownUserChecker(string obj_p1) {
            this.Manager.Comment("checking step \'event UnknownUser(\"manuel\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "manuel", obj_p1, "obj_p1 of UnknownUser, state S27");
        }
        
        private void PurchaseScenarioTestsS10PurchaseFailedChecker(string arg1_p1, string arg2_p2, string arg3_p3) {
            this.Manager.Comment("checking step \'event PurchaseFailed(\"manuel\",\"pc\",\"user is not logged in\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "manuel", arg1_p1, "arg1_p1 of PurchaseFailed, state S60");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "pc", arg2_p2, "arg2_p2 of PurchaseFailed, state S60");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "user is not logged in", arg3_p3, "arg3_p3 of PurchaseFailed, state S60");
        }
        #endregion
        
        #region Test Starting in S12
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void PurchaseScenarioTestsS12() {
            this.Manager.BeginTest("PurchaseScenarioTestsS12");
            this.Manager.Comment("reaching state \'S12\'");
            this.Manager.Comment("executing step \'call Login(\"manuel\",\"geheim\")\'");
            TestAdapter.SystemUnderTest.Login("manuel", "geheim");
            this.Manager.Comment("reaching state \'S13\'");
            this.Manager.Comment("checking step \'return Login\'");
            this.Manager.Comment("reaching state \'S28\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.UnknownUserInfo, null, new UnknownUserDelegate1(this.PurchaseScenarioTestsS12UnknownUserChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S39\'");
                this.Manager.Comment("executing step \'call Purchase(\"guest\",\"pc\")\'");
                TestAdapter.SystemUnderTest.Purchase("guest", "pc");
                this.Manager.Comment("reaching state \'S50\'");
                this.Manager.Comment("checking step \'return Purchase\'");
                this.Manager.Comment("reaching state \'S61\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS12PurchaseFailedChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S71\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS12PurchaseFailedChecker)));
                }
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.UnknownUserInfo, null, new UnknownUserDelegate1(this.PurchaseScenarioTestsS12UnknownUserChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void PurchaseScenarioTestsS12UnknownUserChecker(string obj_p1) {
            this.Manager.Comment("checking step \'event UnknownUser(\"manuel\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "manuel", obj_p1, "obj_p1 of UnknownUser, state S28");
        }
        
        private void PurchaseScenarioTestsS12PurchaseFailedChecker(string arg1_p1, string arg2_p2, string arg3_p3) {
            this.Manager.Comment("checking step \'event PurchaseFailed(\"guest\",\"pc\",\"user is not logged in\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "guest", arg1_p1, "arg1_p1 of PurchaseFailed, state S61");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "pc", arg2_p2, "arg2_p2 of PurchaseFailed, state S61");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "user is not logged in", arg3_p3, "arg3_p3 of PurchaseFailed, state S61");
        }
        #endregion
        
        #region Test Starting in S14
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void PurchaseScenarioTestsS14() {
            this.Manager.BeginTest("PurchaseScenarioTestsS14");
            this.Manager.Comment("reaching state \'S14\'");
            this.Manager.Comment("executing step \'call Login(\"guest\",\"geheim\")\'");
            TestAdapter.SystemUnderTest.Login("guest", "geheim");
            this.Manager.Comment("reaching state \'S15\'");
            this.Manager.Comment("checking step \'return Login\'");
            this.Manager.Comment("reaching state \'S29\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS14LoginSuccessfulChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S40\'");
                this.Manager.Comment("executing step \'call Purchase(\"admin\",\"pc\")\'");
                TestAdapter.SystemUnderTest.Purchase("admin", "pc");
                this.Manager.Comment("reaching state \'S51\'");
                this.Manager.Comment("checking step \'return Purchase\'");
                this.Manager.Comment("reaching state \'S62\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS14PurchaseFailedChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S72\'");
                    this.Manager.Comment("executing step \'call Logout(\"guest\")\'");
                    TestAdapter.SystemUnderTest.Logout("guest");
                    this.Manager.Comment("reaching state \'S78\'");
                    this.Manager.Comment("checking step \'return Logout\'");
                    this.Manager.Comment("reaching state \'S84\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS14PurchaseFailedChecker)));
                }
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS14LoginSuccessfulChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void PurchaseScenarioTestsS14LoginSuccessfulChecker(string obj_p1) {
            this.Manager.Comment("checking step \'event LoginSuccessful(\"guest\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "guest", obj_p1, "obj_p1 of LoginSuccessful, state S29");
        }
        
        private void PurchaseScenarioTestsS14PurchaseFailedChecker(string arg1_p1, string arg2_p2, string arg3_p3) {
            this.Manager.Comment("checking step \'event PurchaseFailed(\"admin\",\"pc\",\"user is not logged in\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "admin", arg1_p1, "arg1_p1 of PurchaseFailed, state S62");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "pc", arg2_p2, "arg2_p2 of PurchaseFailed, state S62");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "user is not logged in", arg3_p3, "arg3_p3 of PurchaseFailed, state S62");
        }
        #endregion
        
        #region Test Starting in S16
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void PurchaseScenarioTestsS16() {
            this.Manager.BeginTest("PurchaseScenarioTestsS16");
            this.Manager.Comment("reaching state \'S16\'");
            this.Manager.Comment("executing step \'call Login(\"guest\",\"geheim\")\'");
            TestAdapter.SystemUnderTest.Login("guest", "geheim");
            this.Manager.Comment("reaching state \'S17\'");
            this.Manager.Comment("checking step \'return Login\'");
            this.Manager.Comment("reaching state \'S30\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS16LoginSuccessfulChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S41\'");
                this.Manager.Comment("executing step \'call Purchase(\"manuel\",\"pc\")\'");
                TestAdapter.SystemUnderTest.Purchase("manuel", "pc");
                this.Manager.Comment("reaching state \'S52\'");
                this.Manager.Comment("checking step \'return Purchase\'");
                this.Manager.Comment("reaching state \'S63\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS16PurchaseFailedChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S73\'");
                    this.Manager.Comment("executing step \'call Logout(\"guest\")\'");
                    TestAdapter.SystemUnderTest.Logout("guest");
                    this.Manager.Comment("reaching state \'S79\'");
                    this.Manager.Comment("checking step \'return Logout\'");
                    this.Manager.Comment("reaching state \'S85\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS16PurchaseFailedChecker)));
                }
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS16LoginSuccessfulChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void PurchaseScenarioTestsS16LoginSuccessfulChecker(string obj_p1) {
            this.Manager.Comment("checking step \'event LoginSuccessful(\"guest\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "guest", obj_p1, "obj_p1 of LoginSuccessful, state S30");
        }
        
        private void PurchaseScenarioTestsS16PurchaseFailedChecker(string arg1_p1, string arg2_p2, string arg3_p3) {
            this.Manager.Comment("checking step \'event PurchaseFailed(\"manuel\",\"pc\",\"user is not logged in\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "manuel", arg1_p1, "arg1_p1 of PurchaseFailed, state S63");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "pc", arg2_p2, "arg2_p2 of PurchaseFailed, state S63");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "user is not logged in", arg3_p3, "arg3_p3 of PurchaseFailed, state S63");
        }
        #endregion
        
        #region Test Starting in S18
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void PurchaseScenarioTestsS18() {
            this.Manager.BeginTest("PurchaseScenarioTestsS18");
            this.Manager.Comment("reaching state \'S18\'");
            this.Manager.Comment("executing step \'call Login(\"guest\",\"geheim\")\'");
            TestAdapter.SystemUnderTest.Login("guest", "geheim");
            this.Manager.Comment("reaching state \'S19\'");
            this.Manager.Comment("checking step \'return Login\'");
            this.Manager.Comment("reaching state \'S31\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS18LoginSuccessfulChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S42\'");
                this.Manager.Comment("executing step \'call Purchase(\"guest\",\"pc\")\'");
                TestAdapter.SystemUnderTest.Purchase("guest", "pc");
                this.Manager.Comment("reaching state \'S53\'");
                this.Manager.Comment("checking step \'return Purchase\'");
                this.Manager.Comment("reaching state \'S64\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS18PurchaseFailedChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S74\'");
                    this.Manager.Comment("executing step \'call Logout(\"guest\")\'");
                    TestAdapter.SystemUnderTest.Logout("guest");
                    this.Manager.Comment("reaching state \'S80\'");
                    this.Manager.Comment("checking step \'return Logout\'");
                    this.Manager.Comment("reaching state \'S86\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS18PurchaseFailedChecker)));
                }
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS18LoginSuccessfulChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void PurchaseScenarioTestsS18LoginSuccessfulChecker(string obj_p1) {
            this.Manager.Comment("checking step \'event LoginSuccessful(\"guest\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "guest", obj_p1, "obj_p1 of LoginSuccessful, state S31");
        }
        
        private void PurchaseScenarioTestsS18PurchaseFailedChecker(string arg1_p1, string arg2_p2, string arg3_p3) {
            this.Manager.Comment("checking step \'event PurchaseFailed(\"guest\",\"pc\",\"read only users have no rights\"" +
                    ")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "guest", arg1_p1, "arg1_p1 of PurchaseFailed, state S64");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "pc", arg2_p2, "arg2_p2 of PurchaseFailed, state S64");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "read only users have no rights", arg3_p3, "arg3_p3 of PurchaseFailed, state S64");
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void PurchaseScenarioTestsS2() {
            this.Manager.BeginTest("PurchaseScenarioTestsS2");
            this.Manager.Comment("reaching state \'S2\'");
            this.Manager.Comment("executing step \'call Login(\"admin\",\"geheim\")\'");
            TestAdapter.SystemUnderTest.Login("admin", "geheim");
            this.Manager.Comment("reaching state \'S3\'");
            this.Manager.Comment("checking step \'return Login\'");
            this.Manager.Comment("reaching state \'S23\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS2LoginSuccessfulChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S34\'");
                this.Manager.Comment("executing step \'call Purchase(\"manuel\",\"pc\")\'");
                TestAdapter.SystemUnderTest.Purchase("manuel", "pc");
                this.Manager.Comment("reaching state \'S45\'");
                this.Manager.Comment("checking step \'return Purchase\'");
                this.Manager.Comment("reaching state \'S56\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS2PurchaseFailedChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S67\'");
                    this.Manager.Comment("executing step \'call Logout(\"admin\")\'");
                    TestAdapter.SystemUnderTest.Logout("admin");
                    this.Manager.Comment("reaching state \'S76\'");
                    this.Manager.Comment("checking step \'return Logout\'");
                    this.Manager.Comment("reaching state \'S82\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS2PurchaseFailedChecker)));
                }
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS2LoginSuccessfulChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void PurchaseScenarioTestsS2LoginSuccessfulChecker(string obj_p1) {
            this.Manager.Comment("checking step \'event LoginSuccessful(\"admin\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "admin", obj_p1, "obj_p1 of LoginSuccessful, state S23");
        }
        
        private void PurchaseScenarioTestsS2PurchaseFailedChecker(string arg1_p1, string arg2_p2, string arg3_p3) {
            this.Manager.Comment("checking step \'event PurchaseFailed(\"manuel\",\"pc\",\"user is not logged in\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "manuel", arg1_p1, "arg1_p1 of PurchaseFailed, state S56");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "pc", arg2_p2, "arg2_p2 of PurchaseFailed, state S56");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "user is not logged in", arg3_p3, "arg3_p3 of PurchaseFailed, state S56");
        }
        #endregion
        
        #region Test Starting in S20
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void PurchaseScenarioTestsS20() {
            this.Manager.BeginTest("PurchaseScenarioTestsS20");
            this.Manager.Comment("reaching state \'S20\'");
            this.Manager.Comment("executing step \'call Login(\"guest\",\"geheim\")\'");
            TestAdapter.SystemUnderTest.Login("guest", "geheim");
            this.Manager.Comment("reaching state \'S21\'");
            this.Manager.Comment("checking step \'return Login\'");
            this.Manager.Comment("reaching state \'S32\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS20LoginSuccessfulChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S43\'");
                this.Manager.Comment("executing step \'call Logout(\"guest\")\'");
                TestAdapter.SystemUnderTest.Logout("guest");
                this.Manager.Comment("reaching state \'S54\'");
                this.Manager.Comment("checking step \'return Logout\'");
                this.Manager.Comment("reaching state \'S65\'");
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS20LoginSuccessfulChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void PurchaseScenarioTestsS20LoginSuccessfulChecker(string obj_p1) {
            this.Manager.Comment("checking step \'event LoginSuccessful(\"guest\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "guest", obj_p1, "obj_p1 of LoginSuccessful, state S32");
        }
        #endregion
        
        #region Test Starting in S4
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void PurchaseScenarioTestsS4() {
            this.Manager.BeginTest("PurchaseScenarioTestsS4");
            this.Manager.Comment("reaching state \'S4\'");
            this.Manager.Comment("executing step \'call Login(\"admin\",\"geheim\")\'");
            TestAdapter.SystemUnderTest.Login("admin", "geheim");
            this.Manager.Comment("reaching state \'S5\'");
            this.Manager.Comment("checking step \'return Login\'");
            this.Manager.Comment("reaching state \'S24\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS4LoginSuccessfulChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S35\'");
                this.Manager.Comment("executing step \'call Purchase(\"guest\",\"pc\")\'");
                TestAdapter.SystemUnderTest.Purchase("guest", "pc");
                this.Manager.Comment("reaching state \'S46\'");
                this.Manager.Comment("checking step \'return Purchase\'");
                this.Manager.Comment("reaching state \'S57\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS4PurchaseFailedChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S68\'");
                    this.Manager.Comment("executing step \'call Logout(\"admin\")\'");
                    TestAdapter.SystemUnderTest.Logout("admin");
                    this.Manager.Comment("reaching state \'S77\'");
                    this.Manager.Comment("checking step \'return Logout\'");
                    this.Manager.Comment("reaching state \'S83\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS4PurchaseFailedChecker)));
                }
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS4LoginSuccessfulChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void PurchaseScenarioTestsS4LoginSuccessfulChecker(string obj_p1) {
            this.Manager.Comment("checking step \'event LoginSuccessful(\"admin\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "admin", obj_p1, "obj_p1 of LoginSuccessful, state S24");
        }
        
        private void PurchaseScenarioTestsS4PurchaseFailedChecker(string arg1_p1, string arg2_p2, string arg3_p3) {
            this.Manager.Comment("checking step \'event PurchaseFailed(\"guest\",\"pc\",\"user is not logged in\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "guest", arg1_p1, "arg1_p1 of PurchaseFailed, state S57");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "pc", arg2_p2, "arg2_p2 of PurchaseFailed, state S57");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "user is not logged in", arg3_p3, "arg3_p3 of PurchaseFailed, state S57");
        }
        #endregion
        
        #region Test Starting in S6
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void PurchaseScenarioTestsS6() {
            this.Manager.BeginTest("PurchaseScenarioTestsS6");
            this.Manager.Comment("reaching state \'S6\'");
            this.Manager.Comment("executing step \'call Login(\"admin\",\"geheim\")\'");
            TestAdapter.SystemUnderTest.Login("admin", "geheim");
            this.Manager.Comment("reaching state \'S7\'");
            this.Manager.Comment("checking step \'return Login\'");
            this.Manager.Comment("reaching state \'S25\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS6LoginSuccessfulChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S36\'");
                this.Manager.Comment("executing step \'call Logout(\"admin\")\'");
                TestAdapter.SystemUnderTest.Logout("admin");
                this.Manager.Comment("reaching state \'S47\'");
                this.Manager.Comment("checking step \'return Logout\'");
                this.Manager.Comment("reaching state \'S58\'");
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.LoginSuccessfulInfo, null, new LoginSuccessfulDelegate1(this.PurchaseScenarioTestsS6LoginSuccessfulChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void PurchaseScenarioTestsS6LoginSuccessfulChecker(string obj_p1) {
            this.Manager.Comment("checking step \'event LoginSuccessful(\"admin\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "admin", obj_p1, "obj_p1 of LoginSuccessful, state S25");
        }
        #endregion
        
        #region Test Starting in S8
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void PurchaseScenarioTestsS8() {
            this.Manager.BeginTest("PurchaseScenarioTestsS8");
            this.Manager.Comment("reaching state \'S8\'");
            this.Manager.Comment("executing step \'call Login(\"manuel\",\"geheim\")\'");
            TestAdapter.SystemUnderTest.Login("manuel", "geheim");
            this.Manager.Comment("reaching state \'S9\'");
            this.Manager.Comment("checking step \'return Login\'");
            this.Manager.Comment("reaching state \'S26\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.UnknownUserInfo, null, new UnknownUserDelegate1(this.PurchaseScenarioTestsS8UnknownUserChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S37\'");
                this.Manager.Comment("executing step \'call Purchase(\"admin\",\"pc\")\'");
                TestAdapter.SystemUnderTest.Purchase("admin", "pc");
                this.Manager.Comment("reaching state \'S48\'");
                this.Manager.Comment("checking step \'return Purchase\'");
                this.Manager.Comment("reaching state \'S59\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS8PurchaseFailedChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S69\'");
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.PurchaseFailedInfo, null, new PurchaseFailedDelegate1(this.PurchaseScenarioTestsS8PurchaseFailedChecker)));
                }
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(PurchaseScenarioTests.UnknownUserInfo, null, new UnknownUserDelegate1(this.PurchaseScenarioTestsS8UnknownUserChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void PurchaseScenarioTestsS8UnknownUserChecker(string obj_p1) {
            this.Manager.Comment("checking step \'event UnknownUser(\"manuel\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "manuel", obj_p1, "obj_p1 of UnknownUser, state S26");
        }
        
        private void PurchaseScenarioTestsS8PurchaseFailedChecker(string arg1_p1, string arg2_p2, string arg3_p3) {
            this.Manager.Comment("checking step \'event PurchaseFailed(\"admin\",\"pc\",\"user is not logged in\")\'");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "admin", arg1_p1, "arg1_p1 of PurchaseFailed, state S59");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "pc", arg2_p2, "arg2_p2 of PurchaseFailed, state S59");
            TestManagerHelpers.AssertAreEqual<string>(this.Manager, "user is not logged in", arg3_p3, "arg3_p3 of PurchaseFailed, state S59");
        }
        #endregion
    }
}