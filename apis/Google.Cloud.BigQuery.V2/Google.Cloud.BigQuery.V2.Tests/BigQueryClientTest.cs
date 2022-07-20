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
    public class BigQueryClientTest : AbstractClientTester<BigQueryClient, BigQueryClientTest.NoOverridesBigQueryClient>
    {
        private const string ProjectId = "sample-project";
        private const string Location = "default-location";

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
            })
            .Where(x => ((MethodInfo)x[0]).Name != "Dispose")
            .Concat(AllInstanceGetters);

        public class NoOverridesBigQueryClient : BigQueryClient
        {
        }

        public class DerivedBigQueryClient : BigQueryClient
        {
            public override string ProjectId => BigQueryClientTest.ProjectId;
            public override string DefaultLocation => BigQueryClientTest.Location;
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
        public void GetJobReference_ImplicitProjectAndLocation()
        {
            var reference = new DerivedBigQueryClient().GetJobReference("jobid");
            Assert.Equal("jobid", reference.JobId);
            Assert.Equal(ProjectId, reference.ProjectId);
            Assert.Equal(Location, reference.Location);
        }

        [Fact]
        public void GetJobReference_ExplicitProjectImplicitLocation()
        {
            var reference = new DerivedBigQueryClient().GetJobReference("p", "jobid");
            Assert.Equal("jobid", reference.JobId);
            Assert.Equal("p", reference.ProjectId);
            Assert.Equal(Location, reference.Location);
        }

        [Fact]
        public void GetJobReference_ExplicitProjectAndLocation()
        {
            var reference = new DerivedBigQueryClient().GetJobReference("p", "jobid", "loc");
            Assert.Equal("jobid", reference.JobId);
            Assert.Equal("p", reference.ProjectId);
            Assert.Equal("loc", reference.Location);
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
        public void GetModelReference_ImplicitProject()
        {
            var reference = new DerivedBigQueryClient().GetModelReference("datasetid", "modelid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("modelid", reference.ModelId);
            Assert.Equal(ProjectId, reference.ProjectId);
        }

        [Fact]
        public void GetModelReference_ExplicitProject()
        {
            var reference = new DerivedBigQueryClient().GetModelReference("p", "datasetid", "modelid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("modelid", reference.ModelId);
            Assert.Equal("p", reference.ProjectId);
        }

        [Fact]
        public void GetRoutineReference_ImplicitProject()
        {
            var reference = new DerivedBigQueryClient().GetRoutineReference("datasetid", "routineid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("routineid", reference.RoutineId);
            Assert.Equal(ProjectId, reference.ProjectId);
        }

        [Fact]
        public void GetRoutineReference_ExplicitProject()
        {
            var reference = new DerivedBigQueryClient().GetRoutineReference("p", "datasetid", "routineid");
            Assert.Equal("datasetid", reference.DatasetId);
            Assert.Equal("routineid", reference.RoutineId);
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
            var dataset = new Dataset();
            var options = new CreateDatasetOptions();
            VerifyEquivalent(new BigQueryDataset(new DerivedBigQueryClient(), GetDataset(reference)),
                client => client.CreateDataset(MatchesWhenSerialized(reference), dataset, options),
                client => client.CreateDataset(datasetId, dataset, options),
                client => client.CreateDataset(ProjectId, datasetId, dataset, options));
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
                client => client.DeleteDataset(ProjectId, datasetId, options),
                client => new BigQueryDataset(client, GetDataset(reference)).Delete(options));
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
        public void UpdateDatasetEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var resource = new Dataset();
            var options = new UpdateDatasetOptions();
            VerifyEquivalent(new BigQueryDataset(new DerivedBigQueryClient(), resource),
                client => client.UpdateDataset(MatchesWhenSerialized(reference), resource, options),
                client => client.UpdateDataset(datasetId, resource, options),
                client => client.UpdateDataset(ProjectId, datasetId, resource, options),
                client => new BigQueryDataset(client, GetDataset(reference)).Update(resource, options));
        }

        [Fact]
        public void PatchDatasetEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var resource = new Dataset();
            var options = new PatchDatasetOptions();
            VerifyEquivalent(new BigQueryDataset(new DerivedBigQueryClient(), resource),
                client => client.PatchDataset(MatchesWhenSerialized(reference), resource, options),
                client => client.PatchDataset(datasetId, resource, options),
                client => client.PatchDataset(ProjectId, datasetId, resource, options),
                client => new BigQueryDataset(client, GetDataset(reference)).Patch(resource, false, options));
        }

        [Fact]
        public void GetOrCreateDatasetEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var getOptions = new GetDatasetOptions();
            var createOptions = new CreateDatasetOptions();
            var dataset = new Dataset();
            VerifyEquivalent(new BigQueryDataset(new DerivedBigQueryClient(), GetDataset(reference)),
                client => client.GetOrCreateDataset(MatchesWhenSerialized(reference), dataset, getOptions, createOptions),
                client => client.GetOrCreateDataset(datasetId, dataset, getOptions, createOptions),
                client => client.GetOrCreateDataset(ProjectId, datasetId, dataset, getOptions, createOptions));
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
        public void SetDatasetLabelEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ModifyLabelsOptions();
            string labelName = "label";
            string labelValue = "value";
            VerifyEquivalent("oldValue",
                client => client.SetDatasetLabel(MatchesWhenSerialized(reference), labelName, labelValue, options),
                client => client.SetDatasetLabel(datasetId, labelName, labelValue, options),
                client => client.SetDatasetLabel(ProjectId, datasetId, labelName, labelValue, options));
        }

        [Fact]
        public void RemoveDatasetLabelEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ModifyLabelsOptions();
            string labelName = "label";
            VerifyEquivalent("oldValue",
                client => client.RemoveDatasetLabel(MatchesWhenSerialized(reference), labelName, options),
                client => client.RemoveDatasetLabel(datasetId, labelName, options),
                client => client.RemoveDatasetLabel(ProjectId, datasetId, labelName, options));
        }

        [Fact]
        public void ClearDatasetLabelsEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ModifyLabelsOptions();
            VerifyEquivalent(new Dictionary<string, string>(),
                client => client.ClearDatasetLabels(MatchesWhenSerialized(reference), options),
                client => client.ClearDatasetLabels(datasetId, options),
                client => client.ClearDatasetLabels(ProjectId, datasetId, options));
        }

        [Fact]
        public void ModifyDatasetLabelsEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ModifyLabelsOptions();
            var labels = new Dictionary<string, string>();
            VerifyEquivalent(new Dictionary<string, string>(),
                client => client.ModifyDatasetLabels(MatchesWhenSerialized(reference), labels, options),
                client => client.ModifyDatasetLabels(datasetId, labels, options),
                client => client.ModifyDatasetLabels(ProjectId, datasetId, labels, options));
        }

        [Fact]
        public void CreateTableEquivalents_Schema()
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
        public void CreateTableEquivalents_Table()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var schema = new TableSchemaBuilder().Build();
            var table = new Table { Schema = schema };
            var reference = GetTableReference(datasetId, tableId);
            var options = new CreateTableOptions();
            VerifyEquivalent(new BigQueryTable(new DerivedBigQueryClient(), GetTable(reference)),
                client => client.CreateTable(MatchesWhenSerialized(reference), table, options),
                client => client.CreateTable(datasetId, tableId, table, options),
                client => client.CreateTable(ProjectId, datasetId, tableId, table, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).CreateTable(tableId, table, options));
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
        public void GetOrCreateTableEquivalents_Schema()
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
        public void GetOrCreateTableEquivalents_Table()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var schema = new TableSchemaBuilder().Build();
            var table = new Table { Schema = schema };
            var reference = GetTableReference(datasetId, tableId);
            var getOptions = new GetTableOptions();
            var createOptions = new CreateTableOptions();
            VerifyEquivalent(new BigQueryTable(new DerivedBigQueryClient(), GetTable(reference)),
                client => client.GetOrCreateTable(MatchesWhenSerialized(reference), table, getOptions, createOptions),
                client => client.GetOrCreateTable(datasetId, tableId, table, getOptions, createOptions),
                client => client.GetOrCreateTable(ProjectId, datasetId, tableId, table, getOptions, createOptions),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetOrCreateTable(tableId, table, getOptions, createOptions));
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
        public void UpdateTableEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var resource = new Table();
            var options = new UpdateTableOptions();
            VerifyEquivalent(new BigQueryTable(new DerivedBigQueryClient(), resource),
                client => client.UpdateTable(MatchesWhenSerialized(reference), resource, options),
                client => client.UpdateTable(datasetId, tableId, resource, options),
                client => client.UpdateTable(ProjectId, datasetId, tableId, resource, options),
                client => new BigQueryTable(client, GetTable(reference)).Update(resource, options));
        }

        [Fact]
        public void PatchTableEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var resource = new Table();
            var options = new PatchTableOptions();
            VerifyEquivalent(new BigQueryTable(new DerivedBigQueryClient(), resource),
                client => client.PatchTable(MatchesWhenSerialized(reference), resource, options),
                client => client.PatchTable(datasetId, tableId, resource, options),
                client => client.PatchTable(ProjectId, datasetId, tableId, resource, options),
                client => new BigQueryTable(client, GetTable(reference)).Patch(resource, false, options));
        }

        [Fact]
        public void GetTableIamPolicyEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var options = new GetTableIamPolicyOptions();
            VerifyEquivalent(new Policy(),
                client => client.GetTableIamPolicy(MatchesWhenSerialized(reference), options),
                client => client.GetTableIamPolicy(datasetId, tableId, options),
                client => client.GetTableIamPolicy(ProjectId, datasetId, tableId, options),
                client => new BigQueryTable(client, GetTable(reference)).GetIamPolicy(options));
        }

        [Fact]
        public void SetTableIamPolicyEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var policy = new Policy();
            var options = new SetTableIamPolicyOptions();
            VerifyEquivalent(new Policy(),
                client => client.SetTableIamPolicy(MatchesWhenSerialized(reference), policy, options),
                client => client.SetTableIamPolicy(datasetId, tableId, policy, options),
                client => client.SetTableIamPolicy(ProjectId, datasetId, tableId, policy, options),
                client => new BigQueryTable(client, GetTable(reference)).SetIamPolicy(policy, options));
        }

        [Fact]
        public void TestTableIamPermissionsEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var permissions = new List<string>();
            var options = new TestTableIamPermissionsOptions();
            VerifyEquivalent(new TestIamPermissionsResponse(),
                client => client.TestTableIamPermissions(MatchesWhenSerialized(reference), permissions, options),
                client => client.TestTableIamPermissions(datasetId, tableId, permissions, options),
                client => client.TestTableIamPermissions(ProjectId, datasetId, tableId, permissions, options),
                client => new BigQueryTable(client, GetTable(reference)).TestIamPermissions(permissions, options));
        }

        [Fact]
        public void DeleteModelEquivalents()
        {
            var datasetId = "dataset";
            var modelId = "model";
            var reference = GetModelReference(datasetId, modelId);
            var options = new DeleteModelOptions();
            VerifyEquivalent(
                client => client.DeleteModel(MatchesWhenSerialized(reference), options),
                client => client.DeleteModel(datasetId, modelId, options),
                client => client.DeleteModel(ProjectId, datasetId, modelId, options),
                client => new BigQueryModel(client, new Model { ModelReference = reference }).Delete(options));
        }

        [Fact]
        public void GetModelEquivalents()
        {
            var datasetId = "dataset";
            var modelId = "model";
            var reference = GetModelReference(datasetId, modelId);
            var options = new GetModelOptions();
            VerifyEquivalent(new BigQueryModel(new DerivedBigQueryClient(), GetModel(reference)),
                client => client.GetModel(MatchesWhenSerialized(reference), options),
                client => client.GetModel(datasetId, modelId, options),
                client => client.GetModel(ProjectId, datasetId, modelId, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetModel(modelId, options));
        }

        [Fact]
        public void ListModelsEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ListModelsOptions();
            VerifyEquivalent(new UnimplementedPagedEnumerable<ListModelsResponse, BigQueryModel>(),
                client => client.ListModels(MatchesWhenSerialized(reference), options),
                client => client.ListModels(datasetId, options),
                client => client.ListModels(ProjectId, datasetId, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).ListModels(options));
        }

        [Fact]
        public void PatchModelEquivalents()
        {
            var datasetId = "dataset";
            var modelId = "model";
            var reference = GetModelReference(datasetId, modelId);
            var resource = new Model();
            var options = new PatchModelOptions();
            VerifyEquivalent(new BigQueryModel(new DerivedBigQueryClient(), resource),
                client => client.PatchModel(MatchesWhenSerialized(reference), resource, options),
                client => client.PatchModel(datasetId, modelId, resource, options),
                client => client.PatchModel(ProjectId, datasetId, modelId, resource, options),
                client => new BigQueryModel(client, GetModel(reference)).Patch(resource, false, options));
        }

        [Fact]
        public void GetRoutineEquivalents()
        {
            var datasetId = "dataset";
            var routineId = "routine";
            var reference = GetRoutineReference(datasetId, routineId);
            var options = new GetRoutineOptions();
            VerifyEquivalent(new BigQueryRoutine(new DerivedBigQueryClient(), GetRoutine(reference)),
                client => client.GetRoutine(MatchesWhenSerialized(reference), options),
                client => client.GetRoutine(datasetId, routineId, options),
                client => client.GetRoutine(ProjectId, datasetId, routineId, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetRoutine(routineId, options));
        }

        [Fact]
        public void ListRoutinesEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ListRoutinesOptions();
            VerifyEquivalent(new UnimplementedPagedEnumerable<ListRoutinesResponse, BigQueryRoutine>(),
                client => client.ListRoutines(MatchesWhenSerialized(reference), options),
                client => client.ListRoutines(datasetId, options),
                client => client.ListRoutines(ProjectId, datasetId, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).ListRoutines(options));
        }

        [Fact]
        public void CreateRoutineEquivalents()
        {
            var datasetId = "dataset";
            var routineId = "routine";
            var routine = new Routine();
            var reference = GetRoutineReference(datasetId, routineId);
            var options = new CreateRoutineOptions();
            VerifyEquivalent(new BigQueryRoutine(new DerivedBigQueryClient(), GetRoutine(reference)),
                client => client.CreateRoutine(MatchesWhenSerialized(reference), routine, options),
                client => client.CreateRoutine(datasetId, routineId, routine, options),
                client => client.CreateRoutine(ProjectId, datasetId, routineId, routine, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).CreateRoutine(routineId, routine, options));
        }

        [Fact]
        public void GetOrCreateRoutineEquivalents()
        {
            var datasetId = "dataset";
            var routineId = "routine";
            var routine = new Routine();
            var reference = GetRoutineReference(datasetId, routineId);
            var getOptions = new GetRoutineOptions();
            var createOptions = new CreateRoutineOptions();
            VerifyEquivalent(new BigQueryRoutine(new DerivedBigQueryClient(), GetRoutine(reference)),
                client => client.GetOrCreateRoutine(MatchesWhenSerialized(reference), routine, getOptions, createOptions),
                client => client.GetOrCreateRoutine(datasetId, routineId, routine, getOptions, createOptions),
                client => client.GetOrCreateRoutine(ProjectId, datasetId, routineId, routine, getOptions, createOptions),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetOrCreateRoutine(routineId, routine, getOptions, createOptions));
        }

        [Fact]
        public void DeleteRoutineEquivalents()
        {
            var datasetId = "dataset";
            var routineId = "routine";
            var reference = GetRoutineReference(datasetId, routineId);
            var options = new DeleteRoutineOptions();
            VerifyEquivalent(
                client => client.DeleteRoutine(MatchesWhenSerialized(reference), options),
                client => client.DeleteRoutine(datasetId, routineId, options),
                client => client.DeleteRoutine(ProjectId, datasetId, routineId, options),
                client => new BigQueryRoutine(client, new Routine { RoutineReference = reference }).Delete(options));
        }

        [Fact]
        public void UpdateRoutineEquivalents()
        {
            var datasetId = "dataset";
            var routineId = "routine";
            var reference = GetRoutineReference(datasetId, routineId);
            var resource = new Routine();
            var options = new UpdateRoutineOptions();
            VerifyEquivalent(new BigQueryRoutine(new DerivedBigQueryClient(), resource),
                client => client.UpdateRoutine(MatchesWhenSerialized(reference), resource, options),
                client => client.UpdateRoutine(datasetId, routineId, resource, options),
                client => client.UpdateRoutine(ProjectId, datasetId, routineId, resource, options),
                client => new BigQueryRoutine(client, GetRoutine(reference)).Update(resource, options));
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
        public void DeleteJobEquivalents()
        {
            var jobId = "job";
            var reference = GetJobReference(jobId);
            var options = new DeleteJobOptions();
            VerifyEquivalent(
                client => client.DeleteJob(MatchesWhenSerialized(reference), options),
                client => client.DeleteJob(jobId, options),
                client => client.DeleteJob(ProjectId, jobId, options),
                client => new BigQueryJob(client, new Job { JobReference = reference }).Delete(options));
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
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadCsvOptions();
            var stream = new MemoryStream();
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadCsv(MatchesWhenSerialized(tableReference), schema, stream, options),
                client => client.UploadCsv(datasetId, tableId, schema, stream, options),
                client => client.UploadCsv(ProjectId, datasetId, tableId, schema, stream, options),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadCsv(stream, options),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadCsv(tableId, schema, stream, options));
        }

        [Fact]
        public void UploadJson_Stream_Equivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadJsonOptions();
            var stream = new MemoryStream();
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadJson(MatchesWhenSerialized(tableReference), schema, stream, options),
                client => client.UploadJson(datasetId, tableId, schema, stream, options),
                client => client.UploadJson(ProjectId, datasetId, tableId, schema, stream, options),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadJson(stream, options),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadJson(tableId, schema, stream, options));
        }

        [Fact]
        public void UploadJson_Strings_Equivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadJsonOptions();
            var rows = new[] { "a", "b" };
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadJson(MatchesWhenSerialized(tableReference), schema, rows, options),
                client => client.UploadJson(datasetId, tableId, schema, rows, options),
                client => client.UploadJson(ProjectId, datasetId, tableId, schema, rows, options),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadJson(rows, options),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadJson(tableId, schema, rows, options));
        }

        [Fact]
        public void UploadAvro_Equivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadAvroOptions();
            var stream = new MemoryStream();
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadAvro(MatchesWhenSerialized(tableReference), schema, stream, options),
                client => client.UploadAvro(datasetId, tableId, schema, stream, options),
                client => client.UploadAvro(ProjectId, datasetId, tableId, schema, stream, options),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadAvro(stream, options),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadAvro(tableId, schema, stream, options));
        }

        [Fact]
        public void UploadParquet_Equivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var options = new UploadParquetOptions();
            var stream = new MemoryStream();
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadParquet(MatchesWhenSerialized(tableReference), stream, options),
                client => client.UploadParquet(datasetId, tableId, stream, options),
                client => client.UploadParquet(ProjectId, datasetId, tableId, stream, options),
                client => new BigQueryTable(client, GetTable(tableReference)).UploadParquet(stream, options),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadParquet(tableId, stream, options));
        }

        [Fact]
        public void UploadOrc_Equivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var options = new UploadOrcOptions();
            var stream = new MemoryStream();
            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadOrc(MatchesWhenSerialized(tableReference), stream, options),
                client => client.UploadOrc(datasetId, tableId, stream, options),
                client => client.UploadOrc(ProjectId, datasetId, tableId, stream, options),
                client => new BigQueryTable(client, GetTable(tableReference)).UploadOrc(stream, options),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadOrc(tableId, stream, options));
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
            VerifyEquivalent(new BigQueryInsertResults(new DerivedBigQueryClient(), options, Enumerable.Repeat(row, 1).ToList(), new TableDataInsertAllResponse()),
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
            VerifyEquivalent(new BigQueryInsertResults(new DerivedBigQueryClient(), options, rows, new TableDataInsertAllResponse()),
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
            VerifyEquivalent(new BigQueryInsertResults(new DerivedBigQueryClient(), options, rows, new TableDataInsertAllResponse()),
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
                client => client.CreateExtractJob(tableReference, uri, options),
                client => client.CreateExtractJob(ProjectId, datasetId, tableId, uri, options),
                client => client.CreateExtractJob(datasetId, tableId, uri, options),
                client => client.CreateExtractJob(ProjectId, datasetId, tableId, new[] { uri }, options),
                client => client.CreateExtractJob(datasetId, tableId, new[] { uri }, options),
                client => new BigQueryTable(client, GetTable(tableReference)).CreateExtractJob(uri, options),
                client => new BigQueryTable(client, GetTable(tableReference)).CreateExtractJob(new[] { uri }, options));
        }

        [Fact]
        public void CreateModelExtractJobEquivalents()
        {
            var datasetId = "dataset";
            var modelId = "model";
            var jobReference = GetJobReference("job");
            var modelReference = GetModelReference(datasetId, modelId);
            var uri = "gs://bucket/object";
            var options = new CreateModelExtractJobOptions();

            VerifyEquivalent(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.CreateModelExtractJob(MatchesWhenSerialized(modelReference), new[] { uri }, options),
                client => client.CreateModelExtractJob(ProjectId, datasetId, modelId, uri, options),
                client => client.CreateModelExtractJob(datasetId, modelId, uri, options),
                client => client.CreateModelExtractJob(modelReference, uri, options),
                client => client.CreateModelExtractJob(ProjectId, datasetId, modelId, new[] { uri }, options),
                client => client.CreateModelExtractJob(datasetId, modelId, new[] { uri }, options),
                client => new BigQueryModel(client, GetModel(modelReference)).CreateModelExtractJob(uri, options),
                client => new BigQueryModel(client, GetModel(modelReference)).CreateModelExtractJob(new[] { uri }, options));
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
        public void GetBigQueryServiceAccountEmailEquivalents()
        {
            var reference = GetProjectReference();
            var options = new GetBigQueryServiceAccountEmailOptions();
            VerifyEquivalent("project@service-account-email.com",
                client => client.GetBigQueryServiceAccountEmail(MatchesWhenSerialized(reference), options),
                client => client.GetBigQueryServiceAccountEmail(options),
                client => client.GetBigQueryServiceAccountEmail(ProjectId, options));
        }

        [Fact]
        public void CreateDatasetAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new CreateDatasetOptions();
            var dataset = new Dataset();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryDataset(new DerivedBigQueryClient(), GetDataset(reference)),
                client => client.CreateDatasetAsync(MatchesWhenSerialized(reference), dataset, options, token),
                client => client.CreateDatasetAsync(datasetId, dataset, options, token),
                client => client.CreateDatasetAsync(ProjectId, datasetId, dataset, options, token));
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
                client => client.DeleteDatasetAsync(ProjectId, datasetId, options, token),
                client => new BigQueryDataset(client, GetDataset(reference)).DeleteAsync(options, token));
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
            var dataset = new Dataset();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryDataset(new DerivedBigQueryClient(), GetDataset(reference)),
                client => client.GetOrCreateDatasetAsync(MatchesWhenSerialized(reference), dataset, getOptions, createOptions, token),
                client => client.GetOrCreateDatasetAsync(datasetId, dataset, getOptions, createOptions, token),
                client => client.GetOrCreateDatasetAsync(ProjectId, datasetId, dataset, getOptions, createOptions, token));
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
        public void UpdateDatasetAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var resource = new Dataset();
            var options = new UpdateDatasetOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryDataset(new DerivedBigQueryClient(), resource),
                client => client.UpdateDatasetAsync(MatchesWhenSerialized(reference), resource, options, token),
                client => client.UpdateDatasetAsync(datasetId, resource, options, token),
                client => client.UpdateDatasetAsync(ProjectId, datasetId, resource, options, token),
                client => new BigQueryDataset(client, GetDataset(reference)).UpdateAsync(resource, options, token));
        }

        [Fact]
        public void PatchDatasetAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var resource = new Dataset();
            var options = new PatchDatasetOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryDataset(new DerivedBigQueryClient(), resource),
                client => client.PatchDatasetAsync(MatchesWhenSerialized(reference), resource, options, token),
                client => client.PatchDatasetAsync(datasetId, resource, options, token),
                client => client.PatchDatasetAsync(ProjectId, datasetId, resource, options, token),
                client => new BigQueryDataset(client, GetDataset(reference)).PatchAsync(resource, false, options, token));
        }

        [Fact]
        public void SetDatasetLabelAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ModifyLabelsOptions();
            var token = new CancellationTokenSource().Token;
            string labelName = "label";
            string labelValue = "value";
            VerifyEquivalentAsync("oldValue",
                client => client.SetDatasetLabelAsync(MatchesWhenSerialized(reference), labelName, labelValue, options, token),
                client => client.SetDatasetLabelAsync(datasetId, labelName, labelValue, options, token),
                client => client.SetDatasetLabelAsync(ProjectId, datasetId, labelName, labelValue, options, token));
        }

        [Fact]
        public void RemoveDatasetLabelAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ModifyLabelsOptions();
            var token = new CancellationTokenSource().Token;
            string labelName = "label";
            VerifyEquivalentAsync("oldValue",
                client => client.RemoveDatasetLabelAsync(MatchesWhenSerialized(reference), labelName, options, token),
                client => client.RemoveDatasetLabelAsync(datasetId, labelName, options, token),
                client => client.RemoveDatasetLabelAsync(ProjectId, datasetId, labelName, options, token));
        }

        [Fact]
        public void ClearDatasetLabelsAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ModifyLabelsOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new Dictionary<string, string>(),
                client => client.ClearDatasetLabelsAsync(MatchesWhenSerialized(reference), options, token),
                client => client.ClearDatasetLabelsAsync(datasetId, options, token),
                client => client.ClearDatasetLabelsAsync(ProjectId, datasetId, options, token));
        }

        [Fact]
        public void ModifyDatasetLabelsAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ModifyLabelsOptions();
            var token = new CancellationTokenSource().Token;
            var labels = new Dictionary<string, string>();
            VerifyEquivalentAsync(new Dictionary<string, string>(),
                client => client.ModifyDatasetLabelsAsync(MatchesWhenSerialized(reference), labels, options, token),
                client => client.ModifyDatasetLabelsAsync(datasetId, labels, options, token),
                client => client.ModifyDatasetLabelsAsync(ProjectId, datasetId, labels, options, token));
        }

        [Fact]
        public void CreateTableAsyncEquivalents_Schema()
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
        public void CreateTableAsyncEquivalents_Table()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var schema = new TableSchemaBuilder().Build();
            var table = new Table { Schema = schema };
            var reference = GetTableReference(datasetId, tableId);
            var options = new CreateTableOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryTable(new DerivedBigQueryClient(), GetTable(reference)),
                client => client.CreateTableAsync(MatchesWhenSerialized(reference), table, options, token),
                client => client.CreateTableAsync(datasetId, tableId, table, options, token),
                client => client.CreateTableAsync(ProjectId, datasetId, tableId, table, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetId)).CreateTableAsync(tableId, table, options, token));
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
        public void GetOrCreateTableAsyncEquivalents_Schema()
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
        public void GetOrCreateTableAsyncEquivalents_Table()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var schema = new TableSchemaBuilder().Build();
            var table = new Table { Schema = schema };
            var reference = GetTableReference(datasetId, tableId);
            var getOptions = new GetTableOptions();
            var createOptions = new CreateTableOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryTable(new DerivedBigQueryClient(), GetTable(reference)),
                client => client.GetOrCreateTableAsync(MatchesWhenSerialized(reference), table, getOptions, createOptions, token),
                client => client.GetOrCreateTableAsync(datasetId, tableId, table, getOptions, createOptions, token),
                client => client.GetOrCreateTableAsync(ProjectId, datasetId, tableId, table, getOptions, createOptions, token),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetOrCreateTableAsync(tableId, table, getOptions, createOptions, token));
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
        public void UpdateTableAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var resource = new Table();
            var options = new UpdateTableOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryTable(new DerivedBigQueryClient(), resource),
                client => client.UpdateTableAsync(MatchesWhenSerialized(reference), resource, options, token),
                client => client.UpdateTableAsync(datasetId, tableId, resource, options, token),
                client => client.UpdateTableAsync(ProjectId, datasetId, tableId, resource, options, token),
                client => new BigQueryTable(client, GetTable(reference)).UpdateAsync(resource, options, token));
        }

        [Fact]
        public void PatchTableAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var resource = new Table();
            var options = new PatchTableOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryTable(new DerivedBigQueryClient(), resource),
                client => client.PatchTableAsync(MatchesWhenSerialized(reference), resource, options, token),
                client => client.PatchTableAsync(datasetId, tableId, resource, options, token),
                client => client.PatchTableAsync(ProjectId, datasetId, tableId, resource, options, token),
                client => new BigQueryTable(client, GetTable(reference)).PatchAsync(resource, false, options, token));
        }

        [Fact]
        public void GetTableIamPolicyAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var options = new GetTableIamPolicyOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new Policy(),
                client => client.GetTableIamPolicyAsync(MatchesWhenSerialized(reference), options, token),
                client => client.GetTableIamPolicyAsync(datasetId, tableId, options, token),
                client => client.GetTableIamPolicyAsync(ProjectId, datasetId, tableId, options, token),
                client => new BigQueryTable(client, GetTable(reference)).GetIamPolicyAsync(options, token));
        }

        [Fact]
        public void SetTableIamPolicyAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var policy = new Policy();
            var options = new SetTableIamPolicyOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new Policy(),
                client => client.SetTableIamPolicyAsync(MatchesWhenSerialized(reference), policy, options, token),
                client => client.SetTableIamPolicyAsync(datasetId, tableId, policy, options, token),
                client => client.SetTableIamPolicyAsync(ProjectId, datasetId, tableId, policy, options, token),
                client => new BigQueryTable(client, GetTable(reference)).SetIamPolicyAsync(policy, options, token));
        }

        [Fact]
        public void TestTableIamPermissionsAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var reference = GetTableReference(datasetId, tableId);
            var permissions = new List<string>();
            var options = new TestTableIamPermissionsOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new TestIamPermissionsResponse(),
                client => client.TestTableIamPermissionsAsync(MatchesWhenSerialized(reference), permissions, options, token),
                client => client.TestTableIamPermissionsAsync(datasetId, tableId, permissions, options, token),
                client => client.TestTableIamPermissionsAsync(ProjectId, datasetId, tableId, permissions, options, token),
                client => new BigQueryTable(client, GetTable(reference)).TestIamPermissionsAsync(permissions, options, token));
        }

        [Fact]
        public void DeleteModelAsyncEquivalents()
        {
            var datasetId = "dataset";
            var modelId = "model";
            var reference = GetModelReference(datasetId, modelId);
            var options = new DeleteModelOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(
                client => client.DeleteModelAsync(MatchesWhenSerialized(reference), options, token),
                client => client.DeleteModelAsync(datasetId, modelId, options, token),
                client => client.DeleteModelAsync(ProjectId, datasetId, modelId, options, token),
                client => new BigQueryModel(client, new Model { ModelReference = reference }).DeleteAsync(options, token));
        }

        [Fact]
        public void GetModelAsyncEquivalents()
        {
            var datasetId = "dataset";
            var modelId = "model";
            var reference = GetModelReference(datasetId, modelId);
            var options = new GetModelOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryModel(new DerivedBigQueryClient(), GetModel(reference)),
                client => client.GetModelAsync(MatchesWhenSerialized(reference), options, token),
                client => client.GetModelAsync(datasetId, modelId, options, token),
                client => client.GetModelAsync(ProjectId, datasetId, modelId, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetModelAsync(modelId, options, token));
        }

        [Fact]
        public void ListModelsAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ListModelsOptions();
            VerifyEquivalent(new UnimplementedPagedAsyncEnumerable<ListModelsResponse, BigQueryModel>(),
                client => client.ListModelsAsync(MatchesWhenSerialized(reference), options),
                client => client.ListModelsAsync(datasetId, options),
                client => client.ListModelsAsync(ProjectId, datasetId, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).ListModelsAsync(options));
        }

        [Fact]
        public void PatchModelAsyncEquivalents()
        {
            var datasetId = "dataset";
            var modelId = "model";
            var reference = GetModelReference(datasetId, modelId);
            var resource = new Model();
            var options = new PatchModelOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryModel(new DerivedBigQueryClient(), resource),
                client => client.PatchModelAsync(MatchesWhenSerialized(reference), resource, options, token),
                client => client.PatchModelAsync(datasetId, modelId, resource, options, token),
                client => client.PatchModelAsync(ProjectId, datasetId, modelId, resource, options, token),
                client => new BigQueryModel(client, GetModel(reference)).PatchAsync(resource, false, options, token));
        }

        [Fact]
        public void GetRoutineAsyncEquivalents()
        {
            var datasetId = "dataset";
            var routineId = "routine";
            var reference = GetRoutineReference(datasetId, routineId);
            var options = new GetRoutineOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryRoutine(new DerivedBigQueryClient(), GetRoutine(reference)),
                client => client.GetRoutineAsync(MatchesWhenSerialized(reference), options, token),
                client => client.GetRoutineAsync(datasetId, routineId, options, token),
                client => client.GetRoutineAsync(ProjectId, datasetId, routineId, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetRoutineAsync(routineId, options, token));
        }

        [Fact]
        public void ListRoutinesAsyncEquivalents()
        {
            var datasetId = "dataset";
            var reference = GetDatasetReference(datasetId);
            var options = new ListRoutinesOptions();
            VerifyEquivalent(new UnimplementedPagedAsyncEnumerable<ListRoutinesResponse, BigQueryRoutine>(),
                client => client.ListRoutinesAsync(MatchesWhenSerialized(reference), options),
                client => client.ListRoutinesAsync(datasetId, options),
                client => client.ListRoutinesAsync(ProjectId, datasetId, options),
                client => new BigQueryDataset(client, GetDataset(datasetId)).ListRoutinesAsync(options));
        }

        [Fact]
        public void CreateRoutineAsyncEquivalents()
        {
            var datasetId = "dataset";
            var routineId = "routine";
            var routine = new Routine();
            var reference = GetRoutineReference(datasetId, routineId);
            var options = new CreateRoutineOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryRoutine(new DerivedBigQueryClient(), GetRoutine(reference)),
                client => client.CreateRoutineAsync(MatchesWhenSerialized(reference), routine, options, token),
                client => client.CreateRoutineAsync(datasetId, routineId, routine, options, token),
                client => client.CreateRoutineAsync(ProjectId, datasetId, routineId, routine, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetId)).CreateRoutineAsync(routineId, routine, options, token));
        }

        [Fact]
        public void GetOrCreateRoutineAsyncEquivalents()
        {
            var datasetId = "dataset";
            var routineId = "routine";
            var routine = new Routine();
            var reference = GetRoutineReference(datasetId, routineId);
            var getOptions = new GetRoutineOptions();
            var createOptions = new CreateRoutineOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryRoutine(new DerivedBigQueryClient(), GetRoutine(reference)),
                client => client.GetOrCreateRoutineAsync(MatchesWhenSerialized(reference), routine, getOptions, createOptions, token),
                client => client.GetOrCreateRoutineAsync(datasetId, routineId, routine, getOptions, createOptions, token),
                client => client.GetOrCreateRoutineAsync(ProjectId, datasetId, routineId, routine, getOptions, createOptions, token),
                client => new BigQueryDataset(client, GetDataset(datasetId)).GetOrCreateRoutineAsync(routineId, routine, getOptions, createOptions, token));
        }

        [Fact]
        public void DeleteRoutineAsyncEquivalents()
        {
            var datasetId = "dataset";
            var routineId = "routine";
            var reference = GetRoutineReference(datasetId, routineId);
            var options = new DeleteRoutineOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(
                client => client.DeleteRoutineAsync(MatchesWhenSerialized(reference), options, token),
                client => client.DeleteRoutineAsync(datasetId, routineId, options, token),
                client => client.DeleteRoutineAsync(ProjectId, datasetId, routineId, options, token),
                client => new BigQueryRoutine(client, new Routine { RoutineReference = reference }).DeleteAsync(options, token));
        }

        [Fact]
        public void UpdateRoutineAsyncEquivalents()
        {
            var datasetId = "dataset";
            var routineId = "routine";
            var reference = GetRoutineReference(datasetId, routineId);
            var resource = new Routine();
            var options = new UpdateRoutineOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(new BigQueryRoutine(new DerivedBigQueryClient(), resource),
                client => client.UpdateRoutineAsync(MatchesWhenSerialized(reference), resource, options, token),
                client => client.UpdateRoutineAsync(datasetId, routineId, resource, options, token),
                client => client.UpdateRoutineAsync(ProjectId, datasetId, routineId, resource, options, token),
                client => new BigQueryRoutine(client, GetRoutine(reference)).UpdateAsync(resource, options, token));
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
        public void DeleteJobAsyncEquivalents()
        {
            var jobId = "job";
            var reference = GetJobReference(jobId);
            var options = new DeleteJobOptions();
            var token = new CancellationTokenSource().Token;
            VerifyEquivalentAsync(
                client => client.DeleteJobAsync(MatchesWhenSerialized(reference), options, token),
                client => client.DeleteJobAsync(jobId, options, token),
                client => client.DeleteJobAsync(ProjectId, jobId, options, token),
                client => new BigQueryJob(client, new Job { JobReference = reference }).DeleteAsync(options, token));
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
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadCsvOptions();
            var token = new CancellationTokenSource().Token;
            var stream = new MemoryStream();
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadCsvAsync(MatchesWhenSerialized(tableReference), schema, stream, options, token),
                client => client.UploadCsvAsync(datasetId, tableId, schema, stream, options, token),
                client => client.UploadCsvAsync(ProjectId, datasetId, tableId, schema, stream, options, token),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadCsvAsync(stream, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadCsvAsync(tableId, schema, stream, options, token));
        }

        [Fact]
        public void UploadJson_Stream_AsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadJsonOptions();
            var token = new CancellationTokenSource().Token;
            var stream = new MemoryStream();
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadJsonAsync(MatchesWhenSerialized(tableReference), schema, stream, options, token),
                client => client.UploadJsonAsync(datasetId, tableId, schema, stream, options, token),
                client => client.UploadJsonAsync(ProjectId, datasetId, tableId, schema, stream, options, token),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadJsonAsync(stream, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadJsonAsync(tableId, schema, stream, options, token));
        }

        [Fact]
        public void UploadJson_Strings_AsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadJsonOptions();
            var token = new CancellationTokenSource().Token;
            var rows = new[] { "a", "b" };
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadJsonAsync(MatchesWhenSerialized(tableReference), schema, rows, options, token),
                client => client.UploadJsonAsync(datasetId, tableId, schema, rows, options, token),
                client => client.UploadJsonAsync(ProjectId, datasetId, tableId, schema, rows, options, token),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadJsonAsync(rows, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadJsonAsync(tableId, schema, rows, options, token));
        }

        [Fact]
        public void UploadAvroAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var schema = new TableSchemaBuilder().Build();
            var options = new UploadAvroOptions();
            var token = new CancellationTokenSource().Token;
            var stream = new MemoryStream();
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadAvroAsync(MatchesWhenSerialized(tableReference), schema, stream, options, token),
                client => client.UploadAvroAsync(datasetId, tableId, schema, stream, options, token),
                client => client.UploadAvroAsync(ProjectId, datasetId, tableId, schema, stream, options, token),
                client => new BigQueryTable(client, GetTable(tableReference, schema)).UploadAvroAsync(stream, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadAvroAsync(tableId, schema, stream, options, token));
        }

        [Fact]
        public void UploadParquetAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var options = new UploadParquetOptions();
            var token = new CancellationTokenSource().Token;
            var stream = new MemoryStream();
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadParquetAsync(MatchesWhenSerialized(tableReference), stream, options, token),
                client => client.UploadParquetAsync(datasetId, tableId, stream, options, token),
                client => client.UploadParquetAsync(ProjectId, datasetId, tableId, stream, options, token),
                client => new BigQueryTable(client, GetTable(tableReference)).UploadParquetAsync(stream, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadParquetAsync(tableId, stream, options, token));
        }

        [Fact]
        public void UploadOrcAsyncEquivalents()
        {
            var datasetId = "dataset";
            var tableId = "table";
            var jobReference = GetJobReference("job");
            var datasetReference = GetDatasetReference(datasetId);
            var tableReference = GetTableReference(datasetId, tableId);
            var options = new UploadOrcOptions();
            var token = new CancellationTokenSource().Token;
            var stream = new MemoryStream();
            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.UploadOrcAsync(MatchesWhenSerialized(tableReference), stream, options, token),
                client => client.UploadOrcAsync(datasetId, tableId, stream, options, token),
                client => client.UploadOrcAsync(ProjectId, datasetId, tableId, stream, options, token),
                client => new BigQueryTable(client, GetTable(tableReference)).UploadOrcAsync(stream, options, token),
                client => new BigQueryDataset(client, GetDataset(datasetReference)).UploadOrcAsync(tableId, stream, options, token));
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
            VerifyEquivalentAsync(new BigQueryInsertResults(new DerivedBigQueryClient(), options, Enumerable.Repeat(row, 1).ToList(), new TableDataInsertAllResponse()),
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
            VerifyEquivalentAsync(new BigQueryInsertResults(new DerivedBigQueryClient(), options, rows, new TableDataInsertAllResponse()),
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
            VerifyEquivalentAsync(new BigQueryInsertResults(new DerivedBigQueryClient(), options, rows, new TableDataInsertAllResponse()),
                client => client.InsertRowsAsync(MatchesWhenSerialized(reference), rows, null, default),
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
                client => client.CreateExtractJobAsync(tableReference, uri, options, token),
                client => client.CreateExtractJobAsync(ProjectId, datasetId, tableId, uri, options, token),
                client => client.CreateExtractJobAsync(datasetId, tableId, uri, options, token),
                client => client.CreateExtractJobAsync(ProjectId, datasetId, tableId, new[] { uri }, options, token),
                client => client.CreateExtractJobAsync(datasetId, tableId, new[] { uri }, options, token),
                client => new BigQueryTable(client, GetTable(tableReference)).CreateExtractJobAsync(uri, options, token),
                client => new BigQueryTable(client, GetTable(tableReference)).CreateExtractJobAsync(new[] { uri }, options, token));
        }

        [Fact]
        public void CreateModelExtractJobAsyncEquivalents()
        {
            var datasetId = "dataset";
            var modelId = "model";
            var jobReference = GetJobReference("job");
            var modelReference = GetModelReference(datasetId, modelId);
            var uri = "gs://bucket/object";
            var options = new CreateModelExtractJobOptions();
            var token = new CancellationTokenSource().Token;

            VerifyEquivalentAsync(new BigQueryJob(new DerivedBigQueryClient(), new Job { JobReference = jobReference }),
                client => client.CreateModelExtractJobAsync(MatchesWhenSerialized(modelReference), new[] { uri }, options, token),
                client => client.CreateModelExtractJobAsync(ProjectId, datasetId, modelId, uri, options, token),
                client => client.CreateModelExtractJobAsync(datasetId, modelId, uri, options, token),
                client => client.CreateModelExtractJobAsync(modelReference, uri, options, token),
                client => client.CreateModelExtractJobAsync(ProjectId, datasetId, modelId, new[] { uri }, options, token),
                client => client.CreateModelExtractJobAsync(datasetId, modelId, new[] { uri }, options, token),
                client => new BigQueryModel(client, GetModel(modelReference)).CreateModelExtractJobAsync(uri, options, token),
                client => new BigQueryModel(client, GetModel(modelReference)).CreateModelExtractJobAsync(new[] { uri }, options, token));
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

        [Fact]
        public void GetBigQueryServiceAccountEmailAsyncEquivalents()
        {
            var reference = GetProjectReference();
            var options = new GetBigQueryServiceAccountEmailOptions();
            var token = new CancellationTokenSource().Token;

            VerifyEquivalentAsync("project@service-account-email.com",
                client => client.GetBigQueryServiceAccountEmailAsync(MatchesWhenSerialized(reference), options, token),
                client => client.GetBigQueryServiceAccountEmailAsync(options, token),
                client => client.GetBigQueryServiceAccountEmailAsync(ProjectId, options, token));
        }

        // TODO: Equivalents for GetQueryResults. That's currently a two-stage process (fetch job, fetch results) which we don't have
        // support for in the code below.

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

        private static Model GetModel(string datasetId, string modelId) =>
            GetModel(GetModelReference(datasetId, modelId));

        private static Model GetModel(ModelReference reference) =>
            new Model { ModelReference = reference };

        private static ModelReference GetModelReference(string datasetId, string modelId) =>
            new ModelReference { ProjectId = ProjectId, DatasetId = datasetId, ModelId = modelId };

        private static Routine GetRoutine(RoutineReference reference) =>
            new Routine { RoutineReference = reference };

        private static RoutineReference GetRoutineReference(string datasetId, string routineId) =>
            new RoutineReference { ProjectId = ProjectId, DatasetId = datasetId, RoutineId = routineId };

        private static Dataset GetDataset(string datasetId) => GetDataset(GetDatasetReference(datasetId));

        private static Dataset GetDataset(DatasetReference reference) => new Dataset { DatasetReference = reference };

        private static DatasetReference GetDatasetReference(string datasetId) =>
            new DatasetReference { ProjectId = ProjectId, DatasetId = datasetId };

        private static Job GetJob(string jobId) => GetJob(GetJobReference(jobId));

        private static Job GetJob(JobReference reference) => new Job { JobReference = reference };

        private static JobReference GetJobReference(string JobId) =>
            new JobReference { ProjectId = ProjectId, JobId = JobId, Location = Location };

        private static ProjectReference GetProjectReference() => new ProjectReference { ProjectId = ProjectId };

        private class UnimplementedPagedEnumerable<TResponse, TResource> : PagedEnumerable<TResponse, TResource>
        {
        }

        private class UnimplementedPagedAsyncEnumerable<TResponse, TResource> : PagedAsyncEnumerable<TResponse, TResource>
        {
        }
    }
}
