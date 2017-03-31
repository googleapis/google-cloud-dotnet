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

using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Snippets
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// All entities use the same partition, which is then wiped at the end of the run.
    /// </summary>
    [CollectionDefinition(nameof(BigQuerySnippetFixture))]
    public sealed class BigQuerySnippetFixture : IDisposable, ICollectionFixture<BigQuerySnippetFixture>
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";
        private const string DatasetPrefix = "snippets_";

        public string ProjectId { get; }
        public string GameDatasetId { get; }
        public BigQueryClient Client { get; }
        // This table should not have inserts made during the test,
        // as it's used as the source for copy operations.
        public string HistoryTableId => "game_history";
        // This table has the same original data as HistoryTableId, but
        // is not used for copying, so is suitable for inserts.
        public string HistoryTableWithInsertsId => "game_history_for_inserts";
        public string LevelsTableId => "levels";
        /// <summary>
        /// A GCS bucket created for this fixture.
        /// </summary>
        public string StorageBucketName { get; }

        private readonly List<string> _datasetsToDelete = new List<string>();

        public BigQuerySnippetFixture()
        {
            ProjectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }
            Client = BigQueryClient.Create(ProjectId);
            GameDatasetId = CreateGameDataset();
            StorageBucketName = GenerateStorageBucketName();
            StorageClient.Create().CreateBucket(ProjectId, StorageBucketName);
        }

        private string CreateGameDataset()
        {
            string id = CreateDataset();
            BigQueryDataset game = Client.GetDataset(id);
            var historySchema = new TableSchemaBuilder
            {
                { "player", BigQueryDbType.String },
                { "score", BigQueryDbType.Int64 },
                { "level", BigQueryDbType.Int64 },
                { "game_started", BigQueryDbType.Timestamp }
            }.Build();
            var historyTable = game.CreateTable(HistoryTableId, historySchema);
            var historyTableWithInserts = game.CreateTable(HistoryTableWithInsertsId, historySchema);

            string[] csvRows =
            {
                CreateHistoryRow("Tim", 503, 1, "2015-05-03T23:01:05"),
                CreateHistoryRow("Nadia", 450, 1, "2013-05-06T10:05:07"),
                CreateHistoryRow("Nadia", 1320, 2, "2013-06-01T15:02:07"),
                CreateHistoryRow("Ben", 300, 1, "2014-01-30T12:53:35"),
                CreateHistoryRow("Tim", 5310, 3, "2014-06-28T10:32:15"),
                CreateHistoryRow("Tim", 2000, 2, "2014-07-01T08:12:25"),
                CreateHistoryRow("Nadia", 8310, 5, "2015-03-20T14:55:10")
            };
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(string.Join("\n", csvRows)));
            historyTable.UploadCsv(stream).PollUntilCompleted().ThrowOnAnyError();
            stream.Position = 0;
            historyTableWithInserts.UploadCsv(stream).PollUntilCompleted().ThrowOnAnyError();
            return id;
        }

        // We use CSV to prepopulate the table so that it's ready for extract operations etc.
        private string CreateHistoryRow(string player, int score, int level, string gameStartedIso) =>
            $"{player},{score},{level},{gameStartedIso}";

        internal string GenerateDatasetId() => DatasetPrefix + Guid.NewGuid().ToString().Replace('-', '_');

        internal string GenerateTableId() => Guid.NewGuid().ToString().Replace("-", "_");

        private string GenerateStorageBucketName() => "bigquerysnippets-" + Guid.NewGuid().ToString().ToLowerInvariant();
        internal string GenerateStorageObjectName() => "file-" + Guid.NewGuid().ToString();

        internal void RegisterDatasetToDelete(string id)
        {
            _datasetsToDelete.Add(id);
        }

        public string CreateDataset()
        {
            string id = GenerateDatasetId();
            Client.CreateDataset(id);
            RegisterDatasetToDelete(id);
            return id;
        }

        public void Dispose()
        {
            // TODO: Work out a way of actually deleting the datasets. If we try to delete them here,
            // we get an error due to them still being in use.
            // For the moment, run the tools/Google.Cloud.BigQuery.V2.CleanTestData program
            // periodically.
        }
    }
}
