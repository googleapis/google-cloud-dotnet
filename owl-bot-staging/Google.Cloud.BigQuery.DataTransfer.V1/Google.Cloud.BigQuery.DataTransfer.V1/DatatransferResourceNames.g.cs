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
using gcbdv = Google.Cloud.BigQuery.DataTransfer.V1;
using sys = System;

namespace Google.Cloud.BigQuery.DataTransfer.V1
{
    /// <summary>Resource name for the <c>DataSource</c> resource.</summary>
    public sealed partial class DataSourceName : gax::IResourceName, sys::IEquatable<DataSourceName>
    {
        /// <summary>The possible contents of <see cref="DataSourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/dataSources/{data_source}</c>.</summary>
            ProjectDataSource = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dataSources/{data_source}</c>.
            /// </summary>
            ProjectLocationDataSource = 2,
        }

        private static gax::PathTemplate s_projectDataSource = new gax::PathTemplate("projects/{project}/dataSources/{data_source}");

        private static gax::PathTemplate s_projectLocationDataSource = new gax::PathTemplate("projects/{project}/locations/{location}/dataSources/{data_source}");

        /// <summary>Creates a <see cref="DataSourceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataSourceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataSourceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataSourceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataSourceName"/> with the pattern <c>projects/{project}/dataSources/{data_source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSourceId">The <c>DataSource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataSourceName"/> constructed from the provided ids.</returns>
        public static DataSourceName FromProjectDataSource(string projectId, string dataSourceId) =>
            new DataSourceName(ResourceNameType.ProjectDataSource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), dataSourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataSourceId, nameof(dataSourceId)));

        /// <summary>
        /// Creates a <see cref="DataSourceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataSources/{data_source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSourceId">The <c>DataSource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataSourceName"/> constructed from the provided ids.</returns>
        public static DataSourceName FromProjectLocationDataSource(string projectId, string locationId, string dataSourceId) =>
            new DataSourceName(ResourceNameType.ProjectLocationDataSource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataSourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataSourceId, nameof(dataSourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>projects/{project}/dataSources/{data_source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSourceId">The <c>DataSource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>projects/{project}/dataSources/{data_source}</c>.
        /// </returns>
        public static string Format(string projectId, string dataSourceId) => FormatProjectDataSource(projectId, dataSourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>projects/{project}/dataSources/{data_source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSourceId">The <c>DataSource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>projects/{project}/dataSources/{data_source}</c>.
        /// </returns>
        public static string FormatProjectDataSource(string projectId, string dataSourceId) =>
            s_projectDataSource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataSourceId, nameof(dataSourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataSources/{data_source}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSourceId">The <c>DataSource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataSourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataSources/{data_source}</c>.
        /// </returns>
        public static string FormatProjectLocationDataSource(string projectId, string locationId, string dataSourceId) =>
            s_projectLocationDataSource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataSourceId, nameof(dataSourceId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataSourceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dataSources/{data_source}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataSources/{data_source}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataSourceName"/> if successful.</returns>
        public static DataSourceName Parse(string dataSourceName) => Parse(dataSourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataSourceName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dataSources/{data_source}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataSources/{data_source}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataSourceName"/> if successful.</returns>
        public static DataSourceName Parse(string dataSourceName, bool allowUnparsed) =>
            TryParse(dataSourceName, allowUnparsed, out DataSourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dataSources/{data_source}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataSources/{data_source}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSourceName, out DataSourceName result) =>
            TryParse(dataSourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataSourceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dataSources/{data_source}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataSources/{data_source}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataSourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataSourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSourceName, bool allowUnparsed, out DataSourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataSourceName, nameof(dataSourceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDataSource.TryParseName(dataSourceName, out resourceName))
            {
                result = FromProjectDataSource(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationDataSource.TryParseName(dataSourceName, out resourceName))
            {
                result = FromProjectLocationDataSource(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataSourceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataSourceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataSourceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataSourceId = dataSourceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataSourceName"/> class from the component parts of pattern
        /// <c>projects/{project}/dataSources/{data_source}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataSourceId">The <c>DataSource</c> ID. Must not be <c>null</c> or empty.</param>
        public DataSourceName(string projectId, string dataSourceId) : this(ResourceNameType.ProjectDataSource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), dataSourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataSourceId, nameof(dataSourceId)))
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
        /// The <c>DataSource</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string DataSourceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectDataSource: return s_projectDataSource.Expand(ProjectId, DataSourceId);
                case ResourceNameType.ProjectLocationDataSource: return s_projectLocationDataSource.Expand(ProjectId, LocationId, DataSourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataSourceName);

        /// <inheritdoc/>
        public bool Equals(DataSourceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataSourceName a, DataSourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataSourceName a, DataSourceName b) => !(a == b);
    }

    public partial class DataSource
    {
        /// <summary>
        /// <see cref="gcbdv::DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::DataSourceName DataSourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::DataSourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDataSourceRequest
    {
        /// <summary>
        /// <see cref="gcbdv::DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::DataSourceName DataSourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::DataSourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataSourcesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateTransferConfigRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTransferConfigRequest
    {
        /// <summary>
        /// <see cref="gcbdv::TransferConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::TransferConfigName TransferConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::TransferConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTransferConfigRequest
    {
        /// <summary>
        /// <see cref="gcbdv::TransferConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::TransferConfigName TransferConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::TransferConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetTransferRunRequest
    {
        /// <summary>
        /// <see cref="gcbdv::RunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::RunName RunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::RunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTransferRunRequest
    {
        /// <summary>
        /// <see cref="gcbdv::RunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::RunName RunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::RunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTransferConfigsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListTransferRunsRequest
    {
        /// <summary>
        /// <see cref="TransferConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TransferConfigName ParentAsTransferConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TransferConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListTransferLogsRequest
    {
        /// <summary><see cref="RunName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RunName ParentAsRunName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RunName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CheckValidCredsRequest
    {
        /// <summary>
        /// <see cref="gcbdv::DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbdv::DataSourceName DataSourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbdv::DataSourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ScheduleTransferRunsRequest
    {
        /// <summary>
        /// <see cref="TransferConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TransferConfigName ParentAsTransferConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TransferConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class StartManualTransferRunsRequest
    {
        /// <summary>
        /// <see cref="TransferConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TransferConfigName ParentAsTransferConfigName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TransferConfigName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
