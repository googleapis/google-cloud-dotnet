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

namespace Google.Cloud.ArtifactRegistry.V1
{
    /// <summary>Settings for <see cref="ArtifactRegistryClient"/> instances.</summary>
    public sealed partial class ArtifactRegistrySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ArtifactRegistrySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ArtifactRegistrySettings"/>.</returns>
        public static ArtifactRegistrySettings GetDefault() => new ArtifactRegistrySettings();

        /// <summary>Constructs a new <see cref="ArtifactRegistrySettings"/> object with default settings.</summary>
        public ArtifactRegistrySettings()
        {
        }

        private ArtifactRegistrySettings(ArtifactRegistrySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDockerImagesSettings = existing.ListDockerImagesSettings;
            GetDockerImageSettings = existing.GetDockerImageSettings;
            ListMavenArtifactsSettings = existing.ListMavenArtifactsSettings;
            GetMavenArtifactSettings = existing.GetMavenArtifactSettings;
            ListNpmPackagesSettings = existing.ListNpmPackagesSettings;
            GetNpmPackageSettings = existing.GetNpmPackageSettings;
            ListPythonPackagesSettings = existing.ListPythonPackagesSettings;
            GetPythonPackageSettings = existing.GetPythonPackageSettings;
            ImportAptArtifactsSettings = existing.ImportAptArtifactsSettings;
            ImportAptArtifactsOperationsSettings = existing.ImportAptArtifactsOperationsSettings.Clone();
            ImportYumArtifactsSettings = existing.ImportYumArtifactsSettings;
            ImportYumArtifactsOperationsSettings = existing.ImportYumArtifactsOperationsSettings.Clone();
            ListRepositoriesSettings = existing.ListRepositoriesSettings;
            GetRepositorySettings = existing.GetRepositorySettings;
            CreateRepositorySettings = existing.CreateRepositorySettings;
            CreateRepositoryOperationsSettings = existing.CreateRepositoryOperationsSettings.Clone();
            UpdateRepositorySettings = existing.UpdateRepositorySettings;
            DeleteRepositorySettings = existing.DeleteRepositorySettings;
            DeleteRepositoryOperationsSettings = existing.DeleteRepositoryOperationsSettings.Clone();
            ListPackagesSettings = existing.ListPackagesSettings;
            GetPackageSettings = existing.GetPackageSettings;
            DeletePackageSettings = existing.DeletePackageSettings;
            DeletePackageOperationsSettings = existing.DeletePackageOperationsSettings.Clone();
            ListVersionsSettings = existing.ListVersionsSettings;
            GetVersionSettings = existing.GetVersionSettings;
            DeleteVersionSettings = existing.DeleteVersionSettings;
            DeleteVersionOperationsSettings = existing.DeleteVersionOperationsSettings.Clone();
            BatchDeleteVersionsSettings = existing.BatchDeleteVersionsSettings;
            BatchDeleteVersionsOperationsSettings = existing.BatchDeleteVersionsOperationsSettings.Clone();
            UpdateVersionSettings = existing.UpdateVersionSettings;
            ListFilesSettings = existing.ListFilesSettings;
            GetFileSettings = existing.GetFileSettings;
            DeleteFileSettings = existing.DeleteFileSettings;
            DeleteFileOperationsSettings = existing.DeleteFileOperationsSettings.Clone();
            UpdateFileSettings = existing.UpdateFileSettings;
            ListTagsSettings = existing.ListTagsSettings;
            GetTagSettings = existing.GetTagSettings;
            CreateTagSettings = existing.CreateTagSettings;
            UpdateTagSettings = existing.UpdateTagSettings;
            DeleteTagSettings = existing.DeleteTagSettings;
            CreateRuleSettings = existing.CreateRuleSettings;
            ListRulesSettings = existing.ListRulesSettings;
            GetRuleSettings = existing.GetRuleSettings;
            UpdateRuleSettings = existing.UpdateRuleSettings;
            DeleteRuleSettings = existing.DeleteRuleSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            GetProjectSettingsSettings = existing.GetProjectSettingsSettings;
            UpdateProjectSettingsSettings = existing.UpdateProjectSettingsSettings;
            GetVPCSCConfigSettings = existing.GetVPCSCConfigSettings;
            UpdateVPCSCConfigSettings = existing.UpdateVPCSCConfigSettings;
            UpdatePackageSettings = existing.UpdatePackageSettings;
            ListAttachmentsSettings = existing.ListAttachmentsSettings;
            GetAttachmentSettings = existing.GetAttachmentSettings;
            CreateAttachmentSettings = existing.CreateAttachmentSettings;
            CreateAttachmentOperationsSettings = existing.CreateAttachmentOperationsSettings.Clone();
            DeleteAttachmentSettings = existing.DeleteAttachmentSettings;
            DeleteAttachmentOperationsSettings = existing.DeleteAttachmentOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ArtifactRegistrySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListDockerImages</c> and <c>ArtifactRegistryClient.ListDockerImagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDockerImagesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetDockerImage</c> and <c>ArtifactRegistryClient.GetDockerImageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDockerImageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListMavenArtifacts</c> and <c>ArtifactRegistryClient.ListMavenArtifactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMavenArtifactsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetMavenArtifact</c> and <c>ArtifactRegistryClient.GetMavenArtifactAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMavenArtifactSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListNpmPackages</c> and <c>ArtifactRegistryClient.ListNpmPackagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNpmPackagesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetNpmPackage</c> and <c>ArtifactRegistryClient.GetNpmPackageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNpmPackageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListPythonPackages</c> and <c>ArtifactRegistryClient.ListPythonPackagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPythonPackagesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetPythonPackage</c> and <c>ArtifactRegistryClient.GetPythonPackageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPythonPackageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ImportAptArtifacts</c> and <c>ArtifactRegistryClient.ImportAptArtifactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportAptArtifactsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ArtifactRegistryClient.ImportAptArtifacts</c> and
        /// <c>ArtifactRegistryClient.ImportAptArtifactsAsync</c>.
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
        public lro::OperationsSettings ImportAptArtifactsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ImportYumArtifacts</c> and <c>ArtifactRegistryClient.ImportYumArtifactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportYumArtifactsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ArtifactRegistryClient.ImportYumArtifacts</c> and
        /// <c>ArtifactRegistryClient.ImportYumArtifactsAsync</c>.
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
        public lro::OperationsSettings ImportYumArtifactsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListRepositories</c> and <c>ArtifactRegistryClient.ListRepositoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRepositoriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetRepository</c> and <c>ArtifactRegistryClient.GetRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.CreateRepository</c> and <c>ArtifactRegistryClient.CreateRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ArtifactRegistryClient.CreateRepository</c> and
        /// <c>ArtifactRegistryClient.CreateRepositoryAsync</c>.
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
        public lro::OperationsSettings CreateRepositoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.UpdateRepository</c> and <c>ArtifactRegistryClient.UpdateRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.DeleteRepository</c> and <c>ArtifactRegistryClient.DeleteRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ArtifactRegistryClient.DeleteRepository</c> and
        /// <c>ArtifactRegistryClient.DeleteRepositoryAsync</c>.
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
        public lro::OperationsSettings DeleteRepositoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListPackages</c> and <c>ArtifactRegistryClient.ListPackagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPackagesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetPackage</c> and <c>ArtifactRegistryClient.GetPackageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPackageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.DeletePackage</c> and <c>ArtifactRegistryClient.DeletePackageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePackageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ArtifactRegistryClient.DeletePackage</c> and
        /// <c>ArtifactRegistryClient.DeletePackageAsync</c>.
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
        public lro::OperationsSettings DeletePackageOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListVersions</c> and <c>ArtifactRegistryClient.ListVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetVersion</c> and <c>ArtifactRegistryClient.GetVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.DeleteVersion</c> and <c>ArtifactRegistryClient.DeleteVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ArtifactRegistryClient.DeleteVersion</c> and
        /// <c>ArtifactRegistryClient.DeleteVersionAsync</c>.
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
        public lro::OperationsSettings DeleteVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.BatchDeleteVersions</c> and <c>ArtifactRegistryClient.BatchDeleteVersionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ArtifactRegistryClient.BatchDeleteVersions</c> and
        /// <c>ArtifactRegistryClient.BatchDeleteVersionsAsync</c>.
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
        public lro::OperationsSettings BatchDeleteVersionsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.UpdateVersion</c> and <c>ArtifactRegistryClient.UpdateVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListFiles</c> and <c>ArtifactRegistryClient.ListFilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetFile</c> and <c>ArtifactRegistryClient.GetFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.DeleteFile</c> and <c>ArtifactRegistryClient.DeleteFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ArtifactRegistryClient.DeleteFile</c> and
        /// <c>ArtifactRegistryClient.DeleteFileAsync</c>.
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
        public lro::OperationsSettings DeleteFileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.UpdateFile</c> and <c>ArtifactRegistryClient.UpdateFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListTags</c> and <c>ArtifactRegistryClient.ListTagsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTagsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetTag</c> and <c>ArtifactRegistryClient.GetTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTagSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.CreateTag</c> and <c>ArtifactRegistryClient.CreateTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTagSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.UpdateTag</c> and <c>ArtifactRegistryClient.UpdateTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTagSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.DeleteTag</c> and <c>ArtifactRegistryClient.DeleteTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTagSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.CreateRule</c> and <c>ArtifactRegistryClient.CreateRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListRules</c> and <c>ArtifactRegistryClient.ListRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetRule</c> and <c>ArtifactRegistryClient.GetRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.UpdateRule</c> and <c>ArtifactRegistryClient.UpdateRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.DeleteRule</c> and <c>ArtifactRegistryClient.DeleteRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.SetIamPolicy</c> and <c>ArtifactRegistryClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetIamPolicy</c> and <c>ArtifactRegistryClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.TestIamPermissions</c> and <c>ArtifactRegistryClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetProjectSettings</c> and <c>ArtifactRegistryClient.GetProjectSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProjectSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.UpdateProjectSettings</c> and <c>ArtifactRegistryClient.UpdateProjectSettingsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProjectSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetVPCSCConfig</c> and <c>ArtifactRegistryClient.GetVPCSCConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVPCSCConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.UpdateVPCSCConfig</c> and <c>ArtifactRegistryClient.UpdateVPCSCConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVPCSCConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.UpdatePackage</c> and <c>ArtifactRegistryClient.UpdatePackageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePackageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.ListAttachments</c> and <c>ArtifactRegistryClient.ListAttachmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAttachmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.GetAttachment</c> and <c>ArtifactRegistryClient.GetAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.CreateAttachment</c> and <c>ArtifactRegistryClient.CreateAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ArtifactRegistryClient.CreateAttachment</c> and
        /// <c>ArtifactRegistryClient.CreateAttachmentAsync</c>.
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
        public lro::OperationsSettings CreateAttachmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ArtifactRegistryClient.DeleteAttachment</c> and <c>ArtifactRegistryClient.DeleteAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ArtifactRegistryClient.DeleteAttachment</c> and
        /// <c>ArtifactRegistryClient.DeleteAttachmentAsync</c>.
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
        public lro::OperationsSettings DeleteAttachmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ArtifactRegistrySettings"/> object.</returns>
        public ArtifactRegistrySettings Clone() => new ArtifactRegistrySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ArtifactRegistryClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ArtifactRegistryClientBuilder : gaxgrpc::ClientBuilderBase<ArtifactRegistryClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ArtifactRegistrySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ArtifactRegistryClientBuilder() : base(ArtifactRegistryClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ArtifactRegistryClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ArtifactRegistryClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ArtifactRegistryClient Build()
        {
            ArtifactRegistryClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ArtifactRegistryClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ArtifactRegistryClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ArtifactRegistryClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ArtifactRegistryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ArtifactRegistryClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ArtifactRegistryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ArtifactRegistryClient.ChannelPool;
    }

    /// <summary>ArtifactRegistry client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Artifact Registry API service.
    /// 
    /// Artifact Registry is an artifact management system for storing artifacts
    /// from different package management systems.
    /// 
    /// The resources managed by this API are:
    /// 
    /// * Repositories, which group packages and their data.
    /// * Packages, which group versions and their tags.
    /// * Versions, which are specific forms of a package.
    /// * Tags, which represent alternative names for versions.
    /// * Files, which contain content and are optionally associated with a Package
    /// or Version.
    /// </remarks>
    public abstract partial class ArtifactRegistryClient
    {
        /// <summary>
        /// The default endpoint for the ArtifactRegistry service, which is a host of "artifactregistry.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "artifactregistry.googleapis.com:443";

        /// <summary>The default ArtifactRegistry scopes.</summary>
        /// <remarks>
        /// The default ArtifactRegistry scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ArtifactRegistry.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ArtifactRegistryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ArtifactRegistryClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ArtifactRegistryClient"/>.</returns>
        public static stt::Task<ArtifactRegistryClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ArtifactRegistryClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ArtifactRegistryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ArtifactRegistryClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ArtifactRegistryClient"/>.</returns>
        public static ArtifactRegistryClient Create() => new ArtifactRegistryClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ArtifactRegistryClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ArtifactRegistrySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ArtifactRegistryClient"/>.</returns>
        internal static ArtifactRegistryClient Create(grpccore::CallInvoker callInvoker, ArtifactRegistrySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ArtifactRegistry.ArtifactRegistryClient grpcClient = new ArtifactRegistry.ArtifactRegistryClient(callInvoker);
            return new ArtifactRegistryClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ArtifactRegistry client</summary>
        public virtual ArtifactRegistry.ArtifactRegistryClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DockerImage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImages(ListDockerImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DockerImage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImagesAsync(ListDockerImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose docker images will be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="DockerImage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDockerImagesRequest request = new ListDockerImagesRequest
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
            return ListDockerImages(request, callSettings);
        }

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose docker images will be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DockerImage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDockerImagesRequest request = new ListDockerImagesRequest
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
            return ListDockerImagesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a docker image.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DockerImage GetDockerImage(GetDockerImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a docker image.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DockerImage> GetDockerImageAsync(GetDockerImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a docker image.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DockerImage> GetDockerImageAsync(GetDockerImageRequest request, st::CancellationToken cancellationToken) =>
            GetDockerImageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a docker image.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the docker images.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DockerImage GetDockerImage(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDockerImage(new GetDockerImageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a docker image.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the docker images.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DockerImage> GetDockerImageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDockerImageAsync(new GetDockerImageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a docker image.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the docker images.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DockerImage> GetDockerImageAsync(string name, st::CancellationToken cancellationToken) =>
            GetDockerImageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a docker image.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the docker images.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DockerImage GetDockerImage(DockerImageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDockerImage(new GetDockerImageRequest
            {
                DockerImageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a docker image.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the docker images.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DockerImage> GetDockerImageAsync(DockerImageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDockerImageAsync(new GetDockerImageRequest
            {
                DockerImageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a docker image.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the docker images.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DockerImage> GetDockerImageAsync(DockerImageName name, st::CancellationToken cancellationToken) =>
            GetDockerImageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists maven artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MavenArtifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMavenArtifactsResponse, MavenArtifact> ListMavenArtifacts(ListMavenArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists maven artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MavenArtifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMavenArtifactsResponse, MavenArtifact> ListMavenArtifactsAsync(ListMavenArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists maven artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose maven artifacts will be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="MavenArtifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMavenArtifactsResponse, MavenArtifact> ListMavenArtifacts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMavenArtifactsRequest request = new ListMavenArtifactsRequest
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
            return ListMavenArtifacts(request, callSettings);
        }

        /// <summary>
        /// Lists maven artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose maven artifacts will be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MavenArtifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMavenArtifactsResponse, MavenArtifact> ListMavenArtifactsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMavenArtifactsRequest request = new ListMavenArtifactsRequest
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
            return ListMavenArtifactsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists maven artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose maven artifacts will be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="MavenArtifact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMavenArtifactsResponse, MavenArtifact> ListMavenArtifacts(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMavenArtifactsRequest request = new ListMavenArtifactsRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMavenArtifacts(request, callSettings);
        }

        /// <summary>
        /// Lists maven artifacts.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose maven artifacts will be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MavenArtifact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMavenArtifactsResponse, MavenArtifact> ListMavenArtifactsAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMavenArtifactsRequest request = new ListMavenArtifactsRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMavenArtifactsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a maven artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MavenArtifact GetMavenArtifact(GetMavenArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a maven artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MavenArtifact> GetMavenArtifactAsync(GetMavenArtifactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a maven artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MavenArtifact> GetMavenArtifactAsync(GetMavenArtifactRequest request, st::CancellationToken cancellationToken) =>
            GetMavenArtifactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a maven artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the maven artifact.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MavenArtifact GetMavenArtifact(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMavenArtifact(new GetMavenArtifactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a maven artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the maven artifact.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MavenArtifact> GetMavenArtifactAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMavenArtifactAsync(new GetMavenArtifactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a maven artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the maven artifact.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MavenArtifact> GetMavenArtifactAsync(string name, st::CancellationToken cancellationToken) =>
            GetMavenArtifactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a maven artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the maven artifact.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MavenArtifact GetMavenArtifact(MavenArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMavenArtifact(new GetMavenArtifactRequest
            {
                MavenArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a maven artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the maven artifact.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MavenArtifact> GetMavenArtifactAsync(MavenArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMavenArtifactAsync(new GetMavenArtifactRequest
            {
                MavenArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a maven artifact.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the maven artifact.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MavenArtifact> GetMavenArtifactAsync(MavenArtifactName name, st::CancellationToken cancellationToken) =>
            GetMavenArtifactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists npm packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NpmPackage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNpmPackagesResponse, NpmPackage> ListNpmPackages(ListNpmPackagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists npm packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NpmPackage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNpmPackagesResponse, NpmPackage> ListNpmPackagesAsync(ListNpmPackagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists npm packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose npm packages will be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="NpmPackage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNpmPackagesResponse, NpmPackage> ListNpmPackages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNpmPackagesRequest request = new ListNpmPackagesRequest
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
            return ListNpmPackages(request, callSettings);
        }

        /// <summary>
        /// Lists npm packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose npm packages will be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NpmPackage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNpmPackagesResponse, NpmPackage> ListNpmPackagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNpmPackagesRequest request = new ListNpmPackagesRequest
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
            return ListNpmPackagesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists npm packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose npm packages will be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="NpmPackage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNpmPackagesResponse, NpmPackage> ListNpmPackages(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNpmPackagesRequest request = new ListNpmPackagesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNpmPackages(request, callSettings);
        }

        /// <summary>
        /// Lists npm packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose npm packages will be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NpmPackage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNpmPackagesResponse, NpmPackage> ListNpmPackagesAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNpmPackagesRequest request = new ListNpmPackagesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNpmPackagesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a npm package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NpmPackage GetNpmPackage(GetNpmPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a npm package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NpmPackage> GetNpmPackageAsync(GetNpmPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a npm package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NpmPackage> GetNpmPackageAsync(GetNpmPackageRequest request, st::CancellationToken cancellationToken) =>
            GetNpmPackageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a npm package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the npm package.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NpmPackage GetNpmPackage(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNpmPackage(new GetNpmPackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a npm package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the npm package.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NpmPackage> GetNpmPackageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNpmPackageAsync(new GetNpmPackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a npm package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the npm package.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NpmPackage> GetNpmPackageAsync(string name, st::CancellationToken cancellationToken) =>
            GetNpmPackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a npm package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the npm package.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NpmPackage GetNpmPackage(NpmPackageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNpmPackage(new GetNpmPackageRequest
            {
                NpmPackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a npm package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the npm package.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NpmPackage> GetNpmPackageAsync(NpmPackageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNpmPackageAsync(new GetNpmPackageRequest
            {
                NpmPackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a npm package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the npm package.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NpmPackage> GetNpmPackageAsync(NpmPackageName name, st::CancellationToken cancellationToken) =>
            GetNpmPackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists python packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PythonPackage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPythonPackagesResponse, PythonPackage> ListPythonPackages(ListPythonPackagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists python packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PythonPackage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPythonPackagesResponse, PythonPackage> ListPythonPackagesAsync(ListPythonPackagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists python packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose python packages will be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="PythonPackage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPythonPackagesResponse, PythonPackage> ListPythonPackages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPythonPackagesRequest request = new ListPythonPackagesRequest
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
            return ListPythonPackages(request, callSettings);
        }

        /// <summary>
        /// Lists python packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose python packages will be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PythonPackage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPythonPackagesResponse, PythonPackage> ListPythonPackagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPythonPackagesRequest request = new ListPythonPackagesRequest
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
            return ListPythonPackagesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists python packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose python packages will be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="PythonPackage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPythonPackagesResponse, PythonPackage> ListPythonPackages(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPythonPackagesRequest request = new ListPythonPackagesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPythonPackages(request, callSettings);
        }

        /// <summary>
        /// Lists python packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose python packages will be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PythonPackage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPythonPackagesResponse, PythonPackage> ListPythonPackagesAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPythonPackagesRequest request = new ListPythonPackagesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPythonPackagesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a python package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PythonPackage GetPythonPackage(GetPythonPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a python package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PythonPackage> GetPythonPackageAsync(GetPythonPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a python package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PythonPackage> GetPythonPackageAsync(GetPythonPackageRequest request, st::CancellationToken cancellationToken) =>
            GetPythonPackageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a python package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the python package.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PythonPackage GetPythonPackage(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPythonPackage(new GetPythonPackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a python package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the python package.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PythonPackage> GetPythonPackageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPythonPackageAsync(new GetPythonPackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a python package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the python package.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PythonPackage> GetPythonPackageAsync(string name, st::CancellationToken cancellationToken) =>
            GetPythonPackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a python package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the python package.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PythonPackage GetPythonPackage(PythonPackageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPythonPackage(new GetPythonPackageRequest
            {
                PythonPackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a python package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the python package.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PythonPackage> GetPythonPackageAsync(PythonPackageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPythonPackageAsync(new GetPythonPackageRequest
            {
                PythonPackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a python package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the python package.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PythonPackage> GetPythonPackageAsync(PythonPackageName name, st::CancellationToken cancellationToken) =>
            GetPythonPackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports Apt artifacts. The returned Operation will complete once the
        /// resources are imported. Package, Version, and File resources are created
        /// based on the imported artifacts. Imported artifacts that conflict with
        /// existing resources are ignored.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata> ImportAptArtifacts(ImportAptArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports Apt artifacts. The returned Operation will complete once the
        /// resources are imported. Package, Version, and File resources are created
        /// based on the imported artifacts. Imported artifacts that conflict with
        /// existing resources are ignored.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata>> ImportAptArtifactsAsync(ImportAptArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports Apt artifacts. The returned Operation will complete once the
        /// resources are imported. Package, Version, and File resources are created
        /// based on the imported artifacts. Imported artifacts that conflict with
        /// existing resources are ignored.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata>> ImportAptArtifactsAsync(ImportAptArtifactsRequest request, st::CancellationToken cancellationToken) =>
            ImportAptArtifactsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportAptArtifacts</c>.</summary>
        public virtual lro::OperationsClient ImportAptArtifactsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportAptArtifacts</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata> PollOnceImportAptArtifacts(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAptArtifactsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportAptArtifacts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata>> PollOnceImportAptArtifactsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAptArtifactsOperationsClient, callSettings);

        /// <summary>
        /// Imports Yum (RPM) artifacts. The returned Operation will complete once the
        /// resources are imported. Package, Version, and File resources are created
        /// based on the imported artifacts. Imported artifacts that conflict with
        /// existing resources are ignored.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata> ImportYumArtifacts(ImportYumArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports Yum (RPM) artifacts. The returned Operation will complete once the
        /// resources are imported. Package, Version, and File resources are created
        /// based on the imported artifacts. Imported artifacts that conflict with
        /// existing resources are ignored.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata>> ImportYumArtifactsAsync(ImportYumArtifactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports Yum (RPM) artifacts. The returned Operation will complete once the
        /// resources are imported. Package, Version, and File resources are created
        /// based on the imported artifacts. Imported artifacts that conflict with
        /// existing resources are ignored.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata>> ImportYumArtifactsAsync(ImportYumArtifactsRequest request, st::CancellationToken cancellationToken) =>
            ImportYumArtifactsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportYumArtifacts</c>.</summary>
        public virtual lro::OperationsClient ImportYumArtifactsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportYumArtifacts</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata> PollOnceImportYumArtifacts(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportYumArtifactsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportYumArtifacts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata>> PollOnceImportYumArtifactsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportYumArtifactsOperationsClient, callSettings);

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose repositories will be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
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
            return ListRepositories(request, callSettings);
        }

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose repositories will be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
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
            return ListRepositoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose repositories will be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
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
            return ListRepositories(request, callSettings);
        }

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose repositories will be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRepositoriesRequest request = new ListRepositoriesRequest
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
            return ListRepositoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepository(new GetRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepositoryAsync(new GetRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepository(new GetRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepositoryAsync(new GetRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(RepositoryName name, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a repository. The returned Operation will finish once the
        /// repository has been created. Its response will be the created Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> CreateRepository(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a repository. The returned Operation will finish once the
        /// repository has been created. Its response will be the created Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a repository. The returned Operation will finish once the
        /// repository has been created. Its response will be the created Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(CreateRepositoryRequest request, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRepository</c>.</summary>
        public virtual lro::OperationsClient CreateRepositoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> PollOnceCreateRepository(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Repository, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> PollOnceCreateRepositoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Repository, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Creates a repository. The returned Operation will finish once the
        /// repository has been created. Its response will be the created Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the repository will be
        /// created.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to be created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The repository id to use for this repository.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> CreateRepository(string parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepository(new CreateRepositoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Creates a repository. The returned Operation will finish once the
        /// repository has been created. Its response will be the created Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the repository will be
        /// created.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to be created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The repository id to use for this repository.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(string parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepositoryAsync(new CreateRepositoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Creates a repository. The returned Operation will finish once the
        /// repository has been created. Its response will be the created Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the repository will be
        /// created.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to be created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The repository id to use for this repository.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(string parent, Repository repository, string repositoryId, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(parent, repository, repositoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a repository. The returned Operation will finish once the
        /// repository has been created. Its response will be the created Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the repository will be
        /// created.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to be created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The repository id to use for this repository.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Repository, OperationMetadata> CreateRepository(gagr::LocationName parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepository(new CreateRepositoryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Creates a repository. The returned Operation will finish once the
        /// repository has been created. Its response will be the created Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the repository will be
        /// created.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to be created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The repository id to use for this repository.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(gagr::LocationName parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepositoryAsync(new CreateRepositoryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Creates a repository. The returned Operation will finish once the
        /// repository has been created. Its response will be the created Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the repository will be
        /// created.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to be created.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The repository id to use for this repository.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(gagr::LocationName parent, Repository repository, string repositoryId, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(parent, repository, repositoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository UpdateRepository(UpdateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> UpdateRepositoryAsync(UpdateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> UpdateRepositoryAsync(UpdateRepositoryRequest request, st::CancellationToken cancellationToken) =>
            UpdateRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a repository.
        /// </summary>
        /// <param name="repository">
        /// The repository that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository UpdateRepository(Repository repository, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRepository(new UpdateRepositoryRequest
            {
                Repository = repository,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a repository.
        /// </summary>
        /// <param name="repository">
        /// The repository that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> UpdateRepositoryAsync(Repository repository, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRepositoryAsync(new UpdateRepositoryRequest
            {
                Repository = repository,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a repository.
        /// </summary>
        /// <param name="repository">
        /// The repository that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> UpdateRepositoryAsync(Repository repository, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRepositoryAsync(repository, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a repository and all of its contents. The returned Operation will
        /// finish once the repository has been deleted. It will not have any Operation
        /// metadata and will return a google.protobuf.Empty response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a repository and all of its contents. The returned Operation will
        /// finish once the repository has been deleted. It will not have any Operation
        /// metadata and will return a google.protobuf.Empty response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a repository and all of its contents. The returned Operation will
        /// finish once the repository has been deleted. It will not have any Operation
        /// metadata and will return a google.protobuf.Empty response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(DeleteRepositoryRequest request, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRepository</c>.</summary>
        public virtual lro::OperationsClient DeleteRepositoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRepository(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteRepositoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Deletes a repository and all of its contents. The returned Operation will
        /// finish once the repository has been deleted. It will not have any Operation
        /// metadata and will return a google.protobuf.Empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepository(new DeleteRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a repository and all of its contents. The returned Operation will
        /// finish once the repository has been deleted. It will not have any Operation
        /// metadata and will return a google.protobuf.Empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepositoryAsync(new DeleteRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a repository and all of its contents. The returned Operation will
        /// finish once the repository has been deleted. It will not have any Operation
        /// metadata and will return a google.protobuf.Empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a repository and all of its contents. The returned Operation will
        /// finish once the repository has been deleted. It will not have any Operation
        /// metadata and will return a google.protobuf.Empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepository(new DeleteRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a repository and all of its contents. The returned Operation will
        /// finish once the repository has been deleted. It will not have any Operation
        /// metadata and will return a google.protobuf.Empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepositoryAsync(new DeleteRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a repository and all of its contents. The returned Operation will
        /// finish once the repository has been deleted. It will not have any Operation
        /// metadata and will return a google.protobuf.Empty response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the repository to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(RepositoryName name, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Package"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPackagesResponse, Package> ListPackages(ListPackagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Package"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPackagesResponse, Package> ListPackagesAsync(ListPackagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose packages will be listed.
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
        /// <returns>A pageable sequence of <see cref="Package"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPackagesResponse, Package> ListPackages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPackagesRequest request = new ListPackagesRequest
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
            return ListPackages(request, callSettings);
        }

        /// <summary>
        /// Lists packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose packages will be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Package"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPackagesResponse, Package> ListPackagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPackagesRequest request = new ListPackagesRequest
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
            return ListPackagesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose packages will be listed.
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
        /// <returns>A pageable sequence of <see cref="Package"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPackagesResponse, Package> ListPackages(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPackagesRequest request = new ListPackagesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPackages(request, callSettings);
        }

        /// <summary>
        /// Lists packages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose packages will be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Package"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPackagesResponse, Package> ListPackagesAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPackagesRequest request = new ListPackagesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPackagesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Package GetPackage(GetPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Package> GetPackageAsync(GetPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Package> GetPackageAsync(GetPackageRequest request, st::CancellationToken cancellationToken) =>
            GetPackageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Package GetPackage(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPackage(new GetPackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Package> GetPackageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPackageAsync(new GetPackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Package> GetPackageAsync(string name, st::CancellationToken cancellationToken) =>
            GetPackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Package GetPackage(PackageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPackage(new GetPackageRequest
            {
                PackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Package> GetPackageAsync(PackageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPackageAsync(new GetPackageRequest
            {
                PackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a package.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Package> GetPackageAsync(PackageName name, st::CancellationToken cancellationToken) =>
            GetPackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a package and all of its versions and tags. The returned operation
        /// will complete once the package has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePackage(DeletePackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a package and all of its versions and tags. The returned operation
        /// will complete once the package has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePackageAsync(DeletePackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a package and all of its versions and tags. The returned operation
        /// will complete once the package has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePackageAsync(DeletePackageRequest request, st::CancellationToken cancellationToken) =>
            DeletePackageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePackage</c>.</summary>
        public virtual lro::OperationsClient DeletePackageOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeletePackage</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeletePackage(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePackageOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePackage</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeletePackageAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePackageOperationsClient, callSettings);

        /// <summary>
        /// Deletes a package and all of its versions and tags. The returned operation
        /// will complete once the package has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePackage(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePackage(new DeletePackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a package and all of its versions and tags. The returned operation
        /// will complete once the package has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePackageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePackageAsync(new DeletePackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a package and all of its versions and tags. The returned operation
        /// will complete once the package has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePackageAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a package and all of its versions and tags. The returned operation
        /// will complete once the package has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePackage(PackageName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePackage(new DeletePackageRequest
            {
                PackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a package and all of its versions and tags. The returned operation
        /// will complete once the package has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePackageAsync(PackageName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePackageAsync(new DeletePackageRequest
            {
                PackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a package and all of its versions and tags. The returned operation
        /// will complete once the package has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the package to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePackageAsync(PackageName name, st::CancellationToken cancellationToken) =>
            DeletePackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists versions.
        /// </summary>
        /// <param name="parent">
        /// The name of the parent resource whose versions will be listed.
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
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVersionsRequest request = new ListVersionsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVersions(request, callSettings);
        }

        /// <summary>
        /// Lists versions.
        /// </summary>
        /// <param name="parent">
        /// The name of the parent resource whose versions will be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVersionsRequest request = new ListVersionsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a version
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version GetVersion(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a version
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a version
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(GetVersionRequest request, st::CancellationToken cancellationToken) =>
            GetVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a version
        /// </summary>
        /// <param name="name">
        /// The name of the version to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version GetVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVersion(new GetVersionRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets a version
        /// </summary>
        /// <param name="name">
        /// The name of the version to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVersionAsync(new GetVersionRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets a version
        /// </summary>
        /// <param name="name">
        /// The name of the version to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> GetVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a version and all of its content. The returned operation will
        /// complete once the version has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVersion(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a version and all of its content. The returned operation will
        /// complete once the version has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVersionAsync(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a version and all of its content. The returned operation will
        /// complete once the version has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVersionAsync(DeleteVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteVersion</c>.</summary>
        public virtual lro::OperationsClient DeleteVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVersionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a version and all of its content. The returned operation will
        /// complete once the version has been deleted.
        /// </summary>
        /// <param name="name">
        /// The name of the version to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVersion(new DeleteVersionRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Deletes a version and all of its content. The returned operation will
        /// complete once the version has been deleted.
        /// </summary>
        /// <param name="name">
        /// The name of the version to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVersionAsync(new DeleteVersionRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Deletes a version and all of its content. The returned operation will
        /// complete once the version has been deleted.
        /// </summary>
        /// <param name="name">
        /// The name of the version to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes multiple versions across a repository. The returned operation will
        /// complete once the versions have been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata> BatchDeleteVersions(BatchDeleteVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes multiple versions across a repository. The returned operation will
        /// complete once the versions have been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>> BatchDeleteVersionsAsync(BatchDeleteVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes multiple versions across a repository. The returned operation will
        /// complete once the versions have been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>> BatchDeleteVersionsAsync(BatchDeleteVersionsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteVersionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchDeleteVersions</c>.</summary>
        public virtual lro::OperationsClient BatchDeleteVersionsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchDeleteVersions</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata> PollOnceBatchDeleteVersions(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteVersionsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchDeleteVersions</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>> PollOnceBatchDeleteVersionsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteVersionsOperationsClient, callSettings);

        /// <summary>
        /// Deletes multiple versions across a repository. The returned operation will
        /// complete once the versions have been deleted.
        /// </summary>
        /// <param name="parent">
        /// The name of the repository holding all requested versions.
        /// </param>
        /// <param name="names">
        /// Required. The names of the versions to delete.
        /// The maximum number of versions deleted per batch is determined by the
        /// service and is dependent on the available resources in the region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata> BatchDeleteVersions(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteVersions(new BatchDeleteVersionsRequest
            {
                Parent = parent ?? "",
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes multiple versions across a repository. The returned operation will
        /// complete once the versions have been deleted.
        /// </summary>
        /// <param name="parent">
        /// The name of the repository holding all requested versions.
        /// </param>
        /// <param name="names">
        /// Required. The names of the versions to delete.
        /// The maximum number of versions deleted per batch is determined by the
        /// service and is dependent on the available resources in the region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>> BatchDeleteVersionsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteVersionsAsync(new BatchDeleteVersionsRequest
            {
                Parent = parent ?? "",
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes multiple versions across a repository. The returned operation will
        /// complete once the versions have been deleted.
        /// </summary>
        /// <param name="parent">
        /// The name of the repository holding all requested versions.
        /// </param>
        /// <param name="names">
        /// Required. The names of the versions to delete.
        /// The maximum number of versions deleted per batch is determined by the
        /// service and is dependent on the available resources in the region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>> BatchDeleteVersionsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeleteVersionsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes multiple versions across a repository. The returned operation will
        /// complete once the versions have been deleted.
        /// </summary>
        /// <param name="parent">
        /// The name of the repository holding all requested versions.
        /// </param>
        /// <param name="names">
        /// Required. The names of the versions to delete.
        /// The maximum number of versions deleted per batch is determined by the
        /// service and is dependent on the available resources in the region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata> BatchDeleteVersions(PackageName parent, scg::IEnumerable<VersionName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteVersions(new BatchDeleteVersionsRequest
            {
                ParentAsPackageName = parent,
                VersionNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes multiple versions across a repository. The returned operation will
        /// complete once the versions have been deleted.
        /// </summary>
        /// <param name="parent">
        /// The name of the repository holding all requested versions.
        /// </param>
        /// <param name="names">
        /// Required. The names of the versions to delete.
        /// The maximum number of versions deleted per batch is determined by the
        /// service and is dependent on the available resources in the region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>> BatchDeleteVersionsAsync(PackageName parent, scg::IEnumerable<VersionName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteVersionsAsync(new BatchDeleteVersionsRequest
            {
                ParentAsPackageName = parent,
                VersionNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes multiple versions across a repository. The returned operation will
        /// complete once the versions have been deleted.
        /// </summary>
        /// <param name="parent">
        /// The name of the repository holding all requested versions.
        /// </param>
        /// <param name="names">
        /// Required. The names of the versions to delete.
        /// The maximum number of versions deleted per batch is determined by the
        /// service and is dependent on the available resources in the region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>> BatchDeleteVersionsAsync(PackageName parent, scg::IEnumerable<VersionName> names, st::CancellationToken cancellationToken) =>
            BatchDeleteVersionsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version UpdateVersion(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(UpdateVersionRequest request, st::CancellationToken cancellationToken) =>
            UpdateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a version.
        /// </summary>
        /// <param name="version">
        /// Required. The Version that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Version UpdateVersion(Version version, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVersion(new UpdateVersionRequest
            {
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a version.
        /// </summary>
        /// <param name="version">
        /// Required. The Version that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(Version version, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVersionAsync(new UpdateVersionRequest
            {
                Version = gax::GaxPreconditions.CheckNotNull(version, nameof(version)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a version.
        /// </summary>
        /// <param name="version">
        /// Required. The Version that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Version> UpdateVersionAsync(Version version, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVersionAsync(version, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="File"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFilesResponse, File> ListFiles(ListFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="File"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFilesResponse, File> ListFilesAsync(ListFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists files.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the repository whose files will be listed. For
        /// example: "projects/p1/locations/us-central1/repositories/repo1
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
        /// <returns>A pageable sequence of <see cref="File"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFilesResponse, File> ListFiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFilesRequest request = new ListFilesRequest
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
            return ListFiles(request, callSettings);
        }

        /// <summary>
        /// Lists files.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the repository whose files will be listed. For
        /// example: "projects/p1/locations/us-central1/repositories/repo1
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
        /// <returns>A pageable asynchronous sequence of <see cref="File"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFilesResponse, File> ListFilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFilesRequest request = new ListFilesRequest
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
            return ListFilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists files.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the repository whose files will be listed. For
        /// example: "projects/p1/locations/us-central1/repositories/repo1
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
        /// <returns>A pageable sequence of <see cref="File"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFilesResponse, File> ListFiles(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFilesRequest request = new ListFilesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFiles(request, callSettings);
        }

        /// <summary>
        /// Lists files.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the repository whose files will be listed. For
        /// example: "projects/p1/locations/us-central1/repositories/repo1
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
        /// <returns>A pageable asynchronous sequence of <see cref="File"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFilesResponse, File> ListFilesAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFilesRequest request = new ListFilesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFilesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual File GetFile(GetFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<File> GetFileAsync(GetFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<File> GetFileAsync(GetFileRequest request, st::CancellationToken cancellationToken) =>
            GetFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a file.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual File GetFile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFile(new GetFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a file.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<File> GetFileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFileAsync(new GetFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a file.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<File> GetFileAsync(string name, st::CancellationToken cancellationToken) =>
            GetFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a file.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual File GetFile(FileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFile(new GetFileRequest
            {
                FileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a file.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<File> GetFileAsync(FileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFileAsync(new GetFileRequest
            {
                FileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a file.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<File> GetFileAsync(FileName name, st::CancellationToken cancellationToken) =>
            GetFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a file and all of its content. It is only allowed on generic
        /// repositories. The returned operation will complete once the file has been
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFile(DeleteFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a file and all of its content. It is only allowed on generic
        /// repositories. The returned operation will complete once the file has been
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFileAsync(DeleteFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a file and all of its content. It is only allowed on generic
        /// repositories. The returned operation will complete once the file has been
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFileAsync(DeleteFileRequest request, st::CancellationToken cancellationToken) =>
            DeleteFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFile</c>.</summary>
        public virtual lro::OperationsClient DeleteFileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteFile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteFileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFileOperationsClient, callSettings);

        /// <summary>
        /// Deletes a file and all of its content. It is only allowed on generic
        /// repositories. The returned operation will complete once the file has been
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFile(new DeleteFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a file and all of its content. It is only allowed on generic
        /// repositories. The returned operation will complete once the file has been
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFileAsync(new DeleteFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a file and all of its content. It is only allowed on generic
        /// repositories. The returned operation will complete once the file has been
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a file and all of its content. It is only allowed on generic
        /// repositories. The returned operation will complete once the file has been
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFile(FileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFile(new DeleteFileRequest
            {
                FileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a file and all of its content. It is only allowed on generic
        /// repositories. The returned operation will complete once the file has been
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFileAsync(FileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFileAsync(new DeleteFileRequest
            {
                FileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a file and all of its content. It is only allowed on generic
        /// repositories. The returned operation will complete once the file has been
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the file to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFileAsync(FileName name, st::CancellationToken cancellationToken) =>
            DeleteFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual File UpdateFile(UpdateFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<File> UpdateFileAsync(UpdateFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<File> UpdateFileAsync(UpdateFileRequest request, st::CancellationToken cancellationToken) =>
            UpdateFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a file.
        /// </summary>
        /// <param name="file">
        /// Required. The File that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask`
        /// definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual File UpdateFile(File file, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFile(new UpdateFileRequest
            {
                File = gax::GaxPreconditions.CheckNotNull(file, nameof(file)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a file.
        /// </summary>
        /// <param name="file">
        /// Required. The File that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask`
        /// definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<File> UpdateFileAsync(File file, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFileAsync(new UpdateFileRequest
            {
                File = gax::GaxPreconditions.CheckNotNull(file, nameof(file)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a file.
        /// </summary>
        /// <param name="file">
        /// Required. The File that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask`
        /// definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<File> UpdateFileAsync(File file, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFileAsync(file, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists tags.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagsResponse, Tag> ListTags(ListTagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists tags.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagsResponse, Tag> ListTagsAsync(ListTagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists tags.
        /// </summary>
        /// <param name="parent">
        /// The name of the parent package whose tags will be listed.
        /// For example:
        /// `projects/p1/locations/us-central1/repositories/repo1/packages/pkg1`.
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
        /// <returns>A pageable sequence of <see cref="Tag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagsResponse, Tag> ListTags(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagsRequest request = new ListTagsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTags(request, callSettings);
        }

        /// <summary>
        /// Lists tags.
        /// </summary>
        /// <param name="parent">
        /// The name of the parent package whose tags will be listed.
        /// For example:
        /// `projects/p1/locations/us-central1/repositories/repo1/packages/pkg1`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagsResponse, Tag> ListTagsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagsRequest request = new ListTagsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTagsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag GetTag(GetTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> GetTagAsync(GetTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> GetTagAsync(GetTagRequest request, st::CancellationToken cancellationToken) =>
            GetTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a tag.
        /// </summary>
        /// <param name="name">
        /// The name of the tag to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag GetTag(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTag(new GetTagRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets a tag.
        /// </summary>
        /// <param name="name">
        /// The name of the tag to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> GetTagAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagAsync(new GetTagRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets a tag.
        /// </summary>
        /// <param name="name">
        /// The name of the tag to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> GetTagAsync(string name, st::CancellationToken cancellationToken) =>
            GetTagAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag CreateTag(CreateTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> CreateTagAsync(CreateTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> CreateTagAsync(CreateTagRequest request, st::CancellationToken cancellationToken) =>
            CreateTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a tag.
        /// </summary>
        /// <param name="parent">
        /// The name of the parent resource where the tag will be created.
        /// </param>
        /// <param name="tag">
        /// The tag to be created.
        /// </param>
        /// <param name="tagId">
        /// The tag id to use for this repository.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag CreateTag(string parent, Tag tag, string tagId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTag(new CreateTagRequest
            {
                Parent = parent ?? "",
                TagId = tagId ?? "",
                Tag = tag,
            }, callSettings);

        /// <summary>
        /// Creates a tag.
        /// </summary>
        /// <param name="parent">
        /// The name of the parent resource where the tag will be created.
        /// </param>
        /// <param name="tag">
        /// The tag to be created.
        /// </param>
        /// <param name="tagId">
        /// The tag id to use for this repository.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> CreateTagAsync(string parent, Tag tag, string tagId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagAsync(new CreateTagRequest
            {
                Parent = parent ?? "",
                TagId = tagId ?? "",
                Tag = tag,
            }, callSettings);

        /// <summary>
        /// Creates a tag.
        /// </summary>
        /// <param name="parent">
        /// The name of the parent resource where the tag will be created.
        /// </param>
        /// <param name="tag">
        /// The tag to be created.
        /// </param>
        /// <param name="tagId">
        /// The tag id to use for this repository.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> CreateTagAsync(string parent, Tag tag, string tagId, st::CancellationToken cancellationToken) =>
            CreateTagAsync(parent, tag, tagId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag UpdateTag(UpdateTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> UpdateTagAsync(UpdateTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> UpdateTagAsync(UpdateTagRequest request, st::CancellationToken cancellationToken) =>
            UpdateTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a tag.
        /// </summary>
        /// <param name="tag">
        /// The tag that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag UpdateTag(Tag tag, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTag(new UpdateTagRequest
            {
                Tag = tag,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a tag.
        /// </summary>
        /// <param name="tag">
        /// The tag that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> UpdateTagAsync(Tag tag, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagAsync(new UpdateTagRequest
            {
                Tag = tag,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a tag.
        /// </summary>
        /// <param name="tag">
        /// The tag that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> UpdateTagAsync(Tag tag, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTagAsync(tag, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTag(DeleteTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagAsync(DeleteTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagAsync(DeleteTagRequest request, st::CancellationToken cancellationToken) =>
            DeleteTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="name">
        /// The name of the tag to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTag(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTag(new DeleteTagRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="name">
        /// The name of the tag to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagAsync(new DeleteTagRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="name">
        /// The name of the tag to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTagAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule CreateRule(CreateRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(CreateRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(CreateRuleRequest request, st::CancellationToken cancellationToken) =>
            CreateRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the rule will be created.
        /// </param>
        /// <param name="rule">
        /// The rule to be created.
        /// </param>
        /// <param name="ruleId">
        /// The rule id to use for this repository.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule CreateRule(string parent, Rule rule, string ruleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRule(new CreateRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RuleId = ruleId ?? "",
                Rule = rule,
            }, callSettings);

        /// <summary>
        /// Creates a rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the rule will be created.
        /// </param>
        /// <param name="rule">
        /// The rule to be created.
        /// </param>
        /// <param name="ruleId">
        /// The rule id to use for this repository.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(string parent, Rule rule, string ruleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuleAsync(new CreateRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RuleId = ruleId ?? "",
                Rule = rule,
            }, callSettings);

        /// <summary>
        /// Creates a rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the rule will be created.
        /// </param>
        /// <param name="rule">
        /// The rule to be created.
        /// </param>
        /// <param name="ruleId">
        /// The rule id to use for this repository.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(string parent, Rule rule, string ruleId, st::CancellationToken cancellationToken) =>
            CreateRuleAsync(parent, rule, ruleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the rule will be created.
        /// </param>
        /// <param name="rule">
        /// The rule to be created.
        /// </param>
        /// <param name="ruleId">
        /// The rule id to use for this repository.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule CreateRule(RepositoryName parent, Rule rule, string ruleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRule(new CreateRuleRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RuleId = ruleId ?? "",
                Rule = rule,
            }, callSettings);

        /// <summary>
        /// Creates a rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the rule will be created.
        /// </param>
        /// <param name="rule">
        /// The rule to be created.
        /// </param>
        /// <param name="ruleId">
        /// The rule id to use for this repository.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(RepositoryName parent, Rule rule, string ruleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuleAsync(new CreateRuleRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RuleId = ruleId ?? "",
                Rule = rule,
            }, callSettings);

        /// <summary>
        /// Creates a rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the rule will be created.
        /// </param>
        /// <param name="rule">
        /// The rule to be created.
        /// </param>
        /// <param name="ruleId">
        /// The rule id to use for this repository.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(RepositoryName parent, Rule rule, string ruleId, st::CancellationToken cancellationToken) =>
            CreateRuleAsync(parent, rule, ruleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRulesResponse, Rule> ListRules(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRulesResponse, Rule> ListRulesAsync(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent repository whose rules will be listed.
        /// For example:
        /// `projects/p1/locations/us-central1/repositories/repo1`.
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
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRulesResponse, Rule> ListRules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRulesRequest request = new ListRulesRequest
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
            return ListRules(request, callSettings);
        }

        /// <summary>
        /// Lists rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent repository whose rules will be listed.
        /// For example:
        /// `projects/p1/locations/us-central1/repositories/repo1`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRulesResponse, Rule> ListRulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRulesRequest request = new ListRulesRequest
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
            return ListRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent repository whose rules will be listed.
        /// For example:
        /// `projects/p1/locations/us-central1/repositories/repo1`.
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
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRulesResponse, Rule> ListRules(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRulesRequest request = new ListRulesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRules(request, callSettings);
        }

        /// <summary>
        /// Lists rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent repository whose rules will be listed.
        /// For example:
        /// `projects/p1/locations/us-central1/repositories/repo1`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRulesResponse, Rule> ListRulesAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRulesRequest request = new ListRulesRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule GetRule(GetRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(GetRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(GetRuleRequest request, st::CancellationToken cancellationToken) =>
            GetRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule GetRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRule(new GetRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuleAsync(new GetRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(string name, st::CancellationToken cancellationToken) =>
            GetRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule GetRule(RuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRule(new GetRuleRequest
            {
                RuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(RuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuleAsync(new GetRuleRequest
            {
                RuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(RuleName name, st::CancellationToken cancellationToken) =>
            GetRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule UpdateRule(UpdateRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> UpdateRuleAsync(UpdateRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> UpdateRuleAsync(UpdateRuleRequest request, st::CancellationToken cancellationToken) =>
            UpdateRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a rule.
        /// </summary>
        /// <param name="rule">
        /// The rule that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule UpdateRule(Rule rule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRule(new UpdateRuleRequest
            {
                Rule = rule,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a rule.
        /// </summary>
        /// <param name="rule">
        /// The rule that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> UpdateRuleAsync(Rule rule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRuleAsync(new UpdateRuleRequest
            {
                Rule = rule,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a rule.
        /// </summary>
        /// <param name="rule">
        /// The rule that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> UpdateRuleAsync(Rule rule, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRuleAsync(rule, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRule(DeleteRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(DeleteRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(DeleteRuleRequest request, st::CancellationToken cancellationToken) =>
            DeleteRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRule(new DeleteRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuleAsync(new DeleteRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRule(RuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRule(new DeleteRuleRequest
            {
                RuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(RuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuleAsync(new DeleteRuleRequest
            {
                RuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(RuleName name, st::CancellationToken cancellationToken) =>
            DeleteRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the IAM policy for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the IAM policy for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the IAM policy for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests if the caller has a list of permissions on a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests if the caller has a list of permissions on a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests if the caller has a list of permissions on a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the Settings for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectSettings GetProjectSettings(GetProjectSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the Settings for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectSettings> GetProjectSettingsAsync(GetProjectSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the Settings for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectSettings> GetProjectSettingsAsync(GetProjectSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetProjectSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the Settings for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the projectSettings resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectSettings GetProjectSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectSettings(new GetProjectSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the Settings for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the projectSettings resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectSettings> GetProjectSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectSettingsAsync(new GetProjectSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the Settings for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the projectSettings resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectSettings> GetProjectSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetProjectSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the Settings for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the projectSettings resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectSettings GetProjectSettings(ProjectSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectSettings(new GetProjectSettingsRequest
            {
                ProjectSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the Settings for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the projectSettings resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectSettings> GetProjectSettingsAsync(ProjectSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectSettingsAsync(new GetProjectSettingsRequest
            {
                ProjectSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the Settings for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the projectSettings resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectSettings> GetProjectSettingsAsync(ProjectSettingsName name, st::CancellationToken cancellationToken) =>
            GetProjectSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Settings for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectSettings UpdateProjectSettings(UpdateProjectSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Settings for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectSettings> UpdateProjectSettingsAsync(UpdateProjectSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Settings for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectSettings> UpdateProjectSettingsAsync(UpdateProjectSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateProjectSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Settings for the Project.
        /// </summary>
        /// <param name="projectSettings">
        /// The project settings.
        /// </param>
        /// <param name="updateMask">
        /// Field mask to support partial updates.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectSettings UpdateProjectSettings(ProjectSettings projectSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProjectSettings(new UpdateProjectSettingsRequest
            {
                ProjectSettings = projectSettings,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the Settings for the Project.
        /// </summary>
        /// <param name="projectSettings">
        /// The project settings.
        /// </param>
        /// <param name="updateMask">
        /// Field mask to support partial updates.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectSettings> UpdateProjectSettingsAsync(ProjectSettings projectSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProjectSettingsAsync(new UpdateProjectSettingsRequest
            {
                ProjectSettings = projectSettings,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the Settings for the Project.
        /// </summary>
        /// <param name="projectSettings">
        /// The project settings.
        /// </param>
        /// <param name="updateMask">
        /// Field mask to support partial updates.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectSettings> UpdateProjectSettingsAsync(ProjectSettings projectSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProjectSettingsAsync(projectSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the VPCSC Config for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VPCSCConfig GetVPCSCConfig(GetVPCSCConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the VPCSC Config for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VPCSCConfig> GetVPCSCConfigAsync(GetVPCSCConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the VPCSC Config for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VPCSCConfig> GetVPCSCConfigAsync(GetVPCSCConfigRequest request, st::CancellationToken cancellationToken) =>
            GetVPCSCConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the VPCSC Config for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VPCSCConfig resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VPCSCConfig GetVPCSCConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVPCSCConfig(new GetVPCSCConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the VPCSC Config for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VPCSCConfig resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VPCSCConfig> GetVPCSCConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVPCSCConfigAsync(new GetVPCSCConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the VPCSC Config for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VPCSCConfig resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VPCSCConfig> GetVPCSCConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetVPCSCConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the VPCSC Config for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VPCSCConfig resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VPCSCConfig GetVPCSCConfig(VpcscConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVPCSCConfig(new GetVPCSCConfigRequest
            {
                VpcscConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the VPCSC Config for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VPCSCConfig resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VPCSCConfig> GetVPCSCConfigAsync(VpcscConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVPCSCConfigAsync(new GetVPCSCConfigRequest
            {
                VpcscConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the VPCSC Config for the Project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the VPCSCConfig resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VPCSCConfig> GetVPCSCConfigAsync(VpcscConfigName name, st::CancellationToken cancellationToken) =>
            GetVPCSCConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the VPCSC Config for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VPCSCConfig UpdateVPCSCConfig(UpdateVPCSCConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the VPCSC Config for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VPCSCConfig> UpdateVPCSCConfigAsync(UpdateVPCSCConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the VPCSC Config for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VPCSCConfig> UpdateVPCSCConfigAsync(UpdateVPCSCConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateVPCSCConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the VPCSC Config for the Project.
        /// </summary>
        /// <param name="vpcscConfig">
        /// The project config.
        /// </param>
        /// <param name="updateMask">
        /// Field mask to support partial updates.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VPCSCConfig UpdateVPCSCConfig(VPCSCConfig vpcscConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVPCSCConfig(new UpdateVPCSCConfigRequest
            {
                VpcscConfig = vpcscConfig,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the VPCSC Config for the Project.
        /// </summary>
        /// <param name="vpcscConfig">
        /// The project config.
        /// </param>
        /// <param name="updateMask">
        /// Field mask to support partial updates.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VPCSCConfig> UpdateVPCSCConfigAsync(VPCSCConfig vpcscConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVPCSCConfigAsync(new UpdateVPCSCConfigRequest
            {
                VpcscConfig = vpcscConfig,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the VPCSC Config for the Project.
        /// </summary>
        /// <param name="vpcscConfig">
        /// The project config.
        /// </param>
        /// <param name="updateMask">
        /// Field mask to support partial updates.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VPCSCConfig> UpdateVPCSCConfigAsync(VPCSCConfig vpcscConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVPCSCConfigAsync(vpcscConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Package UpdatePackage(UpdatePackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Package> UpdatePackageAsync(UpdatePackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Package> UpdatePackageAsync(UpdatePackageRequest request, st::CancellationToken cancellationToken) =>
            UpdatePackageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a package.
        /// </summary>
        /// <param name="package">
        /// The package that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Package UpdatePackage(Package package, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePackage(new UpdatePackageRequest
            {
                Package = package,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a package.
        /// </summary>
        /// <param name="package">
        /// The package that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Package> UpdatePackageAsync(Package package, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePackageAsync(new UpdatePackageRequest
            {
                Package = package,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a package.
        /// </summary>
        /// <param name="package">
        /// The package that replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Package> UpdatePackageAsync(Package package, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePackageAsync(package, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists attachments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttachmentsResponse, Attachment> ListAttachments(ListAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists attachments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttachmentsResponse, Attachment> ListAttachmentsAsync(ListAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists attachments.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose attachments will be listed.
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
        /// <returns>A pageable sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttachmentsResponse, Attachment> ListAttachments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachmentsRequest request = new ListAttachmentsRequest
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
            return ListAttachments(request, callSettings);
        }

        /// <summary>
        /// Lists attachments.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose attachments will be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttachmentsResponse, Attachment> ListAttachmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachmentsRequest request = new ListAttachmentsRequest
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
            return ListAttachmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists attachments.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose attachments will be listed.
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
        /// <returns>A pageable sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttachmentsResponse, Attachment> ListAttachments(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachmentsRequest request = new ListAttachmentsRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttachments(request, callSettings);
        }

        /// <summary>
        /// Lists attachments.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource whose attachments will be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Attachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttachmentsResponse, Attachment> ListAttachmentsAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttachmentsRequest request = new ListAttachmentsRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttachmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets an attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attachment GetAttachment(GetAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(GetAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(GetAttachmentRequest request, st::CancellationToken cancellationToken) =>
            GetAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attachment GetAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachment(new GetAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachmentAsync(new GetAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attachment GetAttachment(AttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachment(new GetAttachmentRequest
            {
                AttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(AttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachmentAsync(new GetAttachmentRequest
            {
                AttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an attachment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(AttachmentName name, st::CancellationToken cancellationToken) =>
            GetAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an attachment. The returned Operation will finish once the
        /// attachment has been created. Its response will be the created attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Attachment, OperationMetadata> CreateAttachment(CreateAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an attachment. The returned Operation will finish once the
        /// attachment has been created. Its response will be the created attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Attachment, OperationMetadata>> CreateAttachmentAsync(CreateAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an attachment. The returned Operation will finish once the
        /// attachment has been created. Its response will be the created attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Attachment, OperationMetadata>> CreateAttachmentAsync(CreateAttachmentRequest request, st::CancellationToken cancellationToken) =>
            CreateAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAttachment</c>.</summary>
        public virtual lro::OperationsClient CreateAttachmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Attachment, OperationMetadata> PollOnceCreateAttachment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Attachment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Attachment, OperationMetadata>> PollOnceCreateAttachmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Attachment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Creates an attachment. The returned Operation will finish once the
        /// attachment has been created. Its response will be the created attachment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the attachment will be
        /// created.
        /// </param>
        /// <param name="attachment">
        /// Required. The attachment to be created.
        /// </param>
        /// <param name="attachmentId">
        /// Required. The attachment id to use for this attachment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Attachment, OperationMetadata> CreateAttachment(string parent, Attachment attachment, string attachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttachment(new CreateAttachmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachmentId, nameof(attachmentId)),
                Attachment = gax::GaxPreconditions.CheckNotNull(attachment, nameof(attachment)),
            }, callSettings);

        /// <summary>
        /// Creates an attachment. The returned Operation will finish once the
        /// attachment has been created. Its response will be the created attachment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the attachment will be
        /// created.
        /// </param>
        /// <param name="attachment">
        /// Required. The attachment to be created.
        /// </param>
        /// <param name="attachmentId">
        /// Required. The attachment id to use for this attachment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Attachment, OperationMetadata>> CreateAttachmentAsync(string parent, Attachment attachment, string attachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttachmentAsync(new CreateAttachmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachmentId, nameof(attachmentId)),
                Attachment = gax::GaxPreconditions.CheckNotNull(attachment, nameof(attachment)),
            }, callSettings);

        /// <summary>
        /// Creates an attachment. The returned Operation will finish once the
        /// attachment has been created. Its response will be the created attachment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the attachment will be
        /// created.
        /// </param>
        /// <param name="attachment">
        /// Required. The attachment to be created.
        /// </param>
        /// <param name="attachmentId">
        /// Required. The attachment id to use for this attachment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Attachment, OperationMetadata>> CreateAttachmentAsync(string parent, Attachment attachment, string attachmentId, st::CancellationToken cancellationToken) =>
            CreateAttachmentAsync(parent, attachment, attachmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an attachment. The returned Operation will finish once the
        /// attachment has been created. Its response will be the created attachment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the attachment will be
        /// created.
        /// </param>
        /// <param name="attachment">
        /// Required. The attachment to be created.
        /// </param>
        /// <param name="attachmentId">
        /// Required. The attachment id to use for this attachment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Attachment, OperationMetadata> CreateAttachment(RepositoryName parent, Attachment attachment, string attachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttachment(new CreateAttachmentRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachmentId, nameof(attachmentId)),
                Attachment = gax::GaxPreconditions.CheckNotNull(attachment, nameof(attachment)),
            }, callSettings);

        /// <summary>
        /// Creates an attachment. The returned Operation will finish once the
        /// attachment has been created. Its response will be the created attachment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the attachment will be
        /// created.
        /// </param>
        /// <param name="attachment">
        /// Required. The attachment to be created.
        /// </param>
        /// <param name="attachmentId">
        /// Required. The attachment id to use for this attachment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Attachment, OperationMetadata>> CreateAttachmentAsync(RepositoryName parent, Attachment attachment, string attachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAttachmentAsync(new CreateAttachmentRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(attachmentId, nameof(attachmentId)),
                Attachment = gax::GaxPreconditions.CheckNotNull(attachment, nameof(attachment)),
            }, callSettings);

        /// <summary>
        /// Creates an attachment. The returned Operation will finish once the
        /// attachment has been created. Its response will be the created attachment.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource where the attachment will be
        /// created.
        /// </param>
        /// <param name="attachment">
        /// Required. The attachment to be created.
        /// </param>
        /// <param name="attachmentId">
        /// Required. The attachment id to use for this attachment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Attachment, OperationMetadata>> CreateAttachmentAsync(RepositoryName parent, Attachment attachment, string attachmentId, st::CancellationToken cancellationToken) =>
            CreateAttachmentAsync(parent, attachment, attachmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an attachment. The returned Operation will
        /// finish once the attachments has been deleted. It will not have any
        /// Operation metadata and will return a `google.protobuf.Empty` response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAttachment(DeleteAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an attachment. The returned Operation will
        /// finish once the attachments has been deleted. It will not have any
        /// Operation metadata and will return a `google.protobuf.Empty` response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachmentAsync(DeleteAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an attachment. The returned Operation will
        /// finish once the attachments has been deleted. It will not have any
        /// Operation metadata and will return a `google.protobuf.Empty` response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachmentAsync(DeleteAttachmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAttachment</c>.</summary>
        public virtual lro::OperationsClient DeleteAttachmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAttachment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAttachmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Deletes an attachment. The returned Operation will
        /// finish once the attachments has been deleted. It will not have any
        /// Operation metadata and will return a `google.protobuf.Empty` response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttachment(new DeleteAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an attachment. The returned Operation will
        /// finish once the attachments has been deleted. It will not have any
        /// Operation metadata and will return a `google.protobuf.Empty` response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttachmentAsync(new DeleteAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an attachment. The returned Operation will
        /// finish once the attachments has been deleted. It will not have any
        /// Operation metadata and will return a `google.protobuf.Empty` response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an attachment. The returned Operation will
        /// finish once the attachments has been deleted. It will not have any
        /// Operation metadata and will return a `google.protobuf.Empty` response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAttachment(AttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttachment(new DeleteAttachmentRequest
            {
                AttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an attachment. The returned Operation will
        /// finish once the attachments has been deleted. It will not have any
        /// Operation metadata and will return a `google.protobuf.Empty` response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachmentAsync(AttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAttachmentAsync(new DeleteAttachmentRequest
            {
                AttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an attachment. The returned Operation will
        /// finish once the attachments has been deleted. It will not have any
        /// Operation metadata and will return a `google.protobuf.Empty` response.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the attachment to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachmentAsync(AttachmentName name, st::CancellationToken cancellationToken) =>
            DeleteAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ArtifactRegistry client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Artifact Registry API service.
    /// 
    /// Artifact Registry is an artifact management system for storing artifacts
    /// from different package management systems.
    /// 
    /// The resources managed by this API are:
    /// 
    /// * Repositories, which group packages and their data.
    /// * Packages, which group versions and their tags.
    /// * Versions, which are specific forms of a package.
    /// * Tags, which represent alternative names for versions.
    /// * Files, which contain content and are optionally associated with a Package
    /// or Version.
    /// </remarks>
    public sealed partial class ArtifactRegistryClientImpl : ArtifactRegistryClient
    {
        private readonly gaxgrpc::ApiCall<ListDockerImagesRequest, ListDockerImagesResponse> _callListDockerImages;

        private readonly gaxgrpc::ApiCall<GetDockerImageRequest, DockerImage> _callGetDockerImage;

        private readonly gaxgrpc::ApiCall<ListMavenArtifactsRequest, ListMavenArtifactsResponse> _callListMavenArtifacts;

        private readonly gaxgrpc::ApiCall<GetMavenArtifactRequest, MavenArtifact> _callGetMavenArtifact;

        private readonly gaxgrpc::ApiCall<ListNpmPackagesRequest, ListNpmPackagesResponse> _callListNpmPackages;

        private readonly gaxgrpc::ApiCall<GetNpmPackageRequest, NpmPackage> _callGetNpmPackage;

        private readonly gaxgrpc::ApiCall<ListPythonPackagesRequest, ListPythonPackagesResponse> _callListPythonPackages;

        private readonly gaxgrpc::ApiCall<GetPythonPackageRequest, PythonPackage> _callGetPythonPackage;

        private readonly gaxgrpc::ApiCall<ImportAptArtifactsRequest, lro::Operation> _callImportAptArtifacts;

        private readonly gaxgrpc::ApiCall<ImportYumArtifactsRequest, lro::Operation> _callImportYumArtifacts;

        private readonly gaxgrpc::ApiCall<ListRepositoriesRequest, ListRepositoriesResponse> _callListRepositories;

        private readonly gaxgrpc::ApiCall<GetRepositoryRequest, Repository> _callGetRepository;

        private readonly gaxgrpc::ApiCall<CreateRepositoryRequest, lro::Operation> _callCreateRepository;

        private readonly gaxgrpc::ApiCall<UpdateRepositoryRequest, Repository> _callUpdateRepository;

        private readonly gaxgrpc::ApiCall<DeleteRepositoryRequest, lro::Operation> _callDeleteRepository;

        private readonly gaxgrpc::ApiCall<ListPackagesRequest, ListPackagesResponse> _callListPackages;

        private readonly gaxgrpc::ApiCall<GetPackageRequest, Package> _callGetPackage;

        private readonly gaxgrpc::ApiCall<DeletePackageRequest, lro::Operation> _callDeletePackage;

        private readonly gaxgrpc::ApiCall<ListVersionsRequest, ListVersionsResponse> _callListVersions;

        private readonly gaxgrpc::ApiCall<GetVersionRequest, Version> _callGetVersion;

        private readonly gaxgrpc::ApiCall<DeleteVersionRequest, lro::Operation> _callDeleteVersion;

        private readonly gaxgrpc::ApiCall<BatchDeleteVersionsRequest, lro::Operation> _callBatchDeleteVersions;

        private readonly gaxgrpc::ApiCall<UpdateVersionRequest, Version> _callUpdateVersion;

        private readonly gaxgrpc::ApiCall<ListFilesRequest, ListFilesResponse> _callListFiles;

        private readonly gaxgrpc::ApiCall<GetFileRequest, File> _callGetFile;

        private readonly gaxgrpc::ApiCall<DeleteFileRequest, lro::Operation> _callDeleteFile;

        private readonly gaxgrpc::ApiCall<UpdateFileRequest, File> _callUpdateFile;

        private readonly gaxgrpc::ApiCall<ListTagsRequest, ListTagsResponse> _callListTags;

        private readonly gaxgrpc::ApiCall<GetTagRequest, Tag> _callGetTag;

        private readonly gaxgrpc::ApiCall<CreateTagRequest, Tag> _callCreateTag;

        private readonly gaxgrpc::ApiCall<UpdateTagRequest, Tag> _callUpdateTag;

        private readonly gaxgrpc::ApiCall<DeleteTagRequest, wkt::Empty> _callDeleteTag;

        private readonly gaxgrpc::ApiCall<CreateRuleRequest, Rule> _callCreateRule;

        private readonly gaxgrpc::ApiCall<ListRulesRequest, ListRulesResponse> _callListRules;

        private readonly gaxgrpc::ApiCall<GetRuleRequest, Rule> _callGetRule;

        private readonly gaxgrpc::ApiCall<UpdateRuleRequest, Rule> _callUpdateRule;

        private readonly gaxgrpc::ApiCall<DeleteRuleRequest, wkt::Empty> _callDeleteRule;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<GetProjectSettingsRequest, ProjectSettings> _callGetProjectSettings;

        private readonly gaxgrpc::ApiCall<UpdateProjectSettingsRequest, ProjectSettings> _callUpdateProjectSettings;

        private readonly gaxgrpc::ApiCall<GetVPCSCConfigRequest, VPCSCConfig> _callGetVPCSCConfig;

        private readonly gaxgrpc::ApiCall<UpdateVPCSCConfigRequest, VPCSCConfig> _callUpdateVPCSCConfig;

        private readonly gaxgrpc::ApiCall<UpdatePackageRequest, Package> _callUpdatePackage;

        private readonly gaxgrpc::ApiCall<ListAttachmentsRequest, ListAttachmentsResponse> _callListAttachments;

        private readonly gaxgrpc::ApiCall<GetAttachmentRequest, Attachment> _callGetAttachment;

        private readonly gaxgrpc::ApiCall<CreateAttachmentRequest, lro::Operation> _callCreateAttachment;

        private readonly gaxgrpc::ApiCall<DeleteAttachmentRequest, lro::Operation> _callDeleteAttachment;

        /// <summary>
        /// Constructs a client wrapper for the ArtifactRegistry service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ArtifactRegistrySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ArtifactRegistryClientImpl(ArtifactRegistry.ArtifactRegistryClient grpcClient, ArtifactRegistrySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ArtifactRegistrySettings effectiveSettings = settings ?? ArtifactRegistrySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ImportAptArtifactsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportAptArtifactsOperationsSettings, logger);
            ImportYumArtifactsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportYumArtifactsOperationsSettings, logger);
            CreateRepositoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRepositoryOperationsSettings, logger);
            DeleteRepositoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRepositoryOperationsSettings, logger);
            DeletePackageOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePackageOperationsSettings, logger);
            DeleteVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteVersionOperationsSettings, logger);
            BatchDeleteVersionsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchDeleteVersionsOperationsSettings, logger);
            DeleteFileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFileOperationsSettings, logger);
            CreateAttachmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAttachmentOperationsSettings, logger);
            DeleteAttachmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAttachmentOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListDockerImages = clientHelper.BuildApiCall<ListDockerImagesRequest, ListDockerImagesResponse>("ListDockerImages", grpcClient.ListDockerImagesAsync, grpcClient.ListDockerImages, effectiveSettings.ListDockerImagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDockerImages);
            Modify_ListDockerImagesApiCall(ref _callListDockerImages);
            _callGetDockerImage = clientHelper.BuildApiCall<GetDockerImageRequest, DockerImage>("GetDockerImage", grpcClient.GetDockerImageAsync, grpcClient.GetDockerImage, effectiveSettings.GetDockerImageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDockerImage);
            Modify_GetDockerImageApiCall(ref _callGetDockerImage);
            _callListMavenArtifacts = clientHelper.BuildApiCall<ListMavenArtifactsRequest, ListMavenArtifactsResponse>("ListMavenArtifacts", grpcClient.ListMavenArtifactsAsync, grpcClient.ListMavenArtifacts, effectiveSettings.ListMavenArtifactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMavenArtifacts);
            Modify_ListMavenArtifactsApiCall(ref _callListMavenArtifacts);
            _callGetMavenArtifact = clientHelper.BuildApiCall<GetMavenArtifactRequest, MavenArtifact>("GetMavenArtifact", grpcClient.GetMavenArtifactAsync, grpcClient.GetMavenArtifact, effectiveSettings.GetMavenArtifactSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMavenArtifact);
            Modify_GetMavenArtifactApiCall(ref _callGetMavenArtifact);
            _callListNpmPackages = clientHelper.BuildApiCall<ListNpmPackagesRequest, ListNpmPackagesResponse>("ListNpmPackages", grpcClient.ListNpmPackagesAsync, grpcClient.ListNpmPackages, effectiveSettings.ListNpmPackagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNpmPackages);
            Modify_ListNpmPackagesApiCall(ref _callListNpmPackages);
            _callGetNpmPackage = clientHelper.BuildApiCall<GetNpmPackageRequest, NpmPackage>("GetNpmPackage", grpcClient.GetNpmPackageAsync, grpcClient.GetNpmPackage, effectiveSettings.GetNpmPackageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNpmPackage);
            Modify_GetNpmPackageApiCall(ref _callGetNpmPackage);
            _callListPythonPackages = clientHelper.BuildApiCall<ListPythonPackagesRequest, ListPythonPackagesResponse>("ListPythonPackages", grpcClient.ListPythonPackagesAsync, grpcClient.ListPythonPackages, effectiveSettings.ListPythonPackagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPythonPackages);
            Modify_ListPythonPackagesApiCall(ref _callListPythonPackages);
            _callGetPythonPackage = clientHelper.BuildApiCall<GetPythonPackageRequest, PythonPackage>("GetPythonPackage", grpcClient.GetPythonPackageAsync, grpcClient.GetPythonPackage, effectiveSettings.GetPythonPackageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPythonPackage);
            Modify_GetPythonPackageApiCall(ref _callGetPythonPackage);
            _callImportAptArtifacts = clientHelper.BuildApiCall<ImportAptArtifactsRequest, lro::Operation>("ImportAptArtifacts", grpcClient.ImportAptArtifactsAsync, grpcClient.ImportAptArtifacts, effectiveSettings.ImportAptArtifactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportAptArtifacts);
            Modify_ImportAptArtifactsApiCall(ref _callImportAptArtifacts);
            _callImportYumArtifacts = clientHelper.BuildApiCall<ImportYumArtifactsRequest, lro::Operation>("ImportYumArtifacts", grpcClient.ImportYumArtifactsAsync, grpcClient.ImportYumArtifacts, effectiveSettings.ImportYumArtifactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportYumArtifacts);
            Modify_ImportYumArtifactsApiCall(ref _callImportYumArtifacts);
            _callListRepositories = clientHelper.BuildApiCall<ListRepositoriesRequest, ListRepositoriesResponse>("ListRepositories", grpcClient.ListRepositoriesAsync, grpcClient.ListRepositories, effectiveSettings.ListRepositoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRepositories);
            Modify_ListRepositoriesApiCall(ref _callListRepositories);
            _callGetRepository = clientHelper.BuildApiCall<GetRepositoryRequest, Repository>("GetRepository", grpcClient.GetRepositoryAsync, grpcClient.GetRepository, effectiveSettings.GetRepositorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRepository);
            Modify_GetRepositoryApiCall(ref _callGetRepository);
            _callCreateRepository = clientHelper.BuildApiCall<CreateRepositoryRequest, lro::Operation>("CreateRepository", grpcClient.CreateRepositoryAsync, grpcClient.CreateRepository, effectiveSettings.CreateRepositorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRepository);
            Modify_CreateRepositoryApiCall(ref _callCreateRepository);
            _callUpdateRepository = clientHelper.BuildApiCall<UpdateRepositoryRequest, Repository>("UpdateRepository", grpcClient.UpdateRepositoryAsync, grpcClient.UpdateRepository, effectiveSettings.UpdateRepositorySettings).WithGoogleRequestParam("repository.name", request => request.Repository?.Name);
            Modify_ApiCall(ref _callUpdateRepository);
            Modify_UpdateRepositoryApiCall(ref _callUpdateRepository);
            _callDeleteRepository = clientHelper.BuildApiCall<DeleteRepositoryRequest, lro::Operation>("DeleteRepository", grpcClient.DeleteRepositoryAsync, grpcClient.DeleteRepository, effectiveSettings.DeleteRepositorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRepository);
            Modify_DeleteRepositoryApiCall(ref _callDeleteRepository);
            _callListPackages = clientHelper.BuildApiCall<ListPackagesRequest, ListPackagesResponse>("ListPackages", grpcClient.ListPackagesAsync, grpcClient.ListPackages, effectiveSettings.ListPackagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPackages);
            Modify_ListPackagesApiCall(ref _callListPackages);
            _callGetPackage = clientHelper.BuildApiCall<GetPackageRequest, Package>("GetPackage", grpcClient.GetPackageAsync, grpcClient.GetPackage, effectiveSettings.GetPackageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPackage);
            Modify_GetPackageApiCall(ref _callGetPackage);
            _callDeletePackage = clientHelper.BuildApiCall<DeletePackageRequest, lro::Operation>("DeletePackage", grpcClient.DeletePackageAsync, grpcClient.DeletePackage, effectiveSettings.DeletePackageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePackage);
            Modify_DeletePackageApiCall(ref _callDeletePackage);
            _callListVersions = clientHelper.BuildApiCall<ListVersionsRequest, ListVersionsResponse>("ListVersions", grpcClient.ListVersionsAsync, grpcClient.ListVersions, effectiveSettings.ListVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVersions);
            Modify_ListVersionsApiCall(ref _callListVersions);
            _callGetVersion = clientHelper.BuildApiCall<GetVersionRequest, Version>("GetVersion", grpcClient.GetVersionAsync, grpcClient.GetVersion, effectiveSettings.GetVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVersion);
            Modify_GetVersionApiCall(ref _callGetVersion);
            _callDeleteVersion = clientHelper.BuildApiCall<DeleteVersionRequest, lro::Operation>("DeleteVersion", grpcClient.DeleteVersionAsync, grpcClient.DeleteVersion, effectiveSettings.DeleteVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteVersion);
            Modify_DeleteVersionApiCall(ref _callDeleteVersion);
            _callBatchDeleteVersions = clientHelper.BuildApiCall<BatchDeleteVersionsRequest, lro::Operation>("BatchDeleteVersions", grpcClient.BatchDeleteVersionsAsync, grpcClient.BatchDeleteVersions, effectiveSettings.BatchDeleteVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteVersions);
            Modify_BatchDeleteVersionsApiCall(ref _callBatchDeleteVersions);
            _callUpdateVersion = clientHelper.BuildApiCall<UpdateVersionRequest, Version>("UpdateVersion", grpcClient.UpdateVersionAsync, grpcClient.UpdateVersion, effectiveSettings.UpdateVersionSettings).WithGoogleRequestParam("version.name", request => request.Version?.Name);
            Modify_ApiCall(ref _callUpdateVersion);
            Modify_UpdateVersionApiCall(ref _callUpdateVersion);
            _callListFiles = clientHelper.BuildApiCall<ListFilesRequest, ListFilesResponse>("ListFiles", grpcClient.ListFilesAsync, grpcClient.ListFiles, effectiveSettings.ListFilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFiles);
            Modify_ListFilesApiCall(ref _callListFiles);
            _callGetFile = clientHelper.BuildApiCall<GetFileRequest, File>("GetFile", grpcClient.GetFileAsync, grpcClient.GetFile, effectiveSettings.GetFileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFile);
            Modify_GetFileApiCall(ref _callGetFile);
            _callDeleteFile = clientHelper.BuildApiCall<DeleteFileRequest, lro::Operation>("DeleteFile", grpcClient.DeleteFileAsync, grpcClient.DeleteFile, effectiveSettings.DeleteFileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFile);
            Modify_DeleteFileApiCall(ref _callDeleteFile);
            _callUpdateFile = clientHelper.BuildApiCall<UpdateFileRequest, File>("UpdateFile", grpcClient.UpdateFileAsync, grpcClient.UpdateFile, effectiveSettings.UpdateFileSettings).WithGoogleRequestParam("file.name", request => request.File?.Name);
            Modify_ApiCall(ref _callUpdateFile);
            Modify_UpdateFileApiCall(ref _callUpdateFile);
            _callListTags = clientHelper.BuildApiCall<ListTagsRequest, ListTagsResponse>("ListTags", grpcClient.ListTagsAsync, grpcClient.ListTags, effectiveSettings.ListTagsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTags);
            Modify_ListTagsApiCall(ref _callListTags);
            _callGetTag = clientHelper.BuildApiCall<GetTagRequest, Tag>("GetTag", grpcClient.GetTagAsync, grpcClient.GetTag, effectiveSettings.GetTagSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTag);
            Modify_GetTagApiCall(ref _callGetTag);
            _callCreateTag = clientHelper.BuildApiCall<CreateTagRequest, Tag>("CreateTag", grpcClient.CreateTagAsync, grpcClient.CreateTag, effectiveSettings.CreateTagSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTag);
            Modify_CreateTagApiCall(ref _callCreateTag);
            _callUpdateTag = clientHelper.BuildApiCall<UpdateTagRequest, Tag>("UpdateTag", grpcClient.UpdateTagAsync, grpcClient.UpdateTag, effectiveSettings.UpdateTagSettings).WithGoogleRequestParam("tag.name", request => request.Tag?.Name);
            Modify_ApiCall(ref _callUpdateTag);
            Modify_UpdateTagApiCall(ref _callUpdateTag);
            _callDeleteTag = clientHelper.BuildApiCall<DeleteTagRequest, wkt::Empty>("DeleteTag", grpcClient.DeleteTagAsync, grpcClient.DeleteTag, effectiveSettings.DeleteTagSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTag);
            Modify_DeleteTagApiCall(ref _callDeleteTag);
            _callCreateRule = clientHelper.BuildApiCall<CreateRuleRequest, Rule>("CreateRule", grpcClient.CreateRuleAsync, grpcClient.CreateRule, effectiveSettings.CreateRuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRule);
            Modify_CreateRuleApiCall(ref _callCreateRule);
            _callListRules = clientHelper.BuildApiCall<ListRulesRequest, ListRulesResponse>("ListRules", grpcClient.ListRulesAsync, grpcClient.ListRules, effectiveSettings.ListRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRules);
            Modify_ListRulesApiCall(ref _callListRules);
            _callGetRule = clientHelper.BuildApiCall<GetRuleRequest, Rule>("GetRule", grpcClient.GetRuleAsync, grpcClient.GetRule, effectiveSettings.GetRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRule);
            Modify_GetRuleApiCall(ref _callGetRule);
            _callUpdateRule = clientHelper.BuildApiCall<UpdateRuleRequest, Rule>("UpdateRule", grpcClient.UpdateRuleAsync, grpcClient.UpdateRule, effectiveSettings.UpdateRuleSettings).WithGoogleRequestParam("rule.name", request => request.Rule?.Name);
            Modify_ApiCall(ref _callUpdateRule);
            Modify_UpdateRuleApiCall(ref _callUpdateRule);
            _callDeleteRule = clientHelper.BuildApiCall<DeleteRuleRequest, wkt::Empty>("DeleteRule", grpcClient.DeleteRuleAsync, grpcClient.DeleteRule, effectiveSettings.DeleteRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRule);
            Modify_DeleteRuleApiCall(ref _callDeleteRule);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callGetProjectSettings = clientHelper.BuildApiCall<GetProjectSettingsRequest, ProjectSettings>("GetProjectSettings", grpcClient.GetProjectSettingsAsync, grpcClient.GetProjectSettings, effectiveSettings.GetProjectSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProjectSettings);
            Modify_GetProjectSettingsApiCall(ref _callGetProjectSettings);
            _callUpdateProjectSettings = clientHelper.BuildApiCall<UpdateProjectSettingsRequest, ProjectSettings>("UpdateProjectSettings", grpcClient.UpdateProjectSettingsAsync, grpcClient.UpdateProjectSettings, effectiveSettings.UpdateProjectSettingsSettings).WithGoogleRequestParam("project_settings.name", request => request.ProjectSettings?.Name);
            Modify_ApiCall(ref _callUpdateProjectSettings);
            Modify_UpdateProjectSettingsApiCall(ref _callUpdateProjectSettings);
            _callGetVPCSCConfig = clientHelper.BuildApiCall<GetVPCSCConfigRequest, VPCSCConfig>("GetVPCSCConfig", grpcClient.GetVPCSCConfigAsync, grpcClient.GetVPCSCConfig, effectiveSettings.GetVPCSCConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVPCSCConfig);
            Modify_GetVPCSCConfigApiCall(ref _callGetVPCSCConfig);
            _callUpdateVPCSCConfig = clientHelper.BuildApiCall<UpdateVPCSCConfigRequest, VPCSCConfig>("UpdateVPCSCConfig", grpcClient.UpdateVPCSCConfigAsync, grpcClient.UpdateVPCSCConfig, effectiveSettings.UpdateVPCSCConfigSettings).WithGoogleRequestParam("vpcsc_config.name", request => request.VpcscConfig?.Name);
            Modify_ApiCall(ref _callUpdateVPCSCConfig);
            Modify_UpdateVPCSCConfigApiCall(ref _callUpdateVPCSCConfig);
            _callUpdatePackage = clientHelper.BuildApiCall<UpdatePackageRequest, Package>("UpdatePackage", grpcClient.UpdatePackageAsync, grpcClient.UpdatePackage, effectiveSettings.UpdatePackageSettings).WithGoogleRequestParam("package.name", request => request.Package?.Name);
            Modify_ApiCall(ref _callUpdatePackage);
            Modify_UpdatePackageApiCall(ref _callUpdatePackage);
            _callListAttachments = clientHelper.BuildApiCall<ListAttachmentsRequest, ListAttachmentsResponse>("ListAttachments", grpcClient.ListAttachmentsAsync, grpcClient.ListAttachments, effectiveSettings.ListAttachmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAttachments);
            Modify_ListAttachmentsApiCall(ref _callListAttachments);
            _callGetAttachment = clientHelper.BuildApiCall<GetAttachmentRequest, Attachment>("GetAttachment", grpcClient.GetAttachmentAsync, grpcClient.GetAttachment, effectiveSettings.GetAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAttachment);
            Modify_GetAttachmentApiCall(ref _callGetAttachment);
            _callCreateAttachment = clientHelper.BuildApiCall<CreateAttachmentRequest, lro::Operation>("CreateAttachment", grpcClient.CreateAttachmentAsync, grpcClient.CreateAttachment, effectiveSettings.CreateAttachmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAttachment);
            Modify_CreateAttachmentApiCall(ref _callCreateAttachment);
            _callDeleteAttachment = clientHelper.BuildApiCall<DeleteAttachmentRequest, lro::Operation>("DeleteAttachment", grpcClient.DeleteAttachmentAsync, grpcClient.DeleteAttachment, effectiveSettings.DeleteAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAttachment);
            Modify_DeleteAttachmentApiCall(ref _callDeleteAttachment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDockerImagesApiCall(ref gaxgrpc::ApiCall<ListDockerImagesRequest, ListDockerImagesResponse> call);

        partial void Modify_GetDockerImageApiCall(ref gaxgrpc::ApiCall<GetDockerImageRequest, DockerImage> call);

        partial void Modify_ListMavenArtifactsApiCall(ref gaxgrpc::ApiCall<ListMavenArtifactsRequest, ListMavenArtifactsResponse> call);

        partial void Modify_GetMavenArtifactApiCall(ref gaxgrpc::ApiCall<GetMavenArtifactRequest, MavenArtifact> call);

        partial void Modify_ListNpmPackagesApiCall(ref gaxgrpc::ApiCall<ListNpmPackagesRequest, ListNpmPackagesResponse> call);

        partial void Modify_GetNpmPackageApiCall(ref gaxgrpc::ApiCall<GetNpmPackageRequest, NpmPackage> call);

        partial void Modify_ListPythonPackagesApiCall(ref gaxgrpc::ApiCall<ListPythonPackagesRequest, ListPythonPackagesResponse> call);

        partial void Modify_GetPythonPackageApiCall(ref gaxgrpc::ApiCall<GetPythonPackageRequest, PythonPackage> call);

        partial void Modify_ImportAptArtifactsApiCall(ref gaxgrpc::ApiCall<ImportAptArtifactsRequest, lro::Operation> call);

        partial void Modify_ImportYumArtifactsApiCall(ref gaxgrpc::ApiCall<ImportYumArtifactsRequest, lro::Operation> call);

        partial void Modify_ListRepositoriesApiCall(ref gaxgrpc::ApiCall<ListRepositoriesRequest, ListRepositoriesResponse> call);

        partial void Modify_GetRepositoryApiCall(ref gaxgrpc::ApiCall<GetRepositoryRequest, Repository> call);

        partial void Modify_CreateRepositoryApiCall(ref gaxgrpc::ApiCall<CreateRepositoryRequest, lro::Operation> call);

        partial void Modify_UpdateRepositoryApiCall(ref gaxgrpc::ApiCall<UpdateRepositoryRequest, Repository> call);

        partial void Modify_DeleteRepositoryApiCall(ref gaxgrpc::ApiCall<DeleteRepositoryRequest, lro::Operation> call);

        partial void Modify_ListPackagesApiCall(ref gaxgrpc::ApiCall<ListPackagesRequest, ListPackagesResponse> call);

        partial void Modify_GetPackageApiCall(ref gaxgrpc::ApiCall<GetPackageRequest, Package> call);

        partial void Modify_DeletePackageApiCall(ref gaxgrpc::ApiCall<DeletePackageRequest, lro::Operation> call);

        partial void Modify_ListVersionsApiCall(ref gaxgrpc::ApiCall<ListVersionsRequest, ListVersionsResponse> call);

        partial void Modify_GetVersionApiCall(ref gaxgrpc::ApiCall<GetVersionRequest, Version> call);

        partial void Modify_DeleteVersionApiCall(ref gaxgrpc::ApiCall<DeleteVersionRequest, lro::Operation> call);

        partial void Modify_BatchDeleteVersionsApiCall(ref gaxgrpc::ApiCall<BatchDeleteVersionsRequest, lro::Operation> call);

        partial void Modify_UpdateVersionApiCall(ref gaxgrpc::ApiCall<UpdateVersionRequest, Version> call);

        partial void Modify_ListFilesApiCall(ref gaxgrpc::ApiCall<ListFilesRequest, ListFilesResponse> call);

        partial void Modify_GetFileApiCall(ref gaxgrpc::ApiCall<GetFileRequest, File> call);

        partial void Modify_DeleteFileApiCall(ref gaxgrpc::ApiCall<DeleteFileRequest, lro::Operation> call);

        partial void Modify_UpdateFileApiCall(ref gaxgrpc::ApiCall<UpdateFileRequest, File> call);

        partial void Modify_ListTagsApiCall(ref gaxgrpc::ApiCall<ListTagsRequest, ListTagsResponse> call);

        partial void Modify_GetTagApiCall(ref gaxgrpc::ApiCall<GetTagRequest, Tag> call);

        partial void Modify_CreateTagApiCall(ref gaxgrpc::ApiCall<CreateTagRequest, Tag> call);

        partial void Modify_UpdateTagApiCall(ref gaxgrpc::ApiCall<UpdateTagRequest, Tag> call);

        partial void Modify_DeleteTagApiCall(ref gaxgrpc::ApiCall<DeleteTagRequest, wkt::Empty> call);

        partial void Modify_CreateRuleApiCall(ref gaxgrpc::ApiCall<CreateRuleRequest, Rule> call);

        partial void Modify_ListRulesApiCall(ref gaxgrpc::ApiCall<ListRulesRequest, ListRulesResponse> call);

        partial void Modify_GetRuleApiCall(ref gaxgrpc::ApiCall<GetRuleRequest, Rule> call);

        partial void Modify_UpdateRuleApiCall(ref gaxgrpc::ApiCall<UpdateRuleRequest, Rule> call);

        partial void Modify_DeleteRuleApiCall(ref gaxgrpc::ApiCall<DeleteRuleRequest, wkt::Empty> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_GetProjectSettingsApiCall(ref gaxgrpc::ApiCall<GetProjectSettingsRequest, ProjectSettings> call);

        partial void Modify_UpdateProjectSettingsApiCall(ref gaxgrpc::ApiCall<UpdateProjectSettingsRequest, ProjectSettings> call);

        partial void Modify_GetVPCSCConfigApiCall(ref gaxgrpc::ApiCall<GetVPCSCConfigRequest, VPCSCConfig> call);

        partial void Modify_UpdateVPCSCConfigApiCall(ref gaxgrpc::ApiCall<UpdateVPCSCConfigRequest, VPCSCConfig> call);

        partial void Modify_UpdatePackageApiCall(ref gaxgrpc::ApiCall<UpdatePackageRequest, Package> call);

        partial void Modify_ListAttachmentsApiCall(ref gaxgrpc::ApiCall<ListAttachmentsRequest, ListAttachmentsResponse> call);

        partial void Modify_GetAttachmentApiCall(ref gaxgrpc::ApiCall<GetAttachmentRequest, Attachment> call);

        partial void Modify_CreateAttachmentApiCall(ref gaxgrpc::ApiCall<CreateAttachmentRequest, lro::Operation> call);

        partial void Modify_DeleteAttachmentApiCall(ref gaxgrpc::ApiCall<DeleteAttachmentRequest, lro::Operation> call);

        partial void OnConstruction(ArtifactRegistry.ArtifactRegistryClient grpcClient, ArtifactRegistrySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ArtifactRegistry client</summary>
        public override ArtifactRegistry.ArtifactRegistryClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListDockerImagesRequest(ref ListDockerImagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDockerImageRequest(ref GetDockerImageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMavenArtifactsRequest(ref ListMavenArtifactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMavenArtifactRequest(ref GetMavenArtifactRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNpmPackagesRequest(ref ListNpmPackagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNpmPackageRequest(ref GetNpmPackageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPythonPackagesRequest(ref ListPythonPackagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPythonPackageRequest(ref GetPythonPackageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportAptArtifactsRequest(ref ImportAptArtifactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportYumArtifactsRequest(ref ImportYumArtifactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRepositoriesRequest(ref ListRepositoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRepositoryRequest(ref GetRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRepositoryRequest(ref CreateRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRepositoryRequest(ref UpdateRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRepositoryRequest(ref DeleteRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPackagesRequest(ref ListPackagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPackageRequest(ref GetPackageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePackageRequest(ref DeletePackageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVersionsRequest(ref ListVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVersionRequest(ref GetVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVersionRequest(ref DeleteVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteVersionsRequest(ref BatchDeleteVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVersionRequest(ref UpdateVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFilesRequest(ref ListFilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFileRequest(ref GetFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFileRequest(ref DeleteFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFileRequest(ref UpdateFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTagsRequest(ref ListTagsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTagRequest(ref GetTagRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTagRequest(ref CreateTagRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTagRequest(ref UpdateTagRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTagRequest(ref DeleteTagRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRuleRequest(ref CreateRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRulesRequest(ref ListRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRuleRequest(ref GetRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRuleRequest(ref UpdateRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRuleRequest(ref DeleteRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProjectSettingsRequest(ref GetProjectSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProjectSettingsRequest(ref UpdateProjectSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVPCSCConfigRequest(ref GetVPCSCConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVPCSCConfigRequest(ref UpdateVPCSCConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePackageRequest(ref UpdatePackageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAttachmentsRequest(ref ListAttachmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAttachmentRequest(ref GetAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAttachmentRequest(ref CreateAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAttachmentRequest(ref DeleteAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DockerImage"/> resources.</returns>
        public override gax::PagedEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImages(ListDockerImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDockerImagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDockerImagesRequest, ListDockerImagesResponse, DockerImage>(_callListDockerImages, request, callSettings);
        }

        /// <summary>
        /// Lists docker images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DockerImage"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDockerImagesResponse, DockerImage> ListDockerImagesAsync(ListDockerImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDockerImagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDockerImagesRequest, ListDockerImagesResponse, DockerImage>(_callListDockerImages, request, callSettings);
        }

        /// <summary>
        /// Gets a docker image.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DockerImage GetDockerImage(GetDockerImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDockerImageRequest(ref request, ref callSettings);
            return _callGetDockerImage.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a docker image.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DockerImage> GetDockerImageAsync(GetDockerImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDockerImageRequest(ref request, ref callSettings);
            return _callGetDockerImage.Async(request, callSettings);
        }

        /// <summary>
        /// Lists maven artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MavenArtifact"/> resources.</returns>
        public override gax::PagedEnumerable<ListMavenArtifactsResponse, MavenArtifact> ListMavenArtifacts(ListMavenArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMavenArtifactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMavenArtifactsRequest, ListMavenArtifactsResponse, MavenArtifact>(_callListMavenArtifacts, request, callSettings);
        }

        /// <summary>
        /// Lists maven artifacts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MavenArtifact"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMavenArtifactsResponse, MavenArtifact> ListMavenArtifactsAsync(ListMavenArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMavenArtifactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMavenArtifactsRequest, ListMavenArtifactsResponse, MavenArtifact>(_callListMavenArtifacts, request, callSettings);
        }

        /// <summary>
        /// Gets a maven artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MavenArtifact GetMavenArtifact(GetMavenArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMavenArtifactRequest(ref request, ref callSettings);
            return _callGetMavenArtifact.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a maven artifact.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MavenArtifact> GetMavenArtifactAsync(GetMavenArtifactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMavenArtifactRequest(ref request, ref callSettings);
            return _callGetMavenArtifact.Async(request, callSettings);
        }

        /// <summary>
        /// Lists npm packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NpmPackage"/> resources.</returns>
        public override gax::PagedEnumerable<ListNpmPackagesResponse, NpmPackage> ListNpmPackages(ListNpmPackagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNpmPackagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNpmPackagesRequest, ListNpmPackagesResponse, NpmPackage>(_callListNpmPackages, request, callSettings);
        }

        /// <summary>
        /// Lists npm packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NpmPackage"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNpmPackagesResponse, NpmPackage> ListNpmPackagesAsync(ListNpmPackagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNpmPackagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNpmPackagesRequest, ListNpmPackagesResponse, NpmPackage>(_callListNpmPackages, request, callSettings);
        }

        /// <summary>
        /// Gets a npm package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NpmPackage GetNpmPackage(GetNpmPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNpmPackageRequest(ref request, ref callSettings);
            return _callGetNpmPackage.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a npm package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NpmPackage> GetNpmPackageAsync(GetNpmPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNpmPackageRequest(ref request, ref callSettings);
            return _callGetNpmPackage.Async(request, callSettings);
        }

        /// <summary>
        /// Lists python packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PythonPackage"/> resources.</returns>
        public override gax::PagedEnumerable<ListPythonPackagesResponse, PythonPackage> ListPythonPackages(ListPythonPackagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPythonPackagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPythonPackagesRequest, ListPythonPackagesResponse, PythonPackage>(_callListPythonPackages, request, callSettings);
        }

        /// <summary>
        /// Lists python packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PythonPackage"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPythonPackagesResponse, PythonPackage> ListPythonPackagesAsync(ListPythonPackagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPythonPackagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPythonPackagesRequest, ListPythonPackagesResponse, PythonPackage>(_callListPythonPackages, request, callSettings);
        }

        /// <summary>
        /// Gets a python package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PythonPackage GetPythonPackage(GetPythonPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPythonPackageRequest(ref request, ref callSettings);
            return _callGetPythonPackage.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a python package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PythonPackage> GetPythonPackageAsync(GetPythonPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPythonPackageRequest(ref request, ref callSettings);
            return _callGetPythonPackage.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportAptArtifacts</c>.</summary>
        public override lro::OperationsClient ImportAptArtifactsOperationsClient { get; }

        /// <summary>
        /// Imports Apt artifacts. The returned Operation will complete once the
        /// resources are imported. Package, Version, and File resources are created
        /// based on the imported artifacts. Imported artifacts that conflict with
        /// existing resources are ignored.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata> ImportAptArtifacts(ImportAptArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAptArtifactsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata>(_callImportAptArtifacts.Sync(request, callSettings), ImportAptArtifactsOperationsClient);
        }

        /// <summary>
        /// Imports Apt artifacts. The returned Operation will complete once the
        /// resources are imported. Package, Version, and File resources are created
        /// based on the imported artifacts. Imported artifacts that conflict with
        /// existing resources are ignored.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata>> ImportAptArtifactsAsync(ImportAptArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAptArtifactsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportAptArtifactsResponse, ImportAptArtifactsMetadata>(await _callImportAptArtifacts.Async(request, callSettings).ConfigureAwait(false), ImportAptArtifactsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportYumArtifacts</c>.</summary>
        public override lro::OperationsClient ImportYumArtifactsOperationsClient { get; }

        /// <summary>
        /// Imports Yum (RPM) artifacts. The returned Operation will complete once the
        /// resources are imported. Package, Version, and File resources are created
        /// based on the imported artifacts. Imported artifacts that conflict with
        /// existing resources are ignored.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata> ImportYumArtifacts(ImportYumArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportYumArtifactsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata>(_callImportYumArtifacts.Sync(request, callSettings), ImportYumArtifactsOperationsClient);
        }

        /// <summary>
        /// Imports Yum (RPM) artifacts. The returned Operation will complete once the
        /// resources are imported. Package, Version, and File resources are created
        /// based on the imported artifacts. Imported artifacts that conflict with
        /// existing resources are ignored.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata>> ImportYumArtifactsAsync(ImportYumArtifactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportYumArtifactsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportYumArtifactsResponse, ImportYumArtifactsMetadata>(await _callImportYumArtifacts.Async(request, callSettings).ConfigureAwait(false), ImportYumArtifactsOperationsClient);
        }

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public override gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRepositoriesRequest, ListRepositoriesResponse, Repository>(_callListRepositories, request, callSettings);
        }

        /// <summary>
        /// Lists repositories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRepositoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRepositoriesRequest, ListRepositoriesResponse, Repository>(_callListRepositories, request, callSettings);
        }

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Repository GetRepository(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRepositoryRequest(ref request, ref callSettings);
            return _callGetRepository.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRepositoryRequest(ref request, ref callSettings);
            return _callGetRepository.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateRepository</c>.</summary>
        public override lro::OperationsClient CreateRepositoryOperationsClient { get; }

        /// <summary>
        /// Creates a repository. The returned Operation will finish once the
        /// repository has been created. Its response will be the created Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Repository, OperationMetadata> CreateRepository(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<Repository, OperationMetadata>(_callCreateRepository.Sync(request, callSettings), CreateRepositoryOperationsClient);
        }

        /// <summary>
        /// Creates a repository. The returned Operation will finish once the
        /// repository has been created. Its response will be the created Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Repository, OperationMetadata>> CreateRepositoryAsync(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<Repository, OperationMetadata>(await _callCreateRepository.Async(request, callSettings).ConfigureAwait(false), CreateRepositoryOperationsClient);
        }

        /// <summary>
        /// Updates a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Repository UpdateRepository(UpdateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRepositoryRequest(ref request, ref callSettings);
            return _callUpdateRepository.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Repository> UpdateRepositoryAsync(UpdateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRepositoryRequest(ref request, ref callSettings);
            return _callUpdateRepository.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteRepository</c>.</summary>
        public override lro::OperationsClient DeleteRepositoryOperationsClient { get; }

        /// <summary>
        /// Deletes a repository and all of its contents. The returned Operation will
        /// finish once the repository has been deleted. It will not have any Operation
        /// metadata and will return a google.protobuf.Empty response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRepository(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRepository.Sync(request, callSettings), DeleteRepositoryOperationsClient);
        }

        /// <summary>
        /// Deletes a repository and all of its contents. The returned Operation will
        /// finish once the repository has been deleted. It will not have any Operation
        /// metadata and will return a google.protobuf.Empty response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRepositoryAsync(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRepository.Async(request, callSettings).ConfigureAwait(false), DeleteRepositoryOperationsClient);
        }

        /// <summary>
        /// Lists packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Package"/> resources.</returns>
        public override gax::PagedEnumerable<ListPackagesResponse, Package> ListPackages(ListPackagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPackagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPackagesRequest, ListPackagesResponse, Package>(_callListPackages, request, callSettings);
        }

        /// <summary>
        /// Lists packages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Package"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPackagesResponse, Package> ListPackagesAsync(ListPackagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPackagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPackagesRequest, ListPackagesResponse, Package>(_callListPackages, request, callSettings);
        }

        /// <summary>
        /// Gets a package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Package GetPackage(GetPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPackageRequest(ref request, ref callSettings);
            return _callGetPackage.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Package> GetPackageAsync(GetPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPackageRequest(ref request, ref callSettings);
            return _callGetPackage.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeletePackage</c>.</summary>
        public override lro::OperationsClient DeletePackageOperationsClient { get; }

        /// <summary>
        /// Deletes a package and all of its versions and tags. The returned operation
        /// will complete once the package has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeletePackage(DeletePackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePackageRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeletePackage.Sync(request, callSettings), DeletePackageOperationsClient);
        }

        /// <summary>
        /// Deletes a package and all of its versions and tags. The returned operation
        /// will complete once the package has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePackageAsync(DeletePackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePackageRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeletePackage.Async(request, callSettings).ConfigureAwait(false), DeletePackageOperationsClient);
        }

        /// <summary>
        /// Lists versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Version"/> resources.</returns>
        public override gax::PagedEnumerable<ListVersionsResponse, Version> ListVersions(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVersionsRequest, ListVersionsResponse, Version>(_callListVersions, request, callSettings);
        }

        /// <summary>
        /// Lists versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Version"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVersionsResponse, Version> ListVersionsAsync(ListVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVersionsRequest, ListVersionsResponse, Version>(_callListVersions, request, callSettings);
        }

        /// <summary>
        /// Gets a version
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Version GetVersion(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVersionRequest(ref request, ref callSettings);
            return _callGetVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a version
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Version> GetVersionAsync(GetVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVersionRequest(ref request, ref callSettings);
            return _callGetVersion.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteVersion</c>.</summary>
        public override lro::OperationsClient DeleteVersionOperationsClient { get; }

        /// <summary>
        /// Deletes a version and all of its content. The returned operation will
        /// complete once the version has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteVersion(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVersionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteVersion.Sync(request, callSettings), DeleteVersionOperationsClient);
        }

        /// <summary>
        /// Deletes a version and all of its content. The returned operation will
        /// complete once the version has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVersionAsync(DeleteVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVersionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteVersion.Async(request, callSettings).ConfigureAwait(false), DeleteVersionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchDeleteVersions</c>.</summary>
        public override lro::OperationsClient BatchDeleteVersionsOperationsClient { get; }

        /// <summary>
        /// Deletes multiple versions across a repository. The returned operation will
        /// complete once the versions have been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata> BatchDeleteVersions(BatchDeleteVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteVersionsRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>(_callBatchDeleteVersions.Sync(request, callSettings), BatchDeleteVersionsOperationsClient);
        }

        /// <summary>
        /// Deletes multiple versions across a repository. The returned operation will
        /// complete once the versions have been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>> BatchDeleteVersionsAsync(BatchDeleteVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteVersionsRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, BatchDeleteVersionsMetadata>(await _callBatchDeleteVersions.Async(request, callSettings).ConfigureAwait(false), BatchDeleteVersionsOperationsClient);
        }

        /// <summary>
        /// Updates a version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Version UpdateVersion(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVersionRequest(ref request, ref callSettings);
            return _callUpdateVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Version> UpdateVersionAsync(UpdateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVersionRequest(ref request, ref callSettings);
            return _callUpdateVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Lists files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="File"/> resources.</returns>
        public override gax::PagedEnumerable<ListFilesResponse, File> ListFiles(ListFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFilesRequest, ListFilesResponse, File>(_callListFiles, request, callSettings);
        }

        /// <summary>
        /// Lists files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="File"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFilesResponse, File> ListFilesAsync(ListFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFilesRequest, ListFilesResponse, File>(_callListFiles, request, callSettings);
        }

        /// <summary>
        /// Gets a file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override File GetFile(GetFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFileRequest(ref request, ref callSettings);
            return _callGetFile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<File> GetFileAsync(GetFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFileRequest(ref request, ref callSettings);
            return _callGetFile.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteFile</c>.</summary>
        public override lro::OperationsClient DeleteFileOperationsClient { get; }

        /// <summary>
        /// Deletes a file and all of its content. It is only allowed on generic
        /// repositories. The returned operation will complete once the file has been
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteFile(DeleteFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteFile.Sync(request, callSettings), DeleteFileOperationsClient);
        }

        /// <summary>
        /// Deletes a file and all of its content. It is only allowed on generic
        /// repositories. The returned operation will complete once the file has been
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFileAsync(DeleteFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteFile.Async(request, callSettings).ConfigureAwait(false), DeleteFileOperationsClient);
        }

        /// <summary>
        /// Updates a file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override File UpdateFile(UpdateFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFileRequest(ref request, ref callSettings);
            return _callUpdateFile.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<File> UpdateFileAsync(UpdateFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFileRequest(ref request, ref callSettings);
            return _callUpdateFile.Async(request, callSettings);
        }

        /// <summary>
        /// Lists tags.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tag"/> resources.</returns>
        public override gax::PagedEnumerable<ListTagsResponse, Tag> ListTags(ListTagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTagsRequest, ListTagsResponse, Tag>(_callListTags, request, callSettings);
        }

        /// <summary>
        /// Lists tags.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tag"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTagsResponse, Tag> ListTagsAsync(ListTagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTagsRequest, ListTagsResponse, Tag>(_callListTags, request, callSettings);
        }

        /// <summary>
        /// Gets a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tag GetTag(GetTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTagRequest(ref request, ref callSettings);
            return _callGetTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tag> GetTagAsync(GetTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTagRequest(ref request, ref callSettings);
            return _callGetTag.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tag CreateTag(CreateTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagRequest(ref request, ref callSettings);
            return _callCreateTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tag> CreateTagAsync(CreateTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagRequest(ref request, ref callSettings);
            return _callCreateTag.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tag UpdateTag(UpdateTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagRequest(ref request, ref callSettings);
            return _callUpdateTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tag> UpdateTagAsync(UpdateTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagRequest(ref request, ref callSettings);
            return _callUpdateTag.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTag(DeleteTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagRequest(ref request, ref callSettings);
            _callDeleteTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTagAsync(DeleteTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagRequest(ref request, ref callSettings);
            return _callDeleteTag.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rule CreateRule(CreateRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRuleRequest(ref request, ref callSettings);
            return _callCreateRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rule> CreateRuleAsync(CreateRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRuleRequest(ref request, ref callSettings);
            return _callCreateRule.Async(request, callSettings);
        }

        /// <summary>
        /// Lists rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public override gax::PagedEnumerable<ListRulesResponse, Rule> ListRules(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRulesRequest, ListRulesResponse, Rule>(_callListRules, request, callSettings);
        }

        /// <summary>
        /// Lists rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRulesResponse, Rule> ListRulesAsync(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRulesRequest, ListRulesResponse, Rule>(_callListRules, request, callSettings);
        }

        /// <summary>
        /// Gets a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rule GetRule(GetRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleRequest(ref request, ref callSettings);
            return _callGetRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rule> GetRuleAsync(GetRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleRequest(ref request, ref callSettings);
            return _callGetRule.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rule UpdateRule(UpdateRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRuleRequest(ref request, ref callSettings);
            return _callUpdateRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rule> UpdateRuleAsync(UpdateRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRuleRequest(ref request, ref callSettings);
            return _callUpdateRule.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteRule(DeleteRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRuleRequest(ref request, ref callSettings);
            _callDeleteRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteRuleAsync(DeleteRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRuleRequest(ref request, ref callSettings);
            return _callDeleteRule.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the IAM policy for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the IAM policy for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Tests if the caller has a list of permissions on a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Tests if the caller has a list of permissions on a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the Settings for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProjectSettings GetProjectSettings(GetProjectSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectSettingsRequest(ref request, ref callSettings);
            return _callGetProjectSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the Settings for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProjectSettings> GetProjectSettingsAsync(GetProjectSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectSettingsRequest(ref request, ref callSettings);
            return _callGetProjectSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Settings for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProjectSettings UpdateProjectSettings(UpdateProjectSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProjectSettingsRequest(ref request, ref callSettings);
            return _callUpdateProjectSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Settings for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProjectSettings> UpdateProjectSettingsAsync(UpdateProjectSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProjectSettingsRequest(ref request, ref callSettings);
            return _callUpdateProjectSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the VPCSC Config for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VPCSCConfig GetVPCSCConfig(GetVPCSCConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVPCSCConfigRequest(ref request, ref callSettings);
            return _callGetVPCSCConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the VPCSC Config for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VPCSCConfig> GetVPCSCConfigAsync(GetVPCSCConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVPCSCConfigRequest(ref request, ref callSettings);
            return _callGetVPCSCConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the VPCSC Config for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VPCSCConfig UpdateVPCSCConfig(UpdateVPCSCConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVPCSCConfigRequest(ref request, ref callSettings);
            return _callUpdateVPCSCConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the VPCSC Config for the Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VPCSCConfig> UpdateVPCSCConfigAsync(UpdateVPCSCConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVPCSCConfigRequest(ref request, ref callSettings);
            return _callUpdateVPCSCConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Package UpdatePackage(UpdatePackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePackageRequest(ref request, ref callSettings);
            return _callUpdatePackage.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Package> UpdatePackageAsync(UpdatePackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePackageRequest(ref request, ref callSettings);
            return _callUpdatePackage.Async(request, callSettings);
        }

        /// <summary>
        /// Lists attachments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Attachment"/> resources.</returns>
        public override gax::PagedEnumerable<ListAttachmentsResponse, Attachment> ListAttachments(ListAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAttachmentsRequest, ListAttachmentsResponse, Attachment>(_callListAttachments, request, callSettings);
        }

        /// <summary>
        /// Lists attachments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Attachment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAttachmentsResponse, Attachment> ListAttachmentsAsync(ListAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAttachmentsRequest, ListAttachmentsResponse, Attachment>(_callListAttachments, request, callSettings);
        }

        /// <summary>
        /// Gets an attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Attachment GetAttachment(GetAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttachmentRequest(ref request, ref callSettings);
            return _callGetAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Attachment> GetAttachmentAsync(GetAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttachmentRequest(ref request, ref callSettings);
            return _callGetAttachment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAttachment</c>.</summary>
        public override lro::OperationsClient CreateAttachmentOperationsClient { get; }

        /// <summary>
        /// Creates an attachment. The returned Operation will finish once the
        /// attachment has been created. Its response will be the created attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Attachment, OperationMetadata> CreateAttachment(CreateAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<Attachment, OperationMetadata>(_callCreateAttachment.Sync(request, callSettings), CreateAttachmentOperationsClient);
        }

        /// <summary>
        /// Creates an attachment. The returned Operation will finish once the
        /// attachment has been created. Its response will be the created attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Attachment, OperationMetadata>> CreateAttachmentAsync(CreateAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<Attachment, OperationMetadata>(await _callCreateAttachment.Async(request, callSettings).ConfigureAwait(false), CreateAttachmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAttachment</c>.</summary>
        public override lro::OperationsClient DeleteAttachmentOperationsClient { get; }

        /// <summary>
        /// Deletes an attachment. The returned Operation will
        /// finish once the attachments has been deleted. It will not have any
        /// Operation metadata and will return a `google.protobuf.Empty` response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAttachment(DeleteAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAttachment.Sync(request, callSettings), DeleteAttachmentOperationsClient);
        }

        /// <summary>
        /// Deletes an attachment. The returned Operation will
        /// finish once the attachments has been deleted. It will not have any
        /// Operation metadata and will return a `google.protobuf.Empty` response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAttachmentAsync(DeleteAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAttachment.Async(request, callSettings).ConfigureAwait(false), DeleteAttachmentOperationsClient);
        }
    }

    public partial class ListDockerImagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMavenArtifactsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNpmPackagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPythonPackagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRepositoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPackagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTagsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAttachmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDockerImagesResponse : gaxgrpc::IPageResponse<DockerImage>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DockerImage> GetEnumerator() => DockerImages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMavenArtifactsResponse : gaxgrpc::IPageResponse<MavenArtifact>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MavenArtifact> GetEnumerator() => MavenArtifacts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNpmPackagesResponse : gaxgrpc::IPageResponse<NpmPackage>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NpmPackage> GetEnumerator() => NpmPackages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPythonPackagesResponse : gaxgrpc::IPageResponse<PythonPackage>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PythonPackage> GetEnumerator() => PythonPackages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRepositoriesResponse : gaxgrpc::IPageResponse<Repository>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Repository> GetEnumerator() => Repositories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPackagesResponse : gaxgrpc::IPageResponse<Package>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Package> GetEnumerator() => Packages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVersionsResponse : gaxgrpc::IPageResponse<Version>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Version> GetEnumerator() => Versions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFilesResponse : gaxgrpc::IPageResponse<File>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<File> GetEnumerator() => Files.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTagsResponse : gaxgrpc::IPageResponse<Tag>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Tag> GetEnumerator() => Tags.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRulesResponse : gaxgrpc::IPageResponse<Rule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Rule> GetEnumerator() => Rules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAttachmentsResponse : gaxgrpc::IPageResponse<Attachment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Attachment> GetEnumerator() => Attachments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ArtifactRegistry
    {
        public partial class ArtifactRegistryClient
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

    public static partial class ArtifactRegistry
    {
        public partial class ArtifactRegistryClient
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
