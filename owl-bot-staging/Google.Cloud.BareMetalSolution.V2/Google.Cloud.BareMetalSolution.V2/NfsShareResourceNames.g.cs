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
    /// <summary>Resource name for the <c>NFSShare</c> resource.</summary>
    public sealed partial class NFSShareName : gax::IResourceName, sys::IEquatable<NFSShareName>
    {
        /// <summary>The possible contents of <see cref="NFSShareName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/nfsShares/{nfs_share}</c>.
            /// </summary>
            ProjectLocationNfsShare = 1,
        }

        private static gax::PathTemplate s_projectLocationNfsShare = new gax::PathTemplate("projects/{project}/locations/{location}/nfsShares/{nfs_share}");

        /// <summary>Creates a <see cref="NFSShareName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NFSShareName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static NFSShareName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NFSShareName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NFSShareName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/nfsShares/{nfs_share}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nfsShareId">The <c>NfsShare</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NFSShareName"/> constructed from the provided ids.</returns>
        public static NFSShareName FromProjectLocationNfsShare(string projectId, string locationId, string nfsShareId) =>
            new NFSShareName(ResourceNameType.ProjectLocationNfsShare, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), nfsShareId: gax::GaxPreconditions.CheckNotNullOrEmpty(nfsShareId, nameof(nfsShareId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NFSShareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nfsShares/{nfs_share}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nfsShareId">The <c>NfsShare</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NFSShareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nfsShares/{nfs_share}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string nfsShareId) =>
            FormatProjectLocationNfsShare(projectId, locationId, nfsShareId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NFSShareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nfsShares/{nfs_share}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nfsShareId">The <c>NfsShare</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NFSShareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/nfsShares/{nfs_share}</c>.
        /// </returns>
        public static string FormatProjectLocationNfsShare(string projectId, string locationId, string nfsShareId) =>
            s_projectLocationNfsShare.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(nfsShareId, nameof(nfsShareId)));

        /// <summary>Parses the given resource name string into a new <see cref="NFSShareName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/nfsShares/{nfs_share}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nFSShareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NFSShareName"/> if successful.</returns>
        public static NFSShareName Parse(string nFSShareName) => Parse(nFSShareName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NFSShareName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/nfsShares/{nfs_share}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nFSShareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NFSShareName"/> if successful.</returns>
        public static NFSShareName Parse(string nFSShareName, bool allowUnparsed) =>
            TryParse(nFSShareName, allowUnparsed, out NFSShareName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NFSShareName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/nfsShares/{nfs_share}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="nFSShareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NFSShareName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nFSShareName, out NFSShareName result) => TryParse(nFSShareName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NFSShareName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/nfsShares/{nfs_share}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="nFSShareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NFSShareName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string nFSShareName, bool allowUnparsed, out NFSShareName result)
        {
            gax::GaxPreconditions.CheckNotNull(nFSShareName, nameof(nFSShareName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNfsShare.TryParseName(nFSShareName, out resourceName))
            {
                result = FromProjectLocationNfsShare(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(nFSShareName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NFSShareName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string nfsShareId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NfsShareId = nfsShareId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NFSShareName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/nfsShares/{nfs_share}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="nfsShareId">The <c>NfsShare</c> ID. Must not be <c>null</c> or empty.</param>
        public NFSShareName(string projectId, string locationId, string nfsShareId) : this(ResourceNameType.ProjectLocationNfsShare, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), nfsShareId: gax::GaxPreconditions.CheckNotNullOrEmpty(nfsShareId, nameof(nfsShareId)))
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
        /// The <c>NfsShare</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NfsShareId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
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
                case ResourceNameType.ProjectLocationNfsShare: return s_projectLocationNfsShare.Expand(ProjectId, LocationId, NfsShareId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NFSShareName);

        /// <inheritdoc/>
        public bool Equals(NFSShareName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NFSShareName a, NFSShareName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NFSShareName a, NFSShareName b) => !(a == b);
    }

    public partial class NfsShare
    {
        /// <summary>
        /// <see cref="gcbv::NFSShareName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::NFSShareName NFSShareName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::NFSShareName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="VolumeName"/>-typed view over the <see cref="Volume"/> resource name property.</summary>
        public VolumeName VolumeAsVolumeName
        {
            get => string.IsNullOrEmpty(Volume) ? null : VolumeName.Parse(Volume, allowUnparsed: true);
            set => Volume = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class AllowedClient
            {
                /// <summary>
                /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
                /// </summary>
                public NetworkName NetworkAsNetworkName
                {
                    get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
                    set => Network = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class GetNfsShareRequest
    {
        /// <summary>
        /// <see cref="gcbv::NFSShareName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::NFSShareName NFSShareName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::NFSShareName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNfsSharesRequest
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

    public partial class RenameNfsShareRequest
    {
        /// <summary>
        /// <see cref="gcbv::NFSShareName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::NFSShareName NFSShareName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::NFSShareName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateNfsShareRequest
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

    public partial class DeleteNfsShareRequest
    {
        /// <summary>
        /// <see cref="gcbv::NFSShareName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::NFSShareName NFSShareName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::NFSShareName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
