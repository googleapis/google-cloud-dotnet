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
using gax = Google.Api.Gax;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    public partial class PurgeUserEventsRequest
    {
        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStoreName ParentAsDataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PurgeDocumentsRequest
    {
        /// <summary><see cref="BranchName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BranchName ParentAsBranchName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BranchName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class InlineSource
            {
                /// <summary>
                /// <see cref="DocumentName"/>-typed view over the <see cref="Documents"/> resource name property.
                /// </summary>
                public gax::ResourceNameList<DocumentName> DocumentsAsDocumentNames
                {
                    get => new gax::ResourceNameList<DocumentName>(Documents, s => string.IsNullOrEmpty(s) ? null : DocumentName.Parse(s, allowUnparsed: true));
                }
            }
        }
    }

    public partial class PurgeDocumentsResponse
    {
        /// <summary>
        /// <see cref="DocumentName"/>-typed view over the <see cref="PurgeSample"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<DocumentName> PurgeSampleAsDocumentNames
        {
            get => new gax::ResourceNameList<DocumentName>(PurgeSample, s => string.IsNullOrEmpty(s) ? null : DocumentName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class PurgeSuggestionDenyListEntriesRequest
    {
        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStoreName ParentAsDataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PurgeCompletionSuggestionsRequest
    {
        /// <summary>
        /// <see cref="DataStoreName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataStoreName ParentAsDataStoreName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataStoreName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
