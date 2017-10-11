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
using Google.Protobuf;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore.Data
{
    /// <summary>
    /// A reference to a document in a Firestore database. The existence of
    /// this object does not imply that the document currently exists in storage.
    /// </summary>
    public sealed class DocumentReference : IEquatable<DocumentReference>
    {
        /// <summary>
        /// The database which contains the document.
        /// </summary>
        public FirestoreDb Database { get; }

        /// <summary>
        /// The final part of the complete document path; this is the identity of
        /// the document relative to its parent collection.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// The complete document path, including project and database ID.
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// The parent collection. Never null.
        /// </summary>
        public CollectionReference Parent { get; }

        internal DocumentReference(FirestoreDb database, CollectionReference parent, string id)
        {
            Database = GaxPreconditions.CheckNotNull(database, nameof(database));
            Parent = GaxPreconditions.CheckNotNull(parent, nameof(parent));
            Id = GaxPreconditions.CheckNotNull(id, nameof(id));
            Path = $"{parent.Path}/{id}";
        }

        /// <summary>
        /// Creates a <see cref="CollectionReference"/> for a direct child collection of this document.
        /// </summary>
        /// <param name="collectionId">The collection ID. This must not be null or contain a forward slash.</param>
        /// <returns>A <see cref="CollectionReference"/> for the specified collection.</returns>
        public CollectionReference Collection(string collectionId) =>
            new CollectionReference(Database, this, PathUtilities.ValidateId(collectionId, nameof(collectionId)));

        /// <inheritdoc />
        public override int GetHashCode() => Path.GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DocumentReference);

        /// <inheritdoc />
        public bool Equals(DocumentReference other) => other != null && other.Path == Path;

        /// <inheritdoc />
        public override string ToString() => Path;

        /// <summary>
        /// Asynchronously creates a document on the server with the given data. The document must not exist beforehand.
        /// </summary>
        /// <param name="documentData">The data for the document. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public async Task<WriteResult> CreateAsync(object documentData, CancellationToken cancellationToken = default)
        {
            var batch = Database.CreateWriteBatch();
            var results = await batch.Create(this, documentData).CommitAsync(cancellationToken).ConfigureAwait(false);
            return results.Single();
        }

        // TODO: Check naming. Other languages just have "get", but that feels a bit odd in .NET.
        // Options:
        // - Get
        // - GetSnapshot
        // - Snapshot
        // (All with an Async suffix, presumably.)

        /// <summary>
        /// Asynchronously fetches a snapshot of the document.
        /// </summary>
        /// <returns>A snapshot of the document. The snapshot may represent a missing document.</returns>
        public async Task<DocumentSnapshot> SnapshotAsync(CancellationToken cancellationToken = default)
        {
            var multiple = await Database.GetDocumentSnapshotsAsync(new[] { this }, null, cancellationToken).ConfigureAwait(false);
            return multiple.Single();
        }
    }
}
