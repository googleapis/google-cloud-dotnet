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

using Google.Api.Gax.Grpc;
using Google.Rpc;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public static class Utilities
    {
        public static MutateRowsResponse.Types.Entry CreateMutateRowsResponseEntry(int index, Code code) =>
            CreateMutateRowsResponseEntry(index, new Status { Code = (int)code });

        public static MutateRowsResponse.Types.Entry CreateMutateRowsResponseEntry(int index, Status status) =>
            new MutateRowsResponse.Types.Entry { Index = index, Status = status };

        public static BigtableClient CreateClientForMutateRowsRetries(
            MutateRowsRequest initialRequest,
            MutateRowsResponse.Types.Entry[] entriesForInitialResponse,
            MutateRowsResponse.Types.Entry[][] entriesForRetryResponses)
        {
            var mock = new Mock<BigtableServiceApiClient>();

            if (entriesForRetryResponses != null)
            {
                var retryResponses = new Queue<MockMutateRowsStream>(entriesForRetryResponses.Select(StreamFromEntries));
                mock.Setup(c => c.MutateRows(It.IsAny<MutateRowsRequest>(), It.IsAny<CallSettings>()))
                    .Returns(retryResponses.Dequeue);
            }

            // Setup the initial response last so the catch-all setup doesn't overwrite it.
            mock.Setup(c => c.MutateRows(initialRequest, It.IsAny<CallSettings>()))
                .Returns(StreamFromEntries(entriesForInitialResponse));

            return new BigtableClientImpl(new[] { mock.Object }, appProfileId: null);

            MockMutateRowsStream StreamFromEntries(MutateRowsResponse.Types.Entry[] entries) =>
                new MockMutateRowsStream(new MutateRowsResponse { Entries = { entries } });
        }
    }
}
