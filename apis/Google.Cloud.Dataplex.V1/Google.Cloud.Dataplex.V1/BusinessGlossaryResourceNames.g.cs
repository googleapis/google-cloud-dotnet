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
    /// <summary>Resource name for the <c>Glossary</c> resource.</summary>
    public sealed partial class GlossaryName : gax::IResourceName, sys::IEquatable<GlossaryName>
    {
        /// <summary>The possible contents of <see cref="GlossaryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/glossaries/{glossary}</c>.
            /// </summary>
            ProjectLocationGlossary = 1,
        }

        private static gax::PathTemplate s_projectLocationGlossary = new gax::PathTemplate("projects/{project}/locations/{location}/glossaries/{glossary}");

        /// <summary>Creates a <see cref="GlossaryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GlossaryName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static GlossaryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GlossaryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GlossaryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GlossaryName"/> constructed from the provided ids.</returns>
        public static GlossaryName FromProjectLocationGlossary(string projectId, string locationId, string glossaryId) =>
            new GlossaryName(ResourceNameType.ProjectLocationGlossary, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), glossaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GlossaryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GlossaryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string glossaryId) =>
            FormatProjectLocationGlossary(projectId, locationId, glossaryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GlossaryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GlossaryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}</c>.
        /// </returns>
        public static string FormatProjectLocationGlossary(string projectId, string locationId, string glossaryId) =>
            s_projectLocationGlossary.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)));

        /// <summary>Parses the given resource name string into a new <see cref="GlossaryName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/glossaries/{glossary}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="glossaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GlossaryName"/> if successful.</returns>
        public static GlossaryName Parse(string glossaryName) => Parse(glossaryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GlossaryName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/glossaries/{glossary}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="glossaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GlossaryName"/> if successful.</returns>
        public static GlossaryName Parse(string glossaryName, bool allowUnparsed) =>
            TryParse(glossaryName, allowUnparsed, out GlossaryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GlossaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/glossaries/{glossary}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="glossaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GlossaryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string glossaryName, out GlossaryName result) => TryParse(glossaryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GlossaryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/glossaries/{glossary}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="glossaryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GlossaryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string glossaryName, bool allowUnparsed, out GlossaryName result)
        {
            gax::GaxPreconditions.CheckNotNull(glossaryName, nameof(glossaryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGlossary.TryParseName(glossaryName, out resourceName))
            {
                result = FromProjectLocationGlossary(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(glossaryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GlossaryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string glossaryId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GlossaryId = glossaryId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GlossaryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        public GlossaryName(string projectId, string locationId, string glossaryId) : this(ResourceNameType.ProjectLocationGlossary, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), glossaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)))
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
        /// The <c>Glossary</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GlossaryId { get; }

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
                case ResourceNameType.ProjectLocationGlossary: return s_projectLocationGlossary.Expand(ProjectId, LocationId, GlossaryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GlossaryName);

        /// <inheritdoc/>
        public bool Equals(GlossaryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GlossaryName a, GlossaryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GlossaryName a, GlossaryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>GlossaryCategory</c> resource.</summary>
    public sealed partial class GlossaryCategoryName : gax::IResourceName, sys::IEquatable<GlossaryCategoryName>
    {
        /// <summary>The possible contents of <see cref="GlossaryCategoryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}</c>.
            /// </summary>
            ProjectLocationGlossaryGlossaryCategory = 1,
        }

        private static gax::PathTemplate s_projectLocationGlossaryGlossaryCategory = new gax::PathTemplate("projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}");

        /// <summary>Creates a <see cref="GlossaryCategoryName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GlossaryCategoryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GlossaryCategoryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GlossaryCategoryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GlossaryCategoryName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryCategoryId">The <c>GlossaryCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GlossaryCategoryName"/> constructed from the provided ids.</returns>
        public static GlossaryCategoryName FromProjectLocationGlossaryGlossaryCategory(string projectId, string locationId, string glossaryId, string glossaryCategoryId) =>
            new GlossaryCategoryName(ResourceNameType.ProjectLocationGlossaryGlossaryCategory, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), glossaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)), glossaryCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryCategoryId, nameof(glossaryCategoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GlossaryCategoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryCategoryId">The <c>GlossaryCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GlossaryCategoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string glossaryId, string glossaryCategoryId) =>
            FormatProjectLocationGlossaryGlossaryCategory(projectId, locationId, glossaryId, glossaryCategoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GlossaryCategoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryCategoryId">The <c>GlossaryCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GlossaryCategoryName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}</c>.
        /// </returns>
        public static string FormatProjectLocationGlossaryGlossaryCategory(string projectId, string locationId, string glossaryId, string glossaryCategoryId) =>
            s_projectLocationGlossaryGlossaryCategory.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryCategoryId, nameof(glossaryCategoryId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GlossaryCategoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="glossaryCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GlossaryCategoryName"/> if successful.</returns>
        public static GlossaryCategoryName Parse(string glossaryCategoryName) => Parse(glossaryCategoryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GlossaryCategoryName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="glossaryCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GlossaryCategoryName"/> if successful.</returns>
        public static GlossaryCategoryName Parse(string glossaryCategoryName, bool allowUnparsed) =>
            TryParse(glossaryCategoryName, allowUnparsed, out GlossaryCategoryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GlossaryCategoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="glossaryCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GlossaryCategoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string glossaryCategoryName, out GlossaryCategoryName result) =>
            TryParse(glossaryCategoryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GlossaryCategoryName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="glossaryCategoryName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GlossaryCategoryName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string glossaryCategoryName, bool allowUnparsed, out GlossaryCategoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(glossaryCategoryName, nameof(glossaryCategoryName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGlossaryGlossaryCategory.TryParseName(glossaryCategoryName, out resourceName))
            {
                result = FromProjectLocationGlossaryGlossaryCategory(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(glossaryCategoryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GlossaryCategoryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string glossaryId = null, string glossaryCategoryId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GlossaryId = glossaryId;
            GlossaryCategoryId = glossaryCategoryId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GlossaryCategoryName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/categories/{glossary_category}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryCategoryId">The <c>GlossaryCategory</c> ID. Must not be <c>null</c> or empty.</param>
        public GlossaryCategoryName(string projectId, string locationId, string glossaryId, string glossaryCategoryId) : this(ResourceNameType.ProjectLocationGlossaryGlossaryCategory, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), glossaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)), glossaryCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryCategoryId, nameof(glossaryCategoryId)))
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
        /// The <c>Glossary</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GlossaryId { get; }

        /// <summary>
        /// The <c>GlossaryCategory</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string GlossaryCategoryId { get; }

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
                case ResourceNameType.ProjectLocationGlossaryGlossaryCategory: return s_projectLocationGlossaryGlossaryCategory.Expand(ProjectId, LocationId, GlossaryId, GlossaryCategoryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GlossaryCategoryName);

        /// <inheritdoc/>
        public bool Equals(GlossaryCategoryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GlossaryCategoryName a, GlossaryCategoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GlossaryCategoryName a, GlossaryCategoryName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>GlossaryTerm</c> resource.</summary>
    public sealed partial class GlossaryTermName : gax::IResourceName, sys::IEquatable<GlossaryTermName>
    {
        /// <summary>The possible contents of <see cref="GlossaryTermName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}</c>.
            /// </summary>
            ProjectLocationGlossaryGlossaryTerm = 1,
        }

        private static gax::PathTemplate s_projectLocationGlossaryGlossaryTerm = new gax::PathTemplate("projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}");

        /// <summary>Creates a <see cref="GlossaryTermName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GlossaryTermName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GlossaryTermName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GlossaryTermName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GlossaryTermName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryTermId">The <c>GlossaryTerm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GlossaryTermName"/> constructed from the provided ids.</returns>
        public static GlossaryTermName FromProjectLocationGlossaryGlossaryTerm(string projectId, string locationId, string glossaryId, string glossaryTermId) =>
            new GlossaryTermName(ResourceNameType.ProjectLocationGlossaryGlossaryTerm, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), glossaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)), glossaryTermId: gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryTermId, nameof(glossaryTermId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GlossaryTermName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryTermId">The <c>GlossaryTerm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GlossaryTermName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string glossaryId, string glossaryTermId) =>
            FormatProjectLocationGlossaryGlossaryTerm(projectId, locationId, glossaryId, glossaryTermId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GlossaryTermName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryTermId">The <c>GlossaryTerm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GlossaryTermName"/> with pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}</c>.
        /// </returns>
        public static string FormatProjectLocationGlossaryGlossaryTerm(string projectId, string locationId, string glossaryId, string glossaryTermId) =>
            s_projectLocationGlossaryGlossaryTerm.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryTermId, nameof(glossaryTermId)));

        /// <summary>Parses the given resource name string into a new <see cref="GlossaryTermName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="glossaryTermName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GlossaryTermName"/> if successful.</returns>
        public static GlossaryTermName Parse(string glossaryTermName) => Parse(glossaryTermName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GlossaryTermName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="glossaryTermName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GlossaryTermName"/> if successful.</returns>
        public static GlossaryTermName Parse(string glossaryTermName, bool allowUnparsed) =>
            TryParse(glossaryTermName, allowUnparsed, out GlossaryTermName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GlossaryTermName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="glossaryTermName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GlossaryTermName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string glossaryTermName, out GlossaryTermName result) =>
            TryParse(glossaryTermName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GlossaryTermName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="glossaryTermName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GlossaryTermName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string glossaryTermName, bool allowUnparsed, out GlossaryTermName result)
        {
            gax::GaxPreconditions.CheckNotNull(glossaryTermName, nameof(glossaryTermName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGlossaryGlossaryTerm.TryParseName(glossaryTermName, out resourceName))
            {
                result = FromProjectLocationGlossaryGlossaryTerm(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(glossaryTermName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GlossaryTermName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string glossaryId = null, string glossaryTermId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GlossaryId = glossaryId;
            GlossaryTermId = glossaryTermId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GlossaryTermName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/glossaries/{glossary}/terms/{glossary_term}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryId">The <c>Glossary</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="glossaryTermId">The <c>GlossaryTerm</c> ID. Must not be <c>null</c> or empty.</param>
        public GlossaryTermName(string projectId, string locationId, string glossaryId, string glossaryTermId) : this(ResourceNameType.ProjectLocationGlossaryGlossaryTerm, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), glossaryId: gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryId, nameof(glossaryId)), glossaryTermId: gax::GaxPreconditions.CheckNotNullOrEmpty(glossaryTermId, nameof(glossaryTermId)))
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
        /// The <c>Glossary</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GlossaryId { get; }

        /// <summary>
        /// The <c>GlossaryTerm</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string GlossaryTermId { get; }

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
                case ResourceNameType.ProjectLocationGlossaryGlossaryTerm: return s_projectLocationGlossaryGlossaryTerm.Expand(ProjectId, LocationId, GlossaryId, GlossaryTermId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GlossaryTermName);

        /// <inheritdoc/>
        public bool Equals(GlossaryTermName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GlossaryTermName a, GlossaryTermName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GlossaryTermName a, GlossaryTermName b) => !(a == b);
    }

    public partial class Glossary
    {
        /// <summary>
        /// <see cref="gcdv::GlossaryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GlossaryName GlossaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GlossaryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GlossaryCategory
    {
        /// <summary>
        /// <see cref="gcdv::GlossaryCategoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GlossaryCategoryName GlossaryCategoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GlossaryCategoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GlossaryTerm
    {
        /// <summary>
        /// <see cref="gcdv::GlossaryTermName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GlossaryTermName GlossaryTermName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GlossaryTermName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="GlossaryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GlossaryName ParentAsGlossaryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GlossaryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateGlossaryRequest
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

    public partial class DeleteGlossaryRequest
    {
        /// <summary>
        /// <see cref="gcdv::GlossaryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GlossaryName GlossaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GlossaryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetGlossaryRequest
    {
        /// <summary>
        /// <see cref="gcdv::GlossaryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GlossaryName GlossaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GlossaryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGlossariesRequest
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

    public partial class CreateGlossaryCategoryRequest
    {
        /// <summary>
        /// <see cref="GlossaryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GlossaryName ParentAsGlossaryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GlossaryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGlossaryCategoryRequest
    {
        /// <summary>
        /// <see cref="gcdv::GlossaryCategoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GlossaryCategoryName GlossaryCategoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GlossaryCategoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetGlossaryCategoryRequest
    {
        /// <summary>
        /// <see cref="gcdv::GlossaryCategoryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GlossaryCategoryName GlossaryCategoryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GlossaryCategoryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGlossaryCategoriesRequest
    {
        /// <summary>
        /// <see cref="GlossaryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GlossaryName ParentAsGlossaryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GlossaryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateGlossaryTermRequest
    {
        /// <summary>
        /// <see cref="GlossaryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GlossaryName ParentAsGlossaryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GlossaryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGlossaryTermRequest
    {
        /// <summary>
        /// <see cref="gcdv::GlossaryTermName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GlossaryTermName GlossaryTermName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GlossaryTermName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetGlossaryTermRequest
    {
        /// <summary>
        /// <see cref="gcdv::GlossaryTermName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::GlossaryTermName GlossaryTermName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::GlossaryTermName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGlossaryTermsRequest
    {
        /// <summary>
        /// <see cref="GlossaryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public GlossaryName ParentAsGlossaryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : GlossaryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
