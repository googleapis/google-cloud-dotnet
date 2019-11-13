// Copyright 2019 Google LLC
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

namespace Google.Cloud.Bigtable.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Bigtable.Common.V2;
    using apis = Google.Cloud.Bigtable.V2;
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

    /// <summary>Generated snippets</summary>
    public class GeneratedBigtableServiceApiClientSnippets
    {
        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRows()
        {
            // Snippet: ReadRows(ReadRowsRequest,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument
            ReadRowsRequest request = new ReadRowsRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request, returning a streaming response
            BigtableServiceApiClient.ReadRowsStream streamingResponse = bigtableServiceApiClient.ReadRows(request);

            // Read streaming responses from server until complete
            IAsyncEnumerator<ReadRowsResponse> responseStream = streamingResponse.ResponseStream;
            while (await responseStream.MoveNext())
            {
                ReadRowsResponse response = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SampleRowKeys</summary>
        public async Task SampleRowKeys()
        {
            // Snippet: SampleRowKeys(SampleRowKeysRequest,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument
            SampleRowKeysRequest request = new SampleRowKeysRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request, returning a streaming response
            BigtableServiceApiClient.SampleRowKeysStream streamingResponse = bigtableServiceApiClient.SampleRowKeys(request);

            // Read streaming responses from server until complete
            IAsyncEnumerator<SampleRowKeysResponse> responseStream = streamingResponse.ResponseStream;
            while (await responseStream.MoveNext())
            {
                SampleRowKeysResponse response = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRowAsync1()
        {
            // Snippet: MutateRowAsync(TableName,ByteString,IEnumerable<Mutation>,CallSettings)
            // Additional: MutateRowAsync(TableName,ByteString,IEnumerable<Mutation>,CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow1()
        {
            // Snippet: MutateRow(TableName,ByteString,IEnumerable<Mutation>,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            MutateRowResponse response = bigtableServiceApiClient.MutateRow(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRowAsync2()
        {
            // Snippet: MutateRowAsync(TableName,ByteString,IEnumerable<Mutation>,string,CallSettings)
            // Additional: MutateRowAsync(TableName,ByteString,IEnumerable<Mutation>,string,CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new List<Mutation>();
            string appProfileId = "";
            // Make the request
            MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(tableName, rowKey, mutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow2()
        {
            // Snippet: MutateRow(TableName,ByteString,IEnumerable<Mutation>,string,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new List<Mutation>();
            string appProfileId = "";
            // Make the request
            MutateRowResponse response = bigtableServiceApiClient.MutateRow(tableName, rowKey, mutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRowAsync_RequestObject()
        {
            // Snippet: MutateRowAsync(MutateRowRequest,CallSettings)
            // Additional: MutateRowAsync(MutateRowRequest,CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Mutations = { },
            };
            // Make the request
            MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow_RequestObject()
        {
            // Snippet: MutateRow(MutateRowRequest,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Mutations = { },
            };
            // Make the request
            MutateRowResponse response = bigtableServiceApiClient.MutateRow(request);
            // End snippet
        }

        /// <summary>Snippet for MutateRows</summary>
        public async Task MutateRows()
        {
            // Snippet: MutateRows(MutateRowsRequest,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument
            MutateRowsRequest request = new MutateRowsRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Entries = { },
            };
            // Make the request, returning a streaming response
            BigtableServiceApiClient.MutateRowsStream streamingResponse = bigtableServiceApiClient.MutateRows(request);

            // Read streaming responses from server until complete
            IAsyncEnumerator<MutateRowsResponse> responseStream = streamingResponse.ResponseStream;
            while (await responseStream.MoveNext())
            {
                MutateRowsResponse response = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRowAsync1()
        {
            // Snippet: CheckAndMutateRowAsync(TableName,ByteString,RowFilter,IEnumerable<Mutation>,IEnumerable<Mutation>,CallSettings)
            // Additional: CheckAndMutateRowAsync(TableName,ByteString,RowFilter,IEnumerable<Mutation>,IEnumerable<Mutation>,CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new List<Mutation>();
            IEnumerable<Mutation> falseMutations = new List<Mutation>();
            // Make the request
            CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow1()
        {
            // Snippet: CheckAndMutateRow(TableName,ByteString,RowFilter,IEnumerable<Mutation>,IEnumerable<Mutation>,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new List<Mutation>();
            IEnumerable<Mutation> falseMutations = new List<Mutation>();
            // Make the request
            CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRowAsync2()
        {
            // Snippet: CheckAndMutateRowAsync(TableName,ByteString,RowFilter,IEnumerable<Mutation>,IEnumerable<Mutation>,string,CallSettings)
            // Additional: CheckAndMutateRowAsync(TableName,ByteString,RowFilter,IEnumerable<Mutation>,IEnumerable<Mutation>,string,CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new List<Mutation>();
            IEnumerable<Mutation> falseMutations = new List<Mutation>();
            string appProfileId = "";
            // Make the request
            CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow2()
        {
            // Snippet: CheckAndMutateRow(TableName,ByteString,RowFilter,IEnumerable<Mutation>,IEnumerable<Mutation>,string,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new List<Mutation>();
            IEnumerable<Mutation> falseMutations = new List<Mutation>();
            string appProfileId = "";
            // Make the request
            CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRowAsync_RequestObject()
        {
            // Snippet: CheckAndMutateRowAsync(CheckAndMutateRowRequest,CallSettings)
            // Additional: CheckAndMutateRowAsync(CheckAndMutateRowRequest,CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
            };
            // Make the request
            CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow_RequestObject()
        {
            // Snippet: CheckAndMutateRow(CheckAndMutateRowRequest,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
            };
            // Make the request
            CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(request);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRowAsync1()
        {
            // Snippet: ReadModifyWriteRowAsync(TableName,ByteString,IEnumerable<ReadModifyWriteRule>,CallSettings)
            // Additional: ReadModifyWriteRowAsync(TableName,ByteString,IEnumerable<ReadModifyWriteRule>,CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new List<ReadModifyWriteRule>();
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow1()
        {
            // Snippet: ReadModifyWriteRow(TableName,ByteString,IEnumerable<ReadModifyWriteRule>,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new List<ReadModifyWriteRule>();
            // Make the request
            ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRowAsync2()
        {
            // Snippet: ReadModifyWriteRowAsync(TableName,ByteString,IEnumerable<ReadModifyWriteRule>,string,CallSettings)
            // Additional: ReadModifyWriteRowAsync(TableName,ByteString,IEnumerable<ReadModifyWriteRule>,string,CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new List<ReadModifyWriteRule>();
            string appProfileId = "";
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(tableName, rowKey, rules, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow2()
        {
            // Snippet: ReadModifyWriteRow(TableName,ByteString,IEnumerable<ReadModifyWriteRule>,string,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new List<ReadModifyWriteRule>();
            string appProfileId = "";
            // Make the request
            ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(tableName, rowKey, rules, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRowAsync_RequestObject()
        {
            // Snippet: ReadModifyWriteRowAsync(ReadModifyWriteRowRequest,CallSettings)
            // Additional: ReadModifyWriteRowAsync(ReadModifyWriteRowRequest,CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Rules = { },
            };
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow_RequestObject()
        {
            // Snippet: ReadModifyWriteRow(ReadModifyWriteRowRequest,CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Rules = { },
            };
            // Make the request
            ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(request);
            // End snippet
        }

    }
}
