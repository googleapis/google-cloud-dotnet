// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;

using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

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
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PublicAdvertisedPrefixesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.Delete</c> and <c>PublicAdvertisedPrefixesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.Get</c> and <c>PublicAdvertisedPrefixesClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.Insert</c> and <c>PublicAdvertisedPrefixesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.List</c> and <c>PublicAdvertisedPrefixesClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicAdvertisedPrefixesClient.Patch</c> and <c>PublicAdvertisedPrefixesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
            return PublicAdvertisedPrefixesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PublicAdvertisedPrefixesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PublicAdvertisedPrefixesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PublicAdvertisedPrefixesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PublicAdvertisedPrefixesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PublicAdvertisedPrefixesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
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

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

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
        /// <returns>The created <see cref="PublicAdvertisedPrefixesClient"/>.</returns>
        internal static PublicAdvertisedPrefixesClient Create(grpccore::CallInvoker callInvoker, PublicAdvertisedPrefixesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient grpcClient = new PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient(callInvoker);
            return new PublicAdvertisedPrefixesClientImpl(grpcClient, settings);
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
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeletePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeletePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeletePublicAdvertisedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation Delete(string project, string publicAdvertisedPrefix, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> DeleteAsync(string project, string publicAdvertisedPrefix, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> DeleteAsync(string project, string publicAdvertisedPrefix, st::CancellationToken cancellationToken) =>
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
        public virtual Operation Insert(InsertPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertPublicAdvertisedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation Insert(string project, PublicAdvertisedPrefix publicAdvertisedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> InsertAsync(string project, PublicAdvertisedPrefix publicAdvertisedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> InsertAsync(string project, PublicAdvertisedPrefix publicAdvertisedPrefixResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, publicAdvertisedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicAdvertisedPrefixList List(ListPublicAdvertisedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicAdvertisedPrefixList> ListAsync(ListPublicAdvertisedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicAdvertisedPrefixList> ListAsync(ListPublicAdvertisedPrefixesRequest request, st::CancellationToken cancellationToken) =>
            ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicAdvertisedPrefixList List(string project, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListPublicAdvertisedPrefixesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicAdvertisedPrefixList> ListAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListPublicAdvertisedPrefixesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicAdvertisedPrefixList> ListAsync(string project, st::CancellationToken cancellationToken) =>
            ListAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(PatchPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchPublicAdvertisedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual Operation Patch(string project, string publicAdvertisedPrefix, PublicAdvertisedPrefix publicAdvertisedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> PatchAsync(string project, string publicAdvertisedPrefix, PublicAdvertisedPrefix publicAdvertisedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
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
        public virtual stt::Task<Operation> PatchAsync(string project, string publicAdvertisedPrefix, PublicAdvertisedPrefix publicAdvertisedPrefixResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, publicAdvertisedPrefix, publicAdvertisedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PublicAdvertisedPrefixes client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The PublicAdvertisedPrefixes API.
    /// </remarks>
    public sealed partial class PublicAdvertisedPrefixesClientImpl : PublicAdvertisedPrefixesClient
    {
        private readonly gaxgrpc::ApiCall<DeletePublicAdvertisedPrefixeRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetPublicAdvertisedPrefixeRequest, PublicAdvertisedPrefix> _callGet;

        private readonly gaxgrpc::ApiCall<InsertPublicAdvertisedPrefixeRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListPublicAdvertisedPrefixesRequest, PublicAdvertisedPrefixList> _callList;

        private readonly gaxgrpc::ApiCall<PatchPublicAdvertisedPrefixeRequest, Operation> _callPatch;

        /// <summary>
        /// Constructs a client wrapper for the PublicAdvertisedPrefixes service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PublicAdvertisedPrefixesSettings"/> used within this client.
        /// </param>
        public PublicAdvertisedPrefixesClientImpl(PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient grpcClient, PublicAdvertisedPrefixesSettings settings)
        {
            GrpcClient = grpcClient;
            PublicAdvertisedPrefixesSettings effectiveSettings = settings ?? PublicAdvertisedPrefixesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callDelete = clientHelper.BuildApiCall<DeletePublicAdvertisedPrefixeRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("public_advertised_prefix", request => request.PublicAdvertisedPrefix);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetPublicAdvertisedPrefixeRequest, PublicAdvertisedPrefix>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("public_advertised_prefix", request => request.PublicAdvertisedPrefix);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertPublicAdvertisedPrefixeRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListPublicAdvertisedPrefixesRequest, PublicAdvertisedPrefixList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchPublicAdvertisedPrefixeRequest, Operation>(grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("public_advertised_prefix", request => request.PublicAdvertisedPrefix);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeletePublicAdvertisedPrefixeRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetPublicAdvertisedPrefixeRequest, PublicAdvertisedPrefix> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertPublicAdvertisedPrefixeRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListPublicAdvertisedPrefixesRequest, PublicAdvertisedPrefixList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchPublicAdvertisedPrefixeRequest, Operation> call);

        partial void OnConstruction(PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient grpcClient, PublicAdvertisedPrefixesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PublicAdvertisedPrefixes client</summary>
        public override PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient GrpcClient { get; }

        partial void Modify_DeletePublicAdvertisedPrefixeRequest(ref DeletePublicAdvertisedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPublicAdvertisedPrefixeRequest(ref GetPublicAdvertisedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertPublicAdvertisedPrefixeRequest(ref InsertPublicAdvertisedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPublicAdvertisedPrefixesRequest(ref ListPublicAdvertisedPrefixesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchPublicAdvertisedPrefixeRequest(ref PatchPublicAdvertisedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeletePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified PublicAdvertisedPrefix
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeletePublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
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

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a PublicAdvertisedPrefix in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublicAdvertisedPrefixList List(ListPublicAdvertisedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublicAdvertisedPrefixesRequest(ref request, ref callSettings);
            return _callList.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the PublicAdvertisedPrefixes for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublicAdvertisedPrefixList> ListAsync(ListPublicAdvertisedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublicAdvertisedPrefixesRequest(ref request, ref callSettings);
            return _callList.Async(request, callSettings);
        }

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Patch(PatchPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            return _callPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PatchAsync(PatchPublicAdvertisedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchPublicAdvertisedPrefixeRequest(ref request, ref callSettings);
            return _callPatch.Async(request, callSettings);
        }
    }
}
