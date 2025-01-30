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
using gcbv = Google.Cloud.BareMetalSolution.V2;
using sys = System;

namespace Google.Cloud.BareMetalSolution.V2
{
    /// <summary>Resource name for the <c>Volume</c> resource.</summary>
    public sealed partial class VolumeName : gax::IResourceName, sys::IEquatable<VolumeName>
    {
        /// <summary>The possible contents of <see cref="VolumeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
            /// </summary>
            ProjectLocationVolume = 1,
        }

        private static gax::PathTemplate s_projectLocationVolume = new gax::PathTemplate("projects/{project}/locations/{location}/volumes/{volume}");

        /// <summary>Creates a <see cref="VolumeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VolumeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VolumeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VolumeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VolumeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VolumeName"/> constructed from the provided ids.</returns>
        public static VolumeName FromProjectLocationVolume(string projectId, string locationId, string volumeId) =>
            new VolumeName(ResourceNameType.ProjectLocationVolume, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string volumeId) =>
            FormatProjectLocationVolume(projectId, locationId, volumeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VolumeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VolumeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>.
        /// </returns>
        public static string FormatProjectLocationVolume(string projectId, string locationId, string volumeId) =>
            s_projectLocationVolume.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)));

        /// <summary>Parses the given resource name string into a new <see cref="VolumeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/volumes/{volume}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="volumeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VolumeName"/> if successful.</returns>
        public static VolumeName Parse(string volumeName) => Parse(volumeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VolumeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/volumes/{volume}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VolumeName"/> if successful.</returns>
        public static VolumeName Parse(string volumeName, bool allowUnparsed) =>
            TryParse(volumeName, allowUnparsed, out VolumeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/volumes/{volume}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="volumeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeName, out VolumeName result) => TryParse(volumeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VolumeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/volumes/{volume}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="volumeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VolumeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string volumeName, bool allowUnparsed, out VolumeName result)
        {
            gax::GaxPreconditions.CheckNotNull(volumeName, nameof(volumeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationVolume.TryParseName(volumeName, out resourceName))
            {
                result = FromProjectLocationVolume(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(volumeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VolumeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string volumeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            VolumeId = volumeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VolumeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/volumes/{volume}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="volumeId">The <c>Volume</c> ID. Must not be <c>null</c> or empty.</param>
        public VolumeName(string projectId, string locationId, string volumeId) : this(ResourceNameType.ProjectLocationVolume, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), volumeId: gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)))
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
                case ResourceNameType.ProjectLocationVolume: return s_projectLocationVolume.Expand(ProjectId, LocationId, VolumeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VolumeName);

        /// <inheritdoc/>
        public bool Equals(VolumeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VolumeName a, VolumeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VolumeName a, VolumeName b) => !(a == b);
    }

    public partial class Volume
    {
        /// <summary>
        /// <see cref="gcbv::VolumeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeName VolumeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Instances"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<InstanceName> InstancesAsInstanceNames
        {
            get => new gax::ResourceNameList<InstanceName>(Instances, s => string.IsNullOrEmpty(s) ? null : InstanceName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class GetVolumeRequest
    {
        /// <summary>
        /// <see cref="gcbv::VolumeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeName VolumeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListVolumesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RenameVolumeRequest
    {
        /// <summary>
        /// <see cref="gcbv::VolumeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeName VolumeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EvictVolumeRequest
    {
        /// <summary>
        /// <see cref="gcbv::VolumeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::VolumeName VolumeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::VolumeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResizeVolumeRequest
    {
        /// <summary><see cref="VolumeName"/>-typed view over the <see cref="Volume"/> resource name property.</summary>
        public VolumeName VolumeAsVolumeName
        {
            get => string.IsNullOrEmpty(Volume) ? null : VolumeName.Parse(Volume, allowUnparsed: true);
            set => Volume = value?.ToString() ?? "";
        }
    }
}
