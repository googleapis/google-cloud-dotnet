// Copyright 2019 Google LLC
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

using gax = Google.Api.Gax;
using gcvv = Google.Cloud.Vision.V1;
using sys = System;

namespace Google.Cloud.Vision.V1
{
    /// <summary>Resource name for the <c>Product</c> resource.</summary>
    public sealed partial class ProductName : gax::IResourceName, sys::IEquatable<ProductName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/products/{product}");

        /// <summary>
        /// Parses the given <c>Product</c> resource name in string form into a new <see cref="ProductName"/> instance.
        /// </summary>
        /// <param name="productName">The <c>Product</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProductName"/> if successful.</returns>
        public static ProductName Parse(string productName)
        {
            gax::GaxPreconditions.CheckNotNull(productName, nameof(productName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(productName);
            return new ProductName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="ProductName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="productName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="productName">The <c>Product</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productName, out ProductName result)
        {
            gax::GaxPreconditions.CheckNotNull(productName, nameof(productName));
            if (s_template.TryParseName(productName, out gax::TemplatedResourceName resourceName))
            {
                result = new ProductName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProductName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProductName"/>.</returns>
        public static string Format(string projectId, string locationId, string productId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(productId, nameof(productId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProductName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c>.</param>
        public ProductName(string projectId, string locationId, string productId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            ProductId = gax::GaxPreconditions.CheckNotNull(productId, nameof(productId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Location</c> ID. Never <c>null</c>.</summary>
        public string LocationId { get; }

        /// <summary>The <c>Product</c> ID. Never <c>null</c>.</summary>
        public string ProductId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, LocationId, ProductId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProductName);

        /// <inheritdoc/>
        public bool Equals(ProductName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ProductName a, ProductName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ProductName a, ProductName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ProductSet</c> resource.</summary>
    public sealed partial class ProductSetName : gax::IResourceName, sys::IEquatable<ProductSetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/productSets/{product_set}");

        /// <summary>
        /// Parses the given <c>ProductSet</c> resource name in string form into a new <see cref="ProductSetName"/>
        /// instance.
        /// </summary>
        /// <param name="productSetName">
        /// The <c>ProductSet</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ProductSetName"/> if successful.</returns>
        public static ProductSetName Parse(string productSetName)
        {
            gax::GaxPreconditions.CheckNotNull(productSetName, nameof(productSetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(productSetName);
            return new ProductSetName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="ProductSetName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="productSetName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="productSetName">
        /// The <c>ProductSet</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductSetName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productSetName, out ProductSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(productSetName, nameof(productSetName));
            if (s_template.TryParseName(productSetName, out gax::TemplatedResourceName resourceName))
            {
                result = new ProductSetName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProductSetName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="productSetId">The <c>ProductSet</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProductSetName"/>.</returns>
        public static string Format(string projectId, string locationId, string productSetId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(productSetId, nameof(productSetId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProductSetName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="productSetId">The <c>ProductSet</c> ID. Must not be <c>null</c>.</param>
        public ProductSetName(string projectId, string locationId, string productSetId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            ProductSetId = gax::GaxPreconditions.CheckNotNull(productSetId, nameof(productSetId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Location</c> ID. Never <c>null</c>.</summary>
        public string LocationId { get; }

        /// <summary>The <c>ProductSet</c> ID. Never <c>null</c>.</summary>
        public string ProductSetId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, LocationId, ProductSetId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProductSetName);

        /// <inheritdoc/>
        public bool Equals(ProductSetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ProductSetName a, ProductSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ProductSetName a, ProductSetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReferenceImage</c> resource.</summary>
    public sealed partial class ReferenceImageName : gax::IResourceName, sys::IEquatable<ReferenceImageName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/products/{product}/referenceImages/{reference_image}");

        /// <summary>
        /// Parses the given <c>ReferenceImage</c> resource name in string form into a new
        /// <see cref="ReferenceImageName"/> instance.
        /// </summary>
        /// <param name="referenceImageName">
        /// The <c>ReferenceImage</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ReferenceImageName"/> if successful.</returns>
        public static ReferenceImageName Parse(string referenceImageName)
        {
            gax::GaxPreconditions.CheckNotNull(referenceImageName, nameof(referenceImageName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(referenceImageName);
            return new ReferenceImageName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="ReferenceImageName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="referenceImageName"/>
        /// is <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="referenceImageName">
        /// The <c>ReferenceImage</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReferenceImageName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string referenceImageName, out ReferenceImageName result)
        {
            gax::GaxPreconditions.CheckNotNull(referenceImageName, nameof(referenceImageName));
            if (s_template.TryParseName(referenceImageName, out gax::TemplatedResourceName resourceName))
            {
                result = new ReferenceImageName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ReferenceImageName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c>.</param>
        /// <param name="referenceImageId">The <c>ReferenceImage</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ReferenceImageName"/>.</returns>
        public static string Format(string projectId, string locationId, string productId, string referenceImageId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(productId, nameof(productId)), gax::GaxPreconditions.CheckNotNull(referenceImageId, nameof(referenceImageId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ReferenceImageName"/> resource name class from its component
        /// parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="productId">The <c>Product</c> ID. Must not be <c>null</c>.</param>
        /// <param name="referenceImageId">The <c>ReferenceImage</c> ID. Must not be <c>null</c>.</param>
        public ReferenceImageName(string projectId, string locationId, string productId, string referenceImageId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            ProductId = gax::GaxPreconditions.CheckNotNull(productId, nameof(productId));
            ReferenceImageId = gax::GaxPreconditions.CheckNotNull(referenceImageId, nameof(referenceImageId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Location</c> ID. Never <c>null</c>.</summary>
        public string LocationId { get; }

        /// <summary>The <c>Product</c> ID. Never <c>null</c>.</summary>
        public string ProductId { get; }

        /// <summary>The <c>ReferenceImage</c> ID. Never <c>null</c>.</summary>
        public string ReferenceImageId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, LocationId, ProductId, ReferenceImageId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReferenceImageName);

        /// <inheritdoc/>
        public bool Equals(ReferenceImageName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ReferenceImageName a, ReferenceImageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ReferenceImageName a, ReferenceImageName b) => !(a == b);
    }

    public partial class Product
    {
        /// <summary>
        /// <see cref="gcvv::ProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductName ProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ProductSet
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReferenceImage
    {
        /// <summary>
        /// <see cref="gcvv::ReferenceImageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ReferenceImageName ReferenceImageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ReferenceImageName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateProductRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListProductsRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetProductRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductName ProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteProductRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductName ProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateProductSetRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListProductSetsRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetProductSetRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteProductSetRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReferenceImageRequest
    {
        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProductName ParentAsProductName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProductName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListReferenceImagesRequest
    {
        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProductName ParentAsProductName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ProductName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetReferenceImageRequest
    {
        /// <summary>
        /// <see cref="gcvv::ReferenceImageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ReferenceImageName ReferenceImageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ReferenceImageName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteReferenceImageRequest
    {
        /// <summary>
        /// <see cref="gcvv::ReferenceImageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ReferenceImageName ReferenceImageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ReferenceImageName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AddProductToProductSetRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Product"/> resource name property.
        /// </summary>
        public ProductName ProductAsProductName
        {
            get => string.IsNullOrEmpty(Product) ? null : ProductName.Parse(Product);
            set => Product = value?.ToString() ?? "";
        }
    }

    public partial class RemoveProductFromProductSetRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductName"/>-typed view over the <see cref="Product"/> resource name property.
        /// </summary>
        public ProductName ProductAsProductName
        {
            get => string.IsNullOrEmpty(Product) ? null : ProductName.Parse(Product);
            set => Product = value?.ToString() ?? "";
        }
    }

    public partial class ListProductsInProductSetRequest
    {
        /// <summary>
        /// <see cref="gcvv::ProductSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProductSetName ProductSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProductSetName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportProductSetsRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PurgeProductsRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
