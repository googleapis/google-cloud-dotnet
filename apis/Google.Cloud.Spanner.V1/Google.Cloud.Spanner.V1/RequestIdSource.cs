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

using System;
using System.Threading;
using Google.Cloud.Spanner.V1.Internal.Logging;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Manages the generation of unique <see cref="RequestId"/> instances for a specific
/// <see cref="SpannerClient"/> instance.
/// </summary>
/// <remarks>
/// This class acts as a dedicated factory for <see cref="RequestId"/> instances.
/// There should be a 1:1 mapping between a <see cref="SpannerClient"/> instance and a <see cref="RequestIdSource"/> instance,
/// which simplifies the <see cref="SpannerClient"/> by centralizing the request ID generation logic.
/// </remarks>
internal class RequestIdSource
{
    private static string s_processId;
    /// <summary>
    /// A unique ID for the user application process. This value can only be set once.
    /// </summary>
    internal static string ProcessId
    {
        get => GetProcessId();
        set
        {
            // Atomically set the process ID only if it's currently null.
            // If it was already set, log a warning and ignore the new value.
            if (Interlocked.CompareExchange(ref s_processId, value, null) != null)
            {
                Logger.DefaultLogger.Warn("ProcessId cannot be changed after it has been accessed. The new value will be ignored.");
            }
        }
    }

    /// <summary>
    /// A counter that is incremented on the instantiation of each new <see cref="RequestIdSource"/>.
    /// Given the one-to-one mapping between a <see cref="SpannerClient"/> and a <see cref="RequestIdSource"/>,
    /// this effectively means the counter is incremented for each new client instance.
    /// </summary>
    private static int s_clientCounter;

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
    internal RequestIdSource() => _clientId = Interlocked.Increment(ref s_clientCounter);

    /// <summary>
    /// Generates the next <see cref="RequestId"/> for a new logical request made with the associated <see cref="SpannerClient"/> instance.
    /// </summary>
    internal RequestId ForNewRequest()
    {
        // We capture the current logical request ID in a local variable to prevent
        // a race condition where another thread could increment _requestCounter
        // again before its value is read here for the SpannerRequestId
        int requestId = Interlocked.Increment(ref _requestCounter);
        return new RequestId(ProcessId, _clientId, requestId);
    }

    /// <summary>
    /// Returns the process ID, generating and storing it if it hasn't been set yet.
    /// </summary>
    private static string GetProcessId()
    {
        if (s_processId == null)
        {
            // A random 64 bit unsigned long string will be used as a default value
            var random = new Random();
            var buffer = new byte[sizeof(ulong)];
            random.NextBytes(buffer);
            string generatedId = BitConverter.ToUInt64(buffer, 0).ToString();

            // Atomically set the process ID to the default value if by this point its still null.
            Interlocked.CompareExchange(ref s_processId, generatedId, null);
        }
        return s_processId;
    }
}
