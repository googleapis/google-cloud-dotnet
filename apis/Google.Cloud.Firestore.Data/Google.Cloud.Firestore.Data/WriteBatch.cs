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
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore.Data
{
    // TODO: Sentinel fields on all operations

    /// <summary>
    /// A batch of write operations, to be applied in a single commit.
    /// </summary>
    public sealed class WriteBatch
    {
        private readonly FirestoreDb _db;

        internal bool IsEmpty => Writes.Count == 0;

        // Visible for testing; should not be used elsewhere in the production code.
        internal List<Write> Writes = new List<Write>();

        internal WriteBatch(FirestoreDb firestoreDb)
        {
            _db = firestoreDb;
        }

        /// <summary>
        /// Adds a write operation which will create the specified document with a precondition
        /// that it doesn't exist already.
        /// </summary>
        /// <param name="documentReference">A document reference indicating the path of the document to create. Must not be null.</param>
        /// <param name="documentData">The data for the document. Must not be null.</param>
        /// <returns>This batch, for the purpose of method chaining</returns>
        public WriteBatch Create(DocumentReference documentReference, object documentData)
        {
            GaxPreconditions.CheckNotNull(documentReference, nameof(documentReference));
            GaxPreconditions.CheckNotNull(documentData, nameof(documentData));
            var write = new Write
            {
                CurrentDocument = Precondition.MustNotExist.Proto,
                Update = new Document
                {
                    Fields = { ValueSerializer.SerializeMap(documentData) },
                    Name = documentReference.Path
                }
            };
            Writes.Add(write);

            return this;
        }

        /// <summary>
        /// Adds a write operation that deletes the specified document, with an optional precondition.
        /// </summary>
        /// <param name="documentReference">A document reference indicating the path of the document to delete. Must not be null.</param>
        /// <param name="precondition">Optional precondition for deletion. May be null, in which case the deletion is unconditional.</param>
        /// <returns>This batch, for the purposes of method chaining.</returns>
        public WriteBatch Delete(DocumentReference documentReference, Precondition precondition = null)
        {
            GaxPreconditions.CheckNotNull(documentReference, nameof(documentReference));
            var write = new Write
            {
                CurrentDocument = precondition?.Proto,
                Delete = documentReference.Path
            };
            Writes.Add(write);
            return this;
        }

        /// <summary>
        /// Commits the batch on the server.
        /// </summary>
        /// <returns>The write results from the commit.</returns>
        public Task<IList<WriteResult>> CommitAsync(CancellationToken cancellationToken = default) =>
            CommitAsync(ByteString.Empty, cancellationToken);

        internal async Task<IList<WriteResult>> CommitAsync(ByteString transactionId, CancellationToken cancellationToken)
        {
            var request = new CommitRequest { Database = _db.RootPath, Writes = { Writes }, Transaction = transactionId };
            var response = await _db.Client.CommitAsync(request, CallSettings.FromCancellationToken(cancellationToken)).ConfigureAwait(false);
            return response.WriteResults.Select(wr => WriteResult.FromProto(wr, response.CommitTime)).ToList();
        }
    }
}
