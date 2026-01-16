// Copyright 2026 Google LLC
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
    /// <summary>Settings for <see cref="ExamplesClient"/> instances.</summary>
    public sealed partial class ExamplesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ExamplesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ExamplesSettings"/>.</returns>
        public static ExamplesSettings GetDefault() => new ExamplesSettings();

        /// <summary>Constructs a new <see cref="ExamplesSettings"/> object with default settings.</summary>
        public ExamplesSettings()
        {
        }

        private ExamplesSettings(ExamplesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateExampleSettings = existing.CreateExampleSettings;
            DeleteExampleSettings = existing.DeleteExampleSettings;
            ListExamplesSettings = existing.ListExamplesSettings;
            GetExampleSettings = existing.GetExampleSettings;
            UpdateExampleSettings = existing.UpdateExampleSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ExamplesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExamplesClient.CreateExample</c> and <c>ExamplesClient.CreateExampleAsync</c>.
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
        public gaxgrpc::CallSettings CreateExampleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExamplesClient.DeleteExample</c> and <c>ExamplesClient.DeleteExampleAsync</c>.
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
        public gaxgrpc::CallSettings DeleteExampleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ExamplesClient.ListExamples</c>
        ///  and <c>ExamplesClient.ListExamplesAsync</c>.
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
        public gaxgrpc::CallSettings ListExamplesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ExamplesClient.GetExample</c>
        ///  and <c>ExamplesClient.GetExampleAsync</c>.
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
        public gaxgrpc::CallSettings GetExampleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExamplesClient.UpdateExample</c> and <c>ExamplesClient.UpdateExampleAsync</c>.
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
        public gaxgrpc::CallSettings UpdateExampleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ExamplesSettings"/> object.</returns>
        public ExamplesSettings Clone() => new ExamplesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExamplesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ExamplesClientBuilder : gaxgrpc::ClientBuilderBase<ExamplesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ExamplesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ExamplesClientBuilder() : base(ExamplesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ExamplesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ExamplesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ExamplesClient Build()
        {
            ExamplesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ExamplesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ExamplesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ExamplesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExamplesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ExamplesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExamplesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExamplesClient.ChannelPool;
    }

    /// <summary>Examples client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Examples][google.cloud.dialogflow.cx.v3.Example].
    /// </remarks>
    public abstract partial class ExamplesClient
    {
        /// <summary>
        /// The default endpoint for the Examples service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Examples scopes.</summary>
        /// <remarks>
        /// The default Examples scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Examples.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ExamplesClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="ExamplesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ExamplesClient"/>.</returns>
        public static stt::Task<ExamplesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ExamplesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ExamplesClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="ExamplesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ExamplesClient"/>.</returns>
        public static ExamplesClient Create() => new ExamplesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ExamplesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ExamplesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ExamplesClient"/>.</returns>
        internal static ExamplesClient Create(grpccore::CallInvoker callInvoker, ExamplesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Examples.ExamplesClient grpcClient = new Examples.ExamplesClient(callInvoker);
            return new ExamplesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Examples client</summary>
        public virtual Examples.ExamplesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an example in the specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example CreateExample(CreateExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an example in the specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(CreateExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an example in the specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(CreateExampleRequest request, st::CancellationToken cancellationToken) =>
            CreateExampleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an example in the specified playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create an example for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example CreateExample(string parent, Example example, gaxgrpc::CallSettings callSettings = null) =>
            CreateExample(new CreateExampleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates an example in the specified playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create an example for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(string parent, Example example, gaxgrpc::CallSettings callSettings = null) =>
            CreateExampleAsync(new CreateExampleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates an example in the specified playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create an example for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(string parent, Example example, st::CancellationToken cancellationToken) =>
            CreateExampleAsync(parent, example, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an example in the specified playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create an example for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example CreateExample(PlaybookName parent, Example example, gaxgrpc::CallSettings callSettings = null) =>
            CreateExample(new CreateExampleRequest
            {
                ParentAsPlaybookName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates an example in the specified playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create an example for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(PlaybookName parent, Example example, gaxgrpc::CallSettings callSettings = null) =>
            CreateExampleAsync(new CreateExampleRequest
            {
                ParentAsPlaybookName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
            }, callSettings);

        /// <summary>
        /// Creates an example in the specified playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to create an example for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
        /// </param>
        /// <param name="example">
        /// Required. The example to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> CreateExampleAsync(PlaybookName parent, Example example, st::CancellationToken cancellationToken) =>
            CreateExampleAsync(parent, example, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExample(DeleteExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(DeleteExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(DeleteExampleRequest request, st::CancellationToken cancellationToken) =>
            DeleteExampleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExample(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExample(new DeleteExampleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExampleAsync(new DeleteExampleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExampleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExample(ExampleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExample(new DeleteExampleRequest
            {
                ExampleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(ExampleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExampleAsync(new DeleteExampleRequest
            {
                ExampleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExampleAsync(ExampleName name, st::CancellationToken cancellationToken) =>
            DeleteExampleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of examples in the specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of examples in the specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of examples in the specified playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to list the examples from.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExamplesRequest request = new ListExamplesRequest
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
            return ListExamples(request, callSettings);
        }

        /// <summary>
        /// Returns a list of examples in the specified playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to list the examples from.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExamplesRequest request = new ListExamplesRequest
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
            return ListExamplesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of examples in the specified playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to list the examples from.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(PlaybookName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsPlaybookName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExamples(request, callSettings);
        }

        /// <summary>
        /// Returns a list of examples in the specified playbook.
        /// </summary>
        /// <param name="parent">
        /// Required. The playbook to list the examples from.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(PlaybookName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExamplesRequest request = new ListExamplesRequest
            {
                ParentAsPlaybookName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExamplesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example GetExample(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(GetExampleRequest request, st::CancellationToken cancellationToken) =>
            GetExampleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example GetExample(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExample(new GetExampleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExampleAsync(new GetExampleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(string name, st::CancellationToken cancellationToken) =>
            GetExampleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example GetExample(ExampleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExample(new GetExampleRequest
            {
                ExampleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(ExampleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExampleAsync(new GetExampleRequest
            {
                ExampleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified example.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the example.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/playbooks/&lt;PlaybookID&gt;/examples/&lt;ExampleID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(ExampleName name, st::CancellationToken cancellationToken) =>
            GetExampleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example UpdateExample(UpdateExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> UpdateExampleAsync(UpdateExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> UpdateExampleAsync(UpdateExampleRequest request, st::CancellationToken cancellationToken) =>
            UpdateExampleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the specified example.
        /// </summary>
        /// <param name="example">
        /// Required. The example to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example UpdateExample(Example example, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExample(new UpdateExampleRequest
            {
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the specified example.
        /// </summary>
        /// <param name="example">
        /// Required. The example to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> UpdateExampleAsync(Example example, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExampleAsync(new UpdateExampleRequest
            {
                Example = gax::GaxPreconditions.CheckNotNull(example, nameof(example)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the specified example.
        /// </summary>
        /// <param name="example">
        /// Required. The example to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> UpdateExampleAsync(Example example, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExampleAsync(example, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Examples client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Examples][google.cloud.dialogflow.cx.v3.Example].
    /// </remarks>
    public sealed partial class ExamplesClientImpl : ExamplesClient
    {
        private readonly gaxgrpc::ApiCall<CreateExampleRequest, Example> _callCreateExample;

        private readonly gaxgrpc::ApiCall<DeleteExampleRequest, wkt::Empty> _callDeleteExample;

        private readonly gaxgrpc::ApiCall<ListExamplesRequest, ListExamplesResponse> _callListExamples;

        private readonly gaxgrpc::ApiCall<GetExampleRequest, Example> _callGetExample;

        private readonly gaxgrpc::ApiCall<UpdateExampleRequest, Example> _callUpdateExample;

        /// <summary>
        /// Constructs a client wrapper for the Examples service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ExamplesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ExamplesClientImpl(Examples.ExamplesClient grpcClient, ExamplesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ExamplesSettings effectiveSettings = settings ?? ExamplesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateExample = clientHelper.BuildApiCall<CreateExampleRequest, Example>("CreateExample", grpcClient.CreateExampleAsync, grpcClient.CreateExample, effectiveSettings.CreateExampleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExample);
            Modify_CreateExampleApiCall(ref _callCreateExample);
            _callDeleteExample = clientHelper.BuildApiCall<DeleteExampleRequest, wkt::Empty>("DeleteExample", grpcClient.DeleteExampleAsync, grpcClient.DeleteExample, effectiveSettings.DeleteExampleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExample);
            Modify_DeleteExampleApiCall(ref _callDeleteExample);
            _callListExamples = clientHelper.BuildApiCall<ListExamplesRequest, ListExamplesResponse>("ListExamples", grpcClient.ListExamplesAsync, grpcClient.ListExamples, effectiveSettings.ListExamplesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExamples);
            Modify_ListExamplesApiCall(ref _callListExamples);
            _callGetExample = clientHelper.BuildApiCall<GetExampleRequest, Example>("GetExample", grpcClient.GetExampleAsync, grpcClient.GetExample, effectiveSettings.GetExampleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExample);
            Modify_GetExampleApiCall(ref _callGetExample);
            _callUpdateExample = clientHelper.BuildApiCall<UpdateExampleRequest, Example>("UpdateExample", grpcClient.UpdateExampleAsync, grpcClient.UpdateExample, effectiveSettings.UpdateExampleSettings).WithGoogleRequestParam("example.name", request => request.Example?.Name);
            Modify_ApiCall(ref _callUpdateExample);
            Modify_UpdateExampleApiCall(ref _callUpdateExample);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateExampleApiCall(ref gaxgrpc::ApiCall<CreateExampleRequest, Example> call);

        partial void Modify_DeleteExampleApiCall(ref gaxgrpc::ApiCall<DeleteExampleRequest, wkt::Empty> call);

        partial void Modify_ListExamplesApiCall(ref gaxgrpc::ApiCall<ListExamplesRequest, ListExamplesResponse> call);

        partial void Modify_GetExampleApiCall(ref gaxgrpc::ApiCall<GetExampleRequest, Example> call);

        partial void Modify_UpdateExampleApiCall(ref gaxgrpc::ApiCall<UpdateExampleRequest, Example> call);

        partial void OnConstruction(Examples.ExamplesClient grpcClient, ExamplesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Examples client</summary>
        public override Examples.ExamplesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateExampleRequest(ref CreateExampleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExampleRequest(ref DeleteExampleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExamplesRequest(ref ListExamplesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExampleRequest(ref GetExampleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExampleRequest(ref UpdateExampleRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates an example in the specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Example CreateExample(CreateExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExampleRequest(ref request, ref callSettings);
            return _callCreateExample.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an example in the specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Example> CreateExampleAsync(CreateExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExampleRequest(ref request, ref callSettings);
            return _callCreateExample.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteExample(DeleteExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExampleRequest(ref request, ref callSettings);
            _callDeleteExample.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteExampleAsync(DeleteExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExampleRequest(ref request, ref callSettings);
            return _callDeleteExample.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of examples in the specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public override gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExamplesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExamplesRequest, ListExamplesResponse, Example>(_callListExamples, request, callSettings);
        }

        /// <summary>
        /// Returns a list of examples in the specified playbook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExamplesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExamplesRequest, ListExamplesResponse, Example>(_callListExamples, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Example GetExample(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExampleRequest(ref request, ref callSettings);
            return _callGetExample.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Example> GetExampleAsync(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExampleRequest(ref request, ref callSettings);
            return _callGetExample.Async(request, callSettings);
        }

        /// <summary>
        /// Update the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Example UpdateExample(UpdateExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExampleRequest(ref request, ref callSettings);
            return _callUpdateExample.Sync(request, callSettings);
        }

        /// <summary>
        /// Update the specified example.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Example> UpdateExampleAsync(UpdateExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExampleRequest(ref request, ref callSettings);
            return _callUpdateExample.Async(request, callSettings);
        }
    }

    public partial class ListExamplesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExamplesResponse : gaxgrpc::IPageResponse<Example>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Example> GetEnumerator() => Examples.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Examples
    {
        public partial class ExamplesClient
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
