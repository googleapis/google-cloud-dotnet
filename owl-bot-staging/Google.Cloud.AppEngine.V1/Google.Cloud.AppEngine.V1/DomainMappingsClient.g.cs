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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.AppEngine.V1
{
    /// <summary>Settings for <see cref="DomainMappingsClient"/> instances.</summary>
    public sealed partial class DomainMappingsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DomainMappingsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DomainMappingsSettings"/>.</returns>
        public static DomainMappingsSettings GetDefault() => new DomainMappingsSettings();

        /// <summary>Constructs a new <see cref="DomainMappingsSettings"/> object with default settings.</summary>
        public DomainMappingsSettings()
        {
        }

        private DomainMappingsSettings(DomainMappingsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDomainMappingsSettings = existing.ListDomainMappingsSettings;
            GetDomainMappingSettings = existing.GetDomainMappingSettings;
            CreateDomainMappingSettings = existing.CreateDomainMappingSettings;
            CreateDomainMappingOperationsSettings = existing.CreateDomainMappingOperationsSettings.Clone();
            UpdateDomainMappingSettings = existing.UpdateDomainMappingSettings;
            UpdateDomainMappingOperationsSettings = existing.UpdateDomainMappingOperationsSettings.Clone();
            DeleteDomainMappingSettings = existing.DeleteDomainMappingSettings;
            DeleteDomainMappingOperationsSettings = existing.DeleteDomainMappingOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(DomainMappingsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainMappingsClient.ListDomainMappings</c> and <c>DomainMappingsClient.ListDomainMappingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDomainMappingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainMappingsClient.GetDomainMapping</c> and <c>DomainMappingsClient.GetDomainMappingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDomainMappingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainMappingsClient.CreateDomainMapping</c> and <c>DomainMappingsClient.CreateDomainMappingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDomainMappingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DomainMappingsClient.CreateDomainMapping</c> and
        /// <c>DomainMappingsClient.CreateDomainMappingAsync</c>.
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
        public lro::OperationsSettings CreateDomainMappingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainMappingsClient.UpdateDomainMapping</c> and <c>DomainMappingsClient.UpdateDomainMappingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDomainMappingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DomainMappingsClient.UpdateDomainMapping</c> and
        /// <c>DomainMappingsClient.UpdateDomainMappingAsync</c>.
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
        public lro::OperationsSettings UpdateDomainMappingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainMappingsClient.DeleteDomainMapping</c> and <c>DomainMappingsClient.DeleteDomainMappingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDomainMappingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DomainMappingsClient.DeleteDomainMapping</c> and
        /// <c>DomainMappingsClient.DeleteDomainMappingAsync</c>.
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
        public lro::OperationsSettings DeleteDomainMappingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DomainMappingsSettings"/> object.</returns>
        public DomainMappingsSettings Clone() => new DomainMappingsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DomainMappingsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DomainMappingsClientBuilder : gaxgrpc::ClientBuilderBase<DomainMappingsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DomainMappingsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DomainMappingsClientBuilder() : base(DomainMappingsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DomainMappingsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DomainMappingsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DomainMappingsClient Build()
        {
            DomainMappingsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DomainMappingsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DomainMappingsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DomainMappingsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DomainMappingsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DomainMappingsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DomainMappingsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DomainMappingsClient.ChannelPool;
    }

    /// <summary>DomainMappings client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages domains serving an application.
    /// </remarks>
    public abstract partial class DomainMappingsClient
    {
        /// <summary>
        /// The default endpoint for the DomainMappings service, which is a host of "appengine.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "appengine.googleapis.com:443";

        /// <summary>The default DomainMappings scopes.</summary>
        /// <remarks>
        /// The default DomainMappings scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/appengine.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/appengine.admin",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DomainMappings.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DomainMappingsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DomainMappingsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DomainMappingsClient"/>.</returns>
        public static stt::Task<DomainMappingsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DomainMappingsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DomainMappingsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DomainMappingsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DomainMappingsClient"/>.</returns>
        public static DomainMappingsClient Create() => new DomainMappingsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DomainMappingsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DomainMappingsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DomainMappingsClient"/>.</returns>
        internal static DomainMappingsClient Create(grpccore::CallInvoker callInvoker, DomainMappingsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DomainMappings.DomainMappingsClient grpcClient = new DomainMappings.DomainMappingsClient(callInvoker);
            return new DomainMappingsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DomainMappings client</summary>
        public virtual DomainMappings.DomainMappingsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the domain mappings on an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DomainMapping"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDomainMappingsResponse, DomainMapping> ListDomainMappings(ListDomainMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the domain mappings on an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DomainMapping"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDomainMappingsResponse, DomainMapping> ListDomainMappingsAsync(ListDomainMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified domain mapping.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DomainMapping GetDomainMapping(GetDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified domain mapping.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DomainMapping> GetDomainMappingAsync(GetDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified domain mapping.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DomainMapping> GetDomainMappingAsync(GetDomainMappingRequest request, st::CancellationToken cancellationToken) =>
            GetDomainMappingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Maps a domain to an application. A user must be authorized to administer a
        /// domain in order to map it to an application. For a list of available
        /// authorized domains, see [`AuthorizedDomains.ListAuthorizedDomains`]().
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DomainMapping, OperationMetadataV1> CreateDomainMapping(CreateDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Maps a domain to an application. A user must be authorized to administer a
        /// domain in order to map it to an application. For a list of available
        /// authorized domains, see [`AuthorizedDomains.ListAuthorizedDomains`]().
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DomainMapping, OperationMetadataV1>> CreateDomainMappingAsync(CreateDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Maps a domain to an application. A user must be authorized to administer a
        /// domain in order to map it to an application. For a list of available
        /// authorized domains, see [`AuthorizedDomains.ListAuthorizedDomains`]().
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DomainMapping, OperationMetadataV1>> CreateDomainMappingAsync(CreateDomainMappingRequest request, st::CancellationToken cancellationToken) =>
            CreateDomainMappingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDomainMapping</c>.</summary>
        public virtual lro::OperationsClient CreateDomainMappingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDomainMapping</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DomainMapping, OperationMetadataV1> PollOnceCreateDomainMapping(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DomainMapping, OperationMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDomainMappingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDomainMapping</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DomainMapping, OperationMetadataV1>> PollOnceCreateDomainMappingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DomainMapping, OperationMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDomainMappingOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified domain mapping. To map an SSL certificate to a
        /// domain mapping, update `certificate_id` to point to an `AuthorizedCertificate`
        /// resource. A user must be authorized to administer the associated domain
        /// in order to update a `DomainMapping` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DomainMapping, OperationMetadataV1> UpdateDomainMapping(UpdateDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified domain mapping. To map an SSL certificate to a
        /// domain mapping, update `certificate_id` to point to an `AuthorizedCertificate`
        /// resource. A user must be authorized to administer the associated domain
        /// in order to update a `DomainMapping` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DomainMapping, OperationMetadataV1>> UpdateDomainMappingAsync(UpdateDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified domain mapping. To map an SSL certificate to a
        /// domain mapping, update `certificate_id` to point to an `AuthorizedCertificate`
        /// resource. A user must be authorized to administer the associated domain
        /// in order to update a `DomainMapping` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DomainMapping, OperationMetadataV1>> UpdateDomainMappingAsync(UpdateDomainMappingRequest request, st::CancellationToken cancellationToken) =>
            UpdateDomainMappingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDomainMapping</c>.</summary>
        public virtual lro::OperationsClient UpdateDomainMappingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDomainMapping</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DomainMapping, OperationMetadataV1> PollOnceUpdateDomainMapping(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DomainMapping, OperationMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDomainMappingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDomainMapping</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DomainMapping, OperationMetadataV1>> PollOnceUpdateDomainMappingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DomainMapping, OperationMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDomainMappingOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified domain mapping. A user must be authorized to
        /// administer the associated domain in order to delete a `DomainMapping`
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadataV1> DeleteDomainMapping(DeleteDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified domain mapping. A user must be authorized to
        /// administer the associated domain in order to delete a `DomainMapping`
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteDomainMappingAsync(DeleteDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified domain mapping. A user must be authorized to
        /// administer the associated domain in order to delete a `DomainMapping`
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteDomainMappingAsync(DeleteDomainMappingRequest request, st::CancellationToken cancellationToken) =>
            DeleteDomainMappingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDomainMapping</c>.</summary>
        public virtual lro::OperationsClient DeleteDomainMappingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDomainMapping</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadataV1> PollOnceDeleteDomainMapping(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDomainMappingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDomainMapping</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> PollOnceDeleteDomainMappingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDomainMappingOperationsClient, callSettings);
    }

    /// <summary>DomainMappings client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages domains serving an application.
    /// </remarks>
    public sealed partial class DomainMappingsClientImpl : DomainMappingsClient
    {
        private readonly gaxgrpc::ApiCall<ListDomainMappingsRequest, ListDomainMappingsResponse> _callListDomainMappings;

        private readonly gaxgrpc::ApiCall<GetDomainMappingRequest, DomainMapping> _callGetDomainMapping;

        private readonly gaxgrpc::ApiCall<CreateDomainMappingRequest, lro::Operation> _callCreateDomainMapping;

        private readonly gaxgrpc::ApiCall<UpdateDomainMappingRequest, lro::Operation> _callUpdateDomainMapping;

        private readonly gaxgrpc::ApiCall<DeleteDomainMappingRequest, lro::Operation> _callDeleteDomainMapping;

        /// <summary>
        /// Constructs a client wrapper for the DomainMappings service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DomainMappingsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DomainMappingsClientImpl(DomainMappings.DomainMappingsClient grpcClient, DomainMappingsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DomainMappingsSettings effectiveSettings = settings ?? DomainMappingsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDomainMappingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDomainMappingOperationsSettings, logger);
            UpdateDomainMappingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDomainMappingOperationsSettings, logger);
            DeleteDomainMappingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDomainMappingOperationsSettings, logger);
            _callListDomainMappings = clientHelper.BuildApiCall<ListDomainMappingsRequest, ListDomainMappingsResponse>("ListDomainMappings", grpcClient.ListDomainMappingsAsync, grpcClient.ListDomainMappings, effectiveSettings.ListDomainMappingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDomainMappings);
            Modify_ListDomainMappingsApiCall(ref _callListDomainMappings);
            _callGetDomainMapping = clientHelper.BuildApiCall<GetDomainMappingRequest, DomainMapping>("GetDomainMapping", grpcClient.GetDomainMappingAsync, grpcClient.GetDomainMapping, effectiveSettings.GetDomainMappingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDomainMapping);
            Modify_GetDomainMappingApiCall(ref _callGetDomainMapping);
            _callCreateDomainMapping = clientHelper.BuildApiCall<CreateDomainMappingRequest, lro::Operation>("CreateDomainMapping", grpcClient.CreateDomainMappingAsync, grpcClient.CreateDomainMapping, effectiveSettings.CreateDomainMappingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDomainMapping);
            Modify_CreateDomainMappingApiCall(ref _callCreateDomainMapping);
            _callUpdateDomainMapping = clientHelper.BuildApiCall<UpdateDomainMappingRequest, lro::Operation>("UpdateDomainMapping", grpcClient.UpdateDomainMappingAsync, grpcClient.UpdateDomainMapping, effectiveSettings.UpdateDomainMappingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateDomainMapping);
            Modify_UpdateDomainMappingApiCall(ref _callUpdateDomainMapping);
            _callDeleteDomainMapping = clientHelper.BuildApiCall<DeleteDomainMappingRequest, lro::Operation>("DeleteDomainMapping", grpcClient.DeleteDomainMappingAsync, grpcClient.DeleteDomainMapping, effectiveSettings.DeleteDomainMappingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDomainMapping);
            Modify_DeleteDomainMappingApiCall(ref _callDeleteDomainMapping);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDomainMappingsApiCall(ref gaxgrpc::ApiCall<ListDomainMappingsRequest, ListDomainMappingsResponse> call);

        partial void Modify_GetDomainMappingApiCall(ref gaxgrpc::ApiCall<GetDomainMappingRequest, DomainMapping> call);

        partial void Modify_CreateDomainMappingApiCall(ref gaxgrpc::ApiCall<CreateDomainMappingRequest, lro::Operation> call);

        partial void Modify_UpdateDomainMappingApiCall(ref gaxgrpc::ApiCall<UpdateDomainMappingRequest, lro::Operation> call);

        partial void Modify_DeleteDomainMappingApiCall(ref gaxgrpc::ApiCall<DeleteDomainMappingRequest, lro::Operation> call);

        partial void OnConstruction(DomainMappings.DomainMappingsClient grpcClient, DomainMappingsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DomainMappings client</summary>
        public override DomainMappings.DomainMappingsClient GrpcClient { get; }

        partial void Modify_ListDomainMappingsRequest(ref ListDomainMappingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDomainMappingRequest(ref GetDomainMappingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDomainMappingRequest(ref CreateDomainMappingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDomainMappingRequest(ref UpdateDomainMappingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDomainMappingRequest(ref DeleteDomainMappingRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the domain mappings on an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DomainMapping"/> resources.</returns>
        public override gax::PagedEnumerable<ListDomainMappingsResponse, DomainMapping> ListDomainMappings(ListDomainMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDomainMappingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDomainMappingsRequest, ListDomainMappingsResponse, DomainMapping>(_callListDomainMappings, request, callSettings);
        }

        /// <summary>
        /// Lists the domain mappings on an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DomainMapping"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDomainMappingsResponse, DomainMapping> ListDomainMappingsAsync(ListDomainMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDomainMappingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDomainMappingsRequest, ListDomainMappingsResponse, DomainMapping>(_callListDomainMappings, request, callSettings);
        }

        /// <summary>
        /// Gets the specified domain mapping.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DomainMapping GetDomainMapping(GetDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDomainMappingRequest(ref request, ref callSettings);
            return _callGetDomainMapping.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified domain mapping.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DomainMapping> GetDomainMappingAsync(GetDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDomainMappingRequest(ref request, ref callSettings);
            return _callGetDomainMapping.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDomainMapping</c>.</summary>
        public override lro::OperationsClient CreateDomainMappingOperationsClient { get; }

        /// <summary>
        /// Maps a domain to an application. A user must be authorized to administer a
        /// domain in order to map it to an application. For a list of available
        /// authorized domains, see [`AuthorizedDomains.ListAuthorizedDomains`]().
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DomainMapping, OperationMetadataV1> CreateDomainMapping(CreateDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDomainMappingRequest(ref request, ref callSettings);
            return new lro::Operation<DomainMapping, OperationMetadataV1>(_callCreateDomainMapping.Sync(request, callSettings), CreateDomainMappingOperationsClient);
        }

        /// <summary>
        /// Maps a domain to an application. A user must be authorized to administer a
        /// domain in order to map it to an application. For a list of available
        /// authorized domains, see [`AuthorizedDomains.ListAuthorizedDomains`]().
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DomainMapping, OperationMetadataV1>> CreateDomainMappingAsync(CreateDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDomainMappingRequest(ref request, ref callSettings);
            return new lro::Operation<DomainMapping, OperationMetadataV1>(await _callCreateDomainMapping.Async(request, callSettings).ConfigureAwait(false), CreateDomainMappingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDomainMapping</c>.</summary>
        public override lro::OperationsClient UpdateDomainMappingOperationsClient { get; }

        /// <summary>
        /// Updates the specified domain mapping. To map an SSL certificate to a
        /// domain mapping, update `certificate_id` to point to an `AuthorizedCertificate`
        /// resource. A user must be authorized to administer the associated domain
        /// in order to update a `DomainMapping` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DomainMapping, OperationMetadataV1> UpdateDomainMapping(UpdateDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDomainMappingRequest(ref request, ref callSettings);
            return new lro::Operation<DomainMapping, OperationMetadataV1>(_callUpdateDomainMapping.Sync(request, callSettings), UpdateDomainMappingOperationsClient);
        }

        /// <summary>
        /// Updates the specified domain mapping. To map an SSL certificate to a
        /// domain mapping, update `certificate_id` to point to an `AuthorizedCertificate`
        /// resource. A user must be authorized to administer the associated domain
        /// in order to update a `DomainMapping` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DomainMapping, OperationMetadataV1>> UpdateDomainMappingAsync(UpdateDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDomainMappingRequest(ref request, ref callSettings);
            return new lro::Operation<DomainMapping, OperationMetadataV1>(await _callUpdateDomainMapping.Async(request, callSettings).ConfigureAwait(false), UpdateDomainMappingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDomainMapping</c>.</summary>
        public override lro::OperationsClient DeleteDomainMappingOperationsClient { get; }

        /// <summary>
        /// Deletes the specified domain mapping. A user must be authorized to
        /// administer the associated domain in order to delete a `DomainMapping`
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadataV1> DeleteDomainMapping(DeleteDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDomainMappingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadataV1>(_callDeleteDomainMapping.Sync(request, callSettings), DeleteDomainMappingOperationsClient);
        }

        /// <summary>
        /// Deletes the specified domain mapping. A user must be authorized to
        /// administer the associated domain in order to delete a `DomainMapping`
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteDomainMappingAsync(DeleteDomainMappingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDomainMappingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadataV1>(await _callDeleteDomainMapping.Async(request, callSettings).ConfigureAwait(false), DeleteDomainMappingOperationsClient);
        }
    }

    public partial class ListDomainMappingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDomainMappingsResponse : gaxgrpc::IPageResponse<DomainMapping>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DomainMapping> GetEnumerator() => DomainMappings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DomainMappings
    {
        public partial class DomainMappingsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
