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
using gagr = Google.Api.Gax.ResourceNames;
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

namespace Google.Cloud.Speech.V1P1Beta1
{
    /// <summary>Settings for <see cref="AdaptationClient"/> instances.</summary>
    public sealed partial class AdaptationSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdaptationSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdaptationSettings"/>.</returns>
        public static AdaptationSettings GetDefault() => new AdaptationSettings();

        /// <summary>Constructs a new <see cref="AdaptationSettings"/> object with default settings.</summary>
        public AdaptationSettings()
        {
        }

        private AdaptationSettings(AdaptationSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreatePhraseSetSettings = existing.CreatePhraseSetSettings;
            GetPhraseSetSettings = existing.GetPhraseSetSettings;
            ListPhraseSetSettings = existing.ListPhraseSetSettings;
            UpdatePhraseSetSettings = existing.UpdatePhraseSetSettings;
            DeletePhraseSetSettings = existing.DeletePhraseSetSettings;
            CreateCustomClassSettings = existing.CreateCustomClassSettings;
            GetCustomClassSettings = existing.GetCustomClassSettings;
            ListCustomClassesSettings = existing.ListCustomClassesSettings;
            UpdateCustomClassSettings = existing.UpdateCustomClassSettings;
            DeleteCustomClassSettings = existing.DeleteCustomClassSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdaptationSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdaptationClient.CreatePhraseSet</c> and <c>AdaptationClient.CreatePhraseSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePhraseSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdaptationClient.GetPhraseSet</c> and <c>AdaptationClient.GetPhraseSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPhraseSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdaptationClient.ListPhraseSet</c> and <c>AdaptationClient.ListPhraseSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPhraseSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdaptationClient.UpdatePhraseSet</c> and <c>AdaptationClient.UpdatePhraseSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePhraseSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdaptationClient.DeletePhraseSet</c> and <c>AdaptationClient.DeletePhraseSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePhraseSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdaptationClient.CreateCustomClass</c> and <c>AdaptationClient.CreateCustomClassAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCustomClassSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdaptationClient.GetCustomClass</c> and <c>AdaptationClient.GetCustomClassAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomClassSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdaptationClient.ListCustomClasses</c> and <c>AdaptationClient.ListCustomClassesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomClassesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdaptationClient.UpdateCustomClass</c> and <c>AdaptationClient.UpdateCustomClassAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCustomClassSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdaptationClient.DeleteCustomClass</c> and <c>AdaptationClient.DeleteCustomClassAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCustomClassSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdaptationSettings"/> object.</returns>
        public AdaptationSettings Clone() => new AdaptationSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdaptationClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AdaptationClientBuilder : gaxgrpc::ClientBuilderBase<AdaptationClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdaptationSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdaptationClientBuilder() : base(AdaptationClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdaptationClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdaptationClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdaptationClient Build()
        {
            AdaptationClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdaptationClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdaptationClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdaptationClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdaptationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdaptationClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdaptationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdaptationClient.ChannelPool;
    }

    /// <summary>Adaptation client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service that implements Google Cloud Speech Adaptation API.
    /// </remarks>
    public abstract partial class AdaptationClient
    {
        /// <summary>
        /// The default endpoint for the Adaptation service, which is a host of "speech.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "speech.googleapis.com:443";

        /// <summary>The default Adaptation scopes.</summary>
        /// <remarks>
        /// The default Adaptation scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Adaptation.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdaptationClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdaptationClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdaptationClient"/>.</returns>
        public static stt::Task<AdaptationClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdaptationClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdaptationClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="AdaptationClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdaptationClient"/>.</returns>
        public static AdaptationClient Create() => new AdaptationClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdaptationClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdaptationSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdaptationClient"/>.</returns>
        internal static AdaptationClient Create(grpccore::CallInvoker callInvoker, AdaptationSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Adaptation.AdaptationClient grpcClient = new Adaptation.AdaptationClient(callInvoker);
            return new AdaptationClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Adaptation client</summary>
        public virtual Adaptation.AdaptationClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a set of phrase hints. Each item in the set can be a single word or
        /// a multi-word phrase. The items in the PhraseSet are favored by the
        /// recognition model when you send a call that includes the PhraseSet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseSet CreatePhraseSet(CreatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a set of phrase hints. Each item in the set can be a single word or
        /// a multi-word phrase. The items in the PhraseSet are favored by the
        /// recognition model when you send a call that includes the PhraseSet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> CreatePhraseSetAsync(CreatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a set of phrase hints. Each item in the set can be a single word or
        /// a multi-word phrase. The items in the PhraseSet are favored by the
        /// recognition model when you send a call that includes the PhraseSet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> CreatePhraseSetAsync(CreatePhraseSetRequest request, st::CancellationToken cancellationToken) =>
            CreatePhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a set of phrase hints. Each item in the set can be a single word or
        /// a multi-word phrase. The items in the PhraseSet are favored by the
        /// recognition model when you send a call that includes the PhraseSet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this phrase set will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The phrase set to create.
        /// </param>
        /// <param name="phraseSetId">
        /// Required. The ID to use for the phrase set, which will become the final
        /// component of the phrase set's resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseSet CreatePhraseSet(string parent, PhraseSet phraseSet, string phraseSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseSet(new CreatePhraseSetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PhraseSetId = gax::GaxPreconditions.CheckNotNullOrEmpty(phraseSetId, nameof(phraseSetId)),
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
            }, callSettings);

        /// <summary>
        /// Create a set of phrase hints. Each item in the set can be a single word or
        /// a multi-word phrase. The items in the PhraseSet are favored by the
        /// recognition model when you send a call that includes the PhraseSet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this phrase set will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The phrase set to create.
        /// </param>
        /// <param name="phraseSetId">
        /// Required. The ID to use for the phrase set, which will become the final
        /// component of the phrase set's resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> CreatePhraseSetAsync(string parent, PhraseSet phraseSet, string phraseSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseSetAsync(new CreatePhraseSetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PhraseSetId = gax::GaxPreconditions.CheckNotNullOrEmpty(phraseSetId, nameof(phraseSetId)),
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
            }, callSettings);

