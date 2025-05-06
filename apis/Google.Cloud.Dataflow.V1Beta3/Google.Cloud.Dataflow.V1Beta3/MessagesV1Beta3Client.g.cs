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

namespace Google.Cloud.Dataflow.V1Beta3
{
    /// <summary>Settings for <see cref="MessagesV1Beta3Client"/> instances.</summary>
    public sealed partial class MessagesV1Beta3Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MessagesV1Beta3Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MessagesV1Beta3Settings"/>.</returns>
        public static MessagesV1Beta3Settings GetDefault() => new MessagesV1Beta3Settings();

        /// <summary>Constructs a new <see cref="MessagesV1Beta3Settings"/> object with default settings.</summary>
        public MessagesV1Beta3Settings()
        {
        }

        private MessagesV1Beta3Settings(MessagesV1Beta3Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListJobMessagesSettings = existing.ListJobMessagesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MessagesV1Beta3Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MessagesV1Beta3Client.ListJobMessages</c> and <c>MessagesV1Beta3Client.ListJobMessagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListJobMessagesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MessagesV1Beta3Settings"/> object.</returns>
        public MessagesV1Beta3Settings Clone() => new MessagesV1Beta3Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MessagesV1Beta3Client"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MessagesV1Beta3ClientBuilder : gaxgrpc::ClientBuilderBase<MessagesV1Beta3Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MessagesV1Beta3Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MessagesV1Beta3ClientBuilder() : base(MessagesV1Beta3Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MessagesV1Beta3Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MessagesV1Beta3Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override MessagesV1Beta3Client Build()
        {
            MessagesV1Beta3Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MessagesV1Beta3Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MessagesV1Beta3Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MessagesV1Beta3Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MessagesV1Beta3Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MessagesV1Beta3Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MessagesV1Beta3Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MessagesV1Beta3Client.ChannelPool;
    }

    /// <summary>MessagesV1Beta3 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Dataflow Messages API is used for monitoring the progress of
    /// Dataflow jobs.
    /// </remarks>
    public abstract partial class MessagesV1Beta3Client
    {
        /// <summary>
        /// The default endpoint for the MessagesV1Beta3 service, which is a host of "dataflow.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataflow.googleapis.com:443";

        /// <summary>The default MessagesV1Beta3 scopes.</summary>
        /// <remarks>
        /// The default MessagesV1Beta3 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/compute",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MessagesV1Beta3.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MessagesV1Beta3Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MessagesV1Beta3ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MessagesV1Beta3Client"/>.</returns>
        public static stt::Task<MessagesV1Beta3Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MessagesV1Beta3ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MessagesV1Beta3Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MessagesV1Beta3ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MessagesV1Beta3Client"/>.</returns>
        public static MessagesV1Beta3Client Create() => new MessagesV1Beta3ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MessagesV1Beta3Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MessagesV1Beta3Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MessagesV1Beta3Client"/>.</returns>
        internal static MessagesV1Beta3Client Create(grpccore::CallInvoker callInvoker, MessagesV1Beta3Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MessagesV1Beta3.MessagesV1Beta3Client grpcClient = new MessagesV1Beta3.MessagesV1Beta3Client(callInvoker);
            return new MessagesV1Beta3ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MessagesV1Beta3 client</summary>
        public virtual MessagesV1Beta3.MessagesV1Beta3Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Request the job status.
        /// 
        /// To request the status of a job, we recommend using
        /// `projects.locations.jobs.messages.list` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.messages.list` is not recommended, as you can only request
        /// the status of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="JobMessage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobMessagesResponse, JobMessage> ListJobMessages(ListJobMessagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Request the job status.
        /// 
        /// To request the status of a job, we recommend using
        /// `projects.locations.jobs.messages.list` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.messages.list` is not recommended, as you can only request
        /// the status of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="JobMessage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobMessagesResponse, JobMessage> ListJobMessagesAsync(ListJobMessagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>MessagesV1Beta3 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Dataflow Messages API is used for monitoring the progress of
    /// Dataflow jobs.
    /// </remarks>
    public sealed partial class MessagesV1Beta3ClientImpl : MessagesV1Beta3Client
    {
        private readonly gaxgrpc::ApiCall<ListJobMessagesRequest, ListJobMessagesResponse> _callListJobMessages;

        /// <summary>
        /// Constructs a client wrapper for the MessagesV1Beta3 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MessagesV1Beta3Settings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MessagesV1Beta3ClientImpl(MessagesV1Beta3.MessagesV1Beta3Client grpcClient, MessagesV1Beta3Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MessagesV1Beta3Settings effectiveSettings = settings ?? MessagesV1Beta3Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListJobMessages = clientHelper.BuildApiCall<ListJobMessagesRequest, ListJobMessagesResponse>("ListJobMessages", grpcClient.ListJobMessagesAsync, grpcClient.ListJobMessages, effectiveSettings.ListJobMessagesSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location).WithGoogleRequestParam("job_id", request => request.JobId);
            Modify_ApiCall(ref _callListJobMessages);
            Modify_ListJobMessagesApiCall(ref _callListJobMessages);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListJobMessagesApiCall(ref gaxgrpc::ApiCall<ListJobMessagesRequest, ListJobMessagesResponse> call);

        partial void OnConstruction(MessagesV1Beta3.MessagesV1Beta3Client grpcClient, MessagesV1Beta3Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MessagesV1Beta3 client</summary>
        public override MessagesV1Beta3.MessagesV1Beta3Client GrpcClient { get; }

        partial void Modify_ListJobMessagesRequest(ref ListJobMessagesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Request the job status.
        /// 
        /// To request the status of a job, we recommend using
        /// `projects.locations.jobs.messages.list` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.messages.list` is not recommended, as you can only request
        /// the status of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="JobMessage"/> resources.</returns>
        public override gax::PagedEnumerable<ListJobMessagesResponse, JobMessage> ListJobMessages(ListJobMessagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobMessagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListJobMessagesRequest, ListJobMessagesResponse, JobMessage>(_callListJobMessages, request, callSettings);
        }

        /// <summary>
        /// Request the job status.
        /// 
        /// To request the status of a job, we recommend using
        /// `projects.locations.jobs.messages.list` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.messages.list` is not recommended, as you can only request
        /// the status of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="JobMessage"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListJobMessagesResponse, JobMessage> ListJobMessagesAsync(ListJobMessagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobMessagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListJobMessagesRequest, ListJobMessagesResponse, JobMessage>(_callListJobMessages, request, callSettings);
        }
    }

    public partial class ListJobMessagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListJobMessagesResponse : gaxgrpc::IPageResponse<JobMessage>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<JobMessage> GetEnumerator() => JobMessages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
