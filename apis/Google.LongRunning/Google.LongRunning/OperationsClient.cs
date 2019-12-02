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
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.LongRunning
{
    /// <summary>
    /// Settings for a <see cref="OperationsClient"/>.
    /// </summary>
    public sealed partial class OperationsSettings : gaxgrpc::ServiceSettingsBase
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
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOperationSettings = existing.GetOperationSettings;
            ListOperationsSettings = existing.ListOperationsSettings;
            CancelOperationSettings = existing.CancelOperationSettings;
            DeleteOperationSettings = existing.DeleteOperationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OperationsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.GetOperation</c> and <c>OperationsClient.GetOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// FIXME: Generate with retries.
        /// </remarks>
        public gaxgrpc::CallSettings GetOperationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.ListOperations</c> and <c>OperationsClient.ListOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// FIXME: Generate with retries.
        /// </remarks>
        public gaxgrpc::CallSettings ListOperationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.CancelOperation</c> and <c>OperationsClient.CancelOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// FIXME: Generate with retries.
        /// </remarks>
        public gaxgrpc::CallSettings CancelOperationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OperationsClient.DeleteOperation</c> and <c>OperationsClient.DeleteOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// FIXME: Generate with retries.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteOperationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="OperationsSettings"/> object.</returns>
        public OperationsSettings Clone() => new OperationsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OperationsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class OperationsClientBuilder : gaxgrpc::ClientBuilderBase<OperationsClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public OperationsSettings Settings { get; set; }

        /// <inheritdoc/>
        public override OperationsClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OperationsClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<OperationsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OperationsClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => OperationsClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => OperationsClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => OperationsClient.ChannelPool;
    }

    /// <summary>
    /// Operations client wrapper, for convenient use.
    /// </summary>
    public abstract partial class OperationsClient
    {
        /// <summary>
        /// The default endpoint for the Operations service, which is a host of "longrunning.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("longrunning.googleapis.com", 443);

        /// <summary>
        /// The default Operations scopes.
        /// </summary>
        /// <remarks>
        /// The default Operations scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="OperationsClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.LongRunning;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// OperationsClient client = await OperationsClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.LongRunning;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     OperationsClient.DefaultEndpoint.Host, OperationsClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// OperationsClient client = OperationsClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="OperationsSettings"/>.</param>
        /// <returns>The task representing the created <see cref="OperationsClient"/>.</returns>
        public static async stt::Task<OperationsClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, OperationsSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="OperationsClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.LongRunning;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// OperationsClient client = OperationsClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.LongRunning;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     OperationsClient.DefaultEndpoint.Host, OperationsClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// OperationsClient client = OperationsClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="OperationsSettings"/>.</param>
        /// <returns>The created <see cref="OperationsClient"/>.</returns>
        public static OperationsClient Create(gaxgrpc::ServiceEndpoint endpoint = null, OperationsSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="OperationsClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="OperationsSettings"/>.</param>
        /// <returns>The created <see cref="OperationsClient"/>.</returns>
        public static OperationsClient Create(grpccore::Channel channel, OperationsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="OperationsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="OperationsSettings"/>.</param>
        /// <returns>The created <see cref="OperationsClient"/>.</returns>
        public static OperationsClient Create(grpccore::CallInvoker callInvoker, OperationsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Operations.OperationsClient grpcClient = new Operations.OperationsClient(callInvoker);
            return new OperationsClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, OperationsSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, OperationsSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, OperationsSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, OperationsSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Operations client.
        /// </summary>
        public virtual Operations.OperationsClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
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
        public virtual stt::Task<Operation> GetOperationAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetOperationAsync(
                new GetOperationRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Operation> GetOperationAsync(
            string name,
            st::CancellationToken cancellationToken) => GetOperationAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => GetOperation(
                new GetOperationRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        public virtual stt::Task<Operation> GetOperationAsync(
            GetOperationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use this
        /// method to poll the operation result at intervals as recommended by the API
        /// service.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Operation> GetOperationAsync(
            GetOperationRequest request,
            st::CancellationToken cancellationToken) => GetOperationAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`. To
        /// override the binding, API services can add a binding such as
        /// `"/v1/{name=users/*}/operations"` to their service configuration.
        /// For backwards compatibility, the default name includes the operations
        /// collection id, however overriding users must ensure the name binding
        /// is the parent resource, without the operations collection id.
        /// </summary>
        /// <param name="name">
        /// The name of the operation's parent resource.
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
        public virtual gax::PagedAsyncEnumerable<ListOperationsResponse, Operation> ListOperationsAsync(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOperationsAsync(
                new ListOperationsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`. To
        /// override the binding, API services can add a binding such as
        /// `"/v1/{name=users/*}/operations"` to their service configuration.
        /// For backwards compatibility, the default name includes the operations
        /// collection id, however overriding users must ensure the name binding
        /// is the parent resource, without the operations collection id.
        /// </summary>
        /// <param name="name">
        /// The name of the operation's parent resource.
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
        public virtual gax::PagedEnumerable<ListOperationsResponse, Operation> ListOperations(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListOperations(
                new ListOperationsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`. To
        /// override the binding, API services can add a binding such as
        /// `"/v1/{name=users/*}/operations"` to their service configuration.
        /// For backwards compatibility, the default name includes the operations
        /// collection id, however overriding users must ensure the name binding
        /// is the parent resource, without the operations collection id.
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
        public virtual gax::PagedAsyncEnumerable<ListOperationsResponse, Operation> ListOperationsAsync(
            ListOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`. To
        /// override the binding, API services can add a binding such as
        /// `"/v1/{name=users/*}/operations"` to their service configuration.
        /// For backwards compatibility, the default name includes the operations
        /// collection id, however overriding users must ensure the name binding
        /// is the parent resource, without the operations collection id.
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
        public virtual gax::PagedEnumerable<ListOperationsResponse, Operation> ListOperations(
            ListOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task CancelOperationAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => CancelOperationAsync(
                new CancelOperationRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task CancelOperationAsync(
            string name,
            st::CancellationToken cancellationToken) => CancelOperationAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void CancelOperation(
            string name,
            gaxgrpc::CallSettings callSettings = null) => CancelOperation(
                new CancelOperationRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task CancelOperationAsync(
            CancelOperationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task CancelOperationAsync(
            CancelOperationRequest request,
            st::CancellationToken cancellationToken) => CancelOperationAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void CancelOperation(
            CancelOperationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOperationAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOperationAsync(
                new DeleteOperationRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOperationAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteOperationAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void DeleteOperation(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteOperation(
                new DeleteOperationRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOperationAsync(
            DeleteOperationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteOperationAsync(
            DeleteOperationRequest request,
            st::CancellationToken cancellationToken) => DeleteOperationAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void DeleteOperation(
            DeleteOperationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// Operations client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class OperationsClientImpl : OperationsClient
    {
        private readonly gaxgrpc::ApiCall<GetOperationRequest, Operation> _callGetOperation;
        private readonly gaxgrpc::ApiCall<ListOperationsRequest, ListOperationsResponse> _callListOperations;
        private readonly gaxgrpc::ApiCall<CancelOperationRequest, pbwkt::Empty> _callCancelOperation;
        private readonly gaxgrpc::ApiCall<DeleteOperationRequest, pbwkt::Empty> _callDeleteOperation;

        /// <summary>
        /// Constructs a client wrapper for the Operations service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OperationsSettings"/> used within this client </param>
        public OperationsClientImpl(Operations.OperationsClient grpcClient, OperationsSettings settings)
        {
            GrpcClient = grpcClient;
            OperationsSettings effectiveSettings = settings ?? OperationsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetOperation = clientHelper.BuildApiCall<GetOperationRequest, Operation>(
                GrpcClient.GetOperationAsync, GrpcClient.GetOperation, effectiveSettings.GetOperationSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListOperations = clientHelper.BuildApiCall<ListOperationsRequest, ListOperationsResponse>(
                GrpcClient.ListOperationsAsync, GrpcClient.ListOperations, effectiveSettings.ListOperationsSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCancelOperation = clientHelper.BuildApiCall<CancelOperationRequest, pbwkt::Empty>(
                GrpcClient.CancelOperationAsync, GrpcClient.CancelOperation, effectiveSettings.CancelOperationSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDeleteOperation = clientHelper.BuildApiCall<DeleteOperationRequest, pbwkt::Empty>(
                GrpcClient.DeleteOperationAsync, GrpcClient.DeleteOperation, effectiveSettings.DeleteOperationSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOperation);
            Modify_GetOperationApiCall(ref _callGetOperation);
            Modify_ApiCall(ref _callListOperations);
            Modify_ListOperationsApiCall(ref _callListOperations);
            Modify_ApiCall(ref _callCancelOperation);
            Modify_CancelOperationApiCall(ref _callCancelOperation);
            Modify_ApiCall(ref _callDeleteOperation);
            Modify_DeleteOperationApiCall(ref _callDeleteOperation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_GetOperationApiCall(ref gaxgrpc::ApiCall<GetOperationRequest, Operation> call);
        partial void Modify_ListOperationsApiCall(ref gaxgrpc::ApiCall<ListOperationsRequest, ListOperationsResponse> call);
        partial void Modify_CancelOperationApiCall(ref gaxgrpc::ApiCall<CancelOperationRequest, pbwkt::Empty> call);
        partial void Modify_DeleteOperationApiCall(ref gaxgrpc::ApiCall<DeleteOperationRequest, pbwkt::Empty> call);
        partial void OnConstruction(Operations.OperationsClient grpcClient, OperationsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Operations client.
        /// </summary>
        public override Operations.OperationsClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetOperationRequest(ref GetOperationRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListOperationsRequest(ref ListOperationsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CancelOperationRequest(ref CancelOperationRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteOperationRequest(ref DeleteOperationRequest request, ref gaxgrpc::CallSettings settings);

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
        public override stt::Task<Operation> GetOperationAsync(
            GetOperationRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOperationRequest(ref request, ref callSettings);
            return _callGetOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`. To
        /// override the binding, API services can add a binding such as
        /// `"/v1/{name=users/*}/operations"` to their service configuration.
        /// For backwards compatibility, the default name includes the operations
        /// collection id, however overriding users must ensure the name binding
        /// is the parent resource, without the operations collection id.
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
        public override gax::PagedAsyncEnumerable<ListOperationsResponse, Operation> ListOperationsAsync(
            ListOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOperationsRequest, ListOperationsResponse, Operation>(_callListOperations, request, callSettings);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the
        /// server doesn't support this method, it returns `UNIMPLEMENTED`.
        ///
        /// NOTE: the `name` binding allows API services to override the binding
        /// to use different resource name schemes, such as `users/*/operations`. To
        /// override the binding, API services can add a binding such as
        /// `"/v1/{name=users/*}/operations"` to their service configuration.
        /// For backwards compatibility, the default name includes the operations
        /// collection id, however overriding users must ensure the name binding
        /// is the parent resource, without the operations collection id.
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
        public override gax::PagedEnumerable<ListOperationsResponse, Operation> ListOperations(
            ListOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOperationsRequest, ListOperationsResponse, Operation>(_callListOperations, request, callSettings);
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task CancelOperationAsync(
            CancelOperationRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override void CancelOperation(
            CancelOperationRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteOperationAsync(
            DeleteOperationRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override void DeleteOperation(
            DeleteOperationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOperationRequest(ref request, ref callSettings);
            _callDeleteOperation.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListOperationsRequest : gaxgrpc::IPageRequest { }
    public partial class ListOperationsResponse : gaxgrpc::IPageResponse<Operation>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Operation> GetEnumerator() => Operations.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
