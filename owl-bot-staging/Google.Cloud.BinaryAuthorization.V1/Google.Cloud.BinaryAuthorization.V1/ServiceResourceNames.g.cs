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
using gcbv = Google.Cloud.BinaryAuthorization.V1;

namespace Google.Cloud.BinaryAuthorization.V1
{
    public partial class GetPolicyRequest
    {
        /// <summary>
        /// <see cref="gcbv::PolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::PolicyName PolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::PolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAttestorRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAttestorRequest
    {
        /// <summary>
        /// <see cref="gcbv::AttestorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::AttestorName AttestorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::AttestorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAttestorsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAttestorRequest
    {
        /// <summary>
        /// <see cref="gcbv::AttestorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::AttestorName AttestorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::AttestorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSystemPolicyRequest
    {
        /// <summary>
        /// <see cref="gcbv::PolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::PolicyName PolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::PolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
