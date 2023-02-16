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
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// A PubSub publisher that is associated with a specific <see cref="TopicName"/>.
/// </summary>
/// <remarks>
/// This class implements the <see cref="IAsyncDisposable"/> interface. However, it is recommended to create a single <c>PublisherClient</c> instance and use it throughout
/// the lifetime of the application. If the <c>PublisherClient</c> is registered in a dependency injection container, its
/// <c>DisposeAsync</c> method will be called automatically.
/// </remarks>
public abstract partial class PublisherClient : IAsyncDisposable
{
    /// <summary>
    /// Default <see cref="BatchingSettings"/> for <see cref="PublisherClient"/>.
    /// Default values are:
    /// <see cref="BatchingSettings.ElementCountThreshold"/> = 100;
    /// <see cref="BatchingSettings.ByteCountThreshold"/> = 1,000,000;
    /// <see cref="BatchingSettings.DelayThreshold"/> = 10 milliseconds;
    /// </summary>
    public static BatchingSettings DefaultBatchingSettings { get; } = new BatchingSettings(100L, 1_000_000L, TimeSpan.FromMilliseconds(10));

    /// <summary>
    /// The absolute maximum <see cref="BatchingSettings"/> supported by the service.
    /// Maximum values are:
    /// <see cref="BatchingSettings.ElementCountThreshold"/> = 1,000;
    /// <see cref="BatchingSettings.ByteCountThreshold"/> = 10,000,000;
    /// </summary>
    public static BatchingSettings ApiMaxBatchingSettings { get; } = new BatchingSettings(1000L, 10_000_000L, null);

    /// <summary>
    /// The default <see cref="Settings.DisposeTimeout"/> of 5 seconds for the <see cref="PublisherClient"/>.
    /// </summary>
    public static TimeSpan DefaultDisposeTimeout { get; } = TimeSpan.FromSeconds(5);

    /// <summary>
    /// The associated <see cref="TopicName"/>. 
    /// </summary>
    public virtual TopicName TopicName => throw new NotImplementedException();

    /// <summary>
    /// Create a <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>, using default settings.
    /// </summary>
    /// <param name="topicName">The <see cref="TopicName"/> to publish messages to. Must not be null.</param>
    /// <returns>A <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>.</returns>
    public static PublisherClient Create(TopicName topicName) =>
        CreateBuilder(topicName, null, null).Build();

    /// <summary>
    /// Creates a <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>, using default settings.
    /// </summary>
    /// <param name="topicName">The <see cref="TopicName"/> to publish messages to. Must not be null.</param>
    /// <returns>A <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>.</returns>
    public static Task<PublisherClient> CreateAsync(TopicName topicName) =>
        CreateBuilder(topicName, null, null).BuildAsync();

    /// <summary>
    /// Create a <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>.
    /// The default <paramref name="settings"/> and <paramref name="clientCreationSettings"/> are suitable for machines with
    /// high network bandwidth (e.g. Google Compute Engine instances). If running with more limited network bandwidth, some
    /// settings may need changing; especially
    /// <see cref="ClientCreationSettings.PublisherServiceApiSettings"/>.<see cref="PublisherServiceApiSettings.PublishSettings"/>.<see cref="CallSettings.Retry"/>.
    /// By default this method generates a gRPC channel per CPU core; if using a high-core-count machine and using many
    /// clients concurrently then this may need reducing; use the setting <see cref="ClientCreationSettings.ClientCount"/>.
    /// </summary>
    /// <param name="topicName">The <see cref="TopicName"/> to publish messages to. Must not be null.</param>
    /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
    /// <see cref="PublisherServiceApiClient"/>s.</param>
    /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="PublisherClient"/>.</param>
    /// <returns>A <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>.</returns>
    [Obsolete("Use PublisherClient.Create(TopicName) to use the default settings, or PublisherClientBuilder for customization.")]
    public static PublisherClient Create(TopicName topicName, ClientCreationSettings clientCreationSettings = null, Settings settings = null) =>
        CreateBuilder(topicName, clientCreationSettings, settings).Build();

