// Copyright 2018, Google LLC
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

using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Defines the API between gRPC listening code and the watch state that handles business logic.
    /// The only implementation is <see cref="WatchState"/>, but this interface makes testing simpler
    /// and the boundary responsibility clearer.
    /// </summary>
    internal interface IWatchState
    {
        /// <summary>
        /// The token to provide to return to this state, or null if there's no resume token.
        /// </summary>
        ByteString ResumeToken { get; }

        /// <summary>
        /// Called before the stream is initialized.
        /// </summary>
        void OnStreamInitialization(StreamInitializationCause cause);

        /// <summary>
        /// Handle the given response.
        /// </summary>
        /// <returns>The next state, or null if the stream needs to be reconnected.</returns>
        Task<WatchResponseResult> HandleResponseAsync(ListenResponse response, CancellationToken cancellationToken);
    }

    internal enum WatchResponseResult
    {
        /// <summary>
        /// Keep processing the current stream
        /// </summary>
        Continue,

        /// <summary>
        /// Reinitialize the stream
        /// </summary>
        ResetStream,

        /// <summary>
        /// The stream has become healthy: reset any backoff.
        /// </summary>
        StreamHealthy
    }

    internal enum StreamInitializationCause
    {
        /// <summary>
        /// A new watch was requested.
        /// </summary>
        WatchStarting,
        /// <summary>
        /// The previous response requested a stream reset.
        /// </summary>
        ResetRequested,
        /// <summary>
        /// A retriable error occurred.
        /// </summary>
        RpcError,
        /// <summary>
        /// The server indicated that the stream was complete.
        /// </summary>
        StreamCompleted
    }
}
