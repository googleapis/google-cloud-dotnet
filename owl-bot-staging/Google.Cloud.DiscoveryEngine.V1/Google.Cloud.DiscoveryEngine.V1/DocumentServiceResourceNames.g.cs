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
using gcdv = Google.Cloud.DiscoveryEngine.V1;

namespace Google.Cloud.DiscoveryEngine.V1
{
    public partial class GetDocumentRequest
    {
        /// <summary>
        /// <see cref="gcdv::DocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DocumentName DocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDocumentsRequest
    {
        /// <summary><see cref="BranchName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BranchName ParentAsBranchName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BranchName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateDocumentRequest
    {
        /// <summary><see cref="BranchName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BranchName ParentAsBranchName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BranchName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDocumentRequest
    {
        /// <summary>
        /// <see cref="gcdv::DocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DocumentName DocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
