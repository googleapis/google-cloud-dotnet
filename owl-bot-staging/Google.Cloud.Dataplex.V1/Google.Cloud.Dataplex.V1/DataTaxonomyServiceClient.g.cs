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

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Settings for <see cref="DataTaxonomyServiceClient"/> instances.</summary>
    public sealed partial class DataTaxonomyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataTaxonomyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataTaxonomyServiceSettings"/>.</returns>
        public static DataTaxonomyServiceSettings GetDefault() => new DataTaxonomyServiceSettings();

        /// <summary>Constructs a new <see cref="DataTaxonomyServiceSettings"/> object with default settings.</summary>
        public DataTaxonomyServiceSettings()
        {
        }

        private DataTaxonomyServiceSettings(DataTaxonomyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDataTaxonomySettings = existing.CreateDataTaxonomySettings;
            CreateDataTaxonomyOperationsSettings = existing.CreateDataTaxonomyOperationsSettings.Clone();
            UpdateDataTaxonomySettings = existing.UpdateDataTaxonomySettings;
            UpdateDataTaxonomyOperationsSettings = existing.UpdateDataTaxonomyOperationsSettings.Clone();
            DeleteDataTaxonomySettings = existing.DeleteDataTaxonomySettings;
            DeleteDataTaxonomyOperationsSettings = existing.DeleteDataTaxonomyOperationsSettings.Clone();
            ListDataTaxonomiesSettings = existing.ListDataTaxonomiesSettings;
            GetDataTaxonomySettings = existing.GetDataTaxonomySettings;
            CreateDataAttributeBindingSettings = existing.CreateDataAttributeBindingSettings;
            CreateDataAttributeBindingOperationsSettings = existing.CreateDataAttributeBindingOperationsSettings.Clone();
            UpdateDataAttributeBindingSettings = existing.UpdateDataAttributeBindingSettings;
            UpdateDataAttributeBindingOperationsSettings = existing.UpdateDataAttributeBindingOperationsSettings.Clone();
            DeleteDataAttributeBindingSettings = existing.DeleteDataAttributeBindingSettings;
            DeleteDataAttributeBindingOperationsSettings = existing.DeleteDataAttributeBindingOperationsSettings.Clone();
            ListDataAttributeBindingsSettings = existing.ListDataAttributeBindingsSettings;
            GetDataAttributeBindingSettings = existing.GetDataAttributeBindingSettings;
            CreateDataAttributeSettings = existing.CreateDataAttributeSettings;
            CreateDataAttributeOperationsSettings = existing.CreateDataAttributeOperationsSettings.Clone();
            UpdateDataAttributeSettings = existing.UpdateDataAttributeSettings;
            UpdateDataAttributeOperationsSettings = existing.UpdateDataAttributeOperationsSettings.Clone();
            DeleteDataAttributeSettings = existing.DeleteDataAttributeSettings;
            DeleteDataAttributeOperationsSettings = existing.DeleteDataAttributeOperationsSettings.Clone();
            ListDataAttributesSettings = existing.ListDataAttributesSettings;
            GetDataAttributeSettings = existing.GetDataAttributeSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataTaxonomyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.CreateDataTaxonomy</c> and <c>DataTaxonomyServiceClient.CreateDataTaxonomyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataTaxonomySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTaxonomyServiceClient.CreateDataTaxonomy</c> and
        /// <c>DataTaxonomyServiceClient.CreateDataTaxonomyAsync</c>.
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
        public lro::OperationsSettings CreateDataTaxonomyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.UpdateDataTaxonomy</c> and <c>DataTaxonomyServiceClient.UpdateDataTaxonomyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataTaxonomySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTaxonomyServiceClient.UpdateDataTaxonomy</c> and
        /// <c>DataTaxonomyServiceClient.UpdateDataTaxonomyAsync</c>.
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
        public lro::OperationsSettings UpdateDataTaxonomyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.DeleteDataTaxonomy</c> and <c>DataTaxonomyServiceClient.DeleteDataTaxonomyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataTaxonomySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTaxonomyServiceClient.DeleteDataTaxonomy</c> and
        /// <c>DataTaxonomyServiceClient.DeleteDataTaxonomyAsync</c>.
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
        public lro::OperationsSettings DeleteDataTaxonomyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.ListDataTaxonomies</c> and <c>DataTaxonomyServiceClient.ListDataTaxonomiesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataTaxonomiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.GetDataTaxonomy</c> and <c>DataTaxonomyServiceClient.GetDataTaxonomyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataTaxonomySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.CreateDataAttributeBinding</c> and
        /// <c>DataTaxonomyServiceClient.CreateDataAttributeBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataAttributeBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTaxonomyServiceClient.CreateDataAttributeBinding</c> and
        /// <c>DataTaxonomyServiceClient.CreateDataAttributeBindingAsync</c>.
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
        public lro::OperationsSettings CreateDataAttributeBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.UpdateDataAttributeBinding</c> and
        /// <c>DataTaxonomyServiceClient.UpdateDataAttributeBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataAttributeBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTaxonomyServiceClient.UpdateDataAttributeBinding</c> and
        /// <c>DataTaxonomyServiceClient.UpdateDataAttributeBindingAsync</c>.
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
        public lro::OperationsSettings UpdateDataAttributeBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.DeleteDataAttributeBinding</c> and
        /// <c>DataTaxonomyServiceClient.DeleteDataAttributeBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataAttributeBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTaxonomyServiceClient.DeleteDataAttributeBinding</c> and
        /// <c>DataTaxonomyServiceClient.DeleteDataAttributeBindingAsync</c>.
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
        public lro::OperationsSettings DeleteDataAttributeBindingOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.ListDataAttributeBindings</c> and
        /// <c>DataTaxonomyServiceClient.ListDataAttributeBindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataAttributeBindingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.GetDataAttributeBinding</c> and
        /// <c>DataTaxonomyServiceClient.GetDataAttributeBindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataAttributeBindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.CreateDataAttribute</c> and
        /// <c>DataTaxonomyServiceClient.CreateDataAttributeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataAttributeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTaxonomyServiceClient.CreateDataAttribute</c> and
        /// <c>DataTaxonomyServiceClient.CreateDataAttributeAsync</c>.
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
        public lro::OperationsSettings CreateDataAttributeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.UpdateDataAttribute</c> and
        /// <c>DataTaxonomyServiceClient.UpdateDataAttributeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataAttributeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTaxonomyServiceClient.UpdateDataAttribute</c> and
        /// <c>DataTaxonomyServiceClient.UpdateDataAttributeAsync</c>.
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
        public lro::OperationsSettings UpdateDataAttributeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.DeleteDataAttribute</c> and
        /// <c>DataTaxonomyServiceClient.DeleteDataAttributeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataAttributeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTaxonomyServiceClient.DeleteDataAttribute</c> and
        /// <c>DataTaxonomyServiceClient.DeleteDataAttributeAsync</c>.
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
        public lro::OperationsSettings DeleteDataAttributeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.ListDataAttributes</c> and <c>DataTaxonomyServiceClient.ListDataAttributesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataAttributesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTaxonomyServiceClient.GetDataAttribute</c> and <c>DataTaxonomyServiceClient.GetDataAttributeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataAttributeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataTaxonomyServiceSettings"/> object.</returns>
        public DataTaxonomyServiceSettings Clone() => new DataTaxonomyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataTaxonomyServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataTaxonomyServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataTaxonomyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataTaxonomyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataTaxonomyServiceClientBuilder() : base(DataTaxonomyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataTaxonomyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataTaxonomyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataTaxonomyServiceClient Build()
        {
            DataTaxonomyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataTaxonomyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataTaxonomyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataTaxonomyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataTaxonomyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataTaxonomyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataTaxonomyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataTaxonomyServiceClient.ChannelPool;
    }

    /// <summary>DataTaxonomyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// DataTaxonomyService enables attribute-based governance. The resources
    /// currently offered include DataTaxonomy and DataAttribute.
    /// </remarks>
    public abstract partial class DataTaxonomyServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataTaxonomyService service, which is a host of "dataplex.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataplex.googleapis.com:443";

        /// <summary>The default DataTaxonomyService scopes.</summary>
        /// <remarks>
        /// The default DataTaxonomyService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataTaxonomyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataTaxonomyServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DataTaxonomyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataTaxonomyServiceClient"/>.</returns>
        public static stt::Task<DataTaxonomyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataTaxonomyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataTaxonomyServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DataTaxonomyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataTaxonomyServiceClient"/>.</returns>
        public static DataTaxonomyServiceClient Create() => new DataTaxonomyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataTaxonomyServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataTaxonomyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataTaxonomyServiceClient"/>.</returns>
        internal static DataTaxonomyServiceClient Create(grpccore::CallInvoker callInvoker, DataTaxonomyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataTaxonomyService.DataTaxonomyServiceClient grpcClient = new DataTaxonomyService.DataTaxonomyServiceClient(callInvoker);
            return new DataTaxonomyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataTaxonomyService client</summary>
        public virtual DataTaxonomyService.DataTaxonomyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataTaxonomy, OperationMetadata> CreateDataTaxonomy(CreateDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> CreateDataTaxonomyAsync(CreateDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> CreateDataTaxonomyAsync(CreateDataTaxonomyRequest request, st::CancellationToken cancellationToken) =>
            CreateDataTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataTaxonomy</c>.</summary>
        public virtual lro::OperationsClient CreateDataTaxonomyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDataTaxonomy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataTaxonomy, OperationMetadata> PollOnceCreateDataTaxonomy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataTaxonomy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataTaxonomyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataTaxonomy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> PollOnceCreateDataTaxonomyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataTaxonomy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataTaxonomyOperationsClient, callSettings);

        /// <summary>
        /// Create a DataTaxonomy resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the data taxonomy location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataTaxonomy">
        /// Required. DataTaxonomy resource.
        /// </param>
        /// <param name="dataTaxonomyId">
        /// Required. DataTaxonomy identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataTaxonomy, OperationMetadata> CreateDataTaxonomy(string parent, DataTaxonomy dataTaxonomy, string dataTaxonomyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTaxonomy(new CreateDataTaxonomyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataTaxonomyId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataTaxonomyId, nameof(dataTaxonomyId)),
                DataTaxonomy = gax::GaxPreconditions.CheckNotNull(dataTaxonomy, nameof(dataTaxonomy)),
            }, callSettings);

        /// <summary>
        /// Create a DataTaxonomy resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the data taxonomy location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataTaxonomy">
        /// Required. DataTaxonomy resource.
        /// </param>
        /// <param name="dataTaxonomyId">
        /// Required. DataTaxonomy identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> CreateDataTaxonomyAsync(string parent, DataTaxonomy dataTaxonomy, string dataTaxonomyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTaxonomyAsync(new CreateDataTaxonomyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataTaxonomyId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataTaxonomyId, nameof(dataTaxonomyId)),
                DataTaxonomy = gax::GaxPreconditions.CheckNotNull(dataTaxonomy, nameof(dataTaxonomy)),
            }, callSettings);

        /// <summary>
        /// Create a DataTaxonomy resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the data taxonomy location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataTaxonomy">
        /// Required. DataTaxonomy resource.
        /// </param>
        /// <param name="dataTaxonomyId">
        /// Required. DataTaxonomy identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> CreateDataTaxonomyAsync(string parent, DataTaxonomy dataTaxonomy, string dataTaxonomyId, st::CancellationToken cancellationToken) =>
            CreateDataTaxonomyAsync(parent, dataTaxonomy, dataTaxonomyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a DataTaxonomy resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the data taxonomy location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataTaxonomy">
        /// Required. DataTaxonomy resource.
        /// </param>
        /// <param name="dataTaxonomyId">
        /// Required. DataTaxonomy identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataTaxonomy, OperationMetadata> CreateDataTaxonomy(gagr::LocationName parent, DataTaxonomy dataTaxonomy, string dataTaxonomyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTaxonomy(new CreateDataTaxonomyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataTaxonomyId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataTaxonomyId, nameof(dataTaxonomyId)),
                DataTaxonomy = gax::GaxPreconditions.CheckNotNull(dataTaxonomy, nameof(dataTaxonomy)),
            }, callSettings);

        /// <summary>
        /// Create a DataTaxonomy resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the data taxonomy location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataTaxonomy">
        /// Required. DataTaxonomy resource.
        /// </param>
        /// <param name="dataTaxonomyId">
        /// Required. DataTaxonomy identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> CreateDataTaxonomyAsync(gagr::LocationName parent, DataTaxonomy dataTaxonomy, string dataTaxonomyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTaxonomyAsync(new CreateDataTaxonomyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataTaxonomyId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataTaxonomyId, nameof(dataTaxonomyId)),
                DataTaxonomy = gax::GaxPreconditions.CheckNotNull(dataTaxonomy, nameof(dataTaxonomy)),
            }, callSettings);

        /// <summary>
        /// Create a DataTaxonomy resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the data taxonomy location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataTaxonomy">
        /// Required. DataTaxonomy resource.
        /// </param>
        /// <param name="dataTaxonomyId">
        /// Required. DataTaxonomy identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> CreateDataTaxonomyAsync(gagr::LocationName parent, DataTaxonomy dataTaxonomy, string dataTaxonomyId, st::CancellationToken cancellationToken) =>
            CreateDataTaxonomyAsync(parent, dataTaxonomy, dataTaxonomyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataTaxonomy, OperationMetadata> UpdateDataTaxonomy(UpdateDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> UpdateDataTaxonomyAsync(UpdateDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> UpdateDataTaxonomyAsync(UpdateDataTaxonomyRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDataTaxonomy</c>.</summary>
        public virtual lro::OperationsClient UpdateDataTaxonomyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDataTaxonomy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataTaxonomy, OperationMetadata> PollOnceUpdateDataTaxonomy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataTaxonomy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataTaxonomyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataTaxonomy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> PollOnceUpdateDataTaxonomyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataTaxonomy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataTaxonomyOperationsClient, callSettings);

        /// <summary>
        /// Updates a DataTaxonomy resource.
        /// </summary>
        /// <param name="dataTaxonomy">
        /// Required. Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataTaxonomy, OperationMetadata> UpdateDataTaxonomy(DataTaxonomy dataTaxonomy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataTaxonomy(new UpdateDataTaxonomyRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DataTaxonomy = gax::GaxPreconditions.CheckNotNull(dataTaxonomy, nameof(dataTaxonomy)),
            }, callSettings);

        /// <summary>
        /// Updates a DataTaxonomy resource.
        /// </summary>
        /// <param name="dataTaxonomy">
        /// Required. Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> UpdateDataTaxonomyAsync(DataTaxonomy dataTaxonomy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataTaxonomyAsync(new UpdateDataTaxonomyRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DataTaxonomy = gax::GaxPreconditions.CheckNotNull(dataTaxonomy, nameof(dataTaxonomy)),
            }, callSettings);

        /// <summary>
        /// Updates a DataTaxonomy resource.
        /// </summary>
        /// <param name="dataTaxonomy">
        /// Required. Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> UpdateDataTaxonomyAsync(DataTaxonomy dataTaxonomy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataTaxonomyAsync(dataTaxonomy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DataTaxonomy resource. All attributes within the DataTaxonomy
        /// must be deleted before the DataTaxonomy can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataTaxonomy(DeleteDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DataTaxonomy resource. All attributes within the DataTaxonomy
        /// must be deleted before the DataTaxonomy can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataTaxonomyAsync(DeleteDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DataTaxonomy resource. All attributes within the DataTaxonomy
        /// must be deleted before the DataTaxonomy can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataTaxonomyAsync(DeleteDataTaxonomyRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataTaxonomy</c>.</summary>
        public virtual lro::OperationsClient DeleteDataTaxonomyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDataTaxonomy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDataTaxonomy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataTaxonomyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataTaxonomy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDataTaxonomyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataTaxonomyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a DataTaxonomy resource. All attributes within the DataTaxonomy
        /// must be deleted before the DataTaxonomy can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataTaxonomy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTaxonomy(new DeleteDataTaxonomyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataTaxonomy resource. All attributes within the DataTaxonomy
        /// must be deleted before the DataTaxonomy can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataTaxonomyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTaxonomyAsync(new DeleteDataTaxonomyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataTaxonomy resource. All attributes within the DataTaxonomy
        /// must be deleted before the DataTaxonomy can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataTaxonomyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataTaxonomyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DataTaxonomy resource. All attributes within the DataTaxonomy
        /// must be deleted before the DataTaxonomy can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataTaxonomy(DataTaxonomyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTaxonomy(new DeleteDataTaxonomyRequest
            {
                DataTaxonomyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataTaxonomy resource. All attributes within the DataTaxonomy
        /// must be deleted before the DataTaxonomy can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataTaxonomyAsync(DataTaxonomyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTaxonomyAsync(new DeleteDataTaxonomyRequest
            {
                DataTaxonomyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataTaxonomy resource. All attributes within the DataTaxonomy
        /// must be deleted before the DataTaxonomy can be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataTaxonomyAsync(DataTaxonomyName name, st::CancellationToken cancellationToken) =>
            DeleteDataTaxonomyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DataTaxonomy resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataTaxonomy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataTaxonomiesResponse, DataTaxonomy> ListDataTaxonomies(ListDataTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataTaxonomy resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataTaxonomy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataTaxonomiesResponse, DataTaxonomy> ListDataTaxonomiesAsync(ListDataTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataTaxonomy resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataTaxonomy location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="DataTaxonomy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataTaxonomiesResponse, DataTaxonomy> ListDataTaxonomies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTaxonomiesRequest request = new ListDataTaxonomiesRequest
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
            return ListDataTaxonomies(request, callSettings);
        }

        /// <summary>
        /// Lists DataTaxonomy resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataTaxonomy location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataTaxonomy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataTaxonomiesResponse, DataTaxonomy> ListDataTaxonomiesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTaxonomiesRequest request = new ListDataTaxonomiesRequest
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
            return ListDataTaxonomiesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DataTaxonomy resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataTaxonomy location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="DataTaxonomy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataTaxonomiesResponse, DataTaxonomy> ListDataTaxonomies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTaxonomiesRequest request = new ListDataTaxonomiesRequest
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
            return ListDataTaxonomies(request, callSettings);
        }

        /// <summary>
        /// Lists DataTaxonomy resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataTaxonomy location, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataTaxonomy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataTaxonomiesResponse, DataTaxonomy> ListDataTaxonomiesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTaxonomiesRequest request = new ListDataTaxonomiesRequest
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
            return ListDataTaxonomiesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTaxonomy GetDataTaxonomy(GetDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTaxonomy> GetDataTaxonomyAsync(GetDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTaxonomy> GetDataTaxonomyAsync(GetDataTaxonomyRequest request, st::CancellationToken cancellationToken) =>
            GetDataTaxonomyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a DataTaxonomy resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTaxonomy GetDataTaxonomy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTaxonomy(new GetDataTaxonomyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a DataTaxonomy resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTaxonomy> GetDataTaxonomyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTaxonomyAsync(new GetDataTaxonomyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a DataTaxonomy resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTaxonomy> GetDataTaxonomyAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataTaxonomyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a DataTaxonomy resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTaxonomy GetDataTaxonomy(DataTaxonomyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTaxonomy(new GetDataTaxonomyRequest
            {
                DataTaxonomyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a DataTaxonomy resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTaxonomy> GetDataTaxonomyAsync(DataTaxonomyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTaxonomyAsync(new GetDataTaxonomyRequest
            {
                DataTaxonomyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a DataTaxonomy resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTaxonomy> GetDataTaxonomyAsync(DataTaxonomyName name, st::CancellationToken cancellationToken) =>
            GetDataTaxonomyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAttributeBinding, OperationMetadata> CreateDataAttributeBinding(CreateDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> CreateDataAttributeBindingAsync(CreateDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> CreateDataAttributeBindingAsync(CreateDataAttributeBindingRequest request, st::CancellationToken cancellationToken) =>
            CreateDataAttributeBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataAttributeBinding</c>.</summary>
        public virtual lro::OperationsClient CreateDataAttributeBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataAttributeBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataAttributeBinding, OperationMetadata> PollOnceCreateDataAttributeBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAttributeBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataAttributeBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataAttributeBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> PollOnceCreateDataAttributeBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAttributeBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataAttributeBindingOperationsClient, callSettings);

        /// <summary>
        /// Create a DataAttributeBinding resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}
        /// </param>
        /// <param name="dataAttributeBinding">
        /// Required. DataAttributeBinding resource.
        /// </param>
        /// <param name="dataAttributeBindingId">
        /// Required. DataAttributeBinding identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAttributeBinding, OperationMetadata> CreateDataAttributeBinding(string parent, DataAttributeBinding dataAttributeBinding, string dataAttributeBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAttributeBinding(new CreateDataAttributeBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAttributeBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeBindingId, nameof(dataAttributeBindingId)),
                DataAttributeBinding = gax::GaxPreconditions.CheckNotNull(dataAttributeBinding, nameof(dataAttributeBinding)),
            }, callSettings);

        /// <summary>
        /// Create a DataAttributeBinding resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}
        /// </param>
        /// <param name="dataAttributeBinding">
        /// Required. DataAttributeBinding resource.
        /// </param>
        /// <param name="dataAttributeBindingId">
        /// Required. DataAttributeBinding identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> CreateDataAttributeBindingAsync(string parent, DataAttributeBinding dataAttributeBinding, string dataAttributeBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAttributeBindingAsync(new CreateDataAttributeBindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAttributeBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeBindingId, nameof(dataAttributeBindingId)),
                DataAttributeBinding = gax::GaxPreconditions.CheckNotNull(dataAttributeBinding, nameof(dataAttributeBinding)),
            }, callSettings);

        /// <summary>
        /// Create a DataAttributeBinding resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}
        /// </param>
        /// <param name="dataAttributeBinding">
        /// Required. DataAttributeBinding resource.
        /// </param>
        /// <param name="dataAttributeBindingId">
        /// Required. DataAttributeBinding identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> CreateDataAttributeBindingAsync(string parent, DataAttributeBinding dataAttributeBinding, string dataAttributeBindingId, st::CancellationToken cancellationToken) =>
            CreateDataAttributeBindingAsync(parent, dataAttributeBinding, dataAttributeBindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a DataAttributeBinding resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}
        /// </param>
        /// <param name="dataAttributeBinding">
        /// Required. DataAttributeBinding resource.
        /// </param>
        /// <param name="dataAttributeBindingId">
        /// Required. DataAttributeBinding identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAttributeBinding, OperationMetadata> CreateDataAttributeBinding(gagr::LocationName parent, DataAttributeBinding dataAttributeBinding, string dataAttributeBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAttributeBinding(new CreateDataAttributeBindingRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAttributeBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeBindingId, nameof(dataAttributeBindingId)),
                DataAttributeBinding = gax::GaxPreconditions.CheckNotNull(dataAttributeBinding, nameof(dataAttributeBinding)),
            }, callSettings);

        /// <summary>
        /// Create a DataAttributeBinding resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}
        /// </param>
        /// <param name="dataAttributeBinding">
        /// Required. DataAttributeBinding resource.
        /// </param>
        /// <param name="dataAttributeBindingId">
        /// Required. DataAttributeBinding identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> CreateDataAttributeBindingAsync(gagr::LocationName parent, DataAttributeBinding dataAttributeBinding, string dataAttributeBindingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAttributeBindingAsync(new CreateDataAttributeBindingRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAttributeBindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeBindingId, nameof(dataAttributeBindingId)),
                DataAttributeBinding = gax::GaxPreconditions.CheckNotNull(dataAttributeBinding, nameof(dataAttributeBinding)),
            }, callSettings);

        /// <summary>
        /// Create a DataAttributeBinding resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}
        /// </param>
        /// <param name="dataAttributeBinding">
        /// Required. DataAttributeBinding resource.
        /// </param>
        /// <param name="dataAttributeBindingId">
        /// Required. DataAttributeBinding identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the Location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> CreateDataAttributeBindingAsync(gagr::LocationName parent, DataAttributeBinding dataAttributeBinding, string dataAttributeBindingId, st::CancellationToken cancellationToken) =>
            CreateDataAttributeBindingAsync(parent, dataAttributeBinding, dataAttributeBindingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAttributeBinding, OperationMetadata> UpdateDataAttributeBinding(UpdateDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> UpdateDataAttributeBindingAsync(UpdateDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> UpdateDataAttributeBindingAsync(UpdateDataAttributeBindingRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataAttributeBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDataAttributeBinding</c>.</summary>
        public virtual lro::OperationsClient UpdateDataAttributeBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataAttributeBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataAttributeBinding, OperationMetadata> PollOnceUpdateDataAttributeBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAttributeBinding, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataAttributeBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataAttributeBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> PollOnceUpdateDataAttributeBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAttributeBinding, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataAttributeBindingOperationsClient, callSettings);

        /// <summary>
        /// Updates a DataAttributeBinding resource.
        /// </summary>
        /// <param name="dataAttributeBinding">
        /// Required. Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAttributeBinding, OperationMetadata> UpdateDataAttributeBinding(DataAttributeBinding dataAttributeBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAttributeBinding(new UpdateDataAttributeBindingRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DataAttributeBinding = gax::GaxPreconditions.CheckNotNull(dataAttributeBinding, nameof(dataAttributeBinding)),
            }, callSettings);

        /// <summary>
        /// Updates a DataAttributeBinding resource.
        /// </summary>
        /// <param name="dataAttributeBinding">
        /// Required. Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> UpdateDataAttributeBindingAsync(DataAttributeBinding dataAttributeBinding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAttributeBindingAsync(new UpdateDataAttributeBindingRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DataAttributeBinding = gax::GaxPreconditions.CheckNotNull(dataAttributeBinding, nameof(dataAttributeBinding)),
            }, callSettings);

        /// <summary>
        /// Updates a DataAttributeBinding resource.
        /// </summary>
        /// <param name="dataAttributeBinding">
        /// Required. Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> UpdateDataAttributeBindingAsync(DataAttributeBinding dataAttributeBinding, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataAttributeBindingAsync(dataAttributeBinding, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DataAttributeBinding resource. All attributes within the
        /// DataAttributeBinding must be deleted before the DataAttributeBinding can be
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAttributeBinding(DeleteDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DataAttributeBinding resource. All attributes within the
        /// DataAttributeBinding must be deleted before the DataAttributeBinding can be
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeBindingAsync(DeleteDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DataAttributeBinding resource. All attributes within the
        /// DataAttributeBinding must be deleted before the DataAttributeBinding can be
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeBindingAsync(DeleteDataAttributeBindingRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataAttributeBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataAttributeBinding</c>.</summary>
        public virtual lro::OperationsClient DeleteDataAttributeBindingOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataAttributeBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDataAttributeBinding(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataAttributeBindingOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataAttributeBinding</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDataAttributeBindingAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataAttributeBindingOperationsClient, callSettings);

        /// <summary>
        /// Deletes a DataAttributeBinding resource. All attributes within the
        /// DataAttributeBinding must be deleted before the DataAttributeBinding can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAttributeBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAttributeBinding(new DeleteDataAttributeBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataAttributeBinding resource. All attributes within the
        /// DataAttributeBinding must be deleted before the DataAttributeBinding can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAttributeBindingAsync(new DeleteDataAttributeBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataAttributeBinding resource. All attributes within the
        /// DataAttributeBinding must be deleted before the DataAttributeBinding can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeBindingAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataAttributeBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DataAttributeBinding resource. All attributes within the
        /// DataAttributeBinding must be deleted before the DataAttributeBinding can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAttributeBinding(DataAttributeBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAttributeBinding(new DeleteDataAttributeBindingRequest
            {
                DataAttributeBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataAttributeBinding resource. All attributes within the
        /// DataAttributeBinding must be deleted before the DataAttributeBinding can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeBindingAsync(DataAttributeBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAttributeBindingAsync(new DeleteDataAttributeBindingRequest
            {
                DataAttributeBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataAttributeBinding resource. All attributes within the
        /// DataAttributeBinding must be deleted before the DataAttributeBinding can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeBindingAsync(DataAttributeBindingName name, st::CancellationToken cancellationToken) =>
            DeleteDataAttributeBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DataAttributeBinding resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAttributeBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAttributeBindingsResponse, DataAttributeBinding> ListDataAttributeBindings(ListDataAttributeBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataAttributeBinding resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAttributeBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAttributeBindingsResponse, DataAttributeBinding> ListDataAttributeBindingsAsync(ListDataAttributeBindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataAttributeBinding resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location:
        /// projects/{project_number}/locations/{location_id}
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
        /// <returns>A pageable sequence of <see cref="DataAttributeBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAttributeBindingsResponse, DataAttributeBinding> ListDataAttributeBindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAttributeBindingsRequest request = new ListDataAttributeBindingsRequest
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
            return ListDataAttributeBindings(request, callSettings);
        }

        /// <summary>
        /// Lists DataAttributeBinding resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location:
        /// projects/{project_number}/locations/{location_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAttributeBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAttributeBindingsResponse, DataAttributeBinding> ListDataAttributeBindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAttributeBindingsRequest request = new ListDataAttributeBindingsRequest
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
            return ListDataAttributeBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DataAttributeBinding resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location:
        /// projects/{project_number}/locations/{location_id}
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
        /// <returns>A pageable sequence of <see cref="DataAttributeBinding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAttributeBindingsResponse, DataAttributeBinding> ListDataAttributeBindings(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAttributeBindingsRequest request = new ListDataAttributeBindingsRequest
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
            return ListDataAttributeBindings(request, callSettings);
        }

        /// <summary>
        /// Lists DataAttributeBinding resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location:
        /// projects/{project_number}/locations/{location_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAttributeBinding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAttributeBindingsResponse, DataAttributeBinding> ListDataAttributeBindingsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAttributeBindingsRequest request = new ListDataAttributeBindingsRequest
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
            return ListDataAttributeBindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAttributeBinding GetDataAttributeBinding(GetDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttributeBinding> GetDataAttributeBindingAsync(GetDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttributeBinding> GetDataAttributeBindingAsync(GetDataAttributeBindingRequest request, st::CancellationToken cancellationToken) =>
            GetDataAttributeBindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a DataAttributeBinding resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAttributeBinding GetDataAttributeBinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAttributeBinding(new GetDataAttributeBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a DataAttributeBinding resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttributeBinding> GetDataAttributeBindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAttributeBindingAsync(new GetDataAttributeBindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a DataAttributeBinding resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttributeBinding> GetDataAttributeBindingAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataAttributeBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a DataAttributeBinding resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAttributeBinding GetDataAttributeBinding(DataAttributeBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAttributeBinding(new GetDataAttributeBindingRequest
            {
                DataAttributeBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a DataAttributeBinding resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttributeBinding> GetDataAttributeBindingAsync(DataAttributeBindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAttributeBindingAsync(new GetDataAttributeBindingRequest
            {
                DataAttributeBindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a DataAttributeBinding resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttributeBinding:
        /// projects/{project_number}/locations/{location_id}/dataAttributeBindings/{data_attribute_binding_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttributeBinding> GetDataAttributeBindingAsync(DataAttributeBindingName name, st::CancellationToken cancellationToken) =>
            GetDataAttributeBindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a DataAttribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAttribute, OperationMetadata> CreateDataAttribute(CreateDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a DataAttribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> CreateDataAttributeAsync(CreateDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a DataAttribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> CreateDataAttributeAsync(CreateDataAttributeRequest request, st::CancellationToken cancellationToken) =>
            CreateDataAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataAttribute</c>.</summary>
        public virtual lro::OperationsClient CreateDataAttributeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDataAttribute</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataAttribute, OperationMetadata> PollOnceCreateDataAttribute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAttribute, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataAttributeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataAttribute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> PollOnceCreateDataAttributeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAttribute, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataAttributeOperationsClient, callSettings);

        /// <summary>
        /// Create a DataAttribute resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="dataAttribute">
        /// Required. DataAttribute resource.
        /// </param>
        /// <param name="dataAttributeId">
        /// Required. DataAttribute identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the DataTaxonomy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAttribute, OperationMetadata> CreateDataAttribute(string parent, DataAttribute dataAttribute, string dataAttributeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAttribute(new CreateDataAttributeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAttributeId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeId, nameof(dataAttributeId)),
                DataAttribute = gax::GaxPreconditions.CheckNotNull(dataAttribute, nameof(dataAttribute)),
            }, callSettings);

        /// <summary>
        /// Create a DataAttribute resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="dataAttribute">
        /// Required. DataAttribute resource.
        /// </param>
        /// <param name="dataAttributeId">
        /// Required. DataAttribute identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the DataTaxonomy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> CreateDataAttributeAsync(string parent, DataAttribute dataAttribute, string dataAttributeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAttributeAsync(new CreateDataAttributeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAttributeId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeId, nameof(dataAttributeId)),
                DataAttribute = gax::GaxPreconditions.CheckNotNull(dataAttribute, nameof(dataAttribute)),
            }, callSettings);

        /// <summary>
        /// Create a DataAttribute resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="dataAttribute">
        /// Required. DataAttribute resource.
        /// </param>
        /// <param name="dataAttributeId">
        /// Required. DataAttribute identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the DataTaxonomy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> CreateDataAttributeAsync(string parent, DataAttribute dataAttribute, string dataAttributeId, st::CancellationToken cancellationToken) =>
            CreateDataAttributeAsync(parent, dataAttribute, dataAttributeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a DataAttribute resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="dataAttribute">
        /// Required. DataAttribute resource.
        /// </param>
        /// <param name="dataAttributeId">
        /// Required. DataAttribute identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the DataTaxonomy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAttribute, OperationMetadata> CreateDataAttribute(DataTaxonomyName parent, DataAttribute dataAttribute, string dataAttributeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAttribute(new CreateDataAttributeRequest
            {
                ParentAsDataTaxonomyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAttributeId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeId, nameof(dataAttributeId)),
                DataAttribute = gax::GaxPreconditions.CheckNotNull(dataAttribute, nameof(dataAttribute)),
            }, callSettings);

        /// <summary>
        /// Create a DataAttribute resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="dataAttribute">
        /// Required. DataAttribute resource.
        /// </param>
        /// <param name="dataAttributeId">
        /// Required. DataAttribute identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the DataTaxonomy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> CreateDataAttributeAsync(DataTaxonomyName parent, DataAttribute dataAttribute, string dataAttributeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAttributeAsync(new CreateDataAttributeRequest
            {
                ParentAsDataTaxonomyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAttributeId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeId, nameof(dataAttributeId)),
                DataAttribute = gax::GaxPreconditions.CheckNotNull(dataAttribute, nameof(dataAttribute)),
            }, callSettings);

        /// <summary>
        /// Create a DataAttribute resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent data taxonomy
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
        /// </param>
        /// <param name="dataAttribute">
        /// Required. DataAttribute resource.
        /// </param>
        /// <param name="dataAttributeId">
        /// Required. DataAttribute identifier.
        /// * Must contain only lowercase letters, numbers and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the DataTaxonomy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> CreateDataAttributeAsync(DataTaxonomyName parent, DataAttribute dataAttribute, string dataAttributeId, st::CancellationToken cancellationToken) =>
            CreateDataAttributeAsync(parent, dataAttribute, dataAttributeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a DataAttribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAttribute, OperationMetadata> UpdateDataAttribute(UpdateDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DataAttribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> UpdateDataAttributeAsync(UpdateDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a DataAttribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> UpdateDataAttributeAsync(UpdateDataAttributeRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDataAttribute</c>.</summary>
        public virtual lro::OperationsClient UpdateDataAttributeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDataAttribute</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataAttribute, OperationMetadata> PollOnceUpdateDataAttribute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAttribute, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataAttributeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataAttribute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> PollOnceUpdateDataAttributeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAttribute, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataAttributeOperationsClient, callSettings);

        /// <summary>
        /// Updates a DataAttribute resource.
        /// </summary>
        /// <param name="dataAttribute">
        /// Required. Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAttribute, OperationMetadata> UpdateDataAttribute(DataAttribute dataAttribute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAttribute(new UpdateDataAttributeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DataAttribute = gax::GaxPreconditions.CheckNotNull(dataAttribute, nameof(dataAttribute)),
            }, callSettings);

        /// <summary>
        /// Updates a DataAttribute resource.
        /// </summary>
        /// <param name="dataAttribute">
        /// Required. Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> UpdateDataAttributeAsync(DataAttribute dataAttribute, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAttributeAsync(new UpdateDataAttributeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DataAttribute = gax::GaxPreconditions.CheckNotNull(dataAttribute, nameof(dataAttribute)),
            }, callSettings);

        /// <summary>
        /// Updates a DataAttribute resource.
        /// </summary>
        /// <param name="dataAttribute">
        /// Required. Only fields specified in `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAttribute, OperationMetadata>> UpdateDataAttributeAsync(DataAttribute dataAttribute, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataAttributeAsync(dataAttribute, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Data Attribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAttribute(DeleteDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Data Attribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeAsync(DeleteDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Data Attribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeAsync(DeleteDataAttributeRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataAttribute</c>.</summary>
        public virtual lro::OperationsClient DeleteDataAttributeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDataAttribute</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDataAttribute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataAttributeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataAttribute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDataAttributeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataAttributeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAttribute(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAttribute(new DeleteDataAttributeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAttributeAsync(new DeleteDataAttributeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataAttributeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAttribute(DataAttributeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAttribute(new DeleteDataAttributeRequest
            {
                DataAttributeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeAsync(DataAttributeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAttributeAsync(new DeleteDataAttributeRequest
            {
                DataAttributeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeAsync(DataAttributeName name, st::CancellationToken cancellationToken) =>
            DeleteDataAttributeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Data Attribute resources in a DataTaxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAttribute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAttributesResponse, DataAttribute> ListDataAttributes(ListDataAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Data Attribute resources in a DataTaxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAttribute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAttributesResponse, DataAttribute> ListDataAttributesAsync(ListDataAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Data Attribute resources in a DataTaxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
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
        /// <returns>A pageable sequence of <see cref="DataAttribute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAttributesResponse, DataAttribute> ListDataAttributes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAttributesRequest request = new ListDataAttributesRequest
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
            return ListDataAttributes(request, callSettings);
        }

        /// <summary>
        /// Lists Data Attribute resources in a DataTaxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAttribute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAttributesResponse, DataAttribute> ListDataAttributesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAttributesRequest request = new ListDataAttributesRequest
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
            return ListDataAttributesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Data Attribute resources in a DataTaxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
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
        /// <returns>A pageable sequence of <see cref="DataAttribute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAttributesResponse, DataAttribute> ListDataAttributes(DataTaxonomyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAttributesRequest request = new ListDataAttributesRequest
            {
                ParentAsDataTaxonomyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataAttributes(request, callSettings);
        }

        /// <summary>
        /// Lists Data Attribute resources in a DataTaxonomy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the DataTaxonomy:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{data_taxonomy_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAttribute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAttributesResponse, DataAttribute> ListDataAttributesAsync(DataTaxonomyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAttributesRequest request = new ListDataAttributesRequest
            {
                ParentAsDataTaxonomyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataAttributesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a Data Attribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAttribute GetDataAttribute(GetDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Data Attribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttribute> GetDataAttributeAsync(GetDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Data Attribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttribute> GetDataAttributeAsync(GetDataAttributeRequest request, st::CancellationToken cancellationToken) =>
            GetDataAttributeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAttribute GetDataAttribute(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAttribute(new GetDataAttributeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttribute> GetDataAttributeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAttributeAsync(new GetDataAttributeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttribute> GetDataAttributeAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataAttributeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAttribute GetDataAttribute(DataAttributeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAttribute(new GetDataAttributeRequest
            {
                DataAttributeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttribute> GetDataAttributeAsync(DataAttributeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAttributeAsync(new GetDataAttributeRequest
            {
                DataAttributeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Data Attribute resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataAttribute:
        /// projects/{project_number}/locations/{location_id}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAttribute> GetDataAttributeAsync(DataAttributeName name, st::CancellationToken cancellationToken) =>
            GetDataAttributeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataTaxonomyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// DataTaxonomyService enables attribute-based governance. The resources
    /// currently offered include DataTaxonomy and DataAttribute.
    /// </remarks>
    public sealed partial class DataTaxonomyServiceClientImpl : DataTaxonomyServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDataTaxonomyRequest, lro::Operation> _callCreateDataTaxonomy;

        private readonly gaxgrpc::ApiCall<UpdateDataTaxonomyRequest, lro::Operation> _callUpdateDataTaxonomy;

        private readonly gaxgrpc::ApiCall<DeleteDataTaxonomyRequest, lro::Operation> _callDeleteDataTaxonomy;

        private readonly gaxgrpc::ApiCall<ListDataTaxonomiesRequest, ListDataTaxonomiesResponse> _callListDataTaxonomies;

        private readonly gaxgrpc::ApiCall<GetDataTaxonomyRequest, DataTaxonomy> _callGetDataTaxonomy;

        private readonly gaxgrpc::ApiCall<CreateDataAttributeBindingRequest, lro::Operation> _callCreateDataAttributeBinding;

        private readonly gaxgrpc::ApiCall<UpdateDataAttributeBindingRequest, lro::Operation> _callUpdateDataAttributeBinding;

        private readonly gaxgrpc::ApiCall<DeleteDataAttributeBindingRequest, lro::Operation> _callDeleteDataAttributeBinding;

        private readonly gaxgrpc::ApiCall<ListDataAttributeBindingsRequest, ListDataAttributeBindingsResponse> _callListDataAttributeBindings;

        private readonly gaxgrpc::ApiCall<GetDataAttributeBindingRequest, DataAttributeBinding> _callGetDataAttributeBinding;

        private readonly gaxgrpc::ApiCall<CreateDataAttributeRequest, lro::Operation> _callCreateDataAttribute;

        private readonly gaxgrpc::ApiCall<UpdateDataAttributeRequest, lro::Operation> _callUpdateDataAttribute;

        private readonly gaxgrpc::ApiCall<DeleteDataAttributeRequest, lro::Operation> _callDeleteDataAttribute;

        private readonly gaxgrpc::ApiCall<ListDataAttributesRequest, ListDataAttributesResponse> _callListDataAttributes;

        private readonly gaxgrpc::ApiCall<GetDataAttributeRequest, DataAttribute> _callGetDataAttribute;

        /// <summary>
        /// Constructs a client wrapper for the DataTaxonomyService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataTaxonomyServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataTaxonomyServiceClientImpl(DataTaxonomyService.DataTaxonomyServiceClient grpcClient, DataTaxonomyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataTaxonomyServiceSettings effectiveSettings = settings ?? DataTaxonomyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDataTaxonomyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDataTaxonomyOperationsSettings, logger);
            UpdateDataTaxonomyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDataTaxonomyOperationsSettings, logger);
            DeleteDataTaxonomyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDataTaxonomyOperationsSettings, logger);
            CreateDataAttributeBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDataAttributeBindingOperationsSettings, logger);
            UpdateDataAttributeBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDataAttributeBindingOperationsSettings, logger);
            DeleteDataAttributeBindingOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDataAttributeBindingOperationsSettings, logger);
            CreateDataAttributeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDataAttributeOperationsSettings, logger);
            UpdateDataAttributeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDataAttributeOperationsSettings, logger);
            DeleteDataAttributeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDataAttributeOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateDataTaxonomy = clientHelper.BuildApiCall<CreateDataTaxonomyRequest, lro::Operation>("CreateDataTaxonomy", grpcClient.CreateDataTaxonomyAsync, grpcClient.CreateDataTaxonomy, effectiveSettings.CreateDataTaxonomySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataTaxonomy);
            Modify_CreateDataTaxonomyApiCall(ref _callCreateDataTaxonomy);
            _callUpdateDataTaxonomy = clientHelper.BuildApiCall<UpdateDataTaxonomyRequest, lro::Operation>("UpdateDataTaxonomy", grpcClient.UpdateDataTaxonomyAsync, grpcClient.UpdateDataTaxonomy, effectiveSettings.UpdateDataTaxonomySettings).WithGoogleRequestParam("data_taxonomy.name", request => request.DataTaxonomy?.Name);
            Modify_ApiCall(ref _callUpdateDataTaxonomy);
            Modify_UpdateDataTaxonomyApiCall(ref _callUpdateDataTaxonomy);
            _callDeleteDataTaxonomy = clientHelper.BuildApiCall<DeleteDataTaxonomyRequest, lro::Operation>("DeleteDataTaxonomy", grpcClient.DeleteDataTaxonomyAsync, grpcClient.DeleteDataTaxonomy, effectiveSettings.DeleteDataTaxonomySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataTaxonomy);
            Modify_DeleteDataTaxonomyApiCall(ref _callDeleteDataTaxonomy);
            _callListDataTaxonomies = clientHelper.BuildApiCall<ListDataTaxonomiesRequest, ListDataTaxonomiesResponse>("ListDataTaxonomies", grpcClient.ListDataTaxonomiesAsync, grpcClient.ListDataTaxonomies, effectiveSettings.ListDataTaxonomiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataTaxonomies);
            Modify_ListDataTaxonomiesApiCall(ref _callListDataTaxonomies);
            _callGetDataTaxonomy = clientHelper.BuildApiCall<GetDataTaxonomyRequest, DataTaxonomy>("GetDataTaxonomy", grpcClient.GetDataTaxonomyAsync, grpcClient.GetDataTaxonomy, effectiveSettings.GetDataTaxonomySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataTaxonomy);
            Modify_GetDataTaxonomyApiCall(ref _callGetDataTaxonomy);
            _callCreateDataAttributeBinding = clientHelper.BuildApiCall<CreateDataAttributeBindingRequest, lro::Operation>("CreateDataAttributeBinding", grpcClient.CreateDataAttributeBindingAsync, grpcClient.CreateDataAttributeBinding, effectiveSettings.CreateDataAttributeBindingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataAttributeBinding);
            Modify_CreateDataAttributeBindingApiCall(ref _callCreateDataAttributeBinding);
            _callUpdateDataAttributeBinding = clientHelper.BuildApiCall<UpdateDataAttributeBindingRequest, lro::Operation>("UpdateDataAttributeBinding", grpcClient.UpdateDataAttributeBindingAsync, grpcClient.UpdateDataAttributeBinding, effectiveSettings.UpdateDataAttributeBindingSettings).WithGoogleRequestParam("data_attribute_binding.name", request => request.DataAttributeBinding?.Name);
            Modify_ApiCall(ref _callUpdateDataAttributeBinding);
            Modify_UpdateDataAttributeBindingApiCall(ref _callUpdateDataAttributeBinding);
            _callDeleteDataAttributeBinding = clientHelper.BuildApiCall<DeleteDataAttributeBindingRequest, lro::Operation>("DeleteDataAttributeBinding", grpcClient.DeleteDataAttributeBindingAsync, grpcClient.DeleteDataAttributeBinding, effectiveSettings.DeleteDataAttributeBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataAttributeBinding);
            Modify_DeleteDataAttributeBindingApiCall(ref _callDeleteDataAttributeBinding);
            _callListDataAttributeBindings = clientHelper.BuildApiCall<ListDataAttributeBindingsRequest, ListDataAttributeBindingsResponse>("ListDataAttributeBindings", grpcClient.ListDataAttributeBindingsAsync, grpcClient.ListDataAttributeBindings, effectiveSettings.ListDataAttributeBindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataAttributeBindings);
            Modify_ListDataAttributeBindingsApiCall(ref _callListDataAttributeBindings);
            _callGetDataAttributeBinding = clientHelper.BuildApiCall<GetDataAttributeBindingRequest, DataAttributeBinding>("GetDataAttributeBinding", grpcClient.GetDataAttributeBindingAsync, grpcClient.GetDataAttributeBinding, effectiveSettings.GetDataAttributeBindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataAttributeBinding);
            Modify_GetDataAttributeBindingApiCall(ref _callGetDataAttributeBinding);
            _callCreateDataAttribute = clientHelper.BuildApiCall<CreateDataAttributeRequest, lro::Operation>("CreateDataAttribute", grpcClient.CreateDataAttributeAsync, grpcClient.CreateDataAttribute, effectiveSettings.CreateDataAttributeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataAttribute);
            Modify_CreateDataAttributeApiCall(ref _callCreateDataAttribute);
            _callUpdateDataAttribute = clientHelper.BuildApiCall<UpdateDataAttributeRequest, lro::Operation>("UpdateDataAttribute", grpcClient.UpdateDataAttributeAsync, grpcClient.UpdateDataAttribute, effectiveSettings.UpdateDataAttributeSettings).WithGoogleRequestParam("data_attribute.name", request => request.DataAttribute?.Name);
            Modify_ApiCall(ref _callUpdateDataAttribute);
            Modify_UpdateDataAttributeApiCall(ref _callUpdateDataAttribute);
            _callDeleteDataAttribute = clientHelper.BuildApiCall<DeleteDataAttributeRequest, lro::Operation>("DeleteDataAttribute", grpcClient.DeleteDataAttributeAsync, grpcClient.DeleteDataAttribute, effectiveSettings.DeleteDataAttributeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataAttribute);
            Modify_DeleteDataAttributeApiCall(ref _callDeleteDataAttribute);
            _callListDataAttributes = clientHelper.BuildApiCall<ListDataAttributesRequest, ListDataAttributesResponse>("ListDataAttributes", grpcClient.ListDataAttributesAsync, grpcClient.ListDataAttributes, effectiveSettings.ListDataAttributesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataAttributes);
            Modify_ListDataAttributesApiCall(ref _callListDataAttributes);
            _callGetDataAttribute = clientHelper.BuildApiCall<GetDataAttributeRequest, DataAttribute>("GetDataAttribute", grpcClient.GetDataAttributeAsync, grpcClient.GetDataAttribute, effectiveSettings.GetDataAttributeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataAttribute);
            Modify_GetDataAttributeApiCall(ref _callGetDataAttribute);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDataTaxonomyApiCall(ref gaxgrpc::ApiCall<CreateDataTaxonomyRequest, lro::Operation> call);

        partial void Modify_UpdateDataTaxonomyApiCall(ref gaxgrpc::ApiCall<UpdateDataTaxonomyRequest, lro::Operation> call);

        partial void Modify_DeleteDataTaxonomyApiCall(ref gaxgrpc::ApiCall<DeleteDataTaxonomyRequest, lro::Operation> call);

        partial void Modify_ListDataTaxonomiesApiCall(ref gaxgrpc::ApiCall<ListDataTaxonomiesRequest, ListDataTaxonomiesResponse> call);

        partial void Modify_GetDataTaxonomyApiCall(ref gaxgrpc::ApiCall<GetDataTaxonomyRequest, DataTaxonomy> call);

        partial void Modify_CreateDataAttributeBindingApiCall(ref gaxgrpc::ApiCall<CreateDataAttributeBindingRequest, lro::Operation> call);

        partial void Modify_UpdateDataAttributeBindingApiCall(ref gaxgrpc::ApiCall<UpdateDataAttributeBindingRequest, lro::Operation> call);

        partial void Modify_DeleteDataAttributeBindingApiCall(ref gaxgrpc::ApiCall<DeleteDataAttributeBindingRequest, lro::Operation> call);

        partial void Modify_ListDataAttributeBindingsApiCall(ref gaxgrpc::ApiCall<ListDataAttributeBindingsRequest, ListDataAttributeBindingsResponse> call);

        partial void Modify_GetDataAttributeBindingApiCall(ref gaxgrpc::ApiCall<GetDataAttributeBindingRequest, DataAttributeBinding> call);

        partial void Modify_CreateDataAttributeApiCall(ref gaxgrpc::ApiCall<CreateDataAttributeRequest, lro::Operation> call);

        partial void Modify_UpdateDataAttributeApiCall(ref gaxgrpc::ApiCall<UpdateDataAttributeRequest, lro::Operation> call);

        partial void Modify_DeleteDataAttributeApiCall(ref gaxgrpc::ApiCall<DeleteDataAttributeRequest, lro::Operation> call);

        partial void Modify_ListDataAttributesApiCall(ref gaxgrpc::ApiCall<ListDataAttributesRequest, ListDataAttributesResponse> call);

        partial void Modify_GetDataAttributeApiCall(ref gaxgrpc::ApiCall<GetDataAttributeRequest, DataAttribute> call);

        partial void OnConstruction(DataTaxonomyService.DataTaxonomyServiceClient grpcClient, DataTaxonomyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataTaxonomyService client</summary>
        public override DataTaxonomyService.DataTaxonomyServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateDataTaxonomyRequest(ref CreateDataTaxonomyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataTaxonomyRequest(ref UpdateDataTaxonomyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataTaxonomyRequest(ref DeleteDataTaxonomyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataTaxonomiesRequest(ref ListDataTaxonomiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataTaxonomyRequest(ref GetDataTaxonomyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataAttributeBindingRequest(ref CreateDataAttributeBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataAttributeBindingRequest(ref UpdateDataAttributeBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataAttributeBindingRequest(ref DeleteDataAttributeBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataAttributeBindingsRequest(ref ListDataAttributeBindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataAttributeBindingRequest(ref GetDataAttributeBindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataAttributeRequest(ref CreateDataAttributeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataAttributeRequest(ref UpdateDataAttributeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataAttributeRequest(ref DeleteDataAttributeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataAttributesRequest(ref ListDataAttributesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataAttributeRequest(ref GetDataAttributeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateDataTaxonomy</c>.</summary>
        public override lro::OperationsClient CreateDataTaxonomyOperationsClient { get; }

        /// <summary>
        /// Create a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataTaxonomy, OperationMetadata> CreateDataTaxonomy(CreateDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataTaxonomyRequest(ref request, ref callSettings);
            return new lro::Operation<DataTaxonomy, OperationMetadata>(_callCreateDataTaxonomy.Sync(request, callSettings), CreateDataTaxonomyOperationsClient);
        }

        /// <summary>
        /// Create a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> CreateDataTaxonomyAsync(CreateDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataTaxonomyRequest(ref request, ref callSettings);
            return new lro::Operation<DataTaxonomy, OperationMetadata>(await _callCreateDataTaxonomy.Async(request, callSettings).ConfigureAwait(false), CreateDataTaxonomyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDataTaxonomy</c>.</summary>
        public override lro::OperationsClient UpdateDataTaxonomyOperationsClient { get; }

        /// <summary>
        /// Updates a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataTaxonomy, OperationMetadata> UpdateDataTaxonomy(UpdateDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataTaxonomyRequest(ref request, ref callSettings);
            return new lro::Operation<DataTaxonomy, OperationMetadata>(_callUpdateDataTaxonomy.Sync(request, callSettings), UpdateDataTaxonomyOperationsClient);
        }

        /// <summary>
        /// Updates a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataTaxonomy, OperationMetadata>> UpdateDataTaxonomyAsync(UpdateDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataTaxonomyRequest(ref request, ref callSettings);
            return new lro::Operation<DataTaxonomy, OperationMetadata>(await _callUpdateDataTaxonomy.Async(request, callSettings).ConfigureAwait(false), UpdateDataTaxonomyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDataTaxonomy</c>.</summary>
        public override lro::OperationsClient DeleteDataTaxonomyOperationsClient { get; }

        /// <summary>
        /// Deletes a DataTaxonomy resource. All attributes within the DataTaxonomy
        /// must be deleted before the DataTaxonomy can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDataTaxonomy(DeleteDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataTaxonomyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDataTaxonomy.Sync(request, callSettings), DeleteDataTaxonomyOperationsClient);
        }

        /// <summary>
        /// Deletes a DataTaxonomy resource. All attributes within the DataTaxonomy
        /// must be deleted before the DataTaxonomy can be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataTaxonomyAsync(DeleteDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataTaxonomyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDataTaxonomy.Async(request, callSettings).ConfigureAwait(false), DeleteDataTaxonomyOperationsClient);
        }

        /// <summary>
        /// Lists DataTaxonomy resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataTaxonomy"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataTaxonomiesResponse, DataTaxonomy> ListDataTaxonomies(ListDataTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataTaxonomiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataTaxonomiesRequest, ListDataTaxonomiesResponse, DataTaxonomy>(_callListDataTaxonomies, request, callSettings);
        }

        /// <summary>
        /// Lists DataTaxonomy resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataTaxonomy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataTaxonomiesResponse, DataTaxonomy> ListDataTaxonomiesAsync(ListDataTaxonomiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataTaxonomiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataTaxonomiesRequest, ListDataTaxonomiesResponse, DataTaxonomy>(_callListDataTaxonomies, request, callSettings);
        }

        /// <summary>
        /// Retrieves a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataTaxonomy GetDataTaxonomy(GetDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataTaxonomyRequest(ref request, ref callSettings);
            return _callGetDataTaxonomy.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a DataTaxonomy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataTaxonomy> GetDataTaxonomyAsync(GetDataTaxonomyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataTaxonomyRequest(ref request, ref callSettings);
            return _callGetDataTaxonomy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDataAttributeBinding</c>.</summary>
        public override lro::OperationsClient CreateDataAttributeBindingOperationsClient { get; }

        /// <summary>
        /// Create a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataAttributeBinding, OperationMetadata> CreateDataAttributeBinding(CreateDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAttributeBindingRequest(ref request, ref callSettings);
            return new lro::Operation<DataAttributeBinding, OperationMetadata>(_callCreateDataAttributeBinding.Sync(request, callSettings), CreateDataAttributeBindingOperationsClient);
        }

        /// <summary>
        /// Create a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> CreateDataAttributeBindingAsync(CreateDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAttributeBindingRequest(ref request, ref callSettings);
            return new lro::Operation<DataAttributeBinding, OperationMetadata>(await _callCreateDataAttributeBinding.Async(request, callSettings).ConfigureAwait(false), CreateDataAttributeBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDataAttributeBinding</c>.</summary>
        public override lro::OperationsClient UpdateDataAttributeBindingOperationsClient { get; }

        /// <summary>
        /// Updates a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataAttributeBinding, OperationMetadata> UpdateDataAttributeBinding(UpdateDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAttributeBindingRequest(ref request, ref callSettings);
            return new lro::Operation<DataAttributeBinding, OperationMetadata>(_callUpdateDataAttributeBinding.Sync(request, callSettings), UpdateDataAttributeBindingOperationsClient);
        }

        /// <summary>
        /// Updates a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataAttributeBinding, OperationMetadata>> UpdateDataAttributeBindingAsync(UpdateDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAttributeBindingRequest(ref request, ref callSettings);
            return new lro::Operation<DataAttributeBinding, OperationMetadata>(await _callUpdateDataAttributeBinding.Async(request, callSettings).ConfigureAwait(false), UpdateDataAttributeBindingOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDataAttributeBinding</c>.</summary>
        public override lro::OperationsClient DeleteDataAttributeBindingOperationsClient { get; }

        /// <summary>
        /// Deletes a DataAttributeBinding resource. All attributes within the
        /// DataAttributeBinding must be deleted before the DataAttributeBinding can be
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAttributeBinding(DeleteDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAttributeBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDataAttributeBinding.Sync(request, callSettings), DeleteDataAttributeBindingOperationsClient);
        }

        /// <summary>
        /// Deletes a DataAttributeBinding resource. All attributes within the
        /// DataAttributeBinding must be deleted before the DataAttributeBinding can be
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeBindingAsync(DeleteDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAttributeBindingRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDataAttributeBinding.Async(request, callSettings).ConfigureAwait(false), DeleteDataAttributeBindingOperationsClient);
        }

        /// <summary>
        /// Lists DataAttributeBinding resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAttributeBinding"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataAttributeBindingsResponse, DataAttributeBinding> ListDataAttributeBindings(ListDataAttributeBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAttributeBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataAttributeBindingsRequest, ListDataAttributeBindingsResponse, DataAttributeBinding>(_callListDataAttributeBindings, request, callSettings);
        }

        /// <summary>
        /// Lists DataAttributeBinding resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAttributeBinding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataAttributeBindingsResponse, DataAttributeBinding> ListDataAttributeBindingsAsync(ListDataAttributeBindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAttributeBindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataAttributeBindingsRequest, ListDataAttributeBindingsResponse, DataAttributeBinding>(_callListDataAttributeBindings, request, callSettings);
        }

        /// <summary>
        /// Retrieves a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataAttributeBinding GetDataAttributeBinding(GetDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAttributeBindingRequest(ref request, ref callSettings);
            return _callGetDataAttributeBinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a DataAttributeBinding resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataAttributeBinding> GetDataAttributeBindingAsync(GetDataAttributeBindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAttributeBindingRequest(ref request, ref callSettings);
            return _callGetDataAttributeBinding.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDataAttribute</c>.</summary>
        public override lro::OperationsClient CreateDataAttributeOperationsClient { get; }

        /// <summary>
        /// Create a DataAttribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataAttribute, OperationMetadata> CreateDataAttribute(CreateDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAttributeRequest(ref request, ref callSettings);
            return new lro::Operation<DataAttribute, OperationMetadata>(_callCreateDataAttribute.Sync(request, callSettings), CreateDataAttributeOperationsClient);
        }

        /// <summary>
        /// Create a DataAttribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataAttribute, OperationMetadata>> CreateDataAttributeAsync(CreateDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAttributeRequest(ref request, ref callSettings);
            return new lro::Operation<DataAttribute, OperationMetadata>(await _callCreateDataAttribute.Async(request, callSettings).ConfigureAwait(false), CreateDataAttributeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDataAttribute</c>.</summary>
        public override lro::OperationsClient UpdateDataAttributeOperationsClient { get; }

        /// <summary>
        /// Updates a DataAttribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataAttribute, OperationMetadata> UpdateDataAttribute(UpdateDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAttributeRequest(ref request, ref callSettings);
            return new lro::Operation<DataAttribute, OperationMetadata>(_callUpdateDataAttribute.Sync(request, callSettings), UpdateDataAttributeOperationsClient);
        }

        /// <summary>
        /// Updates a DataAttribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataAttribute, OperationMetadata>> UpdateDataAttributeAsync(UpdateDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAttributeRequest(ref request, ref callSettings);
            return new lro::Operation<DataAttribute, OperationMetadata>(await _callUpdateDataAttribute.Async(request, callSettings).ConfigureAwait(false), UpdateDataAttributeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDataAttribute</c>.</summary>
        public override lro::OperationsClient DeleteDataAttributeOperationsClient { get; }

        /// <summary>
        /// Deletes a Data Attribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAttribute(DeleteDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAttributeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDataAttribute.Sync(request, callSettings), DeleteDataAttributeOperationsClient);
        }

        /// <summary>
        /// Deletes a Data Attribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAttributeAsync(DeleteDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAttributeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDataAttribute.Async(request, callSettings).ConfigureAwait(false), DeleteDataAttributeOperationsClient);
        }

        /// <summary>
        /// Lists Data Attribute resources in a DataTaxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAttribute"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataAttributesResponse, DataAttribute> ListDataAttributes(ListDataAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAttributesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataAttributesRequest, ListDataAttributesResponse, DataAttribute>(_callListDataAttributes, request, callSettings);
        }

        /// <summary>
        /// Lists Data Attribute resources in a DataTaxonomy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAttribute"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataAttributesResponse, DataAttribute> ListDataAttributesAsync(ListDataAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAttributesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataAttributesRequest, ListDataAttributesResponse, DataAttribute>(_callListDataAttributes, request, callSettings);
        }

        /// <summary>
        /// Retrieves a Data Attribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataAttribute GetDataAttribute(GetDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAttributeRequest(ref request, ref callSettings);
            return _callGetDataAttribute.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a Data Attribute resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataAttribute> GetDataAttributeAsync(GetDataAttributeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAttributeRequest(ref request, ref callSettings);
            return _callGetDataAttribute.Async(request, callSettings);
        }
    }

    public partial class ListDataTaxonomiesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataAttributeBindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataAttributesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataTaxonomiesResponse : gaxgrpc::IPageResponse<DataTaxonomy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataTaxonomy> GetEnumerator() => DataTaxonomies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataAttributeBindingsResponse : gaxgrpc::IPageResponse<DataAttributeBinding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataAttributeBinding> GetEnumerator() => DataAttributeBindings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataAttributesResponse : gaxgrpc::IPageResponse<DataAttribute>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataAttribute> GetEnumerator() => DataAttributes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataTaxonomyService
    {
        public partial class DataTaxonomyServiceClient
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

    public static partial class DataTaxonomyService
    {
        public partial class DataTaxonomyServiceClient
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
