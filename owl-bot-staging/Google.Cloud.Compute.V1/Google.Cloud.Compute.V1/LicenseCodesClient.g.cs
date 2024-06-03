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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="LicenseCodesClient"/> instances.</summary>
    public sealed partial class LicenseCodesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LicenseCodesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LicenseCodesSettings"/>.</returns>
        public static LicenseCodesSettings GetDefault() => new LicenseCodesSettings();

        /// <summary>Constructs a new <see cref="LicenseCodesSettings"/> object with default settings.</summary>
        public LicenseCodesSettings()
        {
        }

        private LicenseCodesSettings(LicenseCodesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LicenseCodesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LicenseCodesClient.Get</c>
        /// and <c>LicenseCodesClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseCodesClient.TestIamPermissions</c> and <c>LicenseCodesClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LicenseCodesSettings"/> object.</returns>
        public LicenseCodesSettings Clone() => new LicenseCodesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LicenseCodesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class LicenseCodesClientBuilder : gaxgrpc::ClientBuilderBase<LicenseCodesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LicenseCodesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LicenseCodesClientBuilder() : base(LicenseCodesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LicenseCodesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LicenseCodesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LicenseCodesClient Build()
        {
            LicenseCodesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LicenseCodesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LicenseCodesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LicenseCodesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LicenseCodesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LicenseCodesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LicenseCodesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LicenseCodesClient.ChannelPool;
    }

    /// <summary>LicenseCodes client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The LicenseCodes API.
    /// </remarks>
    public abstract partial class LicenseCodesClient
    {
        /// <summary>
        /// The default endpoint for the LicenseCodes service, which is a host of "compute.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default LicenseCodes scopes.</summary>
        /// <remarks>
        /// The default LicenseCodes scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute.readonly",
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LicenseCodes.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LicenseCodesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LicenseCodesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LicenseCodesClient"/>.</returns>
        public static stt::Task<LicenseCodesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LicenseCodesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LicenseCodesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LicenseCodesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LicenseCodesClient"/>.</returns>
        public static LicenseCodesClient Create() => new LicenseCodesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LicenseCodesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LicenseCodesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LicenseCodesClient"/>.</returns>
        internal static LicenseCodesClient Create(grpccore::CallInvoker callInvoker, LicenseCodesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LicenseCodes.LicenseCodesClient grpcClient = new LicenseCodes.LicenseCodesClient(callInvoker);
            return new LicenseCodesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LicenseCodes client</summary>
        public virtual LicenseCodes.LicenseCodesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Return a specified license code. License codes are mirrored across all projects that have permissions to read the License Code. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LicenseCode Get(GetLicenseCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return a specified license code. License codes are mirrored across all projects that have permissions to read the License Code. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicenseCode> GetAsync(GetLicenseCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Return a specified license code. License codes are mirrored across all projects that have permissions to read the License Code. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicenseCode> GetAsync(GetLicenseCodeRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Return a specified license code. License codes are mirrored across all projects that have permissions to read the License Code. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="licenseCode">
        /// Number corresponding to the License code resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LicenseCode Get(string project, string licenseCode, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetLicenseCodeRequest
            {
                LicenseCode = gax::GaxPreconditions.CheckNotNullOrEmpty(licenseCode, nameof(licenseCode)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Return a specified license code. License codes are mirrored across all projects that have permissions to read the License Code. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="licenseCode">
        /// Number corresponding to the License code resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicenseCode> GetAsync(string project, string licenseCode, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetLicenseCodeRequest
            {
                LicenseCode = gax::GaxPreconditions.CheckNotNullOrEmpty(licenseCode, nameof(licenseCode)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Return a specified license code. License codes are mirrored across all projects that have permissions to read the License Code. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="licenseCode">
        /// Number corresponding to the License code resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicenseCode> GetAsync(string project, string licenseCode, st::CancellationToken cancellationToken) =>
            GetAsync(project, licenseCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(TestIamPermissionsLicenseCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsLicenseCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsLicenseCodeRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(string project, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new TestIamPermissionsLicenseCodeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new TestIamPermissionsLicenseCodeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string resource, TestPermissionsRequest testPermissionsRequestResource, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(project, resource, testPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LicenseCodes client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The LicenseCodes API.
    /// </remarks>
    public sealed partial class LicenseCodesClientImpl : LicenseCodesClient
    {
        private readonly gaxgrpc::ApiCall<GetLicenseCodeRequest, LicenseCode> _callGet;

        private readonly gaxgrpc::ApiCall<TestIamPermissionsLicenseCodeRequest, TestPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the LicenseCodes service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LicenseCodesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LicenseCodesClientImpl(LicenseCodes.LicenseCodesClient grpcClient, LicenseCodesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LicenseCodesSettings effectiveSettings = settings ?? LicenseCodesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGet = clientHelper.BuildApiCall<GetLicenseCodeRequest, LicenseCode>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("license_code", request => request.LicenseCode);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsLicenseCodeRequest, TestPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetLicenseCodeRequest, LicenseCode> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<TestIamPermissionsLicenseCodeRequest, TestPermissionsResponse> call);

        partial void OnConstruction(LicenseCodes.LicenseCodesClient grpcClient, LicenseCodesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LicenseCodes client</summary>
        public override LicenseCodes.LicenseCodesClient GrpcClient { get; }

        partial void Modify_GetLicenseCodeRequest(ref GetLicenseCodeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsLicenseCodeRequest(ref TestIamPermissionsLicenseCodeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Return a specified license code. License codes are mirrored across all projects that have permissions to read the License Code. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LicenseCode Get(GetLicenseCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLicenseCodeRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Return a specified license code. License codes are mirrored across all projects that have permissions to read the License Code. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LicenseCode> GetAsync(GetLicenseCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLicenseCodeRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestPermissionsResponse TestIamPermissions(TestIamPermissionsLicenseCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsLicenseCodeRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. *Caution* This resource is intended for use only by third-party partners who are creating Cloud Marketplace images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsLicenseCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsLicenseCodeRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }
}
