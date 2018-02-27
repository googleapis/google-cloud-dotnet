// Copyright 2018 Google LLC
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

using Google.Rpc;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public static class MutateRowsStreamUtilities
    {
        public static MutateRowsResponse.Types.Entry CreateEntry(int index, Code code) =>
            CreateEntry(index, new Status { Code = (int)code });

        public static MutateRowsResponse.Types.Entry CreateEntry(int index, Status status) =>
            new MutateRowsResponse.Types.Entry { Index = index, Status = status };

        public static BigtableClient CreateClientForMutateRowsRetries(
            MutateRowsResponse.Types.Entry[] entriesForInitialResponse,
            MutateRowsResponse.Types.Entry[][] entriesForRetryResponses)
        {
            // Initialize the client that will be used for retries and populate it with the retry responses.
            var client = new MockBigtableClient();

            client.AddMutateRowsStream(new MockMutateRowsStream(new MutateRowsResponse { Entries = { entriesForInitialResponse } }));
            if (entriesForRetryResponses != null)
            {
                foreach (var entries in entriesForRetryResponses)
                {
                    client.AddMutateRowsStream(new MockMutateRowsStream(new MutateRowsResponse { Entries = { entries } }));
                }
            }

            return client;
        }
    }
}