    /// <summary>
    /// Create a <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>.
    /// The default <paramref name="settings"/> and <paramref name="clientCreationSettings"/> are suitable for machines with
    /// high network bandwidth (e.g. Google Compute Engine instances). If running with more limited network bandwidth, some
    /// settings may need changing; especially
    /// <see cref="ClientCreationSettings.PublisherServiceApiSettings"/>.<see cref="PublisherServiceApiSettings.PublishSettings"/>.<see cref="CallSettings.Retry"/>.
    /// By default this method generates a gRPC channel per CPU core; if using a high-core-count machine and using many
    /// clients concurrently then this may need reducing; use the setting <see cref="ClientCreationSettings.ClientCount"/>.
    /// </summary>
    /// <param name="topicName">The <see cref="TopicName"/> to publish messages to. Must not be null.</param>
    /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
    /// <see cref="PublisherServiceApiClient"/>s.</param>
    /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="PublisherClient"/>.</param>
    /// <returns>A <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>.</returns>
    [Obsolete("Use PublisherClient.CreateAsync(TopicName) to use the default settings, or PublisherClientBuilder for customization.")]
    public static Task<PublisherClient> CreateAsync(TopicName topicName, ClientCreationSettings clientCreationSettings = null, Settings settings = null) =>
        CreateBuilder(topicName, clientCreationSettings, settings).BuildAsync();

#pragma warning disable CS0618 // Type or member is obsolete
    private static PublisherClientBuilder CreateBuilder(TopicName topicName, ClientCreationSettings clientCreationSettings, Settings settings) =>
        new PublisherClientBuilder
        {
            TopicName = GaxPreconditions.CheckNotNull(topicName, nameof(topicName)),
            Settings = settings,
            EmulatorDetection = clientCreationSettings?.EmulatorDetection ?? EmulatorDetection.None,
            ClientCount = clientCreationSettings?.ClientCount,
            ChannelCredentials = clientCreationSettings?.Credentials,
            Endpoint = clientCreationSettings?.ServiceEndpoint,
            ApiSettings = clientCreationSettings?.PublisherServiceApiSettings
        };
#pragma warning restore CS0618 // Type or member is obsolete

    /// <summary>
    /// Publish a message to the topic specified in <see cref="TopicName"/>.
    /// </summary>
    /// <param name="message">The <see cref="PubsubMessage"/> to publish.</param>
    /// <returns>A task which completes once the message has been published.
    /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
    public virtual Task<string> PublishAsync(PubsubMessage message) => throw new NotImplementedException();

    /// <summary>
    /// Publish a message to the topic specified in <see cref="TopicName"/>.
    /// </summary>
    /// <param name="orderingKey">The ordering key to use for this message.</param>
    /// <param name="message">The string to publish.</param>
    /// <param name="encoding">The encoding for string to byte conversion.
    /// If <c>null</c>, defaults to <see cref="System.Text.Encoding.UTF8"/>.</param>
    /// <returns>A task which completes once the message has been published.
    /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
    public virtual Task<string> PublishAsync(string orderingKey, string message, System.Text.Encoding encoding = null) =>
        PublishAsync(new PubsubMessage
        {
            OrderingKey = orderingKey ?? "",
            Data = encoding == null ? ByteString.CopyFromUtf8(message) : ByteString.CopyFrom(encoding.GetBytes(message))
        });

    /// <summary>
    /// Publish a message to the topic specified in <see cref="TopicName"/>.
    /// </summary>
    /// <param name="message">The string to publish.</param>
    /// <param name="encoding">The encoding for string to byte conversion.
    /// If <c>null</c>, defaults to <see cref="System.Text.Encoding.UTF8"/>.</param>
    /// <returns>A task which completes once the message has been published.
    /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
    public virtual Task<string> PublishAsync(string message, System.Text.Encoding encoding = null) => PublishAsync("", message, encoding);

    /// <summary>
    /// Publish a message to the topic specified in <see cref="TopicName"/>.
    /// </summary>
    /// <param name="orderingKey">The ordering key to use for this message.</param>
    /// <param name="message">The message to publish.</param>
    /// <returns>A task which completes once the message has been published.
    /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
    public virtual Task<string> PublishAsync(string orderingKey, IMessage message) =>
        PublishAsync(new PubsubMessage
        {
            OrderingKey = orderingKey ?? "",
            Data = message.ToByteString()
        });

    /// <summary>
    /// Publish a message to the topic specified in <see cref="TopicName"/>.
    /// </summary>
    /// <param name="message">The message to publish.</param>
    /// <returns>A task which completes once the message has been published.
    /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
    public virtual Task<string> PublishAsync(IMessage message) => PublishAsync("", message);

