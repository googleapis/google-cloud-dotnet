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

namespace Google.Shopping.Merchant.DataSources.V1Beta
{
    /// <summary>Settings for <see cref="FileUploadsServiceClient"/> instances.</summary>
    public sealed partial class FileUploadsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FileUploadsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FileUploadsServiceSettings"/>.</returns>
        public static FileUploadsServiceSettings GetDefault() => new FileUploadsServiceSettings();

        /// <summary>Constructs a new <see cref="FileUploadsServiceSettings"/> object with default settings.</summary>
        public FileUploadsServiceSettings()
        {
        }

        private FileUploadsServiceSettings(FileUploadsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFileUploadSettings = existing.GetFileUploadSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FileUploadsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FileUploadsServiceClient.GetFileUpload</c> and <c>FileUploadsServiceClient.GetFileUploadAsync</c>.
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
        public gaxgrpc::CallSettings GetFileUploadSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FileUploadsServiceSettings"/> object.</returns>
        public FileUploadsServiceSettings Clone() => new FileUploadsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FileUploadsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class FileUploadsServiceClientBuilder : gaxgrpc::ClientBuilderBase<FileUploadsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FileUploadsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FileUploadsServiceClientBuilder() : base(FileUploadsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FileUploadsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FileUploadsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FileUploadsServiceClient Build()
        {
            FileUploadsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FileUploadsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FileUploadsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FileUploadsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FileUploadsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FileUploadsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FileUploadsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FileUploadsServiceClient.ChannelPool;
    }

    /// <summary>FileUploadsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage data source file uploads.
    /// </remarks>
    public abstract partial class FileUploadsServiceClient
    {
        /// <summary>
        /// The default endpoint for the FileUploadsService service, which is a host of "merchantapi.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default FileUploadsService scopes.</summary>
        /// <remarks>
        /// The default FileUploadsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FileUploadsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FileUploadsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FileUploadsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FileUploadsServiceClient"/>.</returns>
        public static stt::Task<FileUploadsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FileUploadsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FileUploadsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FileUploadsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="FileUploadsServiceClient"/>.</returns>
        public static FileUploadsServiceClient Create() => new FileUploadsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FileUploadsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FileUploadsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FileUploadsServiceClient"/>.</returns>
        internal static FileUploadsServiceClient Create(grpccore::CallInvoker callInvoker, FileUploadsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FileUploadsService.FileUploadsServiceClient grpcClient = new FileUploadsService.FileUploadsServiceClient(callInvoker);
            return new FileUploadsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FileUploadsService client</summary>
        public virtual FileUploadsService.FileUploadsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the latest data source file upload. Only the `latest` alias is
        /// accepted for a file upload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FileUpload GetFileUpload(GetFileUploadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the latest data source file upload. Only the `latest` alias is
        /// accepted for a file upload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileUpload> GetFileUploadAsync(GetFileUploadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the latest data source file upload. Only the `latest` alias is
        /// accepted for a file upload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileUpload> GetFileUploadAsync(GetFileUploadRequest request, st::CancellationToken cancellationToken) =>
            GetFileUploadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest data source file upload. Only the `latest` alias is
        /// accepted for a file upload.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source file upload to retrieve.
        /// Format:
        /// `accounts/{account}/dataSources/{datasource}/fileUploads/latest`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FileUpload GetFileUpload(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFileUpload(new GetFileUploadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest data source file upload. Only the `latest` alias is
        /// accepted for a file upload.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source file upload to retrieve.
        /// Format:
        /// `accounts/{account}/dataSources/{datasource}/fileUploads/latest`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileUpload> GetFileUploadAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFileUploadAsync(new GetFileUploadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest data source file upload. Only the `latest` alias is
        /// accepted for a file upload.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source file upload to retrieve.
        /// Format:
        /// `accounts/{account}/dataSources/{datasource}/fileUploads/latest`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileUpload> GetFileUploadAsync(string name, st::CancellationToken cancellationToken) =>
            GetFileUploadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest data source file upload. Only the `latest` alias is
        /// accepted for a file upload.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source file upload to retrieve.
        /// Format:
        /// `accounts/{account}/dataSources/{datasource}/fileUploads/latest`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FileUpload GetFileUpload(FileUploadName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFileUpload(new GetFileUploadRequest
            {
                FileUploadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest data source file upload. Only the `latest` alias is
        /// accepted for a file upload.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source file upload to retrieve.
        /// Format:
        /// `accounts/{account}/dataSources/{datasource}/fileUploads/latest`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileUpload> GetFileUploadAsync(FileUploadName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFileUploadAsync(new GetFileUploadRequest
            {
                FileUploadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest data source file upload. Only the `latest` alias is
        /// accepted for a file upload.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source file upload to retrieve.
        /// Format:
        /// `accounts/{account}/dataSources/{datasource}/fileUploads/latest`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileUpload> GetFileUploadAsync(FileUploadName name, st::CancellationToken cancellationToken) =>
            GetFileUploadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FileUploadsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage data source file uploads.
    /// </remarks>
    public sealed partial class FileUploadsServiceClientImpl : FileUploadsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetFileUploadRequest, FileUpload> _callGetFileUpload;

        /// <summary>
        /// Constructs a client wrapper for the FileUploadsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FileUploadsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FileUploadsServiceClientImpl(FileUploadsService.FileUploadsServiceClient grpcClient, FileUploadsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FileUploadsServiceSettings effectiveSettings = settings ?? FileUploadsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetFileUpload = clientHelper.BuildApiCall<GetFileUploadRequest, FileUpload>("GetFileUpload", grpcClient.GetFileUploadAsync, grpcClient.GetFileUpload, effectiveSettings.GetFileUploadSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFileUpload);
            Modify_GetFileUploadApiCall(ref _callGetFileUpload);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetFileUploadApiCall(ref gaxgrpc::ApiCall<GetFileUploadRequest, FileUpload> call);

        partial void OnConstruction(FileUploadsService.FileUploadsServiceClient grpcClient, FileUploadsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FileUploadsService client</summary>
        public override FileUploadsService.FileUploadsServiceClient GrpcClient { get; }

        partial void Modify_GetFileUploadRequest(ref GetFileUploadRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the latest data source file upload. Only the `latest` alias is
        /// accepted for a file upload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FileUpload GetFileUpload(GetFileUploadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFileUploadRequest(ref request, ref callSettings);
            return _callGetFileUpload.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the latest data source file upload. Only the `latest` alias is
        /// accepted for a file upload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FileUpload> GetFileUploadAsync(GetFileUploadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFileUploadRequest(ref request, ref callSettings);
            return _callGetFileUpload.Async(request, callSettings);
        }
    }
}
