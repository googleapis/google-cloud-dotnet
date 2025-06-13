// Copyright 2022, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// This class contains the temporary and/or permanent failures from Acknowledge and ModifyAckDeadline RPCs for exactly once subscriptions.
/// </summary>
internal sealed class AckError
{
    /// <summary>
    /// True if there are any permanent failures else false if <see cref="PermanentFailureIds"/> is empty.
    /// </summary>
    internal bool HasPermanentFailures => PermanentFailureIds.Any();

    /// <summary>
    /// Gets the AckIds/ExtendIds/NackIds with temporary failures.
    /// This collection will be populated with AckIds/ExtendIds/NackIds only if the failure is temporary,
    /// else this collection will be empty (but not null).
    /// </summary>
    internal IEnumerable<string> TemporaryFailureIds => TemporaryFailures.Select(kvp => kvp.Key);

    /// <summary>
    /// Gets the temporary failures.
    /// This collection will be populated with AckIds/NackIds/ExtendIds with their corresponding failures only if the failure is temporary,
    /// else this collection will be empty (but not null).
    /// </summary>
    internal IEnumerable<KeyValuePair<string, string>> TemporaryFailures { get; }

    /// <summary>
    /// Gets the AckIds/ExtendIds/NackIds with permanent failures.
    /// This collection will be populated with AckIds/ExtendIds/NackIds only if the failure is permanent,
    /// else this collection will be empty (but not null).
    /// </summary>
    internal IEnumerable<string> PermanentFailureIds => PermanentFailures.Select(kvp => kvp.Key);

    /// <summary>
    /// Gets the permanent failures.
    /// This collection will be populated with AckIds/NackIds/ExtendIds with their corresponding failures only if the failure is permanent,
    /// else this collection will be empty (but not null).
    /// </summary>
    internal IEnumerable<KeyValuePair<string, string>> PermanentFailures { get; }

    /// <summary>
    /// Gets the AckIds/ExtendIds/NackIds that are successful.
    /// This collection will be populated with AckIds/ExtendIds/NackIds only if they are successful,
    /// else this collection will be empty (but not null).
    /// </summary>
    internal IEnumerable<string> SuccessfulIds => MessageIds.Except(PermanentFailureIds).Except(TemporaryFailureIds);

