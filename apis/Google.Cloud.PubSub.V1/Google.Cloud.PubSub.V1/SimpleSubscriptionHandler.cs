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
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.PubSub.V1.SubscriberClient;

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// This class is a simple implementation of <see cref="SubscriptionHandler"/> using a delegate.
/// This is present to provide compatibility with the older <see cref="SubscriberClient.StartAsync(Func{PubsubMessage, CancellationToken, Task{Reply}})"/> implementation.
/// </summary>
internal sealed class SimpleSubscriptionHandler : SubscriptionHandler
{
    private readonly Func<PubsubMessage, CancellationToken, Task<Reply>> _handler;

    /// <summary>
    /// Initializes a new instance of the <see cref="SimpleSubscriptionHandler"/> class.
    /// </summary>
    /// <param name="handler">The handler delegate that is passed all the received messages.</param>
    internal SimpleSubscriptionHandler(Func<PubsubMessage, CancellationToken, Task<Reply>> handler) =>
        _handler = handler;

    /// <inheritdoc/>
    public override Task<Reply> HandleMessage(PubsubMessage message, CancellationToken cancellationToken) =>
        _handler(message, cancellationToken);
}
