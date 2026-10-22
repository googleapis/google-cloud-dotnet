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

using Google.Api.Gax.Grpc;
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;
using WKT = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Tests
{
    /// <summary>
    /// Fake FirestoreClient to allow testing of the RPCs required for transactions.
    /// This client doesn't really emulate Firestore in any meaningful way, but it allows
    /// failure injection and request recording.
    /// </summary>
    internal class TransactionTestingClient : FirestoreClient
    {
        private int _nanos = 0;
        private int _transactions = 0;
        private int _failures;
        private readonly Exception _exception;

        /// <summary>
        /// The list of commit requests we've received.
        /// </summary>
        public List<CommitRequest> CommitRequests { get; } = new List<CommitRequest>();

        /// <summary>
        /// The list of commit requests we've received.
        /// </summary>
        public List<RollbackRequest> RollbackRequests { get; } = new List<RollbackRequest>();

        /// <summary>
        /// Creates a testing client which will make all commits succeed.
        /// </summary>
        public TransactionTestingClient() : this(0, null)
        {
        }

        /// <summary>
        /// Creates a client which will respond to the first <paramref name="failures"/> commit calls with <paramref name="exception"/>.
        /// </summary>
        public TransactionTestingClient(int failures, Exception exception, FirestoreSettings settings = null)
        {
            Settings = settings ?? FirestoreSettings.GetDefault();
            _failures = failures;
            _exception = exception;
        }

        // Async wrappers for the synchronous implementations.
        // Using Task.Run instead of Task.FromResult to allow exceptions to be propagated as faulted tasks.
        public override Task<BeginTransactionResponse> BeginTransactionAsync(BeginTransactionRequest request, CallSettings callSettings = null) =>
            Task.Run(() => BeginTransaction(request, callSettings));

        public override Task<CommitResponse> CommitAsync(CommitRequest request, CallSettings callSettings = null) =>
            Task.Run(() => Commit(request, callSettings));

        public override Task RollbackAsync(RollbackRequest request, CallSettings callSettings = null) =>
            Task.Run(() => Rollback(request, callSettings));

        public override RunQueryStream RunQuery(RunQueryRequest request, CallSettings callSettings = null)
        {
            // Don't return any documents, but a response that lets us check the transaction was propagated.
            var response = new RunQueryResponse { ReadTime = GetNextTimestamp() };
            if (request.ConsistencySelectorCase == RunQueryRequest.ConsistencySelectorOneofCase.Transaction)
            {
                response.Transaction = request.Transaction;
            }
            return new FakeQueryStream(new[] { response });
        }

        public override RunAggregationQueryStream RunAggregationQuery(RunAggregationQueryRequest request, CallSettings callSettings = null)
        {
            var response = new RunAggregationQueryResponse { ReadTime = GetNextTimestamp(), Result = new AggregationResult() };
            if (request.ConsistencySelectorCase == RunAggregationQueryRequest.ConsistencySelectorOneofCase.Transaction)
            {
                response.Transaction = request.Transaction;
            }
            return new FakeAggregationQueryStream(new[] { response });
        }

        public override BatchGetDocumentsStream BatchGetDocuments(BatchGetDocumentsRequest request, CallSettings callSettings = null)
        {
            string transaction = request.ConsistencySelectorCase == BatchGetDocumentsRequest.ConsistencySelectorOneofCase.Transaction ?
                request.Transaction.ToStringUtf8() : "no transaction";
            // Fake documents that show which transaction was being used.
            var responses = request.Documents.Select(path => new BatchGetDocumentsResponse
            {
                Found = new Document
                {
                    Name = path,
                    CreateTime = CreateProtoTimestamp(0, 0),
                    UpdateTime = CreateProtoTimestamp(0, 0),
                    Fields = { { "transaction", CreateValue(transaction) } }
                },
                ReadTime = GetNextTimestamp()
            });
            return new FakeDocumentStream(responses);
        }

        public override BeginTransactionResponse BeginTransaction(BeginTransactionRequest request, CallSettings callSettings = null)
        {
            int id = Interlocked.Increment(ref _transactions);
            string text = $"transaction {id}";
            ByteString retry = request.Options?.ReadWrite?.RetryTransaction;
            if (retry != null)
            {
                // We don't want to chain "transaction 5; retrying transaction 4; retrying transaction 3" etc.
                string retryText = retry.ToStringUtf8().Split(';')[0];
                text += $"; retrying {retryText}";
            }
            return new BeginTransactionResponse { Transaction = ByteString.CopyFromUtf8(text) };
        }

        public override CommitResponse Commit(CommitRequest request, CallSettings callSettings = null)
        {
            lock (CommitRequests)
            {
                CommitRequests.Add(request);
            }
            if (Interlocked.Decrement(ref _failures) >= 0)
            {
                throw _exception;
            }
            var commitTime = GetNextTimestamp();
            return new CommitResponse
            {
                CommitTime = commitTime,
                WriteResults = { request.Writes.Select(write => new V1.WriteResult { UpdateTime = commitTime }) }
            };
        }

        public override void Rollback(RollbackRequest request, CallSettings callSettings = null)
        {
            lock (RollbackRequests)
            {
                RollbackRequests.Add(request);
            }
        }

        private WKT::Timestamp GetNextTimestamp() => CreateProtoTimestamp(0, Interlocked.Increment(ref _nanos));
    }
}
