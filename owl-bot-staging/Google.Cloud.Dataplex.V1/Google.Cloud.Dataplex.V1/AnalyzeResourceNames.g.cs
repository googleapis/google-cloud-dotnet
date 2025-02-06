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
using gcdv = Google.Cloud.Dataplex.V1;
using sys = System;

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Resource name for the <c>Environment</c> resource.</summary>
    public sealed partial class EnvironmentName : gax::IResourceName, sys::IEquatable<EnvironmentName>
    {
        /// <summary>The possible contents of <see cref="EnvironmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}</c>.
            /// </summary>
            ProjectLocationLakeEnvironment = 1,
        }

        private static gax::PathTemplate s_projectLocationLakeEnvironment = new gax::PathTemplate("projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}");

        /// <summary>Creates a <see cref="EnvironmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EnvironmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EnvironmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EnvironmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EnvironmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EnvironmentName"/> constructed from the provided ids.</returns>
        public static EnvironmentName FromProjectLocationLakeEnvironment(string projectId, string locationId, string lakeId, string environmentId) =>
            new EnvironmentName(ResourceNameType.ProjectLocationLakeEnvironment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string lakeId, string environmentId) =>
            FormatProjectLocationLakeEnvironment(projectId, locationId, lakeId, environmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}</c>.
        /// </returns>
        public static string FormatProjectLocationLakeEnvironment(string projectId, string locationId, string lakeId, string environmentId) =>
            s_projectLocationLakeEnvironment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)));

        /// <summary>Parses the given resource name string into a new <see cref="EnvironmentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EnvironmentName"/> if successful.</returns>
        public static EnvironmentName Parse(string environmentName) => Parse(environmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EnvironmentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EnvironmentName"/> if successful.</returns>
        public static EnvironmentName Parse(string environmentName, bool allowUnparsed) =>
            TryParse(environmentName, allowUnparsed, out EnvironmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnvironmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnvironmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string environmentName, out EnvironmentName result) =>
            TryParse(environmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnvironmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnvironmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string environmentName, bool allowUnparsed, out EnvironmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(environmentName, nameof(environmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLakeEnvironment.TryParseName(environmentName, out resourceName))
            {
                result = FromProjectLocationLakeEnvironment(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(environmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EnvironmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string environmentId = null, string lakeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EnvironmentId = environmentId;
            LakeId = lakeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EnvironmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        public EnvironmentName(string projectId, string locationId, string lakeId, string environmentId) : this(ResourceNameType.ProjectLocationLakeEnvironment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)))
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
        /// The <c>Environment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EnvironmentId { get; }

        /// <summary>
        /// The <c>Lake</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LakeId { get; }

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
                case ResourceNameType.ProjectLocationLakeEnvironment: return s_projectLocationLakeEnvironment.Expand(ProjectId, LocationId, LakeId, EnvironmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EnvironmentName);

        /// <inheritdoc/>
        public bool Equals(EnvironmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EnvironmentName a, EnvironmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EnvironmentName a, EnvironmentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Content</c> resource.</summary>
    public sealed partial class ContentName : gax::IResourceName, sys::IEquatable<ContentName>
    {
        /// <summary>The possible contents of <see cref="ContentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/lakes/{lake}/content/{content}</c>
            /// .
            /// </summary>
            ProjectLocationLakeContent = 1,
        }

        private static gax::PathTemplate s_projectLocationLakeContent = new gax::PathTemplate("projects/{project}/locations/{location}/lakes/{lake}/content/{content}");

        /// <summary>Creates a <see cref="ContentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ContentName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ContentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ContentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ContentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/content/{content}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentId">The <c>Content</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContentName"/> constructed from the provided ids.</returns>
        public static ContentName FromProjectLocationLakeContent(string projectId, string locationId, string lakeId, string contentId) =>
            new ContentName(ResourceNameType.ProjectLocationLakeContent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), contentId: gax::GaxPreconditions.CheckNotNullOrEmpty(contentId, nameof(contentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/content/{content}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentId">The <c>Content</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/content/{content}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string lakeId, string contentId) =>
            FormatProjectLocationLakeContent(projectId, locationId, lakeId, contentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/content/{content}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentId">The <c>Content</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/content/{content}</c>.
        /// </returns>
        public static string FormatProjectLocationLakeContent(string projectId, string locationId, string lakeId, string contentId) =>
            s_projectLocationLakeContent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contentId, nameof(contentId)));

        /// <summary>Parses the given resource name string into a new <see cref="ContentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/content/{content}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="contentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ContentName"/> if successful.</returns>
        public static ContentName Parse(string contentName) => Parse(contentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ContentName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/content/{content}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ContentName"/> if successful.</returns>
        public static ContentName Parse(string contentName, bool allowUnparsed) =>
            TryParse(contentName, allowUnparsed, out ContentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/content/{content}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="contentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contentName, out ContentName result) => TryParse(contentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/content/{content}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contentName, bool allowUnparsed, out ContentName result)
        {
            gax::GaxPreconditions.CheckNotNull(contentName, nameof(contentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLakeContent.TryParseName(contentName, out resourceName))
            {
                result = FromProjectLocationLakeContent(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(contentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ContentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string contentId = null, string lakeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ContentId = contentId;
            LakeId = lakeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ContentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/content/{content}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentId">The <c>Content</c> ID. Must not be <c>null</c> or empty.</param>
        public ContentName(string projectId, string locationId, string lakeId, string contentId) : this(ResourceNameType.ProjectLocationLakeContent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), contentId: gax::GaxPreconditions.CheckNotNullOrEmpty(contentId, nameof(contentId)))
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
        /// The <c>Content</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ContentId { get; }

        /// <summary>
        /// The <c>Lake</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LakeId { get; }

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
                case ResourceNameType.ProjectLocationLakeContent: return s_projectLocationLakeContent.Expand(ProjectId, LocationId, LakeId, ContentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ContentName);

        /// <inheritdoc/>
        public bool Equals(ContentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ContentName a, ContentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ContentName a, ContentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Session</c> resource.</summary>
    public sealed partial class SessionName : gax::IResourceName, sys::IEquatable<SessionName>
    {
        /// <summary>The possible contents of <see cref="SessionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}</c>
            /// .
            /// </summary>
            ProjectLocationLakeEnvironmentSession = 1,
        }

        private static gax::PathTemplate s_projectLocationLakeEnvironmentSession = new gax::PathTemplate("projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}");

        /// <summary>Creates a <see cref="SessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SessionName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SessionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionName"/> constructed from the provided ids.</returns>
        public static SessionName FromProjectLocationLakeEnvironmentSession(string projectId, string locationId, string lakeId, string environmentId, string sessionId) =>
            new SessionName(ResourceNameType.ProjectLocationLakeEnvironmentSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string lakeId, string environmentId, string sessionId) =>
            FormatProjectLocationLakeEnvironmentSession(projectId, locationId, lakeId, environmentId, sessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}</c>.
        /// </returns>
        public static string FormatProjectLocationLakeEnvironmentSession(string projectId, string locationId, string lakeId, string environmentId, string sessionId) =>
            s_projectLocationLakeEnvironmentSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>Parses the given resource name string into a new <see cref="SessionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SessionName"/> if successful.</returns>
        public static SessionName Parse(string sessionName) => Parse(sessionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SessionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SessionName"/> if successful.</returns>
        public static SessionName Parse(string sessionName, bool allowUnparsed) =>
            TryParse(sessionName, allowUnparsed, out SessionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionName, out SessionName result) => TryParse(sessionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SessionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionName, bool allowUnparsed, out SessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLakeEnvironmentSession.TryParseName(sessionName, out resourceName))
            {
                result = FromProjectLocationLakeEnvironmentSession(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sessionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string environmentId = null, string lakeId = null, string locationId = null, string projectId = null, string sessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EnvironmentId = environmentId;
            LakeId = lakeId;
            LocationId = locationId;
            ProjectId = projectId;
            SessionId = sessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SessionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/environments/{environment}/sessions/{session}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        public SessionName(string projectId, string locationId, string lakeId, string environmentId, string sessionId) : this(ResourceNameType.ProjectLocationLakeEnvironmentSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)))
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
        /// The <c>Environment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EnvironmentId { get; }

        /// <summary>
        /// The <c>Lake</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LakeId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Session</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SessionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationLakeEnvironmentSession: return s_projectLocationLakeEnvironmentSession.Expand(ProjectId, LocationId, LakeId, EnvironmentId, SessionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SessionName);

        /// <inheritdoc/>
        public bool Equals(SessionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SessionName a, SessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SessionName a, SessionName b) => !(a == b);
    }

    public partial class Environment
    {
        /// <summary>
        /// <see cref="gcdv::EnvironmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EnvironmentName EnvironmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EnvironmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Content
    {
        /// <summary>
        /// <see cref="gcdv::ContentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ContentName ContentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ContentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Session
    {
        /// <summary>
        /// <see cref="gcdv::SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SessionName SessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
