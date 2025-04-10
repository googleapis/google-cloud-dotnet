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
using gccv = Google.Cloud.Chronicle.V1;
using sys = System;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Resource name for the <c>DataAccessLabel</c> resource.</summary>
    public sealed partial class DataAccessLabelName : gax::IResourceName, sys::IEquatable<DataAccessLabelName>
    {
        /// <summary>The possible contents of <see cref="DataAccessLabelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceDataAccessLabel = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceDataAccessLabel = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}");

        /// <summary>Creates a <see cref="DataAccessLabelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataAccessLabelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataAccessLabelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataAccessLabelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataAccessLabelName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAccessLabelId">The <c>DataAccessLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataAccessLabelName"/> constructed from the provided ids.</returns>
        public static DataAccessLabelName FromProjectLocationInstanceDataAccessLabel(string projectId, string locationId, string instanceId, string dataAccessLabelId) =>
            new DataAccessLabelName(ResourceNameType.ProjectLocationInstanceDataAccessLabel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dataAccessLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessLabelId, nameof(dataAccessLabelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAccessLabelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAccessLabelId">The <c>DataAccessLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataAccessLabelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string dataAccessLabelId) =>
            FormatProjectLocationInstanceDataAccessLabel(projectId, locationId, instanceId, dataAccessLabelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAccessLabelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAccessLabelId">The <c>DataAccessLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataAccessLabelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceDataAccessLabel(string projectId, string locationId, string instanceId, string dataAccessLabelId) =>
            s_projectLocationInstanceDataAccessLabel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessLabelId, nameof(dataAccessLabelId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataAccessLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAccessLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataAccessLabelName"/> if successful.</returns>
        public static DataAccessLabelName Parse(string dataAccessLabelName) => Parse(dataAccessLabelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataAccessLabelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAccessLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataAccessLabelName"/> if successful.</returns>
        public static DataAccessLabelName Parse(string dataAccessLabelName, bool allowUnparsed) =>
            TryParse(dataAccessLabelName, allowUnparsed, out DataAccessLabelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAccessLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAccessLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAccessLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAccessLabelName, out DataAccessLabelName result) =>
            TryParse(dataAccessLabelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAccessLabelName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAccessLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAccessLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAccessLabelName, bool allowUnparsed, out DataAccessLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataAccessLabelName, nameof(dataAccessLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceDataAccessLabel.TryParseName(dataAccessLabelName, out resourceName))
            {
                result = FromProjectLocationInstanceDataAccessLabel(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataAccessLabelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataAccessLabelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataAccessLabelId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataAccessLabelId = dataAccessLabelId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataAccessLabelName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAccessLabelId">The <c>DataAccessLabel</c> ID. Must not be <c>null</c> or empty.</param>
        public DataAccessLabelName(string projectId, string locationId, string instanceId, string dataAccessLabelId) : this(ResourceNameType.ProjectLocationInstanceDataAccessLabel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dataAccessLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessLabelId, nameof(dataAccessLabelId)))
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
        /// The <c>DataAccessLabel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DataAccessLabelId { get; }

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
                case ResourceNameType.ProjectLocationInstanceDataAccessLabel: return s_projectLocationInstanceDataAccessLabel.Expand(ProjectId, LocationId, InstanceId, DataAccessLabelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataAccessLabelName);

        /// <inheritdoc/>
        public bool Equals(DataAccessLabelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataAccessLabelName a, DataAccessLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataAccessLabelName a, DataAccessLabelName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataAccessScope</c> resource.</summary>
    public sealed partial class DataAccessScopeName : gax::IResourceName, sys::IEquatable<DataAccessScopeName>
    {
        /// <summary>The possible contents of <see cref="DataAccessScopeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceDataAccessScope = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceDataAccessScope = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}");

        /// <summary>Creates a <see cref="DataAccessScopeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataAccessScopeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataAccessScopeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataAccessScopeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataAccessScopeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAccessScopeId">The <c>DataAccessScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataAccessScopeName"/> constructed from the provided ids.</returns>
        public static DataAccessScopeName FromProjectLocationInstanceDataAccessScope(string projectId, string locationId, string instanceId, string dataAccessScopeId) =>
            new DataAccessScopeName(ResourceNameType.ProjectLocationInstanceDataAccessScope, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dataAccessScopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessScopeId, nameof(dataAccessScopeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAccessScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAccessScopeId">The <c>DataAccessScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataAccessScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string dataAccessScopeId) =>
            FormatProjectLocationInstanceDataAccessScope(projectId, locationId, instanceId, dataAccessScopeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAccessScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAccessScopeId">The <c>DataAccessScope</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataAccessScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceDataAccessScope(string projectId, string locationId, string instanceId, string dataAccessScopeId) =>
            s_projectLocationInstanceDataAccessScope.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessScopeId, nameof(dataAccessScopeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataAccessScopeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAccessScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataAccessScopeName"/> if successful.</returns>
        public static DataAccessScopeName Parse(string dataAccessScopeName) => Parse(dataAccessScopeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataAccessScopeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAccessScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataAccessScopeName"/> if successful.</returns>
        public static DataAccessScopeName Parse(string dataAccessScopeName, bool allowUnparsed) =>
            TryParse(dataAccessScopeName, allowUnparsed, out DataAccessScopeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAccessScopeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAccessScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAccessScopeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAccessScopeName, out DataAccessScopeName result) =>
            TryParse(dataAccessScopeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAccessScopeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAccessScopeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAccessScopeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAccessScopeName, bool allowUnparsed, out DataAccessScopeName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataAccessScopeName, nameof(dataAccessScopeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceDataAccessScope.TryParseName(dataAccessScopeName, out resourceName))
            {
                result = FromProjectLocationInstanceDataAccessScope(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataAccessScopeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataAccessScopeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataAccessScopeId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataAccessScopeId = dataAccessScopeId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataAccessScopeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAccessScopeId">The <c>DataAccessScope</c> ID. Must not be <c>null</c> or empty.</param>
        public DataAccessScopeName(string projectId, string locationId, string instanceId, string dataAccessScopeId) : this(ResourceNameType.ProjectLocationInstanceDataAccessScope, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), dataAccessScopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessScopeId, nameof(dataAccessScopeId)))
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
        /// The <c>DataAccessScope</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DataAccessScopeId { get; }

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
                case ResourceNameType.ProjectLocationInstanceDataAccessScope: return s_projectLocationInstanceDataAccessScope.Expand(ProjectId, LocationId, InstanceId, DataAccessScopeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataAccessScopeName);

        /// <inheritdoc/>
        public bool Equals(DataAccessScopeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataAccessScopeName a, DataAccessScopeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataAccessScopeName a, DataAccessScopeName b) => !(a == b);
    }

    public partial class CreateDataAccessLabelRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDataAccessLabelRequest
    {
        /// <summary>
        /// <see cref="gccv::DataAccessLabelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataAccessLabelName DataAccessLabelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataAccessLabelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataAccessLabelsRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDataAccessLabelRequest
    {
        /// <summary>
        /// <see cref="gccv::DataAccessLabelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataAccessLabelName DataAccessLabelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataAccessLabelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDataAccessScopeRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDataAccessScopeRequest
    {
        /// <summary>
        /// <see cref="gccv::DataAccessScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataAccessScopeName DataAccessScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataAccessScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataAccessScopesRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDataAccessScopeRequest
    {
        /// <summary>
        /// <see cref="gccv::DataAccessScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataAccessScopeName DataAccessScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataAccessScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DataAccessLabel
    {
        /// <summary>
        /// <see cref="gccv::DataAccessLabelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataAccessLabelName DataAccessLabelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataAccessLabelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DataAccessScope
    {
        /// <summary>
        /// <see cref="gccv::DataAccessScopeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::DataAccessScopeName DataAccessScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::DataAccessScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
