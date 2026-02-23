// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// A PubSub subscriber that is associated with a specific <see cref="SubscriptionName"/>.
/// </summary>
/// <remarks>
/// <para>To receive messages, the <see cref="StartAsync(SubscriptionHandler)"/> method must be called,
/// with a suitable message handler.</para>
/// <para>The message handler <see cref="Reply"/> states whether to acknowledge the message;
/// if acknowledged then (under normal conditions) it will not be received on this subscription again.</para>
/// <para>But note that it is always possible to receive duplicate messages. This services
/// guarantees "at least once" delivery, not "only once" delivery.</para>
/// <para>
/// This class implements the <see cref="IAsyncDisposable"/> interface. However, it is recommended to create a single <c>SubscriberClient</c> instance, and use it throughout
/// the lifetime of the application. If the <c>SubscriberClient</c> is registered in a dependency injection container, its
/// <c>DisposeAsync</c> method will be called automatically.
/// </para>
/// </remarks>
public abstract partial class SubscriberClient : IAsyncDisposable
{
    /// <summary>
    /// Reply from a message handler; whether to <see cref="Ack"/>
    /// or <see cref="Nack"/> the message to the server.
    /// </summary>
    public enum Reply
    {
        /// <summary>
        /// Message not handled successfully.
        /// </summary>
        Nack = 0,

        /// <summary>
        /// Message handled successfully.
        /// </summary>
        Ack = 1,
    }

    /// <summary>
    /// Settings available for subscriber shutdown.
    /// </summary>
    public enum SubscriberShutdownSetting
    {
        /// <summary>
        /// Stops streaming new upstream messages and then continues processing all received messages. If there are
        /// still messages that need to be processed 30s before the timeout is reached it will switch to <see cref="NackImmediately"/>.
        /// </summary>
        WaitForProcessing = 0,

        /// <summary>
        /// Stops streaming new upstream messages and then aggressively releases unhandled messages by sending Nack responses.
        /// Already handled messages will still be acknowledged.
        /// </summary>
        NackImmediately = 1,
    }

    /// <summary>
    /// Default <see cref="FlowControlSettings"/> for <see cref="SubscriberClient"/>.
    /// Allows 1,000 outstanding messages; and 100Mb outstanding bytes.
    /// </summary>
    /// <returns>Default <see cref="FlowControlSettings"/> for <see cref="SubscriberClient"/>.</returns>
    public static FlowControlSettings DefaultFlowControlSettings { get; } = new FlowControlSettings(1_000, 100_000_000);

    /// <summary>
    /// The service-defined minimum message acknowledgement deadline of 10 seconds.
    /// </summary>
    public static TimeSpan MinimumAckDeadline { get; } = TimeSpan.FromSeconds(10);

    /// <summary>
    /// The service-defined maximum message acknowledgement deadline of 10 minutes.
    /// </summary>
    public static TimeSpan MaximumAckDeadline { get; } = TimeSpan.FromMinutes(10);

    /// <summary>
    /// The default message acknowledgement deadline of 60 seconds.
    /// </summary>
    public static TimeSpan DefaultAckDeadline { get; } = TimeSpan.FromSeconds(60);

    /// <summary>
    /// The default message acknowledgement deadline of 60 seconds for exactly-once delivery subscriptions.
    /// </summary>
    public static TimeSpan DefaultAckDeadlineForExactlyOnceDelivery { get; } = TimeSpan.FromSeconds(60);

    /// <summary>
    /// The minimum message acknowledgement extension window of 50 milliseconds.
    /// </summary>
    public static TimeSpan MinimumAckExtensionWindow { get; } = TimeSpan.FromMilliseconds(50);

    /// <summary>
    /// The minimum message acknowledgement extension window of 60 seconds for exactly once delivery subscriptions.
    /// </summary>
    /// <remarks>
    /// This property is deprecated. Use <see cref="DefaultAckDeadlineForExactlyOnceDelivery"/> instead.
    /// </remarks>
    [Obsolete("Use DefaultAckDeadlineForExactlyOnceDelivery instead.")]
    public static TimeSpan MinimumAckExtensionWindowForExactlyOnceDelivery { get; } = TimeSpan.FromSeconds(60);

    /// <summary>
    /// The default message acknowledgement extension window of 15 seconds.
    /// </summary>
    public static TimeSpan DefaultAckExtensionWindow { get; } = TimeSpan.FromSeconds(15);

    /// <summary>
    /// The enforced 5 second minimum duration between obtaining a lease on a message and when a lease extension can be requested.
    /// </summary>
    public static TimeSpan MinimumLeaseExtensionDelay { get; } = TimeSpan.FromSeconds(5);

