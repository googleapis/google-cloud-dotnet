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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
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

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Settings for <see cref="ExperimentsClient"/> instances.</summary>
    public sealed partial class ExperimentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ExperimentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ExperimentsSettings"/>.</returns>
        public static ExperimentsSettings GetDefault() => new ExperimentsSettings();

        /// <summary>Constructs a new <see cref="ExperimentsSettings"/> object with default settings.</summary>
        public ExperimentsSettings()
        {
        }

        private ExperimentsSettings(ExperimentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListExperimentsSettings = existing.ListExperimentsSettings;
            GetExperimentSettings = existing.GetExperimentSettings;
            CreateExperimentSettings = existing.CreateExperimentSettings;
            UpdateExperimentSettings = existing.UpdateExperimentSettings;
            DeleteExperimentSettings = existing.DeleteExperimentSettings;
            StartExperimentSettings = existing.StartExperimentSettings;
            StopExperimentSettings = existing.StopExperimentSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ExperimentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentsClient.ListExperiments</c> and <c>ExperimentsClient.ListExperimentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExperimentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentsClient.GetExperiment</c> and <c>ExperimentsClient.GetExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentsClient.CreateExperiment</c> and <c>ExperimentsClient.CreateExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentsClient.UpdateExperiment</c> and <c>ExperimentsClient.UpdateExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentsClient.DeleteExperiment</c> and <c>ExperimentsClient.DeleteExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentsClient.StartExperiment</c> and <c>ExperimentsClient.StartExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentsClient.StopExperiment</c> and <c>ExperimentsClient.StopExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ExperimentsSettings"/> object.</returns>
        public ExperimentsSettings Clone() => new ExperimentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExperimentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ExperimentsClientBuilder : gaxgrpc::ClientBuilderBase<ExperimentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ExperimentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ExperimentsClientBuilder() : base(ExperimentsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ExperimentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ExperimentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ExperimentsClient Build()
        {
            ExperimentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ExperimentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ExperimentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ExperimentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExperimentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ExperimentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExperimentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExperimentsClient.ChannelPool;
    }

    /// <summary>Experiments client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Experiments][google.cloud.dialogflow.cx.v3.Experiment].
    /// </remarks>
    public abstract partial class ExperimentsClient
    {
        /// <summary>
        /// The default endpoint for the Experiments service, which is a host of "dialogflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Experiments scopes.</summary>
        /// <remarks>
        /// The default Experiments scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Experiments.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ExperimentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ExperimentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ExperimentsClient"/>.</returns>
        public static stt::Task<ExperimentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ExperimentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ExperimentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ExperimentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ExperimentsClient"/>.</returns>
        public static ExperimentsClient Create() => new ExperimentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ExperimentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ExperimentsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ExperimentsClient"/>.</returns>
        internal static ExperimentsClient Create(grpccore::CallInvoker callInvoker, ExperimentsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Experiments.ExperimentsClient grpcClient = new Experiments.ExperimentsClient(callInvoker);
            return new ExperimentsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Experiments client</summary>
        public virtual Experiments.ExperimentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all experiments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Experiment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExperimentsResponse, Experiment> ListExperiments(ListExperimentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all experiments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Experiment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExperimentsResponse, Experiment> ListExperimentsAsync(ListExperimentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all experiments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Environment][google.cloud.dialogflow.cx.v3.Environment] to
        /// list all environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Experiment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExperimentsResponse, Experiment> ListExperiments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExperimentsRequest request = new ListExperimentsRequest
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
            return ListExperiments(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all experiments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Environment][google.cloud.dialogflow.cx.v3.Environment] to
        /// list all environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Experiment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExperimentsResponse, Experiment> ListExperimentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExperimentsRequest request = new ListExperimentsRequest
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
            return ListExperimentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all experiments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Environment][google.cloud.dialogflow.cx.v3.Environment] to
        /// list all environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Experiment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExperimentsResponse, Experiment> ListExperiments(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExperimentsRequest request = new ListExperimentsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExperiments(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all experiments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Environment][google.cloud.dialogflow.cx.v3.Environment] to
        /// list all environments for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Experiment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExperimentsResponse, Experiment> ListExperimentsAsync(EnvironmentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExperimentsRequest request = new ListExperimentsRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExperimentsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment GetExperiment(GetExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> GetExperimentAsync(GetExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> GetExperimentAsync(GetExperimentRequest request, st::CancellationToken cancellationToken) =>
            GetExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment GetExperiment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExperiment(new GetExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> GetExperimentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExperimentAsync(new GetExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> GetExperimentAsync(string name, st::CancellationToken cancellationToken) =>
            GetExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment GetExperiment(ExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExperiment(new GetExperimentRequest
            {
                ExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> GetExperimentAsync(ExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExperimentAsync(new GetExperimentRequest
            {
                ExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment]. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> GetExperimentAsync(ExperimentName name, st::CancellationToken cancellationToken) =>
            GetExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the
        /// specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment CreateExperiment(CreateExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the
        /// specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> CreateExperimentAsync(CreateExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the
        /// specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> CreateExperimentAsync(CreateExperimentRequest request, st::CancellationToken cancellationToken) =>
            CreateExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the
        /// specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="experiment">
        /// Required. The experiment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment CreateExperiment(string parent, Experiment experiment, gaxgrpc::CallSettings callSettings = null) =>
            CreateExperiment(new CreateExperimentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Experiment = gax::GaxPreconditions.CheckNotNull(experiment, nameof(experiment)),
            }, callSettings);

        /// <summary>
        /// Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the
        /// specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="experiment">
        /// Required. The experiment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> CreateExperimentAsync(string parent, Experiment experiment, gaxgrpc::CallSettings callSettings = null) =>
            CreateExperimentAsync(new CreateExperimentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Experiment = gax::GaxPreconditions.CheckNotNull(experiment, nameof(experiment)),
            }, callSettings);

        /// <summary>
        /// Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the
        /// specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="experiment">
        /// Required. The experiment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> CreateExperimentAsync(string parent, Experiment experiment, st::CancellationToken cancellationToken) =>
            CreateExperimentAsync(parent, experiment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the
        /// specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="experiment">
        /// Required. The experiment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment CreateExperiment(EnvironmentName parent, Experiment experiment, gaxgrpc::CallSettings callSettings = null) =>
            CreateExperiment(new CreateExperimentRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Experiment = gax::GaxPreconditions.CheckNotNull(experiment, nameof(experiment)),
            }, callSettings);

        /// <summary>
        /// Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the
        /// specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="experiment">
        /// Required. The experiment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> CreateExperimentAsync(EnvironmentName parent, Experiment experiment, gaxgrpc::CallSettings callSettings = null) =>
            CreateExperimentAsync(new CreateExperimentRequest
            {
                ParentAsEnvironmentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Experiment = gax::GaxPreconditions.CheckNotNull(experiment, nameof(experiment)),
            }, callSettings);

        /// <summary>
        /// Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the
        /// specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="parent">
        /// Required. The [Agent][google.cloud.dialogflow.cx.v3.Agent] to create an
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;`.
        /// </param>
        /// <param name="experiment">
        /// Required. The experiment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> CreateExperimentAsync(EnvironmentName parent, Experiment experiment, st::CancellationToken cancellationToken) =>
            CreateExperimentAsync(parent, experiment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment UpdateExperiment(UpdateExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> UpdateExperimentAsync(UpdateExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> UpdateExperimentAsync(UpdateExperimentRequest request, st::CancellationToken cancellationToken) =>
            UpdateExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="experiment">
        /// Required. The experiment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment UpdateExperiment(Experiment experiment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExperiment(new UpdateExperimentRequest
            {
                Experiment = gax::GaxPreconditions.CheckNotNull(experiment, nameof(experiment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="experiment">
        /// Required. The experiment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> UpdateExperimentAsync(Experiment experiment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExperimentAsync(new UpdateExperimentRequest
            {
                Experiment = gax::GaxPreconditions.CheckNotNull(experiment, nameof(experiment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="experiment">
        /// Required. The experiment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> UpdateExperimentAsync(Experiment experiment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExperimentAsync(experiment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExperiment(DeleteExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExperimentAsync(DeleteExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExperimentAsync(DeleteExperimentRequest request, st::CancellationToken cancellationToken) =>
            DeleteExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExperiment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExperiment(new DeleteExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExperimentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExperimentAsync(new DeleteExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExperimentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExperiment(ExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExperiment(new DeleteExperimentRequest
            {
                ExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExperimentAsync(ExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExperimentAsync(new DeleteExperimentRequest
            {
                ExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment] to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExperimentAsync(ExperimentName name, st::CancellationToken cancellationToken) =>
            DeleteExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only
        /// changes the state of experiment from PENDING to RUNNING.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment StartExperiment(StartExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only
        /// changes the state of experiment from PENDING to RUNNING.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StartExperimentAsync(StartExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only
        /// changes the state of experiment from PENDING to RUNNING.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StartExperimentAsync(StartExperimentRequest request, st::CancellationToken cancellationToken) =>
            StartExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only
        /// changes the state of experiment from PENDING to RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to start.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment StartExperiment(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartExperiment(new StartExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only
        /// changes the state of experiment from PENDING to RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to start.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StartExperimentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartExperimentAsync(new StartExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only
        /// changes the state of experiment from PENDING to RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to start.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StartExperimentAsync(string name, st::CancellationToken cancellationToken) =>
            StartExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only
        /// changes the state of experiment from PENDING to RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to start.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment StartExperiment(ExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            StartExperiment(new StartExperimentRequest
            {
                ExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only
        /// changes the state of experiment from PENDING to RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to start.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StartExperimentAsync(ExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            StartExperimentAsync(new StartExperimentRequest
            {
                ExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only
        /// changes the state of experiment from PENDING to RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to start.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StartExperimentAsync(ExperimentName name, st::CancellationToken cancellationToken) =>
            StartExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// This rpc only changes the state of experiment from RUNNING to DONE.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment StopExperiment(StopExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// This rpc only changes the state of experiment from RUNNING to DONE.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StopExperimentAsync(StopExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// This rpc only changes the state of experiment from RUNNING to DONE.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StopExperimentAsync(StopExperimentRequest request, st::CancellationToken cancellationToken) =>
            StopExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// This rpc only changes the state of experiment from RUNNING to DONE.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to stop.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment StopExperiment(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopExperiment(new StopExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// This rpc only changes the state of experiment from RUNNING to DONE.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to stop.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StopExperimentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopExperimentAsync(new StopExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// This rpc only changes the state of experiment from RUNNING to DONE.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to stop.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StopExperimentAsync(string name, st::CancellationToken cancellationToken) =>
            StopExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// This rpc only changes the state of experiment from RUNNING to DONE.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to stop.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Experiment StopExperiment(ExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            StopExperiment(new StopExperimentRequest
            {
                ExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// This rpc only changes the state of experiment from RUNNING to DONE.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to stop.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StopExperimentAsync(ExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            StopExperimentAsync(new StopExperimentRequest
            {
                ExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// This rpc only changes the state of experiment from RUNNING to DONE.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the experiment to stop.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/environments/&lt;EnvironmentID&gt;/experiments/&lt;ExperimentID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Experiment> StopExperimentAsync(ExperimentName name, st::CancellationToken cancellationToken) =>
            StopExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Experiments client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Experiments][google.cloud.dialogflow.cx.v3.Experiment].
    /// </remarks>
    public sealed partial class ExperimentsClientImpl : ExperimentsClient
    {
        private readonly gaxgrpc::ApiCall<ListExperimentsRequest, ListExperimentsResponse> _callListExperiments;

        private readonly gaxgrpc::ApiCall<GetExperimentRequest, Experiment> _callGetExperiment;

        private readonly gaxgrpc::ApiCall<CreateExperimentRequest, Experiment> _callCreateExperiment;

        private readonly gaxgrpc::ApiCall<UpdateExperimentRequest, Experiment> _callUpdateExperiment;

        private readonly gaxgrpc::ApiCall<DeleteExperimentRequest, wkt::Empty> _callDeleteExperiment;

        private readonly gaxgrpc::ApiCall<StartExperimentRequest, Experiment> _callStartExperiment;

        private readonly gaxgrpc::ApiCall<StopExperimentRequest, Experiment> _callStopExperiment;

        /// <summary>
        /// Constructs a client wrapper for the Experiments service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ExperimentsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ExperimentsClientImpl(Experiments.ExperimentsClient grpcClient, ExperimentsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ExperimentsSettings effectiveSettings = settings ?? ExperimentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListExperiments = clientHelper.BuildApiCall<ListExperimentsRequest, ListExperimentsResponse>("ListExperiments", grpcClient.ListExperimentsAsync, grpcClient.ListExperiments, effectiveSettings.ListExperimentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExperiments);
            Modify_ListExperimentsApiCall(ref _callListExperiments);
            _callGetExperiment = clientHelper.BuildApiCall<GetExperimentRequest, Experiment>("GetExperiment", grpcClient.GetExperimentAsync, grpcClient.GetExperiment, effectiveSettings.GetExperimentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExperiment);
            Modify_GetExperimentApiCall(ref _callGetExperiment);
            _callCreateExperiment = clientHelper.BuildApiCall<CreateExperimentRequest, Experiment>("CreateExperiment", grpcClient.CreateExperimentAsync, grpcClient.CreateExperiment, effectiveSettings.CreateExperimentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExperiment);
            Modify_CreateExperimentApiCall(ref _callCreateExperiment);
            _callUpdateExperiment = clientHelper.BuildApiCall<UpdateExperimentRequest, Experiment>("UpdateExperiment", grpcClient.UpdateExperimentAsync, grpcClient.UpdateExperiment, effectiveSettings.UpdateExperimentSettings).WithGoogleRequestParam("experiment.name", request => request.Experiment?.Name);
            Modify_ApiCall(ref _callUpdateExperiment);
            Modify_UpdateExperimentApiCall(ref _callUpdateExperiment);
            _callDeleteExperiment = clientHelper.BuildApiCall<DeleteExperimentRequest, wkt::Empty>("DeleteExperiment", grpcClient.DeleteExperimentAsync, grpcClient.DeleteExperiment, effectiveSettings.DeleteExperimentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExperiment);
            Modify_DeleteExperimentApiCall(ref _callDeleteExperiment);
            _callStartExperiment = clientHelper.BuildApiCall<StartExperimentRequest, Experiment>("StartExperiment", grpcClient.StartExperimentAsync, grpcClient.StartExperiment, effectiveSettings.StartExperimentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartExperiment);
            Modify_StartExperimentApiCall(ref _callStartExperiment);
            _callStopExperiment = clientHelper.BuildApiCall<StopExperimentRequest, Experiment>("StopExperiment", grpcClient.StopExperimentAsync, grpcClient.StopExperiment, effectiveSettings.StopExperimentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopExperiment);
            Modify_StopExperimentApiCall(ref _callStopExperiment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListExperimentsApiCall(ref gaxgrpc::ApiCall<ListExperimentsRequest, ListExperimentsResponse> call);

        partial void Modify_GetExperimentApiCall(ref gaxgrpc::ApiCall<GetExperimentRequest, Experiment> call);

        partial void Modify_CreateExperimentApiCall(ref gaxgrpc::ApiCall<CreateExperimentRequest, Experiment> call);

        partial void Modify_UpdateExperimentApiCall(ref gaxgrpc::ApiCall<UpdateExperimentRequest, Experiment> call);

        partial void Modify_DeleteExperimentApiCall(ref gaxgrpc::ApiCall<DeleteExperimentRequest, wkt::Empty> call);

        partial void Modify_StartExperimentApiCall(ref gaxgrpc::ApiCall<StartExperimentRequest, Experiment> call);

        partial void Modify_StopExperimentApiCall(ref gaxgrpc::ApiCall<StopExperimentRequest, Experiment> call);

        partial void OnConstruction(Experiments.ExperimentsClient grpcClient, ExperimentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Experiments client</summary>
        public override Experiments.ExperimentsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListExperimentsRequest(ref ListExperimentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExperimentRequest(ref GetExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateExperimentRequest(ref CreateExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExperimentRequest(ref UpdateExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExperimentRequest(ref DeleteExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartExperimentRequest(ref StartExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopExperimentRequest(ref StopExperimentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all experiments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Experiment"/> resources.</returns>
        public override gax::PagedEnumerable<ListExperimentsResponse, Experiment> ListExperiments(ListExperimentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExperimentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExperimentsRequest, ListExperimentsResponse, Experiment>(_callListExperiments, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all experiments in the specified
        /// [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Experiment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExperimentsResponse, Experiment> ListExperimentsAsync(ListExperimentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExperimentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExperimentsRequest, ListExperimentsResponse, Experiment>(_callListExperiments, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Experiment GetExperiment(GetExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExperimentRequest(ref request, ref callSettings);
            return _callGetExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Experiment> GetExperimentAsync(GetExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExperimentRequest(ref request, ref callSettings);
            return _callGetExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the
        /// specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Experiment CreateExperiment(CreateExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExperimentRequest(ref request, ref callSettings);
            return _callCreateExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an [Experiment][google.cloud.dialogflow.cx.v3.Experiment] in the
        /// specified [Environment][google.cloud.dialogflow.cx.v3.Environment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Experiment> CreateExperimentAsync(CreateExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExperimentRequest(ref request, ref callSettings);
            return _callCreateExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Experiment UpdateExperiment(UpdateExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExperimentRequest(ref request, ref callSettings);
            return _callUpdateExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Experiment> UpdateExperimentAsync(UpdateExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExperimentRequest(ref request, ref callSettings);
            return _callUpdateExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteExperiment(DeleteExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExperimentRequest(ref request, ref callSettings);
            _callDeleteExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteExperimentAsync(DeleteExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExperimentRequest(ref request, ref callSettings);
            return _callDeleteExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Starts the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only
        /// changes the state of experiment from PENDING to RUNNING.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Experiment StartExperiment(StartExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartExperimentRequest(ref request, ref callSettings);
            return _callStartExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts the specified
        /// [Experiment][google.cloud.dialogflow.cx.v3.Experiment]. This rpc only
        /// changes the state of experiment from PENDING to RUNNING.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Experiment> StartExperimentAsync(StartExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartExperimentRequest(ref request, ref callSettings);
            return _callStartExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// This rpc only changes the state of experiment from RUNNING to DONE.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Experiment StopExperiment(StopExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopExperimentRequest(ref request, ref callSettings);
            return _callStopExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Stops the specified [Experiment][google.cloud.dialogflow.cx.v3.Experiment].
        /// This rpc only changes the state of experiment from RUNNING to DONE.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Experiment> StopExperimentAsync(StopExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopExperimentRequest(ref request, ref callSettings);
            return _callStopExperiment.Async(request, callSettings);
        }
    }

    public partial class ListExperimentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExperimentsResponse : gaxgrpc::IPageResponse<Experiment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Experiment> GetEnumerator() => Experiments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Experiments
    {
        public partial class ExperimentsClient
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
