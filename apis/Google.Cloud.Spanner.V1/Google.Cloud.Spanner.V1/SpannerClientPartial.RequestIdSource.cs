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

using System.Threading;

namespace Google.Cloud.Spanner.V1;

public partial class SpannerClientImpl
{
    /// <summary>
    /// Manages the generation of unique <see cref="RequestId"/> instances for a specific
    /// <see cref="SpannerClient"/> instance.
    /// </summary>
    /// <remarks>
    /// This class acts as a dedicated factory for <see cref="RequestId"/> instances.
    /// There should be a 1:1 mapping between a <see cref="SpannerClient"/> instance and a <see cref="RequestIdSource"/> instance,
    /// which simplifies the <see cref="SpannerClient"/> by centralizing the request ID generation logic.
    /// </remarks>
    private sealed class RequestIdSource
    {
        /// <summary>
        /// A counter that is incremented on the instantiation of each new <see cref="RequestIdSource"/> used to identify
        /// the <see cref="SpannerClient"/>. Given the one-to-one mapping between a <see cref="SpannerClient"/> and a <see
        /// cref="RequestIdSource"/>, this effectively means the counter is incremented for each new client instance.
        /// </summary>
        private static int s_instanceCounter;

        /// <summary>
        /// A counter incremented for each logical request made from the client.
        /// </summary>
        private int _requestCounter = 0;

        /// <summary>
        /// The unique ID for the <see cref="SpannerClient"/> instance this generator is associated with.
        /// </summary>
        private readonly int _clientId;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestIdSource"/> class,
        /// assigning a unique client identifier.
        /// </summary>
        internal RequestIdSource() => _clientId = Interlocked.Increment(ref s_instanceCounter);

        /// <summary>
        /// Generates the next <see cref="RequestId"/> for a new logical request made with the associated <see cref="SpannerClient"/> instance.
        /// </summary>
        internal RequestId NewRequestId() => new RequestId(_clientId, Interlocked.Increment(ref _requestCounter));
    }
}
