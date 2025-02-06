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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.ApiKeys.V2
{
    /// <summary>Settings for <see cref="ApiKeysClient"/> instances.</summary>
    public sealed partial class ApiKeysSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ApiKeysSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ApiKeysSettings"/>.</returns>
        public static ApiKeysSettings GetDefault() => new ApiKeysSettings();

        /// <summary>Constructs a new <see cref="ApiKeysSettings"/> object with default settings.</summary>
        public ApiKeysSettings()
        {
        }

        private ApiKeysSettings(ApiKeysSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateKeySettings = existing.CreateKeySettings;
            CreateKeyOperationsSettings = existing.CreateKeyOperationsSettings.Clone();
            ListKeysSettings = existing.ListKeysSettings;
            GetKeySettings = existing.GetKeySettings;
            GetKeyStringSettings = existing.GetKeyStringSettings;
            UpdateKeySettings = existing.UpdateKeySettings;
            UpdateKeyOperationsSettings = existing.UpdateKeyOperationsSettings.Clone();
            DeleteKeySettings = existing.DeleteKeySettings;
            DeleteKeyOperationsSettings = existing.DeleteKeyOperationsSettings.Clone();
            UndeleteKeySettings = existing.UndeleteKeySettings;
            UndeleteKeyOperationsSettings = existing.UndeleteKeyOperationsSettings.Clone();
            LookupKeySettings = existing.LookupKeySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ApiKeysSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiKeysClient.CreateKey</c>
        /// and <c>ApiKeysClient.CreateKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiKeysClient.CreateKey</c> and
        /// <c>ApiKeysClient.CreateKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiKeysClient.ListKeys</c>
        /// and <c>ApiKeysClient.ListKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiKeysClient.GetKey</c>
        /// and <c>ApiKeysClient.GetKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiKeysClient.GetKeyString</c>
        ///  and <c>ApiKeysClient.GetKeyStringAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetKeyStringSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiKeysClient.UpdateKey</c>
        /// and <c>ApiKeysClient.UpdateKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiKeysClient.UpdateKey</c> and
        /// <c>ApiKeysClient.UpdateKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiKeysClient.DeleteKey</c>
        /// and <c>ApiKeysClient.DeleteKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiKeysClient.DeleteKey</c> and
        /// <c>ApiKeysClient.DeleteKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiKeysClient.UndeleteKey</c>
        ///  and <c>ApiKeysClient.UndeleteKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiKeysClient.UndeleteKey</c> and
        /// <c>ApiKeysClient.UndeleteKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UndeleteKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ApiKeysClient.LookupKey</c>
        /// and <c>ApiKeysClient.LookupKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LookupKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ApiKeysSettings"/> object.</returns>
        public ApiKeysSettings Clone() => new ApiKeysSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ApiKeysClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ApiKeysClientBuilder : gaxgrpc::ClientBuilderBase<ApiKeysClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ApiKeysSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ApiKeysClientBuilder() : base(ApiKeysClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ApiKeysClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ApiKeysClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ApiKeysClient Build()
        {
            ApiKeysClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ApiKeysClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ApiKeysClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ApiKeysClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ApiKeysClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ApiKeysClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ApiKeysClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ApiKeysClient.ChannelPool;
    }

    /// <summary>ApiKeys client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages the API keys associated with projects.
    /// </remarks>
    public abstract partial class ApiKeysClient
    {
        /// <summary>
        /// The default endpoint for the ApiKeys service, which is a host of "apikeys.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apikeys.googleapis.com:443";

        /// <summary>The default ApiKeys scopes.</summary>
        /// <remarks>
        /// The default ApiKeys scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ApiKeys.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ApiKeysClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="ApiKeysClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ApiKeysClient"/>.</returns>
        public static stt::Task<ApiKeysClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ApiKeysClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ApiKeysClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="ApiKeysClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ApiKeysClient"/>.</returns>
        public static ApiKeysClient Create() => new ApiKeysClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ApiKeysClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ApiKeysSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ApiKeysClient"/>.</returns>
        internal static ApiKeysClient Create(grpccore::CallInvoker callInvoker, ApiKeysSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ApiKeys.ApiKeysClient grpcClient = new ApiKeys.ApiKeysClient(callInvoker);
            return new ApiKeysClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ApiKeys client</summary>
        public virtual ApiKeys.ApiKeysClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Key, wkt::Empty> CreateKey(CreateKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> CreateKeyAsync(CreateKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> CreateKeyAsync(CreateKeyRequest request, st::CancellationToken cancellationToken) =>
            CreateKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateKey</c>.</summary>
        public virtual lro::OperationsClient CreateKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Key, wkt::Empty> PollOnceCreateKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Key, wkt::Empty>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> PollOnceCreateKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Key, wkt::Empty>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateKeyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the API key is created.
        /// </param>
        /// <param name="key">
        /// Required. The API key fields to set at creation time.
        /// You can configure only the `display_name`, `restrictions`, and
        /// `annotations` fields.
        /// </param>
        /// <param name="keyId">
        /// User specified key id (optional). If specified, it will become the final
        /// component of the key resource name.
        /// 
        /// The id must be unique within the project, must conform with RFC-1034,
        /// is restricted to lower-cased letters, and has a maximum length of 63
        /// characters. In another word, the id must match the regular
        /// expression: `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// 
        /// The id must NOT be a UUID-like string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Key, wkt::Empty> CreateKey(string parent, Key key, string keyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKey(new CreateKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Key = gax::GaxPreconditions.CheckNotNull(key, nameof(key)),
                KeyId = keyId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the API key is created.
        /// </param>
        /// <param name="key">
        /// Required. The API key fields to set at creation time.
        /// You can configure only the `display_name`, `restrictions`, and
        /// `annotations` fields.
        /// </param>
        /// <param name="keyId">
        /// User specified key id (optional). If specified, it will become the final
        /// component of the key resource name.
        /// 
        /// The id must be unique within the project, must conform with RFC-1034,
        /// is restricted to lower-cased letters, and has a maximum length of 63
        /// characters. In another word, the id must match the regular
        /// expression: `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// 
        /// The id must NOT be a UUID-like string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> CreateKeyAsync(string parent, Key key, string keyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKeyAsync(new CreateKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Key = gax::GaxPreconditions.CheckNotNull(key, nameof(key)),
                KeyId = keyId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the API key is created.
        /// </param>
        /// <param name="key">
        /// Required. The API key fields to set at creation time.
        /// You can configure only the `display_name`, `restrictions`, and
        /// `annotations` fields.
        /// </param>
        /// <param name="keyId">
        /// User specified key id (optional). If specified, it will become the final
        /// component of the key resource name.
        /// 
        /// The id must be unique within the project, must conform with RFC-1034,
        /// is restricted to lower-cased letters, and has a maximum length of 63
        /// characters. In another word, the id must match the regular
        /// expression: `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// 
        /// The id must NOT be a UUID-like string.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> CreateKeyAsync(string parent, Key key, string keyId, st::CancellationToken cancellationToken) =>
            CreateKeyAsync(parent, key, keyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the API key is created.
        /// </param>
        /// <param name="key">
        /// Required. The API key fields to set at creation time.
        /// You can configure only the `display_name`, `restrictions`, and
        /// `annotations` fields.
        /// </param>
        /// <param name="keyId">
        /// User specified key id (optional). If specified, it will become the final
        /// component of the key resource name.
        /// 
        /// The id must be unique within the project, must conform with RFC-1034,
        /// is restricted to lower-cased letters, and has a maximum length of 63
        /// characters. In another word, the id must match the regular
        /// expression: `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// 
        /// The id must NOT be a UUID-like string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Key, wkt::Empty> CreateKey(gagr::LocationName parent, Key key, string keyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKey(new CreateKeyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Key = gax::GaxPreconditions.CheckNotNull(key, nameof(key)),
                KeyId = keyId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the API key is created.
        /// </param>
        /// <param name="key">
        /// Required. The API key fields to set at creation time.
        /// You can configure only the `display_name`, `restrictions`, and
        /// `annotations` fields.
        /// </param>
        /// <param name="keyId">
        /// User specified key id (optional). If specified, it will become the final
        /// component of the key resource name.
        /// 
        /// The id must be unique within the project, must conform with RFC-1034,
        /// is restricted to lower-cased letters, and has a maximum length of 63
        /// characters. In another word, the id must match the regular
        /// expression: `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// 
        /// The id must NOT be a UUID-like string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> CreateKeyAsync(gagr::LocationName parent, Key key, string keyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKeyAsync(new CreateKeyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Key = gax::GaxPreconditions.CheckNotNull(key, nameof(key)),
                KeyId = keyId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the API key is created.
        /// </param>
        /// <param name="key">
        /// Required. The API key fields to set at creation time.
        /// You can configure only the `display_name`, `restrictions`, and
        /// `annotations` fields.
        /// </param>
        /// <param name="keyId">
        /// User specified key id (optional). If specified, it will become the final
        /// component of the key resource name.
        /// 
        /// The id must be unique within the project, must conform with RFC-1034,
        /// is restricted to lower-cased letters, and has a maximum length of 63
        /// characters. In another word, the id must match the regular
        /// expression: `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// 
        /// The id must NOT be a UUID-like string.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> CreateKeyAsync(gagr::LocationName parent, Key key, string keyId, st::CancellationToken cancellationToken) =>
            CreateKeyAsync(parent, key, keyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the API keys owned by a project. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Key"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKeysResponse, Key> ListKeys(ListKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the API keys owned by a project. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Key"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKeysResponse, Key> ListKeysAsync(ListKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the API keys owned by a project. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. Lists all API keys associated with this project.
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
        /// <returns>A pageable sequence of <see cref="Key"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKeysResponse, Key> ListKeys(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeysRequest request = new ListKeysRequest
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
            return ListKeys(request, callSettings);
        }

        /// <summary>
        /// Lists the API keys owned by a project. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. Lists all API keys associated with this project.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Key"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKeysResponse, Key> ListKeysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeysRequest request = new ListKeysRequest
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
            return ListKeysAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the API keys owned by a project. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. Lists all API keys associated with this project.
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
        /// <returns>A pageable sequence of <see cref="Key"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKeysResponse, Key> ListKeys(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeysRequest request = new ListKeysRequest
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
            return ListKeys(request, callSettings);
        }

        /// <summary>
        /// Lists the API keys owned by a project. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. Lists all API keys associated with this project.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Key"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKeysResponse, Key> ListKeysAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKeysRequest request = new ListKeysRequest
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
            return ListKeysAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Key GetKey(GetKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> GetKeyAsync(GetKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> GetKeyAsync(GetKeyRequest request, st::CancellationToken cancellationToken) =>
            GetKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Key GetKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKey(new GetKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> GetKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyAsync(new GetKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> GetKeyAsync(string name, st::CancellationToken cancellationToken) =>
            GetKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Key GetKey(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKey(new GetKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> GetKeyAsync(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyAsync(new GetKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Key> GetKeyAsync(KeyName name, st::CancellationToken cancellationToken) =>
            GetKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the key string for an API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetKeyStringResponse GetKeyString(GetKeyStringRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the key string for an API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetKeyStringResponse> GetKeyStringAsync(GetKeyStringRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the key string for an API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetKeyStringResponse> GetKeyStringAsync(GetKeyStringRequest request, st::CancellationToken cancellationToken) =>
            GetKeyStringAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the key string for an API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be retrieved.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetKeyStringResponse GetKeyString(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyString(new GetKeyStringRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the key string for an API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be retrieved.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetKeyStringResponse> GetKeyStringAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyStringAsync(new GetKeyStringRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the key string for an API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be retrieved.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetKeyStringResponse> GetKeyStringAsync(string name, st::CancellationToken cancellationToken) =>
            GetKeyStringAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the key string for an API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be retrieved.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetKeyStringResponse GetKeyString(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyString(new GetKeyStringRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the key string for an API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be retrieved.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetKeyStringResponse> GetKeyStringAsync(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKeyStringAsync(new GetKeyStringRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the key string for an API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be retrieved.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetKeyStringResponse> GetKeyStringAsync(KeyName name, st::CancellationToken cancellationToken) =>
            GetKeyStringAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the modifiable fields of an API key.
        /// The key string of the API key isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Key, wkt::Empty> UpdateKey(UpdateKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the modifiable fields of an API key.
        /// The key string of the API key isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> UpdateKeyAsync(UpdateKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the modifiable fields of an API key.
        /// The key string of the API key isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> UpdateKeyAsync(UpdateKeyRequest request, st::CancellationToken cancellationToken) =>
            UpdateKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateKey</c>.</summary>
        public virtual lro::OperationsClient UpdateKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Key, wkt::Empty> PollOnceUpdateKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Key, wkt::Empty>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> PollOnceUpdateKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Key, wkt::Empty>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateKeyOperationsClient, callSettings);

        /// <summary>
        /// Patches the modifiable fields of an API key.
        /// The key string of the API key isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="key">
        /// Required. Set the `name` field to the resource name of the API key to be
        /// updated. You can update only the `display_name`, `restrictions`, and
        /// `annotations` fields.
        /// </param>
        /// <param name="updateMask">
        /// The field mask specifies which fields to be updated as part of this
        /// request. All other fields are ignored.
        /// Mutable fields are: `display_name`, `restrictions`, and `annotations`.
        /// If an update mask is not provided, the service treats it as an implied mask
        /// equivalent to all allowed fields that are set on the wire. If the field
        /// mask has a special value "*", the service treats it equivalent to replace
        /// all allowed mutable fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Key, wkt::Empty> UpdateKey(Key key, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKey(new UpdateKeyRequest
            {
                Key = gax::GaxPreconditions.CheckNotNull(key, nameof(key)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Patches the modifiable fields of an API key.
        /// The key string of the API key isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="key">
        /// Required. Set the `name` field to the resource name of the API key to be
        /// updated. You can update only the `display_name`, `restrictions`, and
        /// `annotations` fields.
        /// </param>
        /// <param name="updateMask">
        /// The field mask specifies which fields to be updated as part of this
        /// request. All other fields are ignored.
        /// Mutable fields are: `display_name`, `restrictions`, and `annotations`.
        /// If an update mask is not provided, the service treats it as an implied mask
        /// equivalent to all allowed fields that are set on the wire. If the field
        /// mask has a special value "*", the service treats it equivalent to replace
        /// all allowed mutable fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> UpdateKeyAsync(Key key, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKeyAsync(new UpdateKeyRequest
            {
                Key = gax::GaxPreconditions.CheckNotNull(key, nameof(key)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Patches the modifiable fields of an API key.
        /// The key string of the API key isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="key">
        /// Required. Set the `name` field to the resource name of the API key to be
        /// updated. You can update only the `display_name`, `restrictions`, and
        /// `annotations` fields.
        /// </param>
        /// <param name="updateMask">
        /// The field mask specifies which fields to be updated as part of this
        /// request. All other fields are ignored.
        /// Mutable fields are: `display_name`, `restrictions`, and `annotations`.
        /// If an update mask is not provided, the service treats it as an implied mask
        /// equivalent to all allowed fields that are set on the wire. If the field
        /// mask has a special value "*", the service treats it equivalent to replace
        /// all allowed mutable fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> UpdateKeyAsync(Key key, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateKeyAsync(key, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an API key. Deleted key can be retrieved within 30 days of
        /// deletion. Afterward, key will be purged from the project.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Key, wkt::Empty> DeleteKey(DeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an API key. Deleted key can be retrieved within 30 days of
        /// deletion. Afterward, key will be purged from the project.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> DeleteKeyAsync(DeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an API key. Deleted key can be retrieved within 30 days of
        /// deletion. Afterward, key will be purged from the project.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> DeleteKeyAsync(DeleteKeyRequest request, st::CancellationToken cancellationToken) =>
            DeleteKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteKey</c>.</summary>
        public virtual lro::OperationsClient DeleteKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Key, wkt::Empty> PollOnceDeleteKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Key, wkt::Empty>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> PollOnceDeleteKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Key, wkt::Empty>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteKeyOperationsClient, callSettings);

        /// <summary>
        /// Deletes an API key. Deleted key can be retrieved within 30 days of
        /// deletion. Afterward, key will be purged from the project.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Key, wkt::Empty> DeleteKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKey(new DeleteKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an API key. Deleted key can be retrieved within 30 days of
        /// deletion. Afterward, key will be purged from the project.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> DeleteKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKeyAsync(new DeleteKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an API key. Deleted key can be retrieved within 30 days of
        /// deletion. Afterward, key will be purged from the project.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> DeleteKeyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an API key. Deleted key can be retrieved within 30 days of
        /// deletion. Afterward, key will be purged from the project.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Key, wkt::Empty> DeleteKey(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKey(new DeleteKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an API key. Deleted key can be retrieved within 30 days of
        /// deletion. Afterward, key will be purged from the project.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> DeleteKeyAsync(KeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKeyAsync(new DeleteKeyRequest
            {
                KeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an API key. Deleted key can be retrieved within 30 days of
        /// deletion. Afterward, key will be purged from the project.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the API key to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> DeleteKeyAsync(KeyName name, st::CancellationToken cancellationToken) =>
            DeleteKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes an API key which was deleted within 30 days.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Key, wkt::Empty> UndeleteKey(UndeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes an API key which was deleted within 30 days.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> UndeleteKeyAsync(UndeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes an API key which was deleted within 30 days.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> UndeleteKeyAsync(UndeleteKeyRequest request, st::CancellationToken cancellationToken) =>
            UndeleteKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeleteKey</c>.</summary>
        public virtual lro::OperationsClient UndeleteKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeleteKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Key, wkt::Empty> PollOnceUndeleteKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Key, wkt::Empty>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Key, wkt::Empty>> PollOnceUndeleteKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Key, wkt::Empty>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteKeyOperationsClient, callSettings);

        /// <summary>
        /// Find the parent project and resource name of the API
        /// key that matches the key string in the request. If the API key has been
        /// purged, resource name will not be set.
        /// The service account must have the `apikeys.keys.lookup` permission
        /// on the parent project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LookupKeyResponse LookupKey(LookupKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Find the parent project and resource name of the API
        /// key that matches the key string in the request. If the API key has been
        /// purged, resource name will not be set.
        /// The service account must have the `apikeys.keys.lookup` permission
        /// on the parent project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupKeyResponse> LookupKeyAsync(LookupKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Find the parent project and resource name of the API
        /// key that matches the key string in the request. If the API key has been
        /// purged, resource name will not be set.
        /// The service account must have the `apikeys.keys.lookup` permission
        /// on the parent project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LookupKeyResponse> LookupKeyAsync(LookupKeyRequest request, st::CancellationToken cancellationToken) =>
            LookupKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ApiKeys client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages the API keys associated with projects.
    /// </remarks>
    public sealed partial class ApiKeysClientImpl : ApiKeysClient
    {
        private readonly gaxgrpc::ApiCall<CreateKeyRequest, lro::Operation> _callCreateKey;

        private readonly gaxgrpc::ApiCall<ListKeysRequest, ListKeysResponse> _callListKeys;

        private readonly gaxgrpc::ApiCall<GetKeyRequest, Key> _callGetKey;

        private readonly gaxgrpc::ApiCall<GetKeyStringRequest, GetKeyStringResponse> _callGetKeyString;

        private readonly gaxgrpc::ApiCall<UpdateKeyRequest, lro::Operation> _callUpdateKey;

        private readonly gaxgrpc::ApiCall<DeleteKeyRequest, lro::Operation> _callDeleteKey;

        private readonly gaxgrpc::ApiCall<UndeleteKeyRequest, lro::Operation> _callUndeleteKey;

        private readonly gaxgrpc::ApiCall<LookupKeyRequest, LookupKeyResponse> _callLookupKey;

        /// <summary>
        /// Constructs a client wrapper for the ApiKeys service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApiKeysSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ApiKeysClientImpl(ApiKeys.ApiKeysClient grpcClient, ApiKeysSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ApiKeysSettings effectiveSettings = settings ?? ApiKeysSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateKeyOperationsSettings, logger);
            UpdateKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateKeyOperationsSettings, logger);
            DeleteKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteKeyOperationsSettings, logger);
            UndeleteKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeleteKeyOperationsSettings, logger);
            _callCreateKey = clientHelper.BuildApiCall<CreateKeyRequest, lro::Operation>("CreateKey", grpcClient.CreateKeyAsync, grpcClient.CreateKey, effectiveSettings.CreateKeySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateKey);
            Modify_CreateKeyApiCall(ref _callCreateKey);
            _callListKeys = clientHelper.BuildApiCall<ListKeysRequest, ListKeysResponse>("ListKeys", grpcClient.ListKeysAsync, grpcClient.ListKeys, effectiveSettings.ListKeysSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListKeys);
            Modify_ListKeysApiCall(ref _callListKeys);
            _callGetKey = clientHelper.BuildApiCall<GetKeyRequest, Key>("GetKey", grpcClient.GetKeyAsync, grpcClient.GetKey, effectiveSettings.GetKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetKey);
            Modify_GetKeyApiCall(ref _callGetKey);
            _callGetKeyString = clientHelper.BuildApiCall<GetKeyStringRequest, GetKeyStringResponse>("GetKeyString", grpcClient.GetKeyStringAsync, grpcClient.GetKeyString, effectiveSettings.GetKeyStringSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetKeyString);
            Modify_GetKeyStringApiCall(ref _callGetKeyString);
            _callUpdateKey = clientHelper.BuildApiCall<UpdateKeyRequest, lro::Operation>("UpdateKey", grpcClient.UpdateKeyAsync, grpcClient.UpdateKey, effectiveSettings.UpdateKeySettings).WithGoogleRequestParam("key.name", request => request.Key?.Name);
            Modify_ApiCall(ref _callUpdateKey);
            Modify_UpdateKeyApiCall(ref _callUpdateKey);
            _callDeleteKey = clientHelper.BuildApiCall<DeleteKeyRequest, lro::Operation>("DeleteKey", grpcClient.DeleteKeyAsync, grpcClient.DeleteKey, effectiveSettings.DeleteKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteKey);
            Modify_DeleteKeyApiCall(ref _callDeleteKey);
            _callUndeleteKey = clientHelper.BuildApiCall<UndeleteKeyRequest, lro::Operation>("UndeleteKey", grpcClient.UndeleteKeyAsync, grpcClient.UndeleteKey, effectiveSettings.UndeleteKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteKey);
            Modify_UndeleteKeyApiCall(ref _callUndeleteKey);
            _callLookupKey = clientHelper.BuildApiCall<LookupKeyRequest, LookupKeyResponse>("LookupKey", grpcClient.LookupKeyAsync, grpcClient.LookupKey, effectiveSettings.LookupKeySettings);
            Modify_ApiCall(ref _callLookupKey);
            Modify_LookupKeyApiCall(ref _callLookupKey);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateKeyApiCall(ref gaxgrpc::ApiCall<CreateKeyRequest, lro::Operation> call);

        partial void Modify_ListKeysApiCall(ref gaxgrpc::ApiCall<ListKeysRequest, ListKeysResponse> call);

        partial void Modify_GetKeyApiCall(ref gaxgrpc::ApiCall<GetKeyRequest, Key> call);

        partial void Modify_GetKeyStringApiCall(ref gaxgrpc::ApiCall<GetKeyStringRequest, GetKeyStringResponse> call);

        partial void Modify_UpdateKeyApiCall(ref gaxgrpc::ApiCall<UpdateKeyRequest, lro::Operation> call);

        partial void Modify_DeleteKeyApiCall(ref gaxgrpc::ApiCall<DeleteKeyRequest, lro::Operation> call);

        partial void Modify_UndeleteKeyApiCall(ref gaxgrpc::ApiCall<UndeleteKeyRequest, lro::Operation> call);

        partial void Modify_LookupKeyApiCall(ref gaxgrpc::ApiCall<LookupKeyRequest, LookupKeyResponse> call);

        partial void OnConstruction(ApiKeys.ApiKeysClient grpcClient, ApiKeysSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ApiKeys client</summary>
        public override ApiKeys.ApiKeysClient GrpcClient { get; }

        partial void Modify_CreateKeyRequest(ref CreateKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListKeysRequest(ref ListKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetKeyRequest(ref GetKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetKeyStringRequest(ref GetKeyStringRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateKeyRequest(ref UpdateKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteKeyRequest(ref DeleteKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteKeyRequest(ref UndeleteKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupKeyRequest(ref LookupKeyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateKey</c>.</summary>
        public override lro::OperationsClient CreateKeyOperationsClient { get; }

        /// <summary>
        /// Creates a new API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Key, wkt::Empty> CreateKey(CreateKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKeyRequest(ref request, ref callSettings);
            return new lro::Operation<Key, wkt::Empty>(_callCreateKey.Sync(request, callSettings), CreateKeyOperationsClient);
        }

        /// <summary>
        /// Creates a new API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Key, wkt::Empty>> CreateKeyAsync(CreateKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKeyRequest(ref request, ref callSettings);
            return new lro::Operation<Key, wkt::Empty>(await _callCreateKey.Async(request, callSettings).ConfigureAwait(false), CreateKeyOperationsClient);
        }

        /// <summary>
        /// Lists the API keys owned by a project. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Key"/> resources.</returns>
        public override gax::PagedEnumerable<ListKeysResponse, Key> ListKeys(ListKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListKeysRequest, ListKeysResponse, Key>(_callListKeys, request, callSettings);
        }

        /// <summary>
        /// Lists the API keys owned by a project. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Key"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListKeysResponse, Key> ListKeysAsync(ListKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListKeysRequest, ListKeysResponse, Key>(_callListKeys, request, callSettings);
        }

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Key GetKey(GetKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyRequest(ref request, ref callSettings);
            return _callGetKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata for an API key. The key string of the API key
        /// isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Key> GetKeyAsync(GetKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyRequest(ref request, ref callSettings);
            return _callGetKey.Async(request, callSettings);
        }

        /// <summary>
        /// Get the key string for an API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GetKeyStringResponse GetKeyString(GetKeyStringRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyStringRequest(ref request, ref callSettings);
            return _callGetKeyString.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the key string for an API key.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GetKeyStringResponse> GetKeyStringAsync(GetKeyStringRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyStringRequest(ref request, ref callSettings);
            return _callGetKeyString.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateKey</c>.</summary>
        public override lro::OperationsClient UpdateKeyOperationsClient { get; }

        /// <summary>
        /// Patches the modifiable fields of an API key.
        /// The key string of the API key isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Key, wkt::Empty> UpdateKey(UpdateKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKeyRequest(ref request, ref callSettings);
            return new lro::Operation<Key, wkt::Empty>(_callUpdateKey.Sync(request, callSettings), UpdateKeyOperationsClient);
        }

        /// <summary>
        /// Patches the modifiable fields of an API key.
        /// The key string of the API key isn't included in the response.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Key, wkt::Empty>> UpdateKeyAsync(UpdateKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKeyRequest(ref request, ref callSettings);
            return new lro::Operation<Key, wkt::Empty>(await _callUpdateKey.Async(request, callSettings).ConfigureAwait(false), UpdateKeyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteKey</c>.</summary>
        public override lro::OperationsClient DeleteKeyOperationsClient { get; }

        /// <summary>
        /// Deletes an API key. Deleted key can be retrieved within 30 days of
        /// deletion. Afterward, key will be purged from the project.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Key, wkt::Empty> DeleteKey(DeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKeyRequest(ref request, ref callSettings);
            return new lro::Operation<Key, wkt::Empty>(_callDeleteKey.Sync(request, callSettings), DeleteKeyOperationsClient);
        }

        /// <summary>
        /// Deletes an API key. Deleted key can be retrieved within 30 days of
        /// deletion. Afterward, key will be purged from the project.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Key, wkt::Empty>> DeleteKeyAsync(DeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKeyRequest(ref request, ref callSettings);
            return new lro::Operation<Key, wkt::Empty>(await _callDeleteKey.Async(request, callSettings).ConfigureAwait(false), DeleteKeyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeleteKey</c>.</summary>
        public override lro::OperationsClient UndeleteKeyOperationsClient { get; }

        /// <summary>
        /// Undeletes an API key which was deleted within 30 days.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Key, wkt::Empty> UndeleteKey(UndeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteKeyRequest(ref request, ref callSettings);
            return new lro::Operation<Key, wkt::Empty>(_callUndeleteKey.Sync(request, callSettings), UndeleteKeyOperationsClient);
        }

        /// <summary>
        /// Undeletes an API key which was deleted within 30 days.
        /// 
        /// NOTE: Key is a global resource; hence the only supported value for
        /// location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Key, wkt::Empty>> UndeleteKeyAsync(UndeleteKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteKeyRequest(ref request, ref callSettings);
            return new lro::Operation<Key, wkt::Empty>(await _callUndeleteKey.Async(request, callSettings).ConfigureAwait(false), UndeleteKeyOperationsClient);
        }

        /// <summary>
        /// Find the parent project and resource name of the API
        /// key that matches the key string in the request. If the API key has been
        /// purged, resource name will not be set.
        /// The service account must have the `apikeys.keys.lookup` permission
        /// on the parent project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LookupKeyResponse LookupKey(LookupKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupKeyRequest(ref request, ref callSettings);
            return _callLookupKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Find the parent project and resource name of the API
        /// key that matches the key string in the request. If the API key has been
        /// purged, resource name will not be set.
        /// The service account must have the `apikeys.keys.lookup` permission
        /// on the parent project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LookupKeyResponse> LookupKeyAsync(LookupKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupKeyRequest(ref request, ref callSettings);
            return _callLookupKey.Async(request, callSettings);
        }
    }

    public partial class ListKeysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListKeysResponse : gaxgrpc::IPageResponse<Key>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Key> GetEnumerator() => Keys.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ApiKeys
    {
        public partial class ApiKeysClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
