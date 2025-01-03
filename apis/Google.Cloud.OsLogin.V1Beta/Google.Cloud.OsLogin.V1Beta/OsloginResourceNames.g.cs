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
using gcoc = Google.Cloud.OsLogin.Common;

namespace Google.Cloud.OsLogin.V1Beta
{
    public partial class CreateSshPublicKeyRequest
    {
        /// <summary>
        /// <see cref="gcoc::UserName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcoc::UserName ParentAsUserName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcoc::UserName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePosixAccountRequest
    {
        /// <summary>
        /// <see cref="gcoc::PosixAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoc::PosixAccountName PosixAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoc::PosixAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSshPublicKeyRequest
    {
        /// <summary>
        /// <see cref="gcoc::SshPublicKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoc::SshPublicKeyName SshPublicKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoc::SshPublicKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetLoginProfileRequest
    {
        /// <summary>
        /// <see cref="gcoc::UserName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoc::UserName UserName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoc::UserName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSshPublicKeyRequest
    {
        /// <summary>
        /// <see cref="gcoc::SshPublicKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoc::SshPublicKeyName SshPublicKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoc::SshPublicKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportSshPublicKeyRequest
    {
        /// <summary>
        /// <see cref="gcoc::UserName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcoc::UserName ParentAsUserName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcoc::UserName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateSshPublicKeyRequest
    {
        /// <summary>
        /// <see cref="gcoc::SshPublicKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcoc::SshPublicKeyName SshPublicKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcoc::SshPublicKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
