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
using gclv = Google.Cloud.LocationFinder.V1;
using sys = System;

namespace Google.Cloud.LocationFinder.V1
{
    /// <summary>Resource name for the <c>CloudLocation</c> resource.</summary>
    public sealed partial class CloudLocationName : gax::IResourceName, sys::IEquatable<CloudLocationName>
    {
        /// <summary>The possible contents of <see cref="CloudLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/cloudLocations/{cloud_location}</c>
            /// .
            /// </summary>
            ProjectLocationCloudLocation = 1,
        }

        private static gax::PathTemplate s_projectLocationCloudLocation = new gax::PathTemplate("projects/{project}/locations/{location}/cloudLocations/{cloud_location}");

        /// <summary>Creates a <see cref="CloudLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CloudLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CloudLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CloudLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CloudLocationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/cloudLocations/{cloud_location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudLocationId">The <c>CloudLocation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CloudLocationName"/> constructed from the provided ids.</returns>
        public static CloudLocationName FromProjectLocationCloudLocation(string projectId, string locationId, string cloudLocationId) =>
            new CloudLocationName(ResourceNameType.ProjectLocationCloudLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudLocationId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudLocationId, nameof(cloudLocationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudLocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudLocations/{cloud_location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudLocationId">The <c>CloudLocation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CloudLocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudLocations/{cloud_location}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string cloudLocationId) =>
            FormatProjectLocationCloudLocation(projectId, locationId, cloudLocationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudLocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudLocations/{cloud_location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudLocationId">The <c>CloudLocation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CloudLocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/cloudLocations/{cloud_location}</c>.
        /// </returns>
        public static string FormatProjectLocationCloudLocation(string projectId, string locationId, string cloudLocationId) =>
            s_projectLocationCloudLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cloudLocationId, nameof(cloudLocationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloudLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cloudLocations/{cloud_location}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloudLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CloudLocationName"/> if successful.</returns>
        public static CloudLocationName Parse(string cloudLocationName) => Parse(cloudLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloudLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cloudLocations/{cloud_location}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CloudLocationName"/> if successful.</returns>
        public static CloudLocationName Parse(string cloudLocationName, bool allowUnparsed) =>
            TryParse(cloudLocationName, allowUnparsed, out CloudLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cloudLocations/{cloud_location}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloudLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudLocationName, out CloudLocationName result) =>
            TryParse(cloudLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/cloudLocations/{cloud_location}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudLocationName, bool allowUnparsed, out CloudLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(cloudLocationName, nameof(cloudLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCloudLocation.TryParseName(cloudLocationName, out resourceName))
            {
                result = FromProjectLocationCloudLocation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cloudLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CloudLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cloudLocationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CloudLocationId = cloudLocationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CloudLocationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/cloudLocations/{cloud_location}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudLocationId">The <c>CloudLocation</c> ID. Must not be <c>null</c> or empty.</param>
        public CloudLocationName(string projectId, string locationId, string cloudLocationId) : this(ResourceNameType.ProjectLocationCloudLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudLocationId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudLocationId, nameof(cloudLocationId)))
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
        /// The <c>CloudLocation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CloudLocationId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationCloudLocation: return s_projectLocationCloudLocation.Expand(ProjectId, LocationId, CloudLocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CloudLocationName);

        /// <inheritdoc/>
        public bool Equals(CloudLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CloudLocationName a, CloudLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CloudLocationName a, CloudLocationName b) => !(a == b);
    }

    public partial class CloudLocation
    {
        /// <summary>
        /// <see cref="gclv::CloudLocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::CloudLocationName CloudLocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::CloudLocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gclv::CloudLocationName"/>-typed view over the <see cref="ContainingCloudLocation"/> resource
        /// name property.
        /// </summary>
        public gclv::CloudLocationName ContainingCloudLocationAsCloudLocationName
        {
            get => string.IsNullOrEmpty(ContainingCloudLocation) ? null : gclv::CloudLocationName.Parse(ContainingCloudLocation, allowUnparsed: true);
            set => ContainingCloudLocation = value?.ToString() ?? "";
        }
    }

    public partial class ListCloudLocationsRequest
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

    public partial class GetCloudLocationRequest
    {
        /// <summary>
        /// <see cref="gclv::CloudLocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::CloudLocationName CloudLocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::CloudLocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchCloudLocationsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CloudLocationName"/>-typed view over the <see cref="SourceCloudLocation"/> resource name
        /// property.
        /// </summary>
        public CloudLocationName SourceCloudLocationAsCloudLocationName
        {
            get => string.IsNullOrEmpty(SourceCloudLocation) ? null : CloudLocationName.Parse(SourceCloudLocation, allowUnparsed: true);
            set => SourceCloudLocation = value?.ToString() ?? "";
        }
    }
}
