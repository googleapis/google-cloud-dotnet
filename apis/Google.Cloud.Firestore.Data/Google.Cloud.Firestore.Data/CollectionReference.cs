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
using Google.Cloud.Firestore.V1Beta1;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore.Data
{
    /// <summary>
    /// A reference to a collection in a Firestore database. The existence of
    /// this object does not imply that the collection currently exists in storage.
    /// </summary>
    public sealed class CollectionReference : Query, IEquatable<CollectionReference>
    {
        /// <summary>
        /// The final part of the complete collection path; this is the identity of
        /// the collection relative to its parent document.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// The complete collection path, including project and database ID.
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// The parent document, or null if this is a root collection.
        /// </summary>
        public DocumentReference Parent { get; }

        internal CollectionReference(FirestoreDb database, DocumentReference parent, string id)
            : base(GaxPreconditions.CheckNotNull(database, nameof(database)), CreateStructuredQuery(id), parent?.Path ?? database.DocumentsPath)
        {
            Parent = parent; // May be null
            Id = id;
            Path = $"{ParentPath}/{Id}";
        }

        private static StructuredQuery CreateStructuredQuery(string id)
        {
            GaxPreconditions.CheckNotNull(id, nameof(id));
            return new StructuredQuery { From = { new StructuredQuery.Types.CollectionSelector { CollectionId = id } } };
        }

        /// <summary>
        /// Creates a <see cref="DocumentReference"/> for a direct child document of this reference.
        /// If <paramref name="documentId"/> is null, a random ID will be generated. This operation
        /// does not check that the generated ID does not represent an existing document.
        /// </summary>
        /// <param name="documentId">The document ID. This must not contain a forward slash.</param>
        /// <returns>A <see cref="CollectionReference"/> for the specified collection.</returns>
        public DocumentReference Document(string documentId) =>
            new DocumentReference(Database, this,
                documentId == null ? PathUtilities.GenerateId() : PathUtilities.ValidateId(documentId, nameof(documentId)));

        /// <summary>
        /// Asynchronously creates a document with the given data in this collection. The document has a randomly generated ID.
        /// </summary>
        /// <remarks>
        /// If the <see cref="WriteResult"/> for the operation is required, use <see cref="DocumentReference.CreateAsync(object, CancellationToken)"/>
        /// instead of this method.
        /// </remarks>
        /// <param name="documentData">The data for the document. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The reference for the newly-created document.</returns>
        public async Task<DocumentReference> AddAsync(object documentData, CancellationToken cancellationToken = default)
        {
            var docRef = Document(null);
            var result = await docRef.CreateAsync(documentData, cancellationToken).ConfigureAwait(false);
            return docRef;
        }

        /// <inheritdoc />
        public override int GetHashCode() => Path.GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CollectionReference);

        /// <inheritdoc />
        public bool Equals(CollectionReference other) => other != null && other.Path == Path;

        /// <inheritdoc />
        public override string ToString() => Path;
    }
}
