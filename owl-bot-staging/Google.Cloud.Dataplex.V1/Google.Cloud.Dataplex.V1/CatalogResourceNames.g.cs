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
using gcdv = Google.Cloud.Dataplex.V1;
using sys = System;

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Resource name for the <c>AspectType</c> resource.</summary>
    public sealed partial class AspectTypeName : gax::IResourceName, sys::IEquatable<AspectTypeName>
    {
        /// <summary>The possible contents of <see cref="AspectTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/aspectTypes/{aspect_type}</c>.
            /// </summary>
            ProjectLocationAspectType = 1,
        }

        private static gax::PathTemplate s_projectLocationAspectType = new gax::PathTemplate("projects/{project}/locations/{location}/aspectTypes/{aspect_type}");

        /// <summary>Creates a <see cref="AspectTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AspectTypeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AspectTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AspectTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AspectTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/aspectTypes/{aspect_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aspectTypeId">The <c>AspectType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AspectTypeName"/> constructed from the provided ids.</returns>
        public static AspectTypeName FromProjectLocationAspectType(string projectId, string locationId, string aspectTypeId) =>
            new AspectTypeName(ResourceNameType.ProjectLocationAspectType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), aspectTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(aspectTypeId, nameof(aspectTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AspectTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/aspectTypes/{aspect_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aspectTypeId">The <c>AspectType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AspectTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/aspectTypes/{aspect_type}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string aspectTypeId) =>
            FormatProjectLocationAspectType(projectId, locationId, aspectTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AspectTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/aspectTypes/{aspect_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aspectTypeId">The <c>AspectType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AspectTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/aspectTypes/{aspect_type}</c>.
        /// </returns>
        public static string FormatProjectLocationAspectType(string projectId, string locationId, string aspectTypeId) =>
            s_projectLocationAspectType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(aspectTypeId, nameof(aspectTypeId)));

        /// <summary>Parses the given resource name string into a new <see cref="AspectTypeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/aspectTypes/{aspect_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="aspectTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AspectTypeName"/> if successful.</returns>
        public static AspectTypeName Parse(string aspectTypeName) => Parse(aspectTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AspectTypeName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/aspectTypes/{aspect_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="aspectTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AspectTypeName"/> if successful.</returns>
        public static AspectTypeName Parse(string aspectTypeName, bool allowUnparsed) =>
            TryParse(aspectTypeName, allowUnparsed, out AspectTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AspectTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/aspectTypes/{aspect_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="aspectTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AspectTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string aspectTypeName, out AspectTypeName result) =>
            TryParse(aspectTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AspectTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/aspectTypes/{aspect_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="aspectTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AspectTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string aspectTypeName, bool allowUnparsed, out AspectTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(aspectTypeName, nameof(aspectTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAspectType.TryParseName(aspectTypeName, out resourceName))
            {
                result = FromProjectLocationAspectType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(aspectTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AspectTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string aspectTypeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AspectTypeId = aspectTypeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AspectTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/aspectTypes/{aspect_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aspectTypeId">The <c>AspectType</c> ID. Must not be <c>null</c> or empty.</param>
        public AspectTypeName(string projectId, string locationId, string aspectTypeId) : this(ResourceNameType.ProjectLocationAspectType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), aspectTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(aspectTypeId, nameof(aspectTypeId)))
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
        /// The <c>AspectType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AspectTypeId { get; }

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
                case ResourceNameType.ProjectLocationAspectType: return s_projectLocationAspectType.Expand(ProjectId, LocationId, AspectTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AspectTypeName);

        /// <inheritdoc/>
        public bool Equals(AspectTypeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AspectTypeName a, AspectTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AspectTypeName a, AspectTypeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EntryGroup</c> resource.</summary>
    public sealed partial class EntryGroupName : gax::IResourceName, sys::IEquatable<EntryGroupName>
    {
        /// <summary>The possible contents of <see cref="EntryGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/entryGroups/{entry_group}</c>.
            /// </summary>
            ProjectLocationEntryGroup = 1,
        }

        private static gax::PathTemplate s_projectLocationEntryGroup = new gax::PathTemplate("projects/{project}/locations/{location}/entryGroups/{entry_group}");

        /// <summary>Creates a <see cref="EntryGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EntryGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EntryGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EntryGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EntryGroupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EntryGroupName"/> constructed from the provided ids.</returns>
        public static EntryGroupName FromProjectLocationEntryGroup(string projectId, string locationId, string entryGroupId) =>
            new EntryGroupName(ResourceNameType.ProjectLocationEntryGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entryGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntryGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntryGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string entryGroupId) =>
            FormatProjectLocationEntryGroup(projectId, locationId, entryGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntryGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntryGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}</c>.
        /// </returns>
        public static string FormatProjectLocationEntryGroup(string projectId, string locationId, string entryGroupId) =>
            s_projectLocationEntryGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)));

        /// <summary>Parses the given resource name string into a new <see cref="EntryGroupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entryGroups/{entry_group}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entryGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EntryGroupName"/> if successful.</returns>
        public static EntryGroupName Parse(string entryGroupName) => Parse(entryGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EntryGroupName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entryGroups/{entry_group}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entryGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EntryGroupName"/> if successful.</returns>
        public static EntryGroupName Parse(string entryGroupName, bool allowUnparsed) =>
            TryParse(entryGroupName, allowUnparsed, out EntryGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntryGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entryGroups/{entry_group}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entryGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntryGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entryGroupName, out EntryGroupName result) =>
            TryParse(entryGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntryGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entryGroups/{entry_group}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entryGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntryGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entryGroupName, bool allowUnparsed, out EntryGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(entryGroupName, nameof(entryGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEntryGroup.TryParseName(entryGroupName, out resourceName))
            {
                result = FromProjectLocationEntryGroup(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(entryGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EntryGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entryGroupId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntryGroupId = entryGroupId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EntryGroupName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        public EntryGroupName(string projectId, string locationId, string entryGroupId) : this(ResourceNameType.ProjectLocationEntryGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entryGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)))
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
        /// The <c>EntryGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EntryGroupId { get; }

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
                case ResourceNameType.ProjectLocationEntryGroup: return s_projectLocationEntryGroup.Expand(ProjectId, LocationId, EntryGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EntryGroupName);

        /// <inheritdoc/>
        public bool Equals(EntryGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EntryGroupName a, EntryGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EntryGroupName a, EntryGroupName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EntryType</c> resource.</summary>
    public sealed partial class EntryTypeName : gax::IResourceName, sys::IEquatable<EntryTypeName>
    {
        /// <summary>The possible contents of <see cref="EntryTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/entryTypes/{entry_type}</c>.
            /// </summary>
            ProjectLocationEntryType = 1,
        }

        private static gax::PathTemplate s_projectLocationEntryType = new gax::PathTemplate("projects/{project}/locations/{location}/entryTypes/{entry_type}");

        /// <summary>Creates a <see cref="EntryTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EntryTypeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EntryTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EntryTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EntryTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/entryTypes/{entry_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryTypeId">The <c>EntryType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EntryTypeName"/> constructed from the provided ids.</returns>
        public static EntryTypeName FromProjectLocationEntryType(string projectId, string locationId, string entryTypeId) =>
            new EntryTypeName(ResourceNameType.ProjectLocationEntryType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entryTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryTypeId, nameof(entryTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntryTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryTypes/{entry_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryTypeId">The <c>EntryType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntryTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryTypes/{entry_type}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string entryTypeId) =>
            FormatProjectLocationEntryType(projectId, locationId, entryTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntryTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryTypes/{entry_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryTypeId">The <c>EntryType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntryTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryTypes/{entry_type}</c>.
        /// </returns>
        public static string FormatProjectLocationEntryType(string projectId, string locationId, string entryTypeId) =>
            s_projectLocationEntryType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entryTypeId, nameof(entryTypeId)));

        /// <summary>Parses the given resource name string into a new <see cref="EntryTypeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entryTypes/{entry_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entryTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EntryTypeName"/> if successful.</returns>
        public static EntryTypeName Parse(string entryTypeName) => Parse(entryTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EntryTypeName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entryTypes/{entry_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entryTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EntryTypeName"/> if successful.</returns>
        public static EntryTypeName Parse(string entryTypeName, bool allowUnparsed) =>
            TryParse(entryTypeName, allowUnparsed, out EntryTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntryTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entryTypes/{entry_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entryTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntryTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entryTypeName, out EntryTypeName result) => TryParse(entryTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntryTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/entryTypes/{entry_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entryTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntryTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entryTypeName, bool allowUnparsed, out EntryTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(entryTypeName, nameof(entryTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEntryType.TryParseName(entryTypeName, out resourceName))
            {
                result = FromProjectLocationEntryType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(entryTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EntryTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entryTypeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntryTypeId = entryTypeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EntryTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/entryTypes/{entry_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryTypeId">The <c>EntryType</c> ID. Must not be <c>null</c> or empty.</param>
        public EntryTypeName(string projectId, string locationId, string entryTypeId) : this(ResourceNameType.ProjectLocationEntryType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entryTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryTypeId, nameof(entryTypeId)))
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
        /// The <c>EntryType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EntryTypeId { get; }

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
                case ResourceNameType.ProjectLocationEntryType: return s_projectLocationEntryType.Expand(ProjectId, LocationId, EntryTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EntryTypeName);

        /// <inheritdoc/>
        public bool Equals(EntryTypeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EntryTypeName a, EntryTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EntryTypeName a, EntryTypeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Entry</c> resource.</summary>
    public sealed partial class EntryName : gax::IResourceName, sys::IEquatable<EntryName>
    {
        /// <summary>The possible contents of <see cref="EntryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}</c>.
            /// </summary>
            ProjectLocationEntryGroupEntry = 1,
        }

        private static gax::PathTemplate s_projectLocationEntryGroupEntry = new gax::PathTemplate("projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}");

        /// <summary>Creates a <see cref="EntryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EntryName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EntryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EntryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EntryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EntryName"/> constructed from the provided ids.</returns>
        public static EntryName FromProjectLocationEntryGroupEntry(string projectId, string locationId, string entryGroupId, string entryId) =>
            new EntryName(ResourceNameType.ProjectLocationEntryGroupEntry, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entryGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)), entryId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string entryGroupId, string entryId) =>
            FormatProjectLocationEntryGroupEntry(projectId, locationId, entryGroupId, entryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}</c>.
        /// </returns>
        public static string FormatProjectLocationEntryGroupEntry(string projectId, string locationId, string entryGroupId, string entryId) =>
            s_projectLocationEntryGroupEntry.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)));

        /// <summary>Parses the given resource name string into a new <see cref="EntryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EntryName"/> if successful.</returns>
        public static EntryName Parse(string entryName) => Parse(entryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EntryName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EntryName"/> if successful.</returns>
        public static EntryName Parse(string entryName, bool allowUnparsed) =>
            TryParse(entryName, allowUnparsed, out EntryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entryName, out EntryName result) => TryParse(entryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entryName, bool allowUnparsed, out EntryName result)
        {
            gax::GaxPreconditions.CheckNotNull(entryName, nameof(entryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEntryGroupEntry.TryParseName(entryName, out resourceName))
            {
                result = FromProjectLocationEntryGroupEntry(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(entryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EntryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entryId = null, string entryGroupId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntryId = entryId;
            EntryGroupId = entryGroupId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EntryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        public EntryName(string projectId, string locationId, string entryGroupId, string entryId) : this(ResourceNameType.ProjectLocationEntryGroupEntry, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entryGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)), entryId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)))
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
        /// The <c>Entry</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EntryId { get; }

        /// <summary>
        /// The <c>EntryGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EntryGroupId { get; }

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
                case ResourceNameType.ProjectLocationEntryGroupEntry: return s_projectLocationEntryGroupEntry.Expand(ProjectId, LocationId, EntryGroupId, EntryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EntryName);

        /// <inheritdoc/>
        public bool Equals(EntryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EntryName a, EntryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EntryName a, EntryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MetadataJob</c> resource.</summary>
    public sealed partial class MetadataJobName : gax::IResourceName, sys::IEquatable<MetadataJobName>
    {
        /// <summary>The possible contents of <see cref="MetadataJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/metadataJobs/{metadataJob}</c>.
            /// </summary>
            ProjectLocationMetadataJob = 1,
        }

        private static gax::PathTemplate s_projectLocationMetadataJob = new gax::PathTemplate("projects/{project}/locations/{location}/metadataJobs/{metadataJob}");

        /// <summary>Creates a <see cref="MetadataJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MetadataJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MetadataJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MetadataJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MetadataJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/metadataJobs/{metadataJob}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataJobId">The <c>MetadataJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MetadataJobName"/> constructed from the provided ids.</returns>
        public static MetadataJobName FromProjectLocationMetadataJob(string projectId, string locationId, string metadataJobId) =>
            new MetadataJobName(ResourceNameType.ProjectLocationMetadataJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), metadataJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(metadataJobId, nameof(metadataJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetadataJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataJobs/{metadataJob}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataJobId">The <c>MetadataJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetadataJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataJobs/{metadataJob}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string metadataJobId) =>
            FormatProjectLocationMetadataJob(projectId, locationId, metadataJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetadataJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataJobs/{metadataJob}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataJobId">The <c>MetadataJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetadataJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataJobs/{metadataJob}</c>.
        /// </returns>
        public static string FormatProjectLocationMetadataJob(string projectId, string locationId, string metadataJobId) =>
            s_projectLocationMetadataJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(metadataJobId, nameof(metadataJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="MetadataJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/metadataJobs/{metadataJob}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="metadataJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MetadataJobName"/> if successful.</returns>
        public static MetadataJobName Parse(string metadataJobName) => Parse(metadataJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MetadataJobName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/metadataJobs/{metadataJob}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metadataJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MetadataJobName"/> if successful.</returns>
        public static MetadataJobName Parse(string metadataJobName, bool allowUnparsed) =>
            TryParse(metadataJobName, allowUnparsed, out MetadataJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetadataJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/metadataJobs/{metadataJob}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="metadataJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetadataJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metadataJobName, out MetadataJobName result) =>
            TryParse(metadataJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetadataJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/metadataJobs/{metadataJob}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metadataJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetadataJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metadataJobName, bool allowUnparsed, out MetadataJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(metadataJobName, nameof(metadataJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMetadataJob.TryParseName(metadataJobName, out resourceName))
            {
                result = FromProjectLocationMetadataJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(metadataJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MetadataJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string metadataJobId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MetadataJobId = metadataJobId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MetadataJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/metadataJobs/{metadataJob}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataJobId">The <c>MetadataJob</c> ID. Must not be <c>null</c> or empty.</param>
        public MetadataJobName(string projectId, string locationId, string metadataJobId) : this(ResourceNameType.ProjectLocationMetadataJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), metadataJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(metadataJobId, nameof(metadataJobId)))
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
        /// The <c>MetadataJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MetadataJobId { get; }

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
                case ResourceNameType.ProjectLocationMetadataJob: return s_projectLocationMetadataJob.Expand(ProjectId, LocationId, MetadataJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MetadataJobName);

        /// <inheritdoc/>
        public bool Equals(MetadataJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MetadataJobName a, MetadataJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MetadataJobName a, MetadataJobName b) => !(a == b);
    }

    public partial class AspectType
    {
        /// <summary>
        /// <see cref="gcdv::AspectTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AspectTypeName AspectTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AspectTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EntryGroup
    {
        /// <summary>
        /// <see cref="gcdv::EntryGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntryGroupName EntryGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntryGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EntryType
    {
        /// <summary>
        /// <see cref="gcdv::EntryTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntryTypeName EntryTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntryTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class AspectInfo
            {
                /// <summary>
                /// <see cref="AspectTypeName"/>-typed view over the <see cref="Type"/> resource name property.
                /// </summary>
                public AspectTypeName TypeAsAspectTypeName
                {
                    get => string.IsNullOrEmpty(Type) ? null : AspectTypeName.Parse(Type, allowUnparsed: true);
                    set => Type = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class Entry
    {
        /// <summary>
        /// <see cref="gcdv::EntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntryName EntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEntryGroupRequest
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

    public partial class DeleteEntryGroupRequest
    {
        /// <summary>
        /// <see cref="gcdv::EntryGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntryGroupName EntryGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntryGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEntryGroupsRequest
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

    public partial class GetEntryGroupRequest
    {
        /// <summary>
        /// <see cref="gcdv::EntryGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntryGroupName EntryGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntryGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEntryTypeRequest
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

    public partial class DeleteEntryTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::EntryTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntryTypeName EntryTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntryTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEntryTypesRequest
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

    public partial class GetEntryTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::EntryTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntryTypeName EntryTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntryTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAspectTypeRequest
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

    public partial class DeleteAspectTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::AspectTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AspectTypeName AspectTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AspectTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAspectTypesRequest
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

    public partial class GetAspectTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::AspectTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AspectTypeName AspectTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AspectTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEntryRequest
    {
        /// <summary>
        /// <see cref="EntryGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntryGroupName ParentAsEntryGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntryGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEntryRequest
    {
        /// <summary>
        /// <see cref="gcdv::EntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntryName EntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEntriesRequest
    {
        /// <summary>
        /// <see cref="EntryGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntryGroupName ParentAsEntryGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntryGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEntryRequest
    {
        /// <summary>
        /// <see cref="gcdv::EntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntryName EntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LookupEntryRequest
    {
        /// <summary><see cref="EntryName"/>-typed view over the <see cref="Entry"/> resource name property.</summary>
        public EntryName EntryAsEntryName
        {
            get => string.IsNullOrEmpty(Entry) ? null : EntryName.Parse(Entry, allowUnparsed: true);
            set => Entry = value?.ToString() ?? "";
        }
    }

    public partial class SearchEntriesRequest
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

    public partial class CreateMetadataJobRequest
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

    public partial class GetMetadataJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::MetadataJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::MetadataJobName MetadataJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::MetadataJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMetadataJobsRequest
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

    public partial class CancelMetadataJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::MetadataJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::MetadataJobName MetadataJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::MetadataJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MetadataJob
    {
        /// <summary>
        /// <see cref="gcdv::MetadataJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::MetadataJobName MetadataJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::MetadataJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class ImportJobSpec
            {
                public partial class Types
                {
                    public partial class ImportJobScope
                    {
                        /// <summary>
                        /// <see cref="EntryGroupName"/>-typed view over the <see cref="EntryGroups"/> resource name
                        /// property.
                        /// </summary>
                        public gax::ResourceNameList<EntryGroupName> EntryGroupsAsEntryGroupNames
                        {
                            get => new gax::ResourceNameList<EntryGroupName>(EntryGroups, s => string.IsNullOrEmpty(s) ? null : EntryGroupName.Parse(s, allowUnparsed: true));
                        }

                        /// <summary>
                        /// <see cref="EntryTypeName"/>-typed view over the <see cref="EntryTypes"/> resource name
                        /// property.
                        /// </summary>
                        public gax::ResourceNameList<EntryTypeName> EntryTypesAsEntryTypeNames
                        {
                            get => new gax::ResourceNameList<EntryTypeName>(EntryTypes, s => string.IsNullOrEmpty(s) ? null : EntryTypeName.Parse(s, allowUnparsed: true));
                        }

                        /// <summary>
                        /// <see cref="AspectTypeName"/>-typed view over the <see cref="AspectTypes"/> resource name
                        /// property.
                        /// </summary>
                        public gax::ResourceNameList<AspectTypeName> AspectTypesAsAspectTypeNames
                        {
                            get => new gax::ResourceNameList<AspectTypeName>(AspectTypes, s => string.IsNullOrEmpty(s) ? null : AspectTypeName.Parse(s, allowUnparsed: true));
                        }
                    }
                }
            }
        }
    }
}
