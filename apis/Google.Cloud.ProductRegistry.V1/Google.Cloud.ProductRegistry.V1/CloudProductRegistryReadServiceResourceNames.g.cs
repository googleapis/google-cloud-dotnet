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
using gcpv = Google.Cloud.ProductRegistry.V1;

namespace Google.Cloud.ProductRegistry.V1
{
    public partial class GetProductSuiteRequest
    {
        /// <summary>
        /// <see cref="gcpv::ProductSuiteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ProductSuiteName ProductSuiteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ProductSuiteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetLogicalProductRequest
    {
        /// <summary>
        /// <see cref="gcpv::LogicalProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::LogicalProductName LogicalProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::LogicalProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetLogicalProductVariantRequest
    {
        /// <summary>
        /// <see cref="gcpv::LogicalProductVariantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::LogicalProductVariantName LogicalProductVariantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::LogicalProductVariantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLogicalProductVariantsRequest
    {
        /// <summary>
        /// <see cref="LogicalProductName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LogicalProductName ParentAsLogicalProductName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LogicalProductName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
