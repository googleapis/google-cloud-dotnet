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
// limitations under the License.using System;


using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.V1.TransactionOptions.Types;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// A transaction, as created by
    /// <see cref="FirestoreDb.RunTransactionAsync{T}(System.Func{Transaction, Task{T}}, TransactionOptions, CancellationToken)"/>
    /// (and overloads) and passed to user code.
    /// </summary>
    public sealed class Transaction
    {
        /// <summary>
        /// The cancellation token for this transaction
        /// </summary>
        public CancellationToken CancellationToken { get; }

        /// <summary>
        /// The database for this transaction.
        /// </summary>
        public FirestoreDb Database { get; }

        private readonly WriteBatch _writes;

        internal ByteString TransactionId { get; }

        internal Transaction(FirestoreDb db, ByteString transactionId, CancellationToken overallCancellationToken)
        {
            Database = db;
            TransactionId = transactionId;
            CancellationToken = overallCancellationToken;
            _writes = new WriteBatch(db);
        }

        internal static async Task<Transaction> BeginAsync(FirestoreDb db, ByteString previousTransactionId, CancellationToken cancellationToken)
        {
            var request = new BeginTransactionRequest
            {
                Database = db.RootPath,
                Options = previousTransactionId == null ? null : new V1.TransactionOptions { ReadWrite = new ReadWrite { RetryTransaction = previousTransactionId } }
            };
            var response = await db.Client.BeginTransactionAsync(request, CallSettings.FromCancellationToken(cancellationToken)).ConfigureAwait(false);
            return new Transaction(db, response.Transaction, cancellationToken);
        }

        /// <summary>
        /// Fetch a snapshot of the document specified by <paramref name="documentReference"/>, with respect to this transaction.
        /// This method cannot be called after any write operations have been created.
        /// </summary>
        /// <param name="documentReference">The document reference to fetch. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>A snapshot of the given document with respect to this transaction.</returns>
        public Task<DocumentSnapshot> GetSnapshotAsync(DocumentReference documentReference, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(documentReference, nameof(documentReference));
            GaxPreconditions.CheckState(_writes.IsEmpty, "Firestore transactions require all reads to be executed before all writes.");
            using (var cts = CancellationTokenSource.CreateLinkedTokenSource(CancellationToken, cancellationToken))
            {
                return documentReference.GetSnapshotAsync(TransactionId, cts.Token);
            }
        }

        /// <summary>
        /// Fetch snapshots of all the documents specified by <paramref name="documentReferences"/>, with respect to this transaction.
        /// This method cannot be called after any write operations have been created.
        /// </summary>
        /// <remarks>
        /// Any documents which are missing are represented in the returned list by a <see cref="DocumentSnapshot"/>
        /// with <see cref="DocumentSnapshot.Exists"/> value of <c>false</c>.
        /// </remarks>
        /// <param name="documentReferences">The document references to fetch. Must not be null, or contain null references.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The document snapshots, in the same order as <paramref name="documentReferences"/>.</returns>
        public Task<IList<DocumentSnapshot>> GetAllSnapshotsAsync(IEnumerable<DocumentReference> documentReferences, CancellationToken cancellationToken = default) =>
            GetAllSnapshotsAsync(documentReferences, fieldMask: null, cancellationToken);

        /// <summary>
        /// Fetch snapshots of all the documents specified by <paramref name="documentReferences"/>, with respect to this transaction,
        /// potentially limiting the fields returned.
        /// This method cannot be called after any write operations have been created.
        /// </summary>
        /// <remarks>
        /// Any documents which are missing are represented in the returned list by a <see cref="DocumentSnapshot"/>
        /// with <see cref="DocumentSnapshot.Exists"/> value of <c>false</c>.
        /// </remarks>
        /// <param name="documentReferences">The document references to fetch. Must not be null, or contain null references.</param>
        /// <param name="fieldMask">The field mask to use to restrict which fields are retrieved. May be null, in which
        /// case no field mask is applied, and the complete documents are retrieved.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>The document snapshots, in the same order as <paramref name="documentReferences"/>.</returns>
        public Task<IList<DocumentSnapshot>> GetAllSnapshotsAsync(IEnumerable<DocumentReference> documentReferences, FieldMask fieldMask, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckState(_writes.IsEmpty, "Firestore transactions require all reads to be executed before all writes.");
            using (var cts = CancellationTokenSource.CreateLinkedTokenSource(CancellationToken, cancellationToken))
            {
                return Database.GetAllSnapshotsAsync(documentReferences, TransactionId, fieldMask, cts.Token);
            }
        }

        /// <summary>
        /// Performs a query and returned a snapshot of the the results, with respect to this transaction.
        /// This method cannot be called after any write operations have been created.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>A snapshot of results of the given query with respect to this transaction.</returns>
        public Task<QuerySnapshot> GetSnapshotAsync(Query query, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            GaxPreconditions.CheckState(_writes.IsEmpty, "Firestore transactions require all reads to be executed before all writes.");
            using (var cts = CancellationTokenSource.CreateLinkedTokenSource(CancellationToken, cancellationToken))
            {
                return query.GetSnapshotAsync(TransactionId, cts.Token);
            }
        }

        /// <summary>
        /// Fetch the <see cref="AggregateQuerySnapshot"/> from the specified <see cref="AggregateQuery"/>.
        /// </summary>
        /// <param name="query">The aggregate query to execute. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token to monitor for the asynchronous operation.</param>
        /// <returns>A <see cref="AggregateQuerySnapshot"/> of results of the given query with respect to this transaction.</returns>
        public Task<AggregateQuerySnapshot> GetSnapshotAsync(AggregateQuery query, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(query, nameof(query));
            GaxPreconditions.CheckState(_writes.IsEmpty, "Firestore transactions require all reads to be executed before all writes.");
            using var cts = CancellationTokenSource.CreateLinkedTokenSource(CancellationToken, cancellationToken);
            return query.GetSnapshotAsync(TransactionId, cts.Token);
        }

        /// <summary>
        /// Adds an operation to create a document in this transaction.
        /// </summary>
        /// <param name="documentReference">The document reference to create. Must not be null.</param>
        /// <param name="documentData">The data for the document. Must not be null.</param>
        public void Create(DocumentReference documentReference, object documentData)
        {
            // Preconditions are validated by WriteBatch.
            _writes.Create(documentReference, documentData);
        }

        /// <summary>
        /// Adds an operation to set a document's data in this transaction.
        /// </summary>
        /// <param name="documentReference">The document in which to set the data. Must not be null.</param>
        /// <param name="documentData">The data for the document. Must not be null.</param>
        /// <param name="options">The options to use when updating the document. May be null, which is equivalent to <see cref="SetOptions.Overwrite"/>.</param>
        public void Set(DocumentReference documentReference, object documentData, SetOptions options = null)
        {
            // Preconditions are validated by WriteBatch.
            _writes.Set(documentReference, documentData, options);
        }

        /// <summary>
        /// Adds an operation to update a document's data in this transaction.
        /// </summary>
        /// <param name="documentReference">A document reference indicating the path of the document to update. Must not be null.</param>
        /// <param name="updates">The updates to perform on the document, keyed by the dot-separated field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <param name="precondition">Optional precondition for updating the document. May be null, which is equivalent to <see cref="Precondition.MustExist"/>.</param>
        public void Update(DocumentReference documentReference, IDictionary<string, object> updates, Precondition precondition = null)
        {
            GaxPreconditions.CheckNotNull(updates, nameof(updates));
            Update(documentReference, updates.ToDictionary(pair => FieldPath.FromDotSeparatedString(pair.Key), pair => pair.Value), precondition);
        }

        /// <summary>
        /// Adds an operation to update a document's data in this transaction.
        /// </summary>
        /// <param name="documentReference">A document reference indicating the path of the document to update. Must not be null.</param>
        /// <param name="field">The dot-separated name of the field to update. Must not be null.</param>
        /// <param name="value">The new value for the field. May be null.</param>
        /// <param name="precondition">Optional precondition for updating the document. May be null, which is equivalent to <see cref="Precondition.MustExist"/>.</param>
        public void Update(DocumentReference documentReference, string field, object value, Precondition precondition = null)
        {
            GaxPreconditions.CheckNotNull(field, nameof(field));
            Update(documentReference, new Dictionary<string, object> { { field, value } }, precondition);
        }

        /// <summary>
        /// Adds an operation to update a document's data in this transaction.
        /// </summary>
        /// <param name="documentReference">The document to update. Must not be null.</param>
        /// <param name="updates">The updates to perform on the document, keyed by the field path to update. Fields not present in this dictionary are not updated. Must not be null or empty.</param>
        /// <param name="precondition">Optional precondition for updating the document. May be null, which is equivalent to <see cref="Precondition.MustExist"/>.</param>
        public void Update(DocumentReference documentReference, IDictionary<FieldPath, object> updates, Precondition precondition = null)
        {
            // Preconditions are validated by WriteBatch.
            _writes.Update(documentReference, updates, precondition);
        }

        /// <summary>
        /// Adds an operation to delete a document's data in this transaction.
        /// </summary>
        /// <param name="documentReference">The document to delete. Must not be null.</param>
        /// <param name="precondition">Optional precondition for deletion. May be null, in which case the deletion is unconditional.</param>
        public void Delete(DocumentReference documentReference, Precondition precondition = null)
        {
            // Preconditions are validated by WriteBatch.
            _writes.Delete(documentReference, precondition);
        }

        // TODO: The specification has some rules around retrying the commit operation. Rather than implement them
        // here, it would be good to hook into the GAX retry mechanism - we don't want to build too many layers of
        // retry (each with backoff) on top of each other.

        /// <summary>
        /// Asynchronously commits the transaction, using the same cancellation token as was used to begin the transaction.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        internal Task CommitAsync() => _writes.CommitAsync(TransactionId, CancellationToken);

        /// <summary>
        /// Asynchronously rolls back the transaction, using the same cancellation token as was used to begin the transaction.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        internal Task RollbackAsync() =>
            Database.Client.RollbackAsync(Database.RootPath, TransactionId, CancellationToken);
    }
}
