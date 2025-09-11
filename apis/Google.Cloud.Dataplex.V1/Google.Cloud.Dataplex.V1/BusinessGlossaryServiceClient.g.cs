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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Settings for <see cref="BusinessGlossaryServiceClient"/> instances.</summary>
    public sealed partial class BusinessGlossaryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BusinessGlossaryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BusinessGlossaryServiceSettings"/>.</returns>
        public static BusinessGlossaryServiceSettings GetDefault() => new BusinessGlossaryServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BusinessGlossaryServiceSettings"/> object with default settings.
        /// </summary>
        public BusinessGlossaryServiceSettings()
        {
        }

        private BusinessGlossaryServiceSettings(BusinessGlossaryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateGlossarySettings = existing.CreateGlossarySettings;
            CreateGlossaryOperationsSettings = existing.CreateGlossaryOperationsSettings.Clone();
            UpdateGlossarySettings = existing.UpdateGlossarySettings;
            UpdateGlossaryOperationsSettings = existing.UpdateGlossaryOperationsSettings.Clone();
            DeleteGlossarySettings = existing.DeleteGlossarySettings;
            DeleteGlossaryOperationsSettings = existing.DeleteGlossaryOperationsSettings.Clone();
            GetGlossarySettings = existing.GetGlossarySettings;
            ListGlossariesSettings = existing.ListGlossariesSettings;
            CreateGlossaryCategorySettings = existing.CreateGlossaryCategorySettings;
            UpdateGlossaryCategorySettings = existing.UpdateGlossaryCategorySettings;
            DeleteGlossaryCategorySettings = existing.DeleteGlossaryCategorySettings;
            GetGlossaryCategorySettings = existing.GetGlossaryCategorySettings;
            ListGlossaryCategoriesSettings = existing.ListGlossaryCategoriesSettings;
            CreateGlossaryTermSettings = existing.CreateGlossaryTermSettings;
            UpdateGlossaryTermSettings = existing.UpdateGlossaryTermSettings;
            DeleteGlossaryTermSettings = existing.DeleteGlossaryTermSettings;
            GetGlossaryTermSettings = existing.GetGlossaryTermSettings;
            ListGlossaryTermsSettings = existing.ListGlossaryTermsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(BusinessGlossaryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.CreateGlossary</c> and <c>BusinessGlossaryServiceClient.CreateGlossaryAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGlossarySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BusinessGlossaryServiceClient.CreateGlossary</c> and
        /// <c>BusinessGlossaryServiceClient.CreateGlossaryAsync</c>.
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
        public lro::OperationsSettings CreateGlossaryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.UpdateGlossary</c> and <c>BusinessGlossaryServiceClient.UpdateGlossaryAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGlossarySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BusinessGlossaryServiceClient.UpdateGlossary</c> and
        /// <c>BusinessGlossaryServiceClient.UpdateGlossaryAsync</c>.
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
        public lro::OperationsSettings UpdateGlossaryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.DeleteGlossary</c> and <c>BusinessGlossaryServiceClient.DeleteGlossaryAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGlossarySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BusinessGlossaryServiceClient.DeleteGlossary</c> and
        /// <c>BusinessGlossaryServiceClient.DeleteGlossaryAsync</c>.
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
        public lro::OperationsSettings DeleteGlossaryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.GetGlossary</c> and <c>BusinessGlossaryServiceClient.GetGlossaryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGlossarySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.ListGlossaries</c> and <c>BusinessGlossaryServiceClient.ListGlossariesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGlossariesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.CreateGlossaryCategory</c> and
        /// <c>BusinessGlossaryServiceClient.CreateGlossaryCategoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGlossaryCategorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.UpdateGlossaryCategory</c> and
        /// <c>BusinessGlossaryServiceClient.UpdateGlossaryCategoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGlossaryCategorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.DeleteGlossaryCategory</c> and
        /// <c>BusinessGlossaryServiceClient.DeleteGlossaryCategoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGlossaryCategorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.GetGlossaryCategory</c> and
        /// <c>BusinessGlossaryServiceClient.GetGlossaryCategoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGlossaryCategorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.ListGlossaryCategories</c> and
        /// <c>BusinessGlossaryServiceClient.ListGlossaryCategoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGlossaryCategoriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.CreateGlossaryTerm</c> and
        /// <c>BusinessGlossaryServiceClient.CreateGlossaryTermAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGlossaryTermSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.UpdateGlossaryTerm</c> and
        /// <c>BusinessGlossaryServiceClient.UpdateGlossaryTermAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGlossaryTermSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.DeleteGlossaryTerm</c> and
        /// <c>BusinessGlossaryServiceClient.DeleteGlossaryTermAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGlossaryTermSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.GetGlossaryTerm</c> and
        /// <c>BusinessGlossaryServiceClient.GetGlossaryTermAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGlossaryTermSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessGlossaryServiceClient.ListGlossaryTerms</c> and
        /// <c>BusinessGlossaryServiceClient.ListGlossaryTermsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGlossaryTermsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BusinessGlossaryServiceSettings"/> object.</returns>
        public BusinessGlossaryServiceSettings Clone() => new BusinessGlossaryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BusinessGlossaryServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BusinessGlossaryServiceClientBuilder : gaxgrpc::ClientBuilderBase<BusinessGlossaryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BusinessGlossaryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BusinessGlossaryServiceClientBuilder() : base(BusinessGlossaryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BusinessGlossaryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BusinessGlossaryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BusinessGlossaryServiceClient Build()
        {
            BusinessGlossaryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BusinessGlossaryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BusinessGlossaryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BusinessGlossaryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BusinessGlossaryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BusinessGlossaryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BusinessGlossaryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BusinessGlossaryServiceClient.ChannelPool;
    }

    /// <summary>BusinessGlossaryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// BusinessGlossaryService provides APIs for managing business glossary
    /// resources for enterprise customers.
    /// The resources currently supported in Business Glossary are:
    /// 1. Glossary
    /// 2. GlossaryCategory
    /// 3. GlossaryTerm
    /// </remarks>
    public abstract partial class BusinessGlossaryServiceClient
    {
        /// <summary>
        /// The default endpoint for the BusinessGlossaryService service, which is a host of "dataplex.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataplex.googleapis.com:443";

        /// <summary>The default BusinessGlossaryService scopes.</summary>
        /// <remarks>
        /// The default BusinessGlossaryService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BusinessGlossaryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BusinessGlossaryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BusinessGlossaryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BusinessGlossaryServiceClient"/>.</returns>
        public static stt::Task<BusinessGlossaryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BusinessGlossaryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BusinessGlossaryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BusinessGlossaryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BusinessGlossaryServiceClient"/>.</returns>
        public static BusinessGlossaryServiceClient Create() => new BusinessGlossaryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BusinessGlossaryServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BusinessGlossaryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BusinessGlossaryServiceClient"/>.</returns>
        internal static BusinessGlossaryServiceClient Create(grpccore::CallInvoker callInvoker, BusinessGlossaryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BusinessGlossaryService.BusinessGlossaryServiceClient grpcClient = new BusinessGlossaryService.BusinessGlossaryServiceClient(callInvoker);
            return new BusinessGlossaryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BusinessGlossaryService client</summary>
        public virtual BusinessGlossaryService.BusinessGlossaryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Glossary, OperationMetadata> CreateGlossary(CreateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> CreateGlossaryAsync(CreateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> CreateGlossaryAsync(CreateGlossaryRequest request, st::CancellationToken cancellationToken) =>
            CreateGlossaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGlossary</c>.</summary>
        public virtual lro::OperationsClient CreateGlossaryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateGlossary</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Glossary, OperationMetadata> PollOnceCreateGlossary(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Glossary, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGlossaryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGlossary</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> PollOnceCreateGlossaryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Glossary, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGlossaryOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Glossary resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Glossary will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="glossary">
        /// Required. The Glossary to create.
        /// </param>
        /// <param name="glossaryId">
        /// Required. Glossary ID: Glossary identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Glossary, OperationMetadata> CreateGlossary(string parent, Glossary glossary, string glossaryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossary(new CreateGlossaryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GlossaryId = gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)),
                Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
            }, callSettings);

        /// <summary>
        /// Creates a new Glossary resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Glossary will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="glossary">
        /// Required. The Glossary to create.
        /// </param>
        /// <param name="glossaryId">
        /// Required. Glossary ID: Glossary identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> CreateGlossaryAsync(string parent, Glossary glossary, string glossaryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryAsync(new CreateGlossaryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GlossaryId = gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)),
                Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
            }, callSettings);

        /// <summary>
        /// Creates a new Glossary resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Glossary will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="glossary">
        /// Required. The Glossary to create.
        /// </param>
        /// <param name="glossaryId">
        /// Required. Glossary ID: Glossary identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> CreateGlossaryAsync(string parent, Glossary glossary, string glossaryId, st::CancellationToken cancellationToken) =>
            CreateGlossaryAsync(parent, glossary, glossaryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Glossary resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Glossary will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="glossary">
        /// Required. The Glossary to create.
        /// </param>
        /// <param name="glossaryId">
        /// Required. Glossary ID: Glossary identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Glossary, OperationMetadata> CreateGlossary(gagr::LocationName parent, Glossary glossary, string glossaryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossary(new CreateGlossaryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GlossaryId = gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)),
                Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
            }, callSettings);

        /// <summary>
        /// Creates a new Glossary resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Glossary will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="glossary">
        /// Required. The Glossary to create.
        /// </param>
        /// <param name="glossaryId">
        /// Required. Glossary ID: Glossary identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> CreateGlossaryAsync(gagr::LocationName parent, Glossary glossary, string glossaryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryAsync(new CreateGlossaryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GlossaryId = gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)),
                Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
            }, callSettings);

        /// <summary>
        /// Creates a new Glossary resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Glossary will be created.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="glossary">
        /// Required. The Glossary to create.
        /// </param>
        /// <param name="glossaryId">
        /// Required. Glossary ID: Glossary identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> CreateGlossaryAsync(gagr::LocationName parent, Glossary glossary, string glossaryId, st::CancellationToken cancellationToken) =>
            CreateGlossaryAsync(parent, glossary, glossaryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Glossary, OperationMetadata> UpdateGlossary(UpdateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> UpdateGlossaryAsync(UpdateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> UpdateGlossaryAsync(UpdateGlossaryRequest request, st::CancellationToken cancellationToken) =>
            UpdateGlossaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGlossary</c>.</summary>
        public virtual lro::OperationsClient UpdateGlossaryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateGlossary</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Glossary, OperationMetadata> PollOnceUpdateGlossary(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Glossary, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGlossaryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGlossary</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> PollOnceUpdateGlossaryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Glossary, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGlossaryOperationsClient, callSettings);

        /// <summary>
        /// Updates a Glossary resource.
        /// </summary>
        /// <param name="glossary">
        /// Required. The Glossary to update.
        /// The Glossary's `name` field is used to identify the Glossary to update.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Glossary, OperationMetadata> UpdateGlossary(Glossary glossary, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGlossary(new UpdateGlossaryRequest
            {
                Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Glossary resource.
        /// </summary>
        /// <param name="glossary">
        /// Required. The Glossary to update.
        /// The Glossary's `name` field is used to identify the Glossary to update.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> UpdateGlossaryAsync(Glossary glossary, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGlossaryAsync(new UpdateGlossaryRequest
            {
                Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Glossary resource.
        /// </summary>
        /// <param name="glossary">
        /// Required. The Glossary to update.
        /// The Glossary's `name` field is used to identify the Glossary to update.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, OperationMetadata>> UpdateGlossaryAsync(Glossary glossary, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGlossaryAsync(glossary, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Glossary resource. All the categories and terms within the
        /// Glossary must be deleted before the Glossary can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGlossary(DeleteGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Glossary resource. All the categories and terms within the
        /// Glossary must be deleted before the Glossary can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGlossaryAsync(DeleteGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Glossary resource. All the categories and terms within the
        /// Glossary must be deleted before the Glossary can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGlossaryAsync(DeleteGlossaryRequest request, st::CancellationToken cancellationToken) =>
            DeleteGlossaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGlossary</c>.</summary>
        public virtual lro::OperationsClient DeleteGlossaryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteGlossary</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteGlossary(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGlossaryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGlossary</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteGlossaryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGlossaryOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Glossary resource. All the categories and terms within the
        /// Glossary must be deleted before the Glossary can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGlossary(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossary(new DeleteGlossaryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Glossary resource. All the categories and terms within the
        /// Glossary must be deleted before the Glossary can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGlossaryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryAsync(new DeleteGlossaryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Glossary resource. All the categories and terms within the
        /// Glossary must be deleted before the Glossary can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGlossaryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGlossaryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Glossary resource. All the categories and terms within the
        /// Glossary must be deleted before the Glossary can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGlossary(GlossaryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossary(new DeleteGlossaryRequest
            {
                GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Glossary resource. All the categories and terms within the
        /// Glossary must be deleted before the Glossary can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGlossaryAsync(GlossaryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryAsync(new DeleteGlossaryRequest
            {
                GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Glossary resource. All the categories and terms within the
        /// Glossary must be deleted before the Glossary can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGlossaryAsync(GlossaryName name, st::CancellationToken cancellationToken) =>
            DeleteGlossaryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Glossary GetGlossary(GetGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(GetGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(GetGlossaryRequest request, st::CancellationToken cancellationToken) =>
            GetGlossaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Glossary resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Glossary GetGlossary(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossary(new GetGlossaryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Glossary resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryAsync(new GetGlossaryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Glossary resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(string name, st::CancellationToken cancellationToken) =>
            GetGlossaryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Glossary resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Glossary GetGlossary(GlossaryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossary(new GetGlossaryRequest
            {
                GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Glossary resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(GlossaryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryAsync(new GetGlossaryRequest
            {
                GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Glossary resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Glossary to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(GlossaryName name, st::CancellationToken cancellationToken) =>
            GetGlossaryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Glossary resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(ListGlossariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Glossary resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(ListGlossariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Glossary resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of Glossaries.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossariesRequest request = new ListGlossariesRequest
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
            return ListGlossaries(request, callSettings);
        }

        /// <summary>
        /// Lists Glossary resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of Glossaries.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossariesRequest request = new ListGlossariesRequest
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
            return ListGlossariesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Glossary resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of Glossaries.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossariesRequest request = new ListGlossariesRequest
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
            return ListGlossaries(request, callSettings);
        }

        /// <summary>
        /// Lists Glossary resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of Glossaries.
        /// Format: projects/{project_id_or_number}/locations/{location_id}
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossariesRequest request = new ListGlossariesRequest
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
            return ListGlossariesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryCategory CreateGlossaryCategory(CreateGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> CreateGlossaryCategoryAsync(CreateGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> CreateGlossaryCategoryAsync(CreateGlossaryCategoryRequest request, st::CancellationToken cancellationToken) =>
            CreateGlossaryCategoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new GlossaryCategory resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this GlossaryCategory will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `locationId` refers to a Google Cloud region.
        /// </param>
        /// <param name="category">
        /// Required. The GlossaryCategory to create.
        /// </param>
        /// <param name="categoryId">
        /// Required. GlossaryCategory identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryCategory CreateGlossaryCategory(string parent, GlossaryCategory category, string categoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryCategory(new CreateGlossaryCategoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CategoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)),
                Category = gax::GaxPreconditions.CheckNotNull(category, nameof(category)),
            }, callSettings);

        /// <summary>
        /// Creates a new GlossaryCategory resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this GlossaryCategory will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `locationId` refers to a Google Cloud region.
        /// </param>
        /// <param name="category">
        /// Required. The GlossaryCategory to create.
        /// </param>
        /// <param name="categoryId">
        /// Required. GlossaryCategory identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> CreateGlossaryCategoryAsync(string parent, GlossaryCategory category, string categoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryCategoryAsync(new CreateGlossaryCategoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CategoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)),
                Category = gax::GaxPreconditions.CheckNotNull(category, nameof(category)),
            }, callSettings);

        /// <summary>
        /// Creates a new GlossaryCategory resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this GlossaryCategory will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `locationId` refers to a Google Cloud region.
        /// </param>
        /// <param name="category">
        /// Required. The GlossaryCategory to create.
        /// </param>
        /// <param name="categoryId">
        /// Required. GlossaryCategory identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> CreateGlossaryCategoryAsync(string parent, GlossaryCategory category, string categoryId, st::CancellationToken cancellationToken) =>
            CreateGlossaryCategoryAsync(parent, category, categoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new GlossaryCategory resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this GlossaryCategory will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `locationId` refers to a Google Cloud region.
        /// </param>
        /// <param name="category">
        /// Required. The GlossaryCategory to create.
        /// </param>
        /// <param name="categoryId">
        /// Required. GlossaryCategory identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryCategory CreateGlossaryCategory(GlossaryName parent, GlossaryCategory category, string categoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryCategory(new CreateGlossaryCategoryRequest
            {
                ParentAsGlossaryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CategoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)),
                Category = gax::GaxPreconditions.CheckNotNull(category, nameof(category)),
            }, callSettings);

        /// <summary>
        /// Creates a new GlossaryCategory resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this GlossaryCategory will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `locationId` refers to a Google Cloud region.
        /// </param>
        /// <param name="category">
        /// Required. The GlossaryCategory to create.
        /// </param>
        /// <param name="categoryId">
        /// Required. GlossaryCategory identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> CreateGlossaryCategoryAsync(GlossaryName parent, GlossaryCategory category, string categoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryCategoryAsync(new CreateGlossaryCategoryRequest
            {
                ParentAsGlossaryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CategoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)),
                Category = gax::GaxPreconditions.CheckNotNull(category, nameof(category)),
            }, callSettings);

        /// <summary>
        /// Creates a new GlossaryCategory resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this GlossaryCategory will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `locationId` refers to a Google Cloud region.
        /// </param>
        /// <param name="category">
        /// Required. The GlossaryCategory to create.
        /// </param>
        /// <param name="categoryId">
        /// Required. GlossaryCategory identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> CreateGlossaryCategoryAsync(GlossaryName parent, GlossaryCategory category, string categoryId, st::CancellationToken cancellationToken) =>
            CreateGlossaryCategoryAsync(parent, category, categoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryCategory UpdateGlossaryCategory(UpdateGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> UpdateGlossaryCategoryAsync(UpdateGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> UpdateGlossaryCategoryAsync(UpdateGlossaryCategoryRequest request, st::CancellationToken cancellationToken) =>
            UpdateGlossaryCategoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a GlossaryCategory resource.
        /// </summary>
        /// <param name="category">
        /// Required. The GlossaryCategory to update.
        /// The GlossaryCategory's `name` field is used to identify the
        /// GlossaryCategory to update. Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryCategory UpdateGlossaryCategory(GlossaryCategory category, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGlossaryCategory(new UpdateGlossaryCategoryRequest
            {
                Category = gax::GaxPreconditions.CheckNotNull(category, nameof(category)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a GlossaryCategory resource.
        /// </summary>
        /// <param name="category">
        /// Required. The GlossaryCategory to update.
        /// The GlossaryCategory's `name` field is used to identify the
        /// GlossaryCategory to update. Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> UpdateGlossaryCategoryAsync(GlossaryCategory category, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGlossaryCategoryAsync(new UpdateGlossaryCategoryRequest
            {
                Category = gax::GaxPreconditions.CheckNotNull(category, nameof(category)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a GlossaryCategory resource.
        /// </summary>
        /// <param name="category">
        /// Required. The GlossaryCategory to update.
        /// The GlossaryCategory's `name` field is used to identify the
        /// GlossaryCategory to update. Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> UpdateGlossaryCategoryAsync(GlossaryCategory category, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGlossaryCategoryAsync(category, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a GlossaryCategory resource. All the GlossaryCategories and
        /// GlossaryTerms nested directly under the specified GlossaryCategory will be
        /// moved one level up to the parent in the hierarchy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGlossaryCategory(DeleteGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a GlossaryCategory resource. All the GlossaryCategories and
        /// GlossaryTerms nested directly under the specified GlossaryCategory will be
        /// moved one level up to the parent in the hierarchy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryCategoryAsync(DeleteGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a GlossaryCategory resource. All the GlossaryCategories and
        /// GlossaryTerms nested directly under the specified GlossaryCategory will be
        /// moved one level up to the parent in the hierarchy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryCategoryAsync(DeleteGlossaryCategoryRequest request, st::CancellationToken cancellationToken) =>
            DeleteGlossaryCategoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a GlossaryCategory resource. All the GlossaryCategories and
        /// GlossaryTerms nested directly under the specified GlossaryCategory will be
        /// moved one level up to the parent in the hierarchy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGlossaryCategory(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryCategory(new DeleteGlossaryCategoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GlossaryCategory resource. All the GlossaryCategories and
        /// GlossaryTerms nested directly under the specified GlossaryCategory will be
        /// moved one level up to the parent in the hierarchy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryCategoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryCategoryAsync(new DeleteGlossaryCategoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GlossaryCategory resource. All the GlossaryCategories and
        /// GlossaryTerms nested directly under the specified GlossaryCategory will be
        /// moved one level up to the parent in the hierarchy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryCategoryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGlossaryCategoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a GlossaryCategory resource. All the GlossaryCategories and
        /// GlossaryTerms nested directly under the specified GlossaryCategory will be
        /// moved one level up to the parent in the hierarchy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGlossaryCategory(GlossaryCategoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryCategory(new DeleteGlossaryCategoryRequest
            {
                GlossaryCategoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GlossaryCategory resource. All the GlossaryCategories and
        /// GlossaryTerms nested directly under the specified GlossaryCategory will be
        /// moved one level up to the parent in the hierarchy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryCategoryAsync(GlossaryCategoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryCategoryAsync(new DeleteGlossaryCategoryRequest
            {
                GlossaryCategoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GlossaryCategory resource. All the GlossaryCategories and
        /// GlossaryTerms nested directly under the specified GlossaryCategory will be
        /// moved one level up to the parent in the hierarchy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryCategoryAsync(GlossaryCategoryName name, st::CancellationToken cancellationToken) =>
            DeleteGlossaryCategoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryCategory GetGlossaryCategory(GetGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> GetGlossaryCategoryAsync(GetGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> GetGlossaryCategoryAsync(GetGlossaryCategoryRequest request, st::CancellationToken cancellationToken) =>
            GetGlossaryCategoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a GlossaryCategory resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryCategory GetGlossaryCategory(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryCategory(new GetGlossaryCategoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a GlossaryCategory resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> GetGlossaryCategoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryCategoryAsync(new GetGlossaryCategoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a GlossaryCategory resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> GetGlossaryCategoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetGlossaryCategoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a GlossaryCategory resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryCategory GetGlossaryCategory(GlossaryCategoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryCategory(new GetGlossaryCategoryRequest
            {
                GlossaryCategoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a GlossaryCategory resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> GetGlossaryCategoryAsync(GlossaryCategoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryCategoryAsync(new GetGlossaryCategoryRequest
            {
                GlossaryCategoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a GlossaryCategory resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryCategory to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/categories/{category_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryCategory> GetGlossaryCategoryAsync(GlossaryCategoryName name, st::CancellationToken cancellationToken) =>
            GetGlossaryCategoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists GlossaryCategory resources in a Glossary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GlossaryCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossaryCategoriesResponse, GlossaryCategory> ListGlossaryCategories(ListGlossaryCategoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GlossaryCategory resources in a Glossary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GlossaryCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossaryCategoriesResponse, GlossaryCategory> ListGlossaryCategoriesAsync(ListGlossaryCategoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GlossaryCategory resources in a Glossary.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of GlossaryCategories.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// Location is the Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="GlossaryCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossaryCategoriesResponse, GlossaryCategory> ListGlossaryCategories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossaryCategoriesRequest request = new ListGlossaryCategoriesRequest
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
            return ListGlossaryCategories(request, callSettings);
        }

        /// <summary>
        /// Lists GlossaryCategory resources in a Glossary.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of GlossaryCategories.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// Location is the Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GlossaryCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossaryCategoriesResponse, GlossaryCategory> ListGlossaryCategoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossaryCategoriesRequest request = new ListGlossaryCategoriesRequest
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
            return ListGlossaryCategoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists GlossaryCategory resources in a Glossary.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of GlossaryCategories.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// Location is the Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="GlossaryCategory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossaryCategoriesResponse, GlossaryCategory> ListGlossaryCategories(GlossaryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossaryCategoriesRequest request = new ListGlossaryCategoriesRequest
            {
                ParentAsGlossaryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGlossaryCategories(request, callSettings);
        }

        /// <summary>
        /// Lists GlossaryCategory resources in a Glossary.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of GlossaryCategories.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// Location is the Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GlossaryCategory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossaryCategoriesResponse, GlossaryCategory> ListGlossaryCategoriesAsync(GlossaryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossaryCategoriesRequest request = new ListGlossaryCategoriesRequest
            {
                ParentAsGlossaryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGlossaryCategoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryTerm CreateGlossaryTerm(CreateGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> CreateGlossaryTermAsync(CreateGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> CreateGlossaryTermAsync(CreateGlossaryTermRequest request, st::CancellationToken cancellationToken) =>
            CreateGlossaryTermAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new GlossaryTerm resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the GlossaryTerm will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="term">
        /// Required. The GlossaryTerm to create.
        /// </param>
        /// <param name="termId">
        /// Required. GlossaryTerm identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryTerm CreateGlossaryTerm(string parent, GlossaryTerm term, string termId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryTerm(new CreateGlossaryTermRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TermId = gax::GaxPreconditions.CheckNotNullOrEmpty(termId, nameof(termId)),
                Term = gax::GaxPreconditions.CheckNotNull(term, nameof(term)),
            }, callSettings);

        /// <summary>
        /// Creates a new GlossaryTerm resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the GlossaryTerm will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="term">
        /// Required. The GlossaryTerm to create.
        /// </param>
        /// <param name="termId">
        /// Required. GlossaryTerm identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> CreateGlossaryTermAsync(string parent, GlossaryTerm term, string termId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryTermAsync(new CreateGlossaryTermRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TermId = gax::GaxPreconditions.CheckNotNullOrEmpty(termId, nameof(termId)),
                Term = gax::GaxPreconditions.CheckNotNull(term, nameof(term)),
            }, callSettings);

        /// <summary>
        /// Creates a new GlossaryTerm resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the GlossaryTerm will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="term">
        /// Required. The GlossaryTerm to create.
        /// </param>
        /// <param name="termId">
        /// Required. GlossaryTerm identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> CreateGlossaryTermAsync(string parent, GlossaryTerm term, string termId, st::CancellationToken cancellationToken) =>
            CreateGlossaryTermAsync(parent, term, termId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new GlossaryTerm resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the GlossaryTerm will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="term">
        /// Required. The GlossaryTerm to create.
        /// </param>
        /// <param name="termId">
        /// Required. GlossaryTerm identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryTerm CreateGlossaryTerm(GlossaryName parent, GlossaryTerm term, string termId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryTerm(new CreateGlossaryTermRequest
            {
                ParentAsGlossaryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TermId = gax::GaxPreconditions.CheckNotNullOrEmpty(termId, nameof(termId)),
                Term = gax::GaxPreconditions.CheckNotNull(term, nameof(term)),
            }, callSettings);

        /// <summary>
        /// Creates a new GlossaryTerm resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the GlossaryTerm will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="term">
        /// Required. The GlossaryTerm to create.
        /// </param>
        /// <param name="termId">
        /// Required. GlossaryTerm identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> CreateGlossaryTermAsync(GlossaryName parent, GlossaryTerm term, string termId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryTermAsync(new CreateGlossaryTermRequest
            {
                ParentAsGlossaryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TermId = gax::GaxPreconditions.CheckNotNullOrEmpty(termId, nameof(termId)),
                Term = gax::GaxPreconditions.CheckNotNull(term, nameof(term)),
            }, callSettings);

        /// <summary>
        /// Creates a new GlossaryTerm resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where the GlossaryTerm will be created.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="term">
        /// Required. The GlossaryTerm to create.
        /// </param>
        /// <param name="termId">
        /// Required. GlossaryTerm identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> CreateGlossaryTermAsync(GlossaryName parent, GlossaryTerm term, string termId, st::CancellationToken cancellationToken) =>
            CreateGlossaryTermAsync(parent, term, termId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryTerm UpdateGlossaryTerm(UpdateGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> UpdateGlossaryTermAsync(UpdateGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> UpdateGlossaryTermAsync(UpdateGlossaryTermRequest request, st::CancellationToken cancellationToken) =>
            UpdateGlossaryTermAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a GlossaryTerm resource.
        /// </summary>
        /// <param name="term">
        /// Required. The GlossaryTerm to update.
        /// The GlossaryTerm's `name` field is used to identify the GlossaryTerm to
        /// update. Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryTerm UpdateGlossaryTerm(GlossaryTerm term, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGlossaryTerm(new UpdateGlossaryTermRequest
            {
                Term = gax::GaxPreconditions.CheckNotNull(term, nameof(term)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a GlossaryTerm resource.
        /// </summary>
        /// <param name="term">
        /// Required. The GlossaryTerm to update.
        /// The GlossaryTerm's `name` field is used to identify the GlossaryTerm to
        /// update. Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> UpdateGlossaryTermAsync(GlossaryTerm term, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGlossaryTermAsync(new UpdateGlossaryTermRequest
            {
                Term = gax::GaxPreconditions.CheckNotNull(term, nameof(term)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a GlossaryTerm resource.
        /// </summary>
        /// <param name="term">
        /// Required. The GlossaryTerm to update.
        /// The GlossaryTerm's `name` field is used to identify the GlossaryTerm to
        /// update. Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> UpdateGlossaryTermAsync(GlossaryTerm term, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGlossaryTermAsync(term, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGlossaryTerm(DeleteGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryTermAsync(DeleteGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryTermAsync(DeleteGlossaryTermRequest request, st::CancellationToken cancellationToken) =>
            DeleteGlossaryTermAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGlossaryTerm(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryTerm(new DeleteGlossaryTermRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryTermAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryTermAsync(new DeleteGlossaryTermRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryTermAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGlossaryTermAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGlossaryTerm(GlossaryTermName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryTerm(new DeleteGlossaryTermRequest
            {
                GlossaryTermName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryTermAsync(GlossaryTermName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryTermAsync(new DeleteGlossaryTermRequest
            {
                GlossaryTermName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to delete.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGlossaryTermAsync(GlossaryTermName name, st::CancellationToken cancellationToken) =>
            DeleteGlossaryTermAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryTerm GetGlossaryTerm(GetGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> GetGlossaryTermAsync(GetGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> GetGlossaryTermAsync(GetGlossaryTermRequest request, st::CancellationToken cancellationToken) =>
            GetGlossaryTermAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryTerm GetGlossaryTerm(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryTerm(new GetGlossaryTermRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> GetGlossaryTermAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryTermAsync(new GetGlossaryTermRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> GetGlossaryTermAsync(string name, st::CancellationToken cancellationToken) =>
            GetGlossaryTermAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlossaryTerm GetGlossaryTerm(GlossaryTermName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryTerm(new GetGlossaryTermRequest
            {
                GlossaryTermName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> GetGlossaryTermAsync(GlossaryTermName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryTermAsync(new GetGlossaryTermRequest
            {
                GlossaryTermName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a GlossaryTerm resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the GlossaryTerm to retrieve.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}/terms/{term_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlossaryTerm> GetGlossaryTermAsync(GlossaryTermName name, st::CancellationToken cancellationToken) =>
            GetGlossaryTermAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists GlossaryTerm resources in a Glossary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GlossaryTerm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossaryTermsResponse, GlossaryTerm> ListGlossaryTerms(ListGlossaryTermsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GlossaryTerm resources in a Glossary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GlossaryTerm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossaryTermsResponse, GlossaryTerm> ListGlossaryTermsAsync(ListGlossaryTermsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists GlossaryTerm resources in a Glossary.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of GlossaryTerms.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="GlossaryTerm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossaryTermsResponse, GlossaryTerm> ListGlossaryTerms(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossaryTermsRequest request = new ListGlossaryTermsRequest
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
            return ListGlossaryTerms(request, callSettings);
        }

        /// <summary>
        /// Lists GlossaryTerm resources in a Glossary.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of GlossaryTerms.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GlossaryTerm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossaryTermsResponse, GlossaryTerm> ListGlossaryTermsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossaryTermsRequest request = new ListGlossaryTermsRequest
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
            return ListGlossaryTermsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists GlossaryTerm resources in a Glossary.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of GlossaryTerms.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="GlossaryTerm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossaryTermsResponse, GlossaryTerm> ListGlossaryTerms(GlossaryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossaryTermsRequest request = new ListGlossaryTermsRequest
            {
                ParentAsGlossaryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGlossaryTerms(request, callSettings);
        }

        /// <summary>
        /// Lists GlossaryTerm resources in a Glossary.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which has this collection of GlossaryTerms.
        /// Format:
        /// projects/{project_id_or_number}/locations/{location_id}/glossaries/{glossary_id}
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GlossaryTerm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossaryTermsResponse, GlossaryTerm> ListGlossaryTermsAsync(GlossaryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlossaryTermsRequest request = new ListGlossaryTermsRequest
            {
                ParentAsGlossaryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGlossaryTermsAsync(request, callSettings);
        }
    }

    /// <summary>BusinessGlossaryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// BusinessGlossaryService provides APIs for managing business glossary
    /// resources for enterprise customers.
    /// The resources currently supported in Business Glossary are:
    /// 1. Glossary
    /// 2. GlossaryCategory
    /// 3. GlossaryTerm
    /// </remarks>
    public sealed partial class BusinessGlossaryServiceClientImpl : BusinessGlossaryServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateGlossaryRequest, lro::Operation> _callCreateGlossary;

        private readonly gaxgrpc::ApiCall<UpdateGlossaryRequest, lro::Operation> _callUpdateGlossary;

        private readonly gaxgrpc::ApiCall<DeleteGlossaryRequest, lro::Operation> _callDeleteGlossary;

        private readonly gaxgrpc::ApiCall<GetGlossaryRequest, Glossary> _callGetGlossary;

        private readonly gaxgrpc::ApiCall<ListGlossariesRequest, ListGlossariesResponse> _callListGlossaries;

        private readonly gaxgrpc::ApiCall<CreateGlossaryCategoryRequest, GlossaryCategory> _callCreateGlossaryCategory;

        private readonly gaxgrpc::ApiCall<UpdateGlossaryCategoryRequest, GlossaryCategory> _callUpdateGlossaryCategory;

        private readonly gaxgrpc::ApiCall<DeleteGlossaryCategoryRequest, wkt::Empty> _callDeleteGlossaryCategory;

        private readonly gaxgrpc::ApiCall<GetGlossaryCategoryRequest, GlossaryCategory> _callGetGlossaryCategory;

        private readonly gaxgrpc::ApiCall<ListGlossaryCategoriesRequest, ListGlossaryCategoriesResponse> _callListGlossaryCategories;

        private readonly gaxgrpc::ApiCall<CreateGlossaryTermRequest, GlossaryTerm> _callCreateGlossaryTerm;

        private readonly gaxgrpc::ApiCall<UpdateGlossaryTermRequest, GlossaryTerm> _callUpdateGlossaryTerm;

        private readonly gaxgrpc::ApiCall<DeleteGlossaryTermRequest, wkt::Empty> _callDeleteGlossaryTerm;

        private readonly gaxgrpc::ApiCall<GetGlossaryTermRequest, GlossaryTerm> _callGetGlossaryTerm;

        private readonly gaxgrpc::ApiCall<ListGlossaryTermsRequest, ListGlossaryTermsResponse> _callListGlossaryTerms;

        /// <summary>
        /// Constructs a client wrapper for the BusinessGlossaryService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BusinessGlossaryServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BusinessGlossaryServiceClientImpl(BusinessGlossaryService.BusinessGlossaryServiceClient grpcClient, BusinessGlossaryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BusinessGlossaryServiceSettings effectiveSettings = settings ?? BusinessGlossaryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateGlossaryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGlossaryOperationsSettings, logger);
            UpdateGlossaryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGlossaryOperationsSettings, logger);
            DeleteGlossaryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGlossaryOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateGlossary = clientHelper.BuildApiCall<CreateGlossaryRequest, lro::Operation>("CreateGlossary", grpcClient.CreateGlossaryAsync, grpcClient.CreateGlossary, effectiveSettings.CreateGlossarySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGlossary);
            Modify_CreateGlossaryApiCall(ref _callCreateGlossary);
            _callUpdateGlossary = clientHelper.BuildApiCall<UpdateGlossaryRequest, lro::Operation>("UpdateGlossary", grpcClient.UpdateGlossaryAsync, grpcClient.UpdateGlossary, effectiveSettings.UpdateGlossarySettings).WithGoogleRequestParam("glossary.name", request => request.Glossary?.Name);
            Modify_ApiCall(ref _callUpdateGlossary);
            Modify_UpdateGlossaryApiCall(ref _callUpdateGlossary);
            _callDeleteGlossary = clientHelper.BuildApiCall<DeleteGlossaryRequest, lro::Operation>("DeleteGlossary", grpcClient.DeleteGlossaryAsync, grpcClient.DeleteGlossary, effectiveSettings.DeleteGlossarySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGlossary);
            Modify_DeleteGlossaryApiCall(ref _callDeleteGlossary);
            _callGetGlossary = clientHelper.BuildApiCall<GetGlossaryRequest, Glossary>("GetGlossary", grpcClient.GetGlossaryAsync, grpcClient.GetGlossary, effectiveSettings.GetGlossarySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGlossary);
            Modify_GetGlossaryApiCall(ref _callGetGlossary);
            _callListGlossaries = clientHelper.BuildApiCall<ListGlossariesRequest, ListGlossariesResponse>("ListGlossaries", grpcClient.ListGlossariesAsync, grpcClient.ListGlossaries, effectiveSettings.ListGlossariesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGlossaries);
            Modify_ListGlossariesApiCall(ref _callListGlossaries);
            _callCreateGlossaryCategory = clientHelper.BuildApiCall<CreateGlossaryCategoryRequest, GlossaryCategory>("CreateGlossaryCategory", grpcClient.CreateGlossaryCategoryAsync, grpcClient.CreateGlossaryCategory, effectiveSettings.CreateGlossaryCategorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGlossaryCategory);
            Modify_CreateGlossaryCategoryApiCall(ref _callCreateGlossaryCategory);
            _callUpdateGlossaryCategory = clientHelper.BuildApiCall<UpdateGlossaryCategoryRequest, GlossaryCategory>("UpdateGlossaryCategory", grpcClient.UpdateGlossaryCategoryAsync, grpcClient.UpdateGlossaryCategory, effectiveSettings.UpdateGlossaryCategorySettings).WithGoogleRequestParam("category.name", request => request.Category?.Name);
            Modify_ApiCall(ref _callUpdateGlossaryCategory);
            Modify_UpdateGlossaryCategoryApiCall(ref _callUpdateGlossaryCategory);
            _callDeleteGlossaryCategory = clientHelper.BuildApiCall<DeleteGlossaryCategoryRequest, wkt::Empty>("DeleteGlossaryCategory", grpcClient.DeleteGlossaryCategoryAsync, grpcClient.DeleteGlossaryCategory, effectiveSettings.DeleteGlossaryCategorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGlossaryCategory);
            Modify_DeleteGlossaryCategoryApiCall(ref _callDeleteGlossaryCategory);
            _callGetGlossaryCategory = clientHelper.BuildApiCall<GetGlossaryCategoryRequest, GlossaryCategory>("GetGlossaryCategory", grpcClient.GetGlossaryCategoryAsync, grpcClient.GetGlossaryCategory, effectiveSettings.GetGlossaryCategorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGlossaryCategory);
            Modify_GetGlossaryCategoryApiCall(ref _callGetGlossaryCategory);
            _callListGlossaryCategories = clientHelper.BuildApiCall<ListGlossaryCategoriesRequest, ListGlossaryCategoriesResponse>("ListGlossaryCategories", grpcClient.ListGlossaryCategoriesAsync, grpcClient.ListGlossaryCategories, effectiveSettings.ListGlossaryCategoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGlossaryCategories);
            Modify_ListGlossaryCategoriesApiCall(ref _callListGlossaryCategories);
            _callCreateGlossaryTerm = clientHelper.BuildApiCall<CreateGlossaryTermRequest, GlossaryTerm>("CreateGlossaryTerm", grpcClient.CreateGlossaryTermAsync, grpcClient.CreateGlossaryTerm, effectiveSettings.CreateGlossaryTermSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGlossaryTerm);
            Modify_CreateGlossaryTermApiCall(ref _callCreateGlossaryTerm);
            _callUpdateGlossaryTerm = clientHelper.BuildApiCall<UpdateGlossaryTermRequest, GlossaryTerm>("UpdateGlossaryTerm", grpcClient.UpdateGlossaryTermAsync, grpcClient.UpdateGlossaryTerm, effectiveSettings.UpdateGlossaryTermSettings).WithGoogleRequestParam("term.name", request => request.Term?.Name);
            Modify_ApiCall(ref _callUpdateGlossaryTerm);
            Modify_UpdateGlossaryTermApiCall(ref _callUpdateGlossaryTerm);
            _callDeleteGlossaryTerm = clientHelper.BuildApiCall<DeleteGlossaryTermRequest, wkt::Empty>("DeleteGlossaryTerm", grpcClient.DeleteGlossaryTermAsync, grpcClient.DeleteGlossaryTerm, effectiveSettings.DeleteGlossaryTermSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGlossaryTerm);
            Modify_DeleteGlossaryTermApiCall(ref _callDeleteGlossaryTerm);
            _callGetGlossaryTerm = clientHelper.BuildApiCall<GetGlossaryTermRequest, GlossaryTerm>("GetGlossaryTerm", grpcClient.GetGlossaryTermAsync, grpcClient.GetGlossaryTerm, effectiveSettings.GetGlossaryTermSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGlossaryTerm);
            Modify_GetGlossaryTermApiCall(ref _callGetGlossaryTerm);
            _callListGlossaryTerms = clientHelper.BuildApiCall<ListGlossaryTermsRequest, ListGlossaryTermsResponse>("ListGlossaryTerms", grpcClient.ListGlossaryTermsAsync, grpcClient.ListGlossaryTerms, effectiveSettings.ListGlossaryTermsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGlossaryTerms);
            Modify_ListGlossaryTermsApiCall(ref _callListGlossaryTerms);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateGlossaryApiCall(ref gaxgrpc::ApiCall<CreateGlossaryRequest, lro::Operation> call);

        partial void Modify_UpdateGlossaryApiCall(ref gaxgrpc::ApiCall<UpdateGlossaryRequest, lro::Operation> call);

        partial void Modify_DeleteGlossaryApiCall(ref gaxgrpc::ApiCall<DeleteGlossaryRequest, lro::Operation> call);

        partial void Modify_GetGlossaryApiCall(ref gaxgrpc::ApiCall<GetGlossaryRequest, Glossary> call);

        partial void Modify_ListGlossariesApiCall(ref gaxgrpc::ApiCall<ListGlossariesRequest, ListGlossariesResponse> call);

        partial void Modify_CreateGlossaryCategoryApiCall(ref gaxgrpc::ApiCall<CreateGlossaryCategoryRequest, GlossaryCategory> call);

        partial void Modify_UpdateGlossaryCategoryApiCall(ref gaxgrpc::ApiCall<UpdateGlossaryCategoryRequest, GlossaryCategory> call);

        partial void Modify_DeleteGlossaryCategoryApiCall(ref gaxgrpc::ApiCall<DeleteGlossaryCategoryRequest, wkt::Empty> call);

        partial void Modify_GetGlossaryCategoryApiCall(ref gaxgrpc::ApiCall<GetGlossaryCategoryRequest, GlossaryCategory> call);

        partial void Modify_ListGlossaryCategoriesApiCall(ref gaxgrpc::ApiCall<ListGlossaryCategoriesRequest, ListGlossaryCategoriesResponse> call);

        partial void Modify_CreateGlossaryTermApiCall(ref gaxgrpc::ApiCall<CreateGlossaryTermRequest, GlossaryTerm> call);

        partial void Modify_UpdateGlossaryTermApiCall(ref gaxgrpc::ApiCall<UpdateGlossaryTermRequest, GlossaryTerm> call);

        partial void Modify_DeleteGlossaryTermApiCall(ref gaxgrpc::ApiCall<DeleteGlossaryTermRequest, wkt::Empty> call);

        partial void Modify_GetGlossaryTermApiCall(ref gaxgrpc::ApiCall<GetGlossaryTermRequest, GlossaryTerm> call);

        partial void Modify_ListGlossaryTermsApiCall(ref gaxgrpc::ApiCall<ListGlossaryTermsRequest, ListGlossaryTermsResponse> call);

        partial void OnConstruction(BusinessGlossaryService.BusinessGlossaryServiceClient grpcClient, BusinessGlossaryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BusinessGlossaryService client</summary>
        public override BusinessGlossaryService.BusinessGlossaryServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateGlossaryRequest(ref CreateGlossaryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGlossaryRequest(ref UpdateGlossaryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGlossaryRequest(ref DeleteGlossaryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGlossaryRequest(ref GetGlossaryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGlossariesRequest(ref ListGlossariesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGlossaryCategoryRequest(ref CreateGlossaryCategoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGlossaryCategoryRequest(ref UpdateGlossaryCategoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGlossaryCategoryRequest(ref DeleteGlossaryCategoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGlossaryCategoryRequest(ref GetGlossaryCategoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGlossaryCategoriesRequest(ref ListGlossaryCategoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGlossaryTermRequest(ref CreateGlossaryTermRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGlossaryTermRequest(ref UpdateGlossaryTermRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGlossaryTermRequest(ref DeleteGlossaryTermRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGlossaryTermRequest(ref GetGlossaryTermRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGlossaryTermsRequest(ref ListGlossaryTermsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateGlossary</c>.</summary>
        public override lro::OperationsClient CreateGlossaryOperationsClient { get; }

        /// <summary>
        /// Creates a new Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Glossary, OperationMetadata> CreateGlossary(CreateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<Glossary, OperationMetadata>(_callCreateGlossary.Sync(request, callSettings), CreateGlossaryOperationsClient);
        }

        /// <summary>
        /// Creates a new Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Glossary, OperationMetadata>> CreateGlossaryAsync(CreateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<Glossary, OperationMetadata>(await _callCreateGlossary.Async(request, callSettings).ConfigureAwait(false), CreateGlossaryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateGlossary</c>.</summary>
        public override lro::OperationsClient UpdateGlossaryOperationsClient { get; }

        /// <summary>
        /// Updates a Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Glossary, OperationMetadata> UpdateGlossary(UpdateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<Glossary, OperationMetadata>(_callUpdateGlossary.Sync(request, callSettings), UpdateGlossaryOperationsClient);
        }

        /// <summary>
        /// Updates a Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Glossary, OperationMetadata>> UpdateGlossaryAsync(UpdateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<Glossary, OperationMetadata>(await _callUpdateGlossary.Async(request, callSettings).ConfigureAwait(false), UpdateGlossaryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGlossary</c>.</summary>
        public override lro::OperationsClient DeleteGlossaryOperationsClient { get; }

        /// <summary>
        /// Deletes a Glossary resource. All the categories and terms within the
        /// Glossary must be deleted before the Glossary can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteGlossary(DeleteGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteGlossary.Sync(request, callSettings), DeleteGlossaryOperationsClient);
        }

        /// <summary>
        /// Deletes a Glossary resource. All the categories and terms within the
        /// Glossary must be deleted before the Glossary can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGlossaryAsync(DeleteGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteGlossary.Async(request, callSettings).ConfigureAwait(false), DeleteGlossaryOperationsClient);
        }

        /// <summary>
        /// Gets a Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Glossary GetGlossary(GetGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlossaryRequest(ref request, ref callSettings);
            return _callGetGlossary.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Glossary resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Glossary> GetGlossaryAsync(GetGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlossaryRequest(ref request, ref callSettings);
            return _callGetGlossary.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Glossary resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Glossary"/> resources.</returns>
        public override gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(ListGlossariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlossariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGlossariesRequest, ListGlossariesResponse, Glossary>(_callListGlossaries, request, callSettings);
        }

        /// <summary>
        /// Lists Glossary resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Glossary"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(ListGlossariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlossariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGlossariesRequest, ListGlossariesResponse, Glossary>(_callListGlossaries, request, callSettings);
        }

        /// <summary>
        /// Creates a new GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GlossaryCategory CreateGlossaryCategory(CreateGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGlossaryCategoryRequest(ref request, ref callSettings);
            return _callCreateGlossaryCategory.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GlossaryCategory> CreateGlossaryCategoryAsync(CreateGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGlossaryCategoryRequest(ref request, ref callSettings);
            return _callCreateGlossaryCategory.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GlossaryCategory UpdateGlossaryCategory(UpdateGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGlossaryCategoryRequest(ref request, ref callSettings);
            return _callUpdateGlossaryCategory.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GlossaryCategory> UpdateGlossaryCategoryAsync(UpdateGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGlossaryCategoryRequest(ref request, ref callSettings);
            return _callUpdateGlossaryCategory.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a GlossaryCategory resource. All the GlossaryCategories and
        /// GlossaryTerms nested directly under the specified GlossaryCategory will be
        /// moved one level up to the parent in the hierarchy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteGlossaryCategory(DeleteGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlossaryCategoryRequest(ref request, ref callSettings);
            _callDeleteGlossaryCategory.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a GlossaryCategory resource. All the GlossaryCategories and
        /// GlossaryTerms nested directly under the specified GlossaryCategory will be
        /// moved one level up to the parent in the hierarchy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteGlossaryCategoryAsync(DeleteGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlossaryCategoryRequest(ref request, ref callSettings);
            return _callDeleteGlossaryCategory.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GlossaryCategory GetGlossaryCategory(GetGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlossaryCategoryRequest(ref request, ref callSettings);
            return _callGetGlossaryCategory.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a GlossaryCategory resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GlossaryCategory> GetGlossaryCategoryAsync(GetGlossaryCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlossaryCategoryRequest(ref request, ref callSettings);
            return _callGetGlossaryCategory.Async(request, callSettings);
        }

        /// <summary>
        /// Lists GlossaryCategory resources in a Glossary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GlossaryCategory"/> resources.</returns>
        public override gax::PagedEnumerable<ListGlossaryCategoriesResponse, GlossaryCategory> ListGlossaryCategories(ListGlossaryCategoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlossaryCategoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGlossaryCategoriesRequest, ListGlossaryCategoriesResponse, GlossaryCategory>(_callListGlossaryCategories, request, callSettings);
        }

        /// <summary>
        /// Lists GlossaryCategory resources in a Glossary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GlossaryCategory"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGlossaryCategoriesResponse, GlossaryCategory> ListGlossaryCategoriesAsync(ListGlossaryCategoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlossaryCategoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGlossaryCategoriesRequest, ListGlossaryCategoriesResponse, GlossaryCategory>(_callListGlossaryCategories, request, callSettings);
        }

        /// <summary>
        /// Creates a new GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GlossaryTerm CreateGlossaryTerm(CreateGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGlossaryTermRequest(ref request, ref callSettings);
            return _callCreateGlossaryTerm.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GlossaryTerm> CreateGlossaryTermAsync(CreateGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGlossaryTermRequest(ref request, ref callSettings);
            return _callCreateGlossaryTerm.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GlossaryTerm UpdateGlossaryTerm(UpdateGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGlossaryTermRequest(ref request, ref callSettings);
            return _callUpdateGlossaryTerm.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GlossaryTerm> UpdateGlossaryTermAsync(UpdateGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGlossaryTermRequest(ref request, ref callSettings);
            return _callUpdateGlossaryTerm.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteGlossaryTerm(DeleteGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlossaryTermRequest(ref request, ref callSettings);
            _callDeleteGlossaryTerm.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteGlossaryTermAsync(DeleteGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlossaryTermRequest(ref request, ref callSettings);
            return _callDeleteGlossaryTerm.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GlossaryTerm GetGlossaryTerm(GetGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlossaryTermRequest(ref request, ref callSettings);
            return _callGetGlossaryTerm.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a GlossaryTerm resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GlossaryTerm> GetGlossaryTermAsync(GetGlossaryTermRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlossaryTermRequest(ref request, ref callSettings);
            return _callGetGlossaryTerm.Async(request, callSettings);
        }

        /// <summary>
        /// Lists GlossaryTerm resources in a Glossary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GlossaryTerm"/> resources.</returns>
        public override gax::PagedEnumerable<ListGlossaryTermsResponse, GlossaryTerm> ListGlossaryTerms(ListGlossaryTermsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlossaryTermsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGlossaryTermsRequest, ListGlossaryTermsResponse, GlossaryTerm>(_callListGlossaryTerms, request, callSettings);
        }

        /// <summary>
        /// Lists GlossaryTerm resources in a Glossary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GlossaryTerm"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGlossaryTermsResponse, GlossaryTerm> ListGlossaryTermsAsync(ListGlossaryTermsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlossaryTermsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGlossaryTermsRequest, ListGlossaryTermsResponse, GlossaryTerm>(_callListGlossaryTerms, request, callSettings);
        }
    }

    public partial class ListGlossariesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGlossaryCategoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGlossaryTermsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGlossariesResponse : gaxgrpc::IPageResponse<Glossary>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Glossary> GetEnumerator() => Glossaries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGlossaryCategoriesResponse : gaxgrpc::IPageResponse<GlossaryCategory>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GlossaryCategory> GetEnumerator() => Categories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGlossaryTermsResponse : gaxgrpc::IPageResponse<GlossaryTerm>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GlossaryTerm> GetEnumerator() => Terms.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BusinessGlossaryService
    {
        public partial class BusinessGlossaryServiceClient
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

    public static partial class BusinessGlossaryService
    {
        public partial class BusinessGlossaryServiceClient
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

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
