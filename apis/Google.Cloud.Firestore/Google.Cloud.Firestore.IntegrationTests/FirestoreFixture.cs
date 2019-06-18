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

using Google.Cloud.ClientTesting;
using Google.Cloud.Firestore.IntegrationTests.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.IntegrationTests
{
    [CollectionDefinition(nameof(FirestoreFixture))]
    public class FirestoreFixture : CloudProjectFixtureBase, ICollectionFixture<FirestoreFixture>
    {
        // This is not the test project environment variable used by other integration tests,
        // as Datastore and Firestore can't both be active in the same project.
        private const string ProjectEnvironmentVariable = "FIRESTORE_TEST_PROJECT";
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
        /// A collection with <see cref="ArrayDocument"/> data in. Don't modify in tests!
        /// </summary>
        public CollectionReference ArrayQueryCollection { get; }

        /// <summary>
        /// The name of a collection which appears under two different documents.
        /// </summary>
        public string CollectionGroupName { get; }

        /// <summary>
        /// The collection containing the documents with <see cref="CollectionGroupName"/> child collections.
        /// </summary>
        public CollectionReference CollectionGroupParentCollection { get; }

        /// <summary>
        /// A collection intended for tests to create and fetch documents in. Don't query in tests!
        /// </summary>
        public CollectionReference NonQueryCollection { get; }

        private int _uniqueCollectionCounter = 0;

        public FirestoreFixture() : base(ProjectEnvironmentVariable)
        {
            // Currently, only the default database is supported... so we create all our collections with a randomly-generated prefix.
            // When multiple databases are supported, we'll create a new one per test run.
            CollectionPrefix = IdGenerator.FromGuid(prefix: "test-");
            FirestoreDb = FirestoreDb.Create(ProjectId);
            NonQueryCollection = FirestoreDb.Collection(CollectionPrefix + "-non-query");
            HighScoreCollection = FirestoreDb.Collection(CollectionPrefix + "-high-scores");
            ArrayQueryCollection = FirestoreDb.Collection(CollectionPrefix + "-array-query");
            CollectionGroupParentCollection = FirestoreDb.Collection(CollectionPrefix + "-collection-group-parent");
            CollectionGroupName = IdGenerator.FromGuid(prefix: "test-");
            Task.Run(PopulateCollections).Wait();
        }

        private async Task PopulateCollections()
        {
            await PopulateCollection(HighScoreCollection, HighScore.Data);
            await PopulateCollection(ArrayQueryCollection, ArrayDocument.Data);
            await PopulateCollectionGroups();
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

        private async Task PopulateCollectionGroups()
        {
            var batch = FirestoreDb.StartBatch();
            var parentDoc1 = CollectionGroupParentCollection.Document();
            var parentDoc2 = CollectionGroupParentCollection.Document();

            batch.Create(parentDoc1, NamedDocument.Parent1);
            batch.Create(parentDoc2, NamedDocument.Parent2);

            var childDoc1 = parentDoc1.Collection(CollectionGroupName).Document();
            var childDoc2 = parentDoc1.Collection(CollectionGroupName).Document();

            batch.Create(childDoc1, NamedDocument.Child1);
            batch.Create(childDoc2, NamedDocument.Child2);
            await batch.CommitAsync();
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

        // No clean-up for now. With multiple-database support, we'll create a database
        // on construction and delete it here.
    }
}
