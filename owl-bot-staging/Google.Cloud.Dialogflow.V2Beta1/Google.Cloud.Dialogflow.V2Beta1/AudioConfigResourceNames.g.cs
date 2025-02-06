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
using sys = System;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Resource name for the <c>Model</c> resource.</summary>
    public sealed partial class ModelName : gax::IResourceName, sys::IEquatable<ModelName>
    {
        /// <summary>The possible contents of <see cref="ModelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/models/{model}</c>.
            /// </summary>
            ProjectLocationModel = 1,
        }

        private static gax::PathTemplate s_projectLocationModel = new gax::PathTemplate("projects/{project}/locations/{location}/models/{model}");

        /// <summary>Creates a <see cref="ModelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ModelName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ModelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ModelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ModelName"/> with the pattern <c>projects/{project}/locations/{location}/models/{model}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ModelName"/> constructed from the provided ids.</returns>
        public static ModelName FromProjectLocationModel(string projectId, string locationId, string modelId) =>
            new ModelName(ResourceNameType.ProjectLocationModel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string modelId) =>
            FormatProjectLocationModel(projectId, locationId, modelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ModelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/models/{model}</c>.
        /// </returns>
        public static string FormatProjectLocationModel(string projectId, string locationId, string modelId) =>
            s_projectLocationModel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)));

        /// <summary>Parses the given resource name string into a new <see cref="ModelName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/models/{model}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="modelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ModelName"/> if successful.</returns>
        public static ModelName Parse(string modelName) => Parse(modelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ModelName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/models/{model}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ModelName"/> if successful.</returns>
        public static ModelName Parse(string modelName, bool allowUnparsed) =>
            TryParse(modelName, allowUnparsed, out ModelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/models/{model}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="modelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelName, out ModelName result) => TryParse(modelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/models/{model}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelName, bool allowUnparsed, out ModelName result)
        {
            gax::GaxPreconditions.CheckNotNull(modelName, nameof(modelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationModel.TryParseName(modelName, out resourceName))
            {
                result = FromProjectLocationModel(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(modelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ModelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string modelId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ModelId = modelId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ModelName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/models/{model}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelId">The <c>Model</c> ID. Must not be <c>null</c> or empty.</param>
        public ModelName(string projectId, string locationId, string modelId) : this(ResourceNameType.ProjectLocationModel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), modelId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)))
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
        /// The <c>Model</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ModelId { get; }

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
                case ResourceNameType.ProjectLocationModel: return s_projectLocationModel.Expand(ProjectId, LocationId, ModelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ModelName);

        /// <inheritdoc/>
        public bool Equals(ModelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ModelName a, ModelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ModelName a, ModelName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PhraseSet</c> resource.</summary>
    public sealed partial class PhraseSetName : gax::IResourceName, sys::IEquatable<PhraseSetName>
    {
        /// <summary>The possible contents of <see cref="PhraseSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/phraseSets/{phrase_set}</c>.
            /// </summary>
            ProjectLocationPhraseSet = 1,
        }

        private static gax::PathTemplate s_projectLocationPhraseSet = new gax::PathTemplate("projects/{project}/locations/{location}/phraseSets/{phrase_set}");

        /// <summary>Creates a <see cref="PhraseSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PhraseSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PhraseSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PhraseSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PhraseSetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/phraseSets/{phrase_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseSetId">The <c>PhraseSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PhraseSetName"/> constructed from the provided ids.</returns>
        public static PhraseSetName FromProjectLocationPhraseSet(string projectId, string locationId, string phraseSetId) =>
            new PhraseSetName(ResourceNameType.ProjectLocationPhraseSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), phraseSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(phraseSetId, nameof(phraseSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhraseSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseSets/{phrase_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseSetId">The <c>PhraseSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PhraseSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseSets/{phrase_set}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string phraseSetId) =>
            FormatProjectLocationPhraseSet(projectId, locationId, phraseSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PhraseSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseSets/{phrase_set}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseSetId">The <c>PhraseSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PhraseSetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/phraseSets/{phrase_set}</c>.
        /// </returns>
        public static string FormatProjectLocationPhraseSet(string projectId, string locationId, string phraseSetId) =>
            s_projectLocationPhraseSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(phraseSetId, nameof(phraseSetId)));

        /// <summary>Parses the given resource name string into a new <see cref="PhraseSetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseSets/{phrase_set}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="phraseSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PhraseSetName"/> if successful.</returns>
        public static PhraseSetName Parse(string phraseSetName) => Parse(phraseSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PhraseSetName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseSets/{phrase_set}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="phraseSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PhraseSetName"/> if successful.</returns>
        public static PhraseSetName Parse(string phraseSetName, bool allowUnparsed) =>
            TryParse(phraseSetName, allowUnparsed, out PhraseSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhraseSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseSets/{phrase_set}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="phraseSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhraseSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string phraseSetName, out PhraseSetName result) => TryParse(phraseSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PhraseSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/phraseSets/{phrase_set}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="phraseSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PhraseSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string phraseSetName, bool allowUnparsed, out PhraseSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(phraseSetName, nameof(phraseSetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPhraseSet.TryParseName(phraseSetName, out resourceName))
            {
                result = FromProjectLocationPhraseSet(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(phraseSetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PhraseSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string phraseSetId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PhraseSetId = phraseSetId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PhraseSetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/phraseSets/{phrase_set}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="phraseSetId">The <c>PhraseSet</c> ID. Must not be <c>null</c> or empty.</param>
        public PhraseSetName(string projectId, string locationId, string phraseSetId) : this(ResourceNameType.ProjectLocationPhraseSet, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), phraseSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(phraseSetId, nameof(phraseSetId)))
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
        /// The <c>PhraseSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PhraseSetId { get; }

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
                case ResourceNameType.ProjectLocationPhraseSet: return s_projectLocationPhraseSet.Expand(ProjectId, LocationId, PhraseSetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PhraseSetName);

        /// <inheritdoc/>
        public bool Equals(PhraseSetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PhraseSetName a, PhraseSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PhraseSetName a, PhraseSetName b) => !(a == b);
    }

    public partial class InputAudioConfig
    {
        /// <summary>
        /// <see cref="PhraseSetName"/>-typed view over the <see cref="PhraseSets"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<PhraseSetName> PhraseSetsAsPhraseSetNames
        {
            get => new gax::ResourceNameList<PhraseSetName>(PhraseSets, s => string.IsNullOrEmpty(s) ? null : PhraseSetName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class SpeechToTextConfig
    {
        /// <summary>
        /// <see cref="PhraseSetName"/>-typed view over the <see cref="PhraseSets"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<PhraseSetName> PhraseSetsAsPhraseSetNames
        {
            get => new gax::ResourceNameList<PhraseSetName>(PhraseSets, s => string.IsNullOrEmpty(s) ? null : PhraseSetName.Parse(s, allowUnparsed: true));
        }
    }
}
