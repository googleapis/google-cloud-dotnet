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

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Settings for <see cref="PhoneNumbersClient"/> instances.</summary>
    public sealed partial class PhoneNumbersSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PhoneNumbersSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PhoneNumbersSettings"/>.</returns>
        public static PhoneNumbersSettings GetDefault() => new PhoneNumbersSettings();

        /// <summary>Constructs a new <see cref="PhoneNumbersSettings"/> object with default settings.</summary>
        public PhoneNumbersSettings()
        {
        }

        private PhoneNumbersSettings(PhoneNumbersSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListPhoneNumbersSettings = existing.ListPhoneNumbersSettings;
            UpdatePhoneNumberSettings = existing.UpdatePhoneNumberSettings;
            DeletePhoneNumberSettings = existing.DeletePhoneNumberSettings;
            UndeletePhoneNumberSettings = existing.UndeletePhoneNumberSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PhoneNumbersSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumbersClient.ListPhoneNumbers</c> and <c>PhoneNumbersClient.ListPhoneNumbersAsync</c>.
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
        public gaxgrpc::CallSettings ListPhoneNumbersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumbersClient.UpdatePhoneNumber</c> and <c>PhoneNumbersClient.UpdatePhoneNumberAsync</c>.
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
        public gaxgrpc::CallSettings UpdatePhoneNumberSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumbersClient.DeletePhoneNumber</c> and <c>PhoneNumbersClient.DeletePhoneNumberAsync</c>.
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
        public gaxgrpc::CallSettings DeletePhoneNumberSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PhoneNumbersClient.UndeletePhoneNumber</c> and <c>PhoneNumbersClient.UndeletePhoneNumberAsync</c>.
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
        public gaxgrpc::CallSettings UndeletePhoneNumberSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PhoneNumbersSettings"/> object.</returns>
        public PhoneNumbersSettings Clone() => new PhoneNumbersSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PhoneNumbersClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PhoneNumbersClientBuilder : gaxgrpc::ClientBuilderBase<PhoneNumbersClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PhoneNumbersSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PhoneNumbersClientBuilder() : base(PhoneNumbersClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PhoneNumbersClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PhoneNumbersClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PhoneNumbersClient Build()
        {
            PhoneNumbersClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PhoneNumbersClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PhoneNumbersClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PhoneNumbersClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PhoneNumbersClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PhoneNumbersClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PhoneNumbersClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PhoneNumbersClient.ChannelPool;
    }

    /// <summary>PhoneNumbers client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [PhoneNumbers][google.cloud.dialogflow.v2beta1.PhoneNumber].
    /// </remarks>
    public abstract partial class PhoneNumbersClient
    {
        /// <summary>
        /// The default endpoint for the PhoneNumbers service, which is a host of "dialogflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default PhoneNumbers scopes.</summary>
        /// <remarks>
        /// The default PhoneNumbers scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PhoneNumbers.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PhoneNumbersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PhoneNumbersClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PhoneNumbersClient"/>.</returns>
        public static stt::Task<PhoneNumbersClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PhoneNumbersClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PhoneNumbersClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PhoneNumbersClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PhoneNumbersClient"/>.</returns>
        public static PhoneNumbersClient Create() => new PhoneNumbersClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PhoneNumbersClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PhoneNumbersSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PhoneNumbersClient"/>.</returns>
        internal static PhoneNumbersClient Create(grpccore::CallInvoker callInvoker, PhoneNumbersSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PhoneNumbers.PhoneNumbersClient grpcClient = new PhoneNumbers.PhoneNumbersClient(callInvoker);
            return new PhoneNumbersClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PhoneNumbers client</summary>
        public virtual PhoneNumbers.PhoneNumbersClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all phone numbers in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbers(ListPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all phone numbers in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbersAsync(ListPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all phone numbers in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all `PhoneNumber` resources from.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest
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
            return ListPhoneNumbers(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all phone numbers in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all `PhoneNumber` resources from.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest
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
            return ListPhoneNumbersAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all phone numbers in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all `PhoneNumber` resources from.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbers(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPhoneNumbers(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all phone numbers in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all `PhoneNumber` resources from.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbersAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPhoneNumbersAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all phone numbers in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all `PhoneNumber` resources from.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest
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
            return ListPhoneNumbers(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all phone numbers in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all `PhoneNumber` resources from.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumber"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhoneNumbersRequest request = new ListPhoneNumbersRequest
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
            return ListPhoneNumbersAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified `PhoneNumber`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber UpdatePhoneNumber(UpdatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified `PhoneNumber`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified `PhoneNumber`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, st::CancellationToken cancellationToken) =>
            UpdatePhoneNumberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified `PhoneNumber`.
        /// </summary>
        /// <param name="phoneNumber">
        /// Required. The `PhoneNumber` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber UpdatePhoneNumber(PhoneNumber phoneNumber, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhoneNumber(new UpdatePhoneNumberRequest
            {
                PhoneNumber = gax::GaxPreconditions.CheckNotNull(phoneNumber, nameof(phoneNumber)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified `PhoneNumber`.
        /// </summary>
        /// <param name="phoneNumber">
        /// Required. The `PhoneNumber` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UpdatePhoneNumberAsync(PhoneNumber phoneNumber, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhoneNumberAsync(new UpdatePhoneNumberRequest
            {
                PhoneNumber = gax::GaxPreconditions.CheckNotNull(phoneNumber, nameof(phoneNumber)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified `PhoneNumber`.
        /// </summary>
        /// <param name="phoneNumber">
        /// Required. The `PhoneNumber` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UpdatePhoneNumberAsync(PhoneNumber phoneNumber, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePhoneNumberAsync(phoneNumber, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests deletion of a `PhoneNumber`. The `PhoneNumber` is moved into the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on a `PhoneNumber` in the
        /// [ACTIVE][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.ACTIVE]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber DeletePhoneNumber(DeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests deletion of a `PhoneNumber`. The `PhoneNumber` is moved into the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on a `PhoneNumber` in the
        /// [ACTIVE][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.ACTIVE]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> DeletePhoneNumberAsync(DeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests deletion of a `PhoneNumber`. The `PhoneNumber` is moved into the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on a `PhoneNumber` in the
        /// [ACTIVE][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.ACTIVE]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> DeletePhoneNumberAsync(DeletePhoneNumberRequest request, st::CancellationToken cancellationToken) =>
            DeletePhoneNumberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests deletion of a `PhoneNumber`. The `PhoneNumber` is moved into the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on a `PhoneNumber` in the
        /// [ACTIVE][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.ACTIVE]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber DeletePhoneNumber(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhoneNumber(new DeletePhoneNumberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests deletion of a `PhoneNumber`. The `PhoneNumber` is moved into the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on a `PhoneNumber` in the
        /// [ACTIVE][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.ACTIVE]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> DeletePhoneNumberAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhoneNumberAsync(new DeletePhoneNumberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests deletion of a `PhoneNumber`. The `PhoneNumber` is moved into the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on a `PhoneNumber` in the
        /// [ACTIVE][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.ACTIVE]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> DeletePhoneNumberAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePhoneNumberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests deletion of a `PhoneNumber`. The `PhoneNumber` is moved into the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on a `PhoneNumber` in the
        /// [ACTIVE][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.ACTIVE]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber DeletePhoneNumber(PhoneNumberName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhoneNumber(new DeletePhoneNumberRequest
            {
                PhoneNumberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests deletion of a `PhoneNumber`. The `PhoneNumber` is moved into the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on a `PhoneNumber` in the
        /// [ACTIVE][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.ACTIVE]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> DeletePhoneNumberAsync(PhoneNumberName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhoneNumberAsync(new DeletePhoneNumberRequest
            {
                PhoneNumberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests deletion of a `PhoneNumber`. The `PhoneNumber` is moved into the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on a `PhoneNumber` in the
        /// [ACTIVE][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.ACTIVE]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> DeletePhoneNumberAsync(PhoneNumberName name, st::CancellationToken cancellationToken) =>
            DeletePhoneNumberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the deletion request for a `PhoneNumber`. This method may only be
        /// called on a `PhoneNumber` in the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber UndeletePhoneNumber(UndeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the deletion request for a `PhoneNumber`. This method may only be
        /// called on a `PhoneNumber` in the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UndeletePhoneNumberAsync(UndeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the deletion request for a `PhoneNumber`. This method may only be
        /// called on a `PhoneNumber` in the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UndeletePhoneNumberAsync(UndeletePhoneNumberRequest request, st::CancellationToken cancellationToken) =>
            UndeletePhoneNumberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the deletion request for a `PhoneNumber`. This method may only be
        /// called on a `PhoneNumber` in the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber UndeletePhoneNumber(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePhoneNumber(new UndeletePhoneNumberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the deletion request for a `PhoneNumber`. This method may only be
        /// called on a `PhoneNumber` in the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UndeletePhoneNumberAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePhoneNumberAsync(new UndeletePhoneNumberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the deletion request for a `PhoneNumber`. This method may only be
        /// called on a `PhoneNumber` in the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UndeletePhoneNumberAsync(string name, st::CancellationToken cancellationToken) =>
            UndeletePhoneNumberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the deletion request for a `PhoneNumber`. This method may only be
        /// called on a `PhoneNumber` in the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhoneNumber UndeletePhoneNumber(PhoneNumberName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePhoneNumber(new UndeletePhoneNumberRequest
            {
                PhoneNumberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the deletion request for a `PhoneNumber`. This method may only be
        /// called on a `PhoneNumber` in the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UndeletePhoneNumberAsync(PhoneNumberName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePhoneNumberAsync(new UndeletePhoneNumberRequest
            {
                PhoneNumberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the deletion request for a `PhoneNumber`. This method may only be
        /// called on a `PhoneNumber` in the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state.
        /// </summary>
        /// <param name="name">
        /// Required. The unique identifier of the `PhoneNumber` to delete.
        /// Format: `projects/&lt;Project ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/phoneNumbers/&lt;PhoneNumber ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhoneNumber> UndeletePhoneNumberAsync(PhoneNumberName name, st::CancellationToken cancellationToken) =>
            UndeletePhoneNumberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PhoneNumbers client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [PhoneNumbers][google.cloud.dialogflow.v2beta1.PhoneNumber].
    /// </remarks>
    public sealed partial class PhoneNumbersClientImpl : PhoneNumbersClient
    {
        private readonly gaxgrpc::ApiCall<ListPhoneNumbersRequest, ListPhoneNumbersResponse> _callListPhoneNumbers;

        private readonly gaxgrpc::ApiCall<UpdatePhoneNumberRequest, PhoneNumber> _callUpdatePhoneNumber;

        private readonly gaxgrpc::ApiCall<DeletePhoneNumberRequest, PhoneNumber> _callDeletePhoneNumber;

        private readonly gaxgrpc::ApiCall<UndeletePhoneNumberRequest, PhoneNumber> _callUndeletePhoneNumber;

        /// <summary>
        /// Constructs a client wrapper for the PhoneNumbers service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PhoneNumbersSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PhoneNumbersClientImpl(PhoneNumbers.PhoneNumbersClient grpcClient, PhoneNumbersSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PhoneNumbersSettings effectiveSettings = settings ?? PhoneNumbersSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListPhoneNumbers = clientHelper.BuildApiCall<ListPhoneNumbersRequest, ListPhoneNumbersResponse>("ListPhoneNumbers", grpcClient.ListPhoneNumbersAsync, grpcClient.ListPhoneNumbers, effectiveSettings.ListPhoneNumbersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPhoneNumbers);
            Modify_ListPhoneNumbersApiCall(ref _callListPhoneNumbers);
            _callUpdatePhoneNumber = clientHelper.BuildApiCall<UpdatePhoneNumberRequest, PhoneNumber>("UpdatePhoneNumber", grpcClient.UpdatePhoneNumberAsync, grpcClient.UpdatePhoneNumber, effectiveSettings.UpdatePhoneNumberSettings).WithGoogleRequestParam("phone_number.name", request => request.PhoneNumber?.Name);
            Modify_ApiCall(ref _callUpdatePhoneNumber);
            Modify_UpdatePhoneNumberApiCall(ref _callUpdatePhoneNumber);
            _callDeletePhoneNumber = clientHelper.BuildApiCall<DeletePhoneNumberRequest, PhoneNumber>("DeletePhoneNumber", grpcClient.DeletePhoneNumberAsync, grpcClient.DeletePhoneNumber, effectiveSettings.DeletePhoneNumberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePhoneNumber);
            Modify_DeletePhoneNumberApiCall(ref _callDeletePhoneNumber);
            _callUndeletePhoneNumber = clientHelper.BuildApiCall<UndeletePhoneNumberRequest, PhoneNumber>("UndeletePhoneNumber", grpcClient.UndeletePhoneNumberAsync, grpcClient.UndeletePhoneNumber, effectiveSettings.UndeletePhoneNumberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeletePhoneNumber);
            Modify_UndeletePhoneNumberApiCall(ref _callUndeletePhoneNumber);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListPhoneNumbersApiCall(ref gaxgrpc::ApiCall<ListPhoneNumbersRequest, ListPhoneNumbersResponse> call);

        partial void Modify_UpdatePhoneNumberApiCall(ref gaxgrpc::ApiCall<UpdatePhoneNumberRequest, PhoneNumber> call);

        partial void Modify_DeletePhoneNumberApiCall(ref gaxgrpc::ApiCall<DeletePhoneNumberRequest, PhoneNumber> call);

        partial void Modify_UndeletePhoneNumberApiCall(ref gaxgrpc::ApiCall<UndeletePhoneNumberRequest, PhoneNumber> call);

        partial void OnConstruction(PhoneNumbers.PhoneNumbersClient grpcClient, PhoneNumbersSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PhoneNumbers client</summary>
        public override PhoneNumbers.PhoneNumbersClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListPhoneNumbersRequest(ref ListPhoneNumbersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePhoneNumberRequest(ref UpdatePhoneNumberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePhoneNumberRequest(ref DeletePhoneNumberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeletePhoneNumberRequest(ref UndeletePhoneNumberRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all phone numbers in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhoneNumber"/> resources.</returns>
        public override gax::PagedEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbers(ListPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhoneNumbersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPhoneNumbersRequest, ListPhoneNumbersResponse, PhoneNumber>(_callListPhoneNumbers, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all phone numbers in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhoneNumber"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPhoneNumbersResponse, PhoneNumber> ListPhoneNumbersAsync(ListPhoneNumbersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhoneNumbersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPhoneNumbersRequest, ListPhoneNumbersResponse, PhoneNumber>(_callListPhoneNumbers, request, callSettings);
        }

        /// <summary>
        /// Updates the specified `PhoneNumber`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhoneNumber UpdatePhoneNumber(UpdatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhoneNumberRequest(ref request, ref callSettings);
            return _callUpdatePhoneNumber.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified `PhoneNumber`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhoneNumber> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhoneNumberRequest(ref request, ref callSettings);
            return _callUpdatePhoneNumber.Async(request, callSettings);
        }

        /// <summary>
        /// Requests deletion of a `PhoneNumber`. The `PhoneNumber` is moved into the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on a `PhoneNumber` in the
        /// [ACTIVE][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.ACTIVE]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhoneNumber DeletePhoneNumber(DeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhoneNumberRequest(ref request, ref callSettings);
            return _callDeletePhoneNumber.Sync(request, callSettings);
        }

        /// <summary>
        /// Requests deletion of a `PhoneNumber`. The `PhoneNumber` is moved into the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state immediately, and is deleted approximately 30 days later. This method
        /// may only be called on a `PhoneNumber` in the
        /// [ACTIVE][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.ACTIVE]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhoneNumber> DeletePhoneNumberAsync(DeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhoneNumberRequest(ref request, ref callSettings);
            return _callDeletePhoneNumber.Async(request, callSettings);
        }

        /// <summary>
        /// Cancels the deletion request for a `PhoneNumber`. This method may only be
        /// called on a `PhoneNumber` in the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhoneNumber UndeletePhoneNumber(UndeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeletePhoneNumberRequest(ref request, ref callSettings);
            return _callUndeletePhoneNumber.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels the deletion request for a `PhoneNumber`. This method may only be
        /// called on a `PhoneNumber` in the
        /// [DELETE_REQUESTED][google.cloud.dialogflow.v2beta1.PhoneNumber.LifecycleState.DELETE_REQUESTED]
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhoneNumber> UndeletePhoneNumberAsync(UndeletePhoneNumberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeletePhoneNumberRequest(ref request, ref callSettings);
            return _callUndeletePhoneNumber.Async(request, callSettings);
        }
    }

    public partial class ListPhoneNumbersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPhoneNumbersResponse : gaxgrpc::IPageResponse<PhoneNumber>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PhoneNumber> GetEnumerator() => PhoneNumbers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class PhoneNumbers
    {
        public partial class PhoneNumbersClient
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
