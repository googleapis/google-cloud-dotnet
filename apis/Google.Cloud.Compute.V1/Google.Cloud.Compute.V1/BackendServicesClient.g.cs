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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="BackendServicesClient"/> instances.</summary>
    public sealed partial class BackendServicesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BackendServicesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BackendServicesSettings"/>.</returns>
        public static BackendServicesSettings GetDefault() => new BackendServicesSettings();

        /// <summary>Constructs a new <see cref="BackendServicesSettings"/> object with default settings.</summary>
        public BackendServicesSettings()
        {
        }

        private BackendServicesSettings(BackendServicesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AddSignedUrlKeySettings = existing.AddSignedUrlKeySettings;
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            DeleteSignedUrlKeySettings = existing.DeleteSignedUrlKeySettings;
            GetSettings = existing.GetSettings;
            GetHealthSettings = existing.GetHealthSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            SetSecurityPolicySettings = existing.SetSecurityPolicySettings;
            UpdateSettings = existing.UpdateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BackendServicesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackendServicesClient.AddSignedUrlKey</c> and <c>BackendServicesClient.AddSignedUrlKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddSignedUrlKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackendServicesClient.AggregatedList</c> and <c>BackendServicesClient.AggregatedListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackendServicesClient.Delete</c> and <c>BackendServicesClient.DeleteAsync</c>.
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
        /// <c>BackendServicesClient.DeleteSignedUrlKey</c> and <c>BackendServicesClient.DeleteSignedUrlKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSignedUrlKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackendServicesClient.Get</c>
        ///  and <c>BackendServicesClient.GetAsync</c>.
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
        /// <c>BackendServicesClient.GetHealth</c> and <c>BackendServicesClient.GetHealthAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetHealthSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackendServicesClient.Insert</c> and <c>BackendServicesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackendServicesClient.List</c>
        ///  and <c>BackendServicesClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackendServicesClient.Patch</c>
        ///  and <c>BackendServicesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackendServicesClient.SetSecurityPolicy</c> and <c>BackendServicesClient.SetSecurityPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSecurityPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackendServicesClient.Update</c> and <c>BackendServicesClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BackendServicesSettings"/> object.</returns>
        public BackendServicesSettings Clone() => new BackendServicesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BackendServicesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class BackendServicesClientBuilder : gaxgrpc::ClientBuilderBase<BackendServicesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BackendServicesSettings Settings { get; set; }

        partial void InterceptBuild(ref BackendServicesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BackendServicesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BackendServicesClient Build()
        {
            BackendServicesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BackendServicesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BackendServicesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BackendServicesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BackendServicesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<BackendServicesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BackendServicesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => BackendServicesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BackendServicesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BackendServicesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>BackendServices client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The BackendServices API.
    /// </remarks>
    public abstract partial class BackendServicesClient
    {
        /// <summary>
        /// The default endpoint for the BackendServices service, which is a host of "compute.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default BackendServices scopes.</summary>
        /// <remarks>
        /// The default BackendServices scopes are:
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
        /// Asynchronously creates a <see cref="BackendServicesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BackendServicesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BackendServicesClient"/>.</returns>
        public static stt::Task<BackendServicesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BackendServicesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BackendServicesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BackendServicesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BackendServicesClient"/>.</returns>
        public static BackendServicesClient Create() => new BackendServicesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BackendServicesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BackendServicesSettings"/>.</param>
        /// <returns>The created <see cref="BackendServicesClient"/>.</returns>
        internal static BackendServicesClient Create(grpccore::CallInvoker callInvoker, BackendServicesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BackendServices.BackendServicesClient grpcClient = new BackendServices.BackendServicesClient(callInvoker);
            return new BackendServicesClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC BackendServices client</summary>
        public virtual BackendServices.BackendServicesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation AddSignedUrlKey(AddSignedUrlKeyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddSignedUrlKeyAsync(AddSignedUrlKeyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddSignedUrlKeyAsync(AddSignedUrlKeyBackendServiceRequest request, st::CancellationToken cancellationToken) =>
            AddSignedUrlKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="signedUrlKeyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation AddSignedUrlKey(string project, string backendService, SignedUrlKey signedUrlKeyResource, gaxgrpc::CallSettings callSettings = null) =>
            AddSignedUrlKey(new AddSignedUrlKeyBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SignedUrlKeyResource = gax::GaxPreconditions.CheckNotNull(signedUrlKeyResource, nameof(signedUrlKeyResource)),
            }, callSettings);

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="signedUrlKeyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddSignedUrlKeyAsync(string project, string backendService, SignedUrlKey signedUrlKeyResource, gaxgrpc::CallSettings callSettings = null) =>
            AddSignedUrlKeyAsync(new AddSignedUrlKeyBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SignedUrlKeyResource = gax::GaxPreconditions.CheckNotNull(signedUrlKeyResource, nameof(signedUrlKeyResource)),
            }, callSettings);

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="signedUrlKeyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddSignedUrlKeyAsync(string project, string backendService, SignedUrlKey signedUrlKeyResource, st::CancellationToken cancellationToken) =>
            AddSignedUrlKeyAsync(project, backendService, signedUrlKeyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of all BackendService resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<BackendServiceAggregatedList, scg::KeyValuePair<string, BackendServicesScopedList>> AggregatedList(AggregatedListBackendServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all BackendService resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<BackendServiceAggregatedList, scg::KeyValuePair<string, BackendServicesScopedList>> AggregatedListAsync(AggregatedListBackendServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all BackendService resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
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
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<BackendServiceAggregatedList, scg::KeyValuePair<string, BackendServicesScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedList(new AggregatedListBackendServicesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the list of all BackendService resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<BackendServiceAggregatedList, scg::KeyValuePair<string, BackendServicesScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedListAsync(new AggregatedListBackendServicesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes the specified BackendService resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified BackendService resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified BackendService resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteBackendServiceRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified BackendService resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string backendService, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified BackendService resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string backendService, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified BackendService resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string backendService, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, backendService, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteSignedUrlKey(DeleteSignedUrlKeyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendServiceRequest request, st::CancellationToken cancellationToken) =>
            DeleteSignedUrlKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="keyName">
        /// The name of the Signed URL Key to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteSignedUrlKey(string project, string backendService, string keyName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSignedUrlKey(new DeleteSignedUrlKeyBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                KeyName = gax::GaxPreconditions.CheckNotNullOrEmpty(keyName, nameof(keyName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="keyName">
        /// The name of the Signed URL Key to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteSignedUrlKeyAsync(string project, string backendService, string keyName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSignedUrlKeyAsync(new DeleteSignedUrlKeyBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                KeyName = gax::GaxPreconditions.CheckNotNullOrEmpty(keyName, nameof(keyName)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the Signed URL Key should be added. The name should conform to RFC1035.
        /// </param>
        /// <param name="keyName">
        /// The name of the Signed URL Key to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteSignedUrlKeyAsync(string project, string backendService, string keyName, st::CancellationToken cancellationToken) =>
            DeleteSignedUrlKeyAsync(project, backendService, keyName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified BackendService resource. Gets a list of available backend services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackendService Get(GetBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified BackendService resource. Gets a list of available backend services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendService> GetAsync(GetBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified BackendService resource. Gets a list of available backend services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendService> GetAsync(GetBackendServiceRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified BackendService resource. Gets a list of available backend services.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackendService Get(string project, string backendService, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Returns the specified BackendService resource. Gets a list of available backend services.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendService> GetAsync(string project, string backendService, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Returns the specified BackendService resource. Gets a list of available backend services.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendService> GetAsync(string project, string backendService, st::CancellationToken cancellationToken) =>
            GetAsync(project, backendService, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the most recent health check results for this BackendService.
        /// 
        /// Example request body:
        /// 
        /// { "group": "/zones/us-east1-b/instanceGroups/lb-backend-example" }
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackendServiceGroupHealth GetHealth(GetHealthBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the most recent health check results for this BackendService.
        /// 
        /// Example request body:
        /// 
        /// { "group": "/zones/us-east1-b/instanceGroups/lb-backend-example" }
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendServiceGroupHealth> GetHealthAsync(GetHealthBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the most recent health check results for this BackendService.
        /// 
        /// Example request body:
        /// 
        /// { "group": "/zones/us-east1-b/instanceGroups/lb-backend-example" }
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendServiceGroupHealth> GetHealthAsync(GetHealthBackendServiceRequest request, st::CancellationToken cancellationToken) =>
            GetHealthAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the most recent health check results for this BackendService.
        /// 
        /// Example request body:
        /// 
        /// { "group": "/zones/us-east1-b/instanceGroups/lb-backend-example" }
        /// </summary>
        /// <param name="project">
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the queried instance belongs.
        /// </param>
        /// <param name="resourceGroupReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackendServiceGroupHealth GetHealth(string project, string backendService, ResourceGroupReference resourceGroupReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            GetHealth(new GetHealthBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ResourceGroupReferenceResource = gax::GaxPreconditions.CheckNotNull(resourceGroupReferenceResource, nameof(resourceGroupReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Gets the most recent health check results for this BackendService.
        /// 
        /// Example request body:
        /// 
        /// { "group": "/zones/us-east1-b/instanceGroups/lb-backend-example" }
        /// </summary>
        /// <param name="project">
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the queried instance belongs.
        /// </param>
        /// <param name="resourceGroupReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendServiceGroupHealth> GetHealthAsync(string project, string backendService, ResourceGroupReference resourceGroupReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            GetHealthAsync(new GetHealthBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ResourceGroupReferenceResource = gax::GaxPreconditions.CheckNotNull(resourceGroupReferenceResource, nameof(resourceGroupReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Gets the most recent health check results for this BackendService.
        /// 
        /// Example request body:
        /// 
        /// { "group": "/zones/us-east1-b/instanceGroups/lb-backend-example" }
        /// </summary>
        /// <param name="project">
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the queried instance belongs.
        /// </param>
        /// <param name="resourceGroupReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackendServiceGroupHealth> GetHealthAsync(string project, string backendService, ResourceGroupReference resourceGroupReferenceResource, st::CancellationToken cancellationToken) =>
            GetHealthAsync(project, backendService, resourceGroupReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a BackendService resource in the specified project using the data included in the request. For more information, see  Backend services overview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a BackendService resource in the specified project using the data included in the request. For more information, see  Backend services overview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a BackendService resource in the specified project using the data included in the request. For more information, see  Backend services overview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertBackendServiceRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a BackendService resource in the specified project using the data included in the request. For more information, see  Backend services overview.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendServiceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, BackendService backendServiceResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertBackendServiceRequest
            {
                BackendServiceResource = gax::GaxPreconditions.CheckNotNull(backendServiceResource, nameof(backendServiceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Creates a BackendService resource in the specified project using the data included in the request. For more information, see  Backend services overview.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendServiceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, BackendService backendServiceResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertBackendServiceRequest
            {
                BackendServiceResource = gax::GaxPreconditions.CheckNotNull(backendServiceResource, nameof(backendServiceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Creates a BackendService resource in the specified project using the data included in the request. For more information, see  Backend services overview.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendServiceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, BackendService backendServiceResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, backendServiceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of BackendService resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackendService"/> resources.</returns>
        public virtual gax::PagedEnumerable<BackendServiceList, BackendService> List(ListBackendServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of BackendService resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackendService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<BackendServiceList, BackendService> ListAsync(ListBackendServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of BackendService resources available to the specified project.
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
        /// <returns>A pageable sequence of <see cref="BackendService"/> resources.</returns>
        public virtual gax::PagedEnumerable<BackendServiceList, BackendService> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListBackendServicesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the list of BackendService resources available to the specified project.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackendService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<BackendServiceList, BackendService> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListBackendServicesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Patches the specified BackendService resource with the data included in the request. For more information, see  Backend services overview. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(PatchBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified BackendService resource with the data included in the request. For more information, see  Backend services overview. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified BackendService resource with the data included in the request. For more information, see  Backend services overview. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchBackendServiceRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified BackendService resource with the data included in the request. For more information, see  Backend services overview. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to patch.
        /// </param>
        /// <param name="backendServiceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(string project, string backendService, BackendService backendServiceResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                BackendServiceResource = gax::GaxPreconditions.CheckNotNull(backendServiceResource, nameof(backendServiceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Patches the specified BackendService resource with the data included in the request. For more information, see  Backend services overview. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to patch.
        /// </param>
        /// <param name="backendServiceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string backendService, BackendService backendServiceResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                BackendServiceResource = gax::GaxPreconditions.CheckNotNull(backendServiceResource, nameof(backendServiceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Patches the specified BackendService resource with the data included in the request. For more information, see  Backend services overview. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to patch.
        /// </param>
        /// <param name="backendServiceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string backendService, BackendService backendServiceResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, backendService, backendServiceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified backend service. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSecurityPolicy(SetSecurityPolicyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified backend service. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSecurityPolicyAsync(SetSecurityPolicyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified backend service. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSecurityPolicyAsync(SetSecurityPolicyBackendServiceRequest request, st::CancellationToken cancellationToken) =>
            SetSecurityPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified backend service. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the security policy should be set. The name should conform to RFC1035.
        /// </param>
        /// <param name="securityPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSecurityPolicy(string project, string backendService, SecurityPolicyReference securityPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSecurityPolicy(new SetSecurityPolicyBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SecurityPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(securityPolicyReferenceResource, nameof(securityPolicyReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified backend service. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the security policy should be set. The name should conform to RFC1035.
        /// </param>
        /// <param name="securityPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSecurityPolicyAsync(string project, string backendService, SecurityPolicyReference securityPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSecurityPolicyAsync(new SetSecurityPolicyBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SecurityPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(securityPolicyReferenceResource, nameof(securityPolicyReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified backend service. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to which the security policy should be set. The name should conform to RFC1035.
        /// </param>
        /// <param name="securityPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSecurityPolicyAsync(string project, string backendService, SecurityPolicyReference securityPolicyReferenceResource, st::CancellationToken cancellationToken) =>
            SetSecurityPolicyAsync(project, backendService, securityPolicyReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified BackendService resource with the data included in the request. For more information, see Backend services overview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Update(UpdateBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified BackendService resource with the data included in the request. For more information, see Backend services overview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(UpdateBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified BackendService resource with the data included in the request. For more information, see Backend services overview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(UpdateBackendServiceRequest request, st::CancellationToken cancellationToken) =>
            UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified BackendService resource with the data included in the request. For more information, see Backend services overview.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to update.
        /// </param>
        /// <param name="backendServiceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Update(string project, string backendService, BackendService backendServiceResource, gaxgrpc::CallSettings callSettings = null) =>
            Update(new UpdateBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                BackendServiceResource = gax::GaxPreconditions.CheckNotNull(backendServiceResource, nameof(backendServiceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Updates the specified BackendService resource with the data included in the request. For more information, see Backend services overview.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to update.
        /// </param>
        /// <param name="backendServiceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(string project, string backendService, BackendService backendServiceResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsync(new UpdateBackendServiceRequest
            {
                BackendService = gax::GaxPreconditions.CheckNotNullOrEmpty(backendService, nameof(backendService)),
                BackendServiceResource = gax::GaxPreconditions.CheckNotNull(backendServiceResource, nameof(backendServiceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Updates the specified BackendService resource with the data included in the request. For more information, see Backend services overview.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="backendService">
        /// Name of the BackendService resource to update.
        /// </param>
        /// <param name="backendServiceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(string project, string backendService, BackendService backendServiceResource, st::CancellationToken cancellationToken) =>
            UpdateAsync(project, backendService, backendServiceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BackendServices client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The BackendServices API.
    /// </remarks>
    public sealed partial class BackendServicesClientImpl : BackendServicesClient
    {
        private readonly gaxgrpc::ApiCall<AddSignedUrlKeyBackendServiceRequest, Operation> _callAddSignedUrlKey;

        private readonly gaxgrpc::ApiCall<AggregatedListBackendServicesRequest, BackendServiceAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeleteBackendServiceRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<DeleteSignedUrlKeyBackendServiceRequest, Operation> _callDeleteSignedUrlKey;

        private readonly gaxgrpc::ApiCall<GetBackendServiceRequest, BackendService> _callGet;

        private readonly gaxgrpc::ApiCall<GetHealthBackendServiceRequest, BackendServiceGroupHealth> _callGetHealth;

        private readonly gaxgrpc::ApiCall<InsertBackendServiceRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListBackendServicesRequest, BackendServiceList> _callList;

        private readonly gaxgrpc::ApiCall<PatchBackendServiceRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<SetSecurityPolicyBackendServiceRequest, Operation> _callSetSecurityPolicy;

        private readonly gaxgrpc::ApiCall<UpdateBackendServiceRequest, Operation> _callUpdate;

        /// <summary>
        /// Constructs a client wrapper for the BackendServices service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BackendServicesSettings"/> used within this client.</param>
        public BackendServicesClientImpl(BackendServices.BackendServicesClient grpcClient, BackendServicesSettings settings)
        {
            GrpcClient = grpcClient;
            BackendServicesSettings effectiveSettings = settings ?? BackendServicesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callAddSignedUrlKey = clientHelper.BuildApiCall<AddSignedUrlKeyBackendServiceRequest, Operation>(grpcClient.AddSignedUrlKeyAsync, grpcClient.AddSignedUrlKey, effectiveSettings.AddSignedUrlKeySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_service", request => request.BackendService);
            Modify_ApiCall(ref _callAddSignedUrlKey);
            Modify_AddSignedUrlKeyApiCall(ref _callAddSignedUrlKey);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListBackendServicesRequest, BackendServiceAggregatedList>(grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeleteBackendServiceRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_service", request => request.BackendService);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callDeleteSignedUrlKey = clientHelper.BuildApiCall<DeleteSignedUrlKeyBackendServiceRequest, Operation>(grpcClient.DeleteSignedUrlKeyAsync, grpcClient.DeleteSignedUrlKey, effectiveSettings.DeleteSignedUrlKeySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_service", request => request.BackendService);
            Modify_ApiCall(ref _callDeleteSignedUrlKey);
            Modify_DeleteSignedUrlKeyApiCall(ref _callDeleteSignedUrlKey);
            _callGet = clientHelper.BuildApiCall<GetBackendServiceRequest, BackendService>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_service", request => request.BackendService);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetHealth = clientHelper.BuildApiCall<GetHealthBackendServiceRequest, BackendServiceGroupHealth>(grpcClient.GetHealthAsync, grpcClient.GetHealth, effectiveSettings.GetHealthSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_service", request => request.BackendService);
            Modify_ApiCall(ref _callGetHealth);
            Modify_GetHealthApiCall(ref _callGetHealth);
            _callInsert = clientHelper.BuildApiCall<InsertBackendServiceRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListBackendServicesRequest, BackendServiceList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchBackendServiceRequest, Operation>(grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_service", request => request.BackendService);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callSetSecurityPolicy = clientHelper.BuildApiCall<SetSecurityPolicyBackendServiceRequest, Operation>(grpcClient.SetSecurityPolicyAsync, grpcClient.SetSecurityPolicy, effectiveSettings.SetSecurityPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_service", request => request.BackendService);
            Modify_ApiCall(ref _callSetSecurityPolicy);
            Modify_SetSecurityPolicyApiCall(ref _callSetSecurityPolicy);
            _callUpdate = clientHelper.BuildApiCall<UpdateBackendServiceRequest, Operation>(grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("backend_service", request => request.BackendService);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AddSignedUrlKeyApiCall(ref gaxgrpc::ApiCall<AddSignedUrlKeyBackendServiceRequest, Operation> call);

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListBackendServicesRequest, BackendServiceAggregatedList> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteBackendServiceRequest, Operation> call);

        partial void Modify_DeleteSignedUrlKeyApiCall(ref gaxgrpc::ApiCall<DeleteSignedUrlKeyBackendServiceRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetBackendServiceRequest, BackendService> call);

        partial void Modify_GetHealthApiCall(ref gaxgrpc::ApiCall<GetHealthBackendServiceRequest, BackendServiceGroupHealth> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertBackendServiceRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListBackendServicesRequest, BackendServiceList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchBackendServiceRequest, Operation> call);

        partial void Modify_SetSecurityPolicyApiCall(ref gaxgrpc::ApiCall<SetSecurityPolicyBackendServiceRequest, Operation> call);

        partial void Modify_UpdateApiCall(ref gaxgrpc::ApiCall<UpdateBackendServiceRequest, Operation> call);

        partial void OnConstruction(BackendServices.BackendServicesClient grpcClient, BackendServicesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BackendServices client</summary>
        public override BackendServices.BackendServicesClient GrpcClient { get; }

        partial void Modify_AddSignedUrlKeyBackendServiceRequest(ref AddSignedUrlKeyBackendServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AggregatedListBackendServicesRequest(ref AggregatedListBackendServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackendServiceRequest(ref DeleteBackendServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSignedUrlKeyBackendServiceRequest(ref DeleteSignedUrlKeyBackendServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackendServiceRequest(ref GetBackendServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHealthBackendServiceRequest(ref GetHealthBackendServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertBackendServiceRequest(ref InsertBackendServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackendServicesRequest(ref ListBackendServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchBackendServiceRequest(ref PatchBackendServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSecurityPolicyBackendServiceRequest(ref SetSecurityPolicyBackendServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackendServiceRequest(ref UpdateBackendServiceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation AddSignedUrlKey(AddSignedUrlKeyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddSignedUrlKeyBackendServiceRequest(ref request, ref callSettings);
            return _callAddSignedUrlKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> AddSignedUrlKeyAsync(AddSignedUrlKeyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddSignedUrlKeyBackendServiceRequest(ref request, ref callSettings);
            return _callAddSignedUrlKey.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all BackendService resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<BackendServiceAggregatedList, scg::KeyValuePair<string, BackendServicesScopedList>> AggregatedList(AggregatedListBackendServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListBackendServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListBackendServicesRequest, BackendServiceAggregatedList, scg::KeyValuePair<string, BackendServicesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all BackendService resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<BackendServiceAggregatedList, scg::KeyValuePair<string, BackendServicesScopedList>> AggregatedListAsync(AggregatedListBackendServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListBackendServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListBackendServicesRequest, BackendServiceAggregatedList, scg::KeyValuePair<string, BackendServicesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified BackendService resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackendServiceRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified BackendService resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackendServiceRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation DeleteSignedUrlKey(DeleteSignedUrlKeyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSignedUrlKeyBackendServiceRequest(ref request, ref callSettings);
            return _callDeleteSignedUrlKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a key for validating requests with signed URLs for this backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteSignedUrlKeyAsync(DeleteSignedUrlKeyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSignedUrlKeyBackendServiceRequest(ref request, ref callSettings);
            return _callDeleteSignedUrlKey.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified BackendService resource. Gets a list of available backend services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BackendService Get(GetBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackendServiceRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified BackendService resource. Gets a list of available backend services.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackendService> GetAsync(GetBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackendServiceRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the most recent health check results for this BackendService.
        /// 
        /// Example request body:
        /// 
        /// { "group": "/zones/us-east1-b/instanceGroups/lb-backend-example" }
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BackendServiceGroupHealth GetHealth(GetHealthBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHealthBackendServiceRequest(ref request, ref callSettings);
            return _callGetHealth.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the most recent health check results for this BackendService.
        /// 
        /// Example request body:
        /// 
        /// { "group": "/zones/us-east1-b/instanceGroups/lb-backend-example" }
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackendServiceGroupHealth> GetHealthAsync(GetHealthBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHealthBackendServiceRequest(ref request, ref callSettings);
            return _callGetHealth.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a BackendService resource in the specified project using the data included in the request. For more information, see  Backend services overview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertBackendServiceRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a BackendService resource in the specified project using the data included in the request. For more information, see  Backend services overview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertBackendServiceRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of BackendService resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackendService"/> resources.</returns>
        public override gax::PagedEnumerable<BackendServiceList, BackendService> List(ListBackendServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackendServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackendServicesRequest, BackendServiceList, BackendService>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of BackendService resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackendService"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<BackendServiceList, BackendService> ListAsync(ListBackendServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackendServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackendServicesRequest, BackendServiceList, BackendService>(_callList, request, callSettings);
        }

        /// <summary>
        /// Patches the specified BackendService resource with the data included in the request. For more information, see  Backend services overview. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Patch(PatchBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchBackendServiceRequest(ref request, ref callSettings);
            return _callPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified BackendService resource with the data included in the request. For more information, see  Backend services overview. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PatchAsync(PatchBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchBackendServiceRequest(ref request, ref callSettings);
            return _callPatch.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified backend service. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetSecurityPolicy(SetSecurityPolicyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSecurityPolicyBackendServiceRequest(ref request, ref callSettings);
            return _callSetSecurityPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the Google Cloud Armor security policy for the specified backend service. For more information, see Google Cloud Armor Overview
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetSecurityPolicyAsync(SetSecurityPolicyBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSecurityPolicyBackendServiceRequest(ref request, ref callSettings);
            return _callSetSecurityPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified BackendService resource with the data included in the request. For more information, see Backend services overview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Update(UpdateBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackendServiceRequest(ref request, ref callSettings);
            return _callUpdate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified BackendService resource with the data included in the request. For more information, see Backend services overview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateAsync(UpdateBackendServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackendServiceRequest(ref request, ref callSettings);
            return _callUpdate.Async(request, callSettings);
        }
    }

    public partial class AggregatedListBackendServicesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            set => MaxResults = (uint)value;
        }
    }

    public partial class ListBackendServicesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            set => MaxResults = (uint)value;
        }
    }

    public partial class BackendServiceAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, BackendServicesScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, BackendServicesScopedList>> GetEnumerator() =>
            Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class BackendServiceList : gaxgrpc::IPageResponse<BackendService>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackendService> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
