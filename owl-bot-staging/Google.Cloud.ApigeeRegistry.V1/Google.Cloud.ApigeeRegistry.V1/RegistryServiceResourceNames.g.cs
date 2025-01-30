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
using gcav = Google.Cloud.ApigeeRegistry.V1;

namespace Google.Cloud.ApigeeRegistry.V1
{
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

    public partial class ListApiVersionsRequest
    {
        /// <summary><see cref="ApiName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ApiName ParentAsApiName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetApiVersionRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiVersionName ApiVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateApiVersionRequest
    {
        /// <summary><see cref="ApiName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ApiName ParentAsApiName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApiVersionRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiVersionName ApiVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApiSpecsRequest
    {
        /// <summary>
        /// <see cref="ApiVersionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApiVersionName ParentAsApiVersionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiVersionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetApiSpecRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiSpecName ApiSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetApiSpecContentsRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiSpecName ApiSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateApiSpecRequest
    {
        /// <summary>
        /// <see cref="ApiVersionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApiVersionName ParentAsApiVersionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiVersionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApiSpecRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiSpecName ApiSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TagApiSpecRevisionRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiSpecName ApiSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApiSpecRevisionsRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiSpecName ApiSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RollbackApiSpecRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiSpecName ApiSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApiSpecRevisionRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiSpecName ApiSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApiDeploymentsRequest
    {
        /// <summary><see cref="ApiName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ApiName ParentAsApiName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetApiDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiDeploymentName ApiDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateApiDeploymentRequest
    {
        /// <summary><see cref="ApiName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ApiName ParentAsApiName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApiDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiDeploymentName ApiDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TagApiDeploymentRevisionRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiDeploymentName ApiDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApiDeploymentRevisionsRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiDeploymentName ApiDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RollbackApiDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiDeploymentName ApiDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApiDeploymentRevisionRequest
    {
        /// <summary>
        /// <see cref="gcav::ApiDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApiDeploymentName ApiDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApiDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListArtifactsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="ApiName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ApiName ParentAsApiName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApiVersionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApiVersionName ParentAsApiVersionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiVersionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApiSpecName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApiSpecName ParentAsApiSpecName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiSpecName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApiDeploymentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApiDeploymentName ParentAsApiDeploymentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiDeploymentName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (ApiName.TryParse(Parent, out ApiName api))
                {
                    return api;
                }
                if (ApiVersionName.TryParse(Parent, out ApiVersionName apiVersion))
                {
                    return apiVersion;
                }
                if (ApiSpecName.TryParse(Parent, out ApiSpecName apiSpec))
                {
                    return apiSpec;
                }
                if (ApiDeploymentName.TryParse(Parent, out ApiDeploymentName apiDeployment))
                {
                    return apiDeployment;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetArtifactRequest
    {
        /// <summary>
        /// <see cref="gcav::ArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ArtifactName ArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetArtifactContentsRequest
    {
        /// <summary>
        /// <see cref="gcav::ArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ArtifactName ArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateArtifactRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="ApiName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ApiName ParentAsApiName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApiVersionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApiVersionName ParentAsApiVersionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiVersionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApiSpecName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApiSpecName ParentAsApiSpecName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiSpecName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApiDeploymentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApiDeploymentName ParentAsApiDeploymentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApiDeploymentName.Parse(Parent, allowUnparsed: true);
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
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (ApiName.TryParse(Parent, out ApiName api))
                {
                    return api;
                }
                if (ApiVersionName.TryParse(Parent, out ApiVersionName apiVersion))
                {
                    return apiVersion;
                }
                if (ApiSpecName.TryParse(Parent, out ApiSpecName apiSpec))
                {
                    return apiSpec;
                }
                if (ApiDeploymentName.TryParse(Parent, out ApiDeploymentName apiDeployment))
                {
                    return apiDeployment;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteArtifactRequest
    {
        /// <summary>
        /// <see cref="gcav::ArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ArtifactName ArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
