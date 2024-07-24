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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.Functions.V2Beta
{
    /// <summary>Settings for <see cref="FunctionServiceClient"/> instances.</summary>
    public sealed partial class FunctionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FunctionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FunctionServiceSettings"/>.</returns>
        public static FunctionServiceSettings GetDefault() => new FunctionServiceSettings();

        /// <summary>Constructs a new <see cref="FunctionServiceSettings"/> object with default settings.</summary>
        public FunctionServiceSettings()
        {
        }

        private FunctionServiceSettings(FunctionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFunctionSettings = existing.GetFunctionSettings;
            ListFunctionsSettings = existing.ListFunctionsSettings;
            CreateFunctionSettings = existing.CreateFunctionSettings;
            CreateFunctionOperationsSettings = existing.CreateFunctionOperationsSettings.Clone();
            UpdateFunctionSettings = existing.UpdateFunctionSettings;
            UpdateFunctionOperationsSettings = existing.UpdateFunctionOperationsSettings.Clone();
            DeleteFunctionSettings = existing.DeleteFunctionSettings;
            DeleteFunctionOperationsSettings = existing.DeleteFunctionOperationsSettings.Clone();
            GenerateUploadUrlSettings = existing.GenerateUploadUrlSettings;
            GenerateDownloadUrlSettings = existing.GenerateDownloadUrlSettings;
            ListRuntimesSettings = existing.ListRuntimesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(FunctionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FunctionServiceClient.GetFunction</c> and <c>FunctionServiceClient.GetFunctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFunctionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FunctionServiceClient.ListFunctions</c> and <c>FunctionServiceClient.ListFunctionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFunctionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FunctionServiceClient.CreateFunction</c> and <c>FunctionServiceClient.CreateFunctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFunctionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FunctionServiceClient.CreateFunction</c> and
        /// <c>FunctionServiceClient.CreateFunctionAsync</c>.
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
        public lro::OperationsSettings CreateFunctionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FunctionServiceClient.UpdateFunction</c> and <c>FunctionServiceClient.UpdateFunctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFunctionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FunctionServiceClient.UpdateFunction</c> and
        /// <c>FunctionServiceClient.UpdateFunctionAsync</c>.
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
        public lro::OperationsSettings UpdateFunctionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FunctionServiceClient.DeleteFunction</c> and <c>FunctionServiceClient.DeleteFunctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFunctionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FunctionServiceClient.DeleteFunction</c> and
        /// <c>FunctionServiceClient.DeleteFunctionAsync</c>.
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
        public lro::OperationsSettings DeleteFunctionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FunctionServiceClient.GenerateUploadUrl</c> and <c>FunctionServiceClient.GenerateUploadUrlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateUploadUrlSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FunctionServiceClient.GenerateDownloadUrl</c> and <c>FunctionServiceClient.GenerateDownloadUrlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateDownloadUrlSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FunctionServiceClient.ListRuntimes</c> and <c>FunctionServiceClient.ListRuntimesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRuntimesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FunctionServiceSettings"/> object.</returns>
        public FunctionServiceSettings Clone() => new FunctionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FunctionServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class FunctionServiceClientBuilder : gaxgrpc::ClientBuilderBase<FunctionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FunctionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FunctionServiceClientBuilder() : base(FunctionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FunctionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FunctionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FunctionServiceClient Build()
        {
            FunctionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FunctionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FunctionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FunctionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FunctionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FunctionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FunctionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FunctionServiceClient.ChannelPool;
    }

    /// <summary>FunctionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud Functions is used to deploy functions that are executed by
    /// Google in response to various events. Data connected with that event is
    /// passed to a function as the input data.
    /// 
    /// A **function** is a resource which describes a function that should be
    /// executed and how it is triggered.
    /// </remarks>
    public abstract partial class FunctionServiceClient
    {
        /// <summary>
        /// The default endpoint for the FunctionService service, which is a host of "cloudfunctions.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudfunctions.googleapis.com:443";

        /// <summary>The default FunctionService scopes.</summary>
        /// <remarks>
        /// The default FunctionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FunctionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FunctionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FunctionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FunctionServiceClient"/>.</returns>
        public static stt::Task<FunctionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FunctionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FunctionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FunctionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FunctionServiceClient"/>.</returns>
        public static FunctionServiceClient Create() => new FunctionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FunctionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FunctionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FunctionServiceClient"/>.</returns>
        internal static FunctionServiceClient Create(grpccore::CallInvoker callInvoker, FunctionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FunctionService.FunctionServiceClient grpcClient = new FunctionService.FunctionServiceClient(callInvoker);
            return new FunctionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FunctionService client</summary>
        public virtual FunctionService.FunctionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Function GetFunction(GetFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Function> GetFunctionAsync(GetFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Function> GetFunctionAsync(GetFunctionRequest request, st::CancellationToken cancellationToken) =>
            GetFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Function GetFunction(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFunction(new GetFunctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Function> GetFunctionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFunctionAsync(new GetFunctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Function> GetFunctionAsync(string name, st::CancellationToken cancellationToken) =>
            GetFunctionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Function GetFunction(FunctionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFunction(new GetFunctionRequest
            {
                FunctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Function> GetFunctionAsync(FunctionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFunctionAsync(new GetFunctionRequest
            {
                FunctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Function> GetFunctionAsync(FunctionName name, st::CancellationToken cancellationToken) =>
            GetFunctionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Function"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFunctionsResponse, Function> ListFunctions(ListFunctionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Function"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFunctionsResponse, Function> ListFunctionsAsync(ListFunctionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the function should be
        /// listed, specified in the format `projects/*/locations/*` If you want to
        /// list functions in all locations, use "-" in place of a location. When
        /// listing functions in all locations, if one or more location(s) are
        /// unreachable, the response will contain functions from all reachable
        /// locations along with the names of any unreachable locations.
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
        /// <returns>A pageable sequence of <see cref="Function"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFunctionsResponse, Function> ListFunctions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFunctionsRequest request = new ListFunctionsRequest
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
            return ListFunctions(request, callSettings);
        }

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the function should be
        /// listed, specified in the format `projects/*/locations/*` If you want to
        /// list functions in all locations, use "-" in place of a location. When
        /// listing functions in all locations, if one or more location(s) are
        /// unreachable, the response will contain functions from all reachable
        /// locations along with the names of any unreachable locations.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Function"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFunctionsResponse, Function> ListFunctionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFunctionsRequest request = new ListFunctionsRequest
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
            return ListFunctionsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the function should be
        /// listed, specified in the format `projects/*/locations/*` If you want to
        /// list functions in all locations, use "-" in place of a location. When
        /// listing functions in all locations, if one or more location(s) are
        /// unreachable, the response will contain functions from all reachable
        /// locations along with the names of any unreachable locations.
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
        /// <returns>A pageable sequence of <see cref="Function"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFunctionsResponse, Function> ListFunctions(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFunctionsRequest request = new ListFunctionsRequest
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
            return ListFunctions(request, callSettings);
        }

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the function should be
        /// listed, specified in the format `projects/*/locations/*` If you want to
        /// list functions in all locations, use "-" in place of a location. When
        /// listing functions in all locations, if one or more location(s) are
        /// unreachable, the response will contain functions from all reachable
        /// locations along with the names of any unreachable locations.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Function"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFunctionsResponse, Function> ListFunctionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFunctionsRequest request = new ListFunctionsRequest
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
            return ListFunctionsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Function, OperationMetadata> CreateFunction(CreateFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> CreateFunctionAsync(CreateFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> CreateFunctionAsync(CreateFunctionRequest request, st::CancellationToken cancellationToken) =>
            CreateFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFunction</c>.</summary>
        public virtual lro::OperationsClient CreateFunctionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Function, OperationMetadata> PollOnceCreateFunction(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Function, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFunctionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> PollOnceCreateFunctionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Function, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFunctionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="functionId">
        /// The ID to use for the function, which will become the final component of
        /// the function's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Function, OperationMetadata> CreateFunction(string parent, Function function, string functionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFunction(new CreateFunctionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
                FunctionId = functionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="functionId">
        /// The ID to use for the function, which will become the final component of
        /// the function's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> CreateFunctionAsync(string parent, Function function, string functionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFunctionAsync(new CreateFunctionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
                FunctionId = functionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="functionId">
        /// The ID to use for the function, which will become the final component of
        /// the function's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> CreateFunctionAsync(string parent, Function function, string functionId, st::CancellationToken cancellationToken) =>
            CreateFunctionAsync(parent, function, functionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="functionId">
        /// The ID to use for the function, which will become the final component of
        /// the function's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Function, OperationMetadata> CreateFunction(gagr::LocationName parent, Function function, string functionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFunction(new CreateFunctionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
                FunctionId = functionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="functionId">
        /// The ID to use for the function, which will become the final component of
        /// the function's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> CreateFunctionAsync(gagr::LocationName parent, Function function, string functionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFunctionAsync(new CreateFunctionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
                FunctionId = functionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="functionId">
        /// The ID to use for the function, which will become the final component of
        /// the function's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> CreateFunctionAsync(gagr::LocationName parent, Function function, string functionId, st::CancellationToken cancellationToken) =>
            CreateFunctionAsync(parent, function, functionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Function, OperationMetadata> UpdateFunction(UpdateFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> UpdateFunctionAsync(UpdateFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> UpdateFunctionAsync(UpdateFunctionRequest request, st::CancellationToken cancellationToken) =>
            UpdateFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFunction</c>.</summary>
        public virtual lro::OperationsClient UpdateFunctionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Function, OperationMetadata> PollOnceUpdateFunction(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Function, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFunctionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> PollOnceUpdateFunctionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Function, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFunctionOperationsClient, callSettings);

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="function">
        /// Required. New version of the function.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If no field mask is provided, all provided fields in the request will be
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Function, OperationMetadata> UpdateFunction(Function function, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFunction(new UpdateFunctionRequest
            {
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="function">
        /// Required. New version of the function.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If no field mask is provided, all provided fields in the request will be
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> UpdateFunctionAsync(Function function, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFunctionAsync(new UpdateFunctionRequest
            {
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="function">
        /// Required. New version of the function.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If no field mask is provided, all provided fields in the request will be
        /// updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Function, OperationMetadata>> UpdateFunctionAsync(Function function, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFunctionAsync(function, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFunction(DeleteFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFunctionAsync(DeleteFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFunctionAsync(DeleteFunctionRequest request, st::CancellationToken cancellationToken) =>
            DeleteFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFunction</c>.</summary>
        public virtual lro::OperationsClient DeleteFunctionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteFunction(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFunctionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteFunctionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFunctionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFunction(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFunction(new DeleteFunctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFunctionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFunctionAsync(new DeleteFunctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFunctionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFunctionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFunction(FunctionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFunction(new DeleteFunctionRequest
            {
                FunctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFunctionAsync(FunctionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFunctionAsync(new DeleteFunctionRequest
            {
                FunctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFunctionAsync(FunctionName name, st::CancellationToken cancellationToken) =>
            DeleteFunctionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a signed URL for uploading a function source code.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls.
        /// Once the function source code upload is complete, the used signed
        /// URL should be provided in CreateFunction or UpdateFunction request
        /// as a reference to the function source code.
        /// 
        /// When uploading source code to the generated signed URL, please follow
        /// these restrictions:
        /// 
        /// * Source file type should be a zip file.
        /// * No credentials should be attached - the signed URLs provide access to the
        /// target bucket using internal service identity; if credentials were
        /// attached, the identity from the credentials would be used, but that
        /// identity does not have permissions to upload files to the URL.
        /// 
        /// When making a HTTP PUT request, these two headers need to be specified:
        /// 
        /// * `content-type: application/zip`
        /// 
        /// And this header SHOULD NOT be specified:
        /// 
        /// * `Authorization: Bearer YOUR_TOKEN`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateUploadUrlResponse GenerateUploadUrl(GenerateUploadUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a signed URL for uploading a function source code.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls.
        /// Once the function source code upload is complete, the used signed
        /// URL should be provided in CreateFunction or UpdateFunction request
        /// as a reference to the function source code.
        /// 
        /// When uploading source code to the generated signed URL, please follow
        /// these restrictions:
        /// 
        /// * Source file type should be a zip file.
        /// * No credentials should be attached - the signed URLs provide access to the
        /// target bucket using internal service identity; if credentials were
        /// attached, the identity from the credentials would be used, but that
        /// identity does not have permissions to upload files to the URL.
        /// 
        /// When making a HTTP PUT request, these two headers need to be specified:
        /// 
        /// * `content-type: application/zip`
        /// 
        /// And this header SHOULD NOT be specified:
        /// 
        /// * `Authorization: Bearer YOUR_TOKEN`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateUploadUrlResponse> GenerateUploadUrlAsync(GenerateUploadUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a signed URL for uploading a function source code.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls.
        /// Once the function source code upload is complete, the used signed
        /// URL should be provided in CreateFunction or UpdateFunction request
        /// as a reference to the function source code.
        /// 
        /// When uploading source code to the generated signed URL, please follow
        /// these restrictions:
        /// 
        /// * Source file type should be a zip file.
        /// * No credentials should be attached - the signed URLs provide access to the
        /// target bucket using internal service identity; if credentials were
        /// attached, the identity from the credentials would be used, but that
        /// identity does not have permissions to upload files to the URL.
        /// 
        /// When making a HTTP PUT request, these two headers need to be specified:
        /// 
        /// * `content-type: application/zip`
        /// 
        /// And this header SHOULD NOT be specified:
        /// 
        /// * `Authorization: Bearer YOUR_TOKEN`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateUploadUrlResponse> GenerateUploadUrlAsync(GenerateUploadUrlRequest request, st::CancellationToken cancellationToken) =>
            GenerateUploadUrlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a signed URL for downloading deployed function source code.
        /// The URL is only valid for a limited period and should be used within
        /// 30 minutes of generation.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateDownloadUrlResponse GenerateDownloadUrl(GenerateDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a signed URL for downloading deployed function source code.
        /// The URL is only valid for a limited period and should be used within
        /// 30 minutes of generation.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDownloadUrlResponse> GenerateDownloadUrlAsync(GenerateDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a signed URL for downloading deployed function source code.
        /// The URL is only valid for a limited period and should be used within
        /// 30 minutes of generation.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDownloadUrlResponse> GenerateDownloadUrlAsync(GenerateDownloadUrlRequest request, st::CancellationToken cancellationToken) =>
            GenerateDownloadUrlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of runtimes that are supported for the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListRuntimesResponse ListRuntimes(ListRuntimesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of runtimes that are supported for the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRuntimesResponse> ListRuntimesAsync(ListRuntimesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of runtimes that are supported for the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRuntimesResponse> ListRuntimesAsync(ListRuntimesRequest request, st::CancellationToken cancellationToken) =>
            ListRuntimesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of runtimes that are supported for the requested project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the runtimes should be
        /// listed, specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListRuntimesResponse ListRuntimes(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListRuntimes(new ListRuntimesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns a list of runtimes that are supported for the requested project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the runtimes should be
        /// listed, specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRuntimesResponse> ListRuntimesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListRuntimesAsync(new ListRuntimesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns a list of runtimes that are supported for the requested project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the runtimes should be
        /// listed, specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRuntimesResponse> ListRuntimesAsync(string parent, st::CancellationToken cancellationToken) =>
            ListRuntimesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of runtimes that are supported for the requested project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the runtimes should be
        /// listed, specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListRuntimesResponse ListRuntimes(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListRuntimes(new ListRuntimesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns a list of runtimes that are supported for the requested project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the runtimes should be
        /// listed, specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRuntimesResponse> ListRuntimesAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListRuntimesAsync(new ListRuntimesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Returns a list of runtimes that are supported for the requested project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the runtimes should be
        /// listed, specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListRuntimesResponse> ListRuntimesAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            ListRuntimesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FunctionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud Functions is used to deploy functions that are executed by
    /// Google in response to various events. Data connected with that event is
    /// passed to a function as the input data.
    /// 
    /// A **function** is a resource which describes a function that should be
    /// executed and how it is triggered.
    /// </remarks>
    public sealed partial class FunctionServiceClientImpl : FunctionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetFunctionRequest, Function> _callGetFunction;

        private readonly gaxgrpc::ApiCall<ListFunctionsRequest, ListFunctionsResponse> _callListFunctions;

        private readonly gaxgrpc::ApiCall<CreateFunctionRequest, lro::Operation> _callCreateFunction;

        private readonly gaxgrpc::ApiCall<UpdateFunctionRequest, lro::Operation> _callUpdateFunction;

        private readonly gaxgrpc::ApiCall<DeleteFunctionRequest, lro::Operation> _callDeleteFunction;

        private readonly gaxgrpc::ApiCall<GenerateUploadUrlRequest, GenerateUploadUrlResponse> _callGenerateUploadUrl;

        private readonly gaxgrpc::ApiCall<GenerateDownloadUrlRequest, GenerateDownloadUrlResponse> _callGenerateDownloadUrl;

        private readonly gaxgrpc::ApiCall<ListRuntimesRequest, ListRuntimesResponse> _callListRuntimes;

        /// <summary>
        /// Constructs a client wrapper for the FunctionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FunctionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FunctionServiceClientImpl(FunctionService.FunctionServiceClient grpcClient, FunctionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FunctionServiceSettings effectiveSettings = settings ?? FunctionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateFunctionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFunctionOperationsSettings, logger);
            UpdateFunctionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFunctionOperationsSettings, logger);
            DeleteFunctionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFunctionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callGetFunction = clientHelper.BuildApiCall<GetFunctionRequest, Function>("GetFunction", grpcClient.GetFunctionAsync, grpcClient.GetFunction, effectiveSettings.GetFunctionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFunction);
            Modify_GetFunctionApiCall(ref _callGetFunction);
            _callListFunctions = clientHelper.BuildApiCall<ListFunctionsRequest, ListFunctionsResponse>("ListFunctions", grpcClient.ListFunctionsAsync, grpcClient.ListFunctions, effectiveSettings.ListFunctionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFunctions);
            Modify_ListFunctionsApiCall(ref _callListFunctions);
            _callCreateFunction = clientHelper.BuildApiCall<CreateFunctionRequest, lro::Operation>("CreateFunction", grpcClient.CreateFunctionAsync, grpcClient.CreateFunction, effectiveSettings.CreateFunctionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFunction);
            Modify_CreateFunctionApiCall(ref _callCreateFunction);
            _callUpdateFunction = clientHelper.BuildApiCall<UpdateFunctionRequest, lro::Operation>("UpdateFunction", grpcClient.UpdateFunctionAsync, grpcClient.UpdateFunction, effectiveSettings.UpdateFunctionSettings).WithGoogleRequestParam("function.name", request => request.Function?.Name);
            Modify_ApiCall(ref _callUpdateFunction);
            Modify_UpdateFunctionApiCall(ref _callUpdateFunction);
            _callDeleteFunction = clientHelper.BuildApiCall<DeleteFunctionRequest, lro::Operation>("DeleteFunction", grpcClient.DeleteFunctionAsync, grpcClient.DeleteFunction, effectiveSettings.DeleteFunctionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFunction);
            Modify_DeleteFunctionApiCall(ref _callDeleteFunction);
            _callGenerateUploadUrl = clientHelper.BuildApiCall<GenerateUploadUrlRequest, GenerateUploadUrlResponse>("GenerateUploadUrl", grpcClient.GenerateUploadUrlAsync, grpcClient.GenerateUploadUrl, effectiveSettings.GenerateUploadUrlSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGenerateUploadUrl);
            Modify_GenerateUploadUrlApiCall(ref _callGenerateUploadUrl);
            _callGenerateDownloadUrl = clientHelper.BuildApiCall<GenerateDownloadUrlRequest, GenerateDownloadUrlResponse>("GenerateDownloadUrl", grpcClient.GenerateDownloadUrlAsync, grpcClient.GenerateDownloadUrl, effectiveSettings.GenerateDownloadUrlSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateDownloadUrl);
            Modify_GenerateDownloadUrlApiCall(ref _callGenerateDownloadUrl);
            _callListRuntimes = clientHelper.BuildApiCall<ListRuntimesRequest, ListRuntimesResponse>("ListRuntimes", grpcClient.ListRuntimesAsync, grpcClient.ListRuntimes, effectiveSettings.ListRuntimesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRuntimes);
            Modify_ListRuntimesApiCall(ref _callListRuntimes);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetFunctionApiCall(ref gaxgrpc::ApiCall<GetFunctionRequest, Function> call);

        partial void Modify_ListFunctionsApiCall(ref gaxgrpc::ApiCall<ListFunctionsRequest, ListFunctionsResponse> call);

        partial void Modify_CreateFunctionApiCall(ref gaxgrpc::ApiCall<CreateFunctionRequest, lro::Operation> call);

        partial void Modify_UpdateFunctionApiCall(ref gaxgrpc::ApiCall<UpdateFunctionRequest, lro::Operation> call);

        partial void Modify_DeleteFunctionApiCall(ref gaxgrpc::ApiCall<DeleteFunctionRequest, lro::Operation> call);

        partial void Modify_GenerateUploadUrlApiCall(ref gaxgrpc::ApiCall<GenerateUploadUrlRequest, GenerateUploadUrlResponse> call);

        partial void Modify_GenerateDownloadUrlApiCall(ref gaxgrpc::ApiCall<GenerateDownloadUrlRequest, GenerateDownloadUrlResponse> call);

        partial void Modify_ListRuntimesApiCall(ref gaxgrpc::ApiCall<ListRuntimesRequest, ListRuntimesResponse> call);

        partial void OnConstruction(FunctionService.FunctionServiceClient grpcClient, FunctionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FunctionService client</summary>
        public override FunctionService.FunctionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_GetFunctionRequest(ref GetFunctionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFunctionsRequest(ref ListFunctionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFunctionRequest(ref CreateFunctionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFunctionRequest(ref UpdateFunctionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFunctionRequest(ref DeleteFunctionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateUploadUrlRequest(ref GenerateUploadUrlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateDownloadUrlRequest(ref GenerateDownloadUrlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRuntimesRequest(ref ListRuntimesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Function GetFunction(GetFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFunctionRequest(ref request, ref callSettings);
            return _callGetFunction.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Function> GetFunctionAsync(GetFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFunctionRequest(ref request, ref callSettings);
            return _callGetFunction.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Function"/> resources.</returns>
        public override gax::PagedEnumerable<ListFunctionsResponse, Function> ListFunctions(ListFunctionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFunctionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFunctionsRequest, ListFunctionsResponse, Function>(_callListFunctions, request, callSettings);
        }

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Function"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFunctionsResponse, Function> ListFunctionsAsync(ListFunctionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFunctionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFunctionsRequest, ListFunctionsResponse, Function>(_callListFunctions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateFunction</c>.</summary>
        public override lro::OperationsClient CreateFunctionOperationsClient { get; }

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Function, OperationMetadata> CreateFunction(CreateFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<Function, OperationMetadata>(_callCreateFunction.Sync(request, callSettings), CreateFunctionOperationsClient);
        }

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Function, OperationMetadata>> CreateFunctionAsync(CreateFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<Function, OperationMetadata>(await _callCreateFunction.Async(request, callSettings).ConfigureAwait(false), CreateFunctionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateFunction</c>.</summary>
        public override lro::OperationsClient UpdateFunctionOperationsClient { get; }

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Function, OperationMetadata> UpdateFunction(UpdateFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<Function, OperationMetadata>(_callUpdateFunction.Sync(request, callSettings), UpdateFunctionOperationsClient);
        }

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Function, OperationMetadata>> UpdateFunctionAsync(UpdateFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<Function, OperationMetadata>(await _callUpdateFunction.Async(request, callSettings).ConfigureAwait(false), UpdateFunctionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFunction</c>.</summary>
        public override lro::OperationsClient DeleteFunctionOperationsClient { get; }

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteFunction(DeleteFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteFunction.Sync(request, callSettings), DeleteFunctionOperationsClient);
        }

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFunctionAsync(DeleteFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteFunction.Async(request, callSettings).ConfigureAwait(false), DeleteFunctionOperationsClient);
        }

        /// <summary>
        /// Returns a signed URL for uploading a function source code.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls.
        /// Once the function source code upload is complete, the used signed
        /// URL should be provided in CreateFunction or UpdateFunction request
        /// as a reference to the function source code.
        /// 
        /// When uploading source code to the generated signed URL, please follow
        /// these restrictions:
        /// 
        /// * Source file type should be a zip file.
        /// * No credentials should be attached - the signed URLs provide access to the
        /// target bucket using internal service identity; if credentials were
        /// attached, the identity from the credentials would be used, but that
        /// identity does not have permissions to upload files to the URL.
        /// 
        /// When making a HTTP PUT request, these two headers need to be specified:
        /// 
        /// * `content-type: application/zip`
        /// 
        /// And this header SHOULD NOT be specified:
        /// 
        /// * `Authorization: Bearer YOUR_TOKEN`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateUploadUrlResponse GenerateUploadUrl(GenerateUploadUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateUploadUrlRequest(ref request, ref callSettings);
            return _callGenerateUploadUrl.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a signed URL for uploading a function source code.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls.
        /// Once the function source code upload is complete, the used signed
        /// URL should be provided in CreateFunction or UpdateFunction request
        /// as a reference to the function source code.
        /// 
        /// When uploading source code to the generated signed URL, please follow
        /// these restrictions:
        /// 
        /// * Source file type should be a zip file.
        /// * No credentials should be attached - the signed URLs provide access to the
        /// target bucket using internal service identity; if credentials were
        /// attached, the identity from the credentials would be used, but that
        /// identity does not have permissions to upload files to the URL.
        /// 
        /// When making a HTTP PUT request, these two headers need to be specified:
        /// 
        /// * `content-type: application/zip`
        /// 
        /// And this header SHOULD NOT be specified:
        /// 
        /// * `Authorization: Bearer YOUR_TOKEN`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateUploadUrlResponse> GenerateUploadUrlAsync(GenerateUploadUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateUploadUrlRequest(ref request, ref callSettings);
            return _callGenerateUploadUrl.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a signed URL for downloading deployed function source code.
        /// The URL is only valid for a limited period and should be used within
        /// 30 minutes of generation.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateDownloadUrlResponse GenerateDownloadUrl(GenerateDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateDownloadUrlRequest(ref request, ref callSettings);
            return _callGenerateDownloadUrl.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a signed URL for downloading deployed function source code.
        /// The URL is only valid for a limited period and should be used within
        /// 30 minutes of generation.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateDownloadUrlResponse> GenerateDownloadUrlAsync(GenerateDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateDownloadUrlRequest(ref request, ref callSettings);
            return _callGenerateDownloadUrl.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of runtimes that are supported for the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListRuntimesResponse ListRuntimes(ListRuntimesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuntimesRequest(ref request, ref callSettings);
            return _callListRuntimes.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of runtimes that are supported for the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListRuntimesResponse> ListRuntimesAsync(ListRuntimesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuntimesRequest(ref request, ref callSettings);
            return _callListRuntimes.Async(request, callSettings);
        }
    }

    public partial class ListFunctionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFunctionsResponse : gaxgrpc::IPageResponse<Function>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Function> GetEnumerator() => Functions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class FunctionService
    {
        public partial class FunctionServiceClient
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

    public static partial class FunctionService
    {
        public partial class FunctionServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
