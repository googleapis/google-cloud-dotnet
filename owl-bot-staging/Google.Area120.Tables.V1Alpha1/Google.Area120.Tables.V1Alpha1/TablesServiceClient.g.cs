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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Area120.Tables.V1Alpha1
{
    /// <summary>Settings for <see cref="TablesServiceClient"/> instances.</summary>
    public sealed partial class TablesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TablesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TablesServiceSettings"/>.</returns>
        public static TablesServiceSettings GetDefault() => new TablesServiceSettings();

        /// <summary>Constructs a new <see cref="TablesServiceSettings"/> object with default settings.</summary>
        public TablesServiceSettings()
        {
        }

        private TablesServiceSettings(TablesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTableSettings = existing.GetTableSettings;
            ListTablesSettings = existing.ListTablesSettings;
            GetWorkspaceSettings = existing.GetWorkspaceSettings;
            ListWorkspacesSettings = existing.ListWorkspacesSettings;
            GetRowSettings = existing.GetRowSettings;
            ListRowsSettings = existing.ListRowsSettings;
            CreateRowSettings = existing.CreateRowSettings;
            BatchCreateRowsSettings = existing.BatchCreateRowsSettings;
            UpdateRowSettings = existing.UpdateRowSettings;
            BatchUpdateRowsSettings = existing.BatchUpdateRowsSettings;
            DeleteRowSettings = existing.DeleteRowSettings;
            BatchDeleteRowsSettings = existing.BatchDeleteRowsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TablesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TablesServiceClient.GetTable</c> and <c>TablesServiceClient.GetTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTableSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TablesServiceClient.ListTables</c> and <c>TablesServiceClient.ListTablesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTablesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TablesServiceClient.GetWorkspace</c> and <c>TablesServiceClient.GetWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TablesServiceClient.ListWorkspaces</c> and <c>TablesServiceClient.ListWorkspacesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkspacesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TablesServiceClient.GetRow</c>
        ///  and <c>TablesServiceClient.GetRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TablesServiceClient.ListRows</c> and <c>TablesServiceClient.ListRowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TablesServiceClient.CreateRow</c> and <c>TablesServiceClient.CreateRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TablesServiceClient.BatchCreateRows</c> and <c>TablesServiceClient.BatchCreateRowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TablesServiceClient.UpdateRow</c> and <c>TablesServiceClient.UpdateRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TablesServiceClient.BatchUpdateRows</c> and <c>TablesServiceClient.BatchUpdateRowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TablesServiceClient.DeleteRow</c> and <c>TablesServiceClient.DeleteRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TablesServiceClient.BatchDeleteRows</c> and <c>TablesServiceClient.BatchDeleteRowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TablesServiceSettings"/> object.</returns>
        public TablesServiceSettings Clone() => new TablesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TablesServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TablesServiceClientBuilder : gaxgrpc::ClientBuilderBase<TablesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TablesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TablesServiceClientBuilder() : base(TablesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TablesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TablesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TablesServiceClient Build()
        {
            TablesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TablesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TablesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TablesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TablesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TablesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TablesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TablesServiceClient.ChannelPool;
    }

    /// <summary>TablesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Tables Service provides an API for reading and updating tables.
    /// It defines the following resource model:
    /// 
    /// - The API has a collection of [Table][google.area120.tables.v1alpha1.Table]
    /// resources, named `tables/*`
    /// 
    /// - Each Table has a collection of [Row][google.area120.tables.v1alpha1.Row]
    /// resources, named `tables/*/rows/*`
    /// 
    /// - The API has a collection of
    /// [Workspace][google.area120.tables.v1alpha1.Workspace]
    /// resources, named `workspaces/*`.
    /// </remarks>
    public abstract partial class TablesServiceClient
    {
        /// <summary>
        /// The default endpoint for the TablesService service, which is a host of "area120tables.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "area120tables.googleapis.com:443";

        /// <summary>The default TablesService scopes.</summary>
        /// <remarks>
        /// The default TablesService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/drive</description></item>
        /// <item><description>https://www.googleapis.com/auth/drive.file</description></item>
        /// <item><description>https://www.googleapis.com/auth/drive.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/spreadsheets</description></item>
        /// <item><description>https://www.googleapis.com/auth/spreadsheets.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/tables</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/drive",
            "https://www.googleapis.com/auth/drive.file",
            "https://www.googleapis.com/auth/drive.readonly",
            "https://www.googleapis.com/auth/spreadsheets",
            "https://www.googleapis.com/auth/spreadsheets.readonly",
            "https://www.googleapis.com/auth/tables",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TablesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TablesServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TablesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TablesServiceClient"/>.</returns>
        public static stt::Task<TablesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TablesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TablesServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TablesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TablesServiceClient"/>.</returns>
        public static TablesServiceClient Create() => new TablesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TablesServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TablesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TablesServiceClient"/>.</returns>
        internal static TablesServiceClient Create(grpccore::CallInvoker callInvoker, TablesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TablesService.TablesServiceClient grpcClient = new TablesService.TablesServiceClient(callInvoker);
            return new TablesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TablesService client</summary>
        public virtual TablesService.TablesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table GetTable(GetTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(GetTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(GetTableRequest request, st::CancellationToken cancellationToken) =>
            GetTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the table to retrieve.
        /// Format: tables/{table}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table GetTable(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTable(new GetTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the table to retrieve.
        /// Format: tables/{table}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTableAsync(new GetTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the table to retrieve.
        /// Format: tables/{table}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(string name, st::CancellationToken cancellationToken) =>
            GetTableAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the table to retrieve.
        /// Format: tables/{table}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table GetTable(TableName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTable(new GetTableRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the table to retrieve.
        /// Format: tables/{table}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(TableName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTableAsync(new GetTableRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the table to retrieve.
        /// Format: tables/{table}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(TableName name, st::CancellationToken cancellationToken) =>
            GetTableAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists tables for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Table"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTablesResponse, Table> ListTables(ListTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists tables for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Table"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(ListTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workspace GetWorkspace(GetWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(GetWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(GetWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            GetWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the workspace to retrieve.
        /// Format: workspaces/{workspace}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workspace GetWorkspace(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkspace(new GetWorkspaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the workspace to retrieve.
        /// Format: workspaces/{workspace}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkspaceAsync(new GetWorkspaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the workspace to retrieve.
        /// Format: workspaces/{workspace}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkspaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the workspace to retrieve.
        /// Format: workspaces/{workspace}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workspace GetWorkspace(WorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkspace(new GetWorkspaceRequest
            {
                WorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the workspace to retrieve.
        /// Format: workspaces/{workspace}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(WorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkspaceAsync(new GetWorkspaceRequest
            {
                WorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the workspace to retrieve.
        /// Format: workspaces/{workspace}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(WorkspaceName name, st::CancellationToken cancellationToken) =>
            GetWorkspaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists workspaces for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workspace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkspacesResponse, Workspace> ListWorkspaces(ListWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists workspaces for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workspace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkspacesResponse, Workspace> ListWorkspacesAsync(ListWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a row. Returns NOT_FOUND if the row does not exist in the table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Row GetRow(GetRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a row. Returns NOT_FOUND if the row does not exist in the table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> GetRowAsync(GetRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a row. Returns NOT_FOUND if the row does not exist in the table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> GetRowAsync(GetRowRequest request, st::CancellationToken cancellationToken) =>
            GetRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a row. Returns NOT_FOUND if the row does not exist in the table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to retrieve.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Row GetRow(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRow(new GetRowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a row. Returns NOT_FOUND if the row does not exist in the table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to retrieve.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> GetRowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRowAsync(new GetRowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a row. Returns NOT_FOUND if the row does not exist in the table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to retrieve.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> GetRowAsync(string name, st::CancellationToken cancellationToken) =>
            GetRowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a row. Returns NOT_FOUND if the row does not exist in the table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to retrieve.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Row GetRow(RowName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRow(new GetRowRequest
            {
                RowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a row. Returns NOT_FOUND if the row does not exist in the table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to retrieve.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> GetRowAsync(RowName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRowAsync(new GetRowRequest
            {
                RowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a row. Returns NOT_FOUND if the row does not exist in the table.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to retrieve.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> GetRowAsync(RowName name, st::CancellationToken cancellationToken) =>
            GetRowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists rows in a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Row"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRowsResponse, Row> ListRows(ListRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists rows in a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Row"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRowsResponse, Row> ListRowsAsync(ListRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists rows in a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent table.
        /// Format: tables/{table}
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
        /// <returns>A pageable sequence of <see cref="Row"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRowsResponse, Row> ListRows(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRowsRequest request = new ListRowsRequest
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
            return ListRows(request, callSettings);
        }

        /// <summary>
        /// Lists rows in a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent table.
        /// Format: tables/{table}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Row"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRowsResponse, Row> ListRowsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRowsRequest request = new ListRowsRequest
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
            return ListRowsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Row CreateRow(CreateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> CreateRowAsync(CreateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> CreateRowAsync(CreateRowRequest request, st::CancellationToken cancellationToken) =>
            CreateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a row.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent table where this row will be created.
        /// Format: tables/{table}
        /// </param>
        /// <param name="row">
        /// Required. The row to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Row CreateRow(string parent, Row row, gaxgrpc::CallSettings callSettings = null) =>
            CreateRow(new CreateRowRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Row = gax::GaxPreconditions.CheckNotNull(row, nameof(row)),
            }, callSettings);

        /// <summary>
        /// Creates a row.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent table where this row will be created.
        /// Format: tables/{table}
        /// </param>
        /// <param name="row">
        /// Required. The row to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> CreateRowAsync(string parent, Row row, gaxgrpc::CallSettings callSettings = null) =>
            CreateRowAsync(new CreateRowRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Row = gax::GaxPreconditions.CheckNotNull(row, nameof(row)),
            }, callSettings);

        /// <summary>
        /// Creates a row.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent table where this row will be created.
        /// Format: tables/{table}
        /// </param>
        /// <param name="row">
        /// Required. The row to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> CreateRowAsync(string parent, Row row, st::CancellationToken cancellationToken) =>
            CreateRowAsync(parent, row, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateRowsResponse BatchCreateRows(BatchCreateRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateRowsResponse> BatchCreateRowsAsync(BatchCreateRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateRowsResponse> BatchCreateRowsAsync(BatchCreateRowsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Row UpdateRow(UpdateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> UpdateRowAsync(UpdateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> UpdateRowAsync(UpdateRowRequest request, st::CancellationToken cancellationToken) =>
            UpdateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a row.
        /// </summary>
        /// <param name="row">
        /// Required. The row to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Row UpdateRow(Row row, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRow(new UpdateRowRequest
            {
                Row = gax::GaxPreconditions.CheckNotNull(row, nameof(row)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a row.
        /// </summary>
        /// <param name="row">
        /// Required. The row to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> UpdateRowAsync(Row row, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRowAsync(new UpdateRowRequest
            {
                Row = gax::GaxPreconditions.CheckNotNull(row, nameof(row)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a row.
        /// </summary>
        /// <param name="row">
        /// Required. The row to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Row> UpdateRowAsync(Row row, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRowAsync(row, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateRowsResponse BatchUpdateRows(BatchUpdateRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateRowsResponse> BatchUpdateRowsAsync(BatchUpdateRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateRowsResponse> BatchUpdateRowsAsync(BatchUpdateRowsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRow(DeleteRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRowAsync(DeleteRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRowAsync(DeleteRowRequest request, st::CancellationToken cancellationToken) =>
            DeleteRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a row.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to delete.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRow(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRow(new DeleteRowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a row.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to delete.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRowAsync(new DeleteRowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a row.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to delete.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRowAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a row.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to delete.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRow(RowName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRow(new DeleteRowRequest
            {
                RowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a row.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to delete.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRowAsync(RowName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRowAsync(new DeleteRowRequest
            {
                RowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a row.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the row to delete.
        /// Format: tables/{table}/rows/{row}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRowAsync(RowName name, st::CancellationToken cancellationToken) =>
            DeleteRowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteRows(BatchDeleteRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteRowsAsync(BatchDeleteRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteRowsAsync(BatchDeleteRowsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TablesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Tables Service provides an API for reading and updating tables.
    /// It defines the following resource model:
    /// 
    /// - The API has a collection of [Table][google.area120.tables.v1alpha1.Table]
    /// resources, named `tables/*`
    /// 
    /// - Each Table has a collection of [Row][google.area120.tables.v1alpha1.Row]
    /// resources, named `tables/*/rows/*`
    /// 
    /// - The API has a collection of
    /// [Workspace][google.area120.tables.v1alpha1.Workspace]
    /// resources, named `workspaces/*`.
    /// </remarks>
    public sealed partial class TablesServiceClientImpl : TablesServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetTableRequest, Table> _callGetTable;

        private readonly gaxgrpc::ApiCall<ListTablesRequest, ListTablesResponse> _callListTables;

        private readonly gaxgrpc::ApiCall<GetWorkspaceRequest, Workspace> _callGetWorkspace;

        private readonly gaxgrpc::ApiCall<ListWorkspacesRequest, ListWorkspacesResponse> _callListWorkspaces;

        private readonly gaxgrpc::ApiCall<GetRowRequest, Row> _callGetRow;

        private readonly gaxgrpc::ApiCall<ListRowsRequest, ListRowsResponse> _callListRows;

        private readonly gaxgrpc::ApiCall<CreateRowRequest, Row> _callCreateRow;

        private readonly gaxgrpc::ApiCall<BatchCreateRowsRequest, BatchCreateRowsResponse> _callBatchCreateRows;

        private readonly gaxgrpc::ApiCall<UpdateRowRequest, Row> _callUpdateRow;

        private readonly gaxgrpc::ApiCall<BatchUpdateRowsRequest, BatchUpdateRowsResponse> _callBatchUpdateRows;

        private readonly gaxgrpc::ApiCall<DeleteRowRequest, wkt::Empty> _callDeleteRow;

        private readonly gaxgrpc::ApiCall<BatchDeleteRowsRequest, wkt::Empty> _callBatchDeleteRows;

        /// <summary>
        /// Constructs a client wrapper for the TablesService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TablesServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TablesServiceClientImpl(TablesService.TablesServiceClient grpcClient, TablesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TablesServiceSettings effectiveSettings = settings ?? TablesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetTable = clientHelper.BuildApiCall<GetTableRequest, Table>("GetTable", grpcClient.GetTableAsync, grpcClient.GetTable, effectiveSettings.GetTableSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTable);
            Modify_GetTableApiCall(ref _callGetTable);
            _callListTables = clientHelper.BuildApiCall<ListTablesRequest, ListTablesResponse>("ListTables", grpcClient.ListTablesAsync, grpcClient.ListTables, effectiveSettings.ListTablesSettings);
            Modify_ApiCall(ref _callListTables);
            Modify_ListTablesApiCall(ref _callListTables);
            _callGetWorkspace = clientHelper.BuildApiCall<GetWorkspaceRequest, Workspace>("GetWorkspace", grpcClient.GetWorkspaceAsync, grpcClient.GetWorkspace, effectiveSettings.GetWorkspaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkspace);
            Modify_GetWorkspaceApiCall(ref _callGetWorkspace);
            _callListWorkspaces = clientHelper.BuildApiCall<ListWorkspacesRequest, ListWorkspacesResponse>("ListWorkspaces", grpcClient.ListWorkspacesAsync, grpcClient.ListWorkspaces, effectiveSettings.ListWorkspacesSettings);
            Modify_ApiCall(ref _callListWorkspaces);
            Modify_ListWorkspacesApiCall(ref _callListWorkspaces);
            _callGetRow = clientHelper.BuildApiCall<GetRowRequest, Row>("GetRow", grpcClient.GetRowAsync, grpcClient.GetRow, effectiveSettings.GetRowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRow);
            Modify_GetRowApiCall(ref _callGetRow);
            _callListRows = clientHelper.BuildApiCall<ListRowsRequest, ListRowsResponse>("ListRows", grpcClient.ListRowsAsync, grpcClient.ListRows, effectiveSettings.ListRowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRows);
            Modify_ListRowsApiCall(ref _callListRows);
            _callCreateRow = clientHelper.BuildApiCall<CreateRowRequest, Row>("CreateRow", grpcClient.CreateRowAsync, grpcClient.CreateRow, effectiveSettings.CreateRowSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRow);
            Modify_CreateRowApiCall(ref _callCreateRow);
            _callBatchCreateRows = clientHelper.BuildApiCall<BatchCreateRowsRequest, BatchCreateRowsResponse>("BatchCreateRows", grpcClient.BatchCreateRowsAsync, grpcClient.BatchCreateRows, effectiveSettings.BatchCreateRowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateRows);
            Modify_BatchCreateRowsApiCall(ref _callBatchCreateRows);
            _callUpdateRow = clientHelper.BuildApiCall<UpdateRowRequest, Row>("UpdateRow", grpcClient.UpdateRowAsync, grpcClient.UpdateRow, effectiveSettings.UpdateRowSettings).WithGoogleRequestParam("row.name", request => request.Row?.Name);
            Modify_ApiCall(ref _callUpdateRow);
            Modify_UpdateRowApiCall(ref _callUpdateRow);
            _callBatchUpdateRows = clientHelper.BuildApiCall<BatchUpdateRowsRequest, BatchUpdateRowsResponse>("BatchUpdateRows", grpcClient.BatchUpdateRowsAsync, grpcClient.BatchUpdateRows, effectiveSettings.BatchUpdateRowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateRows);
            Modify_BatchUpdateRowsApiCall(ref _callBatchUpdateRows);
            _callDeleteRow = clientHelper.BuildApiCall<DeleteRowRequest, wkt::Empty>("DeleteRow", grpcClient.DeleteRowAsync, grpcClient.DeleteRow, effectiveSettings.DeleteRowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRow);
            Modify_DeleteRowApiCall(ref _callDeleteRow);
            _callBatchDeleteRows = clientHelper.BuildApiCall<BatchDeleteRowsRequest, wkt::Empty>("BatchDeleteRows", grpcClient.BatchDeleteRowsAsync, grpcClient.BatchDeleteRows, effectiveSettings.BatchDeleteRowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteRows);
            Modify_BatchDeleteRowsApiCall(ref _callBatchDeleteRows);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTableApiCall(ref gaxgrpc::ApiCall<GetTableRequest, Table> call);

        partial void Modify_ListTablesApiCall(ref gaxgrpc::ApiCall<ListTablesRequest, ListTablesResponse> call);

        partial void Modify_GetWorkspaceApiCall(ref gaxgrpc::ApiCall<GetWorkspaceRequest, Workspace> call);

        partial void Modify_ListWorkspacesApiCall(ref gaxgrpc::ApiCall<ListWorkspacesRequest, ListWorkspacesResponse> call);

        partial void Modify_GetRowApiCall(ref gaxgrpc::ApiCall<GetRowRequest, Row> call);

        partial void Modify_ListRowsApiCall(ref gaxgrpc::ApiCall<ListRowsRequest, ListRowsResponse> call);

        partial void Modify_CreateRowApiCall(ref gaxgrpc::ApiCall<CreateRowRequest, Row> call);

        partial void Modify_BatchCreateRowsApiCall(ref gaxgrpc::ApiCall<BatchCreateRowsRequest, BatchCreateRowsResponse> call);

        partial void Modify_UpdateRowApiCall(ref gaxgrpc::ApiCall<UpdateRowRequest, Row> call);

        partial void Modify_BatchUpdateRowsApiCall(ref gaxgrpc::ApiCall<BatchUpdateRowsRequest, BatchUpdateRowsResponse> call);

        partial void Modify_DeleteRowApiCall(ref gaxgrpc::ApiCall<DeleteRowRequest, wkt::Empty> call);

        partial void Modify_BatchDeleteRowsApiCall(ref gaxgrpc::ApiCall<BatchDeleteRowsRequest, wkt::Empty> call);

        partial void OnConstruction(TablesService.TablesServiceClient grpcClient, TablesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TablesService client</summary>
        public override TablesService.TablesServiceClient GrpcClient { get; }

        partial void Modify_GetTableRequest(ref GetTableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTablesRequest(ref ListTablesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkspaceRequest(ref GetWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkspacesRequest(ref ListWorkspacesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRowRequest(ref GetRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRowsRequest(ref ListRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRowRequest(ref CreateRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateRowsRequest(ref BatchCreateRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRowRequest(ref UpdateRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateRowsRequest(ref BatchUpdateRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRowRequest(ref DeleteRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteRowsRequest(ref BatchDeleteRowsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Table GetTable(GetTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTableRequest(ref request, ref callSettings);
            return _callGetTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Table> GetTableAsync(GetTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTableRequest(ref request, ref callSettings);
            return _callGetTable.Async(request, callSettings);
        }

        /// <summary>
        /// Lists tables for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Table"/> resources.</returns>
        public override gax::PagedEnumerable<ListTablesResponse, Table> ListTables(ListTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTablesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTablesRequest, ListTablesResponse, Table>(_callListTables, request, callSettings);
        }

        /// <summary>
        /// Lists tables for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Table"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(ListTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTablesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTablesRequest, ListTablesResponse, Table>(_callListTables, request, callSettings);
        }

        /// <summary>
        /// Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Workspace GetWorkspace(GetWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkspaceRequest(ref request, ref callSettings);
            return _callGetWorkspace.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a workspace. Returns NOT_FOUND if the workspace does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Workspace> GetWorkspaceAsync(GetWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkspaceRequest(ref request, ref callSettings);
            return _callGetWorkspace.Async(request, callSettings);
        }

        /// <summary>
        /// Lists workspaces for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workspace"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkspacesResponse, Workspace> ListWorkspaces(ListWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkspacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkspacesRequest, ListWorkspacesResponse, Workspace>(_callListWorkspaces, request, callSettings);
        }

        /// <summary>
        /// Lists workspaces for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workspace"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkspacesResponse, Workspace> ListWorkspacesAsync(ListWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkspacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkspacesRequest, ListWorkspacesResponse, Workspace>(_callListWorkspaces, request, callSettings);
        }

        /// <summary>
        /// Gets a row. Returns NOT_FOUND if the row does not exist in the table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Row GetRow(GetRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRowRequest(ref request, ref callSettings);
            return _callGetRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a row. Returns NOT_FOUND if the row does not exist in the table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Row> GetRowAsync(GetRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRowRequest(ref request, ref callSettings);
            return _callGetRow.Async(request, callSettings);
        }

        /// <summary>
        /// Lists rows in a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Row"/> resources.</returns>
        public override gax::PagedEnumerable<ListRowsResponse, Row> ListRows(ListRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRowsRequest, ListRowsResponse, Row>(_callListRows, request, callSettings);
        }

        /// <summary>
        /// Lists rows in a table. Returns NOT_FOUND if the table does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Row"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRowsResponse, Row> ListRowsAsync(ListRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRowsRequest, ListRowsResponse, Row>(_callListRows, request, callSettings);
        }

        /// <summary>
        /// Creates a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Row CreateRow(CreateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRowRequest(ref request, ref callSettings);
            return _callCreateRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Row> CreateRowAsync(CreateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRowRequest(ref request, ref callSettings);
            return _callCreateRow.Async(request, callSettings);
        }

        /// <summary>
        /// Creates multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateRowsResponse BatchCreateRows(BatchCreateRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateRowsRequest(ref request, ref callSettings);
            return _callBatchCreateRows.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateRowsResponse> BatchCreateRowsAsync(BatchCreateRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateRowsRequest(ref request, ref callSettings);
            return _callBatchCreateRows.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Row UpdateRow(UpdateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRowRequest(ref request, ref callSettings);
            return _callUpdateRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Row> UpdateRowAsync(UpdateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRowRequest(ref request, ref callSettings);
            return _callUpdateRow.Async(request, callSettings);
        }

        /// <summary>
        /// Updates multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateRowsResponse BatchUpdateRows(BatchUpdateRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateRowsRequest(ref request, ref callSettings);
            return _callBatchUpdateRows.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateRowsResponse> BatchUpdateRowsAsync(BatchUpdateRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateRowsRequest(ref request, ref callSettings);
            return _callBatchUpdateRows.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteRow(DeleteRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRowRequest(ref request, ref callSettings);
            _callDeleteRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteRowAsync(DeleteRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRowRequest(ref request, ref callSettings);
            return _callDeleteRow.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchDeleteRows(BatchDeleteRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteRowsRequest(ref request, ref callSettings);
            _callBatchDeleteRows.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes multiple rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchDeleteRowsAsync(BatchDeleteRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteRowsRequest(ref request, ref callSettings);
            return _callBatchDeleteRows.Async(request, callSettings);
        }
    }

    public partial class ListTablesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkspacesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRowsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTablesResponse : gaxgrpc::IPageResponse<Table>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Table> GetEnumerator() => Tables.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListWorkspacesResponse : gaxgrpc::IPageResponse<Workspace>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Workspace> GetEnumerator() => Workspaces.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRowsResponse : gaxgrpc::IPageResponse<Row>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Row> GetEnumerator() => Rows.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
