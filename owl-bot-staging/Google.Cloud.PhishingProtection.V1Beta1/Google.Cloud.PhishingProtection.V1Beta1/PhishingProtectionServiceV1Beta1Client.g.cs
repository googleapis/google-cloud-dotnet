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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.PhishingProtection.V1Beta1
{
    /// <summary>Settings for <see cref="PhishingProtectionServiceV1Beta1Client"/> instances.</summary>
    public sealed partial class PhishingProtectionServiceV1Beta1Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PhishingProtectionServiceV1Beta1Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PhishingProtectionServiceV1Beta1Settings"/>.</returns>
        public static PhishingProtectionServiceV1Beta1Settings GetDefault() => new PhishingProtectionServiceV1Beta1Settings();

        /// <summary>
        /// Constructs a new <see cref="PhishingProtectionServiceV1Beta1Settings"/> object with default settings.
        /// </summary>
        public PhishingProtectionServiceV1Beta1Settings()
        {
        }

        private PhishingProtectionServiceV1Beta1Settings(PhishingProtectionServiceV1Beta1Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ReportPhishingSettings = existing.ReportPhishingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PhishingProtectionServiceV1Beta1Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhishingProtectionServiceV1Beta1Client.ReportPhishing</c> and
        /// <c>PhishingProtectionServiceV1Beta1Client.ReportPhishingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportPhishingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PhishingProtectionServiceV1Beta1Settings"/> object.</returns>
        public PhishingProtectionServiceV1Beta1Settings Clone() => new PhishingProtectionServiceV1Beta1Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PhishingProtectionServiceV1Beta1Client"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class PhishingProtectionServiceV1Beta1ClientBuilder : gaxgrpc::ClientBuilderBase<PhishingProtectionServiceV1Beta1Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PhishingProtectionServiceV1Beta1Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PhishingProtectionServiceV1Beta1ClientBuilder() : base(PhishingProtectionServiceV1Beta1Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PhishingProtectionServiceV1Beta1Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PhishingProtectionServiceV1Beta1Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override PhishingProtectionServiceV1Beta1Client Build()
        {
            PhishingProtectionServiceV1Beta1Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PhishingProtectionServiceV1Beta1Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PhishingProtectionServiceV1Beta1Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PhishingProtectionServiceV1Beta1Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PhishingProtectionServiceV1Beta1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PhishingProtectionServiceV1Beta1Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PhishingProtectionServiceV1Beta1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PhishingProtectionServiceV1Beta1Client.ChannelPool;
    }

    /// <summary>PhishingProtectionServiceV1Beta1 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to report phishing URIs.
    /// </remarks>
    public abstract partial class PhishingProtectionServiceV1Beta1Client
    {
        /// <summary>
        /// The default endpoint for the PhishingProtectionServiceV1Beta1 service, which is a host of
        /// "phishingprotection.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "phishingprotection.googleapis.com:443";

        /// <summary>The default PhishingProtectionServiceV1Beta1 scopes.</summary>
        /// <remarks>
        /// The default PhishingProtectionServiceV1Beta1 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PhishingProtectionServiceV1Beta1.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PhishingProtectionServiceV1Beta1Client"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PhishingProtectionServiceV1Beta1ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PhishingProtectionServiceV1Beta1Client"/>.</returns>
        public static stt::Task<PhishingProtectionServiceV1Beta1Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PhishingProtectionServiceV1Beta1ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PhishingProtectionServiceV1Beta1Client"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PhishingProtectionServiceV1Beta1ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PhishingProtectionServiceV1Beta1Client"/>.</returns>
        public static PhishingProtectionServiceV1Beta1Client Create() =>
            new PhishingProtectionServiceV1Beta1ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PhishingProtectionServiceV1Beta1Client"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PhishingProtectionServiceV1Beta1Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PhishingProtectionServiceV1Beta1Client"/>.</returns>
        internal static PhishingProtectionServiceV1Beta1Client Create(grpccore::CallInvoker callInvoker, PhishingProtectionServiceV1Beta1Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client grpcClient = new PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client(callInvoker);
            return new PhishingProtectionServiceV1Beta1ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PhishingProtectionServiceV1Beta1 client</summary>
        public virtual PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is complete, its result can be found in the Cloud
        /// Security Command Center findings dashboard for Phishing Protection. If the
        /// result verifies the existence of malicious phishing content, the site will
        /// be added the to [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportPhishingResponse ReportPhishing(ReportPhishingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is complete, its result can be found in the Cloud
        /// Security Command Center findings dashboard for Phishing Protection. If the
        /// result verifies the existence of malicious phishing content, the site will
        /// be added the to [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportPhishingResponse> ReportPhishingAsync(ReportPhishingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is complete, its result can be found in the Cloud
        /// Security Command Center findings dashboard for Phishing Protection. If the
        /// result verifies the existence of malicious phishing content, the site will
        /// be added the to [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportPhishingResponse> ReportPhishingAsync(ReportPhishingRequest request, st::CancellationToken cancellationToken) =>
            ReportPhishingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is complete, its result can be found in the Cloud
        /// Security Command Center findings dashboard for Phishing Protection. If the
        /// result verifies the existence of malicious phishing content, the site will
        /// be added the to [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which the report will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="uri">
        /// Required. The URI that is being reported for phishing content to be analyzed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportPhishingResponse ReportPhishing(string parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            ReportPhishing(new ReportPhishingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is complete, its result can be found in the Cloud
        /// Security Command Center findings dashboard for Phishing Protection. If the
        /// result verifies the existence of malicious phishing content, the site will
        /// be added the to [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which the report will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="uri">
        /// Required. The URI that is being reported for phishing content to be analyzed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportPhishingResponse> ReportPhishingAsync(string parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            ReportPhishingAsync(new ReportPhishingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is complete, its result can be found in the Cloud
        /// Security Command Center findings dashboard for Phishing Protection. If the
        /// result verifies the existence of malicious phishing content, the site will
        /// be added the to [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which the report will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="uri">
        /// Required. The URI that is being reported for phishing content to be analyzed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportPhishingResponse> ReportPhishingAsync(string parent, string uri, st::CancellationToken cancellationToken) =>
            ReportPhishingAsync(parent, uri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is complete, its result can be found in the Cloud
        /// Security Command Center findings dashboard for Phishing Protection. If the
        /// result verifies the existence of malicious phishing content, the site will
        /// be added the to [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which the report will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="uri">
        /// Required. The URI that is being reported for phishing content to be analyzed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportPhishingResponse ReportPhishing(gagr::ProjectName parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            ReportPhishing(new ReportPhishingRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is complete, its result can be found in the Cloud
        /// Security Command Center findings dashboard for Phishing Protection. If the
        /// result verifies the existence of malicious phishing content, the site will
        /// be added the to [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which the report will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="uri">
        /// Required. The URI that is being reported for phishing content to be analyzed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportPhishingResponse> ReportPhishingAsync(gagr::ProjectName parent, string uri, gaxgrpc::CallSettings callSettings = null) =>
            ReportPhishingAsync(new ReportPhishingRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Uri = gax::GaxPreconditions.CheckNotNullOrEmpty(uri, nameof(uri)),
            }, callSettings);

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is complete, its result can be found in the Cloud
        /// Security Command Center findings dashboard for Phishing Protection. If the
        /// result verifies the existence of malicious phishing content, the site will
        /// be added the to [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which the report will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="uri">
        /// Required. The URI that is being reported for phishing content to be analyzed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportPhishingResponse> ReportPhishingAsync(gagr::ProjectName parent, string uri, st::CancellationToken cancellationToken) =>
            ReportPhishingAsync(parent, uri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PhishingProtectionServiceV1Beta1 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to report phishing URIs.
    /// </remarks>
    public sealed partial class PhishingProtectionServiceV1Beta1ClientImpl : PhishingProtectionServiceV1Beta1Client
    {
        private readonly gaxgrpc::ApiCall<ReportPhishingRequest, ReportPhishingResponse> _callReportPhishing;

        /// <summary>
        /// Constructs a client wrapper for the PhishingProtectionServiceV1Beta1 service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PhishingProtectionServiceV1Beta1Settings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PhishingProtectionServiceV1Beta1ClientImpl(PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client grpcClient, PhishingProtectionServiceV1Beta1Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PhishingProtectionServiceV1Beta1Settings effectiveSettings = settings ?? PhishingProtectionServiceV1Beta1Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callReportPhishing = clientHelper.BuildApiCall<ReportPhishingRequest, ReportPhishingResponse>("ReportPhishing", grpcClient.ReportPhishingAsync, grpcClient.ReportPhishing, effectiveSettings.ReportPhishingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callReportPhishing);
            Modify_ReportPhishingApiCall(ref _callReportPhishing);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ReportPhishingApiCall(ref gaxgrpc::ApiCall<ReportPhishingRequest, ReportPhishingResponse> call);

        partial void OnConstruction(PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client grpcClient, PhishingProtectionServiceV1Beta1Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PhishingProtectionServiceV1Beta1 client</summary>
        public override PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client GrpcClient { get; }

        partial void Modify_ReportPhishingRequest(ref ReportPhishingRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is complete, its result can be found in the Cloud
        /// Security Command Center findings dashboard for Phishing Protection. If the
        /// result verifies the existence of malicious phishing content, the site will
        /// be added the to [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportPhishingResponse ReportPhishing(ReportPhishingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportPhishingRequest(ref request, ref callSettings);
            return _callReportPhishing.Sync(request, callSettings);
        }

        /// <summary>
        /// Reports a URI suspected of containing phishing content to be reviewed. Once
        /// the report review is complete, its result can be found in the Cloud
        /// Security Command Center findings dashboard for Phishing Protection. If the
        /// result verifies the existence of malicious phishing content, the site will
        /// be added the to [Google's Social Engineering
        /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
        /// protect users that could get exposed to this threat in the future.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportPhishingResponse> ReportPhishingAsync(ReportPhishingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportPhishingRequest(ref request, ref callSettings);
            return _callReportPhishing.Async(request, callSettings);
        }
    }
}
