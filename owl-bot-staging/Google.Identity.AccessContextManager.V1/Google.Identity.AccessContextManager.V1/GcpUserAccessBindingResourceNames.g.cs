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
using gax = Google.Api.Gax;
using giav = Google.Identity.AccessContextManager.V1;
using sys = System;

namespace Google.Identity.AccessContextManager.V1
{
    /// <summary>Resource name for the <c>GcpUserAccessBinding</c> resource.</summary>
    public sealed partial class GcpUserAccessBindingName : gax::IResourceName, sys::IEquatable<GcpUserAccessBindingName>
    {
        /// <summary>The possible contents of <see cref="GcpUserAccessBindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}</c>.
            /// </summary>
            OrganizationGcpUserAccessBinding = 1,
        }

        private static gax::PathTemplate s_organizationGcpUserAccessBinding = new gax::PathTemplate("organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}");

        /// <summary>Creates a <see cref="GcpUserAccessBindingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GcpUserAccessBindingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GcpUserAccessBindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GcpUserAccessBindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GcpUserAccessBindingName"/> with the pattern
        /// <c>organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gcpUserAccessBindingId">
        /// The <c>GcpUserAccessBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="GcpUserAccessBindingName"/> constructed from the provided ids.
        /// </returns>
        public static GcpUserAccessBindingName FromOrganizationGcpUserAccessBinding(string organizationId, string gcpUserAccessBindingId) =>
            new GcpUserAccessBindingName(ResourceNameType.OrganizationGcpUserAccessBinding, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gcpUserAccessBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(gcpUserAccessBindingId, nameof(gcpUserAccessBindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GcpUserAccessBindingName"/> with pattern
        /// <c>organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gcpUserAccessBindingId">
        /// The <c>GcpUserAccessBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GcpUserAccessBindingName"/> with pattern
        /// <c>organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}</c>.
        /// </returns>
        public static string Format(string organizationId, string gcpUserAccessBindingId) =>
            FormatOrganizationGcpUserAccessBinding(organizationId, gcpUserAccessBindingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GcpUserAccessBindingName"/> with pattern
        /// <c>organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gcpUserAccessBindingId">
        /// The <c>GcpUserAccessBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GcpUserAccessBindingName"/> with pattern
        /// <c>organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}</c>.
        /// </returns>
        public static string FormatOrganizationGcpUserAccessBinding(string organizationId, string gcpUserAccessBindingId) =>
            s_organizationGcpUserAccessBinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(gcpUserAccessBindingId, nameof(gcpUserAccessBindingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GcpUserAccessBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gcpUserAccessBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GcpUserAccessBindingName"/> if successful.</returns>
        public static GcpUserAccessBindingName Parse(string gcpUserAccessBindingName) =>
            Parse(gcpUserAccessBindingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GcpUserAccessBindingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gcpUserAccessBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GcpUserAccessBindingName"/> if successful.</returns>
        public static GcpUserAccessBindingName Parse(string gcpUserAccessBindingName, bool allowUnparsed) =>
            TryParse(gcpUserAccessBindingName, allowUnparsed, out GcpUserAccessBindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GcpUserAccessBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gcpUserAccessBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GcpUserAccessBindingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gcpUserAccessBindingName, out GcpUserAccessBindingName result) =>
            TryParse(gcpUserAccessBindingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GcpUserAccessBindingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gcpUserAccessBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GcpUserAccessBindingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gcpUserAccessBindingName, bool allowUnparsed, out GcpUserAccessBindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(gcpUserAccessBindingName, nameof(gcpUserAccessBindingName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationGcpUserAccessBinding.TryParseName(gcpUserAccessBindingName, out resourceName))
            {
                result = FromOrganizationGcpUserAccessBinding(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gcpUserAccessBindingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GcpUserAccessBindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string gcpUserAccessBindingId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GcpUserAccessBindingId = gcpUserAccessBindingId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GcpUserAccessBindingName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/gcpUserAccessBindings/{gcp_user_access_binding}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gcpUserAccessBindingId">
        /// The <c>GcpUserAccessBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public GcpUserAccessBindingName(string organizationId, string gcpUserAccessBindingId) : this(ResourceNameType.OrganizationGcpUserAccessBinding, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gcpUserAccessBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(gcpUserAccessBindingId, nameof(gcpUserAccessBindingId)))
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
        /// The <c>GcpUserAccessBinding</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string GcpUserAccessBindingId { get; }

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
                case ResourceNameType.OrganizationGcpUserAccessBinding: return s_organizationGcpUserAccessBinding.Expand(OrganizationId, GcpUserAccessBindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GcpUserAccessBindingName);

        /// <inheritdoc/>
        public bool Equals(GcpUserAccessBindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GcpUserAccessBindingName a, GcpUserAccessBindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GcpUserAccessBindingName a, GcpUserAccessBindingName b) => !(a == b);
    }

    public partial class GcpUserAccessBinding
    {
        /// <summary>
        /// <see cref="giav::GcpUserAccessBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public giav::GcpUserAccessBindingName GcpUserAccessBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : giav::GcpUserAccessBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AccessLevelName"/>-typed view over the <see cref="AccessLevels"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AccessLevelName> AccessLevelsAsAccessLevelNames
        {
            get => new gax::ResourceNameList<AccessLevelName>(AccessLevels, s => string.IsNullOrEmpty(s) ? null : AccessLevelName.Parse(s, allowUnparsed: true));
        }
    }
}
