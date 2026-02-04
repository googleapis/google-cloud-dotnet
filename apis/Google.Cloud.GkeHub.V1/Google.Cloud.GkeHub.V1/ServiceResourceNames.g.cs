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
using gcgv = Google.Cloud.GkeHub.V1;

namespace Google.Cloud.GkeHub.V1
{
    public partial class GetScopeNamespaceRequest
    {
        /// <summary>
        /// <see cref="gcgv::NamespaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::NamespaceName NamespaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::NamespaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateScopeNamespaceRequest
    {
        /// <summary><see cref="ScopeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ScopeName ParentAsScopeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScopeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteScopeNamespaceRequest
    {
        /// <summary>
        /// <see cref="gcgv::NamespaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::NamespaceName NamespaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::NamespaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListScopeNamespacesRequest
    {
        /// <summary><see cref="ScopeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ScopeName ParentAsScopeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScopeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetScopeRBACRoleBindingRequest
    {
        /// <summary>
        /// <see cref="gcgv::RBACRoleBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::RBACRoleBindingName RBACRoleBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::RBACRoleBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateScopeRBACRoleBindingRequest
    {
        /// <summary><see cref="ScopeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ScopeName ParentAsScopeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScopeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MembershipName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MembershipName ParentAsMembershipName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MembershipName.Parse(Parent, allowUnparsed: true);
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
                if (ScopeName.TryParse(Parent, out ScopeName scope))
                {
                    return scope;
                }
                if (MembershipName.TryParse(Parent, out MembershipName membership))
                {
                    return membership;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteScopeRBACRoleBindingRequest
    {
        /// <summary>
        /// <see cref="gcgv::RBACRoleBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::RBACRoleBindingName RBACRoleBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::RBACRoleBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListScopeRBACRoleBindingsRequest
    {
        /// <summary><see cref="ScopeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ScopeName ParentAsScopeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScopeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MembershipName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MembershipName ParentAsMembershipName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MembershipName.Parse(Parent, allowUnparsed: true);
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
                if (ScopeName.TryParse(Parent, out ScopeName scope))
                {
                    return scope;
                }
                if (MembershipName.TryParse(Parent, out MembershipName membership))
                {
                    return membership;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetScopeRequest
    {
        /// <summary>
        /// <see cref="gcgv::ScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::ScopeName ScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::ScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateScopeRequest
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

    public partial class DeleteScopeRequest
    {
        /// <summary>
        /// <see cref="gcgv::ScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::ScopeName ScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::ScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListScopesRequest
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

    public partial class ListPermittedScopesRequest
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

    public partial class GetMembershipBindingRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipBindingName MembershipBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMembershipBindingRequest
    {
        /// <summary>
        /// <see cref="MembershipName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MembershipName ParentAsMembershipName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MembershipName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMembershipBindingRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipBindingName MembershipBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMembershipBindingsRequest
    {
        /// <summary>
        /// <see cref="MembershipName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MembershipName ParentAsMembershipName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MembershipName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListMembershipsRequest
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

    public partial class GetMembershipRBACRoleBindingRequest
    {
        /// <summary>
        /// <see cref="gcgv::RBACRoleBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::RBACRoleBindingName RBACRoleBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::RBACRoleBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMembershipRBACRoleBindingRequest
    {
        /// <summary><see cref="ScopeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ScopeName ParentAsScopeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScopeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MembershipName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MembershipName ParentAsMembershipName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MembershipName.Parse(Parent, allowUnparsed: true);
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
                if (ScopeName.TryParse(Parent, out ScopeName scope))
                {
                    return scope;
                }
                if (MembershipName.TryParse(Parent, out MembershipName membership))
                {
                    return membership;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMembershipRBACRoleBindingRequest
    {
        /// <summary>
        /// <see cref="gcgv::RBACRoleBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::RBACRoleBindingName RBACRoleBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::RBACRoleBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMembershipRBACRoleBindingsRequest
    {
        /// <summary><see cref="ScopeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ScopeName ParentAsScopeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScopeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="MembershipName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MembershipName ParentAsMembershipName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MembershipName.Parse(Parent, allowUnparsed: true);
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
                if (ScopeName.TryParse(Parent, out ScopeName scope))
                {
                    return scope;
                }
                if (MembershipName.TryParse(Parent, out MembershipName membership))
                {
                    return membership;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GenerateMembershipRBACRoleBindingYAMLRequest
    {
        /// <summary>
        /// <see cref="MembershipName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MembershipName ParentAsMembershipName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MembershipName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetMembershipRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBoundMembershipsRequest
    {
        /// <summary>
        /// <see cref="gcgv::ScopeName"/>-typed view over the <see cref="ScopeName"/> resource name property.
        /// </summary>
        public gcgv::ScopeName ScopeNameAsScopeName
        {
            get => string.IsNullOrEmpty(ScopeName) ? null : gcgv::ScopeName.Parse(ScopeName, allowUnparsed: true);
            set => ScopeName = value?.ToString() ?? "";
        }
    }

    public partial class CreateMembershipRequest
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

    public partial class DeleteMembershipRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpdateMembershipRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateConnectManifestRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFeaturesRequest
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

    public partial class GetFeatureRequest
    {
        /// <summary>
        /// <see cref="gcgv::FeatureName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::FeatureName FeatureName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::FeatureName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFeatureRequest
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

    public partial class DeleteFeatureRequest
    {
        /// <summary>
        /// <see cref="gcgv::FeatureName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::FeatureName FeatureName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::FeatureName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpdateFeatureRequest
    {
        /// <summary>
        /// <see cref="gcgv::FeatureName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::FeatureName FeatureName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::FeatureName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFleetRequest
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

    public partial class GetFleetRequest
    {
        /// <summary>
        /// <see cref="gcgv::FleetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::FleetName FleetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::FleetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFleetRequest
    {
        /// <summary>
        /// <see cref="gcgv::FleetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::FleetName FleetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::FleetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFleetsRequest
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
}
