using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VideoRSSDb.UnitTests
{
    [TestClass()]
    public class GetNewTorrentTests : SqlDatabaseTestClass
    {

        public GetNewTorrentTests()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetNewTorrentTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction should_return_id_of_entered_torrent_that_does_not_exist_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction should_return_id_of_entered_torrent_that_does_not_exist_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction should_raise_error_with_no_table_entered_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            this.should_return_id_of_entered_torrent_that_does_not_existData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.should_raise_error_with_no_table_enteredData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            should_return_id_of_entered_torrent_that_does_not_exist_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            should_return_id_of_entered_torrent_that_does_not_exist_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            should_raise_error_with_no_table_entered_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // testInitializeAction
            // 
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // should_return_id_of_entered_torrent_that_does_not_existData
            // 
            this.should_return_id_of_entered_torrent_that_does_not_existData.PosttestAction = null;
            this.should_return_id_of_entered_torrent_that_does_not_existData.PretestAction = should_return_id_of_entered_torrent_that_does_not_exist_PretestAction;
            this.should_return_id_of_entered_torrent_that_does_not_existData.TestAction = should_return_id_of_entered_torrent_that_does_not_exist_TestAction;
            // 
            // should_return_id_of_entered_torrent_that_does_not_exist_TestAction
            // 
            should_return_id_of_entered_torrent_that_does_not_exist_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(should_return_id_of_entered_torrent_that_does_not_exist_TestAction, "should_return_id_of_entered_torrent_that_does_not_exist_TestAction");
            // 
            // should_return_id_of_entered_torrent_that_does_not_exist_PretestAction
            // 
            resources.ApplyResources(should_return_id_of_entered_torrent_that_does_not_exist_PretestAction, "should_return_id_of_entered_torrent_that_does_not_exist_PretestAction");
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "test_1112344";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // should_raise_error_with_no_table_enteredData
            // 
            this.should_raise_error_with_no_table_enteredData.PosttestAction = null;
            this.should_raise_error_with_no_table_enteredData.PretestAction = null;
            this.should_raise_error_with_no_table_enteredData.TestAction = should_raise_error_with_no_table_entered_TestAction;
            // 
            // should_raise_error_with_no_table_entered_TestAction
            // 
            should_raise_error_with_no_table_entered_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(should_raise_error_with_no_table_entered_TestAction, "should_raise_error_with_no_table_entered_TestAction");
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "Operand type clash: NULL is incompatible with torrent_id_table_type";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // GetNewTorrentTests
            // 
            this.TestInitializeAction = testInitializeAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void should_return_id_of_entered_torrent_that_does_not_exist()
        {
            SqlDatabaseTestActions testActions = this.should_return_id_of_entered_torrent_that_does_not_existData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void should_raise_error_with_no_table_entered()
        {
            SqlDatabaseTestActions testActions = this.should_raise_error_with_no_table_enteredData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        private SqlDatabaseTestActions should_return_id_of_entered_torrent_that_does_not_existData;
        private SqlDatabaseTestActions should_raise_error_with_no_table_enteredData;
    }
}
