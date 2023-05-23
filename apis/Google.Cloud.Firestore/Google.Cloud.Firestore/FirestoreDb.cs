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
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// A Firestore database. Create instances using the static <see cref="Create(string, FirestoreClient)"/> and <see cref="CreateAsync(string, FirestoreClient)"/>
    /// methods, or using a <see cref="FirestoreDbBuilder"/>.
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

        // TODO: Make this public again when the server supports it. Unskip the tests in FirestoreMultipleDbTest.
        /// <summary>
        /// The database ID associated with this database.The value will be "(default)" for the project-default database.
        /// </summary>
        internal string DatabaseId { get; }

        /// <summary>
        /// The resource name of the database, in the form "projects/{project_id}/databases/{database_id}".
        /// </summary>
        internal string RootPath { get; }

        /// <summary>
        /// The root of the documents, in the form "projects/{project_id}/databases/{database_id}/documents".
        /// </summary>
        internal string DocumentsPath { get; }

        private Action<string> WarningLogger { get; }
        
        internal SerializationContext SerializationContext { get; }

        private readonly CallSettings _batchGetCallSettings;

        private FirestoreDb(string projectId, string databaseId, FirestoreClient client, Action<string> warningLogger, SerializationContext serializationContext)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DatabaseId = GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
            Client = GaxPreconditions.CheckNotNull(client, nameof(client));
            // TODO: Investigate using DatabaseName and DocumentPathName.
            RootPath = $"projects/{ProjectId}/databases/{DatabaseId}";
            DocumentsPath = $"{RootPath}/documents";
            WarningLogger = warningLogger;

            // TODO: Potentially make these configurable.
            // The retry settings are taken from firestore_grpc_service_config.json.
            var batchGetRetry = RetrySettings.FromExponentialBackoff(
                maxAttempts: 5,
                initialBackoff: TimeSpan.FromMilliseconds(100),
                maxBackoff: TimeSpan.FromSeconds(60),
                backoffMultiplier: 1.3,
                retryFilter: RetrySettings.FilterForStatusCodes(StatusCode.Unavailable, StatusCode.Internal, StatusCode.DeadlineExceeded));
            _batchGetCallSettings = CallSettings.FromRetry(batchGetRetry).WithTimeout(TimeSpan.FromMinutes(10));

            SerializationContext = GaxPreconditions.CheckNotNull(serializationContext, nameof(serializationContext));
        }

        // Internally, we support non-default databases. The public Create and CreateAsync methods only support the default database,
        // as that's all the server supports at the moment. When that changes, we'll want to support non-default databases publicly,
        // but will probably need a different method name in order to do so, to avoid it being a breaking change.
        // We don't have a CreateAsync method accepting a database ID, as we don't use that anywhere for testing.

        /// <summary>
        /// Creates an instance for the specified project, using the specified <see cref="FirestoreClient"/> for RPC operations.
        /// </summary>
        /// <param name="projectId">The ID of the Google Cloud Platform project that contains the database. May be null, in which case
        /// the project will be automatically detected if possible.</param>
        /// <param name="client">The client to use for RPC operations. May be null, in which case a client will be created with default credentials.</param>
        /// <returns>A new instance.</returns>
        public static FirestoreDb Create(string projectId = null, FirestoreClient client = null) =>
            new FirestoreDbBuilder { ProjectId = projectId ?? Platform.Instance().ProjectId, Client = client }.Build();

        /// <summary>
        /// Asynchronously creates an instance for the specified project, using the specified <see cref="FirestoreClient"/> for RPC operations.
        /// </summary>
        /// <param name="projectId">The ID of the Google Cloud Platform project that contains the database. May be null, in which case
        /// the project will be automatically detected if possible.</param>
        /// <param name="client">The client to use for RPC operations. May be null, in which case a client will be created with default credentials.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result of the task is the new instance.</returns>
        public static async Task<FirestoreDb> CreateAsync(string projectId = null, FirestoreClient client = null) =>
            await new FirestoreDbBuilder
            {
                ProjectId = projectId ?? (await Platform.InstanceAsync().ConfigureAwait(false)).ProjectId,
                Client = client
            }
            .BuildAsync().ConfigureAwait(false);

        /// <summary>
        /// Creates an instance for the specified project and database, using the specified <see cref="FirestoreClient"/>
        /// for RPC operations.
        /// Note: this method should never be made public, as it is expected to grow as additional state is required in the client.
        /// Additional parameters should be made optional, for source (but not binary) compatibility with tests.
        /// This method does not perform any blocking operations, so may be used from async methods.
        /// </summary>
        /// <param name="projectId">The ID of the Google Cloud Platform project that contains the database. Must not be null.</param>
        /// <param name="databaseId">The ID of the database within the project. May be null, in which case the default database will be used.</param>
        /// <param name="client">The client to use for RPC operations. Must not be null.</param>
        /// <param name="warningLogger">The warning logger to use, if any. May be null.</param>
        /// <param name="converterRegistry">A registry of custom converters. May be null.</param>
        /// <returns>A new instance.</returns>
        internal static FirestoreDb Create(
            // Required parameters
            string projectId, string databaseId, FirestoreClient client,
            // Optional parameters
            Action<string> warningLogger = null,
            ConverterRegistry converterRegistry = null) =>
            // Validation is performed in the constructor.
            new FirestoreDb(
                projectId,
                databaseId ?? DefaultDatabaseId,
                client,
                warningLogger,
                new SerializationContext(converterRegistry));

        /// <summary>
        /// Returns a new <see cref="FirestoreDb"/> with the same project, database and client as this one,
        /// but the given writer for warning logs.
        /// </summary>
        /// <param name="warningLogger">The logger for warnings. May be null.</param>
        /// <returns>A new <see cref="FirestoreDb"/> based on this one, with the given warning logger.</returns>
        public FirestoreDb WithWarningLogger(Action<string> warningLogger) =>
            new FirestoreDb(ProjectId, DatabaseId, Client, warningLogger, SerializationContext);

        internal void LogWarning(string message) => WarningLogger?.Invoke(message);

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
        /// Creates and returns a new <see cref="Query"/> that includes all documents in the
        /// database that are contained in a collection or subcollection with the
        /// given collection ID.
        /// </summary>
        /// <param name="collectionId">Identifies the collections to query over.
        /// Every collection or subcollection with this ID as the last segment
        /// of its path will be included. Must not contain a slash.</param>
        /// <returns>The created <see cref="Query"/>.</returns>
        public Query CollectionGroup(string collectionId)
        {
            PathUtilities.ValidateId(collectionId, nameof(collectionId));
            return Query.ForCollectionGroup(this, collectionId);
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
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The document snapshots, in the same order as <paramref name="documents"/>.</returns>
        public Task<IList<DocumentSnapshot>> GetAllSnapshotsAsync(IEnumerable<DocumentReference> documents, CancellationToken cancellationToken = default) =>
            GetAllSnapshotsAsync(documents, null, null, cancellationToken);

        /// <summary>
        /// Fetches document snapshots from the server, potentially limiting the fields returned.
        /// </summary>
        /// <remarks>
        /// Any documents which are missing are represented in the returned list by a <see cref="DocumentSnapshot"/>
        /// with <see cref="DocumentSnapshot.Exists"/> value of <c>false</c>.
        /// </remarks>
        /// <param name="documents">The document references to fetch. Must not be null, or contain null references.</param>
        /// <param name="fieldMask">The field mask to use to restrict which fields are retrieved. May be null, in which
        /// case no field mask is applied, and the complete documents are retrieved.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The document snapshots, in the same order as <paramref name="documents"/>.</returns>
        public Task<IList<DocumentSnapshot>> GetAllSnapshotsAsync(IEnumerable<DocumentReference> documents, FieldMask fieldMask, CancellationToken cancellationToken = default) =>
            GetAllSnapshotsAsync(documents, null, fieldMask, cancellationToken);

        internal async Task<IList<DocumentSnapshot>> GetAllSnapshotsAsync(IEnumerable<DocumentReference> documents, ByteString transactionId, FieldMask fieldMask, CancellationToken cancellationToken)
        {
            // Check for null here, but let the underlying method check for null elements.
            // We're just trying to make sure we don't evaluate it differently later.
            var list = GaxPreconditions.CheckNotNull(documents, nameof(documents)).ToList();
            var unordered = await GetDocumentSnapshotsAsync(list, transactionId, fieldMask, cancellationToken).ConfigureAwait(false);
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
        /// <param name="fieldMask">The field mask to use to restrict which fields are retrieved. May be null, in which
        /// case no field mask is applied, and the complete documents are retrieved.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The document snapshots, in the order they are provided in the response. (This may not be the order of <paramref name="documents"/>.)</returns>
        internal async Task<IList<DocumentSnapshot>> GetDocumentSnapshotsAsync(IEnumerable<DocumentReference> documents, ByteString transactionId, FieldMask fieldMask, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(documents, nameof(documents));
            var request = new BatchGetDocumentsRequest
            {
                Database = RootPath,
                Documents = { documents.Select(ExtractPath) },
                Mask = fieldMask?.ToProto()
            };
            if (transactionId != null)
            {
                request.Transaction = transactionId;
            }

            var clock = Client.Settings.Clock ?? SystemClock.Instance;
            var scheduler = Client.Settings.Scheduler ?? SystemScheduler.Instance;
            var callSettings = _batchGetCallSettings.WithCancellationToken(cancellationToken);

            // This is the function that we'll retry. We can't use the built-in retry functionality, because it's not a unary gRPC call.
            // (We could potentially simulate a unary call, but it would be a little odd to do so.)
            // Note that we perform a "whole request" retry. In theory we could collect some documents, then see an error, and only
            // request the remaining documents. Given how rarely we retry anyway in practice, that's probably not worth doing.
            Func<BatchGetDocumentsRequest, CallSettings, Task<List<DocumentSnapshot>>> function = async (req, settings) =>
            {
                using var stream = Client.BatchGetDocuments(req, settings);
                var responseStream = stream.GrpcCall.ResponseStream;
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
            };

            var retryingTask = RetryHelper.Retry(function, request, callSettings, clock, scheduler);
            return await retryingTask.ConfigureAwait(false);            

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
            Client.ListCollectionIdsAsync(parent?.Path ?? DocumentsPath)
                .Select(id => new CollectionReference(this, parent, id));

        // TODO: Is it appropriate to use ConfigureAwait(false) here? Should the caller be able to specify the context for executing their callback?
        // TODO: Collect up all the exceptions we've retried?
        // TODO: Is it nice to have all these overloads?

        /// <summary>
        /// Runs a transaction asynchronously, with an asynchronous callback that doesn't return a value.
        /// The specified callback is executed for a newly-created transaction. If committing the transaction
        /// fails, the whole operation is retried based on <see cref="TransactionOptions.MaxAttempts"/>.
        /// </summary>
        /// <param name="callback">The callback to execute. Must not be null.</param>
        /// <param name="options">The options for the transaction. May be null, in which case default options will be used.</param>
        /// <param name="cancellationToken">A cancellation token for the operation. This is exposed to the callback through <see cref="Transaction.CancellationToken"/>
        /// and applied to all RPCs to begin, rollback or commit the transaction.</param>
        /// <returns>A task which completes when the transaction has committed.</returns>
        public Task RunTransactionAsync(Func<Transaction, Task> callback, TransactionOptions options = null, CancellationToken cancellationToken = default)
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
        /// <param name="options">The options for the transaction. May be null, in which case default options will be used.</param>
        /// <param name="cancellationToken">A cancellation token for the operation. This is exposed to the callback through <see cref="Transaction.CancellationToken"/>
        /// and applied to all RPCs to begin, rollback or commit the transaction.</param>
        /// <returns>A task which completes when the transaction has committed. The result of the task then contains the result of the callback.</returns>
        public async Task<T> RunTransactionAsync<T>(Func<Transaction, Task<T>> callback, TransactionOptions options = null, CancellationToken cancellationToken = default)
        {

            ByteString previousTransactionId = null;
            options = options ?? TransactionOptions.Default;
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
