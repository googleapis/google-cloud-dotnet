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

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="GenAiTuningServiceClient"/> instances.</summary>
    public sealed partial class GenAiTuningServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GenAiTuningServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GenAiTuningServiceSettings"/>.</returns>
        public static GenAiTuningServiceSettings GetDefault() => new GenAiTuningServiceSettings();

        /// <summary>Constructs a new <see cref="GenAiTuningServiceSettings"/> object with default settings.</summary>
        public GenAiTuningServiceSettings()
        {
        }

        private GenAiTuningServiceSettings(GenAiTuningServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTuningJobSettings = existing.CreateTuningJobSettings;
            GetTuningJobSettings = existing.GetTuningJobSettings;
            ListTuningJobsSettings = existing.ListTuningJobsSettings;
            CancelTuningJobSettings = existing.CancelTuningJobSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(GenAiTuningServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenAiTuningServiceClient.CreateTuningJob</c> and <c>GenAiTuningServiceClient.CreateTuningJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTuningJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenAiTuningServiceClient.GetTuningJob</c> and <c>GenAiTuningServiceClient.GetTuningJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTuningJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenAiTuningServiceClient.ListTuningJobs</c> and <c>GenAiTuningServiceClient.ListTuningJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTuningJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenAiTuningServiceClient.CancelTuningJob</c> and <c>GenAiTuningServiceClient.CancelTuningJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelTuningJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GenAiTuningServiceSettings"/> object.</returns>
        public GenAiTuningServiceSettings Clone() => new GenAiTuningServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GenAiTuningServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class GenAiTuningServiceClientBuilder : gaxgrpc::ClientBuilderBase<GenAiTuningServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GenAiTuningServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GenAiTuningServiceClientBuilder() : base(GenAiTuningServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GenAiTuningServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GenAiTuningServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GenAiTuningServiceClient Build()
        {
            GenAiTuningServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GenAiTuningServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GenAiTuningServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GenAiTuningServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GenAiTuningServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GenAiTuningServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GenAiTuningServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GenAiTuningServiceClient.ChannelPool;
    }

    /// <summary>GenAiTuningService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing GenAI Tuning Jobs.
    /// </remarks>
    public abstract partial class GenAiTuningServiceClient
    {
        /// <summary>
        /// The default endpoint for the GenAiTuningService service, which is a host of "aiplatform.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default GenAiTuningService scopes.</summary>
        /// <remarks>
        /// The default GenAiTuningService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GenAiTuningService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GenAiTuningServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GenAiTuningServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GenAiTuningServiceClient"/>.</returns>
        public static stt::Task<GenAiTuningServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GenAiTuningServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GenAiTuningServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GenAiTuningServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="GenAiTuningServiceClient"/>.</returns>
        public static GenAiTuningServiceClient Create() => new GenAiTuningServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GenAiTuningServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GenAiTuningServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GenAiTuningServiceClient"/>.</returns>
        internal static GenAiTuningServiceClient Create(grpccore::CallInvoker callInvoker, GenAiTuningServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GenAiTuningService.GenAiTuningServiceClient grpcClient = new GenAiTuningService.GenAiTuningServiceClient(callInvoker);
            return new GenAiTuningServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GenAiTuningService client</summary>
        public virtual GenAiTuningService.GenAiTuningServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TuningJob. A created TuningJob right away will be attempted to
        /// be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TuningJob CreateTuningJob(CreateTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TuningJob. A created TuningJob right away will be attempted to
        /// be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> CreateTuningJobAsync(CreateTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TuningJob. A created TuningJob right away will be attempted to
        /// be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> CreateTuningJobAsync(CreateTuningJobRequest request, st::CancellationToken cancellationToken) =>
            CreateTuningJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TuningJob. A created TuningJob right away will be attempted to
        /// be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TuningJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tuningJob">
        /// Required. The TuningJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TuningJob CreateTuningJob(string parent, TuningJob tuningJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateTuningJob(new CreateTuningJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TuningJob = gax::GaxPreconditions.CheckNotNull(tuningJob, nameof(tuningJob)),
            }, callSettings);

        /// <summary>
        /// Creates a TuningJob. A created TuningJob right away will be attempted to
        /// be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TuningJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tuningJob">
        /// Required. The TuningJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> CreateTuningJobAsync(string parent, TuningJob tuningJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateTuningJobAsync(new CreateTuningJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TuningJob = gax::GaxPreconditions.CheckNotNull(tuningJob, nameof(tuningJob)),
            }, callSettings);

        /// <summary>
        /// Creates a TuningJob. A created TuningJob right away will be attempted to
        /// be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TuningJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tuningJob">
        /// Required. The TuningJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> CreateTuningJobAsync(string parent, TuningJob tuningJob, st::CancellationToken cancellationToken) =>
            CreateTuningJobAsync(parent, tuningJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TuningJob. A created TuningJob right away will be attempted to
        /// be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TuningJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tuningJob">
        /// Required. The TuningJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TuningJob CreateTuningJob(gagr::LocationName parent, TuningJob tuningJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateTuningJob(new CreateTuningJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TuningJob = gax::GaxPreconditions.CheckNotNull(tuningJob, nameof(tuningJob)),
            }, callSettings);

        /// <summary>
        /// Creates a TuningJob. A created TuningJob right away will be attempted to
        /// be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TuningJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tuningJob">
        /// Required. The TuningJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> CreateTuningJobAsync(gagr::LocationName parent, TuningJob tuningJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateTuningJobAsync(new CreateTuningJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TuningJob = gax::GaxPreconditions.CheckNotNull(tuningJob, nameof(tuningJob)),
            }, callSettings);

        /// <summary>
        /// Creates a TuningJob. A created TuningJob right away will be attempted to
        /// be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the TuningJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tuningJob">
        /// Required. The TuningJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> CreateTuningJobAsync(gagr::LocationName parent, TuningJob tuningJob, st::CancellationToken cancellationToken) =>
            CreateTuningJobAsync(parent, tuningJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TuningJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TuningJob GetTuningJob(GetTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a TuningJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> GetTuningJobAsync(GetTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a TuningJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> GetTuningJobAsync(GetTuningJobRequest request, st::CancellationToken cancellationToken) =>
            GetTuningJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob resource. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TuningJob GetTuningJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTuningJob(new GetTuningJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob resource. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> GetTuningJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTuningJobAsync(new GetTuningJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob resource. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> GetTuningJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetTuningJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob resource. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TuningJob GetTuningJob(TuningJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTuningJob(new GetTuningJobRequest
            {
                TuningJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob resource. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> GetTuningJobAsync(TuningJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTuningJobAsync(new GetTuningJobRequest
            {
                TuningJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob resource. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TuningJob> GetTuningJobAsync(TuningJobName name, st::CancellationToken cancellationToken) =>
            GetTuningJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists TuningJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TuningJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTuningJobsResponse, TuningJob> ListTuningJobs(ListTuningJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TuningJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TuningJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTuningJobsResponse, TuningJob> ListTuningJobsAsync(ListTuningJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TuningJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the TuningJobs from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="TuningJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTuningJobsResponse, TuningJob> ListTuningJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTuningJobsRequest request = new ListTuningJobsRequest
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
            return ListTuningJobs(request, callSettings);
        }

        /// <summary>
        /// Lists TuningJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the TuningJobs from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TuningJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTuningJobsResponse, TuningJob> ListTuningJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTuningJobsRequest request = new ListTuningJobsRequest
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
            return ListTuningJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists TuningJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the TuningJobs from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="TuningJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTuningJobsResponse, TuningJob> ListTuningJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTuningJobsRequest request = new ListTuningJobsRequest
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
            return ListTuningJobs(request, callSettings);
        }

        /// <summary>
        /// Lists TuningJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the TuningJobs from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TuningJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTuningJobsResponse, TuningJob> ListTuningJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTuningJobsRequest request = new ListTuningJobsRequest
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
            return ListTuningJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Cancels a TuningJob.
        /// Starts asynchronous cancellation on the TuningJob. The server makes a best
        /// effort to cancel the job, but success is not guaranteed. Clients can use
        /// [GenAiTuningService.GetTuningJob][google.cloud.aiplatform.v1beta1.GenAiTuningService.GetTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation, the
        /// TuningJob is not deleted; instead it becomes a job with a
        /// [TuningJob.error][google.cloud.aiplatform.v1beta1.TuningJob.error] value
        /// with a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`, and
        /// [TuningJob.state][google.cloud.aiplatform.v1beta1.TuningJob.state] is set
        /// to `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelTuningJob(CancelTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a TuningJob.
        /// Starts asynchronous cancellation on the TuningJob. The server makes a best
        /// effort to cancel the job, but success is not guaranteed. Clients can use
        /// [GenAiTuningService.GetTuningJob][google.cloud.aiplatform.v1beta1.GenAiTuningService.GetTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation, the
        /// TuningJob is not deleted; instead it becomes a job with a
        /// [TuningJob.error][google.cloud.aiplatform.v1beta1.TuningJob.error] value
        /// with a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`, and
        /// [TuningJob.state][google.cloud.aiplatform.v1beta1.TuningJob.state] is set
        /// to `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTuningJobAsync(CancelTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a TuningJob.
        /// Starts asynchronous cancellation on the TuningJob. The server makes a best
        /// effort to cancel the job, but success is not guaranteed. Clients can use
        /// [GenAiTuningService.GetTuningJob][google.cloud.aiplatform.v1beta1.GenAiTuningService.GetTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation, the
        /// TuningJob is not deleted; instead it becomes a job with a
        /// [TuningJob.error][google.cloud.aiplatform.v1beta1.TuningJob.error] value
        /// with a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`, and
        /// [TuningJob.state][google.cloud.aiplatform.v1beta1.TuningJob.state] is set
        /// to `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTuningJobAsync(CancelTuningJobRequest request, st::CancellationToken cancellationToken) =>
            CancelTuningJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a TuningJob.
        /// Starts asynchronous cancellation on the TuningJob. The server makes a best
        /// effort to cancel the job, but success is not guaranteed. Clients can use
        /// [GenAiTuningService.GetTuningJob][google.cloud.aiplatform.v1beta1.GenAiTuningService.GetTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation, the
        /// TuningJob is not deleted; instead it becomes a job with a
        /// [TuningJob.error][google.cloud.aiplatform.v1beta1.TuningJob.error] value
        /// with a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`, and
        /// [TuningJob.state][google.cloud.aiplatform.v1beta1.TuningJob.state] is set
        /// to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob to cancel. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelTuningJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelTuningJob(new CancelTuningJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a TuningJob.
        /// Starts asynchronous cancellation on the TuningJob. The server makes a best
        /// effort to cancel the job, but success is not guaranteed. Clients can use
        /// [GenAiTuningService.GetTuningJob][google.cloud.aiplatform.v1beta1.GenAiTuningService.GetTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation, the
        /// TuningJob is not deleted; instead it becomes a job with a
        /// [TuningJob.error][google.cloud.aiplatform.v1beta1.TuningJob.error] value
        /// with a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`, and
        /// [TuningJob.state][google.cloud.aiplatform.v1beta1.TuningJob.state] is set
        /// to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob to cancel. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTuningJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelTuningJobAsync(new CancelTuningJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a TuningJob.
        /// Starts asynchronous cancellation on the TuningJob. The server makes a best
        /// effort to cancel the job, but success is not guaranteed. Clients can use
        /// [GenAiTuningService.GetTuningJob][google.cloud.aiplatform.v1beta1.GenAiTuningService.GetTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation, the
        /// TuningJob is not deleted; instead it becomes a job with a
        /// [TuningJob.error][google.cloud.aiplatform.v1beta1.TuningJob.error] value
        /// with a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`, and
        /// [TuningJob.state][google.cloud.aiplatform.v1beta1.TuningJob.state] is set
        /// to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob to cancel. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTuningJobAsync(string name, st::CancellationToken cancellationToken) =>
            CancelTuningJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a TuningJob.
        /// Starts asynchronous cancellation on the TuningJob. The server makes a best
        /// effort to cancel the job, but success is not guaranteed. Clients can use
        /// [GenAiTuningService.GetTuningJob][google.cloud.aiplatform.v1beta1.GenAiTuningService.GetTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation, the
        /// TuningJob is not deleted; instead it becomes a job with a
        /// [TuningJob.error][google.cloud.aiplatform.v1beta1.TuningJob.error] value
        /// with a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`, and
        /// [TuningJob.state][google.cloud.aiplatform.v1beta1.TuningJob.state] is set
        /// to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob to cancel. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelTuningJob(TuningJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelTuningJob(new CancelTuningJobRequest
            {
                TuningJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a TuningJob.
        /// Starts asynchronous cancellation on the TuningJob. The server makes a best
        /// effort to cancel the job, but success is not guaranteed. Clients can use
        /// [GenAiTuningService.GetTuningJob][google.cloud.aiplatform.v1beta1.GenAiTuningService.GetTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation, the
        /// TuningJob is not deleted; instead it becomes a job with a
        /// [TuningJob.error][google.cloud.aiplatform.v1beta1.TuningJob.error] value
        /// with a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`, and
        /// [TuningJob.state][google.cloud.aiplatform.v1beta1.TuningJob.state] is set
        /// to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob to cancel. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTuningJobAsync(TuningJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelTuningJobAsync(new CancelTuningJobRequest
            {
                TuningJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a TuningJob.
        /// Starts asynchronous cancellation on the TuningJob. The server makes a best
        /// effort to cancel the job, but success is not guaranteed. Clients can use
        /// [GenAiTuningService.GetTuningJob][google.cloud.aiplatform.v1beta1.GenAiTuningService.GetTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation, the
        /// TuningJob is not deleted; instead it becomes a job with a
        /// [TuningJob.error][google.cloud.aiplatform.v1beta1.TuningJob.error] value
        /// with a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`, and
        /// [TuningJob.state][google.cloud.aiplatform.v1beta1.TuningJob.state] is set
        /// to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TuningJob to cancel. Format:
        /// `projects/{project}/locations/{location}/tuningJobs/{tuning_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelTuningJobAsync(TuningJobName name, st::CancellationToken cancellationToken) =>
            CancelTuningJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GenAiTuningService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing GenAI Tuning Jobs.
    /// </remarks>
    public sealed partial class GenAiTuningServiceClientImpl : GenAiTuningServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateTuningJobRequest, TuningJob> _callCreateTuningJob;

        private readonly gaxgrpc::ApiCall<GetTuningJobRequest, TuningJob> _callGetTuningJob;

        private readonly gaxgrpc::ApiCall<ListTuningJobsRequest, ListTuningJobsResponse> _callListTuningJobs;

        private readonly gaxgrpc::ApiCall<CancelTuningJobRequest, wkt::Empty> _callCancelTuningJob;

        /// <summary>
        /// Constructs a client wrapper for the GenAiTuningService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GenAiTuningServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GenAiTuningServiceClientImpl(GenAiTuningService.GenAiTuningServiceClient grpcClient, GenAiTuningServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GenAiTuningServiceSettings effectiveSettings = settings ?? GenAiTuningServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateTuningJob = clientHelper.BuildApiCall<CreateTuningJobRequest, TuningJob>("CreateTuningJob", grpcClient.CreateTuningJobAsync, grpcClient.CreateTuningJob, effectiveSettings.CreateTuningJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTuningJob);
            Modify_CreateTuningJobApiCall(ref _callCreateTuningJob);
            _callGetTuningJob = clientHelper.BuildApiCall<GetTuningJobRequest, TuningJob>("GetTuningJob", grpcClient.GetTuningJobAsync, grpcClient.GetTuningJob, effectiveSettings.GetTuningJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTuningJob);
            Modify_GetTuningJobApiCall(ref _callGetTuningJob);
            _callListTuningJobs = clientHelper.BuildApiCall<ListTuningJobsRequest, ListTuningJobsResponse>("ListTuningJobs", grpcClient.ListTuningJobsAsync, grpcClient.ListTuningJobs, effectiveSettings.ListTuningJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTuningJobs);
            Modify_ListTuningJobsApiCall(ref _callListTuningJobs);
            _callCancelTuningJob = clientHelper.BuildApiCall<CancelTuningJobRequest, wkt::Empty>("CancelTuningJob", grpcClient.CancelTuningJobAsync, grpcClient.CancelTuningJob, effectiveSettings.CancelTuningJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelTuningJob);
            Modify_CancelTuningJobApiCall(ref _callCancelTuningJob);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateTuningJobApiCall(ref gaxgrpc::ApiCall<CreateTuningJobRequest, TuningJob> call);

        partial void Modify_GetTuningJobApiCall(ref gaxgrpc::ApiCall<GetTuningJobRequest, TuningJob> call);

        partial void Modify_ListTuningJobsApiCall(ref gaxgrpc::ApiCall<ListTuningJobsRequest, ListTuningJobsResponse> call);

        partial void Modify_CancelTuningJobApiCall(ref gaxgrpc::ApiCall<CancelTuningJobRequest, wkt::Empty> call);

        partial void OnConstruction(GenAiTuningService.GenAiTuningServiceClient grpcClient, GenAiTuningServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GenAiTuningService client</summary>
        public override GenAiTuningService.GenAiTuningServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateTuningJobRequest(ref CreateTuningJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTuningJobRequest(ref GetTuningJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTuningJobsRequest(ref ListTuningJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelTuningJobRequest(ref CancelTuningJobRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a TuningJob. A created TuningJob right away will be attempted to
        /// be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TuningJob CreateTuningJob(CreateTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTuningJobRequest(ref request, ref callSettings);
            return _callCreateTuningJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a TuningJob. A created TuningJob right away will be attempted to
        /// be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TuningJob> CreateTuningJobAsync(CreateTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTuningJobRequest(ref request, ref callSettings);
            return _callCreateTuningJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a TuningJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TuningJob GetTuningJob(GetTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTuningJobRequest(ref request, ref callSettings);
            return _callGetTuningJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a TuningJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TuningJob> GetTuningJobAsync(GetTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTuningJobRequest(ref request, ref callSettings);
            return _callGetTuningJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists TuningJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TuningJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListTuningJobsResponse, TuningJob> ListTuningJobs(ListTuningJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTuningJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTuningJobsRequest, ListTuningJobsResponse, TuningJob>(_callListTuningJobs, request, callSettings);
        }

        /// <summary>
        /// Lists TuningJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TuningJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTuningJobsResponse, TuningJob> ListTuningJobsAsync(ListTuningJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTuningJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTuningJobsRequest, ListTuningJobsResponse, TuningJob>(_callListTuningJobs, request, callSettings);
        }

        /// <summary>
        /// Cancels a TuningJob.
        /// Starts asynchronous cancellation on the TuningJob. The server makes a best
        /// effort to cancel the job, but success is not guaranteed. Clients can use
        /// [GenAiTuningService.GetTuningJob][google.cloud.aiplatform.v1beta1.GenAiTuningService.GetTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation, the
        /// TuningJob is not deleted; instead it becomes a job with a
        /// [TuningJob.error][google.cloud.aiplatform.v1beta1.TuningJob.error] value
        /// with a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`, and
        /// [TuningJob.state][google.cloud.aiplatform.v1beta1.TuningJob.state] is set
        /// to `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelTuningJob(CancelTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelTuningJobRequest(ref request, ref callSettings);
            _callCancelTuningJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a TuningJob.
        /// Starts asynchronous cancellation on the TuningJob. The server makes a best
        /// effort to cancel the job, but success is not guaranteed. Clients can use
        /// [GenAiTuningService.GetTuningJob][google.cloud.aiplatform.v1beta1.GenAiTuningService.GetTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation, the
        /// TuningJob is not deleted; instead it becomes a job with a
        /// [TuningJob.error][google.cloud.aiplatform.v1beta1.TuningJob.error] value
        /// with a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding
        /// to `Code.CANCELLED`, and
        /// [TuningJob.state][google.cloud.aiplatform.v1beta1.TuningJob.state] is set
        /// to `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelTuningJobAsync(CancelTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelTuningJobRequest(ref request, ref callSettings);
            return _callCancelTuningJob.Async(request, callSettings);
        }
    }

    public partial class ListTuningJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTuningJobsResponse : gaxgrpc::IPageResponse<TuningJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TuningJob> GetEnumerator() => TuningJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class GenAiTuningService
    {
        public partial class GenAiTuningServiceClient
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
