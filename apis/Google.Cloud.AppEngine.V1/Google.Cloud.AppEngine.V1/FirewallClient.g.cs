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
    /// <summary>Settings for <see cref="FirewallClient"/> instances.</summary>
    public sealed partial class FirewallSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FirewallSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FirewallSettings"/>.</returns>
        public static FirewallSettings GetDefault() => new FirewallSettings();

        /// <summary>Constructs a new <see cref="FirewallSettings"/> object with default settings.</summary>
        public FirewallSettings()
        {
        }

        private FirewallSettings(FirewallSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListIngressRulesSettings = existing.ListIngressRulesSettings;
            BatchUpdateIngressRulesSettings = existing.BatchUpdateIngressRulesSettings;
            CreateIngressRuleSettings = existing.CreateIngressRuleSettings;
            GetIngressRuleSettings = existing.GetIngressRuleSettings;
            UpdateIngressRuleSettings = existing.UpdateIngressRuleSettings;
            DeleteIngressRuleSettings = existing.DeleteIngressRuleSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FirewallSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallClient.ListIngressRules</c> and <c>FirewallClient.ListIngressRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIngressRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallClient.BatchUpdateIngressRules</c> and <c>FirewallClient.BatchUpdateIngressRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateIngressRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallClient.CreateIngressRule</c> and <c>FirewallClient.CreateIngressRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateIngressRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallClient.GetIngressRule</c> and <c>FirewallClient.GetIngressRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIngressRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallClient.UpdateIngressRule</c> and <c>FirewallClient.UpdateIngressRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateIngressRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirewallClient.DeleteIngressRule</c> and <c>FirewallClient.DeleteIngressRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIngressRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FirewallSettings"/> object.</returns>
        public FirewallSettings Clone() => new FirewallSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FirewallClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class FirewallClientBuilder : gaxgrpc::ClientBuilderBase<FirewallClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FirewallSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FirewallClientBuilder() : base(FirewallClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FirewallClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FirewallClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FirewallClient Build()
        {
            FirewallClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FirewallClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FirewallClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FirewallClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FirewallClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FirewallClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FirewallClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FirewallClient.ChannelPool;
    }

    /// <summary>Firewall client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Firewall resources are used to define a collection of access control rules
    /// for an Application. Each rule is defined with a position which specifies
    /// the rule's order in the sequence of rules, an IP range to be matched against
    /// requests, and an action to take upon matching requests.
    /// 
    /// Every request is evaluated against the Firewall rules in priority order.
    /// Processesing stops at the first rule which matches the request's IP address.
    /// A final rule always specifies an action that applies to all remaining
    /// IP addresses. The default final rule for a newly-created application will be
    /// set to "allow" if not otherwise specified by the user.
    /// </remarks>
    public abstract partial class FirewallClient
    {
        /// <summary>
        /// The default endpoint for the Firewall service, which is a host of "appengine.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "appengine.googleapis.com:443";

        /// <summary>The default Firewall scopes.</summary>
        /// <remarks>
        /// The default Firewall scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Firewall.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FirewallClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="FirewallClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FirewallClient"/>.</returns>
        public static stt::Task<FirewallClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FirewallClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FirewallClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="FirewallClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FirewallClient"/>.</returns>
        public static FirewallClient Create() => new FirewallClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FirewallClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FirewallSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FirewallClient"/>.</returns>
        internal static FirewallClient Create(grpccore::CallInvoker callInvoker, FirewallSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Firewall.FirewallClient grpcClient = new Firewall.FirewallClient(callInvoker);
            return new FirewallClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Firewall client</summary>
        public virtual Firewall.FirewallClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the firewall rules of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirewallRule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIngressRulesResponse, FirewallRule> ListIngressRules(ListIngressRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the firewall rules of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallRule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIngressRulesResponse, FirewallRule> ListIngressRulesAsync(ListIngressRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces the entire firewall ruleset in one bulk operation. This overrides
        /// and replaces the rules of an existing firewall with the new rules.
        /// 
        /// If the final rule does not match traffic with the '*' wildcard IP range,
        /// then an "allow all" rule is explicitly added to the end of the list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateIngressRulesResponse BatchUpdateIngressRules(BatchUpdateIngressRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces the entire firewall ruleset in one bulk operation. This overrides
        /// and replaces the rules of an existing firewall with the new rules.
        /// 
        /// If the final rule does not match traffic with the '*' wildcard IP range,
        /// then an "allow all" rule is explicitly added to the end of the list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateIngressRulesResponse> BatchUpdateIngressRulesAsync(BatchUpdateIngressRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces the entire firewall ruleset in one bulk operation. This overrides
        /// and replaces the rules of an existing firewall with the new rules.
        /// 
        /// If the final rule does not match traffic with the '*' wildcard IP range,
        /// then an "allow all" rule is explicitly added to the end of the list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateIngressRulesResponse> BatchUpdateIngressRulesAsync(BatchUpdateIngressRulesRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateIngressRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a firewall rule for the application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallRule CreateIngressRule(CreateIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a firewall rule for the application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallRule> CreateIngressRuleAsync(CreateIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a firewall rule for the application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallRule> CreateIngressRuleAsync(CreateIngressRuleRequest request, st::CancellationToken cancellationToken) =>
            CreateIngressRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallRule GetIngressRule(GetIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallRule> GetIngressRuleAsync(GetIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallRule> GetIngressRuleAsync(GetIngressRuleRequest request, st::CancellationToken cancellationToken) =>
            GetIngressRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FirewallRule UpdateIngressRule(UpdateIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallRule> UpdateIngressRuleAsync(UpdateIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FirewallRule> UpdateIngressRuleAsync(UpdateIngressRuleRequest request, st::CancellationToken cancellationToken) =>
            UpdateIngressRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteIngressRule(DeleteIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIngressRuleAsync(DeleteIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIngressRuleAsync(DeleteIngressRuleRequest request, st::CancellationToken cancellationToken) =>
            DeleteIngressRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Firewall client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Firewall resources are used to define a collection of access control rules
    /// for an Application. Each rule is defined with a position which specifies
    /// the rule's order in the sequence of rules, an IP range to be matched against
    /// requests, and an action to take upon matching requests.
    /// 
    /// Every request is evaluated against the Firewall rules in priority order.
    /// Processesing stops at the first rule which matches the request's IP address.
    /// A final rule always specifies an action that applies to all remaining
    /// IP addresses. The default final rule for a newly-created application will be
    /// set to "allow" if not otherwise specified by the user.
    /// </remarks>
    public sealed partial class FirewallClientImpl : FirewallClient
    {
        private readonly gaxgrpc::ApiCall<ListIngressRulesRequest, ListIngressRulesResponse> _callListIngressRules;

        private readonly gaxgrpc::ApiCall<BatchUpdateIngressRulesRequest, BatchUpdateIngressRulesResponse> _callBatchUpdateIngressRules;

        private readonly gaxgrpc::ApiCall<CreateIngressRuleRequest, FirewallRule> _callCreateIngressRule;

        private readonly gaxgrpc::ApiCall<GetIngressRuleRequest, FirewallRule> _callGetIngressRule;

        private readonly gaxgrpc::ApiCall<UpdateIngressRuleRequest, FirewallRule> _callUpdateIngressRule;

        private readonly gaxgrpc::ApiCall<DeleteIngressRuleRequest, wkt::Empty> _callDeleteIngressRule;

        /// <summary>
        /// Constructs a client wrapper for the Firewall service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FirewallSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FirewallClientImpl(Firewall.FirewallClient grpcClient, FirewallSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FirewallSettings effectiveSettings = settings ?? FirewallSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListIngressRules = clientHelper.BuildApiCall<ListIngressRulesRequest, ListIngressRulesResponse>("ListIngressRules", grpcClient.ListIngressRulesAsync, grpcClient.ListIngressRules, effectiveSettings.ListIngressRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIngressRules);
            Modify_ListIngressRulesApiCall(ref _callListIngressRules);
            _callBatchUpdateIngressRules = clientHelper.BuildApiCall<BatchUpdateIngressRulesRequest, BatchUpdateIngressRulesResponse>("BatchUpdateIngressRules", grpcClient.BatchUpdateIngressRulesAsync, grpcClient.BatchUpdateIngressRules, effectiveSettings.BatchUpdateIngressRulesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callBatchUpdateIngressRules);
            Modify_BatchUpdateIngressRulesApiCall(ref _callBatchUpdateIngressRules);
            _callCreateIngressRule = clientHelper.BuildApiCall<CreateIngressRuleRequest, FirewallRule>("CreateIngressRule", grpcClient.CreateIngressRuleAsync, grpcClient.CreateIngressRule, effectiveSettings.CreateIngressRuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIngressRule);
            Modify_CreateIngressRuleApiCall(ref _callCreateIngressRule);
            _callGetIngressRule = clientHelper.BuildApiCall<GetIngressRuleRequest, FirewallRule>("GetIngressRule", grpcClient.GetIngressRuleAsync, grpcClient.GetIngressRule, effectiveSettings.GetIngressRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIngressRule);
            Modify_GetIngressRuleApiCall(ref _callGetIngressRule);
            _callUpdateIngressRule = clientHelper.BuildApiCall<UpdateIngressRuleRequest, FirewallRule>("UpdateIngressRule", grpcClient.UpdateIngressRuleAsync, grpcClient.UpdateIngressRule, effectiveSettings.UpdateIngressRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateIngressRule);
            Modify_UpdateIngressRuleApiCall(ref _callUpdateIngressRule);
            _callDeleteIngressRule = clientHelper.BuildApiCall<DeleteIngressRuleRequest, wkt::Empty>("DeleteIngressRule", grpcClient.DeleteIngressRuleAsync, grpcClient.DeleteIngressRule, effectiveSettings.DeleteIngressRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIngressRule);
            Modify_DeleteIngressRuleApiCall(ref _callDeleteIngressRule);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListIngressRulesApiCall(ref gaxgrpc::ApiCall<ListIngressRulesRequest, ListIngressRulesResponse> call);

        partial void Modify_BatchUpdateIngressRulesApiCall(ref gaxgrpc::ApiCall<BatchUpdateIngressRulesRequest, BatchUpdateIngressRulesResponse> call);

        partial void Modify_CreateIngressRuleApiCall(ref gaxgrpc::ApiCall<CreateIngressRuleRequest, FirewallRule> call);

        partial void Modify_GetIngressRuleApiCall(ref gaxgrpc::ApiCall<GetIngressRuleRequest, FirewallRule> call);

        partial void Modify_UpdateIngressRuleApiCall(ref gaxgrpc::ApiCall<UpdateIngressRuleRequest, FirewallRule> call);

        partial void Modify_DeleteIngressRuleApiCall(ref gaxgrpc::ApiCall<DeleteIngressRuleRequest, wkt::Empty> call);

        partial void OnConstruction(Firewall.FirewallClient grpcClient, FirewallSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Firewall client</summary>
        public override Firewall.FirewallClient GrpcClient { get; }

        partial void Modify_ListIngressRulesRequest(ref ListIngressRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateIngressRulesRequest(ref BatchUpdateIngressRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateIngressRuleRequest(ref CreateIngressRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIngressRuleRequest(ref GetIngressRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIngressRuleRequest(ref UpdateIngressRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIngressRuleRequest(ref DeleteIngressRuleRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the firewall rules of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FirewallRule"/> resources.</returns>
        public override gax::PagedEnumerable<ListIngressRulesResponse, FirewallRule> ListIngressRules(ListIngressRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIngressRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIngressRulesRequest, ListIngressRulesResponse, FirewallRule>(_callListIngressRules, request, callSettings);
        }

        /// <summary>
        /// Lists the firewall rules of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FirewallRule"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIngressRulesResponse, FirewallRule> ListIngressRulesAsync(ListIngressRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIngressRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIngressRulesRequest, ListIngressRulesResponse, FirewallRule>(_callListIngressRules, request, callSettings);
        }

        /// <summary>
        /// Replaces the entire firewall ruleset in one bulk operation. This overrides
        /// and replaces the rules of an existing firewall with the new rules.
        /// 
        /// If the final rule does not match traffic with the '*' wildcard IP range,
        /// then an "allow all" rule is explicitly added to the end of the list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateIngressRulesResponse BatchUpdateIngressRules(BatchUpdateIngressRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateIngressRulesRequest(ref request, ref callSettings);
            return _callBatchUpdateIngressRules.Sync(request, callSettings);
        }

        /// <summary>
        /// Replaces the entire firewall ruleset in one bulk operation. This overrides
        /// and replaces the rules of an existing firewall with the new rules.
        /// 
        /// If the final rule does not match traffic with the '*' wildcard IP range,
        /// then an "allow all" rule is explicitly added to the end of the list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateIngressRulesResponse> BatchUpdateIngressRulesAsync(BatchUpdateIngressRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateIngressRulesRequest(ref request, ref callSettings);
            return _callBatchUpdateIngressRules.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a firewall rule for the application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallRule CreateIngressRule(CreateIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIngressRuleRequest(ref request, ref callSettings);
            return _callCreateIngressRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a firewall rule for the application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallRule> CreateIngressRuleAsync(CreateIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIngressRuleRequest(ref request, ref callSettings);
            return _callCreateIngressRule.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallRule GetIngressRule(GetIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIngressRuleRequest(ref request, ref callSettings);
            return _callGetIngressRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallRule> GetIngressRuleAsync(GetIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIngressRuleRequest(ref request, ref callSettings);
            return _callGetIngressRule.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FirewallRule UpdateIngressRule(UpdateIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIngressRuleRequest(ref request, ref callSettings);
            return _callUpdateIngressRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FirewallRule> UpdateIngressRuleAsync(UpdateIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIngressRuleRequest(ref request, ref callSettings);
            return _callUpdateIngressRule.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteIngressRule(DeleteIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIngressRuleRequest(ref request, ref callSettings);
            _callDeleteIngressRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified firewall rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteIngressRuleAsync(DeleteIngressRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIngressRuleRequest(ref request, ref callSettings);
            return _callDeleteIngressRule.Async(request, callSettings);
        }
    }

    public partial class ListIngressRulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIngressRulesResponse : gaxgrpc::IPageResponse<FirewallRule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FirewallRule> GetEnumerator() => IngressRules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
