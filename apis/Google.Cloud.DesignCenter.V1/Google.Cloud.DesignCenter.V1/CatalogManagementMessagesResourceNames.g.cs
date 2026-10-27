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
using gcdv = Google.Cloud.DesignCenter.V1;

namespace Google.Cloud.DesignCenter.V1
{
    public partial class ListSpacesRequest
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

    public partial class GetSpaceRequest
    {
        /// <summary>
        /// <see cref="gcdv::SpaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SpaceName SpaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SpaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSpaceRequest
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

    public partial class DeleteSpaceRequest
    {
        /// <summary>
        /// <see cref="gcdv::SpaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SpaceName SpaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SpaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetCatalogRequest
    {
        /// <summary>
        /// <see cref="gcdv::CatalogName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CatalogName CatalogName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CatalogName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCatalogsRequest
    {
        /// <summary><see cref="SpaceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SpaceName ParentAsSpaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SpaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateCatalogRequest
    {
        /// <summary><see cref="SpaceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SpaceName ParentAsSpaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SpaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCatalogRequest
    {
        /// <summary>
        /// <see cref="gcdv::CatalogName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CatalogName CatalogName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CatalogName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCatalogTemplateRequest
    {
        /// <summary>
        /// <see cref="CatalogName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CatalogName ParentAsCatalogName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CatalogName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCatalogTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::CatalogTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CatalogTemplateName CatalogTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CatalogTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCatalogTemplatesRequest
    {
        /// <summary>
        /// <see cref="CatalogName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CatalogName ParentAsCatalogName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CatalogName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCatalogTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::CatalogTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CatalogTemplateName CatalogTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CatalogTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCatalogTemplateRevisionRequest
    {
        /// <summary>
        /// <see cref="CatalogTemplateName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CatalogTemplateName ParentAsCatalogTemplateName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CatalogTemplateName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCatalogTemplateRevisionRequest
    {
        /// <summary>
        /// <see cref="gcdv::CatalogTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::CatalogTemplateRevisionName CatalogTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CatalogTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCatalogTemplateRevisionsRequest
    {
        /// <summary>
        /// <see cref="CatalogTemplateName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CatalogTemplateName ParentAsCatalogTemplateName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CatalogTemplateName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCatalogTemplateRevisionRequest
    {
        /// <summary>
        /// <see cref="gcdv::CatalogTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::CatalogTemplateRevisionName CatalogTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CatalogTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchCatalogTemplateRevisionTFSourceRequest
    {
        /// <summary>
        /// <see cref="gcdv::CatalogTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::CatalogTemplateRevisionName CatalogTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CatalogTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchCatalogTemplateRevisionAssessmentReportRequest
    {
        /// <summary>
        /// <see cref="gcdv::CatalogTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::CatalogTemplateRevisionName CatalogTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CatalogTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
