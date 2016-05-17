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
using Xunit;


namespace Google.Bigquery.V2.IntegrationTests
{
    // See https://xunit.github.io/docs/shared-context.html#collection-fixture
    // ... although I've removed the separate collection class, and instead just
    // put the attribute on SampleDatasetFixture.

    /// <summary>
    /// Test fixture which creates a new timestamped dataset for all the tests to
    /// operate on.
    /// </summary>
    [CollectionDefinition(nameof(SampleDatasetFixture))]
    public class SampleDatasetFixture : IDisposable, ICollectionFixture<SampleDatasetFixture>
    {
        public string ProjectId { get; }
        public string DatasetId { get; }
        public string HighScoreTableId { get; } = "highscores";
        public string AddressbookTableId { get; } = "addressbook";

        public SampleDatasetFixture()
        {
            // TODO: Inline the code, and remove CloudConfiguration?
            ProjectId = CloudConfiguration.Instance.Project;
            DatasetId = DateTime.UtcNow.ToString("'test'_yyyyMMddTHHmmssFFF", CultureInfo.InvariantCulture);

            CreateData();
        }

        private void CreateData()
        {
            var client = BigqueryClient.Create(ProjectId);
            var dataset = client.CreateDataset(DatasetId);
            CreateHighScoreTable(dataset);
            CreateAddressbookTable(dataset);
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

        private void CreateAddressbookTable(BigqueryDataset dataset)
        {
            // Note: the address format here is purely for testing nested schemas.
            // Address data is fiendishly complicated in reality. Ditto naming...
            var table = dataset.CreateTable(AddressbookTableId, new TableSchemaBuilder
                {
                    { "name", new TableSchemaBuilder
                        {
                            { "first", BigqueryDbType.String },
                            { "last", BigqueryDbType.String }
                        }
                    },
                    { "address", new TableSchemaBuilder
                        {
                            { "number", BigqueryDbType.Integer },
                            { "street", BigqueryDbType.String },
                            { "city", BigqueryDbType.String },
                        }
                    },
                    { "lastModified", BigqueryDbType.Timestamp }
                }.Build());
            // TODO: Add data. InsertRow doesn't currently handle nested objects.
        }

        public void Dispose()
        {
            // TODO: Consider deleting the dataset here. It
            // might be nice to clean up after ourselves, but realistically
            // we won't be creating much data, and it's useful to be able to see
            // it after tests have finished, particularly on failure.
        }
    }
}
