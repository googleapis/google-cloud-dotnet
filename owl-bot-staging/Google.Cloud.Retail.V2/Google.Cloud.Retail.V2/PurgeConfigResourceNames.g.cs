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
using gax = Google.Api.Gax;

namespace Google.Cloud.Retail.V2
{
    public partial class PurgeProductsRequest
    {
        /// <summary><see cref="BranchName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BranchName ParentAsBranchName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BranchName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PurgeProductsResponse
    {
        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="PurgeSample"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ProductName> PurgeSampleAsProductNames
        {
            get => new gax::ResourceNameList<ProductName>(PurgeSample, s => string.IsNullOrEmpty(s) ? null : ProductName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class PurgeUserEventsRequest
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
}
