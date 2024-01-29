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
using gax = Google.Api.Gax;
using gcsv = Google.Cloud.SecurityCenter.V1;
using sys = System;

namespace Google.Cloud.SecurityCenter.V1
{
    /// <summary>Resource name for the <c>OrganizationSettings</c> resource.</summary>
    public sealed partial class OrganizationSettingsName : gax::IResourceName, sys::IEquatable<OrganizationSettingsName>
    {
        /// <summary>The possible contents of <see cref="OrganizationSettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/organizationSettings</c>.
            /// </summary>
            Organization = 1,
        }

        private static gax::PathTemplate s_organization = new gax::PathTemplate("organizations/{organization}/organizationSettings");

        /// <summary>Creates a <see cref="OrganizationSettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationSettingsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrganizationSettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrganizationSettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrganizationSettingsName"/> with the pattern
        /// <c>organizations/{organization}/organizationSettings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationSettingsName"/> constructed from the provided ids.
        /// </returns>
        public static OrganizationSettingsName FromOrganization(string organizationId) =>
            new OrganizationSettingsName(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationSettingsName"/> with pattern
        /// <c>organizations/{organization}/organizationSettings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationSettingsName"/> with pattern
        /// <c>organizations/{organization}/organizationSettings</c>.
        /// </returns>
        public static string Format(string organizationId) => FormatOrganization(organizationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationSettingsName"/> with pattern
        /// <c>organizations/{organization}/organizationSettings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationSettingsName"/> with pattern
        /// <c>organizations/{organization}/organizationSettings</c>.
        /// </returns>
        public static string FormatOrganization(string organizationId) =>
            s_organization.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/organizationSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationSettingsName"/> if successful.</returns>
        public static OrganizationSettingsName Parse(string organizationSettingsName) =>
            Parse(organizationSettingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationSettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/organizationSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrganizationSettingsName"/> if successful.</returns>
        public static OrganizationSettingsName Parse(string organizationSettingsName, bool allowUnparsed) =>
            TryParse(organizationSettingsName, allowUnparsed, out OrganizationSettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationSettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/organizationSettings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationSettingsName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationSettingsName, out OrganizationSettingsName result) =>
            TryParse(organizationSettingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationSettingsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/organizationSettings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationSettingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationSettingsName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationSettingsName, bool allowUnparsed, out OrganizationSettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationSettingsName, nameof(organizationSettingsName));
            gax::TemplatedResourceName resourceName;
            if (s_organization.TryParseName(organizationSettingsName, out resourceName))
            {
                result = FromOrganization(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(organizationSettingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrganizationSettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrganizationSettingsName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/organizationSettings</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        public OrganizationSettingsName(string organizationId) : this(ResourceNameType.Organization, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)))
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
        /// The <c>Organization</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Organization: return s_organization.Expand(OrganizationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrganizationSettingsName);

        /// <inheritdoc/>
        public bool Equals(OrganizationSettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrganizationSettingsName a, OrganizationSettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrganizationSettingsName a, OrganizationSettingsName b) => !(a == b);
    }

    public partial class OrganizationSettings
    {
        /// <summary>
        /// <see cref="gcsv::OrganizationSettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::OrganizationSettingsName OrganizationSettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::OrganizationSettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
