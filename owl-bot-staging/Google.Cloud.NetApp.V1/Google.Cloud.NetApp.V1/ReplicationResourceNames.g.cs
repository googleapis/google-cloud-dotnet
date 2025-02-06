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
using gcnv = Google.Cloud.NetApp.V1;
using sys = System;

namespace Google.Cloud.NetApp.V1
{
    /// <summary>Resource name for the <c>Replication</c> resource.</summary>
    public sealed partial class ReplicationName : gax::IResourceName, sys::IEquatable<ReplicationName>
    {
        /// <summary>The possible contents of <see cref="ReplicationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}</c>.
            /// </summary>
            ProjectLocationVolumeReplication = 1,
        }

        private static gax::PathTemplate s_projectLocationVolumeReplication = new gax::PathTemplate("projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}");

        /// <summary>Creates a <see cref="ReplicationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReplicationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReplicationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReplicationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReplicationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replicationId">The <c>Replication</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReplicationName"/> constructed from the provided ids.</returns>
        public static ReplicationName FromProjectLocationVolumeReplication(string projectId, string locationId, string volumeId, string replicationId) =>
            new ReplicationName(ResourceNameType.ProjectLocationVolumeReplication, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), replicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(replicationId, nameof(replicationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplicationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replicationId">The <c>Replication</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplicationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string volumeId, string replicationId) =>
            FormatProjectLocationVolumeReplication(projectId, locationId, volumeId, replicationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplicationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replicationId">The <c>Replication</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplicationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}</c>.
        /// </returns>
        public static string FormatProjectLocationVolumeReplication(string projectId, string locationId, string volumeId, string replicationId) =>
            s_projectLocationVolumeReplication.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(replicationId, nameof(replicationId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReplicationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="replicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReplicationName"/> if successful.</returns>
        public static ReplicationName Parse(string replicationName) => Parse(replicationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReplicationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="replicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReplicationName"/> if successful.</returns>
        public static ReplicationName Parse(string replicationName, bool allowUnparsed) =>
            TryParse(replicationName, allowUnparsed, out ReplicationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReplicationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="replicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReplicationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string replicationName, out ReplicationName result) =>
            TryParse(replicationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReplicationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="replicationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReplicationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string replicationName, bool allowUnparsed, out ReplicationName result)
        {
            gax::GaxPreconditions.CheckNotNull(replicationName, nameof(replicationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationVolumeReplication.TryParseName(replicationName, out resourceName))
            {
                result = FromProjectLocationVolumeReplication(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(replicationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReplicationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string replicationId = null, string volumeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReplicationId = replicationId;
            VolumeId = volumeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReplicationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/replications/{replication}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replicationId">The <c>Replication</c> ID. Must not be <c>null</c> or empty.</param>
        public ReplicationName(string projectId, string locationId, string volumeId, string replicationId) : this(ResourceNameType.ProjectLocationVolumeReplication, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), replicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(replicationId, nameof(replicationId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Replication</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ReplicationId { get; }

        /// <summary>
        /// The <c>Volume</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VolumeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationVolumeReplication: return s_projectLocationVolumeReplication.Expand(ProjectId, LocationId, VolumeId, ReplicationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReplicationName);

        /// <inheritdoc/>
        public bool Equals(ReplicationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReplicationName a, ReplicationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReplicationName a, ReplicationName b) => !(a == b);
    }

    public partial class Replication
    {
        /// <summary>
        /// <see cref="gcnv::ReplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ReplicationName ReplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ReplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VolumeName"/>-typed view over the <see cref="DestinationVolume"/> resource name property.
        /// </summary>
        public VolumeName DestinationVolumeAsVolumeName
        {
            get => string.IsNullOrEmpty(DestinationVolume) ? null : VolumeName.Parse(DestinationVolume, allowUnparsed: true);
            set => DestinationVolume = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VolumeName"/>-typed view over the <see cref="SourceVolume"/> resource name property.
        /// </summary>
        public VolumeName SourceVolumeAsVolumeName
        {
            get => string.IsNullOrEmpty(SourceVolume) ? null : VolumeName.Parse(SourceVolume, allowUnparsed: true);
            set => SourceVolume = value?.ToString() ?? "";
        }
    }

    public partial class ListReplicationsRequest
    {
        /// <summary><see cref="VolumeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public VolumeName ParentAsVolumeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VolumeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetReplicationRequest
    {
        /// <summary>
        /// <see cref="gcnv::ReplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ReplicationName ReplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ReplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DestinationVolumeParameters
    {
        /// <summary>
        /// <see cref="StoragePoolName"/>-typed view over the <see cref="StoragePool"/> resource name property.
        /// </summary>
        public StoragePoolName StoragePoolAsStoragePoolName
        {
            get => string.IsNullOrEmpty(StoragePool) ? null : StoragePoolName.Parse(StoragePool, allowUnparsed: true);
            set => StoragePool = value?.ToString() ?? "";
        }
    }

    public partial class CreateReplicationRequest
    {
        /// <summary><see cref="VolumeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public VolumeName ParentAsVolumeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VolumeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteReplicationRequest
    {
        /// <summary>
        /// <see cref="gcnv::ReplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ReplicationName ReplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ReplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StopReplicationRequest
    {
        /// <summary>
        /// <see cref="gcnv::ReplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ReplicationName ReplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ReplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResumeReplicationRequest
    {
        /// <summary>
        /// <see cref="gcnv::ReplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ReplicationName ReplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ReplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReverseReplicationDirectionRequest
    {
        /// <summary>
        /// <see cref="gcnv::ReplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ReplicationName ReplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ReplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EstablishPeeringRequest
    {
        /// <summary>
        /// <see cref="gcnv::ReplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ReplicationName ReplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ReplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SyncReplicationRequest
    {
        /// <summary>
        /// <see cref="gcnv::ReplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ReplicationName ReplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ReplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
