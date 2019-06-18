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
using System;
using System.Threading;
using Xunit;

namespace Google.Cloud.Firestore.Snippets
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
