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

using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;


namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    // See https://xunit.github.io/docs/shared-context.html#collection-fixture
    // ... although I've removed the separate collection class, and instead just
    // put the attribute on BigQueryFixture.

    /// <summary>
    /// Test fixture which creates a new timestamped dataset for all the tests to
    /// operate on.
    /// </summary>
    [CollectionDefinition(nameof(BigQueryFixture))]
    public class BigQueryFixture : IDisposable, ICollectionFixture<BigQueryFixture>
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";

        public string ProjectId { get; }
        public string DatasetId { get; }
        public string HighScoreTableId { get; } = "highscores";
        public string PeopleTableId { get; } = "people";
        public string ComplexTypesTableId { get; } = "complex";
        public string ExhaustiveTypesTableId { get; } = "exhaustive";

        public BigQueryFixture()
        {
            ProjectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }

            DatasetId = DateTime.UtcNow.ToString("'test'_yyyyMMddTHHmmssfff", CultureInfo.InvariantCulture);

            CreateData();
        }

        private void CreateData()
        {
            var client = BigQueryClient.Create(ProjectId);
            var dataset = client.CreateDataset(DatasetId);
            CreateHighScoreTable(dataset);
            CreatePeopleTable(dataset);
            CreateComplexTypesTable(dataset);
            CreateExhaustiveTypesTable(dataset);
        }

        private void CreateHighScoreTable(BigQueryDataset dataset)
        {
            var table = dataset.CreateTable(HighScoreTableId, new TableSchemaBuilder
                {
                    { "player", BigQueryDbType.String },
                    { "gameStarted", BigQueryDbType.Timestamp },
                    { "score", BigQueryDbType.Int64 }
                }.Build());
            
            var rows = new[]
            {
                new BigQueryInsertRow {
                    { "player", "Bob" },
                    { "score", 85 },
                    { "gameStarted", new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
                },
                new BigQueryInsertRow {
                    { "player", "Bob" },
                    { "score", 60 },
                    { "gameStarted", new DateTime(1999, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
                },
                new BigQueryInsertRow {
                    { "player", "Angela" },
                    { "score", 95 },
                    { "gameStarted", new DateTime(2002, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
                },
                new BigQueryInsertRow {
                    { "player", null }, // Unnamed player...
                    { "score", 1 },
                    { "gameStarted", new DateTime(2001, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
                }
            };
            InsertAndWait(table, () => table.InsertRows(rows), 4);
        }

        private void CreatePeopleTable(BigQueryDataset dataset)
        {
            // Sample schema taken from 
            // https://cloud.google.com/bigquery/docs/data
            // Data is loaded in UploadTest.
            var table = dataset.CreateTable(PeopleTableId, new TableSchemaBuilder
            {
                { "name", BigQueryDbType.String },
                { "fullName", BigQueryDbType.String, BigQueryFieldMode.Required },
                { "age", BigQueryDbType.Int64 },
                { "gender", BigQueryDbType.String },
                { "phoneNumber", new TableSchemaBuilder
                    {
                        { "areaCode", BigQueryDbType.Int64 },
                        { "number", BigQueryDbType.Int64 }
                    }
                },
                { "children", new TableSchemaBuilder
                    {
                        { "name", BigQueryDbType.String },
                        { "gender", BigQueryDbType.String },
                        { "age", BigQueryDbType.Int64 },
                    },
                    BigQueryFieldMode.Repeated
                },
                { "citiesLived", new TableSchemaBuilder
                    {
                        { "place", BigQueryDbType.String },
                        { "yearsLived", BigQueryDbType.Int64, BigQueryFieldMode.Repeated },
                    },
                    BigQueryFieldMode.Repeated
                }
            }.Build());
            List<string> jsonRows = LoadTextResource("personsData.json");
            var job = table.UploadJson(jsonRows);

            var result = job.PollUntilCompleted();
            var errors = result.Status.ErrorResult;
            if (errors != null)
            {
                throw new Exception("Errors uploading JSON: " + errors);
            }
        }

        private void CreateComplexTypesTable(BigQueryDataset dataset)
        {
            dataset.CreateTable(ComplexTypesTableId, new TableSchemaBuilder
            {
                { "guid", BigQueryDbType.String },
                { "tags", BigQueryDbType.String, BigQueryFieldMode.Repeated },
                { "position", new TableSchemaBuilder
                    {
                        { "x", BigQueryDbType.Int64 },
                        { "y", BigQueryDbType.Int64 }
                    }
                },
                { "job", new TableSchemaBuilder
                    {
                        { "company", BigQueryDbType.String },
                        { "roles", BigQueryDbType.String, BigQueryFieldMode.Repeated }
                    }
                },
                { "names", new TableSchemaBuilder
                    {
                        { "first", BigQueryDbType.String },
                        { "last", BigQueryDbType.String }
                    },
                    BigQueryFieldMode.Repeated
                }
            }.Build());
        }

        private void CreateExhaustiveTypesTable(BigQueryDataset dataset)
        {
            // Record containing a single string, a repeated string and a nested record
            TableSchema recordSchema = new TableSchemaBuilder
            {
                { "single_string", BigQueryDbType.String },
                { "repeated_string", BigQueryDbType.String, BigQueryFieldMode.Repeated },
                { "nested_record",
                    new TableSchemaBuilder {    
                        { "a", BigQueryDbType.Int64 },
                        { "b", BigQueryDbType.Int64 },
                    }
                }
            }.Build();

            var table = dataset.CreateTable(ExhaustiveTypesTableId, new TableSchemaBuilder
            {
                // Single fields
                { "single_string", BigQueryDbType.String },
                { "single_bool", BigQueryDbType.Bool },
                { "single_bytes", BigQueryDbType.Bytes },
                { "single_date", BigQueryDbType.Date },
                { "single_datetime", BigQueryDbType.DateTime },
                { "single_time", BigQueryDbType.Time },
                { "single_timestamp", BigQueryDbType.Timestamp },
                { "single_int64", BigQueryDbType.Int64 },
                { "single_float64", BigQueryDbType.Float64 },
                { "single_record", recordSchema },
                
                // Repeated fields
                { "array_string", BigQueryDbType.String, BigQueryFieldMode.Repeated },
                { "array_bool", BigQueryDbType.Bool, BigQueryFieldMode.Repeated },
                { "array_bytes", BigQueryDbType.Bytes, BigQueryFieldMode.Repeated },
                { "array_date", BigQueryDbType.Date, BigQueryFieldMode.Repeated },
                { "array_datetime", BigQueryDbType.DateTime, BigQueryFieldMode.Repeated },
                { "array_time", BigQueryDbType.Time, BigQueryFieldMode.Repeated },
                { "array_timestamp", BigQueryDbType.Timestamp, BigQueryFieldMode.Repeated },
                { "array_int64", BigQueryDbType.Int64, BigQueryFieldMode.Repeated },
                { "array_float64", BigQueryDbType.Float64, BigQueryFieldMode.Repeated },
                { "array_record", recordSchema, BigQueryFieldMode.Repeated },                
            }.Build());

            InsertAndWait(table, () => table.InsertRow(ExhaustiveTypesTest.GetSampleRow()), 1);
        }

        internal void InsertAndWait(BigQueryTable table, Action insertAction, int expectedRowCountChange)
        {
            var countBefore = table.ListRows().Count();
            var expectedCount = countBefore + expectedRowCountChange;
            insertAction();
            // Wait until there are *at least* enough rows
            int actualCount = table.PollUntilRowCountIsAtLeast(expectedCount);
            // Now check it's *exactly* the right number of rows.
            Assert.Equal(expectedCount, actualCount);
        }

        internal List<string> LoadTextResource(string relativeName)
        {
            var typeInfo = typeof(BigQueryFixture).GetTypeInfo();
            string resourceName = typeInfo.Namespace + "." + relativeName;
            var ret = new List<string>();
            using (var reader = new StreamReader(typeInfo.Assembly.GetManifestResourceStream(resourceName)))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    ret.Add(line);
                }
            }
            return ret;
        }

        internal string CreateTableId() => "test_" + Guid.NewGuid().ToString().Replace("-", "_");

        public void Dispose()
        {
            // TODO: Consider deleting the dataset here. It
            // might be nice to clean up after ourselves, but realistically
            // we won't be creating much data, and it's useful to be able to see
            // it after tests have finished, particularly on failure.
        }
    }
}