    /// <summary>
    /// Publish a message to the topic specified in <see cref="TopicName"/>.
    /// </summary>
    /// <param name="orderingKey">The ordering key to use for this message.</param>
    /// <param name="message">The <see cref="ByteString"/> to publish.</param>
    /// <returns>A task which completes once the message has been published.
    /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
    public virtual Task<string> PublishAsync(string orderingKey, ByteString message) =>
        PublishAsync(new PubsubMessage
        {
            OrderingKey = orderingKey ?? "",
            Data = message
        });

    /// <summary>
    /// Publish a message to the topic specified in <see cref="TopicName"/>.
    /// </summary>
    /// <param name="message">The <see cref="ByteString"/> to publish.</param>
    /// <returns>A task which completes once the message has been published.
    /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
    public virtual Task<string> PublishAsync(ByteString message) => PublishAsync("", message);

    /// <summary>
    /// Publish a message to the topic specified in <see cref="TopicName"/>.
    /// </summary>
    /// <param name="orderingKey">The ordering key to use for this message.</param>
    /// <param name="message">The message to publish.</param>
    /// <returns>A task which completes once the message has been published.
    /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
    public virtual Task<string> PublishAsync(string orderingKey, byte[] message) =>
        PublishAsync(new PubsubMessage
        {
            OrderingKey = orderingKey ?? "",
            Data = ByteString.CopyFrom(message)
        });

    /// <summary>
    /// Publish a message to the topic specified in <see cref="TopicName"/>.
    /// </summary>
    /// <param name="message">The message to publish.</param>
    /// <returns>A task which completes once the message has been published.
    /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
    public virtual Task<string> PublishAsync(byte[] message) => PublishAsync("", message);

    /// <summary>
    /// Re-enable publishing the the given ordering key, after an error has caused the ordering key to be disabled.
    /// </summary>
    /// <param name="orderingKey">The ordering key to re-enable.</param>
    public virtual void ResumePublish(string orderingKey) => throw new NotImplementedException();

    /// <summary>
    /// Shutdown this <see cref="PublisherClient"/>. Cancelling <paramref name="hardStopToken"/> aborts the
    /// clean shutdown process, and may leave some locally queued messages unsent.
    /// The returned <see cref="Task"/> completes when all queued messages have been published.
    /// The returned <see cref="Task"/> cancels if <paramref name="hardStopToken"/> is cancelled.
    /// </summary>
    /// <param name="hardStopToken">Cancel this <see cref="CancellationToken"/> to abort publishing queued messages.</param>
    /// <returns>A <see cref="Task"/> that completes when all queued messages have been published; or cancels if
    /// <paramref name="hardStopToken"/> is cancelled.</returns>
    public virtual Task ShutdownAsync(CancellationToken hardStopToken) => throw new NotImplementedException();

    /// <summary>
    /// Shutdown this <see cref="PublisherClient"/>. If <paramref name="timeout"/> expires, the clean shutdown process will
    /// abort; leaving some locally queued messages unsent.
    /// The returned <see cref="Task"/> completes when all queued messages have been published.
    /// The returned <see cref="Task"/> cancels if the <paramref name="timeout"/> expires before all messages are published.
    /// </summary>
    /// <param name="timeout">After this period, abort publishing queued messages.</param>
    /// <returns>A <see cref="Task"/> that completes when all queued messages have been published; or cancels if
    /// <paramref name="timeout"/> expires.</returns>
    public virtual Task ShutdownAsync(TimeSpan timeout) => ShutdownAsync(new CancellationTokenSource(timeout).Token);

    /// <summary>
    /// Disposes this <see cref="PublisherClient"/> asynchronously.
    /// </summary>
    /// <remarks>
    /// This method asynchronously waits for the time interval as specified in the <see cref="Settings.DisposeTimeout"/>
    /// for the <see cref="PublisherClient"/> to send any pending messages. If the clean shutdown is not
    /// complete after this time, it is aborted; this may leave some locally queued messages unsent.
    /// The time interval can be customized by setting the <see cref="Settings.DisposeTimeout"/>.
    /// </remarks>
    public virtual ValueTask DisposeAsync() => throw new NotImplementedException();
}
