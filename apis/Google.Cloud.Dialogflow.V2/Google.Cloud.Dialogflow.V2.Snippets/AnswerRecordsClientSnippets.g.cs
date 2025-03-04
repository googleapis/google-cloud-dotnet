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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Dialogflow.V2;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAnswerRecordsClientSnippets
    {
        /// <summary>Snippet for ListAnswerRecords</summary>
        public void ListAnswerRecordsRequestObject()
        {
            // Snippet: ListAnswerRecords(ListAnswerRecordsRequest, CallSettings)
            // Create client
            AnswerRecordsClient answerRecordsClient = AnswerRecordsClient.Create();
            // Initialize request argument(s)
            ListAnswerRecordsRequest request = new ListAnswerRecordsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAnswerRecordsResponse, AnswerRecord> response = answerRecordsClient.ListAnswerRecords(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnswerRecord item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnswerRecordsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnswerRecord item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnswerRecord> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnswerRecord item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnswerRecordsAsync</summary>
        public async Task ListAnswerRecordsRequestObjectAsync()
        {
            // Snippet: ListAnswerRecordsAsync(ListAnswerRecordsRequest, CallSettings)
            // Create client
            AnswerRecordsClient answerRecordsClient = await AnswerRecordsClient.CreateAsync();
            // Initialize request argument(s)
            ListAnswerRecordsRequest request = new ListAnswerRecordsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAnswerRecordsResponse, AnswerRecord> response = answerRecordsClient.ListAnswerRecordsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnswerRecord item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnswerRecordsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnswerRecord item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnswerRecord> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnswerRecord item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnswerRecords</summary>
        public void ListAnswerRecords()
        {
            // Snippet: ListAnswerRecords(string, string, int?, CallSettings)
            // Create client
            AnswerRecordsClient answerRecordsClient = AnswerRecordsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListAnswerRecordsResponse, AnswerRecord> response = answerRecordsClient.ListAnswerRecords(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnswerRecord item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnswerRecordsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnswerRecord item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnswerRecord> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnswerRecord item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnswerRecordsAsync</summary>
        public async Task ListAnswerRecordsAsync()
        {
            // Snippet: ListAnswerRecordsAsync(string, string, int?, CallSettings)
            // Create client
            AnswerRecordsClient answerRecordsClient = await AnswerRecordsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListAnswerRecordsResponse, AnswerRecord> response = answerRecordsClient.ListAnswerRecordsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnswerRecord item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnswerRecordsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnswerRecord item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnswerRecord> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnswerRecord item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnswerRecords</summary>
        public void ListAnswerRecordsResourceNames1()
        {
            // Snippet: ListAnswerRecords(ProjectName, string, int?, CallSettings)
            // Create client
            AnswerRecordsClient answerRecordsClient = AnswerRecordsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListAnswerRecordsResponse, AnswerRecord> response = answerRecordsClient.ListAnswerRecords(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnswerRecord item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnswerRecordsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnswerRecord item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnswerRecord> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnswerRecord item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnswerRecordsAsync</summary>
        public async Task ListAnswerRecordsResourceNames1Async()
        {
            // Snippet: ListAnswerRecordsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            AnswerRecordsClient answerRecordsClient = await AnswerRecordsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListAnswerRecordsResponse, AnswerRecord> response = answerRecordsClient.ListAnswerRecordsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnswerRecord item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnswerRecordsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnswerRecord item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnswerRecord> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnswerRecord item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnswerRecords</summary>
        public void ListAnswerRecordsResourceNames2()
        {
            // Snippet: ListAnswerRecords(LocationName, string, int?, CallSettings)
            // Create client
            AnswerRecordsClient answerRecordsClient = AnswerRecordsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAnswerRecordsResponse, AnswerRecord> response = answerRecordsClient.ListAnswerRecords(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnswerRecord item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnswerRecordsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnswerRecord item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnswerRecord> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnswerRecord item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnswerRecordsAsync</summary>
        public async Task ListAnswerRecordsResourceNames2Async()
        {
            // Snippet: ListAnswerRecordsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AnswerRecordsClient answerRecordsClient = await AnswerRecordsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAnswerRecordsResponse, AnswerRecord> response = answerRecordsClient.ListAnswerRecordsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnswerRecord item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnswerRecordsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnswerRecord item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnswerRecord> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnswerRecord item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateAnswerRecord</summary>
        public void UpdateAnswerRecordRequestObject()
        {
            // Snippet: UpdateAnswerRecord(UpdateAnswerRecordRequest, CallSettings)
            // Create client
            AnswerRecordsClient answerRecordsClient = AnswerRecordsClient.Create();
            // Initialize request argument(s)
            UpdateAnswerRecordRequest request = new UpdateAnswerRecordRequest
            {
                AnswerRecord = new AnswerRecord(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AnswerRecord response = answerRecordsClient.UpdateAnswerRecord(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAnswerRecordAsync</summary>
        public async Task UpdateAnswerRecordRequestObjectAsync()
        {
            // Snippet: UpdateAnswerRecordAsync(UpdateAnswerRecordRequest, CallSettings)
            // Additional: UpdateAnswerRecordAsync(UpdateAnswerRecordRequest, CancellationToken)
            // Create client
            AnswerRecordsClient answerRecordsClient = await AnswerRecordsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAnswerRecordRequest request = new UpdateAnswerRecordRequest
            {
                AnswerRecord = new AnswerRecord(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AnswerRecord response = await answerRecordsClient.UpdateAnswerRecordAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAnswerRecord</summary>
        public void UpdateAnswerRecord()
        {
            // Snippet: UpdateAnswerRecord(AnswerRecord, FieldMask, CallSettings)
            // Create client
            AnswerRecordsClient answerRecordsClient = AnswerRecordsClient.Create();
            // Initialize request argument(s)
            AnswerRecord answerRecord = new AnswerRecord();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AnswerRecord response = answerRecordsClient.UpdateAnswerRecord(answerRecord, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAnswerRecordAsync</summary>
        public async Task UpdateAnswerRecordAsync()
        {
            // Snippet: UpdateAnswerRecordAsync(AnswerRecord, FieldMask, CallSettings)
            // Additional: UpdateAnswerRecordAsync(AnswerRecord, FieldMask, CancellationToken)
            // Create client
            AnswerRecordsClient answerRecordsClient = await AnswerRecordsClient.CreateAsync();
            // Initialize request argument(s)
            AnswerRecord answerRecord = new AnswerRecord();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AnswerRecord response = await answerRecordsClient.UpdateAnswerRecordAsync(answerRecord, updateMask);
            // End snippet
        }
    }
}
