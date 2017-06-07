// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.LongRunning
{
    /// <summary>
    /// Settings for a <see cref="OperationsClient"/>.
    /// </summary>
    public sealed partial class OperationsSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="OperationsSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="OperationsSettings"/>.
        /// </returns>
        public static OperationsSettings GetDefault() => new OperationsSettings();

        /// <summary>
        /// Constructs a new <see cref="OperationsSettings"/> object with default settings.
        /// </summary>
        public OperationsSettings() { }

        private OperationsSettings(OperationsSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOperationSettings = existing.GetOperationSettings;
            ListOperationsSettings = existing.ListOperationsSettings;
            CancelOperationSettings = existing.CancelOperationSettings;
            DeleteOperationSettings = existing.DeleteOperationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OperationsSettings existing);

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
        /// <returns>
        /// The "Default" retry backoff for <see cref="OperationsClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="OperationsClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="OperationsClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="OperationsClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="OperationsClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 90000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 90000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(90000),
            maxDelay: TimeSpan.FromMilliseconds(90000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.GetOperation</c> and <c>OperationsClient.GetOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>OperationsClient.GetOperation</c> and
        /// <c>OperationsClient.GetOperationAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 90000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 90000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetOperationSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.ListOperations</c> and <c>OperationsClient.ListOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>OperationsClient.ListOperations</c> and
        /// <c>OperationsClient.ListOperationsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 90000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 90000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListOperationsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.CancelOperation</c> and <c>OperationsClient.CancelOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>OperationsClient.CancelOperation</c> and
        /// <c>OperationsClient.CancelOperationAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 90000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 90000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CancelOperationSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.DeleteOperation</c> and <c>OperationsClient.DeleteOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>OperationsClient.DeleteOperation</c> and
        /// <c>OperationsClient.DeleteOperationAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 90000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 90000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteOperationSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="OperationsSettings"/> object.</returns>
        public OperationsSettings Clone() => new OperationsSettings(this);
    }

    /// <summary>
    /// Operations client wrapper, for convenient use.
    /// </summary>
    public abstract partial class OperationsClient
    {
        /// <summary>
        /// The default endpoint for the Operations service, which is a host of "longrunning.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("longrunning.googleapis.com", 443);

        /// <summary>
        /// The default Operations scopes.
        /// </summary>
        /// <remarks>
        /// The default Operations scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

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
        public static async Task<OperationsClient> CreateAsync(ServiceEndpoint endpoint = null, OperationsSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
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
        public static OperationsClient Create(ServiceEndpoint endpoint = null, OperationsSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
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
        /// The underlying gRPC Operations client.
        /// </summary>
        public virtual Operations.OperationsClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> GetOperationAsync(
            string name,
            CallSettings callSettings = null) => GetOperationAsync(
                new GetOperationRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> GetOperationAsync(
            string name,
            CancellationToken cancellationToken) => GetOperationAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation GetOperation(
            string name,
            CallSettings callSettings = null) => GetOperation(
                new GetOperationRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> GetOperationAsync(
            GetOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation GetOperation(
            GetOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding below allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation collection.
        /// </param>
        /// <param name="filter">
        /// The standard list filter.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Operation"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListOperationsResponse, Operation> ListOperationsAsync(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListOperationsAsync(
                new ListOperationsRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Filter = GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding below allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation collection.
        /// </param>
        /// <param name="filter">
        /// The standard list filter.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Operation"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListOperationsResponse, Operation> ListOperations(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListOperations(
                new ListOperationsRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Filter = GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding below allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Operation"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListOperationsResponse, Operation> ListOperationsAsync(
            ListOperationsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding below allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Operation"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListOperationsResponse, Operation> ListOperations(
            ListOperationsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        /// an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be cancelled.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task CancelOperationAsync(
            string name,
            CallSettings callSettings = null) => CancelOperationAsync(
                new CancelOperationRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// operation completed despite cancellation. On successful cancellation,
        /// the operation is not deleted; instead, it becomes an operation with
        /// an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be cancelled.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task CancelOperationAsync(
            string name,
            CancellationToken cancellationToken) => CancelOperationAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// operation completed despite cancellation. On successful cancellation,
        /// the operation is not deleted; instead, it becomes an operation with
        /// an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be cancelled.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void CancelOperation(
            string name,
            CallSettings callSettings = null) => CancelOperation(
                new CancelOperationRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation.  The server
        /// makes a best effort to cancel the operation, but success is not
        /// guaranteed.  If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.  Clients can use
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// operation completed despite cancellation. On successful cancellation,
        /// the operation is not deleted; instead, it becomes an operation with
        /// an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task CancelOperationAsync(
            CancelOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        /// an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void CancelOperation(
            CancelOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be deleted.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteOperationAsync(
            string name,
            CallSettings callSettings = null) => DeleteOperationAsync(
                new DeleteOperationRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be deleted.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteOperationAsync(
            string name,
            CancellationToken cancellationToken) => DeleteOperationAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">
        /// The name of the operation resource to be deleted.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteOperation(
            string name,
            CallSettings callSettings = null) => DeleteOperation(
                new DeleteOperationRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteOperationAsync(
            DeleteOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteOperation(
            DeleteOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// Operations client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class OperationsClientImpl : OperationsClient
    {
        private readonly ApiCall<GetOperationRequest, Operation> _callGetOperation;
        private readonly ApiCall<ListOperationsRequest, ListOperationsResponse> _callListOperations;
        private readonly ApiCall<CancelOperationRequest, Empty> _callCancelOperation;
        private readonly ApiCall<DeleteOperationRequest, Empty> _callDeleteOperation;

        /// <summary>
        /// Constructs a client wrapper for the Operations service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OperationsSettings"/> used within this client </param>
        public OperationsClientImpl(Operations.OperationsClient grpcClient, OperationsSettings settings)
        {
            this.GrpcClient = grpcClient;
            OperationsSettings effectiveSettings = settings ?? OperationsSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callGetOperation = clientHelper.BuildApiCall<GetOperationRequest, Operation>(
                GrpcClient.GetOperationAsync, GrpcClient.GetOperation, effectiveSettings.GetOperationSettings);
            _callListOperations = clientHelper.BuildApiCall<ListOperationsRequest, ListOperationsResponse>(
                GrpcClient.ListOperationsAsync, GrpcClient.ListOperations, effectiveSettings.ListOperationsSettings);
            _callCancelOperation = clientHelper.BuildApiCall<CancelOperationRequest, Empty>(
                GrpcClient.CancelOperationAsync, GrpcClient.CancelOperation, effectiveSettings.CancelOperationSettings);
            _callDeleteOperation = clientHelper.BuildApiCall<DeleteOperationRequest, Empty>(
                GrpcClient.DeleteOperationAsync, GrpcClient.DeleteOperation, effectiveSettings.DeleteOperationSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(Operations.OperationsClient grpcClient, OperationsSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Operations client.
        /// </summary>
        public override Operations.OperationsClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_GetOperationRequest(ref GetOperationRequest request, ref CallSettings settings);
        partial void Modify_ListOperationsRequest(ref ListOperationsRequest request, ref CallSettings settings);
        partial void Modify_CancelOperationRequest(ref CancelOperationRequest request, ref CallSettings settings);
        partial void Modify_DeleteOperationRequest(ref DeleteOperationRequest request, ref CallSettings settings);

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Operation> GetOperationAsync(
            GetOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetOperationRequest(ref request, ref callSettings);
            return _callGetOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Operation GetOperation(
            GetOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetOperationRequest(ref request, ref callSettings);
            return _callGetOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding below allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Operation"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListOperationsResponse, Operation> ListOperationsAsync(
            ListOperationsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListOperationsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListOperationsRequest, ListOperationsResponse, Operation>(_callListOperations, request, callSettings);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding below allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Operation"/> resources.
        /// </returns>
        public override PagedEnumerable<ListOperationsResponse, Operation> ListOperations(
            ListOperationsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListOperationsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListOperationsRequest, ListOperationsResponse, Operation>(_callListOperations, request, callSettings);
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
        /// an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task CancelOperationAsync(
            CancelOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_CancelOperationRequest(ref request, ref callSettings);
            return _callCancelOperation.Async(request, callSettings);
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
        /// an [Operation.error][google.longrunning.Operation.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void CancelOperation(
            CancelOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_CancelOperationRequest(ref request, ref callSettings);
            _callCancelOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task DeleteOperationAsync(
            DeleteOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteOperationRequest(ref request, ref callSettings);
            return _callDeleteOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is
        /// no longer interested in the operation result. It does not cancel the
        /// operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void DeleteOperation(
            DeleteOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteOperationRequest(ref request, ref callSettings);
            _callDeleteOperation.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListOperationsRequest : IPageRequest { }
    public partial class ListOperationsResponse : IPageResponse<Operation>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Operation> GetEnumerator() => Operations.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
