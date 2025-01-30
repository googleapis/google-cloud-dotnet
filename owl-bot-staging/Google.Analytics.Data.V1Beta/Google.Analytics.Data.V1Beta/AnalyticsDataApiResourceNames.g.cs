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
using gadv = Google.Analytics.Data.V1Beta;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Analytics.Data.V1Beta
{
    /// <summary>Resource name for the <c>Metadata</c> resource.</summary>
    public sealed partial class MetadataName : gax::IResourceName, sys::IEquatable<MetadataName>
    {
        /// <summary>The possible contents of <see cref="MetadataName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>properties/{property}/metadata</c>.</summary>
            Property = 1,
        }

        private static gax::PathTemplate s_property = new gax::PathTemplate("properties/{property}/metadata");

        /// <summary>Creates a <see cref="MetadataName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MetadataName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static MetadataName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MetadataName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MetadataName"/> with the pattern <c>properties/{property}/metadata</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MetadataName"/> constructed from the provided ids.</returns>
        public static MetadataName FromProperty(string propertyId) =>
            new MetadataName(ResourceNameType.Property, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetadataName"/> with pattern
        /// <c>properties/{property}/metadata</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetadataName"/> with pattern <c>properties/{property}/metadata</c>
        /// .
        /// </returns>
        public static string Format(string propertyId) => FormatProperty(propertyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetadataName"/> with pattern
        /// <c>properties/{property}/metadata</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetadataName"/> with pattern <c>properties/{property}/metadata</c>
        /// .
        /// </returns>
        public static string FormatProperty(string propertyId) =>
            s_property.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)));

        /// <summary>Parses the given resource name string into a new <see cref="MetadataName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}/metadata</c></description></item></list>
        /// </remarks>
        /// <param name="metadataName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MetadataName"/> if successful.</returns>
        public static MetadataName Parse(string metadataName) => Parse(metadataName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MetadataName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}/metadata</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metadataName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MetadataName"/> if successful.</returns>
        public static MetadataName Parse(string metadataName, bool allowUnparsed) =>
            TryParse(metadataName, allowUnparsed, out MetadataName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetadataName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}/metadata</c></description></item></list>
        /// </remarks>
        /// <param name="metadataName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetadataName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metadataName, out MetadataName result) => TryParse(metadataName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetadataName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}/metadata</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metadataName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetadataName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metadataName, bool allowUnparsed, out MetadataName result)
        {
            gax::GaxPreconditions.CheckNotNull(metadataName, nameof(metadataName));
            gax::TemplatedResourceName resourceName;
            if (s_property.TryParseName(metadataName, out resourceName))
            {
                result = FromProperty(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(metadataName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MetadataName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MetadataName"/> class from the component parts of pattern
        /// <c>properties/{property}/metadata</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        public MetadataName(string propertyId) : this(ResourceNameType.Property, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)))
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
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Property: return s_property.Expand(PropertyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MetadataName);

        /// <inheritdoc/>
        public bool Equals(MetadataName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MetadataName a, MetadataName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MetadataName a, MetadataName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AudienceExport</c> resource.</summary>
    public sealed partial class AudienceExportName : gax::IResourceName, sys::IEquatable<AudienceExportName>
    {
        /// <summary>The possible contents of <see cref="AudienceExportName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>properties/{property}/audienceExports/{audience_export}</c>.
            /// </summary>
            PropertyAudienceExport = 1,
        }

        private static gax::PathTemplate s_propertyAudienceExport = new gax::PathTemplate("properties/{property}/audienceExports/{audience_export}");

        /// <summary>Creates a <see cref="AudienceExportName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AudienceExportName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AudienceExportName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AudienceExportName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AudienceExportName"/> with the pattern
        /// <c>properties/{property}/audienceExports/{audience_export}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceExportId">The <c>AudienceExport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AudienceExportName"/> constructed from the provided ids.</returns>
        public static AudienceExportName FromPropertyAudienceExport(string propertyId, string audienceExportId) =>
            new AudienceExportName(ResourceNameType.PropertyAudienceExport, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), audienceExportId: gax::GaxPreconditions.CheckNotNullOrEmpty(audienceExportId, nameof(audienceExportId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AudienceExportName"/> with pattern
        /// <c>properties/{property}/audienceExports/{audience_export}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceExportId">The <c>AudienceExport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AudienceExportName"/> with pattern
        /// <c>properties/{property}/audienceExports/{audience_export}</c>.
        /// </returns>
        public static string Format(string propertyId, string audienceExportId) =>
            FormatPropertyAudienceExport(propertyId, audienceExportId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AudienceExportName"/> with pattern
        /// <c>properties/{property}/audienceExports/{audience_export}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceExportId">The <c>AudienceExport</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AudienceExportName"/> with pattern
        /// <c>properties/{property}/audienceExports/{audience_export}</c>.
        /// </returns>
        public static string FormatPropertyAudienceExport(string propertyId, string audienceExportId) =>
            s_propertyAudienceExport.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(audienceExportId, nameof(audienceExportId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AudienceExportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/audienceExports/{audience_export}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="audienceExportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AudienceExportName"/> if successful.</returns>
        public static AudienceExportName Parse(string audienceExportName) => Parse(audienceExportName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AudienceExportName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/audienceExports/{audience_export}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="audienceExportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AudienceExportName"/> if successful.</returns>
        public static AudienceExportName Parse(string audienceExportName, bool allowUnparsed) =>
            TryParse(audienceExportName, allowUnparsed, out AudienceExportName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AudienceExportName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/audienceExports/{audience_export}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="audienceExportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AudienceExportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string audienceExportName, out AudienceExportName result) =>
            TryParse(audienceExportName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AudienceExportName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>properties/{property}/audienceExports/{audience_export}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="audienceExportName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AudienceExportName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string audienceExportName, bool allowUnparsed, out AudienceExportName result)
        {
            gax::GaxPreconditions.CheckNotNull(audienceExportName, nameof(audienceExportName));
            gax::TemplatedResourceName resourceName;
            if (s_propertyAudienceExport.TryParseName(audienceExportName, out resourceName))
            {
                result = FromPropertyAudienceExport(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(audienceExportName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AudienceExportName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string audienceExportId = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AudienceExportId = audienceExportId;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AudienceExportName"/> class from the component parts of pattern
        /// <c>properties/{property}/audienceExports/{audience_export}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceExportId">The <c>AudienceExport</c> ID. Must not be <c>null</c> or empty.</param>
        public AudienceExportName(string propertyId, string audienceExportId) : this(ResourceNameType.PropertyAudienceExport, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), audienceExportId: gax::GaxPreconditions.CheckNotNullOrEmpty(audienceExportId, nameof(audienceExportId)))
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
        /// The <c>AudienceExport</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AudienceExportId { get; }

        /// <summary>
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertyAudienceExport: return s_propertyAudienceExport.Expand(PropertyId, AudienceExportId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AudienceExportName);

        /// <inheritdoc/>
        public bool Equals(AudienceExportName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AudienceExportName a, AudienceExportName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AudienceExportName a, AudienceExportName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Property</c> resource.</summary>
    public sealed partial class PropertyName : gax::IResourceName, sys::IEquatable<PropertyName>
    {
        /// <summary>The possible contents of <see cref="PropertyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>properties/{property}</c>.</summary>
            Property = 1,
        }

        private static gax::PathTemplate s_property = new gax::PathTemplate("properties/{property}");

        /// <summary>Creates a <see cref="PropertyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PropertyName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static PropertyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PropertyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="PropertyName"/> with the pattern <c>properties/{property}</c>.</summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PropertyName"/> constructed from the provided ids.</returns>
        public static PropertyName FromProperty(string propertyId) =>
            new PropertyName(ResourceNameType.Property, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PropertyName"/> with pattern
        /// <c>properties/{property}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PropertyName"/> with pattern <c>properties/{property}</c>.
        /// </returns>
        public static string Format(string propertyId) => FormatProperty(propertyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PropertyName"/> with pattern
        /// <c>properties/{property}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PropertyName"/> with pattern <c>properties/{property}</c>.
        /// </returns>
        public static string FormatProperty(string propertyId) =>
            s_property.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)));

        /// <summary>Parses the given resource name string into a new <see cref="PropertyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}</c></description></item></list>
        /// </remarks>
        /// <param name="propertyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PropertyName"/> if successful.</returns>
        public static PropertyName Parse(string propertyName) => Parse(propertyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PropertyName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="propertyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PropertyName"/> if successful.</returns>
        public static PropertyName Parse(string propertyName, bool allowUnparsed) =>
            TryParse(propertyName, allowUnparsed, out PropertyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PropertyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}</c></description></item></list>
        /// </remarks>
        /// <param name="propertyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PropertyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string propertyName, out PropertyName result) => TryParse(propertyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PropertyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>properties/{property}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="propertyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PropertyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string propertyName, bool allowUnparsed, out PropertyName result)
        {
            gax::GaxPreconditions.CheckNotNull(propertyName, nameof(propertyName));
            gax::TemplatedResourceName resourceName;
            if (s_property.TryParseName(propertyName, out resourceName))
            {
                result = FromProperty(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(propertyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PropertyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string propertyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PropertyId = propertyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PropertyName"/> class from the component parts of pattern
        /// <c>properties/{property}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        public PropertyName(string propertyId) : this(ResourceNameType.Property, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)))
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
        /// The <c>Property</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PropertyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Property: return s_property.Expand(PropertyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PropertyName);

        /// <inheritdoc/>
        public bool Equals(PropertyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PropertyName a, PropertyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PropertyName a, PropertyName b) => !(a == b);
    }

    public partial class Metadata
    {
        /// <summary>
        /// <see cref="gadv::MetadataName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gadv::MetadataName MetadataName
        {
            get => string.IsNullOrEmpty(Name) ? null : gadv::MetadataName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetMetadataRequest
    {
        /// <summary>
        /// <see cref="gadv::MetadataName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gadv::MetadataName MetadataName
        {
            get => string.IsNullOrEmpty(Name) ? null : gadv::MetadataName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAudienceExportRequest
    {
        /// <summary>
        /// <see cref="gadv::AudienceExportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gadv::AudienceExportName AudienceExportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gadv::AudienceExportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAudienceExportsRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateAudienceExportRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PropertyName ParentAsPropertyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PropertyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AudienceExport
    {
        /// <summary>
        /// <see cref="gadv::AudienceExportName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gadv::AudienceExportName AudienceExportName
        {
            get => string.IsNullOrEmpty(Name) ? null : gadv::AudienceExportName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
