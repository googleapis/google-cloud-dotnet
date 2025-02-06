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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.BigQuery.Storage.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBigQueryWriteClientSnippets
    {
        /// <summary>Snippet for CreateWriteStream</summary>
        public void CreateWriteStreamRequestObject()
        {
            // Snippet: CreateWriteStream(CreateWriteStreamRequest, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            CreateWriteStreamRequest request = new CreateWriteStreamRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStream = new WriteStream(),
            };
            // Make the request
            WriteStream response = bigQueryWriteClient.CreateWriteStream(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWriteStreamAsync</summary>
        public async Task CreateWriteStreamRequestObjectAsync()
        {
            // Snippet: CreateWriteStreamAsync(CreateWriteStreamRequest, CallSettings)
            // Additional: CreateWriteStreamAsync(CreateWriteStreamRequest, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            CreateWriteStreamRequest request = new CreateWriteStreamRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStream = new WriteStream(),
            };
            // Make the request
            WriteStream response = await bigQueryWriteClient.CreateWriteStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWriteStream</summary>
        public void CreateWriteStream()
        {
            // Snippet: CreateWriteStream(string, WriteStream, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]/tables/[TABLE]";
            WriteStream writeStream = new WriteStream();
            // Make the request
            WriteStream response = bigQueryWriteClient.CreateWriteStream(parent, writeStream);
            // End snippet
        }

        /// <summary>Snippet for CreateWriteStreamAsync</summary>
        public async Task CreateWriteStreamAsync()
        {
            // Snippet: CreateWriteStreamAsync(string, WriteStream, CallSettings)
            // Additional: CreateWriteStreamAsync(string, WriteStream, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]/tables/[TABLE]";
            WriteStream writeStream = new WriteStream();
            // Make the request
            WriteStream response = await bigQueryWriteClient.CreateWriteStreamAsync(parent, writeStream);
            // End snippet
        }

        /// <summary>Snippet for CreateWriteStream</summary>
        public void CreateWriteStreamResourceNames()
        {
            // Snippet: CreateWriteStream(TableName, WriteStream, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            TableName parent = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]");
            WriteStream writeStream = new WriteStream();
            // Make the request
            WriteStream response = bigQueryWriteClient.CreateWriteStream(parent, writeStream);
            // End snippet
        }

        /// <summary>Snippet for CreateWriteStreamAsync</summary>
        public async Task CreateWriteStreamResourceNamesAsync()
        {
            // Snippet: CreateWriteStreamAsync(TableName, WriteStream, CallSettings)
            // Additional: CreateWriteStreamAsync(TableName, WriteStream, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            TableName parent = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]");
            WriteStream writeStream = new WriteStream();
            // Make the request
            WriteStream response = await bigQueryWriteClient.CreateWriteStreamAsync(parent, writeStream);
            // End snippet
        }

        /// <summary>Snippet for AppendRows</summary>
        public async Task AppendRows()
        {
            // Snippet: AppendRows(CallSettings, BidirectionalStreamingSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize streaming call, retrieving the stream object
            using BigQueryWriteClient.AppendRowsStream response = bigQueryWriteClient.AppendRows();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<AppendRowsResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    AppendRowsResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                AppendRowsRequest request = new AppendRowsRequest
                {
                    WriteStreamAsWriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                    Offset = 0L,
                    ProtoRows = new AppendRowsRequest.Types.ProtoData(),
                    TraceId = "",
                    MissingValueInterpretations =
                    {
                        {
                            "",
                            AppendRowsRequest.Types.MissingValueInterpretation.Unspecified
                        },
                    },
                    DefaultMissingValueInterpretation = AppendRowsRequest.Types.MissingValueInterpretation.Unspecified,
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for GetWriteStream</summary>
        public void GetWriteStreamRequestObject()
        {
            // Snippet: GetWriteStream(GetWriteStreamRequest, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            GetWriteStreamRequest request = new GetWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                View = WriteStreamView.Unspecified,
            };
            // Make the request
            WriteStream response = bigQueryWriteClient.GetWriteStream(request);
            // End snippet
        }

        /// <summary>Snippet for GetWriteStreamAsync</summary>
        public async Task GetWriteStreamRequestObjectAsync()
        {
            // Snippet: GetWriteStreamAsync(GetWriteStreamRequest, CallSettings)
            // Additional: GetWriteStreamAsync(GetWriteStreamRequest, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            GetWriteStreamRequest request = new GetWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                View = WriteStreamView.Unspecified,
            };
            // Make the request
            WriteStream response = await bigQueryWriteClient.GetWriteStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWriteStream</summary>
        public void GetWriteStream()
        {
            // Snippet: GetWriteStream(string, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/tables/[TABLE]/streams/[STREAM]";
            // Make the request
            WriteStream response = bigQueryWriteClient.GetWriteStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetWriteStreamAsync</summary>
        public async Task GetWriteStreamAsync()
        {
            // Snippet: GetWriteStreamAsync(string, CallSettings)
            // Additional: GetWriteStreamAsync(string, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/tables/[TABLE]/streams/[STREAM]";
            // Make the request
            WriteStream response = await bigQueryWriteClient.GetWriteStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWriteStream</summary>
        public void GetWriteStreamResourceNames()
        {
            // Snippet: GetWriteStream(WriteStreamName, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            WriteStreamName name = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]");
            // Make the request
            WriteStream response = bigQueryWriteClient.GetWriteStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetWriteStreamAsync</summary>
        public async Task GetWriteStreamResourceNamesAsync()
        {
            // Snippet: GetWriteStreamAsync(WriteStreamName, CallSettings)
            // Additional: GetWriteStreamAsync(WriteStreamName, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            WriteStreamName name = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]");
            // Make the request
            WriteStream response = await bigQueryWriteClient.GetWriteStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FinalizeWriteStream</summary>
        public void FinalizeWriteStreamRequestObject()
        {
            // Snippet: FinalizeWriteStream(FinalizeWriteStreamRequest, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            FinalizeWriteStreamRequest request = new FinalizeWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            // Make the request
            FinalizeWriteStreamResponse response = bigQueryWriteClient.FinalizeWriteStream(request);
            // End snippet
        }

        /// <summary>Snippet for FinalizeWriteStreamAsync</summary>
        public async Task FinalizeWriteStreamRequestObjectAsync()
        {
            // Snippet: FinalizeWriteStreamAsync(FinalizeWriteStreamRequest, CallSettings)
            // Additional: FinalizeWriteStreamAsync(FinalizeWriteStreamRequest, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            FinalizeWriteStreamRequest request = new FinalizeWriteStreamRequest
            {
                WriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
            };
            // Make the request
            FinalizeWriteStreamResponse response = await bigQueryWriteClient.FinalizeWriteStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FinalizeWriteStream</summary>
        public void FinalizeWriteStream()
        {
            // Snippet: FinalizeWriteStream(string, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/tables/[TABLE]/streams/[STREAM]";
            // Make the request
            FinalizeWriteStreamResponse response = bigQueryWriteClient.FinalizeWriteStream(name);
            // End snippet
        }

        /// <summary>Snippet for FinalizeWriteStreamAsync</summary>
        public async Task FinalizeWriteStreamAsync()
        {
            // Snippet: FinalizeWriteStreamAsync(string, CallSettings)
            // Additional: FinalizeWriteStreamAsync(string, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/tables/[TABLE]/streams/[STREAM]";
            // Make the request
            FinalizeWriteStreamResponse response = await bigQueryWriteClient.FinalizeWriteStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FinalizeWriteStream</summary>
        public void FinalizeWriteStreamResourceNames()
        {
            // Snippet: FinalizeWriteStream(WriteStreamName, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            WriteStreamName name = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]");
            // Make the request
            FinalizeWriteStreamResponse response = bigQueryWriteClient.FinalizeWriteStream(name);
            // End snippet
        }

        /// <summary>Snippet for FinalizeWriteStreamAsync</summary>
        public async Task FinalizeWriteStreamResourceNamesAsync()
        {
            // Snippet: FinalizeWriteStreamAsync(WriteStreamName, CallSettings)
            // Additional: FinalizeWriteStreamAsync(WriteStreamName, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            WriteStreamName name = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]");
            // Make the request
            FinalizeWriteStreamResponse response = await bigQueryWriteClient.FinalizeWriteStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchCommitWriteStreams</summary>
        public void BatchCommitWriteStreamsRequestObject()
        {
            // Snippet: BatchCommitWriteStreams(BatchCommitWriteStreamsRequest, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            BatchCommitWriteStreamsRequest request = new BatchCommitWriteStreamsRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStreams = { "", },
            };
            // Make the request
            BatchCommitWriteStreamsResponse response = bigQueryWriteClient.BatchCommitWriteStreams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCommitWriteStreamsAsync</summary>
        public async Task BatchCommitWriteStreamsRequestObjectAsync()
        {
            // Snippet: BatchCommitWriteStreamsAsync(BatchCommitWriteStreamsRequest, CallSettings)
            // Additional: BatchCommitWriteStreamsAsync(BatchCommitWriteStreamsRequest, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            BatchCommitWriteStreamsRequest request = new BatchCommitWriteStreamsRequest
            {
                ParentAsTableName = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]"),
                WriteStreams = { "", },
            };
            // Make the request
            BatchCommitWriteStreamsResponse response = await bigQueryWriteClient.BatchCommitWriteStreamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCommitWriteStreams</summary>
        public void BatchCommitWriteStreams()
        {
            // Snippet: BatchCommitWriteStreams(string, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]/tables/[TABLE]";
            // Make the request
            BatchCommitWriteStreamsResponse response = bigQueryWriteClient.BatchCommitWriteStreams(parent);
            // End snippet
        }

        /// <summary>Snippet for BatchCommitWriteStreamsAsync</summary>
        public async Task BatchCommitWriteStreamsAsync()
        {
            // Snippet: BatchCommitWriteStreamsAsync(string, CallSettings)
            // Additional: BatchCommitWriteStreamsAsync(string, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/datasets/[DATASET]/tables/[TABLE]";
            // Make the request
            BatchCommitWriteStreamsResponse response = await bigQueryWriteClient.BatchCommitWriteStreamsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for BatchCommitWriteStreams</summary>
        public void BatchCommitWriteStreamsResourceNames()
        {
            // Snippet: BatchCommitWriteStreams(TableName, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            TableName parent = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]");
            // Make the request
            BatchCommitWriteStreamsResponse response = bigQueryWriteClient.BatchCommitWriteStreams(parent);
            // End snippet
        }

        /// <summary>Snippet for BatchCommitWriteStreamsAsync</summary>
        public async Task BatchCommitWriteStreamsResourceNamesAsync()
        {
            // Snippet: BatchCommitWriteStreamsAsync(TableName, CallSettings)
            // Additional: BatchCommitWriteStreamsAsync(TableName, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            TableName parent = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]");
            // Make the request
            BatchCommitWriteStreamsResponse response = await bigQueryWriteClient.BatchCommitWriteStreamsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for FlushRows</summary>
        public void FlushRowsRequestObject()
        {
            // Snippet: FlushRows(FlushRowsRequest, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            FlushRowsRequest request = new FlushRowsRequest
            {
                WriteStreamAsWriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Offset = 0L,
            };
            // Make the request
            FlushRowsResponse response = bigQueryWriteClient.FlushRows(request);
            // End snippet
        }

        /// <summary>Snippet for FlushRowsAsync</summary>
        public async Task FlushRowsRequestObjectAsync()
        {
            // Snippet: FlushRowsAsync(FlushRowsRequest, CallSettings)
            // Additional: FlushRowsAsync(FlushRowsRequest, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            FlushRowsRequest request = new FlushRowsRequest
            {
                WriteStreamAsWriteStreamName = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]"),
                Offset = 0L,
            };
            // Make the request
            FlushRowsResponse response = await bigQueryWriteClient.FlushRowsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FlushRows</summary>
        public void FlushRows()
        {
            // Snippet: FlushRows(string, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            string writeStream = "projects/[PROJECT]/datasets/[DATASET]/tables/[TABLE]/streams/[STREAM]";
            // Make the request
            FlushRowsResponse response = bigQueryWriteClient.FlushRows(writeStream);
            // End snippet
        }

        /// <summary>Snippet for FlushRowsAsync</summary>
        public async Task FlushRowsAsync()
        {
            // Snippet: FlushRowsAsync(string, CallSettings)
            // Additional: FlushRowsAsync(string, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            string writeStream = "projects/[PROJECT]/datasets/[DATASET]/tables/[TABLE]/streams/[STREAM]";
            // Make the request
            FlushRowsResponse response = await bigQueryWriteClient.FlushRowsAsync(writeStream);
            // End snippet
        }

        /// <summary>Snippet for FlushRows</summary>
        public void FlushRowsResourceNames()
        {
            // Snippet: FlushRows(WriteStreamName, CallSettings)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            WriteStreamName writeStream = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]");
            // Make the request
            FlushRowsResponse response = bigQueryWriteClient.FlushRows(writeStream);
            // End snippet
        }

        /// <summary>Snippet for FlushRowsAsync</summary>
        public async Task FlushRowsResourceNamesAsync()
        {
            // Snippet: FlushRowsAsync(WriteStreamName, CallSettings)
            // Additional: FlushRowsAsync(WriteStreamName, CancellationToken)
            // Create client
            BigQueryWriteClient bigQueryWriteClient = await BigQueryWriteClient.CreateAsync();
            // Initialize request argument(s)
            WriteStreamName writeStream = WriteStreamName.FromProjectDatasetTableStream("[PROJECT]", "[DATASET]", "[TABLE]", "[STREAM]");
            // Make the request
            FlushRowsResponse response = await bigQueryWriteClient.FlushRowsAsync(writeStream);
            // End snippet
        }
    }
}
