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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gctv = Google.Cloud.Translate.V3;
using sys = System;

namespace Google.Cloud.Translate.V3
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

    public partial class TranslateTextRequest
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

    public partial class RomanizeTextRequest
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

    public partial class DetectLanguageRequest
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

    public partial class GetSupportedLanguagesRequest
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

    public partial class BatchTranslateTextRequest
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

    public partial class Glossary
    {
        /// <summary>
        /// <see cref="gctv::GlossaryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::GlossaryName GlossaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::GlossaryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
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

    public partial class GetGlossaryRequest
    {
        /// <summary>
        /// <see cref="gctv::GlossaryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::GlossaryName GlossaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::GlossaryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGlossaryRequest
    {
        /// <summary>
        /// <see cref="gctv::GlossaryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::GlossaryName GlossaryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::GlossaryName.Parse(Name, allowUnparsed: true);
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

    public partial class GetGlossaryEntryRequest
    {
        /// <summary>
        /// <see cref="gctv::GlossaryEntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::GlossaryEntryName GlossaryEntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::GlossaryEntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteGlossaryEntryRequest
    {
        /// <summary>
        /// <see cref="gctv::GlossaryEntryName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::GlossaryEntryName GlossaryEntryName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::GlossaryEntryName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListGlossaryEntriesRequest
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

    public partial class CreateGlossaryEntryRequest
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

    public partial class BatchTranslateDocumentRequest
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

    public partial class TranslateTextGlossaryConfig
    {
        /// <summary>
        /// <see cref="GlossaryName"/>-typed view over the <see cref="Glossary"/> resource name property.
        /// </summary>
        public GlossaryName GlossaryAsGlossaryName
        {
            get => string.IsNullOrEmpty(Glossary) ? null : GlossaryName.Parse(Glossary, allowUnparsed: true);
            set => Glossary = value?.ToString() ?? "";
        }
    }
}
