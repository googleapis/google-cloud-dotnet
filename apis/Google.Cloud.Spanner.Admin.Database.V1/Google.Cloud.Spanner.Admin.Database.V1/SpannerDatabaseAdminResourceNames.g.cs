// Copyright 2022 Google LLC
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

using gcscv = Google.Cloud.Spanner.Common.V1;

namespace Google.Cloud.Spanner.Admin.Database.V1
{
    public partial class Database
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDatabasesRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateDatabaseMetadata
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class GetDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpdateDatabaseDdlRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class UpdateDatabaseDdlMetadata
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class DropDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class GetDatabaseDdlRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class ListDatabaseOperationsRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RestoreDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="BackupName"/>-typed view over the <see cref="Backup"/> resource name property.</summary>
        public BackupName BackupAsBackupName
        {
            get => string.IsNullOrEmpty(Backup) ? null : BackupName.Parse(Backup, allowUnparsed: true);
            set => Backup = value?.ToString() ?? "";
        }
    }

    public partial class RestoreDatabaseEncryptionConfig
    {
        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="KmsKeyName"/> resource name property.
        /// </summary>
        public CryptoKeyName KmsKeyNameAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(KmsKeyName) ? null : CryptoKeyName.Parse(KmsKeyName, allowUnparsed: true);
            set => KmsKeyName = value?.ToString() ?? "";
        }
    }

    public partial class RestoreDatabaseMetadata
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class OptimizeRestoredDatabaseMetadata
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
