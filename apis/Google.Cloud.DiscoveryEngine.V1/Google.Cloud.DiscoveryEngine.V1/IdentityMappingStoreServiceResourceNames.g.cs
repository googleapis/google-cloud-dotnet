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
using gcdv = Google.Cloud.DiscoveryEngine.V1;

namespace Google.Cloud.DiscoveryEngine.V1
{
    public partial class CreateIdentityMappingStoreRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcdv::CmekConfigName"/>-typed view over the <see cref="CmekConfigName"/> resource name property.
        /// </summary>
        public gcdv::CmekConfigName CmekConfigNameAsCmekConfigName
        {
            get => string.IsNullOrEmpty(CmekConfigName) ? null : gcdv::CmekConfigName.Parse(CmekConfigName, allowUnparsed: true);
            set => CmekConfigName = value?.ToString() ?? "";
        }
    }

    public partial class GetIdentityMappingStoreRequest
    {
        /// <summary>
        /// <see cref="gcdv::IdentityMappingStoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::IdentityMappingStoreName IdentityMappingStoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::IdentityMappingStoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteIdentityMappingStoreRequest
    {
        /// <summary>
        /// <see cref="gcdv::IdentityMappingStoreName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::IdentityMappingStoreName IdentityMappingStoreName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::IdentityMappingStoreName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportIdentityMappingsRequest
    {
        /// <summary>
        /// <see cref="IdentityMappingStoreName"/>-typed view over the <see cref="IdentityMappingStore"/> resource name
        /// property.
        /// </summary>
        public IdentityMappingStoreName IdentityMappingStoreAsIdentityMappingStoreName
        {
            get => string.IsNullOrEmpty(IdentityMappingStore) ? null : IdentityMappingStoreName.Parse(IdentityMappingStore, allowUnparsed: true);
            set => IdentityMappingStore = value?.ToString() ?? "";
        }
    }

    public partial class PurgeIdentityMappingsRequest
    {
        /// <summary>
        /// <see cref="IdentityMappingStoreName"/>-typed view over the <see cref="IdentityMappingStore"/> resource name
        /// property.
        /// </summary>
        public IdentityMappingStoreName IdentityMappingStoreAsIdentityMappingStoreName
        {
            get => string.IsNullOrEmpty(IdentityMappingStore) ? null : IdentityMappingStoreName.Parse(IdentityMappingStore, allowUnparsed: true);
            set => IdentityMappingStore = value?.ToString() ?? "";
        }
    }

    public partial class ListIdentityMappingsRequest
    {
        /// <summary>
        /// <see cref="IdentityMappingStoreName"/>-typed view over the <see cref="IdentityMappingStore"/> resource name
        /// property.
        /// </summary>
        public IdentityMappingStoreName IdentityMappingStoreAsIdentityMappingStoreName
        {
            get => string.IsNullOrEmpty(IdentityMappingStore) ? null : IdentityMappingStoreName.Parse(IdentityMappingStore, allowUnparsed: true);
            set => IdentityMappingStore = value?.ToString() ?? "";
        }
    }

    public partial class ListIdentityMappingStoresRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