    /// <summary>
    /// The default maximum total acknowledgement extension of 60 minutes.
    /// </summary>
    public static TimeSpan DefaultMaxTotalAckExtension { get; } = TimeSpan.FromMinutes(60);

    /// <summary>
    /// The default <see cref="Settings.DisposeTimeout"/> of 5 seconds for the <see cref="SubscriberClient"/>.
    /// </summary>
    public static TimeSpan DefaultDisposeTimeout { get; } = TimeSpan.FromSeconds(5);

    /// <summary>
    /// The associated <see cref="SubscriptionName"/>.
    /// </summary>
    public virtual SubscriptionName SubscriptionName => throw new NotImplementedException();

    /// <summary>
    /// Create a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>, using default settings.
    /// </summary>
    /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
    /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
    public static SubscriberClient Create(SubscriptionName subscriptionName) =>
        CreateBuilder(subscriptionName, null, null).Build();

    /// <summary>
    /// Creates a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>, using default settings.
    /// </summary>
    /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
    /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
    public static Task<SubscriberClient> CreateAsync(SubscriptionName subscriptionName) =>
        CreateBuilder(subscriptionName, null, null).BuildAsync();

    /// <summary>
    /// Create a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.
    /// The default <paramref name="settings"/> and <paramref name="clientCreationSettings"/> are suitable for machines with
    /// high network bandwidth (e.g. Google Compute Engine instances). If running with more limited network bandwidth, some
    /// settings may need changing; especially <see cref="Settings.AckDeadline"/>.
    /// By default this method generates a gRPC channel per CPU core; if using a high-core-count machine and using many
    /// clients concurrently then this may need reducing; use the setting <see cref="ClientCreationSettings.ClientCount"/>.
    /// </summary>
    /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
    /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
    /// <see cref="SubscriberClient"/>s.</param>
    /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="SubscriberClient"/>.</param>
    /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
    [Obsolete("Use SubscriberClient.Create(SubscriptionName) to use the default settings, or SubscriberClientBuilder for customization.")]
    public static SubscriberClient Create(SubscriptionName subscriptionName, ClientCreationSettings clientCreationSettings = null, Settings settings = null) =>
        CreateBuilder(subscriptionName, clientCreationSettings, settings).Build();

    /// <summary>
    /// Create a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.
    /// The default <paramref name="settings"/> and <paramref name="clientCreationSettings"/> are suitable for machines with
    /// high network bandwidth (e.g. Google Compute Engine instances). If running with more limited network bandwidth, some
    /// settings may need changing; especially <see cref="Settings.AckDeadline"/>.
    /// By default this method generates a gRPC channel per CPU core; if using a high-core-count machine and using many
    /// clients concurrently then this may need reducing; use the setting <see cref="ClientCreationSettings.ClientCount"/>.
    /// </summary>
    /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
    /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
    /// <see cref="SubscriberClient"/>s.</param>
    /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="SubscriberClient"/>.</param>
    /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
    [Obsolete("Use SubscriberClient.Create(SubscriptionName) to use the default settings, or SubscriberClientBuilder for customization.")]
    public static Task<SubscriberClient> CreateAsync(SubscriptionName subscriptionName, ClientCreationSettings clientCreationSettings = null, Settings settings = null) =>
        CreateBuilder(subscriptionName, clientCreationSettings, settings).BuildAsync();

#pragma warning disable CS0618 // Type or member is obsolete
    private static SubscriberClientBuilder CreateBuilder(SubscriptionName subscriptionName, ClientCreationSettings clientCreationSettings, Settings settings) =>
        new SubscriberClientBuilder
        {
            SubscriptionName = GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName)),
            Settings = settings,
            EmulatorDetection = clientCreationSettings?.EmulatorDetection ?? EmulatorDetection.None,
            ClientCount = clientCreationSettings?.ClientCount,
            ChannelCredentials = clientCreationSettings?.Credentials,
            Endpoint = clientCreationSettings?.ServiceEndpoint,
            ApiSettings = clientCreationSettings?.SubscriberServiceApiSettings
        };
