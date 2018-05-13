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
using Google.Cloud.Firestore.V1Beta1;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.V1Beta1.TransactionOptions.Types;

namespace Google.Cloud.Firestore
{
    // TODO: Make this abstract with all the trimmings when we have actual RPCs to issue.

    /// <summary>
    /// A Firestore database
    /// </summary>
    public sealed class FirestoreDb
    {
        private const string DefaultDatabaseId = "(default)";

        /// <summary>
        /// The underlying client used to make service requests.
        /// </summary>
        public FirestoreClient Client { get; }

        /// <summary>
        /// The project ID associated with this database.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The database ID associated with this database.
        /// </summary>
        public string DatabaseId { get; }

        /// <summary>
        /// The resource name of the database, in the form "projects/{project_id}/databases/{database_id}".
        /// </summary>
        internal string RootPath { get; }

        /// <summary>
        /// The root of the documents, in the form "projects/{project_id}/databases/{database_id}/documents".
        /// </summary>
        internal string DocumentsPath { get; }

        private FirestoreDb(string projectId, string databaseId, FirestoreClient client)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DatabaseId = GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
            Client = GaxPreconditions.CheckNotNull(client, nameof(client));
            // TODO: Investigate using DatabaseName and DocumentPathName.
            RootPath = $"projects/{ProjectId}/databases/{DatabaseId}";
            DocumentsPath = $"{RootPath}/documents";
        }

        /// <summary>
        /// Creates an instance for the specified project and database, using the specified <see cref="FirestoreClient"/>
        /// for RPC operations.
        /// </summary>
        /// <param name="projectId">The ID of the Google Cloud Platform project that contains the database. May be null, in which case
        /// the project will be automatically detected if possible.</param>
        /// <param name="databaseId">The ID of the database within the project. May be null, in which case the default database will be used.</param>
        /// <param name="client">The client to use for RPC operations. May be null, in which case a client will be created with default credentials.</param>
        /// <returns>A new instance.</returns>
        public static FirestoreDb Create(string projectId = null, string databaseId = null, FirestoreClient client = null) =>
            new FirestoreDb(
                projectId ?? Platform.Instance().ProjectId,
                databaseId ?? DefaultDatabaseId,
                client ?? FirestoreClient.Create());

        /// <summary>
        /// Asynchronously creates an instance for the specified project and database, using the specified <see cref="FirestoreClient"/>
        /// for RPC operations.
        /// </summary>
        /// <param name="projectId">The ID of the Google Cloud Platform project that contains the database. May be null, in which case
        /// the project will be automatically detected if possible.</param>
        /// <param name="databaseId">The ID of the database within the project. May be null, in which case the default database will be used.</param>
        /// <param name="client">The client to use for RPC operations. May be null, in which case a client will be created with default credentials.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result of the task is the new instance.</returns>
        public static async Task<FirestoreDb> CreateAsync(string projectId = null, string databaseId = null, FirestoreClient client = null) =>
            new FirestoreDb(
                projectId ?? (await Platform.InstanceAsync().ConfigureAwait(false)).ProjectId,
                databaseId ?? DefaultDatabaseId,
                client ?? await FirestoreClient.CreateAsync().ConfigureAwait(false)
            );

        /// <summary>
        /// Creates a local <see cref="CollectionReference"/> for the given path, which must include
        /// an odd number of slash-separated identifiers. This does not perform any remote operations.
        /// </summary>
        /// <param name="path">The collection path, e.g. <c>col1/doc1/col2</c>.</param>
        /// <returns>A collection reference.</returns>
        public CollectionReference Collection(string path)
        {
            string[] elements = PathUtilities.SplitPath(path);
            GaxPreconditions.CheckArgument((elements.Length & 1) == 1, nameof(path), "Path must have an odd number of elements");
            CollectionReference collectionRef = new CollectionReference(this, null, elements[0]);
            for (int i = 1; i < elements.Length; i += 2)
            {
                var documentRef = new DocumentReference(this, collectionRef, elements[i]);
                collectionRef = new CollectionReference(this, documentRef, elements[i + 1]);
            }
            return collectionRef;
        }

        /// <summary>
        /// Creates a local <see cref="DocumentReference"/> for the given path, which must include
        /// an even number of slash-separated identifiers. This does not perform any remote operations.
        /// </summary>
        /// <param name="path">The document path, e.g. <c>col1/doc1/col2/doc2</c>.</param>
        /// <returns>A document reference.</returns>
        public DocumentReference Document(string path)
        {
            string[] elements = PathUtilities.SplitPath(path);
            GaxPreconditions.CheckArgument((elements.Length & 1) == 0, nameof(path), "Path must have an even number of elements");
            DocumentReference documentRef = null;
            for (int i = 0; i < elements.Length; i += 2)
            {
                var collectionRef = new CollectionReference(this, documentRef, elements[i]);
                documentRef = new DocumentReference(this, collectionRef, elements[i + 1]);
            }
            return documentRef;
        }

