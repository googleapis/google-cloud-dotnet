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
using gax = Google.Api.Gax;
using gciv = Google.Cloud.Iap.V1;
using sys = System;

namespace Google.Cloud.Iap.V1
{
    /// <summary>Resource name for the <c>TunnelDestGroup</c> resource.</summary>
    public sealed partial class TunnelDestGroupName : gax::IResourceName, sys::IEquatable<TunnelDestGroupName>
    {
        /// <summary>The possible contents of <see cref="TunnelDestGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}</c>.
            /// </summary>
            ProjectLocationDestGroup = 1,
        }

        private static gax::PathTemplate s_projectLocationDestGroup = new gax::PathTemplate("projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}");

        /// <summary>Creates a <see cref="TunnelDestGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TunnelDestGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TunnelDestGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TunnelDestGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TunnelDestGroupName"/> with the pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="destGroupId">The <c>DestGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TunnelDestGroupName"/> constructed from the provided ids.</returns>
        public static TunnelDestGroupName FromProjectLocationDestGroup(string projectId, string locationId, string destGroupId) =>
            new TunnelDestGroupName(ResourceNameType.ProjectLocationDestGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), destGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(destGroupId, nameof(destGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TunnelDestGroupName"/> with pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="destGroupId">The <c>DestGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TunnelDestGroupName"/> with pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string destGroupId) =>
            FormatProjectLocationDestGroup(projectId, locationId, destGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TunnelDestGroupName"/> with pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="destGroupId">The <c>DestGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TunnelDestGroupName"/> with pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}</c>.
        /// </returns>
        public static string FormatProjectLocationDestGroup(string projectId, string locationId, string destGroupId) =>
            s_projectLocationDestGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(destGroupId, nameof(destGroupId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TunnelDestGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tunnelDestGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TunnelDestGroupName"/> if successful.</returns>
        public static TunnelDestGroupName Parse(string tunnelDestGroupName) => Parse(tunnelDestGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TunnelDestGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tunnelDestGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TunnelDestGroupName"/> if successful.</returns>
        public static TunnelDestGroupName Parse(string tunnelDestGroupName, bool allowUnparsed) =>
            TryParse(tunnelDestGroupName, allowUnparsed, out TunnelDestGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TunnelDestGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tunnelDestGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TunnelDestGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tunnelDestGroupName, out TunnelDestGroupName result) =>
            TryParse(tunnelDestGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TunnelDestGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tunnelDestGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TunnelDestGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tunnelDestGroupName, bool allowUnparsed, out TunnelDestGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(tunnelDestGroupName, nameof(tunnelDestGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDestGroup.TryParseName(tunnelDestGroupName, out resourceName))
            {
                result = FromProjectLocationDestGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tunnelDestGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TunnelDestGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string destGroupId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DestGroupId = destGroupId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TunnelDestGroupName"/> class from the component parts of pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}/destGroups/{dest_group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="destGroupId">The <c>DestGroup</c> ID. Must not be <c>null</c> or empty.</param>
        public TunnelDestGroupName(string projectId, string locationId, string destGroupId) : this(ResourceNameType.ProjectLocationDestGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), destGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(destGroupId, nameof(destGroupId)))
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
        /// The <c>DestGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DestGroupId { get; }

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
                case ResourceNameType.ProjectLocationDestGroup: return s_projectLocationDestGroup.Expand(ProjectId, LocationId, DestGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TunnelDestGroupName);

        /// <inheritdoc/>
        public bool Equals(TunnelDestGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TunnelDestGroupName a, TunnelDestGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TunnelDestGroupName a, TunnelDestGroupName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>TunnelLocation</c> resource.</summary>
    public sealed partial class TunnelLocationName : gax::IResourceName, sys::IEquatable<TunnelLocationName>
    {
        /// <summary>The possible contents of <see cref="TunnelLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/iap_tunnel/locations/{location}</c>.
            /// </summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/iap_tunnel/locations/{location}");

        /// <summary>Creates a <see cref="TunnelLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TunnelLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TunnelLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TunnelLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TunnelLocationName"/> with the pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TunnelLocationName"/> constructed from the provided ids.</returns>
        public static TunnelLocationName FromProjectLocation(string projectId, string locationId) =>
            new TunnelLocationName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TunnelLocationName"/> with pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TunnelLocationName"/> with pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TunnelLocationName"/> with pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TunnelLocationName"/> with pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TunnelLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/iap_tunnel/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tunnelLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TunnelLocationName"/> if successful.</returns>
        public static TunnelLocationName Parse(string tunnelLocationName) => Parse(tunnelLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TunnelLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/iap_tunnel/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tunnelLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TunnelLocationName"/> if successful.</returns>
        public static TunnelLocationName Parse(string tunnelLocationName, bool allowUnparsed) =>
            TryParse(tunnelLocationName, allowUnparsed, out TunnelLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TunnelLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/iap_tunnel/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="tunnelLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TunnelLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tunnelLocationName, out TunnelLocationName result) =>
            TryParse(tunnelLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TunnelLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/iap_tunnel/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tunnelLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TunnelLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tunnelLocationName, bool allowUnparsed, out TunnelLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(tunnelLocationName, nameof(tunnelLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(tunnelLocationName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tunnelLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TunnelLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TunnelLocationName"/> class from the component parts of pattern
        /// <c>projects/{project}/iap_tunnel/locations/{location}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public TunnelLocationName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TunnelLocationName);

        /// <inheritdoc/>
        public bool Equals(TunnelLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TunnelLocationName a, TunnelLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TunnelLocationName a, TunnelLocationName b) => !(a == b);
    }

    public partial class ListTunnelDestGroupsRequest
    {
        /// <summary>
        /// <see cref="TunnelLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TunnelLocationName ParentAsTunnelLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TunnelLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateTunnelDestGroupRequest
    {
        /// <summary>
        /// <see cref="TunnelLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TunnelLocationName ParentAsTunnelLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TunnelLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTunnelDestGroupRequest
    {
        /// <summary>
        /// <see cref="gciv::TunnelDestGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::TunnelDestGroupName TunnelDestGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::TunnelDestGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTunnelDestGroupRequest
    {
        /// <summary>
        /// <see cref="gciv::TunnelDestGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::TunnelDestGroupName TunnelDestGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::TunnelDestGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TunnelDestGroup
    {
        /// <summary>
        /// <see cref="gciv::TunnelDestGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gciv::TunnelDestGroupName TunnelDestGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::TunnelDestGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
