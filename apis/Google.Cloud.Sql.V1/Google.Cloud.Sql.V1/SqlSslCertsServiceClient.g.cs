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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Sql.V1
{
    /// <summary>Settings for <see cref="SqlSslCertsServiceClient"/> instances.</summary>
    public sealed partial class SqlSslCertsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SqlSslCertsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SqlSslCertsServiceSettings"/>.</returns>
        public static SqlSslCertsServiceSettings GetDefault() => new SqlSslCertsServiceSettings();

        /// <summary>Constructs a new <see cref="SqlSslCertsServiceSettings"/> object with default settings.</summary>
        public SqlSslCertsServiceSettings()
        {
        }

        private SqlSslCertsServiceSettings(SqlSslCertsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            UpdateCustomerManagedCertificateSettings = existing.UpdateCustomerManagedCertificateSettings;
            DeleteCustomerManagedCertificateSettings = existing.DeleteCustomerManagedCertificateSettings;
            ListCustomerManagedCertificatesSettings = existing.ListCustomerManagedCertificatesSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SqlSslCertsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlSslCertsServiceClient.Delete</c> and <c>SqlSslCertsServiceClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlSslCertsServiceClient.Get</c> and <c>SqlSslCertsServiceClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlSslCertsServiceClient.Insert</c> and <c>SqlSslCertsServiceClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlSslCertsServiceClient.List</c> and <c>SqlSslCertsServiceClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlSslCertsServiceClient.UpdateCustomerManagedCertificate</c> and
        /// <c>SqlSslCertsServiceClient.UpdateCustomerManagedCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCustomerManagedCertificateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlSslCertsServiceClient.DeleteCustomerManagedCertificate</c> and
        /// <c>SqlSslCertsServiceClient.DeleteCustomerManagedCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCustomerManagedCertificateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlSslCertsServiceClient.ListCustomerManagedCertificates</c> and
        /// <c>SqlSslCertsServiceClient.ListCustomerManagedCertificatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomerManagedCertificatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SqlSslCertsServiceSettings"/> object.</returns>
        public SqlSslCertsServiceSettings Clone() => new SqlSslCertsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SqlSslCertsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SqlSslCertsServiceClientBuilder : gaxgrpc::ClientBuilderBase<SqlSslCertsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SqlSslCertsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SqlSslCertsServiceClientBuilder() : base(SqlSslCertsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SqlSslCertsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SqlSslCertsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SqlSslCertsServiceClient Build()
        {
            SqlSslCertsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SqlSslCertsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SqlSslCertsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SqlSslCertsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SqlSslCertsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SqlSslCertsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SqlSslCertsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SqlSslCertsServiceClient.ChannelPool;
    }

    /// <summary>SqlSslCertsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage SSL certs for Cloud SQL instances.
    /// </remarks>
    public abstract partial class SqlSslCertsServiceClient
    {
        /// <summary>
        /// The default endpoint for the SqlSslCertsService service, which is a host of "sqladmin.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default SqlSslCertsService scopes.</summary>
        /// <remarks>
        /// The default SqlSslCertsService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SqlSslCertsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SqlSslCertsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlSslCertsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SqlSslCertsServiceClient"/>.</returns>
        public static stt::Task<SqlSslCertsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SqlSslCertsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SqlSslCertsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlSslCertsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="SqlSslCertsServiceClient"/>.</returns>
        public static SqlSslCertsServiceClient Create() => new SqlSslCertsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SqlSslCertsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SqlSslCertsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SqlSslCertsServiceClient"/>.</returns>
        internal static SqlSslCertsServiceClient Create(grpccore::CallInvoker callInvoker, SqlSslCertsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SqlSslCertsService.SqlSslCertsServiceClient grpcClient = new SqlSslCertsService.SqlSslCertsServiceClient(callInvoker);
            return new SqlSslCertsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SqlSslCertsService client</summary>
        public virtual SqlSslCertsService.SqlSslCertsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the SSL certificate. For First Generation instances, the
        /// certificate remains valid until the instance is restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(SqlSslCertsDeleteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the SSL certificate. For First Generation instances, the
        /// certificate remains valid until the instance is restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(SqlSslCertsDeleteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the SSL certificate. For First Generation instances, the
        /// certificate remains valid until the instance is restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(SqlSslCertsDeleteRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a particular SSL certificate.  Does not include the private key
        /// (required for usage).  The private key must be saved from the response to
        /// initial creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SslCert Get(SqlSslCertsGetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a particular SSL certificate.  Does not include the private key
        /// (required for usage).  The private key must be saved from the response to
        /// initial creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SslCert> GetAsync(SqlSslCertsGetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a particular SSL certificate.  Does not include the private key
        /// (required for usage).  The private key must be saved from the response to
        /// initial creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SslCert> GetAsync(SqlSslCertsGetRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an SSL certificate and returns it along with the private key and
        /// server certificate authority.  The new certificate will not be usable until
        /// the instance is restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SslCertsInsertResponse Insert(SqlSslCertsInsertRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an SSL certificate and returns it along with the private key and
        /// server certificate authority.  The new certificate will not be usable until
        /// the instance is restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SslCertsInsertResponse> InsertAsync(SqlSslCertsInsertRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an SSL certificate and returns it along with the private key and
        /// server certificate authority.  The new certificate will not be usable until
        /// the instance is restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SslCertsInsertResponse> InsertAsync(SqlSslCertsInsertRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all of the current SSL certificates for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SslCertsListResponse List(SqlSslCertsListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all of the current SSL certificates for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SslCertsListResponse> ListAsync(SqlSslCertsListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all of the current SSL certificates for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SslCertsListResponse> ListAsync(SqlSslCertsListRequest request, st::CancellationToken cancellationToken) =>
            ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upload and update customer managed certificate bundle for an existing Cloud
        /// SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateCustomerManagedCertificate(UpdateCustomerManagedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upload and update customer managed certificate bundle for an existing Cloud
        /// SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateCustomerManagedCertificateAsync(UpdateCustomerManagedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upload and update customer managed certificate bundle for an existing Cloud
        /// SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateCustomerManagedCertificateAsync(UpdateCustomerManagedCertificateRequest request, st::CancellationToken cancellationToken) =>
            UpdateCustomerManagedCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete customer managed certificate bundle for an existing Cloud SQL
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteCustomerManagedCertificate(DeleteCustomerManagedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete customer managed certificate bundle for an existing Cloud SQL
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteCustomerManagedCertificateAsync(DeleteCustomerManagedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete customer managed certificate bundle for an existing Cloud SQL
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteCustomerManagedCertificateAsync(DeleteCustomerManagedCertificateRequest request, st::CancellationToken cancellationToken) =>
            DeleteCustomerManagedCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all customer managed certificate bundles for an existing Cloud SQL
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListCustomerManagedCertificatesResponse ListCustomerManagedCertificates(ListCustomerManagedCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all customer managed certificate bundles for an existing Cloud SQL
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListCustomerManagedCertificatesResponse> ListCustomerManagedCertificatesAsync(ListCustomerManagedCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all customer managed certificate bundles for an existing Cloud SQL
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListCustomerManagedCertificatesResponse> ListCustomerManagedCertificatesAsync(ListCustomerManagedCertificatesRequest request, st::CancellationToken cancellationToken) =>
            ListCustomerManagedCertificatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SqlSslCertsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage SSL certs for Cloud SQL instances.
    /// </remarks>
    public sealed partial class SqlSslCertsServiceClientImpl : SqlSslCertsServiceClient
    {
        private readonly gaxgrpc::ApiCall<SqlSslCertsDeleteRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<SqlSslCertsGetRequest, SslCert> _callGet;

        private readonly gaxgrpc::ApiCall<SqlSslCertsInsertRequest, SslCertsInsertResponse> _callInsert;

        private readonly gaxgrpc::ApiCall<SqlSslCertsListRequest, SslCertsListResponse> _callList;

        private readonly gaxgrpc::ApiCall<UpdateCustomerManagedCertificateRequest, Operation> _callUpdateCustomerManagedCertificate;

        private readonly gaxgrpc::ApiCall<DeleteCustomerManagedCertificateRequest, Operation> _callDeleteCustomerManagedCertificate;

        private readonly gaxgrpc::ApiCall<ListCustomerManagedCertificatesRequest, ListCustomerManagedCertificatesResponse> _callListCustomerManagedCertificates;

        /// <summary>
        /// Constructs a client wrapper for the SqlSslCertsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SqlSslCertsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SqlSslCertsServiceClientImpl(SqlSslCertsService.SqlSslCertsServiceClient grpcClient, SqlSslCertsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SqlSslCertsServiceSettings effectiveSettings = settings ?? SqlSslCertsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callDelete = clientHelper.BuildApiCall<SqlSslCertsDeleteRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance).WithGoogleRequestParam("sha1_fingerprint", request => request.Sha1Fingerprint);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<SqlSslCertsGetRequest, SslCert>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance).WithGoogleRequestParam("sha1_fingerprint", request => request.Sha1Fingerprint);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<SqlSslCertsInsertRequest, SslCertsInsertResponse>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<SqlSslCertsListRequest, SslCertsListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callUpdateCustomerManagedCertificate = clientHelper.BuildApiCall<UpdateCustomerManagedCertificateRequest, Operation>("UpdateCustomerManagedCertificate", grpcClient.UpdateCustomerManagedCertificateAsync, grpcClient.UpdateCustomerManagedCertificate, effectiveSettings.UpdateCustomerManagedCertificateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance).WithGoogleRequestParam("certificate_bundle", request => request.CertificateBundle);
            Modify_ApiCall(ref _callUpdateCustomerManagedCertificate);
            Modify_UpdateCustomerManagedCertificateApiCall(ref _callUpdateCustomerManagedCertificate);
            _callDeleteCustomerManagedCertificate = clientHelper.BuildApiCall<DeleteCustomerManagedCertificateRequest, Operation>("DeleteCustomerManagedCertificate", grpcClient.DeleteCustomerManagedCertificateAsync, grpcClient.DeleteCustomerManagedCertificate, effectiveSettings.DeleteCustomerManagedCertificateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance).WithGoogleRequestParam("certificate_bundle", request => request.CertificateBundle);
            Modify_ApiCall(ref _callDeleteCustomerManagedCertificate);
            Modify_DeleteCustomerManagedCertificateApiCall(ref _callDeleteCustomerManagedCertificate);
            _callListCustomerManagedCertificates = clientHelper.BuildApiCall<ListCustomerManagedCertificatesRequest, ListCustomerManagedCertificatesResponse>("ListCustomerManagedCertificates", grpcClient.ListCustomerManagedCertificatesAsync, grpcClient.ListCustomerManagedCertificates, effectiveSettings.ListCustomerManagedCertificatesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callListCustomerManagedCertificates);
            Modify_ListCustomerManagedCertificatesApiCall(ref _callListCustomerManagedCertificates);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<SqlSslCertsDeleteRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<SqlSslCertsGetRequest, SslCert> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<SqlSslCertsInsertRequest, SslCertsInsertResponse> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<SqlSslCertsListRequest, SslCertsListResponse> call);

        partial void Modify_UpdateCustomerManagedCertificateApiCall(ref gaxgrpc::ApiCall<UpdateCustomerManagedCertificateRequest, Operation> call);

        partial void Modify_DeleteCustomerManagedCertificateApiCall(ref gaxgrpc::ApiCall<DeleteCustomerManagedCertificateRequest, Operation> call);

        partial void Modify_ListCustomerManagedCertificatesApiCall(ref gaxgrpc::ApiCall<ListCustomerManagedCertificatesRequest, ListCustomerManagedCertificatesResponse> call);

        partial void OnConstruction(SqlSslCertsService.SqlSslCertsServiceClient grpcClient, SqlSslCertsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SqlSslCertsService client</summary>
        public override SqlSslCertsService.SqlSslCertsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SqlSslCertsDeleteRequest(ref SqlSslCertsDeleteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlSslCertsGetRequest(ref SqlSslCertsGetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlSslCertsInsertRequest(ref SqlSslCertsInsertRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlSslCertsListRequest(ref SqlSslCertsListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCustomerManagedCertificateRequest(ref UpdateCustomerManagedCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCustomerManagedCertificateRequest(ref DeleteCustomerManagedCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomerManagedCertificatesRequest(ref ListCustomerManagedCertificatesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes the SSL certificate. For First Generation instances, the
        /// certificate remains valid until the instance is restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(SqlSslCertsDeleteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlSslCertsDeleteRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the SSL certificate. For First Generation instances, the
        /// certificate remains valid until the instance is restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(SqlSslCertsDeleteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlSslCertsDeleteRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a particular SSL certificate.  Does not include the private key
        /// (required for usage).  The private key must be saved from the response to
        /// initial creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SslCert Get(SqlSslCertsGetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlSslCertsGetRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a particular SSL certificate.  Does not include the private key
        /// (required for usage).  The private key must be saved from the response to
        /// initial creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SslCert> GetAsync(SqlSslCertsGetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlSslCertsGetRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an SSL certificate and returns it along with the private key and
        /// server certificate authority.  The new certificate will not be usable until
        /// the instance is restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SslCertsInsertResponse Insert(SqlSslCertsInsertRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlSslCertsInsertRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an SSL certificate and returns it along with the private key and
        /// server certificate authority.  The new certificate will not be usable until
        /// the instance is restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SslCertsInsertResponse> InsertAsync(SqlSslCertsInsertRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlSslCertsInsertRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all of the current SSL certificates for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SslCertsListResponse List(SqlSslCertsListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlSslCertsListRequest(ref request, ref callSettings);
            return _callList.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all of the current SSL certificates for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SslCertsListResponse> ListAsync(SqlSslCertsListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlSslCertsListRequest(ref request, ref callSettings);
            return _callList.Async(request, callSettings);
        }

        /// <summary>
        /// Upload and update customer managed certificate bundle for an existing Cloud
        /// SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation UpdateCustomerManagedCertificate(UpdateCustomerManagedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomerManagedCertificateRequest(ref request, ref callSettings);
            return _callUpdateCustomerManagedCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Upload and update customer managed certificate bundle for an existing Cloud
        /// SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateCustomerManagedCertificateAsync(UpdateCustomerManagedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomerManagedCertificateRequest(ref request, ref callSettings);
            return _callUpdateCustomerManagedCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Delete customer managed certificate bundle for an existing Cloud SQL
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation DeleteCustomerManagedCertificate(DeleteCustomerManagedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomerManagedCertificateRequest(ref request, ref callSettings);
            return _callDeleteCustomerManagedCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete customer managed certificate bundle for an existing Cloud SQL
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteCustomerManagedCertificateAsync(DeleteCustomerManagedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomerManagedCertificateRequest(ref request, ref callSettings);
            return _callDeleteCustomerManagedCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// List all customer managed certificate bundles for an existing Cloud SQL
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListCustomerManagedCertificatesResponse ListCustomerManagedCertificates(ListCustomerManagedCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomerManagedCertificatesRequest(ref request, ref callSettings);
            return _callListCustomerManagedCertificates.Sync(request, callSettings);
        }

        /// <summary>
        /// List all customer managed certificate bundles for an existing Cloud SQL
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListCustomerManagedCertificatesResponse> ListCustomerManagedCertificatesAsync(ListCustomerManagedCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomerManagedCertificatesRequest(ref request, ref callSettings);
            return _callListCustomerManagedCertificates.Async(request, callSettings);
        }
    }

    public static partial class SqlSslCertsService
    {
        public partial class SqlSslCertsServiceClient
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
