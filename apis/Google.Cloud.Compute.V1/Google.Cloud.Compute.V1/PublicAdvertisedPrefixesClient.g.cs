// Copyright 2025 Google LLC
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

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="PublicAdvertisedPrefixesClient"/> instances.</summary>
    public sealed partial class PublicAdvertisedPrefixesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PublicAdvertisedPrefixesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PublicAdvertisedPrefixesSettings"/>.</returns>
        public static PublicAdvertisedPrefixesSettings GetDefault() => new PublicAdvertisedPrefixesSettings();

        /// <summary>
        /// Constructs a new <see cref="PublicAdvertisedPrefixesSettings"/> object with default settings.
        /// </summary>
        public PublicAdvertisedPrefixesSettings()
        {
        }

        private PublicAdvertisedPrefixesSettings(PublicAdvertisedPrefixesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AnnounceSettings = existing.AnnounceSettings;
            AnnounceOperationsSettings = existing.AnnounceOperationsSettings.Clone();
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            PatchOperationsSettings = existing.PatchOperationsSettings.Clone();
            WithdrawSettings = existing.WithdrawSettings;
            WithdrawOperationsSettings = existing.WithdrawOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(PublicAdvertisedPrefixesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.Announce</c> and <c>PublicAdvertisedPrefixesClient.AnnounceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnnounceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PublicAdvertisedPrefixesClient.Announce</c> and
        /// <c>PublicAdvertisedPrefixesClient.AnnounceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings AnnounceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.Delete</c> and <c>PublicAdvertisedPrefixesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PublicAdvertisedPrefixesClient.Delete</c> and
        /// <c>PublicAdvertisedPrefixesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.Get</c> and <c>PublicAdvertisedPrefixesClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.Insert</c> and <c>PublicAdvertisedPrefixesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PublicAdvertisedPrefixesClient.Insert</c> and
        /// <c>PublicAdvertisedPrefixesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings InsertOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.List</c> and <c>PublicAdvertisedPrefixesClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.Patch</c> and <c>PublicAdvertisedPrefixesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PublicAdvertisedPrefixesClient.Patch</c> and
        /// <c>PublicAdvertisedPrefixesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings PatchOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.Withdraw</c> and <c>PublicAdvertisedPrefixesClient.WithdrawAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WithdrawSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PublicAdvertisedPrefixesClient.Withdraw</c> and
        /// <c>PublicAdvertisedPrefixesClient.WithdrawAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings WithdrawOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PublicAdvertisedPrefixesSettings"/> object.</returns>
        public PublicAdvertisedPrefixesSettings Clone() => new PublicAdvertisedPrefixesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PublicAdvertisedPrefixesClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PublicAdvertisedPrefixesClientBuilder : gaxgrpc::ClientBuilderBase<PublicAdvertisedPrefixesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PublicAdvertisedPrefixesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PublicAdvertisedPrefixesClientBuilder() : base(PublicAdvertisedPrefixesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PublicAdvertisedPrefixesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PublicAdvertisedPrefixesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PublicAdvertisedPrefixesClient Build()
        {
            PublicAdvertisedPrefixesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PublicAdvertisedPrefixesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PublicAdvertisedPrefixesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PublicAdvertisedPrefixesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PublicAdvertisedPrefixesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PublicAdvertisedPrefixesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PublicAdvertisedPrefixesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PublicAdvertisedPrefixesClient.ChannelPool;
    }

    /// <summary>PublicAdvertisedPrefixes client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The PublicAdvertisedPrefixes API.
    /// </remarks>
    public abstract partial class PublicAdvertisedPrefixesClient
    {
        /// <summary>
        /// The default endpoint for the PublicAdvertisedPrefixes service, which is a host of "compute.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default PublicAdvertisedPrefixes scopes.</summary>
        /// <remarks>
        /// The default PublicAdvertisedPrefixes scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PublicAdvertisedPrefixes.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PublicAdvertisedPrefixesClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PublicAdvertisedPrefixesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PublicAdvertisedPrefixesClient"/>.</returns>
        public static stt::Task<PublicAdvertisedPrefixesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PublicAdvertisedPrefixesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PublicAdvertisedPrefixesClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PublicAdvertisedPrefixesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PublicAdvertisedPrefixesClient"/>.</returns>
        public static PublicAdvertisedPrefixesClient Create() => new PublicAdvertisedPrefixesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PublicAdvertisedPrefixesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PublicAdvertisedPrefixesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PublicAdvertisedPrefixesClient"/>.</returns>
        internal static PublicAdvertisedPrefixesClient Create(grpccore::CallInvoker callInvoker, PublicAdvertisedPrefixesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient grpcClient = new PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient(callInvoker);
            return new PublicAdvertisedPrefixesClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC PublicAdvertisedPrefixes client</summary>
        public virtual PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Announces the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Announce(AnnouncePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Announces the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AnnounceAsync(AnnouncePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Announces the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AnnounceAsync(AnnouncePublicAdvertisedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            AnnounceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Announce</c>.</summary>
        public virtual lro::OperationsClient AnnounceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Announce</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceAnnounce(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AnnounceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>Announce</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceAnnounceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AnnounceOperationsClient, callSettings);

        /// <summary>
        /// Announces the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// The name of the public advertised prefix. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Announce(string project, string publicAdvertisedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            Announce(new AnnouncePublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicAdvertisedPrefix, nameof(publicAdvertisedPrefix)),
            }, callSettings);

        /// <summary>
        /// Announces the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// The name of the public advertised prefix. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AnnounceAsync(string project, string publicAdvertisedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            AnnounceAsync(new AnnouncePublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicAdvertisedPrefix, nameof(publicAdvertisedPrefix)),
            }, callSettings);

        /// <summary>
        /// Announces the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// The name of the public advertised prefix. It should comply with RFC1035.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> AnnounceAsync(string project, string publicAdvertisedPrefix, st::CancellationToken cancellationToken) =>
            AnnounceAsync(project, publicAdvertisedPrefix, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeletePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeletePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeletePublicAdvertisedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public virtual lro::OperationsClient DeleteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDelete(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDeleteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// Name of the PublicAdvertisedPrefix resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string publicAdvertisedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeletePublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicAdvertisedPrefix, nameof(publicAdvertisedPrefix)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// Name of the PublicAdvertisedPrefix resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string publicAdvertisedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeletePublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicAdvertisedPrefix, nameof(publicAdvertisedPrefix)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// Name of the PublicAdvertisedPrefix resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string publicAdvertisedPrefix, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, publicAdvertisedPrefix, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified PublicAdvertisedPrefix resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicAdvertisedPrefix Get(GetPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified PublicAdvertisedPrefix resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicAdvertisedPrefix> GetAsync(GetPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified PublicAdvertisedPrefix resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicAdvertisedPrefix> GetAsync(GetPublicAdvertisedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified PublicAdvertisedPrefix resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// Name of the PublicAdvertisedPrefix resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicAdvertisedPrefix Get(string project, string publicAdvertisedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetPublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicAdvertisedPrefix, nameof(publicAdvertisedPrefix)),
            }, callSettings);

        /// <summary>
        /// Returns the specified PublicAdvertisedPrefix resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// Name of the PublicAdvertisedPrefix resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicAdvertisedPrefix> GetAsync(string project, string publicAdvertisedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetPublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicAdvertisedPrefix, nameof(publicAdvertisedPrefix)),
            }, callSettings);

        /// <summary>
        /// Returns the specified PublicAdvertisedPrefix resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// Name of the PublicAdvertisedPrefix resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicAdvertisedPrefix> GetAsync(string project, string publicAdvertisedPrefix, st::CancellationToken cancellationToken) =>
            GetAsync(project, publicAdvertisedPrefix, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertPublicAdvertisedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public virtual lro::OperationsClient InsertOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceInsert(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceInsertAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, PublicAdvertisedPrefix publicAdvertisedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertPublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicAdvertisedPrefixResource, nameof(publicAdvertisedPrefixResource)),
            }, callSettings);

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, PublicAdvertisedPrefix publicAdvertisedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertPublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicAdvertisedPrefixResource, nameof(publicAdvertisedPrefixResource)),
            }, callSettings);

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, PublicAdvertisedPrefix publicAdvertisedPrefixResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, publicAdvertisedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PublicAdvertisedPrefix"/> resources.</returns>
        public virtual gax::PagedEnumerable<PublicAdvertisedPrefixList, PublicAdvertisedPrefix> List(ListPublicAdvertisedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PublicAdvertisedPrefix"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<PublicAdvertisedPrefixList, PublicAdvertisedPrefix> ListAsync(ListPublicAdvertisedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PublicAdvertisedPrefix"/> resources.</returns>
        public virtual gax::PagedEnumerable<PublicAdvertisedPrefixList, PublicAdvertisedPrefix> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublicAdvertisedPrefixesRequest request = new ListPublicAdvertisedPrefixesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PublicAdvertisedPrefix"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<PublicAdvertisedPrefixList, PublicAdvertisedPrefix> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublicAdvertisedPrefixesRequest request = new ListPublicAdvertisedPrefixesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(PatchPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchPublicAdvertisedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public virtual lro::OperationsClient PatchOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOncePatch(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOncePatchAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// Name of the PublicAdvertisedPrefix resource to patch.
        /// </param>
        /// <param name="publicAdvertisedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(string project, string publicAdvertisedPrefix, PublicAdvertisedPrefix publicAdvertisedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchPublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicAdvertisedPrefix, nameof(publicAdvertisedPrefix)),
                PublicAdvertisedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicAdvertisedPrefixResource, nameof(publicAdvertisedPrefixResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// Name of the PublicAdvertisedPrefix resource to patch.
        /// </param>
        /// <param name="publicAdvertisedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string publicAdvertisedPrefix, PublicAdvertisedPrefix publicAdvertisedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchPublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicAdvertisedPrefix, nameof(publicAdvertisedPrefix)),
                PublicAdvertisedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicAdvertisedPrefixResource, nameof(publicAdvertisedPrefixResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// Name of the PublicAdvertisedPrefix resource to patch.
        /// </param>
        /// <param name="publicAdvertisedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string publicAdvertisedPrefix, PublicAdvertisedPrefix publicAdvertisedPrefixResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, publicAdvertisedPrefix, publicAdvertisedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Withdraws the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Withdraw(WithdrawPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Withdraws the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> WithdrawAsync(WithdrawPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Withdraws the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> WithdrawAsync(WithdrawPublicAdvertisedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            WithdrawAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Withdraw</c>.</summary>
        public virtual lro::OperationsClient WithdrawOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Withdraw</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceWithdraw(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), WithdrawOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>Withdraw</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceWithdrawAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), WithdrawOperationsClient, callSettings);

        /// <summary>
        /// Withdraws the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// The name of the public advertised prefix. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Withdraw(string project, string publicAdvertisedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            Withdraw(new WithdrawPublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicAdvertisedPrefix, nameof(publicAdvertisedPrefix)),
            }, callSettings);

        /// <summary>
        /// Withdraws the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// The name of the public advertised prefix. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> WithdrawAsync(string project, string publicAdvertisedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            WithdrawAsync(new WithdrawPublicAdvertisedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicAdvertisedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicAdvertisedPrefix, nameof(publicAdvertisedPrefix)),
            }, callSettings);

        /// <summary>
        /// Withdraws the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="publicAdvertisedPrefix">
        /// The name of the public advertised prefix. It should comply with RFC1035.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> WithdrawAsync(string project, string publicAdvertisedPrefix, st::CancellationToken cancellationToken) =>
            WithdrawAsync(project, publicAdvertisedPrefix, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PublicAdvertisedPrefixes client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The PublicAdvertisedPrefixes API.
    /// </remarks>
    public sealed partial class PublicAdvertisedPrefixesClientImpl : PublicAdvertisedPrefixesClient
    {
        private readonly gaxgrpc::ApiCall<AnnouncePublicAdvertisedPrefixeRequest, Operation> _callAnnounce;

        private readonly gaxgrpc::ApiCall<DeletePublicAdvertisedPrefixeRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetPublicAdvertisedPrefixeRequest, PublicAdvertisedPrefix> _callGet;

        private readonly gaxgrpc::ApiCall<InsertPublicAdvertisedPrefixeRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListPublicAdvertisedPrefixesRequest, PublicAdvertisedPrefixList> _callList;

        private readonly gaxgrpc::ApiCall<PatchPublicAdvertisedPrefixeRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<WithdrawPublicAdvertisedPrefixeRequest, Operation> _callWithdraw;

        /// <summary>
        /// Constructs a client wrapper for the PublicAdvertisedPrefixes service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PublicAdvertisedPrefixesSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PublicAdvertisedPrefixesClientImpl(PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient grpcClient, PublicAdvertisedPrefixesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PublicAdvertisedPrefixesSettings effectiveSettings = settings ?? PublicAdvertisedPrefixesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            AnnounceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.AnnounceOperationsSettings, logger);
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.InsertOperationsSettings, logger);
            PatchOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.PatchOperationsSettings, logger);
            WithdrawOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.WithdrawOperationsSettings, logger);
            _callAnnounce = clientHelper.BuildApiCall<AnnouncePublicAdvertisedPrefixeRequest, Operation>("Announce", grpcClient.AnnounceAsync, grpcClient.Announce, effectiveSettings.AnnounceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("public_advertised_prefix", request => request.PublicAdvertisedPrefix);
            Modify_ApiCall(ref _callAnnounce);
            Modify_AnnounceApiCall(ref _callAnnounce);
            _callDelete = clientHelper.BuildApiCall<DeletePublicAdvertisedPrefixeRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("public_advertised_prefix", request => request.PublicAdvertisedPrefix);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetPublicAdvertisedPrefixeRequest, PublicAdvertisedPrefix>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("public_advertised_prefix", request => request.PublicAdvertisedPrefix);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertPublicAdvertisedPrefixeRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListPublicAdvertisedPrefixesRequest, PublicAdvertisedPrefixList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchPublicAdvertisedPrefixeRequest, Operation>("Patch", grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("public_advertised_prefix", request => request.PublicAdvertisedPrefix);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callWithdraw = clientHelper.BuildApiCall<WithdrawPublicAdvertisedPrefixeRequest, Operation>("Withdraw", grpcClient.WithdrawAsync, grpcClient.Withdraw, effectiveSettings.WithdrawSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("public_advertised_prefix", request => request.PublicAdvertisedPrefix);
            Modify_ApiCall(ref _callWithdraw);
            Modify_WithdrawApiCall(ref _callWithdraw);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AnnounceApiCall(ref gaxgrpc::ApiCall<AnnouncePublicAdvertisedPrefixeRequest, Operation> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeletePublicAdvertisedPrefixeRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetPublicAdvertisedPrefixeRequest, PublicAdvertisedPrefix> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertPublicAdvertisedPrefixeRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListPublicAdvertisedPrefixesRequest, PublicAdvertisedPrefixList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchPublicAdvertisedPrefixeRequest, Operation> call);

        partial void Modify_WithdrawApiCall(ref gaxgrpc::ApiCall<WithdrawPublicAdvertisedPrefixeRequest, Operation> call);

        partial void OnConstruction(PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient grpcClient, PublicAdvertisedPrefixesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PublicAdvertisedPrefixes client</summary>
        public override PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient GrpcClient { get; }

        partial void Modify_AnnouncePublicAdvertisedPrefixeRequest(ref AnnouncePublicAdvertisedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePublicAdvertisedPrefixeRequest(ref DeletePublicAdvertisedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPublicAdvertisedPrefixeRequest(ref GetPublicAdvertisedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertPublicAdvertisedPrefixeRequest(ref InsertPublicAdvertisedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPublicAdvertisedPrefixesRequest(ref ListPublicAdvertisedPrefixesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchPublicAdvertisedPrefixeRequest(ref PatchPublicAdvertisedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WithdrawPublicAdvertisedPrefixeRequest(ref WithdrawPublicAdvertisedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>Announce</c>.</summary>
        public override lro::OperationsClient AnnounceOperationsClient { get; }

        /// <summary>
        /// Announces the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Announce(AnnouncePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnouncePublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            Operation response = _callAnnounce.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AnnounceOperationsClient);
        }

        /// <summary>
        /// Announces the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> AnnounceAsync(AnnouncePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnouncePublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            Operation response = await _callAnnounce.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), AnnounceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeletePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeletePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns the specified PublicAdvertisedPrefix resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublicAdvertisedPrefix Get(GetPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified PublicAdvertisedPrefix resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublicAdvertisedPrefix> GetAsync(GetPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PublicAdvertisedPrefix"/> resources.</returns>
        public override gax::PagedEnumerable<PublicAdvertisedPrefixList, PublicAdvertisedPrefix> List(ListPublicAdvertisedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublicAdvertisedPrefixesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPublicAdvertisedPrefixesRequest, PublicAdvertisedPrefixList, PublicAdvertisedPrefix>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PublicAdvertisedPrefix"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<PublicAdvertisedPrefixList, PublicAdvertisedPrefix> ListAsync(ListPublicAdvertisedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublicAdvertisedPrefixesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPublicAdvertisedPrefixesRequest, PublicAdvertisedPrefixList, PublicAdvertisedPrefix>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public override lro::OperationsClient PatchOperationsClient { get; }

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Patch(PatchPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            Operation response = _callPatch.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            Operation response = await _callPatch.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Withdraw</c>.</summary>
        public override lro::OperationsClient WithdrawOperationsClient { get; }

        /// <summary>
        /// Withdraws the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Withdraw(WithdrawPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WithdrawPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            Operation response = _callWithdraw.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), WithdrawOperationsClient);
        }

        /// <summary>
        /// Withdraws the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> WithdrawAsync(WithdrawPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WithdrawPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            Operation response = await _callWithdraw.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), WithdrawOperationsClient);
        }
    }

    public partial class ListPublicAdvertisedPrefixesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class PublicAdvertisedPrefixList : gaxgrpc::IPageResponse<PublicAdvertisedPrefix>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PublicAdvertisedPrefix> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class PublicAdvertisedPrefixes
    {
        public partial class PublicAdvertisedPrefixesClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to GlobalOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForGlobalOperations() =>
                GlobalOperations.GlobalOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
