// Copyright 2019 Google LLC
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
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>
    /// Settings for a <see cref="CompanyServiceClient"/>.
    /// </summary>
    public sealed partial class CompanyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CompanyServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CompanyServiceSettings"/>.
        /// </returns>
        public static CompanyServiceSettings GetDefault() => new CompanyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CompanyServiceSettings"/> object with default settings.
        /// </summary>
        public CompanyServiceSettings() { }

        private CompanyServiceSettings(CompanyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateCompanySettings = existing.CreateCompanySettings;
            GetCompanySettings = existing.GetCompanySettings;
            UpdateCompanySettings = existing.UpdateCompanySettings;
            DeleteCompanySettings = existing.DeleteCompanySettings;
            ListCompaniesSettings = existing.ListCompaniesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CompanyServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="CompanyServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="CompanyServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="CompanyServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="CompanyServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="CompanyServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="CompanyServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="CompanyServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="CompanyServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.CreateCompany</c> and <c>CompanyServiceClient.CreateCompanyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CompanyServiceClient.CreateCompany</c> and
        /// <c>CompanyServiceClient.CreateCompanyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateCompanySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.GetCompany</c> and <c>CompanyServiceClient.GetCompanyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CompanyServiceClient.GetCompany</c> and
        /// <c>CompanyServiceClient.GetCompanyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetCompanySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.UpdateCompany</c> and <c>CompanyServiceClient.UpdateCompanyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CompanyServiceClient.UpdateCompany</c> and
        /// <c>CompanyServiceClient.UpdateCompanyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCompanySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.DeleteCompany</c> and <c>CompanyServiceClient.DeleteCompanyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CompanyServiceClient.DeleteCompany</c> and
        /// <c>CompanyServiceClient.DeleteCompanyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCompanySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanyServiceClient.ListCompanies</c> and <c>CompanyServiceClient.ListCompaniesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CompanyServiceClient.ListCompanies</c> and
        /// <c>CompanyServiceClient.ListCompaniesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListCompaniesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="CompanyServiceSettings"/> object.</returns>
        public CompanyServiceSettings Clone() => new CompanyServiceSettings(this);
    }

    /// <summary>
    /// CompanyService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class CompanyServiceClient
    {
        /// <summary>
        /// The default endpoint for the CompanyService service, which is a host of "jobs.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("jobs.googleapis.com", 443);

        /// <summary>
        /// The default CompanyService scopes.
        /// </summary>
        /// <remarks>
        /// The default CompanyService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/jobs"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/jobs",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CompanyServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CompanyServiceClient client = await CompanyServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CompanyServiceClient.DefaultEndpoint.Host, CompanyServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CompanyServiceClient client = CompanyServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CompanyServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CompanyServiceClient"/>.</returns>
        public static async stt::Task<CompanyServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CompanyServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CompanyServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CompanyServiceClient client = CompanyServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Talent.V4Beta1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CompanyServiceClient.DefaultEndpoint.Host, CompanyServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CompanyServiceClient client = CompanyServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CompanyServiceSettings"/>.</param>
        /// <returns>The created <see cref="CompanyServiceClient"/>.</returns>
        public static CompanyServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CompanyServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CompanyServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CompanyServiceSettings"/>.</param>
        /// <returns>The created <see cref="CompanyServiceClient"/>.</returns>
        public static CompanyServiceClient Create(grpccore::Channel channel, CompanyServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CompanyServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CompanyServiceSettings"/>.</param>
        /// <returns>The created <see cref="CompanyServiceClient"/>.</returns>
        public static CompanyServiceClient Create(grpccore::CallInvoker callInvoker, CompanyServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CompanyService.CompanyServiceClient grpcClient = new CompanyService.CompanyServiceClient(callInvoker);
            return new CompanyServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, CompanyServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CompanyServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, CompanyServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CompanyServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC CompanyService client.
        /// </summary>
        public virtual CompanyService.CompanyServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the tenant under which the company is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="company">
        /// Required.
        ///
        /// The company to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> CreateCompanyAsync(
            TenantOrProjectNameOneof parent,
            Company company,
            gaxgrpc::CallSettings callSettings = null) => CreateCompanyAsync(
                new CreateCompanyRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
                },
                callSettings);

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the tenant under which the company is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="company">
        /// Required.
        ///
        /// The company to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> CreateCompanyAsync(
            TenantOrProjectNameOneof parent,
            Company company,
            st::CancellationToken cancellationToken) => CreateCompanyAsync(
                parent,
                company,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the tenant under which the company is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="company">
        /// Required.
        ///
        /// The company to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Company CreateCompany(
            TenantOrProjectNameOneof parent,
            Company company,
            gaxgrpc::CallSettings callSettings = null) => CreateCompany(
                new CreateCompanyRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
                },
                callSettings);

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the tenant under which the company is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="company">
        /// Required.
        ///
        /// The company to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> CreateCompanyAsync(
            string parent,
            Company company,
            gaxgrpc::CallSettings callSettings = null) => CreateCompanyAsync(
                new CreateCompanyRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
                },
                callSettings);

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the tenant under which the company is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="company">
        /// Required.
        ///
        /// The company to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> CreateCompanyAsync(
            string parent,
            Company company,
            st::CancellationToken cancellationToken) => CreateCompanyAsync(
                parent,
                company,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the tenant under which the company is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and a default tenant is created if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="company">
        /// Required.
        ///
        /// The company to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Company CreateCompany(
            string parent,
            Company company,
            gaxgrpc::CallSettings callSettings = null) => CreateCompany(
                new CreateCompanyRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
                },
                callSettings);

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> CreateCompanyAsync(
            CreateCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> CreateCompanyAsync(
            CreateCompanyRequest request,
            st::CancellationToken cancellationToken) => CreateCompanyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Company CreateCompany(
            CreateCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> GetCompanyAsync(
            CompanyNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => GetCompanyAsync(
                new GetCompanyRequest
                {
                    CompanyNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> GetCompanyAsync(
            CompanyNameOneof name,
            st::CancellationToken cancellationToken) => GetCompanyAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Company GetCompany(
            CompanyNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => GetCompany(
                new GetCompanyRequest
                {
                    CompanyNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> GetCompanyAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetCompanyAsync(
                new GetCompanyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> GetCompanyAsync(
            string name,
            st::CancellationToken cancellationToken) => GetCompanyAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be retrieved.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Company GetCompany(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetCompany(
                new GetCompanyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> GetCompanyAsync(
            GetCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> GetCompanyAsync(
            GetCompanyRequest request,
            st::CancellationToken cancellationToken) => GetCompanyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Company GetCompany(
            GetCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="company">
        /// Required.
        ///
        /// The company resource to replace the current resource in the system.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> UpdateCompanyAsync(
            Company company,
            gaxgrpc::CallSettings callSettings = null) => UpdateCompanyAsync(
                new UpdateCompanyRequest
                {
                    Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
                },
                callSettings);

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="company">
        /// Required.
        ///
        /// The company resource to replace the current resource in the system.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> UpdateCompanyAsync(
            Company company,
            st::CancellationToken cancellationToken) => UpdateCompanyAsync(
                company,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="company">
        /// Required.
        ///
        /// The company resource to replace the current resource in the system.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Company UpdateCompany(
            Company company,
            gaxgrpc::CallSettings callSettings = null) => UpdateCompany(
                new UpdateCompanyRequest
                {
                    Company = gax::GaxPreconditions.CheckNotNull(company, nameof(company)),
                },
                callSettings);

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> UpdateCompanyAsync(
            UpdateCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Company> UpdateCompanyAsync(
            UpdateCompanyRequest request,
            st::CancellationToken cancellationToken) => UpdateCompanyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Company UpdateCompany(
            UpdateCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteCompanyAsync(
            CompanyNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => DeleteCompanyAsync(
                new DeleteCompanyRequest
                {
                    CompanyNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteCompanyAsync(
            CompanyNameOneof name,
            st::CancellationToken cancellationToken) => DeleteCompanyAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteCompany(
            CompanyNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => DeleteCompany(
                new DeleteCompanyRequest
                {
                    CompanyNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteCompanyAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteCompanyAsync(
                new DeleteCompanyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteCompanyAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteCompanyAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="name">
        /// Required.
        ///
        /// The resource name of the company to be deleted.
        ///
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/companies/{company_id}", for
        /// example, "projects/api-test-project/tenants/foo/companies/bar".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project/companies/bar".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteCompany(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteCompany(
                new DeleteCompanyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteCompanyAsync(
            DeleteCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteCompanyAsync(
            DeleteCompanyRequest request,
            st::CancellationToken cancellationToken) => DeleteCompanyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteCompany(
            DeleteCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the tenant under which the company is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Company"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(
            TenantOrProjectNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCompaniesAsync(
                new ListCompaniesRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the tenant under which the company is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Company"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(
            TenantOrProjectNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCompanies(
                new ListCompaniesRequest
                {
                    ParentAsTenantOrProjectNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the tenant under which the company is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Company"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCompaniesAsync(
                new ListCompaniesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="parent">
        /// Required.
        ///
        /// Resource name of the tenant under which the company is created.
        ///
        /// The format is "projects/{project_id}/tenants/{tenant_id}", for example,
        /// "projects/api-test-project/tenant/foo".
        ///
        /// Tenant id is optional and the default tenant is used if unspecified, for
        /// example, "projects/api-test-project".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Company"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCompanies(
                new ListCompaniesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Company"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(
            ListCompaniesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Company"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(
            ListCompaniesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// CompanyService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class CompanyServiceClientImpl : CompanyServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateCompanyRequest, Company> _callCreateCompany;
        private readonly gaxgrpc::ApiCall<GetCompanyRequest, Company> _callGetCompany;
        private readonly gaxgrpc::ApiCall<UpdateCompanyRequest, Company> _callUpdateCompany;
        private readonly gaxgrpc::ApiCall<DeleteCompanyRequest, pbwkt::Empty> _callDeleteCompany;
        private readonly gaxgrpc::ApiCall<ListCompaniesRequest, ListCompaniesResponse> _callListCompanies;

        /// <summary>
        /// Constructs a client wrapper for the CompanyService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CompanyServiceSettings"/> used within this client </param>
        public CompanyServiceClientImpl(CompanyService.CompanyServiceClient grpcClient, CompanyServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CompanyServiceSettings effectiveSettings = settings ?? CompanyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateCompany = clientHelper.BuildApiCall<CreateCompanyRequest, Company>(
                GrpcClient.CreateCompanyAsync, GrpcClient.CreateCompany, effectiveSettings.CreateCompanySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetCompany = clientHelper.BuildApiCall<GetCompanyRequest, Company>(
                GrpcClient.GetCompanyAsync, GrpcClient.GetCompany, effectiveSettings.GetCompanySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callUpdateCompany = clientHelper.BuildApiCall<UpdateCompanyRequest, Company>(
                GrpcClient.UpdateCompanyAsync, GrpcClient.UpdateCompany, effectiveSettings.UpdateCompanySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"company.name={request.Company.Name}"));
            _callDeleteCompany = clientHelper.BuildApiCall<DeleteCompanyRequest, pbwkt::Empty>(
                GrpcClient.DeleteCompanyAsync, GrpcClient.DeleteCompany, effectiveSettings.DeleteCompanySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListCompanies = clientHelper.BuildApiCall<ListCompaniesRequest, ListCompaniesResponse>(
                GrpcClient.ListCompaniesAsync, GrpcClient.ListCompanies, effectiveSettings.ListCompaniesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            Modify_ApiCall(ref _callCreateCompany);
            Modify_CreateCompanyApiCall(ref _callCreateCompany);
            Modify_ApiCall(ref _callGetCompany);
            Modify_GetCompanyApiCall(ref _callGetCompany);
            Modify_ApiCall(ref _callUpdateCompany);
            Modify_UpdateCompanyApiCall(ref _callUpdateCompany);
            Modify_ApiCall(ref _callDeleteCompany);
            Modify_DeleteCompanyApiCall(ref _callDeleteCompany);
            Modify_ApiCall(ref _callListCompanies);
            Modify_ListCompaniesApiCall(ref _callListCompanies);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_CreateCompanyApiCall(ref gaxgrpc::ApiCall<CreateCompanyRequest, Company> call);
        partial void Modify_GetCompanyApiCall(ref gaxgrpc::ApiCall<GetCompanyRequest, Company> call);
        partial void Modify_UpdateCompanyApiCall(ref gaxgrpc::ApiCall<UpdateCompanyRequest, Company> call);
        partial void Modify_DeleteCompanyApiCall(ref gaxgrpc::ApiCall<DeleteCompanyRequest, pbwkt::Empty> call);
        partial void Modify_ListCompaniesApiCall(ref gaxgrpc::ApiCall<ListCompaniesRequest, ListCompaniesResponse> call);
        partial void OnConstruction(CompanyService.CompanyServiceClient grpcClient, CompanyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC CompanyService client.
        /// </summary>
        public override CompanyService.CompanyServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateCompanyRequest(ref CreateCompanyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetCompanyRequest(ref GetCompanyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateCompanyRequest(ref UpdateCompanyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteCompanyRequest(ref DeleteCompanyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListCompaniesRequest(ref ListCompaniesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Company> CreateCompanyAsync(
            CreateCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCompanyRequest(ref request, ref callSettings);
            return _callCreateCompany.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new company entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Company CreateCompany(
            CreateCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCompanyRequest(ref request, ref callSettings);
            return _callCreateCompany.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Company> GetCompanyAsync(
            GetCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompanyRequest(ref request, ref callSettings);
            return _callGetCompany.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves specified company.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Company GetCompany(
            GetCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompanyRequest(ref request, ref callSettings);
            return _callGetCompany.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Company> UpdateCompanyAsync(
            UpdateCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCompanyRequest(ref request, ref callSettings);
            return _callUpdateCompany.Async(request, callSettings);
        }

        /// <summary>
        /// Updates specified company.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Company UpdateCompany(
            UpdateCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCompanyRequest(ref request, ref callSettings);
            return _callUpdateCompany.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteCompanyAsync(
            DeleteCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCompanyRequest(ref request, ref callSettings);
            return _callDeleteCompany.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes specified company.
        /// Prerequisite: The company has no jobs associated with it.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteCompany(
            DeleteCompanyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCompanyRequest(ref request, ref callSettings);
            _callDeleteCompany.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Company"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListCompaniesResponse, Company> ListCompaniesAsync(
            ListCompaniesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCompaniesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCompaniesRequest, ListCompaniesResponse, Company>(_callListCompanies, request, callSettings);
        }

        /// <summary>
        /// Lists all companies associated with the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Company"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListCompaniesResponse, Company> ListCompanies(
            ListCompaniesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCompaniesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCompaniesRequest, ListCompaniesResponse, Company>(_callListCompanies, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListCompaniesRequest : gaxgrpc::IPageRequest { }
    public partial class ListCompaniesResponse : gaxgrpc::IPageResponse<Company>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Company> GetEnumerator() => Companies.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