        /// <summary>
        /// Creates a write batch, which can be used to commit multiple mutations atomically.
        /// </summary>
        /// <returns>A write batch for this database.</returns>
        public WriteBatch StartBatch() => new WriteBatch(this);

        internal DocumentReference GetDocumentReferenceFromResourceName(string referenceValue)
        {
            // DocumentsPath doesn't end with a slash, but referenceValue has to. This is slightly better than
            // either constructing a string with a slash on the end.
            GaxPreconditions.CheckArgument(referenceValue.StartsWith(DocumentsPath, StringComparison.Ordinal)
                && referenceValue.Length > DocumentsPath.Length
                && referenceValue[DocumentsPath.Length] == '/',
                nameof(referenceValue), "Reference {0} is not part of database {1}", referenceValue, RootPath);
            return Document(referenceValue.Substring(DocumentsPath.Length + 1));
        }

        /// <summary>
        /// Fetches document snapshots from the server.
        /// </summary>
        /// <remarks>
        /// Any documents which are missing are represented in the returned list by a <see cref="DocumentSnapshot"/>
        /// with <see cref="DocumentSnapshot.Exists"/> value of <c>false</c>.
        /// </remarks>
        /// <param name="documents">The document references to fetch. Must not be null, or contain null references.</param>
        /// <returns>The document snapshots, in the same order as <paramref name="documents"/>.</returns>
        public Task<IList<DocumentSnapshot>> GetAllSnapshotsAsync(IEnumerable<DocumentReference> documents) =>
            GetAllSnapshotsAsync(documents, default);

        /// <summary>
        /// Fetches document snapshots from the server.
        /// </summary>
        /// <remarks>
        /// Any documents which are missing are represented in the returned list by a <see cref="DocumentSnapshot"/>
        /// with <see cref="DocumentSnapshot.Exists"/> value of <c>false</c>.
        /// </remarks>
        /// <param name="documents">The document references to fetch. Must not be null, or contain null references.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The document snapshots, in the same order as <paramref name="documents"/>.</returns>
        public Task<IList<DocumentSnapshot>> GetAllSnapshotsAsync(IEnumerable<DocumentReference> documents, CancellationToken cancellationToken) =>
            GetAllSnapshotsAsync(documents, null, cancellationToken);

        internal async Task<IList<DocumentSnapshot>> GetAllSnapshotsAsync(IEnumerable<DocumentReference> documents, ByteString transactionId, CancellationToken cancellationToken)
        {
            // Check for null here, but let the underlying method check for null elements.
            // We're just trying to make sure we don't evaluate it differently later.
            var list = GaxPreconditions.CheckNotNull(documents, nameof(documents)).ToList();
            var unordered = await GetDocumentSnapshotsAsync(list, transactionId, cancellationToken).ConfigureAwait(false);
            var map = unordered.ToDictionary(snapshot => snapshot.Reference);
            return list.Select(docRef =>
            {
                if (!map.TryGetValue(docRef, out var snapshot))
                {
                    throw new InvalidOperationException($"Server did not return snapshot for document {docRef}");
                }
                return snapshot;
            }).ToList();
        }

        /// <summary>
        /// Fetches document snapshots from the server, based on an optional transaction ID.
        /// </summary>
        /// <param name="documents">The document references to fetch. Must not be null, or contain null references.</param>
        /// <param name="transactionId">A transaction ID, or null to not include any transaction ID.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The document snapshots, in the order they are provided in the response. (This may not be the order of <paramref name="documents"/>.)</returns>
        internal async Task<IList<DocumentSnapshot>> GetDocumentSnapshotsAsync(IEnumerable<DocumentReference> documents, ByteString transactionId, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(documents, nameof(documents));
            var request = new BatchGetDocumentsRequest { Database = RootPath, Documents = { documents.Select(ExtractPath) } };
            if (transactionId != null)
            {
                request.Transaction = transactionId;
            }
            var stream = Client.BatchGetDocuments(request, CallSettings.FromCancellationToken(cancellationToken));
            using (var responseStream = stream.ResponseStream)
            {
                List<DocumentSnapshot> snapshots = new List<DocumentSnapshot>();

                // Note: no need to worry about passing the cancellation token in here, as we've passed it into the overall call.
                // If the token is cancelled, the call will be aborted.
                while (await responseStream.MoveNext().ConfigureAwait(false))
                {
                    var response = responseStream.Current;
                    var readTime = Timestamp.FromProto(response.ReadTime);
                    switch (response.ResultCase)
                    {
                        case BatchGetDocumentsResponse.ResultOneofCase.Found:
                            snapshots.Add(DocumentSnapshot.ForDocument(this, response.Found, readTime));
                            break;
                        case BatchGetDocumentsResponse.ResultOneofCase.Missing:
                            snapshots.Add(DocumentSnapshot.ForMissingDocument(this, response.Missing, readTime));
                            break;
                        default:
                            throw new InvalidOperationException($"Unknown response type: {response.ResultCase}");
                    }
                }
                return snapshots;
            }

            string ExtractPath(DocumentReference documentReference)
            {
                GaxPreconditions.CheckArgument(documentReference != null, nameof(documents), "DocumentReference sequence must not contain null elements.");
                return documentReference.Path;
            }
        }

