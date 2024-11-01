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
using gcav = Google.Cloud.AIPlatform.V1Beta1;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    public partial class CreateNotebookRuntimeTemplateRequest
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

    public partial class GetNotebookRuntimeTemplateRequest
    {
        /// <summary>
        /// <see cref="gcav::NotebookRuntimeTemplateName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::NotebookRuntimeTemplateName NotebookRuntimeTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NotebookRuntimeTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNotebookRuntimeTemplatesRequest
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

    public partial class DeleteNotebookRuntimeTemplateRequest
    {
        /// <summary>
        /// <see cref="gcav::NotebookRuntimeTemplateName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::NotebookRuntimeTemplateName NotebookRuntimeTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NotebookRuntimeTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AssignNotebookRuntimeRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NotebookRuntimeTemplateName"/>-typed view over the <see cref="NotebookRuntimeTemplate"/> resource
        /// name property.
        /// </summary>
        public NotebookRuntimeTemplateName NotebookRuntimeTemplateAsNotebookRuntimeTemplateName
        {
            get => string.IsNullOrEmpty(NotebookRuntimeTemplate) ? null : NotebookRuntimeTemplateName.Parse(NotebookRuntimeTemplate, allowUnparsed: true);
            set => NotebookRuntimeTemplate = value?.ToString() ?? "";
        }
    }

    public partial class GetNotebookRuntimeRequest
    {
        /// <summary>
        /// <see cref="gcav::NotebookRuntimeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NotebookRuntimeName NotebookRuntimeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NotebookRuntimeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNotebookRuntimesRequest
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

    public partial class DeleteNotebookRuntimeRequest
    {
        /// <summary>
        /// <see cref="gcav::NotebookRuntimeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NotebookRuntimeName NotebookRuntimeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NotebookRuntimeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpgradeNotebookRuntimeRequest
    {
        /// <summary>
        /// <see cref="gcav::NotebookRuntimeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NotebookRuntimeName NotebookRuntimeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NotebookRuntimeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StartNotebookRuntimeRequest
    {
        /// <summary>
        /// <see cref="gcav::NotebookRuntimeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NotebookRuntimeName NotebookRuntimeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NotebookRuntimeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StopNotebookRuntimeRequest
    {
        /// <summary>
        /// <see cref="gcav::NotebookRuntimeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NotebookRuntimeName NotebookRuntimeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NotebookRuntimeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateNotebookExecutionJobRequest
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

    public partial class GetNotebookExecutionJobRequest
    {
        /// <summary>
        /// <see cref="gcav::NotebookExecutionJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NotebookExecutionJobName NotebookExecutionJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NotebookExecutionJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNotebookExecutionJobsRequest
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

    public partial class DeleteNotebookExecutionJobRequest
    {
        /// <summary>
        /// <see cref="gcav::NotebookExecutionJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NotebookExecutionJobName NotebookExecutionJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NotebookExecutionJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
