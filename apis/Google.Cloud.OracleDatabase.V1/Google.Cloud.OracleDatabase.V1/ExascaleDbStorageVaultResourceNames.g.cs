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
using gcov = Google.Cloud.OracleDatabase.V1;
using sys = System;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Resource name for the <c>ExascaleDbStorageVault</c> resource.</summary>
    public sealed partial class ExascaleDbStorageVaultName : gax::IResourceName, sys::IEquatable<ExascaleDbStorageVaultName>
    {
        /// <summary>The possible contents of <see cref="ExascaleDbStorageVaultName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}</c>.
            /// </summary>
            ProjectLocationExascaleDbStorageVault = 1,
        }

        private static gax::PathTemplate s_projectLocationExascaleDbStorageVault = new gax::PathTemplate("projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}");

        /// <summary>Creates a <see cref="ExascaleDbStorageVaultName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExascaleDbStorageVaultName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExascaleDbStorageVaultName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExascaleDbStorageVaultName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExascaleDbStorageVaultName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exascaleDbStorageVaultId">
        /// The <c>ExascaleDbStorageVault</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ExascaleDbStorageVaultName"/> constructed from the provided ids.
        /// </returns>
        public static ExascaleDbStorageVaultName FromProjectLocationExascaleDbStorageVault(string projectId, string locationId, string exascaleDbStorageVaultId) =>
            new ExascaleDbStorageVaultName(ResourceNameType.ProjectLocationExascaleDbStorageVault, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), exascaleDbStorageVaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(exascaleDbStorageVaultId, nameof(exascaleDbStorageVaultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExascaleDbStorageVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exascaleDbStorageVaultId">
        /// The <c>ExascaleDbStorageVault</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ExascaleDbStorageVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string exascaleDbStorageVaultId) =>
            FormatProjectLocationExascaleDbStorageVault(projectId, locationId, exascaleDbStorageVaultId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExascaleDbStorageVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exascaleDbStorageVaultId">
        /// The <c>ExascaleDbStorageVault</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ExascaleDbStorageVaultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}</c>.
        /// </returns>
        public static string FormatProjectLocationExascaleDbStorageVault(string projectId, string locationId, string exascaleDbStorageVaultId) =>
            s_projectLocationExascaleDbStorageVault.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(exascaleDbStorageVaultId, nameof(exascaleDbStorageVaultId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExascaleDbStorageVaultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="exascaleDbStorageVaultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExascaleDbStorageVaultName"/> if successful.</returns>
        public static ExascaleDbStorageVaultName Parse(string exascaleDbStorageVaultName) =>
            Parse(exascaleDbStorageVaultName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExascaleDbStorageVaultName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="exascaleDbStorageVaultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExascaleDbStorageVaultName"/> if successful.</returns>
        public static ExascaleDbStorageVaultName Parse(string exascaleDbStorageVaultName, bool allowUnparsed) =>
            TryParse(exascaleDbStorageVaultName, allowUnparsed, out ExascaleDbStorageVaultName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExascaleDbStorageVaultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="exascaleDbStorageVaultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExascaleDbStorageVaultName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string exascaleDbStorageVaultName, out ExascaleDbStorageVaultName result) =>
            TryParse(exascaleDbStorageVaultName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExascaleDbStorageVaultName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="exascaleDbStorageVaultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExascaleDbStorageVaultName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string exascaleDbStorageVaultName, bool allowUnparsed, out ExascaleDbStorageVaultName result)
        {
            gax::GaxPreconditions.CheckNotNull(exascaleDbStorageVaultName, nameof(exascaleDbStorageVaultName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationExascaleDbStorageVault.TryParseName(exascaleDbStorageVaultName, out resourceName))
            {
                result = FromProjectLocationExascaleDbStorageVault(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(exascaleDbStorageVaultName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExascaleDbStorageVaultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string exascaleDbStorageVaultId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExascaleDbStorageVaultId = exascaleDbStorageVaultId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExascaleDbStorageVaultName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="exascaleDbStorageVaultId">
        /// The <c>ExascaleDbStorageVault</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ExascaleDbStorageVaultName(string projectId, string locationId, string exascaleDbStorageVaultId) : this(ResourceNameType.ProjectLocationExascaleDbStorageVault, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), exascaleDbStorageVaultId: gax::GaxPreconditions.CheckNotNullOrEmpty(exascaleDbStorageVaultId, nameof(exascaleDbStorageVaultId)))
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
        /// The <c>ExascaleDbStorageVault</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ExascaleDbStorageVaultId { get; }

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
                case ResourceNameType.ProjectLocationExascaleDbStorageVault: return s_projectLocationExascaleDbStorageVault.Expand(ProjectId, LocationId, ExascaleDbStorageVaultId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExascaleDbStorageVaultName);

        /// <inheritdoc/>
        public bool Equals(ExascaleDbStorageVaultName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExascaleDbStorageVaultName a, ExascaleDbStorageVaultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExascaleDbStorageVaultName a, ExascaleDbStorageVaultName b) => !(a == b);
    }

    public partial class ExascaleDbStorageVault
    {
        /// <summary>
        /// <see cref="gcov::ExascaleDbStorageVaultName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcov::ExascaleDbStorageVaultName ExascaleDbStorageVaultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::ExascaleDbStorageVaultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetExascaleDbStorageVaultRequest
    {
        /// <summary>
        /// <see cref="gcov::ExascaleDbStorageVaultName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcov::ExascaleDbStorageVaultName ExascaleDbStorageVaultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::ExascaleDbStorageVaultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListExascaleDbStorageVaultsRequest
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

    public partial class CreateExascaleDbStorageVaultRequest
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

    public partial class DeleteExascaleDbStorageVaultRequest
    {
        /// <summary>
        /// <see cref="gcov::ExascaleDbStorageVaultName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcov::ExascaleDbStorageVaultName ExascaleDbStorageVaultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcov::ExascaleDbStorageVaultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
