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
using gcbv = Google.Cloud.BackupDR.V1;
using sys = System;

namespace Google.Cloud.BackupDR.V1
{
    /// <summary>Resource name for the <c>BackupPlan</c> resource.</summary>
    public sealed partial class BackupPlanName : gax::IResourceName, sys::IEquatable<BackupPlanName>
    {
        /// <summary>The possible contents of <see cref="BackupPlanName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}</c>.
            /// </summary>
            ProjectLocationBackupPlan = 1,
        }

        private static gax::PathTemplate s_projectLocationBackupPlan = new gax::PathTemplate("projects/{project}/locations/{location}/backupPlans/{backup_plan}");

        /// <summary>Creates a <see cref="BackupPlanName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BackupPlanName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BackupPlanName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BackupPlanName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BackupPlanName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BackupPlanName"/> constructed from the provided ids.</returns>
        public static BackupPlanName FromProjectLocationBackupPlan(string projectId, string locationId, string backupPlanId) =>
            new BackupPlanName(ResourceNameType.ProjectLocationBackupPlan, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupPlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupPlanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupPlanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string backupPlanId) =>
            FormatProjectLocationBackupPlan(projectId, locationId, backupPlanId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupPlanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupPlanName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}</c>.
        /// </returns>
        public static string FormatProjectLocationBackupPlan(string projectId, string locationId, string backupPlanId) =>
            s_projectLocationBackupPlan.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)));

        /// <summary>Parses the given resource name string into a new <see cref="BackupPlanName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupPlans/{backup_plan}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupPlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BackupPlanName"/> if successful.</returns>
        public static BackupPlanName Parse(string backupPlanName) => Parse(backupPlanName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupPlanName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupPlans/{backup_plan}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupPlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BackupPlanName"/> if successful.</returns>
        public static BackupPlanName Parse(string backupPlanName, bool allowUnparsed) =>
            TryParse(backupPlanName, allowUnparsed, out BackupPlanName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupPlanName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupPlans/{backup_plan}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupPlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupPlanName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupPlanName, out BackupPlanName result) =>
            TryParse(backupPlanName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupPlanName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/backupPlans/{backup_plan}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupPlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupPlanName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupPlanName, bool allowUnparsed, out BackupPlanName result)
        {
            gax::GaxPreconditions.CheckNotNull(backupPlanName, nameof(backupPlanName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBackupPlan.TryParseName(backupPlanName, out resourceName))
            {
                result = FromProjectLocationBackupPlan(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(backupPlanName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BackupPlanName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backupPlanId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackupPlanId = backupPlanId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BackupPlanName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        public BackupPlanName(string projectId, string locationId, string backupPlanId) : this(ResourceNameType.ProjectLocationBackupPlan, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupPlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)))
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
        /// The <c>BackupPlan</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BackupPlanId { get; }

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
                case ResourceNameType.ProjectLocationBackupPlan: return s_projectLocationBackupPlan.Expand(ProjectId, LocationId, BackupPlanId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BackupPlanName);

        /// <inheritdoc/>
        public bool Equals(BackupPlanName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BackupPlanName a, BackupPlanName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BackupPlanName a, BackupPlanName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>BackupPlanRevision</c> resource.</summary>
    public sealed partial class BackupPlanRevisionName : gax::IResourceName, sys::IEquatable<BackupPlanRevisionName>
    {
        /// <summary>The possible contents of <see cref="BackupPlanRevisionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}</c>.
            /// </summary>
            ProjectLocationBackupPlanRevision = 1,
        }

        private static gax::PathTemplate s_projectLocationBackupPlanRevision = new gax::PathTemplate("projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}");

        /// <summary>Creates a <see cref="BackupPlanRevisionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BackupPlanRevisionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BackupPlanRevisionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BackupPlanRevisionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BackupPlanRevisionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BackupPlanRevisionName"/> constructed from the provided ids.</returns>
        public static BackupPlanRevisionName FromProjectLocationBackupPlanRevision(string projectId, string locationId, string backupPlanId, string revisionId) =>
            new BackupPlanRevisionName(ResourceNameType.ProjectLocationBackupPlanRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupPlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupPlanRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupPlanRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string backupPlanId, string revisionId) =>
            FormatProjectLocationBackupPlanRevision(projectId, locationId, backupPlanId, revisionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BackupPlanRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BackupPlanRevisionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}</c>.
        /// </returns>
        public static string FormatProjectLocationBackupPlanRevision(string projectId, string locationId, string backupPlanId, string revisionId) =>
            s_projectLocationBackupPlanRevision.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)), gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupPlanRevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupPlanRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BackupPlanRevisionName"/> if successful.</returns>
        public static BackupPlanRevisionName Parse(string backupPlanRevisionName) => Parse(backupPlanRevisionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BackupPlanRevisionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupPlanRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BackupPlanRevisionName"/> if successful.</returns>
        public static BackupPlanRevisionName Parse(string backupPlanRevisionName, bool allowUnparsed) =>
            TryParse(backupPlanRevisionName, allowUnparsed, out BackupPlanRevisionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupPlanRevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="backupPlanRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupPlanRevisionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupPlanRevisionName, out BackupPlanRevisionName result) =>
            TryParse(backupPlanRevisionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BackupPlanRevisionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="backupPlanRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BackupPlanRevisionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string backupPlanRevisionName, bool allowUnparsed, out BackupPlanRevisionName result)
        {
            gax::GaxPreconditions.CheckNotNull(backupPlanRevisionName, nameof(backupPlanRevisionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationBackupPlanRevision.TryParseName(backupPlanRevisionName, out resourceName))
            {
                result = FromProjectLocationBackupPlanRevision(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(backupPlanRevisionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BackupPlanRevisionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string backupPlanId = null, string locationId = null, string projectId = null, string revisionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BackupPlanId = backupPlanId;
            LocationId = locationId;
            ProjectId = projectId;
            RevisionId = revisionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BackupPlanRevisionName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/backupPlans/{backup_plan}/revisions/{revision}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="backupPlanId">The <c>BackupPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        public BackupPlanRevisionName(string projectId, string locationId, string backupPlanId, string revisionId) : this(ResourceNameType.ProjectLocationBackupPlanRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), backupPlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)))
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
        /// The <c>BackupPlan</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BackupPlanId { get; }

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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationBackupPlanRevision: return s_projectLocationBackupPlanRevision.Expand(ProjectId, LocationId, BackupPlanId, RevisionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BackupPlanRevisionName);

        /// <inheritdoc/>
        public bool Equals(BackupPlanRevisionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BackupPlanRevisionName a, BackupPlanRevisionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BackupPlanRevisionName a, BackupPlanRevisionName b) => !(a == b);
    }

    public partial class BackupPlan
    {
        /// <summary>
        /// <see cref="gcbv::BackupPlanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupPlanName BackupPlanName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupPlanName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BackupVaultName"/>-typed view over the <see cref="BackupVault"/> resource name property.
        /// </summary>
        public BackupVaultName BackupVaultAsBackupVaultName
        {
            get => string.IsNullOrEmpty(BackupVault) ? null : BackupVaultName.Parse(BackupVault, allowUnparsed: true);
            set => BackupVault = value?.ToString() ?? "";
        }
    }

    public partial class CreateBackupPlanRequest
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

    public partial class ListBackupPlansRequest
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

    public partial class GetBackupPlanRequest
    {
        /// <summary>
        /// <see cref="gcbv::BackupPlanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupPlanName BackupPlanName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupPlanName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteBackupPlanRequest
    {
        /// <summary>
        /// <see cref="gcbv::BackupPlanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupPlanName BackupPlanName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupPlanName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BackupPlanRevision
    {
        /// <summary>
        /// <see cref="gcbv::BackupPlanRevisionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupPlanRevisionName BackupPlanRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupPlanRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetBackupPlanRevisionRequest
    {
        /// <summary>
        /// <see cref="gcbv::BackupPlanRevisionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::BackupPlanRevisionName BackupPlanRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::BackupPlanRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBackupPlanRevisionsRequest
    {
        /// <summary>
        /// <see cref="BackupPlanName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public BackupPlanName ParentAsBackupPlanName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BackupPlanName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
