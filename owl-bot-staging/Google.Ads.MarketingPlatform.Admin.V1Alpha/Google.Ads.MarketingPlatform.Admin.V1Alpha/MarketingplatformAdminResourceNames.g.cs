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
using gamav = Google.Ads.MarketingPlatform.Admin.V1Alpha;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.MarketingPlatform.Admin.V1Alpha
{
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

    public partial class GetOrganizationRequest
    {
        /// <summary>
        /// <see cref="gamav::OrganizationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamav::OrganizationName OrganizationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamav::OrganizationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAnalyticsAccountLinksRequest
    {
        /// <summary>
        /// <see cref="OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateAnalyticsAccountLinkRequest
    {
        /// <summary>
        /// <see cref="OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAnalyticsAccountLinkRequest
    {
        /// <summary>
        /// <see cref="gamav::AnalyticsAccountLinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gamav::AnalyticsAccountLinkName AnalyticsAccountLinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gamav::AnalyticsAccountLinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SetPropertyServiceLevelRequest
    {
        /// <summary>
        /// <see cref="PropertyName"/>-typed view over the <see cref="AnalyticsProperty"/> resource name property.
        /// </summary>
        public PropertyName AnalyticsPropertyAsPropertyName
        {
            get => string.IsNullOrEmpty(AnalyticsProperty) ? null : PropertyName.Parse(AnalyticsProperty, allowUnparsed: true);
            set => AnalyticsProperty = value?.ToString() ?? "";
        }
    }
}
