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

namespace Google.Cloud.ResourceManager.V3
{
    /// <summary>Settings for <see cref="TagHoldsClient"/> instances.</summary>
    public sealed partial class TagHoldsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TagHoldsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TagHoldsSettings"/>.</returns>
        public static TagHoldsSettings GetDefault() => new TagHoldsSettings();

        /// <summary>Constructs a new <see cref="TagHoldsSettings"/> object with default settings.</summary>
        public TagHoldsSettings()
        {
        }

        private TagHoldsSettings(TagHoldsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTagHoldSettings = existing.CreateTagHoldSettings;
            CreateTagHoldOperationsSettings = existing.CreateTagHoldOperationsSettings.Clone();
            DeleteTagHoldSettings = existing.DeleteTagHoldSettings;
            DeleteTagHoldOperationsSettings = existing.DeleteTagHoldOperationsSettings.Clone();
            ListTagHoldsSettings = existing.ListTagHoldsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TagHoldsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagHoldsClient.CreateTagHold</c> and <c>TagHoldsClient.CreateTagHoldAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTagHoldSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TagHoldsClient.CreateTagHold</c> and
        /// <c>TagHoldsClient.CreateTagHoldAsync</c>.
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
        public lro::OperationsSettings CreateTagHoldOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagHoldsClient.DeleteTagHold</c> and <c>TagHoldsClient.DeleteTagHoldAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTagHoldSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TagHoldsClient.DeleteTagHold</c> and
        /// <c>TagHoldsClient.DeleteTagHoldAsync</c>.
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
        public lro::OperationsSettings DeleteTagHoldOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TagHoldsClient.ListTagHolds</c>
        ///  and <c>TagHoldsClient.ListTagHoldsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTagHoldsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TagHoldsSettings"/> object.</returns>
        public TagHoldsSettings Clone() => new TagHoldsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TagHoldsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TagHoldsClientBuilder : gaxgrpc::ClientBuilderBase<TagHoldsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TagHoldsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TagHoldsClientBuilder() : base(TagHoldsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TagHoldsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TagHoldsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TagHoldsClient Build()
        {
            TagHoldsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TagHoldsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TagHoldsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TagHoldsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TagHoldsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TagHoldsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TagHoldsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TagHoldsClient.ChannelPool;
    }

    /// <summary>TagHolds client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Allow users to create and manage TagHolds for TagValues. TagHolds represent
    /// the use of a Tag Value that is not captured by TagBindings but
    /// should still block TagValue deletion (such as a reference in a policy
    /// condition). This service provides isolated failure domains by cloud location
    /// so that TagHolds can be managed in the same location as their usage.
    /// </remarks>
    public abstract partial class TagHoldsClient
    {
        /// <summary>
        /// The default endpoint for the TagHolds service, which is a host of "cloudresourcemanager.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudresourcemanager.googleapis.com:443";

        /// <summary>The default TagHolds scopes.</summary>
        /// <remarks>
        /// The default TagHolds scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TagHolds.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TagHoldsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="TagHoldsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TagHoldsClient"/>.</returns>
        public static stt::Task<TagHoldsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TagHoldsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TagHoldsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="TagHoldsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TagHoldsClient"/>.</returns>
        public static TagHoldsClient Create() => new TagHoldsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TagHoldsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TagHoldsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TagHoldsClient"/>.</returns>
        internal static TagHoldsClient Create(grpccore::CallInvoker callInvoker, TagHoldsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TagHolds.TagHoldsClient grpcClient = new TagHolds.TagHoldsClient(callInvoker);
            return new TagHoldsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TagHolds client</summary>
        public virtual TagHolds.TagHoldsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TagHold. Returns ALREADY_EXISTS if a TagHold with the same
        /// resource and origin exists under the same TagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagHold, CreateTagHoldMetadata> CreateTagHold(CreateTagHoldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TagHold. Returns ALREADY_EXISTS if a TagHold with the same
        /// resource and origin exists under the same TagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagHold, CreateTagHoldMetadata>> CreateTagHoldAsync(CreateTagHoldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TagHold. Returns ALREADY_EXISTS if a TagHold with the same
        /// resource and origin exists under the same TagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagHold, CreateTagHoldMetadata>> CreateTagHoldAsync(CreateTagHoldRequest request, st::CancellationToken cancellationToken) =>
            CreateTagHoldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTagHold</c>.</summary>
        public virtual lro::OperationsClient CreateTagHoldOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTagHold</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TagHold, CreateTagHoldMetadata> PollOnceCreateTagHold(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagHold, CreateTagHoldMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTagHoldOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTagHold</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TagHold, CreateTagHoldMetadata>> PollOnceCreateTagHoldAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagHold, CreateTagHoldMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTagHoldOperationsClient, callSettings);

        /// <summary>
        /// Creates a TagHold. Returns ALREADY_EXISTS if a TagHold with the same
        /// resource and origin exists under the same TagValue.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TagHold's parent TagValue. Must be of
        /// the form: `tagValues/{tag-value-id}`.
        /// </param>
        /// <param name="tagHold">
        /// Required. The TagHold to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagHold, CreateTagHoldMetadata> CreateTagHold(string parent, TagHold tagHold, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagHold(new CreateTagHoldRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TagHold = gax::GaxPreconditions.CheckNotNull(tagHold, nameof(tagHold)),
            }, callSettings);

        /// <summary>
        /// Creates a TagHold. Returns ALREADY_EXISTS if a TagHold with the same
        /// resource and origin exists under the same TagValue.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TagHold's parent TagValue. Must be of
        /// the form: `tagValues/{tag-value-id}`.
        /// </param>
        /// <param name="tagHold">
        /// Required. The TagHold to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagHold, CreateTagHoldMetadata>> CreateTagHoldAsync(string parent, TagHold tagHold, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagHoldAsync(new CreateTagHoldRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TagHold = gax::GaxPreconditions.CheckNotNull(tagHold, nameof(tagHold)),
            }, callSettings);

