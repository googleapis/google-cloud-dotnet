// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.Grpc;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1;

internal static class ClientBuilderChannelHelper
{
    private static readonly GrpcChannelOptions s_unlimitedSendReceiveChannelOptions = GrpcChannelOptions.Empty
        .WithMaxReceiveMessageSize(int.MaxValue)
        .WithMaxSendMessageSize(int.MaxValue)
        // Set max metadata size to 4 MB i.e., 4194304 bytes.
        .WithCustomOption("grpc.max_metadata_size", 4194304);

        internal static GrpcChannelOptions GetUnlimitedSendReceiveChannelOptions() =>
            // Use a random arg to prevent sub-channel re-use in gRPC, so each channel uses its own connection.
            s_unlimitedSendReceiveChannelOptions.WithCustomOption("sub-channel-separator", Guid.NewGuid().ToString());

    internal static Task DisposeChannelAsync(ChannelBase channel)
    {
        if (channel is null)
        {
            return Task.CompletedTask;
        }
        if (channel is IDisposable disposable)
        {
            disposable.Dispose();
        }

        return channel.ShutdownAsync();
    }
}
