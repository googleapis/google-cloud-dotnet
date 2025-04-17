// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Api.Gax.Grpc;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using Google.Cloud.Firestore.Admin.V1;
using Google.Cloud.Firestore.IntegrationTests.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Admin.V1.Database.Types;
using static Google.Cloud.Firestore.Admin.V1.Index.Types;
using static Google.Cloud.Firestore.Admin.V1.Index.Types.IndexField.Types;
using Index = Google.Cloud.Firestore.Admin.V1.Index;

namespace Google.Cloud.Firestore.IntegrationTests
{
    [CollectionDefinition(nameof(FirestoreFixture))]
    public class FirestoreFixture : CloudProjectFixtureBase, ICollectionFixture<FirestoreFixture>
    {
        // Creating databases and indexes can take a while.
        // We don't want to wait *forever* (which would be the behavior of default poll settings)
        // but we need to have a timeout of more than a minute.
        private static readonly PollSettings AdminOperationPollSettings =
            new PollSettings(expiration: Expiration.FromTimeout(TimeSpan.FromMinutes(5)), delay: TimeSpan.FromSeconds(5));

        // How long we should wait after creating an index, before returning to the caller
        // (who is expecting to be able to use the index immediately). Sometimes the CreateIndex operation
        // returns before the index is *really* ready. A short delay fixes this.
        private static readonly TimeSpan PostIndexCreationDelay = TimeSpan.FromSeconds(20);

        private const string DatabaseLocation = "us-east1";

        public FirestoreDb FirestoreDb { get; }

        /// <summary>
        /// A randomly generated prefix for collections.
        /// </summary>
        public string CollectionPrefix { get; }

        /// <summary>
        /// A collection with <see cref="HighScore"/> data in. Don't modify in tests!
        /// </summary>
        public CollectionReference HighScoreCollection { get; }

        /// <summary>
        /// A collection with <see cref="Student"/> data in. Don't modify in tests!
        /// </summary>
        public CollectionReference StudentCollection { get; }

        /// <summary>
        /// A collection with <see cref="ArrayDocument"/> data in. Don't modify in tests!
        /// </summary>
        public CollectionReference ArrayQueryCollection { get; }

        /// <summary>
        /// A collection intended for tests to create and fetch documents in. Don't query in tests!
        /// </summary>
        public CollectionReference NonQueryCollection { get; }

        /// <summary>
        /// A collection to use in collection group tests. Each test is expected to
        /// use a separate document within this collection as a "root" for its tests.
        /// </summary>
        public CollectionReference CollectionGroupQueryCollection { get; }

        public string DatabaseId => FirestoreDb.DatabaseId;
        internal bool RunningOnEmulator { get; }

        private FirestoreAdminClient AdminClient { get; }

        private int _uniqueCollectionCounter = 0;

        public FirestoreFixture() : base()
        {
            RunningOnEmulator = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("FIRESTORE_EMULATOR_HOST"));
            AdminClient = FirestoreAdminClient.Create();

            // On the emulator, we can't easily create a new database - so we just use the default.
            // We expect each test run time be in a separate emulator session.
            string databaseId = RunningOnEmulator ? null : IdGenerator.FromDateTime(prefix: "test-");
            if (!RunningOnEmulator)
            {
                Task.Run(() => CreateDatabaseAsync(databaseId)).Wait();
            }
            FirestoreDb = new FirestoreDbBuilder
            {
                ProjectId = ProjectId,
                DatabaseId = databaseId,
                EmulatorDetection = EmulatorDetection.EmulatorOrProduction
            }.Build();
            CollectionPrefix = RunningOnEmulator ? IdGenerator.FromGuid(prefix: "test-", suffix: "-") : "";
            NonQueryCollection = FirestoreDb.Collection(CollectionPrefix + "non-query");
            HighScoreCollection = FirestoreDb.Collection(CollectionPrefix + "high-scores");
            StudentCollection = FirestoreDb.Collection(CollectionPrefix + "students");
            ArrayQueryCollection = FirestoreDb.Collection(CollectionPrefix + "array-query");
            CollectionGroupQueryCollection = FirestoreDb.Collection(CollectionPrefix + "collection-groups");
            Task.Run(PopulateCollections).Wait();
        }

        private async Task PopulateCollections()
        {
            // Note: we create the first index separately, to make sure the database is
            // fully initialized for writing. After that point, we can parallelize the remaining
            // index creation.
            await CreateIndexAsync(StudentCollection, AscendingField("EnglishScore"), AscendingField("Level"), AscendingField("MathScore"), AscendingField("Name"));
            var indexTasks = new[]
            {
                CreateIndexAsync(HighScoreCollection, AscendingField("Score"), AscendingField("Level")),
                CreateIndexAsync(HighScoreCollection, AscendingField("Score"), DescendingField("Level")),
            };
            await Task.WhenAll(indexTasks);

            await PopulateCollection(HighScoreCollection, HighScore.Data);
            await PopulateCollection(ArrayQueryCollection, ArrayDocument.Data);
            await PopulateCollection(StudentCollection, Student.Data);
        }

        internal async Task CreateIndexAsync(CollectionReference collection, params IndexField[] fields)
        {
            // Tests which require an index should be skipped, as the emulator doesn't support the
            // admin API.
            if (RunningOnEmulator)
            {
                return;
            }
            var index = new Index
            {
                Fields = { fields },
                QueryScope = QueryScope.Collection
            };
            var job = await AdminClient.CreateIndexAsync(new CollectionGroupName(ProjectId, DatabaseId, collection.Id), index);
            await job.PollUntilCompletedAsync(AdminOperationPollSettings);
            await Task.Delay(PostIndexCreationDelay);
        }

        private async Task PopulateCollection(CollectionReference collection, IEnumerable<object> documents)
        {
            var batch = FirestoreDb.StartBatch();
            foreach (var doc in documents)
            {
                batch.Create(collection.Document(), doc);
            }
            await batch.CommitAsync();
        }

        /// <summary>
        /// Creates a collection reference that will not have been used by other tests (except maliciously).
        /// No documents are added to the collection, so it doesn't exist on the server.
        /// </summary>
        public CollectionReference CreateUniqueCollection()
        {
            int counter = Interlocked.Increment(ref _uniqueCollectionCounter);
            return FirestoreDb.Collection($"{CollectionPrefix}unique-{counter}");
        }

        // Convenience methods for creating fields for indexes.
        internal IndexField AscendingField(string name) => new IndexField { FieldPath = name, Order = Order.Ascending };
        internal IndexField DescendingField(string name) => new IndexField { FieldPath = name, Order = Order.Descending };

        /// <summary>
        /// Creates a new Firestore database.
        /// </summary>
        public async Task CreateDatabaseAsync(string databaseId)
        {
            // Tests which require different databases should be skipped; this is protection against forgetting that.
            Assert.False(RunningOnEmulator);
            var client = FirestoreAdminClient.Create();
            var operation = await client.CreateDatabaseAsync(
                new ProjectName(ProjectId),
                new Database { LocationId = DatabaseLocation, Type = DatabaseType.FirestoreNative },
                databaseId);
            await operation.PollUntilCompletedAsync(AdminOperationPollSettings, CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromMinutes(5))));
        }

        // No clean-up here: CleanTestData deletes test collections, indexes and databases.
    }
}
