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
using gcbav = Google.Cloud.Bigtable.Admin.V2;
using gcbcv = Google.Cloud.Bigtable.Common.V2;

namespace Google.Cloud.Bigtable.Admin.V2
{
    public partial class RestoreTableRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="BackupName"/>-typed view over the <see cref="Backup"/> resource name property.</summary>
        public BackupName BackupAsBackupName
        {
            get => string.IsNullOrEmpty(Backup) ? null : BackupName.Parse(Backup, allowUnparsed: true);
            set => Backup = value?.ToString() ?? "";
        }
    }

    public partial class CreateTableRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateTableFromSnapshotRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SnapshotName"/>-typed view over the <see cref="SourceSnapshot"/> resource name property.
        /// </summary>
        public SnapshotName SourceSnapshotAsSnapshotName
        {
            get => string.IsNullOrEmpty(SourceSnapshot) ? null : SnapshotName.Parse(SourceSnapshot, allowUnparsed: true);
            set => SourceSnapshot = value?.ToString() ?? "";
        }
    }

    public partial class DropRowRangeRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::TableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTablesRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTableRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::TableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTableRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::TableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UndeleteTableRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::TableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ModifyColumnFamiliesRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::TableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateConsistencyTokenRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::TableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CheckConsistencyRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::TableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SnapshotTableRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbcv::TableName TableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::TableName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Cluster"/> resource name property.
        /// </summary>
        public ClusterName ClusterAsClusterName
        {
            get => string.IsNullOrEmpty(Cluster) ? null : ClusterName.Parse(Cluster, allowUnparsed: true);
            set => Cluster = value?.ToString() ?? "";
        }
    }

    public partial class GetSnapshotRequest
    {
        /// <summary>
        /// <see cref="gcbav::SnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::SnapshotName SnapshotName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::SnapshotName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSnapshotsRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSnapshotRequest
    {
        /// <summary>
        /// <see cref="gcbav::SnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::SnapshotName SnapshotName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::SnapshotName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateBackupRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBackupRequest
    {
        /// <summary>
        /// <see cref="gcbav::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBackupRequest
    {
        /// <summary>
        /// <see cref="gcbav::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBackupsRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CopyBackupRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BackupName"/>-typed view over the <see cref="SourceBackup"/> resource name property.
        /// </summary>
        public BackupName SourceBackupAsBackupName
        {
            get => string.IsNullOrEmpty(SourceBackup) ? null : BackupName.Parse(SourceBackup, allowUnparsed: true);
            set => SourceBackup = value?.ToString() ?? "";
        }
    }

    public partial class CopyBackupMetadata
    {
        /// <summary>
        /// <see cref="gcbav::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAuthorizedViewRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::TableName ParentAsTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::TableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListAuthorizedViewsRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::TableName ParentAsTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::TableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAuthorizedViewRequest
    {
        /// <summary>
        /// <see cref="gcbav::AuthorizedViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::AuthorizedViewName AuthorizedViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::AuthorizedViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAuthorizedViewRequest
    {
        /// <summary>
        /// <see cref="gcbav::AuthorizedViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::AuthorizedViewName AuthorizedViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::AuthorizedViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSchemaBundleRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::TableName ParentAsTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::TableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSchemaBundleRequest
    {
        /// <summary>
        /// <see cref="gcbav::SchemaBundleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::SchemaBundleName SchemaBundleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::SchemaBundleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSchemaBundlesRequest
    {
        /// <summary>
        /// <see cref="gcbcv::TableName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::TableName ParentAsTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::TableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSchemaBundleRequest
    {
        /// <summary>
        /// <see cref="gcbav::SchemaBundleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::SchemaBundleName SchemaBundleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::SchemaBundleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
