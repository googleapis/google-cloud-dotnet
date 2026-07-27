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
    /// <summary>Resource name for the <c>PrivateOffer</c> resource.</summary>
    public sealed partial class PrivateOfferName : gax::IResourceName, sys::IEquatable<PrivateOfferName>
    {
        /// <summary>The possible contents of <see cref="PrivateOfferName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/privateOffers/{private_offer}</c>
            /// .
            /// </summary>
            ProjectLocationPrivateOffer = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateOffer = new gax::PathTemplate("projects/{project}/locations/{location}/privateOffers/{private_offer}");

        /// <summary>Creates a <see cref="PrivateOfferName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PrivateOfferName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PrivateOfferName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PrivateOfferName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PrivateOfferName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateOfferId">The <c>PrivateOffer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PrivateOfferName"/> constructed from the provided ids.</returns>
        public static PrivateOfferName FromProjectLocationPrivateOffer(string projectId, string locationId, string privateOfferId) =>
            new PrivateOfferName(ResourceNameType.ProjectLocationPrivateOffer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateOfferId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateOfferId, nameof(privateOfferId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrivateOfferName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateOfferId">The <c>PrivateOffer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PrivateOfferName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string privateOfferId) =>
            FormatProjectLocationPrivateOffer(projectId, locationId, privateOfferId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrivateOfferName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateOfferId">The <c>PrivateOffer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PrivateOfferName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}</c>.
        /// </returns>
        public static string FormatProjectLocationPrivateOffer(string projectId, string locationId, string privateOfferId) =>
            s_projectLocationPrivateOffer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateOfferId, nameof(privateOfferId)));

        /// <summary>Parses the given resource name string into a new <see cref="PrivateOfferName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/privateOffers/{private_offer}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="privateOfferName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PrivateOfferName"/> if successful.</returns>
        public static PrivateOfferName Parse(string privateOfferName) => Parse(privateOfferName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PrivateOfferName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/privateOffers/{private_offer}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="privateOfferName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PrivateOfferName"/> if successful.</returns>
        public static PrivateOfferName Parse(string privateOfferName, bool allowUnparsed) =>
            TryParse(privateOfferName, allowUnparsed, out PrivateOfferName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrivateOfferName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/privateOffers/{private_offer}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="privateOfferName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrivateOfferName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string privateOfferName, out PrivateOfferName result) =>
            TryParse(privateOfferName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrivateOfferName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/privateOffers/{private_offer}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="privateOfferName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrivateOfferName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string privateOfferName, bool allowUnparsed, out PrivateOfferName result)
        {
            gax::GaxPreconditions.CheckNotNull(privateOfferName, nameof(privateOfferName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateOffer.TryParseName(privateOfferName, out resourceName))
            {
                result = FromProjectLocationPrivateOffer(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(privateOfferName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PrivateOfferName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string privateOfferId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PrivateOfferId = privateOfferId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PrivateOfferName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateOfferId">The <c>PrivateOffer</c> ID. Must not be <c>null</c> or empty.</param>
        public PrivateOfferName(string projectId, string locationId, string privateOfferId) : this(ResourceNameType.ProjectLocationPrivateOffer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateOfferId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateOfferId, nameof(privateOfferId)))
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
        /// The <c>PrivateOffer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateOfferId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationPrivateOffer: return s_projectLocationPrivateOffer.Expand(ProjectId, LocationId, PrivateOfferId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PrivateOfferName);

        /// <inheritdoc/>
        public bool Equals(PrivateOfferName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PrivateOfferName a, PrivateOfferName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PrivateOfferName a, PrivateOfferName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PrivateOfferDocument</c> resource.</summary>
    public sealed partial class PrivateOfferDocumentName : gax::IResourceName, sys::IEquatable<PrivateOfferDocumentName>
    {
        /// <summary>The possible contents of <see cref="PrivateOfferDocumentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}</c>.
            /// </summary>
            ProjectLocationPrivateOfferDocument = 1,
        }

        private static gax::PathTemplate s_projectLocationPrivateOfferDocument = new gax::PathTemplate("projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}");

        /// <summary>Creates a <see cref="PrivateOfferDocumentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PrivateOfferDocumentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PrivateOfferDocumentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PrivateOfferDocumentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PrivateOfferDocumentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateOfferId">The <c>PrivateOffer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="PrivateOfferDocumentName"/> constructed from the provided ids.
        /// </returns>
        public static PrivateOfferDocumentName FromProjectLocationPrivateOfferDocument(string projectId, string locationId, string privateOfferId, string documentId) =>
            new PrivateOfferDocumentName(ResourceNameType.ProjectLocationPrivateOfferDocument, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateOfferId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateOfferId, nameof(privateOfferId)), documentId: gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrivateOfferDocumentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateOfferId">The <c>PrivateOffer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PrivateOfferDocumentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string privateOfferId, string documentId) =>
            FormatProjectLocationPrivateOfferDocument(projectId, locationId, privateOfferId, documentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrivateOfferDocumentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateOfferId">The <c>PrivateOffer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PrivateOfferDocumentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}</c>.
        /// </returns>
        public static string FormatProjectLocationPrivateOfferDocument(string projectId, string locationId, string privateOfferId, string documentId) =>
            s_projectLocationPrivateOfferDocument.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(privateOfferId, nameof(privateOfferId)), gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PrivateOfferDocumentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="privateOfferDocumentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PrivateOfferDocumentName"/> if successful.</returns>
        public static PrivateOfferDocumentName Parse(string privateOfferDocumentName) =>
            Parse(privateOfferDocumentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PrivateOfferDocumentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="privateOfferDocumentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PrivateOfferDocumentName"/> if successful.</returns>
        public static PrivateOfferDocumentName Parse(string privateOfferDocumentName, bool allowUnparsed) =>
            TryParse(privateOfferDocumentName, allowUnparsed, out PrivateOfferDocumentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrivateOfferDocumentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="privateOfferDocumentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrivateOfferDocumentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string privateOfferDocumentName, out PrivateOfferDocumentName result) =>
            TryParse(privateOfferDocumentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrivateOfferDocumentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="privateOfferDocumentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrivateOfferDocumentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string privateOfferDocumentName, bool allowUnparsed, out PrivateOfferDocumentName result)
        {
            gax::GaxPreconditions.CheckNotNull(privateOfferDocumentName, nameof(privateOfferDocumentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPrivateOfferDocument.TryParseName(privateOfferDocumentName, out resourceName))
            {
                result = FromProjectLocationPrivateOfferDocument(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(privateOfferDocumentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PrivateOfferDocumentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string documentId = null, string locationId = null, string privateOfferId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DocumentId = documentId;
            LocationId = locationId;
            PrivateOfferId = privateOfferId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PrivateOfferDocumentName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/privateOffers/{private_offer}/documents/{document}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="privateOfferId">The <c>PrivateOffer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        public PrivateOfferDocumentName(string projectId, string locationId, string privateOfferId, string documentId) : this(ResourceNameType.ProjectLocationPrivateOfferDocument, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), privateOfferId: gax::GaxPreconditions.CheckNotNullOrEmpty(privateOfferId, nameof(privateOfferId)), documentId: gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)))
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
        /// The <c>Document</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DocumentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>PrivateOffer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PrivateOfferId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationPrivateOfferDocument: return s_projectLocationPrivateOfferDocument.Expand(ProjectId, LocationId, PrivateOfferId, DocumentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PrivateOfferDocumentName);

        /// <inheritdoc/>
        public bool Equals(PrivateOfferDocumentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PrivateOfferDocumentName a, PrivateOfferDocumentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PrivateOfferDocumentName a, PrivateOfferDocumentName b) => !(a == b);
    }

    public partial class PrivateOffer
    {
        /// <summary>
        /// <see cref="gccv::PrivateOfferName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PrivateOfferName PrivateOfferName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PrivateOfferName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Customer
            {
                /// <summary>
                /// <see cref="gagr::BillingAccountName"/>-typed view over the <see cref="TargetBillingAccount"/>
                /// resource name property.
                /// </summary>
                public gagr::BillingAccountName TargetBillingAccountAsBillingAccountName
                {
                    get => string.IsNullOrEmpty(TargetBillingAccount) ? null : gagr::BillingAccountName.Parse(TargetBillingAccount, allowUnparsed: true);
                    set => TargetBillingAccount = value?.ToString() ?? "";
                }
            }

            public partial class SingleProductOffer
            {
                /// <summary>
                /// <see cref="StandardOfferName"/>-typed view over the <see cref="BaseStandardOffer"/> resource name
                /// property.
                /// </summary>
                public StandardOfferName BaseStandardOfferAsStandardOfferName
                {
                    get => string.IsNullOrEmpty(BaseStandardOffer) ? null : StandardOfferName.Parse(BaseStandardOffer, allowUnparsed: true);
                    set => BaseStandardOffer = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="gccv::PrivateOfferName"/>-typed view over the <see cref="AmendedPrivateOffer"/> resource
                /// name property.
                /// </summary>
                public gccv::PrivateOfferName AmendedPrivateOfferAsPrivateOfferName
                {
                    get => string.IsNullOrEmpty(AmendedPrivateOffer) ? null : gccv::PrivateOfferName.Parse(AmendedPrivateOffer, allowUnparsed: true);
                    set => AmendedPrivateOffer = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="StandardOfferName"/>-typed view over the <see cref="AmendedStandardOffer"/> resource name
                /// property.
                /// </summary>
                public StandardOfferName AmendedStandardOfferAsStandardOfferName
                {
                    get => string.IsNullOrEmpty(AmendedStandardOffer) ? null : StandardOfferName.Parse(AmendedStandardOffer, allowUnparsed: true);
                    set => AmendedStandardOffer = value?.ToString() ?? "";
                }

                public partial class Types
                {
                    public partial class PriceModel
                    {
                        public partial class Types
                        {
                            public partial class SkuDiscount
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
    }

    public partial class PrivateOfferDocument
    {
        /// <summary>
        /// <see cref="gccv::PrivateOfferDocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PrivateOfferDocumentName PrivateOfferDocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PrivateOfferDocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
