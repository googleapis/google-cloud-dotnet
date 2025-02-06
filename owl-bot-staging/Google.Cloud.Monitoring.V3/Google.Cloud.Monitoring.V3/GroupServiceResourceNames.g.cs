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
using gax = Google.Api.Gax;
using gcmv = Google.Cloud.Monitoring.V3;

namespace Google.Cloud.Monitoring.V3
{
    public partial class ListGroupsRequest
    {
        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="ChildrenOfGroup"/> resource name property.
        /// </summary>
        public GroupName ChildrenOfGroupAsGroupName
        {
            get => string.IsNullOrEmpty(ChildrenOfGroup) ? null : GroupName.Parse(ChildrenOfGroup, allowUnparsed: true);
            set => ChildrenOfGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="ChildrenOfGroup"/> resource name property.
        /// </summary>
        public gax::IResourceName ChildrenOfGroupAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(ChildrenOfGroup))
                {
                    return null;
                }
                if (GroupName.TryParse(ChildrenOfGroup, out GroupName group))
                {
                    return group;
                }
                return gax::UnparsedResourceName.Parse(ChildrenOfGroup);
            }
            set => ChildrenOfGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="AncestorsOfGroup"/> resource name property.
        /// </summary>
        public GroupName AncestorsOfGroupAsGroupName
        {
            get => string.IsNullOrEmpty(AncestorsOfGroup) ? null : GroupName.Parse(AncestorsOfGroup, allowUnparsed: true);
            set => AncestorsOfGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="AncestorsOfGroup"/> resource name property.
        /// </summary>
        public gax::IResourceName AncestorsOfGroupAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(AncestorsOfGroup))
                {
                    return null;
                }
                if (GroupName.TryParse(AncestorsOfGroup, out GroupName group))
                {
                    return group;
                }
                return gax::UnparsedResourceName.Parse(AncestorsOfGroup);
            }
            set => AncestorsOfGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="GroupName"/>-typed view over the <see cref="DescendantsOfGroup"/> resource name property.
        /// </summary>
        public GroupName DescendantsOfGroupAsGroupName
        {
            get => string.IsNullOrEmpty(DescendantsOfGroup) ? null : GroupName.Parse(DescendantsOfGroup, allowUnparsed: true);
            set => DescendantsOfGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="DescendantsOfGroup"/> resource name
        /// property.
        /// </summary>
        public gax::IResourceName DescendantsOfGroupAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(DescendantsOfGroup))
                {
                    return null;
                }
                if (GroupName.TryParse(DescendantsOfGroup, out GroupName group))
                {
                    return group;
                }
                return gax::UnparsedResourceName.Parse(DescendantsOfGroup);
            }
            set => DescendantsOfGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::OrganizationName OrganizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::OrganizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Name, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(Name, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Name, out gagr::FolderName folder))
                {
                    return folder;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetGroupRequest
    {
        /// <summary>
        /// <see cref="gcmv::GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::GroupName GroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::GroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::GroupName.TryParse(Name, out gcmv::GroupName group))
                {
                    return group;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGroupRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::OrganizationName OrganizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::OrganizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::FolderName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::FolderName FolderName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::FolderName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Name, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::OrganizationName.TryParse(Name, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::FolderName.TryParse(Name, out gagr::FolderName folder))
                {
                    return folder;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGroupRequest
    {
        /// <summary>
        /// <see cref="gcmv::GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::GroupName GroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::GroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::GroupName.TryParse(Name, out gcmv::GroupName group))
                {
                    return group;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGroupMembersRequest
    {
        /// <summary>
        /// <see cref="gcmv::GroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::GroupName GroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::GroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName ResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return null;
                }
                if (gcmv::GroupName.TryParse(Name, out gcmv::GroupName group))
                {
                    return group;
                }
                return gax::UnparsedResourceName.Parse(Name);
            }
            set => Name = value?.ToString() ?? "";
        }
    }
}
