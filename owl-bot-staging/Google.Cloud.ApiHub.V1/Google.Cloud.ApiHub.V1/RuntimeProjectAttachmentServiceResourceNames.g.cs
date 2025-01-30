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
    /// <summary>Resource name for the <c>RuntimeProjectAttachment</c> resource.</summary>
    public sealed partial class RuntimeProjectAttachmentName : gax::IResourceName, sys::IEquatable<RuntimeProjectAttachmentName>
    {
        /// <summary>The possible contents of <see cref="RuntimeProjectAttachmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}</c>.
            /// </summary>
            ProjectLocationRuntimeProjectAttachment = 1,
        }

        private static gax::PathTemplate s_projectLocationRuntimeProjectAttachment = new gax::PathTemplate("projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}");

        /// <summary>
        /// Creates a <see cref="RuntimeProjectAttachmentName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RuntimeProjectAttachmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RuntimeProjectAttachmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RuntimeProjectAttachmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RuntimeProjectAttachmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runtimeProjectAttachmentId">
        /// The <c>RuntimeProjectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="RuntimeProjectAttachmentName"/> constructed from the provided ids.
        /// </returns>
        public static RuntimeProjectAttachmentName FromProjectLocationRuntimeProjectAttachment(string projectId, string locationId, string runtimeProjectAttachmentId) =>
            new RuntimeProjectAttachmentName(ResourceNameType.ProjectLocationRuntimeProjectAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), runtimeProjectAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeProjectAttachmentId, nameof(runtimeProjectAttachmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuntimeProjectAttachmentName"/> with
        /// pattern <c>projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runtimeProjectAttachmentId">
        /// The <c>RuntimeProjectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="RuntimeProjectAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string runtimeProjectAttachmentId) =>
            FormatProjectLocationRuntimeProjectAttachment(projectId, locationId, runtimeProjectAttachmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RuntimeProjectAttachmentName"/> with
        /// pattern <c>projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runtimeProjectAttachmentId">
        /// The <c>RuntimeProjectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="RuntimeProjectAttachmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}</c>.
        /// </returns>
        public static string FormatProjectLocationRuntimeProjectAttachment(string projectId, string locationId, string runtimeProjectAttachmentId) =>
            s_projectLocationRuntimeProjectAttachment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeProjectAttachmentId, nameof(runtimeProjectAttachmentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RuntimeProjectAttachmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="runtimeProjectAttachmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="RuntimeProjectAttachmentName"/> if successful.</returns>
        public static RuntimeProjectAttachmentName Parse(string runtimeProjectAttachmentName) =>
            Parse(runtimeProjectAttachmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RuntimeProjectAttachmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="runtimeProjectAttachmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RuntimeProjectAttachmentName"/> if successful.</returns>
        public static RuntimeProjectAttachmentName Parse(string runtimeProjectAttachmentName, bool allowUnparsed) =>
            TryParse(runtimeProjectAttachmentName, allowUnparsed, out RuntimeProjectAttachmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RuntimeProjectAttachmentName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="runtimeProjectAttachmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuntimeProjectAttachmentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string runtimeProjectAttachmentName, out RuntimeProjectAttachmentName result) =>
            TryParse(runtimeProjectAttachmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RuntimeProjectAttachmentName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="runtimeProjectAttachmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RuntimeProjectAttachmentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string runtimeProjectAttachmentName, bool allowUnparsed, out RuntimeProjectAttachmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(runtimeProjectAttachmentName, nameof(runtimeProjectAttachmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRuntimeProjectAttachment.TryParseName(runtimeProjectAttachmentName, out resourceName))
            {
                result = FromProjectLocationRuntimeProjectAttachment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(runtimeProjectAttachmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RuntimeProjectAttachmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string runtimeProjectAttachmentId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RuntimeProjectAttachmentId = runtimeProjectAttachmentId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RuntimeProjectAttachmentName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/runtimeProjectAttachments/{runtime_project_attachment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="runtimeProjectAttachmentId">
        /// The <c>RuntimeProjectAttachment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public RuntimeProjectAttachmentName(string projectId, string locationId, string runtimeProjectAttachmentId) : this(ResourceNameType.ProjectLocationRuntimeProjectAttachment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), runtimeProjectAttachmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(runtimeProjectAttachmentId, nameof(runtimeProjectAttachmentId)))
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
        /// The <c>RuntimeProjectAttachment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string RuntimeProjectAttachmentId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRuntimeProjectAttachment: return s_projectLocationRuntimeProjectAttachment.Expand(ProjectId, LocationId, RuntimeProjectAttachmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RuntimeProjectAttachmentName);

        /// <inheritdoc/>
        public bool Equals(RuntimeProjectAttachmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RuntimeProjectAttachmentName a, RuntimeProjectAttachmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RuntimeProjectAttachmentName a, RuntimeProjectAttachmentName b) => !(a == b);
    }

    public partial class CreateRuntimeProjectAttachmentRequest
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

    public partial class GetRuntimeProjectAttachmentRequest
    {
        /// <summary>
        /// <see cref="gcav::RuntimeProjectAttachmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::RuntimeProjectAttachmentName RuntimeProjectAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RuntimeProjectAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListRuntimeProjectAttachmentsRequest
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

    public partial class DeleteRuntimeProjectAttachmentRequest
    {
        /// <summary>
        /// <see cref="gcav::RuntimeProjectAttachmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::RuntimeProjectAttachmentName RuntimeProjectAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RuntimeProjectAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LookupRuntimeProjectAttachmentRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::LocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RuntimeProjectAttachment
    {
        /// <summary>
        /// <see cref="gcav::RuntimeProjectAttachmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::RuntimeProjectAttachmentName RuntimeProjectAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RuntimeProjectAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="RuntimeProject"/> resource name property.
        /// </summary>
        public gagr::ProjectName RuntimeProjectAsProjectName
        {
            get => string.IsNullOrEmpty(RuntimeProject) ? null : gagr::ProjectName.Parse(RuntimeProject, allowUnparsed: true);
            set => RuntimeProject = value?.ToString() ?? "";
        }
    }
}
