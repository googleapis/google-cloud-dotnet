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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcov = Google.Cloud.OracleDatabase.V1;
using sys = System;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Resource name for the <c>DatabaseConnection</c> resource.</summary>
    public sealed partial class DatabaseConnectionName : gax::IResourceName, sys::IEquatable<DatabaseConnectionName>
    {
        /// <summary>The possible contents of <see cref="DatabaseConnectionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/databaseConnections/{database_connection}</c>.
            /// </summary>
            ProjectLocationDatabaseConnection = 1,
        }

        private static gax::PathTemplate s_projectLocationDatabaseConnection = new gax::PathTemplate("projects/{project}/locations/{location}/databaseConnections/{database_connection}");

        /// <summary>Creates a <see cref="DatabaseConnectionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatabaseConnectionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DatabaseConnectionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatabaseConnectionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatabaseConnectionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/databaseConnections/{database_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseConnectionId">
        /// The <c>DatabaseConnection</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="DatabaseConnectionName"/> constructed from the provided ids.</returns>
        public static DatabaseConnectionName FromProjectLocationDatabaseConnection(string projectId, string locationId, string databaseConnectionId) =>
            new DatabaseConnectionName(ResourceNameType.ProjectLocationDatabaseConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), databaseConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseConnectionId, nameof(databaseConnectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatabaseConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databaseConnections/{database_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseConnectionId">
        /// The <c>DatabaseConnection</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DatabaseConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databaseConnections/{database_connection}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string databaseConnectionId) =>
            FormatProjectLocationDatabaseConnection(projectId, locationId, databaseConnectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatabaseConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databaseConnections/{database_connection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseConnectionId">
        /// The <c>DatabaseConnection</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DatabaseConnectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/databaseConnections/{database_connection}</c>.
        /// </returns>
        public static string FormatProjectLocationDatabaseConnection(string projectId, string locationId, string databaseConnectionId) =>
            s_projectLocationDatabaseConnection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseConnectionId, nameof(databaseConnectionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatabaseConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/databaseConnections/{database_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="databaseConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatabaseConnectionName"/> if successful.</returns>
        public static DatabaseConnectionName Parse(string databaseConnectionName) => Parse(databaseConnectionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatabaseConnectionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/databaseConnections/{database_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="databaseConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatabaseConnectionName"/> if successful.</returns>
        public static DatabaseConnectionName Parse(string databaseConnectionName, bool allowUnparsed) =>
            TryParse(databaseConnectionName, allowUnparsed, out DatabaseConnectionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatabaseConnectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/databaseConnections/{database_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="databaseConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatabaseConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseConnectionName, out DatabaseConnectionName result) =>
            TryParse(databaseConnectionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatabaseConnectionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/databaseConnections/{database_connection}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="databaseConnectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatabaseConnectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseConnectionName, bool allowUnparsed, out DatabaseConnectionName result)
        {
            gax::GaxPreconditions.CheckNotNull(databaseConnectionName, nameof(databaseConnectionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatabaseConnection.TryParseName(databaseConnectionName, out resourceName))
            {
                result = FromProjectLocationDatabaseConnection(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(databaseConnectionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatabaseConnectionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string databaseConnectionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatabaseConnectionId = databaseConnectionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatabaseConnectionName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/databaseConnections/{database_connection}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseConnectionId">
        /// The <c>DatabaseConnection</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DatabaseConnectionName(string projectId, string locationId, string databaseConnectionId) : this(ResourceNameType.ProjectLocationDatabaseConnection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), databaseConnectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseConnectionId, nameof(databaseConnectionId)))
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
        /// The <c>DatabaseConnection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string DatabaseConnectionId { get; }

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
                case ResourceNameType.ProjectLocationDatabaseConnection: return s_projectLocationDatabaseConnection.Expand(ProjectId, LocationId, DatabaseConnectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatabaseConnectionName);

        /// <inheritdoc/>
        public bool Equals(DatabaseConnectionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatabaseConnectionName a, DatabaseConnectionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatabaseConnectionName a, DatabaseConnectionName b) => !(a == b);
    }

    public partial class DatabaseConnection
    {
        /// <summary>
        /// <see cref="gcov::DatabaseConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::DatabaseConnectionName DatabaseConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::DatabaseConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="PasswordSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName PasswordSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(PasswordSecretVersion) ? null : SecretVersionName.Parse(PasswordSecretVersion, allowUnparsed: true);
            set => PasswordSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SecretVersionName"/>-typed view over the <see cref="WalletSecretVersion"/> resource name
        /// property.
        /// </summary>
        public SecretVersionName WalletSecretVersionAsSecretVersionName
        {
            get => string.IsNullOrEmpty(WalletSecretVersion) ? null : SecretVersionName.Parse(WalletSecretVersion, allowUnparsed: true);
            set => WalletSecretVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OdbNetworkName"/>-typed view over the <see cref="OdbNetwork"/> resource name property.
        /// </summary>
        public OdbNetworkName OdbNetworkAsOdbNetworkName
        {
            get => string.IsNullOrEmpty(OdbNetwork) ? null : OdbNetworkName.Parse(OdbNetwork, allowUnparsed: true);
            set => OdbNetwork = value?.ToString() ?? "";
        }
    }

    public partial class CreateDatabaseConnectionRequest
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

    public partial class DeleteDatabaseConnectionRequest
    {
        /// <summary>
        /// <see cref="gcov::DatabaseConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::DatabaseConnectionName DatabaseConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::DatabaseConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDatabaseConnectionsRequest
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

    public partial class GetDatabaseConnectionRequest
    {
        /// <summary>
        /// <see cref="gcov::DatabaseConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::DatabaseConnectionName DatabaseConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::DatabaseConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TestDatabaseConnectionRequest
    {
        /// <summary>
        /// <see cref="gcov::DatabaseConnectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcov::DatabaseConnectionName DatabaseConnectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::DatabaseConnectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
