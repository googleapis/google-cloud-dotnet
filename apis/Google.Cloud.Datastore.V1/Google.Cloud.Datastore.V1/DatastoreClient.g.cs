// Copyright 2019 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using linq = System.Linq;
using sysnet = System.Net;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Datastore.V1
{
    /// <summary>Settings for <see cref="DatastoreClient"/> instances.</summary>
    public sealed partial class DatastoreSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DatastoreSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DatastoreSettings"/>.</returns>
        public static DatastoreSettings GetDefault() => new DatastoreSettings();

        /// <summary>Constructs a new <see cref="DatastoreSettings"/> object with default settings.</summary>
        public DatastoreSettings()
        {
        }

        private DatastoreSettings(DatastoreSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            LookupSettings = existing.LookupSettings;
            RunQuerySettings = existing.RunQuerySettings;
            BeginTransactionSettings = existing.BeginTransactionSettings;
            CommitSettings = existing.CommitSettings;
            RollbackSettings = existing.RollbackSettings;
            AllocateIdsSettings = existing.AllocateIdsSettings;
            ReserveIdsSettings = existing.ReserveIdsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DatastoreSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DatastoreClient.Lookup</c>
        /// and <c>DatastoreClient.LookupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LookupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DatastoreClient.RunQuery</c>
        ///  and <c>DatastoreClient.RunQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunQuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DatastoreClient.BeginTransaction</c> and <c>DatastoreClient.BeginTransactionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BeginTransactionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DatastoreClient.Commit</c>
        /// and <c>DatastoreClient.CommitAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CommitSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DatastoreClient.Rollback</c>
        ///  and <c>DatastoreClient.RollbackAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollbackSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DatastoreClient.AllocateIds</c>
        ///  and <c>DatastoreClient.AllocateIdsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AllocateIdsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DatastoreClient.ReserveIds</c>
        ///  and <c>DatastoreClient.ReserveIdsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReserveIdsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DatastoreSettings"/> object.</returns>
        public DatastoreSettings Clone() => new DatastoreSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DatastoreClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DatastoreClientBuilder : gaxgrpc::ClientBuilderBase<DatastoreClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DatastoreSettings Settings { get; set; }

        /// <inheritdoc/>
        public override DatastoreClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DatastoreClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<DatastoreClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DatastoreClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => DatastoreClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DatastoreClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DatastoreClient.ChannelPool;
    }

    /// <summary>Datastore client wrapper, for convenient use.</summary>
    public abstract partial class DatastoreClient
    {
        /// <summary>
        /// The default endpoint for the Datastore service, which is a host of "datastore.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("datastore.googleapis.com", 443);

        /// <summary>The default Datastore scopes.</summary>
        /// <remarks>
        /// The default Datastore scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/datastore</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/datastore",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="DatastoreClient"/>, applying defaults for all unspecified settings, and
        /// creating a channel connecting to the given endpoint with application default credentials where necessary.
        /// See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DatastoreSettings"/>.</param>
        /// <returns>The task representing the created <see cref="DatastoreClient"/>.</returns>
        public static async stt::Task<DatastoreClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, DatastoreSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="DatastoreClient"/>, applying defaults for all unspecified settings, and
        /// creating a channel connecting to the given endpoint with application default credentials where necessary.
        /// See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DatastoreSettings"/>.</param>
        /// <returns>The created <see cref="DatastoreClient"/>.</returns>
        public static DatastoreClient Create(gaxgrpc::ServiceEndpoint endpoint = null, DatastoreSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="DatastoreClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DatastoreSettings"/>.</param>
        /// <returns>The created <see cref="DatastoreClient"/>.</returns>
        public static DatastoreClient Create(grpccore::Channel channel, DatastoreSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="DatastoreClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DatastoreSettings"/>.</param>
        /// <returns>The created <see cref="DatastoreClient"/>.</returns>
        public static DatastoreClient Create(grpccore::CallInvoker callInvoker, DatastoreSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Datastore.DatastoreClient grpcClient = new Datastore.DatastoreClient(callInvoker);
            return new DatastoreClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,DatastoreSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,DatastoreSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create(grpccore::CallInvoker,DatastoreSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,DatastoreSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC Datastore client</summary>
        public virtual Datastore.DatastoreClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupResponse Lookup(LookupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupResponse> LookupAsync(LookupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupResponse> LookupAsync(LookupRequest request, st::CancellationToken cancellationToken) =>
            LookupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="readOptions">
        /// The options for this lookup request.
        /// </param>
        /// <param name="keys">
        /// Required. Keys of entities to look up.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupResponse Lookup(string projectId, ReadOptions readOptions, scg::IEnumerable<Key> keys, gaxgrpc::CallSettings callSettings = null) =>
            Lookup(new LookupRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                ReadOptions = readOptions,
                Keys =
                {
                    gax::GaxPreconditions.CheckNotNull(keys, nameof(keys)),
                },
            }, callSettings);

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="readOptions">
        /// The options for this lookup request.
        /// </param>
        /// <param name="keys">
        /// Required. Keys of entities to look up.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupResponse> LookupAsync(string projectId, ReadOptions readOptions, scg::IEnumerable<Key> keys, gaxgrpc::CallSettings callSettings = null) =>
            LookupAsync(new LookupRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                ReadOptions = readOptions,
                Keys =
                {
                    gax::GaxPreconditions.CheckNotNull(keys, nameof(keys)),
                },
            }, callSettings);

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="readOptions">
        /// The options for this lookup request.
        /// </param>
        /// <param name="keys">
        /// Required. Keys of entities to look up.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupResponse> LookupAsync(string projectId, ReadOptions readOptions, scg::IEnumerable<Key> keys, st::CancellationToken cancellationToken) =>
            LookupAsync(projectId, readOptions, keys, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunQueryResponse RunQuery(RunQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunQueryResponse> RunQueryAsync(RunQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunQueryResponse> RunQueryAsync(RunQueryRequest request, st::CancellationToken cancellationToken) =>
            RunQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BeginTransactionResponse BeginTransaction(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(BeginTransactionRequest request, st::CancellationToken cancellationToken) =>
            BeginTransactionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BeginTransactionResponse BeginTransaction(string projectId, gaxgrpc::CallSettings callSettings = null) =>
            BeginTransaction(new BeginTransactionRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
            }, callSettings);

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(string projectId, gaxgrpc::CallSettings callSettings = null) =>
            BeginTransactionAsync(new BeginTransactionRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
            }, callSettings);

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(string projectId, st::CancellationToken cancellationToken) =>
            BeginTransactionAsync(projectId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(CommitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(CommitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(CommitRequest request, st::CancellationToken cancellationToken) =>
            CommitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="mode">
        /// The type of commit to perform. Defaults to `TRANSACTIONAL`.
        /// </param>
        /// <param name="transaction">
        /// The identifier of the transaction associated with the commit. A
        /// transaction identifier is returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="mutations">
        /// The mutations to perform.
        /// 
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// 
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        /// 
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(string projectId, CommitRequest.Types.Mode mode, proto::ByteString transaction, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            Commit(new CommitRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Mode = mode,
                Transaction = transaction ?? proto::ByteString.Empty,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="mode">
        /// The type of commit to perform. Defaults to `TRANSACTIONAL`.
        /// </param>
        /// <param name="transaction">
        /// The identifier of the transaction associated with the commit. A
        /// transaction identifier is returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="mutations">
        /// The mutations to perform.
        /// 
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// 
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        /// 
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(string projectId, CommitRequest.Types.Mode mode, proto::ByteString transaction, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            CommitAsync(new CommitRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Mode = mode,
                Transaction = transaction ?? proto::ByteString.Empty,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="mode">
        /// The type of commit to perform. Defaults to `TRANSACTIONAL`.
        /// </param>
        /// <param name="transaction">
        /// The identifier of the transaction associated with the commit. A
        /// transaction identifier is returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="mutations">
        /// The mutations to perform.
        /// 
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// 
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        /// 
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(string projectId, CommitRequest.Types.Mode mode, proto::ByteString transaction, scg::IEnumerable<Mutation> mutations, st::CancellationToken cancellationToken) =>
            CommitAsync(projectId, mode, transaction, mutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="mode">
        /// The type of commit to perform. Defaults to `TRANSACTIONAL`.
        /// </param>
        /// <param name="mutations">
        /// The mutations to perform.
        /// 
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// 
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        /// 
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(string projectId, CommitRequest.Types.Mode mode, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            Commit(new CommitRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Mode = mode,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="mode">
        /// The type of commit to perform. Defaults to `TRANSACTIONAL`.
        /// </param>
        /// <param name="mutations">
        /// The mutations to perform.
        /// 
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// 
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        /// 
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(string projectId, CommitRequest.Types.Mode mode, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            CommitAsync(new CommitRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Mode = mode,
                Mutations =
                {
                    mutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="mode">
        /// The type of commit to perform. Defaults to `TRANSACTIONAL`.
        /// </param>
        /// <param name="mutations">
        /// The mutations to perform.
        /// 
        /// When mode is `TRANSACTIONAL`, mutations affecting a single entity are
        /// applied in order. The following sequences of mutations affecting a single
        /// entity are not permitted in a single `Commit` request:
        /// 
        /// - `insert` followed by `insert`
        /// - `update` followed by `insert`
        /// - `upsert` followed by `insert`
        /// - `delete` followed by `update`
        /// 
        /// When mode is `NON_TRANSACTIONAL`, no two mutations may affect a single
        /// entity.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(string projectId, CommitRequest.Types.Mode mode, scg::IEnumerable<Mutation> mutations, st::CancellationToken cancellationToken) =>
            CommitAsync(projectId, mode, mutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RollbackResponse Rollback(RollbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RollbackResponse> RollbackAsync(RollbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RollbackResponse> RollbackAsync(RollbackRequest request, st::CancellationToken cancellationToken) =>
            RollbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="transaction">
        /// Required. The transaction identifier, returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RollbackResponse Rollback(string projectId, proto::ByteString transaction, gaxgrpc::CallSettings callSettings = null) =>
            Rollback(new RollbackRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Transaction = gax::GaxPreconditions.CheckNotNull(transaction, nameof(transaction)),
            }, callSettings);

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="transaction">
        /// Required. The transaction identifier, returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RollbackResponse> RollbackAsync(string projectId, proto::ByteString transaction, gaxgrpc::CallSettings callSettings = null) =>
            RollbackAsync(new RollbackRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Transaction = gax::GaxPreconditions.CheckNotNull(transaction, nameof(transaction)),
            }, callSettings);

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="transaction">
        /// Required. The transaction identifier, returned by a call to
        /// [Datastore.BeginTransaction][google.datastore.v1.Datastore.BeginTransaction].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RollbackResponse> RollbackAsync(string projectId, proto::ByteString transaction, st::CancellationToken cancellationToken) =>
            RollbackAsync(projectId, transaction, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AllocateIdsResponse AllocateIds(AllocateIdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AllocateIdsResponse> AllocateIdsAsync(AllocateIdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AllocateIdsResponse> AllocateIdsAsync(AllocateIdsRequest request, st::CancellationToken cancellationToken) =>
            AllocateIdsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="keys">
        /// Required. A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AllocateIdsResponse AllocateIds(string projectId, scg::IEnumerable<Key> keys, gaxgrpc::CallSettings callSettings = null) =>
            AllocateIds(new AllocateIdsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Keys =
                {
                    gax::GaxPreconditions.CheckNotNull(keys, nameof(keys)),
                },
            }, callSettings);

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="keys">
        /// Required. A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AllocateIdsResponse> AllocateIdsAsync(string projectId, scg::IEnumerable<Key> keys, gaxgrpc::CallSettings callSettings = null) =>
            AllocateIdsAsync(new AllocateIdsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Keys =
                {
                    gax::GaxPreconditions.CheckNotNull(keys, nameof(keys)),
                },
            }, callSettings);

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="keys">
        /// Required. A list of keys with incomplete key paths for which to allocate IDs.
        /// No key may be reserved/read-only.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AllocateIdsResponse> AllocateIdsAsync(string projectId, scg::IEnumerable<Key> keys, st::CancellationToken cancellationToken) =>
            AllocateIdsAsync(projectId, keys, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
        /// Datastore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReserveIdsResponse ReserveIds(ReserveIdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
        /// Datastore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReserveIdsResponse> ReserveIdsAsync(ReserveIdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
        /// Datastore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReserveIdsResponse> ReserveIdsAsync(ReserveIdsRequest request, st::CancellationToken cancellationToken) =>
            ReserveIdsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
        /// Datastore.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="keys">
        /// Required. A list of keys with complete key paths whose numeric IDs should not be
        /// auto-allocated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReserveIdsResponse ReserveIds(string projectId, scg::IEnumerable<Key> keys, gaxgrpc::CallSettings callSettings = null) =>
            ReserveIds(new ReserveIdsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Keys =
                {
                    gax::GaxPreconditions.CheckNotNull(keys, nameof(keys)),
                },
            }, callSettings);

        /// <summary>
        /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
        /// Datastore.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="keys">
        /// Required. A list of keys with complete key paths whose numeric IDs should not be
        /// auto-allocated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReserveIdsResponse> ReserveIdsAsync(string projectId, scg::IEnumerable<Key> keys, gaxgrpc::CallSettings callSettings = null) =>
            ReserveIdsAsync(new ReserveIdsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Keys =
                {
                    gax::GaxPreconditions.CheckNotNull(keys, nameof(keys)),
                },
            }, callSettings);

        /// <summary>
        /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
        /// Datastore.
        /// </summary>
        /// <param name="projectId">
        /// Required. The ID of the project against which to make the request.
        /// </param>
        /// <param name="keys">
        /// Required. A list of keys with complete key paths whose numeric IDs should not be
        /// auto-allocated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReserveIdsResponse> ReserveIdsAsync(string projectId, scg::IEnumerable<Key> keys, st::CancellationToken cancellationToken) =>
            ReserveIdsAsync(projectId, keys, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Datastore client wrapper implementation, for convenient use.</summary>
    public sealed partial class DatastoreClientImpl : DatastoreClient
    {
        private readonly gaxgrpc::ApiCall<LookupRequest, LookupResponse> _callLookup;

        private readonly gaxgrpc::ApiCall<RunQueryRequest, RunQueryResponse> _callRunQuery;

        private readonly gaxgrpc::ApiCall<BeginTransactionRequest, BeginTransactionResponse> _callBeginTransaction;

        private readonly gaxgrpc::ApiCall<CommitRequest, CommitResponse> _callCommit;

        private readonly gaxgrpc::ApiCall<RollbackRequest, RollbackResponse> _callRollback;

        private readonly gaxgrpc::ApiCall<AllocateIdsRequest, AllocateIdsResponse> _callAllocateIds;

        private readonly gaxgrpc::ApiCall<ReserveIdsRequest, ReserveIdsResponse> _callReserveIds;

        /// <summary>
        /// Constructs a client wrapper for the Datastore service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DatastoreSettings"/> used within this client.</param>
        public DatastoreClientImpl(Datastore.DatastoreClient grpcClient, DatastoreSettings settings)
        {
            GrpcClient = grpcClient;
            DatastoreSettings effectiveSettings = settings ?? DatastoreSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callLookup = clientHelper.BuildApiCall<LookupRequest, LookupResponse>(grpcClient.LookupAsync, grpcClient.Lookup, effectiveSettings.LookupSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"project_id={(sysnet::WebUtility.UrlEncode(request.ProjectId))}"));
            Modify_ApiCall(ref _callLookup);
            Modify_LookupApiCall(ref _callLookup);
            _callRunQuery = clientHelper.BuildApiCall<RunQueryRequest, RunQueryResponse>(grpcClient.RunQueryAsync, grpcClient.RunQuery, effectiveSettings.RunQuerySettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"project_id={(sysnet::WebUtility.UrlEncode(request.ProjectId))}"));
            Modify_ApiCall(ref _callRunQuery);
            Modify_RunQueryApiCall(ref _callRunQuery);
            _callBeginTransaction = clientHelper.BuildApiCall<BeginTransactionRequest, BeginTransactionResponse>(grpcClient.BeginTransactionAsync, grpcClient.BeginTransaction, effectiveSettings.BeginTransactionSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"project_id={(sysnet::WebUtility.UrlEncode(request.ProjectId))}"));
            Modify_ApiCall(ref _callBeginTransaction);
            Modify_BeginTransactionApiCall(ref _callBeginTransaction);
            _callCommit = clientHelper.BuildApiCall<CommitRequest, CommitResponse>(grpcClient.CommitAsync, grpcClient.Commit, effectiveSettings.CommitSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"project_id={(sysnet::WebUtility.UrlEncode(request.ProjectId))}"));
            Modify_ApiCall(ref _callCommit);
            Modify_CommitApiCall(ref _callCommit);
            _callRollback = clientHelper.BuildApiCall<RollbackRequest, RollbackResponse>(grpcClient.RollbackAsync, grpcClient.Rollback, effectiveSettings.RollbackSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"project_id={(sysnet::WebUtility.UrlEncode(request.ProjectId))}"));
            Modify_ApiCall(ref _callRollback);
            Modify_RollbackApiCall(ref _callRollback);
            _callAllocateIds = clientHelper.BuildApiCall<AllocateIdsRequest, AllocateIdsResponse>(grpcClient.AllocateIdsAsync, grpcClient.AllocateIds, effectiveSettings.AllocateIdsSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"project_id={(sysnet::WebUtility.UrlEncode(request.ProjectId))}"));
            Modify_ApiCall(ref _callAllocateIds);
            Modify_AllocateIdsApiCall(ref _callAllocateIds);
            _callReserveIds = clientHelper.BuildApiCall<ReserveIdsRequest, ReserveIdsResponse>(grpcClient.ReserveIdsAsync, grpcClient.ReserveIds, effectiveSettings.ReserveIdsSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"project_id={(sysnet::WebUtility.UrlEncode(request.ProjectId))}"));
            Modify_ApiCall(ref _callReserveIds);
            Modify_ReserveIdsApiCall(ref _callReserveIds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_LookupApiCall(ref gaxgrpc::ApiCall<LookupRequest, LookupResponse> call);

        partial void Modify_RunQueryApiCall(ref gaxgrpc::ApiCall<RunQueryRequest, RunQueryResponse> call);

        partial void Modify_BeginTransactionApiCall(ref gaxgrpc::ApiCall<BeginTransactionRequest, BeginTransactionResponse> call);

        partial void Modify_CommitApiCall(ref gaxgrpc::ApiCall<CommitRequest, CommitResponse> call);

        partial void Modify_RollbackApiCall(ref gaxgrpc::ApiCall<RollbackRequest, RollbackResponse> call);

        partial void Modify_AllocateIdsApiCall(ref gaxgrpc::ApiCall<AllocateIdsRequest, AllocateIdsResponse> call);

        partial void Modify_ReserveIdsApiCall(ref gaxgrpc::ApiCall<ReserveIdsRequest, ReserveIdsResponse> call);

        partial void OnConstruction(Datastore.DatastoreClient grpcClient, DatastoreSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Datastore client</summary>
        public override Datastore.DatastoreClient GrpcClient { get; }

        partial void Modify_LookupRequest(ref LookupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunQueryRequest(ref RunQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BeginTransactionRequest(ref BeginTransactionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CommitRequest(ref CommitRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollbackRequest(ref RollbackRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AllocateIdsRequest(ref AllocateIdsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReserveIdsRequest(ref ReserveIdsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LookupResponse Lookup(LookupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupRequest(ref request, ref callSettings);
            return _callLookup.Sync(request, callSettings);
        }

        /// <summary>
        /// Looks up entities by key.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LookupResponse> LookupAsync(LookupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupRequest(ref request, ref callSettings);
            return _callLookup.Async(request, callSettings);
        }

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunQueryResponse RunQuery(RunQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunQueryRequest(ref request, ref callSettings);
            return _callRunQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Queries for entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunQueryResponse> RunQueryAsync(RunQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunQueryRequest(ref request, ref callSettings);
            return _callRunQuery.Async(request, callSettings);
        }

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BeginTransactionResponse BeginTransaction(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Sync(request, callSettings);
        }

        /// <summary>
        /// Begins a new transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BeginTransactionResponse> BeginTransactionAsync(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Async(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CommitResponse Commit(CommitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Sync(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction, optionally creating, deleting or modifying some
        /// entities.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CommitResponse> CommitAsync(CommitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Async(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RollbackResponse Rollback(RollbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            return _callRollback.Sync(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RollbackResponse> RollbackAsync(RollbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            return _callRollback.Async(request, callSettings);
        }

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AllocateIdsResponse AllocateIds(AllocateIdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AllocateIdsRequest(ref request, ref callSettings);
            return _callAllocateIds.Sync(request, callSettings);
        }

        /// <summary>
        /// Allocates IDs for the given keys, which is useful for referencing an entity
        /// before it is inserted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AllocateIdsResponse> AllocateIdsAsync(AllocateIdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AllocateIdsRequest(ref request, ref callSettings);
            return _callAllocateIds.Async(request, callSettings);
        }

        /// <summary>
        /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
        /// Datastore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReserveIdsResponse ReserveIds(ReserveIdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReserveIdsRequest(ref request, ref callSettings);
            return _callReserveIds.Sync(request, callSettings);
        }

        /// <summary>
        /// Prevents the supplied keys' IDs from being auto-allocated by Cloud
        /// Datastore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReserveIdsResponse> ReserveIdsAsync(ReserveIdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReserveIdsRequest(ref request, ref callSettings);
            return _callReserveIds.Async(request, callSettings);
        }
    }
}
