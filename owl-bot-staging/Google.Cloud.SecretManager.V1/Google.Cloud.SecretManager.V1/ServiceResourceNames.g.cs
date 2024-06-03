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
using gcsv = Google.Cloud.SecretManager.V1;

namespace Google.Cloud.SecretManager.V1
{
    public partial class ListSecretsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateSecretRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AddSecretVersionRequest
    {
        /// <summary><see cref="SecretName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SecretName ParentAsSecretName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SecretName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSecretRequest
    {
        /// <summary>
        /// <see cref="gcsv::SecretName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecretName SecretName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSecretVersionsRequest
    {
        /// <summary><see cref="SecretName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SecretName ParentAsSecretName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SecretName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSecretVersionRequest
    {
        /// <summary>
        /// <see cref="gcsv::SecretVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecretVersionName SecretVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AccessSecretVersionRequest
    {
        /// <summary>
        /// <see cref="gcsv::SecretVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecretVersionName SecretVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AccessSecretVersionResponse
    {
        /// <summary>
        /// <see cref="gcsv::SecretVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecretVersionName SecretVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSecretRequest
    {
        /// <summary>
        /// <see cref="gcsv::SecretName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecretName SecretName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DisableSecretVersionRequest
    {
        /// <summary>
        /// <see cref="gcsv::SecretVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecretVersionName SecretVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EnableSecretVersionRequest
    {
        /// <summary>
        /// <see cref="gcsv::SecretVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecretVersionName SecretVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DestroySecretVersionRequest
    {
        /// <summary>
        /// <see cref="gcsv::SecretVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecretVersionName SecretVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecretVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
