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
using gcsv = Google.Cloud.Sql.V1Beta4;

namespace Google.Cloud.Sql.V1Beta4
{
    public partial class CreateBackupRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBackupRequest
    {
        /// <summary>
        /// <see cref="gcsv::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBackupsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBackupRequest
    {
        /// <summary>
        /// <see cref="gcsv::BackupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BackupName BackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExecuteSqlReadOnlyPayload
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class ExecuteSqlPayload
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }
    }

    public partial class PscDnsReconcileNetworkingRequest
    {
        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Networks"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<NetworkName> NetworksAsNetworkNames
        {
            get => new gax::ResourceNameList<NetworkName>(Networks, s => string.IsNullOrEmpty(s) ? null : NetworkName.Parse(s, allowUnparsed: true));
        }
    }
}
