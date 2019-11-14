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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Bigtable.Common.V2;
    using Google.Protobuf;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedBigtableServiceApiClientSnippets
    {
        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRows_RequestObject()
        {
            // Snippet: ReadRows(ReadRowsRequest, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            ReadRowsRequest request = new ReadRowsRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Rows = new RowSet(),
                Filter = new RowFilter(),
                RowsLimit = 0L,
                AppProfileId = "",
            };
            // Make the request, returning a streaming response
            BigtableServiceApiClient.ReadRowsStream response = bigtableServiceApiClient.ReadRows(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRows1()
        {
            // Snippet: ReadRows(string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request, returning a streaming response
            BigtableServiceApiClient.ReadRowsStream response = bigtableServiceApiClient.ReadRows(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRows1_ResourceNames()
        {
            // Snippet: ReadRows(TableName, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request, returning a streaming response
            BigtableServiceApiClient.ReadRowsStream response = bigtableServiceApiClient.ReadRows(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRows2()
        {
            // Snippet: ReadRows(string, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            string appProfileId = "";
            // Make the request, returning a streaming response
            BigtableServiceApiClient.ReadRowsStream response = bigtableServiceApiClient.ReadRows(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRows2_ResourceNames()
        {
            // Snippet: ReadRows(TableName, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string appProfileId = "";
            // Make the request, returning a streaming response
            BigtableServiceApiClient.ReadRowsStream response = bigtableServiceApiClient.ReadRows(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SampleRowKeys</summary>
        public async Task SampleRowKeys_RequestObject()
        {
            // Snippet: SampleRowKeys(SampleRowKeysRequest, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            SampleRowKeysRequest request = new SampleRowKeysRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                AppProfileId = "",
            };
            // Make the request, returning a streaming response
            BigtableServiceApiClient.SampleRowKeysStream response = bigtableServiceApiClient.SampleRowKeys(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<SampleRowKeysResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                SampleRowKeysResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SampleRowKeys</summary>
        public async Task SampleRowKeys1()
        {
            // Snippet: SampleRowKeys(string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request, returning a streaming response
            BigtableServiceApiClient.SampleRowKeysStream response = bigtableServiceApiClient.SampleRowKeys(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<SampleRowKeysResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                SampleRowKeysResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SampleRowKeys</summary>
        public async Task SampleRowKeys1_ResourceNames()
        {
            // Snippet: SampleRowKeys(TableName, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request, returning a streaming response
            BigtableServiceApiClient.SampleRowKeysStream response = bigtableServiceApiClient.SampleRowKeys(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<SampleRowKeysResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                SampleRowKeysResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SampleRowKeys</summary>
        public async Task SampleRowKeys2()
        {
            // Snippet: SampleRowKeys(string, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            string appProfileId = "";
            // Make the request, returning a streaming response
            BigtableServiceApiClient.SampleRowKeysStream response = bigtableServiceApiClient.SampleRowKeys(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<SampleRowKeysResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                SampleRowKeysResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SampleRowKeys</summary>
        public async Task SampleRowKeys2_ResourceNames()
        {
            // Snippet: SampleRowKeys(TableName, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string appProfileId = "";
            // Make the request, returning a streaming response
            BigtableServiceApiClient.SampleRowKeysStream response = bigtableServiceApiClient.SampleRowKeys(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<SampleRowKeysResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                SampleRowKeysResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow_RequestObject()
        {
            // Snippet: MutateRow(MutateRowRequest, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Mutations = { new Mutation(), },
                AppProfileId = "",
            };
            // Make the request
            MutateRowResponse response = bigtableServiceApiClient.MutateRow(request);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRowAsync_RequestObject()
        {
            // Snippet: MutateRowAsync(MutateRowRequest, CallSettings)
            // Additional: MutateRowAsync(MutateRowRequest, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Mutations = { new Mutation(), },
                AppProfileId = "",
            };
            // Make the request
            MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow1()
        {
            // Snippet: MutateRow(string, ByteString, IEnumerable<Mutation>, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            MutateRowResponse response = bigtableServiceApiClient.MutateRow(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRow1Async()
        {
            // Snippet: MutateRowAsync(string, ByteString, IEnumerable<Mutation>, CallSettings)
            // Additional: MutateRowAsync(string, ByteString, IEnumerable<Mutation>, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow1_ResourceNames()
        {
            // Snippet: MutateRow(TableName, ByteString, IEnumerable<Mutation>, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            MutateRowResponse response = bigtableServiceApiClient.MutateRow(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRow1Async_ResourceNames()
        {
            // Snippet: MutateRowAsync(TableName, ByteString, IEnumerable<Mutation>, CallSettings)
            // Additional: MutateRowAsync(TableName, ByteString, IEnumerable<Mutation>, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow2()
        {
            // Snippet: MutateRow(string, ByteString, IEnumerable<Mutation>, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            string appProfileId = "";
            // Make the request
            MutateRowResponse response = bigtableServiceApiClient.MutateRow(tableName, rowKey, mutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRow2Async()
        {
            // Snippet: MutateRowAsync(string, ByteString, IEnumerable<Mutation>, string, CallSettings)
            // Additional: MutateRowAsync(string, ByteString, IEnumerable<Mutation>, string, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            string appProfileId = "";
            // Make the request
            MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(tableName, rowKey, mutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow2_ResourceNames()
        {
            // Snippet: MutateRow(TableName, ByteString, IEnumerable<Mutation>, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            string appProfileId = "";
            // Make the request
            MutateRowResponse response = bigtableServiceApiClient.MutateRow(tableName, rowKey, mutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRow2Async_ResourceNames()
        {
            // Snippet: MutateRowAsync(TableName, ByteString, IEnumerable<Mutation>, string, CallSettings)
            // Additional: MutateRowAsync(TableName, ByteString, IEnumerable<Mutation>, string, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            string appProfileId = "";
            // Make the request
            MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(tableName, rowKey, mutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for MutateRows</summary>
        public async Task MutateRows_RequestObject()
        {
            // Snippet: MutateRows(MutateRowsRequest, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            MutateRowsRequest request = new MutateRowsRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Entries =
                {
                    new MutateRowsRequest.Types.Entry(),
                },
                AppProfileId = "",
            };
            // Make the request, returning a streaming response
            BigtableServiceApiClient.MutateRowsStream response = bigtableServiceApiClient.MutateRows(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<MutateRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                MutateRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for MutateRows</summary>
        public async Task MutateRows1()
        {
            // Snippet: MutateRows(string, IEnumerable<MutateRowsRequest.Types.Entry>, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            IEnumerable<MutateRowsRequest.Types.Entry> entries = new MutateRowsRequest.Types.Entry[]
            {
                new MutateRowsRequest.Types.Entry(),
            };
            // Make the request, returning a streaming response
            BigtableServiceApiClient.MutateRowsStream response = bigtableServiceApiClient.MutateRows(tableName, entries);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<MutateRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                MutateRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for MutateRows</summary>
        public async Task MutateRows1_ResourceNames()
        {
            // Snippet: MutateRows(TableName, IEnumerable<MutateRowsRequest.Types.Entry>, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<MutateRowsRequest.Types.Entry> entries = new MutateRowsRequest.Types.Entry[]
            {
                new MutateRowsRequest.Types.Entry(),
            };
            // Make the request, returning a streaming response
            BigtableServiceApiClient.MutateRowsStream response = bigtableServiceApiClient.MutateRows(tableName, entries);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<MutateRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                MutateRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for MutateRows</summary>
        public async Task MutateRows2()
        {
            // Snippet: MutateRows(string, IEnumerable<MutateRowsRequest.Types.Entry>, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            IEnumerable<MutateRowsRequest.Types.Entry> entries = new MutateRowsRequest.Types.Entry[]
            {
                new MutateRowsRequest.Types.Entry(),
            };
            string appProfileId = "";
            // Make the request, returning a streaming response
            BigtableServiceApiClient.MutateRowsStream response = bigtableServiceApiClient.MutateRows(tableName, entries, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<MutateRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                MutateRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for MutateRows</summary>
        public async Task MutateRows2_ResourceNames()
        {
            // Snippet: MutateRows(TableName, IEnumerable<MutateRowsRequest.Types.Entry>, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<MutateRowsRequest.Types.Entry> entries = new MutateRowsRequest.Types.Entry[]
            {
                new MutateRowsRequest.Types.Entry(),
            };
            string appProfileId = "";
            // Make the request, returning a streaming response
            BigtableServiceApiClient.MutateRowsStream response = bigtableServiceApiClient.MutateRows(tableName, entries, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<MutateRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                MutateRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow_RequestObject()
        {
            // Snippet: CheckAndMutateRow(CheckAndMutateRowRequest, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
                AppProfileId = "",
            };
            // Make the request
            CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(request);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRowAsync_RequestObject()
        {
            // Snippet: CheckAndMutateRowAsync(CheckAndMutateRowRequest, CallSettings)
            // Additional: CheckAndMutateRowAsync(CheckAndMutateRowRequest, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                TrueMutations = { new Mutation(), },
                FalseMutations = { new Mutation(), },
                PredicateFilter = new RowFilter(),
                AppProfileId = "",
            };
            // Make the request
            CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow1()
        {
            // Snippet: CheckAndMutateRow(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new Mutation[] { new Mutation(), };
            IEnumerable<Mutation> falseMutations = new Mutation[] { new Mutation(), };
            // Make the request
            CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRow1Async()
        {
            // Snippet: CheckAndMutateRowAsync(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CallSettings)
            // Additional: CheckAndMutateRowAsync(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new Mutation[] { new Mutation(), };
            IEnumerable<Mutation> falseMutations = new Mutation[] { new Mutation(), };
            // Make the request
            CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow1_ResourceNames()
        {
            // Snippet: CheckAndMutateRow(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new Mutation[] { new Mutation(), };
            IEnumerable<Mutation> falseMutations = new Mutation[] { new Mutation(), };
            // Make the request
            CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRow1Async_ResourceNames()
        {
            // Snippet: CheckAndMutateRowAsync(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CallSettings)
            // Additional: CheckAndMutateRowAsync(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new Mutation[] { new Mutation(), };
            IEnumerable<Mutation> falseMutations = new Mutation[] { new Mutation(), };
            // Make the request
            CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow2()
        {
            // Snippet: CheckAndMutateRow(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new Mutation[] { new Mutation(), };
            IEnumerable<Mutation> falseMutations = new Mutation[] { new Mutation(), };
            string appProfileId = "";
            // Make the request
            CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRow2Async()
        {
            // Snippet: CheckAndMutateRowAsync(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CallSettings)
            // Additional: CheckAndMutateRowAsync(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new Mutation[] { new Mutation(), };
            IEnumerable<Mutation> falseMutations = new Mutation[] { new Mutation(), };
            string appProfileId = "";
            // Make the request
            CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow2_ResourceNames()
        {
            // Snippet: CheckAndMutateRow(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new Mutation[] { new Mutation(), };
            IEnumerable<Mutation> falseMutations = new Mutation[] { new Mutation(), };
            string appProfileId = "";
            // Make the request
            CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRow2Async_ResourceNames()
        {
            // Snippet: CheckAndMutateRowAsync(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CallSettings)
            // Additional: CheckAndMutateRowAsync(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new Mutation[] { new Mutation(), };
            IEnumerable<Mutation> falseMutations = new Mutation[] { new Mutation(), };
            string appProfileId = "";
            // Make the request
            CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow_RequestObject()
        {
            // Snippet: ReadModifyWriteRow(ReadModifyWriteRowRequest, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
                AppProfileId = "",
            };
            // Make the request
            ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(request);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRowAsync_RequestObject()
        {
            // Snippet: ReadModifyWriteRowAsync(ReadModifyWriteRowRequest, CallSettings)
            // Additional: ReadModifyWriteRowAsync(ReadModifyWriteRowRequest, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
                AppProfileId = "",
            };
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow1()
        {
            // Snippet: ReadModifyWriteRow(string, ByteString, IEnumerable<ReadModifyWriteRule>, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new ReadModifyWriteRule[]
            {
                new ReadModifyWriteRule(),
            };
            // Make the request
            ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRow1Async()
        {
            // Snippet: ReadModifyWriteRowAsync(string, ByteString, IEnumerable<ReadModifyWriteRule>, CallSettings)
            // Additional: ReadModifyWriteRowAsync(string, ByteString, IEnumerable<ReadModifyWriteRule>, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new ReadModifyWriteRule[]
            {
                new ReadModifyWriteRule(),
            };
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow1_ResourceNames()
        {
            // Snippet: ReadModifyWriteRow(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new ReadModifyWriteRule[]
            {
                new ReadModifyWriteRule(),
            };
            // Make the request
            ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRow1Async_ResourceNames()
        {
            // Snippet: ReadModifyWriteRowAsync(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, CallSettings)
            // Additional: ReadModifyWriteRowAsync(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new ReadModifyWriteRule[]
            {
                new ReadModifyWriteRule(),
            };
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow2()
        {
            // Snippet: ReadModifyWriteRow(string, ByteString, IEnumerable<ReadModifyWriteRule>, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new ReadModifyWriteRule[]
            {
                new ReadModifyWriteRule(),
            };
            string appProfileId = "";
            // Make the request
            ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(tableName, rowKey, rules, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRow2Async()
        {
            // Snippet: ReadModifyWriteRowAsync(string, ByteString, IEnumerable<ReadModifyWriteRule>, string, CallSettings)
            // Additional: ReadModifyWriteRowAsync(string, ByteString, IEnumerable<ReadModifyWriteRule>, string, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new ReadModifyWriteRule[]
            {
                new ReadModifyWriteRule(),
            };
            string appProfileId = "";
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(tableName, rowKey, rules, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow2_ResourceNames()
        {
            // Snippet: ReadModifyWriteRow(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, string, CallSettings)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new ReadModifyWriteRule[]
            {
                new ReadModifyWriteRule(),
            };
            string appProfileId = "";
            // Make the request
            ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(tableName, rowKey, rules, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRow2Async_ResourceNames()
        {
            // Snippet: ReadModifyWriteRowAsync(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, string, CallSettings)
            // Additional: ReadModifyWriteRowAsync(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, string, CancellationToken)
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new ReadModifyWriteRule[]
            {
                new ReadModifyWriteRule(),
            };
            string appProfileId = "";
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(tableName, rowKey, rules, appProfileId);
            // End snippet
        }
    }
}
