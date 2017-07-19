// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using System;
using System.Linq;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Resource name for the 'table' resource.
    /// </summary>
    public sealed partial class TableName : IResourceName, IEquatable<TableName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/instances/{instance}/tables/{table}");

        /// <summary>
        /// Parses the given table resource name in string form into a new
        /// <see cref="TableName"/> instance.
        /// </summary>
        /// <param name="tableName">The table resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TableName"/> if successful.</returns>
        public static TableName Parse(string tableName)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            TemplatedResourceName resourceName = s_template.ParseName(tableName);
            return new TableName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given table resource name in string form into a new
        /// <see cref="TableName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="tableName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="tableName">The table resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TableName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableName, out TableName result)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(tableName, out resourceName))
            {
                result = new TableName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="TableName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        /// <param name="tableId">The table ID. Must not be <c>null</c>.</param>
        public TableName(string projectId, string instanceId, string tableId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
            TableId = GaxPreconditions.CheckNotNull(tableId, nameof(tableId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The instance ID. Never <c>null</c>.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The table ID. Never <c>null</c>.
        /// </summary>
        public string TableId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceId, TableId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TableName);

        /// <inheritdoc />
        public bool Equals(TableName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TableName a, TableName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TableName a, TableName b) => !(a == b);
    }



}