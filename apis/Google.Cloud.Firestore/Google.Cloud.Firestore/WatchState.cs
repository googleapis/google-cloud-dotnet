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

using Google.Api.Gax;
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.V1.TargetChange.Types.TargetChangeType;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// The state of a Watch operation, dealing with the business logic of keeping track of documents.
    /// </summary>
    internal sealed class WatchState : IWatchState
    {
        private readonly Func<QuerySnapshot, CancellationToken, Task> _callback;
        private readonly Query _query;
        private readonly IComparer<DocumentSnapshot> _comparer;
        private readonly IDictionary<DocumentReference, Document> _changeMap;
        private DocumentSet _documentSet;
        private bool _current;
        private bool _hasPushed;

        public ByteString ResumeToken { get; private set; }

        internal WatchState(Query query, Func<QuerySnapshot, CancellationToken, Task> callback)
        {
            _query = query;
            _callback = callback;
            _comparer = query.CreateDocumentSnapshotComparer();
            _documentSet = DocumentSet.Empty(_comparer);
            _changeMap = new Dictionary<DocumentReference, Document>();
        }

        public void OnStreamInitialization(StreamInitializationCause cause)
        {
            _current = false;
            if (cause == StreamInitializationCause.StreamCompleted || cause == StreamInitializationCause.RpcError)
            {
                _changeMap.Clear();
            }
        }

        public async Task<WatchResponseResult> HandleResponseAsync(ListenResponse response, CancellationToken cancellationToken)
        {
            switch (response.ResponseTypeCase)
            {
                case ListenResponse.ResponseTypeOneofCase.TargetChange:
                    TargetChange change = response.TargetChange;
                    bool noTargetIds = change.TargetIds.Count == 0;

                    switch (change.TargetChangeType)
                    {
                        case NoChange:
                            if (noTargetIds && change.ReadTime != null && _current)
                            {
                                // This means everything is up-to-date, so emit the current set of docs as a snapshot,
                                // if there were changes.
                                await PushSnapshotAsync(Timestamp.FromProto(change.ReadTime), change.ResumeToken, cancellationToken).ConfigureAwait(false);
                            }
                            break;
                        case Add:
                            GaxPreconditions.CheckState(!noTargetIds && WatchStream.WatchTargetId == change.TargetIds[0], "Target ID must be 0x{0:x}", WatchStream.WatchTargetId);
                            break;
                        case Remove:
                            GaxPreconditions.CheckState(!noTargetIds && WatchStream.WatchTargetId == change.TargetIds[0], "Target ID must be 0x{0:x}", WatchStream.WatchTargetId);
                            // The server has effectively aborted this watch in a permanent way. Surface this as an RpcException based on the cause.
                            var cause = change.Cause ?? new Rpc.Status { Code = (int) Rpc.Code.Unknown, Message = "Unknown cause" };
                            var status = new Status((StatusCode)cause.Code, cause.Message);
                            throw new RpcException(status, $"Server removed target. Code: {status.StatusCode} Message: {status.Detail}");
                        case Current:
                            _current = true;
                            break;
                        case Reset:
                            ResetDocs();
                            return WatchResponseResult.Continue;
                        default:
                            throw new InvalidOperationException($"Encountered invalid target change type: {change.Cause.Message}");
                    }

                    bool healthy = change.ResumeToken != null && (change.TargetIds.Count == 0 || change.TargetIds.Contains(WatchStream.WatchTargetId));
                    // Possibly tell the watch stream that it's now healthy (so reset backoff), or just continue.
                    return healthy ? WatchResponseResult.StreamHealthy : WatchResponseResult.Continue;
                case ListenResponse.ResponseTypeOneofCase.DocumentChange:
                    // No other targetIds can show up here, but we still need to see if the targetId was in the
                    // added list or removed list.
                    var changed = response.DocumentChange.TargetIds.Contains(WatchStream.WatchTargetId);
                    var removed = response.DocumentChange.RemovedTargetIds.Contains(WatchStream.WatchTargetId);
                    Document document = response.DocumentChange.Document;
                    DocumentReference docRef = CreateDocumentReference(document.Name);
                    if (changed && removed)
                    {
                        throw new InvalidOperationException("Server error: document was both changed and removed");
                    }
                    if (!changed && !removed)
                    {
                        // This is probably an error in the server, but we can follow protocol by just ignoring this response.
                        return WatchResponseResult.Continue;
                    }
                    _changeMap[docRef] = changed ? document : null;
                    return WatchResponseResult.Continue;
                case ListenResponse.ResponseTypeOneofCase.DocumentDelete:
                    _changeMap[CreateDocumentReference(response.DocumentDelete.Document)] = null;
                    return WatchResponseResult.Continue;
                case ListenResponse.ResponseTypeOneofCase.DocumentRemove:
                    _changeMap[CreateDocumentReference(response.DocumentRemove.Document)] = null;
                    return WatchResponseResult.Continue;
                case ListenResponse.ResponseTypeOneofCase.Filter:
                    // TODO: Do we really want to create the change set itself, rather than just count? It seems a bit wasteful.
                    ChangeSet changeSet = ExtractChanges(default);
                    int currentSize = _documentSet.Count + changeSet.Adds.Count - changeSet.Deletes.Count;
                    // Reset the stream if we don't have the right number of documents.
                    if (response.Filter.Count != currentSize)
                    {
                        ResetDocs();
                        return WatchResponseResult.ResetStream;
                    }
                    return WatchResponseResult.Continue;
                default:
                    throw new InvalidOperationException($"Encountered invalid listen response type: {response.ResponseTypeCase}");
            }
        }

        private void ResetDocs()
        {
            _changeMap.Clear(); // May be unnecessary
            ResumeToken = null;

            foreach (DocumentSnapshot snapshot in _documentSet)
            {
                // Mark each document as deleted. If documents are not deleted, they  will be sent again by
                // the server.
                _changeMap[snapshot.Reference] = null;
            }

            _current = false;
        }

        private async Task PushSnapshotAsync(Timestamp readTime, ByteString nextResumeToken, CancellationToken cancellationToken)
        {
            List<DocumentChange> changes = ComputeSnapshot(readTime);
            if (!_hasPushed || changes.Count != 0)
            {
                QuerySnapshot querySnapshot = QuerySnapshot.ForChanges(_query, _documentSet, changes, readTime);
                await _callback(querySnapshot, cancellationToken).ConfigureAwait(false);
                _hasPushed = true;
            }

            _changeMap.Clear();
            ResumeToken = nextResumeToken;
        }

        private List<DocumentChange> ComputeSnapshot(Timestamp readTime)
        {
            var appliedChanges = new List<DocumentChange>();

            ChangeSet changeSet = ExtractChanges(readTime);

            // Note: Not just using Select here, as Delete/Add/ModifyDocument methods have side-effects.
            changeSet.Sort(_comparer);
            foreach (var doc in changeSet.Deletes)
            {
                appliedChanges.Add(DeleteDocument(doc));
            }
            foreach (var doc in changeSet.Adds)
            {
                appliedChanges.Add(AddDocument(doc));
            }
            foreach (var doc in changeSet.Updates)
            {
                var change = ModifyDocument(doc);
                if (change != null)
                {
                    appliedChanges.Add(change);
                }
            }
            return appliedChanges;
        }

        /// <summary>
        /// Applies a document delete to the document tree. Returns the corresponding DocumentChange event.
        /// </summary>
        private DocumentChange DeleteDocument(DocumentSnapshot oldDocument)
        {
            int oldIndex = _documentSet.IndexOf(oldDocument.Reference);
            _documentSet = _documentSet.WithDocumentRemoved(oldDocument.Reference);
            return new DocumentChange(oldDocument, DocumentChange.Type.Removed, oldIndex, null);
        }

        /// <summary>
        /// Applies a document addition to the document tree. Returns the corresponding DocumentChange event.
        /// </summary>
        private DocumentChange AddDocument(DocumentSnapshot newDocument)
        {
            _documentSet = _documentSet.WithDocumentAdded(newDocument);
            int newIndex = _documentSet.IndexOf(newDocument.Reference);
            return new DocumentChange(newDocument, DocumentChange.Type.Added, null, newIndex);
        }

        /// <summary>
        /// Applies a document modification to the document tree. Returns the DocumentChange event for
        /// successful modifications, or null if the old and new documents have the same update timestamp.
        /// </summary>
        private DocumentChange ModifyDocument(DocumentSnapshot newDocument)
        {
            var docRef = newDocument.Reference;
            if (!_documentSet.TryGetDocument(docRef, out var oldDocument))
            {
                // TODO: Is this appropriate? Java throws an NPE here...
                throw new InvalidOperationException("Attempt to create a document modification, but document wasn't in set.");
            }
            if (oldDocument.UpdateTime == newDocument.UpdateTime)
            {
                return null;
            }
            int oldIndex = _documentSet.IndexOf(docRef);
            _documentSet = _documentSet.WithDocumentRemoved(docRef);
            _documentSet = _documentSet.WithDocumentAdded(newDocument);
            int newIndex = _documentSet.IndexOf(docRef);
            return new DocumentChange(newDocument, DocumentChange.Type.Modified, oldIndex, newIndex);
        }

        private ChangeSet ExtractChanges(Timestamp readTime)
        {
            ChangeSet changeSet = new ChangeSet();
            foreach (var entry in _changeMap)
            {
                if (entry.Value == null)
                {
                    if (_documentSet.TryGetDocument(entry.Key, out var document))
                    {
                        changeSet.Deletes.Add(document);
                    }
                }
                else
                {
                    DocumentSnapshot snapshot = DocumentSnapshot.ForDocument(_query.Database, entry.Value, readTime);
                    var list = _documentSet.Contains(entry.Key) ? changeSet.Updates : changeSet.Adds;
                    list.Add(snapshot);
                }
            }

            return changeSet;
        }

        private DocumentReference CreateDocumentReference(string documentName) =>
            _query.Database.GetDocumentReferenceFromResourceName(documentName);

        private sealed class ChangeSet
        {
            internal List<DocumentSnapshot> Deletes { get; } = new List<DocumentSnapshot>();
            internal List<DocumentSnapshot> Adds { get; } = new List<DocumentSnapshot>();
            internal List<DocumentSnapshot> Updates { get; } = new List<DocumentSnapshot>();

            internal void Sort(IComparer<DocumentSnapshot> comparer)
            {
                Deletes.Sort(comparer);
                Adds.Sort(comparer);
                Updates.Sort(comparer);
            }
        }
    }
}
