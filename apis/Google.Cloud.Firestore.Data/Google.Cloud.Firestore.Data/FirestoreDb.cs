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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore.Data
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
        public WriteBatch CreateWriteBatch() => new WriteBatch(this);

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
    }
}
