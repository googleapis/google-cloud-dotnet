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
using gckv = Google.Cloud.Kms.V1;

namespace Google.Cloud.Kms.V1
{
    public partial class ListKeyRingsRequest
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

    public partial class ListCryptoKeysRequest
    {
        /// <summary>
        /// <see cref="KeyRingName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public KeyRingName ParentAsKeyRingName
        {
            get => string.IsNullOrEmpty(Parent) ? null : KeyRingName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListCryptoKeyVersionsRequest
    {
        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CryptoKeyName ParentAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CryptoKeyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListImportJobsRequest
    {
        /// <summary>
        /// <see cref="KeyRingName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public KeyRingName ParentAsKeyRingName
        {
            get => string.IsNullOrEmpty(Parent) ? null : KeyRingName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetKeyRingRequest
    {
        /// <summary>
        /// <see cref="gckv::KeyRingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::KeyRingName KeyRingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::KeyRingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCryptoKeyRequest
    {
        /// <summary>
        /// <see cref="gckv::CryptoKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::CryptoKeyName CryptoKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::CryptoKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCryptoKeyVersionRequest
    {
        /// <summary>
        /// <see cref="gckv::CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::CryptoKeyVersionName CryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::CryptoKeyVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetPublicKeyRequest
    {
        /// <summary>
        /// <see cref="gckv::CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::CryptoKeyVersionName CryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::CryptoKeyVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetImportJobRequest
    {
        /// <summary>
        /// <see cref="gckv::ImportJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::ImportJobName ImportJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::ImportJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateKeyRingRequest
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

    public partial class CreateCryptoKeyRequest
    {
        /// <summary>
        /// <see cref="KeyRingName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public KeyRingName ParentAsKeyRingName
        {
            get => string.IsNullOrEmpty(Parent) ? null : KeyRingName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateCryptoKeyVersionRequest
    {
        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CryptoKeyName ParentAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CryptoKeyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ImportCryptoKeyVersionRequest
    {
        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CryptoKeyName ParentAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CryptoKeyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeyVersionName"/>-typed view over the <see cref="CryptoKeyVersion"/> resource name
        /// property.
        /// </summary>
        public CryptoKeyVersionName CryptoKeyVersionAsCryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(CryptoKeyVersion) ? null : CryptoKeyVersionName.Parse(CryptoKeyVersion, allowUnparsed: true);
            set => CryptoKeyVersion = value?.ToString() ?? "";
        }
    }

    public partial class CreateImportJobRequest
    {
        /// <summary>
        /// <see cref="KeyRingName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public KeyRingName ParentAsKeyRingName
        {
            get => string.IsNullOrEmpty(Parent) ? null : KeyRingName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateCryptoKeyPrimaryVersionRequest
    {
        /// <summary>
        /// <see cref="gckv::CryptoKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::CryptoKeyName CryptoKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::CryptoKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DestroyCryptoKeyVersionRequest
    {
        /// <summary>
        /// <see cref="gckv::CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::CryptoKeyVersionName CryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::CryptoKeyVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RestoreCryptoKeyVersionRequest
    {
        /// <summary>
        /// <see cref="gckv::CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::CryptoKeyVersionName CryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::CryptoKeyVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EncryptRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gax::UnparsedResourceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DecryptRequest
    {
        /// <summary>
        /// <see cref="gckv::CryptoKeyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::CryptoKeyName CryptoKeyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::CryptoKeyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AsymmetricSignRequest
    {
        /// <summary>
        /// <see cref="gckv::CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::CryptoKeyVersionName CryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::CryptoKeyVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AsymmetricDecryptRequest
    {
        /// <summary>
        /// <see cref="gckv::CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::CryptoKeyVersionName CryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::CryptoKeyVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MacSignRequest
    {
        /// <summary>
        /// <see cref="gckv::CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::CryptoKeyVersionName CryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::CryptoKeyVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MacVerifyRequest
    {
        /// <summary>
        /// <see cref="gckv::CryptoKeyVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gckv::CryptoKeyVersionName CryptoKeyVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gckv::CryptoKeyVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
