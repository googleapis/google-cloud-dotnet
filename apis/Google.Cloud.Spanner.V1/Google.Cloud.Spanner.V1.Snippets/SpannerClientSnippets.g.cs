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
using Google.Cloud.Spanner.V1;
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

namespace Google.Cloud.Spanner.V1.Snippets
{
    public class GeneratedSpannerClientSnippets
    {
        public async Task CreateSessionAsync()
        {
            // Snippet: CreateSessionAsync(DatabaseName,CallSettings)
            // Additional: CreateSessionAsync(DatabaseName,CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            Session response = await spannerClient.CreateSessionAsync(database);
            // End snippet
        }

        public void CreateSession()
        {
            // Snippet: CreateSession(DatabaseName,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            Session response = spannerClient.CreateSession(database);
            // End snippet
        }

        public async Task CreateSessionAsync_RequestObject()
        {
            // Snippet: CreateSessionAsync(CreateSessionRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            Session response = await spannerClient.CreateSessionAsync(request);
            // End snippet
        }

        public void CreateSession_RequestObject()
        {
            // Snippet: CreateSession(CreateSessionRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            Session response = spannerClient.CreateSession(request);
            // End snippet
        }

        public async Task GetSessionAsync()
        {
            // Snippet: GetSessionAsync(SessionName,CallSettings)
            // Additional: GetSessionAsync(SessionName,CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            Session response = await spannerClient.GetSessionAsync(name);
            // End snippet
        }

        public void GetSession()
        {
            // Snippet: GetSession(SessionName,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            Session response = spannerClient.GetSession(name);
            // End snippet
        }

        public async Task GetSessionAsync_RequestObject()
        {
            // Snippet: GetSessionAsync(GetSessionRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // Make the request
            Session response = await spannerClient.GetSessionAsync(request);
            // End snippet
        }

        public void GetSession_RequestObject()
        {
            // Snippet: GetSession(GetSessionRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // Make the request
            Session response = spannerClient.GetSession(request);
            // End snippet
        }

        public async Task DeleteSessionAsync()
        {
            // Snippet: DeleteSessionAsync(SessionName,CallSettings)
            // Additional: DeleteSessionAsync(SessionName,CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            await spannerClient.DeleteSessionAsync(name);
            // End snippet
        }

        public void DeleteSession()
        {
            // Snippet: DeleteSession(SessionName,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            spannerClient.DeleteSession(name);
            // End snippet
        }

        public async Task DeleteSessionAsync_RequestObject()
        {
            // Snippet: DeleteSessionAsync(DeleteSessionRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // Make the request
            await spannerClient.DeleteSessionAsync(request);
            // End snippet
        }

        public void DeleteSession_RequestObject()
        {
            // Snippet: DeleteSession(DeleteSessionRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // Make the request
            spannerClient.DeleteSession(request);
            // End snippet
        }

        public async Task ExecuteSqlAsync_RequestObject()
        {
            // Snippet: ExecuteSqlAsync(ExecuteSqlRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Sql = "",
            };
            // Make the request
            ResultSet response = await spannerClient.ExecuteSqlAsync(request);
            // End snippet
        }

