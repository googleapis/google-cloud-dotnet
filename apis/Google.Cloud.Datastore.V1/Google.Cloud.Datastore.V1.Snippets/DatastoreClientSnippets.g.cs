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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Datastore.V1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Datastore.V1.Snippets
{
    public class GeneratedDatastoreClientSnippets
    {
        public async Task LookupAsync()
        {
            // Snippet: LookupAsync(string,ReadOptions,IEnumerable<Key>,CallSettings)
            // Additional: LookupAsync(string,ReadOptions,IEnumerable<Key>,CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            ReadOptions readOptions = new ReadOptions();
            IEnumerable<Key> keys = new List<Key>();
            // Make the request
            LookupResponse response = await datastoreClient.LookupAsync(projectId, readOptions, keys);
            // End snippet
        }

        public void Lookup()
        {
            // Snippet: Lookup(string,ReadOptions,IEnumerable<Key>,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            ReadOptions readOptions = new ReadOptions();
            IEnumerable<Key> keys = new List<Key>();
            // Make the request
            LookupResponse response = datastoreClient.Lookup(projectId, readOptions, keys);
            // End snippet
        }

        public async Task LookupAsync_RequestObject()
        {
            // Snippet: LookupAsync(LookupRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            LookupRequest request = new LookupRequest
            {
                ProjectId = "",
                Keys = { },
            };
            // Make the request
            LookupResponse response = await datastoreClient.LookupAsync(request);
            // End snippet
        }

        public void Lookup_RequestObject()
        {
            // Snippet: Lookup(LookupRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            LookupRequest request = new LookupRequest
            {
                ProjectId = "",
                Keys = { },
            };
            // Make the request
            LookupResponse response = datastoreClient.Lookup(request);
            // End snippet
        }

        public async Task RunQueryAsync_RequestObject()
        {
            // Snippet: RunQueryAsync(RunQueryRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = "",
                PartitionId = new PartitionId(),
            };
            // Make the request
            RunQueryResponse response = await datastoreClient.RunQueryAsync(request);
            // End snippet
        }

        public void RunQuery_RequestObject()
        {
            // Snippet: RunQuery(RunQueryRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            RunQueryRequest request = new RunQueryRequest
            {
                ProjectId = "",
                PartitionId = new PartitionId(),
            };
            // Make the request
            RunQueryResponse response = datastoreClient.RunQuery(request);
            // End snippet
        }

        public async Task BeginTransactionAsync()
        {
            // Snippet: BeginTransactionAsync(string,CallSettings)
            // Additional: BeginTransactionAsync(string,CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            BeginTransactionResponse response = await datastoreClient.BeginTransactionAsync(projectId);
            // End snippet
        }

        public void BeginTransaction()
        {
            // Snippet: BeginTransaction(string,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            BeginTransactionResponse response = datastoreClient.BeginTransaction(projectId);
            // End snippet
        }

        public async Task BeginTransactionAsync_RequestObject()
        {
            // Snippet: BeginTransactionAsync(BeginTransactionRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = "",
            };
            // Make the request
            BeginTransactionResponse response = await datastoreClient.BeginTransactionAsync(request);
            // End snippet
        }

        public void BeginTransaction_RequestObject()
        {
            // Snippet: BeginTransaction(BeginTransactionRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = "",
            };
            // Make the request
            BeginTransactionResponse response = datastoreClient.BeginTransaction(request);
            // End snippet
        }

        public async Task CommitAsync1()
        {
            // Snippet: CommitAsync(string,CommitRequest.Types.Mode,ByteString,IEnumerable<Mutation>,CallSettings)
            // Additional: CommitAsync(string,CommitRequest.Types.Mode,ByteString,IEnumerable<Mutation>,CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            ByteString transaction = ByteString.CopyFromUtf8("");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            CommitResponse response = await datastoreClient.CommitAsync(projectId, mode, transaction, mutations);
            // End snippet
        }

        public void Commit1()
        {
            // Snippet: Commit(string,CommitRequest.Types.Mode,ByteString,IEnumerable<Mutation>,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            ByteString transaction = ByteString.CopyFromUtf8("");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            CommitResponse response = datastoreClient.Commit(projectId, mode, transaction, mutations);
            // End snippet
        }

        public async Task CommitAsync2()
        {
            // Snippet: CommitAsync(string,CommitRequest.Types.Mode,IEnumerable<Mutation>,CallSettings)
            // Additional: CommitAsync(string,CommitRequest.Types.Mode,IEnumerable<Mutation>,CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            CommitResponse response = await datastoreClient.CommitAsync(projectId, mode, mutations);
            // End snippet
        }

        public void Commit2()
        {
            // Snippet: Commit(string,CommitRequest.Types.Mode,IEnumerable<Mutation>,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            CommitResponse response = datastoreClient.Commit(projectId, mode, mutations);
            // End snippet
        }

        public async Task CommitAsync_RequestObject()
        {
            // Snippet: CommitAsync(CommitRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                ProjectId = "",
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { },
            };
            // Make the request
            CommitResponse response = await datastoreClient.CommitAsync(request);
            // End snippet
        }

        public void Commit_RequestObject()
        {
            // Snippet: Commit(CommitRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                ProjectId = "",
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { },
            };
            // Make the request
            CommitResponse response = datastoreClient.Commit(request);
            // End snippet
        }

        public async Task RollbackAsync()
        {
            // Snippet: RollbackAsync(string,ByteString,CallSettings)
            // Additional: RollbackAsync(string,ByteString,CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            ByteString transaction = ByteString.CopyFromUtf8("");
            // Make the request
            RollbackResponse response = await datastoreClient.RollbackAsync(projectId, transaction);
            // End snippet
        }

        public void Rollback()
        {
            // Snippet: Rollback(string,ByteString,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            ByteString transaction = ByteString.CopyFromUtf8("");
            // Make the request
            RollbackResponse response = datastoreClient.Rollback(projectId, transaction);
            // End snippet
        }

        public async Task RollbackAsync_RequestObject()
        {
            // Snippet: RollbackAsync(RollbackRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                ProjectId = "",
                Transaction = ByteString.CopyFromUtf8(""),
            };
            // Make the request
            RollbackResponse response = await datastoreClient.RollbackAsync(request);
            // End snippet
        }

        public void Rollback_RequestObject()
        {
            // Snippet: Rollback(RollbackRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                ProjectId = "",
                Transaction = ByteString.CopyFromUtf8(""),
            };
            // Make the request
            RollbackResponse response = datastoreClient.Rollback(request);
            // End snippet
        }

        public async Task AllocateIdsAsync()
        {
            // Snippet: AllocateIdsAsync(string,IEnumerable<Key>,CallSettings)
            // Additional: AllocateIdsAsync(string,IEnumerable<Key>,CancellationToken)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            IEnumerable<Key> keys = new List<Key>();
            // Make the request
            AllocateIdsResponse response = await datastoreClient.AllocateIdsAsync(projectId, keys);
            // End snippet
        }

        public void AllocateIds()
        {
            // Snippet: AllocateIds(string,IEnumerable<Key>,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            IEnumerable<Key> keys = new List<Key>();
            // Make the request
            AllocateIdsResponse response = datastoreClient.AllocateIds(projectId, keys);
            // End snippet
        }

        public async Task AllocateIdsAsync_RequestObject()
        {
            // Snippet: AllocateIdsAsync(AllocateIdsRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = await DatastoreClient.CreateAsync();
            // Initialize request argument(s)
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                ProjectId = "",
                Keys = { },
            };
            // Make the request
            AllocateIdsResponse response = await datastoreClient.AllocateIdsAsync(request);
            // End snippet
        }

        public void AllocateIds_RequestObject()
        {
            // Snippet: AllocateIds(AllocateIdsRequest,CallSettings)
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                ProjectId = "",
                Keys = { },
            };
            // Make the request
            AllocateIdsResponse response = datastoreClient.AllocateIds(request);
            // End snippet
        }

    }
}
