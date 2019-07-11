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
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>ProjectDataSourceName: A resource of type 'project_data_source'.</description></item>
    /// <item><description>LocationDataSourceName: A resource of type 'location_data_source'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class DataSourceNameOneof : gax::IResourceName, sys::IEquatable<DataSourceNameOneof>
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
            /// A resource of type 'project_data_source'.
            /// </summary>
            ProjectDataSourceName = 1,

            /// <summary>
            /// A resource of type 'location_data_source'.
            /// </summary>
            LocationDataSourceName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="DataSourceNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>ProjectDataSourceName: A resource of type 'project_data_source'.</description></item>
        /// <item><description>LocationDataSourceName: A resource of type 'location_data_source'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="DataSourceNameOneof"/> if successful.</returns>
        public static DataSourceNameOneof Parse(string name, bool allowUnknown)
        {
            DataSourceNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="DataSourceNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>ProjectDataSourceName: A resource of type 'project_data_source'.</description></item>
        /// <item><description>LocationDataSourceName: A resource of type 'location_data_source'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DataSourceNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out DataSourceNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            ProjectDataSourceName projectDataSourceName;
            if (ProjectDataSourceName.TryParse(name, out projectDataSourceName))
            {
                result = new DataSourceNameOneof(OneofType.ProjectDataSourceName, projectDataSourceName);
                return true;
            }
            LocationDataSourceName locationDataSourceName;
            if (LocationDataSourceName.TryParse(name, out locationDataSourceName))
            {
                result = new DataSourceNameOneof(OneofType.LocationDataSourceName, locationDataSourceName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new DataSourceNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="DataSourceNameOneof"/> from the provided <see cref="ProjectDataSourceName"/>
        /// </summary>
        /// <param name="projectDataSourceName">The <see cref="ProjectDataSourceName"/> to be contained within
        /// the returned <see cref="DataSourceNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="DataSourceNameOneof"/>, containing <paramref name="projectDataSourceName"/>.</returns>
        public static DataSourceNameOneof From(ProjectDataSourceName projectDataSourceName) => new DataSourceNameOneof(OneofType.ProjectDataSourceName, projectDataSourceName);

        /// <summary>
        /// Construct a new instance of <see cref="DataSourceNameOneof"/> from the provided <see cref="LocationDataSourceName"/>
        /// </summary>
        /// <param name="locationDataSourceName">The <see cref="LocationDataSourceName"/> to be contained within
        /// the returned <see cref="DataSourceNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="DataSourceNameOneof"/>, containing <paramref name="locationDataSourceName"/>.</returns>
        public static DataSourceNameOneof From(LocationDataSourceName locationDataSourceName) => new DataSourceNameOneof(OneofType.LocationDataSourceName, locationDataSourceName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.ProjectDataSourceName: return name is ProjectDataSourceName;
                case OneofType.LocationDataSourceName: return name is LocationDataSourceName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DataSourceNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public DataSourceNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="ProjectDataSourceName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="ProjectDataSourceName"/>.
        /// </remarks>
        public ProjectDataSourceName ProjectDataSourceName => CheckAndReturn<ProjectDataSourceName>(OneofType.ProjectDataSourceName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="LocationDataSourceName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="LocationDataSourceName"/>.
        /// </remarks>
        public LocationDataSourceName LocationDataSourceName => CheckAndReturn<LocationDataSourceName>(OneofType.LocationDataSourceName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

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
    /// Resource name for the 'location_data_source' resource.
    /// </summary>
    public sealed partial class LocationDataSourceName : gax::IResourceName, sys::IEquatable<LocationDataSourceName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/dataSources/{data_source}");

        /// <summary>
        /// Parses the given location_data_source resource name in string form into a new
        /// <see cref="LocationDataSourceName"/> instance.
        /// </summary>
        /// <param name="locationDataSourceName">The location_data_source resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationDataSourceName"/> if successful.</returns>
        public static LocationDataSourceName Parse(string locationDataSourceName)
        {
            gax::GaxPreconditions.CheckNotNull(locationDataSourceName, nameof(locationDataSourceName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(locationDataSourceName);
            return new LocationDataSourceName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given location_data_source resource name in string form into a new
        /// <see cref="LocationDataSourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="locationDataSourceName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationDataSourceName">The location_data_source resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationDataSourceName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationDataSourceName, out LocationDataSourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationDataSourceName, nameof(locationDataSourceName));
            gax::TemplatedResourceName resourceName;
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

        /// <summary>Formats the IDs into the string representation of the <see cref="LocationDataSourceName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="dataSourceId">The <c>dataSource</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="LocationDataSourceName"/>.</returns>
        public static string Format(string projectId, string locationId, string dataSourceId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(dataSourceId, nameof(dataSourceId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationDataSourceName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="dataSourceId">The dataSource ID. Must not be <c>null</c>.</param>
        public LocationDataSourceName(string projectId, string locationId, string dataSourceId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            DataSourceId = gax::GaxPreconditions.CheckNotNull(dataSourceId, nameof(dataSourceId));
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
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

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
    /// Resource name for the 'location_run' resource.
    /// </summary>
    public sealed partial class LocationRunName : gax::IResourceName, sys::IEquatable<LocationRunName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/transferConfigs/{transfer_config}/runs/{run}");

        /// <summary>
        /// Parses the given location_run resource name in string form into a new
        /// <see cref="LocationRunName"/> instance.
        /// </summary>
        /// <param name="locationRunName">The location_run resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationRunName"/> if successful.</returns>
        public static LocationRunName Parse(string locationRunName)
        {
            gax::GaxPreconditions.CheckNotNull(locationRunName, nameof(locationRunName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(locationRunName);
            return new LocationRunName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given location_run resource name in string form into a new
        /// <see cref="LocationRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="locationRunName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationRunName">The location_run resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationRunName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationRunName, out LocationRunName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationRunName, nameof(locationRunName));
            gax::TemplatedResourceName resourceName;
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

        /// <summary>Formats the IDs into the string representation of the <see cref="LocationRunName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The <c>transferConfig</c> ID. Must not be <c>null</c>.</param>
        /// <param name="runId">The <c>run</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="LocationRunName"/>.</returns>
        public static string Format(string projectId, string locationId, string transferConfigId, string runId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId)), gax::GaxPreconditions.CheckNotNull(runId, nameof(runId)));

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
        public override bool Equals(object obj) => Equals(obj as LocationRunName);

        /// <inheritdoc />
        public bool Equals(LocationRunName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationRunName a, LocationRunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationRunName a, LocationRunName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'location_transfer_config' resource.
    /// </summary>
    public sealed partial class LocationTransferConfigName : gax::IResourceName, sys::IEquatable<LocationTransferConfigName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/transferConfigs/{transfer_config}");

        /// <summary>
        /// Parses the given location_transfer_config resource name in string form into a new
        /// <see cref="LocationTransferConfigName"/> instance.
        /// </summary>
        /// <param name="locationTransferConfigName">The location_transfer_config resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationTransferConfigName"/> if successful.</returns>
        public static LocationTransferConfigName Parse(string locationTransferConfigName)
        {
            gax::GaxPreconditions.CheckNotNull(locationTransferConfigName, nameof(locationTransferConfigName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(locationTransferConfigName);
            return new LocationTransferConfigName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given location_transfer_config resource name in string form into a new
        /// <see cref="LocationTransferConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="locationTransferConfigName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationTransferConfigName">The location_transfer_config resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationTransferConfigName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationTransferConfigName, out LocationTransferConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationTransferConfigName, nameof(locationTransferConfigName));
            gax::TemplatedResourceName resourceName;
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

        /// <summary>Formats the IDs into the string representation of the <see cref="LocationTransferConfigName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The <c>transferConfig</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="LocationTransferConfigName"/>.</returns>
        public static string Format(string projectId, string locationId, string transferConfigId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationTransferConfigName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The transferConfig ID. Must not be <c>null</c>.</param>
        public LocationTransferConfigName(string projectId, string locationId, string transferConfigId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            TransferConfigId = gax::GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId));
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
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

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
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>ProjectName: A resource of type 'project'.</description></item>
    /// <item><description>LocationName: A resource of type 'location'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class ParentNameOneof : gax::IResourceName, sys::IEquatable<ParentNameOneof>
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
            /// A resource of type 'project'.
            /// </summary>
            ProjectName = 1,

            /// <summary>
            /// A resource of type 'location'.
            /// </summary>
            LocationName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="ParentNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>ProjectName: A resource of type 'project'.</description></item>
        /// <item><description>LocationName: A resource of type 'location'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="ParentNameOneof"/> if successful.</returns>
        public static ParentNameOneof Parse(string name, bool allowUnknown)
        {
            ParentNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="ParentNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>ProjectName: A resource of type 'project'.</description></item>
        /// <item><description>LocationName: A resource of type 'location'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ParentNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out ParentNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            Google.Api.Gax.ResourceNames.ProjectName projectName;
            if (Google.Api.Gax.ResourceNames.ProjectName.TryParse(name, out projectName))
            {
                result = new ParentNameOneof(OneofType.ProjectName, projectName);
                return true;
            }
            LocationName locationName;
            if (LocationName.TryParse(name, out locationName))
            {
                result = new ParentNameOneof(OneofType.LocationName, locationName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new ParentNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="ParentNameOneof"/> from the provided <see cref="Google.Api.Gax.ResourceNames.ProjectName"/>
        /// </summary>
        /// <param name="projectName">The <see cref="Google.Api.Gax.ResourceNames.ProjectName"/> to be contained within
        /// the returned <see cref="ParentNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="ParentNameOneof"/>, containing <paramref name="projectName"/>.</returns>
        public static ParentNameOneof From(Google.Api.Gax.ResourceNames.ProjectName projectName) => new ParentNameOneof(OneofType.ProjectName, projectName);

        /// <summary>
        /// Construct a new instance of <see cref="ParentNameOneof"/> from the provided <see cref="LocationName"/>
        /// </summary>
        /// <param name="locationName">The <see cref="LocationName"/> to be contained within
        /// the returned <see cref="ParentNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="ParentNameOneof"/>, containing <paramref name="locationName"/>.</returns>
        public static ParentNameOneof From(LocationName locationName) => new ParentNameOneof(OneofType.LocationName, locationName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.ProjectName: return name is Google.Api.Gax.ResourceNames.ProjectName;
                case OneofType.LocationName: return name is LocationName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ParentNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public ParentNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="Google.Api.Gax.ResourceNames.ProjectName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="Google.Api.Gax.ResourceNames.ProjectName"/>.
        /// </remarks>
        public Google.Api.Gax.ResourceNames.ProjectName ProjectName => CheckAndReturn<Google.Api.Gax.ResourceNames.ProjectName>(OneofType.ProjectName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="LocationName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="LocationName"/>.
        /// </remarks>
        public LocationName LocationName => CheckAndReturn<LocationName>(OneofType.LocationName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

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
    /// Resource name for the 'project_data_source' resource.
    /// </summary>
    public sealed partial class ProjectDataSourceName : gax::IResourceName, sys::IEquatable<ProjectDataSourceName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/dataSources/{data_source}");

        /// <summary>
        /// Parses the given project_data_source resource name in string form into a new
        /// <see cref="ProjectDataSourceName"/> instance.
        /// </summary>
        /// <param name="projectDataSourceName">The project_data_source resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectDataSourceName"/> if successful.</returns>
        public static ProjectDataSourceName Parse(string projectDataSourceName)
        {
            gax::GaxPreconditions.CheckNotNull(projectDataSourceName, nameof(projectDataSourceName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectDataSourceName);
            return new ProjectDataSourceName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given project_data_source resource name in string form into a new
        /// <see cref="ProjectDataSourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectDataSourceName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectDataSourceName">The project_data_source resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectDataSourceName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectDataSourceName, out ProjectDataSourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectDataSourceName, nameof(projectDataSourceName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectDataSourceName, out resourceName))
            {
                result = new ProjectDataSourceName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectDataSourceName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="dataSourceId">The <c>dataSource</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectDataSourceName"/>.</returns>
        public static string Format(string projectId, string dataSourceId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(dataSourceId, nameof(dataSourceId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectDataSourceName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="dataSourceId">The dataSource ID. Must not be <c>null</c>.</param>
        public ProjectDataSourceName(string projectId, string dataSourceId)
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
        public override bool Equals(object obj) => Equals(obj as ProjectDataSourceName);

        /// <inheritdoc />
        public bool Equals(ProjectDataSourceName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectDataSourceName a, ProjectDataSourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectDataSourceName a, ProjectDataSourceName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project_run' resource.
    /// </summary>
    public sealed partial class ProjectRunName : gax::IResourceName, sys::IEquatable<ProjectRunName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/transferConfigs/{transfer_config}/runs/{run}");

        /// <summary>
        /// Parses the given project_run resource name in string form into a new
        /// <see cref="ProjectRunName"/> instance.
        /// </summary>
        /// <param name="projectRunName">The project_run resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectRunName"/> if successful.</returns>
        public static ProjectRunName Parse(string projectRunName)
        {
            gax::GaxPreconditions.CheckNotNull(projectRunName, nameof(projectRunName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectRunName);
            return new ProjectRunName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given project_run resource name in string form into a new
        /// <see cref="ProjectRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectRunName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectRunName">The project_run resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectRunName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectRunName, out ProjectRunName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectRunName, nameof(projectRunName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectRunName, out resourceName))
            {
                result = new ProjectRunName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectRunName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The <c>transferConfig</c> ID. Must not be <c>null</c>.</param>
        /// <param name="runId">The <c>run</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectRunName"/>.</returns>
        public static string Format(string projectId, string transferConfigId, string runId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId)), gax::GaxPreconditions.CheckNotNull(runId, nameof(runId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectRunName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The transferConfig ID. Must not be <c>null</c>.</param>
        /// <param name="runId">The run ID. Must not be <c>null</c>.</param>
        public ProjectRunName(string projectId, string transferConfigId, string runId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TransferConfigId = gax::GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId));
            RunId = gax::GaxPreconditions.CheckNotNull(runId, nameof(runId));
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
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TransferConfigId, RunId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectRunName);

        /// <inheritdoc />
        public bool Equals(ProjectRunName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectRunName a, ProjectRunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectRunName a, ProjectRunName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project_transfer_config' resource.
    /// </summary>
    public sealed partial class ProjectTransferConfigName : gax::IResourceName, sys::IEquatable<ProjectTransferConfigName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/transferConfigs/{transfer_config}");

        /// <summary>
        /// Parses the given project_transfer_config resource name in string form into a new
        /// <see cref="ProjectTransferConfigName"/> instance.
        /// </summary>
        /// <param name="projectTransferConfigName">The project_transfer_config resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectTransferConfigName"/> if successful.</returns>
        public static ProjectTransferConfigName Parse(string projectTransferConfigName)
        {
            gax::GaxPreconditions.CheckNotNull(projectTransferConfigName, nameof(projectTransferConfigName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(projectTransferConfigName);
            return new ProjectTransferConfigName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given project_transfer_config resource name in string form into a new
        /// <see cref="ProjectTransferConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="projectTransferConfigName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectTransferConfigName">The project_transfer_config resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectTransferConfigName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectTransferConfigName, out ProjectTransferConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectTransferConfigName, nameof(projectTransferConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectTransferConfigName, out resourceName))
            {
                result = new ProjectTransferConfigName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ProjectTransferConfigName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The <c>transferConfig</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ProjectTransferConfigName"/>.</returns>
        public static string Format(string projectId, string transferConfigId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(transferConfigId, nameof(transferConfigId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectTransferConfigName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="transferConfigId">The transferConfig ID. Must not be <c>null</c>.</param>
        public ProjectTransferConfigName(string projectId, string transferConfigId)
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
        public override bool Equals(object obj) => Equals(obj as ProjectTransferConfigName);

        /// <inheritdoc />
        public bool Equals(ProjectTransferConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectTransferConfigName a, ProjectTransferConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectTransferConfigName a, ProjectTransferConfigName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>ProjectRunName: A resource of type 'project_run'.</description></item>
    /// <item><description>LocationRunName: A resource of type 'location_run'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class RunNameOneof : gax::IResourceName, sys::IEquatable<RunNameOneof>
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
            /// A resource of type 'project_run'.
            /// </summary>
            ProjectRunName = 1,

            /// <summary>
            /// A resource of type 'location_run'.
            /// </summary>
            LocationRunName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="RunNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>ProjectRunName: A resource of type 'project_run'.</description></item>
        /// <item><description>LocationRunName: A resource of type 'location_run'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="RunNameOneof"/> if successful.</returns>
        public static RunNameOneof Parse(string name, bool allowUnknown)
        {
            RunNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="RunNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>ProjectRunName: A resource of type 'project_run'.</description></item>
        /// <item><description>LocationRunName: A resource of type 'location_run'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="RunNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out RunNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            ProjectRunName projectRunName;
            if (ProjectRunName.TryParse(name, out projectRunName))
            {
                result = new RunNameOneof(OneofType.ProjectRunName, projectRunName);
                return true;
            }
            LocationRunName locationRunName;
            if (LocationRunName.TryParse(name, out locationRunName))
            {
                result = new RunNameOneof(OneofType.LocationRunName, locationRunName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new RunNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="RunNameOneof"/> from the provided <see cref="ProjectRunName"/>
        /// </summary>
        /// <param name="projectRunName">The <see cref="ProjectRunName"/> to be contained within
        /// the returned <see cref="RunNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="RunNameOneof"/>, containing <paramref name="projectRunName"/>.</returns>
        public static RunNameOneof From(ProjectRunName projectRunName) => new RunNameOneof(OneofType.ProjectRunName, projectRunName);

        /// <summary>
        /// Construct a new instance of <see cref="RunNameOneof"/> from the provided <see cref="LocationRunName"/>
        /// </summary>
        /// <param name="locationRunName">The <see cref="LocationRunName"/> to be contained within
        /// the returned <see cref="RunNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="RunNameOneof"/>, containing <paramref name="locationRunName"/>.</returns>
        public static RunNameOneof From(LocationRunName locationRunName) => new RunNameOneof(OneofType.LocationRunName, locationRunName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.ProjectRunName: return name is ProjectRunName;
                case OneofType.LocationRunName: return name is LocationRunName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="RunNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public RunNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="ProjectRunName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="ProjectRunName"/>.
        /// </remarks>
        public ProjectRunName ProjectRunName => CheckAndReturn<ProjectRunName>(OneofType.ProjectRunName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="LocationRunName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="LocationRunName"/>.
        /// </remarks>
        public LocationRunName LocationRunName => CheckAndReturn<LocationRunName>(OneofType.LocationRunName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

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

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>ProjectTransferConfigName: A resource of type 'project_transfer_config'.</description></item>
    /// <item><description>LocationTransferConfigName: A resource of type 'location_transfer_config'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class TransferConfigNameOneof : gax::IResourceName, sys::IEquatable<TransferConfigNameOneof>
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
            /// A resource of type 'project_transfer_config'.
            /// </summary>
            ProjectTransferConfigName = 1,

            /// <summary>
            /// A resource of type 'location_transfer_config'.
            /// </summary>
            LocationTransferConfigName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="TransferConfigNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>ProjectTransferConfigName: A resource of type 'project_transfer_config'.</description></item>
        /// <item><description>LocationTransferConfigName: A resource of type 'location_transfer_config'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="TransferConfigNameOneof"/> if successful.</returns>
        public static TransferConfigNameOneof Parse(string name, bool allowUnknown)
        {
            TransferConfigNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="TransferConfigNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>ProjectTransferConfigName: A resource of type 'project_transfer_config'.</description></item>
        /// <item><description>LocationTransferConfigName: A resource of type 'location_transfer_config'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TransferConfigNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out TransferConfigNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            ProjectTransferConfigName projectTransferConfigName;
            if (ProjectTransferConfigName.TryParse(name, out projectTransferConfigName))
            {
                result = new TransferConfigNameOneof(OneofType.ProjectTransferConfigName, projectTransferConfigName);
                return true;
            }
            LocationTransferConfigName locationTransferConfigName;
            if (LocationTransferConfigName.TryParse(name, out locationTransferConfigName))
            {
                result = new TransferConfigNameOneof(OneofType.LocationTransferConfigName, locationTransferConfigName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new TransferConfigNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="TransferConfigNameOneof"/> from the provided <see cref="ProjectTransferConfigName"/>
        /// </summary>
        /// <param name="projectTransferConfigName">The <see cref="ProjectTransferConfigName"/> to be contained within
        /// the returned <see cref="TransferConfigNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="TransferConfigNameOneof"/>, containing <paramref name="projectTransferConfigName"/>.</returns>
        public static TransferConfigNameOneof From(ProjectTransferConfigName projectTransferConfigName) => new TransferConfigNameOneof(OneofType.ProjectTransferConfigName, projectTransferConfigName);

        /// <summary>
        /// Construct a new instance of <see cref="TransferConfigNameOneof"/> from the provided <see cref="LocationTransferConfigName"/>
        /// </summary>
        /// <param name="locationTransferConfigName">The <see cref="LocationTransferConfigName"/> to be contained within
        /// the returned <see cref="TransferConfigNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="TransferConfigNameOneof"/>, containing <paramref name="locationTransferConfigName"/>.</returns>
        public static TransferConfigNameOneof From(LocationTransferConfigName locationTransferConfigName) => new TransferConfigNameOneof(OneofType.LocationTransferConfigName, locationTransferConfigName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.ProjectTransferConfigName: return name is ProjectTransferConfigName;
                case OneofType.LocationTransferConfigName: return name is LocationTransferConfigName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="TransferConfigNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public TransferConfigNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="ProjectTransferConfigName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="ProjectTransferConfigName"/>.
        /// </remarks>
        public ProjectTransferConfigName ProjectTransferConfigName => CheckAndReturn<ProjectTransferConfigName>(OneofType.ProjectTransferConfigName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="LocationTransferConfigName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="LocationTransferConfigName"/>.
        /// </remarks>
        public LocationTransferConfigName LocationTransferConfigName => CheckAndReturn<LocationTransferConfigName>(OneofType.LocationTransferConfigName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

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


    public partial class CheckValidCredsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof DataSourceNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateTransferConfigRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DataSource
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof DataSourceNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteTransferConfigRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof TransferConfigNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteTransferRunRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof RunNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDataSourceRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof DataSourceNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.DataSourceNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetTransferConfigRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof TransferConfigNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetTransferRunRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof RunNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListDataSourcesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTransferConfigsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof ParentAsParentNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.ParentNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTransferLogsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof ParentAsRunNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTransferRunsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof ParentAsTransferConfigNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ScheduleTransferRunsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof ParentAsTransferConfigNameOneof
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof.Parse(Parent, true); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class TransferConfig
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof TransferConfigNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.TransferConfigNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class TransferRun
    {
        /// <summary>
        /// <see cref="Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof RunNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.BigQuery.DataTransfer.V1.RunNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}