        // TODO: Consider adding GetRootCollectionsAsync which returns a Task<IList<CollectionReference>>,
        // basically just calling ListRootCollectionsAsync().ToList(cancellationToken).
        // That would be more convenient for users who don't know about async enumerables.

        /// <summary>
        /// Asynchronously retrieves the root collection IDs from the server.
        /// </summary>
        /// <returns>All the root collection references, in a lazily-iterated sequence.</returns>
        public IAsyncEnumerable<CollectionReference> ListRootCollectionsAsync() => ListCollectionsAsync(null);

        internal IAsyncEnumerable<CollectionReference> ListCollectionsAsync(DocumentReference parent) =>
            Client.ListCollectionIdsAsync(parent?.Path ?? RootPath)
                .Select(id => new CollectionReference(this, parent, id));

        /// <summary>
        /// Runs a transaction asynchronously, with an asynchronous callback that doesn't return a value.
        /// The specified callback is executed for a newly-created transaction. If committing the transaction
        /// fails, the whole operation is retried based on <see cref="TransactionOptions.MaxAttempts"/>.
        /// </summary>
        /// <param name="callback">The callback to execute. Must not be null.</param>
        /// <returns>A task which completes when the transaction has committed.</returns>
        public Task RunTransactionAsync(Func<Transaction, Task> callback) => RunTransactionAsync(callback, TransactionOptions.Default, default);

        /// <summary>
        /// Runs a transaction asynchronously, with an asynchronous callback that doesn't return a value.
        /// The specified callback is executed for a newly-created transaction. If committing the transaction
        /// fails, the whole operation is retried based on <see cref="TransactionOptions.MaxAttempts"/>.
        /// </summary>
        /// <param name="callback">The callback to execute. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token for the operation. This is exposed to the callback through <see cref="Transaction.CancellationToken"/>
        /// and applied to all RPCs to begin, rollback or commit the transaction.</param>
        /// <returns>A task which completes when the transaction has committed.</returns>
        public Task RunTransactionAsync(Func<Transaction, Task> callback, CancellationToken cancellationToken) => RunTransactionAsync(callback, TransactionOptions.Default, cancellationToken);

        /// <summary>
        /// Runs a transaction asynchronously, with an asynchronous callback that doesn't return a value.
        /// The specified callback is executed for a newly-created transaction. If committing the transaction
        /// fails, the whole operation is retried based on <see cref="TransactionOptions.MaxAttempts"/>.
        /// </summary>
        /// <param name="callback">The callback to execute. Must not be null.</param>
        /// <param name="options">The options for the transaction. Must not be null..</param>
        /// <returns>A task which completes when the transaction has committed.</returns>
        public Task RunTransactionAsync(Func<Transaction, Task> callback, TransactionOptions options) => RunTransactionAsync(callback, options, default);

        /// <summary>
        /// Runs a transaction asynchronously, with an asynchronous callback that doesn't return a value.
        /// The specified callback is executed for a newly-created transaction. If committing the transaction
        /// fails, the whole operation is retried based on <see cref="TransactionOptions.MaxAttempts"/>.
        /// </summary>
        /// <param name="callback">The callback to execute. Must not be null.</param>
        /// <param name="options">The options for the transaction. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token for the operation. This is exposed to the callback through <see cref="Transaction.CancellationToken"/>
        /// and applied to all RPCs to begin, rollback or commit the transaction.</param>
        /// <returns>A task which completes when the transaction has committed.</returns>
        public Task RunTransactionAsync(Func<Transaction, Task> callback, TransactionOptions options, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(callback, nameof(callback));
            return RunTransactionAsync(
                async transaction => { await callback(transaction).ConfigureAwait(false); return 0; },
                options, cancellationToken);
        }

