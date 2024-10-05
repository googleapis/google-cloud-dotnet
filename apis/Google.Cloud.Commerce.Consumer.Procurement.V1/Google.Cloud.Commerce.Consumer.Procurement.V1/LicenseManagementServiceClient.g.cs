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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Commerce.Consumer.Procurement.V1
{
    /// <summary>Settings for <see cref="LicenseManagementServiceClient"/> instances.</summary>
    public sealed partial class LicenseManagementServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LicenseManagementServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LicenseManagementServiceSettings"/>.</returns>
        public static LicenseManagementServiceSettings GetDefault() => new LicenseManagementServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LicenseManagementServiceSettings"/> object with default settings.
        /// </summary>
        public LicenseManagementServiceSettings()
        {
        }

        private LicenseManagementServiceSettings(LicenseManagementServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLicensePoolSettings = existing.GetLicensePoolSettings;
            UpdateLicensePoolSettings = existing.UpdateLicensePoolSettings;
            AssignSettings = existing.AssignSettings;
            UnassignSettings = existing.UnassignSettings;
            EnumerateLicensedUsersSettings = existing.EnumerateLicensedUsersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LicenseManagementServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagementServiceClient.GetLicensePool</c> and
        /// <c>LicenseManagementServiceClient.GetLicensePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLicensePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagementServiceClient.UpdateLicensePool</c> and
        /// <c>LicenseManagementServiceClient.UpdateLicensePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLicensePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagementServiceClient.Assign</c> and <c>LicenseManagementServiceClient.AssignAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AssignSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagementServiceClient.Unassign</c> and <c>LicenseManagementServiceClient.UnassignAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UnassignSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseManagementServiceClient.EnumerateLicensedUsers</c> and
        /// <c>LicenseManagementServiceClient.EnumerateLicensedUsersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnumerateLicensedUsersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LicenseManagementServiceSettings"/> object.</returns>
        public LicenseManagementServiceSettings Clone() => new LicenseManagementServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LicenseManagementServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class LicenseManagementServiceClientBuilder : gaxgrpc::ClientBuilderBase<LicenseManagementServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LicenseManagementServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LicenseManagementServiceClientBuilder() : base(LicenseManagementServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LicenseManagementServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LicenseManagementServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LicenseManagementServiceClient Build()
        {
            LicenseManagementServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LicenseManagementServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LicenseManagementServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LicenseManagementServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LicenseManagementServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LicenseManagementServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LicenseManagementServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LicenseManagementServiceClient.ChannelPool;
    }

    /// <summary>LicenseManagementService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing licenses.
    /// </remarks>
    public abstract partial class LicenseManagementServiceClient
    {
        /// <summary>
        /// The default endpoint for the LicenseManagementService service, which is a host of
        /// "cloudcommerceconsumerprocurement.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudcommerceconsumerprocurement.googleapis.com:443";

        /// <summary>The default LicenseManagementService scopes.</summary>
        /// <remarks>
        /// The default LicenseManagementService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LicenseManagementService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LicenseManagementServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="LicenseManagementServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LicenseManagementServiceClient"/>.</returns>
        public static stt::Task<LicenseManagementServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LicenseManagementServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LicenseManagementServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LicenseManagementServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LicenseManagementServiceClient"/>.</returns>
        public static LicenseManagementServiceClient Create() => new LicenseManagementServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LicenseManagementServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LicenseManagementServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LicenseManagementServiceClient"/>.</returns>
        internal static LicenseManagementServiceClient Create(grpccore::CallInvoker callInvoker, LicenseManagementServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LicenseManagementService.LicenseManagementServiceClient grpcClient = new LicenseManagementService.LicenseManagementServiceClient(callInvoker);
            return new LicenseManagementServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LicenseManagementService client</summary>
        public virtual LicenseManagementService.LicenseManagementServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the license pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LicensePool GetLicensePool(GetLicensePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the license pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicensePool> GetLicensePoolAsync(GetLicensePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the license pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicensePool> GetLicensePoolAsync(GetLicensePoolRequest request, st::CancellationToken cancellationToken) =>
            GetLicensePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the license pool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the license pool to get.
        /// Format: `billingAccounts/{billing_account}/orders/{order}/licensePool`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LicensePool GetLicensePool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLicensePool(new GetLicensePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the license pool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the license pool to get.
        /// Format: `billingAccounts/{billing_account}/orders/{order}/licensePool`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicensePool> GetLicensePoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLicensePoolAsync(new GetLicensePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the license pool.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the license pool to get.
        /// Format: `billingAccounts/{billing_account}/orders/{order}/licensePool`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicensePool> GetLicensePoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetLicensePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the license pool if one exists for this Order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LicensePool UpdateLicensePool(UpdateLicensePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the license pool if one exists for this Order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicensePool> UpdateLicensePoolAsync(UpdateLicensePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the license pool if one exists for this Order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicensePool> UpdateLicensePoolAsync(UpdateLicensePoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateLicensePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the license pool if one exists for this Order.
        /// </summary>
        /// <param name="licensePool">
        /// Required. The license pool to update.
        /// 
        /// The license pool's name field is used to identify the license pool to
        /// update. Format:
        /// `billingAccounts/{billing_account}/orders/{order}/licensePool`.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LicensePool UpdateLicensePool(LicensePool licensePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLicensePool(new UpdateLicensePoolRequest
            {
                LicensePool = gax::GaxPreconditions.CheckNotNull(licensePool, nameof(licensePool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the license pool if one exists for this Order.
        /// </summary>
        /// <param name="licensePool">
        /// Required. The license pool to update.
        /// 
        /// The license pool's name field is used to identify the license pool to
        /// update. Format:
        /// `billingAccounts/{billing_account}/orders/{order}/licensePool`.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicensePool> UpdateLicensePoolAsync(LicensePool licensePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLicensePoolAsync(new UpdateLicensePoolRequest
            {
                LicensePool = gax::GaxPreconditions.CheckNotNull(licensePool, nameof(licensePool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the license pool if one exists for this Order.
        /// </summary>
        /// <param name="licensePool">
        /// Required. The license pool to update.
        /// 
        /// The license pool's name field is used to identify the license pool to
        /// update. Format:
        /// `billingAccounts/{billing_account}/orders/{order}/licensePool`.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicensePool> UpdateLicensePoolAsync(LicensePool licensePool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateLicensePoolAsync(licensePool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Assigns a license to a user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AssignResponse Assign(AssignRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Assigns a license to a user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssignResponse> AssignAsync(AssignRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Assigns a license to a user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssignResponse> AssignAsync(AssignRequest request, st::CancellationToken cancellationToken) =>
            AssignAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Assigns a license to a user.
        /// </summary>
        /// <param name="parent">
        /// Required. License pool name.
        /// </param>
        /// <param name="usernames">
        /// Required. Username.
        /// Format: `name@domain.com`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AssignResponse Assign(string parent, scg::IEnumerable<string> usernames, gaxgrpc::CallSettings callSettings = null) =>
            Assign(new AssignRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Usernames =
                {
                    gax::GaxPreconditions.CheckNotNull(usernames, nameof(usernames)),
                },
            }, callSettings);

        /// <summary>
        /// Assigns a license to a user.
        /// </summary>
        /// <param name="parent">
        /// Required. License pool name.
        /// </param>
        /// <param name="usernames">
        /// Required. Username.
        /// Format: `name@domain.com`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssignResponse> AssignAsync(string parent, scg::IEnumerable<string> usernames, gaxgrpc::CallSettings callSettings = null) =>
            AssignAsync(new AssignRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Usernames =
                {
                    gax::GaxPreconditions.CheckNotNull(usernames, nameof(usernames)),
                },
            }, callSettings);

        /// <summary>
        /// Assigns a license to a user.
        /// </summary>
        /// <param name="parent">
        /// Required. License pool name.
        /// </param>
        /// <param name="usernames">
        /// Required. Username.
        /// Format: `name@domain.com`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssignResponse> AssignAsync(string parent, scg::IEnumerable<string> usernames, st::CancellationToken cancellationToken) =>
            AssignAsync(parent, usernames, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unassigns a license from a user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnassignResponse Unassign(UnassignRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unassigns a license from a user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnassignResponse> UnassignAsync(UnassignRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unassigns a license from a user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnassignResponse> UnassignAsync(UnassignRequest request, st::CancellationToken cancellationToken) =>
            UnassignAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unassigns a license from a user.
        /// </summary>
        /// <param name="parent">
        /// Required. License pool name.
        /// </param>
        /// <param name="usernames">
        /// Required. Username.
        /// Format: `name@domain.com`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnassignResponse Unassign(string parent, scg::IEnumerable<string> usernames, gaxgrpc::CallSettings callSettings = null) =>
            Unassign(new UnassignRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Usernames =
                {
                    gax::GaxPreconditions.CheckNotNull(usernames, nameof(usernames)),
                },
            }, callSettings);

        /// <summary>
        /// Unassigns a license from a user.
        /// </summary>
        /// <param name="parent">
        /// Required. License pool name.
        /// </param>
        /// <param name="usernames">
        /// Required. Username.
        /// Format: `name@domain.com`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnassignResponse> UnassignAsync(string parent, scg::IEnumerable<string> usernames, gaxgrpc::CallSettings callSettings = null) =>
            UnassignAsync(new UnassignRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Usernames =
                {
                    gax::GaxPreconditions.CheckNotNull(usernames, nameof(usernames)),
                },
            }, callSettings);

        /// <summary>
        /// Unassigns a license from a user.
        /// </summary>
        /// <param name="parent">
        /// Required. License pool name.
        /// </param>
        /// <param name="usernames">
        /// Required. Username.
        /// Format: `name@domain.com`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnassignResponse> UnassignAsync(string parent, scg::IEnumerable<string> usernames, st::CancellationToken cancellationToken) =>
            UnassignAsync(parent, usernames, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enumerates all users assigned a license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LicensedUser"/> resources.</returns>
        public virtual gax::PagedEnumerable<EnumerateLicensedUsersResponse, LicensedUser> EnumerateLicensedUsers(EnumerateLicensedUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enumerates all users assigned a license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LicensedUser"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<EnumerateLicensedUsersResponse, LicensedUser> EnumerateLicensedUsersAsync(EnumerateLicensedUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enumerates all users assigned a license.
        /// </summary>
        /// <param name="parent">
        /// Required. License pool name.
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
        /// <returns>A pageable sequence of <see cref="LicensedUser"/> resources.</returns>
        public virtual gax::PagedEnumerable<EnumerateLicensedUsersResponse, LicensedUser> EnumerateLicensedUsers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            EnumerateLicensedUsersRequest request = new EnumerateLicensedUsersRequest
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
            return EnumerateLicensedUsers(request, callSettings);
        }

        /// <summary>
        /// Enumerates all users assigned a license.
        /// </summary>
        /// <param name="parent">
        /// Required. License pool name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LicensedUser"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<EnumerateLicensedUsersResponse, LicensedUser> EnumerateLicensedUsersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            EnumerateLicensedUsersRequest request = new EnumerateLicensedUsersRequest
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
            return EnumerateLicensedUsersAsync(request, callSettings);
        }
    }

    /// <summary>LicenseManagementService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing licenses.
    /// </remarks>
    public sealed partial class LicenseManagementServiceClientImpl : LicenseManagementServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLicensePoolRequest, LicensePool> _callGetLicensePool;

        private readonly gaxgrpc::ApiCall<UpdateLicensePoolRequest, LicensePool> _callUpdateLicensePool;

        private readonly gaxgrpc::ApiCall<AssignRequest, AssignResponse> _callAssign;

        private readonly gaxgrpc::ApiCall<UnassignRequest, UnassignResponse> _callUnassign;

        private readonly gaxgrpc::ApiCall<EnumerateLicensedUsersRequest, EnumerateLicensedUsersResponse> _callEnumerateLicensedUsers;

        /// <summary>
        /// Constructs a client wrapper for the LicenseManagementService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="LicenseManagementServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LicenseManagementServiceClientImpl(LicenseManagementService.LicenseManagementServiceClient grpcClient, LicenseManagementServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LicenseManagementServiceSettings effectiveSettings = settings ?? LicenseManagementServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetLicensePool = clientHelper.BuildApiCall<GetLicensePoolRequest, LicensePool>("GetLicensePool", grpcClient.GetLicensePoolAsync, grpcClient.GetLicensePool, effectiveSettings.GetLicensePoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLicensePool);
            Modify_GetLicensePoolApiCall(ref _callGetLicensePool);
            _callUpdateLicensePool = clientHelper.BuildApiCall<UpdateLicensePoolRequest, LicensePool>("UpdateLicensePool", grpcClient.UpdateLicensePoolAsync, grpcClient.UpdateLicensePool, effectiveSettings.UpdateLicensePoolSettings).WithGoogleRequestParam("license_pool.name", request => request.LicensePool?.Name);
            Modify_ApiCall(ref _callUpdateLicensePool);
            Modify_UpdateLicensePoolApiCall(ref _callUpdateLicensePool);
            _callAssign = clientHelper.BuildApiCall<AssignRequest, AssignResponse>("Assign", grpcClient.AssignAsync, grpcClient.Assign, effectiveSettings.AssignSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callAssign);
            Modify_AssignApiCall(ref _callAssign);
            _callUnassign = clientHelper.BuildApiCall<UnassignRequest, UnassignResponse>("Unassign", grpcClient.UnassignAsync, grpcClient.Unassign, effectiveSettings.UnassignSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callUnassign);
            Modify_UnassignApiCall(ref _callUnassign);
            _callEnumerateLicensedUsers = clientHelper.BuildApiCall<EnumerateLicensedUsersRequest, EnumerateLicensedUsersResponse>("EnumerateLicensedUsers", grpcClient.EnumerateLicensedUsersAsync, grpcClient.EnumerateLicensedUsers, effectiveSettings.EnumerateLicensedUsersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callEnumerateLicensedUsers);
            Modify_EnumerateLicensedUsersApiCall(ref _callEnumerateLicensedUsers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLicensePoolApiCall(ref gaxgrpc::ApiCall<GetLicensePoolRequest, LicensePool> call);

        partial void Modify_UpdateLicensePoolApiCall(ref gaxgrpc::ApiCall<UpdateLicensePoolRequest, LicensePool> call);

        partial void Modify_AssignApiCall(ref gaxgrpc::ApiCall<AssignRequest, AssignResponse> call);

        partial void Modify_UnassignApiCall(ref gaxgrpc::ApiCall<UnassignRequest, UnassignResponse> call);

        partial void Modify_EnumerateLicensedUsersApiCall(ref gaxgrpc::ApiCall<EnumerateLicensedUsersRequest, EnumerateLicensedUsersResponse> call);

        partial void OnConstruction(LicenseManagementService.LicenseManagementServiceClient grpcClient, LicenseManagementServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LicenseManagementService client</summary>
        public override LicenseManagementService.LicenseManagementServiceClient GrpcClient { get; }

        partial void Modify_GetLicensePoolRequest(ref GetLicensePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateLicensePoolRequest(ref UpdateLicensePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AssignRequest(ref AssignRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UnassignRequest(ref UnassignRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnumerateLicensedUsersRequest(ref EnumerateLicensedUsersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the license pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LicensePool GetLicensePool(GetLicensePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLicensePoolRequest(ref request, ref callSettings);
            return _callGetLicensePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the license pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LicensePool> GetLicensePoolAsync(GetLicensePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLicensePoolRequest(ref request, ref callSettings);
            return _callGetLicensePool.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the license pool if one exists for this Order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LicensePool UpdateLicensePool(UpdateLicensePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLicensePoolRequest(ref request, ref callSettings);
            return _callUpdateLicensePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the license pool if one exists for this Order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LicensePool> UpdateLicensePoolAsync(UpdateLicensePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLicensePoolRequest(ref request, ref callSettings);
            return _callUpdateLicensePool.Async(request, callSettings);
        }

        /// <summary>
        /// Assigns a license to a user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AssignResponse Assign(AssignRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AssignRequest(ref request, ref callSettings);
            return _callAssign.Sync(request, callSettings);
        }

        /// <summary>
        /// Assigns a license to a user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AssignResponse> AssignAsync(AssignRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AssignRequest(ref request, ref callSettings);
            return _callAssign.Async(request, callSettings);
        }

        /// <summary>
        /// Unassigns a license from a user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UnassignResponse Unassign(UnassignRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnassignRequest(ref request, ref callSettings);
            return _callUnassign.Sync(request, callSettings);
        }

        /// <summary>
        /// Unassigns a license from a user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UnassignResponse> UnassignAsync(UnassignRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnassignRequest(ref request, ref callSettings);
            return _callUnassign.Async(request, callSettings);
        }

        /// <summary>
        /// Enumerates all users assigned a license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LicensedUser"/> resources.</returns>
        public override gax::PagedEnumerable<EnumerateLicensedUsersResponse, LicensedUser> EnumerateLicensedUsers(EnumerateLicensedUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnumerateLicensedUsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<EnumerateLicensedUsersRequest, EnumerateLicensedUsersResponse, LicensedUser>(_callEnumerateLicensedUsers, request, callSettings);
        }

        /// <summary>
        /// Enumerates all users assigned a license.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LicensedUser"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<EnumerateLicensedUsersResponse, LicensedUser> EnumerateLicensedUsersAsync(EnumerateLicensedUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnumerateLicensedUsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<EnumerateLicensedUsersRequest, EnumerateLicensedUsersResponse, LicensedUser>(_callEnumerateLicensedUsers, request, callSettings);
        }
    }

    public partial class EnumerateLicensedUsersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class EnumerateLicensedUsersResponse : gaxgrpc::IPageResponse<LicensedUser>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LicensedUser> GetEnumerator() => LicensedUsers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
