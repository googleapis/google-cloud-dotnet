// Copyright 2018 Google Inc. All rights reserved.
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

using Google.Api.Gax.Grpc;
using Google.Rpc;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public static class MutateRowsStreamUtilities
    {
        /// <summary>
        /// Gathers and orders the entries from all responses from the stream.
        /// The order will match the order of the associated request entries.
        /// </summary>
        public static async Task<IEnumerable<MutateRowsResponse.Types.Entry>> GetResponseEntries(
            this BigtableClient.MutateRowsStream stream)
        {
            var responses = new List<MutateRowsResponse>();
            while (await stream.ResponseStream.MoveNext())
            {
                responses.Add(stream.ResponseStream.Current);
            }
            return responses.SelectMany(r => r.Entries).OrderBy(e => e.Index);
        }

        public static MutateRowsResponse.Types.Entry CreateEntry(int index, Code code) =>
            CreateEntry(index, new Status { Code = (int)code });

        public static MutateRowsResponse.Types.Entry CreateEntry(int index, Status status) =>
            new MutateRowsResponse.Types.Entry { Index = index, Status = status };

        public static BigtableClient.MutateRowsStream CreateRetryableMutateRowsStream(
            MutateRowsRequest request,
            MutateRowsResponse.Types.Entry[] entriesForInitialResponse,
            MutateRowsResponse.Types.Entry[][] entriesForRetryResponses,
            RetrySettings retrySettings)
        {
            // Initialize the client that will be used for retries and populate it with the retry responses.
            var client = new MockBigtableClient();
            if (entriesForRetryResponses != null)
            {
                foreach (var entries in entriesForRetryResponses)
                {
                    client.AddMutateRowsStream(new MockMutateRowsStream(new MutateRowsResponse { Entries = { entries } }));
                }
            }

            return new RetryingMutateRowsStream(
                client,
                request,
                new MockMutateRowsStream(new MutateRowsResponse { Entries = { entriesForInitialResponse } }),
                CallSettings.FromCancellationToken(CancellationToken.None),
                retrySettings);
        }
    }
}
