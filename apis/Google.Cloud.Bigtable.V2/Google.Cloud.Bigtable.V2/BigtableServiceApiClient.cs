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
using gaxgrpcgcp = Google.Api.Gax.Grpc.Gcp;
using gcbcv = Google.Cloud.Bigtable.Common.V2;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using linq = System.Linq;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Settings for a <see cref="BigtableServiceApiClient"/>.
    /// </summary>
    public sealed partial class BigtableServiceApiSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="BigtableServiceApiSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="BigtableServiceApiSettings"/>.
        /// </returns>
        public static BigtableServiceApiSettings GetDefault() => new BigtableServiceApiSettings();

        /// <summary>
        /// Constructs a new <see cref="BigtableServiceApiSettings"/> object with default settings.
        /// </summary>
        public BigtableServiceApiSettings() { }

        private BigtableServiceApiSettings(BigtableServiceApiSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ReadRowsSettings = existing.ReadRowsSettings;
            SampleRowKeysSettings = existing.SampleRowKeysSettings;
            MutateRowSettings = existing.MutateRowSettings;
            MutateRowsSettings = existing.MutateRowsSettings;
            CheckAndMutateRowSettings = existing.CheckAndMutateRowSettings;
            ReadModifyWriteRowSettings = existing.ReadModifyWriteRowSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableServiceApiSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "IdempotentParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "IdempotentParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "IdempotentParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 10 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetIdempotentParamsRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(10),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 2.0
        );

        /// <summary>
        /// "IdempotentParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "IdempotentParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "IdempotentParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetIdempotentParamsTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "NonIdempotentParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "NonIdempotentParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "NonIdempotentParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 10 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetNonIdempotentParamsRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(10),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 2.0
        );

        /// <summary>
        /// "NonIdempotentParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "NonIdempotentParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "NonIdempotentParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetNonIdempotentParamsTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "ReadRowsParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "ReadRowsParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "ReadRowsParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 10 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetReadRowsParamsRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(10),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 2.0
        );

        /// <summary>
        /// "ReadRowsParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "ReadRowsParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "ReadRowsParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 300000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetReadRowsParamsTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(300000),
            maxDelay: sys::TimeSpan.FromMilliseconds(300000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "MutateRowsParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "MutateRowsParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "MutateRowsParams" retry backoff for <see cref="BigtableServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 10 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetMutateRowsParamsRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(10),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 2.0
        );

        /// <summary>
        /// "MutateRowsParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "MutateRowsParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "MutateRowsParams" timeout backoff for <see cref="BigtableServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetMutateRowsParamsTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(60000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>BigtableServiceApiClient.ReadRows</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 43200000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ReadRowsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(43200000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>BigtableServiceApiClient.SampleRowKeys</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SampleRowKeysSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.MutateRow</c> and <c>BigtableServiceApiClient.MutateRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableServiceApiClient.MutateRow</c> and
        /// <c>BigtableServiceApiClient.MutateRowAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 10 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings MutateRowSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetIdempotentParamsRetryBackoff(),
                timeoutBackoff: GetIdempotentParamsTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>BigtableServiceApiClient.MutateRows</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings MutateRowsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.CheckAndMutateRow</c> and <c>BigtableServiceApiClient.CheckAndMutateRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableServiceApiClient.CheckAndMutateRow</c> and
        /// <c>BigtableServiceApiClient.CheckAndMutateRowAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 10 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 20000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CheckAndMutateRowSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetNonIdempotentParamsRetryBackoff(),
                timeoutBackoff: GetNonIdempotentParamsTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.ReadModifyWriteRow</c> and <c>BigtableServiceApiClient.ReadModifyWriteRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableServiceApiClient.ReadModifyWriteRow</c> and
        /// <c>BigtableServiceApiClient.ReadModifyWriteRowAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 10 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 20000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ReadModifyWriteRowSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetNonIdempotentParamsRetryBackoff(),
                timeoutBackoff: GetNonIdempotentParamsTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="BigtableServiceApiSettings"/> object.</returns>
        public BigtableServiceApiSettings Clone() => new BigtableServiceApiSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BigtableServiceApiClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BigtableServiceApiClientBuilder : gaxgrpc::ClientBuilderBase<BigtableServiceApiClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public BigtableServiceApiSettings Settings { get; set; }

        /// <inheritdoc/>
        public override BigtableServiceApiClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BigtableServiceApiClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<BigtableServiceApiClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BigtableServiceApiClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => BigtableServiceApiClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BigtableServiceApiClient.DefaultScopes;
    }

    /// <summary>
    /// Bigtable client wrapper, for convenient use.
    /// </summary>
    public abstract partial class BigtableServiceApiClient
    {
        /// <summary>
        /// The default endpoint for the Bigtable service, which is a host of "bigtable.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("bigtable.googleapis.com", 443);

        /// <summary>
        /// The default Bigtable scopes.
        /// </summary>
        /// <remarks>
        /// The default Bigtable scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/bigtable.data"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.data.readonly"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.data"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.data.readonly"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/bigtable.data",
            "https://www.googleapis.com/auth/bigtable.data.readonly",
            "https://www.googleapis.com/auth/cloud-bigtable.data",
            "https://www.googleapis.com/auth/cloud-bigtable.data.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        private static readonly gaxgrpcgcp::GcpCallInvokerPool s_callInvokerPool = new gaxgrpcgcp::GcpCallInvokerPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="BigtableServiceApiClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Bigtable.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// BigtableServiceApiClient client = await BigtableServiceApiClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Bigtable.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     BigtableServiceApiClient.DefaultEndpoint.Host, BigtableServiceApiClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// BigtableServiceApiClient client = BigtableServiceApiClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableServiceApiSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BigtableServiceApiClient"/>.</returns>
        public static async stt::Task<BigtableServiceApiClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, BigtableServiceApiSettings settings = null)
        {
            grpccore::CallInvoker callInvoker = await s_callInvokerPool.GetCallInvokerAsync(endpoint ?? DefaultEndpoint, settings.CreateChannelOptions()).ConfigureAwait(false);
            return Create(callInvoker, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigtableServiceApiClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Bigtable.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// BigtableServiceApiClient client = BigtableServiceApiClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Bigtable.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     BigtableServiceApiClient.DefaultEndpoint.Host, BigtableServiceApiClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// BigtableServiceApiClient client = BigtableServiceApiClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableServiceApiSettings"/>.</param>
        /// <returns>The created <see cref="BigtableServiceApiClient"/>.</returns>
        public static BigtableServiceApiClient Create(gaxgrpc::ServiceEndpoint endpoint = null, BigtableServiceApiSettings settings = null)
        {
            grpccore::CallInvoker callInvoker = s_callInvokerPool.GetCallInvoker(endpoint ?? DefaultEndpoint, settings.CreateChannelOptions());
            return Create(callInvoker, settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableServiceApiClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableServiceApiSettings"/>.</param>
        /// <returns>The created <see cref="BigtableServiceApiClient"/>.</returns>
        public static BigtableServiceApiClient Create(grpccore::Channel channel, BigtableServiceApiSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableServiceApiClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableServiceApiSettings"/>.</param>
        /// <returns>The created <see cref="BigtableServiceApiClient"/>.</returns>
        public static BigtableServiceApiClient Create(grpccore::CallInvoker callInvoker, BigtableServiceApiSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Bigtable.BigtableClient grpcClient = new Bigtable.BigtableClient(callInvoker);
            return new BigtableServiceApiClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, BigtableServiceApiSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, BigtableServiceApiSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, BigtableServiceApiSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, BigtableServiceApiSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_callInvokerPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Bigtable client.
        /// </summary>
        public virtual Bigtable.BigtableClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table from which to read.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual ReadRowsStream ReadRows(
            gcbcv::TableName tableName,
            gaxgrpc::CallSettings callSettings = null) => ReadRows(
                new ReadRowsRequest
                {
                    TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                },
                callSettings);

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table from which to read.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual ReadRowsStream ReadRows(
            string tableName,
            gaxgrpc::CallSettings callSettings = null) => ReadRows(
                new ReadRowsRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                },
                callSettings);

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual ReadRowsStream ReadRows(
            ReadRowsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>ReadRows</c>.
        /// </summary>
        public abstract partial class ReadRowsStream : gaxgrpc::ServerStreamingBase<ReadRowsResponse>
        {
        }

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table from which to sample row keys.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual SampleRowKeysStream SampleRowKeys(
            gcbcv::TableName tableName,
            gaxgrpc::CallSettings callSettings = null) => SampleRowKeys(
                new SampleRowKeysRequest
                {
                    TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                },
                callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table from which to sample row keys.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual SampleRowKeysStream SampleRowKeys(
            string tableName,
            gaxgrpc::CallSettings callSettings = null) => SampleRowKeys(
                new SampleRowKeysRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                },
                callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual SampleRowKeysStream SampleRowKeys(
            SampleRowKeysRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>SampleRowKeys</c>.
        /// </summary>
        public abstract partial class SampleRowKeysStream : gaxgrpc::ServerStreamingBase<SampleRowKeysResponse>
        {
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(
            gcbcv::TableName tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<Mutation> mutations,
            gaxgrpc::CallSettings callSettings = null) => MutateRowAsync(
                new MutateRowRequest
                {
                    TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Mutations = { gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(
            gcbcv::TableName tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<Mutation> mutations,
            st::CancellationToken cancellationToken) => MutateRowAsync(
                tableName,
                rowKey,
                mutations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateRowResponse MutateRow(
            gcbcv::TableName tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<Mutation> mutations,
            gaxgrpc::CallSettings callSettings = null) => MutateRow(
                new MutateRowRequest
                {
                    TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Mutations = { gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(
            string tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<Mutation> mutations,
            gaxgrpc::CallSettings callSettings = null) => MutateRowAsync(
                new MutateRowRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Mutations = { gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(
            string tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<Mutation> mutations,
            st::CancellationToken cancellationToken) => MutateRowAsync(
                tableName,
                rowKey,
                mutations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateRowResponse MutateRow(
            string tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<Mutation> mutations,
            gaxgrpc::CallSettings callSettings = null) => MutateRow(
                new MutateRowRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Mutations = { gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)) },
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
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
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(
            MutateRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
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
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(
            MutateRowRequest request,
            st::CancellationToken cancellationToken) => MutateRowAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
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
        public virtual MutateRowResponse MutateRow(
            MutateRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the mutations should be applied.
        /// </param>
        /// <param name="entries">
        /// The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual MutateRowsStream MutateRows(
            gcbcv::TableName tableName,
            scg::IEnumerable<MutateRowsRequest.Types.Entry> entries,
            gaxgrpc::CallSettings callSettings = null) => MutateRows(
                new MutateRowsRequest
                {
                    TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    Entries = { gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)) },
                },
                callSettings);

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the mutations should be applied.
        /// </param>
        /// <param name="entries">
        /// The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual MutateRowsStream MutateRows(
            string tableName,
            scg::IEnumerable<MutateRowsRequest.Types.Entry> entries,
            gaxgrpc::CallSettings callSettings = null) => MutateRows(
                new MutateRowsRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    Entries = { gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)) },
                },
                callSettings);

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual MutateRowsStream MutateRows(
            MutateRowsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>MutateRows</c>.
        /// </summary>
        public abstract partial class MutateRowsStream : gaxgrpc::ServerStreamingBase<MutateRowsResponse>
        {
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            gcbcv::TableName tableName,
            pb::ByteString rowKey,
            RowFilter predicateFilter,
            scg::IEnumerable<Mutation> trueMutations,
            scg::IEnumerable<Mutation> falseMutations,
            gaxgrpc::CallSettings callSettings = null) => CheckAndMutateRowAsync(
                new CheckAndMutateRowRequest
                {
                    TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    PredicateFilter = predicateFilter, // Optional
                    TrueMutations = { trueMutations ?? linq::Enumerable.Empty<Mutation>() }, // Optional
                    FalseMutations = { falseMutations ?? linq::Enumerable.Empty<Mutation>() }, // Optional
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            gcbcv::TableName tableName,
            pb::ByteString rowKey,
            RowFilter predicateFilter,
            scg::IEnumerable<Mutation> trueMutations,
            scg::IEnumerable<Mutation> falseMutations,
            st::CancellationToken cancellationToken) => CheckAndMutateRowAsync(
                tableName,
                rowKey,
                predicateFilter,
                trueMutations,
                falseMutations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            gcbcv::TableName tableName,
            pb::ByteString rowKey,
            RowFilter predicateFilter,
            scg::IEnumerable<Mutation> trueMutations,
            scg::IEnumerable<Mutation> falseMutations,
            gaxgrpc::CallSettings callSettings = null) => CheckAndMutateRow(
                new CheckAndMutateRowRequest
                {
                    TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    PredicateFilter = predicateFilter, // Optional
                    TrueMutations = { trueMutations ?? linq::Enumerable.Empty<Mutation>() }, // Optional
                    FalseMutations = { falseMutations ?? linq::Enumerable.Empty<Mutation>() }, // Optional
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            string tableName,
            pb::ByteString rowKey,
            RowFilter predicateFilter,
            scg::IEnumerable<Mutation> trueMutations,
            scg::IEnumerable<Mutation> falseMutations,
            gaxgrpc::CallSettings callSettings = null) => CheckAndMutateRowAsync(
                new CheckAndMutateRowRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    PredicateFilter = predicateFilter, // Optional
                    TrueMutations = { trueMutations ?? linq::Enumerable.Empty<Mutation>() }, // Optional
                    FalseMutations = { falseMutations ?? linq::Enumerable.Empty<Mutation>() }, // Optional
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            string tableName,
            pb::ByteString rowKey,
            RowFilter predicateFilter,
            scg::IEnumerable<Mutation> trueMutations,
            scg::IEnumerable<Mutation> falseMutations,
            st::CancellationToken cancellationToken) => CheckAndMutateRowAsync(
                tableName,
                rowKey,
                predicateFilter,
                trueMutations,
                falseMutations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            string tableName,
            pb::ByteString rowKey,
            RowFilter predicateFilter,
            scg::IEnumerable<Mutation> trueMutations,
            scg::IEnumerable<Mutation> falseMutations,
            gaxgrpc::CallSettings callSettings = null) => CheckAndMutateRow(
                new CheckAndMutateRowRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    PredicateFilter = predicateFilter, // Optional
                    TrueMutations = { trueMutations ?? linq::Enumerable.Empty<Mutation>() }, // Optional
                    FalseMutations = { falseMutations ?? linq::Enumerable.Empty<Mutation>() }, // Optional
                },
                callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
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
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            CheckAndMutateRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
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
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            CheckAndMutateRowRequest request,
            st::CancellationToken cancellationToken) => CheckAndMutateRowAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
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
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            CheckAndMutateRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            gcbcv::TableName tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<ReadModifyWriteRule> rules,
            gaxgrpc::CallSettings callSettings = null) => ReadModifyWriteRowAsync(
                new ReadModifyWriteRowRequest
                {
                    TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Rules = { gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)) },
                },
                callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            gcbcv::TableName tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<ReadModifyWriteRule> rules,
            st::CancellationToken cancellationToken) => ReadModifyWriteRowAsync(
                tableName,
                rowKey,
                rules,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            gcbcv::TableName tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<ReadModifyWriteRule> rules,
            gaxgrpc::CallSettings callSettings = null) => ReadModifyWriteRow(
                new ReadModifyWriteRowRequest
                {
                    TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Rules = { gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)) },
                },
                callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            string tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<ReadModifyWriteRule> rules,
            gaxgrpc::CallSettings callSettings = null) => ReadModifyWriteRowAsync(
                new ReadModifyWriteRowRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Rules = { gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)) },
                },
                callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            string tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<ReadModifyWriteRule> rules,
            st::CancellationToken cancellationToken) => ReadModifyWriteRowAsync(
                tableName,
                rowKey,
                rules,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            string tableName,
            pb::ByteString rowKey,
            scg::IEnumerable<ReadModifyWriteRule> rules,
            gaxgrpc::CallSettings callSettings = null) => ReadModifyWriteRow(
                new ReadModifyWriteRowRequest
                {
                    TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                    RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                    Rules = { gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)) },
                },
                callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            ReadModifyWriteRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            ReadModifyWriteRowRequest request,
            st::CancellationToken cancellationToken) => ReadModifyWriteRowAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            ReadModifyWriteRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// Bigtable client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class BigtableServiceApiClientImpl : BigtableServiceApiClient
    {
        private readonly gaxgrpc::ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> _callReadRows;
        private readonly gaxgrpc::ApiServerStreamingCall<SampleRowKeysRequest, SampleRowKeysResponse> _callSampleRowKeys;
        private readonly gaxgrpc::ApiCall<MutateRowRequest, MutateRowResponse> _callMutateRow;
        private readonly gaxgrpc::ApiServerStreamingCall<MutateRowsRequest, MutateRowsResponse> _callMutateRows;
        private readonly gaxgrpc::ApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse> _callCheckAndMutateRow;
        private readonly gaxgrpc::ApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse> _callReadModifyWriteRow;

        /// <summary>
        /// Constructs a client wrapper for the Bigtable service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableServiceApiSettings"/> used within this client </param>
        public BigtableServiceApiClientImpl(Bigtable.BigtableClient grpcClient, BigtableServiceApiSettings settings)
        {
            GrpcClient = grpcClient;
            BigtableServiceApiSettings effectiveSettings = settings ?? BigtableServiceApiSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callReadRows = clientHelper.BuildApiCall<ReadRowsRequest, ReadRowsResponse>(
                GrpcClient.ReadRows, effectiveSettings.ReadRowsSettings)
                .WithGoogleRequestParam("table_name", request => request.TableName);
            _callSampleRowKeys = clientHelper.BuildApiCall<SampleRowKeysRequest, SampleRowKeysResponse>(
                GrpcClient.SampleRowKeys, effectiveSettings.SampleRowKeysSettings)
                .WithGoogleRequestParam("table_name", request => request.TableName);
            _callMutateRow = clientHelper.BuildApiCall<MutateRowRequest, MutateRowResponse>(
                GrpcClient.MutateRowAsync, GrpcClient.MutateRow, effectiveSettings.MutateRowSettings)
                .WithGoogleRequestParam("table_name", request => request.TableName);
            _callMutateRows = clientHelper.BuildApiCall<MutateRowsRequest, MutateRowsResponse>(
                GrpcClient.MutateRows, effectiveSettings.MutateRowsSettings)
                .WithGoogleRequestParam("table_name", request => request.TableName);
            _callCheckAndMutateRow = clientHelper.BuildApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse>(
                GrpcClient.CheckAndMutateRowAsync, GrpcClient.CheckAndMutateRow, effectiveSettings.CheckAndMutateRowSettings)
                .WithGoogleRequestParam("table_name", request => request.TableName);
            _callReadModifyWriteRow = clientHelper.BuildApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse>(
                GrpcClient.ReadModifyWriteRowAsync, GrpcClient.ReadModifyWriteRow, effectiveSettings.ReadModifyWriteRowSettings)
                .WithGoogleRequestParam("table_name", request => request.TableName);
            Modify_ApiCall(ref _callReadRows);
            Modify_ReadRowsApiCall(ref _callReadRows);
            Modify_ApiCall(ref _callSampleRowKeys);
            Modify_SampleRowKeysApiCall(ref _callSampleRowKeys);
            Modify_ApiCall(ref _callMutateRow);
            Modify_MutateRowApiCall(ref _callMutateRow);
            Modify_ApiCall(ref _callMutateRows);
            Modify_MutateRowsApiCall(ref _callMutateRows);
            Modify_ApiCall(ref _callCheckAndMutateRow);
            Modify_CheckAndMutateRowApiCall(ref _callCheckAndMutateRow);
            Modify_ApiCall(ref _callReadModifyWriteRow);
            Modify_ReadModifyWriteRowApiCall(ref _callReadModifyWriteRow);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_ReadRowsApiCall(ref gaxgrpc::ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> call);
        partial void Modify_SampleRowKeysApiCall(ref gaxgrpc::ApiServerStreamingCall<SampleRowKeysRequest, SampleRowKeysResponse> call);
        partial void Modify_MutateRowApiCall(ref gaxgrpc::ApiCall<MutateRowRequest, MutateRowResponse> call);
        partial void Modify_MutateRowsApiCall(ref gaxgrpc::ApiServerStreamingCall<MutateRowsRequest, MutateRowsResponse> call);
        partial void Modify_CheckAndMutateRowApiCall(ref gaxgrpc::ApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse> call);
        partial void Modify_ReadModifyWriteRowApiCall(ref gaxgrpc::ApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse> call);
        partial void OnConstruction(Bigtable.BigtableClient grpcClient, BigtableServiceApiSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Bigtable client.
        /// </summary>
        public override Bigtable.BigtableClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ReadRowsRequest(ref ReadRowsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SampleRowKeysRequest(ref SampleRowKeysRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateRowRequest(ref MutateRowRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateRowsRequest(ref MutateRowsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CheckAndMutateRowRequest(ref CheckAndMutateRowRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ReadModifyWriteRowRequest(ref ReadModifyWriteRowRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override ReadRowsStream ReadRows(
            ReadRowsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRowsRequest(ref request, ref callSettings);
            return new ReadRowsStreamImpl(_callReadRows.Call(request, callSettings));
        }

        internal sealed partial class ReadRowsStreamImpl : ReadRowsStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>ReadRows</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal ReadRowsStreamImpl(grpccore::AsyncServerStreamingCall<ReadRowsResponse> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncServerStreamingCall<ReadRowsResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override scg::IAsyncEnumerator<ReadRowsResponse> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override SampleRowKeysStream SampleRowKeys(
            SampleRowKeysRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SampleRowKeysRequest(ref request, ref callSettings);
            return new SampleRowKeysStreamImpl(_callSampleRowKeys.Call(request, callSettings));
        }

        internal sealed partial class SampleRowKeysStreamImpl : SampleRowKeysStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>SampleRowKeys</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal SampleRowKeysStreamImpl(grpccore::AsyncServerStreamingCall<SampleRowKeysResponse> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncServerStreamingCall<SampleRowKeysResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override scg::IAsyncEnumerator<SampleRowKeysResponse> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
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
        public override stt::Task<MutateRowResponse> MutateRowAsync(
            MutateRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRowRequest(ref request, ref callSettings);
            return _callMutateRow.Async(request, callSettings);
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
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
        public override MutateRowResponse MutateRow(
            MutateRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRowRequest(ref request, ref callSettings);
            return _callMutateRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override MutateRowsStream MutateRows(
            MutateRowsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRowsRequest(ref request, ref callSettings);
            return new MutateRowsStreamImpl(_callMutateRows.Call(request, callSettings));
        }

        internal sealed partial class MutateRowsStreamImpl : MutateRowsStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>MutateRows</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal MutateRowsStreamImpl(grpccore::AsyncServerStreamingCall<MutateRowsResponse> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncServerStreamingCall<MutateRowsResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override scg::IAsyncEnumerator<MutateRowsResponse> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
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
        public override stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            CheckAndMutateRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckAndMutateRowRequest(ref request, ref callSettings);
            return _callCheckAndMutateRow.Async(request, callSettings);
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
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
        public override CheckAndMutateRowResponse CheckAndMutateRow(
            CheckAndMutateRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckAndMutateRowRequest(ref request, ref callSettings);
            return _callCheckAndMutateRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
        public override stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            ReadModifyWriteRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadModifyWriteRowRequest(ref request, ref callSettings);
            return _callReadModifyWriteRow.Async(request, callSettings);
        }

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
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
        public override ReadModifyWriteRowResponse ReadModifyWriteRow(
            ReadModifyWriteRowRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadModifyWriteRowRequest(ref request, ref callSettings);
            return _callReadModifyWriteRow.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
