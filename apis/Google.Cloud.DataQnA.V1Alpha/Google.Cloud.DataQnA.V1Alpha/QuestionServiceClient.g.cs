// Copyright 2022 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.DataQnA.V1Alpha
{
    /// <summary>Settings for <see cref="QuestionServiceClient"/> instances.</summary>
    public sealed partial class QuestionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="QuestionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="QuestionServiceSettings"/>.</returns>
        public static QuestionServiceSettings GetDefault() => new QuestionServiceSettings();

        /// <summary>Constructs a new <see cref="QuestionServiceSettings"/> object with default settings.</summary>
        public QuestionServiceSettings()
        {
        }

        private QuestionServiceSettings(QuestionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetQuestionSettings = existing.GetQuestionSettings;
            CreateQuestionSettings = existing.CreateQuestionSettings;
            ExecuteQuestionSettings = existing.ExecuteQuestionSettings;
            GetUserFeedbackSettings = existing.GetUserFeedbackSettings;
            UpdateUserFeedbackSettings = existing.UpdateUserFeedbackSettings;
            OnCopy(existing);
        }

        partial void OnCopy(QuestionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>QuestionServiceClient.GetQuestion</c> and <c>QuestionServiceClient.GetQuestionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetQuestionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>QuestionServiceClient.CreateQuestion</c> and <c>QuestionServiceClient.CreateQuestionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateQuestionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>QuestionServiceClient.ExecuteQuestion</c> and <c>QuestionServiceClient.ExecuteQuestionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteQuestionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>QuestionServiceClient.GetUserFeedback</c> and <c>QuestionServiceClient.GetUserFeedbackAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserFeedbackSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>QuestionServiceClient.UpdateUserFeedback</c> and <c>QuestionServiceClient.UpdateUserFeedbackAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUserFeedbackSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="QuestionServiceSettings"/> object.</returns>
        public QuestionServiceSettings Clone() => new QuestionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="QuestionServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class QuestionServiceClientBuilder : gaxgrpc::ClientBuilderBase<QuestionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public QuestionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public QuestionServiceClientBuilder() : base(QuestionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref QuestionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<QuestionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override QuestionServiceClient Build()
        {
            QuestionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<QuestionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<QuestionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private QuestionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return QuestionServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<QuestionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return QuestionServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => QuestionServiceClient.ChannelPool;
    }

    /// <summary>QuestionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to interpret natural language queries.
    /// The service allows to create `Question` resources that are interpreted and
    /// are filled with one or more interpretations if the question could be
    /// interpreted. Once a `Question` resource is created and has at least one
    /// interpretation, an interpretation can be chosen for execution, which
    /// triggers a query to the backend (for BigQuery, it will create a job).
    /// Upon successful execution of that interpretation, backend specific
    /// information will be returned so that the client can retrieve the results
    /// from the backend.
    /// 
    /// The `Question` resources are named `projects/*/locations/*/questions/*`.
    /// 
    /// The `Question` resource has a singletion sub-resource `UserFeedback` named
    /// `projects/*/locations/*/questions/*/userFeedback`, which allows access to
    /// user feedback.
    /// </remarks>
    public abstract partial class QuestionServiceClient
    {
        /// <summary>
        /// The default endpoint for the QuestionService service, which is a host of "dataqna.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataqna.googleapis.com:443";

        /// <summary>The default QuestionService scopes.</summary>
        /// <remarks>
        /// The default QuestionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        internal static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(QuestionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="QuestionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="QuestionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="QuestionServiceClient"/>.</returns>
        public static stt::Task<QuestionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new QuestionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="QuestionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="QuestionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="QuestionServiceClient"/>.</returns>
        public static QuestionServiceClient Create() => new QuestionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="QuestionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="QuestionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="QuestionServiceClient"/>.</returns>
        internal static QuestionServiceClient Create(grpccore::CallInvoker callInvoker, QuestionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            QuestionService.QuestionServiceClient grpcClient = new QuestionService.QuestionServiceClient(callInvoker);
            return new QuestionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC QuestionService client</summary>
        public virtual QuestionService.QuestionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a previously created question.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Question GetQuestion(GetQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a previously created question.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> GetQuestionAsync(GetQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a previously created question.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> GetQuestionAsync(GetQuestionRequest request, st::CancellationToken cancellationToken) =>
            GetQuestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a previously created question.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the question.
        /// Example: `projects/foo/locations/bar/questions/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Question GetQuestion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuestion(new GetQuestionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created question.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the question.
        /// Example: `projects/foo/locations/bar/questions/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> GetQuestionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuestionAsync(new GetQuestionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created question.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the question.
        /// Example: `projects/foo/locations/bar/questions/1234`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> GetQuestionAsync(string name, st::CancellationToken cancellationToken) =>
            GetQuestionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a previously created question.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the question.
        /// Example: `projects/foo/locations/bar/questions/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Question GetQuestion(QuestionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuestion(new GetQuestionRequest
            {
                QuestionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created question.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the question.
        /// Example: `projects/foo/locations/bar/questions/1234`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> GetQuestionAsync(QuestionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuestionAsync(new GetQuestionRequest
            {
                QuestionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a previously created question.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the question.
        /// Example: `projects/foo/locations/bar/questions/1234`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> GetQuestionAsync(QuestionName name, st::CancellationToken cancellationToken) =>
            GetQuestionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a question.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Question CreateQuestion(CreateQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a question.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> CreateQuestionAsync(CreateQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a question.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> CreateQuestionAsync(CreateQuestionRequest request, st::CancellationToken cancellationToken) =>
            CreateQuestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a question.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project this data source reference belongs to.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="question">
        /// Required. The question to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Question CreateQuestion(string parent, Question question, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuestion(new CreateQuestionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Question = gax::GaxPreconditions.CheckNotNull(question, nameof(question)),
            }, callSettings);

        /// <summary>
        /// Creates a question.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project this data source reference belongs to.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="question">
        /// Required. The question to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> CreateQuestionAsync(string parent, Question question, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuestionAsync(new CreateQuestionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Question = gax::GaxPreconditions.CheckNotNull(question, nameof(question)),
            }, callSettings);

        /// <summary>
        /// Creates a question.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project this data source reference belongs to.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="question">
        /// Required. The question to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> CreateQuestionAsync(string parent, Question question, st::CancellationToken cancellationToken) =>
            CreateQuestionAsync(parent, question, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a question.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project this data source reference belongs to.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="question">
        /// Required. The question to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Question CreateQuestion(gagr::LocationName parent, Question question, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuestion(new CreateQuestionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Question = gax::GaxPreconditions.CheckNotNull(question, nameof(question)),
            }, callSettings);

        /// <summary>
        /// Creates a question.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project this data source reference belongs to.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="question">
        /// Required. The question to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> CreateQuestionAsync(gagr::LocationName parent, Question question, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuestionAsync(new CreateQuestionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Question = gax::GaxPreconditions.CheckNotNull(question, nameof(question)),
            }, callSettings);

        /// <summary>
        /// Creates a question.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project this data source reference belongs to.
        /// Example: `projects/foo/locations/bar`
        /// </param>
        /// <param name="question">
        /// Required. The question to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> CreateQuestionAsync(gagr::LocationName parent, Question question, st::CancellationToken cancellationToken) =>
            CreateQuestionAsync(parent, question, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes an interpretation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Question ExecuteQuestion(ExecuteQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes an interpretation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> ExecuteQuestionAsync(ExecuteQuestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes an interpretation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> ExecuteQuestionAsync(ExecuteQuestionRequest request, st::CancellationToken cancellationToken) =>
            ExecuteQuestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes an interpretation.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the question.
        /// Example: `projects/foo/locations/bar/questions/1234`
        /// </param>
        /// <param name="interpretationIndex">
        /// Required. Index of the interpretation to execute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Question ExecuteQuestion(string name, int interpretationIndex, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteQuestion(new ExecuteQuestionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InterpretationIndex = interpretationIndex,
            }, callSettings);

        /// <summary>
        /// Executes an interpretation.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the question.
        /// Example: `projects/foo/locations/bar/questions/1234`
        /// </param>
        /// <param name="interpretationIndex">
        /// Required. Index of the interpretation to execute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> ExecuteQuestionAsync(string name, int interpretationIndex, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteQuestionAsync(new ExecuteQuestionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InterpretationIndex = interpretationIndex,
            }, callSettings);

        /// <summary>
        /// Executes an interpretation.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the question.
        /// Example: `projects/foo/locations/bar/questions/1234`
        /// </param>
        /// <param name="interpretationIndex">
        /// Required. Index of the interpretation to execute.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Question> ExecuteQuestionAsync(string name, int interpretationIndex, st::CancellationToken cancellationToken) =>
            ExecuteQuestionAsync(name, interpretationIndex, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets previously created user feedback.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserFeedback GetUserFeedback(GetUserFeedbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets previously created user feedback.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserFeedback> GetUserFeedbackAsync(GetUserFeedbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets previously created user feedback.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserFeedback> GetUserFeedbackAsync(GetUserFeedbackRequest request, st::CancellationToken cancellationToken) =>
            GetUserFeedbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets previously created user feedback.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the user feedback.
        /// User feedback is a singleton resource on a Question.
        /// Example: `projects/foo/locations/bar/questions/1234/userFeedback`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserFeedback GetUserFeedback(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserFeedback(new GetUserFeedbackRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets previously created user feedback.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the user feedback.
        /// User feedback is a singleton resource on a Question.
        /// Example: `projects/foo/locations/bar/questions/1234/userFeedback`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserFeedback> GetUserFeedbackAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserFeedbackAsync(new GetUserFeedbackRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets previously created user feedback.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the user feedback.
        /// User feedback is a singleton resource on a Question.
        /// Example: `projects/foo/locations/bar/questions/1234/userFeedback`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserFeedback> GetUserFeedbackAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserFeedbackAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets previously created user feedback.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the user feedback.
        /// User feedback is a singleton resource on a Question.
        /// Example: `projects/foo/locations/bar/questions/1234/userFeedback`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserFeedback GetUserFeedback(UserFeedbackName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserFeedback(new GetUserFeedbackRequest
            {
                UserFeedbackName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets previously created user feedback.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the user feedback.
        /// User feedback is a singleton resource on a Question.
        /// Example: `projects/foo/locations/bar/questions/1234/userFeedback`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserFeedback> GetUserFeedbackAsync(UserFeedbackName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserFeedbackAsync(new GetUserFeedbackRequest
            {
                UserFeedbackName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets previously created user feedback.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier for the user feedback.
        /// User feedback is a singleton resource on a Question.
        /// Example: `projects/foo/locations/bar/questions/1234/userFeedback`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserFeedback> GetUserFeedbackAsync(UserFeedbackName name, st::CancellationToken cancellationToken) =>
            GetUserFeedbackAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates user feedback. This creates user feedback if there was none before
        /// (upsert).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserFeedback UpdateUserFeedback(UpdateUserFeedbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates user feedback. This creates user feedback if there was none before
        /// (upsert).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserFeedback> UpdateUserFeedbackAsync(UpdateUserFeedbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates user feedback. This creates user feedback if there was none before
        /// (upsert).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserFeedback> UpdateUserFeedbackAsync(UpdateUserFeedbackRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserFeedbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates user feedback. This creates user feedback if there was none before
        /// (upsert).
        /// </summary>
        /// <param name="userFeedback">
        /// Required. The user feedback to update. This can be called even if there is no
        /// user feedback so far.
        /// The feedback's name field is used to identify the user feedback (and the
        /// corresponding question) to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserFeedback UpdateUserFeedback(UserFeedback userFeedback, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserFeedback(new UpdateUserFeedbackRequest
            {
                UserFeedback = gax::GaxPreconditions.CheckNotNull(userFeedback, nameof(userFeedback)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates user feedback. This creates user feedback if there was none before
        /// (upsert).
        /// </summary>
        /// <param name="userFeedback">
        /// Required. The user feedback to update. This can be called even if there is no
        /// user feedback so far.
        /// The feedback's name field is used to identify the user feedback (and the
        /// corresponding question) to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserFeedback> UpdateUserFeedbackAsync(UserFeedback userFeedback, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserFeedbackAsync(new UpdateUserFeedbackRequest
            {
                UserFeedback = gax::GaxPreconditions.CheckNotNull(userFeedback, nameof(userFeedback)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates user feedback. This creates user feedback if there was none before
        /// (upsert).
        /// </summary>
        /// <param name="userFeedback">
        /// Required. The user feedback to update. This can be called even if there is no
        /// user feedback so far.
        /// The feedback's name field is used to identify the user feedback (and the
        /// corresponding question) to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserFeedback> UpdateUserFeedbackAsync(UserFeedback userFeedback, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUserFeedbackAsync(userFeedback, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>QuestionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to interpret natural language queries.
    /// The service allows to create `Question` resources that are interpreted and
    /// are filled with one or more interpretations if the question could be
    /// interpreted. Once a `Question` resource is created and has at least one
    /// interpretation, an interpretation can be chosen for execution, which
    /// triggers a query to the backend (for BigQuery, it will create a job).
    /// Upon successful execution of that interpretation, backend specific
    /// information will be returned so that the client can retrieve the results
    /// from the backend.
    /// 
    /// The `Question` resources are named `projects/*/locations/*/questions/*`.
    /// 
    /// The `Question` resource has a singletion sub-resource `UserFeedback` named
    /// `projects/*/locations/*/questions/*/userFeedback`, which allows access to
    /// user feedback.
    /// </remarks>
    public sealed partial class QuestionServiceClientImpl : QuestionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetQuestionRequest, Question> _callGetQuestion;

        private readonly gaxgrpc::ApiCall<CreateQuestionRequest, Question> _callCreateQuestion;

        private readonly gaxgrpc::ApiCall<ExecuteQuestionRequest, Question> _callExecuteQuestion;

        private readonly gaxgrpc::ApiCall<GetUserFeedbackRequest, UserFeedback> _callGetUserFeedback;

        private readonly gaxgrpc::ApiCall<UpdateUserFeedbackRequest, UserFeedback> _callUpdateUserFeedback;

        /// <summary>
        /// Constructs a client wrapper for the QuestionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="QuestionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public QuestionServiceClientImpl(QuestionService.QuestionServiceClient grpcClient, QuestionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            QuestionServiceSettings effectiveSettings = settings ?? QuestionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callGetQuestion = clientHelper.BuildApiCall<GetQuestionRequest, Question>("GetQuestion", grpcClient.GetQuestionAsync, grpcClient.GetQuestion, effectiveSettings.GetQuestionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetQuestion);
            Modify_GetQuestionApiCall(ref _callGetQuestion);
            _callCreateQuestion = clientHelper.BuildApiCall<CreateQuestionRequest, Question>("CreateQuestion", grpcClient.CreateQuestionAsync, grpcClient.CreateQuestion, effectiveSettings.CreateQuestionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateQuestion);
            Modify_CreateQuestionApiCall(ref _callCreateQuestion);
            _callExecuteQuestion = clientHelper.BuildApiCall<ExecuteQuestionRequest, Question>("ExecuteQuestion", grpcClient.ExecuteQuestionAsync, grpcClient.ExecuteQuestion, effectiveSettings.ExecuteQuestionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExecuteQuestion);
            Modify_ExecuteQuestionApiCall(ref _callExecuteQuestion);
            _callGetUserFeedback = clientHelper.BuildApiCall<GetUserFeedbackRequest, UserFeedback>("GetUserFeedback", grpcClient.GetUserFeedbackAsync, grpcClient.GetUserFeedback, effectiveSettings.GetUserFeedbackSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUserFeedback);
            Modify_GetUserFeedbackApiCall(ref _callGetUserFeedback);
            _callUpdateUserFeedback = clientHelper.BuildApiCall<UpdateUserFeedbackRequest, UserFeedback>("UpdateUserFeedback", grpcClient.UpdateUserFeedbackAsync, grpcClient.UpdateUserFeedback, effectiveSettings.UpdateUserFeedbackSettings).WithGoogleRequestParam("user_feedback.name", request => request.UserFeedback?.Name);
            Modify_ApiCall(ref _callUpdateUserFeedback);
            Modify_UpdateUserFeedbackApiCall(ref _callUpdateUserFeedback);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetQuestionApiCall(ref gaxgrpc::ApiCall<GetQuestionRequest, Question> call);

        partial void Modify_CreateQuestionApiCall(ref gaxgrpc::ApiCall<CreateQuestionRequest, Question> call);

        partial void Modify_ExecuteQuestionApiCall(ref gaxgrpc::ApiCall<ExecuteQuestionRequest, Question> call);

        partial void Modify_GetUserFeedbackApiCall(ref gaxgrpc::ApiCall<GetUserFeedbackRequest, UserFeedback> call);

        partial void Modify_UpdateUserFeedbackApiCall(ref gaxgrpc::ApiCall<UpdateUserFeedbackRequest, UserFeedback> call);

        partial void OnConstruction(QuestionService.QuestionServiceClient grpcClient, QuestionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC QuestionService client</summary>
        public override QuestionService.QuestionServiceClient GrpcClient { get; }

        partial void Modify_GetQuestionRequest(ref GetQuestionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateQuestionRequest(ref CreateQuestionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExecuteQuestionRequest(ref ExecuteQuestionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUserFeedbackRequest(ref GetUserFeedbackRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserFeedbackRequest(ref UpdateUserFeedbackRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a previously created question.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Question GetQuestion(GetQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQuestionRequest(ref request, ref callSettings);
            return _callGetQuestion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a previously created question.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Question> GetQuestionAsync(GetQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQuestionRequest(ref request, ref callSettings);
            return _callGetQuestion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a question.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Question CreateQuestion(CreateQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQuestionRequest(ref request, ref callSettings);
            return _callCreateQuestion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a question.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Question> CreateQuestionAsync(CreateQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQuestionRequest(ref request, ref callSettings);
            return _callCreateQuestion.Async(request, callSettings);
        }

        /// <summary>
        /// Executes an interpretation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Question ExecuteQuestion(ExecuteQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteQuestionRequest(ref request, ref callSettings);
            return _callExecuteQuestion.Sync(request, callSettings);
        }

        /// <summary>
        /// Executes an interpretation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Question> ExecuteQuestionAsync(ExecuteQuestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteQuestionRequest(ref request, ref callSettings);
            return _callExecuteQuestion.Async(request, callSettings);
        }

        /// <summary>
        /// Gets previously created user feedback.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserFeedback GetUserFeedback(GetUserFeedbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserFeedbackRequest(ref request, ref callSettings);
            return _callGetUserFeedback.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets previously created user feedback.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserFeedback> GetUserFeedbackAsync(GetUserFeedbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserFeedbackRequest(ref request, ref callSettings);
            return _callGetUserFeedback.Async(request, callSettings);
        }

        /// <summary>
        /// Updates user feedback. This creates user feedback if there was none before
        /// (upsert).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserFeedback UpdateUserFeedback(UpdateUserFeedbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserFeedbackRequest(ref request, ref callSettings);
            return _callUpdateUserFeedback.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates user feedback. This creates user feedback if there was none before
        /// (upsert).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserFeedback> UpdateUserFeedbackAsync(UpdateUserFeedbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserFeedbackRequest(ref request, ref callSettings);
            return _callUpdateUserFeedback.Async(request, callSettings);
        }
    }
}
