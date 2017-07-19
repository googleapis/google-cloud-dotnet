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
using Google.Cloud.Bigtable.V2;
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

namespace Google.Cloud.Bigtable.V2.Snippets
{
    public class GeneratedBigtableClientSnippets
    {
        public async Task MutateRowAsync()
        {
            // Snippet: MutateRowAsync(string,ByteString,IEnumerable<Mutation>,CallSettings)
            // Additional: MutateRowAsync(string,ByteString,IEnumerable<Mutation>,CancellationToken)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            string formattedTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            ByteString rowKey = ByteString.CopyFromUtf8("");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            MutateRowResponse response = await bigtableClient.MutateRowAsync(formattedTableName, rowKey, mutations);
            // End snippet
        }

        public void MutateRow()
        {
            // Snippet: MutateRow(string,ByteString,IEnumerable<Mutation>,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            string formattedTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            ByteString rowKey = ByteString.CopyFromUtf8("");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            MutateRowResponse response = bigtableClient.MutateRow(formattedTableName, rowKey, mutations);
            // End snippet
        }

        public async Task MutateRowAsync_RequestObject()
        {
            // Snippet: MutateRowAsync(MutateRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            MutateRowRequest request = new MutateRowRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                RowKey = ByteString.CopyFromUtf8(""),
                Mutations = { },
            };
            // Make the request
            MutateRowResponse response = await bigtableClient.MutateRowAsync(request);
            // End snippet
        }

        public void MutateRow_RequestObject()
        {
            // Snippet: MutateRow(MutateRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            MutateRowRequest request = new MutateRowRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                RowKey = ByteString.CopyFromUtf8(""),
                Mutations = { },
            };
            // Make the request
            MutateRowResponse response = bigtableClient.MutateRow(request);
            // End snippet
        }

        public async Task CheckAndMutateRowAsync()
        {
            // Snippet: CheckAndMutateRowAsync(string,ByteString,IEnumerable<Mutation>,IEnumerable<Mutation>,CallSettings)
            // Additional: CheckAndMutateRowAsync(string,ByteString,IEnumerable<Mutation>,IEnumerable<Mutation>,CancellationToken)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            string formattedTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            ByteString rowKey = ByteString.CopyFromUtf8("");
            IEnumerable<Mutation> trueMutations = new List<Mutation>();
            IEnumerable<Mutation> falseMutations = new List<Mutation>();
            // Make the request
            CheckAndMutateRowResponse response = await bigtableClient.CheckAndMutateRowAsync(formattedTableName, rowKey, trueMutations, falseMutations);
            // End snippet
        }

        public void CheckAndMutateRow()
        {
            // Snippet: CheckAndMutateRow(string,ByteString,IEnumerable<Mutation>,IEnumerable<Mutation>,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            string formattedTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            ByteString rowKey = ByteString.CopyFromUtf8("");
            IEnumerable<Mutation> trueMutations = new List<Mutation>();
            IEnumerable<Mutation> falseMutations = new List<Mutation>();
            // Make the request
            CheckAndMutateRowResponse response = bigtableClient.CheckAndMutateRow(formattedTableName, rowKey, trueMutations, falseMutations);
            // End snippet
        }

        public async Task CheckAndMutateRowAsync_RequestObject()
        {
            // Snippet: CheckAndMutateRowAsync(CheckAndMutateRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                RowKey = ByteString.CopyFromUtf8(""),
            };
            // Make the request
            CheckAndMutateRowResponse response = await bigtableClient.CheckAndMutateRowAsync(request);
            // End snippet
        }

        public void CheckAndMutateRow_RequestObject()
        {
            // Snippet: CheckAndMutateRow(CheckAndMutateRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                RowKey = ByteString.CopyFromUtf8(""),
            };
            // Make the request
            CheckAndMutateRowResponse response = bigtableClient.CheckAndMutateRow(request);
            // End snippet
        }

        public async Task ReadModifyWriteRowAsync()
        {
            // Snippet: ReadModifyWriteRowAsync(string,ByteString,IEnumerable<ReadModifyWriteRule>,CallSettings)
            // Additional: ReadModifyWriteRowAsync(string,ByteString,IEnumerable<ReadModifyWriteRule>,CancellationToken)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            string formattedTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            ByteString rowKey = ByteString.CopyFromUtf8("");
            IEnumerable<ReadModifyWriteRule> rules = new List<ReadModifyWriteRule>();
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableClient.ReadModifyWriteRowAsync(formattedTableName, rowKey, rules);
            // End snippet
        }

        public void ReadModifyWriteRow()
        {
            // Snippet: ReadModifyWriteRow(string,ByteString,IEnumerable<ReadModifyWriteRule>,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            string formattedTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            ByteString rowKey = ByteString.CopyFromUtf8("");
            IEnumerable<ReadModifyWriteRule> rules = new List<ReadModifyWriteRule>();
            // Make the request
            ReadModifyWriteRowResponse response = bigtableClient.ReadModifyWriteRow(formattedTableName, rowKey, rules);
            // End snippet
        }

        public async Task ReadModifyWriteRowAsync_RequestObject()
        {
            // Snippet: ReadModifyWriteRowAsync(ReadModifyWriteRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                RowKey = ByteString.CopyFromUtf8(""),
                Rules = { },
            };
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableClient.ReadModifyWriteRowAsync(request);
            // End snippet
        }

        public void ReadModifyWriteRow_RequestObject()
        {
            // Snippet: ReadModifyWriteRow(ReadModifyWriteRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                RowKey = ByteString.CopyFromUtf8(""),
                Rules = { },
            };
            // Make the request
            ReadModifyWriteRowResponse response = bigtableClient.ReadModifyWriteRow(request);
            // End snippet
        }

    }
}
