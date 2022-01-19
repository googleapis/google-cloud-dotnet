// Copyright 2022 Google LLC
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
using gccv = Google.Cloud.CloudDms.V1;
using sys = System;

namespace Google.Cloud.CloudDms.V1
{
    /// <summary>Resource name for the <c>MigrationJob</c> resource.</summary>
    public sealed partial class MigrationJobName : gax::IResourceName, sys::IEquatable<MigrationJobName>
    {
        /// <summary>The possible contents of <see cref="MigrationJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/migrationJobs/{migration_job}</c>
            /// .
            /// </summary>
            ProjectLocationMigrationJob = 1,
        }

        private static gax::PathTemplate s_projectLocationMigrationJob = new gax::PathTemplate("projects/{project}/locations/{location}/migrationJobs/{migration_job}");

        /// <summary>Creates a <see cref="MigrationJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MigrationJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MigrationJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MigrationJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MigrationJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/migrationJobs/{migration_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migrationJobId">The <c>MigrationJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MigrationJobName"/> constructed from the provided ids.</returns>
        public static MigrationJobName FromProjectLocationMigrationJob(string projectId, string locationId, string migrationJobId) =>
            new MigrationJobName(ResourceNameType.ProjectLocationMigrationJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), migrationJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(migrationJobId, nameof(migrationJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MigrationJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/migrationJobs/{migration_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migrationJobId">The <c>MigrationJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MigrationJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/migrationJobs/{migration_job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string migrationJobId) =>
            FormatProjectLocationMigrationJob(projectId, locationId, migrationJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MigrationJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/migrationJobs/{migration_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migrationJobId">The <c>MigrationJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MigrationJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/migrationJobs/{migration_job}</c>.
        /// </returns>
        public static string FormatProjectLocationMigrationJob(string projectId, string locationId, string migrationJobId) =>
            s_projectLocationMigrationJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(migrationJobId, nameof(migrationJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="MigrationJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/migrationJobs/{migration_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="migrationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MigrationJobName"/> if successful.</returns>
        public static MigrationJobName Parse(string migrationJobName) => Parse(migrationJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MigrationJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/migrationJobs/{migration_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="migrationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MigrationJobName"/> if successful.</returns>
        public static MigrationJobName Parse(string migrationJobName, bool allowUnparsed) =>
            TryParse(migrationJobName, allowUnparsed, out MigrationJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MigrationJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/migrationJobs/{migration_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="migrationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MigrationJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string migrationJobName, out MigrationJobName result) =>
            TryParse(migrationJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MigrationJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/migrationJobs/{migration_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="migrationJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MigrationJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string migrationJobName, bool allowUnparsed, out MigrationJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(migrationJobName, nameof(migrationJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMigrationJob.TryParseName(migrationJobName, out resourceName))
            {
                result = FromProjectLocationMigrationJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(migrationJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MigrationJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string migrationJobId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MigrationJobId = migrationJobId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MigrationJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/migrationJobs/{migration_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="migrationJobId">The <c>MigrationJob</c> ID. Must not be <c>null</c> or empty.</param>
        public MigrationJobName(string projectId, string locationId, string migrationJobId) : this(ResourceNameType.ProjectLocationMigrationJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), migrationJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(migrationJobId, nameof(migrationJobId)))
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
        /// The <c>MigrationJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MigrationJobId { get; }

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
                case ResourceNameType.ProjectLocationMigrationJob: return s_projectLocationMigrationJob.Expand(ProjectId, LocationId, MigrationJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MigrationJobName);

        /// <inheritdoc/>
        public bool Equals(MigrationJobName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MigrationJobName a, MigrationJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(MigrationJobName a, MigrationJobName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ConnectionProfile</c> resource.</summary>
    public sealed partial class ConnectionProfileName : gax::IResourceName, sys::IEquatable<ConnectionProfileName>
    {
        /// <summary>The possible contents of <see cref="ConnectionProfileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
            /// </summary>
            ProjectLocationConnectionProfile = 1,
        }

        private static gax::PathTemplate s_projectLocationConnectionProfile = new gax::PathTemplate("projects/{project}/locations/{location}/connectionProfiles/{connection_profile}");

        /// <summary>Creates a <see cref="ConnectionProfileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConnectionProfileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConnectionProfileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConnectionProfileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConnectionProfileName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionProfileId">The <c>ConnectionProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConnectionProfileName"/> constructed from the provided ids.</returns>
        public static ConnectionProfileName FromProjectLocationConnectionProfile(string projectId, string locationId, string connectionProfileId) =>
            new ConnectionProfileName(ResourceNameType.ProjectLocationConnectionProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectionProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionProfileId">The <c>ConnectionProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectionProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string connectionProfileId) =>
            FormatProjectLocationConnectionProfile(projectId, locationId, connectionProfileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConnectionProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionProfileId">The <c>ConnectionProfile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConnectionProfileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>.
        /// </returns>
        public static string FormatProjectLocationConnectionProfile(string projectId, string locationId, string connectionProfileId) =>
            s_projectLocationConnectionProfile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConnectionProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectionProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConnectionProfileName"/> if successful.</returns>
        public static ConnectionProfileName Parse(string connectionProfileName) => Parse(connectionProfileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConnectionProfileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectionProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConnectionProfileName"/> if successful.</returns>
        public static ConnectionProfileName Parse(string connectionProfileName, bool allowUnparsed) =>
            TryParse(connectionProfileName, allowUnparsed, out ConnectionProfileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectionProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="connectionProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectionProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectionProfileName, out ConnectionProfileName result) =>
            TryParse(connectionProfileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConnectionProfileName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="connectionProfileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConnectionProfileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string connectionProfileName, bool allowUnparsed, out ConnectionProfileName result)
        {
            gax::GaxPreconditions.CheckNotNull(connectionProfileName, nameof(connectionProfileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConnectionProfile.TryParseName(connectionProfileName, out resourceName))
            {
                result = FromProjectLocationConnectionProfile(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(connectionProfileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConnectionProfileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string connectionProfileId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConnectionProfileId = connectionProfileId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConnectionProfileName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/connectionProfiles/{connection_profile}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionProfileId">The <c>ConnectionProfile</c> ID. Must not be <c>null</c> or empty.</param>
        public ConnectionProfileName(string projectId, string locationId, string connectionProfileId) : this(ResourceNameType.ProjectLocationConnectionProfile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionProfileId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionProfileId, nameof(connectionProfileId)))
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
        /// The <c>ConnectionProfile</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConnectionProfileId { get; }

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
                case ResourceNameType.ProjectLocationConnectionProfile: return s_projectLocationConnectionProfile.Expand(ProjectId, LocationId, ConnectionProfileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConnectionProfileName);

        /// <inheritdoc/>
        public bool Equals(ConnectionProfileName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ConnectionProfileName a, ConnectionProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ConnectionProfileName a, ConnectionProfileName b) => !(a == b);
    }

    public partial class MigrationJob
    {
        /// <summary>
        /// <see cref="gccv::MigrationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::MigrationJobName MigrationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::MigrationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ConnectionProfile
    {
        /// <summary>
        /// <see cref="gccv::ConnectionProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConnectionProfileName ConnectionProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConnectionProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
