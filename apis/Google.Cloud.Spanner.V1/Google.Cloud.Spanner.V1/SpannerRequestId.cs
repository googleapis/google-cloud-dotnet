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

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Represents a structured request ID for Spanner RPCs, formatted as:
/// {version-id}.{process-id}.{client-id}.{channel-id}.{request-seq}.{attempt-num}
/// </summary>
internal sealed class SpannerRequestId
{
    /// <summary>
    /// The header key used for Spanner request IDs.
    /// </summary>
    internal const string HeaderKey = "x-goog-spanner-request-id";

    /// <summary>
    /// A randomly generated 64-bit integer, represented as a string, that remains constant for the lifetime of the process.
    /// </summary>
    internal static string s_processId;

    /// <summary>
    /// A random number generator used to create a unique process ID.
    /// </summary>
    private static readonly Random s_random = new();

    /// <summary>
    /// The hardcoded version number of the request ID format.
    /// </summary>
    private const int VersionId = 1;

    /// <summary>
    /// A placeholder for the channel identifier, currently hardcoded to 1.
    /// In the future, this will be dynamically assigned to uniquely identify the gRPC channel.
    /// </summary>
    private const int ChannelId = 1;

    /// <summary>
    /// A unique identifier for the client instance that generated the request.
    /// </summary>
    private readonly int _clientId;

    /// <summary>
    /// A sequence number that is unique within a client for each request.
    /// </summary>
    private readonly int _requestSequence;

    /// <summary>
    /// A counter for the number of attempts made for this request, incremented on each retry.
    /// </summary>
    private int _attemptNum = 0;

    /// <summary>
    /// Initializes the static members of the <see cref="SpannerRequestId"/> class.
    /// This constructor is called only once, before the first instance is created or any static members are referenced.
    /// </summary>
    static SpannerRequestId() => s_processId = GenerateProcessId();

    /// <summary>
    /// Initializes a new instance of the <see cref="SpannerRequestId"/> class
    /// with a specified client and request sequence number.
    /// </summary>
    /// <param name="clientId">The unique identifier for the client.</param>
    /// <param name="requestSequence">The sequence number of the request within the client.</param>
    internal SpannerRequestId(int clientId, int requestSequence)
    {
        _clientId = clientId;
        _requestSequence = requestSequence;
    }

    /// <summary>
    /// Atomically returns the header and increments the request's attempt number for future calls.
    /// This method is safe to call from multiple threads.
    /// </summary>
    internal string IncrementAttempt()
    {
        // Retry attempts are expected to be sequential so we can safely
        // increment without first acquiring a lock.
        _attemptNum++;
        return ToString();
    }

    /// <summary>
    /// Returns the string representation of the Spanner request ID.
    /// </summary>
    public override string ToString() => $"{VersionId}.{s_processId}.{_clientId}.{ChannelId}.{_requestSequence}.{_attemptNum}";

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
    /// Generates unique, sequential request IDs for Spanner operations.
    /// Each instance of this class represents a unique client and maintains its own request sequence.
    /// This class is thread-safe.
    /// </summary>
    internal class Generator
    {
        /// <summary>
        /// The unique identifier for the client instance.
        /// </summary>
        private readonly int _clientId;

        /// <summary>
        /// The sequence number for requests, which is atomically incremented for each new request.
        /// </summary>
        private int _requestSequence = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Generator"/> class
        /// with a specified client identifier.
        /// </summary>
        /// <param name="clientId">The unique identifier for the client.</param>
        internal Generator(int clientId) => _clientId = clientId;

        /// <summary>
        /// Generates the next request ID in the sequence.
        /// </summary>
        internal SpannerRequestId Generate()
        {
            // We capture the current sequence in a local variable to prevent
            // a race condition where another thread could increment _requestSequence
            // again before its value is read here for the SpannerRequestId
            int requestSequence = Interlocked.Increment(ref _requestSequence);
            return new SpannerRequestId(_clientId, requestSequence);
        }
    }
}
