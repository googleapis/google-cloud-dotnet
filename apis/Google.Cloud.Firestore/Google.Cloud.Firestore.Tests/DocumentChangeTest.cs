// Copyright 2018, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.ClientTesting;
using Xunit;
using static Google.Cloud.Firestore.Tests.DocumentSnapshotHelpers;

namespace Google.Cloud.Firestore.Tests
{
    public class DocumentChangeTest
    {
        private static readonly FirestoreDb s_db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());

        [Fact]
        public void Equality()
        {
            var snapshot = GetSampleSnapshot(s_db, "doc1");

            var control = new DocumentChange(snapshot, DocumentChange.Type.Modified, 3, 2);
            EqualityTester.AssertEqual(control,
                // Distinct but equal document snapshots
                equal: new[] { new DocumentChange(GetSampleSnapshot(s_db, "doc1"), DocumentChange.Type.Modified, 3, 2) },
                unequal: new[] {
                    // Different document
                    new DocumentChange(GetSampleSnapshot(s_db, "doc2"), DocumentChange.Type.Modified, 3, 2),
                    // These indexes don't actually make sense for added, but it's simplest to change things independently
                    new DocumentChange(snapshot, DocumentChange.Type.Added, 3, 2),
                    new DocumentChange(snapshot, DocumentChange.Type.Modified, 4, 2),
                    new DocumentChange(snapshot, DocumentChange.Type.Modified, 3, 1),
                    new DocumentChange(snapshot, DocumentChange.Type.Modified, null, 2),
                    new DocumentChange(snapshot, DocumentChange.Type.Modified, 3, null),
                });

            // Null matching checks
            EqualityTester.AssertEqual(new DocumentChange(snapshot, DocumentChange.Type.Added, null, 2),
                equal: new[] { new DocumentChange(snapshot, DocumentChange.Type.Added, null, 2) },
                unequal: new[] { new DocumentChange(snapshot, DocumentChange.Type.Added, 0, 2) });
            EqualityTester.AssertEqual(new DocumentChange(snapshot, DocumentChange.Type.Removed, 1, null),
                equal: new[] { new DocumentChange(snapshot, DocumentChange.Type.Removed, 1, null) },
                unequal: new[] { new DocumentChange(snapshot, DocumentChange.Type.Removed, 1, 1) });
        }
    }
}
