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

namespace Google.Cloud.Run.V2
{
    /// <summary>Settings for <see cref="RevisionsClient"/> instances.</summary>
    public sealed partial class RevisionsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RevisionsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RevisionsSettings"/>.</returns>
        public static RevisionsSettings GetDefault() => new RevisionsSettings();

        /// <summary>Constructs a new <see cref="RevisionsSettings"/> object with default settings.</summary>
        public RevisionsSettings()
        {
        }

        private RevisionsSettings(RevisionsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetRevisionSettings = existing.GetRevisionSettings;
            ListRevisionsSettings = existing.ListRevisionsSettings;
            DeleteRevisionSettings = existing.DeleteRevisionSettings;
            DeleteRevisionOperationsSettings = existing.DeleteRevisionOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RevisionsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RevisionsClient.GetRevision</c>
        ///  and <c>RevisionsClient.GetRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRevisionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RevisionsClient.ListRevisions</c> and <c>RevisionsClient.ListRevisionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRevisionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RevisionsClient.DeleteRevision</c> and <c>RevisionsClient.DeleteRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRevisionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>RevisionsClient.DeleteRevision</c> and
        /// <c>RevisionsClient.DeleteRevisionAsync</c>.
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
        public lro::OperationsSettings DeleteRevisionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RevisionsSettings"/> object.</returns>
        public RevisionsSettings Clone() => new RevisionsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RevisionsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RevisionsClientBuilder : gaxgrpc::ClientBuilderBase<RevisionsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RevisionsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RevisionsClientBuilder() : base(RevisionsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RevisionsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RevisionsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RevisionsClient Build()
        {
            RevisionsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RevisionsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RevisionsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RevisionsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RevisionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RevisionsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RevisionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RevisionsClient.ChannelPool;
    }

    /// <summary>Revisions client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud Run Revision Control Plane API.
    /// </remarks>
    public abstract partial class RevisionsClient
    {
        /// <summary>
        /// The default endpoint for the Revisions service, which is a host of "run.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "run.googleapis.com:443";

        /// <summary>The default Revisions scopes.</summary>
        /// <remarks>
        /// The default Revisions scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Revisions.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RevisionsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="RevisionsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RevisionsClient"/>.</returns>
        public static stt::Task<RevisionsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RevisionsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RevisionsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="RevisionsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RevisionsClient"/>.</returns>
        public static RevisionsClient Create() => new RevisionsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RevisionsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RevisionsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RevisionsClient"/>.</returns>
        internal static RevisionsClient Create(grpccore::CallInvoker callInvoker, RevisionsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Revisions.RevisionsClient grpcClient = new Revisions.RevisionsClient(callInvoker);
            return new RevisionsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Revisions client</summary>
        public virtual Revisions.RevisionsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Revision GetRevision(GetRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(GetRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(GetRevisionRequest request, st::CancellationToken cancellationToken) =>
            GetRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Revision.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Revision GetRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRevision(new GetRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Revision.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRevisionAsync(new GetRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Revision.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            GetRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Revision.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Revision GetRevision(RevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRevision(new GetRevisionRequest
            {
                RevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Revision.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(RevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRevisionAsync(new GetRevisionRequest
            {
                RevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Revision.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(RevisionName name, st::CancellationToken cancellationToken) =>
            GetRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Revisions from a given Service, or from a given location.  Results
        /// are sorted by creation time, descending.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRevisionsResponse, Revision> ListRevisions(ListRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Revisions from a given Service, or from a given location.  Results
        /// are sorted by creation time, descending.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRevisionsResponse, Revision> ListRevisionsAsync(ListRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Revisions from a given Service, or from a given location.  Results
        /// are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The Service from which the Revisions should be listed.
        /// To list all Revisions across Services, use "-" instead of Service name.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}
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
        /// <returns>A pageable sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRevisionsResponse, Revision> ListRevisions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRevisionsRequest request = new ListRevisionsRequest
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
            return ListRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists Revisions from a given Service, or from a given location.  Results
        /// are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The Service from which the Revisions should be listed.
        /// To list all Revisions across Services, use "-" instead of Service name.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRevisionsResponse, Revision> ListRevisionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRevisionsRequest request = new ListRevisionsRequest
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
            return ListRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Revisions from a given Service, or from a given location.  Results
        /// are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The Service from which the Revisions should be listed.
        /// To list all Revisions across Services, use "-" instead of Service name.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}
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
        /// <returns>A pageable sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRevisionsResponse, Revision> ListRevisions(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRevisionsRequest request = new ListRevisionsRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists Revisions from a given Service, or from a given location.  Results
        /// are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The Service from which the Revisions should be listed.
        /// To list all Revisions across Services, use "-" instead of Service name.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRevisionsResponse, Revision> ListRevisionsAsync(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRevisionsRequest request = new ListRevisionsRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Revision, Revision> DeleteRevision(DeleteRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Revision, Revision>> DeleteRevisionAsync(DeleteRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Revision, Revision>> DeleteRevisionAsync(DeleteRevisionRequest request, st::CancellationToken cancellationToken) =>
            DeleteRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRevision</c>.</summary>
        public virtual lro::OperationsClient DeleteRevisionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Revision, Revision> PollOnceDeleteRevision(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Revision, Revision>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRevisionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Revision, Revision>> PollOnceDeleteRevisionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Revision, Revision>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRevisionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision to delete.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Revision, Revision> DeleteRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRevision(new DeleteRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision to delete.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Revision, Revision>> DeleteRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRevisionAsync(new DeleteRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision to delete.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Revision, Revision>> DeleteRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision to delete.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Revision, Revision> DeleteRevision(RevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRevision(new DeleteRevisionRequest
            {
                RevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision to delete.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Revision, Revision>> DeleteRevisionAsync(RevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRevisionAsync(new DeleteRevisionRequest
            {
                RevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision to delete.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/revisions/{revision}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Revision, Revision>> DeleteRevisionAsync(RevisionName name, st::CancellationToken cancellationToken) =>
            DeleteRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Revisions client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud Run Revision Control Plane API.
    /// </remarks>
    public sealed partial class RevisionsClientImpl : RevisionsClient
    {
        private readonly gaxgrpc::ApiCall<GetRevisionRequest, Revision> _callGetRevision;

        private readonly gaxgrpc::ApiCall<ListRevisionsRequest, ListRevisionsResponse> _callListRevisions;

        private readonly gaxgrpc::ApiCall<DeleteRevisionRequest, lro::Operation> _callDeleteRevision;

        /// <summary>
        /// Constructs a client wrapper for the Revisions service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RevisionsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RevisionsClientImpl(Revisions.RevisionsClient grpcClient, RevisionsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RevisionsSettings effectiveSettings = settings ?? RevisionsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteRevisionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRevisionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetRevision = clientHelper.BuildApiCall<GetRevisionRequest, Revision>("GetRevision", grpcClient.GetRevisionAsync, grpcClient.GetRevision, effectiveSettings.GetRevisionSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetRevisionRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callGetRevision);
            Modify_GetRevisionApiCall(ref _callGetRevision);
            _callListRevisions = clientHelper.BuildApiCall<ListRevisionsRequest, ListRevisionsResponse>("ListRevisions", grpcClient.ListRevisionsAsync, grpcClient.ListRevisions, effectiveSettings.ListRevisionsSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ListRevisionsRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)(?:/.*)?$", request => request.Parent));
            Modify_ApiCall(ref _callListRevisions);
            Modify_ListRevisionsApiCall(ref _callListRevisions);
            _callDeleteRevision = clientHelper.BuildApiCall<DeleteRevisionRequest, lro::Operation>("DeleteRevision", grpcClient.DeleteRevisionAsync, grpcClient.DeleteRevision, effectiveSettings.DeleteRevisionSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteRevisionRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteRevision);
            Modify_DeleteRevisionApiCall(ref _callDeleteRevision);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetRevisionApiCall(ref gaxgrpc::ApiCall<GetRevisionRequest, Revision> call);

        partial void Modify_ListRevisionsApiCall(ref gaxgrpc::ApiCall<ListRevisionsRequest, ListRevisionsResponse> call);

        partial void Modify_DeleteRevisionApiCall(ref gaxgrpc::ApiCall<DeleteRevisionRequest, lro::Operation> call);

        partial void OnConstruction(Revisions.RevisionsClient grpcClient, RevisionsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Revisions client</summary>
        public override Revisions.RevisionsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetRevisionRequest(ref GetRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRevisionsRequest(ref ListRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRevisionRequest(ref DeleteRevisionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets information about a Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Revision GetRevision(GetRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRevisionRequest(ref request, ref callSettings);
            return _callGetRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Revision> GetRevisionAsync(GetRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRevisionRequest(ref request, ref callSettings);
            return _callGetRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Revisions from a given Service, or from a given location.  Results
        /// are sorted by creation time, descending.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Revision"/> resources.</returns>
        public override gax::PagedEnumerable<ListRevisionsResponse, Revision> ListRevisions(ListRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRevisionsRequest, ListRevisionsResponse, Revision>(_callListRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists Revisions from a given Service, or from a given location.  Results
        /// are sorted by creation time, descending.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Revision"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRevisionsResponse, Revision> ListRevisionsAsync(ListRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRevisionsRequest, ListRevisionsResponse, Revision>(_callListRevisions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteRevision</c>.</summary>
        public override lro::OperationsClient DeleteRevisionOperationsClient { get; }

        /// <summary>
        /// Deletes a Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Revision, Revision> DeleteRevision(DeleteRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<Revision, Revision>(_callDeleteRevision.Sync(request, callSettings), DeleteRevisionOperationsClient);
        }

        /// <summary>
        /// Deletes a Revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Revision, Revision>> DeleteRevisionAsync(DeleteRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<Revision, Revision>(await _callDeleteRevision.Async(request, callSettings).ConfigureAwait(false), DeleteRevisionOperationsClient);
        }
    }

    public partial class ListRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRevisionsResponse : gaxgrpc::IPageResponse<Revision>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Revision> GetEnumerator() => Revisions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Revisions
    {
        public partial class RevisionsClient
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

    public static partial class Revisions
    {
        public partial class RevisionsClient
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
