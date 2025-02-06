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
using gcbv = Google.Cloud.Bigtable.V2;
using sys = System;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>Resource name for the <c>Instance</c> resource.</summary>
    public sealed partial class InstanceName : gax::IResourceName, sys::IEquatable<InstanceName>
    {
        /// <summary>The possible contents of <see cref="InstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/instances/{instance}</c>.</summary>
            ProjectInstance = 1,
        }

        private static gax::PathTemplate s_projectInstance = new gax::PathTemplate("projects/{project}/instances/{instance}");

        /// <summary>Creates a <see cref="InstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static InstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceName"/> with the pattern <c>projects/{project}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstanceName"/> constructed from the provided ids.</returns>
        public static InstanceName FromProjectInstance(string projectId, string instanceId) =>
            new InstanceName(ResourceNameType.ProjectInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceId) => FormatProjectInstance(projectId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </returns>
        public static string FormatProjectInstance(string projectId, string instanceId) =>
            s_projectInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>Parses the given resource name string into a new <see cref="InstanceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
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
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
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
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
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
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
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
            if (s_projectInstance.TryParseName(instanceName, out resourceName))
            {
                result = FromProjectInstance(resourceName[0], resourceName[1]);
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

        private InstanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/instances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceName(string projectId, string instanceId) : this(ResourceNameType.ProjectInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
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
                case ResourceNameType.ProjectInstance: return s_projectInstance.Expand(ProjectId, InstanceId);
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

    /// <summary>Resource name for the <c>Table</c> resource.</summary>
    public sealed partial class TableName : gax::IResourceName, sys::IEquatable<TableName>
    {
        /// <summary>The possible contents of <see cref="TableName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/instances/{instance}/tables/{table}</c>.
            /// </summary>
            ProjectInstanceTable = 1,
        }

        private static gax::PathTemplate s_projectInstanceTable = new gax::PathTemplate("projects/{project}/instances/{instance}/tables/{table}");

        /// <summary>Creates a <see cref="TableName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TableName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TableName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TableName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TableName"/> with the pattern <c>projects/{project}/instances/{instance}/tables/{table}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TableName"/> constructed from the provided ids.</returns>
        public static TableName FromProjectInstanceTable(string projectId, string instanceId, string tableId) =>
            new TableName(ResourceNameType.ProjectInstanceTable, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/tables/{table}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/tables/{table}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceId, string tableId) =>
            FormatProjectInstanceTable(projectId, instanceId, tableId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/tables/{table}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TableName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/tables/{table}</c>.
        /// </returns>
        public static string FormatProjectInstanceTable(string projectId, string instanceId, string tableId) =>
            s_projectInstanceTable.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)));

        /// <summary>Parses the given resource name string into a new <see cref="TableName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}/tables/{table}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TableName"/> if successful.</returns>
        public static TableName Parse(string tableName) => Parse(tableName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TableName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}/tables/{table}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TableName"/> if successful.</returns>
        public static TableName Parse(string tableName, bool allowUnparsed) =>
            TryParse(tableName, allowUnparsed, out TableName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TableName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}/tables/{table}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TableName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableName, out TableName result) => TryParse(tableName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TableName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}/tables/{table}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tableName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TableName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableName, bool allowUnparsed, out TableName result)
        {
            gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            gax::TemplatedResourceName resourceName;
            if (s_projectInstanceTable.TryParseName(tableName, out resourceName))
            {
                result = FromProjectInstanceTable(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tableName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TableName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string projectId = null, string tableId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            ProjectId = projectId;
            TableId = tableId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TableName"/> class from the component parts of pattern
        /// <c>projects/{project}/instances/{instance}/tables/{table}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        public TableName(string projectId, string instanceId, string tableId) : this(ResourceNameType.ProjectInstanceTable, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Table</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TableId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectInstanceTable: return s_projectInstanceTable.Expand(ProjectId, InstanceId, TableId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TableName);

        /// <inheritdoc/>
        public bool Equals(TableName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TableName a, TableName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TableName a, TableName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AuthorizedView</c> resource.</summary>
    public sealed partial class AuthorizedViewName : gax::IResourceName, sys::IEquatable<AuthorizedViewName>
    {
        /// <summary>The possible contents of <see cref="AuthorizedViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}</c>.
            /// </summary>
            ProjectInstanceTableAuthorizedView = 1,
        }

        private static gax::PathTemplate s_projectInstanceTableAuthorizedView = new gax::PathTemplate("projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}");

        /// <summary>Creates a <see cref="AuthorizedViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AuthorizedViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AuthorizedViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AuthorizedViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AuthorizedViewName"/> with the pattern
        /// <c>projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="authorizedViewId">The <c>AuthorizedView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AuthorizedViewName"/> constructed from the provided ids.</returns>
        public static AuthorizedViewName FromProjectInstanceTableAuthorizedView(string projectId, string instanceId, string tableId, string authorizedViewId) =>
            new AuthorizedViewName(ResourceNameType.ProjectInstanceTableAuthorizedView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)), authorizedViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(authorizedViewId, nameof(authorizedViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuthorizedViewName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="authorizedViewId">The <c>AuthorizedView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AuthorizedViewName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceId, string tableId, string authorizedViewId) =>
            FormatProjectInstanceTableAuthorizedView(projectId, instanceId, tableId, authorizedViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuthorizedViewName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="authorizedViewId">The <c>AuthorizedView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AuthorizedViewName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}</c>.
        /// </returns>
        public static string FormatProjectInstanceTableAuthorizedView(string projectId, string instanceId, string tableId, string authorizedViewId) =>
            s_projectInstanceTableAuthorizedView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)), gax::GaxPreconditions.CheckNotNullOrEmpty(authorizedViewId, nameof(authorizedViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AuthorizedViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="authorizedViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AuthorizedViewName"/> if successful.</returns>
        public static AuthorizedViewName Parse(string authorizedViewName) => Parse(authorizedViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AuthorizedViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="authorizedViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AuthorizedViewName"/> if successful.</returns>
        public static AuthorizedViewName Parse(string authorizedViewName, bool allowUnparsed) =>
            TryParse(authorizedViewName, allowUnparsed, out AuthorizedViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AuthorizedViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="authorizedViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AuthorizedViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string authorizedViewName, out AuthorizedViewName result) =>
            TryParse(authorizedViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AuthorizedViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="authorizedViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AuthorizedViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string authorizedViewName, bool allowUnparsed, out AuthorizedViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(authorizedViewName, nameof(authorizedViewName));
            gax::TemplatedResourceName resourceName;
            if (s_projectInstanceTableAuthorizedView.TryParseName(authorizedViewName, out resourceName))
            {
                result = FromProjectInstanceTableAuthorizedView(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(authorizedViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AuthorizedViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string authorizedViewId = null, string instanceId = null, string projectId = null, string tableId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AuthorizedViewId = authorizedViewId;
            InstanceId = instanceId;
            ProjectId = projectId;
            TableId = tableId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AuthorizedViewName"/> class from the component parts of pattern
        /// <c>projects/{project}/instances/{instance}/tables/{table}/authorizedViews/{authorized_view}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="authorizedViewId">The <c>AuthorizedView</c> ID. Must not be <c>null</c> or empty.</param>
        public AuthorizedViewName(string projectId, string instanceId, string tableId, string authorizedViewId) : this(ResourceNameType.ProjectInstanceTableAuthorizedView, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)), authorizedViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(authorizedViewId, nameof(authorizedViewId)))
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
        /// The <c>AuthorizedView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AuthorizedViewId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Table</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TableId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectInstanceTableAuthorizedView: return s_projectInstanceTableAuthorizedView.Expand(ProjectId, InstanceId, TableId, AuthorizedViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AuthorizedViewName);

        /// <inheritdoc/>
        public bool Equals(AuthorizedViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AuthorizedViewName a, AuthorizedViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AuthorizedViewName a, AuthorizedViewName b) => !(a == b);
    }

    public partial class ReadRowsRequest
    {
        /// <summary>
        /// <see cref="gcbv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcbv::AuthorizedViewName"/>-typed view over the <see cref="AuthorizedViewName"/> resource name
        /// property.
        /// </summary>
        public gcbv::AuthorizedViewName AuthorizedViewNameAsAuthorizedViewName
        {
            get => string.IsNullOrEmpty(AuthorizedViewName) ? null : gcbv::AuthorizedViewName.Parse(AuthorizedViewName, allowUnparsed: true);
            set => AuthorizedViewName = value?.ToString() ?? "";
        }
    }

    public partial class SampleRowKeysRequest
    {
        /// <summary>
        /// <see cref="gcbv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcbv::AuthorizedViewName"/>-typed view over the <see cref="AuthorizedViewName"/> resource name
        /// property.
        /// </summary>
        public gcbv::AuthorizedViewName AuthorizedViewNameAsAuthorizedViewName
        {
            get => string.IsNullOrEmpty(AuthorizedViewName) ? null : gcbv::AuthorizedViewName.Parse(AuthorizedViewName, allowUnparsed: true);
            set => AuthorizedViewName = value?.ToString() ?? "";
        }
    }

    public partial class MutateRowRequest
    {
        /// <summary>
        /// <see cref="gcbv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcbv::AuthorizedViewName"/>-typed view over the <see cref="AuthorizedViewName"/> resource name
        /// property.
        /// </summary>
        public gcbv::AuthorizedViewName AuthorizedViewNameAsAuthorizedViewName
        {
            get => string.IsNullOrEmpty(AuthorizedViewName) ? null : gcbv::AuthorizedViewName.Parse(AuthorizedViewName, allowUnparsed: true);
            set => AuthorizedViewName = value?.ToString() ?? "";
        }
    }

    public partial class MutateRowsRequest
    {
        /// <summary>
        /// <see cref="gcbv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcbv::AuthorizedViewName"/>-typed view over the <see cref="AuthorizedViewName"/> resource name
        /// property.
        /// </summary>
        public gcbv::AuthorizedViewName AuthorizedViewNameAsAuthorizedViewName
        {
            get => string.IsNullOrEmpty(AuthorizedViewName) ? null : gcbv::AuthorizedViewName.Parse(AuthorizedViewName, allowUnparsed: true);
            set => AuthorizedViewName = value?.ToString() ?? "";
        }
    }

    public partial class CheckAndMutateRowRequest
    {
        /// <summary>
        /// <see cref="gcbv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcbv::AuthorizedViewName"/>-typed view over the <see cref="AuthorizedViewName"/> resource name
        /// property.
        /// </summary>
        public gcbv::AuthorizedViewName AuthorizedViewNameAsAuthorizedViewName
        {
            get => string.IsNullOrEmpty(AuthorizedViewName) ? null : gcbv::AuthorizedViewName.Parse(AuthorizedViewName, allowUnparsed: true);
            set => AuthorizedViewName = value?.ToString() ?? "";
        }
    }

    public partial class PingAndWarmRequest
    {
        /// <summary>
        /// <see cref="gcbv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReadModifyWriteRowRequest
    {
        /// <summary>
        /// <see cref="gcbv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcbv::AuthorizedViewName"/>-typed view over the <see cref="AuthorizedViewName"/> resource name
        /// property.
        /// </summary>
        public gcbv::AuthorizedViewName AuthorizedViewNameAsAuthorizedViewName
        {
            get => string.IsNullOrEmpty(AuthorizedViewName) ? null : gcbv::AuthorizedViewName.Parse(AuthorizedViewName, allowUnparsed: true);
            set => AuthorizedViewName = value?.ToString() ?? "";
        }
    }

    public partial class GenerateInitialChangeStreamPartitionsRequest
    {
        /// <summary>
        /// <see cref="gcbv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }
    }

    public partial class ReadChangeStreamRequest
    {
        /// <summary>
        /// <see cref="gcbv::TableName"/>-typed view over the <see cref="TableName"/> resource name property.
        /// </summary>
        public gcbv::TableName TableNameAsTableName
        {
            get => string.IsNullOrEmpty(TableName) ? null : gcbv::TableName.Parse(TableName, allowUnparsed: true);
            set => TableName = value?.ToString() ?? "";
        }
    }

    public partial class ExecuteQueryRequest
    {
        /// <summary>
        /// <see cref="gcbv::InstanceName"/>-typed view over the <see cref="InstanceName"/> resource name property.
        /// </summary>
        public gcbv::InstanceName InstanceNameAsInstanceName
        {
            get => string.IsNullOrEmpty(InstanceName) ? null : gcbv::InstanceName.Parse(InstanceName, allowUnparsed: true);
            set => InstanceName = value?.ToString() ?? "";
        }
    }
}
