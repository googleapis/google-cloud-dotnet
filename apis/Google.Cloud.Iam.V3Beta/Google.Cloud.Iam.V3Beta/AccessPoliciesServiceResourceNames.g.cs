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
using gciv = Google.Cloud.Iam.V3Beta;

namespace Google.Cloud.Iam.V3Beta
{
    public partial class CreateAccessPolicyRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
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
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
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

    public partial class GetAccessPolicyRequest
    {
        /// <summary>
        /// <see cref="gciv::AccessPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::AccessPolicyName AccessPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::AccessPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAccessPolicyRequest
    {
        /// <summary>
        /// <see cref="gciv::AccessPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::AccessPolicyName AccessPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::AccessPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAccessPoliciesRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
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
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
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

    public partial class SearchAccessPolicyBindingsRequest
    {
        /// <summary>
        /// <see cref="gciv::AccessPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::AccessPolicyName AccessPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::AccessPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
