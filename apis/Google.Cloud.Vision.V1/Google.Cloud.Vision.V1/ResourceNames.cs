// Copyright 2018 Google LLC
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
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.Vision.V1
{
    /// <summary>
    /// Resource name for the 'image' resource.
    /// </summary>
    public sealed partial class ImageName : gax::IResourceName, sys::IEquatable<ImageName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/products/{product}/referenceImages/{image}");

        /// <summary>
        /// Parses the given image resource name in string form into a new
        /// <see cref="ImageName"/> instance.
        /// </summary>
        /// <param name="imageName">The image resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ImageName"/> if successful.</returns>
        public static ImageName Parse(string imageName)
        {
            gax::GaxPreconditions.CheckNotNull(imageName, nameof(imageName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(imageName);
            return new ImageName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given image resource name in string form into a new
        /// <see cref="ImageName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="imageName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="imageName">The image resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ImageName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string imageName, out ImageName result)
        {
            gax::GaxPreconditions.CheckNotNull(imageName, nameof(imageName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(imageName, out resourceName))
            {
                result = new ImageName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ImageName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="productId">The product ID. Must not be <c>null</c>.</param>
        /// <param name="imageId">The image ID. Must not be <c>null</c>.</param>
        public ImageName(string projectId, string locationId, string productId, string imageId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            ProductId = gax::GaxPreconditions.CheckNotNull(productId, nameof(productId));
            ImageId = gax::GaxPreconditions.CheckNotNull(imageId, nameof(imageId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The product ID. Never <c>null</c>.
        /// </summary>
        public string ProductId { get; }

        /// <summary>
        /// The image ID. Never <c>null</c>.
        /// </summary>
        public string ImageId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, ProductId, ImageId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ImageName);

        /// <inheritdoc />
        public bool Equals(ImageName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ImageName a, ImageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ImageName a, ImageName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'location' resource.
    /// </summary>
    public sealed partial class LocationName : gax::IResourceName, sys::IEquatable<LocationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}");

        /// <summary>
        /// Parses the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(locationName);
            return new LocationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="locationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, out LocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(locationName, out resourceName))
            {
                result = new LocationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        public LocationName(string projectId, string locationId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LocationName);

        /// <inheritdoc />
        public bool Equals(LocationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationName a, LocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationName a, LocationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'product' resource.
    /// </summary>
    public sealed partial class ProductName : gax::IResourceName, sys::IEquatable<ProductName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/products/{product}");

        /// <summary>
        /// Parses the given product resource name in string form into a new
        /// <see cref="ProductName"/> instance.
        /// </summary>
        /// <param name="productName">The product resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProductName"/> if successful.</returns>
        public static ProductName Parse(string productName)
        {
            gax::GaxPreconditions.CheckNotNull(productName, nameof(productName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(productName);
            return new ProductName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given product resource name in string form into a new
        /// <see cref="ProductName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="productName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="productName">The product resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProductName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productName, out ProductName result)
        {
            gax::GaxPreconditions.CheckNotNull(productName, nameof(productName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(productName, out resourceName))
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

        /// <summary>
        /// Constructs a new instance of the <see cref="ProductName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="productId">The product ID. Must not be <c>null</c>.</param>
        public ProductName(string projectId, string locationId, string productId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            ProductId = gax::GaxPreconditions.CheckNotNull(productId, nameof(productId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The product ID. Never <c>null</c>.
        /// </summary>
        public string ProductId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, ProductId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProductName);

        /// <inheritdoc />
        public bool Equals(ProductName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProductName a, ProductName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProductName a, ProductName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'product_set' resource.
    /// </summary>
    public sealed partial class ProductSetName : gax::IResourceName, sys::IEquatable<ProductSetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/productSets/{product_set}");

        /// <summary>
        /// Parses the given product_set resource name in string form into a new
        /// <see cref="ProductSetName"/> instance.
        /// </summary>
        /// <param name="productSetName">The product_set resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProductSetName"/> if successful.</returns>
        public static ProductSetName Parse(string productSetName)
        {
            gax::GaxPreconditions.CheckNotNull(productSetName, nameof(productSetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(productSetName);
            return new ProductSetName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given product_set resource name in string form into a new
        /// <see cref="ProductSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="productSetName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="productSetName">The product_set resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProductSetName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productSetName, out ProductSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(productSetName, nameof(productSetName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(productSetName, out resourceName))
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

        /// <summary>
        /// Constructs a new instance of the <see cref="ProductSetName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="productSetId">The productSet ID. Must not be <c>null</c>.</param>
        public ProductSetName(string projectId, string locationId, string productSetId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            ProductSetId = gax::GaxPreconditions.CheckNotNull(productSetId, nameof(productSetId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The productSet ID. Never <c>null</c>.
        /// </summary>
        public string ProductSetId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, ProductSetId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProductSetName);

        /// <inheritdoc />
        public bool Equals(ProductSetName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProductSetName a, ProductSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProductSetName a, ProductSetName b) => !(a == b);
    }



}