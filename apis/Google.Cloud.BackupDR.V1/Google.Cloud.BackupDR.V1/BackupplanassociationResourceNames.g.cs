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
using gcbv = Google.Cloud.BackupDR.V1;
using sys = System;

namespace Google.Cloud.BackupDR.V1
{
    /// <summary>Resource name for the <c>BackupPlanAssociation</c> resource.</summary>
    public sealed partial class BackupPlanAssociationName : gax::IResourceName, sys::IEquatable<BackupPlanAssociationName>
    {
        /// <summary>The possible contents of <see cref="BackupPlanAssociationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}</c>.
            /// </summary>
            ProjectLocationBackupPlanAssociation = 1,
        }

        private static gax::PathTemplate s_projectLocationBackupPlanAssociation = new gax::PathTemplate("projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}");

        /// <summary>Creates a <see cref="BackupPlanAssociationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BackupPlanAssociationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BackupPlanAssociationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BackupPlanAssociationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BackupPlanAssociationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanAssociationId">
        /// The <c>BackupPlanAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="BackupPlanAssociationName"/> constructed from the provided ids.
        /// </returns>
        public static BackupPlanAssociationName FromProjectLocationBackupPlanAssociation(string projectId, string locationId, string backupPlanAssociationId) =>
            new BackupPlanAssociationName(ResourceNameType.ProjectLocationBackupPlanAssociation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupPlanAssociationId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanAssociationId, nameof(backupPlanAssociationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupPlanAssociationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanAssociationId">
        /// The <c>BackupPlanAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="BackupPlanAssociationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string backupPlanAssociationId) =>
            FormatProjectLocationBackupPlanAssociation(projectId, locationId, backupPlanAssociationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupPlanAssociationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanAssociationId">
        /// The <c>BackupPlanAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="BackupPlanAssociationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}</c>.
        /// </returns>
        public static string FormatProjectLocationBackupPlanAssociation(string projectId, string locationId, string backupPlanAssociationId) =>
            s_projectLocationBackupPlanAssociation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanAssociationId, nameof(backupPlanAssociationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupPlanAssociationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupPlanAssociationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BackupPlanAssociationName"/> if successful.</returns>
        public static BackupPlanAssociationName Parse(string backupPlanAssociationName) =>
            Parse(backupPlanAssociationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupPlanAssociationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupPlanAssociationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BackupPlanAssociationName"/> if successful.</returns>
        public static BackupPlanAssociationName Parse(string backupPlanAssociationName, bool allowUnparsed) =>
            TryParse(backupPlanAssociationName, allowUnparsed, out BackupPlanAssociationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupPlanAssociationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupPlanAssociationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupPlanAssociationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupPlanAssociationName, out BackupPlanAssociationName result) =>
            TryParse(backupPlanAssociationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupPlanAssociationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupPlanAssociationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupPlanAssociationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupPlanAssociationName, bool allowUnparsed, out BackupPlanAssociationName result)
        {
            gax::GaxPreconditions.CheckNotNull(backupPlanAssociationName, nameof(backupPlanAssociationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBackupPlanAssociation.TryParseName(backupPlanAssociationName, out resourceName))
            {
                result = FromProjectLocationBackupPlanAssociation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(backupPlanAssociationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BackupPlanAssociationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backupPlanAssociationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackupPlanAssociationId = backupPlanAssociationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BackupPlanAssociationName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/backupPlanAssociations/{backup_plan_association}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanAssociationId">
        /// The <c>BackupPlanAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public BackupPlanAssociationName(string projectId, string locationId, string backupPlanAssociationId) : this(ResourceNameType.ProjectLocationBackupPlanAssociation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupPlanAssociationId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanAssociationId, nameof(backupPlanAssociationId)))
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
        /// The <c>BackupPlanAssociation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string BackupPlanAssociationId { get; }

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
                case ResourceNameType.ProjectLocationBackupPlanAssociation: return s_projectLocationBackupPlanAssociation.Expand(ProjectId, LocationId, BackupPlanAssociationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BackupPlanAssociationName);

        /// <inheritdoc/>
        public bool Equals(BackupPlanAssociationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BackupPlanAssociationName a, BackupPlanAssociationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BackupPlanAssociationName a, BackupPlanAssociationName b) => !(a == b);
    }

    public partial class BackupPlanAssociation
    {
        /// <summary>
        /// <see cref="gcbv::BackupPlanAssociationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupPlanAssociationName BackupPlanAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupPlanAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BackupPlanName"/>-typed view over the <see cref="BackupPlan"/> resource name property.
        /// </summary>
        public BackupPlanName BackupPlanAsBackupPlanName
        {
            get => string.IsNullOrEmpty(BackupPlan) ? null : BackupPlanName.Parse(BackupPlan, allowUnparsed: true);
            set => BackupPlan = value?.ToString() ?? "";
        }
    }

    public partial class CreateBackupPlanAssociationRequest
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

    public partial class ListBackupPlanAssociationsRequest
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

    public partial class GetBackupPlanAssociationRequest
    {
        /// <summary>
        /// <see cref="gcbv::BackupPlanAssociationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupPlanAssociationName BackupPlanAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupPlanAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBackupPlanAssociationRequest
    {
        /// <summary>
        /// <see cref="gcbv::BackupPlanAssociationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupPlanAssociationName BackupPlanAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupPlanAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TriggerBackupRequest
    {
        /// <summary>
        /// <see cref="gcbv::BackupPlanAssociationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupPlanAssociationName BackupPlanAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupPlanAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
