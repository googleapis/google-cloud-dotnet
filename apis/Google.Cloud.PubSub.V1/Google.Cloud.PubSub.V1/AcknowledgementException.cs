// Copyright 2022 Google LLC
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

using System;
using System.Collections.Generic;

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// Represents an exception while calling the Acknowledge or ModifyAckDeadline RPC fails with a permanent error.
/// </summary>
public sealed class AcknowledgementException : Exception
{
    private static readonly Dictionary<AcknowledgementStatus, string> s_errorMessages =
        new Dictionary<AcknowledgementStatus, string>
        {
            { AcknowledgementStatus.PermissionDenied, "Insufficient permission to execute the specified operation." },
            { AcknowledgementStatus.InvalidAckId, "Acknowledgement ID is malformed or acknowledgement deadline has expired." },
            { AcknowledgementStatus.FailedPrecondition, "Operation was rejected because the system is not in a state required for the operation's execution." },
            { AcknowledgementStatus.Other, "An unknown error occurred." }
        };

    /// <summary>
    /// Gets the status of the acknowledgement.
    /// </summary>
    public AcknowledgementStatus Status { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AcknowledgementException"/> class.
    /// </summary>
    /// <param name="status">The <see cref="AcknowledgementStatus"/> for the exception.</param>
    /// <param name="message">A descriptive message about the exception.</param>
    public AcknowledgementException(AcknowledgementStatus status, string message) : base($"{status}: {message}: {GetErrorMessageFromStatus(status)}") =>
        Status = status;

    /// <summary>
    /// Gets the <see cref="AcknowledgementException"/> from the ackId and permanent error message pair.
    /// </summary>
    /// <param name="idErrorPair">The <see cref="KeyValuePair{TKey, TValue}"/> of ackId as key and permanent error message as value.</param>
    /// <returns>The <see cref="AcknowledgementException"/>.</returns>
    internal static AcknowledgementException FromIdErrorPair(KeyValuePair<string, string> idErrorPair) => idErrorPair.Value switch
    {
        // TODO: We have an enum and string in switch. Check if we can improve it.
        "PERMANENT_FAILURE_INVALID_ACK_ID" => new AcknowledgementException(AcknowledgementStatus.InvalidAckId, idErrorPair.Key),
        nameof(AcknowledgementStatus.FailedPrecondition) => new AcknowledgementException(AcknowledgementStatus.FailedPrecondition, idErrorPair.Key),
        nameof(AcknowledgementStatus.PermissionDenied) => new AcknowledgementException(AcknowledgementStatus.PermissionDenied, idErrorPair.Key),
        _ => new AcknowledgementException(AcknowledgementStatus.Other, idErrorPair.Key),
    };

    /// <summary>
    /// Gets the error message for the given <see cref="AcknowledgementStatus"/>.
    /// </summary>
    /// <param name="status">The <see cref="AcknowledgementStatus"/>.</param>
    /// <returns>The error message.</returns>
    private static string GetErrorMessageFromStatus(AcknowledgementStatus status) =>
        s_errorMessages.TryGetValue(status, out var message) ? message : s_errorMessages[AcknowledgementStatus.Other];
}
