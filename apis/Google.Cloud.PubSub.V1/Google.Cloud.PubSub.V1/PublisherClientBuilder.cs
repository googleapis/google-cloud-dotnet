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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// Builder class for <see cref="PublisherClient"/> to provide simple configuration of credentials,
/// endpoint, client count, publication settings etc.
/// </summary>
public sealed class PublisherClientBuilder : ClientBuilderBase<PublisherClient>
{
    /// <summary>
    /// The name of the topic that the publisher publishes to.
    /// This must be non-null by the time <see cref="Build"/> or <see cref="BuildAsync(CancellationToken)"/> is called.
    /// </summary>
    public TopicName TopicName {  get; set; }

    private int? _clientCount;

    /// <summary>
    /// The number of <see cref="PublisherServiceApiClient"/>s to create and use within a <see cref="PublisherClient"/> instance.
    /// If this is null, the number of clients created will depend on the processor count.
    /// </summary>
    public int? ClientCount
    {
        get => _clientCount;
        set
        {
            if (value is int count)
            {
                // Fairly arbitrary upper limit.
                _clientCount = GaxPreconditions.CheckArgumentRange(count, nameof(value), 1, 256);
            }
            else
            {
                _clientCount = value;
            }
        }
    }

    /// <summary>
    /// Whether the <see cref="PublisherServiceApiClient"/>s may share gRPC connections or not.
    /// Defaults to false, meaning, each client has its own gRPC connection.
    /// </summary>
    public bool ShareClientConnections { get; set; }

    /// <summary>
    /// Additional settings for batching, message ordering etc. Default settings will be used if this is null.
    /// </summary>
    public PublisherClient.Settings Settings { get; set; }

    /// <summary>
    /// The settings to use when creating <see cref= "PublisherServiceApiClient" /> instances.
    /// Default settings will be used if this is null.
    /// </summary>
    public PublisherServiceApiSettings ApiSettings { get; set; }

    /// <summary>
    /// Specifies how to respond to the presence of emulator environment variables.
    /// </summary>
    /// <remarks>
    /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that
    /// environment variables are ignored.
    /// </remarks>
    public new EmulatorDetection EmulatorDetection
    {
        get => base.EmulatorDetection;
        set => base.EmulatorDetection = value;
    }

    /// <summary>
    /// Creates a new instance with default settings. <see cref="TopicName"/> must be set
    /// before calling either <see cref="Build"/> or <see cref="BuildAsync"/>.
    /// </summary>
    public PublisherClientBuilder() : base(PublisherServiceApiClient.ServiceMetadata)
    {
    }

    /// <summary>Builds the resulting client.</summary>
    public override PublisherClient Build() =>
        // With isAsync set to false, the returned task will already be completed(either successfully or faulted),
        // so .ResultWithUnwrappedExceptions() will always return immediately.
        BuildAsyncImpl(default, false).ResultWithUnwrappedExceptions();

    /// <summary>Builds the resulting client asynchronously.</summary>
    public override Task<PublisherClient> BuildAsync(CancellationToken cancellationToken = default) =>
        BuildAsyncImpl(cancellationToken, true);

    private async Task<PublisherClient> BuildAsyncImpl(CancellationToken cancellationToken, bool isAsync)
    {
        Validate();
        var clientCount = ClientCount ?? Environment.ProcessorCount;
        var clients = new PublisherServiceApiClient[clientCount];
        var settings = Settings?.Clone() ?? new PublisherClient.Settings();
        settings.Logger = Logger;
        var shutdowns = new Func<Task>[clientCount];
        for (int i = 0; i < clientCount; i++)
        {
            var grpcChannelOptions = ClientBuilderChannelHelper.GetUnlimitedSendReceiveChannelOptions(ShareClientConnections);

            var builder = new PublisherServiceApiClientBuilder(this, grpcChannelOptions);
            clients[i] = isAsync
                ? await builder.BuildAsync(cancellationToken).ConfigureAwait(false)
                : builder.Build();
            var channel = builder.LastCreatedChannel;
            shutdowns[i] = () => ClientBuilderChannelHelper.DisposeChannelAsync(channel);
        }
        Func<Task> shutdown = () => Task.WhenAll(shutdowns.Select(x => x()));
        return new PublisherClientImpl(TopicName, clients, settings, shutdown);
    }

    /// <inheritdoc />
    protected override ChannelPool GetChannelPool() => throw new NotImplementedException();

    /// <inheritdoc />
    protected override void Validate()
    {
        base.Validate();
        GaxPreconditions.CheckState(TopicName != null, "The topic name must be set before building a client.");
    }
}
