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
using gcov = Google.Cloud.Observability.V1;
using sys = System;

namespace Google.Cloud.Observability.V1
{
    /// <summary>Resource name for the <c>Settings</c> resource.</summary>
    public sealed partial class SettingsName : gax::IResourceName, sys::IEquatable<SettingsName>
    {
        /// <summary>The possible contents of <see cref="SettingsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/locations/{location}/settings</c>.</summary>
            ProjectLocation = 1,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}/settings</c>.
            /// </summary>
            OrganizationLocation = 2,

            /// <summary>A resource name with pattern <c>folders/{folder}/locations/{location}/settings</c>.</summary>
            FolderLocation = 3,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}/settings");

        private static gax::PathTemplate s_organizationLocation = new gax::PathTemplate("organizations/{organization}/locations/{location}/settings");

        private static gax::PathTemplate s_folderLocation = new gax::PathTemplate("folders/{folder}/locations/{location}/settings");

        /// <summary>Creates a <see cref="SettingsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SettingsName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static SettingsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SettingsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern <c>projects/{project}/locations/{location}/settings</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromProjectLocation(string projectId, string locationId) =>
            new SettingsName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromOrganizationLocation(string organizationId, string locationId) =>
            new SettingsName(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Creates a <see cref="SettingsName"/> with the pattern <c>folders/{folder}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SettingsName"/> constructed from the provided ids.</returns>
        public static SettingsName FromFolderLocation(string folderId, string locationId) =>
            new SettingsName(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>projects/{project}/locations/{location}/settings</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/settings</c>.
        /// </returns>
        public static string FormatOrganizationLocation(string organizationId, string locationId) =>
            s_organizationLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SettingsName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/settings</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SettingsName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/settings</c>.
        /// </returns>
        public static string FormatFolderLocation(string folderId, string locationId) =>
            s_folderLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>Parses the given resource name string into a new <see cref="SettingsName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// <item><description><c>organizations/{organization}/locations/{location}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName) => Parse(settingsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SettingsName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// <item><description><c>organizations/{organization}/locations/{location}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SettingsName"/> if successful.</returns>
        public static SettingsName Parse(string settingsName, bool allowUnparsed) =>
            TryParse(settingsName, allowUnparsed, out SettingsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// <item><description><c>organizations/{organization}/locations/{location}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/settings</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, out SettingsName result) => TryParse(settingsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SettingsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/settings</c></description></item>
        /// <item><description><c>organizations/{organization}/locations/{location}/settings</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/settings</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="settingsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SettingsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string settingsName, bool allowUnparsed, out SettingsName result)
        {
            gax::GaxPreconditions.CheckNotNull(settingsName, nameof(settingsName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(settingsName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationLocation.TryParseName(settingsName, out resourceName))
            {
                result = FromOrganizationLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_folderLocation.TryParseName(settingsName, out resourceName))
            {
                result = FromFolderLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(settingsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SettingsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SettingsName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/settings</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public SettingsName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                case ResourceNameType.OrganizationLocation: return s_organizationLocation.Expand(OrganizationId, LocationId);
                case ResourceNameType.FolderLocation: return s_folderLocation.Expand(FolderId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SettingsName);

        /// <inheritdoc/>
        public bool Equals(SettingsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SettingsName a, SettingsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SettingsName a, SettingsName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Bucket</c> resource.</summary>
    public sealed partial class BucketName : gax::IResourceName, sys::IEquatable<BucketName>
    {
        /// <summary>The possible contents of <see cref="BucketName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
            /// </summary>
            ProjectLocationBucket = 1,
        }

        private static gax::PathTemplate s_projectLocationBucket = new gax::PathTemplate("projects/{project}/locations/{location}/buckets/{bucket}");

        /// <summary>Creates a <see cref="BucketName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BucketName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BucketName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BucketName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BucketName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BucketName"/> constructed from the provided ids.</returns>
        public static BucketName FromProjectLocationBucket(string projectId, string locationId, string bucketId) =>
            new BucketName(ResourceNameType.ProjectLocationBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string bucketId) =>
            FormatProjectLocationBucket(projectId, locationId, bucketId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>.
        /// </returns>
        public static string FormatProjectLocationBucket(string projectId, string locationId, string bucketId) =>
            s_projectLocationBucket.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>Parses the given resource name string into a new <see cref="BucketName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/buckets/{bucket}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BucketName"/> if successful.</returns>
        public static BucketName Parse(string bucketName) => Parse(bucketName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BucketName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/buckets/{bucket}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BucketName"/> if successful.</returns>
        public static BucketName Parse(string bucketName, bool allowUnparsed) =>
            TryParse(bucketName, allowUnparsed, out BucketName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BucketName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/buckets/{bucket}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BucketName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bucketName, out BucketName result) => TryParse(bucketName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BucketName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/buckets/{bucket}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BucketName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bucketName, bool allowUnparsed, out BucketName result)
        {
            gax::GaxPreconditions.CheckNotNull(bucketName, nameof(bucketName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBucket.TryParseName(bucketName, out resourceName))
            {
                result = FromProjectLocationBucket(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(bucketName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BucketName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bucketId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BucketId = bucketId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BucketName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        public BucketName(string projectId, string locationId, string bucketId) : this(ResourceNameType.ProjectLocationBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)))
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
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationBucket: return s_projectLocationBucket.Expand(ProjectId, LocationId, BucketId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BucketName);

        /// <inheritdoc/>
        public bool Equals(BucketName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BucketName a, BucketName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BucketName a, BucketName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Dataset</c> resource.</summary>
    public sealed partial class DatasetName : gax::IResourceName, sys::IEquatable<DatasetName>
    {
        /// <summary>The possible contents of <see cref="DatasetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}</c>.
            /// </summary>
            ProjectLocationBucketDataset = 1,
        }

        private static gax::PathTemplate s_projectLocationBucketDataset = new gax::PathTemplate("projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}");

        /// <summary>Creates a <see cref="DatasetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatasetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatasetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatasetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatasetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatasetName"/> constructed from the provided ids.</returns>
        public static DatasetName FromProjectLocationBucketDataset(string projectId, string locationId, string bucketId, string datasetId) =>
            new DatasetName(ResourceNameType.ProjectLocationBucketDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string bucketId, string datasetId) =>
            FormatProjectLocationBucketDataset(projectId, locationId, bucketId, datasetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}</c>.
        /// </returns>
        public static string FormatProjectLocationBucketDataset(string projectId, string locationId, string bucketId, string datasetId) =>
            s_projectLocationBucketDataset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)));

        /// <summary>Parses the given resource name string into a new <see cref="DatasetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName) => Parse(datasetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatasetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatasetName"/> if successful.</returns>
        public static DatasetName Parse(string datasetName, bool allowUnparsed) =>
            TryParse(datasetName, allowUnparsed, out DatasetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, out DatasetName result) => TryParse(datasetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatasetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="datasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string datasetName, bool allowUnparsed, out DatasetName result)
        {
            gax::GaxPreconditions.CheckNotNull(datasetName, nameof(datasetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBucketDataset.TryParseName(datasetName, out resourceName))
            {
                result = FromProjectLocationBucketDataset(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(datasetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatasetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bucketId = null, string datasetId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BucketId = bucketId;
            DatasetId = datasetId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatasetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        public DatasetName(string projectId, string locationId, string bucketId, string datasetId) : this(ResourceNameType.ProjectLocationBucketDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)))
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
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

        /// <summary>
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationBucketDataset: return s_projectLocationBucketDataset.Expand(ProjectId, LocationId, BucketId, DatasetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatasetName);

        /// <inheritdoc/>
        public bool Equals(DatasetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatasetName a, DatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatasetName a, DatasetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>View</c> resource.</summary>
    public sealed partial class ViewName : gax::IResourceName, sys::IEquatable<ViewName>
    {
        /// <summary>The possible contents of <see cref="ViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}</c>.
            /// </summary>
            ProjectLocationBucketDatasetView = 1,
        }

        private static gax::PathTemplate s_projectLocationBucketDatasetView = new gax::PathTemplate("projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}");

        /// <summary>Creates a <see cref="ViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ViewName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ViewName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ViewName"/> constructed from the provided ids.</returns>
        public static ViewName FromProjectLocationBucketDatasetView(string projectId, string locationId, string bucketId, string datasetId, string viewId) =>
            new ViewName(ResourceNameType.ProjectLocationBucketDatasetView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), viewId: gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string bucketId, string datasetId, string viewId) =>
            FormatProjectLocationBucketDatasetView(projectId, locationId, bucketId, datasetId, viewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ViewName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}</c>.
        /// </returns>
        public static string FormatProjectLocationBucketDatasetView(string projectId, string locationId, string bucketId, string datasetId, string viewId) =>
            s_projectLocationBucketDatasetView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)));

        /// <summary>Parses the given resource name string into a new <see cref="ViewName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="viewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ViewName"/> if successful.</returns>
        public static ViewName Parse(string viewName) => Parse(viewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ViewName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="viewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ViewName"/> if successful.</returns>
        public static ViewName Parse(string viewName, bool allowUnparsed) =>
            TryParse(viewName, allowUnparsed, out ViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="ViewName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="viewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string viewName, out ViewName result) => TryParse(viewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="viewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string viewName, bool allowUnparsed, out ViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(viewName, nameof(viewName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBucketDatasetView.TryParseName(viewName, out resourceName))
            {
                result = FromProjectLocationBucketDatasetView(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(viewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bucketId = null, string datasetId = null, string locationId = null, string projectId = null, string viewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BucketId = bucketId;
            DatasetId = datasetId;
            LocationId = locationId;
            ProjectId = projectId;
            ViewId = viewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ViewName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/views/{view}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="viewId">The <c>View</c> ID. Must not be <c>null</c> or empty.</param>
        public ViewName(string projectId, string locationId, string bucketId, string datasetId, string viewId) : this(ResourceNameType.ProjectLocationBucketDatasetView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), viewId: gax::GaxPreconditions.CheckNotNullOrEmpty(viewId, nameof(viewId)))
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
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

        /// <summary>
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>View</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationBucketDatasetView: return s_projectLocationBucketDatasetView.Expand(ProjectId, LocationId, BucketId, DatasetId, ViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ViewName);

        /// <inheritdoc/>
        public bool Equals(ViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ViewName a, ViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ViewName a, ViewName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Link</c> resource.</summary>
    public sealed partial class LinkName : gax::IResourceName, sys::IEquatable<LinkName>
    {
        /// <summary>The possible contents of <see cref="LinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}</c>.
            /// </summary>
            ProjectLocationBucketDatasetLink = 1,
        }

        private static gax::PathTemplate s_projectLocationBucketDatasetLink = new gax::PathTemplate("projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}");

        /// <summary>Creates a <see cref="LinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LinkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LinkName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LinkName"/> constructed from the provided ids.</returns>
        public static LinkName FromProjectLocationBucketDatasetLink(string projectId, string locationId, string bucketId, string datasetId, string linkId) =>
            new LinkName(ResourceNameType.ProjectLocationBucketDatasetLink, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), linkId: gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string bucketId, string datasetId, string linkId) =>
            FormatProjectLocationBucketDatasetLink(projectId, locationId, bucketId, datasetId, linkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}</c>.
        /// </returns>
        public static string FormatProjectLocationBucketDatasetLink(string projectId, string locationId, string bucketId, string datasetId, string linkId) =>
            s_projectLocationBucketDatasetLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)));

        /// <summary>Parses the given resource name string into a new <see cref="LinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="linkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LinkName"/> if successful.</returns>
        public static LinkName Parse(string linkName) => Parse(linkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LinkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="linkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LinkName"/> if successful.</returns>
        public static LinkName Parse(string linkName, bool allowUnparsed) =>
            TryParse(linkName, allowUnparsed, out LinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="LinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="linkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string linkName, out LinkName result) => TryParse(linkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="linkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string linkName, bool allowUnparsed, out LinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(linkName, nameof(linkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBucketDatasetLink.TryParseName(linkName, out resourceName))
            {
                result = FromProjectLocationBucketDatasetLink(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(linkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bucketId = null, string datasetId = null, string linkId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BucketId = bucketId;
            DatasetId = datasetId;
            LinkId = linkId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LinkName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/buckets/{bucket}/datasets/{dataset}/links/{link}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="linkId">The <c>Link</c> ID. Must not be <c>null</c> or empty.</param>
        public LinkName(string projectId, string locationId, string bucketId, string datasetId, string linkId) : this(ResourceNameType.ProjectLocationBucketDatasetLink, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), linkId: gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)))
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
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

        /// <summary>
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>Link</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LinkId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationBucketDatasetLink: return s_projectLocationBucketDatasetLink.Expand(ProjectId, LocationId, BucketId, DatasetId, LinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LinkName);

        /// <inheritdoc/>
        public bool Equals(LinkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LinkName a, LinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LinkName a, LinkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Scope</c> resource.</summary>
    public sealed partial class ScopeName : gax::IResourceName, sys::IEquatable<ScopeName>
    {
        /// <summary>The possible contents of <see cref="ScopeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/scopes/{scope}</c>.
            /// </summary>
            ProjectLocationScope = 1,
        }

        private static gax::PathTemplate s_projectLocationScope = new gax::PathTemplate("projects/{project}/locations/{location}/scopes/{scope}");

        /// <summary>Creates a <see cref="ScopeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ScopeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ScopeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ScopeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ScopeName"/> with the pattern <c>projects/{project}/locations/{location}/scopes/{scope}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ScopeName"/> constructed from the provided ids.</returns>
        public static ScopeName FromProjectLocationScope(string projectId, string locationId, string scopeId) =>
            new ScopeName(ResourceNameType.ProjectLocationScope, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), scopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string scopeId) =>
            FormatProjectLocationScope(projectId, locationId, scopeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}</c>.
        /// </returns>
        public static string FormatProjectLocationScope(string projectId, string locationId, string scopeId) =>
            s_projectLocationScope.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)));

        /// <summary>Parses the given resource name string into a new <see cref="ScopeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/scopes/{scope}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="scopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ScopeName"/> if successful.</returns>
        public static ScopeName Parse(string scopeName) => Parse(scopeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ScopeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/scopes/{scope}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ScopeName"/> if successful.</returns>
        public static ScopeName Parse(string scopeName, bool allowUnparsed) =>
            TryParse(scopeName, allowUnparsed, out ScopeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScopeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/scopes/{scope}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="scopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScopeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scopeName, out ScopeName result) => TryParse(scopeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScopeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/scopes/{scope}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScopeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scopeName, bool allowUnparsed, out ScopeName result)
        {
            gax::GaxPreconditions.CheckNotNull(scopeName, nameof(scopeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationScope.TryParseName(scopeName, out resourceName))
            {
                result = FromProjectLocationScope(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(scopeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ScopeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string scopeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ScopeId = scopeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ScopeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/scopes/{scope}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scopeId">The <c>Scope</c> ID. Must not be <c>null</c> or empty.</param>
        public ScopeName(string projectId, string locationId, string scopeId) : this(ResourceNameType.ProjectLocationScope, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), scopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(scopeId, nameof(scopeId)))
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
        /// The <c>Scope</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ScopeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationScope: return s_projectLocationScope.Expand(ProjectId, LocationId, ScopeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ScopeName);

        /// <inheritdoc/>
        public bool Equals(ScopeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ScopeName a, ScopeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ScopeName a, ScopeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>TraceScope</c> resource.</summary>
    public sealed partial class TraceScopeName : gax::IResourceName, sys::IEquatable<TraceScopeName>
    {
        /// <summary>The possible contents of <see cref="TraceScopeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/traceScopes/{trace_scope}</c>.
            /// </summary>
            ProjectLocationTraceScope = 1,
        }

        private static gax::PathTemplate s_projectLocationTraceScope = new gax::PathTemplate("projects/{project}/locations/{location}/traceScopes/{trace_scope}");

        /// <summary>Creates a <see cref="TraceScopeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TraceScopeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TraceScopeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TraceScopeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TraceScopeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/traceScopes/{trace_scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="traceScopeId">The <c>TraceScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TraceScopeName"/> constructed from the provided ids.</returns>
        public static TraceScopeName FromProjectLocationTraceScope(string projectId, string locationId, string traceScopeId) =>
            new TraceScopeName(ResourceNameType.ProjectLocationTraceScope, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), traceScopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(traceScopeId, nameof(traceScopeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TraceScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/traceScopes/{trace_scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="traceScopeId">The <c>TraceScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TraceScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/traceScopes/{trace_scope}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string traceScopeId) =>
            FormatProjectLocationTraceScope(projectId, locationId, traceScopeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TraceScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/traceScopes/{trace_scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="traceScopeId">The <c>TraceScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TraceScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/traceScopes/{trace_scope}</c>.
        /// </returns>
        public static string FormatProjectLocationTraceScope(string projectId, string locationId, string traceScopeId) =>
            s_projectLocationTraceScope.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(traceScopeId, nameof(traceScopeId)));

        /// <summary>Parses the given resource name string into a new <see cref="TraceScopeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/traceScopes/{trace_scope}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="traceScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TraceScopeName"/> if successful.</returns>
        public static TraceScopeName Parse(string traceScopeName) => Parse(traceScopeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TraceScopeName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/traceScopes/{trace_scope}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="traceScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TraceScopeName"/> if successful.</returns>
        public static TraceScopeName Parse(string traceScopeName, bool allowUnparsed) =>
            TryParse(traceScopeName, allowUnparsed, out TraceScopeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TraceScopeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/traceScopes/{trace_scope}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="traceScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TraceScopeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string traceScopeName, out TraceScopeName result) =>
            TryParse(traceScopeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TraceScopeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/traceScopes/{trace_scope}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="traceScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TraceScopeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string traceScopeName, bool allowUnparsed, out TraceScopeName result)
        {
            gax::GaxPreconditions.CheckNotNull(traceScopeName, nameof(traceScopeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTraceScope.TryParseName(traceScopeName, out resourceName))
            {
                result = FromProjectLocationTraceScope(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(traceScopeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TraceScopeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string traceScopeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TraceScopeId = traceScopeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TraceScopeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/traceScopes/{trace_scope}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="traceScopeId">The <c>TraceScope</c> ID. Must not be <c>null</c> or empty.</param>
        public TraceScopeName(string projectId, string locationId, string traceScopeId) : this(ResourceNameType.ProjectLocationTraceScope, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), traceScopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(traceScopeId, nameof(traceScopeId)))
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
        /// The <c>TraceScope</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TraceScopeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTraceScope: return s_projectLocationTraceScope.Expand(ProjectId, LocationId, TraceScopeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TraceScopeName);

        /// <inheritdoc/>
        public bool Equals(TraceScopeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TraceScopeName a, TraceScopeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TraceScopeName a, TraceScopeName b) => !(a == b);
    }

    public partial class Settings
    {
        /// <summary>
        /// <see cref="gcov::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Bucket
    {
        /// <summary>
        /// <see cref="gcov::BucketName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::BucketName BucketName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::BucketName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateBucketRequest
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

    public partial class GetBucketRequest
    {
        /// <summary>
        /// <see cref="gcov::BucketName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::BucketName BucketName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::BucketName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBucketsRequest
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

    public partial class Dataset
    {
        /// <summary>
        /// <see cref="gcov::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDatasetRequest
    {
        /// <summary>
        /// <see cref="gcov::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDatasetsRequest
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BucketName ParentAsBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class View
    {
        /// <summary>
        /// <see cref="gcov::ViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::ViewName ViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::ViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetViewRequest
    {
        /// <summary>
        /// <see cref="gcov::ViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::ViewName ViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::ViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListViewsRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatasetName ParentAsDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class Link
    {
        /// <summary>
        /// <see cref="gcov::LinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::LinkName LinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::LinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateLinkRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatasetName ParentAsDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetLinkRequest
    {
        /// <summary>
        /// <see cref="gcov::LinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::LinkName LinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::LinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLinksRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatasetName ParentAsDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteLinkRequest
    {
        /// <summary>
        /// <see cref="gcov::LinkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::LinkName LinkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::LinkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Scope
    {
        /// <summary>
        /// <see cref="gcov::ScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::ScopeName ScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::ScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="LogScope"/> resource name property.
        /// </summary>
        public gax::IResourceName LogScopeAsResourceName
        {
            get => string.IsNullOrEmpty(LogScope) ? null : gax::UnparsedResourceName.Parse(LogScope);
            set => LogScope = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="TraceScope"/> resource name property.
        /// </summary>
        public gax::IResourceName TraceScopeAsResourceName
        {
            get => string.IsNullOrEmpty(TraceScope) ? null : gax::UnparsedResourceName.Parse(TraceScope);
            set => TraceScope = value?.ToString() ?? "";
        }
    }

    public partial class GetScopeRequest
    {
        /// <summary>
        /// <see cref="gcov::ScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::ScopeName ScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::ScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TraceScope
    {
        /// <summary>
        /// <see cref="gcov::TraceScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::TraceScopeName TraceScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::TraceScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="ResourceNames"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<gax::IResourceName> ResourceNamesAsResourceNames
        {
            get => new gax::ResourceNameList<gax::IResourceName>(ResourceNames, s => string.IsNullOrEmpty(s) ? null : gax::UnparsedResourceName.Parse(s));
        }
    }

    public partial class CreateTraceScopeRequest
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

    public partial class GetTraceScopeRequest
    {
        /// <summary>
        /// <see cref="gcov::TraceScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::TraceScopeName TraceScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::TraceScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTraceScopesRequest
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

    public partial class DeleteTraceScopeRequest
    {
        /// <summary>
        /// <see cref="gcov::TraceScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::TraceScopeName TraceScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::TraceScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSettingsRequest
    {
        /// <summary>
        /// <see cref="gcov::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
