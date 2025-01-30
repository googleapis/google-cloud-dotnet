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
using gcav = Google.Cloud.ApiHub.V1;
using sys = System;

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Resource name for the <c>HostProjectRegistration</c> resource.</summary>
    public sealed partial class HostProjectRegistrationName : gax::IResourceName, sys::IEquatable<HostProjectRegistrationName>
    {
        /// <summary>The possible contents of <see cref="HostProjectRegistrationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}</c>.
            /// </summary>
            ProjectLocationHostProjectRegistration = 1,
        }

        private static gax::PathTemplate s_projectLocationHostProjectRegistration = new gax::PathTemplate("projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}");

        /// <summary>Creates a <see cref="HostProjectRegistrationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HostProjectRegistrationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HostProjectRegistrationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HostProjectRegistrationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HostProjectRegistrationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hostProjectRegistrationId">
        /// The <c>HostProjectRegistration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="HostProjectRegistrationName"/> constructed from the provided ids.
        /// </returns>
        public static HostProjectRegistrationName FromProjectLocationHostProjectRegistration(string projectId, string locationId, string hostProjectRegistrationId) =>
            new HostProjectRegistrationName(ResourceNameType.ProjectLocationHostProjectRegistration, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), hostProjectRegistrationId: gax::GaxPreconditions.CheckNotNullOrEmpty(hostProjectRegistrationId, nameof(hostProjectRegistrationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HostProjectRegistrationName"/> with
        /// pattern <c>projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hostProjectRegistrationId">
        /// The <c>HostProjectRegistration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="HostProjectRegistrationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string hostProjectRegistrationId) =>
            FormatProjectLocationHostProjectRegistration(projectId, locationId, hostProjectRegistrationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HostProjectRegistrationName"/> with
        /// pattern <c>projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hostProjectRegistrationId">
        /// The <c>HostProjectRegistration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="HostProjectRegistrationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}</c>.
        /// </returns>
        public static string FormatProjectLocationHostProjectRegistration(string projectId, string locationId, string hostProjectRegistrationId) =>
            s_projectLocationHostProjectRegistration.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(hostProjectRegistrationId, nameof(hostProjectRegistrationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HostProjectRegistrationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hostProjectRegistrationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HostProjectRegistrationName"/> if successful.</returns>
        public static HostProjectRegistrationName Parse(string hostProjectRegistrationName) =>
            Parse(hostProjectRegistrationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HostProjectRegistrationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hostProjectRegistrationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HostProjectRegistrationName"/> if successful.</returns>
        public static HostProjectRegistrationName Parse(string hostProjectRegistrationName, bool allowUnparsed) =>
            TryParse(hostProjectRegistrationName, allowUnparsed, out HostProjectRegistrationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HostProjectRegistrationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="hostProjectRegistrationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HostProjectRegistrationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hostProjectRegistrationName, out HostProjectRegistrationName result) =>
            TryParse(hostProjectRegistrationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HostProjectRegistrationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hostProjectRegistrationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HostProjectRegistrationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hostProjectRegistrationName, bool allowUnparsed, out HostProjectRegistrationName result)
        {
            gax::GaxPreconditions.CheckNotNull(hostProjectRegistrationName, nameof(hostProjectRegistrationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationHostProjectRegistration.TryParseName(hostProjectRegistrationName, out resourceName))
            {
                result = FromProjectLocationHostProjectRegistration(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(hostProjectRegistrationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HostProjectRegistrationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string hostProjectRegistrationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            HostProjectRegistrationId = hostProjectRegistrationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HostProjectRegistrationName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/hostProjectRegistrations/{host_project_registration}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hostProjectRegistrationId">
        /// The <c>HostProjectRegistration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public HostProjectRegistrationName(string projectId, string locationId, string hostProjectRegistrationId) : this(ResourceNameType.ProjectLocationHostProjectRegistration, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), hostProjectRegistrationId: gax::GaxPreconditions.CheckNotNullOrEmpty(hostProjectRegistrationId, nameof(hostProjectRegistrationId)))
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
        /// The <c>HostProjectRegistration</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string HostProjectRegistrationId { get; }

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
                case ResourceNameType.ProjectLocationHostProjectRegistration: return s_projectLocationHostProjectRegistration.Expand(ProjectId, LocationId, HostProjectRegistrationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HostProjectRegistrationName);

        /// <inheritdoc/>
        public bool Equals(HostProjectRegistrationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(HostProjectRegistrationName a, HostProjectRegistrationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(HostProjectRegistrationName a, HostProjectRegistrationName b) => !(a == b);
    }

    public partial class CreateHostProjectRegistrationRequest
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

    public partial class GetHostProjectRegistrationRequest
    {
        /// <summary>
        /// <see cref="gcav::HostProjectRegistrationName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::HostProjectRegistrationName HostProjectRegistrationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::HostProjectRegistrationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListHostProjectRegistrationsRequest
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

    public partial class HostProjectRegistration
    {
        /// <summary>
        /// <see cref="gcav::HostProjectRegistrationName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::HostProjectRegistrationName HostProjectRegistrationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::HostProjectRegistrationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="GcpProject"/> resource name property.
        /// </summary>
        public gagr::ProjectName GcpProjectAsProjectName
        {
            get => string.IsNullOrEmpty(GcpProject) ? null : gagr::ProjectName.Parse(GcpProject, allowUnparsed: true);
            set => GcpProject = value?.ToString() ?? "";
        }
    }
}
