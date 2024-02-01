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

namespace Google.Cloud.Vision.V1
{
    public partial class ProductSearchParams
    {
        /// <summary>
        /// <see cref="ProductSetName"/>-typed view over the <see cref="ProductSet"/> resource name property.
        /// </summary>
        public ProductSetName ProductSetAsProductSetName
        {
            get => string.IsNullOrEmpty(ProductSet) ? null : ProductSetName.Parse(ProductSet, allowUnparsed: true);
            set => ProductSet = value?.ToString() ?? "";
        }
    }
}
