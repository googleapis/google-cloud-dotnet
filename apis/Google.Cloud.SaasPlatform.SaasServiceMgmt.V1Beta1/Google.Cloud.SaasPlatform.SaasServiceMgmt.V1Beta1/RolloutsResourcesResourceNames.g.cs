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
using gcssv = Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1;
using sys = System;

namespace Google.Cloud.SaasPlatform.SaasServiceMgmt.V1Beta1
{
    /// <summary>Resource name for the <c>Rollout</c> resource.</summary>
    public sealed partial class RolloutName : gax::IResourceName, sys::IEquatable<RolloutName>
    {
        /// <summary>The possible contents of <see cref="RolloutName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/rollouts/{rollout_id}</c>.
            /// </summary>
            ProjectLocationRollout = 1,
        }

        private static gax::PathTemplate s_projectLocationRollout = new gax::PathTemplate("projects/{project}/locations/{location}/rollouts/{rollout_id}");

        /// <summary>Creates a <see cref="RolloutName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RolloutName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RolloutName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RolloutName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RolloutName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/rollouts/{rollout_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RolloutName"/> constructed from the provided ids.</returns>
        public static RolloutName FromProjectLocationRollout(string projectId, string locationId, string rolloutId) =>
            new RolloutName(ResourceNameType.ProjectLocationRollout, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), rolloutId: gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RolloutName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rollouts/{rollout_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RolloutName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rollouts/{rollout_id}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string rolloutId) =>
            FormatProjectLocationRollout(projectId, locationId, rolloutId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RolloutName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rollouts/{rollout_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RolloutName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rollouts/{rollout_id}</c>.
        /// </returns>
        public static string FormatProjectLocationRollout(string projectId, string locationId, string rolloutId) =>
            s_projectLocationRollout.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)));

        /// <summary>Parses the given resource name string into a new <see cref="RolloutName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rollouts/{rollout_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RolloutName"/> if successful.</returns>
        public static RolloutName Parse(string rolloutName) => Parse(rolloutName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RolloutName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rollouts/{rollout_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RolloutName"/> if successful.</returns>
        public static RolloutName Parse(string rolloutName, bool allowUnparsed) =>
            TryParse(rolloutName, allowUnparsed, out RolloutName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RolloutName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rollouts/{rollout_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RolloutName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rolloutName, out RolloutName result) => TryParse(rolloutName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RolloutName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rollouts/{rollout_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rolloutName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RolloutName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rolloutName, bool allowUnparsed, out RolloutName result)
        {
            gax::GaxPreconditions.CheckNotNull(rolloutName, nameof(rolloutName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRollout.TryParseName(rolloutName, out resourceName))
            {
                result = FromProjectLocationRollout(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(rolloutName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RolloutName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string rolloutId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RolloutId = rolloutId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RolloutName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/rollouts/{rollout_id}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutId">The <c>Rollout</c> ID. Must not be <c>null</c> or empty.</param>
        public RolloutName(string projectId, string locationId, string rolloutId) : this(ResourceNameType.ProjectLocationRollout, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), rolloutId: gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)))
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
        /// The <c>Rollout</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RolloutId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRollout: return s_projectLocationRollout.Expand(ProjectId, LocationId, RolloutId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RolloutName);

        /// <inheritdoc/>
        public bool Equals(RolloutName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RolloutName a, RolloutName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RolloutName a, RolloutName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>RolloutKind</c> resource.</summary>
    public sealed partial class RolloutKindName : gax::IResourceName, sys::IEquatable<RolloutKindName>
    {
        /// <summary>The possible contents of <see cref="RolloutKindName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}</c>
            /// .
            /// </summary>
            ProjectLocationRolloutKind = 1,
        }

        private static gax::PathTemplate s_projectLocationRolloutKind = new gax::PathTemplate("projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}");

        /// <summary>Creates a <see cref="RolloutKindName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RolloutKindName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RolloutKindName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RolloutKindName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RolloutKindName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutKindId">The <c>RolloutKind</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RolloutKindName"/> constructed from the provided ids.</returns>
        public static RolloutKindName FromProjectLocationRolloutKind(string projectId, string locationId, string rolloutKindId) =>
            new RolloutKindName(ResourceNameType.ProjectLocationRolloutKind, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), rolloutKindId: gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutKindId, nameof(rolloutKindId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RolloutKindName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutKindId">The <c>RolloutKind</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RolloutKindName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string rolloutKindId) =>
            FormatProjectLocationRolloutKind(projectId, locationId, rolloutKindId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RolloutKindName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutKindId">The <c>RolloutKind</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RolloutKindName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}</c>.
        /// </returns>
        public static string FormatProjectLocationRolloutKind(string projectId, string locationId, string rolloutKindId) =>
            s_projectLocationRolloutKind.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutKindId, nameof(rolloutKindId)));

        /// <summary>Parses the given resource name string into a new <see cref="RolloutKindName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rolloutKindName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RolloutKindName"/> if successful.</returns>
        public static RolloutKindName Parse(string rolloutKindName) => Parse(rolloutKindName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RolloutKindName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rolloutKindName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RolloutKindName"/> if successful.</returns>
        public static RolloutKindName Parse(string rolloutKindName, bool allowUnparsed) =>
            TryParse(rolloutKindName, allowUnparsed, out RolloutKindName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RolloutKindName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rolloutKindName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RolloutKindName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rolloutKindName, out RolloutKindName result) =>
            TryParse(rolloutKindName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RolloutKindName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rolloutKindName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RolloutKindName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rolloutKindName, bool allowUnparsed, out RolloutKindName result)
        {
            gax::GaxPreconditions.CheckNotNull(rolloutKindName, nameof(rolloutKindName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRolloutKind.TryParseName(rolloutKindName, out resourceName))
            {
                result = FromProjectLocationRolloutKind(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(rolloutKindName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RolloutKindName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string rolloutKindId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RolloutKindId = rolloutKindId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RolloutKindName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/rolloutKinds/{rollout_kind_id}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rolloutKindId">The <c>RolloutKind</c> ID. Must not be <c>null</c> or empty.</param>
        public RolloutKindName(string projectId, string locationId, string rolloutKindId) : this(ResourceNameType.ProjectLocationRolloutKind, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), rolloutKindId: gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutKindId, nameof(rolloutKindId)))
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
        /// The <c>RolloutKind</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RolloutKindId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRolloutKind: return s_projectLocationRolloutKind.Expand(ProjectId, LocationId, RolloutKindId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RolloutKindName);

        /// <inheritdoc/>
        public bool Equals(RolloutKindName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RolloutKindName a, RolloutKindName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RolloutKindName a, RolloutKindName b) => !(a == b);
    }

    public partial class Rollout
    {
        /// <summary>
        /// <see cref="gcssv::RolloutName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::RolloutName RolloutName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::RolloutName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ReleaseName"/>-typed view over the <see cref="Release"/> resource name property.
        /// </summary>
        public ReleaseName ReleaseAsReleaseName
        {
            get => string.IsNullOrEmpty(Release) ? null : ReleaseName.Parse(Release, allowUnparsed: true);
            set => Release = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcssv::RolloutName"/>-typed view over the <see cref="RootRollout"/> resource name property.
        /// </summary>
        public gcssv::RolloutName RootRolloutAsRolloutName
        {
            get => string.IsNullOrEmpty(RootRollout) ? null : gcssv::RolloutName.Parse(RootRollout, allowUnparsed: true);
            set => RootRollout = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcssv::RolloutName"/>-typed view over the <see cref="ParentRollout"/> resource name property.
        /// </summary>
        public gcssv::RolloutName ParentRolloutAsRolloutName
        {
            get => string.IsNullOrEmpty(ParentRollout) ? null : gcssv::RolloutName.Parse(ParentRollout, allowUnparsed: true);
            set => ParentRollout = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RolloutKindName"/>-typed view over the <see cref="RolloutKind"/> resource name property.
        /// </summary>
        public RolloutKindName RolloutKindAsRolloutKindName
        {
            get => string.IsNullOrEmpty(RolloutKind) ? null : RolloutKindName.Parse(RolloutKind, allowUnparsed: true);
            set => RolloutKind = value?.ToString() ?? "";
        }
    }

    public partial class RolloutKind
    {
        /// <summary>
        /// <see cref="gcssv::RolloutKindName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcssv::RolloutKindName RolloutKindName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcssv::RolloutKindName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UnitKindName"/>-typed view over the <see cref="UnitKind"/> resource name property.
        /// </summary>
        public UnitKindName UnitKindAsUnitKindName
        {
            get => string.IsNullOrEmpty(UnitKind) ? null : UnitKindName.Parse(UnitKind, allowUnparsed: true);
            set => UnitKind = value?.ToString() ?? "";
        }
    }
}
