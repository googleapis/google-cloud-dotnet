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
using gccv = Google.Cloud.CloudDms.V1;

namespace Google.Cloud.CloudDms.V1
{
    public partial class ListMigrationJobsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetMigrationJobRequest
    {
        /// <summary>
        /// <see cref="gccv::MigrationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::MigrationJobName MigrationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::MigrationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMigrationJobRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMigrationJobRequest
    {
        /// <summary>
        /// <see cref="gccv::MigrationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::MigrationJobName MigrationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::MigrationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StartMigrationJobRequest
    {
        /// <summary>
        /// <see cref="gccv::MigrationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::MigrationJobName MigrationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::MigrationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StopMigrationJobRequest
    {
        /// <summary>
        /// <see cref="gccv::MigrationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::MigrationJobName MigrationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::MigrationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResumeMigrationJobRequest
    {
        /// <summary>
        /// <see cref="gccv::MigrationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::MigrationJobName MigrationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::MigrationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PromoteMigrationJobRequest
    {
        /// <summary>
        /// <see cref="gccv::MigrationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::MigrationJobName MigrationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::MigrationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class VerifyMigrationJobRequest
    {
        /// <summary>
        /// <see cref="gccv::MigrationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::MigrationJobName MigrationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::MigrationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RestartMigrationJobRequest
    {
        /// <summary>
        /// <see cref="gccv::MigrationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::MigrationJobName MigrationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::MigrationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateSshScriptRequest
    {
        /// <summary>
        /// <see cref="MigrationJobName"/>-typed view over the <see cref="MigrationJob"/> resource name property.
        /// </summary>
        public MigrationJobName MigrationJobAsMigrationJobName
        {
            get => string.IsNullOrEmpty(MigrationJob) ? null : MigrationJobName.Parse(MigrationJob, allowUnparsed: true);
            set => MigrationJob = value?.ToString() ?? "";
        }
    }

    public partial class GenerateTcpProxyScriptRequest
    {
        /// <summary>
        /// <see cref="MigrationJobName"/>-typed view over the <see cref="MigrationJob"/> resource name property.
        /// </summary>
        public MigrationJobName MigrationJobAsMigrationJobName
        {
            get => string.IsNullOrEmpty(MigrationJob) ? null : MigrationJobName.Parse(MigrationJob, allowUnparsed: true);
            set => MigrationJob = value?.ToString() ?? "";
        }
    }

    public partial class ListConnectionProfilesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetConnectionProfileRequest
    {
        /// <summary>
        /// <see cref="gccv::ConnectionProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConnectionProfileName ConnectionProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConnectionProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateConnectionProfileRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteConnectionProfileRequest
    {
        /// <summary>
        /// <see cref="gccv::ConnectionProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConnectionProfileName ConnectionProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConnectionProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePrivateConnectionRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListPrivateConnectionsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePrivateConnectionRequest
    {
        /// <summary>
        /// <see cref="gccv::PrivateConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PrivateConnectionName PrivateConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PrivateConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetPrivateConnectionRequest
    {
        /// <summary>
        /// <see cref="gccv::PrivateConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PrivateConnectionName PrivateConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PrivateConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConversionWorkspacesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetConversionWorkspaceRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversionWorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversionWorkspaceName ConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversionWorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateConversionWorkspaceRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteConversionWorkspaceRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversionWorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversionWorkspaceName ConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversionWorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CommitConversionWorkspaceRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversionWorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversionWorkspaceName ConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversionWorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RollbackConversionWorkspaceRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversionWorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversionWorkspaceName ConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversionWorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ApplyConversionWorkspaceRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversionWorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversionWorkspaceName ConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversionWorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMappingRulesRequest
    {
        /// <summary>
        /// <see cref="ConversionWorkspaceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConversionWorkspaceName ParentAsConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConversionWorkspaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetMappingRuleRequest
    {
        /// <summary>
        /// <see cref="gccv::MappingRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::MappingRuleName MappingRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::MappingRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SeedConversionWorkspaceRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversionWorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversionWorkspaceName ConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversionWorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ConvertConversionWorkspaceRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversionWorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversionWorkspaceName ConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversionWorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportMappingRulesRequest
    {
        /// <summary>
        /// <see cref="ConversionWorkspaceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConversionWorkspaceName ParentAsConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConversionWorkspaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DescribeDatabaseEntitiesRequest
    {
        /// <summary>
        /// <see cref="ConversionWorkspaceName"/>-typed view over the <see cref="ConversionWorkspace"/> resource name
        /// property.
        /// </summary>
        public ConversionWorkspaceName ConversionWorkspaceAsConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(ConversionWorkspace) ? null : ConversionWorkspaceName.Parse(ConversionWorkspace, allowUnparsed: true);
            set => ConversionWorkspace = value?.ToString() ?? "";
        }
    }

    public partial class SearchBackgroundJobsRequest
    {
        /// <summary>
        /// <see cref="ConversionWorkspaceName"/>-typed view over the <see cref="ConversionWorkspace"/> resource name
        /// property.
        /// </summary>
        public ConversionWorkspaceName ConversionWorkspaceAsConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(ConversionWorkspace) ? null : ConversionWorkspaceName.Parse(ConversionWorkspace, allowUnparsed: true);
            set => ConversionWorkspace = value?.ToString() ?? "";
        }
    }

    public partial class DescribeConversionWorkspaceRevisionsRequest
    {
        /// <summary>
        /// <see cref="ConversionWorkspaceName"/>-typed view over the <see cref="ConversionWorkspace"/> resource name
        /// property.
        /// </summary>
        public ConversionWorkspaceName ConversionWorkspaceAsConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(ConversionWorkspace) ? null : ConversionWorkspaceName.Parse(ConversionWorkspace, allowUnparsed: true);
            set => ConversionWorkspace = value?.ToString() ?? "";
        }
    }

    public partial class CreateMappingRuleRequest
    {
        /// <summary>
        /// <see cref="ConversionWorkspaceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConversionWorkspaceName ParentAsConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConversionWorkspaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMappingRuleRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversionWorkspaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversionWorkspaceName ConversionWorkspaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversionWorkspaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchStaticIpsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::LocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
