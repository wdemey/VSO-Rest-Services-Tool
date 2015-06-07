using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VSO_Rest_Services
{
    public class Entities
    {
        public class ApiCollection<T>
        {
            [JsonProperty("value")]
            public IEnumerable<T> Value { get; set; }

            [JsonProperty("count")]
            public int Count { get; set; }
        }

        public class AssociatedBug
        {
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        
        public class Project
        {
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
            [JsonProperty("state")]
            public string state { get; set; }
        }

        public class Owner
        {
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("displayName")]
            public string displayName { get; set; }
        }

        public class Configuration
        {
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
        }

        public class Person
        {
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("displayName")]
            public string displayName { get; set; }
            [JsonProperty("uniqueName")]
            public string uniqueName { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
            [JsonProperty("imageUrl")]
            public string imageUrl { get; set; }
        }



        public class Parent
        {
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }



        public class TestPlan
        {
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }

        }

        public class ChildTestSuite
        {
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }


        public class TestSuite
        {
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
            [JsonProperty("project")]
            public Project project { get; set; }
            [JsonProperty("plan")]
            public TestPlan testplan { get; set; }
            [JsonProperty("parent")]
            public Parent parent { get; set; }
            [JsonProperty("revision")]
            public int revision { get; set; }
            [JsonProperty("testCaseCount")]
            public int testCaseCount { get; set; }
            [JsonProperty("suiteType")]
            public string suiteType { get; set; }
            [JsonProperty("suites")]
            public IList<ChildTestSuite> childTestSuites { get; set; }
            [JsonProperty("testCasesUrl")]
            public string testCasesUrl { get; set; }
            [JsonProperty("inheritDefaultConfigurations")]
            public bool inheritDefaultConfigurations { get; set; }
            [JsonProperty("defaultConfigurations")]
            public IList<Configuration> defaultConfigurations { get; set; }
            [JsonProperty("state")]
            public string state { get; set; }
            [JsonProperty("lastUpdatedBy")]
            public Person lastUpdatedBy { get; set; }
            [JsonProperty("lastUpdatedDate")]
            public DateTime lastUpdatedDate { get; set; }
            [JsonProperty("requirementId")]
            public int requirementId { get; set; }
            [JsonProperty("lastPopulatedDate")]
            public DateTime lastPopulatedDate { get; set; }
        }

        public class TestPoint
        {
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
            [JsonProperty("assignedTo")]
            public Person assignedTo { get; set; }
            [JsonProperty("configuration")]
            public Configuration configuration { get; set; }
            [JsonProperty("failureType")]
            public string failureType { get; set; }
            [JsonProperty("lastTestRun")]
            public TestRun lastTestRun { get; set; }
            [JsonProperty("lastResult")]
            public TestResult lastResult { get; set; }
            [JsonProperty("lastUpdatedDate")]
            public DateTime lastUpdatedDate { get; set; }
            [JsonProperty("lastUpdatedBy")]
            public Person lastUpdatedBy { get; set; }
            [JsonProperty("outcome")]
            public string outcome { get; set; }
            [JsonProperty("revision")]
            public int revision { get; set; }
            [JsonProperty("state")]
            public string state { get; set; }
            [JsonProperty("suite")]
            public TestSuite suite { get; set; }
            [JsonProperty("testCase")]
            public TestCase testCase { get; set; }
            [JsonProperty("testPlan")]
            public TestPlan testPlan { get; set; }
            [JsonProperty("workItemProperties")]
            public IList<WorkItemProperty> workItemProperties { get; set; }
        }

        public class TestCase
        {
            [JsonProperty("id")]
            public string id { get; set; }
            [JsonProperty("title")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
            [JsonProperty("webUrl")]
            public string webUrl { get; set; }
        }


        public class TestResult
        {
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("configuration")]
            public Configuration configuration { get; set; }
            [JsonProperty("project")]
            public Project project { get; set; }
            [JsonProperty("startedDate")]
            public DateTime startedDate { get; set; }
            [JsonProperty("completedDate")]
            public DateTime completedDate { get; set; }
            [JsonProperty("outcome")]
            public string outcome { get; set; }
            [JsonProperty("owner")]
            public Owner owner { get; set; }
            [JsonProperty("revision")]
            public int revision { get; set; }
            [JsonProperty("runBy")]
            public Person runBy { get; set; }
            [JsonProperty("state")]
            public string state { get; set; }
            [JsonProperty("testCase")]
            public TestCase testCase { get; set; }
            [JsonProperty("testRun")]
            public TestRun testRun { get; set; }
            [JsonProperty("lastUpdatedDate")]
            public DateTime lastUpdatedDate { get; set; }
            [JsonProperty("lastUpdatedBy")]
            public Person lastUpdatedBy { get; set; }
            [JsonProperty("priority")]
            public int priority { get; set; }
            [JsonProperty("computerName")]
            public string computerName { get; set; }
            [JsonProperty("createdDate")]
            public DateTime createdDate { get; set; }
            [JsonProperty("associatedBugs")]
            public IList<AssociatedBug> associatedBugs { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }



        public class TestRun
        {
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
            [JsonProperty("isAutomated")]
            public bool isAutomated { get; set; }
            [JsonProperty("iteration")]
            public string iteration { get; set; }
            [JsonProperty("owner")]
            public Owner owner { get; set; }
            [JsonProperty("project")]
            public Project project { get; set; }
            [JsonProperty("startedDate")]
            public DateTime startedDate { get; set; }
            [JsonProperty("completedDate")]
            public DateTime completedDate { get; set; }
            [JsonProperty("state")]
            public string state { get; set; }
            [JsonProperty("plan")]
            public TestPlan testplan { get; set; }
            [JsonProperty("postProcessState")]
            public string postProcessState { get; set; }
            [JsonProperty("totalTests")]
            public int totalTests { get; set; }
            [JsonProperty("passedTests")]
            public int passedTests { get; set; }
            [JsonProperty("createdDate")]
            public DateTime createdDate { get; set; }
            [JsonProperty("lastUpdatedDate")]
            public DateTime lastUpdatedDate { get; set; }
            [JsonProperty("lastUpdatedBy")]
            public Person lastUpdatedBy { get; set; }
            [JsonProperty("revision")]
            public int revision { get; set; }
            [JsonProperty("runStatistics")]
            public IList<TestRunStatistic> runStatistics { get; set; }
            [JsonProperty("webAccessUrl")]
            public string webAccessUrl { get; set; }
            [JsonProperty("unanalyzedTests")]
            public int? unanalyzedTests { get; set; }
            [JsonProperty("notApplicableTests")]
            public int? notApplicableTests { get; set; }
            [JsonProperty("incompleteTests")]
            public int? incompleteTests { get; set; }
        }

        public class TestRunStatistic
        {
            [JsonProperty("state")]
            public string state { get; set; }
            [JsonProperty("outcome")]
            public string outcome { get; set; }
            [JsonProperty("count")]
            public int count { get; set; }
        }

        public class WorkItem
        {
            [JsonProperty("key")]
            public string key { get; set; }
            [JsonProperty("value")]
            public string value { get; set; }
        }

        public class WorkItemProperty
        {
            [JsonProperty("workItem")]
            public WorkItem workItem { get; set; }
        }

        
        public class Target
        {
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class Source
        {
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("url")]
            public string url { get; set; }
        }

        public class WorkItemRelation
        {
            [JsonProperty("target")]
            public Target target { get; set; }
            [JsonProperty("source")]
            public Source source { get; set; }
        }

        public class QueryResult
        {
            [JsonProperty("queryType")]
            public string queryType { get; set; }
            [JsonProperty("queryResultType")]
            public string queryResultType { get; set; }
            [JsonProperty("asOf")]
            public DateTime asOf { get; set; }
            [JsonProperty("workItemRelations")]
            public IList<WorkItemRelation> workItemRelations { get; set; }
        }


    }
}
