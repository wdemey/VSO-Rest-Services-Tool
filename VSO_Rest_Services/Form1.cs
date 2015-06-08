namespace VSO_Rest_Services
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Microsoft.Office.Interop.Excel;

    public partial class frmMain : Form
    {
        String strUser = String.Empty;
        String strPassword = String.Empty;
        String strURL = String.Empty;
        String strTestPlanID = String.Empty;
        String strTestSuiteID = String.Empty;
        String strNumberOfSuites;
        String strMessage = String.Empty;
        String strBaseURL = String.Empty;
        String strProject = String.Empty;
        String strPath = String.Empty;
        String strFullPath = String.Empty;
        String strTestSuiteTreePath = String.Empty;
        String strResponseBody = String.Empty;
        String strTempText = String.Empty;
        String strBugIDs = String.Empty;
        String strJsonContent = String.Empty;
        int intTestSuiteID;
        HttpClient oClient;
        _Application oExcel;
        _Workbook oWorkbook;
        _Worksheet oWorksheet;
        

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCallService_Click(object sender, EventArgs e)
        {
            ValidateFields();
            if (String.IsNullOrEmpty(strMessage))
            {
                CallService();
            }
        }

        private void ValidateFields()
        {
            //Check if fields are filled in
            if(String.IsNullOrEmpty(txtUser.Text))
            {
                strMessage = strMessage + "Field 'User' is empty.";
            }
            else
            {
                strUser = txtUser.Text;
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                strMessage = strMessage + Environment.NewLine + "Field 'Password' is empty.";
            }
            else
            {
                strPassword = txtPassword.Text;
            }

            if (String.IsNullOrEmpty(txtURL.Text))
            {
                strMessage = strMessage + Environment.NewLine + "Field 'URL' is empty.";
            }
            else
            {
                strURL = txtURL.Text;
            }

            if (String.IsNullOrEmpty(txtProject.Text))
            {
                strMessage = strMessage + Environment.NewLine + "Field 'Project' is empty.";
            }
            else
            {
                strProject = txtProject.Text;
            }

            if (String.IsNullOrEmpty(txtTestPlanID.Text))
            {
                strMessage = strMessage + Environment.NewLine + "Field 'Test Plan ID' is empty.";
            }
            else
            {
                strTestPlanID = txtTestPlanID.Text;
            }


            txtMessage.Text = strMessage;
        }
        public async void CallService()
        {
            Entities.ApiCollection<Entities.TestSuite> TestSuites;           
            Entities.ApiCollection<Entities.TestPoint> TestPoints;
            Entities.TestSuite TestSuite_Temp;
            Entities.TestResult TestResult_Temp;
            Entities.QueryResult QueryResult_Temp;
            Boolean blnTestSuiteParentFound = true;

  
            using (HttpClient oClient = new HttpClient())
            {
                try
                {
                    oClient.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    //Set alternate credentials
                    oClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", strUser, strPassword))));
                    txtMessage.Text = "Service called";            
                    
                    //Get a response back containing a list
                    strBaseURL = strURL + "/DefaultCollection/" + strProject + "/_apis/test/plans/" + strTestPlanID + "/suites/" + strTestSuiteID + "?api-version=" + txtAPIVersion.Text;
                    strResponseBody = await GetAsync(oClient, strBaseURL);
                    txtMessage.Text =  txtMessage.Text + Environment.NewLine + "Response received";
                    TestSuites = JsonConvert.DeserializeObject<Entities.ApiCollection<Entities.TestSuite>>(strResponseBody);

                    if (TestSuites.Value.Count() > 0)

                        strNumberOfSuites = TestSuites.Value.Count().ToString();
                        //Create Excel file to write data into
                        oExcel = new Microsoft.Office.Interop.Excel.Application();
                        if(oExcel == null)
                        {
                            txtMessage.Text = txtMessage.Text + Environment.NewLine + "Problems with installation of Excel. Check with your helpdesk.";
                            return;
                        }
                        else
                        {
                            txtMessage.Text = txtMessage.Text + Environment.NewLine + strNumberOfSuites + " test suites found to process to Excel. This can take some minutes.";
                            strTempText = txtMessage.Text;
                            //Create workbook & get access to first sheet
                            oExcel.Visible = false;
                            oWorkbook = oExcel.Workbooks.Add();
                            oWorksheet = oWorkbook.Worksheets.get_Item(1);

                            //Write headers
                            oWorksheet.Cells[1,1] = "TESTPLAN";
                            oWorksheet.Cells[1,2] = "TESTPLAN_ID";
                            oWorksheet.Cells[1,3] = "TEST TREE PATH";
                            oWorksheet.Cells[1,4] = "TESTSUITE";
                            oWorksheet.Cells[1,5] = "TESTSUITE_ID";
                            oWorksheet.Cells[1,6] = "TESTCASE";
                            oWorksheet.Cells[1,7] = "TESTCASE_ID";
                            oWorksheet.Cells[1,8] = "TESTCASE_PRIORITY";
                            oWorksheet.Cells[1,9] = "LAST STATUS";
                            oWorksheet.Cells[1,10] = "LAST EXECUTED ON";
                            oWorksheet.Cells[1,11] = "LAST EXECUTED BY";
                            oWorksheet.Cells[1,12] = "N° OF ASSOCIATED BUGS";
                            oWorksheet.Cells[1,13] = "ASSOCIATED BUG ID'S";
                        }

                        int intRow = 1;
                        int x = 0;

                        foreach (var TestSuite in TestSuites.Value)
                        {
                            x = x + 1;

                            if (TestSuite.testCaseCount > 0)
                            {
                                //Get for each test case in test suite latest status
                                strBaseURL = strURL + "/DefaultCollection/" + strProject + "/_apis/test/plans/" + strTestPlanID + "/suites/" + TestSuite.id + "/points?witFields=System.Title,System.Id,Microsoft.VSTS.Common.Priority&includePointDetails=true&api-version=" + txtAPIVersion.Text;
                                //Get a response back containing a list
                                strResponseBody = await GetAsync(oClient, strBaseURL);
                                if(strResponseBody != String.Empty)
                                {
                                    TestPoints = JsonConvert.DeserializeObject<Entities.ApiCollection<Entities.TestPoint>>(strResponseBody);
                                    if (TestPoints.Value.Count() > 0)

                                        //Retrieve path in test suite tree
                                        strTestSuiteTreePath = String.Empty;
                                        if (TestSuite.parent != null)
                                        {
                                            intTestSuiteID = Convert.ToInt32(TestSuite.parent.id);
                                            strTestSuiteTreePath = TestSuite.name;
                                            blnTestSuiteParentFound = true;

                                            while (blnTestSuiteParentFound == true)
                                            {
                                                strBaseURL = strURL + "/DefaultCollection/" + strProject + "/_apis/test/plans/" + strTestPlanID + "/suites/" + intTestSuiteID + "?api-version=" + txtAPIVersion.Text;
                                                //Get a response back containing test suite info
                                                strResponseBody = await GetAsync(oClient, strBaseURL);
                                                TestSuite_Temp = JsonConvert.DeserializeObject<Entities.TestSuite>(strResponseBody);

                                                if (TestSuite_Temp.parent == null)
                                                {
                                                    blnTestSuiteParentFound = false;
                                                    strTestSuiteTreePath = TestSuite_Temp.name + "\\" + strTestSuiteTreePath;
                                                }
                                                else
                                                {
                                                    strTestSuiteTreePath = TestSuite_Temp.name + "\\" + strTestSuiteTreePath;
                                                    intTestSuiteID = Convert.ToInt32(TestSuite_Temp.parent.id);
                                                }

                                            }
                                        }
                                        else
                                        {
                                            strTestSuiteTreePath = TestSuite.name;
                                        }

                                        foreach (var TestPoint in TestPoints.Value)
                                        {
                                            intRow = intRow + 1;

                                            //Write all info to the Excel
                                            oWorksheet.Cells[intRow, 1] = TestSuite.testplan.name;
                                            oWorksheet.Cells[intRow, 2] = TestSuite.testplan.id;
                                            oWorksheet.Cells[intRow, 3] = strTestSuiteTreePath;
                                            oWorksheet.Cells[intRow, 4] = TestSuite.name;
                                            oWorksheet.Cells[intRow, 5] = TestSuite.id;
                                            oWorksheet.Cells[intRow, 6] = TestPoint.workItemProperties[0].workItem.value;
                                            oWorksheet.Cells[intRow, 7] = TestPoint.workItemProperties[1].workItem.value;
                                            oWorksheet.Cells[intRow, 8] = TestPoint.workItemProperties[2].workItem.value;
                                            oWorksheet.Cells[intRow, 9] = TestPoint.outcome;
                                            oWorksheet.Cells[intRow, 10] = TestPoint.lastUpdatedDate;
                                            oWorksheet.Cells[intRow, 11] = TestPoint.lastUpdatedBy.displayName;

                                            if (rbtYes.Checked)
                                            {
                                                //Post a query to get all linked bugs for the test case
                                                strJsonContent = "{\"query\": \"Select * From WorkItemLinks where Source.[System.WorkItemType] = 'Test Case'"
                                                                 + " and Source.[System.Id] = " + TestPoint.workItemProperties[1].workItem.value
                                                                 + " and [System.Links.LinkType] <> ''"
                                                                 + " and Target.[System.WorkItemType] = 'Bug'"
                                                                 + " ORDER BY [System.Id] ASC MODE(mustcontain)\"}";
                                                strBaseURL = strURL + "/DefaultCollection/" + strProject + "/_apis/wit/wiql?api-version=1.0";

                                                strResponseBody = await PostAsync(oClient, strJsonContent, strBaseURL);
                                                if (strResponseBody != string.Empty)
                                                {
                                                    QueryResult_Temp = JsonConvert.DeserializeObject<Entities.QueryResult>(strResponseBody);
                                                    if (QueryResult_Temp.workItemRelations.Count > 0)
                                                    {
                                                        strBugIDs = String.Empty;
                                                        int intAssociatedBugs = 0;
                                                        for (int i = 0; i < QueryResult_Temp.workItemRelations.Count; i++)
                                                            if (QueryResult_Temp.workItemRelations[i].target.id.ToString() != TestPoint.workItemProperties[1].workItem.value)
                                                            {
                                                                strBugIDs = strBugIDs + QueryResult_Temp.workItemRelations[i].target.id + ";";
                                                                intAssociatedBugs = intAssociatedBugs + 1;
                                                            }
                                                        oWorksheet.Cells[intRow, 12] = intAssociatedBugs;
                                                        oWorksheet.Cells[intRow, 13] = strBugIDs;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            
                            txtMessage.Text = strTempText + Environment.NewLine + x + " of " + strNumberOfSuites + " test suites processed.";  
                        }
                        
                        //Save all info in file into MyDocuments folder
                        //Filename is unique and contains datetime 
                        strPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        strFullPath = strPath + "\\CSM_Test Info_" + DateTime.Now.ToString(format: "dd_MM_yyyy hh_mm") + ".xlsx";
                        oWorkbook.SaveAs(strFullPath);
                        oWorkbook.Close();
                        txtMessage.Text = txtMessage.Text + Environment.NewLine + "All results are processed to Excel." + Environment.NewLine + "File created: "  + strFullPath;
                    }
                catch(Exception myException)
                {
                    txtMessage.Text = txtMessage.Text + Environment.NewLine + myException.ToString();
                }
             }
        }

        public async Task<String> GetAsync(HttpClient myClient, String myUrl)
        {
            var responseBody = String.Empty;

            try
            {
                using (HttpResponseMessage response = myClient.GetAsync(myUrl).Result)
                {
                    if(response.StatusCode.ToString() == "OK")
                    {
                        responseBody = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        responseBody = string.Empty;
                    }
                }
            }
            catch (Exception myException)
            {
                
                txtMessage.Text = txtMessage.Text + Environment.NewLine + myException.ToString();
            }

            return responseBody;
        }

        public async Task<String> PostAsync(HttpClient myClient, String myJSON, String myUrl)
        {
            var responseBody = String.Empty;

            var content = new StringContent(myJSON,Encoding.UTF8,"application/json");

            try
            {
                using (HttpResponseMessage response = myClient.PostAsync(myUrl, content).Result)
                {
                    response.EnsureSuccessStatusCode();
                    responseBody = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception myException)
            {

                txtMessage.Text = txtMessage.Text + Environment.NewLine + myException.ToString();
            }
            return responseBody;
        }

             
        private void btnClose_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rbtYes.Checked=true;
            txtAPIVersion.Text = "1.0";
            txtUser.Text = "TAGUEST";
            txtURL.Text = "https://euroconsumers.visualstudio.com";
            txtProject.Text = "CSM";
            txtTestPlanID.Text = "287";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMessage.Text = String.Empty;
            rbtYes.Checked = true;
            strMessage = String.Empty;
            //This is a comment
        }

     }
}
