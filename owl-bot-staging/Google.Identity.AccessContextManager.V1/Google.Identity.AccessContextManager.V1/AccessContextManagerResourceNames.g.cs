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
using giav = Google.Identity.AccessContextManager.V1;

namespace Google.Identity.AccessContextManager.V1
{
    public partial class ListAccessPoliciesRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAccessPolicyRequest
    {
        /// <summary>
        /// <see cref="giav::AccessPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giav::AccessPolicyName AccessPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : giav::AccessPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAccessPolicyRequest
    {
        /// <summary>
        /// <see cref="giav::AccessPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giav::AccessPolicyName AccessPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : giav::AccessPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAccessLevelsRequest
    {
        /// <summary>
        /// <see cref="AccessPolicyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccessPolicyName ParentAsAccessPolicyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccessPolicyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAccessLevelRequest
    {
        /// <summary>
        /// <see cref="giav::AccessLevelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giav::AccessLevelName AccessLevelName
        {
            get => string.IsNullOrEmpty(Name) ? null : giav::AccessLevelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAccessLevelRequest
    {
        /// <summary>
        /// <see cref="AccessPolicyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccessPolicyName ParentAsAccessPolicyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccessPolicyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAccessLevelRequest
    {
        /// <summary>
        /// <see cref="giav::AccessLevelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giav::AccessLevelName AccessLevelName
        {
            get => string.IsNullOrEmpty(Name) ? null : giav::AccessLevelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReplaceAccessLevelsRequest
    {
        /// <summary>
        /// <see cref="AccessPolicyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccessPolicyName ParentAsAccessPolicyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccessPolicyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListServicePerimetersRequest
    {
        /// <summary>
        /// <see cref="AccessPolicyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccessPolicyName ParentAsAccessPolicyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccessPolicyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetServicePerimeterRequest
    {
        /// <summary>
        /// <see cref="giav::ServicePerimeterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giav::ServicePerimeterName ServicePerimeterName
        {
            get => string.IsNullOrEmpty(Name) ? null : giav::ServicePerimeterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateServicePerimeterRequest
    {
        /// <summary>
        /// <see cref="AccessPolicyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccessPolicyName ParentAsAccessPolicyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccessPolicyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteServicePerimeterRequest
    {
        /// <summary>
        /// <see cref="giav::ServicePerimeterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giav::ServicePerimeterName ServicePerimeterName
        {
            get => string.IsNullOrEmpty(Name) ? null : giav::ServicePerimeterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReplaceServicePerimetersRequest
    {
        /// <summary>
        /// <see cref="AccessPolicyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccessPolicyName ParentAsAccessPolicyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccessPolicyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CommitServicePerimetersRequest
    {
        /// <summary>
        /// <see cref="AccessPolicyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccessPolicyName ParentAsAccessPolicyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccessPolicyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListGcpUserAccessBindingsRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetGcpUserAccessBindingRequest
    {
        /// <summary>
        /// <see cref="giav::GcpUserAccessBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giav::GcpUserAccessBindingName GcpUserAccessBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : giav::GcpUserAccessBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGcpUserAccessBindingRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGcpUserAccessBindingRequest
    {
        /// <summary>
        /// <see cref="giav::GcpUserAccessBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giav::GcpUserAccessBindingName GcpUserAccessBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : giav::GcpUserAccessBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