#pragma warning restore CS0618 // Type or member is obsolete

    /// <summary>
    /// Starts receiving messages. The returned <see cref="Task"/> completes when either <see cref="StopAsync(CancellationToken)"/> is called
    /// or if an unrecoverable fault occurs. See <see cref="StopAsync(CancellationToken)"/> for more details.
    /// This method cannot be called more than once per <see cref="SubscriberClient"/> instance.
    /// </summary>
    /// <param name="handlerAsync">The handler function that is passed all received messages.
    /// This function may be called on multiple threads concurrently. Return <see cref="Reply.Ack"/> from this function
    /// to acknowledge this message (implying it won't be received again); or return <see cref="Reply.Nack"/> to Not
    /// acknowledge this message (implying it will be received again). If this function throws any Exception, then
    /// it behaves as if it returned <see cref="Reply.Nack"/>.</param>
    /// <returns>A <see cref="Task"/> that completes when the subscriber is stopped, or if an unrecoverable error occurs.</returns>
    public virtual Task StartAsync(Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync) =>
        StartAsync(new SimpleSubscriptionHandler(handlerAsync));

    /// <summary>
    /// Starts receiving messages. The returned <see cref="Task"/> completes when either <see cref="StopAsync(CancellationToken)"/> is called
    /// or if an unrecoverable fault occurs. See <see cref="StopAsync(CancellationToken)"/> for more details.
    /// This method cannot be called more than once per <see cref="SubscriberClient"/> instance.
    /// </summary>
    /// <param name="handler">The handler that is passed all received messages and acknowledgement results.</param>
    /// <returns>A <see cref="Task"/> that completes when the subscriber is stopped, or if an unrecoverable error occurs.</returns>
    public virtual Task StartAsync(SubscriptionHandler handler) => throw new NotImplementedException();

    /// <summary>
    /// Stop this <see cref="SubscriberClient"/>. Cancelling <paramref name="hardStopToken"/> aborts the
    /// clean stop process, and may leave some handled messages un-acknowledged.
    /// The returned <see cref="Task"/> completes when all handled messages have been acknowledged.
    /// The returned <see cref="Task"/> faults if there is an unrecoverable error with the underlying service.
    /// The returned <see cref="Task"/> cancels if <paramref name="hardStopToken"/> is cancelled.
    /// </summary>
    /// <param name="hardStopToken">Cancel this <see cref="CancellationToken"/> to abort handlers and acknowledgement.</param>
    /// <returns>A <see cref="Task"/> that completes when all handled messages have been acknowledged;
    /// faults on unrecoverable service errors; or cancels if <paramref name="hardStopToken"/> is cancelled.</returns>
    [Obsolete("Use StopAsync(SubscriberShutdownSetting, TimeSpan?, CancellationToken) instead.")]
    public virtual Task StopAsync(CancellationToken hardStopToken) => throw new NotImplementedException();

    /// <summary>
    /// Stop this <see cref="SubscriberClient"/>. If <paramref name="timeout"/> expires, the
    /// clean stop process will be aborted, and may leave some handled messages un-acknowledged.
    /// The returned <see cref="Task"/> completes when all handled messages have been acknowledged.
    /// The returned <see cref="Task"/> faults if there is an unrecoverable error with the underlying service.
    /// The returned <see cref="Task"/> cancels if <paramref name="timeout"/> expires.
    /// </summary>
    /// <param name="timeout">After this period, abort handling and acknowledging messages.</param>
    /// <returns>A <see cref="Task"/> that completes when all handled messages have been acknowledged;
    /// faults on unrecoverable service errors; or cancels if <paramref name="timeout"/> expires.</returns>
    [Obsolete("Use StopAsync(SubscriberShutdownSetting, TimeSpan?, CancellationToken) instead.")]
    public virtual Task StopAsync(TimeSpan timeout) => StopAsync(SubscriberShutdownSetting.WaitForProcessing, timeout);

    /// <summary>
    /// Stop this <see cref="SubscriberClient"/>.
    /// The returned <see cref="Task"/> completes when all handled messages have been acknowledged.
    /// The returned <see cref="Task"/> faults if there is an unrecoverable error with the underlying service.
    /// </summary>
    /// <param name="shutdownSetting">The <see cref="SubscriberShutdownSetting"/> to use for shutdown.</param>
    /// <param name="timeout">Optional. The timeout for the shutdown process. If not specified, a default 1-hour timeout is used.</param>
    /// <param name="cancellationToken">Optional. A <see cref="CancellationToken"/> that can be used to abort the graceful shutdown and trigger an immediate hard stop.</param>
    /// <returns>A <see cref="Task"/> that completes when the subscriber is stopped, or if an unrecoverable error occurs.</returns>
    public virtual Task StopAsync(SubscriberShutdownSetting shutdownSetting, TimeSpan? timeout = null, CancellationToken cancellationToken = default) => throw new NotImplementedException();

    /// <summary>
    /// Disposes this <see cref="SubscriberClient"/> asynchronously.
    /// </summary>
    /// <remarks>
    /// This method asynchronously waits for the time interval as specified in the <see cref="Settings.DisposeTimeout"/>
    /// for the <see cref="SubscriberClient"/> to acknowledge the handled messages. If the clean shutdown is not
    /// complete after this time, it is aborted; this may leave some handled messages un-acknowledged.
    /// The time interval can be customized by setting the <see cref="Settings.DisposeTimeout"/>.
    /// </remarks>
    public virtual ValueTask DisposeAsync() => throw new NotImplementedException();
}
