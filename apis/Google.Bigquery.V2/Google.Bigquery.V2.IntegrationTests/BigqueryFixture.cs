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


namespace Google.Bigquery.V2.IntegrationTests
{
    // See https://xunit.github.io/docs/shared-context.html#collection-fixture
    // ... although I've removed the separate collection class, and instead just
    // put the attribute on BigqueryFixture.

    /// <summary>
    /// Test fixture which creates a new timestamped dataset for all the tests to
    /// operate on.
    /// </summary>
    [CollectionDefinition(nameof(BigqueryFixture))]
    public class BigqueryFixture : IDisposable, ICollectionFixture<BigqueryFixture>
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";

        public string ProjectId { get; }
        public string DatasetId { get; }
        public string HighScoreTableId { get; } = "highscores";
        public string PeopleTableId { get; } = "people";
        public string ComplexTypesTableId { get; } = "complex";

        public BigqueryFixture()
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
            var client = BigqueryClient.Create(ProjectId);
            var dataset = client.CreateDataset(DatasetId);
            CreateHighScoreTable(dataset);
            CreatePeopleTable(dataset);
            CreateComplexTypesTable(dataset);
        }

        private void CreateHighScoreTable(BigqueryDataset dataset)
        {
            var table = dataset.CreateTable(HighScoreTableId, new TableSchemaBuilder
                {
                    { "player", BigqueryDbType.String },
                    { "gameStarted", BigqueryDbType.Timestamp },
                    { "score", BigqueryDbType.Integer }
                }.Build());
            table.Insert(new InsertRow {
                { "player", "Bob" },
                { "score", 85 },
                { "gameStarted", new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
            });
        }

        private void CreatePeopleTable(BigqueryDataset dataset)
        {
            // Sample schema taken from 
            // https://cloud.google.com/bigquery/docs/data
            // Data is loaded in UploadTest.
            var table = dataset.CreateTable(PeopleTableId, new TableSchemaBuilder
            {
                { "name", BigqueryDbType.String },
                { "fullName", BigqueryDbType.String, FieldMode.Required },
                { "age", BigqueryDbType.Integer },
                { "gender", BigqueryDbType.String },
                { "phoneNumber", new TableSchemaBuilder
                    {
                        { "areaCode", BigqueryDbType.Integer },
                        { "number", BigqueryDbType.Integer }
                    }
                },
                { "children", new TableSchemaBuilder
                    {
                        { "name", BigqueryDbType.String },
                        { "gender", BigqueryDbType.String },
                        { "age", BigqueryDbType.Integer },
                    },
                    FieldMode.Repeated
                },
                { "citiesLived", new TableSchemaBuilder
                    {
                        { "place", BigqueryDbType.String },
                        { "yearsLived", BigqueryDbType.Integer, FieldMode.Repeated },
                    },
                    FieldMode.Repeated
                }
            }.Build());
            // TODO: We need to make this easier to use.
            List<string> jsonRows = LoadTextResource("personsData.json");
            var bytes = Encoding.UTF8.GetBytes(string.Join("\n", jsonRows));
            var job = table.UploadJson(new MemoryStream(bytes));

            var result = job.Poll();
            var errors = result.Status.ErrorResult;
            if (errors != null)
            {
                throw new Exception("Errors uploading JSON: " + errors);
            }
        }

        private void CreateComplexTypesTable(BigqueryDataset dataset)
        {
            dataset.CreateTable(ComplexTypesTableId, new TableSchemaBuilder
            {
                { "guid", BigqueryDbType.String },
                { "tags", BigqueryDbType.String, FieldMode.Repeated },
                { "position", new TableSchemaBuilder
                    {
                        { "x", BigqueryDbType.Integer },
                        { "y", BigqueryDbType.Integer }
                    }
                },
                { "names", new TableSchemaBuilder
                    {
                        { "first", BigqueryDbType.String },
                        { "last", BigqueryDbType.String }
                    },
                    FieldMode.Repeated
                }
            }.Build());
        }

        internal List<string> LoadTextResource(string relativeName)
        {
            var typeInfo = typeof(BigqueryFixture).GetTypeInfo();
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
