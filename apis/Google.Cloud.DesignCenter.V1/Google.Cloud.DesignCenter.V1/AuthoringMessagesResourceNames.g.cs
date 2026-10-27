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
    public partial class ListApplicationTemplatesRequest
    {
        /// <summary><see cref="SpaceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SpaceName ParentAsSpaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SpaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetApplicationTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationTemplateName ApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateApplicationTemplateRequest
    {
        /// <summary><see cref="SpaceName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SpaceName ParentAsSpaceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SpaceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApplicationTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationTemplateName ApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CommitApplicationTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationTemplateName ApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SnapshotApplicationTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationTemplateName ApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportApplicationTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationTemplateName ApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApplicationTemplateRevisionName"/>-typed view over the
        /// <see cref="ApplicationTemplateRevisionUri"/> resource name property.
        /// </summary>
        public ApplicationTemplateRevisionName ApplicationTemplateRevisionUriAsApplicationTemplateRevisionName
        {
            get => string.IsNullOrEmpty(ApplicationTemplateRevisionUri) ? null : ApplicationTemplateRevisionName.Parse(ApplicationTemplateRevisionUri, allowUnparsed: true);
            set => ApplicationTemplateRevisionUri = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SharedTemplateRevisionName"/>-typed view over the <see cref="SharedTemplateRevisionUri"/>
        /// resource name property.
        /// </summary>
        public SharedTemplateRevisionName SharedTemplateRevisionUriAsSharedTemplateRevisionName
        {
            get => string.IsNullOrEmpty(SharedTemplateRevisionUri) ? null : SharedTemplateRevisionName.Parse(SharedTemplateRevisionUri, allowUnparsed: true);
            set => SharedTemplateRevisionUri = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApplicationTemplateSystemRevisionName"/>-typed view over the
        /// <see cref="ApplicationTemplateSystemRevision"/> resource name property.
        /// </summary>
        public ApplicationTemplateSystemRevisionName ApplicationTemplateSystemRevisionAsApplicationTemplateSystemRevisionName
        {
            get => string.IsNullOrEmpty(ApplicationTemplateSystemRevision) ? null : ApplicationTemplateSystemRevisionName.Parse(ApplicationTemplateSystemRevision, allowUnparsed: true);
            set => ApplicationTemplateSystemRevision = value?.ToString() ?? "";
        }
    }

    public partial class GenerateApplicationTemplateRevisionIaCRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::ApplicationTemplateRevisionName ApplicationTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateApplicationTemplateIaCRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationTemplateName ApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportApplicationTemplateIaCRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationTemplateName ApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportApplicationTemplateRevisionIaCRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::ApplicationTemplateRevisionName ApplicationTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportApplicationTemplateIaCRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationTemplateName ApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class IngestApplicationTemplateIaCRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationTemplateName ApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListComponentsRequest
    {
        /// <summary>
        /// <see cref="ApplicationTemplateName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApplicationTemplateName ParentAsApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApplicationTemplateName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetComponentRequest
    {
        /// <summary>
        /// <see cref="gcdv::ComponentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ComponentName ComponentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ComponentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateComponentRequest
    {
        /// <summary>
        /// <see cref="ApplicationTemplateName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApplicationTemplateName ParentAsApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApplicationTemplateName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteComponentRequest
    {
        /// <summary>
        /// <see cref="gcdv::ComponentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ComponentName ComponentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ComponentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConnectionsRequest
    {
        /// <summary>
        /// <see cref="ComponentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ComponentName ParentAsComponentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ComponentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetConnectionRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConnectionName ConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateConnectionRequest
    {
        /// <summary>
        /// <see cref="ComponentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ComponentName ParentAsComponentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ComponentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteConnectionRequest
    {
        /// <summary>
        /// <see cref="gcdv::ConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ConnectionName ConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportSerializedApplicationTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationTemplateName ApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApplicationTemplateRevisionsRequest
    {
        /// <summary>
        /// <see cref="ApplicationTemplateName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApplicationTemplateName ParentAsApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApplicationTemplateName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetApplicationTemplateRevisionRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::ApplicationTemplateRevisionName ApplicationTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApplicationTemplateRevisionRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::ApplicationTemplateRevisionName ApplicationTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApplicationTemplateSystemRevisionsRequest
    {
        /// <summary>
        /// <see cref="ApplicationTemplateName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApplicationTemplateName ParentAsApplicationTemplateName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApplicationTemplateName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetApplicationTemplateSystemRevisionRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationTemplateSystemRevisionName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcdv::ApplicationTemplateSystemRevisionName ApplicationTemplateSystemRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationTemplateSystemRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
