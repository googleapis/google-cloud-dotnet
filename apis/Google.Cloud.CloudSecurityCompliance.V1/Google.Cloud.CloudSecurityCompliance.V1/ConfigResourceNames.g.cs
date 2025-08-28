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
using gccv = Google.Cloud.CloudSecurityCompliance.V1;

namespace Google.Cloud.CloudSecurityCompliance.V1
{
    public partial class ListFrameworksRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFrameworkRequest
    {
        /// <summary>
        /// <see cref="gccv::FrameworkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FrameworkName FrameworkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FrameworkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFrameworkRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFrameworkRequest
    {
        /// <summary>
        /// <see cref="gccv::FrameworkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FrameworkName FrameworkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FrameworkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCloudControlsRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCloudControlRequest
    {
        /// <summary>
        /// <see cref="gccv::CloudControlName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CloudControlName CloudControlName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CloudControlName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCloudControlRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCloudControlRequest
    {
        /// <summary>
        /// <see cref="gccv::CloudControlName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::CloudControlName CloudControlName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CloudControlName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
