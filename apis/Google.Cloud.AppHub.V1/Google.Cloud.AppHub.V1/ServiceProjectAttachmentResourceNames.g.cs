// Copyright 2024 Google LLC
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
using gcav = Google.Cloud.AppHub.V1;
using sys = System;

namespace Google.Cloud.AppHub.V1
{
    /// <summary>Resource name for the <c>ServiceProjectAttachment</c> resource.</summary>
    public sealed partial class ServiceProjectAttachmentName : gax::IResourceName, sys::IEquatable<ServiceProjectAttachmentName>
    {
        /// <summary>The possible contents of <see cref="ServiceProjectAttachmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}</c>.
            /// </summary>
            ProjectLocationServiceProjectAttachment = 1,
        }

        private static gax::PathTemplate s_projectLocationServiceProjectAttachment = new gax::PathTemplate("projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}");

        /// <summary>
        /// Creates a <see cref="ServiceProjectAttachmentName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceProjectAttachmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceProjectAttachmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceProjectAttachmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceProjectAttachmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProjectAttachmentId">
        /// The <c>ServiceProjectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ServiceProjectAttachmentName"/> constructed from the provided ids.
        /// </returns>
        public static ServiceProjectAttachmentName FromProjectLocationServiceProjectAttachment(string projectId, string locationId, string serviceProjectAttachmentId) =>
            new ServiceProjectAttachmentName(ResourceNameType.ProjectLocationServiceProjectAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceProjectAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProjectAttachmentId, nameof(serviceProjectAttachmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceProjectAttachmentName"/> with
        /// pattern <c>projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProjectAttachmentId">
        /// The <c>ServiceProjectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ServiceProjectAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceProjectAttachmentId) =>
            FormatProjectLocationServiceProjectAttachment(projectId, locationId, serviceProjectAttachmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceProjectAttachmentName"/> with
        /// pattern <c>projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProjectAttachmentId">
        /// The <c>ServiceProjectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ServiceProjectAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}</c>.
        /// </returns>
        public static string FormatProjectLocationServiceProjectAttachment(string projectId, string locationId, string serviceProjectAttachmentId) =>
            s_projectLocationServiceProjectAttachment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProjectAttachmentId, nameof(serviceProjectAttachmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceProjectAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceProjectAttachmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ServiceProjectAttachmentName"/> if successful.</returns>
        public static ServiceProjectAttachmentName Parse(string serviceProjectAttachmentName) =>
            Parse(serviceProjectAttachmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceProjectAttachmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceProjectAttachmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceProjectAttachmentName"/> if successful.</returns>
        public static ServiceProjectAttachmentName Parse(string serviceProjectAttachmentName, bool allowUnparsed) =>
            TryParse(serviceProjectAttachmentName, allowUnparsed, out ServiceProjectAttachmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceProjectAttachmentName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceProjectAttachmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceProjectAttachmentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceProjectAttachmentName, out ServiceProjectAttachmentName result) =>
            TryParse(serviceProjectAttachmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceProjectAttachmentName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceProjectAttachmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceProjectAttachmentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceProjectAttachmentName, bool allowUnparsed, out ServiceProjectAttachmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceProjectAttachmentName, nameof(serviceProjectAttachmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceProjectAttachment.TryParseName(serviceProjectAttachmentName, out resourceName))
            {
                result = FromProjectLocationServiceProjectAttachment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceProjectAttachmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceProjectAttachmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serviceProjectAttachmentId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServiceProjectAttachmentId = serviceProjectAttachmentId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceProjectAttachmentName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/serviceProjectAttachments/{service_project_attachment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceProjectAttachmentId">
        /// The <c>ServiceProjectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ServiceProjectAttachmentName(string projectId, string locationId, string serviceProjectAttachmentId) : this(ResourceNameType.ProjectLocationServiceProjectAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceProjectAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceProjectAttachmentId, nameof(serviceProjectAttachmentId)))
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
        /// The <c>ServiceProjectAttachment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ServiceProjectAttachmentId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServiceProjectAttachment: return s_projectLocationServiceProjectAttachment.Expand(ProjectId, LocationId, ServiceProjectAttachmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceProjectAttachmentName);

        /// <inheritdoc/>
        public bool Equals(ServiceProjectAttachmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceProjectAttachmentName a, ServiceProjectAttachmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceProjectAttachmentName a, ServiceProjectAttachmentName b) => !(a == b);
    }

    public partial class ServiceProjectAttachment
    {
        /// <summary>
        /// <see cref="gcav::ServiceProjectAttachmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::ServiceProjectAttachmentName ServiceProjectAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ServiceProjectAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="ServiceProject"/> resource name property.
        /// </summary>
        public gagr::ProjectName ServiceProjectAsProjectName
        {
            get => string.IsNullOrEmpty(ServiceProject) ? null : gagr::ProjectName.Parse(ServiceProject, allowUnparsed: true);
            set => ServiceProject = value?.ToString() ?? "";
        }
    }
}
