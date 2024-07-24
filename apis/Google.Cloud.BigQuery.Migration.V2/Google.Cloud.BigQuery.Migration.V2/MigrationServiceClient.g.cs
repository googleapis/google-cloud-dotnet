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

namespace Google.Cloud.BigQuery.Migration.V2
{
    /// <summary>Settings for <see cref="MigrationServiceClient"/> instances.</summary>
    public sealed partial class MigrationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MigrationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MigrationServiceSettings"/>.</returns>
        public static MigrationServiceSettings GetDefault() => new MigrationServiceSettings();

        /// <summary>Constructs a new <see cref="MigrationServiceSettings"/> object with default settings.</summary>
        public MigrationServiceSettings()
        {
        }

        private MigrationServiceSettings(MigrationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateMigrationWorkflowSettings = existing.CreateMigrationWorkflowSettings;
            GetMigrationWorkflowSettings = existing.GetMigrationWorkflowSettings;
            ListMigrationWorkflowsSettings = existing.ListMigrationWorkflowsSettings;
            DeleteMigrationWorkflowSettings = existing.DeleteMigrationWorkflowSettings;
            StartMigrationWorkflowSettings = existing.StartMigrationWorkflowSettings;
            GetMigrationSubtaskSettings = existing.GetMigrationSubtaskSettings;
            ListMigrationSubtasksSettings = existing.ListMigrationSubtasksSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MigrationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationServiceClient.CreateMigrationWorkflow</c> and
        /// <c>MigrationServiceClient.CreateMigrationWorkflowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMigrationWorkflowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationServiceClient.GetMigrationWorkflow</c> and <c>MigrationServiceClient.GetMigrationWorkflowAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMigrationWorkflowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationServiceClient.ListMigrationWorkflows</c> and
        /// <c>MigrationServiceClient.ListMigrationWorkflowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMigrationWorkflowsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationServiceClient.DeleteMigrationWorkflow</c> and
        /// <c>MigrationServiceClient.DeleteMigrationWorkflowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMigrationWorkflowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationServiceClient.StartMigrationWorkflow</c> and
        /// <c>MigrationServiceClient.StartMigrationWorkflowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartMigrationWorkflowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationServiceClient.GetMigrationSubtask</c> and <c>MigrationServiceClient.GetMigrationSubtaskAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMigrationSubtaskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationServiceClient.ListMigrationSubtasks</c> and <c>MigrationServiceClient.ListMigrationSubtasksAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMigrationSubtasksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MigrationServiceSettings"/> object.</returns>
        public MigrationServiceSettings Clone() => new MigrationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MigrationServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MigrationServiceClientBuilder : gaxgrpc::ClientBuilderBase<MigrationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MigrationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MigrationServiceClientBuilder() : base(MigrationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MigrationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MigrationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MigrationServiceClient Build()
        {
            MigrationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MigrationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MigrationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MigrationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MigrationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MigrationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MigrationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MigrationServiceClient.ChannelPool;
    }

    /// <summary>MigrationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to handle EDW migrations.
    /// </remarks>
    public abstract partial class MigrationServiceClient
    {
        /// <summary>
        /// The default endpoint for the MigrationService service, which is a host of "bigquerymigration.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "bigquerymigration.googleapis.com:443";

        /// <summary>The default MigrationService scopes.</summary>
        /// <remarks>
        /// The default MigrationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MigrationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MigrationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MigrationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MigrationServiceClient"/>.</returns>
        public static stt::Task<MigrationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MigrationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MigrationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MigrationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MigrationServiceClient"/>.</returns>
        public static MigrationServiceClient Create() => new MigrationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MigrationServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MigrationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MigrationServiceClient"/>.</returns>
        internal static MigrationServiceClient Create(grpccore::CallInvoker callInvoker, MigrationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MigrationService.MigrationServiceClient grpcClient = new MigrationService.MigrationServiceClient(callInvoker);
            return new MigrationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MigrationService client</summary>
        public virtual MigrationService.MigrationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationWorkflow CreateMigrationWorkflow(CreateMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> CreateMigrationWorkflowAsync(CreateMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> CreateMigrationWorkflowAsync(CreateMigrationWorkflowRequest request, st::CancellationToken cancellationToken) =>
            CreateMigrationWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a migration workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to which this migration workflow belongs.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="migrationWorkflow">
        /// Required. The migration workflow to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationWorkflow CreateMigrationWorkflow(string parent, MigrationWorkflow migrationWorkflow, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationWorkflow(new CreateMigrationWorkflowRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MigrationWorkflow = gax::GaxPreconditions.CheckNotNull(migrationWorkflow, nameof(migrationWorkflow)),
            }, callSettings);

        /// <summary>
        /// Creates a migration workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to which this migration workflow belongs.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="migrationWorkflow">
        /// Required. The migration workflow to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> CreateMigrationWorkflowAsync(string parent, MigrationWorkflow migrationWorkflow, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationWorkflowAsync(new CreateMigrationWorkflowRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MigrationWorkflow = gax::GaxPreconditions.CheckNotNull(migrationWorkflow, nameof(migrationWorkflow)),
            }, callSettings);

        /// <summary>
        /// Creates a migration workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to which this migration workflow belongs.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="migrationWorkflow">
        /// Required. The migration workflow to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> CreateMigrationWorkflowAsync(string parent, MigrationWorkflow migrationWorkflow, st::CancellationToken cancellationToken) =>
            CreateMigrationWorkflowAsync(parent, migrationWorkflow, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a migration workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to which this migration workflow belongs.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="migrationWorkflow">
        /// Required. The migration workflow to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationWorkflow CreateMigrationWorkflow(gagr::LocationName parent, MigrationWorkflow migrationWorkflow, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationWorkflow(new CreateMigrationWorkflowRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MigrationWorkflow = gax::GaxPreconditions.CheckNotNull(migrationWorkflow, nameof(migrationWorkflow)),
            }, callSettings);

        /// <summary>
        /// Creates a migration workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to which this migration workflow belongs.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="migrationWorkflow">
        /// Required. The migration workflow to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> CreateMigrationWorkflowAsync(gagr::LocationName parent, MigrationWorkflow migrationWorkflow, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigrationWorkflowAsync(new CreateMigrationWorkflowRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MigrationWorkflow = gax::GaxPreconditions.CheckNotNull(migrationWorkflow, nameof(migrationWorkflow)),
            }, callSettings);

        /// <summary>
        /// Creates a migration workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project to which this migration workflow belongs.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="migrationWorkflow">
        /// Required. The migration workflow to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> CreateMigrationWorkflowAsync(gagr::LocationName parent, MigrationWorkflow migrationWorkflow, st::CancellationToken cancellationToken) =>
            CreateMigrationWorkflowAsync(parent, migrationWorkflow, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a previously created migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationWorkflow GetMigrationWorkflow(GetMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a previously created migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> GetMigrationWorkflowAsync(GetMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a previously created migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> GetMigrationWorkflowAsync(GetMigrationWorkflowRequest request, st::CancellationToken cancellationToken) =>
            GetMigrationWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a previously created migration workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationWorkflow GetMigrationWorkflow(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationWorkflow(new GetMigrationWorkflowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created migration workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> GetMigrationWorkflowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationWorkflowAsync(new GetMigrationWorkflowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created migration workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> GetMigrationWorkflowAsync(string name, st::CancellationToken cancellationToken) =>
            GetMigrationWorkflowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a previously created migration workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationWorkflow GetMigrationWorkflow(MigrationWorkflowName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationWorkflow(new GetMigrationWorkflowRequest
            {
                MigrationWorkflowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created migration workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> GetMigrationWorkflowAsync(MigrationWorkflowName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationWorkflowAsync(new GetMigrationWorkflowRequest
            {
                MigrationWorkflowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created migration workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationWorkflow> GetMigrationWorkflowAsync(MigrationWorkflowName name, st::CancellationToken cancellationToken) =>
            GetMigrationWorkflowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists previously created migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigrationWorkflow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> ListMigrationWorkflows(ListMigrationWorkflowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists previously created migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationWorkflow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> ListMigrationWorkflowsAsync(ListMigrationWorkflowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists previously created migration workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of the migration workflows to list.
        /// Example: `projects/123/locations/us`
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
        /// <returns>A pageable sequence of <see cref="MigrationWorkflow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> ListMigrationWorkflows(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationWorkflowsRequest request = new ListMigrationWorkflowsRequest
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
            return ListMigrationWorkflows(request, callSettings);
        }

        /// <summary>
        /// Lists previously created migration workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of the migration workflows to list.
        /// Example: `projects/123/locations/us`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationWorkflow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> ListMigrationWorkflowsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationWorkflowsRequest request = new ListMigrationWorkflowsRequest
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
            return ListMigrationWorkflowsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists previously created migration workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of the migration workflows to list.
        /// Example: `projects/123/locations/us`
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
        /// <returns>A pageable sequence of <see cref="MigrationWorkflow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> ListMigrationWorkflows(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationWorkflowsRequest request = new ListMigrationWorkflowsRequest
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
            return ListMigrationWorkflows(request, callSettings);
        }

        /// <summary>
        /// Lists previously created migration workflow.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of the migration workflows to list.
        /// Example: `projects/123/locations/us`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationWorkflow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> ListMigrationWorkflowsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationWorkflowsRequest request = new ListMigrationWorkflowsRequest
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
            return ListMigrationWorkflowsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a migration workflow by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMigrationWorkflow(DeleteMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a migration workflow by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMigrationWorkflowAsync(DeleteMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a migration workflow by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMigrationWorkflowAsync(DeleteMigrationWorkflowRequest request, st::CancellationToken cancellationToken) =>
            DeleteMigrationWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a migration workflow by name.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMigrationWorkflow(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationWorkflow(new DeleteMigrationWorkflowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a migration workflow by name.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMigrationWorkflowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationWorkflowAsync(new DeleteMigrationWorkflowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a migration workflow by name.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMigrationWorkflowAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMigrationWorkflowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a migration workflow by name.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMigrationWorkflow(MigrationWorkflowName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationWorkflow(new DeleteMigrationWorkflowRequest
            {
                MigrationWorkflowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a migration workflow by name.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMigrationWorkflowAsync(MigrationWorkflowName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigrationWorkflowAsync(new DeleteMigrationWorkflowRequest
            {
                MigrationWorkflowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a migration workflow by name.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMigrationWorkflowAsync(MigrationWorkflowName name, st::CancellationToken cancellationToken) =>
            DeleteMigrationWorkflowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a previously created migration workflow. I.e., the state transitions
        /// from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
        /// An error will be signaled if the state is anything other than DRAFT or
        /// RUNNING.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void StartMigrationWorkflow(StartMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a previously created migration workflow. I.e., the state transitions
        /// from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
        /// An error will be signaled if the state is anything other than DRAFT or
        /// RUNNING.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task StartMigrationWorkflowAsync(StartMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a previously created migration workflow. I.e., the state transitions
        /// from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
        /// An error will be signaled if the state is anything other than DRAFT or
        /// RUNNING.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task StartMigrationWorkflowAsync(StartMigrationWorkflowRequest request, st::CancellationToken cancellationToken) =>
            StartMigrationWorkflowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a previously created migration workflow. I.e., the state transitions
        /// from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
        /// An error will be signaled if the state is anything other than DRAFT or
        /// RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void StartMigrationWorkflow(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartMigrationWorkflow(new StartMigrationWorkflowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a previously created migration workflow. I.e., the state transitions
        /// from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
        /// An error will be signaled if the state is anything other than DRAFT or
        /// RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task StartMigrationWorkflowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartMigrationWorkflowAsync(new StartMigrationWorkflowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a previously created migration workflow. I.e., the state transitions
        /// from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
        /// An error will be signaled if the state is anything other than DRAFT or
        /// RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task StartMigrationWorkflowAsync(string name, st::CancellationToken cancellationToken) =>
            StartMigrationWorkflowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a previously created migration workflow. I.e., the state transitions
        /// from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
        /// An error will be signaled if the state is anything other than DRAFT or
        /// RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void StartMigrationWorkflow(MigrationWorkflowName name, gaxgrpc::CallSettings callSettings = null) =>
            StartMigrationWorkflow(new StartMigrationWorkflowRequest
            {
                MigrationWorkflowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a previously created migration workflow. I.e., the state transitions
        /// from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
        /// An error will be signaled if the state is anything other than DRAFT or
        /// RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task StartMigrationWorkflowAsync(MigrationWorkflowName name, gaxgrpc::CallSettings callSettings = null) =>
            StartMigrationWorkflowAsync(new StartMigrationWorkflowRequest
            {
                MigrationWorkflowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts a previously created migration workflow. I.e., the state transitions
        /// from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
        /// An error will be signaled if the state is anything other than DRAFT or
        /// RUNNING.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration workflow.
        /// Example: `projects/123/locations/us/workflows/1234`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task StartMigrationWorkflowAsync(MigrationWorkflowName name, st::CancellationToken cancellationToken) =>
            StartMigrationWorkflowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a previously created migration subtask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationSubtask GetMigrationSubtask(GetMigrationSubtaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a previously created migration subtask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationSubtask> GetMigrationSubtaskAsync(GetMigrationSubtaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a previously created migration subtask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationSubtask> GetMigrationSubtaskAsync(GetMigrationSubtaskRequest request, st::CancellationToken cancellationToken) =>
            GetMigrationSubtaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a previously created migration subtask.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration subtask.
        /// Example: `projects/123/locations/us/workflows/1234/subtasks/543`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationSubtask GetMigrationSubtask(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationSubtask(new GetMigrationSubtaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created migration subtask.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration subtask.
        /// Example: `projects/123/locations/us/workflows/1234/subtasks/543`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationSubtask> GetMigrationSubtaskAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationSubtaskAsync(new GetMigrationSubtaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created migration subtask.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration subtask.
        /// Example: `projects/123/locations/us/workflows/1234/subtasks/543`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationSubtask> GetMigrationSubtaskAsync(string name, st::CancellationToken cancellationToken) =>
            GetMigrationSubtaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a previously created migration subtask.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration subtask.
        /// Example: `projects/123/locations/us/workflows/1234/subtasks/543`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigrationSubtask GetMigrationSubtask(MigrationSubtaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationSubtask(new GetMigrationSubtaskRequest
            {
                MigrationSubtaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created migration subtask.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration subtask.
        /// Example: `projects/123/locations/us/workflows/1234/subtasks/543`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationSubtask> GetMigrationSubtaskAsync(MigrationSubtaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigrationSubtaskAsync(new GetMigrationSubtaskRequest
            {
                MigrationSubtaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created migration subtask.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the migration subtask.
        /// Example: `projects/123/locations/us/workflows/1234/subtasks/543`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigrationSubtask> GetMigrationSubtaskAsync(MigrationSubtaskName name, st::CancellationToken cancellationToken) =>
            GetMigrationSubtaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists previously created migration subtasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigrationSubtask"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> ListMigrationSubtasks(ListMigrationSubtasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists previously created migration subtasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationSubtask"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> ListMigrationSubtasksAsync(ListMigrationSubtasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists previously created migration subtasks.
        /// </summary>
        /// <param name="parent">
        /// Required. The migration task of the subtasks to list.
        /// Example: `projects/123/locations/us/workflows/1234`
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
        /// <returns>A pageable sequence of <see cref="MigrationSubtask"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> ListMigrationSubtasks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationSubtasksRequest request = new ListMigrationSubtasksRequest
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
            return ListMigrationSubtasks(request, callSettings);
        }

        /// <summary>
        /// Lists previously created migration subtasks.
        /// </summary>
        /// <param name="parent">
        /// Required. The migration task of the subtasks to list.
        /// Example: `projects/123/locations/us/workflows/1234`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationSubtask"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> ListMigrationSubtasksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationSubtasksRequest request = new ListMigrationSubtasksRequest
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
            return ListMigrationSubtasksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists previously created migration subtasks.
        /// </summary>
        /// <param name="parent">
        /// Required. The migration task of the subtasks to list.
        /// Example: `projects/123/locations/us/workflows/1234`
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
        /// <returns>A pageable sequence of <see cref="MigrationSubtask"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> ListMigrationSubtasks(MigrationWorkflowName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationSubtasksRequest request = new ListMigrationSubtasksRequest
            {
                ParentAsMigrationWorkflowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMigrationSubtasks(request, callSettings);
        }

        /// <summary>
        /// Lists previously created migration subtasks.
        /// </summary>
        /// <param name="parent">
        /// Required. The migration task of the subtasks to list.
        /// Example: `projects/123/locations/us/workflows/1234`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationSubtask"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> ListMigrationSubtasksAsync(MigrationWorkflowName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigrationSubtasksRequest request = new ListMigrationSubtasksRequest
            {
                ParentAsMigrationWorkflowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMigrationSubtasksAsync(request, callSettings);
        }
    }

    /// <summary>MigrationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to handle EDW migrations.
    /// </remarks>
    public sealed partial class MigrationServiceClientImpl : MigrationServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateMigrationWorkflowRequest, MigrationWorkflow> _callCreateMigrationWorkflow;

        private readonly gaxgrpc::ApiCall<GetMigrationWorkflowRequest, MigrationWorkflow> _callGetMigrationWorkflow;

        private readonly gaxgrpc::ApiCall<ListMigrationWorkflowsRequest, ListMigrationWorkflowsResponse> _callListMigrationWorkflows;

        private readonly gaxgrpc::ApiCall<DeleteMigrationWorkflowRequest, wkt::Empty> _callDeleteMigrationWorkflow;

        private readonly gaxgrpc::ApiCall<StartMigrationWorkflowRequest, wkt::Empty> _callStartMigrationWorkflow;

        private readonly gaxgrpc::ApiCall<GetMigrationSubtaskRequest, MigrationSubtask> _callGetMigrationSubtask;

        private readonly gaxgrpc::ApiCall<ListMigrationSubtasksRequest, ListMigrationSubtasksResponse> _callListMigrationSubtasks;

        /// <summary>
        /// Constructs a client wrapper for the MigrationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MigrationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MigrationServiceClientImpl(MigrationService.MigrationServiceClient grpcClient, MigrationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MigrationServiceSettings effectiveSettings = settings ?? MigrationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateMigrationWorkflow = clientHelper.BuildApiCall<CreateMigrationWorkflowRequest, MigrationWorkflow>("CreateMigrationWorkflow", grpcClient.CreateMigrationWorkflowAsync, grpcClient.CreateMigrationWorkflow, effectiveSettings.CreateMigrationWorkflowSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMigrationWorkflow);
            Modify_CreateMigrationWorkflowApiCall(ref _callCreateMigrationWorkflow);
            _callGetMigrationWorkflow = clientHelper.BuildApiCall<GetMigrationWorkflowRequest, MigrationWorkflow>("GetMigrationWorkflow", grpcClient.GetMigrationWorkflowAsync, grpcClient.GetMigrationWorkflow, effectiveSettings.GetMigrationWorkflowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMigrationWorkflow);
            Modify_GetMigrationWorkflowApiCall(ref _callGetMigrationWorkflow);
            _callListMigrationWorkflows = clientHelper.BuildApiCall<ListMigrationWorkflowsRequest, ListMigrationWorkflowsResponse>("ListMigrationWorkflows", grpcClient.ListMigrationWorkflowsAsync, grpcClient.ListMigrationWorkflows, effectiveSettings.ListMigrationWorkflowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMigrationWorkflows);
            Modify_ListMigrationWorkflowsApiCall(ref _callListMigrationWorkflows);
            _callDeleteMigrationWorkflow = clientHelper.BuildApiCall<DeleteMigrationWorkflowRequest, wkt::Empty>("DeleteMigrationWorkflow", grpcClient.DeleteMigrationWorkflowAsync, grpcClient.DeleteMigrationWorkflow, effectiveSettings.DeleteMigrationWorkflowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMigrationWorkflow);
            Modify_DeleteMigrationWorkflowApiCall(ref _callDeleteMigrationWorkflow);
            _callStartMigrationWorkflow = clientHelper.BuildApiCall<StartMigrationWorkflowRequest, wkt::Empty>("StartMigrationWorkflow", grpcClient.StartMigrationWorkflowAsync, grpcClient.StartMigrationWorkflow, effectiveSettings.StartMigrationWorkflowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartMigrationWorkflow);
            Modify_StartMigrationWorkflowApiCall(ref _callStartMigrationWorkflow);
            _callGetMigrationSubtask = clientHelper.BuildApiCall<GetMigrationSubtaskRequest, MigrationSubtask>("GetMigrationSubtask", grpcClient.GetMigrationSubtaskAsync, grpcClient.GetMigrationSubtask, effectiveSettings.GetMigrationSubtaskSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMigrationSubtask);
            Modify_GetMigrationSubtaskApiCall(ref _callGetMigrationSubtask);
            _callListMigrationSubtasks = clientHelper.BuildApiCall<ListMigrationSubtasksRequest, ListMigrationSubtasksResponse>("ListMigrationSubtasks", grpcClient.ListMigrationSubtasksAsync, grpcClient.ListMigrationSubtasks, effectiveSettings.ListMigrationSubtasksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMigrationSubtasks);
            Modify_ListMigrationSubtasksApiCall(ref _callListMigrationSubtasks);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateMigrationWorkflowApiCall(ref gaxgrpc::ApiCall<CreateMigrationWorkflowRequest, MigrationWorkflow> call);

        partial void Modify_GetMigrationWorkflowApiCall(ref gaxgrpc::ApiCall<GetMigrationWorkflowRequest, MigrationWorkflow> call);

        partial void Modify_ListMigrationWorkflowsApiCall(ref gaxgrpc::ApiCall<ListMigrationWorkflowsRequest, ListMigrationWorkflowsResponse> call);

        partial void Modify_DeleteMigrationWorkflowApiCall(ref gaxgrpc::ApiCall<DeleteMigrationWorkflowRequest, wkt::Empty> call);

        partial void Modify_StartMigrationWorkflowApiCall(ref gaxgrpc::ApiCall<StartMigrationWorkflowRequest, wkt::Empty> call);

        partial void Modify_GetMigrationSubtaskApiCall(ref gaxgrpc::ApiCall<GetMigrationSubtaskRequest, MigrationSubtask> call);

        partial void Modify_ListMigrationSubtasksApiCall(ref gaxgrpc::ApiCall<ListMigrationSubtasksRequest, ListMigrationSubtasksResponse> call);

        partial void OnConstruction(MigrationService.MigrationServiceClient grpcClient, MigrationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MigrationService client</summary>
        public override MigrationService.MigrationServiceClient GrpcClient { get; }

        partial void Modify_CreateMigrationWorkflowRequest(ref CreateMigrationWorkflowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMigrationWorkflowRequest(ref GetMigrationWorkflowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMigrationWorkflowsRequest(ref ListMigrationWorkflowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMigrationWorkflowRequest(ref DeleteMigrationWorkflowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartMigrationWorkflowRequest(ref StartMigrationWorkflowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMigrationSubtaskRequest(ref GetMigrationSubtaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMigrationSubtasksRequest(ref ListMigrationSubtasksRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MigrationWorkflow CreateMigrationWorkflow(CreateMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMigrationWorkflowRequest(ref request, ref callSettings);
            return _callCreateMigrationWorkflow.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MigrationWorkflow> CreateMigrationWorkflowAsync(CreateMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMigrationWorkflowRequest(ref request, ref callSettings);
            return _callCreateMigrationWorkflow.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a previously created migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MigrationWorkflow GetMigrationWorkflow(GetMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMigrationWorkflowRequest(ref request, ref callSettings);
            return _callGetMigrationWorkflow.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a previously created migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MigrationWorkflow> GetMigrationWorkflowAsync(GetMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMigrationWorkflowRequest(ref request, ref callSettings);
            return _callGetMigrationWorkflow.Async(request, callSettings);
        }

        /// <summary>
        /// Lists previously created migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigrationWorkflow"/> resources.</returns>
        public override gax::PagedEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> ListMigrationWorkflows(ListMigrationWorkflowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMigrationWorkflowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMigrationWorkflowsRequest, ListMigrationWorkflowsResponse, MigrationWorkflow>(_callListMigrationWorkflows, request, callSettings);
        }

        /// <summary>
        /// Lists previously created migration workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationWorkflow"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMigrationWorkflowsResponse, MigrationWorkflow> ListMigrationWorkflowsAsync(ListMigrationWorkflowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMigrationWorkflowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMigrationWorkflowsRequest, ListMigrationWorkflowsResponse, MigrationWorkflow>(_callListMigrationWorkflows, request, callSettings);
        }

        /// <summary>
        /// Deletes a migration workflow by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteMigrationWorkflow(DeleteMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMigrationWorkflowRequest(ref request, ref callSettings);
            _callDeleteMigrationWorkflow.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a migration workflow by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteMigrationWorkflowAsync(DeleteMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMigrationWorkflowRequest(ref request, ref callSettings);
            return _callDeleteMigrationWorkflow.Async(request, callSettings);
        }

        /// <summary>
        /// Starts a previously created migration workflow. I.e., the state transitions
        /// from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
        /// An error will be signaled if the state is anything other than DRAFT or
        /// RUNNING.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void StartMigrationWorkflow(StartMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMigrationWorkflowRequest(ref request, ref callSettings);
            _callStartMigrationWorkflow.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts a previously created migration workflow. I.e., the state transitions
        /// from DRAFT to RUNNING. This is a no-op if the state is already RUNNING.
        /// An error will be signaled if the state is anything other than DRAFT or
        /// RUNNING.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task StartMigrationWorkflowAsync(StartMigrationWorkflowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMigrationWorkflowRequest(ref request, ref callSettings);
            return _callStartMigrationWorkflow.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a previously created migration subtask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MigrationSubtask GetMigrationSubtask(GetMigrationSubtaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMigrationSubtaskRequest(ref request, ref callSettings);
            return _callGetMigrationSubtask.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a previously created migration subtask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MigrationSubtask> GetMigrationSubtaskAsync(GetMigrationSubtaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMigrationSubtaskRequest(ref request, ref callSettings);
            return _callGetMigrationSubtask.Async(request, callSettings);
        }

        /// <summary>
        /// Lists previously created migration subtasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigrationSubtask"/> resources.</returns>
        public override gax::PagedEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> ListMigrationSubtasks(ListMigrationSubtasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMigrationSubtasksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMigrationSubtasksRequest, ListMigrationSubtasksResponse, MigrationSubtask>(_callListMigrationSubtasks, request, callSettings);
        }

        /// <summary>
        /// Lists previously created migration subtasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigrationSubtask"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMigrationSubtasksResponse, MigrationSubtask> ListMigrationSubtasksAsync(ListMigrationSubtasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMigrationSubtasksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMigrationSubtasksRequest, ListMigrationSubtasksResponse, MigrationSubtask>(_callListMigrationSubtasks, request, callSettings);
        }
    }

    public partial class ListMigrationWorkflowsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMigrationSubtasksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMigrationWorkflowsResponse : gaxgrpc::IPageResponse<MigrationWorkflow>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MigrationWorkflow> GetEnumerator() => MigrationWorkflows.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMigrationSubtasksResponse : gaxgrpc::IPageResponse<MigrationSubtask>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MigrationSubtask> GetEnumerator() => MigrationSubtasks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
