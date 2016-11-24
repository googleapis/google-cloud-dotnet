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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
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

        public BigQueryFixture()
        {
            ProjectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }

            DatasetId = DateTime.UtcNow.ToString("'test'_yyyyMMddTHHmmssFFF", CultureInfo.InvariantCulture);

            CreateData();
        }

        private void CreateData()
        {
            var client = BigQueryClient.Create(ProjectId);
            var dataset = client.CreateDataset(DatasetId);
            CreateHighScoreTable(dataset);
            CreatePeopleTable(dataset);
            CreateComplexTypesTable(dataset);
        }

        private void CreateHighScoreTable(BigQueryDataset dataset)
        {
            var table = dataset.CreateTable(HighScoreTableId, new TableSchemaBuilder
                {
                    { "player", BigQueryDbType.String },
                    { "gameStarted", BigQueryDbType.Timestamp },
                    { "score", BigQueryDbType.Integer }
                }.Build());
            table.Insert(new[]
            {
                new InsertRow {
                    { "player", "Bob" },
                    { "score", 85 },
                    { "gameStarted", new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
                },
                new InsertRow {
                    { "player", "Angela" },
                    { "score", 95 },
                    { "gameStarted", new DateTime(2002, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
                },
                new InsertRow {
                    { "player", null }, // Unnamed player...
                    { "score", 1 },
                    { "gameStarted", new DateTime(2001, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
                }
            });
        }

        private void CreatePeopleTable(BigQueryDataset dataset)
        {
            // Sample schema taken from 
            // https://cloud.google.com/bigquery/docs/data
            // Data is loaded in UploadTest.
            var table = dataset.CreateTable(PeopleTableId, new TableSchemaBuilder
            {
                { "name", BigQueryDbType.String },
                { "fullName", BigQueryDbType.String, FieldMode.Required },
                { "age", BigQueryDbType.Integer },
                { "gender", BigQueryDbType.String },
                { "phoneNumber", new TableSchemaBuilder
                    {
                        { "areaCode", BigQueryDbType.Integer },
                        { "number", BigQueryDbType.Integer }
                    }
                },
                { "children", new TableSchemaBuilder
                    {
                        { "name", BigQueryDbType.String },
                        { "gender", BigQueryDbType.String },
                        { "age", BigQueryDbType.Integer },
                    },
                    FieldMode.Repeated
                },
                { "citiesLived", new TableSchemaBuilder
                    {
                        { "place", BigQueryDbType.String },
                        { "yearsLived", BigQueryDbType.Integer, FieldMode.Repeated },
                    },
                    FieldMode.Repeated
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
                { "tags", BigQueryDbType.String, FieldMode.Repeated },
                { "position", new TableSchemaBuilder
                    {
                        { "x", BigQueryDbType.Integer },
                        { "y", BigQueryDbType.Integer }
                    }
                },
                { "names", new TableSchemaBuilder
                    {
                        { "first", BigQueryDbType.String },
                        { "last", BigQueryDbType.String }
                    },
                    FieldMode.Repeated
                }
            }.Build());
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
