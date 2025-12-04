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

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// Represents a structured request ID for Spanner RPCs, formatted as:
/// {version}.{process}.{client}.{channel}.{request}.{attempt}
/// </summary>
internal sealed class RequestId
{
    /// <summary>
    /// The header key used for Spanner request IDs.
    /// </summary>
    internal const string HeaderKey = "x-goog-spanner-request-id";


    /// <summary>
    /// The version number of the request ID format.
    /// </summary>
    private const int FormatVersion = 1;

    /// <summary>
    /// A unique ID for the user application process. This can be overridden, but only before it has been accessed.
    /// </summary>
    private readonly string _processId;

    /// <summary>
    /// A unique ID for the gRPC channel being used. This is hardcoded to 1 for now.
    /// See: b/459445539
    /// </summary>
    private readonly int _channelId  = 1;

    /// <summary>
    /// A unique ID for the <see cref="SpannerClient"/> instance that generated the request.
    /// </summary>
    private readonly int _clientId;

    /// <summary>
    /// A unique ID for the logical request made using the current <see cref="SpannerClient"/>.
    /// </summary>
    private readonly int _requestId;

    /// <summary>
    /// A unique ID for each attempt of the request, incremented before each RPC attempt.
    /// </summary>
    private int _attemptId = 0;

    /// <summary>
    /// Initializes a new instance of the <see cref="RequestId"/> class
    /// with a specified client and logical request identifier.
    /// </summary>
    /// <param name="clientId">The ID for the <see cref="SpannerClient"/> associated with the request.</param>
    /// <param name="processId">The ID for the user application process.</param>
    /// <param name="requestId">The ID of the logical request within the client.</param>
    internal RequestId(string processId, int clientId, int requestId)
    {
        _processId = processId;
        _clientId = clientId;
        _requestId = requestId;
    }

    /// <summary>
    /// Increments the request's attempt number and then returns the request ID.
    /// </summary>
    internal RequestId IncrementAttempt()
    {
        // Retry attempts are expected to be sequential so we can safely
        // increment without first acquiring a lock.
        _attemptId++;
        return this;
    }

    /// <summary>
    /// Returns the string representation of the Spanner request ID.
    /// </summary>
    public override string ToString() => $"{FormatVersion}.{_processId}.{_clientId}.{_channelId}.{_requestId}.{_attemptId}";

}
