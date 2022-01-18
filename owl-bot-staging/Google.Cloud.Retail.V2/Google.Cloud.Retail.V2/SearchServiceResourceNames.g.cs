// Copyright 2022 Google LLC
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

namespace Google.Cloud.Retail.V2
{
    public partial class SearchRequest
    {
        /// <summary><see cref="BranchName"/>-typed view over the <see cref="Branch"/> resource name property.</summary>
        public BranchName BranchAsBranchName
        {
            get => string.IsNullOrEmpty(Branch) ? null : BranchName.Parse(Branch, allowUnparsed: true);
            set => Branch = value?.ToString() ?? "";
        }
    }
}
