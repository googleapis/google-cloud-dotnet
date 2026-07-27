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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gccv = Google.Cloud.CommerceProducer.V1Beta;
using sys = System;

namespace Google.Cloud.CommerceProducer.V1Beta
{
    /// <summary>Resource name for the <c>Sku</c> resource.</summary>
    public sealed partial class SkuName : gax::IResourceName, sys::IEquatable<SkuName>
    {
        /// <summary>The possible contents of <see cref="SkuName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/services/{service}/skus/{sku}</c>
            /// .
            /// </summary>
            ProjectLocationServiceSku = 1,
        }

        private static gax::PathTemplate s_projectLocationServiceSku = new gax::PathTemplate("projects/{project}/locations/{location}/services/{service}/skus/{sku}");

        /// <summary>Creates a <see cref="SkuName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SkuName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SkuName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SkuName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SkuName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/skus/{sku}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SkuName"/> constructed from the provided ids.</returns>
        public static SkuName FromProjectLocationServiceSku(string projectId, string locationId, string serviceId, string skuId) =>
            new SkuName(ResourceNameType.ProjectLocationServiceSku, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), skuId: gax::GaxPreconditions.CheckNotNullOrEmpty(skuId, nameof(skuId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkuName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/skus/{sku}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkuName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/skus/{sku}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceId, string skuId) =>
            FormatProjectLocationServiceSku(projectId, locationId, serviceId, skuId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkuName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/skus/{sku}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkuName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/skus/{sku}</c>.
        /// </returns>
        public static string FormatProjectLocationServiceSku(string projectId, string locationId, string serviceId, string skuId) =>
            s_projectLocationServiceSku.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(skuId, nameof(skuId)));

        /// <summary>Parses the given resource name string into a new <see cref="SkuName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/services/{service}/skus/{sku}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SkuName"/> if successful.</returns>
        public static SkuName Parse(string skuName) => Parse(skuName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SkuName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/services/{service}/skus/{sku}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SkuName"/> if successful.</returns>
        public static SkuName Parse(string skuName, bool allowUnparsed) =>
            TryParse(skuName, allowUnparsed, out SkuName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="SkuName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/services/{service}/skus/{sku}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkuName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skuName, out SkuName result) => TryParse(skuName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SkuName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/services/{service}/skus/{sku}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skuName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkuName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skuName, bool allowUnparsed, out SkuName result)
        {
            gax::GaxPreconditions.CheckNotNull(skuName, nameof(skuName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceSku.TryParseName(skuName, out resourceName))
            {
                result = FromProjectLocationServiceSku(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(skuName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SkuName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serviceId = null, string skuId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServiceId = serviceId;
            SkuId = skuId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SkuName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/skus/{sku}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skuId">The <c>Sku</c> ID. Must not be <c>null</c> or empty.</param>
        public SkuName(string projectId, string locationId, string serviceId, string skuId) : this(ResourceNameType.ProjectLocationServiceSku, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), skuId: gax::GaxPreconditions.CheckNotNullOrEmpty(skuId, nameof(skuId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Service</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ServiceId { get; }

        /// <summary>
        /// The <c>Sku</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SkuId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServiceSku: return s_projectLocationServiceSku.Expand(ProjectId, LocationId, ServiceId, SkuId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SkuName);

        /// <inheritdoc/>
        public bool Equals(SkuName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SkuName a, SkuName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SkuName a, SkuName b) => !(a == b);
    }

    public partial class Sku
    {
        /// <summary>
        /// <see cref="gccv::SkuName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::SkuName SkuName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::SkuName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class SkuPrice
            {
                public partial class Types
                {
                    public partial class AiPlatformManagedModelUsageFee
                    {
                        public partial class Types
                        {
                            public partial class ProvisionedThroughputOverage
                            {
                                /// <summary>
                                /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Service"/> resource
                                /// name property.
                                /// </summary>
                                public gagr::LocationName ServiceAsLocationName
                                {
                                    get => string.IsNullOrEmpty(Service) ? null : gagr::LocationName.Parse(Service, allowUnparsed: true);
                                    set => Service = value?.ToString() ?? "";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