        public void ExecuteSql_RequestObject()
        {
            // Snippet: ExecuteSql(ExecuteSqlRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Sql = "",
            };
            // Make the request
            ResultSet response = spannerClient.ExecuteSql(request);
            // End snippet
        }

        public async Task ReadAsync_RequestObject()
        {
            // Snippet: ReadAsync(ReadRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            ReadRequest request = new ReadRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Table = "",
                Columns = { },
                KeySet = new KeySet(),
            };
            // Make the request
            ResultSet response = await spannerClient.ReadAsync(request);
            // End snippet
        }

        public void Read_RequestObject()
        {
            // Snippet: Read(ReadRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            ReadRequest request = new ReadRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Table = "",
                Columns = { },
                KeySet = new KeySet(),
            };
            // Make the request
            ResultSet response = spannerClient.Read(request);
            // End snippet
        }

        public async Task BeginTransactionAsync()
        {
            // Snippet: BeginTransactionAsync(SessionName,TransactionOptions,CallSettings)
            // Additional: BeginTransactionAsync(SessionName,TransactionOptions,CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions options = new TransactionOptions();
            // Make the request
            Transaction response = await spannerClient.BeginTransactionAsync(session, options);
            // End snippet
        }

        public void BeginTransaction()
        {
            // Snippet: BeginTransaction(SessionName,TransactionOptions,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions options = new TransactionOptions();
            // Make the request
            Transaction response = spannerClient.BeginTransaction(session, options);
            // End snippet
        }

        public async Task BeginTransactionAsync_RequestObject()
        {
            // Snippet: BeginTransactionAsync(BeginTransactionRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            // Make the request
            Transaction response = await spannerClient.BeginTransactionAsync(request);
            // End snippet
        }

        public void BeginTransaction_RequestObject()
        {
            // Snippet: BeginTransaction(BeginTransactionRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            // Make the request
            Transaction response = spannerClient.BeginTransaction(request);
            // End snippet
        }

        public async Task CommitAsync1()
        {
            // Snippet: CommitAsync(SessionName,ByteString,IEnumerable<Mutation>,CallSettings)
            // Additional: CommitAsync(SessionName,ByteString,IEnumerable<Mutation>,CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.CopyFromUtf8("");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            CommitResponse response = await spannerClient.CommitAsync(session, transactionId, mutations);
            // End snippet
        }

        public void Commit1()
        {
            // Snippet: Commit(SessionName,ByteString,IEnumerable<Mutation>,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.CopyFromUtf8("");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            CommitResponse response = spannerClient.Commit(session, transactionId, mutations);
            // End snippet
        }

        public async Task CommitAsync2()
        {
            // Snippet: CommitAsync(SessionName,TransactionOptions,IEnumerable<Mutation>,CallSettings)
            // Additional: CommitAsync(SessionName,TransactionOptions,IEnumerable<Mutation>,CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions singleUseTransaction = new TransactionOptions();
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            CommitResponse response = await spannerClient.CommitAsync(session, singleUseTransaction, mutations);
            // End snippet
        }

        public void Commit2()
        {
            // Snippet: Commit(SessionName,TransactionOptions,IEnumerable<Mutation>,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions singleUseTransaction = new TransactionOptions();
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            CommitResponse response = spannerClient.Commit(session, singleUseTransaction, mutations);
            // End snippet
        }

        public async Task CommitAsync_RequestObject()
        {
            // Snippet: CommitAsync(CommitRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Mutations = { },
            };
            // Make the request
            CommitResponse response = await spannerClient.CommitAsync(request);
            // End snippet
        }

        public void Commit_RequestObject()
        {
            // Snippet: Commit(CommitRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Mutations = { },
            };
            // Make the request
            CommitResponse response = spannerClient.Commit(request);
            // End snippet
        }

        public async Task RollbackAsync()
        {
            // Snippet: RollbackAsync(SessionName,ByteString,CallSettings)
            // Additional: RollbackAsync(SessionName,ByteString,CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.CopyFromUtf8("");
            // Make the request
            await spannerClient.RollbackAsync(session, transactionId);
            // End snippet
        }

        public void Rollback()
        {
            // Snippet: Rollback(SessionName,ByteString,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.CopyFromUtf8("");
            // Make the request
            spannerClient.Rollback(session, transactionId);
            // End snippet
        }

        public async Task RollbackAsync_RequestObject()
        {
            // Snippet: RollbackAsync(RollbackRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.CopyFromUtf8(""),
            };
            // Make the request
            await spannerClient.RollbackAsync(request);
            // End snippet
        }

        public void Rollback_RequestObject()
        {
            // Snippet: Rollback(RollbackRequest,CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.CopyFromUtf8(""),
            };
            // Make the request
            spannerClient.Rollback(request);
            // End snippet
        }

    }
}
