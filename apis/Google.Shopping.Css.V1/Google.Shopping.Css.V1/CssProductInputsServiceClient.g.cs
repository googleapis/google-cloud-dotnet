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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Shopping.Css.V1
{
    /// <summary>Settings for <see cref="CssProductInputsServiceClient"/> instances.</summary>
    public sealed partial class CssProductInputsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CssProductInputsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CssProductInputsServiceSettings"/>.</returns>
        public static CssProductInputsServiceSettings GetDefault() => new CssProductInputsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CssProductInputsServiceSettings"/> object with default settings.
        /// </summary>
        public CssProductInputsServiceSettings()
        {
        }

        private CssProductInputsServiceSettings(CssProductInputsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            InsertCssProductInputSettings = existing.InsertCssProductInputSettings;
            DeleteCssProductInputSettings = existing.DeleteCssProductInputSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CssProductInputsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CssProductInputsServiceClient.InsertCssProductInput</c> and
        /// <c>CssProductInputsServiceClient.InsertCssProductInputAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertCssProductInputSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CssProductInputsServiceClient.DeleteCssProductInput</c> and
        /// <c>CssProductInputsServiceClient.DeleteCssProductInputAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCssProductInputSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CssProductInputsServiceSettings"/> object.</returns>
        public CssProductInputsServiceSettings Clone() => new CssProductInputsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CssProductInputsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CssProductInputsServiceClientBuilder : gaxgrpc::ClientBuilderBase<CssProductInputsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CssProductInputsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CssProductInputsServiceClientBuilder() : base(CssProductInputsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CssProductInputsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CssProductInputsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CssProductInputsServiceClient Build()
        {
            CssProductInputsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CssProductInputsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CssProductInputsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CssProductInputsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CssProductInputsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CssProductInputsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CssProductInputsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CssProductInputsServiceClient.ChannelPool;
    }

    /// <summary>CssProductInputsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to use CssProductInput resource.
    /// This service helps to insert/update/delete CSS Products.
    /// </remarks>
    public abstract partial class CssProductInputsServiceClient
    {
        /// <summary>
        /// The default endpoint for the CssProductInputsService service, which is a host of "css.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "css.googleapis.com:443";

        /// <summary>The default CssProductInputsService scopes.</summary>
        /// <remarks>
        /// The default CssProductInputsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CssProductInputsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CssProductInputsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CssProductInputsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CssProductInputsServiceClient"/>.</returns>
        public static stt::Task<CssProductInputsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CssProductInputsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CssProductInputsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CssProductInputsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CssProductInputsServiceClient"/>.</returns>
        public static CssProductInputsServiceClient Create() => new CssProductInputsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CssProductInputsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CssProductInputsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CssProductInputsServiceClient"/>.</returns>
        internal static CssProductInputsServiceClient Create(grpccore::CallInvoker callInvoker, CssProductInputsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CssProductInputsService.CssProductInputsServiceClient grpcClient = new CssProductInputsService.CssProductInputsServiceClient(callInvoker);
            return new CssProductInputsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CssProductInputsService client</summary>
        public virtual CssProductInputsService.CssProductInputsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a CssProductInput to your CSS Center account. If an
        /// input with the same contentLanguage, identity, feedLabel and feedId already
        /// exists, this method replaces that entry.
        /// 
        /// After inserting, updating, or deleting a CSS Product input, it may
        /// take several minutes before the processed CSS Product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CssProductInput InsertCssProductInput(InsertCssProductInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a CssProductInput to your CSS Center account. If an
        /// input with the same contentLanguage, identity, feedLabel and feedId already
        /// exists, this method replaces that entry.
        /// 
        /// After inserting, updating, or deleting a CSS Product input, it may
        /// take several minutes before the processed CSS Product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CssProductInput> InsertCssProductInputAsync(InsertCssProductInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a CssProductInput to your CSS Center account. If an
        /// input with the same contentLanguage, identity, feedLabel and feedId already
        /// exists, this method replaces that entry.
        /// 
        /// After inserting, updating, or deleting a CSS Product input, it may
        /// take several minutes before the processed CSS Product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CssProductInput> InsertCssProductInputAsync(InsertCssProductInputRequest request, st::CancellationToken cancellationToken) =>
            InsertCssProductInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a CSS Product input from your CSS Center account.
        /// 
        /// After a delete it may take several minutes until the input is no longer
        /// available.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCssProductInput(DeleteCssProductInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a CSS Product input from your CSS Center account.
        /// 
        /// After a delete it may take several minutes until the input is no longer
        /// available.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCssProductInputAsync(DeleteCssProductInputRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a CSS Product input from your CSS Center account.
        /// 
        /// After a delete it may take several minutes until the input is no longer
        /// available.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCssProductInputAsync(DeleteCssProductInputRequest request, st::CancellationToken cancellationToken) =>
            DeleteCssProductInputAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a CSS Product input from your CSS Center account.
        /// 
        /// After a delete it may take several minutes until the input is no longer
        /// available.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product input resource to delete.
        /// Format: accounts/{account}/cssProductInputs/{css_product_input}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCssProductInput(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCssProductInput(new DeleteCssProductInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a CSS Product input from your CSS Center account.
        /// 
        /// After a delete it may take several minutes until the input is no longer
        /// available.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product input resource to delete.
        /// Format: accounts/{account}/cssProductInputs/{css_product_input}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCssProductInputAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCssProductInputAsync(new DeleteCssProductInputRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a CSS Product input from your CSS Center account.
        /// 
        /// After a delete it may take several minutes until the input is no longer
        /// available.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product input resource to delete.
        /// Format: accounts/{account}/cssProductInputs/{css_product_input}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCssProductInputAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCssProductInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a CSS Product input from your CSS Center account.
        /// 
        /// After a delete it may take several minutes until the input is no longer
        /// available.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product input resource to delete.
        /// Format: accounts/{account}/cssProductInputs/{css_product_input}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCssProductInput(CssProductInputName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCssProductInput(new DeleteCssProductInputRequest
            {
                CssProductInputName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a CSS Product input from your CSS Center account.
        /// 
        /// After a delete it may take several minutes until the input is no longer
        /// available.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product input resource to delete.
        /// Format: accounts/{account}/cssProductInputs/{css_product_input}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCssProductInputAsync(CssProductInputName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCssProductInputAsync(new DeleteCssProductInputRequest
            {
                CssProductInputName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a CSS Product input from your CSS Center account.
        /// 
        /// After a delete it may take several minutes until the input is no longer
        /// available.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product input resource to delete.
        /// Format: accounts/{account}/cssProductInputs/{css_product_input}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCssProductInputAsync(CssProductInputName name, st::CancellationToken cancellationToken) =>
            DeleteCssProductInputAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CssProductInputsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to use CssProductInput resource.
    /// This service helps to insert/update/delete CSS Products.
    /// </remarks>
    public sealed partial class CssProductInputsServiceClientImpl : CssProductInputsServiceClient
    {
        private readonly gaxgrpc::ApiCall<InsertCssProductInputRequest, CssProductInput> _callInsertCssProductInput;

        private readonly gaxgrpc::ApiCall<DeleteCssProductInputRequest, wkt::Empty> _callDeleteCssProductInput;

        /// <summary>
        /// Constructs a client wrapper for the CssProductInputsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CssProductInputsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CssProductInputsServiceClientImpl(CssProductInputsService.CssProductInputsServiceClient grpcClient, CssProductInputsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CssProductInputsServiceSettings effectiveSettings = settings ?? CssProductInputsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callInsertCssProductInput = clientHelper.BuildApiCall<InsertCssProductInputRequest, CssProductInput>("InsertCssProductInput", grpcClient.InsertCssProductInputAsync, grpcClient.InsertCssProductInput, effectiveSettings.InsertCssProductInputSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInsertCssProductInput);
            Modify_InsertCssProductInputApiCall(ref _callInsertCssProductInput);
            _callDeleteCssProductInput = clientHelper.BuildApiCall<DeleteCssProductInputRequest, wkt::Empty>("DeleteCssProductInput", grpcClient.DeleteCssProductInputAsync, grpcClient.DeleteCssProductInput, effectiveSettings.DeleteCssProductInputSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCssProductInput);
            Modify_DeleteCssProductInputApiCall(ref _callDeleteCssProductInput);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_InsertCssProductInputApiCall(ref gaxgrpc::ApiCall<InsertCssProductInputRequest, CssProductInput> call);

        partial void Modify_DeleteCssProductInputApiCall(ref gaxgrpc::ApiCall<DeleteCssProductInputRequest, wkt::Empty> call);

        partial void OnConstruction(CssProductInputsService.CssProductInputsServiceClient grpcClient, CssProductInputsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CssProductInputsService client</summary>
        public override CssProductInputsService.CssProductInputsServiceClient GrpcClient { get; }

        partial void Modify_InsertCssProductInputRequest(ref InsertCssProductInputRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCssProductInputRequest(ref DeleteCssProductInputRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Uploads a CssProductInput to your CSS Center account. If an
        /// input with the same contentLanguage, identity, feedLabel and feedId already
        /// exists, this method replaces that entry.
        /// 
        /// After inserting, updating, or deleting a CSS Product input, it may
        /// take several minutes before the processed CSS Product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CssProductInput InsertCssProductInput(InsertCssProductInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertCssProductInputRequest(ref request, ref callSettings);
            return _callInsertCssProductInput.Sync(request, callSettings);
        }

        /// <summary>
        /// Uploads a CssProductInput to your CSS Center account. If an
        /// input with the same contentLanguage, identity, feedLabel and feedId already
        /// exists, this method replaces that entry.
        /// 
        /// After inserting, updating, or deleting a CSS Product input, it may
        /// take several minutes before the processed CSS Product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CssProductInput> InsertCssProductInputAsync(InsertCssProductInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertCssProductInputRequest(ref request, ref callSettings);
            return _callInsertCssProductInput.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a CSS Product input from your CSS Center account.
        /// 
        /// After a delete it may take several minutes until the input is no longer
        /// available.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCssProductInput(DeleteCssProductInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCssProductInputRequest(ref request, ref callSettings);
            _callDeleteCssProductInput.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a CSS Product input from your CSS Center account.
        /// 
        /// After a delete it may take several minutes until the input is no longer
        /// available.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCssProductInputAsync(DeleteCssProductInputRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCssProductInputRequest(ref request, ref callSettings);
            return _callDeleteCssProductInput.Async(request, callSettings);
        }
    }
}
