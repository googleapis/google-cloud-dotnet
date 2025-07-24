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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcsv = Google.Cloud.SecureSourceManager.V1;
using sys = System;

namespace Google.Cloud.SecureSourceManager.V1
{
    /// <summary>Resource name for the <c>Instance</c> resource.</summary>
    public sealed partial class InstanceName : gax::IResourceName, sys::IEquatable<InstanceName>
    {
        /// <summary>The possible contents of <see cref="InstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/instances/{instance}</c>.
            /// </summary>
            ProjectLocationInstance = 1,
        }

        private static gax::PathTemplate s_projectLocationInstance = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}");

        /// <summary>Creates a <see cref="InstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static InstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstanceName"/> constructed from the provided ids.</returns>
        public static InstanceName FromProjectLocationInstance(string projectId, string locationId, string instanceId) =>
            new InstanceName(ResourceNameType.ProjectLocationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId) =>
            FormatProjectLocationInstance(projectId, locationId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>.
        /// </returns>
        public static string FormatProjectLocationInstance(string projectId, string locationId, string instanceId) =>
            s_projectLocationInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>Parses the given resource name string into a new <see cref="InstanceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName) => Parse(instanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName, bool allowUnparsed) =>
            TryParse(instanceName, allowUnparsed, out InstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, out InstanceName result) => TryParse(instanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, bool allowUnparsed, out InstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstance.TryParseName(instanceName, out resourceName))
            {
                result = FromProjectLocationInstance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceName(string projectId, string locationId, string instanceId) : this(ResourceNameType.ProjectLocationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstance: return s_projectLocationInstance.Expand(ProjectId, LocationId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceName);

        /// <inheritdoc/>
        public bool Equals(InstanceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InstanceName a, InstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InstanceName a, InstanceName b) => !(a == b);
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
            /// A resource name with pattern <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
            /// </summary>
            ProjectLocationRepository = 1,
        }

        private static gax::PathTemplate s_projectLocationRepository = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}");

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
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RepositoryName"/> constructed from the provided ids.</returns>
        public static RepositoryName FromProjectLocationRepository(string projectId, string locationId, string repositoryId) =>
            new RepositoryName(ResourceNameType.ProjectLocationRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId) =>
            FormatProjectLocationRepository(projectId, locationId, repositoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RepositoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>.
        /// </returns>
        public static string FormatProjectLocationRepository(string projectId, string locationId, string repositoryId) =>
            s_projectLocationRepository.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)));

        /// <summary>Parses the given resource name string into a new <see cref="RepositoryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/repositories/{repository}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/repositories/{repository}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/repositories/{repository}</c></description>
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
        /// <description><c>projects/{project}/locations/{location}/repositories/{repository}</c></description>
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
            if (s_projectLocationRepository.TryParseName(repositoryName, out resourceName))
            {
                result = FromProjectLocationRepository(resourceName[0], resourceName[1], resourceName[2]);
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

        private RepositoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RepositoryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        public RepositoryName(string projectId, string locationId, string repositoryId) : this(ResourceNameType.ProjectLocationRepository, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)))
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
                case ResourceNameType.ProjectLocationRepository: return s_projectLocationRepository.Expand(ProjectId, LocationId, RepositoryId);
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

    /// <summary>Resource name for the <c>Hook</c> resource.</summary>
    public sealed partial class HookName : gax::IResourceName, sys::IEquatable<HookName>
    {
        /// <summary>The possible contents of <see cref="HookName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}</c>.
            /// </summary>
            ProjectLocationRepositoryHook = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryHook = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}");

        /// <summary>Creates a <see cref="HookName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HookName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HookName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HookName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HookName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hookId">The <c>Hook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="HookName"/> constructed from the provided ids.</returns>
        public static HookName FromProjectLocationRepositoryHook(string projectId, string locationId, string repositoryId, string hookId) =>
            new HookName(ResourceNameType.ProjectLocationRepositoryHook, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), hookId: gax::GaxPreconditions.CheckNotNullOrEmpty(hookId, nameof(hookId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hookId">The <c>Hook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string hookId) =>
            FormatProjectLocationRepositoryHook(projectId, locationId, repositoryId, hookId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hookId">The <c>Hook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryHook(string projectId, string locationId, string repositoryId, string hookId) =>
            s_projectLocationRepositoryHook.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(hookId, nameof(hookId)));

        /// <summary>Parses the given resource name string into a new <see cref="HookName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HookName"/> if successful.</returns>
        public static HookName Parse(string hookName) => Parse(hookName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HookName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HookName"/> if successful.</returns>
        public static HookName Parse(string hookName, bool allowUnparsed) =>
            TryParse(hookName, allowUnparsed, out HookName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="HookName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HookName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hookName, out HookName result) => TryParse(hookName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HookName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HookName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hookName, bool allowUnparsed, out HookName result)
        {
            gax::GaxPreconditions.CheckNotNull(hookName, nameof(hookName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryHook.TryParseName(hookName, out resourceName))
            {
                result = FromProjectLocationRepositoryHook(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(hookName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HookName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string hookId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            HookId = hookId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HookName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/hooks/{hook}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hookId">The <c>Hook</c> ID. Must not be <c>null</c> or empty.</param>
        public HookName(string projectId, string locationId, string repositoryId, string hookId) : this(ResourceNameType.ProjectLocationRepositoryHook, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), hookId: gax::GaxPreconditions.CheckNotNullOrEmpty(hookId, nameof(hookId)))
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
        /// The <c>Hook</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string HookId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryHook: return s_projectLocationRepositoryHook.Expand(ProjectId, LocationId, RepositoryId, HookId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HookName);

        /// <inheritdoc/>
        public bool Equals(HookName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(HookName a, HookName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(HookName a, HookName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>BranchRule</c> resource.</summary>
    public sealed partial class BranchRuleName : gax::IResourceName, sys::IEquatable<BranchRuleName>
    {
        /// <summary>The possible contents of <see cref="BranchRuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}</c>.
            /// </summary>
            ProjectLocationRepositoryBranchRule = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryBranchRule = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}");

        /// <summary>Creates a <see cref="BranchRuleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BranchRuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BranchRuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BranchRuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BranchRuleName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchRuleId">The <c>BranchRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BranchRuleName"/> constructed from the provided ids.</returns>
        public static BranchRuleName FromProjectLocationRepositoryBranchRule(string projectId, string locationId, string repositoryId, string branchRuleId) =>
            new BranchRuleName(ResourceNameType.ProjectLocationRepositoryBranchRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), branchRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(branchRuleId, nameof(branchRuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BranchRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchRuleId">The <c>BranchRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BranchRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string branchRuleId) =>
            FormatProjectLocationRepositoryBranchRule(projectId, locationId, repositoryId, branchRuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BranchRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchRuleId">The <c>BranchRule</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BranchRuleName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryBranchRule(string projectId, string locationId, string repositoryId, string branchRuleId) =>
            s_projectLocationRepositoryBranchRule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(branchRuleId, nameof(branchRuleId)));

        /// <summary>Parses the given resource name string into a new <see cref="BranchRuleName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="branchRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BranchRuleName"/> if successful.</returns>
        public static BranchRuleName Parse(string branchRuleName) => Parse(branchRuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BranchRuleName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="branchRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BranchRuleName"/> if successful.</returns>
        public static BranchRuleName Parse(string branchRuleName, bool allowUnparsed) =>
            TryParse(branchRuleName, allowUnparsed, out BranchRuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BranchRuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="branchRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BranchRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string branchRuleName, out BranchRuleName result) =>
            TryParse(branchRuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BranchRuleName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="branchRuleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BranchRuleName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string branchRuleName, bool allowUnparsed, out BranchRuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(branchRuleName, nameof(branchRuleName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryBranchRule.TryParseName(branchRuleName, out resourceName))
            {
                result = FromProjectLocationRepositoryBranchRule(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(branchRuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BranchRuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string branchRuleId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BranchRuleId = branchRuleId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BranchRuleName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/branchRules/{branch_rule}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchRuleId">The <c>BranchRule</c> ID. Must not be <c>null</c> or empty.</param>
        public BranchRuleName(string projectId, string locationId, string repositoryId, string branchRuleId) : this(ResourceNameType.ProjectLocationRepositoryBranchRule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), branchRuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(branchRuleId, nameof(branchRuleId)))
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
        /// The <c>BranchRule</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BranchRuleId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryBranchRule: return s_projectLocationRepositoryBranchRule.Expand(ProjectId, LocationId, RepositoryId, BranchRuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BranchRuleName);

        /// <inheritdoc/>
        public bool Equals(BranchRuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BranchRuleName a, BranchRuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BranchRuleName a, BranchRuleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PullRequest</c> resource.</summary>
    public sealed partial class PullRequestName : gax::IResourceName, sys::IEquatable<PullRequestName>
    {
        /// <summary>The possible contents of <see cref="PullRequestName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}</c>.
            /// </summary>
            ProjectLocationRepositoryPullRequest = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryPullRequest = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}");

        /// <summary>Creates a <see cref="PullRequestName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PullRequestName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PullRequestName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PullRequestName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PullRequestName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pullRequestId">The <c>PullRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PullRequestName"/> constructed from the provided ids.</returns>
        public static PullRequestName FromProjectLocationRepositoryPullRequest(string projectId, string locationId, string repositoryId, string pullRequestId) =>
            new PullRequestName(ResourceNameType.ProjectLocationRepositoryPullRequest, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), pullRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(pullRequestId, nameof(pullRequestId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PullRequestName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pullRequestId">The <c>PullRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PullRequestName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string pullRequestId) =>
            FormatProjectLocationRepositoryPullRequest(projectId, locationId, repositoryId, pullRequestId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PullRequestName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pullRequestId">The <c>PullRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PullRequestName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryPullRequest(string projectId, string locationId, string repositoryId, string pullRequestId) =>
            s_projectLocationRepositoryPullRequest.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(pullRequestId, nameof(pullRequestId)));

        /// <summary>Parses the given resource name string into a new <see cref="PullRequestName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pullRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PullRequestName"/> if successful.</returns>
        public static PullRequestName Parse(string pullRequestName) => Parse(pullRequestName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PullRequestName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pullRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PullRequestName"/> if successful.</returns>
        public static PullRequestName Parse(string pullRequestName, bool allowUnparsed) =>
            TryParse(pullRequestName, allowUnparsed, out PullRequestName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PullRequestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pullRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PullRequestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pullRequestName, out PullRequestName result) =>
            TryParse(pullRequestName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PullRequestName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pullRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PullRequestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pullRequestName, bool allowUnparsed, out PullRequestName result)
        {
            gax::GaxPreconditions.CheckNotNull(pullRequestName, nameof(pullRequestName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryPullRequest.TryParseName(pullRequestName, out resourceName))
            {
                result = FromProjectLocationRepositoryPullRequest(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(pullRequestName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PullRequestName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string pullRequestId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            PullRequestId = pullRequestId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PullRequestName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pullRequestId">The <c>PullRequest</c> ID. Must not be <c>null</c> or empty.</param>
        public PullRequestName(string projectId, string locationId, string repositoryId, string pullRequestId) : this(ResourceNameType.ProjectLocationRepositoryPullRequest, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), pullRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(pullRequestId, nameof(pullRequestId)))
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
        /// The <c>PullRequest</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PullRequestId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryPullRequest: return s_projectLocationRepositoryPullRequest.Expand(ProjectId, LocationId, RepositoryId, PullRequestId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PullRequestName);

        /// <inheritdoc/>
        public bool Equals(PullRequestName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PullRequestName a, PullRequestName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PullRequestName a, PullRequestName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Issue</c> resource.</summary>
    public sealed partial class IssueName : gax::IResourceName, sys::IEquatable<IssueName>
    {
        /// <summary>The possible contents of <see cref="IssueName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}</c>.
            /// </summary>
            ProjectLocationRepositoryIssue = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryIssue = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}");

        /// <summary>Creates a <see cref="IssueName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IssueName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IssueName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IssueName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IssueName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IssueName"/> constructed from the provided ids.</returns>
        public static IssueName FromProjectLocationRepositoryIssue(string projectId, string locationId, string repositoryId, string issueId) =>
            new IssueName(ResourceNameType.ProjectLocationRepositoryIssue, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), issueId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string issueId) =>
            FormatProjectLocationRepositoryIssue(projectId, locationId, repositoryId, issueId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryIssue(string projectId, string locationId, string repositoryId, string issueId) =>
            s_projectLocationRepositoryIssue.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)));

        /// <summary>Parses the given resource name string into a new <see cref="IssueName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IssueName"/> if successful.</returns>
        public static IssueName Parse(string issueName) => Parse(issueName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IssueName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IssueName"/> if successful.</returns>
        public static IssueName Parse(string issueName, bool allowUnparsed) =>
            TryParse(issueName, allowUnparsed, out IssueName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueName, out IssueName result) => TryParse(issueName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueName, bool allowUnparsed, out IssueName result)
        {
            gax::GaxPreconditions.CheckNotNull(issueName, nameof(issueName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryIssue.TryParseName(issueName, out resourceName))
            {
                result = FromProjectLocationRepositoryIssue(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(issueName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IssueName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string issueId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            IssueId = issueId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IssueName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        public IssueName(string projectId, string locationId, string repositoryId, string issueId) : this(ResourceNameType.ProjectLocationRepositoryIssue, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), issueId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)))
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
        /// The <c>Issue</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IssueId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryIssue: return s_projectLocationRepositoryIssue.Expand(ProjectId, LocationId, RepositoryId, IssueId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IssueName);

        /// <inheritdoc/>
        public bool Equals(IssueName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IssueName a, IssueName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IssueName a, IssueName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>IssueComment</c> resource.</summary>
    public sealed partial class IssueCommentName : gax::IResourceName, sys::IEquatable<IssueCommentName>
    {
        /// <summary>The possible contents of <see cref="IssueCommentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}</c>
            /// .
            /// </summary>
            ProjectLocationRepositoryIssueComment = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryIssueComment = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}");

        /// <summary>Creates a <see cref="IssueCommentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IssueCommentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IssueCommentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IssueCommentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IssueCommentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IssueCommentName"/> constructed from the provided ids.</returns>
        public static IssueCommentName FromProjectLocationRepositoryIssueComment(string projectId, string locationId, string repositoryId, string issueId, string commentId) =>
            new IssueCommentName(ResourceNameType.ProjectLocationRepositoryIssueComment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), issueId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)), commentId: gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueCommentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueCommentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string issueId, string commentId) =>
            FormatProjectLocationRepositoryIssueComment(projectId, locationId, repositoryId, issueId, commentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IssueCommentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IssueCommentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationRepositoryIssueComment(string projectId, string locationId, string repositoryId, string issueId, string commentId) =>
            s_projectLocationRepositoryIssueComment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)), gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)));

        /// <summary>Parses the given resource name string into a new <see cref="IssueCommentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueCommentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IssueCommentName"/> if successful.</returns>
        public static IssueCommentName Parse(string issueCommentName) => Parse(issueCommentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IssueCommentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueCommentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IssueCommentName"/> if successful.</returns>
        public static IssueCommentName Parse(string issueCommentName, bool allowUnparsed) =>
            TryParse(issueCommentName, allowUnparsed, out IssueCommentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueCommentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="issueCommentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueCommentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueCommentName, out IssueCommentName result) =>
            TryParse(issueCommentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IssueCommentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="issueCommentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IssueCommentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string issueCommentName, bool allowUnparsed, out IssueCommentName result)
        {
            gax::GaxPreconditions.CheckNotNull(issueCommentName, nameof(issueCommentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryIssueComment.TryParseName(issueCommentName, out resourceName))
            {
                result = FromProjectLocationRepositoryIssueComment(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(issueCommentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IssueCommentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string commentId = null, string issueId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CommentId = commentId;
            IssueId = issueId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IssueCommentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/issues/{issue}/issueComments/{comment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="issueId">The <c>Issue</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        public IssueCommentName(string projectId, string locationId, string repositoryId, string issueId, string commentId) : this(ResourceNameType.ProjectLocationRepositoryIssueComment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), issueId: gax::GaxPreconditions.CheckNotNullOrEmpty(issueId, nameof(issueId)), commentId: gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)))
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
        /// The <c>Comment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CommentId { get; }

        /// <summary>
        /// The <c>Issue</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IssueId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryIssueComment: return s_projectLocationRepositoryIssueComment.Expand(ProjectId, LocationId, RepositoryId, IssueId, CommentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IssueCommentName);

        /// <inheritdoc/>
        public bool Equals(IssueCommentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IssueCommentName a, IssueCommentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IssueCommentName a, IssueCommentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PullRequestComment</c> resource.</summary>
    public sealed partial class PullRequestCommentName : gax::IResourceName, sys::IEquatable<PullRequestCommentName>
    {
        /// <summary>The possible contents of <see cref="PullRequestCommentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}</c>
            /// .
            /// </summary>
            ProjectLocationRepositoryPullRequestComment = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryPullRequestComment = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}");

        /// <summary>Creates a <see cref="PullRequestCommentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PullRequestCommentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PullRequestCommentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PullRequestCommentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PullRequestCommentName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pullRequestId">The <c>PullRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PullRequestCommentName"/> constructed from the provided ids.</returns>
        public static PullRequestCommentName FromProjectLocationRepositoryPullRequestComment(string projectId, string locationId, string repositoryId, string pullRequestId, string commentId) =>
            new PullRequestCommentName(ResourceNameType.ProjectLocationRepositoryPullRequestComment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), pullRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(pullRequestId, nameof(pullRequestId)), commentId: gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PullRequestCommentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pullRequestId">The <c>PullRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PullRequestCommentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string pullRequestId, string commentId) =>
            FormatProjectLocationRepositoryPullRequestComment(projectId, locationId, repositoryId, pullRequestId, commentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PullRequestCommentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pullRequestId">The <c>PullRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PullRequestCommentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationRepositoryPullRequestComment(string projectId, string locationId, string repositoryId, string pullRequestId, string commentId) =>
            s_projectLocationRepositoryPullRequestComment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(pullRequestId, nameof(pullRequestId)), gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PullRequestCommentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pullRequestCommentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PullRequestCommentName"/> if successful.</returns>
        public static PullRequestCommentName Parse(string pullRequestCommentName) => Parse(pullRequestCommentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PullRequestCommentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pullRequestCommentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PullRequestCommentName"/> if successful.</returns>
        public static PullRequestCommentName Parse(string pullRequestCommentName, bool allowUnparsed) =>
            TryParse(pullRequestCommentName, allowUnparsed, out PullRequestCommentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PullRequestCommentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pullRequestCommentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PullRequestCommentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pullRequestCommentName, out PullRequestCommentName result) =>
            TryParse(pullRequestCommentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PullRequestCommentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pullRequestCommentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PullRequestCommentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pullRequestCommentName, bool allowUnparsed, out PullRequestCommentName result)
        {
            gax::GaxPreconditions.CheckNotNull(pullRequestCommentName, nameof(pullRequestCommentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryPullRequestComment.TryParseName(pullRequestCommentName, out resourceName))
            {
                result = FromProjectLocationRepositoryPullRequestComment(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(pullRequestCommentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PullRequestCommentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string commentId = null, string locationId = null, string projectId = null, string pullRequestId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CommentId = commentId;
            LocationId = locationId;
            ProjectId = projectId;
            PullRequestId = pullRequestId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PullRequestCommentName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/repositories/{repository}/pullRequests/{pull_request}/pullRequestComments/{comment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pullRequestId">The <c>PullRequest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commentId">The <c>Comment</c> ID. Must not be <c>null</c> or empty.</param>
        public PullRequestCommentName(string projectId, string locationId, string repositoryId, string pullRequestId, string commentId) : this(ResourceNameType.ProjectLocationRepositoryPullRequestComment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), pullRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(pullRequestId, nameof(pullRequestId)), commentId: gax::GaxPreconditions.CheckNotNullOrEmpty(commentId, nameof(commentId)))
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
        /// The <c>Comment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CommentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>PullRequest</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PullRequestId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryPullRequestComment: return s_projectLocationRepositoryPullRequestComment.Expand(ProjectId, LocationId, RepositoryId, PullRequestId, CommentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PullRequestCommentName);

        /// <inheritdoc/>
        public bool Equals(PullRequestCommentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PullRequestCommentName a, PullRequestCommentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PullRequestCommentName a, PullRequestCommentName b) => !(a == b);
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
            /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
            /// </summary>
            ProjectLocationKeyRingCryptoKey = 1,
        }

        private static gax::PathTemplate s_projectLocationKeyRingCryptoKey = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}");

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
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CryptoKeyName"/> constructed from the provided ids.</returns>
        public static CryptoKeyName FromProjectLocationKeyRingCryptoKey(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            new CryptoKeyName(ResourceNameType.ProjectLocationKeyRingCryptoKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            FormatProjectLocationKeyRingCryptoKey(projectId, locationId, keyRingId, cryptoKeyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </returns>
        public static string FormatProjectLocationKeyRingCryptoKey(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            s_projectLocationKeyRingCryptoKey.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)));

        /// <summary>Parses the given resource name string into a new <see cref="CryptoKeyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
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
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
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
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
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
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
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
            if (s_projectLocationKeyRingCryptoKey.TryParseName(cryptoKeyName, out resourceName))
            {
                result = FromProjectLocationKeyRingCryptoKey(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
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

        private CryptoKeyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cryptoKeyId = null, string keyRingId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CryptoKeyId = cryptoKeyId;
            KeyRingId = keyRingId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CryptoKeyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        public CryptoKeyName(string projectId, string locationId, string keyRingId, string cryptoKeyId) : this(ResourceNameType.ProjectLocationKeyRingCryptoKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)))
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
        /// The <c>CryptoKey</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CryptoKeyId { get; }

        /// <summary>
        /// The <c>KeyRing</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeyRingId { get; }

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
                case ResourceNameType.ProjectLocationKeyRingCryptoKey: return s_projectLocationKeyRingCryptoKey.Expand(ProjectId, LocationId, KeyRingId, CryptoKeyId);
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

    /// <summary>Resource name for the <c>CaPool</c> resource.</summary>
    public sealed partial class CaPoolName : gax::IResourceName, sys::IEquatable<CaPoolName>
    {
        /// <summary>The possible contents of <see cref="CaPoolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
            /// </summary>
            ProjectLocationCaPool = 1,
        }

        private static gax::PathTemplate s_projectLocationCaPool = new gax::PathTemplate("projects/{project}/locations/{location}/caPools/{ca_pool}");

        /// <summary>Creates a <see cref="CaPoolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CaPoolName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CaPoolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CaPoolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CaPoolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CaPoolName"/> constructed from the provided ids.</returns>
        public static CaPoolName FromProjectLocationCaPool(string projectId, string locationId, string caPoolId) =>
            new CaPoolName(ResourceNameType.ProjectLocationCaPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string caPoolId) =>
            FormatProjectLocationCaPool(projectId, locationId, caPoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CaPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>.
        /// </returns>
        public static string FormatProjectLocationCaPool(string projectId, string locationId, string caPoolId) =>
            s_projectLocationCaPool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)));

        /// <summary>Parses the given resource name string into a new <see cref="CaPoolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CaPoolName"/> if successful.</returns>
        public static CaPoolName Parse(string caPoolName) => Parse(caPoolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CaPoolName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CaPoolName"/> if successful.</returns>
        public static CaPoolName Parse(string caPoolName, bool allowUnparsed) =>
            TryParse(caPoolName, allowUnparsed, out CaPoolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CaPoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CaPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string caPoolName, out CaPoolName result) => TryParse(caPoolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CaPoolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/caPools/{ca_pool}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="caPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CaPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string caPoolName, bool allowUnparsed, out CaPoolName result)
        {
            gax::GaxPreconditions.CheckNotNull(caPoolName, nameof(caPoolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCaPool.TryParseName(caPoolName, out resourceName))
            {
                result = FromProjectLocationCaPool(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(caPoolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CaPoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string caPoolId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CaPoolId = caPoolId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CaPoolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/caPools/{ca_pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="caPoolId">The <c>CaPool</c> ID. Must not be <c>null</c> or empty.</param>
        public CaPoolName(string projectId, string locationId, string caPoolId) : this(ResourceNameType.ProjectLocationCaPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), caPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)))
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
        /// The <c>CaPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CaPoolId { get; }

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
                case ResourceNameType.ProjectLocationCaPool: return s_projectLocationCaPool.Expand(ProjectId, LocationId, CaPoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CaPoolName);

        /// <inheritdoc/>
        public bool Equals(CaPoolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CaPoolName a, CaPoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CaPoolName a, CaPoolName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ServiceAttachment</c> resource.</summary>
    public sealed partial class ServiceAttachmentName : gax::IResourceName, sys::IEquatable<ServiceAttachmentName>
    {
        /// <summary>The possible contents of <see cref="ServiceAttachmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
            /// </summary>
            ProjectRegionServiceAttachment = 1,
        }

        private static gax::PathTemplate s_projectRegionServiceAttachment = new gax::PathTemplate("projects/{project}/regions/{region}/serviceAttachments/{service_attachment}");

        /// <summary>Creates a <see cref="ServiceAttachmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceAttachmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceAttachmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceAttachmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceAttachmentName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAttachmentId">The <c>ServiceAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceAttachmentName"/> constructed from the provided ids.</returns>
        public static ServiceAttachmentName FromProjectRegionServiceAttachment(string projectId, string regionId, string serviceAttachmentId) =>
            new ServiceAttachmentName(ResourceNameType.ProjectRegionServiceAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), serviceAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAttachmentId, nameof(serviceAttachmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAttachmentId">The <c>ServiceAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string serviceAttachmentId) =>
            FormatProjectRegionServiceAttachment(projectId, regionId, serviceAttachmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAttachmentId">The <c>ServiceAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceAttachmentName"/> with pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>.
        /// </returns>
        public static string FormatProjectRegionServiceAttachment(string projectId, string regionId, string serviceAttachmentId) =>
            s_projectRegionServiceAttachment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAttachmentId, nameof(serviceAttachmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceAttachmentName"/> if successful.</returns>
        public static ServiceAttachmentName Parse(string serviceAttachmentName) => Parse(serviceAttachmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceAttachmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceAttachmentName"/> if successful.</returns>
        public static ServiceAttachmentName Parse(string serviceAttachmentName, bool allowUnparsed) =>
            TryParse(serviceAttachmentName, allowUnparsed, out ServiceAttachmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAttachmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAttachmentName, out ServiceAttachmentName result) =>
            TryParse(serviceAttachmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceAttachmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceAttachmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceAttachmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceAttachmentName, bool allowUnparsed, out ServiceAttachmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceAttachmentName, nameof(serviceAttachmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionServiceAttachment.TryParseName(serviceAttachmentName, out resourceName))
            {
                result = FromProjectRegionServiceAttachment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceAttachmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceAttachmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string regionId = null, string serviceAttachmentId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            RegionId = regionId;
            ServiceAttachmentId = serviceAttachmentId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceAttachmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/serviceAttachments/{service_attachment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceAttachmentId">The <c>ServiceAttachment</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceAttachmentName(string projectId, string regionId, string serviceAttachmentId) : this(ResourceNameType.ProjectRegionServiceAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), serviceAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceAttachmentId, nameof(serviceAttachmentId)))
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
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>
        /// The <c>ServiceAttachment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ServiceAttachmentId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionServiceAttachment: return s_projectRegionServiceAttachment.Expand(ProjectId, RegionId, ServiceAttachmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceAttachmentName);

        /// <inheritdoc/>
        public bool Equals(ServiceAttachmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceAttachmentName a, ServiceAttachmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceAttachmentName a, ServiceAttachmentName b) => !(a == b);
    }

    public partial class Instance
    {
        /// <summary>
        /// <see cref="gcsv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="KmsKey"/> resource name property.
        /// </summary>
        public CryptoKeyName KmsKeyAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(KmsKey) ? null : CryptoKeyName.Parse(KmsKey, allowUnparsed: true);
            set => KmsKey = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class PrivateConfig
            {
                /// <summary>
                /// <see cref="CaPoolName"/>-typed view over the <see cref="CaPool"/> resource name property.
                /// </summary>
                public CaPoolName CaPoolAsCaPoolName
                {
                    get => string.IsNullOrEmpty(CaPool) ? null : CaPoolName.Parse(CaPool, allowUnparsed: true);
                    set => CaPool = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="ServiceAttachmentName"/>-typed view over the <see cref="HttpServiceAttachment"/> resource
                /// name property.
                /// </summary>
                public ServiceAttachmentName HttpServiceAttachmentAsServiceAttachmentName
                {
                    get => string.IsNullOrEmpty(HttpServiceAttachment) ? null : ServiceAttachmentName.Parse(HttpServiceAttachment, allowUnparsed: true);
                    set => HttpServiceAttachment = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="ServiceAttachmentName"/>-typed view over the <see cref="SshServiceAttachment"/> resource
                /// name property.
                /// </summary>
                public ServiceAttachmentName SshServiceAttachmentAsServiceAttachmentName
                {
                    get => string.IsNullOrEmpty(SshServiceAttachment) ? null : ServiceAttachmentName.Parse(SshServiceAttachment, allowUnparsed: true);
                    set => SshServiceAttachment = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class Repository
    {
        /// <summary>
        /// <see cref="gcsv::RepositoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::RepositoryName RepositoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::RepositoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Instance"/> resource name property.
        /// </summary>
        public InstanceName InstanceAsInstanceName
        {
            get => string.IsNullOrEmpty(Instance) ? null : InstanceName.Parse(Instance, allowUnparsed: true);
            set => Instance = value?.ToString() ?? "";
        }
    }

    public partial class Hook
    {
        /// <summary>
        /// <see cref="gcsv::HookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::HookName HookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::HookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BranchRule
    {
        /// <summary>
        /// <see cref="gcsv::BranchRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BranchRuleName BranchRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BranchRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PullRequest
    {
        /// <summary>
        /// <see cref="gcsv::PullRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::PullRequestName PullRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::PullRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Issue
    {
        /// <summary>
        /// <see cref="gcsv::IssueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::IssueName IssueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::IssueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class IssueComment
    {
        /// <summary>
        /// <see cref="gcsv::IssueCommentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::IssueCommentName IssueCommentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::IssueCommentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PullRequestComment
    {
        /// <summary>
        /// <see cref="gcsv::PullRequestCommentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::PullRequestCommentName PullRequestCommentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::PullRequestCommentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListInstancesRequest
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

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="gcsv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInstanceRequest
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

    public partial class DeleteInstanceRequest
    {
        /// <summary>
        /// <see cref="gcsv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRepositoriesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Instance"/> resource name property.
        /// </summary>
        public InstanceName InstanceAsInstanceName
        {
            get => string.IsNullOrEmpty(Instance) ? null : InstanceName.Parse(Instance, allowUnparsed: true);
            set => Instance = value?.ToString() ?? "";
        }
    }

    public partial class GetRepositoryRequest
    {
        /// <summary>
        /// <see cref="gcsv::RepositoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::RepositoryName RepositoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::RepositoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateRepositoryRequest
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

    public partial class DeleteRepositoryRequest
    {
        /// <summary>
        /// <see cref="gcsv::RepositoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::RepositoryName RepositoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::RepositoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListHooksRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetHookRequest
    {
        /// <summary>
        /// <see cref="gcsv::HookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::HookName HookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::HookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateHookRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteHookRequest
    {
        /// <summary>
        /// <see cref="gcsv::HookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::HookName HookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::HookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetBranchRuleRequest
    {
        /// <summary>
        /// <see cref="gcsv::BranchRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BranchRuleName BranchRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BranchRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateBranchRuleRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListBranchRulesRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBranchRuleRequest
    {
        /// <summary>
        /// <see cref="gcsv::BranchRuleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BranchRuleName BranchRuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BranchRuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePullRequestRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPullRequestRequest
    {
        /// <summary>
        /// <see cref="gcsv::PullRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::PullRequestName PullRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::PullRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPullRequestsRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class MergePullRequestRequest
    {
        /// <summary>
        /// <see cref="gcsv::PullRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::PullRequestName PullRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::PullRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class OpenPullRequestRequest
    {
        /// <summary>
        /// <see cref="gcsv::PullRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::PullRequestName PullRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::PullRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ClosePullRequestRequest
    {
        /// <summary>
        /// <see cref="gcsv::PullRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::PullRequestName PullRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::PullRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPullRequestFileDiffsRequest
    {
        /// <summary>
        /// <see cref="gcsv::PullRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::PullRequestName PullRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::PullRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateIssueRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetIssueRequest
    {
        /// <summary>
        /// <see cref="gcsv::IssueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::IssueName IssueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::IssueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListIssuesRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteIssueRequest
    {
        /// <summary>
        /// <see cref="gcsv::IssueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::IssueName IssueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::IssueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CloseIssueRequest
    {
        /// <summary>
        /// <see cref="gcsv::IssueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::IssueName IssueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::IssueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class OpenIssueRequest
    {
        /// <summary>
        /// <see cref="gcsv::IssueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::IssueName IssueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::IssueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchTreeRequest
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

    public partial class FetchBlobRequest
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

    public partial class ListPullRequestCommentsRequest
    {
        /// <summary>
        /// <see cref="PullRequestName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PullRequestName ParentAsPullRequestName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PullRequestName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreatePullRequestCommentRequest
    {
        /// <summary>
        /// <see cref="PullRequestName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PullRequestName ParentAsPullRequestName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PullRequestName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreatePullRequestCommentsRequest
    {
        /// <summary>
        /// <see cref="PullRequestName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PullRequestName ParentAsPullRequestName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PullRequestName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePullRequestCommentRequest
    {
        /// <summary>
        /// <see cref="gcsv::PullRequestCommentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::PullRequestCommentName PullRequestCommentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::PullRequestCommentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetPullRequestCommentRequest
    {
        /// <summary>
        /// <see cref="gcsv::PullRequestCommentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::PullRequestCommentName PullRequestCommentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::PullRequestCommentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResolvePullRequestCommentsRequest
    {
        /// <summary>
        /// <see cref="PullRequestName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PullRequestName ParentAsPullRequestName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PullRequestName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PullRequestCommentName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<PullRequestCommentName> PullRequestCommentNames
        {
            get => new gax::ResourceNameList<PullRequestCommentName>(Names, s => string.IsNullOrEmpty(s) ? null : PullRequestCommentName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class UnresolvePullRequestCommentsRequest
    {
        /// <summary>
        /// <see cref="PullRequestName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PullRequestName ParentAsPullRequestName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PullRequestName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PullRequestCommentName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<PullRequestCommentName> PullRequestCommentNames
        {
            get => new gax::ResourceNameList<PullRequestCommentName>(Names, s => string.IsNullOrEmpty(s) ? null : PullRequestCommentName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class CreateIssueCommentRequest
    {
        /// <summary><see cref="IssueName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public IssueName ParentAsIssueName
        {
            get => string.IsNullOrEmpty(Parent) ? null : IssueName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetIssueCommentRequest
    {
        /// <summary>
        /// <see cref="gcsv::IssueCommentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::IssueCommentName IssueCommentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::IssueCommentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListIssueCommentsRequest
    {
        /// <summary><see cref="IssueName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public IssueName ParentAsIssueName
        {
            get => string.IsNullOrEmpty(Parent) ? null : IssueName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteIssueCommentRequest
    {
        /// <summary>
        /// <see cref="gcsv::IssueCommentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::IssueCommentName IssueCommentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::IssueCommentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
