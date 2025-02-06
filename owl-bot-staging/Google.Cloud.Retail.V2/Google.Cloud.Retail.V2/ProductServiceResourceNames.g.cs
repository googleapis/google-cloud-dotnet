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
using gcrv = Google.Cloud.Retail.V2;

namespace Google.Cloud.Retail.V2
{
    public partial class CreateProductRequest
    {
        /// <summary><see cref="BranchName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BranchName ParentAsBranchName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BranchName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetProductRequest
    {
        /// <summary>
        /// <see cref="gcrv::ProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::ProductName ProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::ProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteProductRequest
    {
        /// <summary>
        /// <see cref="gcrv::ProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::ProductName ProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::ProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListProductsRequest
    {
        /// <summary><see cref="BranchName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BranchName ParentAsBranchName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BranchName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AddFulfillmentPlacesRequest
    {
        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Product"/> resource name property.
        /// </summary>
        public ProductName ProductAsProductName
        {
            get => string.IsNullOrEmpty(Product) ? null : ProductName.Parse(Product, allowUnparsed: true);
            set => Product = value?.ToString() ?? "";
        }
    }

    public partial class AddLocalInventoriesRequest
    {
        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Product"/> resource name property.
        /// </summary>
        public ProductName ProductAsProductName
        {
            get => string.IsNullOrEmpty(Product) ? null : ProductName.Parse(Product, allowUnparsed: true);
            set => Product = value?.ToString() ?? "";
        }
    }

    public partial class RemoveLocalInventoriesRequest
    {
        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Product"/> resource name property.
        /// </summary>
        public ProductName ProductAsProductName
        {
            get => string.IsNullOrEmpty(Product) ? null : ProductName.Parse(Product, allowUnparsed: true);
            set => Product = value?.ToString() ?? "";
        }
    }

    public partial class RemoveFulfillmentPlacesRequest
    {
        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Product"/> resource name property.
        /// </summary>
        public ProductName ProductAsProductName
        {
            get => string.IsNullOrEmpty(Product) ? null : ProductName.Parse(Product, allowUnparsed: true);
            set => Product = value?.ToString() ?? "";
        }
    }
}
