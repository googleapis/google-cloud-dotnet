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

namespace Google.LongRunning
{
    /// <summary>Settings for <see cref="OperationsClient"/> instances.</summary>
    public sealed partial class OperationsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OperationsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OperationsSettings"/>.</returns>
        public static OperationsSettings GetDefault() => new OperationsSettings();

        /// <summary>Constructs a new <see cref="OperationsSettings"/> object with default settings.</summary>
        public OperationsSettings()
        {
        }

        private OperationsSettings(OperationsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListOperationsSettings = existing.ListOperationsSettings;
            GetOperationSettings = existing.GetOperationSettings;
            DeleteOperationSettings = existing.DeleteOperationSettings;
            CancelOperationSettings = existing.CancelOperationSettings;
            WaitOperationSettings = existing.WaitOperationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OperationsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.ListOperations</c> and <c>OperationsClient.ListOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 500 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOperationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(500), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.GetOperation</c> and <c>OperationsClient.GetOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 500 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOperationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(500), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.DeleteOperation</c> and <c>OperationsClient.DeleteOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 500 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteOperationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(500), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.CancelOperation</c> and <c>OperationsClient.CancelOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 500 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelOperationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(500), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.WaitOperation</c> and <c>OperationsClient.WaitOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WaitOperationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OperationsSettings"/> object.</returns>
        public OperationsSettings Clone() => new OperationsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OperationsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class OperationsClientBuilder : gaxgrpc::ClientBuilderBase<OperationsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OperationsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OperationsClientBuilder() : base(OperationsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OperationsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OperationsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OperationsClient Build()
        {
            OperationsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OperationsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OperationsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OperationsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OperationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OperationsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OperationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OperationsClient.ChannelPool;
    }

    /// <summary>Operations client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages long-running operations with an API service.
    /// 
    /// When an API method normally takes long time to complete, it can be designed
    /// to return [Operation][google.longrunning.Operation] to the client, and the
    /// client can use this interface to receive the real response asynchronously by
    /// polling the operation resource, or pass the operation resource to another API
    /// (such as Pub/Sub API) to receive the response.  Any API service that returns
    /// long-running operations should implement the `Operations` interface so
    /// developers can have a consistent client experience.
    /// </remarks>
    public abstract partial class OperationsClient
    {
        /// <summary>
        /// The default endpoint for the Operations service, which is a host of "longrunning.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "longrunning.googleapis.com:443";

        /// <summary>The default Operations scopes.</summary>
        /// <remarks>The default Operations scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Operations.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OperationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OperationsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OperationsClient"/>.</returns>
        public static stt::Task<OperationsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OperationsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OperationsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="OperationsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OperationsClient"/>.</returns>
        public static OperationsClient Create() => new OperationsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OperationsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OperationsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OperationsClient"/>.</returns>
        internal static OperationsClient Create(grpccore::CallInvoker callInvoker, OperationsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Operations.OperationsClient grpcClient = new Operations.OperationsClient(callInvoker);
            return new OperationsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Operations client</summary>
        public virtual Operations.OperationsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Operation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOperationsResponse, Operation> ListOperations(ListOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Operation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOperationsResponse, Operation> ListOperationsAsync(ListOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation's parent resource.
        /// </param>
        /// <param name="filter">
        /// The standard list filter.
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
        /// <returns>A pageable sequence of <see cref="Operation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOperationsResponse, Operation> ListOperations(string name, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOperationsRequest request = new ListOperationsRequest
            {
                Name = name ?? "",
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOperations(request, callSettings);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation's parent resource.
        /// </param>
        /// <param name="filter">
        /// The standard list filter.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Operation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOperationsResponse, Operation> ListOperationsAsync(string name, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOperationsRequest request = new ListOperationsRequest
            {
                Name = name ?? "",
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOperationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation GetOperation(GetOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetOperationAsync(GetOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetOperationAsync(GetOperationRequest request, st::CancellationToken cancellationToken) =>
            GetOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation GetOperation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOperation(new GetOperationRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetOperationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOperationAsync(new GetOperationRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetOperationAsync(string name, st::CancellationToken cancellationToken) =>
            GetOperationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteOperation(DeleteOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteOperationAsync(DeleteOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteOperationAsync(DeleteOperationRequest request, st::CancellationToken cancellationToken) =>
            DeleteOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteOperation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOperation(new DeleteOperationRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteOperationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOperationAsync(new DeleteOperationRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteOperationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteOperationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// operation completed despite cancellation. On successful cancellation,
        /// the operation is not deleted; instead, it becomes an operation with
        /// an [Operation.error][google.longrunning.Operation.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of `1`, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelOperation(CancelOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// operation completed despite cancellation. On successful cancellation,
        /// the operation is not deleted; instead, it becomes an operation with
        /// an [Operation.error][google.longrunning.Operation.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of `1`, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelOperationAsync(CancelOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// operation completed despite cancellation. On successful cancellation,
        /// the operation is not deleted; instead, it becomes an operation with
        /// an [Operation.error][google.longrunning.Operation.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of `1`, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelOperationAsync(CancelOperationRequest request, st::CancellationToken cancellationToken) =>
            CancelOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// operation completed despite cancellation. On successful cancellation,
        /// the operation is not deleted; instead, it becomes an operation with
        /// an [Operation.error][google.longrunning.Operation.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of `1`, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be cancelled.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelOperation(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelOperation(new CancelOperationRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// operation completed despite cancellation. On successful cancellation,
        /// the operation is not deleted; instead, it becomes an operation with
        /// an [Operation.error][google.longrunning.Operation.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of `1`, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be cancelled.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelOperationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelOperationAsync(new CancelOperationRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// operation completed despite cancellation. On successful cancellation,
        /// the operation is not deleted; instead, it becomes an operation with
        /// an [Operation.error][google.longrunning.Operation.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of `1`, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be cancelled.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelOperationAsync(string name, st::CancellationToken cancellationToken) =>
            CancelOperationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Waits until the specified long-running operation is done or reaches at most
        /// a specified timeout, returning the latest state.  If the operation is
        /// already done, the latest state is immediately returned.  If the timeout
        /// specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
        /// timeout is used.  If the server does not support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// Note that this method is on a best-effort basis.  It may return the latest
        /// state before the specified timeout (including immediately), meaning even an
        /// immediate response is no guarantee that the operation is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation WaitOperation(WaitOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Waits until the specified long-running operation is done or reaches at most
        /// a specified timeout, returning the latest state.  If the operation is
        /// already done, the latest state is immediately returned.  If the timeout
        /// specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
        /// timeout is used.  If the server does not support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// Note that this method is on a best-effort basis.  It may return the latest
        /// state before the specified timeout (including immediately), meaning even an
        /// immediate response is no guarantee that the operation is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> WaitOperationAsync(WaitOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Waits until the specified long-running operation is done or reaches at most
        /// a specified timeout, returning the latest state.  If the operation is
        /// already done, the latest state is immediately returned.  If the timeout
        /// specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
        /// timeout is used.  If the server does not support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// Note that this method is on a best-effort basis.  It may return the latest
        /// state before the specified timeout (including immediately), meaning even an
        /// immediate response is no guarantee that the operation is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> WaitOperationAsync(WaitOperationRequest request, st::CancellationToken cancellationToken) =>
            WaitOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Operations client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages long-running operations with an API service.
    /// 
    /// When an API method normally takes long time to complete, it can be designed
    /// to return [Operation][google.longrunning.Operation] to the client, and the
    /// client can use this interface to receive the real response asynchronously by
    /// polling the operation resource, or pass the operation resource to another API
    /// (such as Pub/Sub API) to receive the response.  Any API service that returns
    /// long-running operations should implement the `Operations` interface so
    /// developers can have a consistent client experience.
    /// </remarks>
    public sealed partial class OperationsClientImpl : OperationsClient
    {
        private readonly gaxgrpc::ApiCall<ListOperationsRequest, ListOperationsResponse> _callListOperations;

        private readonly gaxgrpc::ApiCall<GetOperationRequest, Operation> _callGetOperation;

        private readonly gaxgrpc::ApiCall<DeleteOperationRequest, wkt::Empty> _callDeleteOperation;

        private readonly gaxgrpc::ApiCall<CancelOperationRequest, wkt::Empty> _callCancelOperation;

        private readonly gaxgrpc::ApiCall<WaitOperationRequest, Operation> _callWaitOperation;

        /// <summary>
        /// Constructs a client wrapper for the Operations service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OperationsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OperationsClientImpl(Operations.OperationsClient grpcClient, OperationsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OperationsSettings effectiveSettings = settings ?? OperationsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListOperations = clientHelper.BuildApiCall<ListOperationsRequest, ListOperationsResponse>("ListOperations", grpcClient.ListOperationsAsync, grpcClient.ListOperations, effectiveSettings.ListOperationsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListOperations);
            Modify_ListOperationsApiCall(ref _callListOperations);
            _callGetOperation = clientHelper.BuildApiCall<GetOperationRequest, Operation>("GetOperation", grpcClient.GetOperationAsync, grpcClient.GetOperation, effectiveSettings.GetOperationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOperation);
            Modify_GetOperationApiCall(ref _callGetOperation);
            _callDeleteOperation = clientHelper.BuildApiCall<DeleteOperationRequest, wkt::Empty>("DeleteOperation", grpcClient.DeleteOperationAsync, grpcClient.DeleteOperation, effectiveSettings.DeleteOperationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteOperation);
            Modify_DeleteOperationApiCall(ref _callDeleteOperation);
            _callCancelOperation = clientHelper.BuildApiCall<CancelOperationRequest, wkt::Empty>("CancelOperation", grpcClient.CancelOperationAsync, grpcClient.CancelOperation, effectiveSettings.CancelOperationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelOperation);
            Modify_CancelOperationApiCall(ref _callCancelOperation);
            _callWaitOperation = clientHelper.BuildApiCall<WaitOperationRequest, Operation>("WaitOperation", grpcClient.WaitOperationAsync, grpcClient.WaitOperation, effectiveSettings.WaitOperationSettings);
            Modify_ApiCall(ref _callWaitOperation);
            Modify_WaitOperationApiCall(ref _callWaitOperation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListOperationsApiCall(ref gaxgrpc::ApiCall<ListOperationsRequest, ListOperationsResponse> call);

        partial void Modify_GetOperationApiCall(ref gaxgrpc::ApiCall<GetOperationRequest, Operation> call);

        partial void Modify_DeleteOperationApiCall(ref gaxgrpc::ApiCall<DeleteOperationRequest, wkt::Empty> call);

        partial void Modify_CancelOperationApiCall(ref gaxgrpc::ApiCall<CancelOperationRequest, wkt::Empty> call);

        partial void Modify_WaitOperationApiCall(ref gaxgrpc::ApiCall<WaitOperationRequest, Operation> call);

        partial void OnConstruction(Operations.OperationsClient grpcClient, OperationsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Operations client</summary>
        public override Operations.OperationsClient GrpcClient { get; }

        partial void Modify_ListOperationsRequest(ref ListOperationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOperationRequest(ref GetOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteOperationRequest(ref DeleteOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelOperationRequest(ref CancelOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WaitOperationRequest(ref WaitOperationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Operation"/> resources.</returns>
        public override gax::PagedEnumerable<ListOperationsResponse, Operation> ListOperations(ListOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOperationsRequest, ListOperationsResponse, Operation>(_callListOperations, request, callSettings);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Operation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOperationsResponse, Operation> ListOperationsAsync(ListOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOperationsRequest, ListOperationsResponse, Operation>(_callListOperations, request, callSettings);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation GetOperation(GetOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOperationRequest(ref request, ref callSettings);
            return _callGetOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> GetOperationAsync(GetOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOperationRequest(ref request, ref callSettings);
            return _callGetOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteOperation(DeleteOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOperationRequest(ref request, ref callSettings);
            _callDeleteOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteOperationAsync(DeleteOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOperationRequest(ref request, ref callSettings);
            return _callDeleteOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// operation completed despite cancellation. On successful cancellation,
        /// the operation is not deleted; instead, it becomes an operation with
        /// an [Operation.error][google.longrunning.Operation.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of `1`, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelOperation(CancelOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelOperationRequest(ref request, ref callSettings);
            _callCancelOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// operation completed despite cancellation. On successful cancellation,
        /// the operation is not deleted; instead, it becomes an operation with
        /// an [Operation.error][google.longrunning.Operation.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of `1`, corresponding to
        /// `Code.CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelOperationAsync(CancelOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelOperationRequest(ref request, ref callSettings);
            return _callCancelOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Waits until the specified long-running operation is done or reaches at most
        /// a specified timeout, returning the latest state.  If the operation is
        /// already done, the latest state is immediately returned.  If the timeout
        /// specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
        /// timeout is used.  If the server does not support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// Note that this method is on a best-effort basis.  It may return the latest
        /// state before the specified timeout (including immediately), meaning even an
        /// immediate response is no guarantee that the operation is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation WaitOperation(WaitOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WaitOperationRequest(ref request, ref callSettings);
            return _callWaitOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Waits until the specified long-running operation is done or reaches at most
        /// a specified timeout, returning the latest state.  If the operation is
        /// already done, the latest state is immediately returned.  If the timeout
        /// specified is greater than the default HTTP/RPC timeout, the HTTP/RPC
        /// timeout is used.  If the server does not support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// Note that this method is on a best-effort basis.  It may return the latest
        /// state before the specified timeout (including immediately), meaning even an
        /// immediate response is no guarantee that the operation is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> WaitOperationAsync(WaitOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WaitOperationRequest(ref request, ref callSettings);
            return _callWaitOperation.Async(request, callSettings);
        }
    }

    public partial class ListOperationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOperationsResponse : gaxgrpc::IPageResponse<Operation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Operation> GetEnumerator() => Operations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
