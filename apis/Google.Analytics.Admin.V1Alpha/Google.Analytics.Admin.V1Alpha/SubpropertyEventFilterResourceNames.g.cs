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
using gaav = Google.Analytics.Admin.V1Alpha;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Analytics.Admin.V1Alpha
{
    /// <summary>Resource name for the <c>SubpropertyEventFilter</c> resource.</summary>
    public sealed partial class SubpropertyEventFilterName : gax::IResourceName, sys::IEquatable<SubpropertyEventFilterName>
    {
        /// <summary>The possible contents of <see cref="SubpropertyEventFilterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>properties/{property}/subpropertyEventFilters/{sub_property_event_filter}</c>.
            /// </summary>
            PropertySubPropertyEventFilter = 1,
        }

        private static gax::PathTemplate s_propertySubPropertyEventFilter = new gax::PathTemplate("properties/{property}/subpropertyEventFilters/{sub_property_event_filter}");

        /// <summary>Creates a <see cref="SubpropertyEventFilterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SubpropertyEventFilterName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SubpropertyEventFilterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SubpropertyEventFilterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SubpropertyEventFilterName"/> with the pattern
        /// <c>properties/{property}/subpropertyEventFilters/{sub_property_event_filter}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subPropertyEventFilterId">
        /// The <c>SubPropertyEventFilter</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="SubpropertyEventFilterName"/> constructed from the provided ids.
        /// </returns>
        public static SubpropertyEventFilterName FromPropertySubPropertyEventFilter(string propertyId, string subPropertyEventFilterId) =>
            new SubpropertyEventFilterName(ResourceNameType.PropertySubPropertyEventFilter, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), subPropertyEventFilterId: gax::GaxPreconditions.CheckNotNullOrEmpty(subPropertyEventFilterId, nameof(subPropertyEventFilterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubpropertyEventFilterName"/> with pattern
        /// <c>properties/{property}/subpropertyEventFilters/{sub_property_event_filter}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subPropertyEventFilterId">
        /// The <c>SubPropertyEventFilter</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SubpropertyEventFilterName"/> with pattern
        /// <c>properties/{property}/subpropertyEventFilters/{sub_property_event_filter}</c>.
        /// </returns>
        public static string Format(string propertyId, string subPropertyEventFilterId) =>
            FormatPropertySubPropertyEventFilter(propertyId, subPropertyEventFilterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubpropertyEventFilterName"/> with pattern
        /// <c>properties/{property}/subpropertyEventFilters/{sub_property_event_filter}</c>.
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subPropertyEventFilterId">
        /// The <c>SubPropertyEventFilter</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SubpropertyEventFilterName"/> with pattern
        /// <c>properties/{property}/subpropertyEventFilters/{sub_property_event_filter}</c>.
        /// </returns>
        public static string FormatPropertySubPropertyEventFilter(string propertyId, string subPropertyEventFilterId) =>
            s_propertySubPropertyEventFilter.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(subPropertyEventFilterId, nameof(subPropertyEventFilterId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SubpropertyEventFilterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/subpropertyEventFilters/{sub_property_event_filter}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="subpropertyEventFilterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubpropertyEventFilterName"/> if successful.</returns>
        public static SubpropertyEventFilterName Parse(string subpropertyEventFilterName) =>
            Parse(subpropertyEventFilterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SubpropertyEventFilterName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/subpropertyEventFilters/{sub_property_event_filter}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subpropertyEventFilterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SubpropertyEventFilterName"/> if successful.</returns>
        public static SubpropertyEventFilterName Parse(string subpropertyEventFilterName, bool allowUnparsed) =>
            TryParse(subpropertyEventFilterName, allowUnparsed, out SubpropertyEventFilterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubpropertyEventFilterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/subpropertyEventFilters/{sub_property_event_filter}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="subpropertyEventFilterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubpropertyEventFilterName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subpropertyEventFilterName, out SubpropertyEventFilterName result) =>
            TryParse(subpropertyEventFilterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubpropertyEventFilterName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>properties/{property}/subpropertyEventFilters/{sub_property_event_filter}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subpropertyEventFilterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubpropertyEventFilterName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subpropertyEventFilterName, bool allowUnparsed, out SubpropertyEventFilterName result)
        {
            gax::GaxPreconditions.CheckNotNull(subpropertyEventFilterName, nameof(subpropertyEventFilterName));
            gax::TemplatedResourceName resourceName;
            if (s_propertySubPropertyEventFilter.TryParseName(subpropertyEventFilterName, out resourceName))
            {
                result = FromPropertySubPropertyEventFilter(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(subpropertyEventFilterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SubpropertyEventFilterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string propertyId = null, string subPropertyEventFilterId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PropertyId = propertyId;
            SubPropertyEventFilterId = subPropertyEventFilterId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SubpropertyEventFilterName"/> class from the component parts of
        /// pattern <c>properties/{property}/subpropertyEventFilters/{sub_property_event_filter}</c>
        /// </summary>
        /// <param name="propertyId">The <c>Property</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subPropertyEventFilterId">
        /// The <c>SubPropertyEventFilter</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public SubpropertyEventFilterName(string propertyId, string subPropertyEventFilterId) : this(ResourceNameType.PropertySubPropertyEventFilter, propertyId: gax::GaxPreconditions.CheckNotNullOrEmpty(propertyId, nameof(propertyId)), subPropertyEventFilterId: gax::GaxPreconditions.CheckNotNullOrEmpty(subPropertyEventFilterId, nameof(subPropertyEventFilterId)))
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

        /// <summary>
        /// The <c>SubPropertyEventFilter</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string SubPropertyEventFilterId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.PropertySubPropertyEventFilter: return s_propertySubPropertyEventFilter.Expand(PropertyId, SubPropertyEventFilterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SubpropertyEventFilterName);

        /// <inheritdoc/>
        public bool Equals(SubpropertyEventFilterName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SubpropertyEventFilterName a, SubpropertyEventFilterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SubpropertyEventFilterName a, SubpropertyEventFilterName b) => !(a == b);
    }

    public partial class SubpropertyEventFilter
    {
        /// <summary>
        /// <see cref="gaav::SubpropertyEventFilterName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gaav::SubpropertyEventFilterName SubpropertyEventFilterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::SubpropertyEventFilterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
