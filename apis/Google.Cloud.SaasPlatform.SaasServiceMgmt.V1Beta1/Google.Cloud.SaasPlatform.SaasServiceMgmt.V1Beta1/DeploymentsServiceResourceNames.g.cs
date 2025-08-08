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
using gcssv = Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1;

namespace Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1
{
    public partial class ListSaasRequest
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

    public partial class GetSaasRequest
    {
        /// <summary>
        /// <see cref="gcssv::SaasName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::SaasName SaasName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::SaasName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSaasRequest
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

    public partial class DeleteSaasRequest
    {
        /// <summary>
        /// <see cref="gcssv::SaasName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::SaasName SaasName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::SaasName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTenantsRequest
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

    public partial class GetTenantRequest
    {
        /// <summary>
        /// <see cref="gcssv::TenantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::TenantName TenantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::TenantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTenantRequest
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

    public partial class DeleteTenantRequest
    {
        /// <summary>
        /// <see cref="gcssv::TenantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::TenantName TenantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::TenantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListUnitKindsRequest
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

    public partial class GetUnitKindRequest
    {
        /// <summary>
        /// <see cref="gcssv::UnitKindName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::UnitKindName UnitKindName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::UnitKindName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateUnitKindRequest
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

    public partial class DeleteUnitKindRequest
    {
        /// <summary>
        /// <see cref="gcssv::UnitKindName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::UnitKindName UnitKindName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::UnitKindName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListUnitsRequest
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

    public partial class GetUnitRequest
    {
        /// <summary>
        /// <see cref="gcssv::UnitName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::UnitName UnitName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::UnitName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateUnitRequest
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

    public partial class DeleteUnitRequest
    {
        /// <summary>
        /// <see cref="gcssv::UnitName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::UnitName UnitName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::UnitName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListUnitOperationsRequest
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

    public partial class GetUnitOperationRequest
    {
        /// <summary>
        /// <see cref="gcssv::UnitOperationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::UnitOperationName UnitOperationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::UnitOperationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateUnitOperationRequest
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

    public partial class DeleteUnitOperationRequest
    {
        /// <summary>
        /// <see cref="gcssv::UnitOperationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::UnitOperationName UnitOperationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::UnitOperationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReleasesRequest
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

    public partial class GetReleaseRequest
    {
        /// <summary>
        /// <see cref="gcssv::ReleaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::ReleaseName ReleaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::ReleaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReleaseRequest
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

    public partial class DeleteReleaseRequest
    {
        /// <summary>
        /// <see cref="gcssv::ReleaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::ReleaseName ReleaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::ReleaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
