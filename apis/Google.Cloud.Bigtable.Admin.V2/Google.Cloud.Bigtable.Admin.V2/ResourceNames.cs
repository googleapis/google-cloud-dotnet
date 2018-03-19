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

namespace Google.Cloud.Bigtable.Admin.V2
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
    /// Resource name for the 'instance' resource.
    /// </summary>
    public sealed partial class InstanceName : IResourceName, IEquatable<InstanceName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/instances/{instance}");

        /// <summary>
        /// Parses the given instance resource name in string form into a new
        /// <see cref="InstanceName"/> instance.
        /// </summary>
        /// <param name="instanceName">The instance resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName)
        {
            GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            TemplatedResourceName resourceName = s_template.ParseName(instanceName);
            return new InstanceName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given instance resource name in string form into a new
        /// <see cref="InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="instanceName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="instanceName">The instance resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InstanceName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, out InstanceName result)
        {
            GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(instanceName, out resourceName))
            {
                result = new InstanceName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="InstanceName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        public InstanceName(string projectId, string instanceId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The instance ID. Never <c>null</c>.
        /// </summary>
        public string InstanceId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as InstanceName);

        /// <inheritdoc />
        public bool Equals(InstanceName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(InstanceName a, InstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(InstanceName a, InstanceName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'app_profile' resource.
    /// </summary>
    public sealed partial class AppProfileName : IResourceName, IEquatable<AppProfileName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/instances/{instance}/appProfiles/{app_profile}");

        /// <summary>
        /// Parses the given app_profile resource name in string form into a new
        /// <see cref="AppProfileName"/> instance.
        /// </summary>
        /// <param name="appProfileName">The app_profile resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AppProfileName"/> if successful.</returns>
        public static AppProfileName Parse(string appProfileName)
        {
            GaxPreconditions.CheckNotNull(appProfileName, nameof(appProfileName));
            TemplatedResourceName resourceName = s_template.ParseName(appProfileName);
            return new AppProfileName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given app_profile resource name in string form into a new
        /// <see cref="AppProfileName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="appProfileName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="appProfileName">The app_profile resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AppProfileName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string appProfileName, out AppProfileName result)
        {
            GaxPreconditions.CheckNotNull(appProfileName, nameof(appProfileName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(appProfileName, out resourceName))
            {
                result = new AppProfileName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AppProfileName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        /// <param name="appProfileId">The appProfile ID. Must not be <c>null</c>.</param>
        public AppProfileName(string projectId, string instanceId, string appProfileId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
            AppProfileId = GaxPreconditions.CheckNotNull(appProfileId, nameof(appProfileId));
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
        /// The appProfile ID. Never <c>null</c>.
        /// </summary>
        public string AppProfileId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceId, AppProfileId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AppProfileName);

        /// <inheritdoc />
        public bool Equals(AppProfileName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AppProfileName a, AppProfileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AppProfileName a, AppProfileName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'cluster' resource.
    /// </summary>
    public sealed partial class ClusterName : IResourceName, IEquatable<ClusterName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/instances/{instance}/clusters/{cluster}");

        /// <summary>
        /// Parses the given cluster resource name in string form into a new
        /// <see cref="ClusterName"/> instance.
        /// </summary>
        /// <param name="clusterName">The cluster resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ClusterName"/> if successful.</returns>
        public static ClusterName Parse(string clusterName)
        {
            GaxPreconditions.CheckNotNull(clusterName, nameof(clusterName));
            TemplatedResourceName resourceName = s_template.ParseName(clusterName);
            return new ClusterName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given cluster resource name in string form into a new
        /// <see cref="ClusterName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="clusterName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="clusterName">The cluster resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ClusterName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clusterName, out ClusterName result)
        {
            GaxPreconditions.CheckNotNull(clusterName, nameof(clusterName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(clusterName, out resourceName))
            {
                result = new ClusterName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ClusterName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        /// <param name="clusterId">The cluster ID. Must not be <c>null</c>.</param>
        public ClusterName(string projectId, string instanceId, string clusterId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
            ClusterId = GaxPreconditions.CheckNotNull(clusterId, nameof(clusterId));
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
        /// The cluster ID. Never <c>null</c>.
        /// </summary>
        public string ClusterId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceId, ClusterId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ClusterName);

        /// <inheritdoc />
        public bool Equals(ClusterName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ClusterName a, ClusterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ClusterName a, ClusterName b) => !(a == b);
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
    /// Resource name for the 'snapshot' resource.
    /// </summary>
    public sealed partial class SnapshotName : IResourceName, IEquatable<SnapshotName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}");

        /// <summary>
        /// Parses the given snapshot resource name in string form into a new
        /// <see cref="SnapshotName"/> instance.
        /// </summary>
        /// <param name="snapshotName">The snapshot resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SnapshotName"/> if successful.</returns>
        public static SnapshotName Parse(string snapshotName)
        {
            GaxPreconditions.CheckNotNull(snapshotName, nameof(snapshotName));
            TemplatedResourceName resourceName = s_template.ParseName(snapshotName);
            return new SnapshotName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given snapshot resource name in string form into a new
        /// <see cref="SnapshotName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="snapshotName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="snapshotName">The snapshot resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SnapshotName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string snapshotName, out SnapshotName result)
        {
            GaxPreconditions.CheckNotNull(snapshotName, nameof(snapshotName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(snapshotName, out resourceName))
            {
                result = new SnapshotName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="SnapshotName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        /// <param name="clusterId">The cluster ID. Must not be <c>null</c>.</param>
        /// <param name="snapshotId">The snapshot ID. Must not be <c>null</c>.</param>
        public SnapshotName(string projectId, string instanceId, string clusterId, string snapshotId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
            ClusterId = GaxPreconditions.CheckNotNull(clusterId, nameof(clusterId));
            SnapshotId = GaxPreconditions.CheckNotNull(snapshotId, nameof(snapshotId));
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
        /// The cluster ID. Never <c>null</c>.
        /// </summary>
        public string ClusterId { get; }

        /// <summary>
        /// The snapshot ID. Never <c>null</c>.
        /// </summary>
        public string SnapshotId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceId, ClusterId, SnapshotId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SnapshotName);

        /// <inheritdoc />
        public bool Equals(SnapshotName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SnapshotName a, SnapshotName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SnapshotName a, SnapshotName b) => !(a == b);
    }

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


    public partial class CheckConsistencyRequest
    {
        /// <summary>
        /// <see cref="TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TableName TableName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.TableName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Cluster
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ClusterName ClusterName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.ClusterName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Location"/> resource name property.
        /// </summary>
        public LocationName LocationAsLocationName
        {
            get { return string.IsNullOrEmpty(Location) ? null : Google.Cloud.Bigtable.Admin.V2.LocationName.Parse(Location); }
            set { Location = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateAppProfileRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Bigtable.Admin.V2.InstanceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateClusterRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Bigtable.Admin.V2.InstanceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateInstanceRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Bigtable.Admin.V2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateTableFromSnapshotRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Bigtable.Admin.V2.InstanceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="SnapshotName"/>-typed view over the <see cref="SourceSnapshot"/> resource name property.
        /// </summary>
        public SnapshotName SourceSnapshotAsSnapshotName
        {
            get { return string.IsNullOrEmpty(SourceSnapshot) ? null : Google.Cloud.Bigtable.Admin.V2.SnapshotName.Parse(SourceSnapshot); }
            set { SourceSnapshot = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateTableRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Bigtable.Admin.V2.InstanceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteAppProfileRequest
    {
        /// <summary>
        /// <see cref="AppProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public AppProfileName AppProfileName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.AppProfileName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteClusterRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ClusterName ClusterName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.ClusterName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteInstanceRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteSnapshotRequest
    {
        /// <summary>
        /// <see cref="SnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public SnapshotName SnapshotName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.SnapshotName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteTableRequest
    {
        /// <summary>
        /// <see cref="TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TableName TableName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.TableName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DropRowRangeRequest
    {
        /// <summary>
        /// <see cref="TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TableName TableName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.TableName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GenerateConsistencyTokenRequest
    {
        /// <summary>
        /// <see cref="TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TableName TableName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.TableName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetAppProfileRequest
    {
        /// <summary>
        /// <see cref="AppProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public AppProfileName AppProfileName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.AppProfileName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetClusterRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ClusterName ClusterName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.ClusterName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetSnapshotRequest
    {
        /// <summary>
        /// <see cref="SnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public SnapshotName SnapshotName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.SnapshotName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetTableRequest
    {
        /// <summary>
        /// <see cref="TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TableName TableName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.TableName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Instance
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InstanceName InstanceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.InstanceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListAppProfilesRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Bigtable.Admin.V2.InstanceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListClustersRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Bigtable.Admin.V2.InstanceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListInstancesRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Bigtable.Admin.V2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListSnapshotsRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Bigtable.Admin.V2.ClusterName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTablesRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Bigtable.Admin.V2.InstanceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ModifyColumnFamiliesRequest
    {
        /// <summary>
        /// <see cref="TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TableName TableName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.TableName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Snapshot
    {
        /// <summary>
        /// <see cref="SnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public SnapshotName SnapshotName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.SnapshotName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class SnapshotTableRequest
    {
        /// <summary>
        /// <see cref="TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TableName TableName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.TableName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Cluster"/> resource name property.
        /// </summary>
        public ClusterName ClusterAsClusterName
        {
            get { return string.IsNullOrEmpty(Cluster) ? null : Google.Cloud.Bigtable.Admin.V2.ClusterName.Parse(Cluster); }
            set { Cluster = value != null ? value.ToString() : ""; }
        }

        /// <summary>
        /// <see cref="SnapshotName"/>-typed view over the <see cref="SnapshotId"/> resource name property.
        /// </summary>
        public SnapshotName SnapshotIdAsSnapshotName
        {
            get { return string.IsNullOrEmpty(SnapshotId) ? null : Google.Cloud.Bigtable.Admin.V2.SnapshotName.Parse(SnapshotId); }
            set { SnapshotId = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Table
    {
        /// <summary>
        /// <see cref="TableName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public TableName TableName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Bigtable.Admin.V2.TableName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}