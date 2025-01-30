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
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>Changelog</c> resource.</summary>
    public sealed partial class ChangelogName : gax::IResourceName, sys::IEquatable<ChangelogName>
    {
        /// <summary>The possible contents of <see cref="ChangelogName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}</c>.
            /// </summary>
            ProjectLocationAgentChangelog = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentChangelog = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}");

        /// <summary>Creates a <see cref="ChangelogName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChangelogName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChangelogName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChangelogName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChangelogName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changelogId">The <c>Changelog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChangelogName"/> constructed from the provided ids.</returns>
        public static ChangelogName FromProjectLocationAgentChangelog(string projectId, string locationId, string agentId, string changelogId) =>
            new ChangelogName(ResourceNameType.ProjectLocationAgentChangelog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), changelogId: gax::GaxPreconditions.CheckNotNullOrEmpty(changelogId, nameof(changelogId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChangelogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changelogId">The <c>Changelog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChangelogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string changelogId) =>
            FormatProjectLocationAgentChangelog(projectId, locationId, agentId, changelogId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChangelogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changelogId">The <c>Changelog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChangelogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentChangelog(string projectId, string locationId, string agentId, string changelogId) =>
            s_projectLocationAgentChangelog.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(changelogId, nameof(changelogId)));

        /// <summary>Parses the given resource name string into a new <see cref="ChangelogName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="changelogName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChangelogName"/> if successful.</returns>
        public static ChangelogName Parse(string changelogName) => Parse(changelogName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChangelogName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="changelogName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChangelogName"/> if successful.</returns>
        public static ChangelogName Parse(string changelogName, bool allowUnparsed) =>
            TryParse(changelogName, allowUnparsed, out ChangelogName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChangelogName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="changelogName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChangelogName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string changelogName, out ChangelogName result) => TryParse(changelogName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChangelogName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="changelogName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChangelogName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string changelogName, bool allowUnparsed, out ChangelogName result)
        {
            gax::GaxPreconditions.CheckNotNull(changelogName, nameof(changelogName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentChangelog.TryParseName(changelogName, out resourceName))
            {
                result = FromProjectLocationAgentChangelog(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(changelogName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ChangelogName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string changelogId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            ChangelogId = changelogId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChangelogName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/changelogs/{changelog}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changelogId">The <c>Changelog</c> ID. Must not be <c>null</c> or empty.</param>
        public ChangelogName(string projectId, string locationId, string agentId, string changelogId) : this(ResourceNameType.ProjectLocationAgentChangelog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), changelogId: gax::GaxPreconditions.CheckNotNullOrEmpty(changelogId, nameof(changelogId)))
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
        /// The <c>Agent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AgentId { get; }

        /// <summary>
        /// The <c>Changelog</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ChangelogId { get; }

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
                case ResourceNameType.ProjectLocationAgentChangelog: return s_projectLocationAgentChangelog.Expand(ProjectId, LocationId, AgentId, ChangelogId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChangelogName);

        /// <inheritdoc/>
        public bool Equals(ChangelogName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChangelogName a, ChangelogName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ChangelogName a, ChangelogName b) => !(a == b);
    }

    public partial class ListChangelogsRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetChangelogRequest
    {
        /// <summary>
        /// <see cref="gcdcv::ChangelogName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ChangelogName ChangelogName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ChangelogName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Changelog
    {
        /// <summary>
        /// <see cref="gcdcv::ChangelogName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ChangelogName ChangelogName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ChangelogName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
