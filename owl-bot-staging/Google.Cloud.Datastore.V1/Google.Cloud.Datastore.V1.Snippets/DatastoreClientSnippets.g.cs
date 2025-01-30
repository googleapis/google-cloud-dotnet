// Copyright 2025 Google LLC
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

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    using Google.Cloud.Datastore.V1;
    using Google.Protobuf;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDatastoreClientSnippets
    {
        /// <summary>Snippet for Lookup</summary>
        public void LookupRequestObject()
        {
            // Snippet: Lookup(LookupRequest, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            LookupRequest request = new LookupRequest
            {
                ReadOptions = new ReadOptions(),
                Keys = { new Key(), },
                PropertyMask = new PropertyMask(),
                ProjectId = "",
                DatabaseId = "",
            };
            // Make the request
            LookupResponse response = datastoreClient.Lookup(request);
            // End snippet
        }

        /// <summary>Snippet for LookupAsync</summary>
        public async Task LookupRequestObjectAsync()
        {
            // Snippet: LookupAsync(LookupRequest, CallSettings)
            // Additional: LookupAsync(LookupRequest, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            LookupRequest request = new LookupRequest
            {
                ReadOptions = new ReadOptions(),
                Keys = { new Key(), },
                PropertyMask = new PropertyMask(),
                ProjectId = "",
                DatabaseId = "",
            };
            // Make the request
            LookupResponse response = await datastoreClient.LookupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Lookup</summary>
        public void Lookup()
        {
            // Snippet: Lookup(string, ReadOptions, IEnumerable<Key>, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            ReadOptions readOptions = new ReadOptions();
            IEnumerable<Key> keys = new Key[] { new Key(), };
            // Make the request
            LookupResponse response = datastoreClient.Lookup(projectId, readOptions, keys);
            // End snippet
        }

        /// <summary>Snippet for LookupAsync</summary>
        public async Task LookupAsync()
        {
            // Snippet: LookupAsync(string, ReadOptions, IEnumerable<Key>, CallSettings)
            // Additional: LookupAsync(string, ReadOptions, IEnumerable<Key>, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            ReadOptions readOptions = new ReadOptions();
            IEnumerable<Key> keys = new Key[] { new Key(), };
            // Make the request
            LookupResponse response = await datastoreClient.LookupAsync(projectId, readOptions, keys);
            // End snippet
        }

        /// <summary>Snippet for RunQuery</summary>
        public void RunQueryRequestObject()
        {
            // Snippet: RunQuery(RunQueryRequest, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            RunQueryRequest request = new RunQueryRequest
            {
                ReadOptions = new ReadOptions(),
                PartitionId = new PartitionId(),
                Query = new Query(),
                ProjectId = "",
                DatabaseId = "",
                PropertyMask = new PropertyMask(),
                ExplainOptions = new ExplainOptions(),
            };
            // Make the request
            RunQueryResponse response = datastoreClient.RunQuery(request);
            // End snippet
        }

        /// <summary>Snippet for RunQueryAsync</summary>
        public async Task RunQueryRequestObjectAsync()
        {
            // Snippet: RunQueryAsync(RunQueryRequest, CallSettings)
            // Additional: RunQueryAsync(RunQueryRequest, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            RunQueryRequest request = new RunQueryRequest
            {
                ReadOptions = new ReadOptions(),
                PartitionId = new PartitionId(),
                Query = new Query(),
                ProjectId = "",
                DatabaseId = "",
                PropertyMask = new PropertyMask(),
                ExplainOptions = new ExplainOptions(),
            };
            // Make the request
            RunQueryResponse response = await datastoreClient.RunQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunAggregationQuery</summary>
        public void RunAggregationQueryRequestObject()
        {
            // Snippet: RunAggregationQuery(RunAggregationQueryRequest, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            RunAggregationQueryRequest request = new RunAggregationQueryRequest
            {
                ReadOptions = new ReadOptions(),
                PartitionId = new PartitionId(),
                AggregationQuery = new AggregationQuery(),
                ProjectId = "",
                DatabaseId = "",
                ExplainOptions = new ExplainOptions(),
            };
            // Make the request
            RunAggregationQueryResponse response = datastoreClient.RunAggregationQuery(request);
            // End snippet
        }

        /// <summary>Snippet for RunAggregationQueryAsync</summary>
        public async Task RunAggregationQueryRequestObjectAsync()
        {
            // Snippet: RunAggregationQueryAsync(RunAggregationQueryRequest, CallSettings)
            // Additional: RunAggregationQueryAsync(RunAggregationQueryRequest, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            RunAggregationQueryRequest request = new RunAggregationQueryRequest
            {
                ReadOptions = new ReadOptions(),
                PartitionId = new PartitionId(),
                AggregationQuery = new AggregationQuery(),
                ProjectId = "",
                DatabaseId = "",
                ExplainOptions = new ExplainOptions(),
            };
            // Make the request
            RunAggregationQueryResponse response = await datastoreClient.RunAggregationQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransactionRequestObject()
        {
            // Snippet: BeginTransaction(BeginTransactionRequest, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = "",
                DatabaseId = "",
                TransactionOptions = new TransactionOptions(),
            };
            // Make the request
            BeginTransactionResponse response = datastoreClient.BeginTransaction(request);
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionRequestObjectAsync()
        {
            // Snippet: BeginTransactionAsync(BeginTransactionRequest, CallSettings)
            // Additional: BeginTransactionAsync(BeginTransactionRequest, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = "",
                DatabaseId = "",
                TransactionOptions = new TransactionOptions(),
            };
            // Make the request
            BeginTransactionResponse response = await datastoreClient.BeginTransactionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransaction()
        {
            // Snippet: BeginTransaction(string, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            BeginTransactionResponse response = datastoreClient.BeginTransaction(projectId);
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionAsync()
        {
            // Snippet: BeginTransactionAsync(string, CallSettings)
            // Additional: BeginTransactionAsync(string, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            BeginTransactionResponse response = await datastoreClient.BeginTransactionAsync(projectId);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void CommitRequestObject()
        {
            // Snippet: Commit(CommitRequest, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                Transaction = ByteString.Empty,
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { new Mutation(), },
                ProjectId = "",
                DatabaseId = "",
            };
            // Make the request
            CommitResponse response = datastoreClient.Commit(request);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task CommitRequestObjectAsync()
        {
            // Snippet: CommitAsync(CommitRequest, CallSettings)
            // Additional: CommitAsync(CommitRequest, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                Transaction = ByteString.Empty,
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { new Mutation(), },
                ProjectId = "",
                DatabaseId = "",
            };
            // Make the request
            CommitResponse response = await datastoreClient.CommitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit1()
        {
            // Snippet: Commit(string, CommitRequest.Types.Mode, ByteString, IEnumerable<Mutation>, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            ByteString transaction = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = datastoreClient.Commit(projectId, mode, transaction, mutations);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task Commit1Async()
        {
            // Snippet: CommitAsync(string, CommitRequest.Types.Mode, ByteString, IEnumerable<Mutation>, CallSettings)
            // Additional: CommitAsync(string, CommitRequest.Types.Mode, ByteString, IEnumerable<Mutation>, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            ByteString transaction = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = await datastoreClient.CommitAsync(projectId, mode, transaction, mutations);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit2()
        {
            // Snippet: Commit(string, CommitRequest.Types.Mode, IEnumerable<Mutation>, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = datastoreClient.Commit(projectId, mode, mutations);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task Commit2Async()
        {
            // Snippet: CommitAsync(string, CommitRequest.Types.Mode, IEnumerable<Mutation>, CallSettings)
            // Additional: CommitAsync(string, CommitRequest.Types.Mode, IEnumerable<Mutation>, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = await datastoreClient.CommitAsync(projectId, mode, mutations);
            // End snippet
        }

        /// <summary>Snippet for Rollback</summary>
        public void RollbackRequestObject()
        {
            // Snippet: Rollback(RollbackRequest, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                Transaction = ByteString.Empty,
                ProjectId = "",
                DatabaseId = "",
            };
            // Make the request
            RollbackResponse response = datastoreClient.Rollback(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackAsync</summary>
        public async Task RollbackRequestObjectAsync()
        {
            // Snippet: RollbackAsync(RollbackRequest, CallSettings)
            // Additional: RollbackAsync(RollbackRequest, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                Transaction = ByteString.Empty,
                ProjectId = "",
                DatabaseId = "",
            };
            // Make the request
            RollbackResponse response = await datastoreClient.RollbackAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Rollback</summary>
        public void Rollback()
        {
            // Snippet: Rollback(string, ByteString, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            ByteString transaction = ByteString.Empty;
            // Make the request
            RollbackResponse response = datastoreClient.Rollback(projectId, transaction);
            // End snippet
        }

        /// <summary>Snippet for RollbackAsync</summary>
        public async Task RollbackAsync()
        {
            // Snippet: RollbackAsync(string, ByteString, CallSettings)
            // Additional: RollbackAsync(string, ByteString, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            ByteString transaction = ByteString.Empty;
            // Make the request
            RollbackResponse response = await datastoreClient.RollbackAsync(projectId, transaction);
            // End snippet
        }

        /// <summary>Snippet for AllocateIds</summary>
        public void AllocateIdsRequestObject()
        {
            // Snippet: AllocateIds(AllocateIdsRequest, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "",
                DatabaseId = "",
            };
            // Make the request
            AllocateIdsResponse response = datastoreClient.AllocateIds(request);
            // End snippet
        }

        /// <summary>Snippet for AllocateIdsAsync</summary>
        public async Task AllocateIdsRequestObjectAsync()
        {
            // Snippet: AllocateIdsAsync(AllocateIdsRequest, CallSettings)
            // Additional: AllocateIdsAsync(AllocateIdsRequest, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "",
                DatabaseId = "",
            };
            // Make the request
            AllocateIdsResponse response = await datastoreClient.AllocateIdsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AllocateIds</summary>
        public void AllocateIds()
        {
            // Snippet: AllocateIds(string, IEnumerable<Key>, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            IEnumerable<Key> keys = new Key[] { new Key(), };
            // Make the request
            AllocateIdsResponse response = datastoreClient.AllocateIds(projectId, keys);
            // End snippet
        }

        /// <summary>Snippet for AllocateIdsAsync</summary>
        public async Task AllocateIdsAsync()
        {
            // Snippet: AllocateIdsAsync(string, IEnumerable<Key>, CallSettings)
            // Additional: AllocateIdsAsync(string, IEnumerable<Key>, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            IEnumerable<Key> keys = new Key[] { new Key(), };
            // Make the request
            AllocateIdsResponse response = await datastoreClient.AllocateIdsAsync(projectId, keys);
            // End snippet
        }

        /// <summary>Snippet for ReserveIds</summary>
        public void ReserveIdsRequestObject()
        {
            // Snippet: ReserveIds(ReserveIdsRequest, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            ReserveIdsRequest request = new ReserveIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "",
                DatabaseId = "",
            };
            // Make the request
            ReserveIdsResponse response = datastoreClient.ReserveIds(request);
            // End snippet
        }

        /// <summary>Snippet for ReserveIdsAsync</summary>
        public async Task ReserveIdsRequestObjectAsync()
        {
            // Snippet: ReserveIdsAsync(ReserveIdsRequest, CallSettings)
            // Additional: ReserveIdsAsync(ReserveIdsRequest, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            ReserveIdsRequest request = new ReserveIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "",
                DatabaseId = "",
            };
            // Make the request
            ReserveIdsResponse response = await datastoreClient.ReserveIdsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReserveIds</summary>
        public void ReserveIds()
        {
            // Snippet: ReserveIds(string, IEnumerable<Key>, CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            IEnumerable<Key> keys = new Key[] { new Key(), };
            // Make the request
            ReserveIdsResponse response = datastoreClient.ReserveIds(projectId, keys);
            // End snippet
        }

        /// <summary>Snippet for ReserveIdsAsync</summary>
        public async Task ReserveIdsAsync()
        {
            // Snippet: ReserveIdsAsync(string, IEnumerable<Key>, CallSettings)
            // Additional: ReserveIdsAsync(string, IEnumerable<Key>, CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            IEnumerable<Key> keys = new Key[] { new Key(), };
            // Make the request
            ReserveIdsResponse response = await datastoreClient.ReserveIdsAsync(projectId, keys);
            // End snippet
        }
    }
}
