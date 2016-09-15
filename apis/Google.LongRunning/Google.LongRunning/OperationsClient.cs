// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Longrunning
{
    /// <summary>
    /// Settings for a Operations wrapper.
    /// </summary>
    public sealed partial class OperationsSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="OperationsSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default OperationsSettings.</returns>
        public static OperationsSettings GetDefault() => new OperationsSettings();

        /// <summary>
        /// Constructs a new OperationsSettings object with default settings.
        /// </summary>
        public OperationsSettings() { }

        private OperationsSettings(OperationsSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOperationSettings = existing.GetOperationSettings?.Clone();
            ListOperationsSettings = existing.ListOperationsSettings?.Clone();
            CancelOperationSettings = existing.CancelOperationSettings?.Clone();
            DeleteOperationSettings = existing.DeleteOperationSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="OperationsClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="OperationsClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="OperationsClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="OperationsClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="OperationsClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.3,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="OperationsClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="OperationsClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="OperationsClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(20000),
            DelayMultiplier = 1.0,
            MaxDelay = TimeSpan.FromMilliseconds(20000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="OperationsClient.GetOperation"/> and <see cref="OperationsClient.GetOperationAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="OperationsClient.GetOperation"/> and
        /// <see cref="OperationsClient.GetOperationAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetOperationSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="OperationsClient.ListOperations"/> and <see cref="OperationsClient.ListOperationsAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="OperationsClient.ListOperations"/> and
        /// <see cref="OperationsClient.ListOperationsAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListOperationsSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="OperationsClient.CancelOperation"/> and <see cref="OperationsClient.CancelOperationAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="OperationsClient.CancelOperation"/> and
        /// <see cref="OperationsClient.CancelOperationAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CancelOperationSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="OperationsClient.DeleteOperation"/> and <see cref="OperationsClient.DeleteOperationAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="OperationsClient.DeleteOperation"/> and
        /// <see cref="OperationsClient.DeleteOperationAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteOperationSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of Operations settings.</returns>
        public OperationsSettings Clone() => new OperationsSettings(this);
    }

    /// <summary>
    /// Operations client wrapper, for convenient use.
    /// </summary>
    public abstract partial class OperationsClient
    {
        /// <summary>
        /// The default Operations scopes
        /// </summary>
        /// <remarks>
        /// The default Operations scopes are:
        /// <list type="bullet">
        /// <item><description>""</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        /// <summary>
        /// Path template for a operationPath resource. Parameters:
        /// <list type="bullet">
        /// <item><description>operation_path</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate OperationPathTemplate { get; } = new PathTemplate("operations/{operation_path=**}");

        /// <summary>
        /// Creates a operationPath resource name from its component IDs.
        /// </summary>
        /// <param name="operation_pathId">The operation_path ID.</param>
        /// <returns>The full operationPath resource name.</returns>
        public static string FormatOperationPathName(string operation_pathId) => OperationPathTemplate.Expand(operation_pathId);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="OperationsClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="OperationsSettings"/>.</param>
        /// <returns>The task representing the created <see cref="OperationsClient"/>.</returns>
        public static async Task<OperationsClient> CreateAsync(ServiceEndpoint endpoint, OperationsSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="OperationsClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="OperationsSettings"/>.</param>
        /// <returns>The created <see cref="OperationsClient"/>.</returns>
        public static OperationsClient Create(ServiceEndpoint endpoint, OperationsSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="OperationsClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="OperationsSettings"/>.</param>
        /// <returns>The created <see cref="OperationsClient"/>.</returns>
        public static OperationsClient Create(Channel channel, OperationsSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Operations.OperationsClient grpcClient = new Operations.OperationsClient(channel);
            return new OperationsClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, OperationsSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, OperationsSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, OperationsSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, OperationsSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying GRPC Operations client.
        /// </summary>
        public virtual Operations.OperationsClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients may use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Operation> GetOperationAsync(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients may use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Operation> GetOperationAsync(
            string name,
            CancellationToken cancellationToken) => GetOperationAsync(
                name,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients may use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation GetOperation(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation collection.</param>
        /// <param name="filter">The standard List filter.</param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of Operation resources.</returns>
        public virtual IPagedAsyncEnumerable<ListOperationsResponse, Operation> ListOperationsAsync(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation collection.</param>
        /// <param name="filter">The standard List filter.</param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of Operation resources.</returns>
        public virtual IPagedEnumerable<ListOperationsResponse, Operation> ListOperations(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients may use
        /// [Operations.GetOperation] or other methods to check whether the
        /// cancellation succeeded or the operation completed despite cancellation.
        /// </summary>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task CancelOperationAsync(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients may use
        /// [Operations.GetOperation] or other methods to check whether the
        /// cancellation succeeded or the operation completed despite cancellation.
        /// </summary>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task CancelOperationAsync(
            string name,
            CancellationToken cancellationToken) => CancelOperationAsync(
                name,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients may use
        /// [Operations.GetOperation] or other methods to check whether the
        /// cancellation succeeded or the operation completed despite cancellation.
        /// </summary>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelOperation(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a long-running operation.  It indicates the client is no longer
        /// interested in the operation result. It does not cancel the operation.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteOperationAsync(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a long-running operation.  It indicates the client is no longer
        /// interested in the operation result. It does not cancel the operation.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteOperationAsync(
            string name,
            CancellationToken cancellationToken) => DeleteOperationAsync(
                name,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Deletes a long-running operation.  It indicates the client is no longer
        /// interested in the operation result. It does not cancel the operation.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteOperation(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class OperationsClientImpl : OperationsClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<GetOperationRequest, Operation> _callGetOperation;
        private readonly ApiCall<ListOperationsRequest, ListOperationsResponse> _callListOperations;
        private readonly ApiCall<CancelOperationRequest, Empty> _callCancelOperation;
        private readonly ApiCall<DeleteOperationRequest, Empty> _callDeleteOperation;

        public OperationsClientImpl(Operations.OperationsClient grpcClient, OperationsSettings settings)
        {
            this.GrpcClient = grpcClient;
            OperationsSettings effectiveSettings = settings ?? OperationsSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callGetOperation = _clientHelper.BuildApiCall<GetOperationRequest, Operation>(
                GrpcClient.GetOperationAsync, GrpcClient.GetOperation, effectiveSettings.GetOperationSettings);
            _callListOperations = _clientHelper.BuildApiCall<ListOperationsRequest, ListOperationsResponse>(
                GrpcClient.ListOperationsAsync, GrpcClient.ListOperations, effectiveSettings.ListOperationsSettings);
            _callCancelOperation = _clientHelper.BuildApiCall<CancelOperationRequest, Empty>(
                GrpcClient.CancelOperationAsync, GrpcClient.CancelOperation, effectiveSettings.CancelOperationSettings);
            _callDeleteOperation = _clientHelper.BuildApiCall<DeleteOperationRequest, Empty>(
                GrpcClient.DeleteOperationAsync, GrpcClient.DeleteOperation, effectiveSettings.DeleteOperationSettings);
        }

        public override Operations.OperationsClient GrpcClient { get; }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients may use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Operation> GetOperationAsync(
            string name,
            CallSettings callSettings = null) => _callGetOperation.Async(
                new GetOperationRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients may use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation GetOperation(
            string name,
            CallSettings callSettings = null) => _callGetOperation.Sync(
                new GetOperationRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation collection.</param>
        /// <param name="filter">The standard List filter.</param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of Operation resources.</returns>
        public override IPagedAsyncEnumerable<ListOperationsResponse, Operation> ListOperationsAsync(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedAsyncEnumerable<ListOperationsRequest, ListOperationsResponse, Operation>(
                _callListOperations,
                new ListOperationsRequest
                {
                    Name = name,
                    Filter = filter,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation collection.</param>
        /// <param name="filter">The standard List filter.</param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of Operation resources.</returns>
        public override IPagedEnumerable<ListOperationsResponse, Operation> ListOperations(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedEnumerable<ListOperationsRequest, ListOperationsResponse, Operation>(
                _callListOperations,
                new ListOperationsRequest
                {
                    Name = name,
                    Filter = filter,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients may use
        /// [Operations.GetOperation] or other methods to check whether the
        /// cancellation succeeded or the operation completed despite cancellation.
        /// </summary>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task CancelOperationAsync(
            string name,
            CallSettings callSettings = null) => _callCancelOperation.Async(
                new CancelOperationRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients may use
        /// [Operations.GetOperation] or other methods to check whether the
        /// cancellation succeeded or the operation completed despite cancellation.
        /// </summary>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelOperation(
            string name,
            CallSettings callSettings = null) => _callCancelOperation.Sync(
                new CancelOperationRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        /// Deletes a long-running operation.  It indicates the client is no longer
        /// interested in the operation result. It does not cancel the operation.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task DeleteOperationAsync(
            string name,
            CallSettings callSettings = null) => _callDeleteOperation.Async(
                new DeleteOperationRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        /// Deletes a long-running operation.  It indicates the client is no longer
        /// interested in the operation result. It does not cancel the operation.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteOperation(
            string name,
            CallSettings callSettings = null) => _callDeleteOperation.Sync(
                new DeleteOperationRequest
                {
                    Name = name,
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

    public partial class ListOperationsRequest : IPageRequest { }
    public partial class ListOperationsResponse : IPageResponse<Operation>
    {
        public IEnumerator<Operation> GetEnumerator() => Operations.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}