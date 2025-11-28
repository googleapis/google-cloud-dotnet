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
using Google.Api.Gax.Grpc.Gcp;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    public partial class BigtableServiceApiSettings
    {
        /// <summary>
        /// <see cref="RetrySettings"/> for calls to <c>BigtableClient.MutateRows</c> and
        /// <c>BigtableClient.MutateRowsAsync</c> when some of the mutations fail for certain reasons.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableClient.MutateRows</c> and <c>BigtableClient.MutateRowsAsync</c>
        /// <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Max attempts: 5</description></item>
        /// <item><description>Initial retry delay: 10 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes on individual mutations:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        /// <seealso cref="MutateRowsSettings"/>
        public RetrySettings MutateRowsRetrySettings { get; set; } =
            RetrySettings.FromExponentialBackoff(
                maxAttempts: 5,
                initialBackoff: TimeSpan.FromMilliseconds(10),
                maxBackoff: TimeSpan.FromMinutes(1),
                backoffMultiplier: 2,
                retryFilter: RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable));

        /// <summary>
        /// <see cref="RetrySettings"/> for calls to <c>BigtableClient.ReadRows</c> when the stream
        /// of results ends prematurely.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableClient.ReadRows</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Max attempts: 5</description></item>
        /// <item><description>Initial retry delay: 10 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes on individual mutations:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// <item><description><see cref="StatusCode.Aborted"/></description></item>
        /// </list>
        /// </remarks>
        /// <seealso cref="ReadRowsSettings"/>
        public RetrySettings ReadRowsRetrySettings { get; set; } =
            RetrySettings.FromExponentialBackoff(
                maxAttempts: 5,
                initialBackoff: TimeSpan.FromMilliseconds(10),
                maxBackoff: TimeSpan.FromMinutes(1),
                backoffMultiplier: 2,
                retryFilter: RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable, StatusCode.Aborted));

        /// <summary>
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used by the server.
        /// </summary>
        public string AppProfileId { get; set; }

        /// <summary>
        /// The maximum number of channels than will be open concurrently to the Bigtable endpoint.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that channels are managed and shared amongst <see cref="BigtableClient"/> instances using the same
        /// endpoint and channel options and which use the default credentials. So this property will have no bearing
        /// across clients using different options. To create a custom grouping of channels to be managed, create a
        /// <see cref="GcpCallInvoker"/> manually and set the <see cref="ClientBuilderBase{BigtableClient}.CallInvoker" />
        /// property on a <see cref="BigtableClientBuilder" />, then build the client.
        /// </para>
        /// </remarks>
        public uint MaxChannels { get; set; } = 16;

        /// <summary>
        /// The number of streams open concurrently in a channel which will trigger a new channel to be opened, as
        /// long as fewer than <see cref="MaxChannels"/> are currently open.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that channels are managed and shared amongst <see cref="BigtableClient"/> instances using the same
        /// endpoint and channel options and which use the default credentials. So this property will have no bearing
        /// across clients using different options. To create a custom grouping of channels to be managed, create a
        /// <see cref="GcpCallInvoker"/> manually and set the <see cref="ClientBuilderBase{BigtableClient}.CallInvoker" />
        /// property on a <see cref="BigtableClientBuilder" />, then build the client.
        /// </para>
        /// </remarks>
        public uint PreferredMaxStreamsPerChannel { get; set; } = 5;

        partial void OnCopy(BigtableServiceApiSettings existing)
        {
            MutateRowsRetrySettings = existing.MutateRowsRetrySettings;
            ReadRowsRetrySettings = existing.ReadRowsRetrySettings;
            AppProfileId = existing.AppProfileId;
            MaxChannels = existing.MaxChannels;
            PreferredMaxStreamsPerChannel = existing.PreferredMaxStreamsPerChannel;
        }
    }

    /// <summary>
    /// Extensions for use on <see cref="BigtableServiceApiSettings"/>.
    /// </summary>
    public static class BigtableServiceApiSettingsExtensions
    {
        internal static ApiConfig CreateApiConfig(this BigtableServiceApiSettings settings)
        {
            settings = settings ?? BigtableServiceApiSettings.GetDefault();
            return new ApiConfig
            {
                ChannelPool = new ChannelPoolConfig
                {
                    MaxSize = settings.MaxChannels,
                    MaxConcurrentStreamsLowWatermark = settings.PreferredMaxStreamsPerChannel
                }
            };
        }
    }

    public sealed partial class BigtableServiceApiClientBuilder : ClientBuilderBase<BigtableServiceApiClient>
    {
        private const string s_emulatorHostEnvironmentVariable = "BIGTABLE_EMULATOR_HOST";
        private static readonly string[] s_emulatorEnvironmentVariables = { s_emulatorHostEnvironmentVariable };

        private static readonly GrpcChannelOptions s_bigtableDefaultOptions = DefaultOptions
            .WithPrimaryUserAgent(BigtableClient.UserAgent)
            // Note: these were previously -1, which was treated as infinity by Grpc.Core, but is treated
            // as "too small for any message" by Grpc.Net.Client. We could potentially hide that difference
            // in the adapter instead of here, but using int.MaxValue feels more sensible anyway.
            .WithMaxSendMessageSize(int.MaxValue)
            .WithMaxReceiveMessageSize(int.MaxValue)
            .WithKeepAliveTime(TimeSpan.FromSeconds(30));

        /// <summary>
        /// Specifies how the builder responds to the presence of emulator environment variables.
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

        internal BigtableServiceApiClientBuilder(BigtableClientBuilder builder) : base(BigtableServiceApiClient.ServiceMetadata)
        {
            Settings = builder.Settings;
            CopyCommonSettings(builder);
        }

        partial void InterceptBuild(ref BigtableServiceApiClient client) => client = MaybeCreateEmulatorClientBuilder()?.Build();

        partial void InterceptBuildAsync(CancellationToken cancellationToken, ref Task<BigtableServiceApiClient> task) =>
            task = MaybeCreateEmulatorClientBuilder()?.BuildAsync(cancellationToken);

        private BigtableServiceApiClientBuilder MaybeCreateEmulatorClientBuilder()
        {
            var emulatorEnvironment = GetEmulatorEnvironment(s_emulatorEnvironmentVariables, s_emulatorEnvironmentVariables);
            if (emulatorEnvironment is null)
            {
                return null;
            }
            // We don't set the EmulatorDetection property here to avoid recursively calling
            // MaybeCreateEmulatorClientBuilder().
            var builder = new BigtableServiceApiClientBuilder
            {
                Settings = Settings,
                Endpoint = emulatorEnvironment[s_emulatorHostEnvironmentVariable],
                ChannelCredentials = ChannelCredentials.Insecure
            };
            builder.CopySettingsForEmulator(this);
            return builder;
        }

        /// <inheritdoc />
        protected override CallInvoker CreateCallInvoker() => CallInvoker ?? CreateGcpCallInvoker();

        /// <summary>
        /// Creates a <see cref="GcpCallInvoker"/> which is a call invoker that can distribute calls across
        /// different underlying channels based on request properties.
        /// </summary>
        public GcpCallInvoker CreateGcpCallInvoker()
        {
            GaxPreconditions.CheckState(CallInvoker is null,
                "Cannot call {0} on a builder that already has {1} set.", nameof(CreateGcpCallInvoker), nameof(CallInvoker));
            var endpoint = EffectiveEndpoint;
            var channelOptions = GetChannelOptions();
            var apiConfig = Settings.CreateApiConfig();
            var grpcAdapter = EffectiveGrpcAdapter;
            // Although *we* never allow the use of the channel pool, we can use the call invoker pool if and
            // only if the base class thinks it can use the channel pool - i.e. it's only using default credentials.
            if (base.CanUseChannelPool)
            {
                return CallInvokerPool.GetCallInvoker(EffectiveUniverseDomain, endpoint, channelOptions, apiConfig, grpcAdapter);
            }
            else
            {
                var credentials = GetChannelCredentials();
                return new GcpCallInvoker(ServiceMetadata, endpoint, credentials, channelOptions, apiConfig, grpcAdapter);
            }
        }

        /// <inheritdoc />
        protected override GrpcChannelOptions GetChannelOptions()
        {
            var options = UserAgent is null ? s_bigtableDefaultOptions : s_bigtableDefaultOptions.WithPrimaryUserAgent(UserAgent);
            if (GrpcChannelOptions is object)
            {
                options = options.MergedWith(GrpcChannelOptions);
            }
            return options;
        }

        /// <inheritdoc />
        protected override async Task<CallInvoker> CreateCallInvokerAsync(CancellationToken cancellationToken) =>
            CallInvoker ?? await CreateGcpCallInvokerAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a <see cref="GcpCallInvoker"/> which is a call invoker that can distribute calls across
        /// different underlying channels based on request properties.
        /// </summary>
        public async Task<GcpCallInvoker> CreateGcpCallInvokerAsync(CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckState(CallInvoker is null,
                "Cannot call {0} on a builder that already has {1} set.", nameof(CreateGcpCallInvoker), nameof(CallInvoker));
            var endpoint = EffectiveEndpoint;
            var channelOptions = GetChannelOptions();
            var apiConfig = Settings.CreateApiConfig();
            var grpcAdapter = EffectiveGrpcAdapter;
            // Although *we* never allow the use of the channel pool, we can use the call invoker pool if and
            // only if the base class thinks it can use the channel pool - i.e. it's only using default credentials.
            if (base.CanUseChannelPool)
            {
                return await CallInvokerPool.GetCallInvokerAsync(EffectiveUniverseDomain, endpoint, channelOptions, apiConfig, grpcAdapter, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                var credentials = await GetChannelCredentialsAsync(cancellationToken).ConfigureAwait(false);
                return new GcpCallInvoker(ServiceMetadata, endpoint, credentials, channelOptions, apiConfig, grpcAdapter);
            }
        }

        // Note: GetChannelPool() will still be called by base.CanUseChannelPool,
        // so we do *have* a regular channel pool, but it's never asked to create any channels.

        /// <inheritdoc />
        protected override bool CanUseChannelPool => false;

        private GcpCallInvokerPool CallInvokerPool => BigtableServiceApiClient.CallInvokerPool;
    }

    public partial class BigtableServiceApiClient
    {
        internal static GcpCallInvokerPool CallInvokerPool { get; } = new GcpCallInvokerPool(ServiceMetadata);

        /// <summary>
        /// Gets the value which specifies routing for replication.
        /// If null or empty, the "default" application profile will be used by the server.
        /// </summary>
        public virtual string AppProfileId => throw new NotImplementedException();

        internal virtual BigtableServiceApiSettings DefaultSettings => null;

        public partial class SampleRowKeysStream
        {
            /// <summary>
            /// Gets all responses from the stream.
            /// </summary>
            /// <returns>The collection of all row key samples.</returns>
            public IList<SampleRowKeysResponse> ToList() =>
                Task.Run(() => ToListAsync()).ResultWithUnwrappedExceptions();

            /// <summary>
            /// Gets all responses from the stream asynchronously.
            /// </summary>
            /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
            /// <returns>The collection of all row key samples.</returns>
            public async Task<IList<SampleRowKeysResponse>> ToListAsync(
                CancellationToken cancellationToken = default)
            {
                var responses = new List<SampleRowKeysResponse>();
                while (await GrpcCall.ResponseStream.MoveNext(cancellationToken).ConfigureAwait(false))
                {
                    responses.Add(GrpcCall.ResponseStream.Current);
                }
                return responses;
            }
        }
    }

    public partial class BigtableServiceApiClientImpl
    {
        private BigtableServiceApiSettings _defaultSettings;

        /// <inheritdoc/>
        public override string AppProfileId => _defaultSettings.AppProfileId;

        internal override BigtableServiceApiSettings DefaultSettings => _defaultSettings;

        partial void OnConstruction(
            Bigtable.BigtableClient grpcClient,
            BigtableServiceApiSettings effectiveSettings,
            ClientHelper clientHelper) =>
            _defaultSettings = effectiveSettings.Clone();

        // Note: the callbacks below intentionally take the specified request as the 1st argument so callers don't need
        // to create closure objects at callsites.
        private void TryApplyAppProfileId<TRequest>(
            TRequest request,
            Func<TRequest, string> appProfileIdGetter,
            Action<TRequest, string> appProfileIdSetter)
        {
            if (AppProfileId != null && appProfileIdGetter(request).Length == 0)
            {
                appProfileIdSetter(request, AppProfileId);
            }
        }

        partial void Modify_CheckAndMutateRowRequest(ref CheckAndMutateRowRequest request, ref CallSettings settings) =>
            TryApplyAppProfileId(request, r => r.AppProfileId, (r, a) => r.AppProfileId = a);

        partial void Modify_MutateRowRequest(ref MutateRowRequest request, ref CallSettings settings)
        {
            GaxPreconditions.CheckState(
                request.IsIdempotent(),
                "Non-idempotent MutateRow requests are not allowed. Specify a version with all SetCell mutations.");

            TryApplyAppProfileId(request, r => r.AppProfileId, (r, a) => r.AppProfileId = a);
        }

        partial void Modify_MutateRowsRequest(ref MutateRowsRequest request, ref CallSettings settings)
        {
            GaxPreconditions.CheckState(
                request.IsIdempotent(),
                "Non-idempotent MutateRows requests are not allowed. Specify a version with all SetCell mutations.");

            TryApplyAppProfileId(request, r => r.AppProfileId, (r, a) => r.AppProfileId = a);
        }

        partial void Modify_ReadModifyWriteRowRequest(ref ReadModifyWriteRowRequest request, ref CallSettings settings) =>
            TryApplyAppProfileId(request, r => r.AppProfileId, (r, a) => r.AppProfileId = a);

        partial void Modify_ReadRowsRequest(ref ReadRowsRequest request, ref CallSettings settings) =>
            TryApplyAppProfileId(request, r => r.AppProfileId, (r, a) => r.AppProfileId = a);

        partial void Modify_SampleRowKeysRequest(ref SampleRowKeysRequest request, ref CallSettings settings) =>
            TryApplyAppProfileId(request, r => r.AppProfileId, (r, a) => r.AppProfileId = a);
    }
}
