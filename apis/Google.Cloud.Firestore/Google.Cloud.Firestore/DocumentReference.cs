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
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// A reference to a document in a Firestore database. The existence of
    /// this object does not imply that the document currently exists in storage.
    /// </summary>
    public sealed class DocumentReference : IEquatable<DocumentReference>, IComparable<DocumentReference>
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
        /// Creates a <see cref="CollectionReference"/> for a child collection of this document.
        /// </summary>
        /// <param name="path">The path to the collection, relative to this document. Must not be null, and must contain
        /// an odd number of slash-separated path elements.</param>
        /// <returns>A <see cref="CollectionReference"/> for the specified collection.</returns>
        public CollectionReference Collection(string path)
        {
            string[] elements = PathUtilities.SplitPath(path);
            GaxPreconditions.CheckArgument((elements.Length & 1) == 1, nameof(path), "Path must have an odd number of elements");
            CollectionReference collectionRef = new CollectionReference(Database, this, elements[0]);
            for (int i = 1; i < elements.Length; i += 2)
            {
                var documentRef = new DocumentReference(Database, collectionRef, elements[i]);
                collectionRef = new CollectionReference(Database, documentRef, elements[i + 1]);
            }
            return collectionRef;
        }

        /// <inheritdoc />
        public override int GetHashCode() => Path.GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DocumentReference);

        /// <inheritdoc />
        public bool Equals(DocumentReference other) => other != null && other.Path == Path;

        /// <inheritdoc />
        public override string ToString() => Path;

        // Note: this implementation wastefully compares the characters in "projects" and "databases" but means we don't need
        // to keep a database-relative path or perform more complex comparisons.
        /// <inheritdoc />
        public int CompareTo(DocumentReference other) => other == null ? 1 : PathComparer.Instance.Compare(Path, other.Path);
        
        /// <summary>
        /// Asynchronously creates a document on the server with the given data. The document must not exist beforehand.
        /// </summary>
        /// <param name="documentData">The data for the document. Must not be null.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> CreateAsync(object documentData) => CreateAsync(documentData, default);

        /// <summary>
        /// Asynchronously creates a document on the server with the given data. The document must not exist beforehand.
        /// </summary>
        /// <param name="documentData">The data for the document. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public async Task<WriteResult> CreateAsync(object documentData, CancellationToken cancellationToken)
        {
            var batch = Database.StartBatch();
            var results = await batch.Create(this, documentData).CommitAsync(cancellationToken).ConfigureAwait(false);
            return results.Single();
        }

        /// <summary>
        /// Asynchronously deletes the document referred to by this path.
        /// </summary>
        /// <remarks>
        /// If the document doesn't exist, this returned task will still succeed.
        /// </remarks>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> DeleteAsync() => DeleteAsync(Precondition.None, default);

        /// <summary>
        /// Asynchronously deletes the document referred to by this path, with a cancellation token.
        /// </summary>
        /// <remarks>
        /// If the document doesn't exist, this returned task will still succeed.
        /// </remarks>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> DeleteAsync(CancellationToken cancellationToken) => DeleteAsync(Precondition.None, cancellationToken);

        /// <summary>
        /// Asynchronously deletes the document referred to by this path, with a precondition.
        /// </summary>
        /// <remarks>
        /// If no precondition is specified and the document doesn't exist, this returned task will succeed. If a precondition
        /// is specified and not met, the returned task will fail with an <see cref="RpcException"/>.
        /// </remarks>
        /// <param name="precondition">Precondition for deletion. Must not be null.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> DeleteAsync(Precondition precondition) => DeleteAsync(precondition, default);

        /// <summary>
        /// Asynchronously deletes the document referred to by this path, with a precondition.
        /// </summary>
        /// <remarks>
        /// If <see cref="Precondition.None">Precondition.None</see> is specified and the document doesn't exist, this returned task
        /// will succeed. If any other precondition is specified and not met, the returned task will fail with an <see cref="RpcException"/>.
        /// </remarks>
        /// <param name="precondition">Precondition for deletion. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public async Task<WriteResult> DeleteAsync(Precondition precondition, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(precondition, nameof(precondition));
            var batch = Database.StartBatch();
            batch.Delete(this, precondition);
            var results = await batch.CommitAsync(cancellationToken).ConfigureAwait(false);
            return results[0];
        }

        /// <summary>
        /// Asynchronously performs a set of updates on the document referred to by this path. A precondition of <see cref="Precondition.MustExist" /> is applied.
        /// </summary>
        /// <param name="updates">The updates to perform on the document, keyed by the dot-separated field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> UpdateAsync(IDictionary<string, object> updates) => UpdateAsync(updates, Precondition.MustExist, default);

        /// <summary>
        /// Asynchronously performs a set of updates on the document referred to by this path. A precondition of <see cref="Precondition.MustExist" /> is applied.
        /// </summary>
        /// <param name="updates">The updates to perform on the document, keyed by the dot-separated field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> UpdateAsync(IDictionary<string, object> updates, CancellationToken cancellationToken) => UpdateAsync(updates, Precondition.MustExist, cancellationToken);

        /// <summary>
        /// Asynchronously performs a set of updates on the document referred to by this path, with a precondition.
        /// </summary>
        /// <param name="updates">The updates to perform on the document, keyed by the dot-separated field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <param name="precondition">Precondition for updating the document. Must not be null.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> UpdateAsync(IDictionary<string, object> updates, Precondition precondition) => UpdateAsync(updates, precondition, default);

        /// <summary>
        /// Asynchronously performs a set of updates on the document referred to by this path, with a precondition.
        /// </summary>
        /// <param name="updates">The updates to perform on the document, keyed by the dot-separated field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <param name="precondition">Precondition for updating the document. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> UpdateAsync(IDictionary<string, object> updates, Precondition precondition, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(updates, nameof(updates));
            GaxPreconditions.CheckNotNull(precondition, nameof(precondition));
            return UpdateAsync(updates.ToDictionary(pair => FieldPath.FromDotSeparatedString(pair.Key), pair => pair.Value), precondition, cancellationToken);
        }

        /// <summary>
        /// Asynchronously performs a single field update on the document referred to by this path. A precondition of <see cref="Precondition.MustExist" /> is applied.
        /// </summary>
        /// <param name="field">The dot-separated name of the field to update. Must not be null.</param>
        /// <param name="value">The new value for the field. May be null.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> UpdateAsync(string field, object value) => UpdateAsync(field, value, Precondition.MustExist, default);

        /// <summary>
        /// Asynchronously performs a single field update on the document referred to by this path. A precondition of <see cref="Precondition.MustExist" /> is applied.
        /// </summary>
        /// <param name="field">The dot-separated name of the field to update. Must not be null.</param>
        /// <param name="value">The new value for the field. May be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> UpdateAsync(string field, object value, CancellationToken cancellationToken) => UpdateAsync(field, value, Precondition.MustExist, cancellationToken);

        /// <summary>
        /// Asynchronously performs a single field update on the document referred to by this path, with a precondition.
        /// </summary>
        /// <param name="field">The dot-separated name of the field to update. Must not be null.</param>
        /// <param name="value">The new value for the field. May be null.</param>
        /// <param name="precondition">Optional precondition for updating the document. Must not be null.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> UpdateAsync(string field, object value, Precondition precondition) => UpdateAsync(field, value, precondition, default);

        /// <summary>
        /// Asynchronously performs a single field update on the document referred to by this path, with a precondition.
        /// </summary>
        /// <param name="field">The dot-separated name of the field to update. Must not be null.</param>
        /// <param name="value">The new value for the field. May be null.</param>
        /// <param name="precondition">Optional precondition for updating the document. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> UpdateAsync(string field, object value, Precondition precondition, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(field, nameof(field));
            return UpdateAsync(new Dictionary<string, object> { { field, value } }, precondition, cancellationToken);
        }

        /// <summary>
        /// Asynchronously performs a set of updates on the document referred to by this path. A precondition of <see cref="Precondition.MustExist" /> is applied.
        /// </summary>
        /// <param name="updates">The updates to perform on the document, keyed by the field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> UpdateAsync(IDictionary<FieldPath, object> updates) => UpdateAsync(updates, Precondition.MustExist, default);

        /// <summary>
        /// Asynchronously performs a set of updates on the document referred to by this path. A precondition of <see cref="Precondition.MustExist" /> is applied.
        /// </summary>
        /// <param name="updates">The updates to perform on the document, keyed by the field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> UpdateAsync(IDictionary<FieldPath, object> updates, CancellationToken cancellationToken) => UpdateAsync(updates, Precondition.MustExist, cancellationToken);

        /// <summary>
        /// Asynchronously performs a set of updates on the document referred to by this path, with a precondition.
        /// </summary>
        /// <param name="updates">The updates to perform on the document, keyed by the field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <param name="precondition">Optional precondition for updating the document. Must not be null.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> UpdateAsync(IDictionary<FieldPath, object> updates, Precondition precondition) => UpdateAsync(updates, precondition, default);

        /// <summary>
        /// Asynchronously performs a set of updates on the document referred to by this path, with a precondition.
        /// </summary>
        /// <param name="updates">The updates to perform on the document, keyed by the field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <param name="precondition">Optional precondition for updating the document. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public async Task<WriteResult> UpdateAsync(IDictionary<FieldPath, object> updates, Precondition precondition, CancellationToken cancellationToken)
        {
            var batch = Database.StartBatch();
            batch.Update(this, updates, precondition);
            var results = await batch.CommitAsync(cancellationToken).ConfigureAwait(false);
            return results[0];
        }

        /// <summary>
        /// Asynchronously sets data in the document, replacing it completely.
        /// </summary>
        /// <param name="documentData">The data to store in the document. Must not be null.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> SetAsync(object documentData) => SetAsync(documentData, SetOptions.Overwrite, default);

        /// <summary>
        /// Asynchronously sets data in the document, replacing it completely.
        /// </summary>
        /// <param name="documentData">The data to store in the document. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> SetAsync(object documentData, CancellationToken cancellationToken) => SetAsync(documentData, SetOptions.Overwrite, cancellationToken);

        /// <summary>
        /// Asynchronously sets data in the document, either replacing it completely or merging fields.
        /// </summary>
        /// <param name="documentData">The data to store in the document. Must not be null.</param>
        /// <param name="options">The options to use when updating the document. Must not be null.</param>
        /// <returns>The write result of the server operation.</returns>
        public Task<WriteResult> SetAsync(object documentData, SetOptions options) => SetAsync(documentData, options, default);

        /// <summary>
        /// Asynchronously sets data in the document, either replacing it completely or merging fields.
        /// </summary>
        /// <param name="documentData">The data to store in the document. Must not be null.</param>
        /// <param name="options">The options to use when updating the document. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The write result of the server operation.</returns>
        public async Task<WriteResult> SetAsync(object documentData, SetOptions options, CancellationToken cancellationToken)
        {
            var batch = Database.StartBatch();
            batch.Set(this, documentData, options);
            var results = await batch.CommitAsync(cancellationToken).ConfigureAwait(false);
            return results[0];
        }

        /// <summary>
        /// Asynchronously fetches a snapshot of the document.
        /// </summary>
        /// <returns>A snapshot of the document. The snapshot may represent a missing document.</returns>
        public Task<DocumentSnapshot> GetSnapshotAsync() => GetSnapshotAsync(default);

        /// <summary>
        /// Asynchronously fetches a snapshot of the document.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>A snapshot of the document. The snapshot may represent a missing document.</returns>
        public Task<DocumentSnapshot> GetSnapshotAsync(CancellationToken cancellationToken) =>
            GetSnapshotAsync(null, cancellationToken);

        /// <summary>
        /// Asynchronously fetches a snapshot of the document.
        /// </summary>
        /// <returns>A snapshot of the document. The snapshot may represent a missing document.</returns>
        internal async Task<DocumentSnapshot> GetSnapshotAsync(ByteString transactionId, CancellationToken cancellationToken)
        {
            var multiple = await Database.GetDocumentSnapshotsAsync(new[] { this }, transactionId, cancellationToken).ConfigureAwait(false);
            return multiple.Single();
        }

        // TODO: Consider adding GetCollectionsAsync which returns a Task<IList<CollectionReference>>,
        // basically just calling ListCollectionsAsync().ToList(cancellationToken).
        // That would be more convenient for users who don't know about async enumerables.

        /// <summary>
        /// Retrieves the collections within this document.
        /// </summary>
        /// <returns>A lazily-iterated sequence of collection references within this document.</returns>
        public IAsyncEnumerable<CollectionReference> ListCollectionsAsync() => Database.ListCollectionsAsync(this);
    }
}
