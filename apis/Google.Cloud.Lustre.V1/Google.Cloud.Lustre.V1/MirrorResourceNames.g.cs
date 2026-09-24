// Copyright 2026 Google LLC
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
using gclv = Google.Cloud.Lustre.V1;
using sys = System;

namespace Google.Cloud.Lustre.V1
{
    /// <summary>Resource name for the <c>Mirror</c> resource.</summary>
    public sealed partial class MirrorName : gax::IResourceName, sys::IEquatable<MirrorName>
    {
        /// <summary>The possible contents of <see cref="MirrorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}</c>.
            /// </summary>
            ProjectLocationInstanceMirror = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceMirror = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}");

        /// <summary>Creates a <see cref="MirrorName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MirrorName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MirrorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MirrorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MirrorName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirrorId">The <c>Mirror</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MirrorName"/> constructed from the provided ids.</returns>
        public static MirrorName FromProjectLocationInstanceMirror(string projectId, string locationId, string instanceId, string mirrorId) =>
            new MirrorName(ResourceNameType.ProjectLocationInstanceMirror, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), mirrorId: gax::GaxPreconditions.CheckNotNullOrEmpty(mirrorId, nameof(mirrorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MirrorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirrorId">The <c>Mirror</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MirrorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string mirrorId) =>
            FormatProjectLocationInstanceMirror(projectId, locationId, instanceId, mirrorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MirrorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirrorId">The <c>Mirror</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MirrorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceMirror(string projectId, string locationId, string instanceId, string mirrorId) =>
            s_projectLocationInstanceMirror.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mirrorId, nameof(mirrorId)));

        /// <summary>Parses the given resource name string into a new <see cref="MirrorName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mirrorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MirrorName"/> if successful.</returns>
        public static MirrorName Parse(string mirrorName) => Parse(mirrorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MirrorName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mirrorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MirrorName"/> if successful.</returns>
        public static MirrorName Parse(string mirrorName, bool allowUnparsed) =>
            TryParse(mirrorName, allowUnparsed, out MirrorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MirrorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mirrorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MirrorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mirrorName, out MirrorName result) => TryParse(mirrorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MirrorName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mirrorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MirrorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mirrorName, bool allowUnparsed, out MirrorName result)
        {
            gax::GaxPreconditions.CheckNotNull(mirrorName, nameof(mirrorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceMirror.TryParseName(mirrorName, out resourceName))
            {
                result = FromProjectLocationInstanceMirror(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mirrorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MirrorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string mirrorId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            MirrorId = mirrorId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MirrorName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/mirrors/{mirror}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mirrorId">The <c>Mirror</c> ID. Must not be <c>null</c> or empty.</param>
        public MirrorName(string projectId, string locationId, string instanceId, string mirrorId) : this(ResourceNameType.ProjectLocationInstanceMirror, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), mirrorId: gax::GaxPreconditions.CheckNotNullOrEmpty(mirrorId, nameof(mirrorId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Mirror</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MirrorId { get; }

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
                case ResourceNameType.ProjectLocationInstanceMirror: return s_projectLocationInstanceMirror.Expand(ProjectId, LocationId, InstanceId, MirrorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MirrorName);

        /// <inheritdoc/>
        public bool Equals(MirrorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MirrorName a, MirrorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MirrorName a, MirrorName b) => !(a == b);
    }

    public partial class Mirror
    {
        /// <summary>
        /// <see cref="gclv::MirrorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::MirrorName MirrorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::MirrorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMirrorRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMirrorRequest
    {
        /// <summary>
        /// <see cref="gclv::MirrorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::MirrorName MirrorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::MirrorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetMirrorRequest
    {
        /// <summary>
        /// <see cref="gclv::MirrorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::MirrorName MirrorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::MirrorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMirrorsRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
