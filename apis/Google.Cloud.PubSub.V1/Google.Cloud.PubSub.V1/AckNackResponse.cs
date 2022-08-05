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

using System.Collections.Generic;

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// A public representation of a response to an ACKnowledge (ACK) or Not ACKnowledge (NACK) request.
/// </summary>
public sealed class AckNackResponse
{
    /// <summary>
    /// The ID of the message being ACK-ed or NACK-ed.
    /// </summary>
    public string MessageId { get; }

    /// <summary>
    /// The status of the ACK/NACK response.
    /// </summary>
    public AcknowledgementStatus Status { get; }

    /// <summary>
    /// The failure message, if any. This will be null if the response is successful.
    /// </summary>
    public string FailureMessage { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AckNackResponse"/> class.
    /// </summary>
    /// <param name="messageId">The ID of the message being ACK-ed/NACK-ed.</param>
    /// <param name="status">The status of ACK/NACK response.</param>
    /// <param name="failureMessage">The failure message. This can be null if ACK/NACK is successful.</param>
    public AckNackResponse(string messageId, AcknowledgementStatus status, string failureMessage)
    {
        MessageId = messageId;
        Status = status;
        FailureMessage = failureMessage;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AckNackResponse"/> class from the pair of message ID and its corresponding permanent failure.
    /// </summary>
    /// <param name="idPermanentErrorPair">The <see cref="KeyValuePair{TKey, TValue}"/> of message ID as key and permanent error message as value.</param>
    /// <returns>A new instance of the <see cref="AckNackResponse"/>.</returns>
    internal static AckNackResponse FromIdPermanentErrorPair(KeyValuePair<string, string> idPermanentErrorPair)
    {
        var acknowledgementException = AcknowledgementException.FromIdPermanentErrorPair(idPermanentErrorPair);
        return new AckNackResponse(idPermanentErrorPair.Key, acknowledgementException.Status, acknowledgementException.Message);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AckNackResponse"/> class from the message ID that is successfully ACK-ed/NACK-ed.
    /// </summary>
    /// <param name="successfulId">The successful message ID.</param>
    /// <returns>A new instance of the <see cref="AckNackResponse"/>.</returns>
    internal static AckNackResponse FromSuccessfulId(string successfulId) =>
        new AckNackResponse(successfulId, AcknowledgementStatus.Success, default);
}
