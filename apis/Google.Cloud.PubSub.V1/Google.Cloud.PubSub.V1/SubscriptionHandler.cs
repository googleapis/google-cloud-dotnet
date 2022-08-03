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
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.PubSub.V1.SubscriberClient;

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// TODO: Documentation. But basically customers would subclass this.
/// </summary>
public abstract class SubscriptionHandler
{
    /// <summary>
    /// TODO
    /// </summary>
    public abstract Task<Reply> HandleMessage(PubsubMessage message, CancellationToken cancellationToken);

    /// <summary>
    /// Called when an ACK operation returns, indicating the status of each message.
    /// </summary>
    /// <remarks>
    /// The default implementation of this method does nothing.
    /// </remarks>
    public virtual void HandleAckResponses(IReadOnlyList<AckNackResponse> details)
    {
    }

    /// <summary>
    /// Called when a NACK operation returns, indicating the status of each message.
    /// </summary>
    /// <remarks>
    /// The default implementation of this method does nothing.
    /// </remarks>
    public virtual void HandleNackResponses(IReadOnlyList<AckNackResponse> details)
    {
    }
}

/// <summary>
/// A public representation of a response to an ack or nack.
/// This probably needs a lot more detail...
/// </summary>
public class AckNackResponse
{
    /// <summary>
    /// The ID of the message being acked/nacked.
    /// </summary>
    public string MessageId { get; }

    /// <summary>
    /// The status of the response.
    /// </summary>
    public AckNackResponseStatus Status { get; }

    /// <summary>
    /// The failure message, if any.
    /// </summary>
    public string FailureMessage { get; }
}

/// <summary>
/// 
/// </summary>
public enum AckNackResponseStatus
{
    /// <summary>
    /// The ack/nack operation was successful.
    /// </summary>
    Success = 0,

    /// <summary>
    /// The ack/nack operation failed, but will be retried.
    /// </summary>
    TemporaryFailure = 1,

    /// <summary>
    /// The ack/nack operation failed, and will not be retried.
    /// </summary>
    PermanentFailure = 2,
}

/// <summary>
/// Simple implementation of SubscriptionHandler using a delegate.
/// This is present to provide compatibility with older SubscriberClient.StartAsync implementations.
/// </summary>
internal sealed class SimpleSubscriptionHandler : SubscriptionHandler
{
    private readonly Func<PubsubMessage, CancellationToken, Task<Reply>> _handler;

    internal SimpleSubscriptionHandler(Func<PubsubMessage, CancellationToken, Task<Reply>> handler) =>
        _handler = handler;

    public override Task<Reply> HandleMessage(PubsubMessage message, CancellationToken cancellationToken) =>
        _handler(message, cancellationToken);
}
