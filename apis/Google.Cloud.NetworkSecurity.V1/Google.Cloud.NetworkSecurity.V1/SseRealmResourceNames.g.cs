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
using gcnv = Google.Cloud.NetworkSecurity.V1;
using sys = System;

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Resource name for the <c>SACRealm</c> resource.</summary>
    public sealed partial class SACRealmName : gax::IResourceName, sys::IEquatable<SACRealmName>
    {
        /// <summary>The possible contents of <see cref="SACRealmName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/sacRealms/{sac_realm}</c>.
            /// </summary>
            ProjectLocationSacRealm = 1,
        }

        private static gax::PathTemplate s_projectLocationSacRealm = new gax::PathTemplate("projects/{project}/locations/{location}/sacRealms/{sac_realm}");

        /// <summary>Creates a <see cref="SACRealmName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SACRealmName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static SACRealmName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SACRealmName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SACRealmName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sacRealms/{sac_realm}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sacRealmId">The <c>SacRealm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SACRealmName"/> constructed from the provided ids.</returns>
        public static SACRealmName FromProjectLocationSacRealm(string projectId, string locationId, string sacRealmId) =>
            new SACRealmName(ResourceNameType.ProjectLocationSacRealm, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sacRealmId: gax::GaxPreconditions.CheckNotNullOrEmpty(sacRealmId, nameof(sacRealmId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SACRealmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sacRealms/{sac_realm}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sacRealmId">The <c>SacRealm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SACRealmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sacRealms/{sac_realm}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sacRealmId) =>
            FormatProjectLocationSacRealm(projectId, locationId, sacRealmId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SACRealmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sacRealms/{sac_realm}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sacRealmId">The <c>SacRealm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SACRealmName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sacRealms/{sac_realm}</c>.
        /// </returns>
        public static string FormatProjectLocationSacRealm(string projectId, string locationId, string sacRealmId) =>
            s_projectLocationSacRealm.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sacRealmId, nameof(sacRealmId)));

        /// <summary>Parses the given resource name string into a new <see cref="SACRealmName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sacRealms/{sac_realm}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sACRealmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SACRealmName"/> if successful.</returns>
        public static SACRealmName Parse(string sACRealmName) => Parse(sACRealmName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SACRealmName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sacRealms/{sac_realm}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sACRealmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SACRealmName"/> if successful.</returns>
        public static SACRealmName Parse(string sACRealmName, bool allowUnparsed) =>
            TryParse(sACRealmName, allowUnparsed, out SACRealmName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SACRealmName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sacRealms/{sac_realm}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sACRealmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SACRealmName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sACRealmName, out SACRealmName result) => TryParse(sACRealmName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SACRealmName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sacRealms/{sac_realm}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sACRealmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SACRealmName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sACRealmName, bool allowUnparsed, out SACRealmName result)
        {
            gax::GaxPreconditions.CheckNotNull(sACRealmName, nameof(sACRealmName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSacRealm.TryParseName(sACRealmName, out resourceName))
            {
                result = FromProjectLocationSacRealm(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sACRealmName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SACRealmName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sacRealmId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SacRealmId = sacRealmId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SACRealmName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sacRealms/{sac_realm}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sacRealmId">The <c>SacRealm</c> ID. Must not be <c>null</c> or empty.</param>
        public SACRealmName(string projectId, string locationId, string sacRealmId) : this(ResourceNameType.ProjectLocationSacRealm, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sacRealmId: gax::GaxPreconditions.CheckNotNullOrEmpty(sacRealmId, nameof(sacRealmId)))
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
        /// The <c>SacRealm</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SacRealmId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSacRealm: return s_projectLocationSacRealm.Expand(ProjectId, LocationId, SacRealmId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SACRealmName);

        /// <inheritdoc/>
        public bool Equals(SACRealmName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SACRealmName a, SACRealmName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SACRealmName a, SACRealmName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SACAttachment</c> resource.</summary>
    public sealed partial class SACAttachmentName : gax::IResourceName, sys::IEquatable<SACAttachmentName>
    {
        /// <summary>The possible contents of <see cref="SACAttachmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/sacAttachments/{sac_attachment}</c>
            /// .
            /// </summary>
            ProjectLocationSacAttachment = 1,
        }

        private static gax::PathTemplate s_projectLocationSacAttachment = new gax::PathTemplate("projects/{project}/locations/{location}/sacAttachments/{sac_attachment}");

        /// <summary>Creates a <see cref="SACAttachmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SACAttachmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SACAttachmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SACAttachmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SACAttachmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sacAttachments/{sac_attachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sacAttachmentId">The <c>SacAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SACAttachmentName"/> constructed from the provided ids.</returns>
        public static SACAttachmentName FromProjectLocationSacAttachment(string projectId, string locationId, string sacAttachmentId) =>
            new SACAttachmentName(ResourceNameType.ProjectLocationSacAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sacAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(sacAttachmentId, nameof(sacAttachmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SACAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sacAttachments/{sac_attachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sacAttachmentId">The <c>SacAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SACAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sacAttachments/{sac_attachment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sacAttachmentId) =>
            FormatProjectLocationSacAttachment(projectId, locationId, sacAttachmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SACAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sacAttachments/{sac_attachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sacAttachmentId">The <c>SacAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SACAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sacAttachments/{sac_attachment}</c>.
        /// </returns>
        public static string FormatProjectLocationSacAttachment(string projectId, string locationId, string sacAttachmentId) =>
            s_projectLocationSacAttachment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sacAttachmentId, nameof(sacAttachmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SACAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sacAttachments/{sac_attachment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sACAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SACAttachmentName"/> if successful.</returns>
        public static SACAttachmentName Parse(string sACAttachmentName) => Parse(sACAttachmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SACAttachmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sacAttachments/{sac_attachment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sACAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SACAttachmentName"/> if successful.</returns>
        public static SACAttachmentName Parse(string sACAttachmentName, bool allowUnparsed) =>
            TryParse(sACAttachmentName, allowUnparsed, out SACAttachmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SACAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sacAttachments/{sac_attachment}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sACAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SACAttachmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sACAttachmentName, out SACAttachmentName result) =>
            TryParse(sACAttachmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SACAttachmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sacAttachments/{sac_attachment}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sACAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SACAttachmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sACAttachmentName, bool allowUnparsed, out SACAttachmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(sACAttachmentName, nameof(sACAttachmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSacAttachment.TryParseName(sACAttachmentName, out resourceName))
            {
                result = FromProjectLocationSacAttachment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sACAttachmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SACAttachmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sacAttachmentId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SacAttachmentId = sacAttachmentId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SACAttachmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sacAttachments/{sac_attachment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sacAttachmentId">The <c>SacAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        public SACAttachmentName(string projectId, string locationId, string sacAttachmentId) : this(ResourceNameType.ProjectLocationSacAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sacAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(sacAttachmentId, nameof(sacAttachmentId)))
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
        /// The <c>SacAttachment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SacAttachmentId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSacAttachment: return s_projectLocationSacAttachment.Expand(ProjectId, LocationId, SacAttachmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SACAttachmentName);

        /// <inheritdoc/>
        public bool Equals(SACAttachmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SACAttachmentName a, SACAttachmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SACAttachmentName a, SACAttachmentName b) => !(a == b);
    }

    public partial class SACRealm
    {
        /// <summary>
        /// <see cref="gcnv::SACRealmName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::SACRealmName SACRealmName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::SACRealmName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSACRealmsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSACRealmRequest
    {
        /// <summary>
        /// <see cref="gcnv::SACRealmName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::SACRealmName SACRealmName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::SACRealmName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSACRealmRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSACRealmRequest
    {
        /// <summary>
        /// <see cref="gcnv::SACRealmName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::SACRealmName SACRealmName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::SACRealmName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SACAttachment
    {
        /// <summary>
        /// <see cref="gcnv::SACAttachmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::SACAttachmentName SACAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::SACAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSACAttachmentsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSACAttachmentRequest
    {
        /// <summary>
        /// <see cref="gcnv::SACAttachmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::SACAttachmentName SACAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::SACAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSACAttachmentRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSACAttachmentRequest
    {
        /// <summary>
        /// <see cref="gcnv::SACAttachmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::SACAttachmentName SACAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::SACAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
