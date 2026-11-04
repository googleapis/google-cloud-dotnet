// Copyright 2026 Google LLC
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

namespace Google.Cloud.Sql.V1Beta4
{
    /// <summary>Settings for <see cref="SqlBackupsServiceClient"/> instances.</summary>
    public sealed partial class SqlBackupsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SqlBackupsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SqlBackupsServiceSettings"/>.</returns>
        public static SqlBackupsServiceSettings GetDefault() => new SqlBackupsServiceSettings();

        /// <summary>Constructs a new <see cref="SqlBackupsServiceSettings"/> object with default settings.</summary>
        public SqlBackupsServiceSettings()
        {
        }

        private SqlBackupsServiceSettings(SqlBackupsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateBackupSettings = existing.CreateBackupSettings;
            GetBackupSettings = existing.GetBackupSettings;
            ListBackupsSettings = existing.ListBackupsSettings;
            UpdateBackupSettings = existing.UpdateBackupSettings;
            DeleteBackupSettings = existing.DeleteBackupSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SqlBackupsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlBackupsServiceClient.CreateBackup</c> and <c>SqlBackupsServiceClient.CreateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlBackupsServiceClient.GetBackup</c> and <c>SqlBackupsServiceClient.GetBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlBackupsServiceClient.ListBackups</c> and <c>SqlBackupsServiceClient.ListBackupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlBackupsServiceClient.UpdateBackup</c> and <c>SqlBackupsServiceClient.UpdateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlBackupsServiceClient.DeleteBackup</c> and <c>SqlBackupsServiceClient.DeleteBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SqlBackupsServiceSettings"/> object.</returns>
        public SqlBackupsServiceSettings Clone() => new SqlBackupsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SqlBackupsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SqlBackupsServiceClientBuilder : gaxgrpc::ClientBuilderBase<SqlBackupsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SqlBackupsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SqlBackupsServiceClientBuilder() : base(SqlBackupsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SqlBackupsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SqlBackupsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SqlBackupsServiceClient Build()
        {
            SqlBackupsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SqlBackupsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SqlBackupsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SqlBackupsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SqlBackupsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SqlBackupsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SqlBackupsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SqlBackupsServiceClient.ChannelPool;
    }

    /// <summary>SqlBackupsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing database backups for Cloud SQL instances.
    /// </remarks>
    public abstract partial class SqlBackupsServiceClient
    {
        /// <summary>
        /// The default endpoint for the SqlBackupsService service, which is a host of "sqladmin.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default SqlBackupsService scopes.</summary>
        /// <remarks>
        /// The default SqlBackupsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/sqlservice.admin</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/sqlservice.admin",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SqlBackupsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SqlBackupsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlBackupsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SqlBackupsServiceClient"/>.</returns>
        public static stt::Task<SqlBackupsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SqlBackupsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SqlBackupsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlBackupsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SqlBackupsServiceClient"/>.</returns>
        public static SqlBackupsServiceClient Create() => new SqlBackupsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SqlBackupsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SqlBackupsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SqlBackupsServiceClient"/>.</returns>
        internal static SqlBackupsServiceClient Create(grpccore::CallInvoker callInvoker, SqlBackupsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SqlBackupsService.SqlBackupsServiceClient grpcClient = new SqlBackupsService.SqlBackupsServiceClient(callInvoker);
            return new SqlBackupsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SqlBackupsService client</summary>
        public virtual SqlBackupsService.SqlBackupsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to
        /// create on-demand backups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CreateBackup(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to
        /// create on-demand backups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to
        /// create on-demand backups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBackupAsync(CreateBackupRequest request, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to
        /// create on-demand backups.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this backup is created.
        /// Format: projects/{project}
        /// </param>
        /// <param name="backup">
        /// Required. The Backup to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CreateBackup(string parent, Backup backup, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to
        /// create on-demand backups.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this backup is created.
        /// Format: projects/{project}
        /// </param>
        /// <param name="backup">
        /// Required. The Backup to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBackupAsync(string parent, Backup backup, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to
        /// create on-demand backups.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this backup is created.
        /// Format: projects/{project}
        /// </param>
        /// <param name="backup">
        /// Required. The Backup to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBackupAsync(string parent, Backup backup, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to
        /// create on-demand backups.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this backup is created.
        /// Format: projects/{project}
        /// </param>
        /// <param name="backup">
        /// Required. The Backup to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CreateBackup(gagr::ProjectName parent, Backup backup, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to
        /// create on-demand backups.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this backup is created.
        /// Format: projects/{project}
        /// </param>
        /// <param name="backup">
        /// Required. The Backup to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBackupAsync(gagr::ProjectName parent, Backup backup, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to
        /// create on-demand backups.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this backup is created.
        /// Format: projects/{project}
        /// </param>
        /// <param name="backup">
        /// Required. The Backup to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBackupAsync(gagr::ProjectName parent, Backup backup, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, st::CancellationToken cancellationToken) =>
            GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to retrieve.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to retrieve.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to retrieve.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to retrieve.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to retrieve.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to retrieve.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all backups associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backups associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backups associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of backups.
        /// Format: projects/{project}
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
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackups(request, callSettings);
        }

        /// <summary>
        /// Lists all backups associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of backups.
        /// Format: projects/{project}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all backups associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of backups.
        /// Format: projects/{project}
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
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackups(request, callSettings);
        }

        /// <summary>
        /// Lists all backups associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of backups.
        /// Format: projects/{project}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackupsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the retention period and the description of the backup. You can use
        /// this API to update final backups only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateBackup(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the retention period and the description of the backup. You can use
        /// this API to update final backups only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the retention period and the description of the backup. You can use
        /// this API to update final backups only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateBackupAsync(UpdateBackupRequest request, st::CancellationToken cancellationToken) =>
            UpdateBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the retention period and the description of the backup. You can use
        /// this API to update final backups only.
        /// </summary>
        /// <param name="backup">
        /// Required. The backup to update.
        /// The backup’s `name` field is used to identify the backup to update.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields that you can update. You can update only the description
        /// and retention period of the final backup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateBackup(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackup(new UpdateBackupRequest
            {
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the retention period and the description of the backup. You can use
        /// this API to update final backups only.
        /// </summary>
        /// <param name="backup">
        /// Required. The backup to update.
        /// The backup’s `name` field is used to identify the backup to update.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields that you can update. You can update only the description
        /// and retention period of the final backup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupAsync(new UpdateBackupRequest
            {
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the retention period and the description of the backup. You can use
        /// this API to update final backups only.
        /// </summary>
        /// <param name="backup">
        /// Required. The backup to update.
        /// The backup’s `name` field is used to identify the backup to update.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields that you can update. You can update only the description
        /// and retention period of the final backup.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackupAsync(backup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBackupAsync(DeleteBackupRequest request, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to delete.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to delete.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to delete.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBackupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to delete.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to delete.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the backup to delete.
        /// Format: projects/{project}/backups/{backup}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SqlBackupsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing database backups for Cloud SQL instances.
    /// </remarks>
    public sealed partial class SqlBackupsServiceClientImpl : SqlBackupsServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateBackupRequest, Operation> _callCreateBackup;

        private readonly gaxgrpc::ApiCall<GetBackupRequest, Backup> _callGetBackup;

        private readonly gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> _callListBackups;

        private readonly gaxgrpc::ApiCall<UpdateBackupRequest, Operation> _callUpdateBackup;

        private readonly gaxgrpc::ApiCall<DeleteBackupRequest, Operation> _callDeleteBackup;

        /// <summary>
        /// Constructs a client wrapper for the SqlBackupsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SqlBackupsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SqlBackupsServiceClientImpl(SqlBackupsService.SqlBackupsServiceClient grpcClient, SqlBackupsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SqlBackupsServiceSettings effectiveSettings = settings ?? SqlBackupsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateBackup = clientHelper.BuildApiCall<CreateBackupRequest, Operation>("CreateBackup", grpcClient.CreateBackupAsync, grpcClient.CreateBackup, effectiveSettings.CreateBackupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackup);
            Modify_CreateBackupApiCall(ref _callCreateBackup);
            _callGetBackup = clientHelper.BuildApiCall<GetBackupRequest, Backup>("GetBackup", grpcClient.GetBackupAsync, grpcClient.GetBackup, effectiveSettings.GetBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackup);
            Modify_GetBackupApiCall(ref _callGetBackup);
            _callListBackups = clientHelper.BuildApiCall<ListBackupsRequest, ListBackupsResponse>("ListBackups", grpcClient.ListBackupsAsync, grpcClient.ListBackups, effectiveSettings.ListBackupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackups);
            Modify_ListBackupsApiCall(ref _callListBackups);
            _callUpdateBackup = clientHelper.BuildApiCall<UpdateBackupRequest, Operation>("UpdateBackup", grpcClient.UpdateBackupAsync, grpcClient.UpdateBackup, effectiveSettings.UpdateBackupSettings).WithGoogleRequestParam("backup.name", request => request.Backup?.Name);
            Modify_ApiCall(ref _callUpdateBackup);
            Modify_UpdateBackupApiCall(ref _callUpdateBackup);
            _callDeleteBackup = clientHelper.BuildApiCall<DeleteBackupRequest, Operation>("DeleteBackup", grpcClient.DeleteBackupAsync, grpcClient.DeleteBackup, effectiveSettings.DeleteBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackup);
            Modify_DeleteBackupApiCall(ref _callDeleteBackup);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateBackupApiCall(ref gaxgrpc::ApiCall<CreateBackupRequest, Operation> call);

        partial void Modify_GetBackupApiCall(ref gaxgrpc::ApiCall<GetBackupRequest, Backup> call);

        partial void Modify_ListBackupsApiCall(ref gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> call);

        partial void Modify_UpdateBackupApiCall(ref gaxgrpc::ApiCall<UpdateBackupRequest, Operation> call);

        partial void Modify_DeleteBackupApiCall(ref gaxgrpc::ApiCall<DeleteBackupRequest, Operation> call);

        partial void OnConstruction(SqlBackupsService.SqlBackupsServiceClient grpcClient, SqlBackupsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SqlBackupsService client</summary>
        public override SqlBackupsService.SqlBackupsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateBackupRequest(ref CreateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupRequest(ref GetBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupsRequest(ref ListBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackupRequest(ref UpdateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupRequest(ref DeleteBackupRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to
        /// create on-demand backups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation CreateBackup(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupRequest(ref request, ref callSettings);
            return _callCreateBackup.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a backup for a Cloud SQL instance. This API can be used only to
        /// create on-demand backups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupRequest(ref request, ref callSettings);
            return _callCreateBackup.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupRequest(ref request, ref callSettings);
            return _callGetBackup.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupRequest(ref request, ref callSettings);
            return _callGetBackup.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all backups associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public override gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackupsRequest, ListBackupsResponse, Backup>(_callListBackups, request, callSettings);
        }

        /// <summary>
        /// Lists all backups associated with the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupsRequest, ListBackupsResponse, Backup>(_callListBackups, request, callSettings);
        }

        /// <summary>
        /// Updates the retention period and the description of the backup. You can use
        /// this API to update final backups only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation UpdateBackup(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupRequest(ref request, ref callSettings);
            return _callUpdateBackup.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the retention period and the description of the backup. You can use
        /// this API to update final backups only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupRequest(ref request, ref callSettings);
            return _callUpdateBackup.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return _callDeleteBackup.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return _callDeleteBackup.Async(request, callSettings);
        }
    }

    public partial class ListBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupsResponse : gaxgrpc::IPageResponse<Backup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Backup> GetEnumerator() => Backups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SqlBackupsService
    {
        public partial class SqlBackupsServiceClient
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
