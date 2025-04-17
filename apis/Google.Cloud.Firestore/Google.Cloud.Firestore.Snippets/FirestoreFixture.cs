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

using Google.Api.Gax.Grpc;
using Google.Api.Gax.ResourceNames;
using Google.Api.Gax;
using Google.Cloud.ClientTesting;
using Google.Cloud.Firestore.Admin.V1;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Admin.V1.Database.Types;

namespace Google.Cloud.Firestore.Snippets
{
    [CollectionDefinition(nameof(FirestoreFixture))]
    public class FirestoreFixture : CloudProjectFixtureBase, ICollectionFixture<FirestoreFixture>
    {
        // Creating databases and indexes can take a while.
        // We don't want to wait *forever* (which would be the behavior of default poll settings)
        // but we need to have a timeout of more than a minute.
        private static readonly PollSettings AdminOperationPollSettings =
            new PollSettings(expiration: Expiration.FromTimeout(TimeSpan.FromMinutes(5)), delay: TimeSpan.FromSeconds(5));

        public FirestoreDb FirestoreDb { get; }

        private const string DatabaseLocation = "us-east1";

        /// <summary>
        /// A randomly generated prefix for collections.
        /// (This isn't strictly necessary as we now use a new database each time, but it doesn't hurt,
        /// and we could allow an existing database to be specified for debugging purposes.)
        /// </summary>
        public string CollectionPrefix { get; }

        /// <summary>
        /// The database ID to use.
        /// </summary>
        public string DatabaseId { get; }

        /// <summary>
        /// A collection with <see cref="HighScore"/> data in. Don't modify in tests!
        /// </summary>
        public CollectionReference HighScoreCollection { get; }

        /// <summary>
        /// A collection intended for tests to create and fetch documents in. Don't query in tests!
        /// </summary>
        public CollectionReference NonQueryCollection { get; }

        private int _uniqueCollectionCounter = 0;

        public bool RunningOnEmulator { get; }

        public FirestoreFixture() : base()
        {
            RunningOnEmulator = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("FIRESTORE_EMULATOR_HOST"));
            DatabaseId = RunningOnEmulator ? null : IdGenerator.FromDateTime(prefix: "test-");
            Task.Run(() => CreateDatabaseAsync(DatabaseId)).Wait();
            CollectionPrefix = IdGenerator.FromGuid(prefix: "test-");
            FirestoreDb = new FirestoreDbBuilder { ProjectId = ProjectId, DatabaseId = DatabaseId }.Build();
            NonQueryCollection = FirestoreDb.Collection(CollectionPrefix + "-non-query");
            HighScoreCollection = FirestoreDb.Collection(CollectionPrefix + "-high-scores");
        }

        /// <summary>
        /// Creates a collection reference that will not have been used by other tests (except maliciously).
        /// No documents are added to the collection, so it doesn't exist on the server.
        /// </summary>
        public CollectionReference CreateUniqueCollection()
        {
            int counter = Interlocked.Increment(ref _uniqueCollectionCounter);
            return FirestoreDb.Collection($"{CollectionPrefix}-unique-{counter}");
        }

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
