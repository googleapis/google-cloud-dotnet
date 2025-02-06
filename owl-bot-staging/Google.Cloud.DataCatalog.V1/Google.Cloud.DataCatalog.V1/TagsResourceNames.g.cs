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
using gcdv = Google.Cloud.DataCatalog.V1;
using sys = System;

namespace Google.Cloud.DataCatalog.V1
{
    /// <summary>Resource name for the <c>Tag</c> resource.</summary>
    public sealed partial class TagName : gax::IResourceName, sys::IEquatable<TagName>
    {
        /// <summary>The possible contents of <see cref="TagName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}</c>.
            /// </summary>
            ProjectLocationEntryGroupEntryTag = 1,
        }

        private static gax::PathTemplate s_projectLocationEntryGroupEntryTag = new gax::PathTemplate("projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}");

        /// <summary>Creates a <see cref="TagName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TagName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TagName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TagName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TagName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagId">The <c>Tag</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TagName"/> constructed from the provided ids.</returns>
        public static TagName FromProjectLocationEntryGroupEntryTag(string projectId, string locationId, string entryGroupId, string entryId, string tagId) =>
            new TagName(ResourceNameType.ProjectLocationEntryGroupEntryTag, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entryGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)), entryId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)), tagId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagId, nameof(tagId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagId">The <c>Tag</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string entryGroupId, string entryId, string tagId) =>
            FormatProjectLocationEntryGroupEntryTag(projectId, locationId, entryGroupId, entryId, tagId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagId">The <c>Tag</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}</c>.
        /// </returns>
        public static string FormatProjectLocationEntryGroupEntryTag(string projectId, string locationId, string entryGroupId, string entryId, string tagId) =>
            s_projectLocationEntryGroupEntryTag.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tagId, nameof(tagId)));

        /// <summary>Parses the given resource name string into a new <see cref="TagName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TagName"/> if successful.</returns>
        public static TagName Parse(string tagName) => Parse(tagName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TagName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TagName"/> if successful.</returns>
        public static TagName Parse(string tagName, bool allowUnparsed) =>
            TryParse(tagName, allowUnparsed, out TagName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="TagName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagName, out TagName result) => TryParse(tagName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagName, bool allowUnparsed, out TagName result)
        {
            gax::GaxPreconditions.CheckNotNull(tagName, nameof(tagName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEntryGroupEntryTag.TryParseName(tagName, out resourceName))
            {
                result = FromProjectLocationEntryGroupEntryTag(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tagName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TagName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entryId = null, string entryGroupId = null, string locationId = null, string projectId = null, string tagId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntryId = entryId;
            EntryGroupId = entryGroupId;
            LocationId = locationId;
            ProjectId = projectId;
            TagId = tagId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TagName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryGroupId">The <c>EntryGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entryId">The <c>Entry</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagId">The <c>Tag</c> ID. Must not be <c>null</c> or empty.</param>
        public TagName(string projectId, string locationId, string entryGroupId, string entryId, string tagId) : this(ResourceNameType.ProjectLocationEntryGroupEntryTag, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entryGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)), entryId: gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)), tagId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagId, nameof(tagId)))
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

        /// <summary>
        /// The <c>Tag</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TagId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationEntryGroupEntryTag: return s_projectLocationEntryGroupEntryTag.Expand(ProjectId, LocationId, EntryGroupId, EntryId, TagId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TagName);

        /// <inheritdoc/>
        public bool Equals(TagName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TagName a, TagName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TagName a, TagName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>TagTemplate</c> resource.</summary>
    public sealed partial class TagTemplateName : gax::IResourceName, sys::IEquatable<TagTemplateName>
    {
        /// <summary>The possible contents of <see cref="TagTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}</c>.
            /// </summary>
            ProjectLocationTagTemplate = 1,
        }

        private static gax::PathTemplate s_projectLocationTagTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/tagTemplates/{tag_template}");

        /// <summary>Creates a <see cref="TagTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TagTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TagTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TagTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TagTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TagTemplateName"/> constructed from the provided ids.</returns>
        public static TagTemplateName FromProjectLocationTagTemplate(string projectId, string locationId, string tagTemplateId) =>
            new TagTemplateName(ResourceNameType.ProjectLocationTagTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tagTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string tagTemplateId) =>
            FormatProjectLocationTagTemplate(projectId, locationId, tagTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}</c>.
        /// </returns>
        public static string FormatProjectLocationTagTemplate(string projectId, string locationId, string tagTemplateId) =>
            s_projectLocationTagTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)));

        /// <summary>Parses the given resource name string into a new <see cref="TagTemplateName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tagTemplates/{tag_template}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tagTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TagTemplateName"/> if successful.</returns>
        public static TagTemplateName Parse(string tagTemplateName) => Parse(tagTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TagTemplateName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tagTemplates/{tag_template}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TagTemplateName"/> if successful.</returns>
        public static TagTemplateName Parse(string tagTemplateName, bool allowUnparsed) =>
            TryParse(tagTemplateName, allowUnparsed, out TagTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tagTemplates/{tag_template}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tagTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagTemplateName, out TagTemplateName result) =>
            TryParse(tagTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/tagTemplates/{tag_template}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagTemplateName, bool allowUnparsed, out TagTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(tagTemplateName, nameof(tagTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTagTemplate.TryParseName(tagTemplateName, out resourceName))
            {
                result = FromProjectLocationTagTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tagTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TagTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string tagTemplateId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TagTemplateId = tagTemplateId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TagTemplateName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        public TagTemplateName(string projectId, string locationId, string tagTemplateId) : this(ResourceNameType.ProjectLocationTagTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tagTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)))
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
        /// The <c>TagTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TagTemplateId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTagTemplate: return s_projectLocationTagTemplate.Expand(ProjectId, LocationId, TagTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TagTemplateName);

        /// <inheritdoc/>
        public bool Equals(TagTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TagTemplateName a, TagTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TagTemplateName a, TagTemplateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>TagTemplateField</c> resource.</summary>
    public sealed partial class TagTemplateFieldName : gax::IResourceName, sys::IEquatable<TagTemplateFieldName>
    {
        /// <summary>The possible contents of <see cref="TagTemplateFieldName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}</c>.
            /// </summary>
            ProjectLocationTagTemplateField = 1,
        }

        private static gax::PathTemplate s_projectLocationTagTemplateField = new gax::PathTemplate("projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}");

        /// <summary>Creates a <see cref="TagTemplateFieldName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TagTemplateFieldName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TagTemplateFieldName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TagTemplateFieldName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TagTemplateFieldName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldId">The <c>Field</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TagTemplateFieldName"/> constructed from the provided ids.</returns>
        public static TagTemplateFieldName FromProjectLocationTagTemplateField(string projectId, string locationId, string tagTemplateId, string fieldId) =>
            new TagTemplateFieldName(ResourceNameType.ProjectLocationTagTemplateField, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tagTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)), fieldId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldId, nameof(fieldId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagTemplateFieldName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldId">The <c>Field</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagTemplateFieldName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string tagTemplateId, string fieldId) =>
            FormatProjectLocationTagTemplateField(projectId, locationId, tagTemplateId, fieldId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagTemplateFieldName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldId">The <c>Field</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagTemplateFieldName"/> with pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}</c>.
        /// </returns>
        public static string FormatProjectLocationTagTemplateField(string projectId, string locationId, string tagTemplateId, string fieldId) =>
            s_projectLocationTagTemplateField.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fieldId, nameof(fieldId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TagTemplateFieldName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tagTemplateFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TagTemplateFieldName"/> if successful.</returns>
        public static TagTemplateFieldName Parse(string tagTemplateFieldName) => Parse(tagTemplateFieldName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TagTemplateFieldName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagTemplateFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TagTemplateFieldName"/> if successful.</returns>
        public static TagTemplateFieldName Parse(string tagTemplateFieldName, bool allowUnparsed) =>
            TryParse(tagTemplateFieldName, allowUnparsed, out TagTemplateFieldName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagTemplateFieldName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tagTemplateFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagTemplateFieldName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagTemplateFieldName, out TagTemplateFieldName result) =>
            TryParse(tagTemplateFieldName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagTemplateFieldName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagTemplateFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagTemplateFieldName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagTemplateFieldName, bool allowUnparsed, out TagTemplateFieldName result)
        {
            gax::GaxPreconditions.CheckNotNull(tagTemplateFieldName, nameof(tagTemplateFieldName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTagTemplateField.TryParseName(tagTemplateFieldName, out resourceName))
            {
                result = FromProjectLocationTagTemplateField(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tagTemplateFieldName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TagTemplateFieldName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string fieldId = null, string locationId = null, string projectId = null, string tagTemplateId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FieldId = fieldId;
            LocationId = locationId;
            ProjectId = projectId;
            TagTemplateId = tagTemplateId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TagTemplateFieldName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagTemplateId">The <c>TagTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldId">The <c>Field</c> ID. Must not be <c>null</c> or empty.</param>
        public TagTemplateFieldName(string projectId, string locationId, string tagTemplateId, string fieldId) : this(ResourceNameType.ProjectLocationTagTemplateField, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), tagTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)), fieldId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldId, nameof(fieldId)))
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
        /// The <c>Field</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FieldId { get; }

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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTagTemplateField: return s_projectLocationTagTemplateField.Expand(ProjectId, LocationId, TagTemplateId, FieldId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TagTemplateFieldName);

        /// <inheritdoc/>
        public bool Equals(TagTemplateFieldName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TagTemplateFieldName a, TagTemplateFieldName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TagTemplateFieldName a, TagTemplateFieldName b) => !(a == b);
    }

    public partial class Tag
    {
        /// <summary>
        /// <see cref="gcdv::TagName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TagName TagName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TagName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TagTemplate
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

    public partial class TagTemplateField
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
}