    /// <summary>
    /// Gets all the AckIds/ExtendIds/NackIds for which the response encountered a <see cref="RpcException"/>.
    /// This collection is always populated with AckIds/ExtendIds/NackIds and is never null.
    /// </summary>
    internal IEnumerable<string> MessageIds { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AckError"/> class.
    /// </summary>
    /// <param name="messageIds">The collection of AckId/NackId/ExtendId for which response is being processed.</param>
    /// <param name="temporaryFailures">The collection of temporary failed AckId/NackId/ExtendId as key and their corresponding failure reason as value.</param>
    /// <param name="permanentFailures">The collection of permanent failed AckId/NackId/ExtendId as key and their corresponding failure reason as value.</param>
    internal AckError(IEnumerable<string> messageIds, IEnumerable<KeyValuePair<string, string>> temporaryFailures, IEnumerable<KeyValuePair<string, string>> permanentFailures)
    {
        MessageIds = messageIds;
        TemporaryFailures = temporaryFailures;
        PermanentFailures = permanentFailures;
    }

    /// <summary>
    /// Gets the permanent errors as the sequence of <see cref="AcknowledgementException"/>
    /// from the current instance of <seealso cref="AckError"/>.
    /// </summary>
    /// <remarks>
    /// This method will always return a sequence of <see cref="AcknowledgementException"/>. This sequence will be empty (but not null) if there are no permanent failures
    /// in the current instance of <seealso cref="AckError"/>.
    /// </remarks>
    /// <returns>The sequence of <see cref="AcknowledgementException"/> if there are permanent failures, empty otherwise.</returns>
    internal IEnumerable<AcknowledgementException> GetPermanentExceptions() =>
        HasPermanentFailures
            ? PermanentFailures.Select(AcknowledgementException.FromIdPermanentErrorPair).ToList()
            : Enumerable.Empty<AcknowledgementException>();

    /// <summary>
    /// Gets the sequence of <see cref="AckNackResponse"/>
    /// from the current instance of <seealso cref="AckError"/>.
    /// It returns the AckNackResponse of only the successful or permanently failed message IDs.
    /// </summary>
    /// <remarks>
    /// This method will always return a sequence of <see cref="AckNackResponse"/>. This sequence will be empty (but not null) if there are no successful responses or permanent failures
    /// in the current instance of <seealso cref="AckError"/>.
    /// </remarks>
    /// <returns>The sequence of <see cref="AckNackResponse"/> if there are successful responses or permanent failures, empty otherwise.</returns>
    internal IEnumerable<AckNackResponse> GetAckNackResponses() =>
        PermanentFailures.Select(AckNackResponse.FromIdPermanentErrorPair)
        .Concat(SuccessfulIds.Select(AckNackResponse.FromSuccessfulId));

    /// <summary>
    /// Gets the <see cref="AckError"/> from the <see cref="RpcException"/> while calling Acknowledge or ModifyAckDeadline RPC.
    /// </summary>
    /// <param name="rpcException">The underlying <see cref="RpcException"/>.</param>
    /// <param name="ids">The ids for which the Acknowledge/ModifyAckDeadline RPC was called.</param>
    /// <returns>The populated instance of <see cref="AckError"/> containing temporary and permanent failures.</returns>
    internal static AckError ForRpcException(RpcException rpcException, IEnumerable<string> ids)
    {
        GaxPreconditions.CheckNotNull(rpcException, nameof(rpcException));
        GaxPreconditions.CheckNotNull(ids, nameof(ids));

        // We can have complete or partial failure. We classify the error as temporary or permanent
        // based on the error message starting from TRANSIENT_FAILURE_ or PERMANENT_FAILURE_ (which is ugly but that's the way it is)
        // and return:
        // the temporary errors in temporaryErrors collection and
        // the permanent errors in permanentErrors collection.
        // For exactly once delivery, the metadata of the rpcException contains the error details. A sample metadata is shown below:
        // {
        //    "ack_id_1": "PERMANENT_FAILURE_INVALID_ACK_ID",
        //    "ack_id_2": "PERMANENT_FAILURE_INVALID_ACK_ID",
        //    "ack_id_3": "TRANSIENT_FAILURE_UNORDERED_ACK_ID"
        // }
        var metadata = rpcException.GetErrorInfo()?.Metadata ?? Enumerable.Empty<KeyValuePair<string, string>>();
        var temporaryErrors = metadata.Where(j => j.Value.StartsWith("TRANSIENT_FAILURE_", StringComparison.Ordinal));
        var permanentErrors = metadata.Where(j => j.Value.StartsWith("PERMANENT_FAILURE_", StringComparison.Ordinal));
        if (temporaryErrors.Any() || permanentErrors.Any())
        {
            // If temporary or permanent error messages are present, it means the entire request hasn't failed with a permanent error.
            return new AckError(ids, temporaryErrors, permanentErrors);
        }
        // If there's no metadata, we may still retry all, depending on the gRPC status code.
        if (ShouldRetryAll(rpcException)) 
        {
            // Return all ids in temporary failures and empty permanent failures, so that the caller can retry the whole temporary batch.
            return new AckError(ids, ids.ToDictionary(key => key, value => rpcException.Status.StatusCode.ToString()), permanentErrors);
        }
        // Now, if there's no metadata and the gRPC status code is not retryable, it means the entire request has failed with a permanent error.
        // It may be due to a gRPC error like a failed precondition or a permission denied error or other permanent error.
        return new AckError(ids, temporaryErrors, ids.ToDictionary(key => key, value => rpcException.Status.StatusCode.ToString()));
    }

    /// <summary>
    /// Checks if the gRPC StatusCode of <see cref="RpcException"/> is retry-able and
    /// the entire batch of AckIds/NackIds/ExtendIds should be retried for Acknowledge/ModifyAckDeadline RPC.
    /// </summary>
    /// <param name="e">The <see cref="RpcException"/>.</param>
    /// <returns><c>True</c> if all AckIds/NackIds/ExtendIds should be retried, else <c>false</c>.</returns>
    /// <remarks>
    /// This API should be used for exactly-once subscriptions only.
    /// </remarks>
    internal static bool ShouldRetryAll(RpcException e) => e.Status.StatusCode switch
    {
        StatusCode.DeadlineExceeded => true,
        StatusCode.ResourceExhausted => true,
        StatusCode.Aborted => true,
        StatusCode.Internal => true,
        StatusCode.Unavailable => true,
        _ => false,
    };
}
