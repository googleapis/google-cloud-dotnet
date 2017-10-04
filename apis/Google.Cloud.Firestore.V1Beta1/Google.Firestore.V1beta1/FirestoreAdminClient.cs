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
using Google.Cloud.Firestore.Admin.V1Beta1;
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Firestore.V1beta1
{
    /// <summary>
    /// Settings for a <see cref="FirestoreAdminClient"/>.
    /// </summary>
    public sealed partial class FirestoreAdminSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="FirestoreAdminSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="FirestoreAdminSettings"/>.
        /// </returns>
        public static FirestoreAdminSettings GetDefault() => new FirestoreAdminSettings();

        /// <summary>
        /// Constructs a new <see cref="FirestoreAdminSettings"/> object with default settings.
        /// </summary>
        public FirestoreAdminSettings() { }

        private FirestoreAdminSettings(FirestoreAdminSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateIndexSettings = existing.CreateIndexSettings;
            ListIndexesSettings = existing.ListIndexesSettings;
            GetIndexSettings = existing.GetIndexSettings;
            DeleteIndexSettings = existing.DeleteIndexSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FirestoreAdminSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="FirestoreAdminClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="FirestoreAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="FirestoreAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="FirestoreAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="FirestoreAdminClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="FirestoreAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="FirestoreAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="FirestoreAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.CreateIndex</c> and <c>FirestoreAdminClient.CreateIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.CreateIndex</c> and
        /// <c>FirestoreAdminClient.CreateIndexAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateIndexSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.ListIndexes</c> and <c>FirestoreAdminClient.ListIndexesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.ListIndexes</c> and
        /// <c>FirestoreAdminClient.ListIndexesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListIndexesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.GetIndex</c> and <c>FirestoreAdminClient.GetIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.GetIndex</c> and
        /// <c>FirestoreAdminClient.GetIndexAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetIndexSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.DeleteIndex</c> and <c>FirestoreAdminClient.DeleteIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.DeleteIndex</c> and
        /// <c>FirestoreAdminClient.DeleteIndexAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteIndexSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="FirestoreAdminSettings"/> object.</returns>
        public FirestoreAdminSettings Clone() => new FirestoreAdminSettings(this);
    }

    /// <summary>
    /// FirestoreAdmin client wrapper, for convenient use.
    /// </summary>
    public abstract partial class FirestoreAdminClient
    {
        /// <summary>
        /// The default endpoint for the FirestoreAdmin service, which is a host of "firestore.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("firestore.googleapis.com", 443);

        /// <summary>
        /// The default FirestoreAdmin scopes.
        /// </summary>
        /// <remarks>
        /// The default FirestoreAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/datastore"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/datastore",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="FirestoreAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FirestoreAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="FirestoreAdminClient"/>.</returns>
        public static async Task<FirestoreAdminClient> CreateAsync(ServiceEndpoint endpoint = null, FirestoreAdminSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="FirestoreAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FirestoreAdminSettings"/>.</param>
        /// <returns>The created <see cref="FirestoreAdminClient"/>.</returns>
        public static FirestoreAdminClient Create(ServiceEndpoint endpoint = null, FirestoreAdminSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="FirestoreAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="FirestoreAdminSettings"/>.</param>
        /// <returns>The created <see cref="FirestoreAdminClient"/>.</returns>
        public static FirestoreAdminClient Create(Channel channel, FirestoreAdminSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            FirestoreAdmin.FirestoreAdminClient grpcClient = new FirestoreAdmin.FirestoreAdminClient(channel);
            return new FirestoreAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, FirestoreAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, FirestoreAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, FirestoreAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, FirestoreAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC FirestoreAdmin client.
        /// </summary>
        public virtual FirestoreAdmin.FirestoreAdminClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the state will be `READY`.
        /// If the index already exists, the call will return an `ALREADY_EXISTS`
        /// status.
        ///
        /// During creation, the process could result in an error, in which case the
        /// index will move to the `ERROR` state. The process can be recovered by
        /// fixing the data that caused the error, removing the index with
        /// [delete][google.firestore.admin.v1beta1.FirestoreAdmin.DeleteIndex], then re-creating the index with
        /// [create][google.firestore.admin.v1beta1.FirestoreAdmin.CreateIndex].
        ///
        /// Indexes with a single field cannot be created.
        /// </summary>
        /// <param name="parent">
        /// The name of the database this index will apply to. For example:
        /// `projects/{project_id}/databases/{database_id}`
        /// </param>
        /// <param name="index">
        /// The index to create. The name and state should not be specified.
        /// Certain single field indexes cannot be created or deleted.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> CreateIndexAsync(
            string parent,
            Index index,
            CallSettings callSettings = null) => CreateIndexAsync(
                new CreateIndexRequest
                {
                    Parent = GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Index = GaxPreconditions.CheckNotNull(index, nameof(index)),
                },
                callSettings);

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the state will be `READY`.
        /// If the index already exists, the call will return an `ALREADY_EXISTS`
        /// status.
        ///
        /// During creation, the process could result in an error, in which case the
        /// index will move to the `ERROR` state. The process can be recovered by
        /// fixing the data that caused the error, removing the index with
        /// [delete][google.firestore.admin.v1beta1.FirestoreAdmin.DeleteIndex], then re-creating the index with
        /// [create][google.firestore.admin.v1beta1.FirestoreAdmin.CreateIndex].
        ///
        /// Indexes with a single field cannot be created.
        /// </summary>
        /// <param name="parent">
        /// The name of the database this index will apply to. For example:
        /// `projects/{project_id}/databases/{database_id}`
        /// </param>
        /// <param name="index">
        /// The index to create. The name and state should not be specified.
        /// Certain single field indexes cannot be created or deleted.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> CreateIndexAsync(
            string parent,
            Index index,
            CancellationToken cancellationToken) => CreateIndexAsync(
                parent,
                index,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the state will be `READY`.
        /// If the index already exists, the call will return an `ALREADY_EXISTS`
        /// status.
        ///
        /// During creation, the process could result in an error, in which case the
        /// index will move to the `ERROR` state. The process can be recovered by
        /// fixing the data that caused the error, removing the index with
        /// [delete][google.firestore.admin.v1beta1.FirestoreAdmin.DeleteIndex], then re-creating the index with
        /// [create][google.firestore.admin.v1beta1.FirestoreAdmin.CreateIndex].
        ///
        /// Indexes with a single field cannot be created.
        /// </summary>
        /// <param name="parent">
        /// The name of the database this index will apply to. For example:
        /// `projects/{project_id}/databases/{database_id}`
        /// </param>
        /// <param name="index">
        /// The index to create. The name and state should not be specified.
        /// Certain single field indexes cannot be created or deleted.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation CreateIndex(
            string parent,
            Index index,
            CallSettings callSettings = null) => CreateIndex(
                new CreateIndexRequest
                {
                    Parent = GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Index = GaxPreconditions.CheckNotNull(index, nameof(index)),
                },
                callSettings);

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the state will be `READY`.
        /// If the index already exists, the call will return an `ALREADY_EXISTS`
        /// status.
        ///
        /// During creation, the process could result in an error, in which case the
        /// index will move to the `ERROR` state. The process can be recovered by
        /// fixing the data that caused the error, removing the index with
        /// [delete][google.firestore.admin.v1beta1.FirestoreAdmin.DeleteIndex], then re-creating the index with
        /// [create][google.firestore.admin.v1beta1.FirestoreAdmin.CreateIndex].
        ///
        /// Indexes with a single field cannot be created.
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
        public virtual Task<Operation> CreateIndexAsync(
            CreateIndexRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the state will be `READY`.
        /// If the index already exists, the call will return an `ALREADY_EXISTS`
        /// status.
        ///
        /// During creation, the process could result in an error, in which case the
        /// index will move to the `ERROR` state. The process can be recovered by
        /// fixing the data that caused the error, removing the index with
        /// [delete][google.firestore.admin.v1beta1.FirestoreAdmin.DeleteIndex], then re-creating the index with
        /// [create][google.firestore.admin.v1beta1.FirestoreAdmin.CreateIndex].
        ///
        /// Indexes with a single field cannot be created.
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
        public virtual Operation CreateIndex(
            CreateIndexRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the indexes that match the specified filters.
        /// </summary>
        /// <param name="parent">
        /// The database name. For example:
        /// `projects/{project_id}/databases/{database_id}`
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
        /// A pageable asynchronous sequence of <see cref="Index"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListIndexesAsync(
                new ListIndexesRequest
                {
                    Parent = GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the indexes that match the specified filters.
        /// </summary>
        /// <param name="parent">
        /// The database name. For example:
        /// `projects/{project_id}/databases/{database_id}`
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
        /// A pageable sequence of <see cref="Index"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListIndexesResponse, Index> ListIndexes(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListIndexes(
                new ListIndexesRequest
                {
                    Parent = GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the indexes that match the specified filters.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Index"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(
            ListIndexesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the indexes that match the specified filters.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Index"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListIndexesResponse, Index> ListIndexes(
            ListIndexesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets an index.
        /// </summary>
        /// <param name="name">
        /// The name of the index. For example:
        /// `projects/{project_id}/databases/{database_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Index> GetIndexAsync(
            string name,
            CallSettings callSettings = null) => GetIndexAsync(
                new GetIndexRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets an index.
        /// </summary>
        /// <param name="name">
        /// The name of the index. For example:
        /// `projects/{project_id}/databases/{database_id}/indexes/{index_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Index> GetIndexAsync(
            string name,
            CancellationToken cancellationToken) => GetIndexAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an index.
        /// </summary>
        /// <param name="name">
        /// The name of the index. For example:
        /// `projects/{project_id}/databases/{database_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Index GetIndex(
            string name,
            CallSettings callSettings = null) => GetIndex(
                new GetIndexRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets an index.
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
        public virtual Task<Index> GetIndexAsync(
            GetIndexRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets an index.
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
        public virtual Index GetIndex(
            GetIndexRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an index.
        /// </summary>
        /// <param name="name">
        /// The index name. For example:
        /// `projects/{project_id}/databases/{database_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteIndexAsync(
            string name,
            CallSettings callSettings = null) => DeleteIndexAsync(
                new DeleteIndexRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an index.
        /// </summary>
        /// <param name="name">
        /// The index name. For example:
        /// `projects/{project_id}/databases/{database_id}/indexes/{index_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteIndexAsync(
            string name,
            CancellationToken cancellationToken) => DeleteIndexAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an index.
        /// </summary>
        /// <param name="name">
        /// The index name. For example:
        /// `projects/{project_id}/databases/{database_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteIndex(
            string name,
            CallSettings callSettings = null) => DeleteIndex(
                new DeleteIndexRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an index.
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
        public virtual Task DeleteIndexAsync(
            DeleteIndexRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an index.
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
        public virtual void DeleteIndex(
            DeleteIndexRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// FirestoreAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class FirestoreAdminClientImpl : FirestoreAdminClient
    {
        private readonly ApiCall<CreateIndexRequest, Operation> _callCreateIndex;
        private readonly ApiCall<ListIndexesRequest, ListIndexesResponse> _callListIndexes;
        private readonly ApiCall<GetIndexRequest, Index> _callGetIndex;
        private readonly ApiCall<DeleteIndexRequest, Empty> _callDeleteIndex;

        /// <summary>
        /// Constructs a client wrapper for the FirestoreAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FirestoreAdminSettings"/> used within this client </param>
        public FirestoreAdminClientImpl(FirestoreAdmin.FirestoreAdminClient grpcClient, FirestoreAdminSettings settings)
        {
            GrpcClient = grpcClient;
            FirestoreAdminSettings effectiveSettings = settings ?? FirestoreAdminSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callCreateIndex = clientHelper.BuildApiCall<CreateIndexRequest, Operation>(
                GrpcClient.CreateIndexAsync, GrpcClient.CreateIndex, effectiveSettings.CreateIndexSettings);
            _callListIndexes = clientHelper.BuildApiCall<ListIndexesRequest, ListIndexesResponse>(
                GrpcClient.ListIndexesAsync, GrpcClient.ListIndexes, effectiveSettings.ListIndexesSettings);
            _callGetIndex = clientHelper.BuildApiCall<GetIndexRequest, Index>(
                GrpcClient.GetIndexAsync, GrpcClient.GetIndex, effectiveSettings.GetIndexSettings);
            _callDeleteIndex = clientHelper.BuildApiCall<DeleteIndexRequest, Empty>(
                GrpcClient.DeleteIndexAsync, GrpcClient.DeleteIndex, effectiveSettings.DeleteIndexSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(FirestoreAdmin.FirestoreAdminClient grpcClient, FirestoreAdminSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC FirestoreAdmin client.
        /// </summary>
        public override FirestoreAdmin.FirestoreAdminClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_CreateIndexRequest(ref CreateIndexRequest request, ref CallSettings settings);
        partial void Modify_ListIndexesRequest(ref ListIndexesRequest request, ref CallSettings settings);
        partial void Modify_GetIndexRequest(ref GetIndexRequest request, ref CallSettings settings);
        partial void Modify_DeleteIndexRequest(ref DeleteIndexRequest request, ref CallSettings settings);

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the state will be `READY`.
        /// If the index already exists, the call will return an `ALREADY_EXISTS`
        /// status.
        ///
        /// During creation, the process could result in an error, in which case the
        /// index will move to the `ERROR` state. The process can be recovered by
        /// fixing the data that caused the error, removing the index with
        /// [delete][google.firestore.admin.v1beta1.FirestoreAdmin.DeleteIndex], then re-creating the index with
        /// [create][google.firestore.admin.v1beta1.FirestoreAdmin.CreateIndex].
        ///
        /// Indexes with a single field cannot be created.
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
        public override Task<Operation> CreateIndexAsync(
            CreateIndexRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return _callCreateIndex.Async(request, callSettings);
        }

        /// <summary>
        /// Creates the specified index.
        /// A newly created index's initial state is `CREATING`. On completion of the
        /// returned [google.longrunning.Operation][google.longrunning.Operation], the state will be `READY`.
        /// If the index already exists, the call will return an `ALREADY_EXISTS`
        /// status.
        ///
        /// During creation, the process could result in an error, in which case the
        /// index will move to the `ERROR` state. The process can be recovered by
        /// fixing the data that caused the error, removing the index with
        /// [delete][google.firestore.admin.v1beta1.FirestoreAdmin.DeleteIndex], then re-creating the index with
        /// [create][google.firestore.admin.v1beta1.FirestoreAdmin.CreateIndex].
        ///
        /// Indexes with a single field cannot be created.
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
        public override Operation CreateIndex(
            CreateIndexRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return _callCreateIndex.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the indexes that match the specified filters.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Index"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(
            ListIndexesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }

        /// <summary>
        /// Lists the indexes that match the specified filters.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Index"/> resources.
        /// </returns>
        public override PagedEnumerable<ListIndexesResponse, Index> ListIndexes(
            ListIndexesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }

        /// <summary>
        /// Gets an index.
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
        public override Task<Index> GetIndexAsync(
            GetIndexRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an index.
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
        public override Index GetIndex(
            GetIndexRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an index.
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
        public override Task DeleteIndexAsync(
            DeleteIndexRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            return _callDeleteIndex.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an index.
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
        public override void DeleteIndex(
            DeleteIndexRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            _callDeleteIndex.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListIndexesRequest : IPageRequest { }
    public partial class ListIndexesResponse : IPageResponse<Index>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Index> GetEnumerator() => Indexes.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
