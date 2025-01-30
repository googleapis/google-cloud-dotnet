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
using gcdv = Google.Cloud.Dialogflow.V2Beta1;
using sys = System;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Resource name for the <c>Version</c> resource.</summary>
    public sealed partial class VersionName : gax::IResourceName, sys::IEquatable<VersionName>
    {
        /// <summary>The possible contents of <see cref="VersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/agent/versions/{version}</c>.</summary>
            ProjectVersion = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/agent/versions/{version}</c>.
            /// </summary>
            ProjectLocationVersion = 2,
        }

        private static gax::PathTemplate s_projectVersion = new gax::PathTemplate("projects/{project}/agent/versions/{version}");

        private static gax::PathTemplate s_projectLocationVersion = new gax::PathTemplate("projects/{project}/locations/{location}/agent/versions/{version}");

        /// <summary>Creates a <see cref="VersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VersionName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VersionName"/> with the pattern <c>projects/{project}/agent/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VersionName"/> constructed from the provided ids.</returns>
        public static VersionName FromProjectVersion(string projectId, string versionId) =>
            new VersionName(ResourceNameType.ProjectVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Creates a <see cref="VersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agent/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VersionName"/> constructed from the provided ids.</returns>
        public static VersionName FromProjectLocationVersion(string projectId, string locationId, string versionId) =>
            new VersionName(ResourceNameType.ProjectLocationVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/agent/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/agent/versions/{version}</c>.
        /// </returns>
        public static string Format(string projectId, string versionId) => FormatProjectVersion(projectId, versionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/agent/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/agent/versions/{version}</c>.
        /// </returns>
        public static string FormatProjectVersion(string projectId, string versionId) =>
            s_projectVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agent/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agent/versions/{version}</c>.
        /// </returns>
        public static string FormatProjectLocationVersion(string projectId, string locationId, string versionId) =>
            s_projectLocationVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>Parses the given resource name string into a new <see cref="VersionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/versions/{version}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agent/versions/{version}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VersionName"/> if successful.</returns>
        public static VersionName Parse(string versionName) => Parse(versionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VersionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/versions/{version}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agent/versions/{version}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VersionName"/> if successful.</returns>
        public static VersionName Parse(string versionName, bool allowUnparsed) =>
            TryParse(versionName, allowUnparsed, out VersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/versions/{version}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agent/versions/{version}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string versionName, out VersionName result) => TryParse(versionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/versions/{version}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agent/versions/{version}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="versionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string versionName, bool allowUnparsed, out VersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(versionName, nameof(versionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectVersion.TryParseName(versionName, out resourceName))
            {
                result = FromProjectVersion(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationVersion.TryParseName(versionName, out resourceName))
            {
                result = FromProjectLocationVersion(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(versionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/agent/versions/{version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        public VersionName(string projectId, string versionId) : this(ResourceNameType.ProjectVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)))
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
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Version</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string VersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectVersion: return s_projectVersion.Expand(ProjectId, VersionId);
                case ResourceNameType.ProjectLocationVersion: return s_projectLocationVersion.Expand(ProjectId, LocationId, VersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VersionName);

        /// <inheritdoc/>
        public bool Equals(VersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VersionName a, VersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VersionName a, VersionName b) => !(a == b);
    }

    public partial class Version
    {
        /// <summary>
        /// <see cref="gcdv::VersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::VersionName VersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::VersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListVersionsRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetVersionRequest
    {
        /// <summary>
        /// <see cref="gcdv::VersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::VersionName VersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::VersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateVersionRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteVersionRequest
    {
        /// <summary>
        /// <see cref="gcdv::VersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::VersionName VersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::VersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
