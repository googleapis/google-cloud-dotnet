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
using gax = Google.Api.Gax;
using gccv = Google.Cloud.Chronicle.V1;
using sys = System;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Resource name for the <c>ReferenceList</c> resource.</summary>
    public sealed partial class ReferenceListName : gax::IResourceName, sys::IEquatable<ReferenceListName>
    {
        /// <summary>The possible contents of <see cref="ReferenceListName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}</c>.
            /// </summary>
            ProjectLocationInstanceReferenceList = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceReferenceList = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}");

        /// <summary>Creates a <see cref="ReferenceListName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReferenceListName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReferenceListName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReferenceListName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReferenceListName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="referenceListId">The <c>ReferenceList</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReferenceListName"/> constructed from the provided ids.</returns>
        public static ReferenceListName FromProjectLocationInstanceReferenceList(string projectId, string locationId, string instanceId, string referenceListId) =>
            new ReferenceListName(ResourceNameType.ProjectLocationInstanceReferenceList, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), referenceListId: gax::GaxPreconditions.CheckNotNullOrEmpty(referenceListId, nameof(referenceListId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReferenceListName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="referenceListId">The <c>ReferenceList</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReferenceListName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string referenceListId) =>
            FormatProjectLocationInstanceReferenceList(projectId, locationId, instanceId, referenceListId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReferenceListName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="referenceListId">The <c>ReferenceList</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReferenceListName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceReferenceList(string projectId, string locationId, string instanceId, string referenceListId) =>
            s_projectLocationInstanceReferenceList.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(referenceListId, nameof(referenceListId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReferenceListName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="referenceListName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReferenceListName"/> if successful.</returns>
        public static ReferenceListName Parse(string referenceListName) => Parse(referenceListName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReferenceListName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="referenceListName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReferenceListName"/> if successful.</returns>
        public static ReferenceListName Parse(string referenceListName, bool allowUnparsed) =>
            TryParse(referenceListName, allowUnparsed, out ReferenceListName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReferenceListName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="referenceListName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReferenceListName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string referenceListName, out ReferenceListName result) =>
            TryParse(referenceListName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReferenceListName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="referenceListName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReferenceListName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string referenceListName, bool allowUnparsed, out ReferenceListName result)
        {
            gax::GaxPreconditions.CheckNotNull(referenceListName, nameof(referenceListName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceReferenceList.TryParseName(referenceListName, out resourceName))
            {
                result = FromProjectLocationInstanceReferenceList(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(referenceListName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReferenceListName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string projectId = null, string referenceListId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
            ReferenceListId = referenceListId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReferenceListName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="referenceListId">The <c>ReferenceList</c> ID. Must not be <c>null</c> or empty.</param>
        public ReferenceListName(string projectId, string locationId, string instanceId, string referenceListId) : this(ResourceNameType.ProjectLocationInstanceReferenceList, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), referenceListId: gax::GaxPreconditions.CheckNotNullOrEmpty(referenceListId, nameof(referenceListId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ReferenceList</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReferenceListId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationInstanceReferenceList: return s_projectLocationInstanceReferenceList.Expand(ProjectId, LocationId, InstanceId, ReferenceListId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReferenceListName);

        /// <inheritdoc/>
        public bool Equals(ReferenceListName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReferenceListName a, ReferenceListName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReferenceListName a, ReferenceListName b) => !(a == b);
    }

    public partial class GetReferenceListRequest
    {
        /// <summary>
        /// <see cref="gccv::ReferenceListName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ReferenceListName ReferenceListName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ReferenceListName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReferenceListsRequest
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

    public partial class CreateReferenceListRequest
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

    public partial class ReferenceList
    {
        /// <summary>
        /// <see cref="gccv::ReferenceListName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ReferenceListName ReferenceListName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ReferenceListName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
