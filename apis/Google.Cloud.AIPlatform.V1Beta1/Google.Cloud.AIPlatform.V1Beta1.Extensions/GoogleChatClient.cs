#region HEADER
// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
#endregion

using Microsoft.Extensions.AI;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.AIPlatform.V1Beta1;

internal sealed class GoogleChatClient : IChatClient
{
    private readonly PredictionServiceClient _predictionServiceClient;

    public ChatClientMetadata Metadata { get; }

    internal GoogleChatClient(PredictionServiceClient predictionServiceClient)
    {
        this._predictionServiceClient = predictionServiceClient;
    }

    public Task<ChatCompletion> CompleteAsync(
        IList<ChatMessage> chatMessages,
        ChatOptions options = null,
        CancellationToken cancellationToken = default)
    {
        throw new System.NotImplementedException();
    }

    public IAsyncEnumerable<StreamingChatCompletionUpdate> CompleteStreamingAsync(
        IList<ChatMessage> chatMessages,
        ChatOptions options = null,
        CancellationToken cancellationToken = default)
    {
        throw new System.NotImplementedException();
    }

    public TService GetService<TService>(object key = null) where TService : class
    {
        throw new System.NotImplementedException();
    }

    public void Dispose()
    {
        // TODO release managed resources here
    }
}
