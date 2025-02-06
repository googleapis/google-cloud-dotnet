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
using gcbv = Google.Cloud.BackupDR.V1;
using sys = System;

namespace Google.Cloud.BackupDR.V1
{
    /// <summary>Resource name for the <c>ManagementServer</c> resource.</summary>
    public sealed partial class ManagementServerName : gax::IResourceName, sys::IEquatable<ManagementServerName>
    {
        /// <summary>The possible contents of <see cref="ManagementServerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/managementServers/{managementserver}</c>.
            /// </summary>
            ProjectLocationManagementserver = 1,
        }

        private static gax::PathTemplate s_projectLocationManagementserver = new gax::PathTemplate("projects/{project}/locations/{location}/managementServers/{managementserver}");

        /// <summary>Creates a <see cref="ManagementServerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ManagementServerName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ManagementServerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ManagementServerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ManagementServerName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/managementServers/{managementserver}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managementserverId">The <c>Managementserver</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ManagementServerName"/> constructed from the provided ids.</returns>
        public static ManagementServerName FromProjectLocationManagementserver(string projectId, string locationId, string managementserverId) =>
            new ManagementServerName(ResourceNameType.ProjectLocationManagementserver, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), managementserverId: gax::GaxPreconditions.CheckNotNullOrEmpty(managementserverId, nameof(managementserverId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ManagementServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/managementServers/{managementserver}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managementserverId">The <c>Managementserver</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ManagementServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/managementServers/{managementserver}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string managementserverId) =>
            FormatProjectLocationManagementserver(projectId, locationId, managementserverId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ManagementServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/managementServers/{managementserver}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managementserverId">The <c>Managementserver</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ManagementServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/managementServers/{managementserver}</c>.
        /// </returns>
        public static string FormatProjectLocationManagementserver(string projectId, string locationId, string managementserverId) =>
            s_projectLocationManagementserver.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(managementserverId, nameof(managementserverId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ManagementServerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/managementServers/{managementserver}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="managementServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ManagementServerName"/> if successful.</returns>
        public static ManagementServerName Parse(string managementServerName) => Parse(managementServerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ManagementServerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/managementServers/{managementserver}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="managementServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ManagementServerName"/> if successful.</returns>
        public static ManagementServerName Parse(string managementServerName, bool allowUnparsed) =>
            TryParse(managementServerName, allowUnparsed, out ManagementServerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ManagementServerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/managementServers/{managementserver}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="managementServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ManagementServerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string managementServerName, out ManagementServerName result) =>
            TryParse(managementServerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ManagementServerName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/managementServers/{managementserver}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="managementServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ManagementServerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string managementServerName, bool allowUnparsed, out ManagementServerName result)
        {
            gax::GaxPreconditions.CheckNotNull(managementServerName, nameof(managementServerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationManagementserver.TryParseName(managementServerName, out resourceName))
            {
                result = FromProjectLocationManagementserver(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(managementServerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ManagementServerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string managementserverId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ManagementserverId = managementserverId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ManagementServerName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/managementServers/{managementserver}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="managementserverId">The <c>Managementserver</c> ID. Must not be <c>null</c> or empty.</param>
        public ManagementServerName(string projectId, string locationId, string managementserverId) : this(ResourceNameType.ProjectLocationManagementserver, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), managementserverId: gax::GaxPreconditions.CheckNotNullOrEmpty(managementserverId, nameof(managementserverId)))
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
        /// The <c>Managementserver</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ManagementserverId { get; }

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
                case ResourceNameType.ProjectLocationManagementserver: return s_projectLocationManagementserver.Expand(ProjectId, LocationId, ManagementserverId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ManagementServerName);

        /// <inheritdoc/>
        public bool Equals(ManagementServerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ManagementServerName a, ManagementServerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ManagementServerName a, ManagementServerName b) => !(a == b);
    }

    public partial class ManagementServer
    {
        /// <summary>
        /// <see cref="gcbv::ManagementServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::ManagementServerName ManagementServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::ManagementServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListManagementServersRequest
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

    public partial class GetManagementServerRequest
    {
        /// <summary>
        /// <see cref="gcbv::ManagementServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::ManagementServerName ManagementServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::ManagementServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateManagementServerRequest
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

    public partial class DeleteManagementServerRequest
    {
        /// <summary>
        /// <see cref="gcbv::ManagementServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::ManagementServerName ManagementServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::ManagementServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
