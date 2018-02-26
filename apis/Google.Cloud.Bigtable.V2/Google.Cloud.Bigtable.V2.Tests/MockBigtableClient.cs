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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class RequestMadeException : Exception { }

    // TODO: See if Moq would be possible/easier rather than hand-rolling.
    public class MockBigtableClient : BigtableClient
    {
        private readonly MockBigtableServiceApiClient _client = new MockBigtableServiceApiClient();

        /// <summary>
        /// Adds a stream that will be returned on a subsequent <see cref="MutateRows"/> call. Added streams will be returned in FIFO order.
        /// </summary>
        public void AddMutateRowsStream(BigtableServiceApiClient.MutateRowsStream mockMutateRowsStream) => _client.AddMutateRowsStream(mockMutateRowsStream);

        protected override BigtableServiceApiClient GetUnderlyingClient() => _client;

        public override CheckAndMutateRowResponse CheckAndMutateRow(CheckAndMutateRowRequest request, CallSettings callSettings = null) =>
            throw new RequestMadeException();
        public override Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(CheckAndMutateRowRequest request, CallSettings callSettings = null) =>
            throw new RequestMadeException();
        public override MutateRowResponse MutateRow(MutateRowRequest request, CallSettings callSettings = null) =>
            throw new RequestMadeException();
        public override Task<MutateRowResponse> MutateRowAsync(MutateRowRequest request, CallSettings callSettings = null) =>
            throw new RequestMadeException();
        public override MutateRowsResponse MutateRows(MutateRowsRequest request, CallSettings callSettings = null) =>
            Task.Run(() => MutateRowsAsync(request, callSettings)).ResultWithUnwrappedExceptions();
        public override Task<MutateRowsResponse> MutateRowsAsync(MutateRowsRequest request, CallSettings callSettings = null) =>
            ConvertResult(request, callSettings, GetUnderlyingClient().MutateRows(request, callSettings));
        public override ReadModifyWriteRowResponse ReadModifyWriteRow(ReadModifyWriteRowRequest request, CallSettings callSettings = null) =>
            throw new RequestMadeException();
        public override Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(ReadModifyWriteRowRequest request, CallSettings callSettings = null) =>
            throw new RequestMadeException();
        public override ReadRowsStream ReadRows(ReadRowsRequest request, CallSettings callSettings = null) =>
            throw new RequestMadeException();
        public override BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(SampleRowKeysRequest request, CallSettings callSettings = null) =>
            throw new RequestMadeException();

        public class MockBigtableServiceApiClient : BigtableServiceApiClient
        {
            private readonly Queue<MutateRowsStream> _mockMutateRowsStreams = new Queue<MutateRowsStream>();

            public void AddMutateRowsStream(MutateRowsStream mockMutateRowsStream) => _mockMutateRowsStreams.Enqueue(mockMutateRowsStream);

            public override MutateRowsStream MutateRows(MutateRowsRequest request, CallSettings callSettings = null) =>
                _mockMutateRowsStreams.Count != 0 ? _mockMutateRowsStreams.Dequeue() : throw new RequestMadeException();
        }
    }
}
