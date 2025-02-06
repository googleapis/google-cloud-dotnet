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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.BigQuery.Storage.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBigQueryReadClientSnippets
    {
        /// <summary>Snippet for CreateReadSession</summary>
        public void CreateReadSessionRequestObject()
        {
            // Snippet: CreateReadSession(CreateReadSessionRequest, CallSettings)
            // Create client
            BigQueryReadClient bigQueryReadClient = BigQueryReadClient.Create();
            // Initialize request argument(s)
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ReadSession = new ReadSession(),
                MaxStreamCount = 0,
                PreferredMinStreamCount = 0,
            };
            // Make the request
            ReadSession response = bigQueryReadClient.CreateReadSession(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReadSessionAsync</summary>
        public async Task CreateReadSessionRequestObjectAsync()
        {
            // Snippet: CreateReadSessionAsync(CreateReadSessionRequest, CallSettings)
            // Additional: CreateReadSessionAsync(CreateReadSessionRequest, CancellationToken)
            // Create client
            BigQueryReadClient bigQueryReadClient = await BigQueryReadClient.CreateAsync();
            // Initialize request argument(s)
            CreateReadSessionRequest request = new CreateReadSessionRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ReadSession = new ReadSession(),
                MaxStreamCount = 0,
                PreferredMinStreamCount = 0,
            };
            // Make the request
            ReadSession response = await bigQueryReadClient.CreateReadSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReadSession</summary>
        public void CreateReadSession()
        {
            // Snippet: CreateReadSession(string, ReadSession, int, CallSettings)
            // Create client
            BigQueryReadClient bigQueryReadClient = BigQueryReadClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            ReadSession readSession = new ReadSession();
            int maxStreamCount = 0;
            // Make the request
            ReadSession response = bigQueryReadClient.CreateReadSession(parent, readSession, maxStreamCount);
            // End snippet
        }

        /// <summary>Snippet for CreateReadSessionAsync</summary>
        public async Task CreateReadSessionAsync()
        {
            // Snippet: CreateReadSessionAsync(string, ReadSession, int, CallSettings)
            // Additional: CreateReadSessionAsync(string, ReadSession, int, CancellationToken)
            // Create client
            BigQueryReadClient bigQueryReadClient = await BigQueryReadClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            ReadSession readSession = new ReadSession();
            int maxStreamCount = 0;
            // Make the request
            ReadSession response = await bigQueryReadClient.CreateReadSessionAsync(parent, readSession, maxStreamCount);
            // End snippet
        }

        /// <summary>Snippet for CreateReadSession</summary>
        public void CreateReadSessionResourceNames()
        {
            // Snippet: CreateReadSession(ProjectName, ReadSession, int, CallSettings)
            // Create client
            BigQueryReadClient bigQueryReadClient = BigQueryReadClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            ReadSession readSession = new ReadSession();
            int maxStreamCount = 0;
            // Make the request
            ReadSession response = bigQueryReadClient.CreateReadSession(parent, readSession, maxStreamCount);
            // End snippet
        }

        /// <summary>Snippet for CreateReadSessionAsync</summary>
        public async Task CreateReadSessionResourceNamesAsync()
        {
            // Snippet: CreateReadSessionAsync(ProjectName, ReadSession, int, CallSettings)
            // Additional: CreateReadSessionAsync(ProjectName, ReadSession, int, CancellationToken)
            // Create client
            BigQueryReadClient bigQueryReadClient = await BigQueryReadClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            ReadSession readSession = new ReadSession();
            int maxStreamCount = 0;
            // Make the request
            ReadSession response = await bigQueryReadClient.CreateReadSessionAsync(parent, readSession, maxStreamCount);
            // End snippet
        }

        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRowsRequestObject()
        {
            // Snippet: ReadRows(ReadRowsRequest, CallSettings)
            // Create client
            BigQueryReadClient bigQueryReadClient = BigQueryReadClient.Create();
            // Initialize request argument(s)
            ReadRowsRequest request = new ReadRowsRequest
            {
                ReadStreamAsReadStreamName = ReadStreamName.FromProjectLocationSessionStream("[PROJECT]", "[LOCATION]", "[SESSION]", "[STREAM]"),
                Offset = 0L,
            };
            // Make the request, returning a streaming response
            using BigQueryReadClient.ReadRowsStream response = bigQueryReadClient.ReadRows(request);

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
        public async Task ReadRows()
        {
            // Snippet: ReadRows(string, long, CallSettings)
            // Create client
            BigQueryReadClient bigQueryReadClient = BigQueryReadClient.Create();
            // Initialize request argument(s)
            string readStream = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]/streams/[STREAM]";
            long offset = 0L;
            // Make the request, returning a streaming response
            using BigQueryReadClient.ReadRowsStream response = bigQueryReadClient.ReadRows(readStream, offset);

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
        public async Task ReadRowsResourceNames()
        {
            // Snippet: ReadRows(ReadStreamName, long, CallSettings)
            // Create client
            BigQueryReadClient bigQueryReadClient = BigQueryReadClient.Create();
            // Initialize request argument(s)
            ReadStreamName readStream = ReadStreamName.FromProjectLocationSessionStream("[PROJECT]", "[LOCATION]", "[SESSION]", "[STREAM]");
            long offset = 0L;
            // Make the request, returning a streaming response
            using BigQueryReadClient.ReadRowsStream response = bigQueryReadClient.ReadRows(readStream, offset);

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

        /// <summary>Snippet for SplitReadStream</summary>
        public void SplitReadStreamRequestObject()
        {
            // Snippet: SplitReadStream(SplitReadStreamRequest, CallSettings)
            // Create client
            BigQueryReadClient bigQueryReadClient = BigQueryReadClient.Create();
            // Initialize request argument(s)
            SplitReadStreamRequest request = new SplitReadStreamRequest
            {
                ReadStreamName = ReadStreamName.FromProjectLocationSessionStream("[PROJECT]", "[LOCATION]", "[SESSION]", "[STREAM]"),
                Fraction = 0,
            };
            // Make the request
            SplitReadStreamResponse response = bigQueryReadClient.SplitReadStream(request);
            // End snippet
        }

        /// <summary>Snippet for SplitReadStreamAsync</summary>
        public async Task SplitReadStreamRequestObjectAsync()
        {
            // Snippet: SplitReadStreamAsync(SplitReadStreamRequest, CallSettings)
            // Additional: SplitReadStreamAsync(SplitReadStreamRequest, CancellationToken)
            // Create client
            BigQueryReadClient bigQueryReadClient = await BigQueryReadClient.CreateAsync();
            // Initialize request argument(s)
            SplitReadStreamRequest request = new SplitReadStreamRequest
            {
                ReadStreamName = ReadStreamName.FromProjectLocationSessionStream("[PROJECT]", "[LOCATION]", "[SESSION]", "[STREAM]"),
                Fraction = 0,
            };
            // Make the request
            SplitReadStreamResponse response = await bigQueryReadClient.SplitReadStreamAsync(request);
            // End snippet
        }
    }
}
