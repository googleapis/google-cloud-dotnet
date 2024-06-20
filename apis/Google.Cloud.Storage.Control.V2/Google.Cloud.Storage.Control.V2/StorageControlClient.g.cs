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

namespace Google.Cloud.Storage.Control.V2
{
    /// <summary>Settings for <see cref="StorageControlClient"/> instances.</summary>
    public sealed partial class StorageControlSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="StorageControlSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="StorageControlSettings"/>.</returns>
        public static StorageControlSettings GetDefault() => new StorageControlSettings();

        /// <summary>Constructs a new <see cref="StorageControlSettings"/> object with default settings.</summary>
        public StorageControlSettings()
        {
        }

        private StorageControlSettings(StorageControlSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateFolderSettings = existing.CreateFolderSettings;
            DeleteFolderSettings = existing.DeleteFolderSettings;
            GetFolderSettings = existing.GetFolderSettings;
            ListFoldersSettings = existing.ListFoldersSettings;
            RenameFolderSettings = existing.RenameFolderSettings;
            RenameFolderOperationsSettings = existing.RenameFolderOperationsSettings.Clone();
            GetStorageLayoutSettings = existing.GetStorageLayoutSettings;
            CreateManagedFolderSettings = existing.CreateManagedFolderSettings;
            DeleteManagedFolderSettings = existing.DeleteManagedFolderSettings;
            GetManagedFolderSettings = existing.GetManagedFolderSettings;
            ListManagedFoldersSettings = existing.ListManagedFoldersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(StorageControlSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.CreateFolder</c> and <c>StorageControlClient.CreateFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.DeleteFolder</c> and <c>StorageControlClient.DeleteFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.GetFolder</c> and <c>StorageControlClient.GetFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFolderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.ListFolders</c> and <c>StorageControlClient.ListFoldersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFoldersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.RenameFolder</c> and <c>StorageControlClient.RenameFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RenameFolderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>StorageControlClient.RenameFolder</c> and
        /// <c>StorageControlClient.RenameFolderAsync</c>.
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
        public lro::OperationsSettings RenameFolderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.GetStorageLayout</c> and <c>StorageControlClient.GetStorageLayoutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetStorageLayoutSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.CreateManagedFolder</c> and <c>StorageControlClient.CreateManagedFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateManagedFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.DeleteManagedFolder</c> and <c>StorageControlClient.DeleteManagedFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteManagedFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.GetManagedFolder</c> and <c>StorageControlClient.GetManagedFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetManagedFolderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageControlClient.ListManagedFolders</c> and <c>StorageControlClient.ListManagedFoldersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListManagedFoldersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="StorageControlSettings"/> object.</returns>
        public StorageControlSettings Clone() => new StorageControlSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StorageControlClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class StorageControlClientBuilder : gaxgrpc::ClientBuilderBase<StorageControlClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StorageControlSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public StorageControlClientBuilder() : base(StorageControlClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref StorageControlClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StorageControlClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StorageControlClient Build()
        {
            StorageControlClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StorageControlClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StorageControlClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StorageControlClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StorageControlClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<StorageControlClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StorageControlClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => StorageControlClient.ChannelPool;
    }

    /// <summary>StorageControl client wrapper, for convenient use.</summary>
    /// <remarks>
    /// StorageControl service includes selected control plane operations.
    /// </remarks>
    public abstract partial class StorageControlClient
    {
        /// <summary>
        /// The default endpoint for the StorageControl service, which is a host of "storage.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "storage.googleapis.com:443";

        /// <summary>The default StorageControl scopes.</summary>
        /// <remarks>
        /// The default StorageControl scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.full_control</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.read_only</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.read_write</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/devstorage.full_control",
            "https://www.googleapis.com/auth/devstorage.read_only",
            "https://www.googleapis.com/auth/devstorage.read_write",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(StorageControl.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="StorageControlClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StorageControlClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StorageControlClient"/>.</returns>
        public static stt::Task<StorageControlClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StorageControlClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StorageControlClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StorageControlClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StorageControlClient"/>.</returns>
        public static StorageControlClient Create() => new StorageControlClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StorageControlClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StorageControlSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="StorageControlClient"/>.</returns>
        internal static StorageControlClient Create(grpccore::CallInvoker callInvoker, StorageControlSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            StorageControl.StorageControlClient grpcClient = new StorageControl.StorageControlClient(callInvoker);
            return new StorageControlClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC StorageControl client</summary>
        public virtual StorageControl.StorageControlClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder CreateFolder(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(CreateFolderRequest request, st::CancellationToken cancellationToken) =>
            CreateFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder CreateFolder(string parent, Folder folder, string folderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolder(new CreateFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                FolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(string parent, Folder folder, string folderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolderAsync(new CreateFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                FolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(string parent, Folder folder, string folderId, st::CancellationToken cancellationToken) =>
            CreateFolderAsync(parent, folder, folderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder CreateFolder(BucketName parent, Folder folder, string folderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolder(new CreateFolderRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                FolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(BucketName parent, Folder folder, string folderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolderAsync(new CreateFolderRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                FolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which the folder will reside. The bucket
        /// must be a hierarchical namespace enabled bucket.
        /// </param>
        /// <param name="folder">
        /// Required. Properties of the new folder being created.
        /// The bucket and name of the folder are specified in the parent and folder_id
        /// fields, respectively. Populating those fields in `folder` will result in an
        /// error.
        /// </param>
        /// <param name="folderId">
        /// Required. The full name of a folder, including all its parent folders.
        /// Folders use single '/' characters as a delimiter.
        /// The folder_id must end with a slash.
        /// For example, the folder_id of "books/biographies/" would create a new
        /// "biographies/" folder under the "books/" folder.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(BucketName parent, Folder folder, string folderId, st::CancellationToken cancellationToken) =>
            CreateFolderAsync(parent, folder, folderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFolder(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(DeleteFolderRequest request, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolder(new DeleteFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolderAsync(new DeleteFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFolder(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolder(new DeleteFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolderAsync(new DeleteFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(FolderName name, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(GetFolderRequest request, st::CancellationToken cancellationToken) =>
            GetFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolder(new GetFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderAsync(new GetFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(string name, st::CancellationToken cancellationToken) =>
            GetFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolder(new GetFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderAsync(new GetFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the folder.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(FolderName name, st::CancellationToken cancellationToken) =>
            GetFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFoldersResponse, Folder> ListFolders(ListFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(ListFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for folders. The bucket must
        /// be a hierarchical namespace enabled bucket.
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
        /// <returns>A pageable sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFoldersResponse, Folder> ListFolders(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFolders(new ListFoldersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for folders. The bucket must
        /// be a hierarchical namespace enabled bucket.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFoldersAsync(new ListFoldersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for folders. The bucket must
        /// be a hierarchical namespace enabled bucket.
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
        /// <returns>A pageable sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFoldersResponse, Folder> ListFolders(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFolders(new ListFoldersRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket in which to look for folders. The bucket must
        /// be a hierarchical namespace enabled bucket.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFoldersAsync(new ListFoldersRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, RenameFolderMetadata> RenameFolder(RenameFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(RenameFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(RenameFolderRequest request, st::CancellationToken cancellationToken) =>
            RenameFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RenameFolder</c>.</summary>
        public virtual lro::OperationsClient RenameFolderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RenameFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Folder, RenameFolderMetadata> PollOnceRenameFolder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, RenameFolderMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RenameFolderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RenameFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> PollOnceRenameFolderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, RenameFolderMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RenameFolderOperationsClient, callSettings);

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, RenameFolderMetadata> RenameFolder(string name, string destinationFolderId, gaxgrpc::CallSettings callSettings = null) =>
            RenameFolder(new RenameFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationFolderId, nameof(destinationFolderId)),
            }, callSettings);

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(string name, string destinationFolderId, gaxgrpc::CallSettings callSettings = null) =>
            RenameFolderAsync(new RenameFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationFolderId, nameof(destinationFolderId)),
            }, callSettings);

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(string name, string destinationFolderId, st::CancellationToken cancellationToken) =>
            RenameFolderAsync(name, destinationFolderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, RenameFolderMetadata> RenameFolder(FolderName name, string destinationFolderId, gaxgrpc::CallSettings callSettings = null) =>
            RenameFolder(new RenameFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationFolderId, nameof(destinationFolderId)),
            }, callSettings);

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(FolderName name, string destinationFolderId, gaxgrpc::CallSettings callSettings = null) =>
            RenameFolderAsync(new RenameFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationFolderId, nameof(destinationFolderId)),
            }, callSettings);

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the source folder being renamed.
        /// Format: `projects/{project}/buckets/{bucket}/folders/{folder}`
        /// </param>
        /// <param name="destinationFolderId">
        /// Required. The destination folder ID, e.g. `foo/bar/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(FolderName name, string destinationFolderId, st::CancellationToken cancellationToken) =>
            RenameFolderAsync(name, destinationFolderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StorageLayout GetStorageLayout(GetStorageLayoutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(GetStorageLayoutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(GetStorageLayoutRequest request, st::CancellationToken cancellationToken) =>
            GetStorageLayoutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StorageLayout GetStorageLayout(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStorageLayout(new GetStorageLayoutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStorageLayoutAsync(new GetStorageLayoutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(string name, st::CancellationToken cancellationToken) =>
            GetStorageLayoutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StorageLayout GetStorageLayout(StorageLayoutName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStorageLayout(new GetStorageLayoutRequest
            {
                StorageLayoutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(StorageLayoutName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStorageLayoutAsync(new GetStorageLayoutRequest
            {
                StorageLayoutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the StorageLayout resource.
        /// Format: `projects/{project}/buckets/{bucket}/storageLayout`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StorageLayout> GetStorageLayoutAsync(StorageLayoutName name, st::CancellationToken cancellationToken) =>
            GetStorageLayoutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder CreateManagedFolder(CreateManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(CreateManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(CreateManagedFolderRequest request, st::CancellationToken cancellationToken) =>
            CreateManagedFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder CreateManagedFolder(string parent, ManagedFolder managedFolder, string managedFolderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagedFolder(new CreateManagedFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ManagedFolder = gax::GaxPreconditions.CheckNotNull(managedFolder, nameof(managedFolder)),
                ManagedFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(managedFolderId, nameof(managedFolderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(string parent, ManagedFolder managedFolder, string managedFolderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagedFolderAsync(new CreateManagedFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ManagedFolder = gax::GaxPreconditions.CheckNotNull(managedFolder, nameof(managedFolder)),
                ManagedFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(managedFolderId, nameof(managedFolderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(string parent, ManagedFolder managedFolder, string managedFolderId, st::CancellationToken cancellationToken) =>
            CreateManagedFolderAsync(parent, managedFolder, managedFolderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder CreateManagedFolder(BucketName parent, ManagedFolder managedFolder, string managedFolderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagedFolder(new CreateManagedFolderRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ManagedFolder = gax::GaxPreconditions.CheckNotNull(managedFolder, nameof(managedFolder)),
                ManagedFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(managedFolderId, nameof(managedFolderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(BucketName parent, ManagedFolder managedFolder, string managedFolderId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagedFolderAsync(new CreateManagedFolderRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ManagedFolder = gax::GaxPreconditions.CheckNotNull(managedFolder, nameof(managedFolder)),
                ManagedFolderId = gax::GaxPreconditions.CheckNotNullOrEmpty(managedFolderId, nameof(managedFolderId)),
            }, callSettings);

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
        /// </param>
        /// <param name="managedFolder">
        /// Required. Properties of the managed folder being created.
        /// The bucket and managed folder names are specified in the `parent` and
        /// `managed_folder_id` fields. Populating these fields in `managed_folder`
        /// will result in an error.
        /// </param>
        /// <param name="managedFolderId">
        /// Required. The name of the managed folder. It uses a single `/` as delimiter
        /// and leading and trailing `/` are allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> CreateManagedFolderAsync(BucketName parent, ManagedFolder managedFolder, string managedFolderId, st::CancellationToken cancellationToken) =>
            CreateManagedFolderAsync(parent, managedFolder, managedFolderId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteManagedFolder(DeleteManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(DeleteManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(DeleteManagedFolderRequest request, st::CancellationToken cancellationToken) =>
            DeleteManagedFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteManagedFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagedFolder(new DeleteManagedFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagedFolderAsync(new DeleteManagedFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteManagedFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteManagedFolder(ManagedFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagedFolder(new DeleteManagedFolderRequest
            {
                ManagedFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(ManagedFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagedFolderAsync(new DeleteManagedFolderRequest
            {
                ManagedFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteManagedFolderAsync(ManagedFolderName name, st::CancellationToken cancellationToken) =>
            DeleteManagedFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder GetManagedFolder(GetManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(GetManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(GetManagedFolderRequest request, st::CancellationToken cancellationToken) =>
            GetManagedFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder GetManagedFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedFolder(new GetManagedFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedFolderAsync(new GetManagedFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(string name, st::CancellationToken cancellationToken) =>
            GetManagedFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedFolder GetManagedFolder(ManagedFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedFolder(new GetManagedFolderRequest
            {
                ManagedFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(ManagedFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagedFolderAsync(new GetManagedFolderRequest
            {
                ManagedFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the managed folder.
        /// Format:
        /// `projects/{project}/buckets/{bucket}/managedFolders/{managedFolder}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedFolder> GetManagedFolderAsync(ManagedFolderName name, st::CancellationToken cancellationToken) =>
            GetManagedFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFolders(ListManagedFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFoldersAsync(ListManagedFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
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
        /// <returns>A pageable sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFolders(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListManagedFolders(new ListManagedFoldersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFoldersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListManagedFoldersAsync(new ListManagedFoldersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
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
        /// <returns>A pageable sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFolders(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListManagedFolders(new ListManagedFoldersRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the bucket this managed folder belongs to.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedFolder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFoldersAsync(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListManagedFoldersAsync(new ListManagedFoldersRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>StorageControl client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// StorageControl service includes selected control plane operations.
    /// </remarks>
    public sealed partial class StorageControlClientImpl : StorageControlClient
    {
        private readonly gaxgrpc::ApiCall<CreateFolderRequest, Folder> _callCreateFolder;

        private readonly gaxgrpc::ApiCall<DeleteFolderRequest, wkt::Empty> _callDeleteFolder;

        private readonly gaxgrpc::ApiCall<GetFolderRequest, Folder> _callGetFolder;

        private readonly gaxgrpc::ApiCall<ListFoldersRequest, ListFoldersResponse> _callListFolders;

        private readonly gaxgrpc::ApiCall<RenameFolderRequest, lro::Operation> _callRenameFolder;

        private readonly gaxgrpc::ApiCall<GetStorageLayoutRequest, StorageLayout> _callGetStorageLayout;

        private readonly gaxgrpc::ApiCall<CreateManagedFolderRequest, ManagedFolder> _callCreateManagedFolder;

        private readonly gaxgrpc::ApiCall<DeleteManagedFolderRequest, wkt::Empty> _callDeleteManagedFolder;

        private readonly gaxgrpc::ApiCall<GetManagedFolderRequest, ManagedFolder> _callGetManagedFolder;

        private readonly gaxgrpc::ApiCall<ListManagedFoldersRequest, ListManagedFoldersResponse> _callListManagedFolders;

        /// <summary>
        /// Constructs a client wrapper for the StorageControl service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="StorageControlSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public StorageControlClientImpl(StorageControl.StorageControlClient grpcClient, StorageControlSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            StorageControlSettings effectiveSettings = settings ?? StorageControlSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            RenameFolderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RenameFolderOperationsSettings, logger);
            _callCreateFolder = clientHelper.BuildApiCall<CreateFolderRequest, Folder>("CreateFolder", grpcClient.CreateFolderAsync, grpcClient.CreateFolder, effectiveSettings.CreateFolderSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callCreateFolder);
            Modify_CreateFolderApiCall(ref _callCreateFolder);
            _callDeleteFolder = clientHelper.BuildApiCall<DeleteFolderRequest, wkt::Empty>("DeleteFolder", grpcClient.DeleteFolderAsync, grpcClient.DeleteFolder, effectiveSettings.DeleteFolderSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteFolderRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteFolder);
            Modify_DeleteFolderApiCall(ref _callDeleteFolder);
            _callGetFolder = clientHelper.BuildApiCall<GetFolderRequest, Folder>("GetFolder", grpcClient.GetFolderAsync, grpcClient.GetFolder, effectiveSettings.GetFolderSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetFolderRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callGetFolder);
            Modify_GetFolderApiCall(ref _callGetFolder);
            _callListFolders = clientHelper.BuildApiCall<ListFoldersRequest, ListFoldersResponse>("ListFolders", grpcClient.ListFoldersAsync, grpcClient.ListFolders, effectiveSettings.ListFoldersSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callListFolders);
            Modify_ListFoldersApiCall(ref _callListFolders);
            _callRenameFolder = clientHelper.BuildApiCall<RenameFolderRequest, lro::Operation>("RenameFolder", grpcClient.RenameFolderAsync, grpcClient.RenameFolder, effectiveSettings.RenameFolderSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<RenameFolderRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callRenameFolder);
            Modify_RenameFolderApiCall(ref _callRenameFolder);
            _callGetStorageLayout = clientHelper.BuildApiCall<GetStorageLayoutRequest, StorageLayout>("GetStorageLayout", grpcClient.GetStorageLayoutAsync, grpcClient.GetStorageLayout, effectiveSettings.GetStorageLayoutSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetStorageLayoutRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callGetStorageLayout);
            Modify_GetStorageLayoutApiCall(ref _callGetStorageLayout);
            _callCreateManagedFolder = clientHelper.BuildApiCall<CreateManagedFolderRequest, ManagedFolder>("CreateManagedFolder", grpcClient.CreateManagedFolderAsync, grpcClient.CreateManagedFolder, effectiveSettings.CreateManagedFolderSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callCreateManagedFolder);
            Modify_CreateManagedFolderApiCall(ref _callCreateManagedFolder);
            _callDeleteManagedFolder = clientHelper.BuildApiCall<DeleteManagedFolderRequest, wkt::Empty>("DeleteManagedFolder", grpcClient.DeleteManagedFolderAsync, grpcClient.DeleteManagedFolder, effectiveSettings.DeleteManagedFolderSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteManagedFolderRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteManagedFolder);
            Modify_DeleteManagedFolderApiCall(ref _callDeleteManagedFolder);
            _callGetManagedFolder = clientHelper.BuildApiCall<GetManagedFolderRequest, ManagedFolder>("GetManagedFolder", grpcClient.GetManagedFolderAsync, grpcClient.GetManagedFolder, effectiveSettings.GetManagedFolderSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetManagedFolderRequest>().WithExtractedParameter("bucket", "^(projects/[^/]+/buckets/[^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callGetManagedFolder);
            Modify_GetManagedFolderApiCall(ref _callGetManagedFolder);
            _callListManagedFolders = clientHelper.BuildApiCall<ListManagedFoldersRequest, ListManagedFoldersResponse>("ListManagedFolders", grpcClient.ListManagedFoldersAsync, grpcClient.ListManagedFolders, effectiveSettings.ListManagedFoldersSettings).WithGoogleRequestParam("bucket", request => request.Parent);
            Modify_ApiCall(ref _callListManagedFolders);
            Modify_ListManagedFoldersApiCall(ref _callListManagedFolders);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateFolderApiCall(ref gaxgrpc::ApiCall<CreateFolderRequest, Folder> call);

        partial void Modify_DeleteFolderApiCall(ref gaxgrpc::ApiCall<DeleteFolderRequest, wkt::Empty> call);

        partial void Modify_GetFolderApiCall(ref gaxgrpc::ApiCall<GetFolderRequest, Folder> call);

        partial void Modify_ListFoldersApiCall(ref gaxgrpc::ApiCall<ListFoldersRequest, ListFoldersResponse> call);

        partial void Modify_RenameFolderApiCall(ref gaxgrpc::ApiCall<RenameFolderRequest, lro::Operation> call);

        partial void Modify_GetStorageLayoutApiCall(ref gaxgrpc::ApiCall<GetStorageLayoutRequest, StorageLayout> call);

        partial void Modify_CreateManagedFolderApiCall(ref gaxgrpc::ApiCall<CreateManagedFolderRequest, ManagedFolder> call);

        partial void Modify_DeleteManagedFolderApiCall(ref gaxgrpc::ApiCall<DeleteManagedFolderRequest, wkt::Empty> call);

        partial void Modify_GetManagedFolderApiCall(ref gaxgrpc::ApiCall<GetManagedFolderRequest, ManagedFolder> call);

        partial void Modify_ListManagedFoldersApiCall(ref gaxgrpc::ApiCall<ListManagedFoldersRequest, ListManagedFoldersResponse> call);

        partial void OnConstruction(StorageControl.StorageControlClient grpcClient, StorageControlSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC StorageControl client</summary>
        public override StorageControl.StorageControlClient GrpcClient { get; }

        partial void Modify_CreateFolderRequest(ref CreateFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFolderRequest(ref DeleteFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFolderRequest(ref GetFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFoldersRequest(ref ListFoldersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenameFolderRequest(ref RenameFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStorageLayoutRequest(ref GetStorageLayoutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateManagedFolderRequest(ref CreateManagedFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteManagedFolderRequest(ref DeleteManagedFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetManagedFolderRequest(ref GetManagedFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListManagedFoldersRequest(ref ListManagedFoldersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Folder CreateFolder(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_CreateFolderRequest(ref request, ref callSettings);
            return _callCreateFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new folder. This operation is only applicable to a hierarchical
        /// namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Folder> CreateFolderAsync(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_CreateFolderRequest(ref request, ref callSettings);
            return _callCreateFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteFolder(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_DeleteFolderRequest(ref request, ref callSettings);
            _callDeleteFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes an empty folder. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteFolderAsync(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_DeleteFolderRequest(ref request, ref callSettings);
            return _callDeleteFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Folder GetFolder(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetFolderRequest(ref request, ref callSettings);
            return _callGetFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Folder> GetFolderAsync(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetFolderRequest(ref request, ref callSettings);
            return _callGetFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Folder"/> resources.</returns>
        public override gax::PagedEnumerable<ListFoldersResponse, Folder> ListFolders(ListFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFoldersRequest, ListFoldersResponse, Folder>(_callListFolders, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of folders. This operation is only applicable to a
        /// hierarchical namespace enabled bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(ListFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFoldersRequest, ListFoldersResponse, Folder>(_callListFolders, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RenameFolder</c>.</summary>
        public override lro::OperationsClient RenameFolderOperationsClient { get; }

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Folder, RenameFolderMetadata> RenameFolder(RenameFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_RenameFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, RenameFolderMetadata>(_callRenameFolder.Sync(request, callSettings), RenameFolderOperationsClient);
        }

        /// <summary>
        /// Renames a source folder to a destination folder. This operation is only
        /// applicable to a hierarchical namespace enabled bucket. During a rename, the
        /// source and destination folders are locked until the long running operation
        /// completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Folder, RenameFolderMetadata>> RenameFolderAsync(RenameFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_RenameFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, RenameFolderMetadata>(await _callRenameFolder.Async(request, callSettings).ConfigureAwait(false), RenameFolderOperationsClient);
        }

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StorageLayout GetStorageLayout(GetStorageLayoutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetStorageLayoutRequest(ref request, ref callSettings);
            return _callGetStorageLayout.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the storage layout configuration for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StorageLayout> GetStorageLayoutAsync(GetStorageLayoutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetStorageLayoutRequest(ref request, ref callSettings);
            return _callGetStorageLayout.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ManagedFolder CreateManagedFolder(CreateManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_CreateManagedFolderRequest(ref request, ref callSettings);
            return _callCreateManagedFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ManagedFolder> CreateManagedFolderAsync(CreateManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_CreateManagedFolderRequest(ref request, ref callSettings);
            return _callCreateManagedFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteManagedFolder(DeleteManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_DeleteManagedFolderRequest(ref request, ref callSettings);
            _callDeleteManagedFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes an empty managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteManagedFolderAsync(DeleteManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_DeleteManagedFolderRequest(ref request, ref callSettings);
            return _callDeleteManagedFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ManagedFolder GetManagedFolder(GetManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetManagedFolderRequest(ref request, ref callSettings);
            return _callGetManagedFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for the specified managed folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ManagedFolder> GetManagedFolderAsync(GetManagedFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_GetManagedFolderRequest(ref request, ref callSettings);
            return _callGetManagedFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagedFolder"/> resources.</returns>
        public override gax::PagedEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFolders(ListManagedFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_ListManagedFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListManagedFoldersRequest, ListManagedFoldersResponse, ManagedFolder>(_callListManagedFolders, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of managed folders for a given bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedFolder"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListManagedFoldersResponse, ManagedFolder> ListManagedFoldersAsync(ListManagedFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            if (request.RequestId == "")
            {
                request = request.Clone();
                request.RequestId = gax::FieldFormats.GenerateUuid4();
            }
            Modify_ListManagedFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListManagedFoldersRequest, ListManagedFoldersResponse, ManagedFolder>(_callListManagedFolders, request, callSettings);
        }
    }

    public partial class ListFoldersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListManagedFoldersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFoldersResponse : gaxgrpc::IPageResponse<Folder>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Folder> GetEnumerator() => Folders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListManagedFoldersResponse : gaxgrpc::IPageResponse<ManagedFolder>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ManagedFolder> GetEnumerator() => ManagedFolders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class StorageControl
    {
        public partial class StorageControlClient
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
}
