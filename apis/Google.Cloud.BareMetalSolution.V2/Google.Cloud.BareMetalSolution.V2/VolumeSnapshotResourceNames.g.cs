// Copyright 2023 Google LLC
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
using gcbv = Google.Cloud.BareMetalSolution.V2;
using sys = System;

namespace Google.Cloud.BareMetalSolution.V2
{
    /// <summary>Resource name for the <c>VolumeSnapshot</c> resource.</summary>
    public sealed partial class VolumeSnapshotName : gax::IResourceName, sys::IEquatable<VolumeSnapshotName>
    {
        /// <summary>The possible contents of <see cref="VolumeSnapshotName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
            /// </summary>
            ProjectLocationVolumeSnapshot = 1,
        }

        private static gax::PathTemplate s_projectLocationVolumeSnapshot = new gax::PathTemplate("projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}");

        /// <summary>Creates a <see cref="VolumeSnapshotName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VolumeSnapshotName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VolumeSnapshotName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VolumeSnapshotName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VolumeSnapshotName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VolumeSnapshotName"/> constructed from the provided ids.</returns>
        public static VolumeSnapshotName FromProjectLocationVolumeSnapshot(string projectId, string locationId, string volumeId, string snapshotId) =>
            new VolumeSnapshotName(ResourceNameType.ProjectLocationVolumeSnapshot, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), snapshotId: gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeSnapshotName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeSnapshotName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string volumeId, string snapshotId) =>
            FormatProjectLocationVolumeSnapshot(projectId, locationId, volumeId, snapshotId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeSnapshotName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeSnapshotName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>.
        /// </returns>
        public static string FormatProjectLocationVolumeSnapshot(string projectId, string locationId, string volumeId, string snapshotId) =>
            s_projectLocationVolumeSnapshot.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VolumeSnapshotName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="volumeSnapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VolumeSnapshotName"/> if successful.</returns>
        public static VolumeSnapshotName Parse(string volumeSnapshotName) => Parse(volumeSnapshotName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VolumeSnapshotName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeSnapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VolumeSnapshotName"/> if successful.</returns>
        public static VolumeSnapshotName Parse(string volumeSnapshotName, bool allowUnparsed) =>
            TryParse(volumeSnapshotName, allowUnparsed, out VolumeSnapshotName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeSnapshotName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="volumeSnapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeSnapshotName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeSnapshotName, out VolumeSnapshotName result) =>
            TryParse(volumeSnapshotName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeSnapshotName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeSnapshotName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeSnapshotName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeSnapshotName, bool allowUnparsed, out VolumeSnapshotName result)
        {
            gax::GaxPreconditions.CheckNotNull(volumeSnapshotName, nameof(volumeSnapshotName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationVolumeSnapshot.TryParseName(volumeSnapshotName, out resourceName))
            {
                result = FromProjectLocationVolumeSnapshot(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(volumeSnapshotName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VolumeSnapshotName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string snapshotId = null, string volumeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SnapshotId = snapshotId;
            VolumeId = volumeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VolumeSnapshotName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}/snapshots/{snapshot}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="snapshotId">The <c>Snapshot</c> ID. Must not be <c>null</c> or empty.</param>
        public VolumeSnapshotName(string projectId, string locationId, string volumeId, string snapshotId) : this(ResourceNameType.ProjectLocationVolumeSnapshot, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)), snapshotId: gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)))
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
        /// The <c>Snapshot</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SnapshotId { get; }

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
                case ResourceNameType.ProjectLocationVolumeSnapshot: return s_projectLocationVolumeSnapshot.Expand(ProjectId, LocationId, VolumeId, SnapshotId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VolumeSnapshotName);

        /// <inheritdoc/>
        public bool Equals(VolumeSnapshotName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(VolumeSnapshotName a, VolumeSnapshotName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(VolumeSnapshotName a, VolumeSnapshotName b) => !(a == b);
    }

    public partial class VolumeSnapshot
    {
        /// <summary>
        /// <see cref="gcbv::VolumeSnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeSnapshotName VolumeSnapshotName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeSnapshotName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VolumeName"/>-typed view over the <see cref="StorageVolume"/> resource name property.
        /// </summary>
        public VolumeName StorageVolumeAsVolumeName
        {
            get => string.IsNullOrEmpty(StorageVolume) ? null : VolumeName.Parse(StorageVolume, allowUnparsed: true);
            set => StorageVolume = value?.ToString() ?? "";
        }
    }

    public partial class GetVolumeSnapshotRequest
    {
        /// <summary>
        /// <see cref="gcbv::VolumeSnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeSnapshotName VolumeSnapshotName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeSnapshotName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListVolumeSnapshotsRequest
    {
        /// <summary><see cref="VolumeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public VolumeName ParentAsVolumeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VolumeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteVolumeSnapshotRequest
    {
        /// <summary>
        /// <see cref="gcbv::VolumeSnapshotName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeSnapshotName VolumeSnapshotName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeSnapshotName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateVolumeSnapshotRequest
    {
        /// <summary><see cref="VolumeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public VolumeName ParentAsVolumeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : VolumeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RestoreVolumeSnapshotRequest
    {
        /// <summary>
        /// <see cref="VolumeSnapshotName"/>-typed view over the <see cref="VolumeSnapshot"/> resource name property.
        /// </summary>
        public VolumeSnapshotName VolumeSnapshotAsVolumeSnapshotName
        {
            get => string.IsNullOrEmpty(VolumeSnapshot) ? null : VolumeSnapshotName.Parse(VolumeSnapshot, allowUnparsed: true);
            set => VolumeSnapshot = value?.ToString() ?? "";
        }
    }
}