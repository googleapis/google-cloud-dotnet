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
/// Represents a structured request ID for Spanner RPCs, formatted as:
/// {version}.{process}.{client}.{channel}.{request}.{attempt}
/// </summary>
internal sealed class SpannerRequestId
{
    /// <summary>
    /// The header key used for Spanner request IDs.
    /// </summary>
    internal const string HeaderKey = "x-goog-spanner-request-id";

    private static Lazy<string> s_process = new(GenerateProcessId);
    /// <summary>
    /// A unique ID for the user application process. This can be overridden, but only before it has been accessed.
    /// </summary>
    internal static string ProcessId
    {
        get => s_process.Value;
        set
        {
            if (s_process.IsValueCreated)
            {
                Logger.DefaultLogger.Warn("ProcessId cannot be changed after it has been accessed. The new value will be ignored.");
            }
            else
            {
                s_process = new Lazy<string>(() => value);
            }
        }
    }

    /// <summary>
    /// The version number of the request ID format.
    /// </summary>
    private const int Version = 1;

    /// <summary>
    /// A unique ID for the gRPC channel being used. This is hardcoded to 1 for now.
    /// See: b/459445539
    /// </summary>
    private const int Channel = 1;

    /// <summary>
    /// A unique ID for the <see cref="SpannerClient"/> instance that generated the request.
    /// </summary>
    private readonly int _client;

    /// <summary>
    /// A unique ID for the logical request made using the current <see cref="SpannerClient"/>.
    /// </summary>
    private readonly int _request;

    /// <summary>
    /// A unique ID for each attempt of the request, incremented before each RPC attempt.
    /// </summary>
    private int _attempt = 0;

    /// <summary>
    /// A random number generator used to create a unique process ID.
    /// </summary>
    private static readonly Random s_random = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="SpannerRequestId"/> class
    /// with a specified client and logical request identifier.
    /// </summary>
    /// <param name="client">The ID for the <see cref="SpannerClient"/> associated with the request.</param>
    /// <param name="request">The ID of the logical request within the client.</param>
    internal SpannerRequestId(int client, int request)
    {
        _client = client;
        _request = request;
    }

    /// <summary>
    /// Increments the request's attempt number and then returns the request ID.
    /// </summary>
    internal string IncrementAttempt()
    {
        // Retry attempts are expected to be sequential so we can safely
        // increment without first acquiring a lock.
        _attempt++;
        return ToString();
    }

    /// <summary>
    /// Returns the string representation of the Spanner request ID.
    /// </summary>
    public override string ToString() => $"{Version}.{ProcessId}.{_client}.{Channel}.{_request}.{_attempt}";

    /// <summary>
    /// Generates a random 64-bit unsigned long as a string.
    /// </summary>
    private static string GenerateProcessId()
    {
        var buffer = new byte[sizeof(ulong)];
        s_random.NextBytes(buffer);
        return BitConverter.ToUInt64(buffer, 0).ToString();
    }

    /// <summary>
    /// Manages the generation of unique <see cref="SpannerRequestId"/> instances for a specific
    /// <see cref="SpannerClient"/> instance.
    /// </summary>
    /// <remarks>
    /// This class acts as a dedicated factory for <see cref="SpannerRequestId"/> instances.
    /// There should be a 1:1 mapping between a <see cref="SpannerClient"/> instance and a <see cref="SpannerRequestId.Source"/> instance,
    /// which simplifies the <see cref="SpannerClient"/> by centralizing the request ID generation logic.
    /// </remarks>
    internal class Source
    {
        /// <summary>
        /// A counter that is incremented on the instantiation of each new <see cref="SpannerRequestId.Source"/>.
        /// Given the one-to-one mapping between a <see cref="SpannerClient"/> and a <see cref="SpannerRequestId.Source"/>,
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
        private readonly int _client;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpannerRequestId.Source"/> class,
        /// assigning a unique client identifier.
        /// </summary>
        internal Source() => _client = Interlocked.Increment(ref s_clientCounter);

        /// <summary>
        /// Generates the next <see cref="SpannerRequestId"/> for a new logical request made with the associated <see cref="SpannerClient"/> instance.
        /// </summary>
        internal SpannerRequestId Next()
        {
            // We capture the current logical request ID in a local variable to prevent
            // a race condition where another thread could increment _requestCounter
            // again before its value is read here for the SpannerRequestId
            int request = Interlocked.Increment(ref _requestCounter);
            return new SpannerRequestId(_client, request);
        }
    }
}
