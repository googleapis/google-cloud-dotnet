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

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Settings for <see cref="AlertPolicyServiceClient"/> instances.</summary>
    public sealed partial class AlertPolicyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AlertPolicyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AlertPolicyServiceSettings"/>.</returns>
        public static AlertPolicyServiceSettings GetDefault() => new AlertPolicyServiceSettings();

        /// <summary>Constructs a new <see cref="AlertPolicyServiceSettings"/> object with default settings.</summary>
        public AlertPolicyServiceSettings()
        {
        }

        private AlertPolicyServiceSettings(AlertPolicyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAlertPoliciesSettings = existing.ListAlertPoliciesSettings;
            GetAlertPolicySettings = existing.GetAlertPolicySettings;
            CreateAlertPolicySettings = existing.CreateAlertPolicySettings;
            DeleteAlertPolicySettings = existing.DeleteAlertPolicySettings;
            UpdateAlertPolicySettings = existing.UpdateAlertPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AlertPolicyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.ListAlertPolicies</c> and <c>AlertPolicyServiceClient.ListAlertPoliciesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAlertPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.GetAlertPolicy</c> and <c>AlertPolicyServiceClient.GetAlertPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAlertPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.CreateAlertPolicy</c> and <c>AlertPolicyServiceClient.CreateAlertPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAlertPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.DeleteAlertPolicy</c> and <c>AlertPolicyServiceClient.DeleteAlertPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAlertPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.UpdateAlertPolicy</c> and <c>AlertPolicyServiceClient.UpdateAlertPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAlertPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AlertPolicyServiceSettings"/> object.</returns>
        public AlertPolicyServiceSettings Clone() => new AlertPolicyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AlertPolicyServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AlertPolicyServiceClientBuilder : gaxgrpc::ClientBuilderBase<AlertPolicyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AlertPolicyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AlertPolicyServiceClientBuilder() : base(AlertPolicyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AlertPolicyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AlertPolicyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AlertPolicyServiceClient Build()
        {
            AlertPolicyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AlertPolicyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AlertPolicyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AlertPolicyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AlertPolicyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AlertPolicyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AlertPolicyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AlertPolicyServiceClient.ChannelPool;
    }

    /// <summary>AlertPolicyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The AlertPolicyService API is used to manage (list, create, delete,
    /// edit) alert policies in Cloud Monitoring. An alerting policy is
    /// a description of the conditions under which some aspect of your
    /// system is considered to be "unhealthy" and the ways to notify
    /// people or services about this state. In addition to using this API, alert
    /// policies can also be managed through
    /// [Cloud Monitoring](https://cloud.google.com/monitoring/docs/),
    /// which can be reached by clicking the "Monitoring" tab in
    /// [Cloud console](https://console.cloud.google.com/).
    /// </remarks>
    public abstract partial class AlertPolicyServiceClient
    {
        /// <summary>
        /// The default endpoint for the AlertPolicyService service, which is a host of "monitoring.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "monitoring.googleapis.com:443";

        /// <summary>The default AlertPolicyService scopes.</summary>
        /// <remarks>
        /// The default AlertPolicyService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.read</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AlertPolicyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AlertPolicyServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AlertPolicyServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AlertPolicyServiceClient"/>.</returns>
        public static stt::Task<AlertPolicyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AlertPolicyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AlertPolicyServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AlertPolicyServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="AlertPolicyServiceClient"/>.</returns>
        public static AlertPolicyServiceClient Create() => new AlertPolicyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AlertPolicyServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AlertPolicyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AlertPolicyServiceClient"/>.</returns>
        internal static AlertPolicyServiceClient Create(grpccore::CallInvoker callInvoker, AlertPolicyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AlertPolicyService.AlertPolicyServiceClient grpcClient = new AlertPolicyService.AlertPolicyServiceClient(callInvoker);
            return new AlertPolicyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AlertPolicyService client</summary>
        public virtual AlertPolicyService.AlertPolicyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(ListAlertPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(ListAlertPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// alert policies are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
        /// operation, instead.
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
        /// <returns>A pageable sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAlertPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// alert policies are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
        /// operation, instead.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAlertPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// alert policies are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
        /// operation, instead.
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
        /// <returns>A pageable sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAlertPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// alert policies are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
        /// operation, instead.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAlertPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// alert policies are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
        /// operation, instead.
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
        /// <returns>A pageable sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAlertPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// alert policies are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
        /// operation, instead.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAlertPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// alert policies are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
        /// operation, instead.
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
        /// <returns>A pageable sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAlertPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// alert policies are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
        /// operation, instead.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAlertPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// alert policies are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
        /// operation, instead.
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
        /// <returns>A pageable sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAlertPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// alert policies are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
        /// operation, instead.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AlertPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAlertPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy GetAlertPolicy(GetAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(GetAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(GetAlertPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAlertPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy GetAlertPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAlertPolicy(new GetAlertPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAlertPolicyAsync(new GetAlertPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetAlertPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy GetAlertPolicy(AlertPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAlertPolicy(new GetAlertPolicyRequest
            {
                AlertPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(AlertPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAlertPolicyAsync(new GetAlertPolicyRequest
            {
                AlertPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(AlertPolicyName name, st::CancellationToken cancellationToken) =>
            GetAlertPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy GetAlertPolicy(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAlertPolicy(new GetAlertPolicyRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAlertPolicyAsync(new GetAlertPolicyRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            GetAlertPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy CreateAlertPolicy(CreateAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(CreateAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(CreateAlertPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateAlertPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy CreateAlertPolicy(string name, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlertPolicy(new CreateAlertPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(string name, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlertPolicyAsync(new CreateAlertPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(string name, AlertPolicy alertPolicy, st::CancellationToken cancellationToken) =>
            CreateAlertPolicyAsync(name, alertPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy CreateAlertPolicy(gagr::ProjectName name, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlertPolicy(new CreateAlertPolicyRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(gagr::ProjectName name, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlertPolicyAsync(new CreateAlertPolicyRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(gagr::ProjectName name, AlertPolicy alertPolicy, st::CancellationToken cancellationToken) =>
            CreateAlertPolicyAsync(name, alertPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy CreateAlertPolicy(gagr::OrganizationName name, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlertPolicy(new CreateAlertPolicyRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(gagr::OrganizationName name, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlertPolicyAsync(new CreateAlertPolicyRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(gagr::OrganizationName name, AlertPolicy alertPolicy, st::CancellationToken cancellationToken) =>
            CreateAlertPolicyAsync(name, alertPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy CreateAlertPolicy(gagr::FolderName name, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlertPolicy(new CreateAlertPolicyRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(gagr::FolderName name, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlertPolicyAsync(new CreateAlertPolicyRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(gagr::FolderName name, AlertPolicy alertPolicy, st::CancellationToken cancellationToken) =>
            CreateAlertPolicyAsync(name, alertPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy CreateAlertPolicy(gax::IResourceName name, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlertPolicy(new CreateAlertPolicyRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(gax::IResourceName name, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAlertPolicyAsync(new CreateAlertPolicyRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the alerting policy. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. |name| must be
        /// a host project of a Metrics Scope, otherwise INVALID_ARGUMENT error will
        /// return. The alerting policy that is returned will have a name that contains
        /// a normalized representation of this name as a prefix but adds a suffix of
        /// the form `/alertPolicies/[ALERT_POLICY_ID]`, identifying the policy in the
        /// container.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The requested alerting policy. You should omit the `name` field
        /// in this policy. The name will be returned in the new policy, including a
        /// new `[ALERT_POLICY_ID]` value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(gax::IResourceName name, AlertPolicy alertPolicy, st::CancellationToken cancellationToken) =>
            CreateAlertPolicyAsync(name, alertPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAlertPolicy(DeleteAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAlertPolicyAsync(DeleteAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAlertPolicyAsync(DeleteAlertPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAlertPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// 
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAlertPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAlertPolicy(new DeleteAlertPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// 
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAlertPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAlertPolicyAsync(new DeleteAlertPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// 
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAlertPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAlertPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// 
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAlertPolicy(AlertPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAlertPolicy(new DeleteAlertPolicyRequest
            {
                AlertPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// 
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAlertPolicyAsync(AlertPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAlertPolicyAsync(new DeleteAlertPolicyRequest
            {
                AlertPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// 
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAlertPolicyAsync(AlertPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteAlertPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// 
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAlertPolicy(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAlertPolicy(new DeleteAlertPolicyRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// 
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAlertPolicyAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAlertPolicyAsync(new DeleteAlertPolicyRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The alerting policy to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/alertPolicies/[ALERT_POLICY_ID]
        /// 
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAlertPolicyAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            DeleteAlertPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy UpdateAlertPolicy(UpdateAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> UpdateAlertPolicyAsync(UpdateAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> UpdateAlertPolicyAsync(UpdateAlertPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateAlertPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="updateMask">
        /// Optional. A list of alerting policy field names. If this field is not
        /// empty, each listed field in the existing alerting policy is set to the
        /// value of the corresponding field in the supplied policy (`alert_policy`),
        /// or to the field's default value if the field is not in the supplied
        /// alerting policy.  Fields not listed retain their previous value.
        /// 
        /// Examples of valid field masks include `display_name`, `documentation`,
        /// `documentation.content`, `documentation.mime_type`, `user_labels`,
        /// `user_label.nameofkey`, `enabled`, `conditions`, `combiner`, etc.
        /// 
        /// If this field is empty, then the supplied alerting policy replaces the
        /// existing policy. It is the same as deleting the existing policy and
        /// adding the supplied policy, except for the following:
        /// 
        /// +   The new policy will have the same `[ALERT_POLICY_ID]` as the former
        /// policy. This gives you continuity with the former policy in your
        /// notifications and incidents.
        /// +   Conditions in the new policy will keep their former `[CONDITION_ID]` if
        /// the supplied condition includes the `name` field with that
        /// `[CONDITION_ID]`. If the supplied condition omits the `name` field,
        /// then a new `[CONDITION_ID]` is created.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The updated alerting policy or the updated values for the
        /// fields listed in `update_mask`.
        /// If `update_mask` is not empty, any fields in this policy that are
        /// not in `update_mask` are ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AlertPolicy UpdateAlertPolicy(wkt::FieldMask updateMask, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAlertPolicy(new UpdateAlertPolicyRequest
            {
                UpdateMask = updateMask,
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="updateMask">
        /// Optional. A list of alerting policy field names. If this field is not
        /// empty, each listed field in the existing alerting policy is set to the
        /// value of the corresponding field in the supplied policy (`alert_policy`),
        /// or to the field's default value if the field is not in the supplied
        /// alerting policy.  Fields not listed retain their previous value.
        /// 
        /// Examples of valid field masks include `display_name`, `documentation`,
        /// `documentation.content`, `documentation.mime_type`, `user_labels`,
        /// `user_label.nameofkey`, `enabled`, `conditions`, `combiner`, etc.
        /// 
        /// If this field is empty, then the supplied alerting policy replaces the
        /// existing policy. It is the same as deleting the existing policy and
        /// adding the supplied policy, except for the following:
        /// 
        /// +   The new policy will have the same `[ALERT_POLICY_ID]` as the former
        /// policy. This gives you continuity with the former policy in your
        /// notifications and incidents.
        /// +   Conditions in the new policy will keep their former `[CONDITION_ID]` if
        /// the supplied condition includes the `name` field with that
        /// `[CONDITION_ID]`. If the supplied condition omits the `name` field,
        /// then a new `[CONDITION_ID]` is created.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The updated alerting policy or the updated values for the
        /// fields listed in `update_mask`.
        /// If `update_mask` is not empty, any fields in this policy that are
        /// not in `update_mask` are ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> UpdateAlertPolicyAsync(wkt::FieldMask updateMask, AlertPolicy alertPolicy, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAlertPolicyAsync(new UpdateAlertPolicyRequest
            {
                UpdateMask = updateMask,
                AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="updateMask">
        /// Optional. A list of alerting policy field names. If this field is not
        /// empty, each listed field in the existing alerting policy is set to the
        /// value of the corresponding field in the supplied policy (`alert_policy`),
        /// or to the field's default value if the field is not in the supplied
        /// alerting policy.  Fields not listed retain their previous value.
        /// 
        /// Examples of valid field masks include `display_name`, `documentation`,
        /// `documentation.content`, `documentation.mime_type`, `user_labels`,
        /// `user_label.nameofkey`, `enabled`, `conditions`, `combiner`, etc.
        /// 
        /// If this field is empty, then the supplied alerting policy replaces the
        /// existing policy. It is the same as deleting the existing policy and
        /// adding the supplied policy, except for the following:
        /// 
        /// +   The new policy will have the same `[ALERT_POLICY_ID]` as the former
        /// policy. This gives you continuity with the former policy in your
        /// notifications and incidents.
        /// +   Conditions in the new policy will keep their former `[CONDITION_ID]` if
        /// the supplied condition includes the `name` field with that
        /// `[CONDITION_ID]`. If the supplied condition omits the `name` field,
        /// then a new `[CONDITION_ID]` is created.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The updated alerting policy or the updated values for the
        /// fields listed in `update_mask`.
        /// If `update_mask` is not empty, any fields in this policy that are
        /// not in `update_mask` are ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AlertPolicy> UpdateAlertPolicyAsync(wkt::FieldMask updateMask, AlertPolicy alertPolicy, st::CancellationToken cancellationToken) =>
            UpdateAlertPolicyAsync(updateMask, alertPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AlertPolicyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The AlertPolicyService API is used to manage (list, create, delete,
    /// edit) alert policies in Cloud Monitoring. An alerting policy is
    /// a description of the conditions under which some aspect of your
    /// system is considered to be "unhealthy" and the ways to notify
    /// people or services about this state. In addition to using this API, alert
    /// policies can also be managed through
    /// [Cloud Monitoring](https://cloud.google.com/monitoring/docs/),
    /// which can be reached by clicking the "Monitoring" tab in
    /// [Cloud console](https://console.cloud.google.com/).
    /// </remarks>
    public sealed partial class AlertPolicyServiceClientImpl : AlertPolicyServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAlertPoliciesRequest, ListAlertPoliciesResponse> _callListAlertPolicies;

        private readonly gaxgrpc::ApiCall<GetAlertPolicyRequest, AlertPolicy> _callGetAlertPolicy;

        private readonly gaxgrpc::ApiCall<CreateAlertPolicyRequest, AlertPolicy> _callCreateAlertPolicy;

        private readonly gaxgrpc::ApiCall<DeleteAlertPolicyRequest, wkt::Empty> _callDeleteAlertPolicy;

        private readonly gaxgrpc::ApiCall<UpdateAlertPolicyRequest, AlertPolicy> _callUpdateAlertPolicy;

        /// <summary>
        /// Constructs a client wrapper for the AlertPolicyService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AlertPolicyServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AlertPolicyServiceClientImpl(AlertPolicyService.AlertPolicyServiceClient grpcClient, AlertPolicyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AlertPolicyServiceSettings effectiveSettings = settings ?? AlertPolicyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListAlertPolicies = clientHelper.BuildApiCall<ListAlertPoliciesRequest, ListAlertPoliciesResponse>("ListAlertPolicies", grpcClient.ListAlertPoliciesAsync, grpcClient.ListAlertPolicies, effectiveSettings.ListAlertPoliciesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListAlertPolicies);
            Modify_ListAlertPoliciesApiCall(ref _callListAlertPolicies);
            _callGetAlertPolicy = clientHelper.BuildApiCall<GetAlertPolicyRequest, AlertPolicy>("GetAlertPolicy", grpcClient.GetAlertPolicyAsync, grpcClient.GetAlertPolicy, effectiveSettings.GetAlertPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAlertPolicy);
            Modify_GetAlertPolicyApiCall(ref _callGetAlertPolicy);
            _callCreateAlertPolicy = clientHelper.BuildApiCall<CreateAlertPolicyRequest, AlertPolicy>("CreateAlertPolicy", grpcClient.CreateAlertPolicyAsync, grpcClient.CreateAlertPolicy, effectiveSettings.CreateAlertPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateAlertPolicy);
            Modify_CreateAlertPolicyApiCall(ref _callCreateAlertPolicy);
            _callDeleteAlertPolicy = clientHelper.BuildApiCall<DeleteAlertPolicyRequest, wkt::Empty>("DeleteAlertPolicy", grpcClient.DeleteAlertPolicyAsync, grpcClient.DeleteAlertPolicy, effectiveSettings.DeleteAlertPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAlertPolicy);
            Modify_DeleteAlertPolicyApiCall(ref _callDeleteAlertPolicy);
            _callUpdateAlertPolicy = clientHelper.BuildApiCall<UpdateAlertPolicyRequest, AlertPolicy>("UpdateAlertPolicy", grpcClient.UpdateAlertPolicyAsync, grpcClient.UpdateAlertPolicy, effectiveSettings.UpdateAlertPolicySettings).WithGoogleRequestParam("alert_policy.name", request => request.AlertPolicy?.Name);
            Modify_ApiCall(ref _callUpdateAlertPolicy);
            Modify_UpdateAlertPolicyApiCall(ref _callUpdateAlertPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAlertPoliciesApiCall(ref gaxgrpc::ApiCall<ListAlertPoliciesRequest, ListAlertPoliciesResponse> call);

        partial void Modify_GetAlertPolicyApiCall(ref gaxgrpc::ApiCall<GetAlertPolicyRequest, AlertPolicy> call);

        partial void Modify_CreateAlertPolicyApiCall(ref gaxgrpc::ApiCall<CreateAlertPolicyRequest, AlertPolicy> call);

        partial void Modify_DeleteAlertPolicyApiCall(ref gaxgrpc::ApiCall<DeleteAlertPolicyRequest, wkt::Empty> call);

        partial void Modify_UpdateAlertPolicyApiCall(ref gaxgrpc::ApiCall<UpdateAlertPolicyRequest, AlertPolicy> call);

        partial void OnConstruction(AlertPolicyService.AlertPolicyServiceClient grpcClient, AlertPolicyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AlertPolicyService client</summary>
        public override AlertPolicyService.AlertPolicyServiceClient GrpcClient { get; }

        partial void Modify_ListAlertPoliciesRequest(ref ListAlertPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAlertPolicyRequest(ref GetAlertPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAlertPolicyRequest(ref CreateAlertPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAlertPolicyRequest(ref DeleteAlertPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAlertPolicyRequest(ref UpdateAlertPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AlertPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(ListAlertPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAlertPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAlertPoliciesRequest, ListAlertPoliciesResponse, AlertPolicy>(_callListAlertPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists the existing alerting policies for the workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AlertPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(ListAlertPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAlertPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAlertPoliciesRequest, ListAlertPoliciesResponse, AlertPolicy>(_callListAlertPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AlertPolicy GetAlertPolicy(GetAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAlertPolicyRequest(ref request, ref callSettings);
            return _callGetAlertPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AlertPolicy> GetAlertPolicyAsync(GetAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAlertPolicyRequest(ref request, ref callSettings);
            return _callGetAlertPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AlertPolicy CreateAlertPolicy(CreateAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAlertPolicyRequest(ref request, ref callSettings);
            return _callCreateAlertPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AlertPolicy> CreateAlertPolicyAsync(CreateAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAlertPolicyRequest(ref request, ref callSettings);
            return _callCreateAlertPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAlertPolicy(DeleteAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAlertPolicyRequest(ref request, ref callSettings);
            _callDeleteAlertPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAlertPolicyAsync(DeleteAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAlertPolicyRequest(ref request, ref callSettings);
            return _callDeleteAlertPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AlertPolicy UpdateAlertPolicy(UpdateAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAlertPolicyRequest(ref request, ref callSettings);
            return _callUpdateAlertPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// alerting policies in a single project. This includes calls to
        /// CreateAlertPolicy, DeleteAlertPolicy and UpdateAlertPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AlertPolicy> UpdateAlertPolicyAsync(UpdateAlertPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAlertPolicyRequest(ref request, ref callSettings);
            return _callUpdateAlertPolicy.Async(request, callSettings);
        }
    }

    public partial class ListAlertPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAlertPoliciesResponse : gaxgrpc::IPageResponse<AlertPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AlertPolicy> GetEnumerator() => AlertPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
