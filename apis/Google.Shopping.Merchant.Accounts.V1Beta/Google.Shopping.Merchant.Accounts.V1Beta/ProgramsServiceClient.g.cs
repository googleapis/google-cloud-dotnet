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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="ProgramsServiceClient"/> instances.</summary>
    public sealed partial class ProgramsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProgramsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProgramsServiceSettings"/>.</returns>
        public static ProgramsServiceSettings GetDefault() => new ProgramsServiceSettings();

        /// <summary>Constructs a new <see cref="ProgramsServiceSettings"/> object with default settings.</summary>
        public ProgramsServiceSettings()
        {
        }

        private ProgramsServiceSettings(ProgramsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetProgramSettings = existing.GetProgramSettings;
            ListProgramsSettings = existing.ListProgramsSettings;
            EnableProgramSettings = existing.EnableProgramSettings;
            DisableProgramSettings = existing.DisableProgramSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProgramsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProgramsServiceClient.GetProgram</c> and <c>ProgramsServiceClient.GetProgramAsync</c>.
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
        public gaxgrpc::CallSettings GetProgramSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProgramsServiceClient.ListPrograms</c> and <c>ProgramsServiceClient.ListProgramsAsync</c>.
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
        public gaxgrpc::CallSettings ListProgramsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProgramsServiceClient.EnableProgram</c> and <c>ProgramsServiceClient.EnableProgramAsync</c>.
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
        public gaxgrpc::CallSettings EnableProgramSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProgramsServiceClient.DisableProgram</c> and <c>ProgramsServiceClient.DisableProgramAsync</c>.
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
        public gaxgrpc::CallSettings DisableProgramSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProgramsServiceSettings"/> object.</returns>
        public ProgramsServiceSettings Clone() => new ProgramsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProgramsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ProgramsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProgramsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProgramsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProgramsServiceClientBuilder() : base(ProgramsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProgramsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProgramsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProgramsServiceClient Build()
        {
            ProgramsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProgramsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProgramsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProgramsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProgramsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProgramsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProgramsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProgramsServiceClient.ChannelPool;
    }

    /// <summary>ProgramsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for program management.
    /// 
    /// Programs provide a mechanism for adding functionality to merchant accounts. A
    /// typical example of this is the [Free product
    /// listings](https://support.google.com/merchants/topic/9240261?ref_topic=7257954,7259405,&amp;sjid=796648681813264022-EU)
    /// program, which enables products from a merchant's store to be shown across
    /// Google for free.
    /// 
    /// This service exposes methods to retrieve a merchant's
    /// participation in all available programs, in addition to methods for
    /// explicitly enabling or disabling participation in each program.
    /// </remarks>
    public abstract partial class ProgramsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProgramsService service, which is a host of "merchantapi.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default ProgramsService scopes.</summary>
        /// <remarks>
        /// The default ProgramsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProgramsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProgramsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProgramsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProgramsServiceClient"/>.</returns>
        public static stt::Task<ProgramsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProgramsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProgramsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProgramsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProgramsServiceClient"/>.</returns>
        public static ProgramsServiceClient Create() => new ProgramsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProgramsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProgramsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProgramsServiceClient"/>.</returns>
        internal static ProgramsServiceClient Create(grpccore::CallInvoker callInvoker, ProgramsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProgramsService.ProgramsServiceClient grpcClient = new ProgramsService.ProgramsServiceClient(callInvoker);
            return new ProgramsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProgramsService client</summary>
        public virtual ProgramsService.ProgramsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified program for the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Program GetProgram(GetProgramRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified program for the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> GetProgramAsync(GetProgramRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified program for the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> GetProgramAsync(GetProgramRequest request, st::CancellationToken cancellationToken) =>
            GetProgramAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified program for the account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program to retrieve.
        /// Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Program GetProgram(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProgram(new GetProgramRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified program for the account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program to retrieve.
        /// Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> GetProgramAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProgramAsync(new GetProgramRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified program for the account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program to retrieve.
        /// Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> GetProgramAsync(string name, st::CancellationToken cancellationToken) =>
            GetProgramAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified program for the account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program to retrieve.
        /// Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Program GetProgram(ProgramName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProgram(new GetProgramRequest
            {
                ProgramName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified program for the account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program to retrieve.
        /// Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> GetProgramAsync(ProgramName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProgramAsync(new GetProgramRequest
            {
                ProgramName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified program for the account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program to retrieve.
        /// Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> GetProgramAsync(ProgramName name, st::CancellationToken cancellationToken) =>
            GetProgramAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves all programs for the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Program"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProgramsResponse, Program> ListPrograms(ListProgramsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves all programs for the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Program"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProgramsResponse, Program> ListProgramsAsync(ListProgramsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves all programs for the account.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the account for which to retrieve all programs.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable sequence of <see cref="Program"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProgramsResponse, Program> ListPrograms(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProgramsRequest request = new ListProgramsRequest
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
            return ListPrograms(request, callSettings);
        }

        /// <summary>
        /// Retrieves all programs for the account.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the account for which to retrieve all programs.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Program"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProgramsResponse, Program> ListProgramsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProgramsRequest request = new ListProgramsRequest
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
            return ListProgramsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves all programs for the account.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the account for which to retrieve all programs.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable sequence of <see cref="Program"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProgramsResponse, Program> ListPrograms(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProgramsRequest request = new ListProgramsRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPrograms(request, callSettings);
        }

        /// <summary>
        /// Retrieves all programs for the account.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the account for which to retrieve all programs.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Program"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProgramsResponse, Program> ListProgramsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProgramsRequest request = new ListProgramsRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProgramsAsync(request, callSettings);
        }

        /// <summary>
        /// Enable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Program EnableProgram(EnableProgramRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> EnableProgramAsync(EnableProgramRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> EnableProgramAsync(EnableProgramRequest request, st::CancellationToken cancellationToken) =>
            EnableProgramAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to enable participation for the
        /// given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Program EnableProgram(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableProgram(new EnableProgramRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to enable participation for the
        /// given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> EnableProgramAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableProgramAsync(new EnableProgramRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to enable participation for the
        /// given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> EnableProgramAsync(string name, st::CancellationToken cancellationToken) =>
            EnableProgramAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to enable participation for the
        /// given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Program EnableProgram(ProgramName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableProgram(new EnableProgramRequest
            {
                ProgramName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to enable participation for the
        /// given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> EnableProgramAsync(ProgramName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableProgramAsync(new EnableProgramRequest
            {
                ProgramName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to enable participation for the
        /// given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> EnableProgramAsync(ProgramName name, st::CancellationToken cancellationToken) =>
            EnableProgramAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Program DisableProgram(DisableProgramRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> DisableProgramAsync(DisableProgramRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> DisableProgramAsync(DisableProgramRequest request, st::CancellationToken cancellationToken) =>
            DisableProgramAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to disable participation for
        /// the given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Program DisableProgram(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableProgram(new DisableProgramRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to disable participation for
        /// the given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> DisableProgramAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableProgramAsync(new DisableProgramRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to disable participation for
        /// the given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> DisableProgramAsync(string name, st::CancellationToken cancellationToken) =>
            DisableProgramAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to disable participation for
        /// the given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Program DisableProgram(ProgramName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableProgram(new DisableProgramRequest
            {
                ProgramName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to disable participation for
        /// the given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> DisableProgramAsync(ProgramName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableProgramAsync(new DisableProgramRequest
            {
                ProgramName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the program for which to disable participation for
        /// the given account. Format: `accounts/{account}/programs/{program}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Program> DisableProgramAsync(ProgramName name, st::CancellationToken cancellationToken) =>
            DisableProgramAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProgramsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for program management.
    /// 
    /// Programs provide a mechanism for adding functionality to merchant accounts. A
    /// typical example of this is the [Free product
    /// listings](https://support.google.com/merchants/topic/9240261?ref_topic=7257954,7259405,&amp;sjid=796648681813264022-EU)
    /// program, which enables products from a merchant's store to be shown across
    /// Google for free.
    /// 
    /// This service exposes methods to retrieve a merchant's
    /// participation in all available programs, in addition to methods for
    /// explicitly enabling or disabling participation in each program.
    /// </remarks>
    public sealed partial class ProgramsServiceClientImpl : ProgramsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetProgramRequest, Program> _callGetProgram;

        private readonly gaxgrpc::ApiCall<ListProgramsRequest, ListProgramsResponse> _callListPrograms;

        private readonly gaxgrpc::ApiCall<EnableProgramRequest, Program> _callEnableProgram;

        private readonly gaxgrpc::ApiCall<DisableProgramRequest, Program> _callDisableProgram;

        /// <summary>
        /// Constructs a client wrapper for the ProgramsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProgramsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProgramsServiceClientImpl(ProgramsService.ProgramsServiceClient grpcClient, ProgramsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProgramsServiceSettings effectiveSettings = settings ?? ProgramsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetProgram = clientHelper.BuildApiCall<GetProgramRequest, Program>("GetProgram", grpcClient.GetProgramAsync, grpcClient.GetProgram, effectiveSettings.GetProgramSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProgram);
            Modify_GetProgramApiCall(ref _callGetProgram);
            _callListPrograms = clientHelper.BuildApiCall<ListProgramsRequest, ListProgramsResponse>("ListPrograms", grpcClient.ListProgramsAsync, grpcClient.ListPrograms, effectiveSettings.ListProgramsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPrograms);
            Modify_ListProgramsApiCall(ref _callListPrograms);
            _callEnableProgram = clientHelper.BuildApiCall<EnableProgramRequest, Program>("EnableProgram", grpcClient.EnableProgramAsync, grpcClient.EnableProgram, effectiveSettings.EnableProgramSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableProgram);
            Modify_EnableProgramApiCall(ref _callEnableProgram);
            _callDisableProgram = clientHelper.BuildApiCall<DisableProgramRequest, Program>("DisableProgram", grpcClient.DisableProgramAsync, grpcClient.DisableProgram, effectiveSettings.DisableProgramSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableProgram);
            Modify_DisableProgramApiCall(ref _callDisableProgram);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetProgramApiCall(ref gaxgrpc::ApiCall<GetProgramRequest, Program> call);

        partial void Modify_ListProgramsApiCall(ref gaxgrpc::ApiCall<ListProgramsRequest, ListProgramsResponse> call);

        partial void Modify_EnableProgramApiCall(ref gaxgrpc::ApiCall<EnableProgramRequest, Program> call);

        partial void Modify_DisableProgramApiCall(ref gaxgrpc::ApiCall<DisableProgramRequest, Program> call);

        partial void OnConstruction(ProgramsService.ProgramsServiceClient grpcClient, ProgramsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProgramsService client</summary>
        public override ProgramsService.ProgramsServiceClient GrpcClient { get; }

        partial void Modify_GetProgramRequest(ref GetProgramRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProgramsRequest(ref ListProgramsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableProgramRequest(ref EnableProgramRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableProgramRequest(ref DisableProgramRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the specified program for the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Program GetProgram(GetProgramRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProgramRequest(ref request, ref callSettings);
            return _callGetProgram.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified program for the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Program> GetProgramAsync(GetProgramRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProgramRequest(ref request, ref callSettings);
            return _callGetProgram.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves all programs for the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Program"/> resources.</returns>
        public override gax::PagedEnumerable<ListProgramsResponse, Program> ListPrograms(ListProgramsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProgramsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProgramsRequest, ListProgramsResponse, Program>(_callListPrograms, request, callSettings);
        }

        /// <summary>
        /// Retrieves all programs for the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Program"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProgramsResponse, Program> ListProgramsAsync(ListProgramsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProgramsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProgramsRequest, ListProgramsResponse, Program>(_callListPrograms, request, callSettings);
        }

        /// <summary>
        /// Enable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Program EnableProgram(EnableProgramRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableProgramRequest(ref request, ref callSettings);
            return _callEnableProgram.Sync(request, callSettings);
        }

        /// <summary>
        /// Enable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Program> EnableProgramAsync(EnableProgramRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableProgramRequest(ref request, ref callSettings);
            return _callEnableProgram.Async(request, callSettings);
        }

        /// <summary>
        /// Disable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Program DisableProgram(DisableProgramRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableProgramRequest(ref request, ref callSettings);
            return _callDisableProgram.Sync(request, callSettings);
        }

        /// <summary>
        /// Disable participation in the specified program for the account. Executing
        /// this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Program> DisableProgramAsync(DisableProgramRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableProgramRequest(ref request, ref callSettings);
            return _callDisableProgram.Async(request, callSettings);
        }
    }

    public partial class ListProgramsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProgramsResponse : gaxgrpc::IPageResponse<Program>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Program> GetEnumerator() => Programs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
