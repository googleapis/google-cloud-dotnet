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
using gcdv = Google.Cloud.Dataplex.V1;
using sys = System;

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Resource name for the <c>Lake</c> resource.</summary>
    public sealed partial class LakeName : gax::IResourceName, sys::IEquatable<LakeName>
    {
        /// <summary>The possible contents of <see cref="LakeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/lakes/{lake}</c>.
            /// </summary>
            ProjectLocationLake = 1,
        }

        private static gax::PathTemplate s_projectLocationLake = new gax::PathTemplate("projects/{project}/locations/{location}/lakes/{lake}");

        /// <summary>Creates a <see cref="LakeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LakeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LakeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LakeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LakeName"/> with the pattern <c>projects/{project}/locations/{location}/lakes/{lake}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LakeName"/> constructed from the provided ids.</returns>
        public static LakeName FromProjectLocationLake(string projectId, string locationId, string lakeId) =>
            new LakeName(ResourceNameType.ProjectLocationLake, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LakeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LakeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string lakeId) =>
            FormatProjectLocationLake(projectId, locationId, lakeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LakeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LakeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}</c>.
        /// </returns>
        public static string FormatProjectLocationLake(string projectId, string locationId, string lakeId) =>
            s_projectLocationLake.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)));

        /// <summary>Parses the given resource name string into a new <see cref="LakeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/lakes/{lake}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="lakeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LakeName"/> if successful.</returns>
        public static LakeName Parse(string lakeName) => Parse(lakeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LakeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/lakes/{lake}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lakeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LakeName"/> if successful.</returns>
        public static LakeName Parse(string lakeName, bool allowUnparsed) =>
            TryParse(lakeName, allowUnparsed, out LakeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="LakeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/lakes/{lake}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="lakeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LakeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lakeName, out LakeName result) => TryParse(lakeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LakeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/lakes/{lake}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lakeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LakeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lakeName, bool allowUnparsed, out LakeName result)
        {
            gax::GaxPreconditions.CheckNotNull(lakeName, nameof(lakeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLake.TryParseName(lakeName, out resourceName))
            {
                result = FromProjectLocationLake(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(lakeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LakeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string lakeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LakeId = lakeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LakeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        public LakeName(string projectId, string locationId, string lakeId) : this(ResourceNameType.ProjectLocationLake, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)))
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
        /// The <c>Lake</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LakeId { get; }

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
                case ResourceNameType.ProjectLocationLake: return s_projectLocationLake.Expand(ProjectId, LocationId, LakeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LakeName);

        /// <inheritdoc/>
        public bool Equals(LakeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LakeName a, LakeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LakeName a, LakeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Zone</c> resource.</summary>
    public sealed partial class ZoneName : gax::IResourceName, sys::IEquatable<ZoneName>
    {
        /// <summary>The possible contents of <see cref="ZoneName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}</c>.
            /// </summary>
            ProjectLocationLakeZone = 1,
        }

        private static gax::PathTemplate s_projectLocationLakeZone = new gax::PathTemplate("projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}");

        /// <summary>Creates a <see cref="ZoneName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ZoneName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ZoneName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ZoneName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ZoneName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ZoneName"/> constructed from the provided ids.</returns>
        public static ZoneName FromProjectLocationLakeZone(string projectId, string locationId, string lakeId, string zoneId) =>
            new ZoneName(ResourceNameType.ProjectLocationLakeZone, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string lakeId, string zoneId) =>
            FormatProjectLocationLakeZone(projectId, locationId, lakeId, zoneId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ZoneName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}</c>.
        /// </returns>
        public static string FormatProjectLocationLakeZone(string projectId, string locationId, string lakeId, string zoneId) =>
            s_projectLocationLakeZone.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)));

        /// <summary>Parses the given resource name string into a new <see cref="ZoneName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ZoneName"/> if successful.</returns>
        public static ZoneName Parse(string zoneName) => Parse(zoneName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ZoneName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ZoneName"/> if successful.</returns>
        public static ZoneName Parse(string zoneName, bool allowUnparsed) =>
            TryParse(zoneName, allowUnparsed, out ZoneName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="ZoneName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ZoneName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string zoneName, out ZoneName result) => TryParse(zoneName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ZoneName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="zoneName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ZoneName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string zoneName, bool allowUnparsed, out ZoneName result)
        {
            gax::GaxPreconditions.CheckNotNull(zoneName, nameof(zoneName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLakeZone.TryParseName(zoneName, out resourceName))
            {
                result = FromProjectLocationLakeZone(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(zoneName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ZoneName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string lakeId = null, string locationId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LakeId = lakeId;
            LocationId = locationId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ZoneName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        public ZoneName(string projectId, string locationId, string lakeId, string zoneId) : this(ResourceNameType.ProjectLocationLakeZone, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)))
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
        /// The <c>Lake</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LakeId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationLakeZone: return s_projectLocationLakeZone.Expand(ProjectId, LocationId, LakeId, ZoneId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ZoneName);

        /// <inheritdoc/>
        public bool Equals(ZoneName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ZoneName a, ZoneName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ZoneName a, ZoneName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Action</c> resource.</summary>
    public sealed partial class ActionName : gax::IResourceName, sys::IEquatable<ActionName>
    {
        /// <summary>The possible contents of <see cref="ActionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/lakes/{lake}/actions/{action}</c>
            /// .
            /// </summary>
            ProjectLocationLakeAction = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/actions/{action}</c>.
            /// </summary>
            ProjectLocationLakeZoneAction = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}/actions/{action}</c>
            /// .
            /// </summary>
            ProjectLocationLakeZoneAssetAction = 3,
        }

        private static gax::PathTemplate s_projectLocationLakeAction = new gax::PathTemplate("projects/{project}/locations/{location}/lakes/{lake}/actions/{action}");

        private static gax::PathTemplate s_projectLocationLakeZoneAction = new gax::PathTemplate("projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/actions/{action}");

        private static gax::PathTemplate s_projectLocationLakeZoneAssetAction = new gax::PathTemplate("projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}/actions/{action}");

        /// <summary>Creates a <see cref="ActionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ActionName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ActionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ActionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ActionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/actions/{action}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="actionId">The <c>Action</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ActionName"/> constructed from the provided ids.</returns>
        public static ActionName FromProjectLocationLakeAction(string projectId, string locationId, string lakeId, string actionId) =>
            new ActionName(ResourceNameType.ProjectLocationLakeAction, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), actionId: gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)));

        /// <summary>
        /// Creates a <see cref="ActionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/actions/{action}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="actionId">The <c>Action</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ActionName"/> constructed from the provided ids.</returns>
        public static ActionName FromProjectLocationLakeZoneAction(string projectId, string locationId, string lakeId, string zoneId, string actionId) =>
            new ActionName(ResourceNameType.ProjectLocationLakeZoneAction, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), actionId: gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)));

        /// <summary>
        /// Creates a <see cref="ActionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}/actions/{action}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="actionId">The <c>Action</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ActionName"/> constructed from the provided ids.</returns>
        public static ActionName FromProjectLocationLakeZoneAssetAction(string projectId, string locationId, string lakeId, string zoneId, string assetId, string actionId) =>
            new ActionName(ResourceNameType.ProjectLocationLakeZoneAssetAction, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), actionId: gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ActionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/actions/{action}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="actionId">The <c>Action</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ActionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/actions/{action}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string lakeId, string actionId) =>
            FormatProjectLocationLakeAction(projectId, locationId, lakeId, actionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ActionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/actions/{action}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="actionId">The <c>Action</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ActionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/actions/{action}</c>.
        /// </returns>
        public static string FormatProjectLocationLakeAction(string projectId, string locationId, string lakeId, string actionId) =>
            s_projectLocationLakeAction.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ActionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/actions/{action}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="actionId">The <c>Action</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ActionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/actions/{action}</c>.
        /// </returns>
        public static string FormatProjectLocationLakeZoneAction(string projectId, string locationId, string lakeId, string zoneId, string actionId) =>
            s_projectLocationLakeZoneAction.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ActionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}/actions/{action}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="actionId">The <c>Action</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ActionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}/actions/{action}</c>.
        /// </returns>
        public static string FormatProjectLocationLakeZoneAssetAction(string projectId, string locationId, string lakeId, string zoneId, string assetId, string actionId) =>
            s_projectLocationLakeZoneAssetAction.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ActionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/actions/{action}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/actions/{action}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}/actions/{action}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="actionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ActionName"/> if successful.</returns>
        public static ActionName Parse(string actionName) => Parse(actionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ActionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/actions/{action}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/actions/{action}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}/actions/{action}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="actionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ActionName"/> if successful.</returns>
        public static ActionName Parse(string actionName, bool allowUnparsed) =>
            TryParse(actionName, allowUnparsed, out ActionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ActionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/actions/{action}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/actions/{action}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}/actions/{action}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="actionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ActionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string actionName, out ActionName result) => TryParse(actionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ActionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/lakes/{lake}/actions/{action}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/actions/{action}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}/actions/{action}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="actionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ActionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string actionName, bool allowUnparsed, out ActionName result)
        {
            gax::GaxPreconditions.CheckNotNull(actionName, nameof(actionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLakeAction.TryParseName(actionName, out resourceName))
            {
                result = FromProjectLocationLakeAction(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationLakeZoneAction.TryParseName(actionName, out resourceName))
            {
                result = FromProjectLocationLakeZoneAction(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (s_projectLocationLakeZoneAssetAction.TryParseName(actionName, out resourceName))
            {
                result = FromProjectLocationLakeZoneAssetAction(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(actionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ActionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string actionId = null, string assetId = null, string lakeId = null, string locationId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ActionId = actionId;
            AssetId = assetId;
            LakeId = lakeId;
            LocationId = locationId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ActionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/actions/{action}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="actionId">The <c>Action</c> ID. Must not be <c>null</c> or empty.</param>
        public ActionName(string projectId, string locationId, string lakeId, string actionId) : this(ResourceNameType.ProjectLocationLakeAction, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), actionId: gax::GaxPreconditions.CheckNotNullOrEmpty(actionId, nameof(actionId)))
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
        /// The <c>Action</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ActionId { get; }

        /// <summary>
        /// The <c>Asset</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string AssetId { get; }

        /// <summary>
        /// The <c>Lake</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LakeId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationLakeAction: return s_projectLocationLakeAction.Expand(ProjectId, LocationId, LakeId, ActionId);
                case ResourceNameType.ProjectLocationLakeZoneAction: return s_projectLocationLakeZoneAction.Expand(ProjectId, LocationId, LakeId, ZoneId, ActionId);
                case ResourceNameType.ProjectLocationLakeZoneAssetAction: return s_projectLocationLakeZoneAssetAction.Expand(ProjectId, LocationId, LakeId, ZoneId, AssetId, ActionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ActionName);

        /// <inheritdoc/>
        public bool Equals(ActionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ActionName a, ActionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ActionName a, ActionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Asset</c> resource.</summary>
    public sealed partial class AssetName : gax::IResourceName, sys::IEquatable<AssetName>
    {
        /// <summary>The possible contents of <see cref="AssetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}</c>.
            /// </summary>
            ProjectLocationLakeZoneAsset = 1,
        }

        private static gax::PathTemplate s_projectLocationLakeZoneAsset = new gax::PathTemplate("projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}");

        /// <summary>Creates a <see cref="AssetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssetName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssetName"/> constructed from the provided ids.</returns>
        public static AssetName FromProjectLocationLakeZoneAsset(string projectId, string locationId, string lakeId, string zoneId, string assetId) =>
            new AssetName(ResourceNameType.ProjectLocationLakeZoneAsset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string lakeId, string zoneId, string assetId) =>
            FormatProjectLocationLakeZoneAsset(projectId, locationId, lakeId, zoneId, assetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}</c>.
        /// </returns>
        public static string FormatProjectLocationLakeZoneAsset(string projectId, string locationId, string lakeId, string zoneId, string assetId) =>
            s_projectLocationLakeZoneAsset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)));

        /// <summary>Parses the given resource name string into a new <see cref="AssetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetName"/> if successful.</returns>
        public static AssetName Parse(string assetName) => Parse(assetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssetName"/> if successful.</returns>
        public static AssetName Parse(string assetName, bool allowUnparsed) =>
            TryParse(assetName, allowUnparsed, out AssetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetName, out AssetName result) => TryParse(assetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetName, bool allowUnparsed, out AssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetName, nameof(assetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLakeZoneAsset.TryParseName(assetName, out resourceName))
            {
                result = FromProjectLocationLakeZoneAsset(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AssetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetId = null, string lakeId = null, string locationId = null, string projectId = null, string zoneId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetId = assetId;
            LakeId = lakeId;
            LocationId = locationId;
            ProjectId = projectId;
            ZoneId = zoneId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/lakes/{lake}/zones/{zone}/assets/{asset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lakeId">The <c>Lake</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="zoneId">The <c>Zone</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        public AssetName(string projectId, string locationId, string lakeId, string zoneId, string assetId) : this(ResourceNameType.ProjectLocationLakeZoneAsset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), lakeId: gax::GaxPreconditions.CheckNotNullOrEmpty(lakeId, nameof(lakeId)), zoneId: gax::GaxPreconditions.CheckNotNullOrEmpty(zoneId, nameof(zoneId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)))
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
        /// The <c>Asset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetId { get; }

        /// <summary>
        /// The <c>Lake</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LakeId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Zone</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ZoneId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationLakeZoneAsset: return s_projectLocationLakeZoneAsset.Expand(ProjectId, LocationId, LakeId, ZoneId, AssetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssetName);

        /// <inheritdoc/>
        public bool Equals(AssetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AssetName a, AssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AssetName a, AssetName b) => !(a == b);
    }

    public partial class Lake
    {
        /// <summary>
        /// <see cref="gcdv::LakeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::LakeName LakeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::LakeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Zone
    {
        /// <summary>
        /// <see cref="gcdv::ZoneName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ZoneName ZoneName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ZoneName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Action
    {
        /// <summary>
        /// <see cref="gcdv::ActionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ActionName ActionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ActionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="LakeName"/>-typed view over the <see cref="Lake"/> resource name property.</summary>
        public LakeName LakeAsLakeName
        {
            get => string.IsNullOrEmpty(Lake) ? null : LakeName.Parse(Lake, allowUnparsed: true);
            set => Lake = value?.ToString() ?? "";
        }

        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Zone"/> resource name property.</summary>
        public ZoneName ZoneAsZoneName
        {
            get => string.IsNullOrEmpty(Zone) ? null : ZoneName.Parse(Zone, allowUnparsed: true);
            set => Zone = value?.ToString() ?? "";
        }

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        public AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }
    }

    public partial class Asset
    {
        /// <summary>
        /// <see cref="gcdv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
