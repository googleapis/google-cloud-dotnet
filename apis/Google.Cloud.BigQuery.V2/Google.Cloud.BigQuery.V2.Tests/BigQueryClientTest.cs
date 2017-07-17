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
using Google.Apis.Bigquery.v2.Data;
using Google.Cloud.ClientTesting;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryClientTest : AbstractClientTester<BigQueryClient, BigQueryClientTest.DerivedBigQueryClient>
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
                var overloads = typeof(BigQueryClient).GetTypeInfo().GetDeclaredMethods(method.Name);
                var referenceAcceptingOverload = overloads.FirstOrDefault(
                    o => o.GetParameters().FirstOrDefault()?.ParameterType.Name.EndsWith("Reference") == true);
                return referenceAcceptingOverload == null || referenceAcceptingOverload == method;
            });

        public class DerivedBigQueryClient : BigQueryClient
        {
            public override string ProjectId => BigQueryClientTest.ProjectId;
        }

        [Theory]
        [MemberData(nameof(NotImplementedMethods))]
        public void NotImplementedMethodsThrow(MethodInfo method)
        {
            AssertNotImplemented(method);
        }

        protected override object GetArgument(ParameterInfo parameter)
        {
            if (parameter.ParameterType == typeof(BigQueryInsertRow))
            {
                return new BigQueryInsertRow();
            }
            if (parameter.ParameterType == typeof(TableReference))
            {
                return new TableReference();
            }
            return base.GetArgument(parameter);
        }

        [Fact]
        public void GetJobReference_ImplicitProject()
        {
            var reference = new DerivedBigQueryClient().GetJobReference("jobid");
            Assert.Equal("jobid", reference.JobId);
            Assert.Equal(ProjectId, reference.ProjectId);
        }

        [Fact]
        public void GetJobReference_ExplicitProject()
        {
            var reference = new DerivedBigQueryClient().GetJobReference("p", "jobid");
            Assert.Equal("jobid", reference.JobId);
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void GetTableReference_ImplicitProject()
        {
            var reference = new DerivedBigQueryClient().GetTableReference("datasetid", "tableid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("tableid", reference.TableId);
            Assert.Equal(ProjectId, reference.ProjectId);
        }

        [Fact]
        public void GetTableReference_ExplicitProject()
        {
            var reference = new DerivedBigQueryClient().GetTableReference("p", "datasetid", "tableid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("tableid", reference.TableId);
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void GetDatasetReference_ImplicitProject()
        {
            var reference = new DerivedBigQueryClient().GetDatasetReference("datasetid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal(ProjectId, reference.ProjectId);
        }

        [Fact]
        public void GetDatasetReference_ExplicitProject()
        {
            var reference = new DerivedBigQueryClient().GetDatasetReference("p", "datasetid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void GetProjectReference_ExplicitProject()
        {
            var reference = new DerivedBigQueryClient().GetProjectReference("p");
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void CreateDatasetEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new CreateDatasetOptions();
            VerifyEquivalent(new BigQueryDataset(new DerivedBigQueryClient(), GetDataset(reference)),
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
            VerifyEquivalent(new BigQueryDataset(new DerivedBigQueryClient(), GetDataset(reference)),
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
            VerifyEquivalent(new BigQueryDataset(new DerivedBigQueryClient(), GetDataset(reference)),
                client => client.GetOrCreateDataset(MatchesWhenSerialized(reference), getOptions, createOptions),
                client => client.GetOrCreateDataset(datasetId, getOptions, createOptions),
                client => client.GetOrCreateDataset(ProjectId, datasetId, getOptions, createOptions));
        }

        [Fact]
        public void ListDatasetsEquivalents()
        {
            var reference = new ProjectReference { ProjectId = ProjectId };
            var options = new ListDatasetsOptions();
            VerifyEquivalent(new UnimplementedPagedEnumerable<DatasetList, BigQueryDataset>(),
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
            VerifyEquivalent(new BigQueryTable(new DerivedBigQueryClient(), GetTable(reference)),
                client => client.CreateTable(MatchesWhenSerialized(reference), schema, options),
                client => client.CreateTable(datasetId, tableId, schema, options),
                client => client.CreateTable(ProjectId, datasetId, tableId, schema, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).CreateTable(tableId, schema, options));
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
                client => new BigQueryTable(client, new Table { TableReference = reference }).Delete(options));
        }

        [Fact]
        public void GetTableEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var options = new GetTableOptions();
            VerifyEquivalent(new BigQueryTable(new DerivedBigQueryClient(), GetTable(reference)),
                client => client.GetTable(MatchesWhenSerialized(reference), options),
                client => client.GetTable(datasetId, tableId, options),
                client => client.GetTable(ProjectId, datasetId, tableId, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetTable(tableId, options));
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
            VerifyEquivalent(new BigQueryTable(new DerivedBigQueryClient(), GetTable(reference)),
                client => client.GetOrCreateTable(MatchesWhenSerialized(reference), schema, getOptions, createOptions),
                client => client.GetOrCreateTable(datasetId, tableId, schema, getOptions, createOptions),
                client => client.GetOrCreateTable(ProjectId, datasetId, tableId, schema, getOptions, createOptions),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetOrCreateTable(tableId, schema, getOptions, createOptions));
        }

        [Fact]
        public void ListTablesEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ListTablesOptions();
            VerifyEquivalent(new UnimplementedPagedEnumerable<TableList, BigQueryTable>(),
                client => client.ListTables(MatchesWhenSerialized(reference), options),
                client => client.ListTables(datasetId, options),
                client => client.ListTables(ProjectId, datasetId, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).ListTables(options));
        }

        [Fact]
        public void GetJobEquivalents()
        {
            var jobId = "job";
            var reference = GetJobReference(jobId);
            var options = new GetJobOptions();
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), GetJob(reference)),
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
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), GetJob(reference)),
                client => client.CancelJob(MatchesWhenSerialized(reference), options),
                client => client.CancelJob(jobId, options),
                client => client.CancelJob(ProjectId, jobId, options),
                client => new BigQueryJob(client, GetJob(reference)).Cancel(options));
        }

        [Fact]
        public void PollJobUntilCompletedEquivalents()
        {
            var jobId = "job";
            var reference = GetJobReference(jobId);
            var options = new GetJobOptions();
            var pollSettings = new PollSettings(Expiration.None, TimeSpan.Zero);
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), GetJob(reference)),
                client => client.PollJobUntilCompleted(MatchesWhenSerialized(reference), options, pollSettings),
                client => client.PollJobUntilCompleted(jobId, options, pollSettings),
                client => client.PollJobUntilCompleted(ProjectId, jobId, options, pollSettings),
                client => new BigQueryJob(client, GetJob(reference)).PollUntilCompleted(options, pollSettings));
        }

        [Fact]
        public void ListJobsEquivalents()
        {
            var reference = new ProjectReference { ProjectId = ProjectId };
            var options = new ListJobsOptions();
            VerifyEquivalent(new UnimplementedPagedEnumerable<JobList, BigQueryJob>(),
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
            VerifyEquivalent(new UnimplementedPagedEnumerable<TableDataList, BigQueryRow>(),
                client => client.ListRows(MatchesWhenSerialized(reference), schema, options),
                client => client.ListRows(datasetId, tableId, schema, options),
                client => client.ListRows(ProjectId, datasetId, tableId, schema, options),
                client => new BigQueryTable(client, GetTable(reference, schema)).ListRows(options));
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
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadCsv(MatchesWhenSerialized(tableReference), schema, stream, options),
                client => client.UploadCsv(datasetId, tableId, schema, stream, options),
                client => client.UploadCsv(ProjectId, datasetId, tableId, schema, stream, options),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadCsv(stream, options));
        }

        [Fact]
        public void UploadJson_Stream_Equivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadJsonOptions();
            var stream = new MemoryStream();
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadJson(MatchesWhenSerialized(tableReference), schema, stream, options),
                client => client.UploadJson(datasetId, tableId, schema, stream, options),
                client => client.UploadJson(ProjectId, datasetId, tableId, schema, stream, options),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadJson(stream, options));
        }

        [Fact]
        public void UploadJson_Strings_Equivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadJsonOptions();
            var rows = new[] { "a", "b" };
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadJson(MatchesWhenSerialized(tableReference), schema, rows, options),
                client => client.UploadJson(datasetId, tableId, schema, rows, options),
                client => client.UploadJson(ProjectId, datasetId, tableId, schema, rows, options),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadJson(rows, options));
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
            var row = new BigQueryInsertRow();
            VerifyEquivalent(
                client => client.InsertRows(MatchesWhenSerialized(reference), new[] { row }, options),
                client => client.InsertRow(datasetId, tableId, row, options),
                client => client.InsertRow(ProjectId, datasetId, tableId, row, options),
                client => new BigQueryTable(client, GetTable(reference)).InsertRow(row, options));
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
            var rows = new[] { new BigQueryInsertRow(), new BigQueryInsertRow() };
            VerifyEquivalent(
                client => client.InsertRows(MatchesWhenSerialized(reference), rows, options),
                client => client.InsertRows(datasetId, tableId, rows, options),
                client => client.InsertRows(ProjectId, datasetId, tableId, rows, options),
                client => new BigQueryTable(client, GetTable(reference)).InsertRows(rows, options));
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
            var rows = new[] { new BigQueryInsertRow(), new BigQueryInsertRow() };
            VerifyEquivalent(
                client => client.InsertRows(MatchesWhenSerialized(reference), rows, null),
                client => client.InsertRows(datasetId, tableId, rows[0], rows[1]),
                client => client.InsertRows(ProjectId, datasetId, tableId, rows[0], rows[1]),
                client => new BigQueryTable(client, GetTable(reference)).InsertRows(rows[0], rows[1]));
        }

        [Fact]
        public void CreateExtractJobEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var tableReference = GetTableReference(datasetId, tableId);
            var uri = "gs://bucket/object";
            var options = new CreateExtractJobOptions();

            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.CreateExtractJob(MatchesWhenSerialized(tableReference), new[] { uri }, options),
                client => client.CreateExtractJob(ProjectId, datasetId, tableId, uri, options),
                client => client.CreateExtractJob(datasetId, tableId, uri, options),
                client => client.CreateExtractJob(tableReference, uri, options),
                client => client.CreateExtractJob(ProjectId, datasetId, tableId, new[] { uri }, options),
                client => client.CreateExtractJob(datasetId, tableId, uri, options),
                client => client.CreateExtractJob(datasetId, tableId, uri, options),
                client => client.CreateExtractJob(ProjectId, datasetId, tableId, uri, options),
                client => new BigQueryTable(client, GetTable(tableReference)).CreateExtractJob(uri, options),
                client => new BigQueryTable(client, GetTable(tableReference)).CreateExtractJob(new[] { uri }, options));
        }

        [Fact]
        public void CreateCopyJobEquivalents()
        {
            var jobReference = GetJobReference("job");
            var sourceTableReference = GetTableReference("sourceDataset", "sourceTable");
            var destinationTableReference = GetTableReference("destDataset", "destTable");
            var options = new CreateCopyJobOptions();

            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.CreateCopyJob(MatchesWhenSerialized(new[] { sourceTableReference }), MatchesWhenSerialized(destinationTableReference), options),
                client => client.CreateCopyJob(sourceTableReference, destinationTableReference, options),
                client => new BigQueryTable(client, GetTable(sourceTableReference)).CreateCopyJob(destinationTableReference, options));
        }

        [Fact]
        public void CreateDatasetAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new CreateDatasetOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryDataset(new DerivedBigQueryClient(), GetDataset(reference)),
                client => client.CreateDatasetAsync(MatchesWhenSerialized(reference), options, token),
                client => client.CreateDatasetAsync(datasetId, options, token),
                client => client.CreateDatasetAsync(ProjectId, datasetId, options, token));
        }

        [Fact]
        public void DeleteDatasetAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new DeleteDatasetOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(
                client => client.DeleteDatasetAsync(MatchesWhenSerialized(reference), options, token),
                client => client.DeleteDatasetAsync(datasetId, options, token),
                client => client.DeleteDatasetAsync(ProjectId, datasetId, options, token));
        }

        [Fact]
        public void GetDatasetAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new GetDatasetOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryDataset(new DerivedBigQueryClient(), GetDataset(reference)),
                client => client.GetDatasetAsync(MatchesWhenSerialized(reference), options, token),
                client => client.GetDatasetAsync(datasetId, options, token),
                client => client.GetDatasetAsync(ProjectId, datasetId, options, token));
        }

        [Fact]
        public void GetOrCreateDatasetAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var getOptions = new GetDatasetOptions();
            var createOptions = new CreateDatasetOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryDataset(new DerivedBigQueryClient(), GetDataset(reference)),
                client => client.GetOrCreateDatasetAsync(MatchesWhenSerialized(reference), getOptions, createOptions, token),
                client => client.GetOrCreateDatasetAsync(datasetId, getOptions, createOptions, token),
                client => client.GetOrCreateDatasetAsync(ProjectId, datasetId, getOptions, createOptions, token));
        }

        [Fact]
        public void ListDatasetsAsyncEquivalents()
        {
            var reference = new ProjectReference { ProjectId = ProjectId };
            var options = new ListDatasetsOptions();
            VerifyEquivalent(new UnimplementedPagedAsyncEnumerable<DatasetList, BigQueryDataset>(),
                client => client.ListDatasetsAsync(MatchesWhenSerialized(reference), options),
                client => client.ListDatasetsAsync(options),
                client => client.ListDatasetsAsync(ProjectId, options));
        }

        [Fact]
        public void CreateTableAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var schema = new TableSchemaBuilder().Build();
            var reference = GetTableReference(datasetId, tableId);
            var options = new CreateTableOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryTable(new DerivedBigQueryClient(), GetTable(reference)),
                client => client.CreateTableAsync(MatchesWhenSerialized(reference), schema, options, token),
                client => client.CreateTableAsync(datasetId, tableId, schema, options, token),
                client => client.CreateTableAsync(ProjectId, datasetId, tableId, schema, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetId)).CreateTableAsync(tableId, schema, options, token));
        }

        [Fact]
        public void DeleteTableAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var schema = new TableSchemaBuilder().Build();
            var reference = GetTableReference(datasetId, tableId);
            var options = new DeleteTableOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(
                client => client.DeleteTableAsync(MatchesWhenSerialized(reference), options, token),
                client => client.DeleteTableAsync(datasetId, tableId, options, token),
                client => client.DeleteTableAsync(ProjectId, datasetId, tableId, options, token),
                client => new BigQueryTable(client, new Table { TableReference = reference }).DeleteAsync(options, token));
        }

        [Fact]
        public void GetTableAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var options = new GetTableOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryTable(new DerivedBigQueryClient(), GetTable(reference)),
                client => client.GetTableAsync(MatchesWhenSerialized(reference), options, token),
                client => client.GetTableAsync(datasetId, tableId, options, token),
                client => client.GetTableAsync(ProjectId, datasetId, tableId, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetTableAsync(tableId, options, token));
        }

        [Fact]
        public void GetOrCreateTableAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var schema = new TableSchemaBuilder().Build();
            var reference = GetTableReference(datasetId, tableId);
            var getOptions = new GetTableOptions();
            var createOptions = new CreateTableOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryTable(new DerivedBigQueryClient(), GetTable(reference)),
                client => client.GetOrCreateTableAsync(MatchesWhenSerialized(reference), schema, getOptions, createOptions, token),
                client => client.GetOrCreateTableAsync(datasetId, tableId, schema, getOptions, createOptions, token),
                client => client.GetOrCreateTableAsync(ProjectId, datasetId, tableId, schema, getOptions, createOptions, token),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetOrCreateTableAsync(tableId, schema, getOptions, createOptions, token));
        }

        [Fact]
        public void ListTablesAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ListTablesOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalent(new UnimplementedPagedAsyncEnumerable<TableList, BigQueryTable>(),
                client => client.ListTablesAsync(MatchesWhenSerialized(reference), options),
                client => client.ListTablesAsync(datasetId, options),
                client => client.ListTablesAsync(ProjectId, datasetId, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).ListTablesAsync(options));
        }

        [Fact]
        public void GetJobAsyncEquivalents()
        {
            var jobId = "job";
            var reference = GetJobReference(jobId);
            var options = new GetJobOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), GetJob(reference)),
                client => client.GetJobAsync(MatchesWhenSerialized(reference), options, token),
                client => client.GetJobAsync(jobId, options, token),
                client => client.GetJobAsync(ProjectId, jobId, options, token));
        }

        [Fact]
        public void CancelJobAsyncEquivalents()
        {
            var jobId = "job";
            var reference = GetJobReference(jobId);
            var options = new CancelJobOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), GetJob(reference)),
                client => client.CancelJobAsync(MatchesWhenSerialized(reference), options, token),
                client => client.CancelJobAsync(jobId, options, token),
                client => client.CancelJobAsync(ProjectId, jobId, options, token),
                client => new BigQueryJob(client, GetJob(reference)).CancelAsync(options, token));
        }

        [Fact]
        public void PollJobUntilCompletedAsyncEquivalents()
        {
            var jobId = "job";
            var reference = GetJobReference(jobId);
            var options = new GetJobOptions();
            var pollSettings = new PollSettings(Expiration.None, TimeSpan.Zero);
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), GetJob(reference)),
                client => client.PollJobUntilCompletedAsync(MatchesWhenSerialized(reference), options, pollSettings, token),
                client => client.PollJobUntilCompletedAsync(jobId, options, pollSettings, token),
                client => client.PollJobUntilCompletedAsync(ProjectId, jobId, options, pollSettings, token),
                client => new BigQueryJob(client, GetJob(reference)).PollUntilCompletedAsync(options, pollSettings, token));
        }

        [Fact]
        public void ListJobsAsyncEquivalents()
        {
            var reference = new ProjectReference { ProjectId = ProjectId };
            var options = new ListJobsOptions();
            VerifyEquivalent(new UnimplementedPagedAsyncEnumerable<JobList, BigQueryJob>(),
                client => client.ListJobsAsync(MatchesWhenSerialized(reference), options),
                client => client.ListJobsAsync(options),
                client => client.ListJobsAsync(ProjectId, options));
        }

        [Fact]
        public void ListRowsAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new ListRowsOptions();
            VerifyEquivalent(new UnimplementedPagedAsyncEnumerable<TableDataList, BigQueryRow>(),
                client => client.ListRowsAsync(MatchesWhenSerialized(reference), schema, options),
                client => client.ListRowsAsync(datasetId, tableId, schema, options),
                client => client.ListRowsAsync(ProjectId, datasetId, tableId, schema, options),
                client => new BigQueryTable(client, GetTable(reference, schema)).ListRowsAsync(options));
        }

        [Fact]
        public void UploadCsvAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadCsvOptions();
            var token = new CancellationTokenSource().Token;
            var stream = new MemoryStream();
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadCsvAsync(MatchesWhenSerialized(tableReference), schema, stream, options, token),
                client => client.UploadCsvAsync(datasetId, tableId, schema, stream, options, token),
                client => client.UploadCsvAsync(ProjectId, datasetId, tableId, schema, stream, options, token),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadCsvAsync(stream, options, token));
        }

        [Fact]
        public void UploadJson_Stream_AsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadJsonOptions();
            var token = new CancellationTokenSource().Token;
            var stream = new MemoryStream();
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadJsonAsync(MatchesWhenSerialized(tableReference), schema, stream, options, token),
                client => client.UploadJsonAsync(datasetId, tableId, schema, stream, options, token),
                client => client.UploadJsonAsync(ProjectId, datasetId, tableId, schema, stream, options, token),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadJsonAsync(stream, options, token));
        }

        [Fact]
        public void UploadJson_Strings_AsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadJsonOptions();
            var token = new CancellationTokenSource().Token;
            var rows = new[] { "a", "b" };
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadJsonAsync(MatchesWhenSerialized(tableReference), schema, rows, options, token),
                client => client.UploadJsonAsync(datasetId, tableId, schema, rows, options, token),
                client => client.UploadJsonAsync(ProjectId, datasetId, tableId, schema, rows, options, token),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadJsonAsync(rows, options, token));
        }

        [Fact]
        public void InsertAsyncEquivalents_SingleRow()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = new TableReference { ProjectId = ProjectId, DatasetId = datasetId, TableId = tableId };
            var schema = new TableSchemaBuilder().Build();
            var options = new InsertOptions();
            var token = new CancellationTokenSource().Token;
            var stream = new MemoryStream();
            var row = new BigQueryInsertRow();
            VerifyEquivalentAsync(
                client => client.InsertRowsAsync(MatchesWhenSerialized(reference), new[] { row }, options, token),
                client => client.InsertRowAsync(datasetId, tableId, row, options, token),
                client => client.InsertRowAsync(ProjectId, datasetId, tableId, row, options, token),
                client => new BigQueryTable(client, GetTable(reference)).InsertRowAsync(row, options, token));
        }

        [Fact]
        public void InsertAsyncEquivalents_RowCollection()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = new TableReference { ProjectId = ProjectId, DatasetId = datasetId, TableId = tableId };
            var schema = new TableSchemaBuilder().Build();
            var options = new InsertOptions();
            var token = new CancellationTokenSource().Token;
            var stream = new MemoryStream();
            var rows = new[] { new BigQueryInsertRow(), new BigQueryInsertRow() };
            VerifyEquivalentAsync(
                client => client.InsertRowsAsync(MatchesWhenSerialized(reference), rows, options, token),
                client => client.InsertRowsAsync(datasetId, tableId, rows, options, token),
                client => client.InsertRowsAsync(ProjectId, datasetId, tableId, rows, options, token),
                client => new BigQueryTable(client, GetTable(reference)).InsertRowsAsync(rows, options, token));
        }

        [Fact]
        public void InsertAsyncEquivalents_ParamsRows()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = new TableReference { ProjectId = ProjectId, DatasetId = datasetId, TableId = tableId };
            var schema = new TableSchemaBuilder().Build();
            var options = new InsertOptions();
            var token = new CancellationTokenSource().Token;
            var stream = new MemoryStream();
            var rows = new[] { new BigQueryInsertRow(), new BigQueryInsertRow() };
            VerifyEquivalentAsync(
                client => client.InsertRowsAsync(MatchesWhenSerialized(reference), rows, null, default(CancellationToken)),
                client => client.InsertRowsAsync(datasetId, tableId, rows[0], rows[1]),
                client => client.InsertRowsAsync(ProjectId, datasetId, tableId, rows[0], rows[1]),
                client => new BigQueryTable(client, GetTable(reference)).InsertRowsAsync(rows[0], rows[1]));
        }

        [Fact]
        public void CreateExtractJobAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var tableReference = GetTableReference(datasetId, tableId);
            var uri = "gs://bucket/object";
            var options = new CreateExtractJobOptions();
            var token = new CancellationTokenSource().Token;

            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.CreateExtractJobAsync(MatchesWhenSerialized(tableReference), new[] { uri }, options, token),
                client => client.CreateExtractJobAsync(ProjectId, datasetId, tableId, uri, options, token),
                client => client.CreateExtractJobAsync(datasetId, tableId, uri, options, token),
                client => client.CreateExtractJobAsync(tableReference, uri, options, token),
                client => client.CreateExtractJobAsync(ProjectId, datasetId, tableId, new[] { uri }, options, token),
                client => client.CreateExtractJobAsync(datasetId, tableId, uri, options, token),
                client => client.CreateExtractJobAsync(datasetId, tableId, uri, options, token),
                client => client.CreateExtractJobAsync(ProjectId, datasetId, tableId, uri, options, token),
                client => new BigQueryTable(client, GetTable(tableReference)).CreateExtractJobAsync(uri, options, token),
                client => new BigQueryTable(client, GetTable(tableReference)).CreateExtractJobAsync(new[] { uri }, options, token));
        }

        [Fact]
        public void CreateCopyJobAsyncEquivalents()
        {
            var jobReference = GetJobReference("job");
            var sourceTableReference = GetTableReference("sourceDataset", "sourceTable");
            var destinationTableReference = GetTableReference("destDataset", "destTable");
            var options = new CreateCopyJobOptions();
            var token = new CancellationTokenSource().Token;

            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.CreateCopyJobAsync(MatchesWhenSerialized(new[] { sourceTableReference }), MatchesWhenSerialized(destinationTableReference), options, token),
                client => client.CreateCopyJobAsync(sourceTableReference, destinationTableReference, options, token),
                client => new BigQueryTable(client, GetTable(sourceTableReference)).CreateCopyJobAsync(destinationTableReference, options, token));
        }

        private T MatchesWhenSerialized<T>(T expected)
        {
            string serialized = JsonConvert.SerializeObject(expected);
            return It.Is<T>(actual => JsonConvert.SerializeObject(actual) == serialized);
        }

        private void VerifyEquivalent<TResult>(
            TResult result,
            Expression<Func<DerivedBigQueryClient, TResult>> underlyingCall,
            params Func<BigQueryClient, TResult>[] equivalentCalls) where TResult : class
        {
            foreach (var call in equivalentCalls)
            {
                var mock = new Mock<DerivedBigQueryClient>() { CallBase = true };
                mock.Setup(underlyingCall).Returns(result);
                Assert.Same(result, call(mock.Object));
                mock.VerifyAll();
            }
        }

        private void VerifyEquivalent(
            Expression<Action<DerivedBigQueryClient>> underlyingCall,
            params Action<BigQueryClient>[] equivalentCalls)
        {
            foreach (var call in equivalentCalls)
            {
                var mock = new Mock<DerivedBigQueryClient>() { CallBase = true };
                mock.Setup(underlyingCall);
                call(mock.Object);
                mock.VerifyAll();
            }
        }

        private void VerifyEquivalentAsync<TResult>(
            TResult result,
            Expression<Func<DerivedBigQueryClient, Task<TResult>>> underlyingCall,
            params Func<BigQueryClient, Task<TResult>>[] equivalentCalls) where TResult : class
        {
            var taskResult = Task.FromResult(result);
            foreach (var call in equivalentCalls)
            {
                var mock = new Mock<DerivedBigQueryClient>() { CallBase = true };
                mock.Setup(underlyingCall).Returns(taskResult);
                Assert.Same(taskResult, call(mock.Object));
                mock.VerifyAll();
            }
        }

        private void VerifyEquivalentAsync(
            Expression<Func<DerivedBigQueryClient, Task>> underlyingCall,
            params Func<BigQueryClient, Task>[] equivalentCalls)
        {
            var taskResult = Task.FromResult(0);
            foreach (var call in equivalentCalls)
            {
                var mock = new Mock<DerivedBigQueryClient>() { CallBase = true };
                mock.Setup(underlyingCall).Returns(taskResult);
                Assert.Same(taskResult, call(mock.Object));
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

        private class UnimplementedPagedEnumerable<TResponse, TResource> : PagedEnumerable<TResponse, TResource>
        {
        }

        private class UnimplementedPagedAsyncEnumerable<TResponse, TResource> : PagedAsyncEnumerable<TResponse, TResource>
        {
        }
    }
}