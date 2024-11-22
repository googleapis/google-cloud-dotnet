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
using gcav = Google.Cloud.AIPlatform.V1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>RagCorpus</c> resource.</summary>
    public sealed partial class RagCorpusName : gax::IResourceName, sys::IEquatable<RagCorpusName>
    {
        /// <summary>The possible contents of <see cref="RagCorpusName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}</c>.
            /// </summary>
            ProjectLocationRagCorpus = 1,
        }

        private static gax::PathTemplate s_projectLocationRagCorpus = new gax::PathTemplate("projects/{project}/locations/{location}/ragCorpora/{rag_corpus}");

        /// <summary>Creates a <see cref="RagCorpusName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RagCorpusName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RagCorpusName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RagCorpusName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RagCorpusName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragCorpusId">The <c>RagCorpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RagCorpusName"/> constructed from the provided ids.</returns>
        public static RagCorpusName FromProjectLocationRagCorpus(string projectId, string locationId, string ragCorpusId) =>
            new RagCorpusName(ResourceNameType.ProjectLocationRagCorpus, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), ragCorpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(ragCorpusId, nameof(ragCorpusId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RagCorpusName"/> with pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragCorpusId">The <c>RagCorpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RagCorpusName"/> with pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string ragCorpusId) =>
            FormatProjectLocationRagCorpus(projectId, locationId, ragCorpusId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RagCorpusName"/> with pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragCorpusId">The <c>RagCorpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RagCorpusName"/> with pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}</c>.
        /// </returns>
        public static string FormatProjectLocationRagCorpus(string projectId, string locationId, string ragCorpusId) =>
            s_projectLocationRagCorpus.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(ragCorpusId, nameof(ragCorpusId)));

        /// <summary>Parses the given resource name string into a new <see cref="RagCorpusName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="ragCorpusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RagCorpusName"/> if successful.</returns>
        public static RagCorpusName Parse(string ragCorpusName) => Parse(ragCorpusName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RagCorpusName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="ragCorpusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RagCorpusName"/> if successful.</returns>
        public static RagCorpusName Parse(string ragCorpusName, bool allowUnparsed) =>
            TryParse(ragCorpusName, allowUnparsed, out RagCorpusName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RagCorpusName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="ragCorpusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RagCorpusName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string ragCorpusName, out RagCorpusName result) => TryParse(ragCorpusName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RagCorpusName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="ragCorpusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RagCorpusName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string ragCorpusName, bool allowUnparsed, out RagCorpusName result)
        {
            gax::GaxPreconditions.CheckNotNull(ragCorpusName, nameof(ragCorpusName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRagCorpus.TryParseName(ragCorpusName, out resourceName))
            {
                result = FromProjectLocationRagCorpus(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(ragCorpusName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RagCorpusName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string ragCorpusId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RagCorpusId = ragCorpusId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RagCorpusName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragCorpusId">The <c>RagCorpus</c> ID. Must not be <c>null</c> or empty.</param>
        public RagCorpusName(string projectId, string locationId, string ragCorpusId) : this(ResourceNameType.ProjectLocationRagCorpus, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), ragCorpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(ragCorpusId, nameof(ragCorpusId)))
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
        /// The <c>RagCorpus</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RagCorpusId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRagCorpus: return s_projectLocationRagCorpus.Expand(ProjectId, LocationId, RagCorpusId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RagCorpusName);

        /// <inheritdoc/>
        public bool Equals(RagCorpusName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RagCorpusName a, RagCorpusName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RagCorpusName a, RagCorpusName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>RagFile</c> resource.</summary>
    public sealed partial class RagFileName : gax::IResourceName, sys::IEquatable<RagFileName>
    {
        /// <summary>The possible contents of <see cref="RagFileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}</c>.
            /// </summary>
            ProjectLocationRagCorpusRagFile = 1,
        }

        private static gax::PathTemplate s_projectLocationRagCorpusRagFile = new gax::PathTemplate("projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}");

        /// <summary>Creates a <see cref="RagFileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RagFileName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RagFileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RagFileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RagFileName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragCorpusId">The <c>RagCorpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragFileId">The <c>RagFile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RagFileName"/> constructed from the provided ids.</returns>
        public static RagFileName FromProjectLocationRagCorpusRagFile(string projectId, string locationId, string ragCorpusId, string ragFileId) =>
            new RagFileName(ResourceNameType.ProjectLocationRagCorpusRagFile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), ragCorpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(ragCorpusId, nameof(ragCorpusId)), ragFileId: gax::GaxPreconditions.CheckNotNullOrEmpty(ragFileId, nameof(ragFileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RagFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragCorpusId">The <c>RagCorpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragFileId">The <c>RagFile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RagFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string ragCorpusId, string ragFileId) =>
            FormatProjectLocationRagCorpusRagFile(projectId, locationId, ragCorpusId, ragFileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RagFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragCorpusId">The <c>RagCorpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragFileId">The <c>RagFile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RagFileName"/> with pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}</c>.
        /// </returns>
        public static string FormatProjectLocationRagCorpusRagFile(string projectId, string locationId, string ragCorpusId, string ragFileId) =>
            s_projectLocationRagCorpusRagFile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(ragCorpusId, nameof(ragCorpusId)), gax::GaxPreconditions.CheckNotNullOrEmpty(ragFileId, nameof(ragFileId)));

        /// <summary>Parses the given resource name string into a new <see cref="RagFileName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="ragFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RagFileName"/> if successful.</returns>
        public static RagFileName Parse(string ragFileName) => Parse(ragFileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RagFileName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="ragFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RagFileName"/> if successful.</returns>
        public static RagFileName Parse(string ragFileName, bool allowUnparsed) =>
            TryParse(ragFileName, allowUnparsed, out RagFileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RagFileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="ragFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RagFileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string ragFileName, out RagFileName result) => TryParse(ragFileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RagFileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="ragFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RagFileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string ragFileName, bool allowUnparsed, out RagFileName result)
        {
            gax::GaxPreconditions.CheckNotNull(ragFileName, nameof(ragFileName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRagCorpusRagFile.TryParseName(ragFileName, out resourceName))
            {
                result = FromProjectLocationRagCorpusRagFile(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(ragFileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RagFileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string ragCorpusId = null, string ragFileId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RagCorpusId = ragCorpusId;
            RagFileId = ragFileId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RagFileName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/ragCorpora/{rag_corpus}/ragFiles/{rag_file}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragCorpusId">The <c>RagCorpus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="ragFileId">The <c>RagFile</c> ID. Must not be <c>null</c> or empty.</param>
        public RagFileName(string projectId, string locationId, string ragCorpusId, string ragFileId) : this(ResourceNameType.ProjectLocationRagCorpusRagFile, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), ragCorpusId: gax::GaxPreconditions.CheckNotNullOrEmpty(ragCorpusId, nameof(ragCorpusId)), ragFileId: gax::GaxPreconditions.CheckNotNullOrEmpty(ragFileId, nameof(ragFileId)))
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
        /// The <c>RagCorpus</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RagCorpusId { get; }

        /// <summary>
        /// The <c>RagFile</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RagFileId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRagCorpusRagFile: return s_projectLocationRagCorpusRagFile.Expand(ProjectId, LocationId, RagCorpusId, RagFileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RagFileName);

        /// <inheritdoc/>
        public bool Equals(RagFileName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RagFileName a, RagFileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RagFileName a, RagFileName b) => !(a == b);
    }

    public partial class RagEmbeddingModelConfig
    {
        public partial class Types
        {
            public partial class VertexPredictionEndpoint
            {
                /// <summary>
                /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
                /// </summary>
                public EndpointName EndpointAsEndpointName
                {
                    get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
                    set => Endpoint = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.
                /// </summary>
                public ModelName ModelAsModelName
                {
                    get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
                    set => Model = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class RagCorpus
    {
        /// <summary>
        /// <see cref="gcav::RagCorpusName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::RagCorpusName RagCorpusName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RagCorpusName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RagFile
    {
        /// <summary>
        /// <see cref="gcav::RagFileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::RagFileName RagFileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::RagFileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
