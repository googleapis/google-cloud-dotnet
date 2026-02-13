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

namespace Google.Cloud.Dataform.V1Beta1
{
    /// <summary>Settings for <see cref="DataformClient"/> instances.</summary>
    public sealed partial class DataformSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataformSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataformSettings"/>.</returns>
        public static DataformSettings GetDefault() => new DataformSettings();

        /// <summary>Constructs a new <see cref="DataformSettings"/> object with default settings.</summary>
        public DataformSettings()
        {
        }

        private DataformSettings(DataformSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTeamFolderSettings = existing.GetTeamFolderSettings;
            CreateTeamFolderSettings = existing.CreateTeamFolderSettings;
            UpdateTeamFolderSettings = existing.UpdateTeamFolderSettings;
            DeleteTeamFolderSettings = existing.DeleteTeamFolderSettings;
            QueryTeamFolderContentsSettings = existing.QueryTeamFolderContentsSettings;
            SearchTeamFoldersSettings = existing.SearchTeamFoldersSettings;
            GetFolderSettings = existing.GetFolderSettings;
            CreateFolderSettings = existing.CreateFolderSettings;
            UpdateFolderSettings = existing.UpdateFolderSettings;
            DeleteFolderSettings = existing.DeleteFolderSettings;
            QueryFolderContentsSettings = existing.QueryFolderContentsSettings;
            QueryUserRootContentsSettings = existing.QueryUserRootContentsSettings;
            MoveFolderSettings = existing.MoveFolderSettings;
            MoveFolderOperationsSettings = existing.MoveFolderOperationsSettings.Clone();
            ListRepositoriesSettings = existing.ListRepositoriesSettings;
            GetRepositorySettings = existing.GetRepositorySettings;
            CreateRepositorySettings = existing.CreateRepositorySettings;
            UpdateRepositorySettings = existing.UpdateRepositorySettings;
            DeleteRepositorySettings = existing.DeleteRepositorySettings;
            MoveRepositorySettings = existing.MoveRepositorySettings;
            MoveRepositoryOperationsSettings = existing.MoveRepositoryOperationsSettings.Clone();
            CommitRepositoryChangesSettings = existing.CommitRepositoryChangesSettings;
            ReadRepositoryFileSettings = existing.ReadRepositoryFileSettings;
            QueryRepositoryDirectoryContentsSettings = existing.QueryRepositoryDirectoryContentsSettings;
            FetchRepositoryHistorySettings = existing.FetchRepositoryHistorySettings;
            ComputeRepositoryAccessTokenStatusSettings = existing.ComputeRepositoryAccessTokenStatusSettings;
            FetchRemoteBranchesSettings = existing.FetchRemoteBranchesSettings;
            ListWorkspacesSettings = existing.ListWorkspacesSettings;
            GetWorkspaceSettings = existing.GetWorkspaceSettings;
            CreateWorkspaceSettings = existing.CreateWorkspaceSettings;
            DeleteWorkspaceSettings = existing.DeleteWorkspaceSettings;
            InstallNpmPackagesSettings = existing.InstallNpmPackagesSettings;
            PullGitCommitsSettings = existing.PullGitCommitsSettings;
            PushGitCommitsSettings = existing.PushGitCommitsSettings;
            FetchFileGitStatusesSettings = existing.FetchFileGitStatusesSettings;
            FetchGitAheadBehindSettings = existing.FetchGitAheadBehindSettings;
            CommitWorkspaceChangesSettings = existing.CommitWorkspaceChangesSettings;
            ResetWorkspaceChangesSettings = existing.ResetWorkspaceChangesSettings;
            FetchFileDiffSettings = existing.FetchFileDiffSettings;
            QueryDirectoryContentsSettings = existing.QueryDirectoryContentsSettings;
            SearchFilesSettings = existing.SearchFilesSettings;
            MakeDirectorySettings = existing.MakeDirectorySettings;
            RemoveDirectorySettings = existing.RemoveDirectorySettings;
            MoveDirectorySettings = existing.MoveDirectorySettings;
            ReadFileSettings = existing.ReadFileSettings;
            RemoveFileSettings = existing.RemoveFileSettings;
            MoveFileSettings = existing.MoveFileSettings;
            WriteFileSettings = existing.WriteFileSettings;
            ListReleaseConfigsSettings = existing.ListReleaseConfigsSettings;
            GetReleaseConfigSettings = existing.GetReleaseConfigSettings;
            CreateReleaseConfigSettings = existing.CreateReleaseConfigSettings;
            UpdateReleaseConfigSettings = existing.UpdateReleaseConfigSettings;
            DeleteReleaseConfigSettings = existing.DeleteReleaseConfigSettings;
            ListCompilationResultsSettings = existing.ListCompilationResultsSettings;
            GetCompilationResultSettings = existing.GetCompilationResultSettings;
            CreateCompilationResultSettings = existing.CreateCompilationResultSettings;
            QueryCompilationResultActionsSettings = existing.QueryCompilationResultActionsSettings;
            ListWorkflowConfigsSettings = existing.ListWorkflowConfigsSettings;
            GetWorkflowConfigSettings = existing.GetWorkflowConfigSettings;
            CreateWorkflowConfigSettings = existing.CreateWorkflowConfigSettings;
            UpdateWorkflowConfigSettings = existing.UpdateWorkflowConfigSettings;
            DeleteWorkflowConfigSettings = existing.DeleteWorkflowConfigSettings;
            ListWorkflowInvocationsSettings = existing.ListWorkflowInvocationsSettings;
            GetWorkflowInvocationSettings = existing.GetWorkflowInvocationSettings;
            CreateWorkflowInvocationSettings = existing.CreateWorkflowInvocationSettings;
            DeleteWorkflowInvocationSettings = existing.DeleteWorkflowInvocationSettings;
            CancelWorkflowInvocationSettings = existing.CancelWorkflowInvocationSettings;
            QueryWorkflowInvocationActionsSettings = existing.QueryWorkflowInvocationActionsSettings;
            GetConfigSettings = existing.GetConfigSettings;
            UpdateConfigSettings = existing.UpdateConfigSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataformSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.GetTeamFolder</c> and <c>DataformClient.GetTeamFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTeamFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.CreateTeamFolder</c> and <c>DataformClient.CreateTeamFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTeamFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.UpdateTeamFolder</c> and <c>DataformClient.UpdateTeamFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTeamFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.DeleteTeamFolder</c> and <c>DataformClient.DeleteTeamFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTeamFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.QueryTeamFolderContents</c> and <c>DataformClient.QueryTeamFolderContentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryTeamFolderContentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.SearchTeamFolders</c> and <c>DataformClient.SearchTeamFoldersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchTeamFoldersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.GetFolder</c>
        ///  and <c>DataformClient.GetFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.CreateFolder</c>
        ///  and <c>DataformClient.CreateFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.UpdateFolder</c>
        ///  and <c>DataformClient.UpdateFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.DeleteFolder</c>
        ///  and <c>DataformClient.DeleteFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.QueryFolderContents</c> and <c>DataformClient.QueryFolderContentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryFolderContentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.QueryUserRootContents</c> and <c>DataformClient.QueryUserRootContentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryUserRootContentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.MoveFolder</c>
        ///  and <c>DataformClient.MoveFolderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveFolderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataformClient.MoveFolder</c> and
        /// <c>DataformClient.MoveFolderAsync</c>.
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
        public lro::OperationsSettings MoveFolderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.ListRepositories</c> and <c>DataformClient.ListRepositoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRepositoriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.GetRepository</c> and <c>DataformClient.GetRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.CreateRepository</c> and <c>DataformClient.CreateRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.UpdateRepository</c> and <c>DataformClient.UpdateRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.DeleteRepository</c> and <c>DataformClient.DeleteRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.MoveRepository</c> and <c>DataformClient.MoveRepositoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveRepositorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataformClient.MoveRepository</c> and
        /// <c>DataformClient.MoveRepositoryAsync</c>.
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
        public lro::OperationsSettings MoveRepositoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.CommitRepositoryChanges</c> and <c>DataformClient.CommitRepositoryChangesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CommitRepositoryChangesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.ReadRepositoryFile</c> and <c>DataformClient.ReadRepositoryFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadRepositoryFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.QueryRepositoryDirectoryContents</c> and
        /// <c>DataformClient.QueryRepositoryDirectoryContentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryRepositoryDirectoryContentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.FetchRepositoryHistory</c> and <c>DataformClient.FetchRepositoryHistoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchRepositoryHistorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.ComputeRepositoryAccessTokenStatus</c> and
        /// <c>DataformClient.ComputeRepositoryAccessTokenStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComputeRepositoryAccessTokenStatusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.FetchRemoteBranches</c> and <c>DataformClient.FetchRemoteBranchesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchRemoteBranchesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.ListWorkspaces</c> and <c>DataformClient.ListWorkspacesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkspacesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.GetWorkspace</c>
        ///  and <c>DataformClient.GetWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.CreateWorkspace</c> and <c>DataformClient.CreateWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.DeleteWorkspace</c> and <c>DataformClient.DeleteWorkspaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkspaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.InstallNpmPackages</c> and <c>DataformClient.InstallNpmPackagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InstallNpmPackagesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.PullGitCommits</c> and <c>DataformClient.PullGitCommitsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PullGitCommitsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.PushGitCommits</c> and <c>DataformClient.PushGitCommitsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PushGitCommitsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.FetchFileGitStatuses</c> and <c>DataformClient.FetchFileGitStatusesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchFileGitStatusesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.FetchGitAheadBehind</c> and <c>DataformClient.FetchGitAheadBehindAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchGitAheadBehindSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.CommitWorkspaceChanges</c> and <c>DataformClient.CommitWorkspaceChangesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CommitWorkspaceChangesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.ResetWorkspaceChanges</c> and <c>DataformClient.ResetWorkspaceChangesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetWorkspaceChangesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.FetchFileDiff</c> and <c>DataformClient.FetchFileDiffAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchFileDiffSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.QueryDirectoryContents</c> and <c>DataformClient.QueryDirectoryContentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryDirectoryContentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.SearchFiles</c>
        ///  and <c>DataformClient.SearchFilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchFilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.MakeDirectory</c> and <c>DataformClient.MakeDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MakeDirectorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.RemoveDirectory</c> and <c>DataformClient.RemoveDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveDirectorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.MoveDirectory</c> and <c>DataformClient.MoveDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveDirectorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.ReadFile</c>
        /// and <c>DataformClient.ReadFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.RemoveFile</c>
        ///  and <c>DataformClient.RemoveFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.MoveFile</c>
        /// and <c>DataformClient.MoveFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.WriteFile</c>
        ///  and <c>DataformClient.WriteFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WriteFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.ListReleaseConfigs</c> and <c>DataformClient.ListReleaseConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReleaseConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.GetReleaseConfig</c> and <c>DataformClient.GetReleaseConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReleaseConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.CreateReleaseConfig</c> and <c>DataformClient.CreateReleaseConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReleaseConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.UpdateReleaseConfig</c> and <c>DataformClient.UpdateReleaseConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReleaseConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.DeleteReleaseConfig</c> and <c>DataformClient.DeleteReleaseConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReleaseConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.ListCompilationResults</c> and <c>DataformClient.ListCompilationResultsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCompilationResultsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.GetCompilationResult</c> and <c>DataformClient.GetCompilationResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCompilationResultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.CreateCompilationResult</c> and <c>DataformClient.CreateCompilationResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCompilationResultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.QueryCompilationResultActions</c> and <c>DataformClient.QueryCompilationResultActionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryCompilationResultActionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.ListWorkflowConfigs</c> and <c>DataformClient.ListWorkflowConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkflowConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.GetWorkflowConfig</c> and <c>DataformClient.GetWorkflowConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkflowConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.CreateWorkflowConfig</c> and <c>DataformClient.CreateWorkflowConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkflowConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.UpdateWorkflowConfig</c> and <c>DataformClient.UpdateWorkflowConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkflowConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.DeleteWorkflowConfig</c> and <c>DataformClient.DeleteWorkflowConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkflowConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.ListWorkflowInvocations</c> and <c>DataformClient.ListWorkflowInvocationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkflowInvocationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.GetWorkflowInvocation</c> and <c>DataformClient.GetWorkflowInvocationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkflowInvocationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.CreateWorkflowInvocation</c> and <c>DataformClient.CreateWorkflowInvocationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkflowInvocationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.DeleteWorkflowInvocation</c> and <c>DataformClient.DeleteWorkflowInvocationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkflowInvocationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.CancelWorkflowInvocation</c> and <c>DataformClient.CancelWorkflowInvocationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelWorkflowInvocationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.QueryWorkflowInvocationActions</c> and
        /// <c>DataformClient.QueryWorkflowInvocationActionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryWorkflowInvocationActionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.GetConfig</c>
        ///  and <c>DataformClient.GetConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.UpdateConfig</c>
        ///  and <c>DataformClient.UpdateConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.GetIamPolicy</c>
        ///  and <c>DataformClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataformClient.SetIamPolicy</c>
        ///  and <c>DataformClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataformClient.TestIamPermissions</c> and <c>DataformClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataformSettings"/> object.</returns>
        public DataformSettings Clone() => new DataformSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataformClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DataformClientBuilder : gaxgrpc::ClientBuilderBase<DataformClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataformSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataformClientBuilder() : base(DataformClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataformClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataformClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataformClient Build()
        {
            DataformClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataformClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataformClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataformClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataformClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataformClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataformClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataformClient.ChannelPool;
    }

    /// <summary>Dataform client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Dataform is a service to develop, create, document, test, and update curated
    /// tables in BigQuery.
    /// </remarks>
    public abstract partial class DataformClient
    {
        /// <summary>
        /// The default endpoint for the Dataform service, which is a host of "dataform.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataform.googleapis.com:443";

        /// <summary>The default Dataform scopes.</summary>
        /// <remarks>
        /// The default Dataform scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigquery</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigquery",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Dataform.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataformClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="DataformClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataformClient"/>.</returns>
        public static stt::Task<DataformClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataformClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataformClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="DataformClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataformClient"/>.</returns>
        public static DataformClient Create() => new DataformClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataformClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataformSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataformClient"/>.</returns>
        internal static DataformClient Create(grpccore::CallInvoker callInvoker, DataformSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Dataform.DataformClient grpcClient = new Dataform.DataformClient(callInvoker);
            return new DataformClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Dataform client</summary>
        public virtual Dataform.DataformClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TeamFolder GetTeamFolder(GetTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> GetTeamFolderAsync(GetTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> GetTeamFolderAsync(GetTeamFolderRequest request, st::CancellationToken cancellationToken) =>
            GetTeamFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TeamFolder GetTeamFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTeamFolder(new GetTeamFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> GetTeamFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTeamFolderAsync(new GetTeamFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> GetTeamFolderAsync(string name, st::CancellationToken cancellationToken) =>
            GetTeamFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TeamFolder GetTeamFolder(TeamFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTeamFolder(new GetTeamFolderRequest
            {
                TeamFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> GetTeamFolderAsync(TeamFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTeamFolderAsync(new GetTeamFolderRequest
            {
                TeamFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> GetTeamFolderAsync(TeamFolderName name, st::CancellationToken cancellationToken) =>
            GetTeamFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TeamFolder in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TeamFolder CreateTeamFolder(CreateTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TeamFolder in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> CreateTeamFolderAsync(CreateTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TeamFolder in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> CreateTeamFolderAsync(CreateTeamFolderRequest request, st::CancellationToken cancellationToken) =>
            CreateTeamFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TeamFolder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the TeamFolder. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="teamFolder">
        /// Required. The TeamFolder to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TeamFolder CreateTeamFolder(string parent, TeamFolder teamFolder, gaxgrpc::CallSettings callSettings = null) =>
            CreateTeamFolder(new CreateTeamFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TeamFolder = gax::GaxPreconditions.CheckNotNull(teamFolder, nameof(teamFolder)),
            }, callSettings);

        /// <summary>
        /// Creates a new TeamFolder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the TeamFolder. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="teamFolder">
        /// Required. The TeamFolder to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> CreateTeamFolderAsync(string parent, TeamFolder teamFolder, gaxgrpc::CallSettings callSettings = null) =>
            CreateTeamFolderAsync(new CreateTeamFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TeamFolder = gax::GaxPreconditions.CheckNotNull(teamFolder, nameof(teamFolder)),
            }, callSettings);

        /// <summary>
        /// Creates a new TeamFolder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the TeamFolder. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="teamFolder">
        /// Required. The TeamFolder to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> CreateTeamFolderAsync(string parent, TeamFolder teamFolder, st::CancellationToken cancellationToken) =>
            CreateTeamFolderAsync(parent, teamFolder, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TeamFolder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the TeamFolder. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="teamFolder">
        /// Required. The TeamFolder to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TeamFolder CreateTeamFolder(gagr::LocationName parent, TeamFolder teamFolder, gaxgrpc::CallSettings callSettings = null) =>
            CreateTeamFolder(new CreateTeamFolderRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TeamFolder = gax::GaxPreconditions.CheckNotNull(teamFolder, nameof(teamFolder)),
            }, callSettings);

        /// <summary>
        /// Creates a new TeamFolder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the TeamFolder. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="teamFolder">
        /// Required. The TeamFolder to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> CreateTeamFolderAsync(gagr::LocationName parent, TeamFolder teamFolder, gaxgrpc::CallSettings callSettings = null) =>
            CreateTeamFolderAsync(new CreateTeamFolderRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TeamFolder = gax::GaxPreconditions.CheckNotNull(teamFolder, nameof(teamFolder)),
            }, callSettings);

        /// <summary>
        /// Creates a new TeamFolder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the TeamFolder. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="teamFolder">
        /// Required. The TeamFolder to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> CreateTeamFolderAsync(gagr::LocationName parent, TeamFolder teamFolder, st::CancellationToken cancellationToken) =>
            CreateTeamFolderAsync(parent, teamFolder, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TeamFolder UpdateTeamFolder(UpdateTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> UpdateTeamFolderAsync(UpdateTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> UpdateTeamFolderAsync(UpdateTeamFolderRequest request, st::CancellationToken cancellationToken) =>
            UpdateTeamFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single TeamFolder.
        /// </summary>
        /// <param name="teamFolder">
        /// Required. The updated TeamFolder.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the Folder. If left unset,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TeamFolder UpdateTeamFolder(TeamFolder teamFolder, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTeamFolder(new UpdateTeamFolderRequest
            {
                UpdateMask = updateMask,
                TeamFolder = gax::GaxPreconditions.CheckNotNull(teamFolder, nameof(teamFolder)),
            }, callSettings);

        /// <summary>
        /// Updates a single TeamFolder.
        /// </summary>
        /// <param name="teamFolder">
        /// Required. The updated TeamFolder.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the Folder. If left unset,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> UpdateTeamFolderAsync(TeamFolder teamFolder, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTeamFolderAsync(new UpdateTeamFolderRequest
            {
                UpdateMask = updateMask,
                TeamFolder = gax::GaxPreconditions.CheckNotNull(teamFolder, nameof(teamFolder)),
            }, callSettings);

        /// <summary>
        /// Updates a single TeamFolder.
        /// </summary>
        /// <param name="teamFolder">
        /// Required. The updated TeamFolder.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the Folder. If left unset,
        /// all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TeamFolder> UpdateTeamFolderAsync(TeamFolder teamFolder, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTeamFolderAsync(teamFolder, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTeamFolder(DeleteTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTeamFolderAsync(DeleteTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTeamFolderAsync(DeleteTeamFolderRequest request, st::CancellationToken cancellationToken) =>
            DeleteTeamFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTeamFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTeamFolder(new DeleteTeamFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTeamFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTeamFolderAsync(new DeleteTeamFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTeamFolderAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTeamFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTeamFolder(TeamFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTeamFolder(new DeleteTeamFolderRequest
            {
                TeamFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTeamFolderAsync(TeamFolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTeamFolderAsync(new DeleteTeamFolderRequest
            {
                TeamFolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TeamFolder.
        /// </summary>
        /// <param name="name">
        /// Required. The TeamFolder's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTeamFolderAsync(TeamFolderName name, st::CancellationToken cancellationToken) =>
            DeleteTeamFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a given TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedEnumerable<QueryTeamFolderContentsResponse, QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> QueryTeamFolderContents(QueryTeamFolderContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a given TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of
        /// <see cref="QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<QueryTeamFolderContentsResponse, QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> QueryTeamFolderContentsAsync(QueryTeamFolderContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a given TeamFolder.
        /// </summary>
        /// <param name="teamFolder">
        /// Required. Name of the team_folder whose contents to list.
        /// Format: `projects/*/locations/*/teamFolders/*`.
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
        /// <returns>
        /// A pageable sequence of <see cref="QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedEnumerable<QueryTeamFolderContentsResponse, QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> QueryTeamFolderContents(string teamFolder, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryTeamFolderContentsRequest request = new QueryTeamFolderContentsRequest
            {
                TeamFolder = gax::GaxPreconditions.CheckNotNullOrEmpty(teamFolder, nameof(teamFolder)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryTeamFolderContents(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given TeamFolder.
        /// </summary>
        /// <param name="teamFolder">
        /// Required. Name of the team_folder whose contents to list.
        /// Format: `projects/*/locations/*/teamFolders/*`.
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
        /// <returns>
        /// A pageable asynchronous sequence of
        /// <see cref="QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<QueryTeamFolderContentsResponse, QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> QueryTeamFolderContentsAsync(string teamFolder, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryTeamFolderContentsRequest request = new QueryTeamFolderContentsRequest
            {
                TeamFolder = gax::GaxPreconditions.CheckNotNullOrEmpty(teamFolder, nameof(teamFolder)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryTeamFolderContentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given TeamFolder.
        /// </summary>
        /// <param name="teamFolder">
        /// Required. Name of the team_folder whose contents to list.
        /// Format: `projects/*/locations/*/teamFolders/*`.
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
        /// <returns>
        /// A pageable sequence of <see cref="QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedEnumerable<QueryTeamFolderContentsResponse, QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> QueryTeamFolderContents(TeamFolderName teamFolder, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryTeamFolderContentsRequest request = new QueryTeamFolderContentsRequest
            {
                TeamFolderAsTeamFolderName = gax::GaxPreconditions.CheckNotNull(teamFolder, nameof(teamFolder)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryTeamFolderContents(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given TeamFolder.
        /// </summary>
        /// <param name="teamFolder">
        /// Required. Name of the team_folder whose contents to list.
        /// Format: `projects/*/locations/*/teamFolders/*`.
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
        /// <returns>
        /// A pageable asynchronous sequence of
        /// <see cref="QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<QueryTeamFolderContentsResponse, QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> QueryTeamFolderContentsAsync(TeamFolderName teamFolder, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryTeamFolderContentsRequest request = new QueryTeamFolderContentsRequest
            {
                TeamFolderAsTeamFolderName = gax::GaxPreconditions.CheckNotNull(teamFolder, nameof(teamFolder)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryTeamFolderContentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all TeamFolders in a given location that the caller has access to
        /// and match the provided filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="SearchTeamFoldersResponse.Types.TeamFolderSearchResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchTeamFoldersResponse, SearchTeamFoldersResponse.Types.TeamFolderSearchResult> SearchTeamFolders(SearchTeamFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all TeamFolders in a given location that the caller has access to
        /// and match the provided filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchTeamFoldersResponse.Types.TeamFolderSearchResult"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchTeamFoldersResponse, SearchTeamFoldersResponse.Types.TeamFolderSearchResult> SearchTeamFoldersAsync(SearchTeamFoldersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(GetFolderRequest request, st::CancellationToken cancellationToken) =>
            GetFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolder(new GetFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderAsync(new GetFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(string name, st::CancellationToken cancellationToken) =>
            GetFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder GetFolder(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolder(new GetFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFolderAsync(new GetFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> GetFolderAsync(FolderName name, st::CancellationToken cancellationToken) =>
            GetFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Folder in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder CreateFolder(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Folder in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Folder in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(CreateFolderRequest request, st::CancellationToken cancellationToken) =>
            CreateFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Folder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the Folder. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="folder">
        /// Required. The Folder to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder CreateFolder(string parent, Folder folder, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolder(new CreateFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
            }, callSettings);

        /// <summary>
        /// Creates a new Folder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the Folder. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="folder">
        /// Required. The Folder to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(string parent, Folder folder, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolderAsync(new CreateFolderRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
            }, callSettings);

        /// <summary>
        /// Creates a new Folder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the Folder. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="folder">
        /// Required. The Folder to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(string parent, Folder folder, st::CancellationToken cancellationToken) =>
            CreateFolderAsync(parent, folder, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Folder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the Folder. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="folder">
        /// Required. The Folder to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder CreateFolder(gagr::LocationName parent, Folder folder, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolder(new CreateFolderRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
            }, callSettings);

        /// <summary>
        /// Creates a new Folder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the Folder. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="folder">
        /// Required. The Folder to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(gagr::LocationName parent, Folder folder, gaxgrpc::CallSettings callSettings = null) =>
            CreateFolderAsync(new CreateFolderRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
            }, callSettings);

        /// <summary>
        /// Creates a new Folder in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the Folder. Must be in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="folder">
        /// Required. The Folder to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> CreateFolderAsync(gagr::LocationName parent, Folder folder, st::CancellationToken cancellationToken) =>
            CreateFolderAsync(parent, folder, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder UpdateFolder(UpdateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> UpdateFolderAsync(UpdateFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> UpdateFolderAsync(UpdateFolderRequest request, st::CancellationToken cancellationToken) =>
            UpdateFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single Folder.
        /// </summary>
        /// <param name="folder">
        /// Required. The updated Folder.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the Folder. If left unset,
        /// all fields that can be updated, will be updated. A few fields cannot be
        /// updated and will be ignored if specified in the update_mask (e.g.
        /// parent_name, team_folder_name).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Folder UpdateFolder(Folder folder, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFolder(new UpdateFolderRequest
            {
                UpdateMask = updateMask,
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
            }, callSettings);

        /// <summary>
        /// Updates a single Folder.
        /// </summary>
        /// <param name="folder">
        /// Required. The updated Folder.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the Folder. If left unset,
        /// all fields that can be updated, will be updated. A few fields cannot be
        /// updated and will be ignored if specified in the update_mask (e.g.
        /// parent_name, team_folder_name).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> UpdateFolderAsync(Folder folder, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFolderAsync(new UpdateFolderRequest
            {
                UpdateMask = updateMask,
                Folder = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
            }, callSettings);

        /// <summary>
        /// Updates a single Folder.
        /// </summary>
        /// <param name="folder">
        /// Required. The updated Folder.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the Folder. If left unset,
        /// all fields that can be updated, will be updated. A few fields cannot be
        /// updated and will be ignored if specified in the update_mask (e.g.
        /// parent_name, team_folder_name).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Folder> UpdateFolderAsync(Folder folder, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFolderAsync(folder, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFolder(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(DeleteFolderRequest request, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFolder(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolder(new DeleteFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolderAsync(new DeleteFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFolder(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolder(new DeleteFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(FolderName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFolderAsync(new DeleteFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Folder.
        /// </summary>
        /// <param name="name">
        /// Required. The Folder's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFolderAsync(FolderName name, st::CancellationToken cancellationToken) =>
            DeleteFolderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a given Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="QueryFolderContentsResponse.Types.FolderContentsEntry"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<QueryFolderContentsResponse, QueryFolderContentsResponse.Types.FolderContentsEntry> QueryFolderContents(QueryFolderContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a given Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="QueryFolderContentsResponse.Types.FolderContentsEntry"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<QueryFolderContentsResponse, QueryFolderContentsResponse.Types.FolderContentsEntry> QueryFolderContentsAsync(QueryFolderContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a given Folder.
        /// </summary>
        /// <param name="folder">
        /// Required. Name of the folder whose contents to list.
        /// Format: projects/*/locations/*/folders/*
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
        /// <returns>
        /// A pageable sequence of <see cref="QueryFolderContentsResponse.Types.FolderContentsEntry"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<QueryFolderContentsResponse, QueryFolderContentsResponse.Types.FolderContentsEntry> QueryFolderContents(string folder, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryFolderContentsRequest request = new QueryFolderContentsRequest
            {
                Folder = gax::GaxPreconditions.CheckNotNullOrEmpty(folder, nameof(folder)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryFolderContents(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given Folder.
        /// </summary>
        /// <param name="folder">
        /// Required. Name of the folder whose contents to list.
        /// Format: projects/*/locations/*/folders/*
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="QueryFolderContentsResponse.Types.FolderContentsEntry"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<QueryFolderContentsResponse, QueryFolderContentsResponse.Types.FolderContentsEntry> QueryFolderContentsAsync(string folder, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryFolderContentsRequest request = new QueryFolderContentsRequest
            {
                Folder = gax::GaxPreconditions.CheckNotNullOrEmpty(folder, nameof(folder)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryFolderContentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given Folder.
        /// </summary>
        /// <param name="folder">
        /// Required. Name of the folder whose contents to list.
        /// Format: projects/*/locations/*/folders/*
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
        /// <returns>
        /// A pageable sequence of <see cref="QueryFolderContentsResponse.Types.FolderContentsEntry"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<QueryFolderContentsResponse, QueryFolderContentsResponse.Types.FolderContentsEntry> QueryFolderContents(FolderName folder, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryFolderContentsRequest request = new QueryFolderContentsRequest
            {
                FolderAsFolderName = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryFolderContents(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given Folder.
        /// </summary>
        /// <param name="folder">
        /// Required. Name of the folder whose contents to list.
        /// Format: projects/*/locations/*/folders/*
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="QueryFolderContentsResponse.Types.FolderContentsEntry"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<QueryFolderContentsResponse, QueryFolderContentsResponse.Types.FolderContentsEntry> QueryFolderContentsAsync(FolderName folder, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryFolderContentsRequest request = new QueryFolderContentsRequest
            {
                FolderAsFolderName = gax::GaxPreconditions.CheckNotNull(folder, nameof(folder)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryFolderContentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a caller's root folder in a given location.
        /// The root folder contains all resources that are created by the user and not
        /// contained in any other folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="QueryUserRootContentsResponse.Types.RootContentsEntry"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<QueryUserRootContentsResponse, QueryUserRootContentsResponse.Types.RootContentsEntry> QueryUserRootContents(QueryUserRootContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a caller's root folder in a given location.
        /// The root folder contains all resources that are created by the user and not
        /// contained in any other folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="QueryUserRootContentsResponse.Types.RootContentsEntry"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<QueryUserRootContentsResponse, QueryUserRootContentsResponse.Types.RootContentsEntry> QueryUserRootContentsAsync(QueryUserRootContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a caller's root folder in a given location.
        /// The root folder contains all resources that are created by the user and not
        /// contained in any other folder.
        /// </summary>
        /// <param name="location">
        /// Required. Location of the user root folder whose contents to list.
        /// Format: projects/*/locations/*
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
        /// <returns>
        /// A pageable sequence of <see cref="QueryUserRootContentsResponse.Types.RootContentsEntry"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<QueryUserRootContentsResponse, QueryUserRootContentsResponse.Types.RootContentsEntry> QueryUserRootContents(string location, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryUserRootContentsRequest request = new QueryUserRootContentsRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryUserRootContents(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a caller's root folder in a given location.
        /// The root folder contains all resources that are created by the user and not
        /// contained in any other folder.
        /// </summary>
        /// <param name="location">
        /// Required. Location of the user root folder whose contents to list.
        /// Format: projects/*/locations/*
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="QueryUserRootContentsResponse.Types.RootContentsEntry"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<QueryUserRootContentsResponse, QueryUserRootContentsResponse.Types.RootContentsEntry> QueryUserRootContentsAsync(string location, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryUserRootContentsRequest request = new QueryUserRootContentsRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryUserRootContentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a caller's root folder in a given location.
        /// The root folder contains all resources that are created by the user and not
        /// contained in any other folder.
        /// </summary>
        /// <param name="location">
        /// Required. Location of the user root folder whose contents to list.
        /// Format: projects/*/locations/*
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
        /// <returns>
        /// A pageable sequence of <see cref="QueryUserRootContentsResponse.Types.RootContentsEntry"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<QueryUserRootContentsResponse, QueryUserRootContentsResponse.Types.RootContentsEntry> QueryUserRootContents(gagr::LocationName location, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryUserRootContentsRequest request = new QueryUserRootContentsRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryUserRootContents(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a caller's root folder in a given location.
        /// The root folder contains all resources that are created by the user and not
        /// contained in any other folder.
        /// </summary>
        /// <param name="location">
        /// Required. Location of the user root folder whose contents to list.
        /// Format: projects/*/locations/*
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="QueryUserRootContentsResponse.Types.RootContentsEntry"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<QueryUserRootContentsResponse, QueryUserRootContentsResponse.Types.RootContentsEntry> QueryUserRootContentsAsync(gagr::LocationName location, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryUserRootContentsRequest request = new QueryUserRootContentsRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryUserRootContentsAsync(request, callSettings);
        }

        /// <summary>
        /// Moves a Folder to a new Folder, TeamFolder, or the root location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, MoveFolderMetadata> MoveFolder(MoveFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a Folder to a new Folder, TeamFolder, or the root location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveFolderMetadata>> MoveFolderAsync(MoveFolderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a Folder to a new Folder, TeamFolder, or the root location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveFolderMetadata>> MoveFolderAsync(MoveFolderRequest request, st::CancellationToken cancellationToken) =>
            MoveFolderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>MoveFolder</c>.</summary>
        public virtual lro::OperationsClient MoveFolderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>MoveFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, MoveFolderMetadata> PollOnceMoveFolder(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, MoveFolderMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveFolderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>MoveFolder</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveFolderMetadata>> PollOnceMoveFolderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, MoveFolderMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveFolderOperationsClient, callSettings);

        /// <summary>
        /// Moves a Folder to a new Folder, TeamFolder, or the root location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Folder to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// Folder to. Can be in the format of: "" to move into the root User folder,
        /// `projects/*/locations/*/folders/*`, `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, MoveFolderMetadata> MoveFolder(string name, string destinationContainingFolder, gaxgrpc::CallSettings callSettings = null) =>
            MoveFolder(new MoveFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationContainingFolder = destinationContainingFolder ?? "",
            }, callSettings);

        /// <summary>
        /// Moves a Folder to a new Folder, TeamFolder, or the root location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Folder to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// Folder to. Can be in the format of: "" to move into the root User folder,
        /// `projects/*/locations/*/folders/*`, `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveFolderMetadata>> MoveFolderAsync(string name, string destinationContainingFolder, gaxgrpc::CallSettings callSettings = null) =>
            MoveFolderAsync(new MoveFolderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationContainingFolder = destinationContainingFolder ?? "",
            }, callSettings);

        /// <summary>
        /// Moves a Folder to a new Folder, TeamFolder, or the root location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Folder to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// Folder to. Can be in the format of: "" to move into the root User folder,
        /// `projects/*/locations/*/folders/*`, `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveFolderMetadata>> MoveFolderAsync(string name, string destinationContainingFolder, st::CancellationToken cancellationToken) =>
            MoveFolderAsync(name, destinationContainingFolder, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a Folder to a new Folder, TeamFolder, or the root location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Folder to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// Folder to. Can be in the format of: "" to move into the root User folder,
        /// `projects/*/locations/*/folders/*`, `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, MoveFolderMetadata> MoveFolder(FolderName name, string destinationContainingFolder, gaxgrpc::CallSettings callSettings = null) =>
            MoveFolder(new MoveFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationContainingFolder = destinationContainingFolder ?? "",
            }, callSettings);

        /// <summary>
        /// Moves a Folder to a new Folder, TeamFolder, or the root location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Folder to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// Folder to. Can be in the format of: "" to move into the root User folder,
        /// `projects/*/locations/*/folders/*`, `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveFolderMetadata>> MoveFolderAsync(FolderName name, string destinationContainingFolder, gaxgrpc::CallSettings callSettings = null) =>
            MoveFolderAsync(new MoveFolderRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationContainingFolder = destinationContainingFolder ?? "",
            }, callSettings);

        /// <summary>
        /// Moves a Folder to a new Folder, TeamFolder, or the root location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Folder to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// Folder to. Can be in the format of: "" to move into the root User folder,
        /// `projects/*/locations/*/folders/*`, `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveFolderMetadata>> MoveFolderAsync(FolderName name, string destinationContainingFolder, st::CancellationToken cancellationToken) =>
            MoveFolderAsync(name, destinationContainingFolder, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// **Note:** *This method can return repositories not shown in the [Dataform
        /// UI](https://console.cloud.google.com/bigquery/dataform)*.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRepositoriesResponse, Repository> ListRepositories(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// **Note:** *This method can return repositories not shown in the [Dataform
        /// UI](https://console.cloud.google.com/bigquery/dataform)*.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Repository"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRepositoriesResponse, Repository> ListRepositoriesAsync(ListRepositoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// **Note:** *This method can return repositories not shown in the [Dataform
        /// UI](https://console.cloud.google.com/bigquery/dataform)*.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to list repositories. Must be in the format
        /// `projects/*/locations/*`.
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
        /// Lists Repositories in a given project and location.
        /// 
        /// **Note:** *This method can return repositories not shown in the [Dataform
        /// UI](https://console.cloud.google.com/bigquery/dataform)*.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to list repositories. Must be in the format
        /// `projects/*/locations/*`.
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
        /// Lists Repositories in a given project and location.
        /// 
        /// **Note:** *This method can return repositories not shown in the [Dataform
        /// UI](https://console.cloud.google.com/bigquery/dataform)*.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to list repositories. Must be in the format
        /// `projects/*/locations/*`.
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
        /// Lists Repositories in a given project and location.
        /// 
        /// **Note:** *This method can return repositories not shown in the [Dataform
        /// UI](https://console.cloud.google.com/bigquery/dataform)*.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to list repositories. Must be in the format
        /// `projects/*/locations/*`.
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
        /// Fetches a single Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepository(new GetRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepositoryAsync(new GetRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository GetRepository(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepository(new GetRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRepositoryAsync(new GetRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> GetRepositoryAsync(RepositoryName name, st::CancellationToken cancellationToken) =>
            GetRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Repository in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository CreateRepository(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Repository in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> CreateRepositoryAsync(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Repository in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> CreateRepositoryAsync(CreateRepositoryRequest request, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Repository in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the repository. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository CreateRepository(string parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepository(new CreateRepositoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Repository in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the repository. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> CreateRepositoryAsync(string parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepositoryAsync(new CreateRepositoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Repository in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the repository. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> CreateRepositoryAsync(string parent, Repository repository, string repositoryId, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(parent, repository, repositoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Repository in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the repository. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository CreateRepository(gagr::LocationName parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepository(new CreateRepositoryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Repository in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the repository. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> CreateRepositoryAsync(gagr::LocationName parent, Repository repository, string repositoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRepositoryAsync(new CreateRepositoryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
                RepositoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Repository in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location in which to create the repository. Must be in the
        /// format `projects/*/locations/*`.
        /// </param>
        /// <param name="repository">
        /// Required. The repository to create.
        /// </param>
        /// <param name="repositoryId">
        /// Required. The ID to use for the repository, which will become the final
        /// component of the repository's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> CreateRepositoryAsync(gagr::LocationName parent, Repository repository, string repositoryId, st::CancellationToken cancellationToken) =>
            CreateRepositoryAsync(parent, repository, repositoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single Repository.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository UpdateRepository(UpdateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Repository.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> UpdateRepositoryAsync(UpdateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Repository.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> UpdateRepositoryAsync(UpdateRepositoryRequest request, st::CancellationToken cancellationToken) =>
            UpdateRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single Repository.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="repository">
        /// Required. The repository to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the repository. If left
        /// unset, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Repository UpdateRepository(Repository repository, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRepository(new UpdateRepositoryRequest
            {
                UpdateMask = updateMask,
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Updates a single Repository.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="repository">
        /// Required. The repository to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the repository. If left
        /// unset, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> UpdateRepositoryAsync(Repository repository, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRepositoryAsync(new UpdateRepositoryRequest
            {
                UpdateMask = updateMask,
                Repository = gax::GaxPreconditions.CheckNotNull(repository, nameof(repository)),
            }, callSettings);

        /// <summary>
        /// Updates a single Repository.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="repository">
        /// Required. The repository to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the repository. If left
        /// unset, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Repository> UpdateRepositoryAsync(Repository repository, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRepositoryAsync(repository, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRepository(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRepositoryAsync(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRepositoryAsync(DeleteRepositoryRequest request, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRepository(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepository(new DeleteRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRepositoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepositoryAsync(new DeleteRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRepositoryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRepository(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepository(new DeleteRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRepositoryAsync(RepositoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRepositoryAsync(new DeleteRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Repository.
        /// </summary>
        /// <param name="name">
        /// Required. The repository's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRepositoryAsync(RepositoryName name, st::CancellationToken cancellationToken) =>
            DeleteRepositoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a Repository to a new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, MoveRepositoryMetadata> MoveRepository(MoveRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a Repository to a new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveRepositoryMetadata>> MoveRepositoryAsync(MoveRepositoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a Repository to a new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveRepositoryMetadata>> MoveRepositoryAsync(MoveRepositoryRequest request, st::CancellationToken cancellationToken) =>
            MoveRepositoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>MoveRepository</c>.</summary>
        public virtual lro::OperationsClient MoveRepositoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>MoveRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, MoveRepositoryMetadata> PollOnceMoveRepository(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, MoveRepositoryMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>MoveRepository</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveRepositoryMetadata>> PollOnceMoveRepositoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, MoveRepositoryMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveRepositoryOperationsClient, callSettings);

        /// <summary>
        /// Moves a Repository to a new location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the repository to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// repository to. Can be in the format of: "" to move into the root User
        /// folder, `projects/*/locations/*/folders/*`,
        /// `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, MoveRepositoryMetadata> MoveRepository(string name, string destinationContainingFolder, gaxgrpc::CallSettings callSettings = null) =>
            MoveRepository(new MoveRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationContainingFolder = destinationContainingFolder ?? "",
            }, callSettings);

        /// <summary>
        /// Moves a Repository to a new location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the repository to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// repository to. Can be in the format of: "" to move into the root User
        /// folder, `projects/*/locations/*/folders/*`,
        /// `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveRepositoryMetadata>> MoveRepositoryAsync(string name, string destinationContainingFolder, gaxgrpc::CallSettings callSettings = null) =>
            MoveRepositoryAsync(new MoveRepositoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DestinationContainingFolder = destinationContainingFolder ?? "",
            }, callSettings);

        /// <summary>
        /// Moves a Repository to a new location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the repository to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// repository to. Can be in the format of: "" to move into the root User
        /// folder, `projects/*/locations/*/folders/*`,
        /// `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveRepositoryMetadata>> MoveRepositoryAsync(string name, string destinationContainingFolder, st::CancellationToken cancellationToken) =>
            MoveRepositoryAsync(name, destinationContainingFolder, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a Repository to a new location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the repository to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// repository to. Can be in the format of: "" to move into the root User
        /// folder, `projects/*/locations/*/folders/*`,
        /// `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, MoveRepositoryMetadata> MoveRepository(RepositoryName name, string destinationContainingFolder, gaxgrpc::CallSettings callSettings = null) =>
            MoveRepository(new MoveRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationContainingFolder = destinationContainingFolder ?? "",
            }, callSettings);

        /// <summary>
        /// Moves a Repository to a new location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the repository to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// repository to. Can be in the format of: "" to move into the root User
        /// folder, `projects/*/locations/*/folders/*`,
        /// `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveRepositoryMetadata>> MoveRepositoryAsync(RepositoryName name, string destinationContainingFolder, gaxgrpc::CallSettings callSettings = null) =>
            MoveRepositoryAsync(new MoveRepositoryRequest
            {
                RepositoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DestinationContainingFolder = destinationContainingFolder ?? "",
            }, callSettings);

        /// <summary>
        /// Moves a Repository to a new location.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the repository to move.
        /// </param>
        /// <param name="destinationContainingFolder">
        /// Optional. The name of the Folder, TeamFolder, or root location to move the
        /// repository to. Can be in the format of: "" to move into the root User
        /// folder, `projects/*/locations/*/folders/*`,
        /// `projects/*/locations/*/teamFolders/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, MoveRepositoryMetadata>> MoveRepositoryAsync(RepositoryName name, string destinationContainingFolder, st::CancellationToken cancellationToken) =>
            MoveRepositoryAsync(name, destinationContainingFolder, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies a Git commit to a Repository. The Repository must not have a value
        /// for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitRepositoryChangesResponse CommitRepositoryChanges(CommitRepositoryChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies a Git commit to a Repository. The Repository must not have a value
        /// for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitRepositoryChangesResponse> CommitRepositoryChangesAsync(CommitRepositoryChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies a Git commit to a Repository. The Repository must not have a value
        /// for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitRepositoryChangesResponse> CommitRepositoryChangesAsync(CommitRepositoryChangesRequest request, st::CancellationToken cancellationToken) =>
            CommitRepositoryChangesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a file (inside a Repository). The Repository
        /// must not have a value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadRepositoryFileResponse ReadRepositoryFile(ReadRepositoryFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a file (inside a Repository). The Repository
        /// must not have a value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadRepositoryFileResponse> ReadRepositoryFileAsync(ReadRepositoryFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a file (inside a Repository). The Repository
        /// must not have a value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadRepositoryFileResponse> ReadRepositoryFileAsync(ReadRepositoryFileRequest request, st::CancellationToken cancellationToken) =>
            ReadRepositoryFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a given Repository directory. The Repository must
        /// not have a value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DirectoryEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryRepositoryDirectoryContentsResponse, DirectoryEntry> QueryRepositoryDirectoryContents(QueryRepositoryDirectoryContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a given Repository directory. The Repository must
        /// not have a value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DirectoryEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryRepositoryDirectoryContentsResponse, DirectoryEntry> QueryRepositoryDirectoryContentsAsync(QueryRepositoryDirectoryContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a Repository's history of commits.  The Repository must not have a
        /// value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CommitLogEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchRepositoryHistoryResponse, CommitLogEntry> FetchRepositoryHistory(FetchRepositoryHistoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a Repository's history of commits.  The Repository must not have a
        /// value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CommitLogEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchRepositoryHistoryResponse, CommitLogEntry> FetchRepositoryHistoryAsync(FetchRepositoryHistoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Computes a Repository's Git access token status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeRepositoryAccessTokenStatusResponse ComputeRepositoryAccessTokenStatus(ComputeRepositoryAccessTokenStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Computes a Repository's Git access token status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeRepositoryAccessTokenStatusResponse> ComputeRepositoryAccessTokenStatusAsync(ComputeRepositoryAccessTokenStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Computes a Repository's Git access token status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeRepositoryAccessTokenStatusResponse> ComputeRepositoryAccessTokenStatusAsync(ComputeRepositoryAccessTokenStatusRequest request, st::CancellationToken cancellationToken) =>
            ComputeRepositoryAccessTokenStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a Repository's remote branches.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchRemoteBranchesResponse FetchRemoteBranches(FetchRemoteBranchesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a Repository's remote branches.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchRemoteBranchesResponse> FetchRemoteBranchesAsync(FetchRemoteBranchesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a Repository's remote branches.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchRemoteBranchesResponse> FetchRemoteBranchesAsync(FetchRemoteBranchesRequest request, st::CancellationToken cancellationToken) =>
            FetchRemoteBranchesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Workspaces in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workspace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkspacesResponse, Workspace> ListWorkspaces(ListWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Workspaces in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workspace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkspacesResponse, Workspace> ListWorkspacesAsync(ListWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Workspaces in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list workspaces. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable sequence of <see cref="Workspace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkspacesResponse, Workspace> ListWorkspaces(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkspacesRequest request = new ListWorkspacesRequest
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
            return ListWorkspaces(request, callSettings);
        }

        /// <summary>
        /// Lists Workspaces in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list workspaces. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workspace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkspacesResponse, Workspace> ListWorkspacesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkspacesRequest request = new ListWorkspacesRequest
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
            return ListWorkspacesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Workspaces in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list workspaces. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable sequence of <see cref="Workspace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkspacesResponse, Workspace> ListWorkspaces(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkspacesRequest request = new ListWorkspacesRequest
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
            return ListWorkspaces(request, callSettings);
        }

        /// <summary>
        /// Lists Workspaces in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list workspaces. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workspace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkspacesResponse, Workspace> ListWorkspacesAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkspacesRequest request = new ListWorkspacesRequest
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
            return ListWorkspacesAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workspace GetWorkspace(GetWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(GetWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(GetWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            GetWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workspace GetWorkspace(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkspace(new GetWorkspaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkspaceAsync(new GetWorkspaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkspaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workspace GetWorkspace(WorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkspace(new GetWorkspaceRequest
            {
                WorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(WorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkspaceAsync(new GetWorkspaceRequest
            {
                WorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> GetWorkspaceAsync(WorkspaceName name, st::CancellationToken cancellationToken) =>
            GetWorkspaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Workspace in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workspace CreateWorkspace(CreateWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Workspace in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> CreateWorkspaceAsync(CreateWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Workspace in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> CreateWorkspaceAsync(CreateWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Workspace in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workspace. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workspace">
        /// Required. The workspace to create.
        /// </param>
        /// <param name="workspaceId">
        /// Required. The ID to use for the workspace, which will become the final
        /// component of the workspace's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workspace CreateWorkspace(string parent, Workspace workspace, string workspaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkspace(new CreateWorkspaceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Workspace = gax::GaxPreconditions.CheckNotNull(workspace, nameof(workspace)),
                WorkspaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Workspace in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workspace. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workspace">
        /// Required. The workspace to create.
        /// </param>
        /// <param name="workspaceId">
        /// Required. The ID to use for the workspace, which will become the final
        /// component of the workspace's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> CreateWorkspaceAsync(string parent, Workspace workspace, string workspaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkspaceAsync(new CreateWorkspaceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Workspace = gax::GaxPreconditions.CheckNotNull(workspace, nameof(workspace)),
                WorkspaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Workspace in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workspace. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workspace">
        /// Required. The workspace to create.
        /// </param>
        /// <param name="workspaceId">
        /// Required. The ID to use for the workspace, which will become the final
        /// component of the workspace's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> CreateWorkspaceAsync(string parent, Workspace workspace, string workspaceId, st::CancellationToken cancellationToken) =>
            CreateWorkspaceAsync(parent, workspace, workspaceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Workspace in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workspace. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workspace">
        /// Required. The workspace to create.
        /// </param>
        /// <param name="workspaceId">
        /// Required. The ID to use for the workspace, which will become the final
        /// component of the workspace's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workspace CreateWorkspace(RepositoryName parent, Workspace workspace, string workspaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkspace(new CreateWorkspaceRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Workspace = gax::GaxPreconditions.CheckNotNull(workspace, nameof(workspace)),
                WorkspaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Workspace in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workspace. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workspace">
        /// Required. The workspace to create.
        /// </param>
        /// <param name="workspaceId">
        /// Required. The ID to use for the workspace, which will become the final
        /// component of the workspace's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> CreateWorkspaceAsync(RepositoryName parent, Workspace workspace, string workspaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkspaceAsync(new CreateWorkspaceRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Workspace = gax::GaxPreconditions.CheckNotNull(workspace, nameof(workspace)),
                WorkspaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(workspaceId, nameof(workspaceId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Workspace in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workspace. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workspace">
        /// Required. The workspace to create.
        /// </param>
        /// <param name="workspaceId">
        /// Required. The ID to use for the workspace, which will become the final
        /// component of the workspace's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workspace> CreateWorkspaceAsync(RepositoryName parent, Workspace workspace, string workspaceId, st::CancellationToken cancellationToken) =>
            CreateWorkspaceAsync(parent, workspace, workspaceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkspace(DeleteWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkspaceAsync(DeleteWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkspaceAsync(DeleteWorkspaceRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkspace(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkspace(new DeleteWorkspaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkspaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkspaceAsync(new DeleteWorkspaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace resource's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkspaceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkspaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkspace(WorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkspace(new DeleteWorkspaceRequest
            {
                WorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkspaceAsync(WorkspaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkspaceAsync(new DeleteWorkspaceRequest
            {
                WorkspaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Workspace.
        /// </summary>
        /// <param name="name">
        /// Required. The workspace resource's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkspaceAsync(WorkspaceName name, st::CancellationToken cancellationToken) =>
            DeleteWorkspaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Installs dependency NPM packages (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstallNpmPackagesResponse InstallNpmPackages(InstallNpmPackagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Installs dependency NPM packages (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallNpmPackagesResponse> InstallNpmPackagesAsync(InstallNpmPackagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Installs dependency NPM packages (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallNpmPackagesResponse> InstallNpmPackagesAsync(InstallNpmPackagesRequest request, st::CancellationToken cancellationToken) =>
            InstallNpmPackagesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pulls Git commits from the Repository's remote into a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PullGitCommitsResponse PullGitCommits(PullGitCommitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pulls Git commits from the Repository's remote into a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullGitCommitsResponse> PullGitCommitsAsync(PullGitCommitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pulls Git commits from the Repository's remote into a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PullGitCommitsResponse> PullGitCommitsAsync(PullGitCommitsRequest request, st::CancellationToken cancellationToken) =>
            PullGitCommitsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pushes Git commits from a Workspace to the Repository's remote.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PushGitCommitsResponse PushGitCommits(PushGitCommitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pushes Git commits from a Workspace to the Repository's remote.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PushGitCommitsResponse> PushGitCommitsAsync(PushGitCommitsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pushes Git commits from a Workspace to the Repository's remote.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PushGitCommitsResponse> PushGitCommitsAsync(PushGitCommitsRequest request, st::CancellationToken cancellationToken) =>
            PushGitCommitsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches Git statuses for the files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchFileGitStatusesResponse FetchFileGitStatuses(FetchFileGitStatusesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches Git statuses for the files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchFileGitStatusesResponse> FetchFileGitStatusesAsync(FetchFileGitStatusesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches Git statuses for the files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchFileGitStatusesResponse> FetchFileGitStatusesAsync(FetchFileGitStatusesRequest request, st::CancellationToken cancellationToken) =>
            FetchFileGitStatusesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches Git ahead/behind against a remote branch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchGitAheadBehindResponse FetchGitAheadBehind(FetchGitAheadBehindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches Git ahead/behind against a remote branch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitAheadBehindResponse> FetchGitAheadBehindAsync(FetchGitAheadBehindRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches Git ahead/behind against a remote branch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchGitAheadBehindResponse> FetchGitAheadBehindAsync(FetchGitAheadBehindRequest request, st::CancellationToken cancellationToken) =>
            FetchGitAheadBehindAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies a Git commit for uncommitted files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitWorkspaceChangesResponse CommitWorkspaceChanges(CommitWorkspaceChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies a Git commit for uncommitted files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitWorkspaceChangesResponse> CommitWorkspaceChangesAsync(CommitWorkspaceChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies a Git commit for uncommitted files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitWorkspaceChangesResponse> CommitWorkspaceChangesAsync(CommitWorkspaceChangesRequest request, st::CancellationToken cancellationToken) =>
            CommitWorkspaceChangesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a Git reset for uncommitted files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResetWorkspaceChangesResponse ResetWorkspaceChanges(ResetWorkspaceChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a Git reset for uncommitted files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResetWorkspaceChangesResponse> ResetWorkspaceChangesAsync(ResetWorkspaceChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a Git reset for uncommitted files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResetWorkspaceChangesResponse> ResetWorkspaceChangesAsync(ResetWorkspaceChangesRequest request, st::CancellationToken cancellationToken) =>
            ResetWorkspaceChangesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches Git diff for an uncommitted file in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchFileDiffResponse FetchFileDiff(FetchFileDiffRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches Git diff for an uncommitted file in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchFileDiffResponse> FetchFileDiffAsync(FetchFileDiffRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches Git diff for an uncommitted file in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchFileDiffResponse> FetchFileDiffAsync(FetchFileDiffRequest request, st::CancellationToken cancellationToken) =>
            FetchFileDiffAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a given Workspace directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DirectoryEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryDirectoryContentsResponse, DirectoryEntry> QueryDirectoryContents(QueryDirectoryContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a given Workspace directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DirectoryEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryDirectoryContentsResponse, DirectoryEntry> QueryDirectoryContentsAsync(QueryDirectoryContentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds the contents of a given Workspace directory by filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchFilesResponse, SearchResult> SearchFiles(SearchFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds the contents of a given Workspace directory by filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchFilesResponse, SearchResult> SearchFilesAsync(SearchFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a directory inside a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MakeDirectoryResponse MakeDirectory(MakeDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a directory inside a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MakeDirectoryResponse> MakeDirectoryAsync(MakeDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a directory inside a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MakeDirectoryResponse> MakeDirectoryAsync(MakeDirectoryRequest request, st::CancellationToken cancellationToken) =>
            MakeDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a directory (inside a Workspace) and all of its contents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveDirectoryResponse RemoveDirectory(RemoveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a directory (inside a Workspace) and all of its contents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveDirectoryResponse> RemoveDirectoryAsync(RemoveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a directory (inside a Workspace) and all of its contents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveDirectoryResponse> RemoveDirectoryAsync(RemoveDirectoryRequest request, st::CancellationToken cancellationToken) =>
            RemoveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a directory (inside a Workspace), and all of its contents, to a new
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MoveDirectoryResponse MoveDirectory(MoveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a directory (inside a Workspace), and all of its contents, to a new
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MoveDirectoryResponse> MoveDirectoryAsync(MoveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a directory (inside a Workspace), and all of its contents, to a new
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MoveDirectoryResponse> MoveDirectoryAsync(MoveDirectoryRequest request, st::CancellationToken cancellationToken) =>
            MoveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the contents of a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadFileResponse ReadFile(ReadFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadFileResponse> ReadFileAsync(ReadFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the contents of a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadFileResponse> ReadFileAsync(ReadFileRequest request, st::CancellationToken cancellationToken) =>
            ReadFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveFileResponse RemoveFile(RemoveFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveFileResponse> RemoveFileAsync(RemoveFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveFileResponse> RemoveFileAsync(RemoveFileRequest request, st::CancellationToken cancellationToken) =>
            RemoveFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a file (inside a Workspace) to a new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MoveFileResponse MoveFile(MoveFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a file (inside a Workspace) to a new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MoveFileResponse> MoveFileAsync(MoveFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a file (inside a Workspace) to a new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MoveFileResponse> MoveFileAsync(MoveFileRequest request, st::CancellationToken cancellationToken) =>
            MoveFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes to a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteFileResponse WriteFile(WriteFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes to a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteFileResponse> WriteFileAsync(WriteFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes to a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteFileResponse> WriteFileAsync(WriteFileRequest request, st::CancellationToken cancellationToken) =>
            WriteFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ReleaseConfigs in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReleaseConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleaseConfigsResponse, ReleaseConfig> ListReleaseConfigs(ListReleaseConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReleaseConfigs in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReleaseConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleaseConfigsResponse, ReleaseConfig> ListReleaseConfigsAsync(ListReleaseConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReleaseConfigs in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list release configs. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable sequence of <see cref="ReleaseConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleaseConfigsResponse, ReleaseConfig> ListReleaseConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleaseConfigsRequest request = new ListReleaseConfigsRequest
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
            return ListReleaseConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ReleaseConfigs in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list release configs. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReleaseConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleaseConfigsResponse, ReleaseConfig> ListReleaseConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleaseConfigsRequest request = new ListReleaseConfigsRequest
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
            return ListReleaseConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ReleaseConfigs in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list release configs. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable sequence of <see cref="ReleaseConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleaseConfigsResponse, ReleaseConfig> ListReleaseConfigs(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleaseConfigsRequest request = new ListReleaseConfigsRequest
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
            return ListReleaseConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ReleaseConfigs in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list release configs. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReleaseConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleaseConfigsResponse, ReleaseConfig> ListReleaseConfigsAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleaseConfigsRequest request = new ListReleaseConfigsRequest
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
            return ListReleaseConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single ReleaseConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReleaseConfig GetReleaseConfig(GetReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single ReleaseConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> GetReleaseConfigAsync(GetReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single ReleaseConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> GetReleaseConfigAsync(GetReleaseConfigRequest request, st::CancellationToken cancellationToken) =>
            GetReleaseConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReleaseConfig GetReleaseConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReleaseConfig(new GetReleaseConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> GetReleaseConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReleaseConfigAsync(new GetReleaseConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> GetReleaseConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetReleaseConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReleaseConfig GetReleaseConfig(ReleaseConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReleaseConfig(new GetReleaseConfigRequest
            {
                ReleaseConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> GetReleaseConfigAsync(ReleaseConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReleaseConfigAsync(new GetReleaseConfigRequest
            {
                ReleaseConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> GetReleaseConfigAsync(ReleaseConfigName name, st::CancellationToken cancellationToken) =>
            GetReleaseConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ReleaseConfig in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReleaseConfig CreateReleaseConfig(CreateReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ReleaseConfig in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> CreateReleaseConfigAsync(CreateReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ReleaseConfig in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> CreateReleaseConfigAsync(CreateReleaseConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateReleaseConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ReleaseConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the release config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="releaseConfig">
        /// Required. The release config to create.
        /// </param>
        /// <param name="releaseConfigId">
        /// Required. The ID to use for the release config, which will become the final
        /// component of the release config's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReleaseConfig CreateReleaseConfig(string parent, ReleaseConfig releaseConfig, string releaseConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReleaseConfig(new CreateReleaseConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReleaseConfig = gax::GaxPreconditions.CheckNotNull(releaseConfig, nameof(releaseConfig)),
                ReleaseConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseConfigId, nameof(releaseConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReleaseConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the release config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="releaseConfig">
        /// Required. The release config to create.
        /// </param>
        /// <param name="releaseConfigId">
        /// Required. The ID to use for the release config, which will become the final
        /// component of the release config's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> CreateReleaseConfigAsync(string parent, ReleaseConfig releaseConfig, string releaseConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReleaseConfigAsync(new CreateReleaseConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReleaseConfig = gax::GaxPreconditions.CheckNotNull(releaseConfig, nameof(releaseConfig)),
                ReleaseConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseConfigId, nameof(releaseConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReleaseConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the release config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="releaseConfig">
        /// Required. The release config to create.
        /// </param>
        /// <param name="releaseConfigId">
        /// Required. The ID to use for the release config, which will become the final
        /// component of the release config's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> CreateReleaseConfigAsync(string parent, ReleaseConfig releaseConfig, string releaseConfigId, st::CancellationToken cancellationToken) =>
            CreateReleaseConfigAsync(parent, releaseConfig, releaseConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ReleaseConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the release config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="releaseConfig">
        /// Required. The release config to create.
        /// </param>
        /// <param name="releaseConfigId">
        /// Required. The ID to use for the release config, which will become the final
        /// component of the release config's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReleaseConfig CreateReleaseConfig(RepositoryName parent, ReleaseConfig releaseConfig, string releaseConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReleaseConfig(new CreateReleaseConfigRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReleaseConfig = gax::GaxPreconditions.CheckNotNull(releaseConfig, nameof(releaseConfig)),
                ReleaseConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseConfigId, nameof(releaseConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReleaseConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the release config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="releaseConfig">
        /// Required. The release config to create.
        /// </param>
        /// <param name="releaseConfigId">
        /// Required. The ID to use for the release config, which will become the final
        /// component of the release config's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> CreateReleaseConfigAsync(RepositoryName parent, ReleaseConfig releaseConfig, string releaseConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReleaseConfigAsync(new CreateReleaseConfigRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReleaseConfig = gax::GaxPreconditions.CheckNotNull(releaseConfig, nameof(releaseConfig)),
                ReleaseConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseConfigId, nameof(releaseConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReleaseConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the release config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="releaseConfig">
        /// Required. The release config to create.
        /// </param>
        /// <param name="releaseConfigId">
        /// Required. The ID to use for the release config, which will become the final
        /// component of the release config's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> CreateReleaseConfigAsync(RepositoryName parent, ReleaseConfig releaseConfig, string releaseConfigId, st::CancellationToken cancellationToken) =>
            CreateReleaseConfigAsync(parent, releaseConfig, releaseConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single ReleaseConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReleaseConfig UpdateReleaseConfig(UpdateReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single ReleaseConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> UpdateReleaseConfigAsync(UpdateReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single ReleaseConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> UpdateReleaseConfigAsync(UpdateReleaseConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateReleaseConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single ReleaseConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="releaseConfig">
        /// Required. The release config to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the release config. If left
        /// unset, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReleaseConfig UpdateReleaseConfig(ReleaseConfig releaseConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReleaseConfig(new UpdateReleaseConfigRequest
            {
                UpdateMask = updateMask,
                ReleaseConfig = gax::GaxPreconditions.CheckNotNull(releaseConfig, nameof(releaseConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a single ReleaseConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="releaseConfig">
        /// Required. The release config to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the release config. If left
        /// unset, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> UpdateReleaseConfigAsync(ReleaseConfig releaseConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReleaseConfigAsync(new UpdateReleaseConfigRequest
            {
                UpdateMask = updateMask,
                ReleaseConfig = gax::GaxPreconditions.CheckNotNull(releaseConfig, nameof(releaseConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a single ReleaseConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="releaseConfig">
        /// Required. The release config to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the release config. If left
        /// unset, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReleaseConfig> UpdateReleaseConfigAsync(ReleaseConfig releaseConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReleaseConfigAsync(releaseConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ReleaseConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReleaseConfig(DeleteReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ReleaseConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseConfigAsync(DeleteReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ReleaseConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseConfigAsync(DeleteReleaseConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteReleaseConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReleaseConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReleaseConfig(new DeleteReleaseConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReleaseConfigAsync(new DeleteReleaseConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReleaseConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReleaseConfig(ReleaseConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReleaseConfig(new DeleteReleaseConfigRequest
            {
                ReleaseConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseConfigAsync(ReleaseConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReleaseConfigAsync(new DeleteReleaseConfigRequest
            {
                ReleaseConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReleaseConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The release config's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReleaseConfigAsync(ReleaseConfigName name, st::CancellationToken cancellationToken) =>
            DeleteReleaseConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CompilationResults in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CompilationResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompilationResultsResponse, CompilationResult> ListCompilationResults(ListCompilationResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CompilationResults in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CompilationResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompilationResultsResponse, CompilationResult> ListCompilationResultsAsync(ListCompilationResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CompilationResults in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list compilation results. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable sequence of <see cref="CompilationResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompilationResultsResponse, CompilationResult> ListCompilationResults(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompilationResultsRequest request = new ListCompilationResultsRequest
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
            return ListCompilationResults(request, callSettings);
        }

        /// <summary>
        /// Lists CompilationResults in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list compilation results. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CompilationResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompilationResultsResponse, CompilationResult> ListCompilationResultsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompilationResultsRequest request = new ListCompilationResultsRequest
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
            return ListCompilationResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists CompilationResults in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list compilation results. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable sequence of <see cref="CompilationResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompilationResultsResponse, CompilationResult> ListCompilationResults(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompilationResultsRequest request = new ListCompilationResultsRequest
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
            return ListCompilationResults(request, callSettings);
        }

        /// <summary>
        /// Lists CompilationResults in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list compilation results. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CompilationResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompilationResultsResponse, CompilationResult> ListCompilationResultsAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompilationResultsRequest request = new ListCompilationResultsRequest
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
            return ListCompilationResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single CompilationResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompilationResult GetCompilationResult(GetCompilationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single CompilationResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> GetCompilationResultAsync(GetCompilationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single CompilationResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> GetCompilationResultAsync(GetCompilationResultRequest request, st::CancellationToken cancellationToken) =>
            GetCompilationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single CompilationResult.
        /// </summary>
        /// <param name="name">
        /// Required. The compilation result's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompilationResult GetCompilationResult(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompilationResult(new GetCompilationResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single CompilationResult.
        /// </summary>
        /// <param name="name">
        /// Required. The compilation result's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> GetCompilationResultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompilationResultAsync(new GetCompilationResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single CompilationResult.
        /// </summary>
        /// <param name="name">
        /// Required. The compilation result's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> GetCompilationResultAsync(string name, st::CancellationToken cancellationToken) =>
            GetCompilationResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single CompilationResult.
        /// </summary>
        /// <param name="name">
        /// Required. The compilation result's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompilationResult GetCompilationResult(CompilationResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompilationResult(new GetCompilationResultRequest
            {
                CompilationResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single CompilationResult.
        /// </summary>
        /// <param name="name">
        /// Required. The compilation result's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> GetCompilationResultAsync(CompilationResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompilationResultAsync(new GetCompilationResultRequest
            {
                CompilationResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single CompilationResult.
        /// </summary>
        /// <param name="name">
        /// Required. The compilation result's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> GetCompilationResultAsync(CompilationResultName name, st::CancellationToken cancellationToken) =>
            GetCompilationResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new CompilationResult in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompilationResult CreateCompilationResult(CreateCompilationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new CompilationResult in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> CreateCompilationResultAsync(CreateCompilationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new CompilationResult in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> CreateCompilationResultAsync(CreateCompilationResultRequest request, st::CancellationToken cancellationToken) =>
            CreateCompilationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new CompilationResult in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the compilation result. Must be
        /// in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="compilationResult">
        /// Required. The compilation result to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompilationResult CreateCompilationResult(string parent, CompilationResult compilationResult, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompilationResult(new CreateCompilationResultRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CompilationResult = gax::GaxPreconditions.CheckNotNull(compilationResult, nameof(compilationResult)),
            }, callSettings);

        /// <summary>
        /// Creates a new CompilationResult in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the compilation result. Must be
        /// in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="compilationResult">
        /// Required. The compilation result to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> CreateCompilationResultAsync(string parent, CompilationResult compilationResult, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompilationResultAsync(new CreateCompilationResultRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CompilationResult = gax::GaxPreconditions.CheckNotNull(compilationResult, nameof(compilationResult)),
            }, callSettings);

        /// <summary>
        /// Creates a new CompilationResult in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the compilation result. Must be
        /// in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="compilationResult">
        /// Required. The compilation result to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> CreateCompilationResultAsync(string parent, CompilationResult compilationResult, st::CancellationToken cancellationToken) =>
            CreateCompilationResultAsync(parent, compilationResult, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new CompilationResult in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the compilation result. Must be
        /// in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="compilationResult">
        /// Required. The compilation result to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompilationResult CreateCompilationResult(RepositoryName parent, CompilationResult compilationResult, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompilationResult(new CreateCompilationResultRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CompilationResult = gax::GaxPreconditions.CheckNotNull(compilationResult, nameof(compilationResult)),
            }, callSettings);

        /// <summary>
        /// Creates a new CompilationResult in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the compilation result. Must be
        /// in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="compilationResult">
        /// Required. The compilation result to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> CreateCompilationResultAsync(RepositoryName parent, CompilationResult compilationResult, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompilationResultAsync(new CreateCompilationResultRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CompilationResult = gax::GaxPreconditions.CheckNotNull(compilationResult, nameof(compilationResult)),
            }, callSettings);

        /// <summary>
        /// Creates a new CompilationResult in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the compilation result. Must be
        /// in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="compilationResult">
        /// Required. The compilation result to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompilationResult> CreateCompilationResultAsync(RepositoryName parent, CompilationResult compilationResult, st::CancellationToken cancellationToken) =>
            CreateCompilationResultAsync(parent, compilationResult, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns CompilationResultActions in a given CompilationResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CompilationResultAction"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryCompilationResultActionsResponse, CompilationResultAction> QueryCompilationResultActions(QueryCompilationResultActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns CompilationResultActions in a given CompilationResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CompilationResultAction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryCompilationResultActionsResponse, CompilationResultAction> QueryCompilationResultActionsAsync(QueryCompilationResultActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists WorkflowConfigs in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkflowConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowConfigsResponse, WorkflowConfig> ListWorkflowConfigs(ListWorkflowConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists WorkflowConfigs in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowConfigsResponse, WorkflowConfig> ListWorkflowConfigsAsync(ListWorkflowConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists WorkflowConfigs in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list workflow configs. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable sequence of <see cref="WorkflowConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowConfigsResponse, WorkflowConfig> ListWorkflowConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowConfigsRequest request = new ListWorkflowConfigsRequest
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
            return ListWorkflowConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists WorkflowConfigs in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list workflow configs. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowConfigsResponse, WorkflowConfig> ListWorkflowConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowConfigsRequest request = new ListWorkflowConfigsRequest
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
            return ListWorkflowConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists WorkflowConfigs in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list workflow configs. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable sequence of <see cref="WorkflowConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowConfigsResponse, WorkflowConfig> ListWorkflowConfigs(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowConfigsRequest request = new ListWorkflowConfigsRequest
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
            return ListWorkflowConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists WorkflowConfigs in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to list workflow configs. Must be in the
        /// format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowConfigsResponse, WorkflowConfig> ListWorkflowConfigsAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowConfigsRequest request = new ListWorkflowConfigsRequest
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
            return ListWorkflowConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single WorkflowConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowConfig GetWorkflowConfig(GetWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single WorkflowConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> GetWorkflowConfigAsync(GetWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single WorkflowConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> GetWorkflowConfigAsync(GetWorkflowConfigRequest request, st::CancellationToken cancellationToken) =>
            GetWorkflowConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowConfig GetWorkflowConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowConfig(new GetWorkflowConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> GetWorkflowConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowConfigAsync(new GetWorkflowConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> GetWorkflowConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkflowConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowConfig GetWorkflowConfig(WorkflowConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowConfig(new GetWorkflowConfigRequest
            {
                WorkflowConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> GetWorkflowConfigAsync(WorkflowConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowConfigAsync(new GetWorkflowConfigRequest
            {
                WorkflowConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> GetWorkflowConfigAsync(WorkflowConfigName name, st::CancellationToken cancellationToken) =>
            GetWorkflowConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new WorkflowConfig in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowConfig CreateWorkflowConfig(CreateWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new WorkflowConfig in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> CreateWorkflowConfigAsync(CreateWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new WorkflowConfig in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> CreateWorkflowConfigAsync(CreateWorkflowConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkflowConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new WorkflowConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowConfig">
        /// Required. The workflow config to create.
        /// </param>
        /// <param name="workflowConfigId">
        /// Required. The ID to use for the workflow config, which will become the
        /// final component of the workflow config's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowConfig CreateWorkflowConfig(string parent, WorkflowConfig workflowConfig, string workflowConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowConfig(new CreateWorkflowConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkflowConfig = gax::GaxPreconditions.CheckNotNull(workflowConfig, nameof(workflowConfig)),
                WorkflowConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(workflowConfigId, nameof(workflowConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkflowConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowConfig">
        /// Required. The workflow config to create.
        /// </param>
        /// <param name="workflowConfigId">
        /// Required. The ID to use for the workflow config, which will become the
        /// final component of the workflow config's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> CreateWorkflowConfigAsync(string parent, WorkflowConfig workflowConfig, string workflowConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowConfigAsync(new CreateWorkflowConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkflowConfig = gax::GaxPreconditions.CheckNotNull(workflowConfig, nameof(workflowConfig)),
                WorkflowConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(workflowConfigId, nameof(workflowConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkflowConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowConfig">
        /// Required. The workflow config to create.
        /// </param>
        /// <param name="workflowConfigId">
        /// Required. The ID to use for the workflow config, which will become the
        /// final component of the workflow config's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> CreateWorkflowConfigAsync(string parent, WorkflowConfig workflowConfig, string workflowConfigId, st::CancellationToken cancellationToken) =>
            CreateWorkflowConfigAsync(parent, workflowConfig, workflowConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new WorkflowConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowConfig">
        /// Required. The workflow config to create.
        /// </param>
        /// <param name="workflowConfigId">
        /// Required. The ID to use for the workflow config, which will become the
        /// final component of the workflow config's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowConfig CreateWorkflowConfig(RepositoryName parent, WorkflowConfig workflowConfig, string workflowConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowConfig(new CreateWorkflowConfigRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkflowConfig = gax::GaxPreconditions.CheckNotNull(workflowConfig, nameof(workflowConfig)),
                WorkflowConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(workflowConfigId, nameof(workflowConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkflowConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowConfig">
        /// Required. The workflow config to create.
        /// </param>
        /// <param name="workflowConfigId">
        /// Required. The ID to use for the workflow config, which will become the
        /// final component of the workflow config's resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> CreateWorkflowConfigAsync(RepositoryName parent, WorkflowConfig workflowConfig, string workflowConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowConfigAsync(new CreateWorkflowConfigRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkflowConfig = gax::GaxPreconditions.CheckNotNull(workflowConfig, nameof(workflowConfig)),
                WorkflowConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(workflowConfigId, nameof(workflowConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkflowConfig in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow config. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowConfig">
        /// Required. The workflow config to create.
        /// </param>
        /// <param name="workflowConfigId">
        /// Required. The ID to use for the workflow config, which will become the
        /// final component of the workflow config's resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> CreateWorkflowConfigAsync(RepositoryName parent, WorkflowConfig workflowConfig, string workflowConfigId, st::CancellationToken cancellationToken) =>
            CreateWorkflowConfigAsync(parent, workflowConfig, workflowConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single WorkflowConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowConfig UpdateWorkflowConfig(UpdateWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single WorkflowConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> UpdateWorkflowConfigAsync(UpdateWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single WorkflowConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> UpdateWorkflowConfigAsync(UpdateWorkflowConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkflowConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single WorkflowConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="workflowConfig">
        /// Required. The workflow config to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the workflow config. If
        /// left unset, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowConfig UpdateWorkflowConfig(WorkflowConfig workflowConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkflowConfig(new UpdateWorkflowConfigRequest
            {
                UpdateMask = updateMask,
                WorkflowConfig = gax::GaxPreconditions.CheckNotNull(workflowConfig, nameof(workflowConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a single WorkflowConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="workflowConfig">
        /// Required. The workflow config to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the workflow config. If
        /// left unset, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> UpdateWorkflowConfigAsync(WorkflowConfig workflowConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkflowConfigAsync(new UpdateWorkflowConfigRequest
            {
                UpdateMask = updateMask,
                WorkflowConfig = gax::GaxPreconditions.CheckNotNull(workflowConfig, nameof(workflowConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a single WorkflowConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="workflowConfig">
        /// Required. The workflow config to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the workflow config. If
        /// left unset, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowConfig> UpdateWorkflowConfigAsync(WorkflowConfig workflowConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWorkflowConfigAsync(workflowConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single WorkflowConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkflowConfig(DeleteWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single WorkflowConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowConfigAsync(DeleteWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single WorkflowConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowConfigAsync(DeleteWorkflowConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkflowConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkflowConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowConfig(new DeleteWorkflowConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowConfigAsync(new DeleteWorkflowConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkflowConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkflowConfig(WorkflowConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowConfig(new DeleteWorkflowConfigRequest
            {
                WorkflowConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowConfigAsync(WorkflowConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowConfigAsync(new DeleteWorkflowConfigRequest
            {
                WorkflowConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single WorkflowConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow config's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowConfigAsync(WorkflowConfigName name, st::CancellationToken cancellationToken) =>
            DeleteWorkflowConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists WorkflowInvocations in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkflowInvocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> ListWorkflowInvocations(ListWorkflowInvocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists WorkflowInvocations in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowInvocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> ListWorkflowInvocationsAsync(ListWorkflowInvocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists WorkflowInvocations in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the WorkflowInvocation type. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable sequence of <see cref="WorkflowInvocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> ListWorkflowInvocations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowInvocationsRequest request = new ListWorkflowInvocationsRequest
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
            return ListWorkflowInvocations(request, callSettings);
        }

        /// <summary>
        /// Lists WorkflowInvocations in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the WorkflowInvocation type. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowInvocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> ListWorkflowInvocationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowInvocationsRequest request = new ListWorkflowInvocationsRequest
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
            return ListWorkflowInvocationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists WorkflowInvocations in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the WorkflowInvocation type. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable sequence of <see cref="WorkflowInvocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> ListWorkflowInvocations(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowInvocationsRequest request = new ListWorkflowInvocationsRequest
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
            return ListWorkflowInvocations(request, callSettings);
        }

        /// <summary>
        /// Lists WorkflowInvocations in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the WorkflowInvocation type. Must be in
        /// the format `projects/*/locations/*/repositories/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowInvocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> ListWorkflowInvocationsAsync(RepositoryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkflowInvocationsRequest request = new ListWorkflowInvocationsRequest
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
            return ListWorkflowInvocationsAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowInvocation GetWorkflowInvocation(GetWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> GetWorkflowInvocationAsync(GetWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a single WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> GetWorkflowInvocationAsync(GetWorkflowInvocationRequest request, st::CancellationToken cancellationToken) =>
            GetWorkflowInvocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowInvocation GetWorkflowInvocation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowInvocation(new GetWorkflowInvocationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> GetWorkflowInvocationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowInvocationAsync(new GetWorkflowInvocationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> GetWorkflowInvocationAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkflowInvocationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowInvocation GetWorkflowInvocation(WorkflowInvocationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowInvocation(new GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> GetWorkflowInvocationAsync(WorkflowInvocationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkflowInvocationAsync(new GetWorkflowInvocationRequest
            {
                WorkflowInvocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> GetWorkflowInvocationAsync(WorkflowInvocationName name, st::CancellationToken cancellationToken) =>
            GetWorkflowInvocationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new WorkflowInvocation in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowInvocation CreateWorkflowInvocation(CreateWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new WorkflowInvocation in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> CreateWorkflowInvocationAsync(CreateWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new WorkflowInvocation in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> CreateWorkflowInvocationAsync(CreateWorkflowInvocationRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkflowInvocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new WorkflowInvocation in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow invocation. Must
        /// be in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowInvocation">
        /// Required. The workflow invocation resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowInvocation CreateWorkflowInvocation(string parent, WorkflowInvocation workflowInvocation, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowInvocation(new CreateWorkflowInvocationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkflowInvocation = gax::GaxPreconditions.CheckNotNull(workflowInvocation, nameof(workflowInvocation)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkflowInvocation in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow invocation. Must
        /// be in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowInvocation">
        /// Required. The workflow invocation resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> CreateWorkflowInvocationAsync(string parent, WorkflowInvocation workflowInvocation, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowInvocationAsync(new CreateWorkflowInvocationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkflowInvocation = gax::GaxPreconditions.CheckNotNull(workflowInvocation, nameof(workflowInvocation)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkflowInvocation in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow invocation. Must
        /// be in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowInvocation">
        /// Required. The workflow invocation resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> CreateWorkflowInvocationAsync(string parent, WorkflowInvocation workflowInvocation, st::CancellationToken cancellationToken) =>
            CreateWorkflowInvocationAsync(parent, workflowInvocation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new WorkflowInvocation in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow invocation. Must
        /// be in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowInvocation">
        /// Required. The workflow invocation resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkflowInvocation CreateWorkflowInvocation(RepositoryName parent, WorkflowInvocation workflowInvocation, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowInvocation(new CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkflowInvocation = gax::GaxPreconditions.CheckNotNull(workflowInvocation, nameof(workflowInvocation)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkflowInvocation in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow invocation. Must
        /// be in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowInvocation">
        /// Required. The workflow invocation resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> CreateWorkflowInvocationAsync(RepositoryName parent, WorkflowInvocation workflowInvocation, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkflowInvocationAsync(new CreateWorkflowInvocationRequest
            {
                ParentAsRepositoryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkflowInvocation = gax::GaxPreconditions.CheckNotNull(workflowInvocation, nameof(workflowInvocation)),
            }, callSettings);

        /// <summary>
        /// Creates a new WorkflowInvocation in a given Repository.
        /// </summary>
        /// <param name="parent">
        /// Required. The repository in which to create the workflow invocation. Must
        /// be in the format `projects/*/locations/*/repositories/*`.
        /// </param>
        /// <param name="workflowInvocation">
        /// Required. The workflow invocation resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkflowInvocation> CreateWorkflowInvocationAsync(RepositoryName parent, WorkflowInvocation workflowInvocation, st::CancellationToken cancellationToken) =>
            CreateWorkflowInvocationAsync(parent, workflowInvocation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkflowInvocation(DeleteWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowInvocationAsync(DeleteWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowInvocationAsync(DeleteWorkflowInvocationRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkflowInvocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkflowInvocation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowInvocation(new DeleteWorkflowInvocationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowInvocationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowInvocationAsync(new DeleteWorkflowInvocationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowInvocationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkflowInvocationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWorkflowInvocation(WorkflowInvocationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowInvocation(new DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowInvocationAsync(WorkflowInvocationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkflowInvocationAsync(new DeleteWorkflowInvocationRequest
            {
                WorkflowInvocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single WorkflowInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The workflow invocation resource's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWorkflowInvocationAsync(WorkflowInvocationName name, st::CancellationToken cancellationToken) =>
            DeleteWorkflowInvocationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests cancellation of a running WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CancelWorkflowInvocationResponse CancelWorkflowInvocation(CancelWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests cancellation of a running WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelWorkflowInvocationResponse> CancelWorkflowInvocationAsync(CancelWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests cancellation of a running WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelWorkflowInvocationResponse> CancelWorkflowInvocationAsync(CancelWorkflowInvocationRequest request, st::CancellationToken cancellationToken) =>
            CancelWorkflowInvocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns WorkflowInvocationActions in a given WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkflowInvocationAction"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryWorkflowInvocationActionsResponse, WorkflowInvocationAction> QueryWorkflowInvocationActions(QueryWorkflowInvocationActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns WorkflowInvocationActions in a given WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowInvocationAction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryWorkflowInvocationActionsResponse, WorkflowInvocationAction> QueryWorkflowInvocationActionsAsync(QueryWorkflowInvocationActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get default config for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get default config for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get default config for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(GetConfigRequest request, st::CancellationToken cancellationToken) =>
            GetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get default config for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The config name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfig(new GetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get default config for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The config name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfigAsync(new GetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get default config for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The config name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get default config for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The config name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(ConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfig(new GetConfigRequest
            {
                ConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get default config for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The config name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(ConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfigAsync(new GetConfigRequest
            {
                ConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get default config for a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. The config name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(ConfigName name, st::CancellationToken cancellationToken) =>
            GetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update default config for a given project and location.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config UpdateConfig(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update default config for a given project and location.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update default config for a given project and location.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(UpdateConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update default config for a given project and location.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="config">
        /// Required. The config to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the config.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config UpdateConfig(Config config, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConfig(new UpdateConfigRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update default config for a given project and location.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="config">
        /// Required. The config to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the config.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(Config config, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConfigAsync(new UpdateConfigRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update default config for a given project and location.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="config">
        /// Required. The config to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies the fields to be updated in the config.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(Config config, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConfigAsync(config, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// 
        /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// 
        /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// 
        /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a `NOT_FOUND` error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a `NOT_FOUND` error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a `NOT_FOUND` error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Dataform client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Dataform is a service to develop, create, document, test, and update curated
    /// tables in BigQuery.
    /// </remarks>
    public sealed partial class DataformClientImpl : DataformClient
    {
        private readonly gaxgrpc::ApiCall<GetTeamFolderRequest, TeamFolder> _callGetTeamFolder;

        private readonly gaxgrpc::ApiCall<CreateTeamFolderRequest, TeamFolder> _callCreateTeamFolder;

        private readonly gaxgrpc::ApiCall<UpdateTeamFolderRequest, TeamFolder> _callUpdateTeamFolder;

        private readonly gaxgrpc::ApiCall<DeleteTeamFolderRequest, wkt::Empty> _callDeleteTeamFolder;

        private readonly gaxgrpc::ApiCall<QueryTeamFolderContentsRequest, QueryTeamFolderContentsResponse> _callQueryTeamFolderContents;

        private readonly gaxgrpc::ApiCall<SearchTeamFoldersRequest, SearchTeamFoldersResponse> _callSearchTeamFolders;

        private readonly gaxgrpc::ApiCall<GetFolderRequest, Folder> _callGetFolder;

        private readonly gaxgrpc::ApiCall<CreateFolderRequest, Folder> _callCreateFolder;

        private readonly gaxgrpc::ApiCall<UpdateFolderRequest, Folder> _callUpdateFolder;

        private readonly gaxgrpc::ApiCall<DeleteFolderRequest, wkt::Empty> _callDeleteFolder;

        private readonly gaxgrpc::ApiCall<QueryFolderContentsRequest, QueryFolderContentsResponse> _callQueryFolderContents;

        private readonly gaxgrpc::ApiCall<QueryUserRootContentsRequest, QueryUserRootContentsResponse> _callQueryUserRootContents;

        private readonly gaxgrpc::ApiCall<MoveFolderRequest, lro::Operation> _callMoveFolder;

        private readonly gaxgrpc::ApiCall<ListRepositoriesRequest, ListRepositoriesResponse> _callListRepositories;

        private readonly gaxgrpc::ApiCall<GetRepositoryRequest, Repository> _callGetRepository;

        private readonly gaxgrpc::ApiCall<CreateRepositoryRequest, Repository> _callCreateRepository;

        private readonly gaxgrpc::ApiCall<UpdateRepositoryRequest, Repository> _callUpdateRepository;

        private readonly gaxgrpc::ApiCall<DeleteRepositoryRequest, wkt::Empty> _callDeleteRepository;

        private readonly gaxgrpc::ApiCall<MoveRepositoryRequest, lro::Operation> _callMoveRepository;

        private readonly gaxgrpc::ApiCall<CommitRepositoryChangesRequest, CommitRepositoryChangesResponse> _callCommitRepositoryChanges;

        private readonly gaxgrpc::ApiCall<ReadRepositoryFileRequest, ReadRepositoryFileResponse> _callReadRepositoryFile;

        private readonly gaxgrpc::ApiCall<QueryRepositoryDirectoryContentsRequest, QueryRepositoryDirectoryContentsResponse> _callQueryRepositoryDirectoryContents;

        private readonly gaxgrpc::ApiCall<FetchRepositoryHistoryRequest, FetchRepositoryHistoryResponse> _callFetchRepositoryHistory;

        private readonly gaxgrpc::ApiCall<ComputeRepositoryAccessTokenStatusRequest, ComputeRepositoryAccessTokenStatusResponse> _callComputeRepositoryAccessTokenStatus;

        private readonly gaxgrpc::ApiCall<FetchRemoteBranchesRequest, FetchRemoteBranchesResponse> _callFetchRemoteBranches;

        private readonly gaxgrpc::ApiCall<ListWorkspacesRequest, ListWorkspacesResponse> _callListWorkspaces;

        private readonly gaxgrpc::ApiCall<GetWorkspaceRequest, Workspace> _callGetWorkspace;

        private readonly gaxgrpc::ApiCall<CreateWorkspaceRequest, Workspace> _callCreateWorkspace;

        private readonly gaxgrpc::ApiCall<DeleteWorkspaceRequest, wkt::Empty> _callDeleteWorkspace;

        private readonly gaxgrpc::ApiCall<InstallNpmPackagesRequest, InstallNpmPackagesResponse> _callInstallNpmPackages;

        private readonly gaxgrpc::ApiCall<PullGitCommitsRequest, PullGitCommitsResponse> _callPullGitCommits;

        private readonly gaxgrpc::ApiCall<PushGitCommitsRequest, PushGitCommitsResponse> _callPushGitCommits;

        private readonly gaxgrpc::ApiCall<FetchFileGitStatusesRequest, FetchFileGitStatusesResponse> _callFetchFileGitStatuses;

        private readonly gaxgrpc::ApiCall<FetchGitAheadBehindRequest, FetchGitAheadBehindResponse> _callFetchGitAheadBehind;

        private readonly gaxgrpc::ApiCall<CommitWorkspaceChangesRequest, CommitWorkspaceChangesResponse> _callCommitWorkspaceChanges;

        private readonly gaxgrpc::ApiCall<ResetWorkspaceChangesRequest, ResetWorkspaceChangesResponse> _callResetWorkspaceChanges;

        private readonly gaxgrpc::ApiCall<FetchFileDiffRequest, FetchFileDiffResponse> _callFetchFileDiff;

        private readonly gaxgrpc::ApiCall<QueryDirectoryContentsRequest, QueryDirectoryContentsResponse> _callQueryDirectoryContents;

        private readonly gaxgrpc::ApiCall<SearchFilesRequest, SearchFilesResponse> _callSearchFiles;

        private readonly gaxgrpc::ApiCall<MakeDirectoryRequest, MakeDirectoryResponse> _callMakeDirectory;

        private readonly gaxgrpc::ApiCall<RemoveDirectoryRequest, RemoveDirectoryResponse> _callRemoveDirectory;

        private readonly gaxgrpc::ApiCall<MoveDirectoryRequest, MoveDirectoryResponse> _callMoveDirectory;

        private readonly gaxgrpc::ApiCall<ReadFileRequest, ReadFileResponse> _callReadFile;

        private readonly gaxgrpc::ApiCall<RemoveFileRequest, RemoveFileResponse> _callRemoveFile;

        private readonly gaxgrpc::ApiCall<MoveFileRequest, MoveFileResponse> _callMoveFile;

        private readonly gaxgrpc::ApiCall<WriteFileRequest, WriteFileResponse> _callWriteFile;

        private readonly gaxgrpc::ApiCall<ListReleaseConfigsRequest, ListReleaseConfigsResponse> _callListReleaseConfigs;

        private readonly gaxgrpc::ApiCall<GetReleaseConfigRequest, ReleaseConfig> _callGetReleaseConfig;

        private readonly gaxgrpc::ApiCall<CreateReleaseConfigRequest, ReleaseConfig> _callCreateReleaseConfig;

        private readonly gaxgrpc::ApiCall<UpdateReleaseConfigRequest, ReleaseConfig> _callUpdateReleaseConfig;

        private readonly gaxgrpc::ApiCall<DeleteReleaseConfigRequest, wkt::Empty> _callDeleteReleaseConfig;

        private readonly gaxgrpc::ApiCall<ListCompilationResultsRequest, ListCompilationResultsResponse> _callListCompilationResults;

        private readonly gaxgrpc::ApiCall<GetCompilationResultRequest, CompilationResult> _callGetCompilationResult;

        private readonly gaxgrpc::ApiCall<CreateCompilationResultRequest, CompilationResult> _callCreateCompilationResult;

        private readonly gaxgrpc::ApiCall<QueryCompilationResultActionsRequest, QueryCompilationResultActionsResponse> _callQueryCompilationResultActions;

        private readonly gaxgrpc::ApiCall<ListWorkflowConfigsRequest, ListWorkflowConfigsResponse> _callListWorkflowConfigs;

        private readonly gaxgrpc::ApiCall<GetWorkflowConfigRequest, WorkflowConfig> _callGetWorkflowConfig;

        private readonly gaxgrpc::ApiCall<CreateWorkflowConfigRequest, WorkflowConfig> _callCreateWorkflowConfig;

        private readonly gaxgrpc::ApiCall<UpdateWorkflowConfigRequest, WorkflowConfig> _callUpdateWorkflowConfig;

        private readonly gaxgrpc::ApiCall<DeleteWorkflowConfigRequest, wkt::Empty> _callDeleteWorkflowConfig;

        private readonly gaxgrpc::ApiCall<ListWorkflowInvocationsRequest, ListWorkflowInvocationsResponse> _callListWorkflowInvocations;

        private readonly gaxgrpc::ApiCall<GetWorkflowInvocationRequest, WorkflowInvocation> _callGetWorkflowInvocation;

        private readonly gaxgrpc::ApiCall<CreateWorkflowInvocationRequest, WorkflowInvocation> _callCreateWorkflowInvocation;

        private readonly gaxgrpc::ApiCall<DeleteWorkflowInvocationRequest, wkt::Empty> _callDeleteWorkflowInvocation;

        private readonly gaxgrpc::ApiCall<CancelWorkflowInvocationRequest, CancelWorkflowInvocationResponse> _callCancelWorkflowInvocation;

        private readonly gaxgrpc::ApiCall<QueryWorkflowInvocationActionsRequest, QueryWorkflowInvocationActionsResponse> _callQueryWorkflowInvocationActions;

        private readonly gaxgrpc::ApiCall<GetConfigRequest, Config> _callGetConfig;

        private readonly gaxgrpc::ApiCall<UpdateConfigRequest, Config> _callUpdateConfig;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the Dataform service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataformSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataformClientImpl(Dataform.DataformClient grpcClient, DataformSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataformSettings effectiveSettings = settings ?? DataformSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            MoveFolderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.MoveFolderOperationsSettings, logger);
            MoveRepositoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.MoveRepositoryOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callGetTeamFolder = clientHelper.BuildApiCall<GetTeamFolderRequest, TeamFolder>("GetTeamFolder", grpcClient.GetTeamFolderAsync, grpcClient.GetTeamFolder, effectiveSettings.GetTeamFolderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTeamFolder);
            Modify_GetTeamFolderApiCall(ref _callGetTeamFolder);
            _callCreateTeamFolder = clientHelper.BuildApiCall<CreateTeamFolderRequest, TeamFolder>("CreateTeamFolder", grpcClient.CreateTeamFolderAsync, grpcClient.CreateTeamFolder, effectiveSettings.CreateTeamFolderSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTeamFolder);
            Modify_CreateTeamFolderApiCall(ref _callCreateTeamFolder);
            _callUpdateTeamFolder = clientHelper.BuildApiCall<UpdateTeamFolderRequest, TeamFolder>("UpdateTeamFolder", grpcClient.UpdateTeamFolderAsync, grpcClient.UpdateTeamFolder, effectiveSettings.UpdateTeamFolderSettings).WithGoogleRequestParam("team_folder.name", request => request.TeamFolder?.Name);
            Modify_ApiCall(ref _callUpdateTeamFolder);
            Modify_UpdateTeamFolderApiCall(ref _callUpdateTeamFolder);
            _callDeleteTeamFolder = clientHelper.BuildApiCall<DeleteTeamFolderRequest, wkt::Empty>("DeleteTeamFolder", grpcClient.DeleteTeamFolderAsync, grpcClient.DeleteTeamFolder, effectiveSettings.DeleteTeamFolderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTeamFolder);
            Modify_DeleteTeamFolderApiCall(ref _callDeleteTeamFolder);
            _callQueryTeamFolderContents = clientHelper.BuildApiCall<QueryTeamFolderContentsRequest, QueryTeamFolderContentsResponse>("QueryTeamFolderContents", grpcClient.QueryTeamFolderContentsAsync, grpcClient.QueryTeamFolderContents, effectiveSettings.QueryTeamFolderContentsSettings).WithGoogleRequestParam("team_folder", request => request.TeamFolder);
            Modify_ApiCall(ref _callQueryTeamFolderContents);
            Modify_QueryTeamFolderContentsApiCall(ref _callQueryTeamFolderContents);
            _callSearchTeamFolders = clientHelper.BuildApiCall<SearchTeamFoldersRequest, SearchTeamFoldersResponse>("SearchTeamFolders", grpcClient.SearchTeamFoldersAsync, grpcClient.SearchTeamFolders, effectiveSettings.SearchTeamFoldersSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callSearchTeamFolders);
            Modify_SearchTeamFoldersApiCall(ref _callSearchTeamFolders);
            _callGetFolder = clientHelper.BuildApiCall<GetFolderRequest, Folder>("GetFolder", grpcClient.GetFolderAsync, grpcClient.GetFolder, effectiveSettings.GetFolderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFolder);
            Modify_GetFolderApiCall(ref _callGetFolder);
            _callCreateFolder = clientHelper.BuildApiCall<CreateFolderRequest, Folder>("CreateFolder", grpcClient.CreateFolderAsync, grpcClient.CreateFolder, effectiveSettings.CreateFolderSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFolder);
            Modify_CreateFolderApiCall(ref _callCreateFolder);
            _callUpdateFolder = clientHelper.BuildApiCall<UpdateFolderRequest, Folder>("UpdateFolder", grpcClient.UpdateFolderAsync, grpcClient.UpdateFolder, effectiveSettings.UpdateFolderSettings).WithGoogleRequestParam("folder.name", request => request.Folder?.Name);
            Modify_ApiCall(ref _callUpdateFolder);
            Modify_UpdateFolderApiCall(ref _callUpdateFolder);
            _callDeleteFolder = clientHelper.BuildApiCall<DeleteFolderRequest, wkt::Empty>("DeleteFolder", grpcClient.DeleteFolderAsync, grpcClient.DeleteFolder, effectiveSettings.DeleteFolderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFolder);
            Modify_DeleteFolderApiCall(ref _callDeleteFolder);
            _callQueryFolderContents = clientHelper.BuildApiCall<QueryFolderContentsRequest, QueryFolderContentsResponse>("QueryFolderContents", grpcClient.QueryFolderContentsAsync, grpcClient.QueryFolderContents, effectiveSettings.QueryFolderContentsSettings).WithGoogleRequestParam("folder", request => request.Folder);
            Modify_ApiCall(ref _callQueryFolderContents);
            Modify_QueryFolderContentsApiCall(ref _callQueryFolderContents);
            _callQueryUserRootContents = clientHelper.BuildApiCall<QueryUserRootContentsRequest, QueryUserRootContentsResponse>("QueryUserRootContents", grpcClient.QueryUserRootContentsAsync, grpcClient.QueryUserRootContents, effectiveSettings.QueryUserRootContentsSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callQueryUserRootContents);
            Modify_QueryUserRootContentsApiCall(ref _callQueryUserRootContents);
            _callMoveFolder = clientHelper.BuildApiCall<MoveFolderRequest, lro::Operation>("MoveFolder", grpcClient.MoveFolderAsync, grpcClient.MoveFolder, effectiveSettings.MoveFolderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMoveFolder);
            Modify_MoveFolderApiCall(ref _callMoveFolder);
            _callListRepositories = clientHelper.BuildApiCall<ListRepositoriesRequest, ListRepositoriesResponse>("ListRepositories", grpcClient.ListRepositoriesAsync, grpcClient.ListRepositories, effectiveSettings.ListRepositoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRepositories);
            Modify_ListRepositoriesApiCall(ref _callListRepositories);
            _callGetRepository = clientHelper.BuildApiCall<GetRepositoryRequest, Repository>("GetRepository", grpcClient.GetRepositoryAsync, grpcClient.GetRepository, effectiveSettings.GetRepositorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRepository);
            Modify_GetRepositoryApiCall(ref _callGetRepository);
            _callCreateRepository = clientHelper.BuildApiCall<CreateRepositoryRequest, Repository>("CreateRepository", grpcClient.CreateRepositoryAsync, grpcClient.CreateRepository, effectiveSettings.CreateRepositorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRepository);
            Modify_CreateRepositoryApiCall(ref _callCreateRepository);
            _callUpdateRepository = clientHelper.BuildApiCall<UpdateRepositoryRequest, Repository>("UpdateRepository", grpcClient.UpdateRepositoryAsync, grpcClient.UpdateRepository, effectiveSettings.UpdateRepositorySettings).WithGoogleRequestParam("repository.name", request => request.Repository?.Name);
            Modify_ApiCall(ref _callUpdateRepository);
            Modify_UpdateRepositoryApiCall(ref _callUpdateRepository);
            _callDeleteRepository = clientHelper.BuildApiCall<DeleteRepositoryRequest, wkt::Empty>("DeleteRepository", grpcClient.DeleteRepositoryAsync, grpcClient.DeleteRepository, effectiveSettings.DeleteRepositorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRepository);
            Modify_DeleteRepositoryApiCall(ref _callDeleteRepository);
            _callMoveRepository = clientHelper.BuildApiCall<MoveRepositoryRequest, lro::Operation>("MoveRepository", grpcClient.MoveRepositoryAsync, grpcClient.MoveRepository, effectiveSettings.MoveRepositorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMoveRepository);
            Modify_MoveRepositoryApiCall(ref _callMoveRepository);
            _callCommitRepositoryChanges = clientHelper.BuildApiCall<CommitRepositoryChangesRequest, CommitRepositoryChangesResponse>("CommitRepositoryChanges", grpcClient.CommitRepositoryChangesAsync, grpcClient.CommitRepositoryChanges, effectiveSettings.CommitRepositoryChangesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCommitRepositoryChanges);
            Modify_CommitRepositoryChangesApiCall(ref _callCommitRepositoryChanges);
            _callReadRepositoryFile = clientHelper.BuildApiCall<ReadRepositoryFileRequest, ReadRepositoryFileResponse>("ReadRepositoryFile", grpcClient.ReadRepositoryFileAsync, grpcClient.ReadRepositoryFile, effectiveSettings.ReadRepositoryFileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callReadRepositoryFile);
            Modify_ReadRepositoryFileApiCall(ref _callReadRepositoryFile);
            _callQueryRepositoryDirectoryContents = clientHelper.BuildApiCall<QueryRepositoryDirectoryContentsRequest, QueryRepositoryDirectoryContentsResponse>("QueryRepositoryDirectoryContents", grpcClient.QueryRepositoryDirectoryContentsAsync, grpcClient.QueryRepositoryDirectoryContents, effectiveSettings.QueryRepositoryDirectoryContentsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callQueryRepositoryDirectoryContents);
            Modify_QueryRepositoryDirectoryContentsApiCall(ref _callQueryRepositoryDirectoryContents);
            _callFetchRepositoryHistory = clientHelper.BuildApiCall<FetchRepositoryHistoryRequest, FetchRepositoryHistoryResponse>("FetchRepositoryHistory", grpcClient.FetchRepositoryHistoryAsync, grpcClient.FetchRepositoryHistory, effectiveSettings.FetchRepositoryHistorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchRepositoryHistory);
            Modify_FetchRepositoryHistoryApiCall(ref _callFetchRepositoryHistory);
            _callComputeRepositoryAccessTokenStatus = clientHelper.BuildApiCall<ComputeRepositoryAccessTokenStatusRequest, ComputeRepositoryAccessTokenStatusResponse>("ComputeRepositoryAccessTokenStatus", grpcClient.ComputeRepositoryAccessTokenStatusAsync, grpcClient.ComputeRepositoryAccessTokenStatus, effectiveSettings.ComputeRepositoryAccessTokenStatusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callComputeRepositoryAccessTokenStatus);
            Modify_ComputeRepositoryAccessTokenStatusApiCall(ref _callComputeRepositoryAccessTokenStatus);
            _callFetchRemoteBranches = clientHelper.BuildApiCall<FetchRemoteBranchesRequest, FetchRemoteBranchesResponse>("FetchRemoteBranches", grpcClient.FetchRemoteBranchesAsync, grpcClient.FetchRemoteBranches, effectiveSettings.FetchRemoteBranchesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchRemoteBranches);
            Modify_FetchRemoteBranchesApiCall(ref _callFetchRemoteBranches);
            _callListWorkspaces = clientHelper.BuildApiCall<ListWorkspacesRequest, ListWorkspacesResponse>("ListWorkspaces", grpcClient.ListWorkspacesAsync, grpcClient.ListWorkspaces, effectiveSettings.ListWorkspacesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkspaces);
            Modify_ListWorkspacesApiCall(ref _callListWorkspaces);
            _callGetWorkspace = clientHelper.BuildApiCall<GetWorkspaceRequest, Workspace>("GetWorkspace", grpcClient.GetWorkspaceAsync, grpcClient.GetWorkspace, effectiveSettings.GetWorkspaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkspace);
            Modify_GetWorkspaceApiCall(ref _callGetWorkspace);
            _callCreateWorkspace = clientHelper.BuildApiCall<CreateWorkspaceRequest, Workspace>("CreateWorkspace", grpcClient.CreateWorkspaceAsync, grpcClient.CreateWorkspace, effectiveSettings.CreateWorkspaceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkspace);
            Modify_CreateWorkspaceApiCall(ref _callCreateWorkspace);
            _callDeleteWorkspace = clientHelper.BuildApiCall<DeleteWorkspaceRequest, wkt::Empty>("DeleteWorkspace", grpcClient.DeleteWorkspaceAsync, grpcClient.DeleteWorkspace, effectiveSettings.DeleteWorkspaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkspace);
            Modify_DeleteWorkspaceApiCall(ref _callDeleteWorkspace);
            _callInstallNpmPackages = clientHelper.BuildApiCall<InstallNpmPackagesRequest, InstallNpmPackagesResponse>("InstallNpmPackages", grpcClient.InstallNpmPackagesAsync, grpcClient.InstallNpmPackages, effectiveSettings.InstallNpmPackagesSettings).WithGoogleRequestParam("workspace", request => request.Workspace);
            Modify_ApiCall(ref _callInstallNpmPackages);
            Modify_InstallNpmPackagesApiCall(ref _callInstallNpmPackages);
            _callPullGitCommits = clientHelper.BuildApiCall<PullGitCommitsRequest, PullGitCommitsResponse>("PullGitCommits", grpcClient.PullGitCommitsAsync, grpcClient.PullGitCommits, effectiveSettings.PullGitCommitsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPullGitCommits);
            Modify_PullGitCommitsApiCall(ref _callPullGitCommits);
            _callPushGitCommits = clientHelper.BuildApiCall<PushGitCommitsRequest, PushGitCommitsResponse>("PushGitCommits", grpcClient.PushGitCommitsAsync, grpcClient.PushGitCommits, effectiveSettings.PushGitCommitsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPushGitCommits);
            Modify_PushGitCommitsApiCall(ref _callPushGitCommits);
            _callFetchFileGitStatuses = clientHelper.BuildApiCall<FetchFileGitStatusesRequest, FetchFileGitStatusesResponse>("FetchFileGitStatuses", grpcClient.FetchFileGitStatusesAsync, grpcClient.FetchFileGitStatuses, effectiveSettings.FetchFileGitStatusesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchFileGitStatuses);
            Modify_FetchFileGitStatusesApiCall(ref _callFetchFileGitStatuses);
            _callFetchGitAheadBehind = clientHelper.BuildApiCall<FetchGitAheadBehindRequest, FetchGitAheadBehindResponse>("FetchGitAheadBehind", grpcClient.FetchGitAheadBehindAsync, grpcClient.FetchGitAheadBehind, effectiveSettings.FetchGitAheadBehindSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchGitAheadBehind);
            Modify_FetchGitAheadBehindApiCall(ref _callFetchGitAheadBehind);
            _callCommitWorkspaceChanges = clientHelper.BuildApiCall<CommitWorkspaceChangesRequest, CommitWorkspaceChangesResponse>("CommitWorkspaceChanges", grpcClient.CommitWorkspaceChangesAsync, grpcClient.CommitWorkspaceChanges, effectiveSettings.CommitWorkspaceChangesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCommitWorkspaceChanges);
            Modify_CommitWorkspaceChangesApiCall(ref _callCommitWorkspaceChanges);
            _callResetWorkspaceChanges = clientHelper.BuildApiCall<ResetWorkspaceChangesRequest, ResetWorkspaceChangesResponse>("ResetWorkspaceChanges", grpcClient.ResetWorkspaceChangesAsync, grpcClient.ResetWorkspaceChanges, effectiveSettings.ResetWorkspaceChangesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResetWorkspaceChanges);
            Modify_ResetWorkspaceChangesApiCall(ref _callResetWorkspaceChanges);
            _callFetchFileDiff = clientHelper.BuildApiCall<FetchFileDiffRequest, FetchFileDiffResponse>("FetchFileDiff", grpcClient.FetchFileDiffAsync, grpcClient.FetchFileDiff, effectiveSettings.FetchFileDiffSettings).WithGoogleRequestParam("workspace", request => request.Workspace);
            Modify_ApiCall(ref _callFetchFileDiff);
            Modify_FetchFileDiffApiCall(ref _callFetchFileDiff);
            _callQueryDirectoryContents = clientHelper.BuildApiCall<QueryDirectoryContentsRequest, QueryDirectoryContentsResponse>("QueryDirectoryContents", grpcClient.QueryDirectoryContentsAsync, grpcClient.QueryDirectoryContents, effectiveSettings.QueryDirectoryContentsSettings).WithGoogleRequestParam("workspace", request => request.Workspace);
            Modify_ApiCall(ref _callQueryDirectoryContents);
            Modify_QueryDirectoryContentsApiCall(ref _callQueryDirectoryContents);
            _callSearchFiles = clientHelper.BuildApiCall<SearchFilesRequest, SearchFilesResponse>("SearchFiles", grpcClient.SearchFilesAsync, grpcClient.SearchFiles, effectiveSettings.SearchFilesSettings).WithGoogleRequestParam("workspace", request => request.Workspace);
            Modify_ApiCall(ref _callSearchFiles);
            Modify_SearchFilesApiCall(ref _callSearchFiles);
            _callMakeDirectory = clientHelper.BuildApiCall<MakeDirectoryRequest, MakeDirectoryResponse>("MakeDirectory", grpcClient.MakeDirectoryAsync, grpcClient.MakeDirectory, effectiveSettings.MakeDirectorySettings).WithGoogleRequestParam("workspace", request => request.Workspace);
            Modify_ApiCall(ref _callMakeDirectory);
            Modify_MakeDirectoryApiCall(ref _callMakeDirectory);
            _callRemoveDirectory = clientHelper.BuildApiCall<RemoveDirectoryRequest, RemoveDirectoryResponse>("RemoveDirectory", grpcClient.RemoveDirectoryAsync, grpcClient.RemoveDirectory, effectiveSettings.RemoveDirectorySettings).WithGoogleRequestParam("workspace", request => request.Workspace);
            Modify_ApiCall(ref _callRemoveDirectory);
            Modify_RemoveDirectoryApiCall(ref _callRemoveDirectory);
            _callMoveDirectory = clientHelper.BuildApiCall<MoveDirectoryRequest, MoveDirectoryResponse>("MoveDirectory", grpcClient.MoveDirectoryAsync, grpcClient.MoveDirectory, effectiveSettings.MoveDirectorySettings).WithGoogleRequestParam("workspace", request => request.Workspace);
            Modify_ApiCall(ref _callMoveDirectory);
            Modify_MoveDirectoryApiCall(ref _callMoveDirectory);
            _callReadFile = clientHelper.BuildApiCall<ReadFileRequest, ReadFileResponse>("ReadFile", grpcClient.ReadFileAsync, grpcClient.ReadFile, effectiveSettings.ReadFileSettings).WithGoogleRequestParam("workspace", request => request.Workspace);
            Modify_ApiCall(ref _callReadFile);
            Modify_ReadFileApiCall(ref _callReadFile);
            _callRemoveFile = clientHelper.BuildApiCall<RemoveFileRequest, RemoveFileResponse>("RemoveFile", grpcClient.RemoveFileAsync, grpcClient.RemoveFile, effectiveSettings.RemoveFileSettings).WithGoogleRequestParam("workspace", request => request.Workspace);
            Modify_ApiCall(ref _callRemoveFile);
            Modify_RemoveFileApiCall(ref _callRemoveFile);
            _callMoveFile = clientHelper.BuildApiCall<MoveFileRequest, MoveFileResponse>("MoveFile", grpcClient.MoveFileAsync, grpcClient.MoveFile, effectiveSettings.MoveFileSettings).WithGoogleRequestParam("workspace", request => request.Workspace);
            Modify_ApiCall(ref _callMoveFile);
            Modify_MoveFileApiCall(ref _callMoveFile);
            _callWriteFile = clientHelper.BuildApiCall<WriteFileRequest, WriteFileResponse>("WriteFile", grpcClient.WriteFileAsync, grpcClient.WriteFile, effectiveSettings.WriteFileSettings).WithGoogleRequestParam("workspace", request => request.Workspace);
            Modify_ApiCall(ref _callWriteFile);
            Modify_WriteFileApiCall(ref _callWriteFile);
            _callListReleaseConfigs = clientHelper.BuildApiCall<ListReleaseConfigsRequest, ListReleaseConfigsResponse>("ListReleaseConfigs", grpcClient.ListReleaseConfigsAsync, grpcClient.ListReleaseConfigs, effectiveSettings.ListReleaseConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReleaseConfigs);
            Modify_ListReleaseConfigsApiCall(ref _callListReleaseConfigs);
            _callGetReleaseConfig = clientHelper.BuildApiCall<GetReleaseConfigRequest, ReleaseConfig>("GetReleaseConfig", grpcClient.GetReleaseConfigAsync, grpcClient.GetReleaseConfig, effectiveSettings.GetReleaseConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReleaseConfig);
            Modify_GetReleaseConfigApiCall(ref _callGetReleaseConfig);
            _callCreateReleaseConfig = clientHelper.BuildApiCall<CreateReleaseConfigRequest, ReleaseConfig>("CreateReleaseConfig", grpcClient.CreateReleaseConfigAsync, grpcClient.CreateReleaseConfig, effectiveSettings.CreateReleaseConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReleaseConfig);
            Modify_CreateReleaseConfigApiCall(ref _callCreateReleaseConfig);
            _callUpdateReleaseConfig = clientHelper.BuildApiCall<UpdateReleaseConfigRequest, ReleaseConfig>("UpdateReleaseConfig", grpcClient.UpdateReleaseConfigAsync, grpcClient.UpdateReleaseConfig, effectiveSettings.UpdateReleaseConfigSettings).WithGoogleRequestParam("release_config.name", request => request.ReleaseConfig?.Name);
            Modify_ApiCall(ref _callUpdateReleaseConfig);
            Modify_UpdateReleaseConfigApiCall(ref _callUpdateReleaseConfig);
            _callDeleteReleaseConfig = clientHelper.BuildApiCall<DeleteReleaseConfigRequest, wkt::Empty>("DeleteReleaseConfig", grpcClient.DeleteReleaseConfigAsync, grpcClient.DeleteReleaseConfig, effectiveSettings.DeleteReleaseConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReleaseConfig);
            Modify_DeleteReleaseConfigApiCall(ref _callDeleteReleaseConfig);
            _callListCompilationResults = clientHelper.BuildApiCall<ListCompilationResultsRequest, ListCompilationResultsResponse>("ListCompilationResults", grpcClient.ListCompilationResultsAsync, grpcClient.ListCompilationResults, effectiveSettings.ListCompilationResultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCompilationResults);
            Modify_ListCompilationResultsApiCall(ref _callListCompilationResults);
            _callGetCompilationResult = clientHelper.BuildApiCall<GetCompilationResultRequest, CompilationResult>("GetCompilationResult", grpcClient.GetCompilationResultAsync, grpcClient.GetCompilationResult, effectiveSettings.GetCompilationResultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCompilationResult);
            Modify_GetCompilationResultApiCall(ref _callGetCompilationResult);
            _callCreateCompilationResult = clientHelper.BuildApiCall<CreateCompilationResultRequest, CompilationResult>("CreateCompilationResult", grpcClient.CreateCompilationResultAsync, grpcClient.CreateCompilationResult, effectiveSettings.CreateCompilationResultSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCompilationResult);
            Modify_CreateCompilationResultApiCall(ref _callCreateCompilationResult);
            _callQueryCompilationResultActions = clientHelper.BuildApiCall<QueryCompilationResultActionsRequest, QueryCompilationResultActionsResponse>("QueryCompilationResultActions", grpcClient.QueryCompilationResultActionsAsync, grpcClient.QueryCompilationResultActions, effectiveSettings.QueryCompilationResultActionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callQueryCompilationResultActions);
            Modify_QueryCompilationResultActionsApiCall(ref _callQueryCompilationResultActions);
            _callListWorkflowConfigs = clientHelper.BuildApiCall<ListWorkflowConfigsRequest, ListWorkflowConfigsResponse>("ListWorkflowConfigs", grpcClient.ListWorkflowConfigsAsync, grpcClient.ListWorkflowConfigs, effectiveSettings.ListWorkflowConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkflowConfigs);
            Modify_ListWorkflowConfigsApiCall(ref _callListWorkflowConfigs);
            _callGetWorkflowConfig = clientHelper.BuildApiCall<GetWorkflowConfigRequest, WorkflowConfig>("GetWorkflowConfig", grpcClient.GetWorkflowConfigAsync, grpcClient.GetWorkflowConfig, effectiveSettings.GetWorkflowConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkflowConfig);
            Modify_GetWorkflowConfigApiCall(ref _callGetWorkflowConfig);
            _callCreateWorkflowConfig = clientHelper.BuildApiCall<CreateWorkflowConfigRequest, WorkflowConfig>("CreateWorkflowConfig", grpcClient.CreateWorkflowConfigAsync, grpcClient.CreateWorkflowConfig, effectiveSettings.CreateWorkflowConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkflowConfig);
            Modify_CreateWorkflowConfigApiCall(ref _callCreateWorkflowConfig);
            _callUpdateWorkflowConfig = clientHelper.BuildApiCall<UpdateWorkflowConfigRequest, WorkflowConfig>("UpdateWorkflowConfig", grpcClient.UpdateWorkflowConfigAsync, grpcClient.UpdateWorkflowConfig, effectiveSettings.UpdateWorkflowConfigSettings).WithGoogleRequestParam("workflow_config.name", request => request.WorkflowConfig?.Name);
            Modify_ApiCall(ref _callUpdateWorkflowConfig);
            Modify_UpdateWorkflowConfigApiCall(ref _callUpdateWorkflowConfig);
            _callDeleteWorkflowConfig = clientHelper.BuildApiCall<DeleteWorkflowConfigRequest, wkt::Empty>("DeleteWorkflowConfig", grpcClient.DeleteWorkflowConfigAsync, grpcClient.DeleteWorkflowConfig, effectiveSettings.DeleteWorkflowConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkflowConfig);
            Modify_DeleteWorkflowConfigApiCall(ref _callDeleteWorkflowConfig);
            _callListWorkflowInvocations = clientHelper.BuildApiCall<ListWorkflowInvocationsRequest, ListWorkflowInvocationsResponse>("ListWorkflowInvocations", grpcClient.ListWorkflowInvocationsAsync, grpcClient.ListWorkflowInvocations, effectiveSettings.ListWorkflowInvocationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkflowInvocations);
            Modify_ListWorkflowInvocationsApiCall(ref _callListWorkflowInvocations);
            _callGetWorkflowInvocation = clientHelper.BuildApiCall<GetWorkflowInvocationRequest, WorkflowInvocation>("GetWorkflowInvocation", grpcClient.GetWorkflowInvocationAsync, grpcClient.GetWorkflowInvocation, effectiveSettings.GetWorkflowInvocationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkflowInvocation);
            Modify_GetWorkflowInvocationApiCall(ref _callGetWorkflowInvocation);
            _callCreateWorkflowInvocation = clientHelper.BuildApiCall<CreateWorkflowInvocationRequest, WorkflowInvocation>("CreateWorkflowInvocation", grpcClient.CreateWorkflowInvocationAsync, grpcClient.CreateWorkflowInvocation, effectiveSettings.CreateWorkflowInvocationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWorkflowInvocation);
            Modify_CreateWorkflowInvocationApiCall(ref _callCreateWorkflowInvocation);
            _callDeleteWorkflowInvocation = clientHelper.BuildApiCall<DeleteWorkflowInvocationRequest, wkt::Empty>("DeleteWorkflowInvocation", grpcClient.DeleteWorkflowInvocationAsync, grpcClient.DeleteWorkflowInvocation, effectiveSettings.DeleteWorkflowInvocationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWorkflowInvocation);
            Modify_DeleteWorkflowInvocationApiCall(ref _callDeleteWorkflowInvocation);
            _callCancelWorkflowInvocation = clientHelper.BuildApiCall<CancelWorkflowInvocationRequest, CancelWorkflowInvocationResponse>("CancelWorkflowInvocation", grpcClient.CancelWorkflowInvocationAsync, grpcClient.CancelWorkflowInvocation, effectiveSettings.CancelWorkflowInvocationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelWorkflowInvocation);
            Modify_CancelWorkflowInvocationApiCall(ref _callCancelWorkflowInvocation);
            _callQueryWorkflowInvocationActions = clientHelper.BuildApiCall<QueryWorkflowInvocationActionsRequest, QueryWorkflowInvocationActionsResponse>("QueryWorkflowInvocationActions", grpcClient.QueryWorkflowInvocationActionsAsync, grpcClient.QueryWorkflowInvocationActions, effectiveSettings.QueryWorkflowInvocationActionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callQueryWorkflowInvocationActions);
            Modify_QueryWorkflowInvocationActionsApiCall(ref _callQueryWorkflowInvocationActions);
            _callGetConfig = clientHelper.BuildApiCall<GetConfigRequest, Config>("GetConfig", grpcClient.GetConfigAsync, grpcClient.GetConfig, effectiveSettings.GetConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConfig);
            Modify_GetConfigApiCall(ref _callGetConfig);
            _callUpdateConfig = clientHelper.BuildApiCall<UpdateConfigRequest, Config>("UpdateConfig", grpcClient.UpdateConfigAsync, grpcClient.UpdateConfig, effectiveSettings.UpdateConfigSettings).WithGoogleRequestParam("config.name", request => request.Config?.Name);
            Modify_ApiCall(ref _callUpdateConfig);
            Modify_UpdateConfigApiCall(ref _callUpdateConfig);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTeamFolderApiCall(ref gaxgrpc::ApiCall<GetTeamFolderRequest, TeamFolder> call);

        partial void Modify_CreateTeamFolderApiCall(ref gaxgrpc::ApiCall<CreateTeamFolderRequest, TeamFolder> call);

        partial void Modify_UpdateTeamFolderApiCall(ref gaxgrpc::ApiCall<UpdateTeamFolderRequest, TeamFolder> call);

        partial void Modify_DeleteTeamFolderApiCall(ref gaxgrpc::ApiCall<DeleteTeamFolderRequest, wkt::Empty> call);

        partial void Modify_QueryTeamFolderContentsApiCall(ref gaxgrpc::ApiCall<QueryTeamFolderContentsRequest, QueryTeamFolderContentsResponse> call);

        partial void Modify_SearchTeamFoldersApiCall(ref gaxgrpc::ApiCall<SearchTeamFoldersRequest, SearchTeamFoldersResponse> call);

        partial void Modify_GetFolderApiCall(ref gaxgrpc::ApiCall<GetFolderRequest, Folder> call);

        partial void Modify_CreateFolderApiCall(ref gaxgrpc::ApiCall<CreateFolderRequest, Folder> call);

        partial void Modify_UpdateFolderApiCall(ref gaxgrpc::ApiCall<UpdateFolderRequest, Folder> call);

        partial void Modify_DeleteFolderApiCall(ref gaxgrpc::ApiCall<DeleteFolderRequest, wkt::Empty> call);

        partial void Modify_QueryFolderContentsApiCall(ref gaxgrpc::ApiCall<QueryFolderContentsRequest, QueryFolderContentsResponse> call);

        partial void Modify_QueryUserRootContentsApiCall(ref gaxgrpc::ApiCall<QueryUserRootContentsRequest, QueryUserRootContentsResponse> call);

        partial void Modify_MoveFolderApiCall(ref gaxgrpc::ApiCall<MoveFolderRequest, lro::Operation> call);

        partial void Modify_ListRepositoriesApiCall(ref gaxgrpc::ApiCall<ListRepositoriesRequest, ListRepositoriesResponse> call);

        partial void Modify_GetRepositoryApiCall(ref gaxgrpc::ApiCall<GetRepositoryRequest, Repository> call);

        partial void Modify_CreateRepositoryApiCall(ref gaxgrpc::ApiCall<CreateRepositoryRequest, Repository> call);

        partial void Modify_UpdateRepositoryApiCall(ref gaxgrpc::ApiCall<UpdateRepositoryRequest, Repository> call);

        partial void Modify_DeleteRepositoryApiCall(ref gaxgrpc::ApiCall<DeleteRepositoryRequest, wkt::Empty> call);

        partial void Modify_MoveRepositoryApiCall(ref gaxgrpc::ApiCall<MoveRepositoryRequest, lro::Operation> call);

        partial void Modify_CommitRepositoryChangesApiCall(ref gaxgrpc::ApiCall<CommitRepositoryChangesRequest, CommitRepositoryChangesResponse> call);

        partial void Modify_ReadRepositoryFileApiCall(ref gaxgrpc::ApiCall<ReadRepositoryFileRequest, ReadRepositoryFileResponse> call);

        partial void Modify_QueryRepositoryDirectoryContentsApiCall(ref gaxgrpc::ApiCall<QueryRepositoryDirectoryContentsRequest, QueryRepositoryDirectoryContentsResponse> call);

        partial void Modify_FetchRepositoryHistoryApiCall(ref gaxgrpc::ApiCall<FetchRepositoryHistoryRequest, FetchRepositoryHistoryResponse> call);

        partial void Modify_ComputeRepositoryAccessTokenStatusApiCall(ref gaxgrpc::ApiCall<ComputeRepositoryAccessTokenStatusRequest, ComputeRepositoryAccessTokenStatusResponse> call);

        partial void Modify_FetchRemoteBranchesApiCall(ref gaxgrpc::ApiCall<FetchRemoteBranchesRequest, FetchRemoteBranchesResponse> call);

        partial void Modify_ListWorkspacesApiCall(ref gaxgrpc::ApiCall<ListWorkspacesRequest, ListWorkspacesResponse> call);

        partial void Modify_GetWorkspaceApiCall(ref gaxgrpc::ApiCall<GetWorkspaceRequest, Workspace> call);

        partial void Modify_CreateWorkspaceApiCall(ref gaxgrpc::ApiCall<CreateWorkspaceRequest, Workspace> call);

        partial void Modify_DeleteWorkspaceApiCall(ref gaxgrpc::ApiCall<DeleteWorkspaceRequest, wkt::Empty> call);

        partial void Modify_InstallNpmPackagesApiCall(ref gaxgrpc::ApiCall<InstallNpmPackagesRequest, InstallNpmPackagesResponse> call);

        partial void Modify_PullGitCommitsApiCall(ref gaxgrpc::ApiCall<PullGitCommitsRequest, PullGitCommitsResponse> call);

        partial void Modify_PushGitCommitsApiCall(ref gaxgrpc::ApiCall<PushGitCommitsRequest, PushGitCommitsResponse> call);

        partial void Modify_FetchFileGitStatusesApiCall(ref gaxgrpc::ApiCall<FetchFileGitStatusesRequest, FetchFileGitStatusesResponse> call);

        partial void Modify_FetchGitAheadBehindApiCall(ref gaxgrpc::ApiCall<FetchGitAheadBehindRequest, FetchGitAheadBehindResponse> call);

        partial void Modify_CommitWorkspaceChangesApiCall(ref gaxgrpc::ApiCall<CommitWorkspaceChangesRequest, CommitWorkspaceChangesResponse> call);

        partial void Modify_ResetWorkspaceChangesApiCall(ref gaxgrpc::ApiCall<ResetWorkspaceChangesRequest, ResetWorkspaceChangesResponse> call);

        partial void Modify_FetchFileDiffApiCall(ref gaxgrpc::ApiCall<FetchFileDiffRequest, FetchFileDiffResponse> call);

        partial void Modify_QueryDirectoryContentsApiCall(ref gaxgrpc::ApiCall<QueryDirectoryContentsRequest, QueryDirectoryContentsResponse> call);

        partial void Modify_SearchFilesApiCall(ref gaxgrpc::ApiCall<SearchFilesRequest, SearchFilesResponse> call);

        partial void Modify_MakeDirectoryApiCall(ref gaxgrpc::ApiCall<MakeDirectoryRequest, MakeDirectoryResponse> call);

        partial void Modify_RemoveDirectoryApiCall(ref gaxgrpc::ApiCall<RemoveDirectoryRequest, RemoveDirectoryResponse> call);

        partial void Modify_MoveDirectoryApiCall(ref gaxgrpc::ApiCall<MoveDirectoryRequest, MoveDirectoryResponse> call);

        partial void Modify_ReadFileApiCall(ref gaxgrpc::ApiCall<ReadFileRequest, ReadFileResponse> call);

        partial void Modify_RemoveFileApiCall(ref gaxgrpc::ApiCall<RemoveFileRequest, RemoveFileResponse> call);

        partial void Modify_MoveFileApiCall(ref gaxgrpc::ApiCall<MoveFileRequest, MoveFileResponse> call);

        partial void Modify_WriteFileApiCall(ref gaxgrpc::ApiCall<WriteFileRequest, WriteFileResponse> call);

        partial void Modify_ListReleaseConfigsApiCall(ref gaxgrpc::ApiCall<ListReleaseConfigsRequest, ListReleaseConfigsResponse> call);

        partial void Modify_GetReleaseConfigApiCall(ref gaxgrpc::ApiCall<GetReleaseConfigRequest, ReleaseConfig> call);

        partial void Modify_CreateReleaseConfigApiCall(ref gaxgrpc::ApiCall<CreateReleaseConfigRequest, ReleaseConfig> call);

        partial void Modify_UpdateReleaseConfigApiCall(ref gaxgrpc::ApiCall<UpdateReleaseConfigRequest, ReleaseConfig> call);

        partial void Modify_DeleteReleaseConfigApiCall(ref gaxgrpc::ApiCall<DeleteReleaseConfigRequest, wkt::Empty> call);

        partial void Modify_ListCompilationResultsApiCall(ref gaxgrpc::ApiCall<ListCompilationResultsRequest, ListCompilationResultsResponse> call);

        partial void Modify_GetCompilationResultApiCall(ref gaxgrpc::ApiCall<GetCompilationResultRequest, CompilationResult> call);

        partial void Modify_CreateCompilationResultApiCall(ref gaxgrpc::ApiCall<CreateCompilationResultRequest, CompilationResult> call);

        partial void Modify_QueryCompilationResultActionsApiCall(ref gaxgrpc::ApiCall<QueryCompilationResultActionsRequest, QueryCompilationResultActionsResponse> call);

        partial void Modify_ListWorkflowConfigsApiCall(ref gaxgrpc::ApiCall<ListWorkflowConfigsRequest, ListWorkflowConfigsResponse> call);

        partial void Modify_GetWorkflowConfigApiCall(ref gaxgrpc::ApiCall<GetWorkflowConfigRequest, WorkflowConfig> call);

        partial void Modify_CreateWorkflowConfigApiCall(ref gaxgrpc::ApiCall<CreateWorkflowConfigRequest, WorkflowConfig> call);

        partial void Modify_UpdateWorkflowConfigApiCall(ref gaxgrpc::ApiCall<UpdateWorkflowConfigRequest, WorkflowConfig> call);

        partial void Modify_DeleteWorkflowConfigApiCall(ref gaxgrpc::ApiCall<DeleteWorkflowConfigRequest, wkt::Empty> call);

        partial void Modify_ListWorkflowInvocationsApiCall(ref gaxgrpc::ApiCall<ListWorkflowInvocationsRequest, ListWorkflowInvocationsResponse> call);

        partial void Modify_GetWorkflowInvocationApiCall(ref gaxgrpc::ApiCall<GetWorkflowInvocationRequest, WorkflowInvocation> call);

        partial void Modify_CreateWorkflowInvocationApiCall(ref gaxgrpc::ApiCall<CreateWorkflowInvocationRequest, WorkflowInvocation> call);

        partial void Modify_DeleteWorkflowInvocationApiCall(ref gaxgrpc::ApiCall<DeleteWorkflowInvocationRequest, wkt::Empty> call);

        partial void Modify_CancelWorkflowInvocationApiCall(ref gaxgrpc::ApiCall<CancelWorkflowInvocationRequest, CancelWorkflowInvocationResponse> call);

        partial void Modify_QueryWorkflowInvocationActionsApiCall(ref gaxgrpc::ApiCall<QueryWorkflowInvocationActionsRequest, QueryWorkflowInvocationActionsResponse> call);

        partial void Modify_GetConfigApiCall(ref gaxgrpc::ApiCall<GetConfigRequest, Config> call);

        partial void Modify_UpdateConfigApiCall(ref gaxgrpc::ApiCall<UpdateConfigRequest, Config> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(Dataform.DataformClient grpcClient, DataformSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Dataform client</summary>
        public override Dataform.DataformClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_GetTeamFolderRequest(ref GetTeamFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTeamFolderRequest(ref CreateTeamFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTeamFolderRequest(ref UpdateTeamFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTeamFolderRequest(ref DeleteTeamFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryTeamFolderContentsRequest(ref QueryTeamFolderContentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchTeamFoldersRequest(ref SearchTeamFoldersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFolderRequest(ref GetFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFolderRequest(ref CreateFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFolderRequest(ref UpdateFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFolderRequest(ref DeleteFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryFolderContentsRequest(ref QueryFolderContentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryUserRootContentsRequest(ref QueryUserRootContentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveFolderRequest(ref MoveFolderRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRepositoriesRequest(ref ListRepositoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRepositoryRequest(ref GetRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRepositoryRequest(ref CreateRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRepositoryRequest(ref UpdateRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRepositoryRequest(ref DeleteRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveRepositoryRequest(ref MoveRepositoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CommitRepositoryChangesRequest(ref CommitRepositoryChangesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadRepositoryFileRequest(ref ReadRepositoryFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryRepositoryDirectoryContentsRequest(ref QueryRepositoryDirectoryContentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchRepositoryHistoryRequest(ref FetchRepositoryHistoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ComputeRepositoryAccessTokenStatusRequest(ref ComputeRepositoryAccessTokenStatusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchRemoteBranchesRequest(ref FetchRemoteBranchesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkspacesRequest(ref ListWorkspacesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkspaceRequest(ref GetWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWorkspaceRequest(ref CreateWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkspaceRequest(ref DeleteWorkspaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InstallNpmPackagesRequest(ref InstallNpmPackagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PullGitCommitsRequest(ref PullGitCommitsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PushGitCommitsRequest(ref PushGitCommitsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchFileGitStatusesRequest(ref FetchFileGitStatusesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchGitAheadBehindRequest(ref FetchGitAheadBehindRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CommitWorkspaceChangesRequest(ref CommitWorkspaceChangesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetWorkspaceChangesRequest(ref ResetWorkspaceChangesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchFileDiffRequest(ref FetchFileDiffRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryDirectoryContentsRequest(ref QueryDirectoryContentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchFilesRequest(ref SearchFilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MakeDirectoryRequest(ref MakeDirectoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveDirectoryRequest(ref RemoveDirectoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveDirectoryRequest(ref MoveDirectoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadFileRequest(ref ReadFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveFileRequest(ref RemoveFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveFileRequest(ref MoveFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WriteFileRequest(ref WriteFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReleaseConfigsRequest(ref ListReleaseConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReleaseConfigRequest(ref GetReleaseConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReleaseConfigRequest(ref CreateReleaseConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReleaseConfigRequest(ref UpdateReleaseConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReleaseConfigRequest(ref DeleteReleaseConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCompilationResultsRequest(ref ListCompilationResultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCompilationResultRequest(ref GetCompilationResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCompilationResultRequest(ref CreateCompilationResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryCompilationResultActionsRequest(ref QueryCompilationResultActionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkflowConfigsRequest(ref ListWorkflowConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkflowConfigRequest(ref GetWorkflowConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWorkflowConfigRequest(ref CreateWorkflowConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkflowConfigRequest(ref UpdateWorkflowConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkflowConfigRequest(ref DeleteWorkflowConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkflowInvocationsRequest(ref ListWorkflowInvocationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkflowInvocationRequest(ref GetWorkflowInvocationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWorkflowInvocationRequest(ref CreateWorkflowInvocationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkflowInvocationRequest(ref DeleteWorkflowInvocationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelWorkflowInvocationRequest(ref CancelWorkflowInvocationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryWorkflowInvocationActionsRequest(ref QueryWorkflowInvocationActionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConfigRequest(ref GetConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConfigRequest(ref UpdateConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Fetches a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TeamFolder GetTeamFolder(GetTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTeamFolderRequest(ref request, ref callSettings);
            return _callGetTeamFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TeamFolder> GetTeamFolderAsync(GetTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTeamFolderRequest(ref request, ref callSettings);
            return _callGetTeamFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new TeamFolder in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TeamFolder CreateTeamFolder(CreateTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTeamFolderRequest(ref request, ref callSettings);
            return _callCreateTeamFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new TeamFolder in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TeamFolder> CreateTeamFolderAsync(CreateTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTeamFolderRequest(ref request, ref callSettings);
            return _callCreateTeamFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TeamFolder UpdateTeamFolder(UpdateTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTeamFolderRequest(ref request, ref callSettings);
            return _callUpdateTeamFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TeamFolder> UpdateTeamFolderAsync(UpdateTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTeamFolderRequest(ref request, ref callSettings);
            return _callUpdateTeamFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTeamFolder(DeleteTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTeamFolderRequest(ref request, ref callSettings);
            _callDeleteTeamFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTeamFolderAsync(DeleteTeamFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTeamFolderRequest(ref request, ref callSettings);
            return _callDeleteTeamFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry"/>
        /// resources.
        /// </returns>
        public override gax::PagedEnumerable<QueryTeamFolderContentsResponse, QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> QueryTeamFolderContents(QueryTeamFolderContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryTeamFolderContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryTeamFolderContentsRequest, QueryTeamFolderContentsResponse, QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry>(_callQueryTeamFolderContents, request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given TeamFolder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of
        /// <see cref="QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<QueryTeamFolderContentsResponse, QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry> QueryTeamFolderContentsAsync(QueryTeamFolderContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryTeamFolderContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryTeamFolderContentsRequest, QueryTeamFolderContentsResponse, QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry>(_callQueryTeamFolderContents, request, callSettings);
        }

        /// <summary>
        /// Returns all TeamFolders in a given location that the caller has access to
        /// and match the provided filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="SearchTeamFoldersResponse.Types.TeamFolderSearchResult"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<SearchTeamFoldersResponse, SearchTeamFoldersResponse.Types.TeamFolderSearchResult> SearchTeamFolders(SearchTeamFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchTeamFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchTeamFoldersRequest, SearchTeamFoldersResponse, SearchTeamFoldersResponse.Types.TeamFolderSearchResult>(_callSearchTeamFolders, request, callSettings);
        }

        /// <summary>
        /// Returns all TeamFolders in a given location that the caller has access to
        /// and match the provided filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchTeamFoldersResponse.Types.TeamFolderSearchResult"/>
        /// resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchTeamFoldersResponse, SearchTeamFoldersResponse.Types.TeamFolderSearchResult> SearchTeamFoldersAsync(SearchTeamFoldersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchTeamFoldersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchTeamFoldersRequest, SearchTeamFoldersResponse, SearchTeamFoldersResponse.Types.TeamFolderSearchResult>(_callSearchTeamFolders, request, callSettings);
        }

        /// <summary>
        /// Fetches a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Folder GetFolder(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFolderRequest(ref request, ref callSettings);
            return _callGetFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Folder> GetFolderAsync(GetFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFolderRequest(ref request, ref callSettings);
            return _callGetFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new Folder in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Folder CreateFolder(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFolderRequest(ref request, ref callSettings);
            return _callCreateFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Folder in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Folder> CreateFolderAsync(CreateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFolderRequest(ref request, ref callSettings);
            return _callCreateFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Folder UpdateFolder(UpdateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFolderRequest(ref request, ref callSettings);
            return _callUpdateFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Folder> UpdateFolderAsync(UpdateFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFolderRequest(ref request, ref callSettings);
            return _callUpdateFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteFolder(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFolderRequest(ref request, ref callSettings);
            _callDeleteFolder.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteFolderAsync(DeleteFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFolderRequest(ref request, ref callSettings);
            return _callDeleteFolder.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="QueryFolderContentsResponse.Types.FolderContentsEntry"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<QueryFolderContentsResponse, QueryFolderContentsResponse.Types.FolderContentsEntry> QueryFolderContents(QueryFolderContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryFolderContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryFolderContentsRequest, QueryFolderContentsResponse, QueryFolderContentsResponse.Types.FolderContentsEntry>(_callQueryFolderContents, request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given Folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="QueryFolderContentsResponse.Types.FolderContentsEntry"/>
        /// resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<QueryFolderContentsResponse, QueryFolderContentsResponse.Types.FolderContentsEntry> QueryFolderContentsAsync(QueryFolderContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryFolderContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryFolderContentsRequest, QueryFolderContentsResponse, QueryFolderContentsResponse.Types.FolderContentsEntry>(_callQueryFolderContents, request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a caller's root folder in a given location.
        /// The root folder contains all resources that are created by the user and not
        /// contained in any other folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="QueryUserRootContentsResponse.Types.RootContentsEntry"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<QueryUserRootContentsResponse, QueryUserRootContentsResponse.Types.RootContentsEntry> QueryUserRootContents(QueryUserRootContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryUserRootContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryUserRootContentsRequest, QueryUserRootContentsResponse, QueryUserRootContentsResponse.Types.RootContentsEntry>(_callQueryUserRootContents, request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a caller's root folder in a given location.
        /// The root folder contains all resources that are created by the user and not
        /// contained in any other folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="QueryUserRootContentsResponse.Types.RootContentsEntry"/>
        /// resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<QueryUserRootContentsResponse, QueryUserRootContentsResponse.Types.RootContentsEntry> QueryUserRootContentsAsync(QueryUserRootContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryUserRootContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryUserRootContentsRequest, QueryUserRootContentsResponse, QueryUserRootContentsResponse.Types.RootContentsEntry>(_callQueryUserRootContents, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>MoveFolder</c>.</summary>
        public override lro::OperationsClient MoveFolderOperationsClient { get; }

        /// <summary>
        /// Moves a Folder to a new Folder, TeamFolder, or the root location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, MoveFolderMetadata> MoveFolder(MoveFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveFolderRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, MoveFolderMetadata>(_callMoveFolder.Sync(request, callSettings), MoveFolderOperationsClient);
        }

        /// <summary>
        /// Moves a Folder to a new Folder, TeamFolder, or the root location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, MoveFolderMetadata>> MoveFolderAsync(MoveFolderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveFolderRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, MoveFolderMetadata>(await _callMoveFolder.Async(request, callSettings).ConfigureAwait(false), MoveFolderOperationsClient);
        }

        /// <summary>
        /// Lists Repositories in a given project and location.
        /// 
        /// **Note:** *This method can return repositories not shown in the [Dataform
        /// UI](https://console.cloud.google.com/bigquery/dataform)*.
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
        /// Lists Repositories in a given project and location.
        /// 
        /// **Note:** *This method can return repositories not shown in the [Dataform
        /// UI](https://console.cloud.google.com/bigquery/dataform)*.
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
        /// Fetches a single Repository.
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
        /// Fetches a single Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Repository> GetRepositoryAsync(GetRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRepositoryRequest(ref request, ref callSettings);
            return _callGetRepository.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new Repository in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Repository CreateRepository(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRepositoryRequest(ref request, ref callSettings);
            return _callCreateRepository.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Repository in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Repository> CreateRepositoryAsync(CreateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRepositoryRequest(ref request, ref callSettings);
            return _callCreateRepository.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single Repository.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
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
        /// Updates a single Repository.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Repository> UpdateRepositoryAsync(UpdateRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRepositoryRequest(ref request, ref callSettings);
            return _callUpdateRepository.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteRepository(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRepositoryRequest(ref request, ref callSettings);
            _callDeleteRepository.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteRepositoryAsync(DeleteRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRepositoryRequest(ref request, ref callSettings);
            return _callDeleteRepository.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>MoveRepository</c>.</summary>
        public override lro::OperationsClient MoveRepositoryOperationsClient { get; }

        /// <summary>
        /// Moves a Repository to a new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, MoveRepositoryMetadata> MoveRepository(MoveRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, MoveRepositoryMetadata>(_callMoveRepository.Sync(request, callSettings), MoveRepositoryOperationsClient);
        }

        /// <summary>
        /// Moves a Repository to a new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, MoveRepositoryMetadata>> MoveRepositoryAsync(MoveRepositoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveRepositoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, MoveRepositoryMetadata>(await _callMoveRepository.Async(request, callSettings).ConfigureAwait(false), MoveRepositoryOperationsClient);
        }

        /// <summary>
        /// Applies a Git commit to a Repository. The Repository must not have a value
        /// for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CommitRepositoryChangesResponse CommitRepositoryChanges(CommitRepositoryChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRepositoryChangesRequest(ref request, ref callSettings);
            return _callCommitRepositoryChanges.Sync(request, callSettings);
        }

        /// <summary>
        /// Applies a Git commit to a Repository. The Repository must not have a value
        /// for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CommitRepositoryChangesResponse> CommitRepositoryChangesAsync(CommitRepositoryChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRepositoryChangesRequest(ref request, ref callSettings);
            return _callCommitRepositoryChanges.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a file (inside a Repository). The Repository
        /// must not have a value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReadRepositoryFileResponse ReadRepositoryFile(ReadRepositoryFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRepositoryFileRequest(ref request, ref callSettings);
            return _callReadRepositoryFile.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a file (inside a Repository). The Repository
        /// must not have a value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReadRepositoryFileResponse> ReadRepositoryFileAsync(ReadRepositoryFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRepositoryFileRequest(ref request, ref callSettings);
            return _callReadRepositoryFile.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given Repository directory. The Repository must
        /// not have a value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DirectoryEntry"/> resources.</returns>
        public override gax::PagedEnumerable<QueryRepositoryDirectoryContentsResponse, DirectoryEntry> QueryRepositoryDirectoryContents(QueryRepositoryDirectoryContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryRepositoryDirectoryContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryRepositoryDirectoryContentsRequest, QueryRepositoryDirectoryContentsResponse, DirectoryEntry>(_callQueryRepositoryDirectoryContents, request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given Repository directory. The Repository must
        /// not have a value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DirectoryEntry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryRepositoryDirectoryContentsResponse, DirectoryEntry> QueryRepositoryDirectoryContentsAsync(QueryRepositoryDirectoryContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryRepositoryDirectoryContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryRepositoryDirectoryContentsRequest, QueryRepositoryDirectoryContentsResponse, DirectoryEntry>(_callQueryRepositoryDirectoryContents, request, callSettings);
        }

        /// <summary>
        /// Fetches a Repository's history of commits.  The Repository must not have a
        /// value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CommitLogEntry"/> resources.</returns>
        public override gax::PagedEnumerable<FetchRepositoryHistoryResponse, CommitLogEntry> FetchRepositoryHistory(FetchRepositoryHistoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchRepositoryHistoryRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchRepositoryHistoryRequest, FetchRepositoryHistoryResponse, CommitLogEntry>(_callFetchRepositoryHistory, request, callSettings);
        }

        /// <summary>
        /// Fetches a Repository's history of commits.  The Repository must not have a
        /// value for `git_remote_settings.url`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CommitLogEntry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchRepositoryHistoryResponse, CommitLogEntry> FetchRepositoryHistoryAsync(FetchRepositoryHistoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchRepositoryHistoryRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchRepositoryHistoryRequest, FetchRepositoryHistoryResponse, CommitLogEntry>(_callFetchRepositoryHistory, request, callSettings);
        }

        /// <summary>
        /// Computes a Repository's Git access token status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComputeRepositoryAccessTokenStatusResponse ComputeRepositoryAccessTokenStatus(ComputeRepositoryAccessTokenStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeRepositoryAccessTokenStatusRequest(ref request, ref callSettings);
            return _callComputeRepositoryAccessTokenStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// Computes a Repository's Git access token status.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComputeRepositoryAccessTokenStatusResponse> ComputeRepositoryAccessTokenStatusAsync(ComputeRepositoryAccessTokenStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeRepositoryAccessTokenStatusRequest(ref request, ref callSettings);
            return _callComputeRepositoryAccessTokenStatus.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches a Repository's remote branches.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchRemoteBranchesResponse FetchRemoteBranches(FetchRemoteBranchesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchRemoteBranchesRequest(ref request, ref callSettings);
            return _callFetchRemoteBranches.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a Repository's remote branches.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchRemoteBranchesResponse> FetchRemoteBranchesAsync(FetchRemoteBranchesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchRemoteBranchesRequest(ref request, ref callSettings);
            return _callFetchRemoteBranches.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Workspaces in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workspace"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkspacesResponse, Workspace> ListWorkspaces(ListWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkspacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkspacesRequest, ListWorkspacesResponse, Workspace>(_callListWorkspaces, request, callSettings);
        }

        /// <summary>
        /// Lists Workspaces in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workspace"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkspacesResponse, Workspace> ListWorkspacesAsync(ListWorkspacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkspacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkspacesRequest, ListWorkspacesResponse, Workspace>(_callListWorkspaces, request, callSettings);
        }

        /// <summary>
        /// Fetches a single Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Workspace GetWorkspace(GetWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkspaceRequest(ref request, ref callSettings);
            return _callGetWorkspace.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Workspace> GetWorkspaceAsync(GetWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkspaceRequest(ref request, ref callSettings);
            return _callGetWorkspace.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new Workspace in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Workspace CreateWorkspace(CreateWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkspaceRequest(ref request, ref callSettings);
            return _callCreateWorkspace.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Workspace in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Workspace> CreateWorkspaceAsync(CreateWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkspaceRequest(ref request, ref callSettings);
            return _callCreateWorkspace.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteWorkspace(DeleteWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkspaceRequest(ref request, ref callSettings);
            _callDeleteWorkspace.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteWorkspaceAsync(DeleteWorkspaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkspaceRequest(ref request, ref callSettings);
            return _callDeleteWorkspace.Async(request, callSettings);
        }

        /// <summary>
        /// Installs dependency NPM packages (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstallNpmPackagesResponse InstallNpmPackages(InstallNpmPackagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstallNpmPackagesRequest(ref request, ref callSettings);
            return _callInstallNpmPackages.Sync(request, callSettings);
        }

        /// <summary>
        /// Installs dependency NPM packages (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstallNpmPackagesResponse> InstallNpmPackagesAsync(InstallNpmPackagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstallNpmPackagesRequest(ref request, ref callSettings);
            return _callInstallNpmPackages.Async(request, callSettings);
        }

        /// <summary>
        /// Pulls Git commits from the Repository's remote into a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PullGitCommitsResponse PullGitCommits(PullGitCommitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PullGitCommitsRequest(ref request, ref callSettings);
            return _callPullGitCommits.Sync(request, callSettings);
        }

        /// <summary>
        /// Pulls Git commits from the Repository's remote into a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PullGitCommitsResponse> PullGitCommitsAsync(PullGitCommitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PullGitCommitsRequest(ref request, ref callSettings);
            return _callPullGitCommits.Async(request, callSettings);
        }

        /// <summary>
        /// Pushes Git commits from a Workspace to the Repository's remote.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PushGitCommitsResponse PushGitCommits(PushGitCommitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PushGitCommitsRequest(ref request, ref callSettings);
            return _callPushGitCommits.Sync(request, callSettings);
        }

        /// <summary>
        /// Pushes Git commits from a Workspace to the Repository's remote.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PushGitCommitsResponse> PushGitCommitsAsync(PushGitCommitsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PushGitCommitsRequest(ref request, ref callSettings);
            return _callPushGitCommits.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches Git statuses for the files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchFileGitStatusesResponse FetchFileGitStatuses(FetchFileGitStatusesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchFileGitStatusesRequest(ref request, ref callSettings);
            return _callFetchFileGitStatuses.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches Git statuses for the files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchFileGitStatusesResponse> FetchFileGitStatusesAsync(FetchFileGitStatusesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchFileGitStatusesRequest(ref request, ref callSettings);
            return _callFetchFileGitStatuses.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches Git ahead/behind against a remote branch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchGitAheadBehindResponse FetchGitAheadBehind(FetchGitAheadBehindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchGitAheadBehindRequest(ref request, ref callSettings);
            return _callFetchGitAheadBehind.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches Git ahead/behind against a remote branch.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchGitAheadBehindResponse> FetchGitAheadBehindAsync(FetchGitAheadBehindRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchGitAheadBehindRequest(ref request, ref callSettings);
            return _callFetchGitAheadBehind.Async(request, callSettings);
        }

        /// <summary>
        /// Applies a Git commit for uncommitted files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CommitWorkspaceChangesResponse CommitWorkspaceChanges(CommitWorkspaceChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitWorkspaceChangesRequest(ref request, ref callSettings);
            return _callCommitWorkspaceChanges.Sync(request, callSettings);
        }

        /// <summary>
        /// Applies a Git commit for uncommitted files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CommitWorkspaceChangesResponse> CommitWorkspaceChangesAsync(CommitWorkspaceChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitWorkspaceChangesRequest(ref request, ref callSettings);
            return _callCommitWorkspaceChanges.Async(request, callSettings);
        }

        /// <summary>
        /// Performs a Git reset for uncommitted files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResetWorkspaceChangesResponse ResetWorkspaceChanges(ResetWorkspaceChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetWorkspaceChangesRequest(ref request, ref callSettings);
            return _callResetWorkspaceChanges.Sync(request, callSettings);
        }

        /// <summary>
        /// Performs a Git reset for uncommitted files in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResetWorkspaceChangesResponse> ResetWorkspaceChangesAsync(ResetWorkspaceChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetWorkspaceChangesRequest(ref request, ref callSettings);
            return _callResetWorkspaceChanges.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches Git diff for an uncommitted file in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchFileDiffResponse FetchFileDiff(FetchFileDiffRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchFileDiffRequest(ref request, ref callSettings);
            return _callFetchFileDiff.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches Git diff for an uncommitted file in a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchFileDiffResponse> FetchFileDiffAsync(FetchFileDiffRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchFileDiffRequest(ref request, ref callSettings);
            return _callFetchFileDiff.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given Workspace directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DirectoryEntry"/> resources.</returns>
        public override gax::PagedEnumerable<QueryDirectoryContentsResponse, DirectoryEntry> QueryDirectoryContents(QueryDirectoryContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryDirectoryContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryDirectoryContentsRequest, QueryDirectoryContentsResponse, DirectoryEntry>(_callQueryDirectoryContents, request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a given Workspace directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DirectoryEntry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryDirectoryContentsResponse, DirectoryEntry> QueryDirectoryContentsAsync(QueryDirectoryContentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryDirectoryContentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryDirectoryContentsRequest, QueryDirectoryContentsResponse, DirectoryEntry>(_callQueryDirectoryContents, request, callSettings);
        }

        /// <summary>
        /// Finds the contents of a given Workspace directory by filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchResult"/> resources.</returns>
        public override gax::PagedEnumerable<SearchFilesResponse, SearchResult> SearchFiles(SearchFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchFilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchFilesRequest, SearchFilesResponse, SearchResult>(_callSearchFiles, request, callSettings);
        }

        /// <summary>
        /// Finds the contents of a given Workspace directory by filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchFilesResponse, SearchResult> SearchFilesAsync(SearchFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchFilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchFilesRequest, SearchFilesResponse, SearchResult>(_callSearchFiles, request, callSettings);
        }

        /// <summary>
        /// Creates a directory inside a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MakeDirectoryResponse MakeDirectory(MakeDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MakeDirectoryRequest(ref request, ref callSettings);
            return _callMakeDirectory.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a directory inside a Workspace.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MakeDirectoryResponse> MakeDirectoryAsync(MakeDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MakeDirectoryRequest(ref request, ref callSettings);
            return _callMakeDirectory.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a directory (inside a Workspace) and all of its contents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveDirectoryResponse RemoveDirectory(RemoveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveDirectoryRequest(ref request, ref callSettings);
            return _callRemoveDirectory.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a directory (inside a Workspace) and all of its contents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveDirectoryResponse> RemoveDirectoryAsync(RemoveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveDirectoryRequest(ref request, ref callSettings);
            return _callRemoveDirectory.Async(request, callSettings);
        }

        /// <summary>
        /// Moves a directory (inside a Workspace), and all of its contents, to a new
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MoveDirectoryResponse MoveDirectory(MoveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveDirectoryRequest(ref request, ref callSettings);
            return _callMoveDirectory.Sync(request, callSettings);
        }

        /// <summary>
        /// Moves a directory (inside a Workspace), and all of its contents, to a new
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MoveDirectoryResponse> MoveDirectoryAsync(MoveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveDirectoryRequest(ref request, ref callSettings);
            return _callMoveDirectory.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReadFileResponse ReadFile(ReadFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadFileRequest(ref request, ref callSettings);
            return _callReadFile.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the contents of a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReadFileResponse> ReadFileAsync(ReadFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadFileRequest(ref request, ref callSettings);
            return _callReadFile.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveFileResponse RemoveFile(RemoveFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveFileRequest(ref request, ref callSettings);
            return _callRemoveFile.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveFileResponse> RemoveFileAsync(RemoveFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveFileRequest(ref request, ref callSettings);
            return _callRemoveFile.Async(request, callSettings);
        }

        /// <summary>
        /// Moves a file (inside a Workspace) to a new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MoveFileResponse MoveFile(MoveFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveFileRequest(ref request, ref callSettings);
            return _callMoveFile.Sync(request, callSettings);
        }

        /// <summary>
        /// Moves a file (inside a Workspace) to a new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MoveFileResponse> MoveFileAsync(MoveFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveFileRequest(ref request, ref callSettings);
            return _callMoveFile.Async(request, callSettings);
        }

        /// <summary>
        /// Writes to a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WriteFileResponse WriteFile(WriteFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteFileRequest(ref request, ref callSettings);
            return _callWriteFile.Sync(request, callSettings);
        }

        /// <summary>
        /// Writes to a file (inside a Workspace).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WriteFileResponse> WriteFileAsync(WriteFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteFileRequest(ref request, ref callSettings);
            return _callWriteFile.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ReleaseConfigs in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReleaseConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListReleaseConfigsResponse, ReleaseConfig> ListReleaseConfigs(ListReleaseConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReleaseConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReleaseConfigsRequest, ListReleaseConfigsResponse, ReleaseConfig>(_callListReleaseConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists ReleaseConfigs in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReleaseConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReleaseConfigsResponse, ReleaseConfig> ListReleaseConfigsAsync(ListReleaseConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReleaseConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReleaseConfigsRequest, ListReleaseConfigsResponse, ReleaseConfig>(_callListReleaseConfigs, request, callSettings);
        }

        /// <summary>
        /// Fetches a single ReleaseConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReleaseConfig GetReleaseConfig(GetReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReleaseConfigRequest(ref request, ref callSettings);
            return _callGetReleaseConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single ReleaseConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReleaseConfig> GetReleaseConfigAsync(GetReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReleaseConfigRequest(ref request, ref callSettings);
            return _callGetReleaseConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new ReleaseConfig in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReleaseConfig CreateReleaseConfig(CreateReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReleaseConfigRequest(ref request, ref callSettings);
            return _callCreateReleaseConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new ReleaseConfig in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReleaseConfig> CreateReleaseConfigAsync(CreateReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReleaseConfigRequest(ref request, ref callSettings);
            return _callCreateReleaseConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single ReleaseConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReleaseConfig UpdateReleaseConfig(UpdateReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReleaseConfigRequest(ref request, ref callSettings);
            return _callUpdateReleaseConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a single ReleaseConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReleaseConfig> UpdateReleaseConfigAsync(UpdateReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReleaseConfigRequest(ref request, ref callSettings);
            return _callUpdateReleaseConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single ReleaseConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteReleaseConfig(DeleteReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReleaseConfigRequest(ref request, ref callSettings);
            _callDeleteReleaseConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single ReleaseConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteReleaseConfigAsync(DeleteReleaseConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReleaseConfigRequest(ref request, ref callSettings);
            return _callDeleteReleaseConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists CompilationResults in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CompilationResult"/> resources.</returns>
        public override gax::PagedEnumerable<ListCompilationResultsResponse, CompilationResult> ListCompilationResults(ListCompilationResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCompilationResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCompilationResultsRequest, ListCompilationResultsResponse, CompilationResult>(_callListCompilationResults, request, callSettings);
        }

        /// <summary>
        /// Lists CompilationResults in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CompilationResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCompilationResultsResponse, CompilationResult> ListCompilationResultsAsync(ListCompilationResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCompilationResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCompilationResultsRequest, ListCompilationResultsResponse, CompilationResult>(_callListCompilationResults, request, callSettings);
        }

        /// <summary>
        /// Fetches a single CompilationResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CompilationResult GetCompilationResult(GetCompilationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompilationResultRequest(ref request, ref callSettings);
            return _callGetCompilationResult.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single CompilationResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CompilationResult> GetCompilationResultAsync(GetCompilationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompilationResultRequest(ref request, ref callSettings);
            return _callGetCompilationResult.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new CompilationResult in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CompilationResult CreateCompilationResult(CreateCompilationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCompilationResultRequest(ref request, ref callSettings);
            return _callCreateCompilationResult.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new CompilationResult in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CompilationResult> CreateCompilationResultAsync(CreateCompilationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCompilationResultRequest(ref request, ref callSettings);
            return _callCreateCompilationResult.Async(request, callSettings);
        }

        /// <summary>
        /// Returns CompilationResultActions in a given CompilationResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CompilationResultAction"/> resources.</returns>
        public override gax::PagedEnumerable<QueryCompilationResultActionsResponse, CompilationResultAction> QueryCompilationResultActions(QueryCompilationResultActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryCompilationResultActionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryCompilationResultActionsRequest, QueryCompilationResultActionsResponse, CompilationResultAction>(_callQueryCompilationResultActions, request, callSettings);
        }

        /// <summary>
        /// Returns CompilationResultActions in a given CompilationResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CompilationResultAction"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryCompilationResultActionsResponse, CompilationResultAction> QueryCompilationResultActionsAsync(QueryCompilationResultActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryCompilationResultActionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryCompilationResultActionsRequest, QueryCompilationResultActionsResponse, CompilationResultAction>(_callQueryCompilationResultActions, request, callSettings);
        }

        /// <summary>
        /// Lists WorkflowConfigs in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkflowConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkflowConfigsResponse, WorkflowConfig> ListWorkflowConfigs(ListWorkflowConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkflowConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkflowConfigsRequest, ListWorkflowConfigsResponse, WorkflowConfig>(_callListWorkflowConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists WorkflowConfigs in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkflowConfigsResponse, WorkflowConfig> ListWorkflowConfigsAsync(ListWorkflowConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkflowConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkflowConfigsRequest, ListWorkflowConfigsResponse, WorkflowConfig>(_callListWorkflowConfigs, request, callSettings);
        }

        /// <summary>
        /// Fetches a single WorkflowConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkflowConfig GetWorkflowConfig(GetWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkflowConfigRequest(ref request, ref callSettings);
            return _callGetWorkflowConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single WorkflowConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkflowConfig> GetWorkflowConfigAsync(GetWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkflowConfigRequest(ref request, ref callSettings);
            return _callGetWorkflowConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new WorkflowConfig in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkflowConfig CreateWorkflowConfig(CreateWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkflowConfigRequest(ref request, ref callSettings);
            return _callCreateWorkflowConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new WorkflowConfig in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkflowConfig> CreateWorkflowConfigAsync(CreateWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkflowConfigRequest(ref request, ref callSettings);
            return _callCreateWorkflowConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single WorkflowConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkflowConfig UpdateWorkflowConfig(UpdateWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkflowConfigRequest(ref request, ref callSettings);
            return _callUpdateWorkflowConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a single WorkflowConfig.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkflowConfig> UpdateWorkflowConfigAsync(UpdateWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkflowConfigRequest(ref request, ref callSettings);
            return _callUpdateWorkflowConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single WorkflowConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteWorkflowConfig(DeleteWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkflowConfigRequest(ref request, ref callSettings);
            _callDeleteWorkflowConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single WorkflowConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteWorkflowConfigAsync(DeleteWorkflowConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkflowConfigRequest(ref request, ref callSettings);
            return _callDeleteWorkflowConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists WorkflowInvocations in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkflowInvocation"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> ListWorkflowInvocations(ListWorkflowInvocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkflowInvocationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkflowInvocationsRequest, ListWorkflowInvocationsResponse, WorkflowInvocation>(_callListWorkflowInvocations, request, callSettings);
        }

        /// <summary>
        /// Lists WorkflowInvocations in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowInvocation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkflowInvocationsResponse, WorkflowInvocation> ListWorkflowInvocationsAsync(ListWorkflowInvocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkflowInvocationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkflowInvocationsRequest, ListWorkflowInvocationsResponse, WorkflowInvocation>(_callListWorkflowInvocations, request, callSettings);
        }

        /// <summary>
        /// Fetches a single WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkflowInvocation GetWorkflowInvocation(GetWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkflowInvocationRequest(ref request, ref callSettings);
            return _callGetWorkflowInvocation.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a single WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkflowInvocation> GetWorkflowInvocationAsync(GetWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkflowInvocationRequest(ref request, ref callSettings);
            return _callGetWorkflowInvocation.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new WorkflowInvocation in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkflowInvocation CreateWorkflowInvocation(CreateWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkflowInvocationRequest(ref request, ref callSettings);
            return _callCreateWorkflowInvocation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new WorkflowInvocation in a given Repository.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkflowInvocation> CreateWorkflowInvocationAsync(CreateWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkflowInvocationRequest(ref request, ref callSettings);
            return _callCreateWorkflowInvocation.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteWorkflowInvocation(DeleteWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkflowInvocationRequest(ref request, ref callSettings);
            _callDeleteWorkflowInvocation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteWorkflowInvocationAsync(DeleteWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkflowInvocationRequest(ref request, ref callSettings);
            return _callDeleteWorkflowInvocation.Async(request, callSettings);
        }

        /// <summary>
        /// Requests cancellation of a running WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CancelWorkflowInvocationResponse CancelWorkflowInvocation(CancelWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelWorkflowInvocationRequest(ref request, ref callSettings);
            return _callCancelWorkflowInvocation.Sync(request, callSettings);
        }

        /// <summary>
        /// Requests cancellation of a running WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CancelWorkflowInvocationResponse> CancelWorkflowInvocationAsync(CancelWorkflowInvocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelWorkflowInvocationRequest(ref request, ref callSettings);
            return _callCancelWorkflowInvocation.Async(request, callSettings);
        }

        /// <summary>
        /// Returns WorkflowInvocationActions in a given WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkflowInvocationAction"/> resources.</returns>
        public override gax::PagedEnumerable<QueryWorkflowInvocationActionsResponse, WorkflowInvocationAction> QueryWorkflowInvocationActions(QueryWorkflowInvocationActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryWorkflowInvocationActionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryWorkflowInvocationActionsRequest, QueryWorkflowInvocationActionsResponse, WorkflowInvocationAction>(_callQueryWorkflowInvocationActions, request, callSettings);
        }

        /// <summary>
        /// Returns WorkflowInvocationActions in a given WorkflowInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkflowInvocationAction"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryWorkflowInvocationActionsResponse, WorkflowInvocationAction> QueryWorkflowInvocationActionsAsync(QueryWorkflowInvocationActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryWorkflowInvocationActionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryWorkflowInvocationActionsRequest, QueryWorkflowInvocationActionsResponse, WorkflowInvocationAction>(_callQueryWorkflowInvocationActions, request, callSettings);
        }

        /// <summary>
        /// Get default config for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Config GetConfig(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConfigRequest(ref request, ref callSettings);
            return _callGetConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Get default config for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Config> GetConfigAsync(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConfigRequest(ref request, ref callSettings);
            return _callGetConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Update default config for a given project and location.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Config UpdateConfig(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConfigRequest(ref request, ref callSettings);
            return _callUpdateConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Update default config for a given project and location.
        /// 
        /// **Note:** *This method does not fully implement
        /// [AIP/134](https://google.aip.dev/134). The wildcard entry (\*) is treated
        /// as a bad request, and when the `field_mask` is omitted, the request is
        /// treated as a full update on all modifiable fields.*
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Config> UpdateConfigAsync(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConfigRequest(ref request, ref callSettings);
            return _callUpdateConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
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
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
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
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// 
        /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
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
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// 
        /// Can return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
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
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a `NOT_FOUND` error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
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
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a `NOT_FOUND` error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class QueryTeamFolderContentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchTeamFoldersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryFolderContentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryUserRootContentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRepositoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryRepositoryDirectoryContentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchRepositoryHistoryRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkspacesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryDirectoryContentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchFilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReleaseConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCompilationResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryCompilationResultActionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkflowConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkflowInvocationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryWorkflowInvocationActionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryTeamFolderContentsResponse : gaxgrpc::IPageResponse<QueryTeamFolderContentsResponse.Types.TeamFolderContentsEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.TeamFolderContentsEntry> GetEnumerator() => Entries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchTeamFoldersResponse : gaxgrpc::IPageResponse<SearchTeamFoldersResponse.Types.TeamFolderSearchResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.TeamFolderSearchResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class QueryFolderContentsResponse : gaxgrpc::IPageResponse<QueryFolderContentsResponse.Types.FolderContentsEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.FolderContentsEntry> GetEnumerator() => Entries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class QueryUserRootContentsResponse : gaxgrpc::IPageResponse<QueryUserRootContentsResponse.Types.RootContentsEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.RootContentsEntry> GetEnumerator() => Entries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRepositoriesResponse : gaxgrpc::IPageResponse<Repository>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Repository> GetEnumerator() => Repositories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class QueryRepositoryDirectoryContentsResponse : gaxgrpc::IPageResponse<DirectoryEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DirectoryEntry> GetEnumerator() => DirectoryEntries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchRepositoryHistoryResponse : gaxgrpc::IPageResponse<CommitLogEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CommitLogEntry> GetEnumerator() => Commits.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListWorkspacesResponse : gaxgrpc::IPageResponse<Workspace>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Workspace> GetEnumerator() => Workspaces.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class QueryDirectoryContentsResponse : gaxgrpc::IPageResponse<DirectoryEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DirectoryEntry> GetEnumerator() => DirectoryEntries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchFilesResponse : gaxgrpc::IPageResponse<SearchResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SearchResult> GetEnumerator() => SearchResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReleaseConfigsResponse : gaxgrpc::IPageResponse<ReleaseConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReleaseConfig> GetEnumerator() => ReleaseConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCompilationResultsResponse : gaxgrpc::IPageResponse<CompilationResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CompilationResult> GetEnumerator() => CompilationResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class QueryCompilationResultActionsResponse : gaxgrpc::IPageResponse<CompilationResultAction>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CompilationResultAction> GetEnumerator() => CompilationResultActions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListWorkflowConfigsResponse : gaxgrpc::IPageResponse<WorkflowConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkflowConfig> GetEnumerator() => WorkflowConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListWorkflowInvocationsResponse : gaxgrpc::IPageResponse<WorkflowInvocation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkflowInvocation> GetEnumerator() => WorkflowInvocations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class QueryWorkflowInvocationActionsResponse : gaxgrpc::IPageResponse<WorkflowInvocationAction>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkflowInvocationAction> GetEnumerator() => WorkflowInvocationActions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Dataform
    {
        public partial class DataformClient
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

    public static partial class Dataform
    {
        public partial class DataformClient
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
