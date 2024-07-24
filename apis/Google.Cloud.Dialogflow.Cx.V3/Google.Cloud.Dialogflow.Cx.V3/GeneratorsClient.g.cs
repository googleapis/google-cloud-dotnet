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
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Settings for <see cref="GeneratorsClient"/> instances.</summary>
    public sealed partial class GeneratorsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GeneratorsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GeneratorsSettings"/>.</returns>
        public static GeneratorsSettings GetDefault() => new GeneratorsSettings();

        /// <summary>Constructs a new <see cref="GeneratorsSettings"/> object with default settings.</summary>
        public GeneratorsSettings()
        {
        }

        private GeneratorsSettings(GeneratorsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGeneratorsSettings = existing.ListGeneratorsSettings;
            GetGeneratorSettings = existing.GetGeneratorSettings;
            CreateGeneratorSettings = existing.CreateGeneratorSettings;
            UpdateGeneratorSettings = existing.UpdateGeneratorSettings;
            DeleteGeneratorSettings = existing.DeleteGeneratorSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GeneratorsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeneratorsClient.ListGenerators</c> and <c>GeneratorsClient.ListGeneratorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGeneratorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeneratorsClient.GetGenerator</c> and <c>GeneratorsClient.GetGeneratorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGeneratorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeneratorsClient.CreateGenerator</c> and <c>GeneratorsClient.CreateGeneratorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGeneratorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeneratorsClient.UpdateGenerator</c> and <c>GeneratorsClient.UpdateGeneratorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGeneratorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeneratorsClient.DeleteGenerator</c> and <c>GeneratorsClient.DeleteGeneratorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGeneratorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GeneratorsSettings"/> object.</returns>
        public GeneratorsSettings Clone() => new GeneratorsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GeneratorsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class GeneratorsClientBuilder : gaxgrpc::ClientBuilderBase<GeneratorsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GeneratorsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GeneratorsClientBuilder() : base(GeneratorsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GeneratorsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GeneratorsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GeneratorsClient Build()
        {
            GeneratorsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GeneratorsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GeneratorsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GeneratorsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GeneratorsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GeneratorsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GeneratorsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GeneratorsClient.ChannelPool;
    }

    /// <summary>Generators client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Generators][google.cloud.dialogflow.cx.v3.Generator]
    /// </remarks>
    public abstract partial class GeneratorsClient
    {
        /// <summary>
        /// The default endpoint for the Generators service, which is a host of "dialogflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Generators scopes.</summary>
        /// <remarks>
        /// The default Generators scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Generators.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GeneratorsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GeneratorsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GeneratorsClient"/>.</returns>
        public static stt::Task<GeneratorsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GeneratorsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GeneratorsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="GeneratorsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GeneratorsClient"/>.</returns>
        public static GeneratorsClient Create() => new GeneratorsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GeneratorsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GeneratorsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GeneratorsClient"/>.</returns>
        internal static GeneratorsClient Create(grpccore::CallInvoker callInvoker, GeneratorsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Generators.GeneratorsClient grpcClient = new Generators.GeneratorsClient(callInvoker);
            return new GeneratorsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Generators client</summary>
        public virtual Generators.GeneratorsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all generators in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Generator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGeneratorsResponse, Generator> ListGenerators(ListGeneratorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all generators in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Generator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGeneratorsResponse, Generator> ListGeneratorsAsync(ListGeneratorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all generators in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all generators for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Generator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGeneratorsResponse, Generator> ListGenerators(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeneratorsRequest request = new ListGeneratorsRequest
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
            return ListGenerators(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all generators in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all generators for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Generator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGeneratorsResponse, Generator> ListGeneratorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeneratorsRequest request = new ListGeneratorsRequest
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
            return ListGeneratorsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all generators in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all generators for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Generator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGeneratorsResponse, Generator> ListGenerators(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeneratorsRequest request = new ListGeneratorsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGenerators(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all generators in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all generators for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Generator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGeneratorsResponse, Generator> ListGeneratorsAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeneratorsRequest request = new ListGeneratorsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGeneratorsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Generator GetGenerator(GetGeneratorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> GetGeneratorAsync(GetGeneratorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> GetGeneratorAsync(GetGeneratorRequest request, st::CancellationToken cancellationToken) =>
            GetGeneratorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified generator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Generator GetGenerator(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGenerator(new GetGeneratorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified generator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> GetGeneratorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGeneratorAsync(new GetGeneratorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified generator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> GetGeneratorAsync(string name, st::CancellationToken cancellationToken) =>
            GetGeneratorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified generator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Generator GetGenerator(GeneratorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGenerator(new GetGeneratorRequest
            {
                GeneratorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified generator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> GetGeneratorAsync(GeneratorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGeneratorAsync(new GetGeneratorRequest
            {
                GeneratorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified generator.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> GetGeneratorAsync(GeneratorName name, st::CancellationToken cancellationToken) =>
            GetGeneratorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a generator in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Generator CreateGenerator(CreateGeneratorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a generator in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> CreateGeneratorAsync(CreateGeneratorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a generator in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> CreateGeneratorAsync(CreateGeneratorRequest request, st::CancellationToken cancellationToken) =>
            CreateGeneratorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a generator in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a generator for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="generator">
        /// Required. The generator to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Generator CreateGenerator(string parent, Generator generator, gaxgrpc::CallSettings callSettings = null) =>
            CreateGenerator(new CreateGeneratorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Generator = gax::GaxPreconditions.CheckNotNull(generator, nameof(generator)),
            }, callSettings);

        /// <summary>
        /// Creates a generator in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a generator for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="generator">
        /// Required. The generator to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> CreateGeneratorAsync(string parent, Generator generator, gaxgrpc::CallSettings callSettings = null) =>
            CreateGeneratorAsync(new CreateGeneratorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Generator = gax::GaxPreconditions.CheckNotNull(generator, nameof(generator)),
            }, callSettings);

        /// <summary>
        /// Creates a generator in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a generator for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="generator">
        /// Required. The generator to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> CreateGeneratorAsync(string parent, Generator generator, st::CancellationToken cancellationToken) =>
            CreateGeneratorAsync(parent, generator, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a generator in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a generator for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="generator">
        /// Required. The generator to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Generator CreateGenerator(AgentName parent, Generator generator, gaxgrpc::CallSettings callSettings = null) =>
            CreateGenerator(new CreateGeneratorRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Generator = gax::GaxPreconditions.CheckNotNull(generator, nameof(generator)),
            }, callSettings);

        /// <summary>
        /// Creates a generator in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a generator for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="generator">
        /// Required. The generator to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> CreateGeneratorAsync(AgentName parent, Generator generator, gaxgrpc::CallSettings callSettings = null) =>
            CreateGeneratorAsync(new CreateGeneratorRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Generator = gax::GaxPreconditions.CheckNotNull(generator, nameof(generator)),
            }, callSettings);

        /// <summary>
        /// Creates a generator in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a generator for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="generator">
        /// Required. The generator to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> CreateGeneratorAsync(AgentName parent, Generator generator, st::CancellationToken cancellationToken) =>
            CreateGeneratorAsync(parent, generator, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the specified generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Generator UpdateGenerator(UpdateGeneratorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the specified generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> UpdateGeneratorAsync(UpdateGeneratorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the specified generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> UpdateGeneratorAsync(UpdateGeneratorRequest request, st::CancellationToken cancellationToken) =>
            UpdateGeneratorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the specified generator.
        /// </summary>
        /// <param name="generator">
        /// Required. The generator to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Generator UpdateGenerator(Generator generator, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGenerator(new UpdateGeneratorRequest
            {
                Generator = gax::GaxPreconditions.CheckNotNull(generator, nameof(generator)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the specified generator.
        /// </summary>
        /// <param name="generator">
        /// Required. The generator to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> UpdateGeneratorAsync(Generator generator, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGeneratorAsync(new UpdateGeneratorRequest
            {
                Generator = gax::GaxPreconditions.CheckNotNull(generator, nameof(generator)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the specified generator.
        /// </summary>
        /// <param name="generator">
        /// Required. The generator to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Generator> UpdateGeneratorAsync(Generator generator, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGeneratorAsync(generator, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified generators.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGenerator(DeleteGeneratorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified generators.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorAsync(DeleteGeneratorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified generators.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorAsync(DeleteGeneratorRequest request, st::CancellationToken cancellationToken) =>
            DeleteGeneratorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified generators.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGenerator(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGenerator(new DeleteGeneratorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified generators.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGeneratorAsync(new DeleteGeneratorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified generators.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGeneratorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified generators.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGenerator(GeneratorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGenerator(new DeleteGeneratorRequest
            {
                GeneratorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified generators.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorAsync(GeneratorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGeneratorAsync(new DeleteGeneratorRequest
            {
                GeneratorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified generators.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the generator to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/generators/&lt;Generator ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGeneratorAsync(GeneratorName name, st::CancellationToken cancellationToken) =>
            DeleteGeneratorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Generators client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Generators][google.cloud.dialogflow.cx.v3.Generator]
    /// </remarks>
    public sealed partial class GeneratorsClientImpl : GeneratorsClient
    {
        private readonly gaxgrpc::ApiCall<ListGeneratorsRequest, ListGeneratorsResponse> _callListGenerators;

        private readonly gaxgrpc::ApiCall<GetGeneratorRequest, Generator> _callGetGenerator;

        private readonly gaxgrpc::ApiCall<CreateGeneratorRequest, Generator> _callCreateGenerator;

        private readonly gaxgrpc::ApiCall<UpdateGeneratorRequest, Generator> _callUpdateGenerator;

        private readonly gaxgrpc::ApiCall<DeleteGeneratorRequest, wkt::Empty> _callDeleteGenerator;

        /// <summary>
        /// Constructs a client wrapper for the Generators service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GeneratorsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GeneratorsClientImpl(Generators.GeneratorsClient grpcClient, GeneratorsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GeneratorsSettings effectiveSettings = settings ?? GeneratorsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListGenerators = clientHelper.BuildApiCall<ListGeneratorsRequest, ListGeneratorsResponse>("ListGenerators", grpcClient.ListGeneratorsAsync, grpcClient.ListGenerators, effectiveSettings.ListGeneratorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGenerators);
            Modify_ListGeneratorsApiCall(ref _callListGenerators);
            _callGetGenerator = clientHelper.BuildApiCall<GetGeneratorRequest, Generator>("GetGenerator", grpcClient.GetGeneratorAsync, grpcClient.GetGenerator, effectiveSettings.GetGeneratorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGenerator);
            Modify_GetGeneratorApiCall(ref _callGetGenerator);
            _callCreateGenerator = clientHelper.BuildApiCall<CreateGeneratorRequest, Generator>("CreateGenerator", grpcClient.CreateGeneratorAsync, grpcClient.CreateGenerator, effectiveSettings.CreateGeneratorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGenerator);
            Modify_CreateGeneratorApiCall(ref _callCreateGenerator);
            _callUpdateGenerator = clientHelper.BuildApiCall<UpdateGeneratorRequest, Generator>("UpdateGenerator", grpcClient.UpdateGeneratorAsync, grpcClient.UpdateGenerator, effectiveSettings.UpdateGeneratorSettings).WithGoogleRequestParam("generator.name", request => request.Generator?.Name);
            Modify_ApiCall(ref _callUpdateGenerator);
            Modify_UpdateGeneratorApiCall(ref _callUpdateGenerator);
            _callDeleteGenerator = clientHelper.BuildApiCall<DeleteGeneratorRequest, wkt::Empty>("DeleteGenerator", grpcClient.DeleteGeneratorAsync, grpcClient.DeleteGenerator, effectiveSettings.DeleteGeneratorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGenerator);
            Modify_DeleteGeneratorApiCall(ref _callDeleteGenerator);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListGeneratorsApiCall(ref gaxgrpc::ApiCall<ListGeneratorsRequest, ListGeneratorsResponse> call);

        partial void Modify_GetGeneratorApiCall(ref gaxgrpc::ApiCall<GetGeneratorRequest, Generator> call);

        partial void Modify_CreateGeneratorApiCall(ref gaxgrpc::ApiCall<CreateGeneratorRequest, Generator> call);

        partial void Modify_UpdateGeneratorApiCall(ref gaxgrpc::ApiCall<UpdateGeneratorRequest, Generator> call);

        partial void Modify_DeleteGeneratorApiCall(ref gaxgrpc::ApiCall<DeleteGeneratorRequest, wkt::Empty> call);

        partial void OnConstruction(Generators.GeneratorsClient grpcClient, GeneratorsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Generators client</summary>
        public override Generators.GeneratorsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListGeneratorsRequest(ref ListGeneratorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGeneratorRequest(ref GetGeneratorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGeneratorRequest(ref CreateGeneratorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGeneratorRequest(ref UpdateGeneratorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGeneratorRequest(ref DeleteGeneratorRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all generators in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Generator"/> resources.</returns>
        public override gax::PagedEnumerable<ListGeneratorsResponse, Generator> ListGenerators(ListGeneratorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGeneratorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGeneratorsRequest, ListGeneratorsResponse, Generator>(_callListGenerators, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all generators in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Generator"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGeneratorsResponse, Generator> ListGeneratorsAsync(ListGeneratorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGeneratorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGeneratorsRequest, ListGeneratorsResponse, Generator>(_callListGenerators, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Generator GetGenerator(GetGeneratorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGeneratorRequest(ref request, ref callSettings);
            return _callGetGenerator.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Generator> GetGeneratorAsync(GetGeneratorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGeneratorRequest(ref request, ref callSettings);
            return _callGetGenerator.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a generator in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Generator CreateGenerator(CreateGeneratorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGeneratorRequest(ref request, ref callSettings);
            return _callCreateGenerator.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a generator in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Generator> CreateGeneratorAsync(CreateGeneratorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGeneratorRequest(ref request, ref callSettings);
            return _callCreateGenerator.Async(request, callSettings);
        }

        /// <summary>
        /// Update the specified generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Generator UpdateGenerator(UpdateGeneratorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGeneratorRequest(ref request, ref callSettings);
            return _callUpdateGenerator.Sync(request, callSettings);
        }

        /// <summary>
        /// Update the specified generator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Generator> UpdateGeneratorAsync(UpdateGeneratorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGeneratorRequest(ref request, ref callSettings);
            return _callUpdateGenerator.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified generators.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteGenerator(DeleteGeneratorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGeneratorRequest(ref request, ref callSettings);
            _callDeleteGenerator.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified generators.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteGeneratorAsync(DeleteGeneratorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGeneratorRequest(ref request, ref callSettings);
            return _callDeleteGenerator.Async(request, callSettings);
        }
    }

    public partial class ListGeneratorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGeneratorsResponse : gaxgrpc::IPageResponse<Generator>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Generator> GetEnumerator() => Generators.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Generators
    {
        public partial class GeneratorsClient
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
        }
    }
}
