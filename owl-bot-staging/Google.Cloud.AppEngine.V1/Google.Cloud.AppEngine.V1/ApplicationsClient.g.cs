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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.AppEngine.V1
{
    /// <summary>Settings for <see cref="ApplicationsClient"/> instances.</summary>
    public sealed partial class ApplicationsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ApplicationsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ApplicationsSettings"/>.</returns>
        public static ApplicationsSettings GetDefault() => new ApplicationsSettings();

        /// <summary>Constructs a new <see cref="ApplicationsSettings"/> object with default settings.</summary>
        public ApplicationsSettings()
        {
        }

        private ApplicationsSettings(ApplicationsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetApplicationSettings = existing.GetApplicationSettings;
            CreateApplicationSettings = existing.CreateApplicationSettings;
            CreateApplicationOperationsSettings = existing.CreateApplicationOperationsSettings.Clone();
            UpdateApplicationSettings = existing.UpdateApplicationSettings;
            UpdateApplicationOperationsSettings = existing.UpdateApplicationOperationsSettings.Clone();
            RepairApplicationSettings = existing.RepairApplicationSettings;
            RepairApplicationOperationsSettings = existing.RepairApplicationOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ApplicationsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationsClient.GetApplication</c> and <c>ApplicationsClient.GetApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationsClient.CreateApplication</c> and <c>ApplicationsClient.CreateApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApplicationsClient.CreateApplication</c> and
        /// <c>ApplicationsClient.CreateApplicationAsync</c>.
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
        public lro::OperationsSettings CreateApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationsClient.UpdateApplication</c> and <c>ApplicationsClient.UpdateApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApplicationsClient.UpdateApplication</c> and
        /// <c>ApplicationsClient.UpdateApplicationAsync</c>.
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
        public lro::OperationsSettings UpdateApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApplicationsClient.RepairApplication</c> and <c>ApplicationsClient.RepairApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RepairApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApplicationsClient.RepairApplication</c> and
        /// <c>ApplicationsClient.RepairApplicationAsync</c>.
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
        public lro::OperationsSettings RepairApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ApplicationsSettings"/> object.</returns>
        public ApplicationsSettings Clone() => new ApplicationsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ApplicationsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ApplicationsClientBuilder : gaxgrpc::ClientBuilderBase<ApplicationsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ApplicationsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ApplicationsClientBuilder() : base(ApplicationsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ApplicationsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ApplicationsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ApplicationsClient Build()
        {
            ApplicationsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ApplicationsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ApplicationsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ApplicationsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ApplicationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ApplicationsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ApplicationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ApplicationsClient.ChannelPool;
    }

    /// <summary>Applications client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages App Engine applications.
    /// </remarks>
    public abstract partial class ApplicationsClient
    {
        /// <summary>
        /// The default endpoint for the Applications service, which is a host of "appengine.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "appengine.googleapis.com:443";

        /// <summary>The default Applications scopes.</summary>
        /// <remarks>
        /// The default Applications scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/appengine.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/appengine.admin",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Applications.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ApplicationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApplicationsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ApplicationsClient"/>.</returns>
        public static stt::Task<ApplicationsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ApplicationsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ApplicationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApplicationsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ApplicationsClient"/>.</returns>
        public static ApplicationsClient Create() => new ApplicationsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ApplicationsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ApplicationsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ApplicationsClient"/>.</returns>
        internal static ApplicationsClient Create(grpccore::CallInvoker callInvoker, ApplicationsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Applications.ApplicationsClient grpcClient = new Applications.ApplicationsClient(callInvoker);
            return new ApplicationsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Applications client</summary>
        public virtual Applications.ApplicationsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an application.
        /// </summary>
        /// <param name="name">
        /// Name of the Application resource to get. Example: `apps/myapp`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplication(new GetApplicationRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets information about an application.
        /// </summary>
        /// <param name="name">
        /// Name of the Application resource to get. Example: `apps/myapp`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationAsync(new GetApplicationRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets information about an application.
        /// </summary>
        /// <param name="name">
        /// Name of the Application resource to get. Example: `apps/myapp`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an App Engine application for a Google Cloud Platform project.
        /// Required fields:
        /// 
        /// * `id` - The ID of the target Cloud Platform project.
        /// * *location* - The [region](https://cloud.google.com/appengine/docs/locations) where you want the App Engine application located.
        /// 
        /// For more information about App Engine applications, see [Managing Projects, Applications, and Billing](https://cloud.google.com/appengine/docs/standard/python/console/).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadataV1> CreateApplication(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an App Engine application for a Google Cloud Platform project.
        /// Required fields:
        /// 
        /// * `id` - The ID of the target Cloud Platform project.
        /// * *location* - The [region](https://cloud.google.com/appengine/docs/locations) where you want the App Engine application located.
        /// 
        /// For more information about App Engine applications, see [Managing Projects, Applications, and Billing](https://cloud.google.com/appengine/docs/standard/python/console/).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadataV1>> CreateApplicationAsync(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an App Engine application for a Google Cloud Platform project.
        /// Required fields:
        /// 
        /// * `id` - The ID of the target Cloud Platform project.
        /// * *location* - The [region](https://cloud.google.com/appengine/docs/locations) where you want the App Engine application located.
        /// 
        /// For more information about App Engine applications, see [Managing Projects, Applications, and Billing](https://cloud.google.com/appengine/docs/standard/python/console/).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadataV1>> CreateApplicationAsync(CreateApplicationRequest request, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateApplication</c>.</summary>
        public virtual lro::OperationsClient CreateApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Application, OperationMetadataV1> PollOnceCreateApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadataV1>> PollOnceCreateApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified Application resource.
        /// You can update the following fields:
        /// 
        /// * `auth_domain` - Google authentication domain for controlling user access to the application.
        /// * `default_cookie_expiration` - Cookie expiration policy for the application.
        /// * `iap` - Identity-Aware Proxy properties for the application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadataV1> UpdateApplication(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified Application resource.
        /// You can update the following fields:
        /// 
        /// * `auth_domain` - Google authentication domain for controlling user access to the application.
        /// * `default_cookie_expiration` - Cookie expiration policy for the application.
        /// * `iap` - Identity-Aware Proxy properties for the application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadataV1>> UpdateApplicationAsync(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified Application resource.
        /// You can update the following fields:
        /// 
        /// * `auth_domain` - Google authentication domain for controlling user access to the application.
        /// * `default_cookie_expiration` - Cookie expiration policy for the application.
        /// * `iap` - Identity-Aware Proxy properties for the application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadataV1>> UpdateApplicationAsync(UpdateApplicationRequest request, st::CancellationToken cancellationToken) =>
            UpdateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateApplication</c>.</summary>
        public virtual lro::OperationsClient UpdateApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Application, OperationMetadataV1> PollOnceUpdateApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadataV1>> PollOnceUpdateApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateApplicationOperationsClient, callSettings);

        /// <summary>
        /// Recreates the required App Engine features for the specified App Engine
        /// application, for example a Cloud Storage bucket or App Engine service
        /// account.
        /// Use this method if you receive an error message about a missing feature,
        /// for example, *Error retrieving the App Engine service account*.
        /// If you have deleted your App Engine service account, this will
        /// not be able to recreate it. Instead, you should attempt to use the
        /// IAM undelete API if possible at https://cloud.google.com/iam/reference/rest/v1/projects.serviceAccounts/undelete?apix_params=%7B"name"%3A"projects%2F-%2FserviceAccounts%2Funique_id"%2C"resource"%3A%7B%7D%7D .
        /// If the deletion was recent, the numeric ID can be found in the Cloud
        /// Console Activity Log.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Application, OperationMetadataV1> RepairApplication(RepairApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Recreates the required App Engine features for the specified App Engine
        /// application, for example a Cloud Storage bucket or App Engine service
        /// account.
        /// Use this method if you receive an error message about a missing feature,
        /// for example, *Error retrieving the App Engine service account*.
        /// If you have deleted your App Engine service account, this will
        /// not be able to recreate it. Instead, you should attempt to use the
        /// IAM undelete API if possible at https://cloud.google.com/iam/reference/rest/v1/projects.serviceAccounts/undelete?apix_params=%7B"name"%3A"projects%2F-%2FserviceAccounts%2Funique_id"%2C"resource"%3A%7B%7D%7D .
        /// If the deletion was recent, the numeric ID can be found in the Cloud
        /// Console Activity Log.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadataV1>> RepairApplicationAsync(RepairApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Recreates the required App Engine features for the specified App Engine
        /// application, for example a Cloud Storage bucket or App Engine service
        /// account.
        /// Use this method if you receive an error message about a missing feature,
        /// for example, *Error retrieving the App Engine service account*.
        /// If you have deleted your App Engine service account, this will
        /// not be able to recreate it. Instead, you should attempt to use the
        /// IAM undelete API if possible at https://cloud.google.com/iam/reference/rest/v1/projects.serviceAccounts/undelete?apix_params=%7B"name"%3A"projects%2F-%2FserviceAccounts%2Funique_id"%2C"resource"%3A%7B%7D%7D .
        /// If the deletion was recent, the numeric ID can be found in the Cloud
        /// Console Activity Log.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadataV1>> RepairApplicationAsync(RepairApplicationRequest request, st::CancellationToken cancellationToken) =>
            RepairApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RepairApplication</c>.</summary>
        public virtual lro::OperationsClient RepairApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RepairApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Application, OperationMetadataV1> PollOnceRepairApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RepairApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RepairApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Application, OperationMetadataV1>> PollOnceRepairApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Application, OperationMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RepairApplicationOperationsClient, callSettings);
    }

    /// <summary>Applications client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages App Engine applications.
    /// </remarks>
    public sealed partial class ApplicationsClientImpl : ApplicationsClient
    {
        private readonly gaxgrpc::ApiCall<GetApplicationRequest, Application> _callGetApplication;

        private readonly gaxgrpc::ApiCall<CreateApplicationRequest, lro::Operation> _callCreateApplication;

        private readonly gaxgrpc::ApiCall<UpdateApplicationRequest, lro::Operation> _callUpdateApplication;

        private readonly gaxgrpc::ApiCall<RepairApplicationRequest, lro::Operation> _callRepairApplication;

        /// <summary>
        /// Constructs a client wrapper for the Applications service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApplicationsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ApplicationsClientImpl(Applications.ApplicationsClient grpcClient, ApplicationsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ApplicationsSettings effectiveSettings = settings ?? ApplicationsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateApplicationOperationsSettings, logger);
            UpdateApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateApplicationOperationsSettings, logger);
            RepairApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RepairApplicationOperationsSettings, logger);
            _callGetApplication = clientHelper.BuildApiCall<GetApplicationRequest, Application>("GetApplication", grpcClient.GetApplicationAsync, grpcClient.GetApplication, effectiveSettings.GetApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApplication);
            Modify_GetApplicationApiCall(ref _callGetApplication);
            _callCreateApplication = clientHelper.BuildApiCall<CreateApplicationRequest, lro::Operation>("CreateApplication", grpcClient.CreateApplicationAsync, grpcClient.CreateApplication, effectiveSettings.CreateApplicationSettings);
            Modify_ApiCall(ref _callCreateApplication);
            Modify_CreateApplicationApiCall(ref _callCreateApplication);
            _callUpdateApplication = clientHelper.BuildApiCall<UpdateApplicationRequest, lro::Operation>("UpdateApplication", grpcClient.UpdateApplicationAsync, grpcClient.UpdateApplication, effectiveSettings.UpdateApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateApplication);
            Modify_UpdateApplicationApiCall(ref _callUpdateApplication);
            _callRepairApplication = clientHelper.BuildApiCall<RepairApplicationRequest, lro::Operation>("RepairApplication", grpcClient.RepairApplicationAsync, grpcClient.RepairApplication, effectiveSettings.RepairApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRepairApplication);
            Modify_RepairApplicationApiCall(ref _callRepairApplication);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApplicationApiCall(ref gaxgrpc::ApiCall<GetApplicationRequest, Application> call);

        partial void Modify_CreateApplicationApiCall(ref gaxgrpc::ApiCall<CreateApplicationRequest, lro::Operation> call);

        partial void Modify_UpdateApplicationApiCall(ref gaxgrpc::ApiCall<UpdateApplicationRequest, lro::Operation> call);

        partial void Modify_RepairApplicationApiCall(ref gaxgrpc::ApiCall<RepairApplicationRequest, lro::Operation> call);

        partial void OnConstruction(Applications.ApplicationsClient grpcClient, ApplicationsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Applications client</summary>
        public override Applications.ApplicationsClient GrpcClient { get; }

        partial void Modify_GetApplicationRequest(ref GetApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApplicationRequest(ref CreateApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApplicationRequest(ref UpdateApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RepairApplicationRequest(ref RepairApplicationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets information about an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateApplication</c>.</summary>
        public override lro::OperationsClient CreateApplicationOperationsClient { get; }

        /// <summary>
        /// Creates an App Engine application for a Google Cloud Platform project.
        /// Required fields:
        /// 
        /// * `id` - The ID of the target Cloud Platform project.
        /// * *location* - The [region](https://cloud.google.com/appengine/docs/locations) where you want the App Engine application located.
        /// 
        /// For more information about App Engine applications, see [Managing Projects, Applications, and Billing](https://cloud.google.com/appengine/docs/standard/python/console/).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Application, OperationMetadataV1> CreateApplication(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadataV1>(_callCreateApplication.Sync(request, callSettings), CreateApplicationOperationsClient);
        }

        /// <summary>
        /// Creates an App Engine application for a Google Cloud Platform project.
        /// Required fields:
        /// 
        /// * `id` - The ID of the target Cloud Platform project.
        /// * *location* - The [region](https://cloud.google.com/appengine/docs/locations) where you want the App Engine application located.
        /// 
        /// For more information about App Engine applications, see [Managing Projects, Applications, and Billing](https://cloud.google.com/appengine/docs/standard/python/console/).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Application, OperationMetadataV1>> CreateApplicationAsync(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadataV1>(await _callCreateApplication.Async(request, callSettings).ConfigureAwait(false), CreateApplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateApplication</c>.</summary>
        public override lro::OperationsClient UpdateApplicationOperationsClient { get; }

        /// <summary>
        /// Updates the specified Application resource.
        /// You can update the following fields:
        /// 
        /// * `auth_domain` - Google authentication domain for controlling user access to the application.
        /// * `default_cookie_expiration` - Cookie expiration policy for the application.
        /// * `iap` - Identity-Aware Proxy properties for the application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Application, OperationMetadataV1> UpdateApplication(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadataV1>(_callUpdateApplication.Sync(request, callSettings), UpdateApplicationOperationsClient);
        }

        /// <summary>
        /// Updates the specified Application resource.
        /// You can update the following fields:
        /// 
        /// * `auth_domain` - Google authentication domain for controlling user access to the application.
        /// * `default_cookie_expiration` - Cookie expiration policy for the application.
        /// * `iap` - Identity-Aware Proxy properties for the application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Application, OperationMetadataV1>> UpdateApplicationAsync(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadataV1>(await _callUpdateApplication.Async(request, callSettings).ConfigureAwait(false), UpdateApplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RepairApplication</c>.</summary>
        public override lro::OperationsClient RepairApplicationOperationsClient { get; }

        /// <summary>
        /// Recreates the required App Engine features for the specified App Engine
        /// application, for example a Cloud Storage bucket or App Engine service
        /// account.
        /// Use this method if you receive an error message about a missing feature,
        /// for example, *Error retrieving the App Engine service account*.
        /// If you have deleted your App Engine service account, this will
        /// not be able to recreate it. Instead, you should attempt to use the
        /// IAM undelete API if possible at https://cloud.google.com/iam/reference/rest/v1/projects.serviceAccounts/undelete?apix_params=%7B"name"%3A"projects%2F-%2FserviceAccounts%2Funique_id"%2C"resource"%3A%7B%7D%7D .
        /// If the deletion was recent, the numeric ID can be found in the Cloud
        /// Console Activity Log.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Application, OperationMetadataV1> RepairApplication(RepairApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepairApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadataV1>(_callRepairApplication.Sync(request, callSettings), RepairApplicationOperationsClient);
        }

        /// <summary>
        /// Recreates the required App Engine features for the specified App Engine
        /// application, for example a Cloud Storage bucket or App Engine service
        /// account.
        /// Use this method if you receive an error message about a missing feature,
        /// for example, *Error retrieving the App Engine service account*.
        /// If you have deleted your App Engine service account, this will
        /// not be able to recreate it. Instead, you should attempt to use the
        /// IAM undelete API if possible at https://cloud.google.com/iam/reference/rest/v1/projects.serviceAccounts/undelete?apix_params=%7B"name"%3A"projects%2F-%2FserviceAccounts%2Funique_id"%2C"resource"%3A%7B%7D%7D .
        /// If the deletion was recent, the numeric ID can be found in the Cloud
        /// Console Activity Log.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Application, OperationMetadataV1>> RepairApplicationAsync(RepairApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepairApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Application, OperationMetadataV1>(await _callRepairApplication.Async(request, callSettings).ConfigureAwait(false), RepairApplicationOperationsClient);
        }
    }

    public static partial class Applications
    {
        public partial class ApplicationsClient
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
