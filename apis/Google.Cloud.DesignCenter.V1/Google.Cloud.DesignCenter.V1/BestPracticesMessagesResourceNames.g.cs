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
using sys = System;

namespace Google.Cloud.DesignCenter.V1
{
    public partial class FetchApplicationAssessmentReportRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateApplicationAssessmentReportRequest
    {
        /// <summary>
        /// <see cref="gcdv::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateApplicationTemplateAssessmentReportRequest
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

    public partial class GenerateAssessmentReportRequest
    {
        /// <summary>
        /// <see cref="gcdv::SpaceName"/>-typed view over the <see cref="SpaceName"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gcdv::SpaceName SpaceNameAsSpaceName
        {
            get => string.IsNullOrEmpty(SpaceName) ? null : gcdv::SpaceName.Parse(SpaceName, allowUnparsed: true);
            set => SpaceName = value?.ToString() ?? "";
        }
    }

    public partial class GenerateTerraformPlanAssessmentReportRequest
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

    public partial class GetPolicyRequest
    {
        /// <summary>
        /// <see cref="gcdv::PolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PolicyName PolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPoliciesRequest
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

    public partial class CreatePolicyRequest
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

    public partial class DeletePolicyRequest
    {
        /// <summary>
        /// <see cref="gcdv::PolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::PolicyName PolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::PolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
