// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using System;
using System.Linq;

namespace Google.Cloud.BigQuery.DataTransfer.V1
{
    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : IResourceName, IEquatable<ProjectName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}");

        /// <summary>
        /// Parses the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName;
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

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectName(string projectId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

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
    /// Resource name for the 'location' resource.
    /// </summary>
    public sealed partial class LocationName : IResourceName, IEquatable<LocationName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/locations/{location}");

        /// <summary>
        /// Parses the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName)
        {
            GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            TemplatedResourceName resourceName = s_template.ParseName(locationName);
            return new LocationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="locationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, out LocationName result)
        {
            GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            TemplatedResourceName resourceName;
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

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        public LocationName(string projectId, string locationId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
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
        public ResourceNameKind Kind => ResourceNameKind.Simple;

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
    /// Resource name for the 'location_data_source' resource.
    /// </summary>
    public sealed partial class LocationDataSourceName : IResourceName, IEquatable<LocationDataSourceName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/locations/{location}/dataSources/{data_source}");

        /// <summary>
        /// Parses the given location_data_source resource name in string form into a new
        /// <see cref="LocationDataSourceName"/> instance.
        /// </summary>
        /// <param name="locationDataSourceName">The location_data_source resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationDataSourceName"/> if successful.</returns>
        public static LocationDataSourceName Parse(string locationDataSourceName)
        {
            GaxPreconditions.CheckNotNull(locationDataSourceName, nameof(locationDataSourceName));
            TemplatedResourceName resourceName = s_template.ParseName(locationDataSourceName);
            return new LocationDataSourceName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given location_data_source resource name in string form into a new
        /// <see cref="LocationDataSourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="locationDataSourceName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationDataSourceName">The location_data_source resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationDataSourceName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationDataSourceName, out LocationDataSourceName result)
        {
            GaxPreconditions.CheckNotNull(locationDataSourceName, nameof(locationDataSourceName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(locationDataSourceName, out resourceName))
            {
                result = new LocationDataSourceName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationDataSourceName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="dataSourceId">The dataSource ID. Must not be <c>null</c>.</param>
        public LocationDataSourceName(string projectId, string locationId, string dataSourceId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            DataSourceId = GaxPreconditions.CheckNotNull(dataSourceId, nameof(dataSourceId));
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
        /// The dataSource ID. Never <c>null</c>.
        /// </summary>
        public string DataSourceId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, DataSourceId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LocationDataSourceName);

        /// <inheritdoc />
        public bool Equals(LocationDataSourceName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationDataSourceName a, LocationDataSourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationDataSourceName a, LocationDataSourceName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'location_transfer_config' resource.
    /// </summary>
    public sealed partial class LocationTransferConfigName : IResourceName, IEquatable<LocationTransferConfigName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/locations/{location}/transferConfigs/{transfer_config}");

        /// <summary>
        /// Parses the given location_transfer_config resource name in string form into a new
        /// <see cref="LocationTransferConfigName"/> instance.
        /// </summary>
        /// <param name="locationTransferConfigName">The location_transfer_config resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationTransferConfigName"/> if successful.</returns>
        public static LocationTransferConfigName Parse(string locationTransferConfigName)
        {
            GaxPreconditions.CheckNotNull(locationTransferConfigName, nameof(locationTransferConfigName));
            TemplatedResourceName resourceName = s_template.ParseName(locationTransferConfigName);
            return new LocationTransferConfigName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given location_transfer_config resource name in string form into a new
        /// <see cref="LocationTransferConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="locationTransferConfigName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationTransferConfigName">The location_transfer_config resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationTransferConfigName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationTransferConfigName, out LocationTransferConfigName result)
        {
            GaxPreconditions.CheckNotNull(locationTransferConfigName, nameof(locationTransferConfigName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(locationTransferConfigName, out resourceName))
            {
                result = new LocationTransferConfigName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationTransferConfigName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The transferConfig ID. Must not be <c>null</c>.</param>
        public LocationTransferConfigName(string projectId, string locationId, string transferConfigId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            TransferConfigId = GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId));
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

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, TransferConfigId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LocationTransferConfigName);

        /// <inheritdoc />
        public bool Equals(LocationTransferConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationTransferConfigName a, LocationTransferConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationTransferConfigName a, LocationTransferConfigName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'location_run' resource.
    /// </summary>
    public sealed partial class LocationRunName : IResourceName, IEquatable<LocationRunName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}");

        /// <summary>
        /// Parses the given location_run resource name in string form into a new
        /// <see cref="LocationRunName"/> instance.
        /// </summary>
        /// <param name="locationRunName">The location_run resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationRunName"/> if successful.</returns>
        public static LocationRunName Parse(string locationRunName)
        {
            GaxPreconditions.CheckNotNull(locationRunName, nameof(locationRunName));
            TemplatedResourceName resourceName = s_template.ParseName(locationRunName);
            return new LocationRunName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given location_run resource name in string form into a new
        /// <see cref="LocationRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="locationRunName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationRunName">The location_run resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationRunName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationRunName, out LocationRunName result)
        {
            GaxPreconditions.CheckNotNull(locationRunName, nameof(locationRunName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(locationRunName, out resourceName))
            {
                result = new LocationRunName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationRunName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The transferConfig ID. Must not be <c>null</c>.</param>
        /// <param name="runId">The run ID. Must not be <c>null</c>.</param>
        public LocationRunName(string projectId, string locationId, string transferConfigId, string runId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            TransferConfigId = GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId));
            RunId = GaxPreconditions.CheckNotNull(runId, nameof(runId));
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
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, TransferConfigId, RunId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LocationRunName);

        /// <inheritdoc />
        public bool Equals(LocationRunName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationRunName a, LocationRunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationRunName a, LocationRunName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'data_source' resource.
    /// </summary>
    public sealed partial class DataSourceName : IResourceName, IEquatable<DataSourceName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/dataSources/{data_source}");

        /// <summary>
        /// Parses the given data_source resource name in string form into a new
        /// <see cref="DataSourceName"/> instance.
        /// </summary>
        /// <param name="dataSourceName">The data_source resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataSourceName"/> if successful.</returns>
        public static DataSourceName Parse(string dataSourceName)
        {
            GaxPreconditions.CheckNotNull(dataSourceName, nameof(dataSourceName));
            TemplatedResourceName resourceName = s_template.ParseName(dataSourceName);
            return new DataSourceName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given data_source resource name in string form into a new
        /// <see cref="DataSourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="dataSourceName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="dataSourceName">The data_source resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DataSourceName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataSourceName, out DataSourceName result)
        {
            GaxPreconditions.CheckNotNull(dataSourceName, nameof(dataSourceName));
            TemplatedResourceName resourceName;
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

        /// <summary>
        /// Constructs a new instance of the <see cref="DataSourceName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="dataSourceId">The dataSource ID. Must not be <c>null</c>.</param>
        public DataSourceName(string projectId, string dataSourceId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DataSourceId = GaxPreconditions.CheckNotNull(dataSourceId, nameof(dataSourceId));
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
        public ResourceNameKind Kind => ResourceNameKind.Simple;

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
    /// Resource name for the 'transfer_config' resource.
    /// </summary>
    public sealed partial class TransferConfigName : IResourceName, IEquatable<TransferConfigName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/transferConfigs/{transfer_config}");

        /// <summary>
        /// Parses the given transfer_config resource name in string form into a new
        /// <see cref="TransferConfigName"/> instance.
        /// </summary>
        /// <param name="transferConfigName">The transfer_config resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TransferConfigName"/> if successful.</returns>
        public static TransferConfigName Parse(string transferConfigName)
        {
            GaxPreconditions.CheckNotNull(transferConfigName, nameof(transferConfigName));
            TemplatedResourceName resourceName = s_template.ParseName(transferConfigName);
            return new TransferConfigName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given transfer_config resource name in string form into a new
        /// <see cref="TransferConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="transferConfigName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="transferConfigName">The transfer_config resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TransferConfigName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string transferConfigName, out TransferConfigName result)
        {
            GaxPreconditions.CheckNotNull(transferConfigName, nameof(transferConfigName));
            TemplatedResourceName resourceName;
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

        /// <summary>
        /// Constructs a new instance of the <see cref="TransferConfigName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The transferConfig ID. Must not be <c>null</c>.</param>
        public TransferConfigName(string projectId, string transferConfigId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TransferConfigId = GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId));
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
        public ResourceNameKind Kind => ResourceNameKind.Simple;

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
    /// Resource name for the 'run' resource.
    /// </summary>
    public sealed partial class RunName : IResourceName, IEquatable<RunName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/transferConfigs/{transfer_config}/runs/{run}");

        /// <summary>
        /// Parses the given run resource name in string form into a new
        /// <see cref="RunName"/> instance.
        /// </summary>
        /// <param name="runName">The run resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RunName"/> if successful.</returns>
        public static RunName Parse(string runName)
        {
            GaxPreconditions.CheckNotNull(runName, nameof(runName));
            TemplatedResourceName resourceName = s_template.ParseName(runName);
            return new RunName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given run resource name in string form into a new
        /// <see cref="RunName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="runName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="runName">The run resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="RunName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string runName, out RunName result)
        {
            GaxPreconditions.CheckNotNull(runName, nameof(runName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(runName, out resourceName))
            {
                result = new RunName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="RunName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The transferConfig ID. Must not be <c>null</c>.</param>
        /// <param name="runId">The run ID. Must not be <c>null</c>.</param>
        public RunName(string projectId, string transferConfigId, string runId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TransferConfigId = GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId));
            RunId = GaxPreconditions.CheckNotNull(runId, nameof(runId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The transferConfig ID. Never <c>null</c>.
        /// </summary>
        public string TransferConfigId { get; }

        /// <summary>
        /// The run ID. Never <c>null</c>.
        /// </summary>
        public string RunId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TransferConfigId, RunId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as RunName);

        /// <inheritdoc />
        public bool Equals(RunName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(RunName a, RunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(RunName a, RunName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>LocationName: A resource of type 'location'.</description></item>
    /// <item><description>ProjectName: A resource of type 'project'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class ParentNameOneof : IResourceName, IEquatable<ParentNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="ParentNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'location'.
            /// </summary>
            LocationName = 1,

            /// <summary>
            /// A resource of type 'project'.
            /// </summary>
            ProjectName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="ParentNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>LocationName: A resource of type 'location'.</description></item>
        /// <item><description>ProjectName: A resource of type 'project'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="ParentNameOneof"/> if successful.</returns>
        public static ParentNameOneof Parse(string name, bool allowUnknown)
        {
            ParentNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="ParentNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>LocationName: A resource of type 'location'.</description></item>
        /// <item><description>ProjectName: A resource of type 'project'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ParentNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out ParentNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            LocationName locationName;
            if (LocationName.TryParse(name, out locationName))
            {
                result = new ParentNameOneof(OneofType.LocationName, locationName);
                return true;
            }
            ProjectName projectName;
            if (ProjectName.TryParse(name, out projectName))
            {
                result = new ParentNameOneof(OneofType.ProjectName, projectName);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new ParentNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="ParentNameOneof"/> from the provided <see cref="LocationName"/>
        /// </summary>
        /// <param name="locationName">The <see cref="LocationName"/> to be contained within
        /// the returned <see cref="ParentNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="ParentNameOneof"/>, containing <paramref name="locationName"/>.</returns>
        public static ParentNameOneof From(LocationName locationName) => new ParentNameOneof(OneofType.LocationName, locationName);

        /// <summary>
        /// Construct a new instance of <see cref="ParentNameOneof"/> from the provided <see cref="ProjectName"/>
        /// </summary>
        /// <param name="projectName">The <see cref="ProjectName"/> to be contained within
        /// the returned <see cref="ParentNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="ParentNameOneof"/>, containing <paramref name="projectName"/>.</returns>
        public static ParentNameOneof From(ProjectName projectName) => new ParentNameOneof(OneofType.ProjectName, projectName);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.LocationName: return name is LocationName;
                case OneofType.ProjectName: return name is ProjectName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ParentNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public ParentNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="LocationName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="LocationName"/>.
        /// </remarks>
        public LocationName LocationName => CheckAndReturn<LocationName>(OneofType.LocationName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="ProjectName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="ProjectName"/>.
        /// </remarks>
        public ProjectName ProjectName => CheckAndReturn<ProjectName>(OneofType.ProjectName);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ParentNameOneof);

        /// <inheritdoc />
        public bool Equals(ParentNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ParentNameOneof a, ParentNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ParentNameOneof a, ParentNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>LocationDataSourceName: A resource of type 'location_data_source'.</description></item>
    /// <item><description>DataSourceName: A resource of type 'data_source'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class DataSourceNameOneof : IResourceName, IEquatable<DataSourceNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="DataSourceNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'location_data_source'.
            /// </summary>
            LocationDataSourceName = 1,

            /// <summary>
            /// A resource of type 'data_source'.
            /// </summary>
            DataSourceName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="DataSourceNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>LocationDataSourceName: A resource of type 'location_data_source'.</description></item>
        /// <item><description>DataSourceName: A resource of type 'data_source'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="DataSourceNameOneof"/> if successful.</returns>
        public static DataSourceNameOneof Parse(string name, bool allowUnknown)
        {
            DataSourceNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="DataSourceNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>LocationDataSourceName: A resource of type 'location_data_source'.</description></item>
        /// <item><description>DataSourceName: A resource of type 'data_source'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DataSourceNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out DataSourceNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            LocationDataSourceName locationDataSourceName;
            if (LocationDataSourceName.TryParse(name, out locationDataSourceName))
            {
                result = new DataSourceNameOneof(OneofType.LocationDataSourceName, locationDataSourceName);
                return true;
            }
            DataSourceName dataSourceName;
            if (DataSourceName.TryParse(name, out dataSourceName))
            {
                result = new DataSourceNameOneof(OneofType.DataSourceName, dataSourceName);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new DataSourceNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="DataSourceNameOneof"/> from the provided <see cref="LocationDataSourceName"/>
        /// </summary>
        /// <param name="locationDataSourceName">The <see cref="LocationDataSourceName"/> to be contained within
        /// the returned <see cref="DataSourceNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="DataSourceNameOneof"/>, containing <paramref name="locationDataSourceName"/>.</returns>
        public static DataSourceNameOneof From(LocationDataSourceName locationDataSourceName) => new DataSourceNameOneof(OneofType.LocationDataSourceName, locationDataSourceName);

        /// <summary>
        /// Construct a new instance of <see cref="DataSourceNameOneof"/> from the provided <see cref="DataSourceName"/>
        /// </summary>
        /// <param name="dataSourceName">The <see cref="DataSourceName"/> to be contained within
        /// the returned <see cref="DataSourceNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="DataSourceNameOneof"/>, containing <paramref name="dataSourceName"/>.</returns>
        public static DataSourceNameOneof From(DataSourceName dataSourceName) => new DataSourceNameOneof(OneofType.DataSourceName, dataSourceName);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.LocationDataSourceName: return name is LocationDataSourceName;
                case OneofType.DataSourceName: return name is DataSourceName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DataSourceNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public DataSourceNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="LocationDataSourceName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="LocationDataSourceName"/>.
        /// </remarks>
        public LocationDataSourceName LocationDataSourceName => CheckAndReturn<LocationDataSourceName>(OneofType.LocationDataSourceName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="DataSourceName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="DataSourceName"/>.
        /// </remarks>
        public DataSourceName DataSourceName => CheckAndReturn<DataSourceName>(OneofType.DataSourceName);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DataSourceNameOneof);

        /// <inheritdoc />
        public bool Equals(DataSourceNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DataSourceNameOneof a, DataSourceNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DataSourceNameOneof a, DataSourceNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>LocationTransferConfigName: A resource of type 'location_transfer_config'.</description></item>
    /// <item><description>TransferConfigName: A resource of type 'transfer_config'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class TransferConfigNameOneof : IResourceName, IEquatable<TransferConfigNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="TransferConfigNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'location_transfer_config'.
            /// </summary>
            LocationTransferConfigName = 1,

            /// <summary>
            /// A resource of type 'transfer_config'.
            /// </summary>
            TransferConfigName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="TransferConfigNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>LocationTransferConfigName: A resource of type 'location_transfer_config'.</description></item>
        /// <item><description>TransferConfigName: A resource of type 'transfer_config'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="TransferConfigNameOneof"/> if successful.</returns>
        public static TransferConfigNameOneof Parse(string name, bool allowUnknown)
        {
            TransferConfigNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="TransferConfigNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>LocationTransferConfigName: A resource of type 'location_transfer_config'.</description></item>
        /// <item><description>TransferConfigName: A resource of type 'transfer_config'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TransferConfigNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out TransferConfigNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            LocationTransferConfigName locationTransferConfigName;
            if (LocationTransferConfigName.TryParse(name, out locationTransferConfigName))
            {
                result = new TransferConfigNameOneof(OneofType.LocationTransferConfigName, locationTransferConfigName);
                return true;
            }
            TransferConfigName transferConfigName;
            if (TransferConfigName.TryParse(name, out transferConfigName))
            {
                result = new TransferConfigNameOneof(OneofType.TransferConfigName, transferConfigName);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new TransferConfigNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="TransferConfigNameOneof"/> from the provided <see cref="LocationTransferConfigName"/>
        /// </summary>
        /// <param name="locationTransferConfigName">The <see cref="LocationTransferConfigName"/> to be contained within
        /// the returned <see cref="TransferConfigNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="TransferConfigNameOneof"/>, containing <paramref name="locationTransferConfigName"/>.</returns>
        public static TransferConfigNameOneof From(LocationTransferConfigName locationTransferConfigName) => new TransferConfigNameOneof(OneofType.LocationTransferConfigName, locationTransferConfigName);

        /// <summary>
        /// Construct a new instance of <see cref="TransferConfigNameOneof"/> from the provided <see cref="TransferConfigName"/>
        /// </summary>
        /// <param name="transferConfigName">The <see cref="TransferConfigName"/> to be contained within
        /// the returned <see cref="TransferConfigNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="TransferConfigNameOneof"/>, containing <paramref name="transferConfigName"/>.</returns>
        public static TransferConfigNameOneof From(TransferConfigName transferConfigName) => new TransferConfigNameOneof(OneofType.TransferConfigName, transferConfigName);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.LocationTransferConfigName: return name is LocationTransferConfigName;
                case OneofType.TransferConfigName: return name is TransferConfigName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="TransferConfigNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public TransferConfigNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="LocationTransferConfigName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="LocationTransferConfigName"/>.
        /// </remarks>
        public LocationTransferConfigName LocationTransferConfigName => CheckAndReturn<LocationTransferConfigName>(OneofType.LocationTransferConfigName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="TransferConfigName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="TransferConfigName"/>.
        /// </remarks>
        public TransferConfigName TransferConfigName => CheckAndReturn<TransferConfigName>(OneofType.TransferConfigName);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TransferConfigNameOneof);

        /// <inheritdoc />
        public bool Equals(TransferConfigNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TransferConfigNameOneof a, TransferConfigNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TransferConfigNameOneof a, TransferConfigNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>LocationRunName: A resource of type 'location_run'.</description></item>
    /// <item><description>RunName: A resource of type 'run'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class RunNameOneof : IResourceName, IEquatable<RunNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="RunNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'location_run'.
            /// </summary>
            LocationRunName = 1,

            /// <summary>
            /// A resource of type 'run'.
            /// </summary>
            RunName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="RunNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>LocationRunName: A resource of type 'location_run'.</description></item>
        /// <item><description>RunName: A resource of type 'run'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="RunNameOneof"/> if successful.</returns>
        public static RunNameOneof Parse(string name, bool allowUnknown)
        {
            RunNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="RunNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>LocationRunName: A resource of type 'location_run'.</description></item>
        /// <item><description>RunName: A resource of type 'run'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="RunNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out RunNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            LocationRunName locationRunName;
            if (LocationRunName.TryParse(name, out locationRunName))
            {
                result = new RunNameOneof(OneofType.LocationRunName, locationRunName);
                return true;
            }
            RunName runName;
            if (RunName.TryParse(name, out runName))
            {
                result = new RunNameOneof(OneofType.RunName, runName);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new RunNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="RunNameOneof"/> from the provided <see cref="LocationRunName"/>
        /// </summary>
        /// <param name="locationRunName">The <see cref="LocationRunName"/> to be contained within
        /// the returned <see cref="RunNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="RunNameOneof"/>, containing <paramref name="locationRunName"/>.</returns>
        public static RunNameOneof From(LocationRunName locationRunName) => new RunNameOneof(OneofType.LocationRunName, locationRunName);

        /// <summary>
        /// Construct a new instance of <see cref="RunNameOneof"/> from the provided <see cref="RunName"/>
        /// </summary>
        /// <param name="runName">The <see cref="RunName"/> to be contained within
        /// the returned <see cref="RunNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="RunNameOneof"/>, containing <paramref name="runName"/>.</returns>
        public static RunNameOneof From(RunName runName) => new RunNameOneof(OneofType.RunName, runName);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.LocationRunName: return name is LocationRunName;
                case OneofType.RunName: return name is RunName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="RunNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public RunNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="LocationRunName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="LocationRunName"/>.
        /// </remarks>
        public LocationRunName LocationRunName => CheckAndReturn<LocationRunName>(OneofType.LocationRunName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="RunName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="RunName"/>.
        /// </remarks>
        public RunName RunName => CheckAndReturn<RunName>(OneofType.RunName);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as RunNameOneof);

        /// <inheritdoc />
        public bool Equals(RunNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(RunNameOneof a, RunNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(RunNameOneof a, RunNameOneof b) => !(a == b);
    }


    public partial class CheckValidCredsRequest
    {
        /// <summary>
        /// <see cref="DataSourceNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DataSourceNameOneof DataSourceNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateTransferConfigRequest
    {
        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DataSource
    {
        /// <summary>
        /// <see cref="DataSourceNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DataSourceNameOneof DataSourceNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteTransferConfigRequest
    {
        /// <summary>
        /// <see cref="TransferConfigNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TransferConfigNameOneof TransferConfigNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteTransferRunRequest
    {
        /// <summary>
        /// <see cref="RunNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public RunNameOneof RunNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDataSourceRequest
    {
        /// <summary>
        /// <see cref="DataSourceNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DataSourceNameOneof DataSourceNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetTransferConfigRequest
    {
        /// <summary>
        /// <see cref="TransferConfigNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TransferConfigNameOneof TransferConfigNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetTransferRunRequest
    {
        /// <summary>
        /// <see cref="RunNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public RunNameOneof RunNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListDataSourcesRequest
    {
        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTransferConfigsRequest
    {
        /// <summary>
        /// <see cref="ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTransferLogsRequest
    {
        /// <summary>
        /// <see cref="RunNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RunNameOneof ParentAsRunNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTransferRunsRequest
    {
        /// <summary>
        /// <see cref="TransferConfigNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TransferConfigNameOneof ParentAsTransferConfigNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ScheduleTransferRunsRequest
    {
        /// <summary>
        /// <see cref="TransferConfigNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TransferConfigNameOneof ParentAsTransferConfigNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class TransferConfig
    {
        /// <summary>
        /// <see cref="TransferConfigNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TransferConfigNameOneof TransferConfigNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class TransferRun
    {
        /// <summary>
        /// <see cref="RunNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public RunNameOneof RunNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}