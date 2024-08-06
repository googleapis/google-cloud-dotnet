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
using gcav = Google.Cloud.ApiHub.V1;

namespace Google.Cloud.ApiHub.V1
{
    public partial class CreateApiRequest
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

    public partial class GetApiRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiName ApiName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApiRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiName ApiName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApisRequest
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

    public partial class CreateVersionRequest
    {
        /// <summary><see cref="ApiName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ApiName ParentAsApiName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetVersionRequest
    {
        /// <summary>
        /// <see cref="gcav::VersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::VersionName VersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::VersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteVersionRequest
    {
        /// <summary>
        /// <see cref="gcav::VersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::VersionName VersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::VersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListVersionsRequest
    {
        /// <summary><see cref="ApiName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ApiName ParentAsApiName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateSpecRequest
    {
        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public VersionName ParentAsVersionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VersionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSpecRequest
    {
        /// <summary>
        /// <see cref="gcav::SpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SpecName SpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSpecRequest
    {
        /// <summary>
        /// <see cref="gcav::SpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SpecName SpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSpecsRequest
    {
        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public VersionName ParentAsVersionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VersionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSpecContentsRequest
    {
        /// <summary>
        /// <see cref="gcav::SpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SpecName SpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetApiOperationRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiOperationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiOperationName ApiOperationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiOperationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApiOperationsRequest
    {
        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public VersionName ParentAsVersionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VersionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDefinitionRequest
    {
        /// <summary>
        /// <see cref="gcav::DefinitionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DefinitionName DefinitionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DefinitionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDeploymentRequest
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

    public partial class GetDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcav::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcav::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDeploymentsRequest
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

    public partial class CreateAttributeRequest
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

    public partial class GetAttributeRequest
    {
        /// <summary>
        /// <see cref="gcav::AttributeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AttributeName AttributeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AttributeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAttributeRequest
    {
        /// <summary>
        /// <see cref="gcav::AttributeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AttributeName AttributeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AttributeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAttributesRequest
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

    public partial class SearchResourcesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Location"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationAsLocationName
        {
            get => string.IsNullOrEmpty(Location) ? null : gagr::LocationName.Parse(Location, allowUnparsed: true);
            set => Location = value?.ToString() ?? "";
        }
    }

    public partial class CreateDependencyRequest
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

    public partial class GetDependencyRequest
    {
        /// <summary>
        /// <see cref="gcav::DependencyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DependencyName DependencyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DependencyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDependencyRequest
    {
        /// <summary>
        /// <see cref="gcav::DependencyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DependencyName DependencyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DependencyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDependenciesRequest
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

    public partial class CreateExternalApiRequest
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

    public partial class GetExternalApiRequest
    {
        /// <summary>
        /// <see cref="gcav::ExternalApiName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ExternalApiName ExternalApiName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ExternalApiName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteExternalApiRequest
    {
        /// <summary>
        /// <see cref="gcav::ExternalApiName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ExternalApiName ExternalApiName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ExternalApiName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListExternalApisRequest
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
