// Copyright 2019, Google LLC
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

using Google.Cloud.Firestore.V1;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    /// <summary>
    /// Helpers to create sample document snapshots easily.
    /// </summary>
    internal static class DocumentSnapshotHelpers
    {
        internal static DocumentSnapshot GetSampleSnapshot(FirestoreDb db, string docId)
        {
            var readTime = new Timestamp(10, 2);
            var proto = new Document
            {
                CreateTime = CreateProtoTimestamp(1, 10),
                UpdateTime = CreateProtoTimestamp(2, 20),
                Name = db.Document($"col1/{docId}").Path,
                Fields = { ValueSerializer.SerializeMap(db.SerializationContext, new { Name = docId }) }
            };
            return DocumentSnapshot.ForDocument(db, proto, readTime);
        }
    }
}