        /// <summary>
        /// Create a set of phrase hints. Each item in the set can be a single word or
        /// a multi-word phrase. The items in the PhraseSet are favored by the
        /// recognition model when you send a call that includes the PhraseSet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this phrase set will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The phrase set to create.
        /// </param>
        /// <param name="phraseSetId">
        /// Required. The ID to use for the phrase set, which will become the final
        /// component of the phrase set's resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> CreatePhraseSetAsync(string parent, PhraseSet phraseSet, string phraseSetId, st::CancellationToken cancellationToken) =>
            CreatePhraseSetAsync(parent, phraseSet, phraseSetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a set of phrase hints. Each item in the set can be a single word or
        /// a multi-word phrase. The items in the PhraseSet are favored by the
        /// recognition model when you send a call that includes the PhraseSet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this phrase set will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The phrase set to create.
        /// </param>
        /// <param name="phraseSetId">
        /// Required. The ID to use for the phrase set, which will become the final
        /// component of the phrase set's resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseSet CreatePhraseSet(gagr::LocationName parent, PhraseSet phraseSet, string phraseSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseSet(new CreatePhraseSetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PhraseSetId = gax::GaxPreconditions.CheckNotNullOrEmpty(phraseSetId, nameof(phraseSetId)),
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
            }, callSettings);

        /// <summary>
        /// Create a set of phrase hints. Each item in the set can be a single word or
        /// a multi-word phrase. The items in the PhraseSet are favored by the
        /// recognition model when you send a call that includes the PhraseSet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this phrase set will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The phrase set to create.
        /// </param>
        /// <param name="phraseSetId">
        /// Required. The ID to use for the phrase set, which will become the final
        /// component of the phrase set's resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> CreatePhraseSetAsync(gagr::LocationName parent, PhraseSet phraseSet, string phraseSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseSetAsync(new CreatePhraseSetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PhraseSetId = gax::GaxPreconditions.CheckNotNullOrEmpty(phraseSetId, nameof(phraseSetId)),
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
            }, callSettings);

        /// <summary>
        /// Create a set of phrase hints. Each item in the set can be a single word or
        /// a multi-word phrase. The items in the PhraseSet are favored by the
        /// recognition model when you send a call that includes the PhraseSet.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this phrase set will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The phrase set to create.
        /// </param>
        /// <param name="phraseSetId">
        /// Required. The ID to use for the phrase set, which will become the final
        /// component of the phrase set's resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> CreatePhraseSetAsync(gagr::LocationName parent, PhraseSet phraseSet, string phraseSetId, st::CancellationToken cancellationToken) =>
            CreatePhraseSetAsync(parent, phraseSet, phraseSetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseSet GetPhraseSet(GetPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(GetPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(GetPhraseSetRequest request, st::CancellationToken cancellationToken) =>
            GetPhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseSet GetPhraseSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseSet(new GetPhraseSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseSetAsync(new GetPhraseSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(string name, st::CancellationToken cancellationToken) =>
            GetPhraseSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseSet GetPhraseSet(PhraseSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseSet(new GetPhraseSetRequest
            {
                PhraseSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(PhraseSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseSetAsync(new GetPhraseSetRequest
            {
                PhraseSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(PhraseSetName name, st::CancellationToken cancellationToken) =>
            GetPhraseSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List phrase sets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseSetResponse, PhraseSet> ListPhraseSet(ListPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List phrase sets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseSetResponse, PhraseSet> ListPhraseSetAsync(ListPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List phrase sets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of phrase set. Format:
        /// 
        /// `projects/{project}/locations/{location}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
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
        /// <returns>A pageable sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseSetResponse, PhraseSet> ListPhraseSet(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseSetRequest request = new ListPhraseSetRequest
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
            return ListPhraseSet(request, callSettings);
        }

        /// <summary>
        /// List phrase sets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of phrase set. Format:
        /// 
        /// `projects/{project}/locations/{location}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseSetResponse, PhraseSet> ListPhraseSetAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseSetRequest request = new ListPhraseSetRequest
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
            return ListPhraseSetAsync(request, callSettings);
        }

        /// <summary>
        /// List phrase sets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of phrase set. Format:
        /// 
        /// `projects/{project}/locations/{location}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
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
        /// <returns>A pageable sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseSetResponse, PhraseSet> ListPhraseSet(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseSetRequest request = new ListPhraseSetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPhraseSet(request, callSettings);
        }

        /// <summary>
        /// List phrase sets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of phrase set. Format:
        /// 
        /// `projects/{project}/locations/{location}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseSetResponse, PhraseSet> ListPhraseSetAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseSetRequest request = new ListPhraseSetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPhraseSetAsync(request, callSettings);
        }

        /// <summary>
        /// Update a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseSet UpdatePhraseSet(UpdatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> UpdatePhraseSetAsync(UpdatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> UpdatePhraseSetAsync(UpdatePhraseSetRequest request, st::CancellationToken cancellationToken) =>
            UpdatePhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a phrase set.
        /// </summary>
        /// <param name="phraseSet">
        /// Required. The phrase set to update.
        /// 
        /// The phrase set's `name` field is used to identify the set to be
        /// updated. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseSet UpdatePhraseSet(PhraseSet phraseSet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhraseSet(new UpdatePhraseSetRequest
            {
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a phrase set.
        /// </summary>
        /// <param name="phraseSet">
        /// Required. The phrase set to update.
        /// 
        /// The phrase set's `name` field is used to identify the set to be
        /// updated. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> UpdatePhraseSetAsync(PhraseSet phraseSet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhraseSetAsync(new UpdatePhraseSetRequest
            {
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a phrase set.
        /// </summary>
        /// <param name="phraseSet">
        /// Required. The phrase set to update.
        /// 
        /// The phrase set's `name` field is used to identify the set to be
        /// updated. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> UpdatePhraseSetAsync(PhraseSet phraseSet, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePhraseSetAsync(phraseSet, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePhraseSet(DeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseSetAsync(DeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseSetAsync(DeletePhraseSetRequest request, st::CancellationToken cancellationToken) =>
            DeletePhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePhraseSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseSet(new DeletePhraseSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseSetAsync(new DeletePhraseSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseSetAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePhraseSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePhraseSet(PhraseSetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseSet(new DeletePhraseSetRequest
            {
                PhraseSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseSetAsync(PhraseSetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseSetAsync(new DeletePhraseSetRequest
            {
                PhraseSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a phrase set.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the phrase set to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhraseSetAsync(PhraseSetName name, st::CancellationToken cancellationToken) =>
            DeletePhraseSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomClass CreateCustomClass(CreateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> CreateCustomClassAsync(CreateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> CreateCustomClassAsync(CreateCustomClassRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a custom class.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this custom class will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="customClass">
        /// Required. The custom class to create.
        /// </param>
        /// <param name="customClassId">
        /// Required. The ID to use for the custom class, which will become the final
        /// component of the custom class' resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomClass CreateCustomClass(string parent, CustomClass customClass, string customClassId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomClass(new CreateCustomClassRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomClassId = gax::GaxPreconditions.CheckNotNullOrEmpty(customClassId, nameof(customClassId)),
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
            }, callSettings);

        /// <summary>
        /// Create a custom class.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this custom class will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="customClass">
        /// Required. The custom class to create.
        /// </param>
        /// <param name="customClassId">
        /// Required. The ID to use for the custom class, which will become the final
        /// component of the custom class' resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> CreateCustomClassAsync(string parent, CustomClass customClass, string customClassId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomClassAsync(new CreateCustomClassRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomClassId = gax::GaxPreconditions.CheckNotNullOrEmpty(customClassId, nameof(customClassId)),
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
            }, callSettings);

        /// <summary>
        /// Create a custom class.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this custom class will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="customClass">
        /// Required. The custom class to create.
        /// </param>
        /// <param name="customClassId">
        /// Required. The ID to use for the custom class, which will become the final
        /// component of the custom class' resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> CreateCustomClassAsync(string parent, CustomClass customClass, string customClassId, st::CancellationToken cancellationToken) =>
            CreateCustomClassAsync(parent, customClass, customClassId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a custom class.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this custom class will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="customClass">
        /// Required. The custom class to create.
        /// </param>
        /// <param name="customClassId">
        /// Required. The ID to use for the custom class, which will become the final
        /// component of the custom class' resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomClass CreateCustomClass(gagr::LocationName parent, CustomClass customClass, string customClassId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomClass(new CreateCustomClassRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomClassId = gax::GaxPreconditions.CheckNotNullOrEmpty(customClassId, nameof(customClassId)),
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
            }, callSettings);

        /// <summary>
        /// Create a custom class.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this custom class will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="customClass">
        /// Required. The custom class to create.
        /// </param>
        /// <param name="customClassId">
        /// Required. The ID to use for the custom class, which will become the final
        /// component of the custom class' resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> CreateCustomClassAsync(gagr::LocationName parent, CustomClass customClass, string customClassId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomClassAsync(new CreateCustomClassRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomClassId = gax::GaxPreconditions.CheckNotNullOrEmpty(customClassId, nameof(customClassId)),
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
            }, callSettings);

        /// <summary>
        /// Create a custom class.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this custom class will be created.
        /// Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="customClass">
        /// Required. The custom class to create.
        /// </param>
        /// <param name="customClassId">
        /// Required. The ID to use for the custom class, which will become the final
        /// component of the custom class' resource name.
        /// 
        /// This value should restrict to letters, numbers, and hyphens, with the first
        /// character a letter, the last a letter or a number, and be 4-63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> CreateCustomClassAsync(gagr::LocationName parent, CustomClass customClass, string customClassId, st::CancellationToken cancellationToken) =>
            CreateCustomClassAsync(parent, customClass, customClassId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomClass GetCustomClass(GetCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(GetCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(GetCustomClassRequest request, st::CancellationToken cancellationToken) =>
            GetCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomClass GetCustomClass(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomClass(new GetCustomClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomClassAsync(new GetCustomClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomClass GetCustomClass(CustomClassName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomClass(new GetCustomClassRequest
            {
                CustomClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(CustomClassName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomClassAsync(new GetCustomClassRequest
            {
                CustomClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to retrieve. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(CustomClassName name, st::CancellationToken cancellationToken) =>
            GetCustomClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List custom classes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClasses(ListCustomClassesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List custom classes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClassesAsync(ListCustomClassesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List custom classes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of custom classes. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
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
        /// <returns>A pageable sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClasses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomClassesRequest request = new ListCustomClassesRequest
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
            return ListCustomClasses(request, callSettings);
        }

        /// <summary>
        /// List custom classes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of custom classes. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClassesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomClassesRequest request = new ListCustomClassesRequest
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
            return ListCustomClassesAsync(request, callSettings);
        }

        /// <summary>
        /// List custom classes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of custom classes. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
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
        /// <returns>A pageable sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClasses(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomClassesRequest request = new ListCustomClassesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomClasses(request, callSettings);
        }

        /// <summary>
        /// List custom classes.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of custom classes. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClassesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomClassesRequest request = new ListCustomClassesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomClassesAsync(request, callSettings);
        }

        /// <summary>
        /// Update a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomClass UpdateCustomClass(UpdateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> UpdateCustomClassAsync(UpdateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> UpdateCustomClassAsync(UpdateCustomClassRequest request, st::CancellationToken cancellationToken) =>
            UpdateCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a custom class.
        /// </summary>
        /// <param name="customClass">
        /// Required. The custom class to update.
        /// 
        /// The custom class's `name` field is used to identify the custom class to be
        /// updated. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomClass UpdateCustomClass(CustomClass customClass, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomClass(new UpdateCustomClassRequest
            {
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a custom class.
        /// </summary>
        /// <param name="customClass">
        /// Required. The custom class to update.
        /// 
        /// The custom class's `name` field is used to identify the custom class to be
        /// updated. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> UpdateCustomClassAsync(CustomClass customClass, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomClassAsync(new UpdateCustomClassRequest
            {
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a custom class.
        /// </summary>
        /// <param name="customClass">
        /// Required. The custom class to update.
        /// 
        /// The custom class's `name` field is used to identify the custom class to be
        /// updated. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> UpdateCustomClassAsync(CustomClass customClass, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCustomClassAsync(customClass, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomClass(DeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomClassAsync(DeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomClassAsync(DeleteCustomClassRequest request, st::CancellationToken cancellationToken) =>
            DeleteCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomClass(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomClass(new DeleteCustomClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomClassAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomClassAsync(new DeleteCustomClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomClassAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCustomClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomClass(CustomClassName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomClass(new DeleteCustomClassRequest
            {
                CustomClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomClassAsync(CustomClassName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomClassAsync(new DeleteCustomClassRequest
            {
                CustomClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a custom class.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the custom class to delete. Format:
        /// 
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// 
        /// Speech-to-Text supports three locations: `global`, `us` (US North America),
        /// and `eu` (Europe). If you are calling the `speech.googleapis.com`
        /// endpoint, use the `global` location. To specify a region, use a
        /// [regional endpoint](https://cloud.google.com/speech-to-text/docs/endpoints)
        /// with matching `us` or `eu` location value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomClassAsync(CustomClassName name, st::CancellationToken cancellationToken) =>
            DeleteCustomClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Adaptation client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service that implements Google Cloud Speech Adaptation API.
    /// </remarks>
    public sealed partial class AdaptationClientImpl : AdaptationClient
    {
        private readonly gaxgrpc::ApiCall<CreatePhraseSetRequest, PhraseSet> _callCreatePhraseSet;

        private readonly gaxgrpc::ApiCall<GetPhraseSetRequest, PhraseSet> _callGetPhraseSet;

        private readonly gaxgrpc::ApiCall<ListPhraseSetRequest, ListPhraseSetResponse> _callListPhraseSet;

        private readonly gaxgrpc::ApiCall<UpdatePhraseSetRequest, PhraseSet> _callUpdatePhraseSet;

        private readonly gaxgrpc::ApiCall<DeletePhraseSetRequest, wkt::Empty> _callDeletePhraseSet;

        private readonly gaxgrpc::ApiCall<CreateCustomClassRequest, CustomClass> _callCreateCustomClass;

        private readonly gaxgrpc::ApiCall<GetCustomClassRequest, CustomClass> _callGetCustomClass;

        private readonly gaxgrpc::ApiCall<ListCustomClassesRequest, ListCustomClassesResponse> _callListCustomClasses;

        private readonly gaxgrpc::ApiCall<UpdateCustomClassRequest, CustomClass> _callUpdateCustomClass;

        private readonly gaxgrpc::ApiCall<DeleteCustomClassRequest, wkt::Empty> _callDeleteCustomClass;

        /// <summary>
        /// Constructs a client wrapper for the Adaptation service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdaptationSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdaptationClientImpl(Adaptation.AdaptationClient grpcClient, AdaptationSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdaptationSettings effectiveSettings = settings ?? AdaptationSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreatePhraseSet = clientHelper.BuildApiCall<CreatePhraseSetRequest, PhraseSet>("CreatePhraseSet", grpcClient.CreatePhraseSetAsync, grpcClient.CreatePhraseSet, effectiveSettings.CreatePhraseSetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePhraseSet);
            Modify_CreatePhraseSetApiCall(ref _callCreatePhraseSet);
            _callGetPhraseSet = clientHelper.BuildApiCall<GetPhraseSetRequest, PhraseSet>("GetPhraseSet", grpcClient.GetPhraseSetAsync, grpcClient.GetPhraseSet, effectiveSettings.GetPhraseSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPhraseSet);
            Modify_GetPhraseSetApiCall(ref _callGetPhraseSet);
            _callListPhraseSet = clientHelper.BuildApiCall<ListPhraseSetRequest, ListPhraseSetResponse>("ListPhraseSet", grpcClient.ListPhraseSetAsync, grpcClient.ListPhraseSet, effectiveSettings.ListPhraseSetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPhraseSet);
            Modify_ListPhraseSetApiCall(ref _callListPhraseSet);
            _callUpdatePhraseSet = clientHelper.BuildApiCall<UpdatePhraseSetRequest, PhraseSet>("UpdatePhraseSet", grpcClient.UpdatePhraseSetAsync, grpcClient.UpdatePhraseSet, effectiveSettings.UpdatePhraseSetSettings).WithGoogleRequestParam("phrase_set.name", request => request.PhraseSet?.Name);
            Modify_ApiCall(ref _callUpdatePhraseSet);
            Modify_UpdatePhraseSetApiCall(ref _callUpdatePhraseSet);
            _callDeletePhraseSet = clientHelper.BuildApiCall<DeletePhraseSetRequest, wkt::Empty>("DeletePhraseSet", grpcClient.DeletePhraseSetAsync, grpcClient.DeletePhraseSet, effectiveSettings.DeletePhraseSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePhraseSet);
            Modify_DeletePhraseSetApiCall(ref _callDeletePhraseSet);
            _callCreateCustomClass = clientHelper.BuildApiCall<CreateCustomClassRequest, CustomClass>("CreateCustomClass", grpcClient.CreateCustomClassAsync, grpcClient.CreateCustomClass, effectiveSettings.CreateCustomClassSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCustomClass);
            Modify_CreateCustomClassApiCall(ref _callCreateCustomClass);
            _callGetCustomClass = clientHelper.BuildApiCall<GetCustomClassRequest, CustomClass>("GetCustomClass", grpcClient.GetCustomClassAsync, grpcClient.GetCustomClass, effectiveSettings.GetCustomClassSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomClass);
            Modify_GetCustomClassApiCall(ref _callGetCustomClass);
            _callListCustomClasses = clientHelper.BuildApiCall<ListCustomClassesRequest, ListCustomClassesResponse>("ListCustomClasses", grpcClient.ListCustomClassesAsync, grpcClient.ListCustomClasses, effectiveSettings.ListCustomClassesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomClasses);
            Modify_ListCustomClassesApiCall(ref _callListCustomClasses);
            _callUpdateCustomClass = clientHelper.BuildApiCall<UpdateCustomClassRequest, CustomClass>("UpdateCustomClass", grpcClient.UpdateCustomClassAsync, grpcClient.UpdateCustomClass, effectiveSettings.UpdateCustomClassSettings).WithGoogleRequestParam("custom_class.name", request => request.CustomClass?.Name);
            Modify_ApiCall(ref _callUpdateCustomClass);
            Modify_UpdateCustomClassApiCall(ref _callUpdateCustomClass);
            _callDeleteCustomClass = clientHelper.BuildApiCall<DeleteCustomClassRequest, wkt::Empty>("DeleteCustomClass", grpcClient.DeleteCustomClassAsync, grpcClient.DeleteCustomClass, effectiveSettings.DeleteCustomClassSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCustomClass);
            Modify_DeleteCustomClassApiCall(ref _callDeleteCustomClass);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreatePhraseSetApiCall(ref gaxgrpc::ApiCall<CreatePhraseSetRequest, PhraseSet> call);

        partial void Modify_GetPhraseSetApiCall(ref gaxgrpc::ApiCall<GetPhraseSetRequest, PhraseSet> call);

        partial void Modify_ListPhraseSetApiCall(ref gaxgrpc::ApiCall<ListPhraseSetRequest, ListPhraseSetResponse> call);

        partial void Modify_UpdatePhraseSetApiCall(ref gaxgrpc::ApiCall<UpdatePhraseSetRequest, PhraseSet> call);

        partial void Modify_DeletePhraseSetApiCall(ref gaxgrpc::ApiCall<DeletePhraseSetRequest, wkt::Empty> call);

        partial void Modify_CreateCustomClassApiCall(ref gaxgrpc::ApiCall<CreateCustomClassRequest, CustomClass> call);

        partial void Modify_GetCustomClassApiCall(ref gaxgrpc::ApiCall<GetCustomClassRequest, CustomClass> call);

        partial void Modify_ListCustomClassesApiCall(ref gaxgrpc::ApiCall<ListCustomClassesRequest, ListCustomClassesResponse> call);

        partial void Modify_UpdateCustomClassApiCall(ref gaxgrpc::ApiCall<UpdateCustomClassRequest, CustomClass> call);

        partial void Modify_DeleteCustomClassApiCall(ref gaxgrpc::ApiCall<DeleteCustomClassRequest, wkt::Empty> call);

        partial void OnConstruction(Adaptation.AdaptationClient grpcClient, AdaptationSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Adaptation client</summary>
        public override Adaptation.AdaptationClient GrpcClient { get; }

        partial void Modify_CreatePhraseSetRequest(ref CreatePhraseSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPhraseSetRequest(ref GetPhraseSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPhraseSetRequest(ref ListPhraseSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePhraseSetRequest(ref UpdatePhraseSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePhraseSetRequest(ref DeletePhraseSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomClassRequest(ref CreateCustomClassRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCustomClassRequest(ref GetCustomClassRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomClassesRequest(ref ListCustomClassesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCustomClassRequest(ref UpdateCustomClassRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCustomClassRequest(ref DeleteCustomClassRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a set of phrase hints. Each item in the set can be a single word or
        /// a multi-word phrase. The items in the PhraseSet are favored by the
        /// recognition model when you send a call that includes the PhraseSet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhraseSet CreatePhraseSet(CreatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhraseSetRequest(ref request, ref callSettings);
            return _callCreatePhraseSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a set of phrase hints. Each item in the set can be a single word or
        /// a multi-word phrase. The items in the PhraseSet are favored by the
        /// recognition model when you send a call that includes the PhraseSet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhraseSet> CreatePhraseSetAsync(CreatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhraseSetRequest(ref request, ref callSettings);
            return _callCreatePhraseSet.Async(request, callSettings);
        }

        /// <summary>
        /// Get a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhraseSet GetPhraseSet(GetPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhraseSetRequest(ref request, ref callSettings);
            return _callGetPhraseSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhraseSet> GetPhraseSetAsync(GetPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhraseSetRequest(ref request, ref callSettings);
            return _callGetPhraseSet.Async(request, callSettings);
        }

        /// <summary>
        /// List phrase sets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhraseSet"/> resources.</returns>
        public override gax::PagedEnumerable<ListPhraseSetResponse, PhraseSet> ListPhraseSet(ListPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhraseSetRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPhraseSetRequest, ListPhraseSetResponse, PhraseSet>(_callListPhraseSet, request, callSettings);
        }

        /// <summary>
        /// List phrase sets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseSet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPhraseSetResponse, PhraseSet> ListPhraseSetAsync(ListPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhraseSetRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPhraseSetRequest, ListPhraseSetResponse, PhraseSet>(_callListPhraseSet, request, callSettings);
        }

        /// <summary>
        /// Update a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhraseSet UpdatePhraseSet(UpdatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhraseSetRequest(ref request, ref callSettings);
            return _callUpdatePhraseSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhraseSet> UpdatePhraseSetAsync(UpdatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhraseSetRequest(ref request, ref callSettings);
            return _callUpdatePhraseSet.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePhraseSet(DeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhraseSetRequest(ref request, ref callSettings);
            _callDeletePhraseSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a phrase set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePhraseSetAsync(DeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhraseSetRequest(ref request, ref callSettings);
            return _callDeletePhraseSet.Async(request, callSettings);
        }

        /// <summary>
        /// Create a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomClass CreateCustomClass(CreateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomClassRequest(ref request, ref callSettings);
            return _callCreateCustomClass.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomClass> CreateCustomClassAsync(CreateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomClassRequest(ref request, ref callSettings);
            return _callCreateCustomClass.Async(request, callSettings);
        }

        /// <summary>
        /// Get a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomClass GetCustomClass(GetCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomClassRequest(ref request, ref callSettings);
            return _callGetCustomClass.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomClass> GetCustomClassAsync(GetCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomClassRequest(ref request, ref callSettings);
            return _callGetCustomClass.Async(request, callSettings);
        }

        /// <summary>
        /// List custom classes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomClass"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClasses(ListCustomClassesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomClassesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomClassesRequest, ListCustomClassesResponse, CustomClass>(_callListCustomClasses, request, callSettings);
        }

        /// <summary>
        /// List custom classes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomClass"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClassesAsync(ListCustomClassesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomClassesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomClassesRequest, ListCustomClassesResponse, CustomClass>(_callListCustomClasses, request, callSettings);
        }

        /// <summary>
        /// Update a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomClass UpdateCustomClass(UpdateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomClassRequest(ref request, ref callSettings);
            return _callUpdateCustomClass.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomClass> UpdateCustomClassAsync(UpdateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomClassRequest(ref request, ref callSettings);
            return _callUpdateCustomClass.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCustomClass(DeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomClassRequest(ref request, ref callSettings);
            _callDeleteCustomClass.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a custom class.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCustomClassAsync(DeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomClassRequest(ref request, ref callSettings);
            return _callDeleteCustomClass.Async(request, callSettings);
        }
    }

    public partial class ListPhraseSetRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomClassesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPhraseSetResponse : gaxgrpc::IPageResponse<PhraseSet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PhraseSet> GetEnumerator() => PhraseSets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCustomClassesResponse : gaxgrpc::IPageResponse<CustomClass>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CustomClass> GetEnumerator() => CustomClasses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
