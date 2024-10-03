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
using gaav = Google.Ads.AdManager.V1;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Resource name for the <c>CustomField</c> resource.</summary>
    public sealed partial class CustomFieldName : gax::IResourceName, sys::IEquatable<CustomFieldName>
    {
        /// <summary>The possible contents of <see cref="CustomFieldName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>networks/{network_code}/customFields/{custom_field}</c>.
            /// </summary>
            NetworkCodeCustomField = 1,
        }

        private static gax::PathTemplate s_networkCodeCustomField = new gax::PathTemplate("networks/{network_code}/customFields/{custom_field}");

        /// <summary>Creates a <see cref="CustomFieldName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomFieldName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomFieldName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomFieldName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomFieldName"/> with the pattern
        /// <c>networks/{network_code}/customFields/{custom_field}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customFieldId">The <c>CustomField</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomFieldName"/> constructed from the provided ids.</returns>
        public static CustomFieldName FromNetworkCodeCustomField(string networkCodeId, string customFieldId) =>
            new CustomFieldName(ResourceNameType.NetworkCodeCustomField, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), customFieldId: gax::GaxPreconditions.CheckNotNullOrEmpty(customFieldId, nameof(customFieldId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomFieldName"/> with pattern
        /// <c>networks/{network_code}/customFields/{custom_field}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customFieldId">The <c>CustomField</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomFieldName"/> with pattern
        /// <c>networks/{network_code}/customFields/{custom_field}</c>.
        /// </returns>
        public static string Format(string networkCodeId, string customFieldId) =>
            FormatNetworkCodeCustomField(networkCodeId, customFieldId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomFieldName"/> with pattern
        /// <c>networks/{network_code}/customFields/{custom_field}</c>.
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customFieldId">The <c>CustomField</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomFieldName"/> with pattern
        /// <c>networks/{network_code}/customFields/{custom_field}</c>.
        /// </returns>
        public static string FormatNetworkCodeCustomField(string networkCodeId, string customFieldId) =>
            s_networkCodeCustomField.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customFieldId, nameof(customFieldId)));

        /// <summary>Parses the given resource name string into a new <see cref="CustomFieldName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/customFields/{custom_field}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomFieldName"/> if successful.</returns>
        public static CustomFieldName Parse(string customFieldName) => Parse(customFieldName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomFieldName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/customFields/{custom_field}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomFieldName"/> if successful.</returns>
        public static CustomFieldName Parse(string customFieldName, bool allowUnparsed) =>
            TryParse(customFieldName, allowUnparsed, out CustomFieldName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomFieldName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/customFields/{custom_field}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomFieldName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customFieldName, out CustomFieldName result) =>
            TryParse(customFieldName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomFieldName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>networks/{network_code}/customFields/{custom_field}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomFieldName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customFieldName, bool allowUnparsed, out CustomFieldName result)
        {
            gax::GaxPreconditions.CheckNotNull(customFieldName, nameof(customFieldName));
            gax::TemplatedResourceName resourceName;
            if (s_networkCodeCustomField.TryParseName(customFieldName, out resourceName))
            {
                result = FromNetworkCodeCustomField(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customFieldName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomFieldName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customFieldId = null, string networkCodeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomFieldId = customFieldId;
            NetworkCodeId = networkCodeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomFieldName"/> class from the component parts of pattern
        /// <c>networks/{network_code}/customFields/{custom_field}</c>
        /// </summary>
        /// <param name="networkCodeId">The <c>NetworkCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customFieldId">The <c>CustomField</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomFieldName(string networkCodeId, string customFieldId) : this(ResourceNameType.NetworkCodeCustomField, networkCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkCodeId, nameof(networkCodeId)), customFieldId: gax::GaxPreconditions.CheckNotNullOrEmpty(customFieldId, nameof(customFieldId)))
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
        /// The <c>CustomField</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomFieldId { get; }

        /// <summary>
        /// The <c>NetworkCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkCodeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.NetworkCodeCustomField: return s_networkCodeCustomField.Expand(NetworkCodeId, CustomFieldId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomFieldName);

        /// <inheritdoc/>
        public bool Equals(CustomFieldName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomFieldName a, CustomFieldName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomFieldName a, CustomFieldName b) => !(a == b);
    }

    public partial class CustomField
    {
        /// <summary>
        /// <see cref="gaav::CustomFieldName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gaav::CustomFieldName CustomFieldName
        {
            get => string.IsNullOrEmpty(Name) ? null : gaav::CustomFieldName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
