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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="ScheduleServiceClient"/> instances.</summary>
    public sealed partial class ScheduleServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ScheduleServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ScheduleServiceSettings"/>.</returns>
        public static ScheduleServiceSettings GetDefault() => new ScheduleServiceSettings();

        /// <summary>Constructs a new <see cref="ScheduleServiceSettings"/> object with default settings.</summary>
        public ScheduleServiceSettings()
        {
        }

        private ScheduleServiceSettings(ScheduleServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateScheduleSettings = existing.CreateScheduleSettings;
            DeleteScheduleSettings = existing.DeleteScheduleSettings;
            DeleteScheduleOperationsSettings = existing.DeleteScheduleOperationsSettings.Clone();
            GetScheduleSettings = existing.GetScheduleSettings;
            ListSchedulesSettings = existing.ListSchedulesSettings;
            PauseScheduleSettings = existing.PauseScheduleSettings;
            ResumeScheduleSettings = existing.ResumeScheduleSettings;
            UpdateScheduleSettings = existing.UpdateScheduleSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ScheduleServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ScheduleServiceClient.CreateSchedule</c> and <c>ScheduleServiceClient.CreateScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateScheduleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ScheduleServiceClient.DeleteSchedule</c> and <c>ScheduleServiceClient.DeleteScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteScheduleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ScheduleServiceClient.DeleteSchedule</c> and
        /// <c>ScheduleServiceClient.DeleteScheduleAsync</c>.
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
        public lro::OperationsSettings DeleteScheduleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ScheduleServiceClient.GetSchedule</c> and <c>ScheduleServiceClient.GetScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetScheduleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ScheduleServiceClient.ListSchedules</c> and <c>ScheduleServiceClient.ListSchedulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSchedulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ScheduleServiceClient.PauseSchedule</c> and <c>ScheduleServiceClient.PauseScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PauseScheduleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ScheduleServiceClient.ResumeSchedule</c> and <c>ScheduleServiceClient.ResumeScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeScheduleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ScheduleServiceClient.UpdateSchedule</c> and <c>ScheduleServiceClient.UpdateScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateScheduleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ScheduleServiceSettings"/> object.</returns>
        public ScheduleServiceSettings Clone() => new ScheduleServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ScheduleServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ScheduleServiceClientBuilder : gaxgrpc::ClientBuilderBase<ScheduleServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ScheduleServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ScheduleServiceClientBuilder() : base(ScheduleServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ScheduleServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ScheduleServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ScheduleServiceClient Build()
        {
            ScheduleServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ScheduleServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ScheduleServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ScheduleServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ScheduleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ScheduleServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ScheduleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ScheduleServiceClient.ChannelPool;
    }

    /// <summary>ScheduleService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Vertex AI's Schedule resources to
    /// periodically launch shceudled runs to make API calls.
    /// </remarks>
    public abstract partial class ScheduleServiceClient
    {
        /// <summary>
        /// The default endpoint for the ScheduleService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default ScheduleService scopes.</summary>
        /// <remarks>
        /// The default ScheduleService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ScheduleService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ScheduleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ScheduleServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ScheduleServiceClient"/>.</returns>
        public static stt::Task<ScheduleServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ScheduleServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ScheduleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ScheduleServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ScheduleServiceClient"/>.</returns>
        public static ScheduleServiceClient Create() => new ScheduleServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ScheduleServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ScheduleServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ScheduleServiceClient"/>.</returns>
        internal static ScheduleServiceClient Create(grpccore::CallInvoker callInvoker, ScheduleServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ScheduleService.ScheduleServiceClient grpcClient = new ScheduleService.ScheduleServiceClient(callInvoker);
            return new ScheduleServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ScheduleService client</summary>
        public virtual ScheduleService.ScheduleServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schedule CreateSchedule(CreateScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> CreateScheduleAsync(CreateScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> CreateScheduleAsync(CreateScheduleRequest request, st::CancellationToken cancellationToken) =>
            CreateScheduleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Schedule.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Schedule in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The Schedule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schedule CreateSchedule(string parent, Schedule schedule, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchedule(new CreateScheduleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Schedule = gax::GaxPreconditions.CheckNotNull(schedule, nameof(schedule)),
            }, callSettings);

        /// <summary>
        /// Creates a Schedule.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Schedule in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The Schedule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> CreateScheduleAsync(string parent, Schedule schedule, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduleAsync(new CreateScheduleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Schedule = gax::GaxPreconditions.CheckNotNull(schedule, nameof(schedule)),
            }, callSettings);

        /// <summary>
        /// Creates a Schedule.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Schedule in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The Schedule to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> CreateScheduleAsync(string parent, Schedule schedule, st::CancellationToken cancellationToken) =>
            CreateScheduleAsync(parent, schedule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Schedule.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Schedule in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The Schedule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schedule CreateSchedule(gagr::LocationName parent, Schedule schedule, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchedule(new CreateScheduleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Schedule = gax::GaxPreconditions.CheckNotNull(schedule, nameof(schedule)),
            }, callSettings);

        /// <summary>
        /// Creates a Schedule.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Schedule in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The Schedule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> CreateScheduleAsync(gagr::LocationName parent, Schedule schedule, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduleAsync(new CreateScheduleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Schedule = gax::GaxPreconditions.CheckNotNull(schedule, nameof(schedule)),
            }, callSettings);

        /// <summary>
        /// Creates a Schedule.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Schedule in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The Schedule to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> CreateScheduleAsync(gagr::LocationName parent, Schedule schedule, st::CancellationToken cancellationToken) =>
            CreateScheduleAsync(parent, schedule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSchedule(DeleteScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteScheduleAsync(DeleteScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteScheduleAsync(DeleteScheduleRequest request, st::CancellationToken cancellationToken) =>
            DeleteScheduleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSchedule</c>.</summary>
        public virtual lro::OperationsClient DeleteScheduleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSchedule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteSchedule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteScheduleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSchedule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteScheduleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteScheduleOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSchedule(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchedule(new DeleteScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteScheduleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScheduleAsync(new DeleteScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteScheduleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSchedule(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchedule(new DeleteScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteScheduleAsync(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScheduleAsync(new DeleteScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteScheduleAsync(ScheduleName name, st::CancellationToken cancellationToken) =>
            DeleteScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schedule GetSchedule(GetScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(GetScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(GetScheduleRequest request, st::CancellationToken cancellationToken) =>
            GetScheduleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schedule GetSchedule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchedule(new GetScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScheduleAsync(new GetScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(string name, st::CancellationToken cancellationToken) =>
            GetScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schedule GetSchedule(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchedule(new GetScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScheduleAsync(new GetScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Schedule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(ScheduleName name, st::CancellationToken cancellationToken) =>
            GetScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Schedules in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSchedulesResponse, Schedule> ListSchedules(ListSchedulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Schedules in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSchedulesResponse, Schedule> ListSchedulesAsync(ListSchedulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Schedules in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Schedules from.
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
        /// <returns>A pageable sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSchedulesResponse, Schedule> ListSchedules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchedulesRequest request = new ListSchedulesRequest
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
            return ListSchedules(request, callSettings);
        }

        /// <summary>
        /// Lists Schedules in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Schedules from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSchedulesResponse, Schedule> ListSchedulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchedulesRequest request = new ListSchedulesRequest
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
            return ListSchedulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Schedules in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Schedules from.
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
        /// <returns>A pageable sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSchedulesResponse, Schedule> ListSchedules(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchedulesRequest request = new ListSchedulesRequest
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
            return ListSchedules(request, callSettings);
        }

        /// <summary>
        /// Lists Schedules in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the Schedules from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSchedulesResponse, Schedule> ListSchedulesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchedulesRequest request = new ListSchedulesRequest
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
            return ListSchedulesAsync(request, callSettings);
        }

        /// <summary>
        /// Pauses a Schedule. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'PAUSED'. If
        /// the schedule is paused, no new runs will be created. Already created runs
        /// will NOT be paused or canceled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PauseSchedule(PauseScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a Schedule. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'PAUSED'. If
        /// the schedule is paused, no new runs will be created. Already created runs
        /// will NOT be paused or canceled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseScheduleAsync(PauseScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a Schedule. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'PAUSED'. If
        /// the schedule is paused, no new runs will be created. Already created runs
        /// will NOT be paused or canceled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseScheduleAsync(PauseScheduleRequest request, st::CancellationToken cancellationToken) =>
            PauseScheduleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a Schedule. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'PAUSED'. If
        /// the schedule is paused, no new runs will be created. Already created runs
        /// will NOT be paused or canceled.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be paused.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PauseSchedule(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseSchedule(new PauseScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a Schedule. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'PAUSED'. If
        /// the schedule is paused, no new runs will be created. Already created runs
        /// will NOT be paused or canceled.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be paused.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseScheduleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseScheduleAsync(new PauseScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a Schedule. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'PAUSED'. If
        /// the schedule is paused, no new runs will be created. Already created runs
        /// will NOT be paused or canceled.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be paused.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseScheduleAsync(string name, st::CancellationToken cancellationToken) =>
            PauseScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a Schedule. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'PAUSED'. If
        /// the schedule is paused, no new runs will be created. Already created runs
        /// will NOT be paused or canceled.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be paused.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PauseSchedule(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseSchedule(new PauseScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a Schedule. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'PAUSED'. If
        /// the schedule is paused, no new runs will be created. Already created runs
        /// will NOT be paused or canceled.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be paused.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseScheduleAsync(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseScheduleAsync(new PauseScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a Schedule. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'PAUSED'. If
        /// the schedule is paused, no new runs will be created. Already created runs
        /// will NOT be paused or canceled.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be paused.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseScheduleAsync(ScheduleName name, st::CancellationToken cancellationToken) =>
            PauseScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeSchedule(ResumeScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeScheduleAsync(ResumeScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeScheduleAsync(ResumeScheduleRequest request, st::CancellationToken cancellationToken) =>
            ResumeScheduleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeSchedule(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeSchedule(new ResumeScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeScheduleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeScheduleAsync(new ResumeScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeScheduleAsync(string name, st::CancellationToken cancellationToken) =>
            ResumeScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeSchedule(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeSchedule(new ResumeScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeScheduleAsync(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeScheduleAsync(new ResumeScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeScheduleAsync(ScheduleName name, st::CancellationToken cancellationToken) =>
            ResumeScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="catchUp">
        /// Optional. Whether to backfill missed runs when the schedule is resumed from
        /// PAUSED state. If set to true, all missed runs will be scheduled. New runs
        /// will be scheduled after the backfill is complete. This will also update
        /// [Schedule.catch_up][google.cloud.aiplatform.v1.Schedule.catch_up] field.
        /// Default to false.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeSchedule(string name, bool catchUp, gaxgrpc::CallSettings callSettings = null) =>
            ResumeSchedule(new ResumeScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                CatchUp = catchUp,
            }, callSettings);

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="catchUp">
        /// Optional. Whether to backfill missed runs when the schedule is resumed from
        /// PAUSED state. If set to true, all missed runs will be scheduled. New runs
        /// will be scheduled after the backfill is complete. This will also update
        /// [Schedule.catch_up][google.cloud.aiplatform.v1.Schedule.catch_up] field.
        /// Default to false.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeScheduleAsync(string name, bool catchUp, gaxgrpc::CallSettings callSettings = null) =>
            ResumeScheduleAsync(new ResumeScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                CatchUp = catchUp,
            }, callSettings);

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="catchUp">
        /// Optional. Whether to backfill missed runs when the schedule is resumed from
        /// PAUSED state. If set to true, all missed runs will be scheduled. New runs
        /// will be scheduled after the backfill is complete. This will also update
        /// [Schedule.catch_up][google.cloud.aiplatform.v1.Schedule.catch_up] field.
        /// Default to false.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeScheduleAsync(string name, bool catchUp, st::CancellationToken cancellationToken) =>
            ResumeScheduleAsync(name, catchUp, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="catchUp">
        /// Optional. Whether to backfill missed runs when the schedule is resumed from
        /// PAUSED state. If set to true, all missed runs will be scheduled. New runs
        /// will be scheduled after the backfill is complete. This will also update
        /// [Schedule.catch_up][google.cloud.aiplatform.v1.Schedule.catch_up] field.
        /// Default to false.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeSchedule(ScheduleName name, bool catchUp, gaxgrpc::CallSettings callSettings = null) =>
            ResumeSchedule(new ResumeScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                CatchUp = catchUp,
            }, callSettings);

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="catchUp">
        /// Optional. Whether to backfill missed runs when the schedule is resumed from
        /// PAUSED state. If set to true, all missed runs will be scheduled. New runs
        /// will be scheduled after the backfill is complete. This will also update
        /// [Schedule.catch_up][google.cloud.aiplatform.v1.Schedule.catch_up] field.
        /// Default to false.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeScheduleAsync(ScheduleName name, bool catchUp, gaxgrpc::CallSettings callSettings = null) =>
            ResumeScheduleAsync(new ResumeScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                CatchUp = catchUp,
            }, callSettings);

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Schedule resource to be resumed.
        /// Format:
        /// `projects/{project}/locations/{location}/schedules/{schedule}`
        /// </param>
        /// <param name="catchUp">
        /// Optional. Whether to backfill missed runs when the schedule is resumed from
        /// PAUSED state. If set to true, all missed runs will be scheduled. New runs
        /// will be scheduled after the backfill is complete. This will also update
        /// [Schedule.catch_up][google.cloud.aiplatform.v1.Schedule.catch_up] field.
        /// Default to false.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeScheduleAsync(ScheduleName name, bool catchUp, st::CancellationToken cancellationToken) =>
            ResumeScheduleAsync(name, catchUp, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an active or paused Schedule.
        /// 
        /// When the Schedule is updated, new runs will be scheduled starting from the
        /// updated next execution time after the update time based on the
        /// time_specification in the updated Schedule. All unstarted runs before the
        /// update time will be skipped while already created runs will NOT be paused
        /// or canceled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schedule UpdateSchedule(UpdateScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an active or paused Schedule.
        /// 
        /// When the Schedule is updated, new runs will be scheduled starting from the
        /// updated next execution time after the update time based on the
        /// time_specification in the updated Schedule. All unstarted runs before the
        /// update time will be skipped while already created runs will NOT be paused
        /// or canceled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> UpdateScheduleAsync(UpdateScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an active or paused Schedule.
        /// 
        /// When the Schedule is updated, new runs will be scheduled starting from the
        /// updated next execution time after the update time based on the
        /// time_specification in the updated Schedule. All unstarted runs before the
        /// update time will be skipped while already created runs will NOT be paused
        /// or canceled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> UpdateScheduleAsync(UpdateScheduleRequest request, st::CancellationToken cancellationToken) =>
            UpdateScheduleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an active or paused Schedule.
        /// 
        /// When the Schedule is updated, new runs will be scheduled starting from the
        /// updated next execution time after the update time based on the
        /// time_specification in the updated Schedule. All unstarted runs before the
        /// update time will be skipped while already created runs will NOT be paused
        /// or canceled.
        /// </summary>
        /// <param name="schedule">
        /// Required. The Schedule which replaces the resource on the server.
        /// The following restrictions will be applied:
        /// 
        /// * The scheduled request type cannot be changed.
        /// * The non-empty fields cannot be unset.
        /// * The output_only fields will be ignored if specified.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schedule UpdateSchedule(Schedule schedule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSchedule(new UpdateScheduleRequest
            {
                Schedule = gax::GaxPreconditions.CheckNotNull(schedule, nameof(schedule)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an active or paused Schedule.
        /// 
        /// When the Schedule is updated, new runs will be scheduled starting from the
        /// updated next execution time after the update time based on the
        /// time_specification in the updated Schedule. All unstarted runs before the
        /// update time will be skipped while already created runs will NOT be paused
        /// or canceled.
        /// </summary>
        /// <param name="schedule">
        /// Required. The Schedule which replaces the resource on the server.
        /// The following restrictions will be applied:
        /// 
        /// * The scheduled request type cannot be changed.
        /// * The non-empty fields cannot be unset.
        /// * The output_only fields will be ignored if specified.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> UpdateScheduleAsync(Schedule schedule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScheduleAsync(new UpdateScheduleRequest
            {
                Schedule = gax::GaxPreconditions.CheckNotNull(schedule, nameof(schedule)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an active or paused Schedule.
        /// 
        /// When the Schedule is updated, new runs will be scheduled starting from the
        /// updated next execution time after the update time based on the
        /// time_specification in the updated Schedule. All unstarted runs before the
        /// update time will be skipped while already created runs will NOT be paused
        /// or canceled.
        /// </summary>
        /// <param name="schedule">
        /// Required. The Schedule which replaces the resource on the server.
        /// The following restrictions will be applied:
        /// 
        /// * The scheduled request type cannot be changed.
        /// * The non-empty fields cannot be unset.
        /// * The output_only fields will be ignored if specified.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> UpdateScheduleAsync(Schedule schedule, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateScheduleAsync(schedule, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ScheduleService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Vertex AI's Schedule resources to
    /// periodically launch shceudled runs to make API calls.
    /// </remarks>
    public sealed partial class ScheduleServiceClientImpl : ScheduleServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateScheduleRequest, Schedule> _callCreateSchedule;

        private readonly gaxgrpc::ApiCall<DeleteScheduleRequest, lro::Operation> _callDeleteSchedule;

        private readonly gaxgrpc::ApiCall<GetScheduleRequest, Schedule> _callGetSchedule;

        private readonly gaxgrpc::ApiCall<ListSchedulesRequest, ListSchedulesResponse> _callListSchedules;

        private readonly gaxgrpc::ApiCall<PauseScheduleRequest, wkt::Empty> _callPauseSchedule;

        private readonly gaxgrpc::ApiCall<ResumeScheduleRequest, wkt::Empty> _callResumeSchedule;

        private readonly gaxgrpc::ApiCall<UpdateScheduleRequest, Schedule> _callUpdateSchedule;

        /// <summary>
        /// Constructs a client wrapper for the ScheduleService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ScheduleServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ScheduleServiceClientImpl(ScheduleService.ScheduleServiceClient grpcClient, ScheduleServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ScheduleServiceSettings effectiveSettings = settings ?? ScheduleServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteScheduleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteScheduleOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateSchedule = clientHelper.BuildApiCall<CreateScheduleRequest, Schedule>("CreateSchedule", grpcClient.CreateScheduleAsync, grpcClient.CreateSchedule, effectiveSettings.CreateScheduleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSchedule);
            Modify_CreateScheduleApiCall(ref _callCreateSchedule);
            _callDeleteSchedule = clientHelper.BuildApiCall<DeleteScheduleRequest, lro::Operation>("DeleteSchedule", grpcClient.DeleteScheduleAsync, grpcClient.DeleteSchedule, effectiveSettings.DeleteScheduleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSchedule);
            Modify_DeleteScheduleApiCall(ref _callDeleteSchedule);
            _callGetSchedule = clientHelper.BuildApiCall<GetScheduleRequest, Schedule>("GetSchedule", grpcClient.GetScheduleAsync, grpcClient.GetSchedule, effectiveSettings.GetScheduleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSchedule);
            Modify_GetScheduleApiCall(ref _callGetSchedule);
            _callListSchedules = clientHelper.BuildApiCall<ListSchedulesRequest, ListSchedulesResponse>("ListSchedules", grpcClient.ListSchedulesAsync, grpcClient.ListSchedules, effectiveSettings.ListSchedulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSchedules);
            Modify_ListSchedulesApiCall(ref _callListSchedules);
            _callPauseSchedule = clientHelper.BuildApiCall<PauseScheduleRequest, wkt::Empty>("PauseSchedule", grpcClient.PauseScheduleAsync, grpcClient.PauseSchedule, effectiveSettings.PauseScheduleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPauseSchedule);
            Modify_PauseScheduleApiCall(ref _callPauseSchedule);
            _callResumeSchedule = clientHelper.BuildApiCall<ResumeScheduleRequest, wkt::Empty>("ResumeSchedule", grpcClient.ResumeScheduleAsync, grpcClient.ResumeSchedule, effectiveSettings.ResumeScheduleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeSchedule);
            Modify_ResumeScheduleApiCall(ref _callResumeSchedule);
            _callUpdateSchedule = clientHelper.BuildApiCall<UpdateScheduleRequest, Schedule>("UpdateSchedule", grpcClient.UpdateScheduleAsync, grpcClient.UpdateSchedule, effectiveSettings.UpdateScheduleSettings).WithGoogleRequestParam("schedule.name", request => request.Schedule?.Name);
            Modify_ApiCall(ref _callUpdateSchedule);
            Modify_UpdateScheduleApiCall(ref _callUpdateSchedule);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateScheduleApiCall(ref gaxgrpc::ApiCall<CreateScheduleRequest, Schedule> call);

        partial void Modify_DeleteScheduleApiCall(ref gaxgrpc::ApiCall<DeleteScheduleRequest, lro::Operation> call);

        partial void Modify_GetScheduleApiCall(ref gaxgrpc::ApiCall<GetScheduleRequest, Schedule> call);

        partial void Modify_ListSchedulesApiCall(ref gaxgrpc::ApiCall<ListSchedulesRequest, ListSchedulesResponse> call);

        partial void Modify_PauseScheduleApiCall(ref gaxgrpc::ApiCall<PauseScheduleRequest, wkt::Empty> call);

        partial void Modify_ResumeScheduleApiCall(ref gaxgrpc::ApiCall<ResumeScheduleRequest, wkt::Empty> call);

        partial void Modify_UpdateScheduleApiCall(ref gaxgrpc::ApiCall<UpdateScheduleRequest, Schedule> call);

        partial void OnConstruction(ScheduleService.ScheduleServiceClient grpcClient, ScheduleServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ScheduleService client</summary>
        public override ScheduleService.ScheduleServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateScheduleRequest(ref CreateScheduleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteScheduleRequest(ref DeleteScheduleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetScheduleRequest(ref GetScheduleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSchedulesRequest(ref ListSchedulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PauseScheduleRequest(ref PauseScheduleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeScheduleRequest(ref ResumeScheduleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateScheduleRequest(ref UpdateScheduleRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Schedule CreateSchedule(CreateScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScheduleRequest(ref request, ref callSettings);
            return _callCreateSchedule.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Schedule> CreateScheduleAsync(CreateScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScheduleRequest(ref request, ref callSettings);
            return _callCreateSchedule.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteSchedule</c>.</summary>
        public override lro::OperationsClient DeleteScheduleOperationsClient { get; }

        /// <summary>
        /// Deletes a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteSchedule(DeleteScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScheduleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteSchedule.Sync(request, callSettings), DeleteScheduleOperationsClient);
        }

        /// <summary>
        /// Deletes a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteScheduleAsync(DeleteScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScheduleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteSchedule.Async(request, callSettings).ConfigureAwait(false), DeleteScheduleOperationsClient);
        }

        /// <summary>
        /// Gets a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Schedule GetSchedule(GetScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScheduleRequest(ref request, ref callSettings);
            return _callGetSchedule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Schedule> GetScheduleAsync(GetScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScheduleRequest(ref request, ref callSettings);
            return _callGetSchedule.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Schedules in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Schedule"/> resources.</returns>
        public override gax::PagedEnumerable<ListSchedulesResponse, Schedule> ListSchedules(ListSchedulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSchedulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSchedulesRequest, ListSchedulesResponse, Schedule>(_callListSchedules, request, callSettings);
        }

        /// <summary>
        /// Lists Schedules in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schedule"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSchedulesResponse, Schedule> ListSchedulesAsync(ListSchedulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSchedulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSchedulesRequest, ListSchedulesResponse, Schedule>(_callListSchedules, request, callSettings);
        }

        /// <summary>
        /// Pauses a Schedule. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'PAUSED'. If
        /// the schedule is paused, no new runs will be created. Already created runs
        /// will NOT be paused or canceled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void PauseSchedule(PauseScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseScheduleRequest(ref request, ref callSettings);
            _callPauseSchedule.Sync(request, callSettings);
        }

        /// <summary>
        /// Pauses a Schedule. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'PAUSED'. If
        /// the schedule is paused, no new runs will be created. Already created runs
        /// will NOT be paused or canceled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task PauseScheduleAsync(PauseScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseScheduleRequest(ref request, ref callSettings);
            return _callPauseSchedule.Async(request, callSettings);
        }

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ResumeSchedule(ResumeScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeScheduleRequest(ref request, ref callSettings);
            _callResumeSchedule.Sync(request, callSettings);
        }

        /// <summary>
        /// Resumes a paused Schedule to start scheduling new runs. Will mark
        /// [Schedule.state][google.cloud.aiplatform.v1.Schedule.state] to 'ACTIVE'.
        /// Only paused Schedule can be resumed.
        /// 
        /// When the Schedule is resumed, new runs will be scheduled starting from the
        /// next execution time after the current time based on the time_specification
        /// in the Schedule. If [Schedule.catchUp][] is set up true, all
        /// missed runs will be scheduled for backfill first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task ResumeScheduleAsync(ResumeScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeScheduleRequest(ref request, ref callSettings);
            return _callResumeSchedule.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an active or paused Schedule.
        /// 
        /// When the Schedule is updated, new runs will be scheduled starting from the
        /// updated next execution time after the update time based on the
        /// time_specification in the updated Schedule. All unstarted runs before the
        /// update time will be skipped while already created runs will NOT be paused
        /// or canceled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Schedule UpdateSchedule(UpdateScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScheduleRequest(ref request, ref callSettings);
            return _callUpdateSchedule.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an active or paused Schedule.
        /// 
        /// When the Schedule is updated, new runs will be scheduled starting from the
        /// updated next execution time after the update time based on the
        /// time_specification in the updated Schedule. All unstarted runs before the
        /// update time will be skipped while already created runs will NOT be paused
        /// or canceled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Schedule> UpdateScheduleAsync(UpdateScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScheduleRequest(ref request, ref callSettings);
            return _callUpdateSchedule.Async(request, callSettings);
        }
    }

    public partial class ListSchedulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSchedulesResponse : gaxgrpc::IPageResponse<Schedule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Schedule> GetEnumerator() => Schedules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ScheduleService
    {
        public partial class ScheduleServiceClient
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

    public static partial class ScheduleService
    {
        public partial class ScheduleServiceClient
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
