// Copyright 2024 Google LLC
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

namespace Google.Cloud.DataCatalog.V1
{
    /// <summary>Settings for <see cref="PolicyTagManagerClient"/> instances.</summary>
    public sealed partial class PolicyTagManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PolicyTagManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PolicyTagManagerSettings"/>.</returns>
        public static PolicyTagManagerSettings GetDefault() => new PolicyTagManagerSettings();

        /// <summary>Constructs a new <see cref="PolicyTagManagerSettings"/> object with default settings.</summary>
        public PolicyTagManagerSettings()
        {
        }

        private PolicyTagManagerSettings(PolicyTagManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTaxonomySettings = existing.CreateTaxonomySettings;
            DeleteTaxonomySettings = existing.DeleteTaxonomySettings;
            UpdateTaxonomySettings = existing.UpdateTaxonomySettings;
            ListTaxonomiesSettings = existing.ListTaxonomiesSettings;
            GetTaxonomySettings = existing.GetTaxonomySettings;
            CreatePolicyTagSettings = existing.CreatePolicyTagSettings;
            DeletePolicyTagSettings = existing.DeletePolicyTagSettings;
            UpdatePolicyTagSettings = existing.UpdatePolicyTagSettings;
            ListPolicyTagsSettings = existing.ListPolicyTagsSettings;
            GetPolicyTagSettings = existing.GetPolicyTagSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(PolicyTagManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.CreateTaxonomy</c> and <c>PolicyTagManagerClient.CreateTaxonomyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTaxonomySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.DeleteTaxonomy</c> and <c>PolicyTagManagerClient.DeleteTaxonomyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTaxonomySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.UpdateTaxonomy</c> and <c>PolicyTagManagerClient.UpdateTaxonomyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTaxonomySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.ListTaxonomies</c> and <c>PolicyTagManagerClient.ListTaxonomiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTaxonomiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.GetTaxonomy</c> and <c>PolicyTagManagerClient.GetTaxonomyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTaxonomySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.CreatePolicyTag</c> and <c>PolicyTagManagerClient.CreatePolicyTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePolicyTagSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.DeletePolicyTag</c> and <c>PolicyTagManagerClient.DeletePolicyTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePolicyTagSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.UpdatePolicyTag</c> and <c>PolicyTagManagerClient.UpdatePolicyTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePolicyTagSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.ListPolicyTags</c> and <c>PolicyTagManagerClient.ListPolicyTagsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPolicyTagsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.GetPolicyTag</c> and <c>PolicyTagManagerClient.GetPolicyTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPolicyTagSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.GetIamPolicy</c> and <c>PolicyTagManagerClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.SetIamPolicy</c> and <c>PolicyTagManagerClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyTagManagerClient.TestIamPermissions</c> and <c>PolicyTagManagerClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PolicyTagManagerSettings"/> object.</returns>
        public PolicyTagManagerSettings Clone() => new PolicyTagManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PolicyTagManagerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PolicyTagManagerClientBuilder : gaxgrpc::ClientBuilderBase<PolicyTagManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PolicyTagManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PolicyTagManagerClientBuilder() : base(PolicyTagManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PolicyTagManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PolicyTagManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PolicyTagManagerClient Build()
        {
            PolicyTagManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PolicyTagManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PolicyTagManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PolicyTagManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PolicyTagManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PolicyTagManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PolicyTagManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PolicyTagManagerClient.ChannelPool;
    }

    /// <summary>PolicyTagManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Policy Tag Manager API service allows you to manage your policy tags and
    /// taxonomies.
    /// 
    /// Policy tags are used to tag BigQuery columns and apply additional access
    /// control policies. A taxonomy is a hierarchical grouping of policy tags that
    /// classify data along a common axis.
    /// </remarks>
    public abstract partial class PolicyTagManagerClient
    {
        /// <summary>
        /// The default endpoint for the PolicyTagManager service, which is a host of "datacatalog.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datacatalog.googleapis.com:443";

        /// <summary>The default PolicyTagManager scopes.</summary>
        /// <remarks>
        /// The default PolicyTagManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PolicyTagManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PolicyTagManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PolicyTagManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PolicyTagManagerClient"/>.</returns>
        public static stt::Task<PolicyTagManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PolicyTagManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PolicyTagManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PolicyTagManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PolicyTagManagerClient"/>.</returns>
        public static PolicyTagManagerClient Create() => new PolicyTagManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PolicyTagManagerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PolicyTagManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PolicyTagManagerClient"/>.</returns>
        internal static PolicyTagManagerClient Create(grpccore::CallInvoker callInvoker, PolicyTagManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PolicyTagManager.PolicyTagManagerClient grpcClient = new PolicyTagManager.PolicyTagManagerClient(callInvoker);
            return new PolicyTagManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PolicyTagManager client</summary>
        public virtual PolicyTagManager.PolicyTagManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a taxonomy in a specified project.
        /// 
        /// The taxonomy is initially empty, that is, it doesn't contain policy tags.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Taxonomy CreateTaxonomy(CreateTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a taxonomy in a specified project.
        /// 
        /// The taxonomy is initially empty, that is, it doesn't contain policy tags.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> CreateTaxonomyAsync(CreateTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a taxonomy in a specified project.
        /// 
        /// The taxonomy is initially empty, that is, it doesn't contain policy tags.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> CreateTaxonomyAsync(CreateTaxonomyRequest request, st::CancellationToken cancellationToken) =>
            CreateTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a taxonomy in a specified project.
        /// 
        /// The taxonomy is initially empty, that is, it doesn't contain policy tags.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the taxonomy will belong to.
        /// </param>
        /// <param name="taxonomy">
        /// The taxonomy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Taxonomy CreateTaxonomy(string parent, Taxonomy taxonomy, gaxgrpc::CallSettings callSettings = null) =>
            CreateTaxonomy(new CreateTaxonomyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Taxonomy = taxonomy,
            }, callSettings);

        /// <summary>
        /// Creates a taxonomy in a specified project.
        /// 
        /// The taxonomy is initially empty, that is, it doesn't contain policy tags.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the taxonomy will belong to.
        /// </param>
        /// <param name="taxonomy">
        /// The taxonomy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> CreateTaxonomyAsync(string parent, Taxonomy taxonomy, gaxgrpc::CallSettings callSettings = null) =>
            CreateTaxonomyAsync(new CreateTaxonomyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Taxonomy = taxonomy,
            }, callSettings);

        /// <summary>
        /// Creates a taxonomy in a specified project.
        /// 
        /// The taxonomy is initially empty, that is, it doesn't contain policy tags.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the taxonomy will belong to.
        /// </param>
        /// <param name="taxonomy">
        /// The taxonomy to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> CreateTaxonomyAsync(string parent, Taxonomy taxonomy, st::CancellationToken cancellationToken) =>
            CreateTaxonomyAsync(parent, taxonomy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a taxonomy in a specified project.
        /// 
        /// The taxonomy is initially empty, that is, it doesn't contain policy tags.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the taxonomy will belong to.
        /// </param>
        /// <param name="taxonomy">
        /// The taxonomy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Taxonomy CreateTaxonomy(gagr::LocationName parent, Taxonomy taxonomy, gaxgrpc::CallSettings callSettings = null) =>
            CreateTaxonomy(new CreateTaxonomyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Taxonomy = taxonomy,
            }, callSettings);

        /// <summary>
        /// Creates a taxonomy in a specified project.
        /// 
        /// The taxonomy is initially empty, that is, it doesn't contain policy tags.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the taxonomy will belong to.
        /// </param>
        /// <param name="taxonomy">
        /// The taxonomy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> CreateTaxonomyAsync(gagr::LocationName parent, Taxonomy taxonomy, gaxgrpc::CallSettings callSettings = null) =>
            CreateTaxonomyAsync(new CreateTaxonomyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Taxonomy = taxonomy,
            }, callSettings);

        /// <summary>
        /// Creates a taxonomy in a specified project.
        /// 
        /// The taxonomy is initially empty, that is, it doesn't contain policy tags.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the taxonomy will belong to.
        /// </param>
        /// <param name="taxonomy">
        /// The taxonomy to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> CreateTaxonomyAsync(gagr::LocationName parent, Taxonomy taxonomy, st::CancellationToken cancellationToken) =>
            CreateTaxonomyAsync(parent, taxonomy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a taxonomy, including all policy tags in this
        /// taxonomy, their associated policies, and the policy tags references from
        /// BigQuery columns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTaxonomy(DeleteTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a taxonomy, including all policy tags in this
        /// taxonomy, their associated policies, and the policy tags references from
        /// BigQuery columns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaxonomyAsync(DeleteTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a taxonomy, including all policy tags in this
        /// taxonomy, their associated policies, and the policy tags references from
        /// BigQuery columns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaxonomyAsync(DeleteTaxonomyRequest request, st::CancellationToken cancellationToken) =>
            DeleteTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a taxonomy, including all policy tags in this
        /// taxonomy, their associated policies, and the policy tags references from
        /// BigQuery columns.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to delete.
        /// 
        /// Note: All policy tags in this taxonomy are also deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTaxonomy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTaxonomy(new DeleteTaxonomyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a taxonomy, including all policy tags in this
        /// taxonomy, their associated policies, and the policy tags references from
        /// BigQuery columns.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to delete.
        /// 
        /// Note: All policy tags in this taxonomy are also deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaxonomyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTaxonomyAsync(new DeleteTaxonomyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a taxonomy, including all policy tags in this
        /// taxonomy, their associated policies, and the policy tags references from
        /// BigQuery columns.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to delete.
        /// 
        /// Note: All policy tags in this taxonomy are also deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaxonomyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTaxonomyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a taxonomy, including all policy tags in this
        /// taxonomy, their associated policies, and the policy tags references from
        /// BigQuery columns.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to delete.
        /// 
        /// Note: All policy tags in this taxonomy are also deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTaxonomy(TaxonomyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTaxonomy(new DeleteTaxonomyRequest
            {
                TaxonomyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a taxonomy, including all policy tags in this
        /// taxonomy, their associated policies, and the policy tags references from
        /// BigQuery columns.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to delete.
        /// 
        /// Note: All policy tags in this taxonomy are also deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaxonomyAsync(TaxonomyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTaxonomyAsync(new DeleteTaxonomyRequest
            {
                TaxonomyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a taxonomy, including all policy tags in this
        /// taxonomy, their associated policies, and the policy tags references from
        /// BigQuery columns.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to delete.
        /// 
        /// Note: All policy tags in this taxonomy are also deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTaxonomyAsync(TaxonomyName name, st::CancellationToken cancellationToken) =>
            DeleteTaxonomyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a taxonomy, including its display name,
        /// description, and activated policy types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Taxonomy UpdateTaxonomy(UpdateTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a taxonomy, including its display name,
        /// description, and activated policy types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> UpdateTaxonomyAsync(UpdateTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a taxonomy, including its display name,
        /// description, and activated policy types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> UpdateTaxonomyAsync(UpdateTaxonomyRequest request, st::CancellationToken cancellationToken) =>
            UpdateTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a taxonomy, including its display name,
        /// description, and activated policy types.
        /// </summary>
        /// <param name="taxonomy">
        /// The taxonomy to update. You can update only its description, display name,
        /// and activated policy types.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Taxonomy UpdateTaxonomy(Taxonomy taxonomy, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTaxonomy(new UpdateTaxonomyRequest { Taxonomy = taxonomy, }, callSettings);

        /// <summary>
        /// Updates a taxonomy, including its display name,
        /// description, and activated policy types.
        /// </summary>
        /// <param name="taxonomy">
        /// The taxonomy to update. You can update only its description, display name,
        /// and activated policy types.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> UpdateTaxonomyAsync(Taxonomy taxonomy, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTaxonomyAsync(new UpdateTaxonomyRequest { Taxonomy = taxonomy, }, callSettings);

        /// <summary>
        /// Updates a taxonomy, including its display name,
        /// description, and activated policy types.
        /// </summary>
        /// <param name="taxonomy">
        /// The taxonomy to update. You can update only its description, display name,
        /// and activated policy types.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> UpdateTaxonomyAsync(Taxonomy taxonomy, st::CancellationToken cancellationToken) =>
            UpdateTaxonomyAsync(taxonomy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all taxonomies in a project in a particular location that you
        /// have a permission to view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Taxonomy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTaxonomiesResponse, Taxonomy> ListTaxonomies(ListTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all taxonomies in a project in a particular location that you
        /// have a permission to view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Taxonomy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTaxonomiesResponse, Taxonomy> ListTaxonomiesAsync(ListTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all taxonomies in a project in a particular location that you
        /// have a permission to view.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project to list the taxonomies of.
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
        /// <returns>A pageable sequence of <see cref="Taxonomy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTaxonomiesResponse, Taxonomy> ListTaxonomies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTaxonomiesRequest request = new ListTaxonomiesRequest
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
            return ListTaxonomies(request, callSettings);
        }

        /// <summary>
        /// Lists all taxonomies in a project in a particular location that you
        /// have a permission to view.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project to list the taxonomies of.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Taxonomy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTaxonomiesResponse, Taxonomy> ListTaxonomiesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTaxonomiesRequest request = new ListTaxonomiesRequest
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
            return ListTaxonomiesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all taxonomies in a project in a particular location that you
        /// have a permission to view.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project to list the taxonomies of.
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
        /// <returns>A pageable sequence of <see cref="Taxonomy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTaxonomiesResponse, Taxonomy> ListTaxonomies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTaxonomiesRequest request = new ListTaxonomiesRequest
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
            return ListTaxonomies(request, callSettings);
        }

        /// <summary>
        /// Lists all taxonomies in a project in a particular location that you
        /// have a permission to view.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project to list the taxonomies of.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Taxonomy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTaxonomiesResponse, Taxonomy> ListTaxonomiesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTaxonomiesRequest request = new ListTaxonomiesRequest
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
            return ListTaxonomiesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Taxonomy GetTaxonomy(GetTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> GetTaxonomyAsync(GetTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> GetTaxonomyAsync(GetTaxonomyRequest request, st::CancellationToken cancellationToken) =>
            GetTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a taxonomy.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Taxonomy GetTaxonomy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaxonomy(new GetTaxonomyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a taxonomy.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> GetTaxonomyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaxonomyAsync(new GetTaxonomyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a taxonomy.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> GetTaxonomyAsync(string name, st::CancellationToken cancellationToken) =>
            GetTaxonomyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a taxonomy.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Taxonomy GetTaxonomy(TaxonomyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaxonomy(new GetTaxonomyRequest
            {
                TaxonomyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a taxonomy.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> GetTaxonomyAsync(TaxonomyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaxonomyAsync(new GetTaxonomyRequest
            {
                TaxonomyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a taxonomy.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the taxonomy to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Taxonomy> GetTaxonomyAsync(TaxonomyName name, st::CancellationToken cancellationToken) =>
            GetTaxonomyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a policy tag in a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyTag CreatePolicyTag(CreatePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a policy tag in a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> CreatePolicyTagAsync(CreatePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a policy tag in a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> CreatePolicyTagAsync(CreatePolicyTagRequest request, st::CancellationToken cancellationToken) =>
            CreatePolicyTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a policy tag in a taxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the taxonomy that the policy tag will belong to.
        /// </param>
        /// <param name="policyTag">
        /// The policy tag to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyTag CreatePolicyTag(string parent, PolicyTag policyTag, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyTag(new CreatePolicyTagRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PolicyTag = policyTag,
            }, callSettings);

        /// <summary>
        /// Creates a policy tag in a taxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the taxonomy that the policy tag will belong to.
        /// </param>
        /// <param name="policyTag">
        /// The policy tag to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> CreatePolicyTagAsync(string parent, PolicyTag policyTag, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyTagAsync(new CreatePolicyTagRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PolicyTag = policyTag,
            }, callSettings);

        /// <summary>
        /// Creates a policy tag in a taxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the taxonomy that the policy tag will belong to.
        /// </param>
        /// <param name="policyTag">
        /// The policy tag to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> CreatePolicyTagAsync(string parent, PolicyTag policyTag, st::CancellationToken cancellationToken) =>
            CreatePolicyTagAsync(parent, policyTag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a policy tag in a taxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the taxonomy that the policy tag will belong to.
        /// </param>
        /// <param name="policyTag">
        /// The policy tag to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyTag CreatePolicyTag(TaxonomyName parent, PolicyTag policyTag, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyTag(new CreatePolicyTagRequest
            {
                ParentAsTaxonomyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyTag = policyTag,
            }, callSettings);

        /// <summary>
        /// Creates a policy tag in a taxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the taxonomy that the policy tag will belong to.
        /// </param>
        /// <param name="policyTag">
        /// The policy tag to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> CreatePolicyTagAsync(TaxonomyName parent, PolicyTag policyTag, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyTagAsync(new CreatePolicyTagRequest
            {
                ParentAsTaxonomyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyTag = policyTag,
            }, callSettings);

        /// <summary>
        /// Creates a policy tag in a taxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the taxonomy that the policy tag will belong to.
        /// </param>
        /// <param name="policyTag">
        /// The policy tag to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> CreatePolicyTagAsync(TaxonomyName parent, PolicyTag policyTag, st::CancellationToken cancellationToken) =>
            CreatePolicyTagAsync(parent, policyTag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a policy tag together with the following:
        /// 
        /// * All of its descendant policy tags, if any
        /// * Policies associated with the policy tag and its descendants
        /// * References from BigQuery table schema of the policy tag and its
        /// descendants
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePolicyTag(DeletePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a policy tag together with the following:
        /// 
        /// * All of its descendant policy tags, if any
        /// * Policies associated with the policy tag and its descendants
        /// * References from BigQuery table schema of the policy tag and its
        /// descendants
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyTagAsync(DeletePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a policy tag together with the following:
        /// 
        /// * All of its descendant policy tags, if any
        /// * Policies associated with the policy tag and its descendants
        /// * References from BigQuery table schema of the policy tag and its
        /// descendants
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyTagAsync(DeletePolicyTagRequest request, st::CancellationToken cancellationToken) =>
            DeletePolicyTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a policy tag together with the following:
        /// 
        /// * All of its descendant policy tags, if any
        /// * Policies associated with the policy tag and its descendants
        /// * References from BigQuery table schema of the policy tag and its
        /// descendants
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag to delete.
        /// 
        /// Note: All of its descendant policy tags are also deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePolicyTag(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyTag(new DeletePolicyTagRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy tag together with the following:
        /// 
        /// * All of its descendant policy tags, if any
        /// * Policies associated with the policy tag and its descendants
        /// * References from BigQuery table schema of the policy tag and its
        /// descendants
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag to delete.
        /// 
        /// Note: All of its descendant policy tags are also deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyTagAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyTagAsync(new DeletePolicyTagRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy tag together with the following:
        /// 
        /// * All of its descendant policy tags, if any
        /// * Policies associated with the policy tag and its descendants
        /// * References from BigQuery table schema of the policy tag and its
        /// descendants
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag to delete.
        /// 
        /// Note: All of its descendant policy tags are also deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyTagAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePolicyTagAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a policy tag together with the following:
        /// 
        /// * All of its descendant policy tags, if any
        /// * Policies associated with the policy tag and its descendants
        /// * References from BigQuery table schema of the policy tag and its
        /// descendants
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag to delete.
        /// 
        /// Note: All of its descendant policy tags are also deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePolicyTag(PolicyTagName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyTag(new DeletePolicyTagRequest
            {
                PolicyTagName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy tag together with the following:
        /// 
        /// * All of its descendant policy tags, if any
        /// * Policies associated with the policy tag and its descendants
        /// * References from BigQuery table schema of the policy tag and its
        /// descendants
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag to delete.
        /// 
        /// Note: All of its descendant policy tags are also deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyTagAsync(PolicyTagName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyTagAsync(new DeletePolicyTagRequest
            {
                PolicyTagName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy tag together with the following:
        /// 
        /// * All of its descendant policy tags, if any
        /// * Policies associated with the policy tag and its descendants
        /// * References from BigQuery table schema of the policy tag and its
        /// descendants
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag to delete.
        /// 
        /// Note: All of its descendant policy tags are also deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyTagAsync(PolicyTagName name, st::CancellationToken cancellationToken) =>
            DeletePolicyTagAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a policy tag, including its display
        /// name, description, and parent policy tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyTag UpdatePolicyTag(UpdatePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a policy tag, including its display
        /// name, description, and parent policy tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> UpdatePolicyTagAsync(UpdatePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a policy tag, including its display
        /// name, description, and parent policy tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> UpdatePolicyTagAsync(UpdatePolicyTagRequest request, st::CancellationToken cancellationToken) =>
            UpdatePolicyTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a policy tag, including its display
        /// name, description, and parent policy tag.
        /// </summary>
        /// <param name="policyTag">
        /// The policy tag to update. You can update only its description, display
        /// name, and parent policy tag fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyTag UpdatePolicyTag(PolicyTag policyTag, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePolicyTag(new UpdatePolicyTagRequest
            {
                PolicyTag = policyTag,
            }, callSettings);

        /// <summary>
        /// Updates a policy tag, including its display
        /// name, description, and parent policy tag.
        /// </summary>
        /// <param name="policyTag">
        /// The policy tag to update. You can update only its description, display
        /// name, and parent policy tag fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> UpdatePolicyTagAsync(PolicyTag policyTag, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePolicyTagAsync(new UpdatePolicyTagRequest
            {
                PolicyTag = policyTag,
            }, callSettings);

        /// <summary>
        /// Updates a policy tag, including its display
        /// name, description, and parent policy tag.
        /// </summary>
        /// <param name="policyTag">
        /// The policy tag to update. You can update only its description, display
        /// name, and parent policy tag fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> UpdatePolicyTagAsync(PolicyTag policyTag, st::CancellationToken cancellationToken) =>
            UpdatePolicyTagAsync(policyTag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all policy tags in a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyTag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPolicyTagsResponse, PolicyTag> ListPolicyTags(ListPolicyTagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all policy tags in a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyTag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPolicyTagsResponse, PolicyTag> ListPolicyTagsAsync(ListPolicyTagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all policy tags in a taxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the taxonomy to list the policy tags of.
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
        /// <returns>A pageable sequence of <see cref="PolicyTag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPolicyTagsResponse, PolicyTag> ListPolicyTags(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyTagsRequest request = new ListPolicyTagsRequest
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
            return ListPolicyTags(request, callSettings);
        }

        /// <summary>
        /// Lists all policy tags in a taxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the taxonomy to list the policy tags of.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyTag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPolicyTagsResponse, PolicyTag> ListPolicyTagsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyTagsRequest request = new ListPolicyTagsRequest
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
            return ListPolicyTagsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all policy tags in a taxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the taxonomy to list the policy tags of.
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
        /// <returns>A pageable sequence of <see cref="PolicyTag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPolicyTagsResponse, PolicyTag> ListPolicyTags(TaxonomyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyTagsRequest request = new ListPolicyTagsRequest
            {
                ParentAsTaxonomyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPolicyTags(request, callSettings);
        }

        /// <summary>
        /// Lists all policy tags in a taxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the taxonomy to list the policy tags of.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyTag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPolicyTagsResponse, PolicyTag> ListPolicyTagsAsync(TaxonomyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyTagsRequest request = new ListPolicyTagsRequest
            {
                ParentAsTaxonomyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPolicyTagsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a policy tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyTag GetPolicyTag(GetPolicyTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a policy tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> GetPolicyTagAsync(GetPolicyTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a policy tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> GetPolicyTagAsync(GetPolicyTagRequest request, st::CancellationToken cancellationToken) =>
            GetPolicyTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a policy tag.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyTag GetPolicyTag(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyTag(new GetPolicyTagRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a policy tag.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> GetPolicyTagAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyTagAsync(new GetPolicyTagRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a policy tag.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> GetPolicyTagAsync(string name, st::CancellationToken cancellationToken) =>
            GetPolicyTagAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a policy tag.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyTag GetPolicyTag(PolicyTagName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyTag(new GetPolicyTagRequest
            {
                PolicyTagName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a policy tag.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> GetPolicyTagAsync(PolicyTagName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyTagAsync(new GetPolicyTagRequest
            {
                PolicyTagName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a policy tag.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the policy tag.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyTag> GetPolicyTagAsync(PolicyTagName name, st::CancellationToken cancellationToken) =>
            GetPolicyTagAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for a policy tag or a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for a policy tag or a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for a policy tag or a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM policy for a policy tag or a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy for a policy tag or a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy for a policy tag or a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns your permissions on a specified policy tag or
        /// taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns your permissions on a specified policy tag or
        /// taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns your permissions on a specified policy tag or
        /// taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PolicyTagManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Policy Tag Manager API service allows you to manage your policy tags and
    /// taxonomies.
    /// 
    /// Policy tags are used to tag BigQuery columns and apply additional access
    /// control policies. A taxonomy is a hierarchical grouping of policy tags that
    /// classify data along a common axis.
    /// </remarks>
    public sealed partial class PolicyTagManagerClientImpl : PolicyTagManagerClient
    {
        private readonly gaxgrpc::ApiCall<CreateTaxonomyRequest, Taxonomy> _callCreateTaxonomy;

        private readonly gaxgrpc::ApiCall<DeleteTaxonomyRequest, wkt::Empty> _callDeleteTaxonomy;

        private readonly gaxgrpc::ApiCall<UpdateTaxonomyRequest, Taxonomy> _callUpdateTaxonomy;

        private readonly gaxgrpc::ApiCall<ListTaxonomiesRequest, ListTaxonomiesResponse> _callListTaxonomies;

        private readonly gaxgrpc::ApiCall<GetTaxonomyRequest, Taxonomy> _callGetTaxonomy;

        private readonly gaxgrpc::ApiCall<CreatePolicyTagRequest, PolicyTag> _callCreatePolicyTag;

        private readonly gaxgrpc::ApiCall<DeletePolicyTagRequest, wkt::Empty> _callDeletePolicyTag;

        private readonly gaxgrpc::ApiCall<UpdatePolicyTagRequest, PolicyTag> _callUpdatePolicyTag;

        private readonly gaxgrpc::ApiCall<ListPolicyTagsRequest, ListPolicyTagsResponse> _callListPolicyTags;

        private readonly gaxgrpc::ApiCall<GetPolicyTagRequest, PolicyTag> _callGetPolicyTag;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the PolicyTagManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PolicyTagManagerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PolicyTagManagerClientImpl(PolicyTagManager.PolicyTagManagerClient grpcClient, PolicyTagManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PolicyTagManagerSettings effectiveSettings = settings ?? PolicyTagManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateTaxonomy = clientHelper.BuildApiCall<CreateTaxonomyRequest, Taxonomy>("CreateTaxonomy", grpcClient.CreateTaxonomyAsync, grpcClient.CreateTaxonomy, effectiveSettings.CreateTaxonomySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTaxonomy);
            Modify_CreateTaxonomyApiCall(ref _callCreateTaxonomy);
            _callDeleteTaxonomy = clientHelper.BuildApiCall<DeleteTaxonomyRequest, wkt::Empty>("DeleteTaxonomy", grpcClient.DeleteTaxonomyAsync, grpcClient.DeleteTaxonomy, effectiveSettings.DeleteTaxonomySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTaxonomy);
            Modify_DeleteTaxonomyApiCall(ref _callDeleteTaxonomy);
            _callUpdateTaxonomy = clientHelper.BuildApiCall<UpdateTaxonomyRequest, Taxonomy>("UpdateTaxonomy", grpcClient.UpdateTaxonomyAsync, grpcClient.UpdateTaxonomy, effectiveSettings.UpdateTaxonomySettings).WithGoogleRequestParam("taxonomy.name", request => request.Taxonomy?.Name);
            Modify_ApiCall(ref _callUpdateTaxonomy);
            Modify_UpdateTaxonomyApiCall(ref _callUpdateTaxonomy);
            _callListTaxonomies = clientHelper.BuildApiCall<ListTaxonomiesRequest, ListTaxonomiesResponse>("ListTaxonomies", grpcClient.ListTaxonomiesAsync, grpcClient.ListTaxonomies, effectiveSettings.ListTaxonomiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTaxonomies);
            Modify_ListTaxonomiesApiCall(ref _callListTaxonomies);
            _callGetTaxonomy = clientHelper.BuildApiCall<GetTaxonomyRequest, Taxonomy>("GetTaxonomy", grpcClient.GetTaxonomyAsync, grpcClient.GetTaxonomy, effectiveSettings.GetTaxonomySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTaxonomy);
            Modify_GetTaxonomyApiCall(ref _callGetTaxonomy);
            _callCreatePolicyTag = clientHelper.BuildApiCall<CreatePolicyTagRequest, PolicyTag>("CreatePolicyTag", grpcClient.CreatePolicyTagAsync, grpcClient.CreatePolicyTag, effectiveSettings.CreatePolicyTagSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePolicyTag);
            Modify_CreatePolicyTagApiCall(ref _callCreatePolicyTag);
            _callDeletePolicyTag = clientHelper.BuildApiCall<DeletePolicyTagRequest, wkt::Empty>("DeletePolicyTag", grpcClient.DeletePolicyTagAsync, grpcClient.DeletePolicyTag, effectiveSettings.DeletePolicyTagSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePolicyTag);
            Modify_DeletePolicyTagApiCall(ref _callDeletePolicyTag);
            _callUpdatePolicyTag = clientHelper.BuildApiCall<UpdatePolicyTagRequest, PolicyTag>("UpdatePolicyTag", grpcClient.UpdatePolicyTagAsync, grpcClient.UpdatePolicyTag, effectiveSettings.UpdatePolicyTagSettings).WithGoogleRequestParam("policy_tag.name", request => request.PolicyTag?.Name);
            Modify_ApiCall(ref _callUpdatePolicyTag);
            Modify_UpdatePolicyTagApiCall(ref _callUpdatePolicyTag);
            _callListPolicyTags = clientHelper.BuildApiCall<ListPolicyTagsRequest, ListPolicyTagsResponse>("ListPolicyTags", grpcClient.ListPolicyTagsAsync, grpcClient.ListPolicyTags, effectiveSettings.ListPolicyTagsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPolicyTags);
            Modify_ListPolicyTagsApiCall(ref _callListPolicyTags);
            _callGetPolicyTag = clientHelper.BuildApiCall<GetPolicyTagRequest, PolicyTag>("GetPolicyTag", grpcClient.GetPolicyTagAsync, grpcClient.GetPolicyTag, effectiveSettings.GetPolicyTagSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPolicyTag);
            Modify_GetPolicyTagApiCall(ref _callGetPolicyTag);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateTaxonomyApiCall(ref gaxgrpc::ApiCall<CreateTaxonomyRequest, Taxonomy> call);

        partial void Modify_DeleteTaxonomyApiCall(ref gaxgrpc::ApiCall<DeleteTaxonomyRequest, wkt::Empty> call);

        partial void Modify_UpdateTaxonomyApiCall(ref gaxgrpc::ApiCall<UpdateTaxonomyRequest, Taxonomy> call);

        partial void Modify_ListTaxonomiesApiCall(ref gaxgrpc::ApiCall<ListTaxonomiesRequest, ListTaxonomiesResponse> call);

        partial void Modify_GetTaxonomyApiCall(ref gaxgrpc::ApiCall<GetTaxonomyRequest, Taxonomy> call);

        partial void Modify_CreatePolicyTagApiCall(ref gaxgrpc::ApiCall<CreatePolicyTagRequest, PolicyTag> call);

        partial void Modify_DeletePolicyTagApiCall(ref gaxgrpc::ApiCall<DeletePolicyTagRequest, wkt::Empty> call);

        partial void Modify_UpdatePolicyTagApiCall(ref gaxgrpc::ApiCall<UpdatePolicyTagRequest, PolicyTag> call);

        partial void Modify_ListPolicyTagsApiCall(ref gaxgrpc::ApiCall<ListPolicyTagsRequest, ListPolicyTagsResponse> call);

        partial void Modify_GetPolicyTagApiCall(ref gaxgrpc::ApiCall<GetPolicyTagRequest, PolicyTag> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(PolicyTagManager.PolicyTagManagerClient grpcClient, PolicyTagManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PolicyTagManager client</summary>
        public override PolicyTagManager.PolicyTagManagerClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateTaxonomyRequest(ref CreateTaxonomyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTaxonomyRequest(ref DeleteTaxonomyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTaxonomyRequest(ref UpdateTaxonomyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTaxonomiesRequest(ref ListTaxonomiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTaxonomyRequest(ref GetTaxonomyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePolicyTagRequest(ref CreatePolicyTagRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePolicyTagRequest(ref DeletePolicyTagRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePolicyTagRequest(ref UpdatePolicyTagRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPolicyTagsRequest(ref ListPolicyTagsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPolicyTagRequest(ref GetPolicyTagRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a taxonomy in a specified project.
        /// 
        /// The taxonomy is initially empty, that is, it doesn't contain policy tags.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Taxonomy CreateTaxonomy(CreateTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTaxonomyRequest(ref request, ref callSettings);
            return _callCreateTaxonomy.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a taxonomy in a specified project.
        /// 
        /// The taxonomy is initially empty, that is, it doesn't contain policy tags.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Taxonomy> CreateTaxonomyAsync(CreateTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTaxonomyRequest(ref request, ref callSettings);
            return _callCreateTaxonomy.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a taxonomy, including all policy tags in this
        /// taxonomy, their associated policies, and the policy tags references from
        /// BigQuery columns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTaxonomy(DeleteTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTaxonomyRequest(ref request, ref callSettings);
            _callDeleteTaxonomy.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a taxonomy, including all policy tags in this
        /// taxonomy, their associated policies, and the policy tags references from
        /// BigQuery columns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTaxonomyAsync(DeleteTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTaxonomyRequest(ref request, ref callSettings);
            return _callDeleteTaxonomy.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a taxonomy, including its display name,
        /// description, and activated policy types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Taxonomy UpdateTaxonomy(UpdateTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTaxonomyRequest(ref request, ref callSettings);
            return _callUpdateTaxonomy.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a taxonomy, including its display name,
        /// description, and activated policy types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Taxonomy> UpdateTaxonomyAsync(UpdateTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTaxonomyRequest(ref request, ref callSettings);
            return _callUpdateTaxonomy.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all taxonomies in a project in a particular location that you
        /// have a permission to view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Taxonomy"/> resources.</returns>
        public override gax::PagedEnumerable<ListTaxonomiesResponse, Taxonomy> ListTaxonomies(ListTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTaxonomiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTaxonomiesRequest, ListTaxonomiesResponse, Taxonomy>(_callListTaxonomies, request, callSettings);
        }

        /// <summary>
        /// Lists all taxonomies in a project in a particular location that you
        /// have a permission to view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Taxonomy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTaxonomiesResponse, Taxonomy> ListTaxonomiesAsync(ListTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTaxonomiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTaxonomiesRequest, ListTaxonomiesResponse, Taxonomy>(_callListTaxonomies, request, callSettings);
        }

        /// <summary>
        /// Gets a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Taxonomy GetTaxonomy(GetTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaxonomyRequest(ref request, ref callSettings);
            return _callGetTaxonomy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Taxonomy> GetTaxonomyAsync(GetTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaxonomyRequest(ref request, ref callSettings);
            return _callGetTaxonomy.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a policy tag in a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PolicyTag CreatePolicyTag(CreatePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyTagRequest(ref request, ref callSettings);
            return _callCreatePolicyTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a policy tag in a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PolicyTag> CreatePolicyTagAsync(CreatePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyTagRequest(ref request, ref callSettings);
            return _callCreatePolicyTag.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a policy tag together with the following:
        /// 
        /// * All of its descendant policy tags, if any
        /// * Policies associated with the policy tag and its descendants
        /// * References from BigQuery table schema of the policy tag and its
        /// descendants
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePolicyTag(DeletePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyTagRequest(ref request, ref callSettings);
            _callDeletePolicyTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a policy tag together with the following:
        /// 
        /// * All of its descendant policy tags, if any
        /// * Policies associated with the policy tag and its descendants
        /// * References from BigQuery table schema of the policy tag and its
        /// descendants
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePolicyTagAsync(DeletePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyTagRequest(ref request, ref callSettings);
            return _callDeletePolicyTag.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a policy tag, including its display
        /// name, description, and parent policy tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PolicyTag UpdatePolicyTag(UpdatePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyTagRequest(ref request, ref callSettings);
            return _callUpdatePolicyTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a policy tag, including its display
        /// name, description, and parent policy tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PolicyTag> UpdatePolicyTagAsync(UpdatePolicyTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyTagRequest(ref request, ref callSettings);
            return _callUpdatePolicyTag.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all policy tags in a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyTag"/> resources.</returns>
        public override gax::PagedEnumerable<ListPolicyTagsResponse, PolicyTag> ListPolicyTags(ListPolicyTagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPolicyTagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPolicyTagsRequest, ListPolicyTagsResponse, PolicyTag>(_callListPolicyTags, request, callSettings);
        }

        /// <summary>
        /// Lists all policy tags in a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyTag"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPolicyTagsResponse, PolicyTag> ListPolicyTagsAsync(ListPolicyTagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPolicyTagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPolicyTagsRequest, ListPolicyTagsResponse, PolicyTag>(_callListPolicyTags, request, callSettings);
        }

        /// <summary>
        /// Gets a policy tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PolicyTag GetPolicyTag(GetPolicyTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyTagRequest(ref request, ref callSettings);
            return _callGetPolicyTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a policy tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PolicyTag> GetPolicyTagAsync(GetPolicyTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyTagRequest(ref request, ref callSettings);
            return _callGetPolicyTag.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy for a policy tag or a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy for a policy tag or a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM policy for a policy tag or a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM policy for a policy tag or a taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns your permissions on a specified policy tag or
        /// taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns your permissions on a specified policy tag or
        /// taxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class ListTaxonomiesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPolicyTagsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTaxonomiesResponse : gaxgrpc::IPageResponse<Taxonomy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Taxonomy> GetEnumerator() => Taxonomies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPolicyTagsResponse : gaxgrpc::IPageResponse<PolicyTag>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PolicyTag> GetEnumerator() => PolicyTags.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class PolicyTagManager
    {
        public partial class PolicyTagManagerClient
        {
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
