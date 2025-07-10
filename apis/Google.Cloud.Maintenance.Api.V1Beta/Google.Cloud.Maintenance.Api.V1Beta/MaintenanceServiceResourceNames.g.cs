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
using gcmav = Google.Cloud.Maintenance.Api.V1Beta;
using sys = System;

namespace Google.Cloud.Maintenance.Api.V1Beta
{
    /// <summary>Resource name for the <c>ResourceMaintenance</c> resource.</summary>
    public sealed partial class ResourceMaintenanceName : gax::IResourceName, sys::IEquatable<ResourceMaintenanceName>
    {
        /// <summary>The possible contents of <see cref="ResourceMaintenanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}</c>.
            /// </summary>
            ProjectLocationResourceMaintenance = 1,
        }

        private static gax::PathTemplate s_projectLocationResourceMaintenance = new gax::PathTemplate("projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}");

        /// <summary>Creates a <see cref="ResourceMaintenanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ResourceMaintenanceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ResourceMaintenanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ResourceMaintenanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ResourceMaintenanceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceMaintenanceId">
        /// The <c>ResourceMaintenance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ResourceMaintenanceName"/> constructed from the provided ids.
        /// </returns>
        public static ResourceMaintenanceName FromProjectLocationResourceMaintenance(string projectId, string locationId, string resourceMaintenanceId) =>
            new ResourceMaintenanceName(ResourceNameType.ProjectLocationResourceMaintenance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceMaintenanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceMaintenanceId, nameof(resourceMaintenanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceMaintenanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceMaintenanceId">
        /// The <c>ResourceMaintenance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ResourceMaintenanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string resourceMaintenanceId) =>
            FormatProjectLocationResourceMaintenance(projectId, locationId, resourceMaintenanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceMaintenanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceMaintenanceId">
        /// The <c>ResourceMaintenance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ResourceMaintenanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}</c>.
        /// </returns>
        public static string FormatProjectLocationResourceMaintenance(string projectId, string locationId, string resourceMaintenanceId) =>
            s_projectLocationResourceMaintenance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceMaintenanceId, nameof(resourceMaintenanceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ResourceMaintenanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="resourceMaintenanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ResourceMaintenanceName"/> if successful.</returns>
        public static ResourceMaintenanceName Parse(string resourceMaintenanceName) => Parse(resourceMaintenanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ResourceMaintenanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceMaintenanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ResourceMaintenanceName"/> if successful.</returns>
        public static ResourceMaintenanceName Parse(string resourceMaintenanceName, bool allowUnparsed) =>
            TryParse(resourceMaintenanceName, allowUnparsed, out ResourceMaintenanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceMaintenanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="resourceMaintenanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceMaintenanceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceMaintenanceName, out ResourceMaintenanceName result) =>
            TryParse(resourceMaintenanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceMaintenanceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceMaintenanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceMaintenanceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceMaintenanceName, bool allowUnparsed, out ResourceMaintenanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(resourceMaintenanceName, nameof(resourceMaintenanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationResourceMaintenance.TryParseName(resourceMaintenanceName, out resourceName))
            {
                result = FromProjectLocationResourceMaintenance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(resourceMaintenanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ResourceMaintenanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string resourceMaintenanceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ResourceMaintenanceId = resourceMaintenanceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ResourceMaintenanceName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/resourceMaintenances/{resource_maintenance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceMaintenanceId">
        /// The <c>ResourceMaintenance</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ResourceMaintenanceName(string projectId, string locationId, string resourceMaintenanceId) : this(ResourceNameType.ProjectLocationResourceMaintenance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceMaintenanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceMaintenanceId, nameof(resourceMaintenanceId)))
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
        /// The <c>ResourceMaintenance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ResourceMaintenanceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationResourceMaintenance: return s_projectLocationResourceMaintenance.Expand(ProjectId, LocationId, ResourceMaintenanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ResourceMaintenanceName);

        /// <inheritdoc/>
        public bool Equals(ResourceMaintenanceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ResourceMaintenanceName a, ResourceMaintenanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ResourceMaintenanceName a, ResourceMaintenanceName b) => !(a == b);
    }

    public partial class SummarizeMaintenancesRequest
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

    public partial class ResourceMaintenance
    {
        /// <summary>
        /// <see cref="gcmav::ResourceMaintenanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmav::ResourceMaintenanceName ResourceMaintenanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmav::ResourceMaintenanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListResourceMaintenancesRequest
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

    public partial class GetResourceMaintenanceRequest
    {
        /// <summary>
        /// <see cref="gcmav::ResourceMaintenanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmav::ResourceMaintenanceName ResourceMaintenanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmav::ResourceMaintenanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
