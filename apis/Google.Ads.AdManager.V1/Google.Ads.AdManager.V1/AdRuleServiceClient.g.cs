// Copyright 2026 Google LLC
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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="AdRuleServiceClient"/> instances.</summary>
    public sealed partial class AdRuleServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdRuleServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdRuleServiceSettings"/>.</returns>
        public static AdRuleServiceSettings GetDefault() => new AdRuleServiceSettings();

        /// <summary>Constructs a new <see cref="AdRuleServiceSettings"/> object with default settings.</summary>
        public AdRuleServiceSettings()
        {
        }

        private AdRuleServiceSettings(AdRuleServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdRuleSettings = existing.GetAdRuleSettings;
            ListAdRulesSettings = existing.ListAdRulesSettings;
            CreateAdRuleSettings = existing.CreateAdRuleSettings;
            BatchCreateAdRulesSettings = existing.BatchCreateAdRulesSettings;
            UpdateAdRuleSettings = existing.UpdateAdRuleSettings;
            BatchUpdateAdRulesSettings = existing.BatchUpdateAdRulesSettings;
            BatchActivateAdRulesSettings = existing.BatchActivateAdRulesSettings;
            BatchDeactivateAdRulesSettings = existing.BatchDeactivateAdRulesSettings;
            BatchDeleteAdRulesSettings = existing.BatchDeleteAdRulesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdRuleServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdRuleServiceClient.GetAdRule</c> and <c>AdRuleServiceClient.GetAdRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdRuleServiceClient.ListAdRules</c> and <c>AdRuleServiceClient.ListAdRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAdRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdRuleServiceClient.CreateAdRule</c> and <c>AdRuleServiceClient.CreateAdRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAdRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdRuleServiceClient.BatchCreateAdRules</c> and <c>AdRuleServiceClient.BatchCreateAdRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateAdRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdRuleServiceClient.UpdateAdRule</c> and <c>AdRuleServiceClient.UpdateAdRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAdRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdRuleServiceClient.BatchUpdateAdRules</c> and <c>AdRuleServiceClient.BatchUpdateAdRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateAdRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdRuleServiceClient.BatchActivateAdRules</c> and <c>AdRuleServiceClient.BatchActivateAdRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateAdRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdRuleServiceClient.BatchDeactivateAdRules</c> and <c>AdRuleServiceClient.BatchDeactivateAdRulesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateAdRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdRuleServiceClient.BatchDeleteAdRules</c> and <c>AdRuleServiceClient.BatchDeleteAdRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteAdRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdRuleServiceSettings"/> object.</returns>
        public AdRuleServiceSettings Clone() => new AdRuleServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdRuleServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AdRuleServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdRuleServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdRuleServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdRuleServiceClientBuilder() : base(AdRuleServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdRuleServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdRuleServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdRuleServiceClient Build()
        {
            AdRuleServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdRuleServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdRuleServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdRuleServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdRuleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdRuleServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdRuleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdRuleServiceClient.ChannelPool;
    }

    /// <summary>AdRuleService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `AdRule` objects.
    /// </remarks>
    public abstract partial class AdRuleServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdRuleService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default AdRuleService scopes.</summary>
        /// <remarks>
        /// The default AdRuleService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdRuleService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdRuleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdRuleServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdRuleServiceClient"/>.</returns>
        public static stt::Task<AdRuleServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdRuleServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdRuleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdRuleServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdRuleServiceClient"/>.</returns>
        public static AdRuleServiceClient Create() => new AdRuleServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdRuleServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdRuleServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdRuleServiceClient"/>.</returns>
        internal static AdRuleServiceClient Create(grpccore::CallInvoker callInvoker, AdRuleServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdRuleService.AdRuleServiceClient grpcClient = new AdRuleService.AdRuleServiceClient(callInvoker);
            return new AdRuleServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdRuleService client</summary>
        public virtual AdRuleService.AdRuleServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdRule GetAdRule(GetAdRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> GetAdRuleAsync(GetAdRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> GetAdRuleAsync(GetAdRuleRequest request, st::CancellationToken cancellationToken) =>
            GetAdRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an `AdRule` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdRule.
        /// Format: `networks/{network_code}/adRules/{ad_rule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdRule GetAdRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdRule(new GetAdRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `AdRule` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdRule.
        /// Format: `networks/{network_code}/adRules/{ad_rule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> GetAdRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdRuleAsync(new GetAdRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `AdRule` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdRule.
        /// Format: `networks/{network_code}/adRules/{ad_rule_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> GetAdRuleAsync(string name, st::CancellationToken cancellationToken) =>
            GetAdRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an `AdRule` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdRule.
        /// Format: `networks/{network_code}/adRules/{ad_rule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdRule GetAdRule(AdRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdRule(new GetAdRuleRequest
            {
                AdRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `AdRule` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdRule.
        /// Format: `networks/{network_code}/adRules/{ad_rule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> GetAdRuleAsync(AdRuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAdRuleAsync(new GetAdRuleRequest
            {
                AdRuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an `AdRule` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AdRule.
        /// Format: `networks/{network_code}/adRules/{ad_rule_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> GetAdRuleAsync(AdRuleName name, st::CancellationToken cancellationToken) =>
            GetAdRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdRulesResponse, AdRule> ListAdRules(ListAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdRulesResponse, AdRule> ListAdRulesAsync(ListAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdRules.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="AdRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdRulesResponse, AdRule> ListAdRules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdRulesRequest request = new ListAdRulesRequest
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
            return ListAdRules(request, callSettings);
        }

        /// <summary>
        /// Lists `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdRules.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdRulesResponse, AdRule> ListAdRulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdRulesRequest request = new ListAdRulesRequest
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
            return ListAdRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdRules.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="AdRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdRulesResponse, AdRule> ListAdRules(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdRulesRequest request = new ListAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAdRules(request, callSettings);
        }

        /// <summary>
        /// Lists `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of AdRules.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AdRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdRulesResponse, AdRule> ListAdRulesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAdRulesRequest request = new ListAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAdRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdRule CreateAdRule(CreateAdRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> CreateAdRuleAsync(CreateAdRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> CreateAdRuleAsync(CreateAdRuleRequest request, st::CancellationToken cancellationToken) =>
            CreateAdRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `AdRule` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdRule` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adRule">
        /// Required. The `AdRule` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdRule CreateAdRule(string parent, AdRule adRule, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdRule(new CreateAdRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AdRule = gax::GaxPreconditions.CheckNotNull(adRule, nameof(adRule)),
            }, callSettings);

        /// <summary>
        /// Creates a `AdRule` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdRule` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adRule">
        /// Required. The `AdRule` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> CreateAdRuleAsync(string parent, AdRule adRule, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdRuleAsync(new CreateAdRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AdRule = gax::GaxPreconditions.CheckNotNull(adRule, nameof(adRule)),
            }, callSettings);

        /// <summary>
        /// Creates a `AdRule` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdRule` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adRule">
        /// Required. The `AdRule` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> CreateAdRuleAsync(string parent, AdRule adRule, st::CancellationToken cancellationToken) =>
            CreateAdRuleAsync(parent, adRule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `AdRule` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdRule` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adRule">
        /// Required. The `AdRule` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdRule CreateAdRule(NetworkName parent, AdRule adRule, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdRule(new CreateAdRuleRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdRule = gax::GaxPreconditions.CheckNotNull(adRule, nameof(adRule)),
            }, callSettings);

        /// <summary>
        /// Creates a `AdRule` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdRule` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adRule">
        /// Required. The `AdRule` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> CreateAdRuleAsync(NetworkName parent, AdRule adRule, gaxgrpc::CallSettings callSettings = null) =>
            CreateAdRuleAsync(new CreateAdRuleRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdRule = gax::GaxPreconditions.CheckNotNull(adRule, nameof(adRule)),
            }, callSettings);

        /// <summary>
        /// Creates a `AdRule` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `AdRule` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="adRule">
        /// Required. The `AdRule` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> CreateAdRuleAsync(NetworkName parent, AdRule adRule, st::CancellationToken cancellationToken) =>
            CreateAdRuleAsync(parent, adRule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateAdRulesResponse BatchCreateAdRules(BatchCreateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdRulesResponse> BatchCreateAdRulesAsync(BatchCreateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdRulesResponse> BatchCreateAdRulesAsync(BatchCreateAdRulesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateAdRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateAdRulesResponse BatchCreateAdRules(string parent, scg::IEnumerable<CreateAdRuleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateAdRules(new BatchCreateAdRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdRulesResponse> BatchCreateAdRulesAsync(string parent, scg::IEnumerable<CreateAdRuleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateAdRulesAsync(new BatchCreateAdRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdRulesResponse> BatchCreateAdRulesAsync(string parent, scg::IEnumerable<CreateAdRuleRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateAdRulesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateAdRulesResponse BatchCreateAdRules(NetworkName parent, scg::IEnumerable<CreateAdRuleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateAdRules(new BatchCreateAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdRulesResponse> BatchCreateAdRulesAsync(NetworkName parent, scg::IEnumerable<CreateAdRuleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateAdRulesAsync(new BatchCreateAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateAdRulesResponse> BatchCreateAdRulesAsync(NetworkName parent, scg::IEnumerable<CreateAdRuleRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateAdRulesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdRule UpdateAdRule(UpdateAdRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> UpdateAdRuleAsync(UpdateAdRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> UpdateAdRuleAsync(UpdateAdRuleRequest request, st::CancellationToken cancellationToken) =>
            UpdateAdRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `AdRule` object.
        /// </summary>
        /// <param name="adRule">
        /// Required. The `AdRule` to update.
        /// 
        /// The `AdRule`'s `name` is used to identify the `AdRule` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdRule UpdateAdRule(AdRule adRule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAdRule(new UpdateAdRuleRequest
            {
                AdRule = gax::GaxPreconditions.CheckNotNull(adRule, nameof(adRule)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `AdRule` object.
        /// </summary>
        /// <param name="adRule">
        /// Required. The `AdRule` to update.
        /// 
        /// The `AdRule`'s `name` is used to identify the `AdRule` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> UpdateAdRuleAsync(AdRule adRule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAdRuleAsync(new UpdateAdRuleRequest
            {
                AdRule = gax::GaxPreconditions.CheckNotNull(adRule, nameof(adRule)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `AdRule` object.
        /// </summary>
        /// <param name="adRule">
        /// Required. The `AdRule` to update.
        /// 
        /// The `AdRule`'s `name` is used to identify the `AdRule` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdRule> UpdateAdRuleAsync(AdRule adRule, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAdRuleAsync(adRule, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateAdRulesResponse BatchUpdateAdRules(BatchUpdateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdRulesResponse> BatchUpdateAdRulesAsync(BatchUpdateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdRulesResponse> BatchUpdateAdRulesAsync(BatchUpdateAdRulesRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateAdRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateAdRulesResponse BatchUpdateAdRules(string parent, scg::IEnumerable<UpdateAdRuleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAdRules(new BatchUpdateAdRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdRulesResponse> BatchUpdateAdRulesAsync(string parent, scg::IEnumerable<UpdateAdRuleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAdRulesAsync(new BatchUpdateAdRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdRulesResponse> BatchUpdateAdRulesAsync(string parent, scg::IEnumerable<UpdateAdRuleRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateAdRulesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateAdRulesResponse BatchUpdateAdRules(NetworkName parent, scg::IEnumerable<UpdateAdRuleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAdRules(new BatchUpdateAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdRulesResponse> BatchUpdateAdRulesAsync(NetworkName parent, scg::IEnumerable<UpdateAdRuleRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAdRulesAsync(new BatchUpdateAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `AdRules` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateAdRuleRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `AdRule` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAdRulesResponse> BatchUpdateAdRulesAsync(NetworkName parent, scg::IEnumerable<UpdateAdRuleRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateAdRulesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateAdRulesResponse BatchActivateAdRules(BatchActivateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateAdRulesResponse> BatchActivateAdRulesAsync(BatchActivateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateAdRulesResponse> BatchActivateAdRulesAsync(BatchActivateAdRulesRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateAdRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateAdRulesResponse BatchActivateAdRules(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateAdRules(new BatchActivateAdRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateAdRulesResponse> BatchActivateAdRulesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateAdRulesAsync(new BatchActivateAdRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateAdRulesResponse> BatchActivateAdRulesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateAdRulesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateAdRulesResponse BatchActivateAdRules(NetworkName parent, scg::IEnumerable<AdRuleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateAdRules(new BatchActivateAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdRuleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateAdRulesResponse> BatchActivateAdRulesAsync(NetworkName parent, scg::IEnumerable<AdRuleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateAdRulesAsync(new BatchActivateAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdRuleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateAdRulesResponse> BatchActivateAdRulesAsync(NetworkName parent, scg::IEnumerable<AdRuleName> names, st::CancellationToken cancellationToken) =>
            BatchActivateAdRulesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateAdRulesResponse BatchDeactivateAdRules(BatchDeactivateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateAdRulesResponse> BatchDeactivateAdRulesAsync(BatchDeactivateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateAdRulesResponse> BatchDeactivateAdRulesAsync(BatchDeactivateAdRulesRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateAdRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateAdRulesResponse BatchDeactivateAdRules(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateAdRules(new BatchDeactivateAdRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateAdRulesResponse> BatchDeactivateAdRulesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateAdRulesAsync(new BatchDeactivateAdRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateAdRulesResponse> BatchDeactivateAdRulesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateAdRulesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateAdRulesResponse BatchDeactivateAdRules(NetworkName parent, scg::IEnumerable<AdRuleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateAdRules(new BatchDeactivateAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdRuleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateAdRulesResponse> BatchDeactivateAdRulesAsync(NetworkName parent, scg::IEnumerable<AdRuleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateAdRulesAsync(new BatchDeactivateAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdRuleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateAdRulesResponse> BatchDeactivateAdRulesAsync(NetworkName parent, scg::IEnumerable<AdRuleName> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateAdRulesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteAdRules(BatchDeleteAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAdRulesAsync(BatchDeleteAdRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAdRulesAsync(BatchDeleteAdRulesRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteAdRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteAdRules(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteAdRules(new BatchDeleteAdRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAdRulesAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteAdRulesAsync(new BatchDeleteAdRulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAdRulesAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeleteAdRulesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteAdRules(NetworkName parent, scg::IEnumerable<AdRuleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteAdRules(new BatchDeleteAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdRuleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAdRulesAsync(NetworkName parent, scg::IEnumerable<AdRuleName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteAdRulesAsync(new BatchDeleteAdRulesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AdRuleNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of `AdRule` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the AdRule.
        /// Format:
        /// `networks/{network_code}/adRules/{ad_rule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAdRulesAsync(NetworkName parent, scg::IEnumerable<AdRuleName> names, st::CancellationToken cancellationToken) =>
            BatchDeleteAdRulesAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdRuleService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `AdRule` objects.
    /// </remarks>
    public sealed partial class AdRuleServiceClientImpl : AdRuleServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdRuleRequest, AdRule> _callGetAdRule;

        private readonly gaxgrpc::ApiCall<ListAdRulesRequest, ListAdRulesResponse> _callListAdRules;

        private readonly gaxgrpc::ApiCall<CreateAdRuleRequest, AdRule> _callCreateAdRule;

        private readonly gaxgrpc::ApiCall<BatchCreateAdRulesRequest, BatchCreateAdRulesResponse> _callBatchCreateAdRules;

        private readonly gaxgrpc::ApiCall<UpdateAdRuleRequest, AdRule> _callUpdateAdRule;

        private readonly gaxgrpc::ApiCall<BatchUpdateAdRulesRequest, BatchUpdateAdRulesResponse> _callBatchUpdateAdRules;

        private readonly gaxgrpc::ApiCall<BatchActivateAdRulesRequest, BatchActivateAdRulesResponse> _callBatchActivateAdRules;

        private readonly gaxgrpc::ApiCall<BatchDeactivateAdRulesRequest, BatchDeactivateAdRulesResponse> _callBatchDeactivateAdRules;

        private readonly gaxgrpc::ApiCall<BatchDeleteAdRulesRequest, wkt::Empty> _callBatchDeleteAdRules;

        /// <summary>
        /// Constructs a client wrapper for the AdRuleService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdRuleServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdRuleServiceClientImpl(AdRuleService.AdRuleServiceClient grpcClient, AdRuleServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdRuleServiceSettings effectiveSettings = settings ?? AdRuleServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAdRule = clientHelper.BuildApiCall<GetAdRuleRequest, AdRule>("GetAdRule", grpcClient.GetAdRuleAsync, grpcClient.GetAdRule, effectiveSettings.GetAdRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAdRule);
            Modify_GetAdRuleApiCall(ref _callGetAdRule);
            _callListAdRules = clientHelper.BuildApiCall<ListAdRulesRequest, ListAdRulesResponse>("ListAdRules", grpcClient.ListAdRulesAsync, grpcClient.ListAdRules, effectiveSettings.ListAdRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAdRules);
            Modify_ListAdRulesApiCall(ref _callListAdRules);
            _callCreateAdRule = clientHelper.BuildApiCall<CreateAdRuleRequest, AdRule>("CreateAdRule", grpcClient.CreateAdRuleAsync, grpcClient.CreateAdRule, effectiveSettings.CreateAdRuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAdRule);
            Modify_CreateAdRuleApiCall(ref _callCreateAdRule);
            _callBatchCreateAdRules = clientHelper.BuildApiCall<BatchCreateAdRulesRequest, BatchCreateAdRulesResponse>("BatchCreateAdRules", grpcClient.BatchCreateAdRulesAsync, grpcClient.BatchCreateAdRules, effectiveSettings.BatchCreateAdRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateAdRules);
            Modify_BatchCreateAdRulesApiCall(ref _callBatchCreateAdRules);
            _callUpdateAdRule = clientHelper.BuildApiCall<UpdateAdRuleRequest, AdRule>("UpdateAdRule", grpcClient.UpdateAdRuleAsync, grpcClient.UpdateAdRule, effectiveSettings.UpdateAdRuleSettings).WithGoogleRequestParam("ad_rule.name", request => request.AdRule?.Name);
            Modify_ApiCall(ref _callUpdateAdRule);
            Modify_UpdateAdRuleApiCall(ref _callUpdateAdRule);
            _callBatchUpdateAdRules = clientHelper.BuildApiCall<BatchUpdateAdRulesRequest, BatchUpdateAdRulesResponse>("BatchUpdateAdRules", grpcClient.BatchUpdateAdRulesAsync, grpcClient.BatchUpdateAdRules, effectiveSettings.BatchUpdateAdRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateAdRules);
            Modify_BatchUpdateAdRulesApiCall(ref _callBatchUpdateAdRules);
            _callBatchActivateAdRules = clientHelper.BuildApiCall<BatchActivateAdRulesRequest, BatchActivateAdRulesResponse>("BatchActivateAdRules", grpcClient.BatchActivateAdRulesAsync, grpcClient.BatchActivateAdRules, effectiveSettings.BatchActivateAdRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateAdRules);
            Modify_BatchActivateAdRulesApiCall(ref _callBatchActivateAdRules);
            _callBatchDeactivateAdRules = clientHelper.BuildApiCall<BatchDeactivateAdRulesRequest, BatchDeactivateAdRulesResponse>("BatchDeactivateAdRules", grpcClient.BatchDeactivateAdRulesAsync, grpcClient.BatchDeactivateAdRules, effectiveSettings.BatchDeactivateAdRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateAdRules);
            Modify_BatchDeactivateAdRulesApiCall(ref _callBatchDeactivateAdRules);
            _callBatchDeleteAdRules = clientHelper.BuildApiCall<BatchDeleteAdRulesRequest, wkt::Empty>("BatchDeleteAdRules", grpcClient.BatchDeleteAdRulesAsync, grpcClient.BatchDeleteAdRules, effectiveSettings.BatchDeleteAdRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteAdRules);
            Modify_BatchDeleteAdRulesApiCall(ref _callBatchDeleteAdRules);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdRuleApiCall(ref gaxgrpc::ApiCall<GetAdRuleRequest, AdRule> call);

        partial void Modify_ListAdRulesApiCall(ref gaxgrpc::ApiCall<ListAdRulesRequest, ListAdRulesResponse> call);

        partial void Modify_CreateAdRuleApiCall(ref gaxgrpc::ApiCall<CreateAdRuleRequest, AdRule> call);

        partial void Modify_BatchCreateAdRulesApiCall(ref gaxgrpc::ApiCall<BatchCreateAdRulesRequest, BatchCreateAdRulesResponse> call);

        partial void Modify_UpdateAdRuleApiCall(ref gaxgrpc::ApiCall<UpdateAdRuleRequest, AdRule> call);

        partial void Modify_BatchUpdateAdRulesApiCall(ref gaxgrpc::ApiCall<BatchUpdateAdRulesRequest, BatchUpdateAdRulesResponse> call);

        partial void Modify_BatchActivateAdRulesApiCall(ref gaxgrpc::ApiCall<BatchActivateAdRulesRequest, BatchActivateAdRulesResponse> call);

        partial void Modify_BatchDeactivateAdRulesApiCall(ref gaxgrpc::ApiCall<BatchDeactivateAdRulesRequest, BatchDeactivateAdRulesResponse> call);

        partial void Modify_BatchDeleteAdRulesApiCall(ref gaxgrpc::ApiCall<BatchDeleteAdRulesRequest, wkt::Empty> call);

        partial void OnConstruction(AdRuleService.AdRuleServiceClient grpcClient, AdRuleServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdRuleService client</summary>
        public override AdRuleService.AdRuleServiceClient GrpcClient { get; }

        partial void Modify_GetAdRuleRequest(ref GetAdRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAdRulesRequest(ref ListAdRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAdRuleRequest(ref CreateAdRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateAdRulesRequest(ref BatchCreateAdRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAdRuleRequest(ref UpdateAdRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateAdRulesRequest(ref BatchUpdateAdRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateAdRulesRequest(ref BatchActivateAdRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateAdRulesRequest(ref BatchDeactivateAdRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteAdRulesRequest(ref BatchDeleteAdRulesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves an `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdRule GetAdRule(GetAdRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdRuleRequest(ref request, ref callSettings);
            return _callGetAdRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdRule> GetAdRuleAsync(GetAdRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdRuleRequest(ref request, ref callSettings);
            return _callGetAdRule.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AdRule"/> resources.</returns>
        public override gax::PagedEnumerable<ListAdRulesResponse, AdRule> ListAdRules(ListAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAdRulesRequest, ListAdRulesResponse, AdRule>(_callListAdRules, request, callSettings);
        }

        /// <summary>
        /// Lists `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AdRule"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAdRulesResponse, AdRule> ListAdRulesAsync(ListAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAdRulesRequest, ListAdRulesResponse, AdRule>(_callListAdRules, request, callSettings);
        }

        /// <summary>
        /// Creates a `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdRule CreateAdRule(CreateAdRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAdRuleRequest(ref request, ref callSettings);
            return _callCreateAdRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdRule> CreateAdRuleAsync(CreateAdRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAdRuleRequest(ref request, ref callSettings);
            return _callCreateAdRule.Async(request, callSettings);
        }

        /// <summary>
        /// Batch creates `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateAdRulesResponse BatchCreateAdRules(BatchCreateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateAdRulesRequest(ref request, ref callSettings);
            return _callBatchCreateAdRules.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch creates `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateAdRulesResponse> BatchCreateAdRulesAsync(BatchCreateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateAdRulesRequest(ref request, ref callSettings);
            return _callBatchCreateAdRules.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdRule UpdateAdRule(UpdateAdRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAdRuleRequest(ref request, ref callSettings);
            return _callUpdateAdRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `AdRule` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdRule> UpdateAdRuleAsync(UpdateAdRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAdRuleRequest(ref request, ref callSettings);
            return _callUpdateAdRule.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateAdRulesResponse BatchUpdateAdRules(BatchUpdateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateAdRulesRequest(ref request, ref callSettings);
            return _callBatchUpdateAdRules.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateAdRulesResponse> BatchUpdateAdRulesAsync(BatchUpdateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateAdRulesRequest(ref request, ref callSettings);
            return _callBatchUpdateAdRules.Async(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateAdRulesResponse BatchActivateAdRules(BatchActivateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateAdRulesRequest(ref request, ref callSettings);
            return _callBatchActivateAdRules.Sync(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateAdRulesResponse> BatchActivateAdRulesAsync(BatchActivateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateAdRulesRequest(ref request, ref callSettings);
            return _callBatchActivateAdRules.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateAdRulesResponse BatchDeactivateAdRules(BatchDeactivateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateAdRulesRequest(ref request, ref callSettings);
            return _callBatchDeactivateAdRules.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateAdRulesResponse> BatchDeactivateAdRulesAsync(BatchDeactivateAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateAdRulesRequest(ref request, ref callSettings);
            return _callBatchDeactivateAdRules.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchDeleteAdRules(BatchDeleteAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteAdRulesRequest(ref request, ref callSettings);
            _callBatchDeleteAdRules.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a list of `AdRule` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchDeleteAdRulesAsync(BatchDeleteAdRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteAdRulesRequest(ref request, ref callSettings);
            return _callBatchDeleteAdRules.Async(request, callSettings);
        }
    }

    public partial class ListAdRulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAdRulesResponse : gaxgrpc::IPageResponse<AdRule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AdRule> GetEnumerator() => AdRules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
