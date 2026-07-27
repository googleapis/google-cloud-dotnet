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
using gax = Google.Api.Gax;
using gccv = Google.Cloud.CommerceProducer.V1Beta;
using sys = System;

namespace Google.Cloud.CommerceProducer.V1Beta
{
    /// <summary>Resource name for the <c>StandardOffer</c> resource.</summary>
    public sealed partial class StandardOfferName : gax::IResourceName, sys::IEquatable<StandardOfferName>
    {
        /// <summary>The possible contents of <see cref="StandardOfferName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}</c>.
            /// </summary>
            ProjectLocationServiceStandardOffer = 1,
        }

        private static gax::PathTemplate s_projectLocationServiceStandardOffer = new gax::PathTemplate("projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}");

        /// <summary>Creates a <see cref="StandardOfferName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StandardOfferName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StandardOfferName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StandardOfferName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StandardOfferName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardOfferId">The <c>StandardOffer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StandardOfferName"/> constructed from the provided ids.</returns>
        public static StandardOfferName FromProjectLocationServiceStandardOffer(string projectId, string locationId, string serviceId, string standardOfferId) =>
            new StandardOfferName(ResourceNameType.ProjectLocationServiceStandardOffer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), standardOfferId: gax::GaxPreconditions.CheckNotNullOrEmpty(standardOfferId, nameof(standardOfferId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StandardOfferName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardOfferId">The <c>StandardOffer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StandardOfferName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceId, string standardOfferId) =>
            FormatProjectLocationServiceStandardOffer(projectId, locationId, serviceId, standardOfferId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StandardOfferName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardOfferId">The <c>StandardOffer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StandardOfferName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}</c>.
        /// </returns>
        public static string FormatProjectLocationServiceStandardOffer(string projectId, string locationId, string serviceId, string standardOfferId) =>
            s_projectLocationServiceStandardOffer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(standardOfferId, nameof(standardOfferId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StandardOfferName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="standardOfferName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StandardOfferName"/> if successful.</returns>
        public static StandardOfferName Parse(string standardOfferName) => Parse(standardOfferName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StandardOfferName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="standardOfferName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StandardOfferName"/> if successful.</returns>
        public static StandardOfferName Parse(string standardOfferName, bool allowUnparsed) =>
            TryParse(standardOfferName, allowUnparsed, out StandardOfferName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StandardOfferName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="standardOfferName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StandardOfferName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string standardOfferName, out StandardOfferName result) =>
            TryParse(standardOfferName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StandardOfferName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="standardOfferName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StandardOfferName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string standardOfferName, bool allowUnparsed, out StandardOfferName result)
        {
            gax::GaxPreconditions.CheckNotNull(standardOfferName, nameof(standardOfferName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceStandardOffer.TryParseName(standardOfferName, out resourceName))
            {
                result = FromProjectLocationServiceStandardOffer(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(standardOfferName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StandardOfferName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serviceId = null, string standardOfferId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServiceId = serviceId;
            StandardOfferId = standardOfferId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StandardOfferName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="standardOfferId">The <c>StandardOffer</c> ID. Must not be <c>null</c> or empty.</param>
        public StandardOfferName(string projectId, string locationId, string serviceId, string standardOfferId) : this(ResourceNameType.ProjectLocationServiceStandardOffer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), standardOfferId: gax::GaxPreconditions.CheckNotNullOrEmpty(standardOfferId, nameof(standardOfferId)))
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
        /// The <c>StandardOffer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string StandardOfferId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServiceStandardOffer: return s_projectLocationServiceStandardOffer.Expand(ProjectId, LocationId, ServiceId, StandardOfferId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StandardOfferName);

        /// <inheritdoc/>
        public bool Equals(StandardOfferName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(StandardOfferName a, StandardOfferName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(StandardOfferName a, StandardOfferName b) => !(a == b);
    }

    public partial class StandardOffer
    {
        /// <summary>
        /// <see cref="gccv::StandardOfferName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::StandardOfferName StandardOfferName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::StandardOfferName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class PriceModel
            {
                public partial class Types
                {
                    public partial class SkuList
                    {
                        /// <summary>
                        /// <see cref="SkuName"/>-typed view over the <see cref="Skus"/> resource name property.
                        /// </summary>
                        public gax::ResourceNameList<SkuName> SkusAsSkuNames
                        {
                            get => new gax::ResourceNameList<SkuName>(Skus, s => string.IsNullOrEmpty(s) ? null : SkuName.Parse(s, allowUnparsed: true));
                        }
                    }

                    public partial class SkuGroupList
                    {
                        /// <summary>
                        /// <see cref="SkuGroupName"/>-typed view over the <see cref="SkuGroups"/> resource name
                        /// property.
                        /// </summary>
                        public gax::ResourceNameList<SkuGroupName> SkuGroupsAsSkuGroupNames
                        {
                            get => new gax::ResourceNameList<SkuGroupName>(SkuGroups, s => string.IsNullOrEmpty(s) ? null : SkuGroupName.Parse(s, allowUnparsed: true));
                        }
                    }

                    public partial class FlatFeeSubscription
                    {
                        /// <summary>
                        /// <see cref="SkuName"/>-typed view over the <see cref="Sku"/> resource name property.
                        /// </summary>
                        public SkuName SkuAsSkuName
                        {
                            get => string.IsNullOrEmpty(Sku) ? null : SkuName.Parse(Sku, allowUnparsed: true);
                            set => Sku = value?.ToString() ?? "";
                        }
                    }
                }
            }
        }
    }
}
