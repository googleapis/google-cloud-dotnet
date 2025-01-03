// Copyright 2025 Google LLC
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

namespace Grafeas.V1
{
    /// <summary>Settings for <see cref="GrafeasClient"/> instances.</summary>
    public sealed partial class GrafeasSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GrafeasSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GrafeasSettings"/>.</returns>
        public static GrafeasSettings GetDefault() => new GrafeasSettings();

        /// <summary>Constructs a new <see cref="GrafeasSettings"/> object with default settings.</summary>
        public GrafeasSettings()
        {
        }

        private GrafeasSettings(GrafeasSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOccurrenceSettings = existing.GetOccurrenceSettings;
            ListOccurrencesSettings = existing.ListOccurrencesSettings;
            DeleteOccurrenceSettings = existing.DeleteOccurrenceSettings;
            CreateOccurrenceSettings = existing.CreateOccurrenceSettings;
            BatchCreateOccurrencesSettings = existing.BatchCreateOccurrencesSettings;
            UpdateOccurrenceSettings = existing.UpdateOccurrenceSettings;
            GetOccurrenceNoteSettings = existing.GetOccurrenceNoteSettings;
            GetNoteSettings = existing.GetNoteSettings;
            ListNotesSettings = existing.ListNotesSettings;
            DeleteNoteSettings = existing.DeleteNoteSettings;
            CreateNoteSettings = existing.CreateNoteSettings;
            BatchCreateNotesSettings = existing.BatchCreateNotesSettings;
            UpdateNoteSettings = existing.UpdateNoteSettings;
            ListNoteOccurrencesSettings = existing.ListNoteOccurrencesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GrafeasSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GrafeasClient.GetOccurrence</c>
        ///  and <c>GrafeasClient.GetOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOccurrenceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasClient.ListOccurrences</c> and <c>GrafeasClient.ListOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOccurrencesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasClient.DeleteOccurrence</c> and <c>GrafeasClient.DeleteOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteOccurrenceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasClient.CreateOccurrence</c> and <c>GrafeasClient.CreateOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateOccurrenceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasClient.BatchCreateOccurrences</c> and <c>GrafeasClient.BatchCreateOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateOccurrencesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasClient.UpdateOccurrence</c> and <c>GrafeasClient.UpdateOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateOccurrenceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasClient.GetOccurrenceNote</c> and <c>GrafeasClient.GetOccurrenceNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOccurrenceNoteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GrafeasClient.GetNote</c>
        /// and <c>GrafeasClient.GetNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNoteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GrafeasClient.ListNotes</c>
        /// and <c>GrafeasClient.ListNotesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNotesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GrafeasClient.DeleteNote</c>
        ///  and <c>GrafeasClient.DeleteNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNoteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GrafeasClient.CreateNote</c>
        ///  and <c>GrafeasClient.CreateNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNoteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasClient.BatchCreateNotes</c> and <c>GrafeasClient.BatchCreateNotesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateNotesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GrafeasClient.UpdateNote</c>
        ///  and <c>GrafeasClient.UpdateNoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNoteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GrafeasClient.ListNoteOccurrences</c> and <c>GrafeasClient.ListNoteOccurrencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNoteOccurrencesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GrafeasSettings"/> object.</returns>
        public GrafeasSettings Clone() => new GrafeasSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GrafeasClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class GrafeasClientBuilder : gaxgrpc::ClientBuilderBase<GrafeasClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GrafeasSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GrafeasClientBuilder() : base(GrafeasClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GrafeasClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GrafeasClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GrafeasClient Build()
        {
            GrafeasClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GrafeasClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GrafeasClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GrafeasClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GrafeasClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GrafeasClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GrafeasClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }
    }

    /// <summary>Grafeas client wrapper, for convenient use.</summary>
    /// <remarks>
    /// [Grafeas](https://grafeas.io) API.
    /// 
    /// Retrieves analysis results of Cloud components such as Docker container
    /// images.
    /// 
    /// Analysis results are stored as a series of occurrences. An `Occurrence`
    /// contains information about a specific analysis instance on a resource. An
    /// occurrence refers to a `Note`. A note contains details describing the
    /// analysis and is generally stored in a separate project, called a `Provider`.
    /// Multiple occurrences can refer to the same note.
    /// 
    /// For example, an SSL vulnerability could affect multiple images. In this case,
    /// there would be one note for the vulnerability and an occurrence for each
    /// image with the vulnerability referring to that note.
    /// </remarks>
    public abstract partial class GrafeasClient
    {

        /// <summary>The default Grafeas scopes.</summary>
        /// <remarks>The default Grafeas scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Grafeas.Descriptor, null, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GrafeasClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="GrafeasClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GrafeasClient"/>.</returns>
        public static stt::Task<GrafeasClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GrafeasClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GrafeasClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="GrafeasClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GrafeasClient"/>.</returns>
        public static GrafeasClient Create() => new GrafeasClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GrafeasClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GrafeasSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GrafeasClient"/>.</returns>
        internal static GrafeasClient Create(grpccore::CallInvoker callInvoker, GrafeasSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Grafeas.GrafeasClient grpcClient = new Grafeas.GrafeasClient(callInvoker);
            return new GrafeasClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Grafeas client</summary>
        public virtual Grafeas.GrafeasClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Occurrence GetOccurrence(GetOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(GetOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(GetOccurrenceRequest request, st::CancellationToken cancellationToken) =>
            GetOccurrenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Occurrence GetOccurrence(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOccurrence(new GetOccurrenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOccurrenceAsync(new GetOccurrenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(string name, st::CancellationToken cancellationToken) =>
            GetOccurrenceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Occurrence GetOccurrence(OccurrenceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOccurrence(new GetOccurrenceRequest
            {
                OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(OccurrenceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOccurrenceAsync(new GetOccurrenceRequest
            {
                OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> GetOccurrenceAsync(OccurrenceName name, st::CancellationToken cancellationToken) =>
            GetOccurrenceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrences(ListOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrencesAsync(ListOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrences(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOccurrencesRequest request = new ListOccurrencesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
            return ListOccurrences(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrencesAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOccurrencesRequest request = new ListOccurrencesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
            return ListOccurrencesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrences(ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOccurrencesRequest request = new ListOccurrencesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
            return ListOccurrences(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list occurrences for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrencesAsync(ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOccurrencesRequest request = new ListOccurrencesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
            return ListOccurrencesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteOccurrence(DeleteOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteOccurrenceAsync(DeleteOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteOccurrenceAsync(DeleteOccurrenceRequest request, st::CancellationToken cancellationToken) =>
            DeleteOccurrenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteOccurrence(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOccurrence(new DeleteOccurrenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteOccurrenceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOccurrenceAsync(new DeleteOccurrenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteOccurrenceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteOccurrenceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteOccurrence(OccurrenceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOccurrence(new DeleteOccurrenceRequest
            {
                OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteOccurrenceAsync(OccurrenceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOccurrenceAsync(new DeleteOccurrenceRequest
            {
                OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteOccurrenceAsync(OccurrenceName name, st::CancellationToken cancellationToken) =>
            DeleteOccurrenceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Occurrence CreateOccurrence(CreateOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(CreateOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(CreateOccurrenceRequest request, st::CancellationToken cancellationToken) =>
            CreateOccurrenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Occurrence CreateOccurrence(string parent, Occurrence occurrence, gaxgrpc::CallSettings callSettings = null) =>
            CreateOccurrence(new CreateOccurrenceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
            }, callSettings);

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(string parent, Occurrence occurrence, gaxgrpc::CallSettings callSettings = null) =>
            CreateOccurrenceAsync(new CreateOccurrenceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
            }, callSettings);

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(string parent, Occurrence occurrence, st::CancellationToken cancellationToken) =>
            CreateOccurrenceAsync(parent, occurrence, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Occurrence CreateOccurrence(ProjectName parent, Occurrence occurrence, gaxgrpc::CallSettings callSettings = null) =>
            CreateOccurrence(new CreateOccurrenceRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
            }, callSettings);

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(ProjectName parent, Occurrence occurrence, gaxgrpc::CallSettings callSettings = null) =>
            CreateOccurrenceAsync(new CreateOccurrenceRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
            }, callSettings);

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrence is to be created.
        /// </param>
        /// <param name="occurrence">
        /// The occurrence to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> CreateOccurrenceAsync(ProjectName parent, Occurrence occurrence, st::CancellationToken cancellationToken) =>
            CreateOccurrenceAsync(parent, occurrence, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateOccurrencesResponse BatchCreateOccurrences(BatchCreateOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(BatchCreateOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(BatchCreateOccurrencesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateOccurrencesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateOccurrencesResponse BatchCreateOccurrences(string parent, scg::IEnumerable<Occurrence> occurrences, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateOccurrences(new BatchCreateOccurrencesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Occurrences =
                {
                    gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)),
                },
            }, callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(string parent, scg::IEnumerable<Occurrence> occurrences, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateOccurrencesAsync(new BatchCreateOccurrencesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Occurrences =
                {
                    gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)),
                },
            }, callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(string parent, scg::IEnumerable<Occurrence> occurrences, st::CancellationToken cancellationToken) =>
            BatchCreateOccurrencesAsync(parent, occurrences, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateOccurrencesResponse BatchCreateOccurrences(ProjectName parent, scg::IEnumerable<Occurrence> occurrences, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateOccurrences(new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Occurrences =
                {
                    gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)),
                },
            }, callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(ProjectName parent, scg::IEnumerable<Occurrence> occurrences, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateOccurrencesAsync(new BatchCreateOccurrencesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Occurrences =
                {
                    gax::GaxPreconditions.CheckNotNull(occurrences, nameof(occurrences)),
                },
            }, callSettings);

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the occurrences are to be created.
        /// </param>
        /// <param name="occurrences">
        /// The occurrences to create. Max allowed length is 1000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(ProjectName parent, scg::IEnumerable<Occurrence> occurrences, st::CancellationToken cancellationToken) =>
            BatchCreateOccurrencesAsync(parent, occurrences, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Occurrence UpdateOccurrence(UpdateOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(UpdateOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(UpdateOccurrenceRequest request, st::CancellationToken cancellationToken) =>
            UpdateOccurrenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Occurrence UpdateOccurrence(string name, Occurrence occurrence, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOccurrence(new UpdateOccurrenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(string name, Occurrence occurrence, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOccurrenceAsync(new UpdateOccurrenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(string name, Occurrence occurrence, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateOccurrenceAsync(name, occurrence, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Occurrence UpdateOccurrence(OccurrenceName name, Occurrence occurrence, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOccurrence(new UpdateOccurrenceRequest
            {
                OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(OccurrenceName name, Occurrence occurrence, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOccurrenceAsync(new UpdateOccurrenceRequest
            {
                OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Occurrence = gax::GaxPreconditions.CheckNotNull(occurrence, nameof(occurrence)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="occurrence">
        /// The updated occurrence.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Occurrence> UpdateOccurrenceAsync(OccurrenceName name, Occurrence occurrence, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateOccurrenceAsync(name, occurrence, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note GetOccurrenceNote(GetOccurrenceNoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(GetOccurrenceNoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(GetOccurrenceNoteRequest request, st::CancellationToken cancellationToken) =>
            GetOccurrenceNoteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note GetOccurrenceNote(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOccurrenceNote(new GetOccurrenceNoteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOccurrenceNoteAsync(new GetOccurrenceNoteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(string name, st::CancellationToken cancellationToken) =>
            GetOccurrenceNoteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note GetOccurrenceNote(OccurrenceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOccurrenceNote(new GetOccurrenceNoteRequest
            {
                OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(OccurrenceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOccurrenceNoteAsync(new GetOccurrenceNoteRequest
            {
                OccurrenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="name">
        /// The name of the occurrence in the form of
        /// `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetOccurrenceNoteAsync(OccurrenceName name, st::CancellationToken cancellationToken) =>
            GetOccurrenceNoteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note GetNote(GetNoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetNoteAsync(GetNoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetNoteAsync(GetNoteRequest request, st::CancellationToken cancellationToken) =>
            GetNoteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note GetNote(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNote(new GetNoteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetNoteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNoteAsync(new GetNoteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetNoteAsync(string name, st::CancellationToken cancellationToken) =>
            GetNoteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note GetNote(NoteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNote(new GetNoteRequest
            {
                NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetNoteAsync(NoteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNoteAsync(new GetNoteRequest
            {
                NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> GetNoteAsync(NoteName name, st::CancellationToken cancellationToken) =>
            GetNoteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Note"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotesResponse, Note> ListNotes(ListNotesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Note"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotesResponse, Note> ListNotesAsync(ListNotesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable sequence of <see cref="Note"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotesResponse, Note> ListNotes(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotesRequest request = new ListNotesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
            return ListNotes(request, callSettings);
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Note"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotesResponse, Note> ListNotesAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotesRequest request = new ListNotesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
            return ListNotesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable sequence of <see cref="Note"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotesResponse, Note> ListNotes(ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotesRequest request = new ListNotesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
            return ListNotes(request, callSettings);
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="parent">
        /// The name of the project to list notes for in the form of
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Note"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotesResponse, Note> ListNotesAsync(ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotesRequest request = new ListNotesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
            return ListNotesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNote(DeleteNoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNoteAsync(DeleteNoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNoteAsync(DeleteNoteRequest request, st::CancellationToken cancellationToken) =>
            DeleteNoteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNote(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNote(new DeleteNoteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNoteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNoteAsync(new DeleteNoteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNoteAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNoteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNote(NoteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNote(new DeleteNoteRequest
            {
                NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNoteAsync(NoteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNoteAsync(new DeleteNoteRequest
            {
                NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNoteAsync(NoteName name, st::CancellationToken cancellationToken) =>
            DeleteNoteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note CreateNote(CreateNoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> CreateNoteAsync(CreateNoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> CreateNoteAsync(CreateNoteRequest request, st::CancellationToken cancellationToken) =>
            CreateNoteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note CreateNote(string parent, string noteId, Note note, gaxgrpc::CallSettings callSettings = null) =>
            CreateNote(new CreateNoteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
            }, callSettings);

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> CreateNoteAsync(string parent, string noteId, Note note, gaxgrpc::CallSettings callSettings = null) =>
            CreateNoteAsync(new CreateNoteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
            }, callSettings);

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> CreateNoteAsync(string parent, string noteId, Note note, st::CancellationToken cancellationToken) =>
            CreateNoteAsync(parent, noteId, note, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note CreateNote(ProjectName parent, string noteId, Note note, gaxgrpc::CallSettings callSettings = null) =>
            CreateNote(new CreateNoteRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
            }, callSettings);

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> CreateNoteAsync(ProjectName parent, string noteId, Note note, gaxgrpc::CallSettings callSettings = null) =>
            CreateNoteAsync(new CreateNoteRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NoteId = gax::GaxPreconditions.CheckNotNullOrEmpty(noteId, nameof(noteId)),
                Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
            }, callSettings);

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the note is to be created.
        /// </param>
        /// <param name="noteId">
        /// The ID to use for this note.
        /// </param>
        /// <param name="note">
        /// The note to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> CreateNoteAsync(ProjectName parent, string noteId, Note note, st::CancellationToken cancellationToken) =>
            CreateNoteAsync(parent, noteId, note, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateNotesResponse BatchCreateNotes(BatchCreateNotesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(BatchCreateNotesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(BatchCreateNotesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateNotesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateNotesResponse BatchCreateNotes(string parent, scg::IDictionary<string, Note> notes, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateNotes(new BatchCreateNotesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Notes =
                {
                    gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)),
                },
            }, callSettings);

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(string parent, scg::IDictionary<string, Note> notes, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateNotesAsync(new BatchCreateNotesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Notes =
                {
                    gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)),
                },
            }, callSettings);

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(string parent, scg::IDictionary<string, Note> notes, st::CancellationToken cancellationToken) =>
            BatchCreateNotesAsync(parent, notes, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateNotesResponse BatchCreateNotes(ProjectName parent, scg::IDictionary<string, Note> notes, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateNotes(new BatchCreateNotesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Notes =
                {
                    gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)),
                },
            }, callSettings);

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(ProjectName parent, scg::IDictionary<string, Note> notes, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateNotesAsync(new BatchCreateNotesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Notes =
                {
                    gax::GaxPreconditions.CheckNotNull(notes, nameof(notes)),
                },
            }, callSettings);

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="parent">
        /// The name of the project in the form of `projects/[PROJECT_ID]`, under which
        /// the notes are to be created.
        /// </param>
        /// <param name="notes">
        /// The notes to create. Max allowed length is 1000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(ProjectName parent, scg::IDictionary<string, Note> notes, st::CancellationToken cancellationToken) =>
            BatchCreateNotesAsync(parent, notes, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note UpdateNote(UpdateNoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> UpdateNoteAsync(UpdateNoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> UpdateNoteAsync(UpdateNoteRequest request, st::CancellationToken cancellationToken) =>
            UpdateNoteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note UpdateNote(string name, Note note, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNote(new UpdateNoteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> UpdateNoteAsync(string name, Note note, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNoteAsync(new UpdateNoteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> UpdateNoteAsync(string name, Note note, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNoteAsync(name, note, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Note UpdateNote(NoteName name, Note note, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNote(new UpdateNoteRequest
            {
                NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> UpdateNoteAsync(NoteName name, Note note, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNoteAsync(new UpdateNoteRequest
            {
                NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Note = gax::GaxPreconditions.CheckNotNull(note, nameof(note)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="note">
        /// The updated note.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Note> UpdateNoteAsync(NoteName name, Note note, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNoteAsync(name, note, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrences(ListNoteOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrencesAsync(ListNoteOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrences(string name, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNoteOccurrencesRequest request = new ListNoteOccurrencesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
            return ListNoteOccurrences(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrencesAsync(string name, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNoteOccurrencesRequest request = new ListNoteOccurrencesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
            return ListNoteOccurrencesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrences(NoteName name, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNoteOccurrencesRequest request = new ListNoteOccurrencesRequest
            {
                NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
            return ListNoteOccurrences(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="name">
        /// The name of the note to list occurrences for in the form of
        /// `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
        /// </param>
        /// <param name="filter">
        /// The filter expression.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Occurrence"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrencesAsync(NoteName name, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNoteOccurrencesRequest request = new ListNoteOccurrencesRequest
            {
                NoteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
            return ListNoteOccurrencesAsync(request, callSettings);
        }
    }

    /// <summary>Grafeas client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// [Grafeas](https://grafeas.io) API.
    /// 
    /// Retrieves analysis results of Cloud components such as Docker container
    /// images.
    /// 
    /// Analysis results are stored as a series of occurrences. An `Occurrence`
    /// contains information about a specific analysis instance on a resource. An
    /// occurrence refers to a `Note`. A note contains details describing the
    /// analysis and is generally stored in a separate project, called a `Provider`.
    /// Multiple occurrences can refer to the same note.
    /// 
    /// For example, an SSL vulnerability could affect multiple images. In this case,
    /// there would be one note for the vulnerability and an occurrence for each
    /// image with the vulnerability referring to that note.
    /// </remarks>
    public sealed partial class GrafeasClientImpl : GrafeasClient
    {
        private readonly gaxgrpc::ApiCall<GetOccurrenceRequest, Occurrence> _callGetOccurrence;

        private readonly gaxgrpc::ApiCall<ListOccurrencesRequest, ListOccurrencesResponse> _callListOccurrences;

        private readonly gaxgrpc::ApiCall<DeleteOccurrenceRequest, wkt::Empty> _callDeleteOccurrence;

        private readonly gaxgrpc::ApiCall<CreateOccurrenceRequest, Occurrence> _callCreateOccurrence;

        private readonly gaxgrpc::ApiCall<BatchCreateOccurrencesRequest, BatchCreateOccurrencesResponse> _callBatchCreateOccurrences;

        private readonly gaxgrpc::ApiCall<UpdateOccurrenceRequest, Occurrence> _callUpdateOccurrence;

        private readonly gaxgrpc::ApiCall<GetOccurrenceNoteRequest, Note> _callGetOccurrenceNote;

        private readonly gaxgrpc::ApiCall<GetNoteRequest, Note> _callGetNote;

        private readonly gaxgrpc::ApiCall<ListNotesRequest, ListNotesResponse> _callListNotes;

        private readonly gaxgrpc::ApiCall<DeleteNoteRequest, wkt::Empty> _callDeleteNote;

        private readonly gaxgrpc::ApiCall<CreateNoteRequest, Note> _callCreateNote;

        private readonly gaxgrpc::ApiCall<BatchCreateNotesRequest, BatchCreateNotesResponse> _callBatchCreateNotes;

        private readonly gaxgrpc::ApiCall<UpdateNoteRequest, Note> _callUpdateNote;

        private readonly gaxgrpc::ApiCall<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse> _callListNoteOccurrences;

        /// <summary>
        /// Constructs a client wrapper for the Grafeas service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GrafeasSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GrafeasClientImpl(Grafeas.GrafeasClient grpcClient, GrafeasSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GrafeasSettings effectiveSettings = settings ?? GrafeasSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetOccurrence = clientHelper.BuildApiCall<GetOccurrenceRequest, Occurrence>("GetOccurrence", grpcClient.GetOccurrenceAsync, grpcClient.GetOccurrence, effectiveSettings.GetOccurrenceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOccurrence);
            Modify_GetOccurrenceApiCall(ref _callGetOccurrence);
            _callListOccurrences = clientHelper.BuildApiCall<ListOccurrencesRequest, ListOccurrencesResponse>("ListOccurrences", grpcClient.ListOccurrencesAsync, grpcClient.ListOccurrences, effectiveSettings.ListOccurrencesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOccurrences);
            Modify_ListOccurrencesApiCall(ref _callListOccurrences);
            _callDeleteOccurrence = clientHelper.BuildApiCall<DeleteOccurrenceRequest, wkt::Empty>("DeleteOccurrence", grpcClient.DeleteOccurrenceAsync, grpcClient.DeleteOccurrence, effectiveSettings.DeleteOccurrenceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteOccurrence);
            Modify_DeleteOccurrenceApiCall(ref _callDeleteOccurrence);
            _callCreateOccurrence = clientHelper.BuildApiCall<CreateOccurrenceRequest, Occurrence>("CreateOccurrence", grpcClient.CreateOccurrenceAsync, grpcClient.CreateOccurrence, effectiveSettings.CreateOccurrenceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOccurrence);
            Modify_CreateOccurrenceApiCall(ref _callCreateOccurrence);
            _callBatchCreateOccurrences = clientHelper.BuildApiCall<BatchCreateOccurrencesRequest, BatchCreateOccurrencesResponse>("BatchCreateOccurrences", grpcClient.BatchCreateOccurrencesAsync, grpcClient.BatchCreateOccurrences, effectiveSettings.BatchCreateOccurrencesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateOccurrences);
            Modify_BatchCreateOccurrencesApiCall(ref _callBatchCreateOccurrences);
            _callUpdateOccurrence = clientHelper.BuildApiCall<UpdateOccurrenceRequest, Occurrence>("UpdateOccurrence", grpcClient.UpdateOccurrenceAsync, grpcClient.UpdateOccurrence, effectiveSettings.UpdateOccurrenceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateOccurrence);
            Modify_UpdateOccurrenceApiCall(ref _callUpdateOccurrence);
            _callGetOccurrenceNote = clientHelper.BuildApiCall<GetOccurrenceNoteRequest, Note>("GetOccurrenceNote", grpcClient.GetOccurrenceNoteAsync, grpcClient.GetOccurrenceNote, effectiveSettings.GetOccurrenceNoteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOccurrenceNote);
            Modify_GetOccurrenceNoteApiCall(ref _callGetOccurrenceNote);
            _callGetNote = clientHelper.BuildApiCall<GetNoteRequest, Note>("GetNote", grpcClient.GetNoteAsync, grpcClient.GetNote, effectiveSettings.GetNoteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNote);
            Modify_GetNoteApiCall(ref _callGetNote);
            _callListNotes = clientHelper.BuildApiCall<ListNotesRequest, ListNotesResponse>("ListNotes", grpcClient.ListNotesAsync, grpcClient.ListNotes, effectiveSettings.ListNotesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNotes);
            Modify_ListNotesApiCall(ref _callListNotes);
            _callDeleteNote = clientHelper.BuildApiCall<DeleteNoteRequest, wkt::Empty>("DeleteNote", grpcClient.DeleteNoteAsync, grpcClient.DeleteNote, effectiveSettings.DeleteNoteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNote);
            Modify_DeleteNoteApiCall(ref _callDeleteNote);
            _callCreateNote = clientHelper.BuildApiCall<CreateNoteRequest, Note>("CreateNote", grpcClient.CreateNoteAsync, grpcClient.CreateNote, effectiveSettings.CreateNoteSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNote);
            Modify_CreateNoteApiCall(ref _callCreateNote);
            _callBatchCreateNotes = clientHelper.BuildApiCall<BatchCreateNotesRequest, BatchCreateNotesResponse>("BatchCreateNotes", grpcClient.BatchCreateNotesAsync, grpcClient.BatchCreateNotes, effectiveSettings.BatchCreateNotesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateNotes);
            Modify_BatchCreateNotesApiCall(ref _callBatchCreateNotes);
            _callUpdateNote = clientHelper.BuildApiCall<UpdateNoteRequest, Note>("UpdateNote", grpcClient.UpdateNoteAsync, grpcClient.UpdateNote, effectiveSettings.UpdateNoteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateNote);
            Modify_UpdateNoteApiCall(ref _callUpdateNote);
            _callListNoteOccurrences = clientHelper.BuildApiCall<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse>("ListNoteOccurrences", grpcClient.ListNoteOccurrencesAsync, grpcClient.ListNoteOccurrences, effectiveSettings.ListNoteOccurrencesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListNoteOccurrences);
            Modify_ListNoteOccurrencesApiCall(ref _callListNoteOccurrences);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetOccurrenceApiCall(ref gaxgrpc::ApiCall<GetOccurrenceRequest, Occurrence> call);

        partial void Modify_ListOccurrencesApiCall(ref gaxgrpc::ApiCall<ListOccurrencesRequest, ListOccurrencesResponse> call);

        partial void Modify_DeleteOccurrenceApiCall(ref gaxgrpc::ApiCall<DeleteOccurrenceRequest, wkt::Empty> call);

        partial void Modify_CreateOccurrenceApiCall(ref gaxgrpc::ApiCall<CreateOccurrenceRequest, Occurrence> call);

        partial void Modify_BatchCreateOccurrencesApiCall(ref gaxgrpc::ApiCall<BatchCreateOccurrencesRequest, BatchCreateOccurrencesResponse> call);

        partial void Modify_UpdateOccurrenceApiCall(ref gaxgrpc::ApiCall<UpdateOccurrenceRequest, Occurrence> call);

        partial void Modify_GetOccurrenceNoteApiCall(ref gaxgrpc::ApiCall<GetOccurrenceNoteRequest, Note> call);

        partial void Modify_GetNoteApiCall(ref gaxgrpc::ApiCall<GetNoteRequest, Note> call);

        partial void Modify_ListNotesApiCall(ref gaxgrpc::ApiCall<ListNotesRequest, ListNotesResponse> call);

        partial void Modify_DeleteNoteApiCall(ref gaxgrpc::ApiCall<DeleteNoteRequest, wkt::Empty> call);

        partial void Modify_CreateNoteApiCall(ref gaxgrpc::ApiCall<CreateNoteRequest, Note> call);

        partial void Modify_BatchCreateNotesApiCall(ref gaxgrpc::ApiCall<BatchCreateNotesRequest, BatchCreateNotesResponse> call);

        partial void Modify_UpdateNoteApiCall(ref gaxgrpc::ApiCall<UpdateNoteRequest, Note> call);

        partial void Modify_ListNoteOccurrencesApiCall(ref gaxgrpc::ApiCall<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse> call);

        partial void OnConstruction(Grafeas.GrafeasClient grpcClient, GrafeasSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Grafeas client</summary>
        public override Grafeas.GrafeasClient GrpcClient { get; }

        partial void Modify_GetOccurrenceRequest(ref GetOccurrenceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOccurrencesRequest(ref ListOccurrencesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteOccurrenceRequest(ref DeleteOccurrenceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateOccurrenceRequest(ref CreateOccurrenceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateOccurrencesRequest(ref BatchCreateOccurrencesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateOccurrenceRequest(ref UpdateOccurrenceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOccurrenceNoteRequest(ref GetOccurrenceNoteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNoteRequest(ref GetNoteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNotesRequest(ref ListNotesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNoteRequest(ref DeleteNoteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateNoteRequest(ref CreateNoteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateNotesRequest(ref BatchCreateNotesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNoteRequest(ref UpdateNoteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNoteOccurrencesRequest(ref ListNoteOccurrencesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Occurrence GetOccurrence(GetOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceRequest(ref request, ref callSettings);
            return _callGetOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Occurrence> GetOccurrenceAsync(GetOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceRequest(ref request, ref callSettings);
            return _callGetOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Occurrence"/> resources.</returns>
        public override gax::PagedEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrences(ListOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOccurrencesRequest, ListOccurrencesResponse, Occurrence>(_callListOccurrences, request, callSettings);
        }

        /// <summary>
        /// Lists occurrences for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Occurrence"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOccurrencesResponse, Occurrence> ListOccurrencesAsync(ListOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOccurrencesRequest, ListOccurrencesResponse, Occurrence>(_callListOccurrences, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteOccurrence(DeleteOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOccurrenceRequest(ref request, ref callSettings);
            _callDeleteOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified occurrence. For example, use this method to delete an
        /// occurrence when the occurrence is no longer applicable for the given
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteOccurrenceAsync(DeleteOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOccurrenceRequest(ref request, ref callSettings);
            return _callDeleteOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Occurrence CreateOccurrence(CreateOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOccurrenceRequest(ref request, ref callSettings);
            return _callCreateOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Occurrence> CreateOccurrenceAsync(CreateOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOccurrenceRequest(ref request, ref callSettings);
            return _callCreateOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateOccurrencesResponse BatchCreateOccurrences(BatchCreateOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateOccurrencesRequest(ref request, ref callSettings);
            return _callBatchCreateOccurrences.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates new occurrences in batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateOccurrencesResponse> BatchCreateOccurrencesAsync(BatchCreateOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateOccurrencesRequest(ref request, ref callSettings);
            return _callBatchCreateOccurrences.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Occurrence UpdateOccurrence(UpdateOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOccurrenceRequest(ref request, ref callSettings);
            return _callUpdateOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified occurrence.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Occurrence> UpdateOccurrenceAsync(UpdateOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOccurrenceRequest(ref request, ref callSettings);
            return _callUpdateOccurrence.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Note GetOccurrenceNote(GetOccurrenceNoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceNoteRequest(ref request, ref callSettings);
            return _callGetOccurrenceNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the note attached to the specified occurrence. Consumer projects can
        /// use this method to get a note that belongs to a provider project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Note> GetOccurrenceNoteAsync(GetOccurrenceNoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOccurrenceNoteRequest(ref request, ref callSettings);
            return _callGetOccurrenceNote.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Note GetNote(GetNoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNoteRequest(ref request, ref callSettings);
            return _callGetNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Note> GetNoteAsync(GetNoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNoteRequest(ref request, ref callSettings);
            return _callGetNote.Async(request, callSettings);
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Note"/> resources.</returns>
        public override gax::PagedEnumerable<ListNotesResponse, Note> ListNotes(ListNotesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotesRequest, ListNotesResponse, Note>(_callListNotes, request, callSettings);
        }

        /// <summary>
        /// Lists notes for the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Note"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNotesResponse, Note> ListNotesAsync(ListNotesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotesRequest, ListNotesResponse, Note>(_callListNotes, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteNote(DeleteNoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNoteRequest(ref request, ref callSettings);
            _callDeleteNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteNoteAsync(DeleteNoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNoteRequest(ref request, ref callSettings);
            return _callDeleteNote.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Note CreateNote(CreateNoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNoteRequest(ref request, ref callSettings);
            return _callCreateNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Note> CreateNoteAsync(CreateNoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNoteRequest(ref request, ref callSettings);
            return _callCreateNote.Async(request, callSettings);
        }

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateNotesResponse BatchCreateNotes(BatchCreateNotesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateNotesRequest(ref request, ref callSettings);
            return _callBatchCreateNotes.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates new notes in batch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateNotesResponse> BatchCreateNotesAsync(BatchCreateNotesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateNotesRequest(ref request, ref callSettings);
            return _callBatchCreateNotes.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Note UpdateNote(UpdateNoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNoteRequest(ref request, ref callSettings);
            return _callUpdateNote.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Note> UpdateNoteAsync(UpdateNoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNoteRequest(ref request, ref callSettings);
            return _callUpdateNote.Async(request, callSettings);
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Occurrence"/> resources.</returns>
        public override gax::PagedEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrences(ListNoteOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNoteOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse, Occurrence>(_callListNoteOccurrences, request, callSettings);
        }

        /// <summary>
        /// Lists occurrences referencing the specified note. Provider projects can use
        /// this method to get all occurrences across consumer projects referencing the
        /// specified note.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Occurrence"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNoteOccurrencesResponse, Occurrence> ListNoteOccurrencesAsync(ListNoteOccurrencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNoteOccurrencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNoteOccurrencesRequest, ListNoteOccurrencesResponse, Occurrence>(_callListNoteOccurrences, request, callSettings);
        }
    }

    public partial class ListOccurrencesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNotesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNoteOccurrencesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOccurrencesResponse : gaxgrpc::IPageResponse<Occurrence>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Occurrence> GetEnumerator() => Occurrences.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNotesResponse : gaxgrpc::IPageResponse<Note>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Note> GetEnumerator() => Notes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNoteOccurrencesResponse : gaxgrpc::IPageResponse<Occurrence>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Occurrence> GetEnumerator() => Occurrences.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
