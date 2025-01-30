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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Settings for <see cref="SipTrunksClient"/> instances.</summary>
    public sealed partial class SipTrunksSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SipTrunksSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SipTrunksSettings"/>.</returns>
        public static SipTrunksSettings GetDefault() => new SipTrunksSettings();

        /// <summary>Constructs a new <see cref="SipTrunksSettings"/> object with default settings.</summary>
        public SipTrunksSettings()
        {
        }

        private SipTrunksSettings(SipTrunksSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSipTrunkSettings = existing.CreateSipTrunkSettings;
            DeleteSipTrunkSettings = existing.DeleteSipTrunkSettings;
            ListSipTrunksSettings = existing.ListSipTrunksSettings;
            GetSipTrunkSettings = existing.GetSipTrunkSettings;
            UpdateSipTrunkSettings = existing.UpdateSipTrunkSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SipTrunksSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SipTrunksClient.CreateSipTrunk</c> and <c>SipTrunksClient.CreateSipTrunkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSipTrunkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SipTrunksClient.DeleteSipTrunk</c> and <c>SipTrunksClient.DeleteSipTrunkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSipTrunkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SipTrunksClient.ListSipTrunks</c> and <c>SipTrunksClient.ListSipTrunksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSipTrunksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SipTrunksClient.GetSipTrunk</c>
        ///  and <c>SipTrunksClient.GetSipTrunkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSipTrunkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SipTrunksClient.UpdateSipTrunk</c> and <c>SipTrunksClient.UpdateSipTrunkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSipTrunkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SipTrunksSettings"/> object.</returns>
        public SipTrunksSettings Clone() => new SipTrunksSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SipTrunksClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SipTrunksClientBuilder : gaxgrpc::ClientBuilderBase<SipTrunksClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SipTrunksSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SipTrunksClientBuilder() : base(SipTrunksClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SipTrunksClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SipTrunksClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SipTrunksClient Build()
        {
            SipTrunksClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SipTrunksClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SipTrunksClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SipTrunksClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SipTrunksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SipTrunksClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SipTrunksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SipTrunksClient.ChannelPool;
    }

    /// <summary>SipTrunks client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [SipTrunks][google.cloud.dialogflow.v2beta1.SipTrunk].
    /// </remarks>
    public abstract partial class SipTrunksClient
    {
        /// <summary>
        /// The default endpoint for the SipTrunks service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default SipTrunks scopes.</summary>
        /// <remarks>
        /// The default SipTrunks scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SipTrunks.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SipTrunksClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="SipTrunksClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SipTrunksClient"/>.</returns>
        public static stt::Task<SipTrunksClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SipTrunksClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SipTrunksClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="SipTrunksClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SipTrunksClient"/>.</returns>
        public static SipTrunksClient Create() => new SipTrunksClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SipTrunksClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SipTrunksSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SipTrunksClient"/>.</returns>
        internal static SipTrunksClient Create(grpccore::CallInvoker callInvoker, SipTrunksSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SipTrunks.SipTrunksClient grpcClient = new SipTrunks.SipTrunksClient(callInvoker);
            return new SipTrunksClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SipTrunks client</summary>
        public virtual SipTrunks.SipTrunksClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a SipTrunk for a specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipTrunk CreateSipTrunk(CreateSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a SipTrunk for a specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> CreateSipTrunkAsync(CreateSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a SipTrunk for a specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> CreateSipTrunkAsync(CreateSipTrunkRequest request, st::CancellationToken cancellationToken) =>
            CreateSipTrunkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a SipTrunk for a specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a SIP trunk for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="sipTrunk">
        /// Required. The SIP trunk to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipTrunk CreateSipTrunk(string parent, SipTrunk sipTrunk, gaxgrpc::CallSettings callSettings = null) =>
            CreateSipTrunk(new CreateSipTrunkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SipTrunk = gax::GaxPreconditions.CheckNotNull(sipTrunk, nameof(sipTrunk)),
            }, callSettings);

        /// <summary>
        /// Creates a SipTrunk for a specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a SIP trunk for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="sipTrunk">
        /// Required. The SIP trunk to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> CreateSipTrunkAsync(string parent, SipTrunk sipTrunk, gaxgrpc::CallSettings callSettings = null) =>
            CreateSipTrunkAsync(new CreateSipTrunkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SipTrunk = gax::GaxPreconditions.CheckNotNull(sipTrunk, nameof(sipTrunk)),
            }, callSettings);

        /// <summary>
        /// Creates a SipTrunk for a specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a SIP trunk for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="sipTrunk">
        /// Required. The SIP trunk to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> CreateSipTrunkAsync(string parent, SipTrunk sipTrunk, st::CancellationToken cancellationToken) =>
            CreateSipTrunkAsync(parent, sipTrunk, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a SipTrunk for a specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a SIP trunk for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="sipTrunk">
        /// Required. The SIP trunk to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipTrunk CreateSipTrunk(gagr::LocationName parent, SipTrunk sipTrunk, gaxgrpc::CallSettings callSettings = null) =>
            CreateSipTrunk(new CreateSipTrunkRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SipTrunk = gax::GaxPreconditions.CheckNotNull(sipTrunk, nameof(sipTrunk)),
            }, callSettings);

        /// <summary>
        /// Creates a SipTrunk for a specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a SIP trunk for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="sipTrunk">
        /// Required. The SIP trunk to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> CreateSipTrunkAsync(gagr::LocationName parent, SipTrunk sipTrunk, gaxgrpc::CallSettings callSettings = null) =>
            CreateSipTrunkAsync(new CreateSipTrunkRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SipTrunk = gax::GaxPreconditions.CheckNotNull(sipTrunk, nameof(sipTrunk)),
            }, callSettings);

        /// <summary>
        /// Creates a SipTrunk for a specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a SIP trunk for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="sipTrunk">
        /// Required. The SIP trunk to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> CreateSipTrunkAsync(gagr::LocationName parent, SipTrunk sipTrunk, st::CancellationToken cancellationToken) =>
            CreateSipTrunkAsync(parent, sipTrunk, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSipTrunk(DeleteSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSipTrunkAsync(DeleteSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSipTrunkAsync(DeleteSipTrunkRequest request, st::CancellationToken cancellationToken) =>
            DeleteSipTrunkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSipTrunk(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSipTrunk(new DeleteSipTrunkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSipTrunkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSipTrunkAsync(new DeleteSipTrunkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSipTrunkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSipTrunkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSipTrunk(SipTrunkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSipTrunk(new DeleteSipTrunkRequest
            {
                SipTrunkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSipTrunkAsync(SipTrunkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSipTrunkAsync(new DeleteSipTrunkRequest
            {
                SipTrunkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSipTrunkAsync(SipTrunkName name, st::CancellationToken cancellationToken) =>
            DeleteSipTrunkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of SipTrunks in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SipTrunk"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSipTrunksResponse, SipTrunk> ListSipTrunks(ListSipTrunksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of SipTrunks in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SipTrunk"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSipTrunksResponse, SipTrunk> ListSipTrunksAsync(ListSipTrunksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of SipTrunks in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list SIP trunks from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="SipTrunk"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSipTrunksResponse, SipTrunk> ListSipTrunks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSipTrunksRequest request = new ListSipTrunksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSipTrunks(request, callSettings);
        }

        /// <summary>
        /// Returns a list of SipTrunks in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list SIP trunks from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SipTrunk"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSipTrunksResponse, SipTrunk> ListSipTrunksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSipTrunksRequest request = new ListSipTrunksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSipTrunksAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of SipTrunks in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list SIP trunks from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="SipTrunk"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSipTrunksResponse, SipTrunk> ListSipTrunks(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSipTrunksRequest request = new ListSipTrunksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSipTrunks(request, callSettings);
        }

        /// <summary>
        /// Returns a list of SipTrunks in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list SIP trunks from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SipTrunk"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSipTrunksResponse, SipTrunk> ListSipTrunksAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSipTrunksRequest request = new ListSipTrunksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSipTrunksAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipTrunk GetSipTrunk(GetSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> GetSipTrunkAsync(GetSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> GetSipTrunkAsync(GetSipTrunkRequest request, st::CancellationToken cancellationToken) =>
            GetSipTrunkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipTrunk GetSipTrunk(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipTrunk(new GetSipTrunkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> GetSipTrunkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipTrunkAsync(new GetSipTrunkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> GetSipTrunkAsync(string name, st::CancellationToken cancellationToken) =>
            GetSipTrunkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipTrunk GetSipTrunk(SipTrunkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipTrunk(new GetSipTrunkRequest
            {
                SipTrunkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> GetSipTrunkAsync(SipTrunkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSipTrunkAsync(new GetSipTrunkRequest
            {
                SipTrunkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified SipTrunk.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the SIP trunk to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/sipTrunks/&lt;SipTrunk
        /// ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> GetSipTrunkAsync(SipTrunkName name, st::CancellationToken cancellationToken) =>
            GetSipTrunkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipTrunk UpdateSipTrunk(UpdateSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> UpdateSipTrunkAsync(UpdateSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> UpdateSipTrunkAsync(UpdateSipTrunkRequest request, st::CancellationToken cancellationToken) =>
            UpdateSipTrunkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified SipTrunk.
        /// </summary>
        /// <param name="sipTrunk">
        /// Required. The SipTrunk to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SipTrunk UpdateSipTrunk(SipTrunk sipTrunk, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSipTrunk(new UpdateSipTrunkRequest
            {
                SipTrunk = gax::GaxPreconditions.CheckNotNull(sipTrunk, nameof(sipTrunk)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified SipTrunk.
        /// </summary>
        /// <param name="sipTrunk">
        /// Required. The SipTrunk to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> UpdateSipTrunkAsync(SipTrunk sipTrunk, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSipTrunkAsync(new UpdateSipTrunkRequest
            {
                SipTrunk = gax::GaxPreconditions.CheckNotNull(sipTrunk, nameof(sipTrunk)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified SipTrunk.
        /// </summary>
        /// <param name="sipTrunk">
        /// Required. The SipTrunk to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SipTrunk> UpdateSipTrunkAsync(SipTrunk sipTrunk, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSipTrunkAsync(sipTrunk, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SipTrunks client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [SipTrunks][google.cloud.dialogflow.v2beta1.SipTrunk].
    /// </remarks>
    public sealed partial class SipTrunksClientImpl : SipTrunksClient
    {
        private readonly gaxgrpc::ApiCall<CreateSipTrunkRequest, SipTrunk> _callCreateSipTrunk;

        private readonly gaxgrpc::ApiCall<DeleteSipTrunkRequest, wkt::Empty> _callDeleteSipTrunk;

        private readonly gaxgrpc::ApiCall<ListSipTrunksRequest, ListSipTrunksResponse> _callListSipTrunks;

        private readonly gaxgrpc::ApiCall<GetSipTrunkRequest, SipTrunk> _callGetSipTrunk;

        private readonly gaxgrpc::ApiCall<UpdateSipTrunkRequest, SipTrunk> _callUpdateSipTrunk;

        /// <summary>
        /// Constructs a client wrapper for the SipTrunks service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SipTrunksSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SipTrunksClientImpl(SipTrunks.SipTrunksClient grpcClient, SipTrunksSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SipTrunksSettings effectiveSettings = settings ?? SipTrunksSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateSipTrunk = clientHelper.BuildApiCall<CreateSipTrunkRequest, SipTrunk>("CreateSipTrunk", grpcClient.CreateSipTrunkAsync, grpcClient.CreateSipTrunk, effectiveSettings.CreateSipTrunkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSipTrunk);
            Modify_CreateSipTrunkApiCall(ref _callCreateSipTrunk);
            _callDeleteSipTrunk = clientHelper.BuildApiCall<DeleteSipTrunkRequest, wkt::Empty>("DeleteSipTrunk", grpcClient.DeleteSipTrunkAsync, grpcClient.DeleteSipTrunk, effectiveSettings.DeleteSipTrunkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSipTrunk);
            Modify_DeleteSipTrunkApiCall(ref _callDeleteSipTrunk);
            _callListSipTrunks = clientHelper.BuildApiCall<ListSipTrunksRequest, ListSipTrunksResponse>("ListSipTrunks", grpcClient.ListSipTrunksAsync, grpcClient.ListSipTrunks, effectiveSettings.ListSipTrunksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSipTrunks);
            Modify_ListSipTrunksApiCall(ref _callListSipTrunks);
            _callGetSipTrunk = clientHelper.BuildApiCall<GetSipTrunkRequest, SipTrunk>("GetSipTrunk", grpcClient.GetSipTrunkAsync, grpcClient.GetSipTrunk, effectiveSettings.GetSipTrunkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSipTrunk);
            Modify_GetSipTrunkApiCall(ref _callGetSipTrunk);
            _callUpdateSipTrunk = clientHelper.BuildApiCall<UpdateSipTrunkRequest, SipTrunk>("UpdateSipTrunk", grpcClient.UpdateSipTrunkAsync, grpcClient.UpdateSipTrunk, effectiveSettings.UpdateSipTrunkSettings).WithGoogleRequestParam("sip_trunk.name", request => request.SipTrunk?.Name);
            Modify_ApiCall(ref _callUpdateSipTrunk);
            Modify_UpdateSipTrunkApiCall(ref _callUpdateSipTrunk);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSipTrunkApiCall(ref gaxgrpc::ApiCall<CreateSipTrunkRequest, SipTrunk> call);

        partial void Modify_DeleteSipTrunkApiCall(ref gaxgrpc::ApiCall<DeleteSipTrunkRequest, wkt::Empty> call);

        partial void Modify_ListSipTrunksApiCall(ref gaxgrpc::ApiCall<ListSipTrunksRequest, ListSipTrunksResponse> call);

        partial void Modify_GetSipTrunkApiCall(ref gaxgrpc::ApiCall<GetSipTrunkRequest, SipTrunk> call);

        partial void Modify_UpdateSipTrunkApiCall(ref gaxgrpc::ApiCall<UpdateSipTrunkRequest, SipTrunk> call);

        partial void OnConstruction(SipTrunks.SipTrunksClient grpcClient, SipTrunksSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SipTrunks client</summary>
        public override SipTrunks.SipTrunksClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateSipTrunkRequest(ref CreateSipTrunkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSipTrunkRequest(ref DeleteSipTrunkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSipTrunksRequest(ref ListSipTrunksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSipTrunkRequest(ref GetSipTrunkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSipTrunkRequest(ref UpdateSipTrunkRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a SipTrunk for a specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SipTrunk CreateSipTrunk(CreateSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSipTrunkRequest(ref request, ref callSettings);
            return _callCreateSipTrunk.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a SipTrunk for a specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SipTrunk> CreateSipTrunkAsync(CreateSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSipTrunkRequest(ref request, ref callSettings);
            return _callCreateSipTrunk.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSipTrunk(DeleteSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSipTrunkRequest(ref request, ref callSettings);
            _callDeleteSipTrunk.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSipTrunkAsync(DeleteSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSipTrunkRequest(ref request, ref callSettings);
            return _callDeleteSipTrunk.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of SipTrunks in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SipTrunk"/> resources.</returns>
        public override gax::PagedEnumerable<ListSipTrunksResponse, SipTrunk> ListSipTrunks(ListSipTrunksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSipTrunksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSipTrunksRequest, ListSipTrunksResponse, SipTrunk>(_callListSipTrunks, request, callSettings);
        }

        /// <summary>
        /// Returns a list of SipTrunks in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SipTrunk"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSipTrunksResponse, SipTrunk> ListSipTrunksAsync(ListSipTrunksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSipTrunksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSipTrunksRequest, ListSipTrunksResponse, SipTrunk>(_callListSipTrunks, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SipTrunk GetSipTrunk(GetSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSipTrunkRequest(ref request, ref callSettings);
            return _callGetSipTrunk.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SipTrunk> GetSipTrunkAsync(GetSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSipTrunkRequest(ref request, ref callSettings);
            return _callGetSipTrunk.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SipTrunk UpdateSipTrunk(UpdateSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSipTrunkRequest(ref request, ref callSettings);
            return _callUpdateSipTrunk.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified SipTrunk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SipTrunk> UpdateSipTrunkAsync(UpdateSipTrunkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSipTrunkRequest(ref request, ref callSettings);
            return _callUpdateSipTrunk.Async(request, callSettings);
        }
    }

    public partial class ListSipTrunksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSipTrunksResponse : gaxgrpc::IPageResponse<SipTrunk>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SipTrunk> GetEnumerator() => SipTrunks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SipTrunks
    {
        public partial class SipTrunksClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
