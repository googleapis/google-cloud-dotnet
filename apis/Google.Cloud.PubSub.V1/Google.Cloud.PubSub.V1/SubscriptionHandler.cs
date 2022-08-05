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
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.PubSub.V1.SubscriberClient;

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// This abstract class provides the message handler to handle and process the messages.
/// It also provides the ACKnowledge (ACK) and Not ACKnowledge (NACK) response handlers which indicates the ACK/NACK status of each message for the subscription.
/// The users of subscription should inherit from this class and provide their implementation to handle messages and their acknowledgement response.
/// </summary>
public abstract class SubscriptionHandler
{
    /// <summary>
    /// The handler function that is passed all received messages.
    /// This function may be called on multiple threads concurrently. Return <see cref="Reply.Ack"/> from this function
    /// to ACKnowledge this message (implying it won't be received again); or return <see cref="Reply.Nack"/> to Not
    /// ACKnowledge this message (implying it will be received again). If this function throws any Exception, then
    /// it behaves as if it returned <see cref="Reply.Nack"/>.
    /// </summary>
    /// <remarks>
    /// The users of subscription must implement this function to handle the messages.
    /// </remarks>
    public abstract Task<Reply> HandleMessage(PubsubMessage message, CancellationToken cancellationToken);

    /// <summary>
    /// This handler function is called when an ACKnowledge (ACK) operation returns, indicating the status of successful or permanently failed messages.
    /// </summary>
    /// <param name="responses">The read-only collection of the <see cref="AckNackResponse"/>
    /// indicating the <see cref="SubscriberClient.Reply.Ack"/> status of successful or permanently failed messages. This collection may be empty but never null.
    /// For exactly once delivery subscription, this collection contains only the successful or permanently failed messages. In this case,
    /// the messages that have failed with temporary errors are not included in this collection as their status may change in the future.
    /// For non-exactly once subscriptions, this collection contains the ACK status as success for all the messages. In this case,
    /// a message may appear multiple times with the same status.</param>
    /// <remarks>
    /// The default implementation of this method does nothing. The users of subscription should override this method to handle the ACK response for exactly once delivery subscriptions.
    /// This is optional for non-exactly once delivery subscriptions.
    /// <para>
    /// Any exception thrown from this method will terminate the <see cref="SubscriberClient"/>.
    /// </para>
    /// </remarks>
    public virtual void HandleAckResponses(IReadOnlyList<AckNackResponse> responses)
    {
    }

    /// <summary>
    /// This handler function is called when a Not ACKnowledge (NACK) operation returns, indicating the status of successful or permanently failed messages.
    /// </summary>
    /// <param name="responses">The read-only collection of the <see cref="AckNackResponse"/>
    /// indicating the <see cref="SubscriberClient.Reply.Nack"/> status of successful or permanently failed messages. This collection may be empty but never null.
    /// For exactly once delivery subscription, this collection contains only the successful or permanently failed messages. In this case,
    /// the messages that have failed with temporary errors are not included in this collection as their status may change in the future.
    /// For non-exactly once subscriptions, this collection contains the NACK status as success for all the messages. In this case,
    /// a message may appear multiple times with the same status.</param>
    /// <remarks>
    /// The default implementation of this method does nothing. The users of subscription should override this method to handle the NACK response for exactly once delivery subscriptions.
    /// This is optional for non-exactly once delivery subscriptions.
    /// <para>
    /// Any exception thrown from this method will terminate the <see cref="SubscriberClient"/>.
    /// </para>
    /// </remarks>
    public virtual void HandleNackResponses(IReadOnlyList<AckNackResponse> responses)
    {
    }
}
