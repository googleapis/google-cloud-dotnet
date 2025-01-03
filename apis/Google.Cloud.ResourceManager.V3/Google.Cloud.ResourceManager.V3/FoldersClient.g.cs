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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.ResourceManager.V3
{
    /// <summary>Settings for <see cref="FoldersClient"/> instances.</summary>
    public sealed partial class FoldersSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FoldersSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FoldersSettings"/>.</returns>
        public static FoldersSettings GetDefault() => new FoldersSettings();

        /// <summary>Constructs a new <see cref="FoldersSettings"/> object with default settings.</summary>
        public FoldersSettings()
        {
        }

        private FoldersSettings(FoldersSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFolderSettings = existing.GetFolderSettings;
            ListFoldersSettings = existing.ListFoldersSettings;
            SearchFoldersSettings = existing.SearchFoldersSettings;
            CreateFolderSettings = existing.CreateFolderSettings;
            CreateFolderOperationsSettings = existing.CreateFolderOperationsSettings.Clone();
            UpdateFolderSettings = existing.UpdateFolderSettings;
            UpdateFolderOperationsSettings = existing.UpdateFolderOperationsSettings.Clone();
            MoveFolderSettings = existing.MoveFolderSettings;
            MoveFolderOperationsSettings = existing.MoveFolderOperationsSettings.Clone();
            DeleteFolderSettings = existing.DeleteFolderSettings;
            DeleteFolderOperationsSettings = existing.DeleteFolderOperationsSettings.Clone();
            UndeleteFolderSettings = existing.UndeleteFolderSettings;
            UndeleteFolderOperationsSettings = existing.UndeleteFolderOperationsSettings.Clone();
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FoldersSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FoldersClient.GetFolder</c>
        /// and <c>FoldersClient.GetFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFolderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FoldersClient.ListFolders</c>
        ///  and <c>FoldersClient.ListFoldersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFoldersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FoldersClient.SearchFolders</c>
        ///  and <c>FoldersClient.SearchFoldersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchFoldersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FoldersClient.CreateFolder</c>
        ///  and <c>FoldersClient.CreateFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FoldersClient.CreateFolder</c> and
        /// <c>FoldersClient.CreateFolderAsync</c>.
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
        public lro::OperationsSettings CreateFolderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FoldersClient.UpdateFolder</c>
        ///  and <c>FoldersClient.UpdateFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FoldersClient.UpdateFolder</c> and
        /// <c>FoldersClient.UpdateFolderAsync</c>.
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
        public lro::OperationsSettings UpdateFolderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FoldersClient.MoveFolder</c>
        ///  and <c>FoldersClient.MoveFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FoldersClient.MoveFolder</c> and
        /// <c>FoldersClient.MoveFolderAsync</c>.
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
        public lro::OperationsSettings MoveFolderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FoldersClient.DeleteFolder</c>
        ///  and <c>FoldersClient.DeleteFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FoldersClient.DeleteFolder</c> and
        /// <c>FoldersClient.DeleteFolderAsync</c>.
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
        public lro::OperationsSettings DeleteFolderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.UndeleteFolder</c> and <c>FoldersClient.UndeleteFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FoldersClient.UndeleteFolder</c> and
        /// <c>FoldersClient.UndeleteFolderAsync</c>.
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
        public lro::OperationsSettings UndeleteFolderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FoldersClient.GetIamPolicy</c>
        ///  and <c>FoldersClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FoldersClient.SetIamPolicy</c>
        ///  and <c>FoldersClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FoldersClient.TestIamPermissions</c> and <c>FoldersClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FoldersSettings"/> object.</returns>
        public FoldersSettings Clone() => new FoldersSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FoldersClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class FoldersClientBuilder : gaxgrpc::ClientBuilderBase<FoldersClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FoldersSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FoldersClientBuilder() : base(FoldersClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FoldersClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FoldersClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FoldersClient Build()
        {
            FoldersClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FoldersClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FoldersClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FoldersClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FoldersClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FoldersClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FoldersClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FoldersClient.ChannelPool;
    }

    /// <summary>Folders client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Cloud Platform folder resources.
    /// Folders can be used to organize the resources under an
    /// organization and to control the policies applied to groups of resources.
    /// </remarks>
    public abstract partial class FoldersClient
    {
        /// <summary>
        /// The default endpoint for the Folders service, which is a host of "cloudresourcemanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudresourcemanager.googleapis.com:443";

        /// <summary>The default Folders scopes.</summary>
        /// <remarks>
        /// The default Folders scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Folders.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FoldersClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="FoldersClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FoldersClient"/>.</returns>
        public static stt::Task<FoldersClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FoldersClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FoldersClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="FoldersClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FoldersClient"/>.</returns>
        public static FoldersClient Create() => new FoldersClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FoldersClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FoldersSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FoldersClient"/>.</returns>
        internal static FoldersClient Create(grpccore::CallInvoker callInvoker, FoldersSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Folders.FoldersClient grpcClient = new Folders.FoldersClient(callInvoker);
            return new FoldersClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Folders client</summary>
        public virtual Folders.FoldersClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name.
        /// Valid folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name.
        /// Valid folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name.
        /// Valid folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(GetFolderRequest request, st::CancellationToken cancellationToken) =>
            GetFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name.
        /// Valid folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to retrieve.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolder(new GetFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name.
        /// Valid folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to retrieve.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderAsync(new GetFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name.
        /// Valid folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to retrieve.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(string name, st::CancellationToken cancellationToken) =>
            GetFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name.
        /// Valid folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to retrieve.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(gagr::FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolder(new GetFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name.
        /// Valid folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to retrieve.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(gagr::FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderAsync(new GetFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name.
        /// Valid folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to retrieve.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(gagr::FolderName name, st::CancellationToken cancellationToken) =>
            GetFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the folders that are direct descendants of supplied parent resource.
        /// `list()` provides a strongly consistent view of the folders underneath
        /// the specified parent resource.
        /// `list()` returns folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFoldersResponse, Folder> ListFolders(ListFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the folders that are direct descendants of supplied parent resource.
        /// `list()` provides a strongly consistent view of the folders underneath
        /// the specified parent resource.
        /// `list()` returns folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(ListFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the folders that are direct descendants of supplied parent resource.
        /// `list()` provides a strongly consistent view of the folders underneath
        /// the specified parent resource.
        /// `list()` returns folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose folders are being listed.
        /// Only children of this parent resource are listed; descendants are not
        /// listed.
        /// 
        /// If the parent is a folder, use the value `folders/{folder_id}`. If the
        /// parent is an organization, use the value `organizations/{org_id}`.
        /// 
        /// Access to this method is controlled by checking the
        /// `resourcemanager.folders.list` permission on the `parent`.
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
        public virtual gax::PagedEnumerable<ListFoldersResponse, Folder> ListFolders(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFoldersRequest request = new ListFoldersRequest
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
            return ListFolders(request, callSettings);
        }

        /// <summary>
        /// Lists the folders that are direct descendants of supplied parent resource.
        /// `list()` provides a strongly consistent view of the folders underneath
        /// the specified parent resource.
        /// `list()` returns folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose folders are being listed.
        /// Only children of this parent resource are listed; descendants are not
        /// listed.
        /// 
        /// If the parent is a folder, use the value `folders/{folder_id}`. If the
        /// parent is an organization, use the value `organizations/{org_id}`.
        /// 
        /// Access to this method is controlled by checking the
        /// `resourcemanager.folders.list` permission on the `parent`.
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
        public virtual gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFoldersRequest request = new ListFoldersRequest
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
            return ListFoldersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the folders that are direct descendants of supplied parent resource.
        /// `list()` provides a strongly consistent view of the folders underneath
        /// the specified parent resource.
        /// `list()` returns folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose folders are being listed.
        /// Only children of this parent resource are listed; descendants are not
        /// listed.
        /// 
        /// If the parent is a folder, use the value `folders/{folder_id}`. If the
        /// parent is an organization, use the value `organizations/{org_id}`.
        /// 
        /// Access to this method is controlled by checking the
        /// `resourcemanager.folders.list` permission on the `parent`.
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
        public virtual gax::PagedEnumerable<ListFoldersResponse, Folder> ListFolders(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFoldersRequest request = new ListFoldersRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFolders(request, callSettings);
        }

        /// <summary>
        /// Lists the folders that are direct descendants of supplied parent resource.
        /// `list()` provides a strongly consistent view of the folders underneath
        /// the specified parent resource.
        /// `list()` returns folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose folders are being listed.
        /// Only children of this parent resource are listed; descendants are not
        /// listed.
        /// 
        /// If the parent is a folder, use the value `folders/{folder_id}`. If the
        /// parent is an organization, use the value `organizations/{org_id}`.
        /// 
        /// Access to this method is controlled by checking the
        /// `resourcemanager.folders.list` permission on the `parent`.
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
        public virtual gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFoldersRequest request = new ListFoldersRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFoldersAsync(request, callSettings);
        }

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// `search()` provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        /// 
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchFoldersResponse, Folder> SearchFolders(SearchFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// `search()` provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        /// 
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchFoldersResponse, Folder> SearchFoldersAsync(SearchFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// `search()` provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        /// 
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="query">
        /// Optional. Search criteria used to select the folders to return.
        /// If no search criteria is specified then all accessible folders will be
        /// returned.
        /// 
        /// Query expressions can be used to restrict results based upon displayName,
        /// state and parent, where the operators `=` (`:`) `NOT`, `AND` and `OR`
        /// can be used along with the suffix wildcard symbol `*`.
        /// 
        /// The `displayName` field in a query expression should use escaped quotes
        /// for values that include whitespace to prevent unexpected behavior.
        /// 
        /// ```
        /// | Field                   | Description                            |
        /// |-------------------------|----------------------------------------|
        /// | displayName             | Filters by displayName.                |
        /// | parent                  | Filters by parent (for example: folders/123). |
        /// | state, lifecycleState   | Filters by state.                      |
        /// ```
        /// 
        /// Some example queries are:
        /// 
        /// * Query `displayName=Test*` returns Folder resources whose display name
        /// starts with "Test".
        /// * Query `state=ACTIVE` returns Folder resources with
        /// `state` set to `ACTIVE`.
        /// * Query `parent=folders/123` returns Folder resources that have
        /// `folders/123` as a parent resource.
        /// * Query `parent=folders/123 AND state=ACTIVE` returns active
        /// Folder resources that have `folders/123` as a parent resource.
        /// * Query `displayName=\\"Test String\\"` returns Folder resources with
        /// display names that include both "Test" and "String".
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
        public virtual gax::PagedEnumerable<SearchFoldersResponse, Folder> SearchFolders(string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchFoldersRequest request = new SearchFoldersRequest { Query = query ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchFolders(request, callSettings);
        }

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// `search()` provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        /// 
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="query">
        /// Optional. Search criteria used to select the folders to return.
        /// If no search criteria is specified then all accessible folders will be
        /// returned.
        /// 
        /// Query expressions can be used to restrict results based upon displayName,
        /// state and parent, where the operators `=` (`:`) `NOT`, `AND` and `OR`
        /// can be used along with the suffix wildcard symbol `*`.
        /// 
        /// The `displayName` field in a query expression should use escaped quotes
        /// for values that include whitespace to prevent unexpected behavior.
        /// 
        /// ```
        /// | Field                   | Description                            |
        /// |-------------------------|----------------------------------------|
        /// | displayName             | Filters by displayName.                |
        /// | parent                  | Filters by parent (for example: folders/123). |
        /// | state, lifecycleState   | Filters by state.                      |
        /// ```
        /// 
        /// Some example queries are:
        /// 
        /// * Query `displayName=Test*` returns Folder resources whose display name
        /// starts with "Test".
        /// * Query `state=ACTIVE` returns Folder resources with
        /// `state` set to `ACTIVE`.
        /// * Query `parent=folders/123` returns Folder resources that have
        /// `folders/123` as a parent resource.
        /// * Query `parent=folders/123 AND state=ACTIVE` returns active
        /// Folder resources that have `folders/123` as a parent resource.
        /// * Query `displayName=\\"Test String\\"` returns Folder resources with
        /// display names that include both "Test" and "String".
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
        public virtual gax::PagedAsyncEnumerable<SearchFoldersResponse, Folder> SearchFoldersAsync(string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchFoldersRequest request = new SearchFoldersRequest { Query = query ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchFoldersAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a folder in the resource hierarchy.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// created Folder.
        /// 
        /// In order to succeed, the addition of this new folder must not violate
        /// the folder naming, height, or fanout constraints.
        /// 
        /// + The folder's `display_name` must be distinct from all other folders that
        /// share its parent.
        /// + The addition of the folder must not cause the active folder hierarchy
        /// to exceed a height of 10. Note, the full active + deleted folder hierarchy
        /// is allowed to reach a height of 20; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the folder must not cause the total number of folders
        /// under its parent to exceed 300.
        /// 
        /// If the operation fails due to a folder constraint violation, some errors
        /// may be returned by the `CreateFolder` request, with status code
        /// `FAILED_PRECONDITION` and an error description. Other folder constraint
        /// violations will be communicated in the `Operation`, with the specific
        /// `PreconditionFailure` returned in the details list in the `Operation.error`
        /// field.
        /// 
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, CreateFolderMetadata> CreateFolder(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a folder in the resource hierarchy.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// created Folder.
        /// 
        /// In order to succeed, the addition of this new folder must not violate
        /// the folder naming, height, or fanout constraints.
        /// 
        /// + The folder's `display_name` must be distinct from all other folders that
        /// share its parent.
        /// + The addition of the folder must not cause the active folder hierarchy
        /// to exceed a height of 10. Note, the full active + deleted folder hierarchy
        /// is allowed to reach a height of 20; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the folder must not cause the total number of folders
        /// under its parent to exceed 300.
        /// 
        /// If the operation fails due to a folder constraint violation, some errors
        /// may be returned by the `CreateFolder` request, with status code
        /// `FAILED_PRECONDITION` and an error description. Other folder constraint
        /// violations will be communicated in the `Operation`, with the specific
        /// `PreconditionFailure` returned in the details list in the `Operation.error`
        /// field.
        /// 
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, CreateFolderMetadata>> CreateFolderAsync(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a folder in the resource hierarchy.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// created Folder.
        /// 
        /// In order to succeed, the addition of this new folder must not violate
        /// the folder naming, height, or fanout constraints.
        /// 
        /// + The folder's `display_name` must be distinct from all other folders that
        /// share its parent.
        /// + The addition of the folder must not cause the active folder hierarchy
        /// to exceed a height of 10. Note, the full active + deleted folder hierarchy
        /// is allowed to reach a height of 20; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the folder must not cause the total number of folders
        /// under its parent to exceed 300.
        /// 
        /// If the operation fails due to a folder constraint violation, some errors
        /// may be returned by the `CreateFolder` request, with status code
        /// `FAILED_PRECONDITION` and an error description. Other folder constraint
        /// violations will be communicated in the `Operation`, with the specific
        /// `PreconditionFailure` returned in the details list in the `Operation.error`
        /// field.
        /// 
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, CreateFolderMetadata>> CreateFolderAsync(CreateFolderRequest request, st::CancellationToken cancellationToken) =>
            CreateFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFolder</c>.</summary>
        public virtual lro::OperationsClient CreateFolderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Folder, CreateFolderMetadata> PollOnceCreateFolder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, CreateFolderMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFolderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Folder, CreateFolderMetadata>> PollOnceCreateFolderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, CreateFolderMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFolderOperationsClient, callSettings);

        /// <summary>
        /// Creates a folder in the resource hierarchy.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// created Folder.
        /// 
        /// In order to succeed, the addition of this new folder must not violate
        /// the folder naming, height, or fanout constraints.
        /// 
        /// + The folder's `display_name` must be distinct from all other folders that
        /// share its parent.
        /// + The addition of the folder must not cause the active folder hierarchy
        /// to exceed a height of 10. Note, the full active + deleted folder hierarchy
        /// is allowed to reach a height of 20; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the folder must not cause the total number of folders
        /// under its parent to exceed 300.
        /// 
        /// If the operation fails due to a folder constraint violation, some errors
        /// may be returned by the `CreateFolder` request, with status code
        /// `FAILED_PRECONDITION` and an error description. Other folder constraint
        /// violations will be communicated in the `Operation`, with the specific
        /// `PreconditionFailure` returned in the details list in the `Operation.error`
        /// field.
        /// 
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="folder">
        /// Required. The folder being created, only the display name and parent will
        /// be consulted. All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, CreateFolderMetadata> CreateFolder(Folder folder, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolder(new CreateFolderRequest
            {
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
            }, callSettings);

        /// <summary>
        /// Creates a folder in the resource hierarchy.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// created Folder.
        /// 
        /// In order to succeed, the addition of this new folder must not violate
        /// the folder naming, height, or fanout constraints.
        /// 
        /// + The folder's `display_name` must be distinct from all other folders that
        /// share its parent.
        /// + The addition of the folder must not cause the active folder hierarchy
        /// to exceed a height of 10. Note, the full active + deleted folder hierarchy
        /// is allowed to reach a height of 20; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the folder must not cause the total number of folders
        /// under its parent to exceed 300.
        /// 
        /// If the operation fails due to a folder constraint violation, some errors
        /// may be returned by the `CreateFolder` request, with status code
        /// `FAILED_PRECONDITION` and an error description. Other folder constraint
        /// violations will be communicated in the `Operation`, with the specific
        /// `PreconditionFailure` returned in the details list in the `Operation.error`
        /// field.
        /// 
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="folder">
        /// Required. The folder being created, only the display name and parent will
        /// be consulted. All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, CreateFolderMetadata>> CreateFolderAsync(Folder folder, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolderAsync(new CreateFolderRequest
            {
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
            }, callSettings);

        /// <summary>
        /// Creates a folder in the resource hierarchy.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// created Folder.
        /// 
        /// In order to succeed, the addition of this new folder must not violate
        /// the folder naming, height, or fanout constraints.
        /// 
        /// + The folder's `display_name` must be distinct from all other folders that
        /// share its parent.
        /// + The addition of the folder must not cause the active folder hierarchy
        /// to exceed a height of 10. Note, the full active + deleted folder hierarchy
        /// is allowed to reach a height of 20; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the folder must not cause the total number of folders
        /// under its parent to exceed 300.
        /// 
        /// If the operation fails due to a folder constraint violation, some errors
        /// may be returned by the `CreateFolder` request, with status code
        /// `FAILED_PRECONDITION` and an error description. Other folder constraint
        /// violations will be communicated in the `Operation`, with the specific
        /// `PreconditionFailure` returned in the details list in the `Operation.error`
        /// field.
        /// 
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="folder">
        /// Required. The folder being created, only the display name and parent will
        /// be consulted. All other fields will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, CreateFolderMetadata>> CreateFolderAsync(Folder folder, st::CancellationToken cancellationToken) =>
            CreateFolderAsync(folder, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a folder, changing its `display_name`.
        /// Changes to the folder `display_name` will be rejected if they violate
        /// either the `display_name` formatting rules or the naming constraints
        /// described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation.
        /// 
        /// The folder's `display_name` must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// between 3 and 30 characters. This is captured by the regular expression:
        /// `[\p{L}\p{N}][\p{L}\p{N}_- ]{1,28}[\p{L}\p{N}]`.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        /// 
        /// If the update fails due to the unique name constraint then a
        /// `PreconditionFailure` explaining this violation will be returned
        /// in the Status.details field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, UpdateFolderMetadata> UpdateFolder(UpdateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a folder, changing its `display_name`.
        /// Changes to the folder `display_name` will be rejected if they violate
        /// either the `display_name` formatting rules or the naming constraints
        /// described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation.
        /// 
        /// The folder's `display_name` must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// between 3 and 30 characters. This is captured by the regular expression:
        /// `[\p{L}\p{N}][\p{L}\p{N}_- ]{1,28}[\p{L}\p{N}]`.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        /// 
        /// If the update fails due to the unique name constraint then a
        /// `PreconditionFailure` explaining this violation will be returned
        /// in the Status.details field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, UpdateFolderMetadata>> UpdateFolderAsync(UpdateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a folder, changing its `display_name`.
        /// Changes to the folder `display_name` will be rejected if they violate
        /// either the `display_name` formatting rules or the naming constraints
        /// described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation.
        /// 
        /// The folder's `display_name` must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// between 3 and 30 characters. This is captured by the regular expression:
        /// `[\p{L}\p{N}][\p{L}\p{N}_- ]{1,28}[\p{L}\p{N}]`.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        /// 
        /// If the update fails due to the unique name constraint then a
        /// `PreconditionFailure` explaining this violation will be returned
        /// in the Status.details field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, UpdateFolderMetadata>> UpdateFolderAsync(UpdateFolderRequest request, st::CancellationToken cancellationToken) =>
            UpdateFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFolder</c>.</summary>
        public virtual lro::OperationsClient UpdateFolderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Folder, UpdateFolderMetadata> PollOnceUpdateFolder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, UpdateFolderMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFolderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Folder, UpdateFolderMetadata>> PollOnceUpdateFolderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, UpdateFolderMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFolderOperationsClient, callSettings);

        /// <summary>
        /// Updates a folder, changing its `display_name`.
        /// Changes to the folder `display_name` will be rejected if they violate
        /// either the `display_name` formatting rules or the naming constraints
        /// described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation.
        /// 
        /// The folder's `display_name` must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// between 3 and 30 characters. This is captured by the regular expression:
        /// `[\p{L}\p{N}][\p{L}\p{N}_- ]{1,28}[\p{L}\p{N}]`.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        /// 
        /// If the update fails due to the unique name constraint then a
        /// `PreconditionFailure` explaining this violation will be returned
        /// in the Status.details field.
        /// </summary>
        /// <param name="folder">
        /// Required. The new definition of the Folder. It must include the `name`
        /// field, which cannot be changed.
        /// </param>
        /// <param name="updateMask">
        /// Required. Fields to be updated.
        /// Only the `display_name` can be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, UpdateFolderMetadata> UpdateFolder(Folder folder, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFolder(new UpdateFolderRequest
            {
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a folder, changing its `display_name`.
        /// Changes to the folder `display_name` will be rejected if they violate
        /// either the `display_name` formatting rules or the naming constraints
        /// described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation.
        /// 
        /// The folder's `display_name` must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// between 3 and 30 characters. This is captured by the regular expression:
        /// `[\p{L}\p{N}][\p{L}\p{N}_- ]{1,28}[\p{L}\p{N}]`.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        /// 
        /// If the update fails due to the unique name constraint then a
        /// `PreconditionFailure` explaining this violation will be returned
        /// in the Status.details field.
        /// </summary>
        /// <param name="folder">
        /// Required. The new definition of the Folder. It must include the `name`
        /// field, which cannot be changed.
        /// </param>
        /// <param name="updateMask">
        /// Required. Fields to be updated.
        /// Only the `display_name` can be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, UpdateFolderMetadata>> UpdateFolderAsync(Folder folder, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFolderAsync(new UpdateFolderRequest
            {
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a folder, changing its `display_name`.
        /// Changes to the folder `display_name` will be rejected if they violate
        /// either the `display_name` formatting rules or the naming constraints
        /// described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation.
        /// 
        /// The folder's `display_name` must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// between 3 and 30 characters. This is captured by the regular expression:
        /// `[\p{L}\p{N}][\p{L}\p{N}_- ]{1,28}[\p{L}\p{N}]`.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        /// 
        /// If the update fails due to the unique name constraint then a
        /// `PreconditionFailure` explaining this violation will be returned
        /// in the Status.details field.
        /// </summary>
        /// <param name="folder">
        /// Required. The new definition of the Folder. It must include the `name`
        /// field, which cannot be changed.
        /// </param>
        /// <param name="updateMask">
        /// Required. Fields to be updated.
        /// Only the `display_name` can be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, UpdateFolderMetadata>> UpdateFolderAsync(Folder folder, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFolderAsync(folder, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a folder under a new resource parent.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved folder.
        /// Upon failure, a `FolderOperationError` categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned
        /// in the `Operation.error` field.
        /// In addition, the `Operation.metadata` field will be populated with a
        /// `FolderOperation` message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height,
        /// or fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, MoveFolderMetadata> MoveFolder(MoveFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a folder under a new resource parent.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved folder.
        /// Upon failure, a `FolderOperationError` categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned
        /// in the `Operation.error` field.
        /// In addition, the `Operation.metadata` field will be populated with a
        /// `FolderOperation` message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height,
        /// or fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, MoveFolderMetadata>> MoveFolderAsync(MoveFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a folder under a new resource parent.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved folder.
        /// Upon failure, a `FolderOperationError` categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned
        /// in the `Operation.error` field.
        /// In addition, the `Operation.metadata` field will be populated with a
        /// `FolderOperation` message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height,
        /// or fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, MoveFolderMetadata>> MoveFolderAsync(MoveFolderRequest request, st::CancellationToken cancellationToken) =>
            MoveFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>MoveFolder</c>.</summary>
        public virtual lro::OperationsClient MoveFolderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>MoveFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Folder, MoveFolderMetadata> PollOnceMoveFolder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, MoveFolderMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveFolderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>MoveFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Folder, MoveFolderMetadata>> PollOnceMoveFolderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, MoveFolderMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveFolderOperationsClient, callSettings);

        /// <summary>
        /// Moves a folder under a new resource parent.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved folder.
        /// Upon failure, a `FolderOperationError` categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned
        /// in the `Operation.error` field.
        /// In addition, the `Operation.metadata` field will be populated with a
        /// `FolderOperation` message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height,
        /// or fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Folder to move.
        /// Must be of the form folders/{folder_id}
        /// </param>
        /// <param name="destinationParent">
        /// Required. The resource name of the folder or organization which should be
        /// the folder's new parent. Must be of the form `folders/{folder_id}` or
        /// `organizations/{org_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, MoveFolderMetadata> MoveFolder(string name, string destinationParent, gaxgrpc::CallSettings callSettings = null) =>
            MoveFolder(new MoveFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationParent = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationParent, nameof(destinationParent)),
            }, callSettings);

        /// <summary>
        /// Moves a folder under a new resource parent.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved folder.
        /// Upon failure, a `FolderOperationError` categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned
        /// in the `Operation.error` field.
        /// In addition, the `Operation.metadata` field will be populated with a
        /// `FolderOperation` message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height,
        /// or fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Folder to move.
        /// Must be of the form folders/{folder_id}
        /// </param>
        /// <param name="destinationParent">
        /// Required. The resource name of the folder or organization which should be
        /// the folder's new parent. Must be of the form `folders/{folder_id}` or
        /// `organizations/{org_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, MoveFolderMetadata>> MoveFolderAsync(string name, string destinationParent, gaxgrpc::CallSettings callSettings = null) =>
            MoveFolderAsync(new MoveFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationParent = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationParent, nameof(destinationParent)),
            }, callSettings);

        /// <summary>
        /// Moves a folder under a new resource parent.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved folder.
        /// Upon failure, a `FolderOperationError` categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned
        /// in the `Operation.error` field.
        /// In addition, the `Operation.metadata` field will be populated with a
        /// `FolderOperation` message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height,
        /// or fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Folder to move.
        /// Must be of the form folders/{folder_id}
        /// </param>
        /// <param name="destinationParent">
        /// Required. The resource name of the folder or organization which should be
        /// the folder's new parent. Must be of the form `folders/{folder_id}` or
        /// `organizations/{org_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, MoveFolderMetadata>> MoveFolderAsync(string name, string destinationParent, st::CancellationToken cancellationToken) =>
            MoveFolderAsync(name, destinationParent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a folder under a new resource parent.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved folder.
        /// Upon failure, a `FolderOperationError` categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned
        /// in the `Operation.error` field.
        /// In addition, the `Operation.metadata` field will be populated with a
        /// `FolderOperation` message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height,
        /// or fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Folder to move.
        /// Must be of the form folders/{folder_id}
        /// </param>
        /// <param name="destinationParent">
        /// Required. The resource name of the folder or organization which should be
        /// the folder's new parent. Must be of the form `folders/{folder_id}` or
        /// `organizations/{org_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, MoveFolderMetadata> MoveFolder(gagr::FolderName name, gax::IResourceName destinationParent, gaxgrpc::CallSettings callSettings = null) =>
            MoveFolder(new MoveFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationParentAsResourceName = gax::GaxPreconditions.CheckNotNull(destinationParent, nameof(destinationParent)),
            }, callSettings);

        /// <summary>
        /// Moves a folder under a new resource parent.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved folder.
        /// Upon failure, a `FolderOperationError` categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned
        /// in the `Operation.error` field.
        /// In addition, the `Operation.metadata` field will be populated with a
        /// `FolderOperation` message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height,
        /// or fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Folder to move.
        /// Must be of the form folders/{folder_id}
        /// </param>
        /// <param name="destinationParent">
        /// Required. The resource name of the folder or organization which should be
        /// the folder's new parent. Must be of the form `folders/{folder_id}` or
        /// `organizations/{org_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, MoveFolderMetadata>> MoveFolderAsync(gagr::FolderName name, gax::IResourceName destinationParent, gaxgrpc::CallSettings callSettings = null) =>
            MoveFolderAsync(new MoveFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationParentAsResourceName = gax::GaxPreconditions.CheckNotNull(destinationParent, nameof(destinationParent)),
            }, callSettings);

        /// <summary>
        /// Moves a folder under a new resource parent.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved folder.
        /// Upon failure, a `FolderOperationError` categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned
        /// in the `Operation.error` field.
        /// In addition, the `Operation.metadata` field will be populated with a
        /// `FolderOperation` message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height,
        /// or fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Folder to move.
        /// Must be of the form folders/{folder_id}
        /// </param>
        /// <param name="destinationParent">
        /// Required. The resource name of the folder or organization which should be
        /// the folder's new parent. Must be of the form `folders/{folder_id}` or
        /// `organizations/{org_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, MoveFolderMetadata>> MoveFolderAsync(gagr::FolderName name, gax::IResourceName destinationParent, st::CancellationToken cancellationToken) =>
            MoveFolderAsync(name, destinationParent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on an empty folder, where a folder is empty if it
        /// doesn't contain any folders or projects in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. If
        /// called on a folder in
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state the operation will result in a no-op success.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, DeleteFolderMetadata> DeleteFolder(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on an empty folder, where a folder is empty if it
        /// doesn't contain any folders or projects in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. If
        /// called on a folder in
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state the operation will result in a no-op success.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, DeleteFolderMetadata>> DeleteFolderAsync(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on an empty folder, where a folder is empty if it
        /// doesn't contain any folders or projects in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. If
        /// called on a folder in
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state the operation will result in a no-op success.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, DeleteFolderMetadata>> DeleteFolderAsync(DeleteFolderRequest request, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFolder</c>.</summary>
        public virtual lro::OperationsClient DeleteFolderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Folder, DeleteFolderMetadata> PollOnceDeleteFolder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, DeleteFolderMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFolderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Folder, DeleteFolderMetadata>> PollOnceDeleteFolderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, DeleteFolderMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFolderOperationsClient, callSettings);

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on an empty folder, where a folder is empty if it
        /// doesn't contain any folders or projects in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. If
        /// called on a folder in
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state the operation will result in a no-op success.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, DeleteFolderMetadata> DeleteFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolder(new DeleteFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on an empty folder, where a folder is empty if it
        /// doesn't contain any folders or projects in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. If
        /// called on a folder in
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state the operation will result in a no-op success.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, DeleteFolderMetadata>> DeleteFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolderAsync(new DeleteFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on an empty folder, where a folder is empty if it
        /// doesn't contain any folders or projects in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. If
        /// called on a folder in
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state the operation will result in a no-op success.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, DeleteFolderMetadata>> DeleteFolderAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on an empty folder, where a folder is empty if it
        /// doesn't contain any folders or projects in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. If
        /// called on a folder in
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state the operation will result in a no-op success.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, DeleteFolderMetadata> DeleteFolder(gagr::FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolder(new DeleteFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on an empty folder, where a folder is empty if it
        /// doesn't contain any folders or projects in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. If
        /// called on a folder in
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state the operation will result in a no-op success.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, DeleteFolderMetadata>> DeleteFolderAsync(gagr::FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolderAsync(new DeleteFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on an empty folder, where a folder is empty if it
        /// doesn't contain any folders or projects in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. If
        /// called on a folder in
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state the operation will result in a no-op success.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to be deleted.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, DeleteFolderMetadata>> DeleteFolderAsync(gagr::FolderName name, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a
        /// folder in any state. If the folder is in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state the
        /// result will be a no-op success. In order to succeed, the folder's parent
        /// must be in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. In
        /// addition, reintroducing the folder into the tree must not violate folder
        /// naming, height, and fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.undelete`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, UndeleteFolderMetadata> UndeleteFolder(UndeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a
        /// folder in any state. If the folder is in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state the
        /// result will be a no-op success. In order to succeed, the folder's parent
        /// must be in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. In
        /// addition, reintroducing the folder into the tree must not violate folder
        /// naming, height, and fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.undelete`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, UndeleteFolderMetadata>> UndeleteFolderAsync(UndeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a
        /// folder in any state. If the folder is in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state the
        /// result will be a no-op success. In order to succeed, the folder's parent
        /// must be in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. In
        /// addition, reintroducing the folder into the tree must not violate folder
        /// naming, height, and fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.undelete`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, UndeleteFolderMetadata>> UndeleteFolderAsync(UndeleteFolderRequest request, st::CancellationToken cancellationToken) =>
            UndeleteFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeleteFolder</c>.</summary>
        public virtual lro::OperationsClient UndeleteFolderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeleteFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Folder, UndeleteFolderMetadata> PollOnceUndeleteFolder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, UndeleteFolderMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteFolderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Folder, UndeleteFolderMetadata>> PollOnceUndeleteFolderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Folder, UndeleteFolderMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteFolderOperationsClient, callSettings);

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a
        /// folder in any state. If the folder is in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state the
        /// result will be a no-op success. In order to succeed, the folder's parent
        /// must be in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. In
        /// addition, reintroducing the folder into the tree must not violate folder
        /// naming, height, and fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.undelete`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to undelete.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, UndeleteFolderMetadata> UndeleteFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteFolder(new UndeleteFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a
        /// folder in any state. If the folder is in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state the
        /// result will be a no-op success. In order to succeed, the folder's parent
        /// must be in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. In
        /// addition, reintroducing the folder into the tree must not violate folder
        /// naming, height, and fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.undelete`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to undelete.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, UndeleteFolderMetadata>> UndeleteFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteFolderAsync(new UndeleteFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a
        /// folder in any state. If the folder is in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state the
        /// result will be a no-op success. In order to succeed, the folder's parent
        /// must be in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. In
        /// addition, reintroducing the folder into the tree must not violate folder
        /// naming, height, and fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.undelete`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to undelete.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, UndeleteFolderMetadata>> UndeleteFolderAsync(string name, st::CancellationToken cancellationToken) =>
            UndeleteFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a
        /// folder in any state. If the folder is in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state the
        /// result will be a no-op success. In order to succeed, the folder's parent
        /// must be in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. In
        /// addition, reintroducing the folder into the tree must not violate folder
        /// naming, height, and fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.undelete`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to undelete.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Folder, UndeleteFolderMetadata> UndeleteFolder(gagr::FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteFolder(new UndeleteFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a
        /// folder in any state. If the folder is in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state the
        /// result will be a no-op success. In order to succeed, the folder's parent
        /// must be in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. In
        /// addition, reintroducing the folder into the tree must not violate folder
        /// naming, height, and fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.undelete`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to undelete.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, UndeleteFolderMetadata>> UndeleteFolderAsync(gagr::FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteFolderAsync(new UndeleteFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a
        /// folder in any state. If the folder is in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state the
        /// result will be a no-op success. In order to succeed, the folder's parent
        /// must be in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. In
        /// addition, reintroducing the folder into the tree must not violate folder
        /// naming, height, and fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.undelete`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the folder to undelete.
        /// Must be of the form `folders/{folder_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Folder, UndeleteFolderMetadata>> UndeleteFolderAsync(gagr::FolderName name, st::CancellationToken cancellationToken) =>
            UndeleteFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the folder's resource name, for example: "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the folder's resource name, for example: "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the folder's resource name, for example: "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the folder's resource name, for example: "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the folder's resource name, for example: "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the folder's resource name, for example: "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the folder's resource name, for example: "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the folder's resource name, for example: "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the folder's resource name, for example: "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy.
        /// The `resource` field should be the folder's resource name, for example:
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy.
        /// The `resource` field should be the folder's resource name, for example:
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy.
        /// The `resource` field should be the folder's resource name, for example:
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy.
        /// The `resource` field should be the folder's resource name, for example:
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy.
        /// The `resource` field should be the folder's resource name, for example:
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy.
        /// The `resource` field should be the folder's resource name, for example:
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy.
        /// The `resource` field should be the folder's resource name, for example:
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy.
        /// The `resource` field should be the folder's resource name, for example:
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy.
        /// The `resource` field should be the folder's resource name, for example:
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified folder.
        /// The `resource` field should be the folder's resource name,
        /// for example: "folders/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified folder.
        /// The `resource` field should be the folder's resource name,
        /// for example: "folders/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified folder.
        /// The `resource` field should be the folder's resource name,
        /// for example: "folders/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified folder.
        /// The `resource` field should be the folder's resource name,
        /// for example: "folders/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified folder.
        /// The `resource` field should be the folder's resource name,
        /// for example: "folders/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified folder.
        /// The `resource` field should be the folder's resource name,
        /// for example: "folders/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified folder.
        /// The `resource` field should be the folder's resource name,
        /// for example: "folders/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified folder.
        /// The `resource` field should be the folder's resource name,
        /// for example: "folders/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified folder.
        /// The `resource` field should be the folder's resource name,
        /// for example: "folders/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Folders client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Cloud Platform folder resources.
    /// Folders can be used to organize the resources under an
    /// organization and to control the policies applied to groups of resources.
    /// </remarks>
    public sealed partial class FoldersClientImpl : FoldersClient
    {
        private readonly gaxgrpc::ApiCall<GetFolderRequest, Folder> _callGetFolder;

        private readonly gaxgrpc::ApiCall<ListFoldersRequest, ListFoldersResponse> _callListFolders;

        private readonly gaxgrpc::ApiCall<SearchFoldersRequest, SearchFoldersResponse> _callSearchFolders;

        private readonly gaxgrpc::ApiCall<CreateFolderRequest, lro::Operation> _callCreateFolder;

        private readonly gaxgrpc::ApiCall<UpdateFolderRequest, lro::Operation> _callUpdateFolder;

        private readonly gaxgrpc::ApiCall<MoveFolderRequest, lro::Operation> _callMoveFolder;

        private readonly gaxgrpc::ApiCall<DeleteFolderRequest, lro::Operation> _callDeleteFolder;

        private readonly gaxgrpc::ApiCall<UndeleteFolderRequest, lro::Operation> _callUndeleteFolder;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the Folders service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FoldersSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FoldersClientImpl(Folders.FoldersClient grpcClient, FoldersSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FoldersSettings effectiveSettings = settings ?? FoldersSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateFolderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFolderOperationsSettings, logger);
            UpdateFolderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFolderOperationsSettings, logger);
            MoveFolderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.MoveFolderOperationsSettings, logger);
            DeleteFolderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFolderOperationsSettings, logger);
            UndeleteFolderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeleteFolderOperationsSettings, logger);
            _callGetFolder = clientHelper.BuildApiCall<GetFolderRequest, Folder>("GetFolder", grpcClient.GetFolderAsync, grpcClient.GetFolder, effectiveSettings.GetFolderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFolder);
            Modify_GetFolderApiCall(ref _callGetFolder);
            _callListFolders = clientHelper.BuildApiCall<ListFoldersRequest, ListFoldersResponse>("ListFolders", grpcClient.ListFoldersAsync, grpcClient.ListFolders, effectiveSettings.ListFoldersSettings);
            Modify_ApiCall(ref _callListFolders);
            Modify_ListFoldersApiCall(ref _callListFolders);
            _callSearchFolders = clientHelper.BuildApiCall<SearchFoldersRequest, SearchFoldersResponse>("SearchFolders", grpcClient.SearchFoldersAsync, grpcClient.SearchFolders, effectiveSettings.SearchFoldersSettings);
            Modify_ApiCall(ref _callSearchFolders);
            Modify_SearchFoldersApiCall(ref _callSearchFolders);
            _callCreateFolder = clientHelper.BuildApiCall<CreateFolderRequest, lro::Operation>("CreateFolder", grpcClient.CreateFolderAsync, grpcClient.CreateFolder, effectiveSettings.CreateFolderSettings);
            Modify_ApiCall(ref _callCreateFolder);
            Modify_CreateFolderApiCall(ref _callCreateFolder);
            _callUpdateFolder = clientHelper.BuildApiCall<UpdateFolderRequest, lro::Operation>("UpdateFolder", grpcClient.UpdateFolderAsync, grpcClient.UpdateFolder, effectiveSettings.UpdateFolderSettings).WithGoogleRequestParam("folder.name", request => request.Folder?.Name);
            Modify_ApiCall(ref _callUpdateFolder);
            Modify_UpdateFolderApiCall(ref _callUpdateFolder);
            _callMoveFolder = clientHelper.BuildApiCall<MoveFolderRequest, lro::Operation>("MoveFolder", grpcClient.MoveFolderAsync, grpcClient.MoveFolder, effectiveSettings.MoveFolderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMoveFolder);
            Modify_MoveFolderApiCall(ref _callMoveFolder);
            _callDeleteFolder = clientHelper.BuildApiCall<DeleteFolderRequest, lro::Operation>("DeleteFolder", grpcClient.DeleteFolderAsync, grpcClient.DeleteFolder, effectiveSettings.DeleteFolderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFolder);
            Modify_DeleteFolderApiCall(ref _callDeleteFolder);
            _callUndeleteFolder = clientHelper.BuildApiCall<UndeleteFolderRequest, lro::Operation>("UndeleteFolder", grpcClient.UndeleteFolderAsync, grpcClient.UndeleteFolder, effectiveSettings.UndeleteFolderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteFolder);
            Modify_UndeleteFolderApiCall(ref _callUndeleteFolder);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetFolderApiCall(ref gaxgrpc::ApiCall<GetFolderRequest, Folder> call);

        partial void Modify_ListFoldersApiCall(ref gaxgrpc::ApiCall<ListFoldersRequest, ListFoldersResponse> call);

        partial void Modify_SearchFoldersApiCall(ref gaxgrpc::ApiCall<SearchFoldersRequest, SearchFoldersResponse> call);

        partial void Modify_CreateFolderApiCall(ref gaxgrpc::ApiCall<CreateFolderRequest, lro::Operation> call);

        partial void Modify_UpdateFolderApiCall(ref gaxgrpc::ApiCall<UpdateFolderRequest, lro::Operation> call);

        partial void Modify_MoveFolderApiCall(ref gaxgrpc::ApiCall<MoveFolderRequest, lro::Operation> call);

        partial void Modify_DeleteFolderApiCall(ref gaxgrpc::ApiCall<DeleteFolderRequest, lro::Operation> call);

        partial void Modify_UndeleteFolderApiCall(ref gaxgrpc::ApiCall<UndeleteFolderRequest, lro::Operation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(Folders.FoldersClient grpcClient, FoldersSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Folders client</summary>
        public override Folders.FoldersClient GrpcClient { get; }

        partial void Modify_GetFolderRequest(ref GetFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFoldersRequest(ref ListFoldersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchFoldersRequest(ref SearchFoldersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFolderRequest(ref CreateFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFolderRequest(ref UpdateFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveFolderRequest(ref MoveFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFolderRequest(ref DeleteFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteFolderRequest(ref UndeleteFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name.
        /// Valid folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Folder GetFolder(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFolderRequest(ref request, ref callSettings);
            return _callGetFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a folder identified by the supplied resource name.
        /// Valid folder resource names have the format `folders/{folder_id}`
        /// (for example, `folders/1234`).
        /// The caller must have `resourcemanager.folders.get` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Folder> GetFolderAsync(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFolderRequest(ref request, ref callSettings);
            return _callGetFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the folders that are direct descendants of supplied parent resource.
        /// `list()` provides a strongly consistent view of the folders underneath
        /// the specified parent resource.
        /// `list()` returns folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
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
        /// Lists the folders that are direct descendants of supplied parent resource.
        /// `list()` provides a strongly consistent view of the folders underneath
        /// the specified parent resource.
        /// `list()` returns folders sorted based upon the (ascending) lexical ordering
        /// of their display_name.
        /// The caller must have `resourcemanager.folders.list` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFoldersResponse, Folder> ListFoldersAsync(ListFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFoldersRequest, ListFoldersResponse, Folder>(_callListFolders, request, callSettings);
        }

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// `search()` provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        /// 
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Folder"/> resources.</returns>
        public override gax::PagedEnumerable<SearchFoldersResponse, Folder> SearchFolders(SearchFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchFoldersRequest, SearchFoldersResponse, Folder>(_callSearchFolders, request, callSettings);
        }

        /// <summary>
        /// Search for folders that match specific filter criteria.
        /// `search()` provides an eventually consistent view of the folders a user has
        /// access to which meet the specified filter criteria.
        /// 
        /// This will only return folders on which the caller has the
        /// permission `resourcemanager.folders.get`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Folder"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchFoldersResponse, Folder> SearchFoldersAsync(SearchFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchFoldersRequest, SearchFoldersResponse, Folder>(_callSearchFolders, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateFolder</c>.</summary>
        public override lro::OperationsClient CreateFolderOperationsClient { get; }

        /// <summary>
        /// Creates a folder in the resource hierarchy.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// created Folder.
        /// 
        /// In order to succeed, the addition of this new folder must not violate
        /// the folder naming, height, or fanout constraints.
        /// 
        /// + The folder's `display_name` must be distinct from all other folders that
        /// share its parent.
        /// + The addition of the folder must not cause the active folder hierarchy
        /// to exceed a height of 10. Note, the full active + deleted folder hierarchy
        /// is allowed to reach a height of 20; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the folder must not cause the total number of folders
        /// under its parent to exceed 300.
        /// 
        /// If the operation fails due to a folder constraint violation, some errors
        /// may be returned by the `CreateFolder` request, with status code
        /// `FAILED_PRECONDITION` and an error description. Other folder constraint
        /// violations will be communicated in the `Operation`, with the specific
        /// `PreconditionFailure` returned in the details list in the `Operation.error`
        /// field.
        /// 
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Folder, CreateFolderMetadata> CreateFolder(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, CreateFolderMetadata>(_callCreateFolder.Sync(request, callSettings), CreateFolderOperationsClient);
        }

        /// <summary>
        /// Creates a folder in the resource hierarchy.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder creation workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// created Folder.
        /// 
        /// In order to succeed, the addition of this new folder must not violate
        /// the folder naming, height, or fanout constraints.
        /// 
        /// + The folder's `display_name` must be distinct from all other folders that
        /// share its parent.
        /// + The addition of the folder must not cause the active folder hierarchy
        /// to exceed a height of 10. Note, the full active + deleted folder hierarchy
        /// is allowed to reach a height of 20; this provides additional headroom when
        /// moving folders that contain deleted folders.
        /// + The addition of the folder must not cause the total number of folders
        /// under its parent to exceed 300.
        /// 
        /// If the operation fails due to a folder constraint violation, some errors
        /// may be returned by the `CreateFolder` request, with status code
        /// `FAILED_PRECONDITION` and an error description. Other folder constraint
        /// violations will be communicated in the `Operation`, with the specific
        /// `PreconditionFailure` returned in the details list in the `Operation.error`
        /// field.
        /// 
        /// The caller must have `resourcemanager.folders.create` permission on the
        /// identified parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Folder, CreateFolderMetadata>> CreateFolderAsync(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, CreateFolderMetadata>(await _callCreateFolder.Async(request, callSettings).ConfigureAwait(false), CreateFolderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateFolder</c>.</summary>
        public override lro::OperationsClient UpdateFolderOperationsClient { get; }

        /// <summary>
        /// Updates a folder, changing its `display_name`.
        /// Changes to the folder `display_name` will be rejected if they violate
        /// either the `display_name` formatting rules or the naming constraints
        /// described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation.
        /// 
        /// The folder's `display_name` must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// between 3 and 30 characters. This is captured by the regular expression:
        /// `[\p{L}\p{N}][\p{L}\p{N}_- ]{1,28}[\p{L}\p{N}]`.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        /// 
        /// If the update fails due to the unique name constraint then a
        /// `PreconditionFailure` explaining this violation will be returned
        /// in the Status.details field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Folder, UpdateFolderMetadata> UpdateFolder(UpdateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, UpdateFolderMetadata>(_callUpdateFolder.Sync(request, callSettings), UpdateFolderOperationsClient);
        }

        /// <summary>
        /// Updates a folder, changing its `display_name`.
        /// Changes to the folder `display_name` will be rejected if they violate
        /// either the `display_name` formatting rules or the naming constraints
        /// described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation.
        /// 
        /// The folder's `display_name` must start and end with a letter or digit,
        /// may contain letters, digits, spaces, hyphens and underscores and can be
        /// between 3 and 30 characters. This is captured by the regular expression:
        /// `[\p{L}\p{N}][\p{L}\p{N}_- ]{1,28}[\p{L}\p{N}]`.
        /// The caller must have `resourcemanager.folders.update` permission on the
        /// identified folder.
        /// 
        /// If the update fails due to the unique name constraint then a
        /// `PreconditionFailure` explaining this violation will be returned
        /// in the Status.details field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Folder, UpdateFolderMetadata>> UpdateFolderAsync(UpdateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, UpdateFolderMetadata>(await _callUpdateFolder.Async(request, callSettings).ConfigureAwait(false), UpdateFolderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>MoveFolder</c>.</summary>
        public override lro::OperationsClient MoveFolderOperationsClient { get; }

        /// <summary>
        /// Moves a folder under a new resource parent.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved folder.
        /// Upon failure, a `FolderOperationError` categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned
        /// in the `Operation.error` field.
        /// In addition, the `Operation.metadata` field will be populated with a
        /// `FolderOperation` message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height,
        /// or fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Folder, MoveFolderMetadata> MoveFolder(MoveFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, MoveFolderMetadata>(_callMoveFolder.Sync(request, callSettings), MoveFolderOperationsClient);
        }

        /// <summary>
        /// Moves a folder under a new resource parent.
        /// Returns an `Operation` which can be used to track the progress of the
        /// folder move workflow.
        /// Upon success, the `Operation.response` field will be populated with the
        /// moved folder.
        /// Upon failure, a `FolderOperationError` categorizing the failure cause will
        /// be returned - if the failure occurs synchronously then the
        /// `FolderOperationError` will be returned in the `Status.details` field.
        /// If it occurs asynchronously, then the FolderOperation will be returned
        /// in the `Operation.error` field.
        /// In addition, the `Operation.metadata` field will be populated with a
        /// `FolderOperation` message as an aid to stateless clients.
        /// Folder moves will be rejected if they violate either the naming, height,
        /// or fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.move`
        /// permission on the folder's current and proposed new parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Folder, MoveFolderMetadata>> MoveFolderAsync(MoveFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, MoveFolderMetadata>(await _callMoveFolder.Async(request, callSettings).ConfigureAwait(false), MoveFolderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFolder</c>.</summary>
        public override lro::OperationsClient DeleteFolderOperationsClient { get; }

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on an empty folder, where a folder is empty if it
        /// doesn't contain any folders or projects in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. If
        /// called on a folder in
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state the operation will result in a no-op success.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Folder, DeleteFolderMetadata> DeleteFolder(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, DeleteFolderMetadata>(_callDeleteFolder.Sync(request, callSettings), DeleteFolderOperationsClient);
        }

        /// <summary>
        /// Requests deletion of a folder. The folder is moved into the
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on an empty folder, where a folder is empty if it
        /// doesn't contain any folders or projects in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. If
        /// called on a folder in
        /// [DELETE_REQUESTED][google.cloud.resourcemanager.v3.Folder.State.DELETE_REQUESTED]
        /// state the operation will result in a no-op success.
        /// The caller must have `resourcemanager.folders.delete` permission on the
        /// identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Folder, DeleteFolderMetadata>> DeleteFolderAsync(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, DeleteFolderMetadata>(await _callDeleteFolder.Async(request, callSettings).ConfigureAwait(false), DeleteFolderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeleteFolder</c>.</summary>
        public override lro::OperationsClient UndeleteFolderOperationsClient { get; }

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a
        /// folder in any state. If the folder is in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state the
        /// result will be a no-op success. In order to succeed, the folder's parent
        /// must be in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. In
        /// addition, reintroducing the folder into the tree must not violate folder
        /// naming, height, and fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.undelete`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Folder, UndeleteFolderMetadata> UndeleteFolder(UndeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, UndeleteFolderMetadata>(_callUndeleteFolder.Sync(request, callSettings), UndeleteFolderOperationsClient);
        }

        /// <summary>
        /// Cancels the deletion request for a folder. This method may be called on a
        /// folder in any state. If the folder is in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state the
        /// result will be a no-op success. In order to succeed, the folder's parent
        /// must be in the
        /// [ACTIVE][google.cloud.resourcemanager.v3.Folder.State.ACTIVE] state. In
        /// addition, reintroducing the folder into the tree must not violate folder
        /// naming, height, and fanout constraints described in the
        /// [CreateFolder][google.cloud.resourcemanager.v3.Folders.CreateFolder]
        /// documentation. The caller must have `resourcemanager.folders.undelete`
        /// permission on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Folder, UndeleteFolderMetadata>> UndeleteFolderAsync(UndeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteFolderRequest(ref request, ref callSettings);
            return new lro::Operation<Folder, UndeleteFolderMetadata>(await _callUndeleteFolder.Async(request, callSettings).ConfigureAwait(false), UndeleteFolderOperationsClient);
        }

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the folder's resource name, for example: "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a folder. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the folder's resource name, for example: "folders/1234".
        /// The caller must have `resourcemanager.folders.getIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy.
        /// The `resource` field should be the folder's resource name, for example:
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a folder, replacing any existing policy.
        /// The `resource` field should be the folder's resource name, for example:
        /// "folders/1234".
        /// The caller must have `resourcemanager.folders.setIamPolicy` permission
        /// on the identified folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified folder.
        /// The `resource` field should be the folder's resource name,
        /// for example: "folders/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified folder.
        /// The `resource` field should be the folder's resource name,
        /// for example: "folders/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class ListFoldersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchFoldersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFoldersResponse : gaxgrpc::IPageResponse<Folder>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Folder> GetEnumerator() => Folders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchFoldersResponse : gaxgrpc::IPageResponse<Folder>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Folder> GetEnumerator() => Folders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Folders
    {
        public partial class FoldersClient
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
