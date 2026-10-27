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
using gcdv = Google.Cloud.DesignCenter.V1;

namespace Google.Cloud.DesignCenter.V1
{
    public partial class CreateShareRequest
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

    public partial class ListSharesRequest
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

    public partial class GetShareRequest
    {
        /// <summary>
        /// <see cref="gcdv::ShareName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ShareName ShareName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ShareName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteShareRequest
    {
        /// <summary>
        /// <see cref="gcdv::ShareName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ShareName ShareName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ShareName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SyncShareRequest
    {
        /// <summary>
        /// <see cref="gcdv::ShareName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ShareName ShareName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ShareName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSharedTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::SharedTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SharedTemplateName SharedTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SharedTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSharedTemplatesRequest
    {
        /// <summary><see cref="SpaceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SpaceName ParentAsSpaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SpaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSharedTemplateRevisionRequest
    {
        /// <summary>
        /// <see cref="gcdv::SharedTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::SharedTemplateRevisionName SharedTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SharedTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSharedTemplateRevisionsRequest
    {
        /// <summary>
        /// <see cref="SharedTemplateName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public SharedTemplateName ParentAsSharedTemplateName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SharedTemplateName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class FetchSharedTemplateRevisionTFSourceRequest
    {
        /// <summary>
        /// <see cref="gcdv::SharedTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::SharedTemplateRevisionName SharedTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SharedTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchSharedTemplateRevisionAssessmentReportRequest
    {
        /// <summary>
        /// <see cref="gcdv::SharedTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::SharedTemplateRevisionName SharedTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SharedTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
