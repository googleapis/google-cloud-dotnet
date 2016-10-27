// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2.Data;
using Google.Cloud.ClientTesting;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Xunit;
using System.Collections;
using System.IO;

namespace Google.Bigquery.V2.Tests
{
    public class BigqueryClientTest : AbstractClientTester<BigqueryClient, BigqueryClientTest.DerivedBigqueryClient>
    {
        private const string ProjectId = "sample-project";

        public static IEnumerable<object[]> NotImplementedMethods => AllInstanceMethods
            .Where(array =>
            {
                var method = (MethodInfo)array[0];
                // The Get*Reference methods are actually implemented...
                if (method.Name.StartsWith("Get") && method.Name.EndsWith("Reference"))
                {
                    return false;
                }
                // For methods with overloads, where there's a "core" overload accepting a *Reference type,
                // only check that that one is not implemented - the others should be tested for delegation
                // separately. (Testing them here creates confusing coverage.)
                var overloads = typeof(BigqueryClient).GetTypeInfo().GetDeclaredMethods(method.Name);
                var referenceAcceptingOverload = overloads.FirstOrDefault(
                    o => o.GetParameters().FirstOrDefault()?.ParameterType.Name.EndsWith("Reference") == true);
                return referenceAcceptingOverload == null || referenceAcceptingOverload == method;
            });

        public class DerivedBigqueryClient : BigqueryClient
        {
            public override string ProjectId => BigqueryClientTest.ProjectId;
        }

        [Theory]
        [MemberData(nameof(NotImplementedMethods))]
        public void NotImplementedMethodsThrow(MethodInfo method)
        {
            AssertNotImplemented(method);
        }

        protected override object GetArgument(ParameterInfo parameter)
        {
            if (parameter.ParameterType == typeof(InsertRow))
            {
                return new InsertRow();
            }
            return base.GetArgument(parameter);
        }

        [Fact]
        public void GetJobReference_ImplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetJobReference("jobid");
            Assert.Equal("jobid", reference.JobId);
            Assert.Equal(ProjectId, reference.ProjectId);
        }

        [Fact]
        public void GetJobReference_ExplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetJobReference("p", "jobid");
            Assert.Equal("jobid", reference.JobId);
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void GetTableReference_ImplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetTableReference("datasetid", "tableid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("tableid", reference.TableId);
            Assert.Equal(ProjectId, reference.ProjectId);
        }

        [Fact]
        public void GetTableReference_ExplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetTableReference("p", "datasetid", "tableid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("tableid", reference.TableId);
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void GetDatasetReference_ImplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetDatasetReference("datasetid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal(ProjectId, reference.ProjectId);
        }

        [Fact]
        public void GetDatasetReference_ExplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetDatasetReference("p", "datasetid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void GetProjectReference_ExplicitProject()
        {
            var reference = new DerivedBigqueryClient().GetProjectReference("p");
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void CreateDatasetEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new CreateDatasetOptions();
            VerifyEquivalent(new BigqueryDataset(new DerivedBigqueryClient(), GetDataset(reference)),
                client => client.CreateDataset(MatchesWhenSerialized(reference), options),
                client => client.CreateDataset(datasetId, options),
                client => client.CreateDataset(ProjectId, datasetId, options));
        }

        [Fact]
        public void DeleteDatasetEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new DeleteDatasetOptions();
            VerifyEquivalent(
                client => client.DeleteDataset(MatchesWhenSerialized(reference), options),
                client => client.DeleteDataset(datasetId, options),
                client => client.DeleteDataset(ProjectId, datasetId, options));
        }

        [Fact]
        public void GetDatasetEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new GetDatasetOptions();
            VerifyEquivalent(new BigqueryDataset(new DerivedBigqueryClient(), GetDataset(reference)),
                client => client.GetDataset(MatchesWhenSerialized(reference), options),
                client => client.GetDataset(datasetId, options),
                client => client.GetDataset(ProjectId, datasetId, options));
        }

