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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gccv = Google.Cloud.CloudBuild.V1;
using sys = System;

namespace Google.Cloud.CloudBuild.V1
{
    /// <summary>Resource name for the <c>Build</c> resource.</summary>
    public sealed partial class BuildName : gax::IResourceName, sys::IEquatable<BuildName>
    {
        /// <summary>The possible contents of <see cref="BuildName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/builds/{build}</c>.</summary>
            ProjectBuild = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/builds/{build}</c>.
            /// </summary>
            ProjectLocationBuild = 2,
        }

        private static gax::PathTemplate s_projectBuild = new gax::PathTemplate("projects/{project}/builds/{build}");

        private static gax::PathTemplate s_projectLocationBuild = new gax::PathTemplate("projects/{project}/locations/{location}/builds/{build}");

        /// <summary>Creates a <see cref="BuildName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BuildName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BuildName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BuildName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BuildName"/> with the pattern <c>projects/{project}/builds/{build}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BuildName"/> constructed from the provided ids.</returns>
        public static BuildName FromProjectBuild(string projectId, string buildId) =>
            new BuildName(ResourceNameType.ProjectBuild, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), buildId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)));

        /// <summary>
        /// Creates a <see cref="BuildName"/> with the pattern <c>projects/{project}/locations/{location}/builds/{build}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BuildName"/> constructed from the provided ids.</returns>
        public static BuildName FromProjectLocationBuild(string projectId, string locationId, string buildId) =>
            new BuildName(ResourceNameType.ProjectLocationBuild, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), buildId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildName"/> with pattern
        /// <c>projects/{project}/builds/{build}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildName"/> with pattern <c>projects/{project}/builds/{build}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string buildId) => FormatProjectBuild(projectId, buildId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildName"/> with pattern
        /// <c>projects/{project}/builds/{build}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildName"/> with pattern <c>projects/{project}/builds/{build}</c>
        /// .
        /// </returns>
        public static string FormatProjectBuild(string projectId, string buildId) =>
            s_projectBuild.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildName"/> with pattern
        /// <c>projects/{project}/locations/{location}/builds/{build}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildName"/> with pattern
        /// <c>projects/{project}/locations/{location}/builds/{build}</c>.
        /// </returns>
        public static string FormatProjectLocationBuild(string projectId, string locationId, string buildId) =>
            s_projectLocationBuild.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)));

        /// <summary>Parses the given resource name string into a new <see cref="BuildName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/builds/{build}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/builds/{build}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BuildName"/> if successful.</returns>
        public static BuildName Parse(string buildName) => Parse(buildName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BuildName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/builds/{build}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/builds/{build}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BuildName"/> if successful.</returns>
        public static BuildName Parse(string buildName, bool allowUnparsed) =>
            TryParse(buildName, allowUnparsed, out BuildName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/builds/{build}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/builds/{build}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildName, out BuildName result) => TryParse(buildName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/builds/{build}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/builds/{build}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildName, bool allowUnparsed, out BuildName result)
        {
            gax::GaxPreconditions.CheckNotNull(buildName, nameof(buildName));
            gax::TemplatedResourceName resourceName;
            if (s_projectBuild.TryParseName(buildName, out resourceName))
            {
                result = FromProjectBuild(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationBuild.TryParseName(buildName, out resourceName))
            {
                result = FromProjectLocationBuild(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(buildName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BuildName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string buildId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BuildId = buildId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BuildName"/> class from the component parts of pattern
        /// <c>projects/{project}/builds/{build}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="buildId">The <c>Build</c> ID. Must not be <c>null</c> or empty.</param>
        public BuildName(string projectId, string buildId) : this(ResourceNameType.ProjectBuild, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), buildId: gax::GaxPreconditions.CheckNotNullOrEmpty(buildId, nameof(buildId)))
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
        /// The <c>Build</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string BuildId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectBuild: return s_projectBuild.Expand(ProjectId, BuildId);
                case ResourceNameType.ProjectLocationBuild: return s_projectLocationBuild.Expand(ProjectId, LocationId, BuildId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BuildName);

        /// <inheritdoc/>
        public bool Equals(BuildName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BuildName a, BuildName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BuildName a, BuildName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>BuildTrigger</c> resource.</summary>
    public sealed partial class BuildTriggerName : gax::IResourceName, sys::IEquatable<BuildTriggerName>
    {
        /// <summary>The possible contents of <see cref="BuildTriggerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/triggers/{trigger}</c>.</summary>
            ProjectTrigger = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/triggers/{trigger}</c>.
            /// </summary>
            ProjectLocationTrigger = 2,
        }

        private static gax::PathTemplate s_projectTrigger = new gax::PathTemplate("projects/{project}/triggers/{trigger}");

        private static gax::PathTemplate s_projectLocationTrigger = new gax::PathTemplate("projects/{project}/locations/{location}/triggers/{trigger}");

        /// <summary>Creates a <see cref="BuildTriggerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BuildTriggerName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BuildTriggerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BuildTriggerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BuildTriggerName"/> with the pattern <c>projects/{project}/triggers/{trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="triggerId">The <c>Trigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BuildTriggerName"/> constructed from the provided ids.</returns>
        public static BuildTriggerName FromProjectTrigger(string projectId, string triggerId) =>
            new BuildTriggerName(ResourceNameType.ProjectTrigger, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), triggerId: gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)));

        /// <summary>
        /// Creates a <see cref="BuildTriggerName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/triggers/{trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="triggerId">The <c>Trigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BuildTriggerName"/> constructed from the provided ids.</returns>
        public static BuildTriggerName FromProjectLocationTrigger(string projectId, string locationId, string triggerId) =>
            new BuildTriggerName(ResourceNameType.ProjectLocationTrigger, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), triggerId: gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildTriggerName"/> with pattern
        /// <c>projects/{project}/triggers/{trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="triggerId">The <c>Trigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildTriggerName"/> with pattern
        /// <c>projects/{project}/triggers/{trigger}</c>.
        /// </returns>
        public static string Format(string projectId, string triggerId) => FormatProjectTrigger(projectId, triggerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildTriggerName"/> with pattern
        /// <c>projects/{project}/triggers/{trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="triggerId">The <c>Trigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildTriggerName"/> with pattern
        /// <c>projects/{project}/triggers/{trigger}</c>.
        /// </returns>
        public static string FormatProjectTrigger(string projectId, string triggerId) =>
            s_projectTrigger.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BuildTriggerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/triggers/{trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="triggerId">The <c>Trigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BuildTriggerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/triggers/{trigger}</c>.
        /// </returns>
        public static string FormatProjectLocationTrigger(string projectId, string locationId, string triggerId) =>
            s_projectLocationTrigger.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)));

        /// <summary>Parses the given resource name string into a new <see cref="BuildTriggerName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/triggers/{trigger}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/triggers/{trigger}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="buildTriggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BuildTriggerName"/> if successful.</returns>
        public static BuildTriggerName Parse(string buildTriggerName) => Parse(buildTriggerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BuildTriggerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/triggers/{trigger}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/triggers/{trigger}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildTriggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BuildTriggerName"/> if successful.</returns>
        public static BuildTriggerName Parse(string buildTriggerName, bool allowUnparsed) =>
            TryParse(buildTriggerName, allowUnparsed, out BuildTriggerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildTriggerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/triggers/{trigger}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/triggers/{trigger}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="buildTriggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildTriggerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildTriggerName, out BuildTriggerName result) =>
            TryParse(buildTriggerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BuildTriggerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/triggers/{trigger}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/triggers/{trigger}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="buildTriggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BuildTriggerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string buildTriggerName, bool allowUnparsed, out BuildTriggerName result)
        {
            gax::GaxPreconditions.CheckNotNull(buildTriggerName, nameof(buildTriggerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTrigger.TryParseName(buildTriggerName, out resourceName))
            {
                result = FromProjectTrigger(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationTrigger.TryParseName(buildTriggerName, out resourceName))
            {
                result = FromProjectLocationTrigger(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(buildTriggerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BuildTriggerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string triggerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TriggerId = triggerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BuildTriggerName"/> class from the component parts of pattern
        /// <c>projects/{project}/triggers/{trigger}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="triggerId">The <c>Trigger</c> ID. Must not be <c>null</c> or empty.</param>
        public BuildTriggerName(string projectId, string triggerId) : this(ResourceNameType.ProjectTrigger, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), triggerId: gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)))
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
        /// The <c>Trigger</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string TriggerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTrigger: return s_projectTrigger.Expand(ProjectId, TriggerId);
                case ResourceNameType.ProjectLocationTrigger: return s_projectLocationTrigger.Expand(ProjectId, LocationId, TriggerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BuildTriggerName);

        /// <inheritdoc/>
        public bool Equals(BuildTriggerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BuildTriggerName a, BuildTriggerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BuildTriggerName a, BuildTriggerName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>GithubEnterpriseConfig</c> resource.</summary>
    public sealed partial class GithubEnterpriseConfigName : gax::IResourceName, sys::IEquatable<GithubEnterpriseConfigName>
    {
        /// <summary>The possible contents of <see cref="GithubEnterpriseConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/githubEnterpriseConfigs/{config}</c>.
            /// </summary>
            ProjectConfig = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/githubEnterpriseConfigs/{config}</c>
            /// .
            /// </summary>
            ProjectLocationConfig = 2,
        }

        private static gax::PathTemplate s_projectConfig = new gax::PathTemplate("projects/{project}/githubEnterpriseConfigs/{config}");

        private static gax::PathTemplate s_projectLocationConfig = new gax::PathTemplate("projects/{project}/locations/{location}/githubEnterpriseConfigs/{config}");

        /// <summary>Creates a <see cref="GithubEnterpriseConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GithubEnterpriseConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GithubEnterpriseConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GithubEnterpriseConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GithubEnterpriseConfigName"/> with the pattern
        /// <c>projects/{project}/githubEnterpriseConfigs/{config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="GithubEnterpriseConfigName"/> constructed from the provided ids.
        /// </returns>
        public static GithubEnterpriseConfigName FromProjectConfig(string projectId, string configId) =>
            new GithubEnterpriseConfigName(ResourceNameType.ProjectConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), configId: gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)));

        /// <summary>
        /// Creates a <see cref="GithubEnterpriseConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/githubEnterpriseConfigs/{config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="GithubEnterpriseConfigName"/> constructed from the provided ids.
        /// </returns>
        public static GithubEnterpriseConfigName FromProjectLocationConfig(string projectId, string locationId, string configId) =>
            new GithubEnterpriseConfigName(ResourceNameType.ProjectLocationConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), configId: gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GithubEnterpriseConfigName"/> with pattern
        /// <c>projects/{project}/githubEnterpriseConfigs/{config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GithubEnterpriseConfigName"/> with pattern
        /// <c>projects/{project}/githubEnterpriseConfigs/{config}</c>.
        /// </returns>
        public static string Format(string projectId, string configId) => FormatProjectConfig(projectId, configId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GithubEnterpriseConfigName"/> with pattern
        /// <c>projects/{project}/githubEnterpriseConfigs/{config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GithubEnterpriseConfigName"/> with pattern
        /// <c>projects/{project}/githubEnterpriseConfigs/{config}</c>.
        /// </returns>
        public static string FormatProjectConfig(string projectId, string configId) =>
            s_projectConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GithubEnterpriseConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/githubEnterpriseConfigs/{config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GithubEnterpriseConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/githubEnterpriseConfigs/{config}</c>.
        /// </returns>
        public static string FormatProjectLocationConfig(string projectId, string locationId, string configId) =>
            s_projectLocationConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GithubEnterpriseConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/githubEnterpriseConfigs/{config}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/githubEnterpriseConfigs/{config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="githubEnterpriseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GithubEnterpriseConfigName"/> if successful.</returns>
        public static GithubEnterpriseConfigName Parse(string githubEnterpriseConfigName) =>
            Parse(githubEnterpriseConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GithubEnterpriseConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/githubEnterpriseConfigs/{config}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/githubEnterpriseConfigs/{config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="githubEnterpriseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GithubEnterpriseConfigName"/> if successful.</returns>
        public static GithubEnterpriseConfigName Parse(string githubEnterpriseConfigName, bool allowUnparsed) =>
            TryParse(githubEnterpriseConfigName, allowUnparsed, out GithubEnterpriseConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GithubEnterpriseConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/githubEnterpriseConfigs/{config}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/githubEnterpriseConfigs/{config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="githubEnterpriseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GithubEnterpriseConfigName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string githubEnterpriseConfigName, out GithubEnterpriseConfigName result) =>
            TryParse(githubEnterpriseConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GithubEnterpriseConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/githubEnterpriseConfigs/{config}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/githubEnterpriseConfigs/{config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="githubEnterpriseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GithubEnterpriseConfigName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string githubEnterpriseConfigName, bool allowUnparsed, out GithubEnterpriseConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(githubEnterpriseConfigName, nameof(githubEnterpriseConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectConfig.TryParseName(githubEnterpriseConfigName, out resourceName))
            {
                result = FromProjectConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationConfig.TryParseName(githubEnterpriseConfigName, out resourceName))
            {
                result = FromProjectLocationConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(githubEnterpriseConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GithubEnterpriseConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string configId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConfigId = configId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GithubEnterpriseConfigName"/> class from the component parts of
        /// pattern <c>projects/{project}/githubEnterpriseConfigs/{config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="configId">The <c>Config</c> ID. Must not be <c>null</c> or empty.</param>
        public GithubEnterpriseConfigName(string projectId, string configId) : this(ResourceNameType.ProjectConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), configId: gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)))
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
        /// The <c>Config</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ConfigId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectConfig: return s_projectConfig.Expand(ProjectId, ConfigId);
                case ResourceNameType.ProjectLocationConfig: return s_projectLocationConfig.Expand(ProjectId, LocationId, ConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GithubEnterpriseConfigName);

        /// <inheritdoc/>
        public bool Equals(GithubEnterpriseConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GithubEnterpriseConfigName a, GithubEnterpriseConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GithubEnterpriseConfigName a, GithubEnterpriseConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>WorkerPool</c> resource.</summary>
    public sealed partial class WorkerPoolName : gax::IResourceName, sys::IEquatable<WorkerPoolName>
    {
        /// <summary>The possible contents of <see cref="WorkerPoolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
            /// </summary>
            ProjectLocationWorkerPool = 1,
        }

        private static gax::PathTemplate s_projectLocationWorkerPool = new gax::PathTemplate("projects/{project}/locations/{location}/workerPools/{worker_pool}");

        /// <summary>Creates a <see cref="WorkerPoolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkerPoolName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WorkerPoolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkerPoolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkerPoolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workerPoolId">The <c>WorkerPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkerPoolName"/> constructed from the provided ids.</returns>
        public static WorkerPoolName FromProjectLocationWorkerPool(string projectId, string locationId, string workerPoolId) =>
            new WorkerPoolName(ResourceNameType.ProjectLocationWorkerPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workerPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkerPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workerPoolId">The <c>WorkerPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkerPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string workerPoolId) =>
            FormatProjectLocationWorkerPool(projectId, locationId, workerPoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkerPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workerPoolId">The <c>WorkerPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkerPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>.
        /// </returns>
        public static string FormatProjectLocationWorkerPool(string projectId, string locationId, string workerPoolId) =>
            s_projectLocationWorkerPool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)));

        /// <summary>Parses the given resource name string into a new <see cref="WorkerPoolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workerPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkerPoolName"/> if successful.</returns>
        public static WorkerPoolName Parse(string workerPoolName) => Parse(workerPoolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkerPoolName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workerPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkerPoolName"/> if successful.</returns>
        public static WorkerPoolName Parse(string workerPoolName, bool allowUnparsed) =>
            TryParse(workerPoolName, allowUnparsed, out WorkerPoolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkerPoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workerPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkerPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workerPoolName, out WorkerPoolName result) =>
            TryParse(workerPoolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkerPoolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workerPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkerPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workerPoolName, bool allowUnparsed, out WorkerPoolName result)
        {
            gax::GaxPreconditions.CheckNotNull(workerPoolName, nameof(workerPoolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationWorkerPool.TryParseName(workerPoolName, out resourceName))
            {
                result = FromProjectLocationWorkerPool(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workerPoolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkerPoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string workerPoolId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            WorkerPoolId = workerPoolId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkerPoolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/workerPools/{worker_pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workerPoolId">The <c>WorkerPool</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkerPoolName(string projectId, string locationId, string workerPoolId) : this(ResourceNameType.ProjectLocationWorkerPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workerPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)))
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
        /// The <c>WorkerPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WorkerPoolId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationWorkerPool: return s_projectLocationWorkerPool.Expand(ProjectId, LocationId, WorkerPoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkerPoolName);

        /// <inheritdoc/>
        public bool Equals(WorkerPoolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkerPoolName a, WorkerPoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkerPoolName a, WorkerPoolName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Network</c> resource.</summary>
    public sealed partial class NetworkName : gax::IResourceName, sys::IEquatable<NetworkName>
    {
        /// <summary>The possible contents of <see cref="NetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/global/networks/{network}</c>.</summary>
            ProjectNetwork = 1,
        }

        private static gax::PathTemplate s_projectNetwork = new gax::PathTemplate("projects/{project}/global/networks/{network}");

        /// <summary>Creates a <see cref="NetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkName"/> with the pattern <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkName"/> constructed from the provided ids.</returns>
        public static NetworkName FromProjectNetwork(string projectId, string networkId) =>
            new NetworkName(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string Format(string projectId, string networkId) => FormatProjectNetwork(projectId, networkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string FormatProjectNetwork(string projectId, string networkId) =>
            s_projectNetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>Parses the given resource name string into a new <see cref="NetworkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName) => Parse(networkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName, bool allowUnparsed) =>
            TryParse(networkName, allowUnparsed, out NetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, out NetworkName result) => TryParse(networkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, bool allowUnparsed, out NetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkName, nameof(networkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNetwork.TryParseName(networkName, out resourceName))
            {
                result = FromProjectNetwork(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkId = networkId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkName"/> class from the component parts of pattern
        /// <c>projects/{project}/global/networks/{network}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkName(string projectId, string networkId) : this(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)))
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
        /// The <c>Network</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkId { get; }

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
                case ResourceNameType.ProjectNetwork: return s_projectNetwork.Expand(ProjectId, NetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworkName);

        /// <inheritdoc/>
        public bool Equals(NetworkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NetworkName a, NetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NetworkName a, NetworkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ServiceAccount</c> resource.</summary>
    public sealed partial class ServiceAccountName : gax::IResourceName, sys::IEquatable<ServiceAccountName>
    {
        /// <summary>The possible contents of <see cref="ServiceAccountName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/serviceAccounts/{service_account}</c>.
            /// </summary>
            ProjectServiceAccount = 1,
        }

        private static gax::PathTemplate s_projectServiceAccount = new gax::PathTemplate("projects/{project}/serviceAccounts/{service_account}");

        /// <summary>Creates a <see cref="ServiceAccountName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceAccountName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceAccountName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceAccountName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceAccountName"/> with the pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceAccountName"/> constructed from the provided ids.</returns>
        public static ServiceAccountName FromProjectServiceAccount(string projectId, string serviceAccountId) =>
            new ServiceAccountName(ResourceNameType.ProjectServiceAccount, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), serviceAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountId, nameof(serviceAccountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </returns>
        public static string Format(string projectId, string serviceAccountId) =>
            FormatProjectServiceAccount(projectId, serviceAccountId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAccountName"/> with pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>.
        /// </returns>
        public static string FormatProjectServiceAccount(string projectId, string serviceAccountId) =>
            s_projectServiceAccount.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountId, nameof(serviceAccountId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceAccountName"/> if successful.</returns>
        public static ServiceAccountName Parse(string serviceAccountName) => Parse(serviceAccountName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceAccountName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceAccountName"/> if successful.</returns>
        public static ServiceAccountName Parse(string serviceAccountName, bool allowUnparsed) =>
            TryParse(serviceAccountName, allowUnparsed, out ServiceAccountName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAccountName, out ServiceAccountName result) =>
            TryParse(serviceAccountName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAccountName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/serviceAccounts/{service_account}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAccountName, bool allowUnparsed, out ServiceAccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceAccountName, nameof(serviceAccountName));
            gax::TemplatedResourceName resourceName;
            if (s_projectServiceAccount.TryParseName(serviceAccountName, out resourceName))
            {
                result = FromProjectServiceAccount(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceAccountName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceAccountName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string serviceAccountId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            ServiceAccountId = serviceAccountId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceAccountName"/> class from the component parts of pattern
        /// <c>projects/{project}/serviceAccounts/{service_account}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAccountId">The <c>ServiceAccount</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceAccountName(string projectId, string serviceAccountId) : this(ResourceNameType.ProjectServiceAccount, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), serviceAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAccountId, nameof(serviceAccountId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ServiceAccount</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ServiceAccountId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectServiceAccount: return s_projectServiceAccount.Expand(ProjectId, ServiceAccountId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceAccountName);

        /// <inheritdoc/>
        public bool Equals(ServiceAccountName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceAccountName a, ServiceAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceAccountName a, ServiceAccountName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Secret</c> resource.</summary>
    public sealed partial class SecretName : gax::IResourceName, sys::IEquatable<SecretName>
    {
        /// <summary>The possible contents of <see cref="SecretName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/secrets/{secret}</c>.</summary>
            ProjectSecret = 1,
        }

        private static gax::PathTemplate s_projectSecret = new gax::PathTemplate("projects/{project}/secrets/{secret}");

        /// <summary>Creates a <see cref="SecretName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecretName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecretName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecretName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecretName"/> with the pattern <c>projects/{project}/secrets/{secret}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecretName"/> constructed from the provided ids.</returns>
        public static SecretName FromProjectSecret(string projectId, string secretId) =>
            new SecretName(ResourceNameType.ProjectSecret, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}</c>.
        /// </returns>
        public static string Format(string projectId, string secretId) => FormatProjectSecret(projectId, secretId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}</c>.
        /// </returns>
        public static string FormatProjectSecret(string projectId, string secretId) =>
            s_projectSecret.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)));

        /// <summary>Parses the given resource name string into a new <see cref="SecretName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="secretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecretName"/> if successful.</returns>
        public static SecretName Parse(string secretName) => Parse(secretName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecretName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecretName"/> if successful.</returns>
        public static SecretName Parse(string secretName, bool allowUnparsed) =>
            TryParse(secretName, allowUnparsed, out SecretName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="secretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretName, out SecretName result) => TryParse(secretName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretName, bool allowUnparsed, out SecretName result)
        {
            gax::GaxPreconditions.CheckNotNull(secretName, nameof(secretName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSecret.TryParseName(secretName, out resourceName))
            {
                result = FromProjectSecret(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(secretName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecretName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string secretId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SecretId = secretId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecretName"/> class from the component parts of pattern
        /// <c>projects/{project}/secrets/{secret}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        public SecretName(string projectId, string secretId) : this(ResourceNameType.ProjectSecret, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Secret</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SecretId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSecret: return s_projectSecret.Expand(ProjectId, SecretId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecretName);

        /// <inheritdoc/>
        public bool Equals(SecretName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecretName a, SecretName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecretName a, SecretName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SecretVersion</c> resource.</summary>
    public sealed partial class SecretVersionName : gax::IResourceName, sys::IEquatable<SecretVersionName>
    {
        /// <summary>The possible contents of <see cref="SecretVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
            /// </summary>
            ProjectSecretVersion = 1,
        }

        private static gax::PathTemplate s_projectSecretVersion = new gax::PathTemplate("projects/{project}/secrets/{secret}/versions/{version}");

        /// <summary>Creates a <see cref="SecretVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecretVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecretVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecretVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecretVersionName"/> with the pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SecretVersionName"/> constructed from the provided ids.</returns>
        public static SecretVersionName FromProjectSecretVersion(string projectId, string secretId, string versionId) =>
            new SecretVersionName(ResourceNameType.ProjectSecretVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </returns>
        public static string Format(string projectId, string secretId, string versionId) =>
            FormatProjectSecretVersion(projectId, secretId, versionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecretVersionName"/> with pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>.
        /// </returns>
        public static string FormatProjectSecretVersion(string projectId, string secretId, string versionId) =>
            s_projectSecretVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecretVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecretVersionName"/> if successful.</returns>
        public static SecretVersionName Parse(string secretVersionName) => Parse(secretVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecretVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecretVersionName"/> if successful.</returns>
        public static SecretVersionName Parse(string secretVersionName, bool allowUnparsed) =>
            TryParse(secretVersionName, allowUnparsed, out SecretVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretVersionName, out SecretVersionName result) =>
            TryParse(secretVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecretVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/secrets/{secret}/versions/{version}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="secretVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecretVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string secretVersionName, bool allowUnparsed, out SecretVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(secretVersionName, nameof(secretVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSecretVersion.TryParseName(secretVersionName, out resourceName))
            {
                result = FromProjectSecretVersion(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(secretVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecretVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string secretId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SecretId = secretId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecretVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/secrets/{secret}/versions/{version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="secretId">The <c>Secret</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        public SecretVersionName(string projectId, string secretId, string versionId) : this(ResourceNameType.ProjectSecretVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), secretId: gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Secret</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SecretId { get; }

        /// <summary>
        /// The <c>Version</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
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
                case ResourceNameType.ProjectSecretVersion: return s_projectSecretVersion.Expand(ProjectId, SecretId, VersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecretVersionName);

        /// <inheritdoc/>
        public bool Equals(SecretVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecretVersionName a, SecretVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecretVersionName a, SecretVersionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Membership</c> resource.</summary>
    public sealed partial class MembershipName : gax::IResourceName, sys::IEquatable<MembershipName>
    {
        /// <summary>The possible contents of <see cref="MembershipName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/memberships/{cluster_name}</c>.
            /// </summary>
            ProjectLocationClusterName = 1,
        }

        private static gax::PathTemplate s_projectLocationClusterName = new gax::PathTemplate("projects/{project}/locations/{location}/memberships/{cluster_name}");

        /// <summary>Creates a <see cref="MembershipName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MembershipName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MembershipName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MembershipName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MembershipName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/memberships/{cluster_name}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterNameId">The <c>ClusterName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MembershipName"/> constructed from the provided ids.</returns>
        public static MembershipName FromProjectLocationClusterName(string projectId, string locationId, string clusterNameId) =>
            new MembershipName(ResourceNameType.ProjectLocationClusterName, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterNameId, nameof(clusterNameId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{cluster_name}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterNameId">The <c>ClusterName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{cluster_name}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clusterNameId) =>
            FormatProjectLocationClusterName(projectId, locationId, clusterNameId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{cluster_name}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterNameId">The <c>ClusterName</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{cluster_name}</c>.
        /// </returns>
        public static string FormatProjectLocationClusterName(string projectId, string locationId, string clusterNameId) =>
            s_projectLocationClusterName.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterNameId, nameof(clusterNameId)));

        /// <summary>Parses the given resource name string into a new <see cref="MembershipName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{cluster_name}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MembershipName"/> if successful.</returns>
        public static MembershipName Parse(string membershipName) => Parse(membershipName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MembershipName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{cluster_name}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MembershipName"/> if successful.</returns>
        public static MembershipName Parse(string membershipName, bool allowUnparsed) =>
            TryParse(membershipName, allowUnparsed, out MembershipName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MembershipName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{cluster_name}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MembershipName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string membershipName, out MembershipName result) =>
            TryParse(membershipName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MembershipName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{cluster_name}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MembershipName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string membershipName, bool allowUnparsed, out MembershipName result)
        {
            gax::GaxPreconditions.CheckNotNull(membershipName, nameof(membershipName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationClusterName.TryParseName(membershipName, out resourceName))
            {
                result = FromProjectLocationClusterName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(membershipName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MembershipName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterNameId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterNameId = clusterNameId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MembershipName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/memberships/{cluster_name}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterNameId">The <c>ClusterName</c> ID. Must not be <c>null</c> or empty.</param>
        public MembershipName(string projectId, string locationId, string clusterNameId) : this(ResourceNameType.ProjectLocationClusterName, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterNameId, nameof(clusterNameId)))
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
        /// The <c>ClusterName</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClusterNameId { get; }

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
                case ResourceNameType.ProjectLocationClusterName: return s_projectLocationClusterName.Expand(ProjectId, LocationId, ClusterNameId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MembershipName);

        /// <inheritdoc/>
        public bool Equals(MembershipName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MembershipName a, MembershipName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MembershipName a, MembershipName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CryptoKey</c> resource.</summary>
    public sealed partial class CryptoKeyName : gax::IResourceName, sys::IEquatable<CryptoKeyName>
    {
        /// <summary>The possible contents of <see cref="CryptoKeyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}</c>.
            /// </summary>
            ProjectLocationKeyringKey = 1,
        }

        private static gax::PathTemplate s_projectLocationKeyringKey = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}");

        /// <summary>Creates a <see cref="CryptoKeyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CryptoKeyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CryptoKeyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CryptoKeyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CryptoKeyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyringId">The <c>Keyring</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CryptoKeyName"/> constructed from the provided ids.</returns>
        public static CryptoKeyName FromProjectLocationKeyringKey(string projectId, string locationId, string keyringId, string keyId) =>
            new CryptoKeyName(ResourceNameType.ProjectLocationKeyringKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyringId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyringId, nameof(keyringId)), keyId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyId, nameof(keyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyringId">The <c>Keyring</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string keyringId, string keyId) =>
            FormatProjectLocationKeyringKey(projectId, locationId, keyringId, keyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyringId">The <c>Keyring</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}</c>.
        /// </returns>
        public static string FormatProjectLocationKeyringKey(string projectId, string locationId, string keyringId, string keyId) =>
            s_projectLocationKeyringKey.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyringId, nameof(keyringId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyId, nameof(keyId)));

        /// <summary>Parses the given resource name string into a new <see cref="CryptoKeyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cryptoKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CryptoKeyName"/> if successful.</returns>
        public static CryptoKeyName Parse(string cryptoKeyName) => Parse(cryptoKeyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CryptoKeyName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cryptoKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CryptoKeyName"/> if successful.</returns>
        public static CryptoKeyName Parse(string cryptoKeyName, bool allowUnparsed) =>
            TryParse(cryptoKeyName, allowUnparsed, out CryptoKeyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CryptoKeyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cryptoKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CryptoKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeyName, out CryptoKeyName result) => TryParse(cryptoKeyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CryptoKeyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cryptoKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CryptoKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeyName, bool allowUnparsed, out CryptoKeyName result)
        {
            gax::GaxPreconditions.CheckNotNull(cryptoKeyName, nameof(cryptoKeyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationKeyringKey.TryParseName(cryptoKeyName, out resourceName))
            {
                result = FromProjectLocationKeyringKey(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cryptoKeyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CryptoKeyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string keyId = null, string keyringId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            KeyId = keyId;
            KeyringId = keyringId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CryptoKeyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{keyring}/cryptoKeys/{key}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyringId">The <c>Keyring</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyId">The <c>Key</c> ID. Must not be <c>null</c> or empty.</param>
        public CryptoKeyName(string projectId, string locationId, string keyringId, string keyId) : this(ResourceNameType.ProjectLocationKeyringKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyringId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyringId, nameof(keyringId)), keyId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyId, nameof(keyId)))
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
        /// The <c>Key</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeyId { get; }

        /// <summary>
        /// The <c>Keyring</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeyringId { get; }

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
                case ResourceNameType.ProjectLocationKeyringKey: return s_projectLocationKeyringKey.Expand(ProjectId, LocationId, KeyringId, KeyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CryptoKeyName);

        /// <inheritdoc/>
        public bool Equals(CryptoKeyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CryptoKeyName a, CryptoKeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CryptoKeyName a, CryptoKeyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Subscription</c> resource.</summary>
    public sealed partial class SubscriptionName : gax::IResourceName, sys::IEquatable<SubscriptionName>
    {
        /// <summary>The possible contents of <see cref="SubscriptionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/subscriptions/{subscription}</c>.</summary>
            ProjectSubscription = 1,
        }

        private static gax::PathTemplate s_projectSubscription = new gax::PathTemplate("projects/{project}/subscriptions/{subscription}");

        /// <summary>Creates a <see cref="SubscriptionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SubscriptionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SubscriptionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SubscriptionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SubscriptionName"/> with the pattern <c>projects/{project}/subscriptions/{subscription}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SubscriptionName"/> constructed from the provided ids.</returns>
        public static SubscriptionName FromProjectSubscription(string projectId, string subscriptionId) =>
            new SubscriptionName(ResourceNameType.ProjectSubscription, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), subscriptionId: gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/subscriptions/{subscription}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/subscriptions/{subscription}</c>.
        /// </returns>
        public static string Format(string projectId, string subscriptionId) =>
            FormatProjectSubscription(projectId, subscriptionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/subscriptions/{subscription}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubscriptionName"/> with pattern
        /// <c>projects/{project}/subscriptions/{subscription}</c>.
        /// </returns>
        public static string FormatProjectSubscription(string projectId, string subscriptionId) =>
            s_projectSubscription.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)));

        /// <summary>Parses the given resource name string into a new <see cref="SubscriptionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscriptions/{subscription}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubscriptionName"/> if successful.</returns>
        public static SubscriptionName Parse(string subscriptionName) => Parse(subscriptionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SubscriptionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscriptions/{subscription}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SubscriptionName"/> if successful.</returns>
        public static SubscriptionName Parse(string subscriptionName, bool allowUnparsed) =>
            TryParse(subscriptionName, allowUnparsed, out SubscriptionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubscriptionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscriptions/{subscription}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubscriptionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subscriptionName, out SubscriptionName result) =>
            TryParse(subscriptionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubscriptionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/subscriptions/{subscription}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subscriptionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubscriptionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subscriptionName, bool allowUnparsed, out SubscriptionName result)
        {
            gax::GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectSubscription.TryParseName(subscriptionName, out resourceName))
            {
                result = FromProjectSubscription(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(subscriptionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SubscriptionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string subscriptionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SubscriptionName"/> class from the component parts of pattern
        /// <c>projects/{project}/subscriptions/{subscription}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subscriptionId">The <c>Subscription</c> ID. Must not be <c>null</c> or empty.</param>
        public SubscriptionName(string projectId, string subscriptionId) : this(ResourceNameType.ProjectSubscription, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), subscriptionId: gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Subscription</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SubscriptionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectSubscription: return s_projectSubscription.Expand(ProjectId, SubscriptionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SubscriptionName);

        /// <inheritdoc/>
        public bool Equals(SubscriptionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SubscriptionName a, SubscriptionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SubscriptionName a, SubscriptionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Topic</c> resource.</summary>
    public sealed partial class TopicName : gax::IResourceName, sys::IEquatable<TopicName>
    {
        /// <summary>The possible contents of <see cref="TopicName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/topics/{topic}</c>.</summary>
            ProjectTopic = 1,
        }

        private static gax::PathTemplate s_projectTopic = new gax::PathTemplate("projects/{project}/topics/{topic}");

        /// <summary>Creates a <see cref="TopicName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TopicName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TopicName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TopicName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TopicName"/> with the pattern <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TopicName"/> constructed from the provided ids.</returns>
        public static TopicName FromProjectTopic(string projectId, string topicId) =>
            new TopicName(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string topicId) => FormatProjectTopic(projectId, topicId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicName"/> with pattern
        /// <c>projects/{project}/topics/{topic}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicName"/> with pattern <c>projects/{project}/topics/{topic}</c>
        /// .
        /// </returns>
        public static string FormatProjectTopic(string projectId, string topicId) =>
            s_projectTopic.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)));

        /// <summary>Parses the given resource name string into a new <see cref="TopicName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName) => Parse(topicName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TopicName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName, bool allowUnparsed) =>
            TryParse(topicName, allowUnparsed, out TopicName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, out TopicName result) => TryParse(topicName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}/topics/{topic}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, bool allowUnparsed, out TopicName result)
        {
            gax::GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            gax::TemplatedResourceName resourceName;
            if (s_projectTopic.TryParseName(topicName, out resourceName))
            {
                result = FromProjectTopic(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(topicName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TopicName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string topicId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            TopicId = topicId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TopicName"/> class from the component parts of pattern
        /// <c>projects/{project}/topics/{topic}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c> or empty.</param>
        public TopicName(string projectId, string topicId) : this(ResourceNameType.ProjectTopic, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), topicId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Topic</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TopicId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectTopic: return s_projectTopic.Expand(ProjectId, TopicId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TopicName);

        /// <inheritdoc/>
        public bool Equals(TopicName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TopicName a, TopicName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TopicName a, TopicName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Repository</c> resource.</summary>
    public sealed partial class RepositoryName : gax::IResourceName, sys::IEquatable<RepositoryName>
    {
        /// <summary>The possible contents of <see cref="RepositoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
            /// </summary>
            ProjectLocationConnectionRepository = 1,
        }

        private static gax::PathTemplate s_projectLocationConnectionRepository = new gax::PathTemplate("projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}");

        /// <summary>Creates a <see cref="RepositoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RepositoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RepositoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RepositoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RepositoryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RepositoryName"/> constructed from the provided ids.</returns>
        public static RepositoryName FromProjectLocationConnectionRepository(string projectId, string locationId, string connectionId, string repositoryId) =>
            new RepositoryName(ResourceNameType.ProjectLocationConnectionRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string connectionId, string repositoryId) =>
            FormatProjectLocationConnectionRepository(projectId, locationId, connectionId, repositoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>.
        /// </returns>
        public static string FormatProjectLocationConnectionRepository(string projectId, string locationId, string connectionId, string repositoryId) =>
            s_projectLocationConnectionRepository.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>Parses the given resource name string into a new <see cref="RepositoryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RepositoryName"/> if successful.</returns>
        public static RepositoryName Parse(string repositoryName) => Parse(repositoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RepositoryName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RepositoryName"/> if successful.</returns>
        public static RepositoryName Parse(string repositoryName, bool allowUnparsed) =>
            TryParse(repositoryName, allowUnparsed, out RepositoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RepositoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RepositoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string repositoryName, out RepositoryName result) =>
            TryParse(repositoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RepositoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="repositoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RepositoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string repositoryName, bool allowUnparsed, out RepositoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(repositoryName, nameof(repositoryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConnectionRepository.TryParseName(repositoryName, out resourceName))
            {
                result = FromProjectLocationConnectionRepository(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(repositoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RepositoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string connectionId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConnectionId = connectionId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RepositoryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        public RepositoryName(string projectId, string locationId, string connectionId, string repositoryId) : this(ResourceNameType.ProjectLocationConnectionRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)))
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
        /// The <c>Connection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ConnectionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Repository</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RepositoryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationConnectionRepository: return s_projectLocationConnectionRepository.Expand(ProjectId, LocationId, ConnectionId, RepositoryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RepositoryName);

        /// <inheritdoc/>
        public bool Equals(RepositoryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RepositoryName a, RepositoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RepositoryName a, RepositoryName b) => !(a == b);
    }

    public partial class RetryBuildRequest
    {
        /// <summary>
        /// <see cref="gccv::BuildName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::BuildName BuildName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::BuildName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RunBuildTriggerRequest
    {
        /// <summary>
        /// <see cref="gccv::BuildTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::BuildTriggerName BuildTriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::BuildTriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Build
    {
        /// <summary>
        /// <see cref="ServiceAccountName"/>-typed view over the <see cref="ServiceAccount"/> resource name property.
        /// </summary>
        public ServiceAccountName ServiceAccountAsServiceAccountName
        {
            get => string.IsNullOrEmpty(ServiceAccount) ? null : ServiceAccountName.Parse(ServiceAccount, allowUnparsed: true);
            set => ServiceAccount = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gccv::BuildName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::BuildName BuildName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::BuildName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InlineSecret
    {
        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="KmsKeyName"/> resource name property.
        /// </summary>
        public CryptoKeyName KmsKeyNameAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(KmsKeyName) ? null : CryptoKeyName.Parse(KmsKeyName, allowUnparsed: true);
            set => KmsKeyName = value?.ToString() ?? "";
        }
    }

    public partial class SecretManagerSecret
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="VersionName"/> resource name property.
        /// </summary>
        public SecretVersionName VersionNameAsSecretVersionName
        {
            get => string.IsNullOrEmpty(VersionName) ? null : SecretVersionName.Parse(VersionName, allowUnparsed: true);
            set => VersionName = value?.ToString() ?? "";
        }
    }

    public partial class CreateBuildRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBuildRequest
    {
        /// <summary>
        /// <see cref="gccv::BuildName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::BuildName BuildName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::BuildName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBuildsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CancelBuildRequest
    {
        /// <summary>
        /// <see cref="gccv::BuildName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::BuildName BuildName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::BuildName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GitRepoSource
    {
        /// <summary>
        /// <see cref="GithubEnterpriseConfigName"/>-typed view over the <see cref="GithubEnterpriseConfig"/> resource
        /// name property.
        /// </summary>
        public GithubEnterpriseConfigName GithubEnterpriseConfigAsGithubEnterpriseConfigName
        {
            get => string.IsNullOrEmpty(GithubEnterpriseConfig) ? null : GithubEnterpriseConfigName.Parse(GithubEnterpriseConfig, allowUnparsed: true);
            set => GithubEnterpriseConfig = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Repository"/> resource name property.
        /// </summary>
        public RepositoryName RepositoryAsRepositoryName
        {
            get => string.IsNullOrEmpty(Repository) ? null : RepositoryName.Parse(Repository, allowUnparsed: true);
            set => Repository = value?.ToString() ?? "";
        }
    }

    public partial class GitFileSource
    {
        /// <summary>
        /// <see cref="GithubEnterpriseConfigName"/>-typed view over the <see cref="GithubEnterpriseConfig"/> resource
        /// name property.
        /// </summary>
        public GithubEnterpriseConfigName GithubEnterpriseConfigAsGithubEnterpriseConfigName
        {
            get => string.IsNullOrEmpty(GithubEnterpriseConfig) ? null : GithubEnterpriseConfigName.Parse(GithubEnterpriseConfig, allowUnparsed: true);
            set => GithubEnterpriseConfig = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Repository"/> resource name property.
        /// </summary>
        public RepositoryName RepositoryAsRepositoryName
        {
            get => string.IsNullOrEmpty(Repository) ? null : RepositoryName.Parse(Repository, allowUnparsed: true);
            set => Repository = value?.ToString() ?? "";
        }
    }

    public partial class BuildTrigger
    {
        /// <summary>
        /// <see cref="gccv::BuildTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::BuildTriggerName BuildTriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::BuildTriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ServiceAccountName"/>-typed view over the <see cref="ServiceAccount"/> resource name property.
        /// </summary>
        public ServiceAccountName ServiceAccountAsServiceAccountName
        {
            get => string.IsNullOrEmpty(ServiceAccount) ? null : ServiceAccountName.Parse(ServiceAccount, allowUnparsed: true);
            set => ServiceAccount = value?.ToString() ?? "";
        }
    }

    public partial class RepositoryEventConfig
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Repository"/> resource name property.
        /// </summary>
        public RepositoryName RepositoryAsRepositoryName
        {
            get => string.IsNullOrEmpty(Repository) ? null : RepositoryName.Parse(Repository, allowUnparsed: true);
            set => Repository = value?.ToString() ?? "";
        }
    }

    public partial class PubsubConfig
    {
        /// <summary>
        /// <see cref="SubscriptionName"/>-typed view over the <see cref="Subscription"/> resource name property.
        /// </summary>
        public SubscriptionName SubscriptionAsSubscriptionName
        {
            get => string.IsNullOrEmpty(Subscription) ? null : SubscriptionName.Parse(Subscription, allowUnparsed: true);
            set => Subscription = value?.ToString() ?? "";
        }

        /// <summary><see cref="TopicName"/>-typed view over the <see cref="Topic"/> resource name property.</summary>
        public TopicName TopicAsTopicName
        {
            get => string.IsNullOrEmpty(Topic) ? null : TopicName.Parse(Topic, allowUnparsed: true);
            set => Topic = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ServiceAccountName"/>-typed view over the <see cref="ServiceAccountEmail"/> resource name
        /// property.
        /// </summary>
        public ServiceAccountName ServiceAccountEmailAsServiceAccountName
        {
            get => string.IsNullOrEmpty(ServiceAccountEmail) ? null : ServiceAccountName.Parse(ServiceAccountEmail, allowUnparsed: true);
            set => ServiceAccountEmail = value?.ToString() ?? "";
        }
    }

    public partial class WebhookConfig
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="Secret"/> resource name property.
        /// </summary>
        public SecretVersionName SecretAsSecretVersionName
        {
            get => string.IsNullOrEmpty(Secret) ? null : SecretVersionName.Parse(Secret, allowUnparsed: true);
            set => Secret = value?.ToString() ?? "";
        }
    }

    public partial class CreateBuildTriggerRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetBuildTriggerRequest
    {
        /// <summary>
        /// <see cref="gccv::BuildTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::BuildTriggerName BuildTriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::BuildTriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBuildTriggersRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBuildTriggerRequest
    {
        /// <summary>
        /// <see cref="gccv::BuildTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::BuildTriggerName BuildTriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::BuildTriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BuildOptions
    {
        public partial class Types
        {
            public partial class PoolOption
            {
                /// <summary>
                /// <see cref="gccv::WorkerPoolName"/>-typed view over the <see cref="Name"/> resource name property.
                /// </summary>
                public gccv::WorkerPoolName WorkerPoolName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gccv::WorkerPoolName.Parse(Name, allowUnparsed: true);
                    set => Name = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class GitHubEnterpriseConfig
    {
        /// <summary>
        /// <see cref="gccv::GithubEnterpriseConfigName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::GithubEnterpriseConfigName GithubEnterpriseConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::GithubEnterpriseConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="PeeredNetwork"/> resource name property.
        /// </summary>
        public NetworkName PeeredNetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(PeeredNetwork) ? null : NetworkName.Parse(PeeredNetwork, allowUnparsed: true);
            set => PeeredNetwork = value?.ToString() ?? "";
        }
    }

    public partial class GitHubEnterpriseSecrets
    {
        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PrivateKeyVersionName"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PrivateKeyVersionNameAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PrivateKeyVersionName) ? null : SecretVersionName.Parse(PrivateKeyVersionName, allowUnparsed: true);
            set => PrivateKeyVersionName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="WebhookSecretVersionName"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName WebhookSecretVersionNameAsSecretVersionName
        {
            get => string.IsNullOrEmpty(WebhookSecretVersionName) ? null : SecretVersionName.Parse(WebhookSecretVersionName, allowUnparsed: true);
            set => WebhookSecretVersionName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="OauthSecretVersionName"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName OauthSecretVersionNameAsSecretVersionName
        {
            get => string.IsNullOrEmpty(OauthSecretVersionName) ? null : SecretVersionName.Parse(OauthSecretVersionName, allowUnparsed: true);
            set => OauthSecretVersionName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="OauthClientIdVersionName"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName OauthClientIdVersionNameAsSecretVersionName
        {
            get => string.IsNullOrEmpty(OauthClientIdVersionName) ? null : SecretVersionName.Parse(OauthClientIdVersionName, allowUnparsed: true);
            set => OauthClientIdVersionName = value?.ToString() ?? "";
        }
    }

    public partial class WorkerPool
    {
        /// <summary>
        /// <see cref="gccv::WorkerPoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::WorkerPoolName WorkerPoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::WorkerPoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PrivatePoolV1Config
    {
        public partial class Types
        {
            public partial class NetworkConfig
            {
                /// <summary>
                /// <see cref="NetworkName"/>-typed view over the <see cref="PeeredNetwork"/> resource name property.
                /// </summary>
                public NetworkName PeeredNetworkAsNetworkName
                {
                    get => string.IsNullOrEmpty(PeeredNetwork) ? null : NetworkName.Parse(PeeredNetwork, allowUnparsed: true);
                    set => PeeredNetwork = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class CreateWorkerPoolRequest
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

    public partial class GetWorkerPoolRequest
    {
        /// <summary>
        /// <see cref="gccv::WorkerPoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::WorkerPoolName WorkerPoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::WorkerPoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWorkerPoolRequest
    {
        /// <summary>
        /// <see cref="gccv::WorkerPoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::WorkerPoolName WorkerPoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::WorkerPoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkerPoolsRequest
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

    public partial class CreateWorkerPoolOperationMetadata
    {
        /// <summary>
        /// <see cref="WorkerPoolName"/>-typed view over the <see cref="WorkerPool"/> resource name property.
        /// </summary>
        public WorkerPoolName WorkerPoolAsWorkerPoolName
        {
            get => string.IsNullOrEmpty(WorkerPool) ? null : WorkerPoolName.Parse(WorkerPool, allowUnparsed: true);
            set => WorkerPool = value?.ToString() ?? "";
        }
    }

    public partial class UpdateWorkerPoolOperationMetadata
    {
        /// <summary>
        /// <see cref="WorkerPoolName"/>-typed view over the <see cref="WorkerPool"/> resource name property.
        /// </summary>
        public WorkerPoolName WorkerPoolAsWorkerPoolName
        {
            get => string.IsNullOrEmpty(WorkerPool) ? null : WorkerPoolName.Parse(WorkerPool, allowUnparsed: true);
            set => WorkerPool = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWorkerPoolOperationMetadata
    {
        /// <summary>
        /// <see cref="WorkerPoolName"/>-typed view over the <see cref="WorkerPool"/> resource name property.
        /// </summary>
        public WorkerPoolName WorkerPoolAsWorkerPoolName
        {
            get => string.IsNullOrEmpty(WorkerPool) ? null : WorkerPoolName.Parse(WorkerPool, allowUnparsed: true);
            set => WorkerPool = value?.ToString() ?? "";
        }
    }
}
