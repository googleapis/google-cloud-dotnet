// Copyright 2020 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gcbsv = Google.Cloud.BigQuery.Storage.V1;
using sys = System;

namespace Google.Cloud.BigQuery.Storage.V1
{
    /// <summary>Resource name for the <c>Table</c> resource.</summary>
    public sealed partial class TableName : gax::IResourceName, sys::IEquatable<TableName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/datasets/{dataset}/tables/{table}");

        /// <summary>
        /// Parses the given <c>Table</c> resource name in string form into a new <see cref="TableName"/> instance.
        /// </summary>
        /// <param name="tableName">The <c>Table</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TableName"/> if successful.</returns>
        public static TableName Parse(string tableName)
        {
            gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(tableName);
            return new TableName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="TableName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="tableName"/> is <c>null</c>
        /// , as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="tableName">The <c>Table</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TableName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tableName, out TableName result)
        {
            gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            if (s_template.TryParseName(tableName, out gax::TemplatedResourceName resourceName))
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

        /// <summary>Formats the IDs into the string representation of the <see cref="TableName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c>.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="TableName"/>.</returns>
        public static string Format(string projectId, string datasetId, string tableId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNull(tableId, nameof(tableId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="TableName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c>.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c>.</param>
        public TableName(string projectId, string datasetId, string tableId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DatasetId = gax::GaxPreconditions.CheckNotNull(datasetId, nameof(datasetId));
            TableId = gax::GaxPreconditions.CheckNotNull(tableId, nameof(tableId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Dataset</c> ID. Never <c>null</c>.</summary>
        public string DatasetId { get; }

        /// <summary>The <c>Table</c> ID. Never <c>null</c>.</summary>
        public string TableId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, DatasetId, TableId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TableName);

        /// <inheritdoc/>
        public bool Equals(TableName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(TableName a, TableName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(TableName a, TableName b) => !(a == b);
    }

    public partial class CreateReadSessionRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ReadRowsRequest
    {
        /// <summary>
        /// <see cref="ReadStreamName"/>-typed view over the <see cref="ReadStream"/> resource name property.
        /// </summary>
        public ReadStreamName ReadStreamAsReadStreamName
        {
            get => string.IsNullOrEmpty(ReadStream) ? null : ReadStreamName.Parse(ReadStream);
            set => ReadStream = value?.ToString() ?? "";
        }
    }

    public partial class SplitReadStreamRequest
    {
        /// <summary>
        /// <see cref="gcbsv::ReadStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbsv::ReadStreamName ReadStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbsv::ReadStreamName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