        [Fact]
        public void GetOrCreateDatasetEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var getOptions = new GetDatasetOptions();
            var createOptions = new CreateDatasetOptions();
            VerifyEquivalent(new BigqueryDataset(new DerivedBigqueryClient(), GetDataset(reference)),
                client => client.GetOrCreateDataset(MatchesWhenSerialized(reference), getOptions, createOptions),
                client => client.GetOrCreateDataset(datasetId, getOptions, createOptions),
                client => client.GetOrCreateDataset(ProjectId, datasetId, getOptions, createOptions));
        }

        [Fact]
        public void ListDatasetsEquivalents()
        {
            var reference = new ProjectReference { ProjectId = ProjectId };
            var options = new ListDatasetsOptions();
            VerifyEquivalent(new UnimplementedPagedEnumerable<DatasetList, BigqueryDataset>(),
                client => client.ListDatasets(MatchesWhenSerialized(reference), options),
                client => client.ListDatasets(options),
                client => client.ListDatasets(ProjectId, options));
        }

        [Fact]
        public void CreateTableEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var schema = new TableSchemaBuilder().Build();
            var reference = GetTableReference(datasetId, tableId);
            var options = new CreateTableOptions();
            VerifyEquivalent(new BigqueryTable(new DerivedBigqueryClient(), GetTable(reference)),
                client => client.CreateTable(MatchesWhenSerialized(reference), schema, options),
                client => client.CreateTable(datasetId, tableId, schema, options),
                client => client.CreateTable(ProjectId, datasetId, tableId, schema, options),
                client => new BigqueryDataset(client, GetDataset(datasetId)).CreateTable(tableId, schema, options));
        }

        [Fact]
        public void DeleteTableEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var schema = new TableSchemaBuilder().Build();
            var reference = GetTableReference(datasetId, tableId);
            var options = new DeleteTableOptions();
            VerifyEquivalent(
                client => client.DeleteTable(MatchesWhenSerialized(reference), options),
                client => client.DeleteTable(datasetId, tableId, options),
                client => client.DeleteTable(ProjectId, datasetId, tableId, options),
                client => new BigqueryTable(client, new Table { TableReference = reference }).Delete(options));
        }

        [Fact]
        public void GetTableEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var options = new GetTableOptions();
            VerifyEquivalent(new BigqueryTable(new DerivedBigqueryClient(), GetTable(reference)),
                client => client.GetTable(MatchesWhenSerialized(reference), options),
                client => client.GetTable(datasetId, tableId, options),
                client => client.GetTable(ProjectId, datasetId, tableId, options),
                client => new BigqueryDataset(client, GetDataset(datasetId)).GetTable(tableId, options));
        }

        [Fact]
        public void GetOrCreateTableEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var schema = new TableSchemaBuilder().Build();
            var reference = GetTableReference(datasetId, tableId);
            var getOptions = new GetTableOptions();
            var createOptions = new CreateTableOptions();
            VerifyEquivalent(new BigqueryTable(new DerivedBigqueryClient(), GetTable(reference)),
                client => client.GetOrCreateTable(MatchesWhenSerialized(reference), schema, getOptions, createOptions),
                client => client.GetOrCreateTable(datasetId, tableId, schema, getOptions, createOptions),
                client => client.GetOrCreateTable(ProjectId, datasetId, tableId, schema, getOptions, createOptions),
                client => new BigqueryDataset(client, GetDataset(datasetId)).GetOrCreateTable(tableId, schema, getOptions, createOptions));
        }

        [Fact]
        public void ListTablesEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ListTablesOptions();
            VerifyEquivalent(new UnimplementedPagedEnumerable<TableList, BigqueryTable>(),
                client => client.ListTables(MatchesWhenSerialized(reference), options),
                client => client.ListTables(datasetId, options),
                client => client.ListTables(ProjectId, datasetId, options),
                client => new BigqueryDataset(client, GetDataset(datasetId)).ListTables(options));
        }

        [Fact]
        public void GetJobEquivalents()
        {
            var jobId = "job";
            var reference = GetJobReference(jobId);
            var options = new GetJobOptions();
            VerifyEquivalent(new BigqueryJob(new DerivedBigqueryClient(), GetJob(reference)),
                client => client.GetJob(MatchesWhenSerialized(reference), options),
                client => client.GetJob(jobId, options),
                client => client.GetJob(ProjectId, jobId, options));
        }

        [Fact]
        public void CancelJobEquivalents()
        {
            var jobId = "job";
            var reference = GetJobReference(jobId);
            var options = new CancelJobOptions();
            VerifyEquivalent(new BigqueryJob(new DerivedBigqueryClient(), GetJob(reference)),
                client => client.CancelJob(MatchesWhenSerialized(reference), options),
                client => client.CancelJob(jobId, options),
                client => client.CancelJob(ProjectId, jobId, options),
                client => new BigqueryJob(client, GetJob(reference)).Cancel(options));
        }

        [Fact]
        public void PollJobUntilCompletedEquivalents()
        {
            var jobId = "job";
            var reference = GetJobReference(jobId);
            var options = new PollJobOptions();
            VerifyEquivalent(new BigqueryJob(new DerivedBigqueryClient(), GetJob(reference)),
                client => client.PollJobUntilCompleted(MatchesWhenSerialized(reference), options),
                client => client.PollJobUntilCompleted(jobId, options),
                client => client.PollJobUntilCompleted(ProjectId, jobId, options),
                client => new BigqueryJob(client, GetJob(reference)).PollUntilCompleted(options));
        }

        [Fact]
        public void PollQueryUntilCompletedEquivalents()
        {
            var jobId = "job";
            var reference = GetJobReference(jobId);
            var getQueryResultsOptions = new GetQueryResultsOptions();
            var pollOptions = new PollJobOptions();
            VerifyEquivalent(
                new BigqueryQueryJob(new DerivedBigqueryClient(), new GetQueryResultsResponse { JobReference = reference }, getQueryResultsOptions),
                client => client.PollQueryUntilCompleted(MatchesWhenSerialized(reference), getQueryResultsOptions, pollOptions),
                client => client.PollQueryUntilCompleted(jobId, getQueryResultsOptions, pollOptions),
                client => client.PollQueryUntilCompleted(ProjectId, jobId, getQueryResultsOptions, pollOptions),
                client => new BigqueryJob(client, GetJob(reference)).PollQueryUntilCompleted(getQueryResultsOptions, pollOptions),
                client => new BigqueryQueryJob(client, new GetQueryResultsResponse { JobReference = reference }, getQueryResultsOptions).PollUntilCompleted(pollOptions));
        }

        [Fact]
        public void ListJobsEquivalents()
        {
            var reference = new ProjectReference { ProjectId = ProjectId };
            var options = new ListJobsOptions();
            VerifyEquivalent(new UnimplementedPagedEnumerable<JobList, BigqueryJob>(),
                client => client.ListJobs(MatchesWhenSerialized(reference), options),
                client => client.ListJobs(options),
                client => client.ListJobs(ProjectId, options));
        }

        [Fact]
        public void ListRowsEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new ListRowsOptions();
            VerifyEquivalent(new UnimplementedPagedEnumerable<TableDataList, BigqueryRow>(),
                client => client.ListRows(MatchesWhenSerialized(reference), schema, options),
                client => client.ListRows(datasetId, tableId, schema, options),
                client => client.ListRows(ProjectId, datasetId, tableId, schema, options),
                client => new BigqueryTable(client, GetTable(reference, schema)).ListRows(options));
        }

        [Fact]
        public void UploadCsvEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadCsvOptions();
            var stream = new MemoryStream();
            VerifyEquivalent(new BigqueryJob(new DerivedBigqueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadCsv(MatchesWhenSerialized(tableReference), schema, stream, options),
                client => client.UploadCsv(datasetId, tableId, schema, stream, options),
                client => client.UploadCsv(ProjectId, datasetId, tableId, schema, stream, options),
                client => new BigqueryTable(client, GetTable(tableReference, schema)).UploadCsv(stream, options));
        }

        [Fact]
        public void UploadJsonEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadJsonOptions();
            var stream = new MemoryStream();
            VerifyEquivalent(new BigqueryJob(new DerivedBigqueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadJson(MatchesWhenSerialized(tableReference), schema, stream, options),
                client => client.UploadJson(datasetId, tableId, schema, stream, options),
                client => client.UploadJson(ProjectId, datasetId, tableId, schema, stream, options),
                client => new BigqueryTable(client, GetTable(tableReference, schema)).UploadJson(stream, options));
        }

        [Fact]
        public void InsertEquivalents_SingleRow()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = new TableReference { ProjectId = ProjectId, DatasetId = datasetId, TableId = tableId };
            var schema = new TableSchemaBuilder().Build();
            var options = new InsertOptions();
            var stream = new MemoryStream();
            var row = new InsertRow();
            VerifyEquivalent(
                client => client.Insert(MatchesWhenSerialized(reference), new[] { row }, options),
                client => client.Insert(datasetId, tableId, row, options),
                client => client.Insert(ProjectId, datasetId, tableId, row, options),
                client => new BigqueryTable(client, GetTable(reference)).Insert(row, options));
        }

        [Fact]
        public void InsertEquivalents_RowCollection()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = new TableReference { ProjectId = ProjectId, DatasetId = datasetId, TableId = tableId };
            var schema = new TableSchemaBuilder().Build();
            var options = new InsertOptions();
            var stream = new MemoryStream();
            var rows = new[] { new InsertRow(), new InsertRow() };
            VerifyEquivalent(
                client => client.Insert(MatchesWhenSerialized(reference), rows, options),
                client => client.Insert(datasetId, tableId, rows, options),
                client => client.Insert(ProjectId, datasetId, tableId, rows, options),
                client => new BigqueryTable(client, GetTable(reference)).Insert(rows, options));
        }

        [Fact]
        public void InsertEquivalents_ParamsRows()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = new TableReference { ProjectId = ProjectId, DatasetId = datasetId, TableId = tableId };
            var schema = new TableSchemaBuilder().Build();
            var options = new InsertOptions();
            var stream = new MemoryStream();
            var rows = new[] { new InsertRow(), new InsertRow() };
            VerifyEquivalent(
                client => client.Insert(MatchesWhenSerialized(reference), rows, null),
                client => client.Insert(datasetId, tableId, rows[0], rows[1]),
                client => client.Insert(ProjectId, datasetId, tableId, rows[0], rows[1]),
                client => new BigqueryTable(client, GetTable(reference)).Insert(rows[0], rows[1]));
        }

        private T MatchesWhenSerialized<T>(T expected)
        {
            string serialized = JsonConvert.SerializeObject(expected);
            return It.Is<T>(actual => JsonConvert.SerializeObject(actual) == serialized);
        }

        private void VerifyEquivalent<TResult>(
            TResult result,
            Expression<Func<DerivedBigqueryClient, TResult>> underlyingCall,
            params Func<BigqueryClient, TResult>[] equivalentCalls) where TResult : class
        {
            foreach (var call in equivalentCalls)
            {
                var mock = new Mock<DerivedBigqueryClient>();
                mock.CallBase = true;
                mock.Setup(underlyingCall).Returns(result);
                Assert.Same(result, call(mock.Object));
                mock.VerifyAll();
            }
        }

        private void VerifyEquivalent(
            Expression<Action<DerivedBigqueryClient>> underlyingCall,
            params Action<BigqueryClient>[] equivalentCalls)
        {
            foreach (var call in equivalentCalls)
            {
                var mock = new Mock<DerivedBigqueryClient>();
                mock.CallBase = true;
                mock.Setup(underlyingCall);
                call(mock.Object);
                mock.VerifyAll();
            }
        }

        private static Table GetTable(string datasetId, string tableId, TableSchema schema = null) =>
            GetTable(GetTableReference(datasetId, tableId), schema);

        private static Table GetTable(TableReference reference, TableSchema schema = null) =>
            new Table { TableReference = reference, Schema = schema };

        private static TableReference GetTableReference(string datasetId, string tableId) =>
            new TableReference { ProjectId = ProjectId, DatasetId = datasetId, TableId = tableId };

        private static Dataset GetDataset(string datasetId) => GetDataset(GetDatasetReference(datasetId));

        private static Dataset GetDataset(DatasetReference reference) => new Dataset { DatasetReference = reference };

        private static DatasetReference GetDatasetReference(string datasetId) =>
            new DatasetReference { ProjectId = ProjectId, DatasetId = datasetId };

        private static Job GetJob(string jobId) => GetJob(GetJobReference(jobId));

        private static Job GetJob(JobReference reference) => new Job { JobReference = reference };

        private static JobReference GetJobReference(string JobId) =>
            new JobReference { ProjectId = ProjectId, JobId = JobId };

        // TODO: Create a simple implementation in Google.Api.Gax.Testing, after the planned refactoring.
        private class UnimplementedPagedEnumerable<TResponse, TResource> : IPagedEnumerable<TResponse, TResource>
        {
            public IResponseEnumerable<TResponse, TResource> AsPages()
            {
                throw new NotImplementedException();
            }

            public IEnumerator<TResource> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}