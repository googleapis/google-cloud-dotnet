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
using gcbmv = Google.Cloud.BigQuery.Migration.V2;

namespace Google.Cloud.BigQuery.Migration.V2
{
    public partial class CreateMigrationWorkflowRequest
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

    public partial class GetMigrationWorkflowRequest
    {
        /// <summary>
        /// <see cref="gcbmv::MigrationWorkflowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbmv::MigrationWorkflowName MigrationWorkflowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbmv::MigrationWorkflowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMigrationWorkflowsRequest
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

    public partial class DeleteMigrationWorkflowRequest
    {
        /// <summary>
        /// <see cref="gcbmv::MigrationWorkflowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbmv::MigrationWorkflowName MigrationWorkflowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbmv::MigrationWorkflowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StartMigrationWorkflowRequest
    {
        /// <summary>
        /// <see cref="gcbmv::MigrationWorkflowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbmv::MigrationWorkflowName MigrationWorkflowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbmv::MigrationWorkflowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetMigrationSubtaskRequest
    {
        /// <summary>
        /// <see cref="gcbmv::MigrationSubtaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbmv::MigrationSubtaskName MigrationSubtaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbmv::MigrationSubtaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMigrationSubtasksRequest
    {
        /// <summary>
        /// <see cref="MigrationWorkflowName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MigrationWorkflowName ParentAsMigrationWorkflowName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MigrationWorkflowName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
