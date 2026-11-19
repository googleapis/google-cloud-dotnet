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
using gax = Google.Api.Gax;
using gcav = Google.Cloud.AgentRegistry.V1;
using sys = System;

namespace Google.Cloud.AgentRegistry.V1
{
    /// <summary>Resource name for the <c>Skill</c> resource.</summary>
    public sealed partial class SkillName : gax::IResourceName, sys::IEquatable<SkillName>
    {
        /// <summary>The possible contents of <see cref="SkillName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/skills/{skill}</c>.
            /// </summary>
            ProjectLocationSkill = 1,
        }

        private static gax::PathTemplate s_projectLocationSkill = new gax::PathTemplate("projects/{project}/locations/{location}/skills/{skill}");

        /// <summary>Creates a <see cref="SkillName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SkillName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SkillName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SkillName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SkillName"/> with the pattern <c>projects/{project}/locations/{location}/skills/{skill}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skillId">The <c>Skill</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SkillName"/> constructed from the provided ids.</returns>
        public static SkillName FromProjectLocationSkill(string projectId, string locationId, string skillId) =>
            new SkillName(ResourceNameType.ProjectLocationSkill, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), skillId: gax::GaxPreconditions.CheckNotNullOrEmpty(skillId, nameof(skillId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkillName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skills/{skill}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skillId">The <c>Skill</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkillName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skills/{skill}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string skillId) =>
            FormatProjectLocationSkill(projectId, locationId, skillId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkillName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skills/{skill}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skillId">The <c>Skill</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkillName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skills/{skill}</c>.
        /// </returns>
        public static string FormatProjectLocationSkill(string projectId, string locationId, string skillId) =>
            s_projectLocationSkill.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(skillId, nameof(skillId)));

        /// <summary>Parses the given resource name string into a new <see cref="SkillName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/skills/{skill}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="skillName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SkillName"/> if successful.</returns>
        public static SkillName Parse(string skillName) => Parse(skillName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SkillName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/skills/{skill}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skillName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SkillName"/> if successful.</returns>
        public static SkillName Parse(string skillName, bool allowUnparsed) =>
            TryParse(skillName, allowUnparsed, out SkillName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SkillName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/skills/{skill}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="skillName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkillName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skillName, out SkillName result) => TryParse(skillName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SkillName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/skills/{skill}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skillName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkillName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skillName, bool allowUnparsed, out SkillName result)
        {
            gax::GaxPreconditions.CheckNotNull(skillName, nameof(skillName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSkill.TryParseName(skillName, out resourceName))
            {
                result = FromProjectLocationSkill(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(skillName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SkillName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string skillId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SkillId = skillId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SkillName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/skills/{skill}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skillId">The <c>Skill</c> ID. Must not be <c>null</c> or empty.</param>
        public SkillName(string projectId, string locationId, string skillId) : this(ResourceNameType.ProjectLocationSkill, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), skillId: gax::GaxPreconditions.CheckNotNullOrEmpty(skillId, nameof(skillId)))
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
        /// The <c>Skill</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SkillId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSkill: return s_projectLocationSkill.Expand(ProjectId, LocationId, SkillId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SkillName);

        /// <inheritdoc/>
        public bool Equals(SkillName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SkillName a, SkillName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SkillName a, SkillName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SkillRevision</c> resource.</summary>
    public sealed partial class SkillRevisionName : gax::IResourceName, sys::IEquatable<SkillRevisionName>
    {
        /// <summary>The possible contents of <see cref="SkillRevisionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}</c>.
            /// </summary>
            ProjectLocationSkillRevision = 1,
        }

        private static gax::PathTemplate s_projectLocationSkillRevision = new gax::PathTemplate("projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}");

        /// <summary>Creates a <see cref="SkillRevisionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SkillRevisionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SkillRevisionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SkillRevisionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SkillRevisionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skillId">The <c>Skill</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SkillRevisionName"/> constructed from the provided ids.</returns>
        public static SkillRevisionName FromProjectLocationSkillRevision(string projectId, string locationId, string skillId, string revisionId) =>
            new SkillRevisionName(ResourceNameType.ProjectLocationSkillRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), skillId: gax::GaxPreconditions.CheckNotNullOrEmpty(skillId, nameof(skillId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkillRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skillId">The <c>Skill</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkillRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string skillId, string revisionId) =>
            FormatProjectLocationSkillRevision(projectId, locationId, skillId, revisionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SkillRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skillId">The <c>Skill</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SkillRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}</c>.
        /// </returns>
        public static string FormatProjectLocationSkillRevision(string projectId, string locationId, string skillId, string revisionId) =>
            s_projectLocationSkillRevision.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(skillId, nameof(skillId)), gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SkillRevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="skillRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SkillRevisionName"/> if successful.</returns>
        public static SkillRevisionName Parse(string skillRevisionName) => Parse(skillRevisionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SkillRevisionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skillRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SkillRevisionName"/> if successful.</returns>
        public static SkillRevisionName Parse(string skillRevisionName, bool allowUnparsed) =>
            TryParse(skillRevisionName, allowUnparsed, out SkillRevisionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SkillRevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="skillRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkillRevisionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skillRevisionName, out SkillRevisionName result) =>
            TryParse(skillRevisionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SkillRevisionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="skillRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SkillRevisionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string skillRevisionName, bool allowUnparsed, out SkillRevisionName result)
        {
            gax::GaxPreconditions.CheckNotNull(skillRevisionName, nameof(skillRevisionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSkillRevision.TryParseName(skillRevisionName, out resourceName))
            {
                result = FromProjectLocationSkillRevision(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(skillRevisionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SkillRevisionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string revisionId = null, string skillId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RevisionId = revisionId;
            SkillId = skillId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SkillRevisionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/skills/{skill}/revisions/{revision}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="skillId">The <c>Skill</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        public SkillRevisionName(string projectId, string locationId, string skillId, string revisionId) : this(ResourceNameType.ProjectLocationSkillRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), skillId: gax::GaxPreconditions.CheckNotNullOrEmpty(skillId, nameof(skillId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)))
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
        /// The <c>Revision</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RevisionId { get; }

        /// <summary>
        /// The <c>Skill</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SkillId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSkillRevision: return s_projectLocationSkillRevision.Expand(ProjectId, LocationId, SkillId, RevisionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SkillRevisionName);

        /// <inheritdoc/>
        public bool Equals(SkillRevisionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SkillRevisionName a, SkillRevisionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SkillRevisionName a, SkillRevisionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Publisher</c> resource.</summary>
    public sealed partial class PublisherName : gax::IResourceName, sys::IEquatable<PublisherName>
    {
        /// <summary>The possible contents of <see cref="PublisherName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/publishers/{publisher}</c>.
            /// </summary>
            ProjectLocationPublisher = 1,
        }

        private static gax::PathTemplate s_projectLocationPublisher = new gax::PathTemplate("projects/{project}/locations/{location}/publishers/{publisher}");

        /// <summary>Creates a <see cref="PublisherName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PublisherName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PublisherName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PublisherName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PublisherName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PublisherName"/> constructed from the provided ids.</returns>
        public static PublisherName FromProjectLocationPublisher(string projectId, string locationId, string publisherId) =>
            new PublisherName(ResourceNameType.ProjectLocationPublisher, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), publisherId: gax::GaxPreconditions.CheckNotNullOrEmpty(publisherId, nameof(publisherId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PublisherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PublisherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string publisherId) =>
            FormatProjectLocationPublisher(projectId, locationId, publisherId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PublisherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PublisherName"/> with pattern
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}</c>.
        /// </returns>
        public static string FormatProjectLocationPublisher(string projectId, string locationId, string publisherId) =>
            s_projectLocationPublisher.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(publisherId, nameof(publisherId)));

        /// <summary>Parses the given resource name string into a new <see cref="PublisherName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/publishers/{publisher}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="publisherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PublisherName"/> if successful.</returns>
        public static PublisherName Parse(string publisherName) => Parse(publisherName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PublisherName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/publishers/{publisher}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="publisherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PublisherName"/> if successful.</returns>
        public static PublisherName Parse(string publisherName, bool allowUnparsed) =>
            TryParse(publisherName, allowUnparsed, out PublisherName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PublisherName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/publishers/{publisher}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="publisherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PublisherName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string publisherName, out PublisherName result) => TryParse(publisherName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PublisherName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/publishers/{publisher}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="publisherName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PublisherName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string publisherName, bool allowUnparsed, out PublisherName result)
        {
            gax::GaxPreconditions.CheckNotNull(publisherName, nameof(publisherName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPublisher.TryParseName(publisherName, out resourceName))
            {
                result = FromProjectLocationPublisher(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(publisherName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PublisherName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string publisherId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            PublisherId = publisherId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PublisherName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/publishers/{publisher}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="publisherId">The <c>Publisher</c> ID. Must not be <c>null</c> or empty.</param>
        public PublisherName(string projectId, string locationId, string publisherId) : this(ResourceNameType.ProjectLocationPublisher, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), publisherId: gax::GaxPreconditions.CheckNotNullOrEmpty(publisherId, nameof(publisherId)))
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
        /// The <c>Publisher</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PublisherId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationPublisher: return s_projectLocationPublisher.Expand(ProjectId, LocationId, PublisherId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PublisherName);

        /// <inheritdoc/>
        public bool Equals(PublisherName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PublisherName a, PublisherName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PublisherName a, PublisherName b) => !(a == b);
    }

    public partial class Skill
    {
        /// <summary>
        /// <see cref="gcav::SkillName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SkillName SkillName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SkillName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SkillRevisionName"/>-typed view over the <see cref="DefaultRevision"/> resource name property.
        /// </summary>
        public SkillRevisionName DefaultRevisionAsSkillRevisionName
        {
            get => string.IsNullOrEmpty(DefaultRevision) ? null : SkillRevisionName.Parse(DefaultRevision, allowUnparsed: true);
            set => DefaultRevision = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PublisherName"/>-typed view over the <see cref="Publisher"/> resource name property.
        /// </summary>
        public PublisherName PublisherAsPublisherName
        {
            get => string.IsNullOrEmpty(Publisher) ? null : PublisherName.Parse(Publisher, allowUnparsed: true);
            set => Publisher = value?.ToString() ?? "";
        }
    }

    public partial class SkillRevision
    {
        /// <summary>
        /// <see cref="gcav::SkillRevisionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SkillRevisionName SkillRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SkillRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class ScanResult
            {
                /// <summary>
                /// <see cref="FindingName"/>-typed view over the <see cref="Findings"/> resource name property.
                /// </summary>
                public gax::ResourceNameList<FindingName> FindingsAsFindingNames
                {
                    get => new gax::ResourceNameList<FindingName>(Findings, s => string.IsNullOrEmpty(s) ? null : FindingName.Parse(s, allowUnparsed: true));
                }
            }
        }
    }

    public partial class Publisher
    {
        /// <summary>
        /// <see cref="gcav::PublisherName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PublisherName PublisherName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PublisherName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