        /// <summary>
        /// Runs a transaction asynchronously, with an asynchronous callback that returns a value.
        /// The specified callback is executed for a newly-created transaction. If committing the transaction
        /// fails, the whole operation is retried based on <see cref="TransactionOptions.MaxAttempts"/>.
        /// </summary>
        /// <typeparam name="T">The result type of the callback.</typeparam>
        /// <param name="callback">The callback to execute. Must not be null.</param>
        /// <returns>A task which completes when the transaction has committed. The result of the task then contains the result of the callback.</returns>
        public Task<T> RunTransactionAsync<T>(Func<Transaction, Task<T>> callback) => RunTransactionAsync(callback, TransactionOptions.Default, default);

        /// <summary>
        /// Runs a transaction asynchronously, with an asynchronous callback that returns a value.
        /// The specified callback is executed for a newly-created transaction. If committing the transaction
        /// fails, the whole operation is retried based on <see cref="TransactionOptions.MaxAttempts"/>.
        /// </summary>
        /// <typeparam name="T">The result type of the callback.</typeparam>
        /// <param name="callback">The callback to execute. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token for the operation. This is exposed to the callback through <see cref="Transaction.CancellationToken"/>
        /// and applied to all RPCs to begin, rollback or commit the transaction.</param>
        /// <returns>A task which completes when the transaction has committed. The result of the task then contains the result of the callback.</returns>
        public Task<T> RunTransactionAsync<T>(Func<Transaction, Task<T>> callback, CancellationToken cancellationToken) => RunTransactionAsync(callback, TransactionOptions.Default, cancellationToken);

        /// <summary>
        /// Runs a transaction asynchronously, with an asynchronous callback that returns a value.
        /// The specified callback is executed for a newly-created transaction. If committing the transaction
        /// fails, the whole operation is retried based on <see cref="TransactionOptions.MaxAttempts"/>.
        /// </summary>
        /// <typeparam name="T">The result type of the callback.</typeparam>
        /// <param name="callback">The callback to execute. Must not be null.</param>
        /// <param name="options">The options for the transaction. Must not be null.</param>
        /// <returns>A task which completes when the transaction has committed. The result of the task then contains the result of the callback.</returns>
        public Task<T> RunTransactionAsync<T>(Func<Transaction, Task<T>> callback, TransactionOptions options) => RunTransactionAsync(callback, options, default);

        // TODO: Is it appropriate to use ConfigureAwait(false) here? Should the caller be able to specify the context for executing their callback?
        // TODO: Collect up all the exceptions we've retried?

        /// <summary>
        /// Runs a transaction asynchronously, with an asynchronous callback that returns a value.
        /// The specified callback is executed for a newly-created transaction. If committing the transaction
        /// fails, the whole operation is retried based on <see cref="TransactionOptions.MaxAttempts"/>.
        /// </summary>
        /// <typeparam name="T">The result type of the callback.</typeparam>
        /// <param name="callback">The callback to execute. Must not be null.</param>
        /// <param name="options">The options for the transaction. Must not be null.</param>
        /// <param name="cancellationToken">A cancellation token for the operation. This is exposed to the callback through <see cref="Transaction.CancellationToken"/>
        /// and applied to all RPCs to begin, rollback or commit the transaction.</param>
        /// <returns>A task which completes when the transaction has committed. The result of the task then contains the result of the callback.</returns>
        public async Task<T> RunTransactionAsync<T>(Func<Transaction, Task<T>> callback, TransactionOptions options, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(callback, nameof(callback));
            GaxPreconditions.CheckNotNull(options, nameof(options));
            ByteString previousTransactionId = null;
            var attemptsLeft = options.MaxAttempts;
            TimeSpan backoff = TimeSpan.FromSeconds(1);

            while (true)
            {
                attemptsLeft--;
                var transaction = await Transaction.BeginAsync(this, previousTransactionId, cancellationToken).ConfigureAwait(false);
                previousTransactionId = transaction.TransactionId;
                bool rollback = true;
                try
                {
                    T result = await callback(transaction).ConfigureAwait(false);
                    try
                    {
                        rollback = false;
                        await transaction.CommitAsync().ConfigureAwait(false);
                        return result;
                    }
                    catch (RpcException e) when (CheckRetry(e, ref rollback))
                    {
                        // On to the next iteration...
                    }
                }
                finally
                {
                    if (rollback)
                    {
                        await transaction.RollbackAsync().ConfigureAwait(false);
                    }
                }
            }

            bool CheckRetry(RpcException e, ref bool rollback)
            {
                switch (e.Status.StatusCode)
                {
                    case StatusCode.Aborted:
                        // Definitely rollback, retry if we have any attempts left.
                        rollback = true;
                        return attemptsLeft > 0;
                    case StatusCode.DeadlineExceeded:
                    case StatusCode.Cancelled:
                        // No retry, but we do want to roll back.
                        rollback = true;
                        return false;
                    default:
                        return false;
                }
            }
        }
    }
}
