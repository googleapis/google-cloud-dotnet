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

namespace Google.Cloud.Support.V2Beta
{
    /// <summary>Settings for <see cref="CaseServiceClient"/> instances.</summary>
    public sealed partial class CaseServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CaseServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CaseServiceSettings"/>.</returns>
        public static CaseServiceSettings GetDefault() => new CaseServiceSettings();

        /// <summary>Constructs a new <see cref="CaseServiceSettings"/> object with default settings.</summary>
        public CaseServiceSettings()
        {
        }

        private CaseServiceSettings(CaseServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCaseSettings = existing.GetCaseSettings;
            ListCasesSettings = existing.ListCasesSettings;
            SearchCasesSettings = existing.SearchCasesSettings;
            CreateCaseSettings = existing.CreateCaseSettings;
            UpdateCaseSettings = existing.UpdateCaseSettings;
            EscalateCaseSettings = existing.EscalateCaseSettings;
            CloseCaseSettings = existing.CloseCaseSettings;
            SearchCaseClassificationsSettings = existing.SearchCaseClassificationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CaseServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CaseServiceClient.GetCase</c>
        ///  and <c>CaseServiceClient.GetCaseAsync</c>.
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
        public gaxgrpc::CallSettings GetCaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CaseServiceClient.ListCases</c>
        ///  and <c>CaseServiceClient.ListCasesAsync</c>.
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
        public gaxgrpc::CallSettings ListCasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CaseServiceClient.SearchCases</c> and <c>CaseServiceClient.SearchCasesAsync</c>.
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
        public gaxgrpc::CallSettings SearchCasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CaseServiceClient.CreateCase</c> and <c>CaseServiceClient.CreateCaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CaseServiceClient.UpdateCase</c> and <c>CaseServiceClient.UpdateCaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CaseServiceClient.EscalateCase</c> and <c>CaseServiceClient.EscalateCaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EscalateCaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CaseServiceClient.CloseCase</c>
        ///  and <c>CaseServiceClient.CloseCaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CloseCaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CaseServiceClient.SearchCaseClassifications</c> and <c>CaseServiceClient.SearchCaseClassificationsAsync</c>
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
        public gaxgrpc::CallSettings SearchCaseClassificationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CaseServiceSettings"/> object.</returns>
        public CaseServiceSettings Clone() => new CaseServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CaseServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CaseServiceClientBuilder : gaxgrpc::ClientBuilderBase<CaseServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CaseServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CaseServiceClientBuilder() : base(CaseServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CaseServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CaseServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CaseServiceClient Build()
        {
            CaseServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CaseServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CaseServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CaseServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CaseServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CaseServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CaseServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CaseServiceClient.ChannelPool;
    }

    /// <summary>CaseService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service to manage Google Cloud support cases.
    /// </remarks>
    public abstract partial class CaseServiceClient
    {
        /// <summary>
        /// The default endpoint for the CaseService service, which is a host of "cloudsupport.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudsupport.googleapis.com:443";

        /// <summary>The default CaseService scopes.</summary>
        /// <remarks>
        /// The default CaseService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CaseService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CaseServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CaseServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CaseServiceClient"/>.</returns>
        public static stt::Task<CaseServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CaseServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CaseServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CaseServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CaseServiceClient"/>.</returns>
        public static CaseServiceClient Create() => new CaseServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CaseServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CaseServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CaseServiceClient"/>.</returns>
        internal static CaseServiceClient Create(grpccore::CallInvoker callInvoker, CaseServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CaseService.CaseServiceClient grpcClient = new CaseService.CaseServiceClient(callInvoker);
            return new CaseServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CaseService client</summary>
        public virtual CaseService.CaseServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Case GetCase(GetCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> GetCaseAsync(GetCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve a case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> GetCaseAsync(GetCaseRequest request, st::CancellationToken cancellationToken) =>
            GetCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a case.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of a case to be retrieved.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Case GetCase(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCase(new GetCaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a case.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of a case to be retrieved.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> GetCaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCaseAsync(new GetCaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a case.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of a case to be retrieved.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> GetCaseAsync(string name, st::CancellationToken cancellationToken) =>
            GetCaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve a case.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of a case to be retrieved.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Case GetCase(CaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCase(new GetCaseRequest
            {
                CaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a case.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of a case to be retrieved.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> GetCaseAsync(CaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCaseAsync(new GetCaseRequest
            {
                CaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve a case.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of a case to be retrieved.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> GetCaseAsync(CaseName name, st::CancellationToken cancellationToken) =>
            GetCaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve all cases under a parent, but not its children.
        /// 
        /// For example, listing cases under an organization only returns the cases
        /// that are directly parented by that organization. To retrieve cases
        /// under an organization and its projects, use `cases.search`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Case"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCasesResponse, Case> ListCases(ListCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve all cases under a parent, but not its children.
        /// 
        /// For example, listing cases under an organization only returns the cases
        /// that are directly parented by that organization. To retrieve cases
        /// under an organization and its projects, use `cases.search`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Case"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCasesResponse, Case> ListCasesAsync(ListCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve all cases under a parent, but not its children.
        /// 
        /// For example, listing cases under an organization only returns the cases
        /// that are directly parented by that organization. To retrieve cases
        /// under an organization and its projects, use `cases.search`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of a parent to list cases under.
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
        /// <returns>A pageable sequence of <see cref="Case"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCasesResponse, Case> ListCases(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCasesRequest request = new ListCasesRequest
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
            return ListCases(request, callSettings);
        }

        /// <summary>
        /// Retrieve all cases under a parent, but not its children.
        /// 
        /// For example, listing cases under an organization only returns the cases
        /// that are directly parented by that organization. To retrieve cases
        /// under an organization and its projects, use `cases.search`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of a parent to list cases under.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Case"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCasesResponse, Case> ListCasesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCasesRequest request = new ListCasesRequest
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
            return ListCasesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve all cases under a parent, but not its children.
        /// 
        /// For example, listing cases under an organization only returns the cases
        /// that are directly parented by that organization. To retrieve cases
        /// under an organization and its projects, use `cases.search`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of a parent to list cases under.
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
        /// <returns>A pageable sequence of <see cref="Case"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCasesResponse, Case> ListCases(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCasesRequest request = new ListCasesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCases(request, callSettings);
        }

        /// <summary>
        /// Retrieve all cases under a parent, but not its children.
        /// 
        /// For example, listing cases under an organization only returns the cases
        /// that are directly parented by that organization. To retrieve cases
        /// under an organization and its projects, use `cases.search`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of a parent to list cases under.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Case"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCasesResponse, Case> ListCasesAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCasesRequest request = new ListCasesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCasesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve all cases under a parent, but not its children.
        /// 
        /// For example, listing cases under an organization only returns the cases
        /// that are directly parented by that organization. To retrieve cases
        /// under an organization and its projects, use `cases.search`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of a parent to list cases under.
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
        /// <returns>A pageable sequence of <see cref="Case"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCasesResponse, Case> ListCases(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCasesRequest request = new ListCasesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCases(request, callSettings);
        }

        /// <summary>
        /// Retrieve all cases under a parent, but not its children.
        /// 
        /// For example, listing cases under an organization only returns the cases
        /// that are directly parented by that organization. To retrieve cases
        /// under an organization and its projects, use `cases.search`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of a parent to list cases under.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Case"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCasesResponse, Case> ListCasesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCasesRequest request = new ListCasesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCasesAsync(request, callSettings);
        }

        /// <summary>
        /// Search for cases using a query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Case"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchCasesResponse, Case> SearchCases(SearchCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search for cases using a query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Case"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchCasesResponse, Case> SearchCasesAsync(SearchCasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Case CreateCase(CreateCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> CreateCaseAsync(CreateCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> CreateCaseAsync(CreateCaseRequest request, st::CancellationToken cancellationToken) =>
            CreateCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent under which the case should be created.
        /// </param>
        /// <param name="case">
        /// Required. The case to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Case CreateCase(string parent, Case @case, gaxgrpc::CallSettings callSettings = null) =>
            CreateCase(new CreateCaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Case = gax::GaxPreconditions.CheckNotNull(@case, nameof(@case)),
            }, callSettings);

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent under which the case should be created.
        /// </param>
        /// <param name="case">
        /// Required. The case to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> CreateCaseAsync(string parent, Case @case, gaxgrpc::CallSettings callSettings = null) =>
            CreateCaseAsync(new CreateCaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Case = gax::GaxPreconditions.CheckNotNull(@case, nameof(@case)),
            }, callSettings);

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent under which the case should be created.
        /// </param>
        /// <param name="case">
        /// Required. The case to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> CreateCaseAsync(string parent, Case @case, st::CancellationToken cancellationToken) =>
            CreateCaseAsync(parent, @case, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent under which the case should be created.
        /// </param>
        /// <param name="case">
        /// Required. The case to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Case CreateCase(gagr::OrganizationName parent, Case @case, gaxgrpc::CallSettings callSettings = null) =>
            CreateCase(new CreateCaseRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Case = gax::GaxPreconditions.CheckNotNull(@case, nameof(@case)),
            }, callSettings);

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent under which the case should be created.
        /// </param>
        /// <param name="case">
        /// Required. The case to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> CreateCaseAsync(gagr::OrganizationName parent, Case @case, gaxgrpc::CallSettings callSettings = null) =>
            CreateCaseAsync(new CreateCaseRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Case = gax::GaxPreconditions.CheckNotNull(@case, nameof(@case)),
            }, callSettings);

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent under which the case should be created.
        /// </param>
        /// <param name="case">
        /// Required. The case to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> CreateCaseAsync(gagr::OrganizationName parent, Case @case, st::CancellationToken cancellationToken) =>
            CreateCaseAsync(parent, @case, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent under which the case should be created.
        /// </param>
        /// <param name="case">
        /// Required. The case to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Case CreateCase(gagr::ProjectName parent, Case @case, gaxgrpc::CallSettings callSettings = null) =>
            CreateCase(new CreateCaseRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Case = gax::GaxPreconditions.CheckNotNull(@case, nameof(@case)),
            }, callSettings);

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent under which the case should be created.
        /// </param>
        /// <param name="case">
        /// Required. The case to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> CreateCaseAsync(gagr::ProjectName parent, Case @case, gaxgrpc::CallSettings callSettings = null) =>
            CreateCaseAsync(new CreateCaseRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Case = gax::GaxPreconditions.CheckNotNull(@case, nameof(@case)),
            }, callSettings);

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent under which the case should be created.
        /// </param>
        /// <param name="case">
        /// Required. The case to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> CreateCaseAsync(gagr::ProjectName parent, Case @case, st::CancellationToken cancellationToken) =>
            CreateCaseAsync(parent, @case, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a case. Only some fields can be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Case UpdateCase(UpdateCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a case. Only some fields can be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> UpdateCaseAsync(UpdateCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a case. Only some fields can be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> UpdateCaseAsync(UpdateCaseRequest request, st::CancellationToken cancellationToken) =>
            UpdateCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a case. Only some fields can be updated.
        /// </summary>
        /// <param name="case">
        /// Required. The case to update.
        /// </param>
        /// <param name="updateMask">
        /// A list of attributes of the case that should be updated. Supported values
        /// are `priority`, `display_name`, and `subscriber_email_addresses`. If no
        /// fields are specified, all supported fields are updated.
        /// 
        /// Be careful - if you do not provide a field mask, then you might
        /// accidentally clear some fields. For example, if you leave the field mask
        /// empty and do not provide a value for `subscriber_email_addresses`, then
        /// `subscriber_email_addresses` is updated to empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Case UpdateCase(Case @case, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCase(new UpdateCaseRequest
            {
                Case = gax::GaxPreconditions.CheckNotNull(@case, nameof(@case)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a case. Only some fields can be updated.
        /// </summary>
        /// <param name="case">
        /// Required. The case to update.
        /// </param>
        /// <param name="updateMask">
        /// A list of attributes of the case that should be updated. Supported values
        /// are `priority`, `display_name`, and `subscriber_email_addresses`. If no
        /// fields are specified, all supported fields are updated.
        /// 
        /// Be careful - if you do not provide a field mask, then you might
        /// accidentally clear some fields. For example, if you leave the field mask
        /// empty and do not provide a value for `subscriber_email_addresses`, then
        /// `subscriber_email_addresses` is updated to empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> UpdateCaseAsync(Case @case, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCaseAsync(new UpdateCaseRequest
            {
                Case = gax::GaxPreconditions.CheckNotNull(@case, nameof(@case)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a case. Only some fields can be updated.
        /// </summary>
        /// <param name="case">
        /// Required. The case to update.
        /// </param>
        /// <param name="updateMask">
        /// A list of attributes of the case that should be updated. Supported values
        /// are `priority`, `display_name`, and `subscriber_email_addresses`. If no
        /// fields are specified, all supported fields are updated.
        /// 
        /// Be careful - if you do not provide a field mask, then you might
        /// accidentally clear some fields. For example, if you leave the field mask
        /// empty and do not provide a value for `subscriber_email_addresses`, then
        /// `subscriber_email_addresses` is updated to empty.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> UpdateCaseAsync(Case @case, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCaseAsync(@case, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Escalate a case, starting the Google Cloud Support escalation management
        /// process.
        /// 
        /// This operation is only available for some support services. Go to
        /// https://cloud.google.com/support and look for 'Technical support
        /// escalations' in the feature list to find out which ones let you
        /// do that.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Case EscalateCase(EscalateCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Escalate a case, starting the Google Cloud Support escalation management
        /// process.
        /// 
        /// This operation is only available for some support services. Go to
        /// https://cloud.google.com/support and look for 'Technical support
        /// escalations' in the feature list to find out which ones let you
        /// do that.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> EscalateCaseAsync(EscalateCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Escalate a case, starting the Google Cloud Support escalation management
        /// process.
        /// 
        /// This operation is only available for some support services. Go to
        /// https://cloud.google.com/support and look for 'Technical support
        /// escalations' in the feature list to find out which ones let you
        /// do that.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> EscalateCaseAsync(EscalateCaseRequest request, st::CancellationToken cancellationToken) =>
            EscalateCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Close a case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Case CloseCase(CloseCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Close a case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> CloseCaseAsync(CloseCaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Close a case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Case> CloseCaseAsync(CloseCaseRequest request, st::CancellationToken cancellationToken) =>
            CloseCaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve valid classifications to use when creating a support case.
        /// 
        /// Classifications are hierarchical. Each classification is a string
        /// containing all levels of the hierarchy separated by `" &gt; "`. For example,
        /// `"Technical Issue &gt; Compute &gt; Compute Engine"`.
        /// 
        /// Classification IDs returned by this endpoint are valid for at least six
        /// months. When a classification is deactivated, this endpoint immediately
        /// stops returning it. After six months, `case.create` requests using the
        /// classification will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CaseClassification"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchCaseClassificationsResponse, CaseClassification> SearchCaseClassifications(SearchCaseClassificationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve valid classifications to use when creating a support case.
        /// 
        /// Classifications are hierarchical. Each classification is a string
        /// containing all levels of the hierarchy separated by `" &gt; "`. For example,
        /// `"Technical Issue &gt; Compute &gt; Compute Engine"`.
        /// 
        /// Classification IDs returned by this endpoint are valid for at least six
        /// months. When a classification is deactivated, this endpoint immediately
        /// stops returning it. After six months, `case.create` requests using the
        /// classification will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CaseClassification"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchCaseClassificationsResponse, CaseClassification> SearchCaseClassificationsAsync(SearchCaseClassificationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>CaseService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service to manage Google Cloud support cases.
    /// </remarks>
    public sealed partial class CaseServiceClientImpl : CaseServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCaseRequest, Case> _callGetCase;

        private readonly gaxgrpc::ApiCall<ListCasesRequest, ListCasesResponse> _callListCases;

        private readonly gaxgrpc::ApiCall<SearchCasesRequest, SearchCasesResponse> _callSearchCases;

        private readonly gaxgrpc::ApiCall<CreateCaseRequest, Case> _callCreateCase;

        private readonly gaxgrpc::ApiCall<UpdateCaseRequest, Case> _callUpdateCase;

        private readonly gaxgrpc::ApiCall<EscalateCaseRequest, Case> _callEscalateCase;

        private readonly gaxgrpc::ApiCall<CloseCaseRequest, Case> _callCloseCase;

        private readonly gaxgrpc::ApiCall<SearchCaseClassificationsRequest, SearchCaseClassificationsResponse> _callSearchCaseClassifications;

        /// <summary>
        /// Constructs a client wrapper for the CaseService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CaseServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CaseServiceClientImpl(CaseService.CaseServiceClient grpcClient, CaseServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CaseServiceSettings effectiveSettings = settings ?? CaseServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCase = clientHelper.BuildApiCall<GetCaseRequest, Case>("GetCase", grpcClient.GetCaseAsync, grpcClient.GetCase, effectiveSettings.GetCaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCase);
            Modify_GetCaseApiCall(ref _callGetCase);
            _callListCases = clientHelper.BuildApiCall<ListCasesRequest, ListCasesResponse>("ListCases", grpcClient.ListCasesAsync, grpcClient.ListCases, effectiveSettings.ListCasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCases);
            Modify_ListCasesApiCall(ref _callListCases);
            _callSearchCases = clientHelper.BuildApiCall<SearchCasesRequest, SearchCasesResponse>("SearchCases", grpcClient.SearchCasesAsync, grpcClient.SearchCases, effectiveSettings.SearchCasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchCases);
            Modify_SearchCasesApiCall(ref _callSearchCases);
            _callCreateCase = clientHelper.BuildApiCall<CreateCaseRequest, Case>("CreateCase", grpcClient.CreateCaseAsync, grpcClient.CreateCase, effectiveSettings.CreateCaseSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCase);
            Modify_CreateCaseApiCall(ref _callCreateCase);
            _callUpdateCase = clientHelper.BuildApiCall<UpdateCaseRequest, Case>("UpdateCase", grpcClient.UpdateCaseAsync, grpcClient.UpdateCase, effectiveSettings.UpdateCaseSettings).WithGoogleRequestParam("case.name", request => request.Case?.Name);
            Modify_ApiCall(ref _callUpdateCase);
            Modify_UpdateCaseApiCall(ref _callUpdateCase);
            _callEscalateCase = clientHelper.BuildApiCall<EscalateCaseRequest, Case>("EscalateCase", grpcClient.EscalateCaseAsync, grpcClient.EscalateCase, effectiveSettings.EscalateCaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEscalateCase);
            Modify_EscalateCaseApiCall(ref _callEscalateCase);
            _callCloseCase = clientHelper.BuildApiCall<CloseCaseRequest, Case>("CloseCase", grpcClient.CloseCaseAsync, grpcClient.CloseCase, effectiveSettings.CloseCaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCloseCase);
            Modify_CloseCaseApiCall(ref _callCloseCase);
            _callSearchCaseClassifications = clientHelper.BuildApiCall<SearchCaseClassificationsRequest, SearchCaseClassificationsResponse>("SearchCaseClassifications", grpcClient.SearchCaseClassificationsAsync, grpcClient.SearchCaseClassifications, effectiveSettings.SearchCaseClassificationsSettings);
            Modify_ApiCall(ref _callSearchCaseClassifications);
            Modify_SearchCaseClassificationsApiCall(ref _callSearchCaseClassifications);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCaseApiCall(ref gaxgrpc::ApiCall<GetCaseRequest, Case> call);

        partial void Modify_ListCasesApiCall(ref gaxgrpc::ApiCall<ListCasesRequest, ListCasesResponse> call);

        partial void Modify_SearchCasesApiCall(ref gaxgrpc::ApiCall<SearchCasesRequest, SearchCasesResponse> call);

        partial void Modify_CreateCaseApiCall(ref gaxgrpc::ApiCall<CreateCaseRequest, Case> call);

        partial void Modify_UpdateCaseApiCall(ref gaxgrpc::ApiCall<UpdateCaseRequest, Case> call);

        partial void Modify_EscalateCaseApiCall(ref gaxgrpc::ApiCall<EscalateCaseRequest, Case> call);

        partial void Modify_CloseCaseApiCall(ref gaxgrpc::ApiCall<CloseCaseRequest, Case> call);

        partial void Modify_SearchCaseClassificationsApiCall(ref gaxgrpc::ApiCall<SearchCaseClassificationsRequest, SearchCaseClassificationsResponse> call);

        partial void OnConstruction(CaseService.CaseServiceClient grpcClient, CaseServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CaseService client</summary>
        public override CaseService.CaseServiceClient GrpcClient { get; }

        partial void Modify_GetCaseRequest(ref GetCaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCasesRequest(ref ListCasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchCasesRequest(ref SearchCasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCaseRequest(ref CreateCaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCaseRequest(ref UpdateCaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EscalateCaseRequest(ref EscalateCaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CloseCaseRequest(ref CloseCaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchCaseClassificationsRequest(ref SearchCaseClassificationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieve a case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Case GetCase(GetCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCaseRequest(ref request, ref callSettings);
            return _callGetCase.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve a case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Case> GetCaseAsync(GetCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCaseRequest(ref request, ref callSettings);
            return _callGetCase.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve all cases under a parent, but not its children.
        /// 
        /// For example, listing cases under an organization only returns the cases
        /// that are directly parented by that organization. To retrieve cases
        /// under an organization and its projects, use `cases.search`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Case"/> resources.</returns>
        public override gax::PagedEnumerable<ListCasesResponse, Case> ListCases(ListCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCasesRequest, ListCasesResponse, Case>(_callListCases, request, callSettings);
        }

        /// <summary>
        /// Retrieve all cases under a parent, but not its children.
        /// 
        /// For example, listing cases under an organization only returns the cases
        /// that are directly parented by that organization. To retrieve cases
        /// under an organization and its projects, use `cases.search`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Case"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCasesResponse, Case> ListCasesAsync(ListCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCasesRequest, ListCasesResponse, Case>(_callListCases, request, callSettings);
        }

        /// <summary>
        /// Search for cases using a query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Case"/> resources.</returns>
        public override gax::PagedEnumerable<SearchCasesResponse, Case> SearchCases(SearchCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchCasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchCasesRequest, SearchCasesResponse, Case>(_callSearchCases, request, callSettings);
        }

        /// <summary>
        /// Search for cases using a query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Case"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchCasesResponse, Case> SearchCasesAsync(SearchCasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchCasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchCasesRequest, SearchCasesResponse, Case>(_callSearchCases, request, callSettings);
        }

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Case CreateCase(CreateCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCaseRequest(ref request, ref callSettings);
            return _callCreateCase.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new case and associate it with a parent.
        /// 
        /// It must have the following fields set: `display_name`, `description`,
        /// `classification`, and `priority`. If you're just testing the API and don't
        /// want to route your case to an agent, set `testCase=true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Case> CreateCaseAsync(CreateCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCaseRequest(ref request, ref callSettings);
            return _callCreateCase.Async(request, callSettings);
        }

        /// <summary>
        /// Update a case. Only some fields can be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Case UpdateCase(UpdateCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCaseRequest(ref request, ref callSettings);
            return _callUpdateCase.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a case. Only some fields can be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Case> UpdateCaseAsync(UpdateCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCaseRequest(ref request, ref callSettings);
            return _callUpdateCase.Async(request, callSettings);
        }

        /// <summary>
        /// Escalate a case, starting the Google Cloud Support escalation management
        /// process.
        /// 
        /// This operation is only available for some support services. Go to
        /// https://cloud.google.com/support and look for 'Technical support
        /// escalations' in the feature list to find out which ones let you
        /// do that.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Case EscalateCase(EscalateCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EscalateCaseRequest(ref request, ref callSettings);
            return _callEscalateCase.Sync(request, callSettings);
        }

        /// <summary>
        /// Escalate a case, starting the Google Cloud Support escalation management
        /// process.
        /// 
        /// This operation is only available for some support services. Go to
        /// https://cloud.google.com/support and look for 'Technical support
        /// escalations' in the feature list to find out which ones let you
        /// do that.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Case> EscalateCaseAsync(EscalateCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EscalateCaseRequest(ref request, ref callSettings);
            return _callEscalateCase.Async(request, callSettings);
        }

        /// <summary>
        /// Close a case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Case CloseCase(CloseCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CloseCaseRequest(ref request, ref callSettings);
            return _callCloseCase.Sync(request, callSettings);
        }

        /// <summary>
        /// Close a case.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Case> CloseCaseAsync(CloseCaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CloseCaseRequest(ref request, ref callSettings);
            return _callCloseCase.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve valid classifications to use when creating a support case.
        /// 
        /// Classifications are hierarchical. Each classification is a string
        /// containing all levels of the hierarchy separated by `" &gt; "`. For example,
        /// `"Technical Issue &gt; Compute &gt; Compute Engine"`.
        /// 
        /// Classification IDs returned by this endpoint are valid for at least six
        /// months. When a classification is deactivated, this endpoint immediately
        /// stops returning it. After six months, `case.create` requests using the
        /// classification will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CaseClassification"/> resources.</returns>
        public override gax::PagedEnumerable<SearchCaseClassificationsResponse, CaseClassification> SearchCaseClassifications(SearchCaseClassificationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchCaseClassificationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchCaseClassificationsRequest, SearchCaseClassificationsResponse, CaseClassification>(_callSearchCaseClassifications, request, callSettings);
        }

        /// <summary>
        /// Retrieve valid classifications to use when creating a support case.
        /// 
        /// Classifications are hierarchical. Each classification is a string
        /// containing all levels of the hierarchy separated by `" &gt; "`. For example,
        /// `"Technical Issue &gt; Compute &gt; Compute Engine"`.
        /// 
        /// Classification IDs returned by this endpoint are valid for at least six
        /// months. When a classification is deactivated, this endpoint immediately
        /// stops returning it. After six months, `case.create` requests using the
        /// classification will fail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CaseClassification"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchCaseClassificationsResponse, CaseClassification> SearchCaseClassificationsAsync(SearchCaseClassificationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchCaseClassificationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchCaseClassificationsRequest, SearchCaseClassificationsResponse, CaseClassification>(_callSearchCaseClassifications, request, callSettings);
        }
    }

    public partial class ListCasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchCasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchCaseClassificationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCasesResponse : gaxgrpc::IPageResponse<Case>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Case> GetEnumerator() => Cases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchCasesResponse : gaxgrpc::IPageResponse<Case>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Case> GetEnumerator() => Cases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchCaseClassificationsResponse : gaxgrpc::IPageResponse<CaseClassification>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CaseClassification> GetEnumerator() => CaseClassifications.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
