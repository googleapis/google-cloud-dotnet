// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gagr = Google.Api.Gax.ResourceNames;
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

        /// <inheritdoc/>
        public static bool operator ==(BuildName a, BuildName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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
        }

        private static gax::PathTemplate s_projectTrigger = new gax::PathTemplate("projects/{project}/triggers/{trigger}");

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

        /// <summary>Parses the given resource name string into a new <see cref="BuildTriggerName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/triggers/{trigger}</c></description></item>
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

        private BuildTriggerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string triggerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Trigger</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
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
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BuildTriggerName);

        /// <inheritdoc/>
        public bool Equals(BuildTriggerName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(BuildTriggerName a, BuildTriggerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(BuildTriggerName a, BuildTriggerName b) => !(a == b);
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

        /// <inheritdoc/>
        public static bool operator ==(NetworkName a, NetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public static bool operator ==(ServiceAccountName a, ServiceAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ServiceAccountName a, ServiceAccountName b) => !(a == b);
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
    }
}
