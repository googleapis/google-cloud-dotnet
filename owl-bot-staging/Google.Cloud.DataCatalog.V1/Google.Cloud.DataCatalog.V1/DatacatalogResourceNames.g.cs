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
using gcdv = Google.Cloud.DataCatalog.V1;
using sys = System;

namespace Google.Cloud.DataCatalog.V1
{
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

    /// <summary>Resource name for the <c>TagTemplateFieldEnumValue</c> resource.</summary>
    public sealed partial class TagTemplateFieldEnumValueName : gax::IResourceName, sys::IEquatable<TagTemplateFieldEnumValueName>
    {
        /// <summary>The possible contents of <see cref="TagTemplateFieldEnumValueName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}</c>
            /// .
            /// </summary>
            ProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName = 1,
        }

        private static gax::PathTemplate s_projectLocationTagTemplateTagTemplateFieldEnumValueDisplayName = new gax::PathTemplate("projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}");

        /// <summary>
        /// Creates a <see cref="TagTemplateFieldEnumValueName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TagTemplateFieldEnumValueName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TagTemplateFieldEnumValueName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TagTemplateFieldEnumValueName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TagTemplateFieldEnumValueName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateFieldId">The <c>TagTemplateField</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enumValueDisplayNameId">
        /// The <c>EnumValueDisplayName</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="TagTemplateFieldEnumValueName"/> constructed from the provided ids.
        /// </returns>
        public static TagTemplateFieldEnumValueName FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName(string projectId, string locationId, string tagTemplateId, string tagTemplateFieldId, string enumValueDisplayNameId) =>
            new TagTemplateFieldEnumValueName(ResourceNameType.ProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tagTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)), tagTemplateFieldId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateFieldId, nameof(tagTemplateFieldId)), enumValueDisplayNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(enumValueDisplayNameId, nameof(enumValueDisplayNameId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagTemplateFieldEnumValueName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateFieldId">The <c>TagTemplateField</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enumValueDisplayNameId">
        /// The <c>EnumValueDisplayName</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="TagTemplateFieldEnumValueName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string tagTemplateId, string tagTemplateFieldId, string enumValueDisplayNameId) =>
            FormatProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName(projectId, locationId, tagTemplateId, tagTemplateFieldId, enumValueDisplayNameId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagTemplateFieldEnumValueName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateFieldId">The <c>TagTemplateField</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enumValueDisplayNameId">
        /// The <c>EnumValueDisplayName</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="TagTemplateFieldEnumValueName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName(string projectId, string locationId, string tagTemplateId, string tagTemplateFieldId, string enumValueDisplayNameId) =>
            s_projectLocationTagTemplateTagTemplateFieldEnumValueDisplayName.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateFieldId, nameof(tagTemplateFieldId)), gax::GaxPreconditions.CheckNotNullOrEmpty(enumValueDisplayNameId, nameof(enumValueDisplayNameId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TagTemplateFieldEnumValueName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tagTemplateFieldEnumValueName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="TagTemplateFieldEnumValueName"/> if successful.</returns>
        public static TagTemplateFieldEnumValueName Parse(string tagTemplateFieldEnumValueName) =>
            Parse(tagTemplateFieldEnumValueName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TagTemplateFieldEnumValueName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagTemplateFieldEnumValueName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TagTemplateFieldEnumValueName"/> if successful.</returns>
        public static TagTemplateFieldEnumValueName Parse(string tagTemplateFieldEnumValueName, bool allowUnparsed) =>
            TryParse(tagTemplateFieldEnumValueName, allowUnparsed, out TagTemplateFieldEnumValueName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagTemplateFieldEnumValueName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tagTemplateFieldEnumValueName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagTemplateFieldEnumValueName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagTemplateFieldEnumValueName, out TagTemplateFieldEnumValueName result) =>
            TryParse(tagTemplateFieldEnumValueName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagTemplateFieldEnumValueName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagTemplateFieldEnumValueName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagTemplateFieldEnumValueName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagTemplateFieldEnumValueName, bool allowUnparsed, out TagTemplateFieldEnumValueName result)
        {
            gax::GaxPreconditions.CheckNotNull(tagTemplateFieldEnumValueName, nameof(tagTemplateFieldEnumValueName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTagTemplateTagTemplateFieldEnumValueDisplayName.TryParseName(tagTemplateFieldEnumValueName, out resourceName))
            {
                result = FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tagTemplateFieldEnumValueName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TagTemplateFieldEnumValueName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string enumValueDisplayNameId = null, string locationId = null, string projectId = null, string tagTemplateId = null, string tagTemplateFieldId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EnumValueDisplayNameId = enumValueDisplayNameId;
            LocationId = locationId;
            ProjectId = projectId;
            TagTemplateId = tagTemplateId;
            TagTemplateFieldId = tagTemplateFieldId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TagTemplateFieldEnumValueName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{tag_template_field_id}/enumValues/{enum_value_display_name}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateFieldId">The <c>TagTemplateField</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="enumValueDisplayNameId">
        /// The <c>EnumValueDisplayName</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public TagTemplateFieldEnumValueName(string projectId, string locationId, string tagTemplateId, string tagTemplateFieldId, string enumValueDisplayNameId) : this(ResourceNameType.ProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tagTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)), tagTemplateFieldId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateFieldId, nameof(tagTemplateFieldId)), enumValueDisplayNameId: gax::GaxPreconditions.CheckNotNullOrEmpty(enumValueDisplayNameId, nameof(enumValueDisplayNameId)))
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
        /// The <c>EnumValueDisplayName</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string EnumValueDisplayNameId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>TagTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TagTemplateId { get; }

        /// <summary>
        /// The <c>TagTemplateField</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string TagTemplateFieldId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName: return s_projectLocationTagTemplateTagTemplateFieldEnumValueDisplayName.Expand(ProjectId, LocationId, TagTemplateId, TagTemplateFieldId, EnumValueDisplayNameId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TagTemplateFieldEnumValueName);

        /// <inheritdoc/>
        public bool Equals(TagTemplateFieldEnumValueName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TagTemplateFieldEnumValueName a, TagTemplateFieldEnumValueName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TagTemplateFieldEnumValueName a, TagTemplateFieldEnumValueName b) => !(a == b);
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

    public partial class CreateTagTemplateRequest
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

    public partial class GetTagTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::TagTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TagTemplateName TagTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TagTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTagTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::TagTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TagTemplateName TagTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TagTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTagRequest
    {
        /// <summary><see cref="EntryName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public EntryName ParentAsEntryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTagRequest
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

    public partial class CreateTagTemplateFieldRequest
    {
        /// <summary>
        /// <see cref="TagTemplateName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TagTemplateName ParentAsTagTemplateName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TagTemplateName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateTagTemplateFieldRequest
    {
        /// <summary>
        /// <see cref="gcdv::TagTemplateFieldName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TagTemplateFieldName TagTemplateFieldName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TagTemplateFieldName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RenameTagTemplateFieldRequest
    {
        /// <summary>
        /// <see cref="gcdv::TagTemplateFieldName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TagTemplateFieldName TagTemplateFieldName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TagTemplateFieldName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RenameTagTemplateFieldEnumValueRequest
    {
        /// <summary>
        /// <see cref="gcdv::TagTemplateFieldEnumValueName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::TagTemplateFieldEnumValueName TagTemplateFieldEnumValueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TagTemplateFieldEnumValueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTagTemplateFieldRequest
    {
        /// <summary>
        /// <see cref="gcdv::TagTemplateFieldName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TagTemplateFieldName TagTemplateFieldName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TagTemplateFieldName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTagsRequest
    {
        /// <summary><see cref="EntryName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public EntryName ParentAsEntryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ReconcileTagsRequest
    {
        /// <summary><see cref="EntryName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public EntryName ParentAsEntryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TagTemplateName"/>-typed view over the <see cref="TagTemplate"/> resource name property.
        /// </summary>
        public TagTemplateName TagTemplateAsTagTemplateName
        {
            get => string.IsNullOrEmpty(TagTemplate) ? null : TagTemplateName.Parse(TagTemplate, allowUnparsed: true);
            set => TagTemplate = value?.ToString() ?? "";
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

    public partial class StarEntryRequest
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

    public partial class UnstarEntryRequest
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

    public partial class ImportEntriesRequest
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

    public partial class ModifyEntryOverviewRequest
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

    public partial class ModifyEntryContactsRequest
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
}
