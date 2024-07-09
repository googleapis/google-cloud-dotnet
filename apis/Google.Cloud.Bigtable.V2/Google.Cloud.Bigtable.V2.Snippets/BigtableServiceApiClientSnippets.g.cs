// Copyright 2024 Google LLC
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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Bigtable.Common.V2;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using gcbv = Google.Cloud.Bigtable.V2;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBigtableServiceApiClientSnippets
    {
        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRowsRequestObject()
        {
            // Snippet: ReadRows(ReadRowsRequest, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            gcbv::ReadRowsRequest request = new gcbv::ReadRowsRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Rows = new gcbv::RowSet(),
                Filter = new gcbv::RowFilter(),
                RowsLimit = 0L,
                AppProfileId = "",
                RequestStatsView = gcbv::ReadRowsRequest.Types.RequestStatsView.Unspecified,
                Reversed = false,
                AuthorizedViewNameAsAuthorizedViewName = gcbv::AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
            };
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ReadRowsStream response = bigtableServiceApiClient.ReadRows(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ReadRowsResponse responseItem = responseStream.Current;
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
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ReadRowsStream response = bigtableServiceApiClient.ReadRows(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ReadRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRows1ResourceNames()
        {
            // Snippet: ReadRows(TableName, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ReadRowsStream response = bigtableServiceApiClient.ReadRows(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ReadRowsResponse responseItem = responseStream.Current;
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
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ReadRowsStream response = bigtableServiceApiClient.ReadRows(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ReadRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRows2ResourceNames()
        {
            // Snippet: ReadRows(TableName, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ReadRowsStream response = bigtableServiceApiClient.ReadRows(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ReadRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ReadRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SampleRowKeys</summary>
        public async Task SampleRowKeysRequestObject()
        {
            // Snippet: SampleRowKeys(SampleRowKeysRequest, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            gcbv::SampleRowKeysRequest request = new gcbv::SampleRowKeysRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                AppProfileId = "",
                AuthorizedViewNameAsAuthorizedViewName = gcbv::AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
            };
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.SampleRowKeysStream response = bigtableServiceApiClient.SampleRowKeys(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::SampleRowKeysResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::SampleRowKeysResponse responseItem = responseStream.Current;
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
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.SampleRowKeysStream response = bigtableServiceApiClient.SampleRowKeys(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::SampleRowKeysResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::SampleRowKeysResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SampleRowKeys</summary>
        public async Task SampleRowKeys1ResourceNames()
        {
            // Snippet: SampleRowKeys(TableName, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.SampleRowKeysStream response = bigtableServiceApiClient.SampleRowKeys(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::SampleRowKeysResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::SampleRowKeysResponse responseItem = responseStream.Current;
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
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.SampleRowKeysStream response = bigtableServiceApiClient.SampleRowKeys(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::SampleRowKeysResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::SampleRowKeysResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SampleRowKeys</summary>
        public async Task SampleRowKeys2ResourceNames()
        {
            // Snippet: SampleRowKeys(TableName, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.SampleRowKeysStream response = bigtableServiceApiClient.SampleRowKeys(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::SampleRowKeysResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::SampleRowKeysResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRowRequestObject()
        {
            // Snippet: MutateRow(MutateRowRequest, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            gcbv::MutateRowRequest request = new gcbv::MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Mutations =
                {
                    new gcbv::Mutation(),
                },
                AppProfileId = "",
                AuthorizedViewNameAsAuthorizedViewName = gcbv::AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
            };
            // Make the request
            gcbv::MutateRowResponse response = bigtableServiceApiClient.MutateRow(request);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRowRequestObjectAsync()
        {
            // Snippet: MutateRowAsync(MutateRowRequest, CallSettings)
            // Additional: MutateRowAsync(MutateRowRequest, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::MutateRowRequest request = new gcbv::MutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Mutations =
                {
                    new gcbv::Mutation(),
                },
                AppProfileId = "",
                AuthorizedViewNameAsAuthorizedViewName = gcbv::AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
            };
            // Make the request
            gcbv::MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow1()
        {
            // Snippet: MutateRow(string, ByteString, IEnumerable<Mutation>, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::Mutation> mutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            // Make the request
            gcbv::MutateRowResponse response = bigtableServiceApiClient.MutateRow(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRow1Async()
        {
            // Snippet: MutateRowAsync(string, ByteString, IEnumerable<Mutation>, CallSettings)
            // Additional: MutateRowAsync(string, ByteString, IEnumerable<Mutation>, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::Mutation> mutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            // Make the request
            gcbv::MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow1ResourceNames()
        {
            // Snippet: MutateRow(TableName, ByteString, IEnumerable<Mutation>, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::Mutation> mutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            // Make the request
            gcbv::MutateRowResponse response = bigtableServiceApiClient.MutateRow(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRow1ResourceNamesAsync()
        {
            // Snippet: MutateRowAsync(TableName, ByteString, IEnumerable<Mutation>, CallSettings)
            // Additional: MutateRowAsync(TableName, ByteString, IEnumerable<Mutation>, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::Mutation> mutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            // Make the request
            gcbv::MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow2()
        {
            // Snippet: MutateRow(string, ByteString, IEnumerable<Mutation>, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::Mutation> mutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::MutateRowResponse response = bigtableServiceApiClient.MutateRow(tableName, rowKey, mutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRow2Async()
        {
            // Snippet: MutateRowAsync(string, ByteString, IEnumerable<Mutation>, string, CallSettings)
            // Additional: MutateRowAsync(string, ByteString, IEnumerable<Mutation>, string, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::Mutation> mutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(tableName, rowKey, mutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow2ResourceNames()
        {
            // Snippet: MutateRow(TableName, ByteString, IEnumerable<Mutation>, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::Mutation> mutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::MutateRowResponse response = bigtableServiceApiClient.MutateRow(tableName, rowKey, mutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRow2ResourceNamesAsync()
        {
            // Snippet: MutateRowAsync(TableName, ByteString, IEnumerable<Mutation>, string, CallSettings)
            // Additional: MutateRowAsync(TableName, ByteString, IEnumerable<Mutation>, string, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::Mutation> mutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::MutateRowResponse response = await bigtableServiceApiClient.MutateRowAsync(tableName, rowKey, mutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for MutateRows</summary>
        public async Task MutateRowsRequestObject()
        {
            // Snippet: MutateRows(MutateRowsRequest, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            gcbv::MutateRowsRequest request = new gcbv::MutateRowsRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Entries =
                {
                    new gcbv::MutateRowsRequest.Types.Entry(),
                },
                AppProfileId = "",
                AuthorizedViewNameAsAuthorizedViewName = gcbv::AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
            };
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.MutateRowsStream response = bigtableServiceApiClient.MutateRows(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::MutateRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::MutateRowsResponse responseItem = responseStream.Current;
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
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            IEnumerable<gcbv::MutateRowsRequest.Types.Entry> entries = new gcbv::MutateRowsRequest.Types.Entry[]
            {
                new gcbv::MutateRowsRequest.Types.Entry(),
            };
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.MutateRowsStream response = bigtableServiceApiClient.MutateRows(tableName, entries);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::MutateRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::MutateRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for MutateRows</summary>
        public async Task MutateRows1ResourceNames()
        {
            // Snippet: MutateRows(TableName, IEnumerable<MutateRowsRequest.Types.Entry>, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<gcbv::MutateRowsRequest.Types.Entry> entries = new gcbv::MutateRowsRequest.Types.Entry[]
            {
                new gcbv::MutateRowsRequest.Types.Entry(),
            };
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.MutateRowsStream response = bigtableServiceApiClient.MutateRows(tableName, entries);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::MutateRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::MutateRowsResponse responseItem = responseStream.Current;
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
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            IEnumerable<gcbv::MutateRowsRequest.Types.Entry> entries = new gcbv::MutateRowsRequest.Types.Entry[]
            {
                new gcbv::MutateRowsRequest.Types.Entry(),
            };
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.MutateRowsStream response = bigtableServiceApiClient.MutateRows(tableName, entries, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::MutateRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::MutateRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for MutateRows</summary>
        public async Task MutateRows2ResourceNames()
        {
            // Snippet: MutateRows(TableName, IEnumerable<MutateRowsRequest.Types.Entry>, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<gcbv::MutateRowsRequest.Types.Entry> entries = new gcbv::MutateRowsRequest.Types.Entry[]
            {
                new gcbv::MutateRowsRequest.Types.Entry(),
            };
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.MutateRowsStream response = bigtableServiceApiClient.MutateRows(tableName, entries, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::MutateRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::MutateRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRowRequestObject()
        {
            // Snippet: CheckAndMutateRow(CheckAndMutateRowRequest, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            gcbv::CheckAndMutateRowRequest request = new gcbv::CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                TrueMutations =
                {
                    new gcbv::Mutation(),
                },
                FalseMutations =
                {
                    new gcbv::Mutation(),
                },
                PredicateFilter = new gcbv::RowFilter(),
                AppProfileId = "",
                AuthorizedViewNameAsAuthorizedViewName = gcbv::AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
            };
            // Make the request
            gcbv::CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(request);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRowRequestObjectAsync()
        {
            // Snippet: CheckAndMutateRowAsync(CheckAndMutateRowRequest, CallSettings)
            // Additional: CheckAndMutateRowAsync(CheckAndMutateRowRequest, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::CheckAndMutateRowRequest request = new gcbv::CheckAndMutateRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                TrueMutations =
                {
                    new gcbv::Mutation(),
                },
                FalseMutations =
                {
                    new gcbv::Mutation(),
                },
                PredicateFilter = new gcbv::RowFilter(),
                AppProfileId = "",
                AuthorizedViewNameAsAuthorizedViewName = gcbv::AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
            };
            // Make the request
            gcbv::CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow1()
        {
            // Snippet: CheckAndMutateRow(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            gcbv::RowFilter predicateFilter = new gcbv::RowFilter();
            IEnumerable<gcbv::Mutation> trueMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            IEnumerable<gcbv::Mutation> falseMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            // Make the request
            gcbv::CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRow1Async()
        {
            // Snippet: CheckAndMutateRowAsync(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CallSettings)
            // Additional: CheckAndMutateRowAsync(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            gcbv::RowFilter predicateFilter = new gcbv::RowFilter();
            IEnumerable<gcbv::Mutation> trueMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            IEnumerable<gcbv::Mutation> falseMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            // Make the request
            gcbv::CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow1ResourceNames()
        {
            // Snippet: CheckAndMutateRow(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            gcbv::RowFilter predicateFilter = new gcbv::RowFilter();
            IEnumerable<gcbv::Mutation> trueMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            IEnumerable<gcbv::Mutation> falseMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            // Make the request
            gcbv::CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRow1ResourceNamesAsync()
        {
            // Snippet: CheckAndMutateRowAsync(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CallSettings)
            // Additional: CheckAndMutateRowAsync(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            gcbv::RowFilter predicateFilter = new gcbv::RowFilter();
            IEnumerable<gcbv::Mutation> trueMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            IEnumerable<gcbv::Mutation> falseMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            // Make the request
            gcbv::CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow2()
        {
            // Snippet: CheckAndMutateRow(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            gcbv::RowFilter predicateFilter = new gcbv::RowFilter();
            IEnumerable<gcbv::Mutation> trueMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            IEnumerable<gcbv::Mutation> falseMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRow2Async()
        {
            // Snippet: CheckAndMutateRowAsync(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CallSettings)
            // Additional: CheckAndMutateRowAsync(string, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            gcbv::RowFilter predicateFilter = new gcbv::RowFilter();
            IEnumerable<gcbv::Mutation> trueMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            IEnumerable<gcbv::Mutation> falseMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow2ResourceNames()
        {
            // Snippet: CheckAndMutateRow(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            gcbv::RowFilter predicateFilter = new gcbv::RowFilter();
            IEnumerable<gcbv::Mutation> trueMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            IEnumerable<gcbv::Mutation> falseMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::CheckAndMutateRowResponse response = bigtableServiceApiClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRow2ResourceNamesAsync()
        {
            // Snippet: CheckAndMutateRowAsync(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CallSettings)
            // Additional: CheckAndMutateRowAsync(TableName, ByteString, RowFilter, IEnumerable<Mutation>, IEnumerable<Mutation>, string, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            gcbv::RowFilter predicateFilter = new gcbv::RowFilter();
            IEnumerable<gcbv::Mutation> trueMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            IEnumerable<gcbv::Mutation> falseMutations = new gcbv::Mutation[]
            {
                new gcbv::Mutation(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::CheckAndMutateRowResponse response = await bigtableServiceApiClient.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for PingAndWarm</summary>
        public void PingAndWarmRequestObject()
        {
            // Snippet: PingAndWarm(PingAndWarmRequest, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            gcbv::PingAndWarmRequest request = new gcbv::PingAndWarmRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "",
            };
            // Make the request
            gcbv::PingAndWarmResponse response = bigtableServiceApiClient.PingAndWarm(request);
            // End snippet
        }

        /// <summary>Snippet for PingAndWarmAsync</summary>
        public async Task PingAndWarmRequestObjectAsync()
        {
            // Snippet: PingAndWarmAsync(PingAndWarmRequest, CallSettings)
            // Additional: PingAndWarmAsync(PingAndWarmRequest, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::PingAndWarmRequest request = new gcbv::PingAndWarmRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "",
            };
            // Make the request
            gcbv::PingAndWarmResponse response = await bigtableServiceApiClient.PingAndWarmAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PingAndWarm</summary>
        public void PingAndWarm1()
        {
            // Snippet: PingAndWarm(string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            gcbv::PingAndWarmResponse response = bigtableServiceApiClient.PingAndWarm(name);
            // End snippet
        }

        /// <summary>Snippet for PingAndWarmAsync</summary>
        public async Task PingAndWarm1Async()
        {
            // Snippet: PingAndWarmAsync(string, CallSettings)
            // Additional: PingAndWarmAsync(string, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            gcbv::PingAndWarmResponse response = await bigtableServiceApiClient.PingAndWarmAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PingAndWarm</summary>
        public void PingAndWarm1ResourceNames()
        {
            // Snippet: PingAndWarm(InstanceName, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            gcbv::PingAndWarmResponse response = bigtableServiceApiClient.PingAndWarm(name);
            // End snippet
        }

        /// <summary>Snippet for PingAndWarmAsync</summary>
        public async Task PingAndWarm1ResourceNamesAsync()
        {
            // Snippet: PingAndWarmAsync(InstanceName, CallSettings)
            // Additional: PingAndWarmAsync(InstanceName, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            gcbv::PingAndWarmResponse response = await bigtableServiceApiClient.PingAndWarmAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PingAndWarm</summary>
        public void PingAndWarm2()
        {
            // Snippet: PingAndWarm(string, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            string appProfileId = "";
            // Make the request
            gcbv::PingAndWarmResponse response = bigtableServiceApiClient.PingAndWarm(name, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for PingAndWarmAsync</summary>
        public async Task PingAndWarm2Async()
        {
            // Snippet: PingAndWarmAsync(string, string, CallSettings)
            // Additional: PingAndWarmAsync(string, string, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            string appProfileId = "";
            // Make the request
            gcbv::PingAndWarmResponse response = await bigtableServiceApiClient.PingAndWarmAsync(name, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for PingAndWarm</summary>
        public void PingAndWarm2ResourceNames()
        {
            // Snippet: PingAndWarm(InstanceName, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string appProfileId = "";
            // Make the request
            gcbv::PingAndWarmResponse response = bigtableServiceApiClient.PingAndWarm(name, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for PingAndWarmAsync</summary>
        public async Task PingAndWarm2ResourceNamesAsync()
        {
            // Snippet: PingAndWarmAsync(InstanceName, string, CallSettings)
            // Additional: PingAndWarmAsync(InstanceName, string, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string appProfileId = "";
            // Make the request
            gcbv::PingAndWarmResponse response = await bigtableServiceApiClient.PingAndWarmAsync(name, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRowRequestObject()
        {
            // Snippet: ReadModifyWriteRow(ReadModifyWriteRowRequest, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            gcbv::ReadModifyWriteRowRequest request = new gcbv::ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Rules =
                {
                    new gcbv::ReadModifyWriteRule(),
                },
                AppProfileId = "",
                AuthorizedViewNameAsAuthorizedViewName = gcbv::AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
            };
            // Make the request
            gcbv::ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(request);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRowRequestObjectAsync()
        {
            // Snippet: ReadModifyWriteRowAsync(ReadModifyWriteRowRequest, CallSettings)
            // Additional: ReadModifyWriteRowAsync(ReadModifyWriteRowRequest, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::ReadModifyWriteRowRequest request = new gcbv::ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Rules =
                {
                    new gcbv::ReadModifyWriteRule(),
                },
                AppProfileId = "",
                AuthorizedViewNameAsAuthorizedViewName = gcbv::AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
            };
            // Make the request
            gcbv::ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow1()
        {
            // Snippet: ReadModifyWriteRow(string, ByteString, IEnumerable<ReadModifyWriteRule>, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::ReadModifyWriteRule> rules = new gcbv::ReadModifyWriteRule[]
            {
                new gcbv::ReadModifyWriteRule(),
            };
            // Make the request
            gcbv::ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRow1Async()
        {
            // Snippet: ReadModifyWriteRowAsync(string, ByteString, IEnumerable<ReadModifyWriteRule>, CallSettings)
            // Additional: ReadModifyWriteRowAsync(string, ByteString, IEnumerable<ReadModifyWriteRule>, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::ReadModifyWriteRule> rules = new gcbv::ReadModifyWriteRule[]
            {
                new gcbv::ReadModifyWriteRule(),
            };
            // Make the request
            gcbv::ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow1ResourceNames()
        {
            // Snippet: ReadModifyWriteRow(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::ReadModifyWriteRule> rules = new gcbv::ReadModifyWriteRule[]
            {
                new gcbv::ReadModifyWriteRule(),
            };
            // Make the request
            gcbv::ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRow1ResourceNamesAsync()
        {
            // Snippet: ReadModifyWriteRowAsync(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, CallSettings)
            // Additional: ReadModifyWriteRowAsync(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::ReadModifyWriteRule> rules = new gcbv::ReadModifyWriteRule[]
            {
                new gcbv::ReadModifyWriteRule(),
            };
            // Make the request
            gcbv::ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow2()
        {
            // Snippet: ReadModifyWriteRow(string, ByteString, IEnumerable<ReadModifyWriteRule>, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::ReadModifyWriteRule> rules = new gcbv::ReadModifyWriteRule[]
            {
                new gcbv::ReadModifyWriteRule(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(tableName, rowKey, rules, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRow2Async()
        {
            // Snippet: ReadModifyWriteRowAsync(string, ByteString, IEnumerable<ReadModifyWriteRule>, string, CallSettings)
            // Additional: ReadModifyWriteRowAsync(string, ByteString, IEnumerable<ReadModifyWriteRule>, string, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::ReadModifyWriteRule> rules = new gcbv::ReadModifyWriteRule[]
            {
                new gcbv::ReadModifyWriteRule(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(tableName, rowKey, rules, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow2ResourceNames()
        {
            // Snippet: ReadModifyWriteRow(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::ReadModifyWriteRule> rules = new gcbv::ReadModifyWriteRule[]
            {
                new gcbv::ReadModifyWriteRule(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::ReadModifyWriteRowResponse response = bigtableServiceApiClient.ReadModifyWriteRow(tableName, rowKey, rules, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRow2ResourceNamesAsync()
        {
            // Snippet: ReadModifyWriteRowAsync(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, string, CallSettings)
            // Additional: ReadModifyWriteRowAsync(TableName, ByteString, IEnumerable<ReadModifyWriteRule>, string, CancellationToken)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = await gcbv::BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.Empty;
            IEnumerable<gcbv::ReadModifyWriteRule> rules = new gcbv::ReadModifyWriteRule[]
            {
                new gcbv::ReadModifyWriteRule(),
            };
            string appProfileId = "";
            // Make the request
            gcbv::ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(tableName, rowKey, rules, appProfileId);
            // End snippet
        }

        /// <summary>Snippet for GenerateInitialChangeStreamPartitions</summary>
        public async Task GenerateInitialChangeStreamPartitionsRequestObject()
        {
            // Snippet: GenerateInitialChangeStreamPartitions(GenerateInitialChangeStreamPartitionsRequest, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            gcbv::GenerateInitialChangeStreamPartitionsRequest request = new gcbv::GenerateInitialChangeStreamPartitionsRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                AppProfileId = "",
            };
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream response = bigtableServiceApiClient.GenerateInitialChangeStreamPartitions(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::GenerateInitialChangeStreamPartitionsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::GenerateInitialChangeStreamPartitionsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for GenerateInitialChangeStreamPartitions</summary>
        public async Task GenerateInitialChangeStreamPartitions1()
        {
            // Snippet: GenerateInitialChangeStreamPartitions(string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream response = bigtableServiceApiClient.GenerateInitialChangeStreamPartitions(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::GenerateInitialChangeStreamPartitionsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::GenerateInitialChangeStreamPartitionsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for GenerateInitialChangeStreamPartitions</summary>
        public async Task GenerateInitialChangeStreamPartitions1ResourceNames()
        {
            // Snippet: GenerateInitialChangeStreamPartitions(TableName, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream response = bigtableServiceApiClient.GenerateInitialChangeStreamPartitions(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::GenerateInitialChangeStreamPartitionsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::GenerateInitialChangeStreamPartitionsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for GenerateInitialChangeStreamPartitions</summary>
        public async Task GenerateInitialChangeStreamPartitions2()
        {
            // Snippet: GenerateInitialChangeStreamPartitions(string, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream response = bigtableServiceApiClient.GenerateInitialChangeStreamPartitions(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::GenerateInitialChangeStreamPartitionsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::GenerateInitialChangeStreamPartitionsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for GenerateInitialChangeStreamPartitions</summary>
        public async Task GenerateInitialChangeStreamPartitions2ResourceNames()
        {
            // Snippet: GenerateInitialChangeStreamPartitions(TableName, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream response = bigtableServiceApiClient.GenerateInitialChangeStreamPartitions(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::GenerateInitialChangeStreamPartitionsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::GenerateInitialChangeStreamPartitionsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadChangeStream</summary>
        public async Task ReadChangeStreamRequestObject()
        {
            // Snippet: ReadChangeStream(ReadChangeStreamRequest, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            gcbv::ReadChangeStreamRequest request = new gcbv::ReadChangeStreamRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                AppProfileId = "",
                Partition = new gcbv::StreamPartition(),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
                HeartbeatDuration = new Duration(),
            };
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ReadChangeStreamStream response = bigtableServiceApiClient.ReadChangeStream(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ReadChangeStreamResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ReadChangeStreamResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadChangeStream</summary>
        public async Task ReadChangeStream1()
        {
            // Snippet: ReadChangeStream(string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ReadChangeStreamStream response = bigtableServiceApiClient.ReadChangeStream(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ReadChangeStreamResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ReadChangeStreamResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadChangeStream</summary>
        public async Task ReadChangeStream1ResourceNames()
        {
            // Snippet: ReadChangeStream(TableName, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ReadChangeStreamStream response = bigtableServiceApiClient.ReadChangeStream(tableName);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ReadChangeStreamResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ReadChangeStreamResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadChangeStream</summary>
        public async Task ReadChangeStream2()
        {
            // Snippet: ReadChangeStream(string, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ReadChangeStreamStream response = bigtableServiceApiClient.ReadChangeStream(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ReadChangeStreamResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ReadChangeStreamResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadChangeStream</summary>
        public async Task ReadChangeStream2ResourceNames()
        {
            // Snippet: ReadChangeStream(TableName, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            TableName tableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ReadChangeStreamStream response = bigtableServiceApiClient.ReadChangeStream(tableName, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ReadChangeStreamResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ReadChangeStreamResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ExecuteQuery</summary>
        public async Task ExecuteQueryRequestObject()
        {
            // Snippet: ExecuteQuery(ExecuteQueryRequest, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            gcbv::ExecuteQueryRequest request = new gcbv::ExecuteQueryRequest
            {
                InstanceNameAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "",
                Query = "",
                ProtoFormat = new gcbv::ProtoFormat(),
                Params =
                {
                    {
                        "",
                        new gcbv::Value()
                    },
                },
                ResumeToken = ByteString.Empty,
            };
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ExecuteQueryStream response = bigtableServiceApiClient.ExecuteQuery(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ExecuteQueryResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ExecuteQueryResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ExecuteQuery</summary>
        public async Task ExecuteQuery1()
        {
            // Snippet: ExecuteQuery(string, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string instanceName = "projects/[PROJECT]/instances/[INSTANCE]";
            string query = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ExecuteQueryStream response = bigtableServiceApiClient.ExecuteQuery(instanceName, query);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ExecuteQueryResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ExecuteQueryResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ExecuteQuery</summary>
        public async Task ExecuteQuery1ResourceNames()
        {
            // Snippet: ExecuteQuery(InstanceName, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            InstanceName instanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string query = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ExecuteQueryStream response = bigtableServiceApiClient.ExecuteQuery(instanceName, query);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ExecuteQueryResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ExecuteQueryResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ExecuteQuery</summary>
        public async Task ExecuteQuery2()
        {
            // Snippet: ExecuteQuery(string, string, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string instanceName = "projects/[PROJECT]/instances/[INSTANCE]";
            string query = "";
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ExecuteQueryStream response = bigtableServiceApiClient.ExecuteQuery(instanceName, query, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ExecuteQueryResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ExecuteQueryResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ExecuteQuery</summary>
        public async Task ExecuteQuery2ResourceNames()
        {
            // Snippet: ExecuteQuery(InstanceName, string, string, CallSettings)
            // Create client
            gcbv::BigtableServiceApiClient bigtableServiceApiClient = gcbv::BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            InstanceName instanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string query = "";
            string appProfileId = "";
            // Make the request, returning a streaming response
            using gcbv::BigtableServiceApiClient.ExecuteQueryStream response = bigtableServiceApiClient.ExecuteQuery(instanceName, query, appProfileId);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcbv::ExecuteQueryResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcbv::ExecuteQueryResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }
    }
}