        /// <summary>
        /// Creates a TagHold. Returns ALREADY_EXISTS if a TagHold with the same
        /// resource and origin exists under the same TagValue.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TagHold's parent TagValue. Must be of
        /// the form: `tagValues/{tag-value-id}`.
        /// </param>
        /// <param name="tagHold">
        /// Required. The TagHold to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagHold, CreateTagHoldMetadata>> CreateTagHoldAsync(string parent, TagHold tagHold, st::CancellationToken cancellationToken) =>
            CreateTagHoldAsync(parent, tagHold, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TagHold. Returns ALREADY_EXISTS if a TagHold with the same
        /// resource and origin exists under the same TagValue.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TagHold's parent TagValue. Must be of
        /// the form: `tagValues/{tag-value-id}`.
        /// </param>
        /// <param name="tagHold">
        /// Required. The TagHold to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagHold, CreateTagHoldMetadata> CreateTagHold(TagValueName parent, TagHold tagHold, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagHold(new CreateTagHoldRequest
            {
                ParentAsTagValueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TagHold = gax::GaxPreconditions.CheckNotNull(tagHold, nameof(tagHold)),
            }, callSettings);

        /// <summary>
        /// Creates a TagHold. Returns ALREADY_EXISTS if a TagHold with the same
        /// resource and origin exists under the same TagValue.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TagHold's parent TagValue. Must be of
        /// the form: `tagValues/{tag-value-id}`.
        /// </param>
        /// <param name="tagHold">
        /// Required. The TagHold to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagHold, CreateTagHoldMetadata>> CreateTagHoldAsync(TagValueName parent, TagHold tagHold, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagHoldAsync(new CreateTagHoldRequest
            {
                ParentAsTagValueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TagHold = gax::GaxPreconditions.CheckNotNull(tagHold, nameof(tagHold)),
            }, callSettings);

        /// <summary>
        /// Creates a TagHold. Returns ALREADY_EXISTS if a TagHold with the same
        /// resource and origin exists under the same TagValue.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TagHold's parent TagValue. Must be of
        /// the form: `tagValues/{tag-value-id}`.
        /// </param>
        /// <param name="tagHold">
        /// Required. The TagHold to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagHold, CreateTagHoldMetadata>> CreateTagHoldAsync(TagValueName parent, TagHold tagHold, st::CancellationToken cancellationToken) =>
            CreateTagHoldAsync(parent, tagHold, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TagHold.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTagHoldMetadata> DeleteTagHold(DeleteTagHoldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TagHold.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagHoldMetadata>> DeleteTagHoldAsync(DeleteTagHoldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TagHold.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagHoldMetadata>> DeleteTagHoldAsync(DeleteTagHoldRequest request, st::CancellationToken cancellationToken) =>
            DeleteTagHoldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTagHold</c>.</summary>
        public virtual lro::OperationsClient DeleteTagHoldOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTagHold</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTagHoldMetadata> PollOnceDeleteTagHold(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteTagHoldMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTagHoldOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTagHold</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagHoldMetadata>> PollOnceDeleteTagHoldAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteTagHoldMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTagHoldOperationsClient, callSettings);

        /// <summary>
        /// Deletes a TagHold.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TagHold to delete. Must be of the form:
        /// `tagValues/{tag-value-id}/tagHolds/{tag-hold-id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTagHoldMetadata> DeleteTagHold(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagHold(new DeleteTagHoldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagHold.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TagHold to delete. Must be of the form:
        /// `tagValues/{tag-value-id}/tagHolds/{tag-hold-id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagHoldMetadata>> DeleteTagHoldAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagHoldAsync(new DeleteTagHoldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagHold.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TagHold to delete. Must be of the form:
        /// `tagValues/{tag-value-id}/tagHolds/{tag-hold-id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagHoldMetadata>> DeleteTagHoldAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTagHoldAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TagHold.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TagHold to delete. Must be of the form:
        /// `tagValues/{tag-value-id}/tagHolds/{tag-hold-id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteTagHoldMetadata> DeleteTagHold(TagHoldName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagHold(new DeleteTagHoldRequest
            {
                TagHoldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagHold.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TagHold to delete. Must be of the form:
        /// `tagValues/{tag-value-id}/tagHolds/{tag-hold-id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagHoldMetadata>> DeleteTagHoldAsync(TagHoldName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagHoldAsync(new DeleteTagHoldRequest
            {
                TagHoldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagHold.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the TagHold to delete. Must be of the form:
        /// `tagValues/{tag-value-id}/tagHolds/{tag-hold-id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteTagHoldMetadata>> DeleteTagHoldAsync(TagHoldName name, st::CancellationToken cancellationToken) =>
            DeleteTagHoldAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists TagHolds under a TagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TagHold"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagHoldsResponse, TagHold> ListTagHolds(ListTagHoldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TagHolds under a TagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TagHold"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagHoldsResponse, TagHold> ListTagHoldsAsync(ListTagHoldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TagHolds under a TagValue.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent TagValue. Must be of the form:
        /// `tagValues/{tag-value-id}`.
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
        /// <returns>A pageable sequence of <see cref="TagHold"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagHoldsResponse, TagHold> ListTagHolds(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagHoldsRequest request = new ListTagHoldsRequest
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
            return ListTagHolds(request, callSettings);
        }

        /// <summary>
        /// Lists TagHolds under a TagValue.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent TagValue. Must be of the form:
        /// `tagValues/{tag-value-id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TagHold"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagHoldsResponse, TagHold> ListTagHoldsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagHoldsRequest request = new ListTagHoldsRequest
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
            return ListTagHoldsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists TagHolds under a TagValue.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent TagValue. Must be of the form:
        /// `tagValues/{tag-value-id}`.
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
        /// <returns>A pageable sequence of <see cref="TagHold"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagHoldsResponse, TagHold> ListTagHolds(TagValueName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagHoldsRequest request = new ListTagHoldsRequest
            {
                ParentAsTagValueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTagHolds(request, callSettings);
        }

        /// <summary>
        /// Lists TagHolds under a TagValue.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent TagValue. Must be of the form:
        /// `tagValues/{tag-value-id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TagHold"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagHoldsResponse, TagHold> ListTagHoldsAsync(TagValueName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagHoldsRequest request = new ListTagHoldsRequest
            {
                ParentAsTagValueName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTagHoldsAsync(request, callSettings);
        }
    }

    /// <summary>TagHolds client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Allow users to create and manage TagHolds for TagValues. TagHolds represent
    /// the use of a Tag Value that is not captured by TagBindings but
    /// should still block TagValue deletion (such as a reference in a policy
    /// condition). This service provides isolated failure domains by cloud location
    /// so that TagHolds can be managed in the same location as their usage.
    /// </remarks>
    public sealed partial class TagHoldsClientImpl : TagHoldsClient
    {
        private readonly gaxgrpc::ApiCall<CreateTagHoldRequest, lro::Operation> _callCreateTagHold;

        private readonly gaxgrpc::ApiCall<DeleteTagHoldRequest, lro::Operation> _callDeleteTagHold;

        private readonly gaxgrpc::ApiCall<ListTagHoldsRequest, ListTagHoldsResponse> _callListTagHolds;

        /// <summary>
        /// Constructs a client wrapper for the TagHolds service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TagHoldsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TagHoldsClientImpl(TagHolds.TagHoldsClient grpcClient, TagHoldsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TagHoldsSettings effectiveSettings = settings ?? TagHoldsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateTagHoldOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTagHoldOperationsSettings, logger);
            DeleteTagHoldOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTagHoldOperationsSettings, logger);
            _callCreateTagHold = clientHelper.BuildApiCall<CreateTagHoldRequest, lro::Operation>("CreateTagHold", grpcClient.CreateTagHoldAsync, grpcClient.CreateTagHold, effectiveSettings.CreateTagHoldSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTagHold);
            Modify_CreateTagHoldApiCall(ref _callCreateTagHold);
            _callDeleteTagHold = clientHelper.BuildApiCall<DeleteTagHoldRequest, lro::Operation>("DeleteTagHold", grpcClient.DeleteTagHoldAsync, grpcClient.DeleteTagHold, effectiveSettings.DeleteTagHoldSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTagHold);
            Modify_DeleteTagHoldApiCall(ref _callDeleteTagHold);
            _callListTagHolds = clientHelper.BuildApiCall<ListTagHoldsRequest, ListTagHoldsResponse>("ListTagHolds", grpcClient.ListTagHoldsAsync, grpcClient.ListTagHolds, effectiveSettings.ListTagHoldsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTagHolds);
            Modify_ListTagHoldsApiCall(ref _callListTagHolds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateTagHoldApiCall(ref gaxgrpc::ApiCall<CreateTagHoldRequest, lro::Operation> call);

        partial void Modify_DeleteTagHoldApiCall(ref gaxgrpc::ApiCall<DeleteTagHoldRequest, lro::Operation> call);

        partial void Modify_ListTagHoldsApiCall(ref gaxgrpc::ApiCall<ListTagHoldsRequest, ListTagHoldsResponse> call);

        partial void OnConstruction(TagHolds.TagHoldsClient grpcClient, TagHoldsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TagHolds client</summary>
        public override TagHolds.TagHoldsClient GrpcClient { get; }

        partial void Modify_CreateTagHoldRequest(ref CreateTagHoldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTagHoldRequest(ref DeleteTagHoldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTagHoldsRequest(ref ListTagHoldsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateTagHold</c>.</summary>
        public override lro::OperationsClient CreateTagHoldOperationsClient { get; }

        /// <summary>
        /// Creates a TagHold. Returns ALREADY_EXISTS if a TagHold with the same
        /// resource and origin exists under the same TagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TagHold, CreateTagHoldMetadata> CreateTagHold(CreateTagHoldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagHoldRequest(ref request, ref callSettings);
            return new lro::Operation<TagHold, CreateTagHoldMetadata>(_callCreateTagHold.Sync(request, callSettings), CreateTagHoldOperationsClient);
        }

        /// <summary>
        /// Creates a TagHold. Returns ALREADY_EXISTS if a TagHold with the same
        /// resource and origin exists under the same TagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TagHold, CreateTagHoldMetadata>> CreateTagHoldAsync(CreateTagHoldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagHoldRequest(ref request, ref callSettings);
            return new lro::Operation<TagHold, CreateTagHoldMetadata>(await _callCreateTagHold.Async(request, callSettings).ConfigureAwait(false), CreateTagHoldOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTagHold</c>.</summary>
        public override lro::OperationsClient DeleteTagHoldOperationsClient { get; }

        /// <summary>
        /// Deletes a TagHold.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteTagHoldMetadata> DeleteTagHold(DeleteTagHoldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagHoldRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteTagHoldMetadata>(_callDeleteTagHold.Sync(request, callSettings), DeleteTagHoldOperationsClient);
        }

        /// <summary>
        /// Deletes a TagHold.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteTagHoldMetadata>> DeleteTagHoldAsync(DeleteTagHoldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagHoldRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteTagHoldMetadata>(await _callDeleteTagHold.Async(request, callSettings).ConfigureAwait(false), DeleteTagHoldOperationsClient);
        }

        /// <summary>
        /// Lists TagHolds under a TagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TagHold"/> resources.</returns>
        public override gax::PagedEnumerable<ListTagHoldsResponse, TagHold> ListTagHolds(ListTagHoldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagHoldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTagHoldsRequest, ListTagHoldsResponse, TagHold>(_callListTagHolds, request, callSettings);
        }

        /// <summary>
        /// Lists TagHolds under a TagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TagHold"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTagHoldsResponse, TagHold> ListTagHoldsAsync(ListTagHoldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagHoldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTagHoldsRequest, ListTagHoldsResponse, TagHold>(_callListTagHolds, request, callSettings);
        }
    }

    public partial class ListTagHoldsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTagHoldsResponse : gaxgrpc::IPageResponse<TagHold>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TagHold> GetEnumerator() => TagHolds.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TagHolds
    {
        public partial class TagHoldsClient
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
