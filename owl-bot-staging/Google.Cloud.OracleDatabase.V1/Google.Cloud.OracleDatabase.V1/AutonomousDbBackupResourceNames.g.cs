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
using gcov = Google.Cloud.OracleDatabase.V1;
using sys = System;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Resource name for the <c>AutonomousDatabaseBackup</c> resource.</summary>
    public sealed partial class AutonomousDatabaseBackupName : gax::IResourceName, sys::IEquatable<AutonomousDatabaseBackupName>
    {
        /// <summary>The possible contents of <see cref="AutonomousDatabaseBackupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}</c>.
            /// </summary>
            ProjectLocationAutonomousDatabaseBackup = 1,
        }

        private static gax::PathTemplate s_projectLocationAutonomousDatabaseBackup = new gax::PathTemplate("projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}");

        /// <summary>
        /// Creates a <see cref="AutonomousDatabaseBackupName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AutonomousDatabaseBackupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AutonomousDatabaseBackupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AutonomousDatabaseBackupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AutonomousDatabaseBackupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autonomousDatabaseBackupId">
        /// The <c>AutonomousDatabaseBackup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AutonomousDatabaseBackupName"/> constructed from the provided ids.
        /// </returns>
        public static AutonomousDatabaseBackupName FromProjectLocationAutonomousDatabaseBackup(string projectId, string locationId, string autonomousDatabaseBackupId) =>
            new AutonomousDatabaseBackupName(ResourceNameType.ProjectLocationAutonomousDatabaseBackup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), autonomousDatabaseBackupId: gax::GaxPreconditions.CheckNotNullOrEmpty(autonomousDatabaseBackupId, nameof(autonomousDatabaseBackupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutonomousDatabaseBackupName"/> with
        /// pattern <c>projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autonomousDatabaseBackupId">
        /// The <c>AutonomousDatabaseBackup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AutonomousDatabaseBackupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string autonomousDatabaseBackupId) =>
            FormatProjectLocationAutonomousDatabaseBackup(projectId, locationId, autonomousDatabaseBackupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutonomousDatabaseBackupName"/> with
        /// pattern <c>projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autonomousDatabaseBackupId">
        /// The <c>AutonomousDatabaseBackup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AutonomousDatabaseBackupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}</c>.
        /// </returns>
        public static string FormatProjectLocationAutonomousDatabaseBackup(string projectId, string locationId, string autonomousDatabaseBackupId) =>
            s_projectLocationAutonomousDatabaseBackup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(autonomousDatabaseBackupId, nameof(autonomousDatabaseBackupId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AutonomousDatabaseBackupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="autonomousDatabaseBackupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="AutonomousDatabaseBackupName"/> if successful.</returns>
        public static AutonomousDatabaseBackupName Parse(string autonomousDatabaseBackupName) =>
            Parse(autonomousDatabaseBackupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AutonomousDatabaseBackupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="autonomousDatabaseBackupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AutonomousDatabaseBackupName"/> if successful.</returns>
        public static AutonomousDatabaseBackupName Parse(string autonomousDatabaseBackupName, bool allowUnparsed) =>
            TryParse(autonomousDatabaseBackupName, allowUnparsed, out AutonomousDatabaseBackupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutonomousDatabaseBackupName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="autonomousDatabaseBackupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutonomousDatabaseBackupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string autonomousDatabaseBackupName, out AutonomousDatabaseBackupName result) =>
            TryParse(autonomousDatabaseBackupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutonomousDatabaseBackupName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="autonomousDatabaseBackupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutonomousDatabaseBackupName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string autonomousDatabaseBackupName, bool allowUnparsed, out AutonomousDatabaseBackupName result)
        {
            gax::GaxPreconditions.CheckNotNull(autonomousDatabaseBackupName, nameof(autonomousDatabaseBackupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAutonomousDatabaseBackup.TryParseName(autonomousDatabaseBackupName, out resourceName))
            {
                result = FromProjectLocationAutonomousDatabaseBackup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(autonomousDatabaseBackupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AutonomousDatabaseBackupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string autonomousDatabaseBackupId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AutonomousDatabaseBackupId = autonomousDatabaseBackupId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AutonomousDatabaseBackupName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/autonomousDatabaseBackups/{autonomous_database_backup}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autonomousDatabaseBackupId">
        /// The <c>AutonomousDatabaseBackup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AutonomousDatabaseBackupName(string projectId, string locationId, string autonomousDatabaseBackupId) : this(ResourceNameType.ProjectLocationAutonomousDatabaseBackup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), autonomousDatabaseBackupId: gax::GaxPreconditions.CheckNotNullOrEmpty(autonomousDatabaseBackupId, nameof(autonomousDatabaseBackupId)))
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
        /// The <c>AutonomousDatabaseBackup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AutonomousDatabaseBackupId { get; }

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
                case ResourceNameType.ProjectLocationAutonomousDatabaseBackup: return s_projectLocationAutonomousDatabaseBackup.Expand(ProjectId, LocationId, AutonomousDatabaseBackupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AutonomousDatabaseBackupName);

        /// <inheritdoc/>
        public bool Equals(AutonomousDatabaseBackupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AutonomousDatabaseBackupName a, AutonomousDatabaseBackupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AutonomousDatabaseBackupName a, AutonomousDatabaseBackupName b) => !(a == b);
    }

    public partial class AutonomousDatabaseBackup
    {
        /// <summary>
        /// <see cref="gcov::AutonomousDatabaseBackupName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcov::AutonomousDatabaseBackupName AutonomousDatabaseBackupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::AutonomousDatabaseBackupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AutonomousDatabaseName"/>-typed view over the <see cref="AutonomousDatabase"/> resource name
        /// property.
        /// </summary>
        public AutonomousDatabaseName AutonomousDatabaseAsAutonomousDatabaseName
        {
            get => string.IsNullOrEmpty(AutonomousDatabase) ? null : AutonomousDatabaseName.Parse(AutonomousDatabase, allowUnparsed: true);
            set => AutonomousDatabase = value?.ToString() ?? "";
        }
    }
}
