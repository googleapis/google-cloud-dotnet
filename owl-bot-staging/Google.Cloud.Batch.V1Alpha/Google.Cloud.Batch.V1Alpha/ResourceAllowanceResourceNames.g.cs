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
using gcbv = Google.Cloud.Batch.V1Alpha;
using sys = System;

namespace Google.Cloud.Batch.V1Alpha
{
    /// <summary>Resource name for the <c>ResourceAllowance</c> resource.</summary>
    public sealed partial class ResourceAllowanceName : gax::IResourceName, sys::IEquatable<ResourceAllowanceName>
    {
        /// <summary>The possible contents of <see cref="ResourceAllowanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}</c>.
            /// </summary>
            ProjectLocationResourceAllowance = 1,
        }

        private static gax::PathTemplate s_projectLocationResourceAllowance = new gax::PathTemplate("projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}");

        /// <summary>Creates a <see cref="ResourceAllowanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ResourceAllowanceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ResourceAllowanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ResourceAllowanceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ResourceAllowanceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceAllowanceId">The <c>ResourceAllowance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ResourceAllowanceName"/> constructed from the provided ids.</returns>
        public static ResourceAllowanceName FromProjectLocationResourceAllowance(string projectId, string locationId, string resourceAllowanceId) =>
            new ResourceAllowanceName(ResourceNameType.ProjectLocationResourceAllowance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceAllowanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceAllowanceId, nameof(resourceAllowanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceAllowanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceAllowanceId">The <c>ResourceAllowance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ResourceAllowanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string resourceAllowanceId) =>
            FormatProjectLocationResourceAllowance(projectId, locationId, resourceAllowanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ResourceAllowanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceAllowanceId">The <c>ResourceAllowance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ResourceAllowanceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}</c>.
        /// </returns>
        public static string FormatProjectLocationResourceAllowance(string projectId, string locationId, string resourceAllowanceId) =>
            s_projectLocationResourceAllowance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceAllowanceId, nameof(resourceAllowanceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ResourceAllowanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="resourceAllowanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ResourceAllowanceName"/> if successful.</returns>
        public static ResourceAllowanceName Parse(string resourceAllowanceName) => Parse(resourceAllowanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ResourceAllowanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceAllowanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ResourceAllowanceName"/> if successful.</returns>
        public static ResourceAllowanceName Parse(string resourceAllowanceName, bool allowUnparsed) =>
            TryParse(resourceAllowanceName, allowUnparsed, out ResourceAllowanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceAllowanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="resourceAllowanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceAllowanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceAllowanceName, out ResourceAllowanceName result) =>
            TryParse(resourceAllowanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ResourceAllowanceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="resourceAllowanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceAllowanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resourceAllowanceName, bool allowUnparsed, out ResourceAllowanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(resourceAllowanceName, nameof(resourceAllowanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationResourceAllowance.TryParseName(resourceAllowanceName, out resourceName))
            {
                result = FromProjectLocationResourceAllowance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(resourceAllowanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ResourceAllowanceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string resourceAllowanceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ResourceAllowanceId = resourceAllowanceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ResourceAllowanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/resourceAllowances/{resource_allowance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceAllowanceId">The <c>ResourceAllowance</c> ID. Must not be <c>null</c> or empty.</param>
        public ResourceAllowanceName(string projectId, string locationId, string resourceAllowanceId) : this(ResourceNameType.ProjectLocationResourceAllowance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), resourceAllowanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceAllowanceId, nameof(resourceAllowanceId)))
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
        /// The <c>ResourceAllowance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ResourceAllowanceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationResourceAllowance: return s_projectLocationResourceAllowance.Expand(ProjectId, LocationId, ResourceAllowanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ResourceAllowanceName);

        /// <inheritdoc/>
        public bool Equals(ResourceAllowanceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ResourceAllowanceName a, ResourceAllowanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ResourceAllowanceName a, ResourceAllowanceName b) => !(a == b);
    }

    public partial class ResourceAllowance
    {
        /// <summary>
        /// <see cref="gcbv::ResourceAllowanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::ResourceAllowanceName ResourceAllowanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::ResourceAllowanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
