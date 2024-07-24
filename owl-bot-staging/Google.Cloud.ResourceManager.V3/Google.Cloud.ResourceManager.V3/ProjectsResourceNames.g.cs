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

namespace Google.Cloud.ResourceManager.V3
{
    public partial class Project
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetProjectRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProjectsRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gax::UnparsedResourceName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class MoveProjectRequest
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
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="DestinationParent"/> resource name property.
        /// </summary>
        public gax::IResourceName DestinationParentAsResourceName
        {
            get => string.IsNullOrEmpty(DestinationParent) ? null : gax::UnparsedResourceName.Parse(DestinationParent);
            set => DestinationParent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteProjectRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UndeleteProjectRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::ProjectName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
