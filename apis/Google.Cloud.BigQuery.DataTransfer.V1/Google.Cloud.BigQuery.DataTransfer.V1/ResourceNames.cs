// Copyright 2019 Google LLC
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
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.BigQuery.DataTransfer.V1
{
    /// <summary>
    /// Resource name for the 'data_source' resource.
    /// </summary>
    public sealed partial class DataSourceName : gax::IResourceName, sys::IEquatable<DataSourceName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/dataSources/{data_source}");

        /// <summary>
        /// Parses the given data_source resource name in string form into a new
        /// <see cref="DataSourceName"/> instance.
        /// </summary>
        /// <param name="dataSourceName">The data_source resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataSourceName"/> if successful.</returns>
        public static DataSourceName Parse(string dataSourceName)
        {
            gax::GaxPreconditions.CheckNotNull(dataSourceName, nameof(dataSourceName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(dataSourceName);
            return new DataSourceName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given data_source resource name in string form into a new
        /// <see cref="DataSourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="dataSourceName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="dataSourceName">The data_source resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DataSourceName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSourceName, out DataSourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataSourceName, nameof(dataSourceName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(dataSourceName, out resourceName))
            {
                result = new DataSourceName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="DataSourceName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="dataSourceId">The <c>dataSource</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="DataSourceName"/>.</returns>
        public static string Format(string projectId, string dataSourceId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(dataSourceId, nameof(dataSourceId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="DataSourceName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="dataSourceId">The dataSource ID. Must not be <c>null</c>.</param>
        public DataSourceName(string projectId, string dataSourceId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DataSourceId = gax::GaxPreconditions.CheckNotNull(dataSourceId, nameof(dataSourceId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The dataSource ID. Never <c>null</c>.
        /// </summary>
        public string DataSourceId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DataSourceId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DataSourceName);

        /// <inheritdoc />
        public bool Equals(DataSourceName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DataSourceName a, DataSourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DataSourceName a, DataSourceName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'location' resource.
    /// </summary>
    public sealed partial class LocationName : gax::IResourceName, sys::IEquatable<LocationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}");

        /// <summary>
        /// Parses the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(locationName);
            return new LocationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="locationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, out LocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(locationName, out resourceName))
            {
                result = new LocationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="LocationName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="LocationName"/>.</returns>
        public static string Format(string projectId, string locationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        public LocationName(string projectId, string locationId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LocationName);

        /// <inheritdoc />
        public bool Equals(LocationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationName a, LocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationName a, LocationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : gax::IResourceName, sys::IEquatable<ProjectName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}");

        /// <summary>
        /// Parses the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName)
        {
            gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectName, out resourceName))
            {
                result = new ProjectName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectName"/>.</returns>
        public static string Format(string projectId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectName(string projectId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectName);

        /// <inheritdoc />
        public bool Equals(ProjectName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectName a, ProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectName a, ProjectName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'transfer_config' resource.
    /// </summary>
    public sealed partial class TransferConfigName : gax::IResourceName, sys::IEquatable<TransferConfigName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/transferConfigs/{transfer_config}");

        /// <summary>
        /// Parses the given transfer_config resource name in string form into a new
        /// <see cref="TransferConfigName"/> instance.
        /// </summary>
        /// <param name="transferConfigName">The transfer_config resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TransferConfigName"/> if successful.</returns>
        public static TransferConfigName Parse(string transferConfigName)
        {
            gax::GaxPreconditions.CheckNotNull(transferConfigName, nameof(transferConfigName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(transferConfigName);
            return new TransferConfigName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given transfer_config resource name in string form into a new
        /// <see cref="TransferConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="transferConfigName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="transferConfigName">The transfer_config resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TransferConfigName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transferConfigName, out TransferConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(transferConfigName, nameof(transferConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(transferConfigName, out resourceName))
            {
                result = new TransferConfigName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="TransferConfigName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The <c>transferConfig</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="TransferConfigName"/>.</returns>
        public static string Format(string projectId, string transferConfigId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="TransferConfigName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The transferConfig ID. Must not be <c>null</c>.</param>
        public TransferConfigName(string projectId, string transferConfigId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TransferConfigId = gax::GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The transferConfig ID. Never <c>null</c>.
        /// </summary>
        public string TransferConfigId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TransferConfigId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TransferConfigName);

        /// <inheritdoc />
        public bool Equals(TransferConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TransferConfigName a, TransferConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TransferConfigName a, TransferConfigName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'transfer_run' resource.
    /// </summary>
    public sealed partial class TransferRunName : gax::IResourceName, sys::IEquatable<TransferRunName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}");

        /// <summary>
        /// Parses the given transfer_run resource name in string form into a new
        /// <see cref="TransferRunName"/> instance.
        /// </summary>
        /// <param name="transferRunName">The transfer_run resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TransferRunName"/> if successful.</returns>
        public static TransferRunName Parse(string transferRunName)
        {
            gax::GaxPreconditions.CheckNotNull(transferRunName, nameof(transferRunName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(transferRunName);
            return new TransferRunName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given transfer_run resource name in string form into a new
        /// <see cref="TransferRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="transferRunName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="transferRunName">The transfer_run resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TransferRunName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transferRunName, out TransferRunName result)
        {
            gax::GaxPreconditions.CheckNotNull(transferRunName, nameof(transferRunName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(transferRunName, out resourceName))
            {
                result = new TransferRunName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="TransferRunName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The <c>transferConfig</c> ID. Must not be <c>null</c>.</param>
        /// <param name="runId">The <c>run</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="TransferRunName"/>.</returns>
        public static string Format(string projectId, string locationId, string transferConfigId, string runId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId)), gax::GaxPreconditions.CheckNotNull(runId, nameof(runId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="TransferRunName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The transferConfig ID. Must not be <c>null</c>.</param>
        /// <param name="runId">The run ID. Must not be <c>null</c>.</param>
        public TransferRunName(string projectId, string locationId, string transferConfigId, string runId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            TransferConfigId = gax::GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId));
            RunId = gax::GaxPreconditions.CheckNotNull(runId, nameof(runId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The transferConfig ID. Never <c>null</c>.
        /// </summary>
        public string TransferConfigId { get; }

        /// <summary>
        /// The run ID. Never <c>null</c>.
        /// </summary>
        public string RunId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, TransferConfigId, RunId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TransferRunName);

        /// <inheritdoc />
        public bool Equals(TransferRunName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TransferRunName a, TransferRunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TransferRunName a, TransferRunName b) => !(a == b);
    }


    public partial class CheckValidCredsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.DataSourceName DataSourceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.DataSourceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateTransferConfigRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DataSource
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.DataSourceName DataSourceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.DataSourceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteTransferConfigRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName TransferConfigName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteTransferRunRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName TransferRunName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDataSourceRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.DataSourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.DataSourceName DataSourceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.DataSourceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetTransferConfigRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName TransferConfigName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetTransferRunRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName TransferRunName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListDataSourcesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTransferConfigsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTransferLogsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName ParentAsTransferRunName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTransferRunsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName ParentAsTransferConfigName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ScheduleTransferRunsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName ParentAsTransferConfigName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class StartManualTransferRunsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName ParentAsTransferConfigName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class TransferConfig
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName TransferConfigName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class TransferRun
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName TransferRunName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferRunName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}