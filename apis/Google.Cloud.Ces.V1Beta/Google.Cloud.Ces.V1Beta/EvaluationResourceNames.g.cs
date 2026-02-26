// Copyright 2026 Google LLC
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
using gccv = Google.Cloud.Ces.V1Beta;
using sys = System;

namespace Google.Cloud.Ces.V1Beta
{
    /// <summary>Resource name for the <c>Evaluation</c> resource.</summary>
    public sealed partial class EvaluationName : gax::IResourceName, sys::IEquatable<EvaluationName>
    {
        /// <summary>The possible contents of <see cref="EvaluationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}</c>.
            /// </summary>
            ProjectLocationAppEvaluation = 1,
        }

        private static gax::PathTemplate s_projectLocationAppEvaluation = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}");

        /// <summary>Creates a <see cref="EvaluationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EvaluationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EvaluationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EvaluationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EvaluationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EvaluationName"/> constructed from the provided ids.</returns>
        public static EvaluationName FromProjectLocationAppEvaluation(string projectId, string locationId, string appId, string evaluationId) =>
            new EvaluationName(ResourceNameType.ProjectLocationAppEvaluation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string appId, string evaluationId) =>
            FormatProjectLocationAppEvaluation(projectId, locationId, appId, evaluationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}</c>.
        /// </returns>
        public static string FormatProjectLocationAppEvaluation(string projectId, string locationId, string appId, string evaluationId) =>
            s_projectLocationAppEvaluation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)));

        /// <summary>Parses the given resource name string into a new <see cref="EvaluationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EvaluationName"/> if successful.</returns>
        public static EvaluationName Parse(string evaluationName) => Parse(evaluationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EvaluationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EvaluationName"/> if successful.</returns>
        public static EvaluationName Parse(string evaluationName, bool allowUnparsed) =>
            TryParse(evaluationName, allowUnparsed, out EvaluationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationName, out EvaluationName result) =>
            TryParse(evaluationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationName, bool allowUnparsed, out EvaluationName result)
        {
            gax::GaxPreconditions.CheckNotNull(evaluationName, nameof(evaluationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppEvaluation.TryParseName(evaluationName, out resourceName))
            {
                result = FromProjectLocationAppEvaluation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(evaluationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EvaluationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string evaluationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            EvaluationId = evaluationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EvaluationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        public EvaluationName(string projectId, string locationId, string appId, string evaluationId) : this(ResourceNameType.ProjectLocationAppEvaluation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)))
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
        /// The <c>App</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// The <c>Evaluation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EvaluationId { get; }

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
                case ResourceNameType.ProjectLocationAppEvaluation: return s_projectLocationAppEvaluation.Expand(ProjectId, LocationId, AppId, EvaluationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EvaluationName);

        /// <inheritdoc/>
        public bool Equals(EvaluationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EvaluationName a, EvaluationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EvaluationName a, EvaluationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EvaluationDataset</c> resource.</summary>
    public sealed partial class EvaluationDatasetName : gax::IResourceName, sys::IEquatable<EvaluationDatasetName>
    {
        /// <summary>The possible contents of <see cref="EvaluationDatasetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}</c>.
            /// </summary>
            ProjectLocationAppEvaluationDataset = 1,
        }

        private static gax::PathTemplate s_projectLocationAppEvaluationDataset = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}");

        /// <summary>Creates a <see cref="EvaluationDatasetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EvaluationDatasetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EvaluationDatasetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EvaluationDatasetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EvaluationDatasetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationDatasetId">The <c>EvaluationDataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EvaluationDatasetName"/> constructed from the provided ids.</returns>
        public static EvaluationDatasetName FromProjectLocationAppEvaluationDataset(string projectId, string locationId, string appId, string evaluationDatasetId) =>
            new EvaluationDatasetName(ResourceNameType.ProjectLocationAppEvaluationDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), evaluationDatasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationDatasetId, nameof(evaluationDatasetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationDatasetId">The <c>EvaluationDataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string appId, string evaluationDatasetId) =>
            FormatProjectLocationAppEvaluationDataset(projectId, locationId, appId, evaluationDatasetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationDatasetId">The <c>EvaluationDataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationDatasetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}</c>.
        /// </returns>
        public static string FormatProjectLocationAppEvaluationDataset(string projectId, string locationId, string appId, string evaluationDatasetId) =>
            s_projectLocationAppEvaluationDataset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationDatasetId, nameof(evaluationDatasetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EvaluationDatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EvaluationDatasetName"/> if successful.</returns>
        public static EvaluationDatasetName Parse(string evaluationDatasetName) => Parse(evaluationDatasetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EvaluationDatasetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EvaluationDatasetName"/> if successful.</returns>
        public static EvaluationDatasetName Parse(string evaluationDatasetName, bool allowUnparsed) =>
            TryParse(evaluationDatasetName, allowUnparsed, out EvaluationDatasetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationDatasetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationDatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationDatasetName, out EvaluationDatasetName result) =>
            TryParse(evaluationDatasetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationDatasetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationDatasetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationDatasetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationDatasetName, bool allowUnparsed, out EvaluationDatasetName result)
        {
            gax::GaxPreconditions.CheckNotNull(evaluationDatasetName, nameof(evaluationDatasetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppEvaluationDataset.TryParseName(evaluationDatasetName, out resourceName))
            {
                result = FromProjectLocationAppEvaluationDataset(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(evaluationDatasetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EvaluationDatasetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string evaluationDatasetId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            EvaluationDatasetId = evaluationDatasetId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EvaluationDatasetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationDatasets/{evaluation_dataset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationDatasetId">The <c>EvaluationDataset</c> ID. Must not be <c>null</c> or empty.</param>
        public EvaluationDatasetName(string projectId, string locationId, string appId, string evaluationDatasetId) : this(ResourceNameType.ProjectLocationAppEvaluationDataset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), evaluationDatasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationDatasetId, nameof(evaluationDatasetId)))
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
        /// The <c>App</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// The <c>EvaluationDataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string EvaluationDatasetId { get; }

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
                case ResourceNameType.ProjectLocationAppEvaluationDataset: return s_projectLocationAppEvaluationDataset.Expand(ProjectId, LocationId, AppId, EvaluationDatasetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EvaluationDatasetName);

        /// <inheritdoc/>
        public bool Equals(EvaluationDatasetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EvaluationDatasetName a, EvaluationDatasetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EvaluationDatasetName a, EvaluationDatasetName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EvaluationResult</c> resource.</summary>
    public sealed partial class EvaluationResultName : gax::IResourceName, sys::IEquatable<EvaluationResultName>
    {
        /// <summary>The possible contents of <see cref="EvaluationResultName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}</c>
            /// .
            /// </summary>
            ProjectLocationAppEvaluationEvaluationResult = 1,
        }

        private static gax::PathTemplate s_projectLocationAppEvaluationEvaluationResult = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}");

        /// <summary>Creates a <see cref="EvaluationResultName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EvaluationResultName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EvaluationResultName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EvaluationResultName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EvaluationResultName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationResultId">The <c>EvaluationResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EvaluationResultName"/> constructed from the provided ids.</returns>
        public static EvaluationResultName FromProjectLocationAppEvaluationEvaluationResult(string projectId, string locationId, string appId, string evaluationId, string evaluationResultId) =>
            new EvaluationResultName(ResourceNameType.ProjectLocationAppEvaluationEvaluationResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)), evaluationResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationResultId, nameof(evaluationResultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationResultId">The <c>EvaluationResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string appId, string evaluationId, string evaluationResultId) =>
            FormatProjectLocationAppEvaluationEvaluationResult(projectId, locationId, appId, evaluationId, evaluationResultId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationResultId">The <c>EvaluationResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationAppEvaluationEvaluationResult(string projectId, string locationId, string appId, string evaluationId, string evaluationResultId) =>
            s_projectLocationAppEvaluationEvaluationResult.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationResultId, nameof(evaluationResultId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EvaluationResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EvaluationResultName"/> if successful.</returns>
        public static EvaluationResultName Parse(string evaluationResultName) => Parse(evaluationResultName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EvaluationResultName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EvaluationResultName"/> if successful.</returns>
        public static EvaluationResultName Parse(string evaluationResultName, bool allowUnparsed) =>
            TryParse(evaluationResultName, allowUnparsed, out EvaluationResultName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationResultName, out EvaluationResultName result) =>
            TryParse(evaluationResultName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationResultName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationResultName, bool allowUnparsed, out EvaluationResultName result)
        {
            gax::GaxPreconditions.CheckNotNull(evaluationResultName, nameof(evaluationResultName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppEvaluationEvaluationResult.TryParseName(evaluationResultName, out resourceName))
            {
                result = FromProjectLocationAppEvaluationEvaluationResult(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(evaluationResultName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EvaluationResultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string evaluationId = null, string evaluationResultId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            EvaluationId = evaluationId;
            EvaluationResultId = evaluationResultId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EvaluationResultName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluations/{evaluation}/results/{evaluation_result}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationId">The <c>Evaluation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationResultId">The <c>EvaluationResult</c> ID. Must not be <c>null</c> or empty.</param>
        public EvaluationResultName(string projectId, string locationId, string appId, string evaluationId, string evaluationResultId) : this(ResourceNameType.ProjectLocationAppEvaluationEvaluationResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), evaluationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationId, nameof(evaluationId)), evaluationResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationResultId, nameof(evaluationResultId)))
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
        /// The <c>App</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// The <c>Evaluation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EvaluationId { get; }

        /// <summary>
        /// The <c>EvaluationResult</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string EvaluationResultId { get; }

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
                case ResourceNameType.ProjectLocationAppEvaluationEvaluationResult: return s_projectLocationAppEvaluationEvaluationResult.Expand(ProjectId, LocationId, AppId, EvaluationId, EvaluationResultId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EvaluationResultName);

        /// <inheritdoc/>
        public bool Equals(EvaluationResultName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EvaluationResultName a, EvaluationResultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EvaluationResultName a, EvaluationResultName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EvaluationRun</c> resource.</summary>
    public sealed partial class EvaluationRunName : gax::IResourceName, sys::IEquatable<EvaluationRunName>
    {
        /// <summary>The possible contents of <see cref="EvaluationRunName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}</c>.
            /// </summary>
            ProjectLocationAppEvaluationRun = 1,
        }

        private static gax::PathTemplate s_projectLocationAppEvaluationRun = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}");

        /// <summary>Creates a <see cref="EvaluationRunName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EvaluationRunName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EvaluationRunName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EvaluationRunName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EvaluationRunName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationRunId">The <c>EvaluationRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EvaluationRunName"/> constructed from the provided ids.</returns>
        public static EvaluationRunName FromProjectLocationAppEvaluationRun(string projectId, string locationId, string appId, string evaluationRunId) =>
            new EvaluationRunName(ResourceNameType.ProjectLocationAppEvaluationRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), evaluationRunId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationRunId, nameof(evaluationRunId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationRunId">The <c>EvaluationRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string appId, string evaluationRunId) =>
            FormatProjectLocationAppEvaluationRun(projectId, locationId, appId, evaluationRunId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationRunId">The <c>EvaluationRun</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}</c>.
        /// </returns>
        public static string FormatProjectLocationAppEvaluationRun(string projectId, string locationId, string appId, string evaluationRunId) =>
            s_projectLocationAppEvaluationRun.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationRunId, nameof(evaluationRunId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EvaluationRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EvaluationRunName"/> if successful.</returns>
        public static EvaluationRunName Parse(string evaluationRunName) => Parse(evaluationRunName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EvaluationRunName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EvaluationRunName"/> if successful.</returns>
        public static EvaluationRunName Parse(string evaluationRunName, bool allowUnparsed) =>
            TryParse(evaluationRunName, allowUnparsed, out EvaluationRunName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationRunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationRunName, out EvaluationRunName result) =>
            TryParse(evaluationRunName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationRunName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationRunName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationRunName, bool allowUnparsed, out EvaluationRunName result)
        {
            gax::GaxPreconditions.CheckNotNull(evaluationRunName, nameof(evaluationRunName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppEvaluationRun.TryParseName(evaluationRunName, out resourceName))
            {
                result = FromProjectLocationAppEvaluationRun(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(evaluationRunName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EvaluationRunName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string evaluationRunId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            EvaluationRunId = evaluationRunId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EvaluationRunName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationRuns/{evaluation_run}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationRunId">The <c>EvaluationRun</c> ID. Must not be <c>null</c> or empty.</param>
        public EvaluationRunName(string projectId, string locationId, string appId, string evaluationRunId) : this(ResourceNameType.ProjectLocationAppEvaluationRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), evaluationRunId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationRunId, nameof(evaluationRunId)))
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
        /// The <c>App</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// The <c>EvaluationRun</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string EvaluationRunId { get; }

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
                case ResourceNameType.ProjectLocationAppEvaluationRun: return s_projectLocationAppEvaluationRun.Expand(ProjectId, LocationId, AppId, EvaluationRunId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EvaluationRunName);

        /// <inheritdoc/>
        public bool Equals(EvaluationRunName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EvaluationRunName a, EvaluationRunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EvaluationRunName a, EvaluationRunName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EvaluationExpectation</c> resource.</summary>
    public sealed partial class EvaluationExpectationName : gax::IResourceName, sys::IEquatable<EvaluationExpectationName>
    {
        /// <summary>The possible contents of <see cref="EvaluationExpectationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}</c>
            /// .
            /// </summary>
            ProjectLocationAppEvaluationExpectation = 1,
        }

        private static gax::PathTemplate s_projectLocationAppEvaluationExpectation = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}");

        /// <summary>Creates a <see cref="EvaluationExpectationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EvaluationExpectationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EvaluationExpectationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EvaluationExpectationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EvaluationExpectationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationExpectationId">
        /// The <c>EvaluationExpectation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EvaluationExpectationName"/> constructed from the provided ids.
        /// </returns>
        public static EvaluationExpectationName FromProjectLocationAppEvaluationExpectation(string projectId, string locationId, string appId, string evaluationExpectationId) =>
            new EvaluationExpectationName(ResourceNameType.ProjectLocationAppEvaluationExpectation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), evaluationExpectationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationExpectationId, nameof(evaluationExpectationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationExpectationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationExpectationId">
        /// The <c>EvaluationExpectation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationExpectationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string appId, string evaluationExpectationId) =>
            FormatProjectLocationAppEvaluationExpectation(projectId, locationId, appId, evaluationExpectationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EvaluationExpectationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationExpectationId">
        /// The <c>EvaluationExpectation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EvaluationExpectationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}</c>.
        /// </returns>
        public static string FormatProjectLocationAppEvaluationExpectation(string projectId, string locationId, string appId, string evaluationExpectationId) =>
            s_projectLocationAppEvaluationExpectation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationExpectationId, nameof(evaluationExpectationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EvaluationExpectationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationExpectationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EvaluationExpectationName"/> if successful.</returns>
        public static EvaluationExpectationName Parse(string evaluationExpectationName) =>
            Parse(evaluationExpectationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EvaluationExpectationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationExpectationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EvaluationExpectationName"/> if successful.</returns>
        public static EvaluationExpectationName Parse(string evaluationExpectationName, bool allowUnparsed) =>
            TryParse(evaluationExpectationName, allowUnparsed, out EvaluationExpectationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationExpectationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="evaluationExpectationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationExpectationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationExpectationName, out EvaluationExpectationName result) =>
            TryParse(evaluationExpectationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EvaluationExpectationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="evaluationExpectationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EvaluationExpectationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string evaluationExpectationName, bool allowUnparsed, out EvaluationExpectationName result)
        {
            gax::GaxPreconditions.CheckNotNull(evaluationExpectationName, nameof(evaluationExpectationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppEvaluationExpectation.TryParseName(evaluationExpectationName, out resourceName))
            {
                result = FromProjectLocationAppEvaluationExpectation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(evaluationExpectationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EvaluationExpectationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string evaluationExpectationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            EvaluationExpectationId = evaluationExpectationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EvaluationExpectationName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/evaluationExpectations/{evaluation_expectation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="evaluationExpectationId">
        /// The <c>EvaluationExpectation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public EvaluationExpectationName(string projectId, string locationId, string appId, string evaluationExpectationId) : this(ResourceNameType.ProjectLocationAppEvaluationExpectation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), evaluationExpectationId: gax::GaxPreconditions.CheckNotNullOrEmpty(evaluationExpectationId, nameof(evaluationExpectationId)))
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
        /// The <c>App</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// The <c>EvaluationExpectation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string EvaluationExpectationId { get; }

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
                case ResourceNameType.ProjectLocationAppEvaluationExpectation: return s_projectLocationAppEvaluationExpectation.Expand(ProjectId, LocationId, AppId, EvaluationExpectationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EvaluationExpectationName);

        /// <inheritdoc/>
        public bool Equals(EvaluationExpectationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EvaluationExpectationName a, EvaluationExpectationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EvaluationExpectationName a, EvaluationExpectationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ScheduledEvaluationRun</c> resource.</summary>
    public sealed partial class ScheduledEvaluationRunName : gax::IResourceName, sys::IEquatable<ScheduledEvaluationRunName>
    {
        /// <summary>The possible contents of <see cref="ScheduledEvaluationRunName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}</c>
            /// .
            /// </summary>
            ProjectLocationAppScheduledEvaluationRun = 1,
        }

        private static gax::PathTemplate s_projectLocationAppScheduledEvaluationRun = new gax::PathTemplate("projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}");

        /// <summary>Creates a <see cref="ScheduledEvaluationRunName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ScheduledEvaluationRunName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ScheduledEvaluationRunName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ScheduledEvaluationRunName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ScheduledEvaluationRunName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduledEvaluationRunId">
        /// The <c>ScheduledEvaluationRun</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ScheduledEvaluationRunName"/> constructed from the provided ids.
        /// </returns>
        public static ScheduledEvaluationRunName FromProjectLocationAppScheduledEvaluationRun(string projectId, string locationId, string appId, string scheduledEvaluationRunId) =>
            new ScheduledEvaluationRunName(ResourceNameType.ProjectLocationAppScheduledEvaluationRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), scheduledEvaluationRunId: gax::GaxPreconditions.CheckNotNullOrEmpty(scheduledEvaluationRunId, nameof(scheduledEvaluationRunId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScheduledEvaluationRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduledEvaluationRunId">
        /// The <c>ScheduledEvaluationRun</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ScheduledEvaluationRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string appId, string scheduledEvaluationRunId) =>
            FormatProjectLocationAppScheduledEvaluationRun(projectId, locationId, appId, scheduledEvaluationRunId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ScheduledEvaluationRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduledEvaluationRunId">
        /// The <c>ScheduledEvaluationRun</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ScheduledEvaluationRunName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationAppScheduledEvaluationRun(string projectId, string locationId, string appId, string scheduledEvaluationRunId) =>
            s_projectLocationAppScheduledEvaluationRun.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), gax::GaxPreconditions.CheckNotNullOrEmpty(scheduledEvaluationRunId, nameof(scheduledEvaluationRunId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ScheduledEvaluationRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="scheduledEvaluationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ScheduledEvaluationRunName"/> if successful.</returns>
        public static ScheduledEvaluationRunName Parse(string scheduledEvaluationRunName) =>
            Parse(scheduledEvaluationRunName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ScheduledEvaluationRunName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scheduledEvaluationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ScheduledEvaluationRunName"/> if successful.</returns>
        public static ScheduledEvaluationRunName Parse(string scheduledEvaluationRunName, bool allowUnparsed) =>
            TryParse(scheduledEvaluationRunName, allowUnparsed, out ScheduledEvaluationRunName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScheduledEvaluationRunName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="scheduledEvaluationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScheduledEvaluationRunName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scheduledEvaluationRunName, out ScheduledEvaluationRunName result) =>
            TryParse(scheduledEvaluationRunName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ScheduledEvaluationRunName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="scheduledEvaluationRunName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ScheduledEvaluationRunName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string scheduledEvaluationRunName, bool allowUnparsed, out ScheduledEvaluationRunName result)
        {
            gax::GaxPreconditions.CheckNotNull(scheduledEvaluationRunName, nameof(scheduledEvaluationRunName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAppScheduledEvaluationRun.TryParseName(scheduledEvaluationRunName, out resourceName))
            {
                result = FromProjectLocationAppScheduledEvaluationRun(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(scheduledEvaluationRunName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ScheduledEvaluationRunName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string appId = null, string locationId = null, string projectId = null, string scheduledEvaluationRunId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AppId = appId;
            LocationId = locationId;
            ProjectId = projectId;
            ScheduledEvaluationRunId = scheduledEvaluationRunId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ScheduledEvaluationRunName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/apps/{app}/scheduledEvaluationRuns/{scheduled_evaluation_run}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="appId">The <c>App</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="scheduledEvaluationRunId">
        /// The <c>ScheduledEvaluationRun</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ScheduledEvaluationRunName(string projectId, string locationId, string appId, string scheduledEvaluationRunId) : this(ResourceNameType.ProjectLocationAppScheduledEvaluationRun, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), appId: gax::GaxPreconditions.CheckNotNullOrEmpty(appId, nameof(appId)), scheduledEvaluationRunId: gax::GaxPreconditions.CheckNotNullOrEmpty(scheduledEvaluationRunId, nameof(scheduledEvaluationRunId)))
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
        /// The <c>App</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ScheduledEvaluationRun</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ScheduledEvaluationRunId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAppScheduledEvaluationRun: return s_projectLocationAppScheduledEvaluationRun.Expand(ProjectId, LocationId, AppId, ScheduledEvaluationRunId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ScheduledEvaluationRunName);

        /// <inheritdoc/>
        public bool Equals(ScheduledEvaluationRunName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ScheduledEvaluationRunName a, ScheduledEvaluationRunName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ScheduledEvaluationRunName a, ScheduledEvaluationRunName b) => !(a == b);
    }

    public partial class AggregatedMetrics
    {
        public partial class Types
        {
            public partial class ToolMetrics
            {
                /// <summary>
                /// <see cref="ToolName"/>-typed view over the <see cref="Tool"/> resource name property.
                /// </summary>
                public ToolName ToolAsToolName
                {
                    get => string.IsNullOrEmpty(Tool) ? null : ToolName.Parse(Tool, allowUnparsed: true);
                    set => Tool = value?.ToString() ?? "";
                }
            }

            public partial class ToolCallLatencyMetrics
            {
                /// <summary>
                /// <see cref="ToolName"/>-typed view over the <see cref="Tool"/> resource name property.
                /// </summary>
                public ToolName ToolAsToolName
                {
                    get => string.IsNullOrEmpty(Tool) ? null : ToolName.Parse(Tool, allowUnparsed: true);
                    set => Tool = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class Evaluation
    {
        /// <summary>
        /// <see cref="gccv::EvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationName EvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EvaluationDatasetName"/>-typed view over the <see cref="EvaluationDatasets"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<EvaluationDatasetName> EvaluationDatasetsAsEvaluationDatasetNames
        {
            get => new gax::ResourceNameList<EvaluationDatasetName>(EvaluationDatasets, s => string.IsNullOrEmpty(s) ? null : EvaluationDatasetName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="EvaluationRunName"/>-typed view over the <see cref="EvaluationRuns"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<EvaluationRunName> EvaluationRunsAsEvaluationRunNames
        {
            get => new gax::ResourceNameList<EvaluationRunName>(EvaluationRuns, s => string.IsNullOrEmpty(s) ? null : EvaluationRunName.Parse(s, allowUnparsed: true));
        }

        public partial class Types
        {
            public partial class Golden
            {
                /// <summary>
                /// <see cref="EvaluationExpectationName"/>-typed view over the <see cref="EvaluationExpectations"/>
                /// resource name property.
                /// </summary>
                public gax::ResourceNameList<EvaluationExpectationName> EvaluationExpectationsAsEvaluationExpectationNames
                {
                    get => new gax::ResourceNameList<EvaluationExpectationName>(EvaluationExpectations, s => string.IsNullOrEmpty(s) ? null : EvaluationExpectationName.Parse(s, allowUnparsed: true));
                }
            }

            public partial class Scenario
            {
                /// <summary>
                /// <see cref="EvaluationExpectationName"/>-typed view over the <see cref="EvaluationExpectations"/>
                /// resource name property.
                /// </summary>
                public gax::ResourceNameList<EvaluationExpectationName> EvaluationExpectationsAsEvaluationExpectationNames
                {
                    get => new gax::ResourceNameList<EvaluationExpectationName>(EvaluationExpectations, s => string.IsNullOrEmpty(s) ? null : EvaluationExpectationName.Parse(s, allowUnparsed: true));
                }
            }
        }
    }

    public partial class EvaluationDataset
    {
        /// <summary>
        /// <see cref="gccv::EvaluationDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationDatasetName EvaluationDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EvaluationName"/>-typed view over the <see cref="Evaluations"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<EvaluationName> EvaluationsAsEvaluationNames
        {
            get => new gax::ResourceNameList<EvaluationName>(Evaluations, s => string.IsNullOrEmpty(s) ? null : EvaluationName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class EvaluationResult
    {
        /// <summary>
        /// <see cref="gccv::EvaluationResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationResultName EvaluationResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EvaluationRunName"/>-typed view over the <see cref="EvaluationRun"/> resource name property.
        /// </summary>
        public EvaluationRunName EvaluationRunAsEvaluationRunName
        {
            get => string.IsNullOrEmpty(EvaluationRun) ? null : EvaluationRunName.Parse(EvaluationRun, allowUnparsed: true);
            set => EvaluationRun = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AppVersionName"/>-typed view over the <see cref="AppVersion"/> resource name property.
        /// </summary>
        public AppVersionName AppVersionAsAppVersionName
        {
            get => string.IsNullOrEmpty(AppVersion) ? null : AppVersionName.Parse(AppVersion, allowUnparsed: true);
            set => AppVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ChangelogName"/>-typed view over the <see cref="Changelog"/> resource name property.
        /// </summary>
        public ChangelogName ChangelogAsChangelogName
        {
            get => string.IsNullOrEmpty(Changelog) ? null : ChangelogName.Parse(Changelog, allowUnparsed: true);
            set => Changelog = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class EvaluationExpectationResult
            {
                /// <summary>
                /// <see cref="EvaluationExpectationName"/>-typed view over the <see cref="EvaluationExpectation"/>
                /// resource name property.
                /// </summary>
                public EvaluationExpectationName EvaluationExpectationAsEvaluationExpectationName
                {
                    get => string.IsNullOrEmpty(EvaluationExpectation) ? null : EvaluationExpectationName.Parse(EvaluationExpectation, allowUnparsed: true);
                    set => EvaluationExpectation = value?.ToString() ?? "";
                }
            }

            public partial class GoldenResult
            {
                public partial class Types
                {
                    public partial class TurnReplayResult
                    {
                        /// <summary>
                        /// <see cref="ConversationName"/>-typed view over the <see cref="Conversation"/> resource name
                        /// property.
                        /// </summary>
                        public ConversationName ConversationAsConversationName
                        {
                            get => string.IsNullOrEmpty(Conversation) ? null : ConversationName.Parse(Conversation, allowUnparsed: true);
                            set => Conversation = value?.ToString() ?? "";
                        }
                    }
                }
            }

            public partial class ScenarioResult
            {
                /// <summary>
                /// <see cref="ConversationName"/>-typed view over the <see cref="Conversation"/> resource name
                /// property.
                /// </summary>
                public ConversationName ConversationAsConversationName
                {
                    get => string.IsNullOrEmpty(Conversation) ? null : ConversationName.Parse(Conversation, allowUnparsed: true);
                    set => Conversation = value?.ToString() ?? "";
                }
            }

            public partial class ToolCallLatency
            {
                /// <summary>
                /// <see cref="ToolName"/>-typed view over the <see cref="Tool"/> resource name property.
                /// </summary>
                public ToolName ToolAsToolName
                {
                    get => string.IsNullOrEmpty(Tool) ? null : ToolName.Parse(Tool, allowUnparsed: true);
                    set => Tool = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class EvaluationRun
    {
        /// <summary>
        /// <see cref="gccv::EvaluationRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationRunName EvaluationRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EvaluationResultName"/>-typed view over the <see cref="EvaluationResults"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<EvaluationResultName> EvaluationResultsAsEvaluationResultNames
        {
            get => new gax::ResourceNameList<EvaluationResultName>(EvaluationResults, s => string.IsNullOrEmpty(s) ? null : EvaluationResultName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="AppVersionName"/>-typed view over the <see cref="AppVersion"/> resource name property.
        /// </summary>
        public AppVersionName AppVersionAsAppVersionName
        {
            get => string.IsNullOrEmpty(AppVersion) ? null : AppVersionName.Parse(AppVersion, allowUnparsed: true);
            set => AppVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EvaluationName"/>-typed view over the <see cref="Evaluations"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<EvaluationName> EvaluationsAsEvaluationNames
        {
            get => new gax::ResourceNameList<EvaluationName>(Evaluations, s => string.IsNullOrEmpty(s) ? null : EvaluationName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="EvaluationDatasetName"/>-typed view over the <see cref="EvaluationDataset"/> resource name
        /// property.
        /// </summary>
        public EvaluationDatasetName EvaluationDatasetAsEvaluationDatasetName
        {
            get => string.IsNullOrEmpty(EvaluationDataset) ? null : EvaluationDatasetName.Parse(EvaluationDataset, allowUnparsed: true);
            set => EvaluationDataset = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ScheduledEvaluationRunName"/>-typed view over the <see cref="ScheduledEvaluationRun"/> resource
        /// name property.
        /// </summary>
        public ScheduledEvaluationRunName ScheduledEvaluationRunAsScheduledEvaluationRunName
        {
            get => string.IsNullOrEmpty(ScheduledEvaluationRun) ? null : ScheduledEvaluationRunName.Parse(ScheduledEvaluationRun, allowUnparsed: true);
            set => ScheduledEvaluationRun = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ChangelogName"/>-typed view over the <see cref="Changelog"/> resource name property.
        /// </summary>
        public ChangelogName ChangelogAsChangelogName
        {
            get => string.IsNullOrEmpty(Changelog) ? null : ChangelogName.Parse(Changelog, allowUnparsed: true);
            set => Changelog = value?.ToString() ?? "";
        }
    }

    public partial class LatencyReport
    {
        public partial class Types
        {
            public partial class ToolLatency
            {
                /// <summary>
                /// <see cref="ToolName"/>-typed view over the <see cref="Tool"/> resource name property.
                /// </summary>
                public ToolName ToolAsToolName
                {
                    get => string.IsNullOrEmpty(Tool) ? null : ToolName.Parse(Tool, allowUnparsed: true);
                    set => Tool = value?.ToString() ?? "";
                }
            }

            public partial class GuardrailLatency
            {
                /// <summary>
                /// <see cref="GuardrailName"/>-typed view over the <see cref="Guardrail"/> resource name property.
                /// </summary>
                public GuardrailName GuardrailAsGuardrailName
                {
                    get => string.IsNullOrEmpty(Guardrail) ? null : GuardrailName.Parse(Guardrail, allowUnparsed: true);
                    set => Guardrail = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class EvaluationExpectation
    {
        /// <summary>
        /// <see cref="gccv::EvaluationExpectationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationExpectationName EvaluationExpectationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationExpectationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RunEvaluationRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="App"/> resource name property.</summary>
        public AppName AppAsAppName
        {
            get => string.IsNullOrEmpty(App) ? null : AppName.Parse(App, allowUnparsed: true);
            set => App = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EvaluationName"/>-typed view over the <see cref="Evaluations"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<EvaluationName> EvaluationsAsEvaluationNames
        {
            get => new gax::ResourceNameList<EvaluationName>(Evaluations, s => string.IsNullOrEmpty(s) ? null : EvaluationName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="EvaluationDatasetName"/>-typed view over the <see cref="EvaluationDataset"/> resource name
        /// property.
        /// </summary>
        public EvaluationDatasetName EvaluationDatasetAsEvaluationDatasetName
        {
            get => string.IsNullOrEmpty(EvaluationDataset) ? null : EvaluationDatasetName.Parse(EvaluationDataset, allowUnparsed: true);
            set => EvaluationDataset = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AppVersionName"/>-typed view over the <see cref="AppVersion"/> resource name property.
        /// </summary>
        public AppVersionName AppVersionAsAppVersionName
        {
            get => string.IsNullOrEmpty(AppVersion) ? null : AppVersionName.Parse(AppVersion, allowUnparsed: true);
            set => AppVersion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ScheduledEvaluationRunName"/>-typed view over the <see cref="ScheduledEvaluationRun"/> resource
        /// name property.
        /// </summary>
        public ScheduledEvaluationRunName ScheduledEvaluationRunAsScheduledEvaluationRunName
        {
            get => string.IsNullOrEmpty(ScheduledEvaluationRun) ? null : ScheduledEvaluationRunName.Parse(ScheduledEvaluationRun, allowUnparsed: true);
            set => ScheduledEvaluationRun = value?.ToString() ?? "";
        }
    }

    public partial class ScheduledEvaluationRun
    {
        /// <summary>
        /// <see cref="gccv::ScheduledEvaluationRunName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::ScheduledEvaluationRunName ScheduledEvaluationRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ScheduledEvaluationRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EvaluationRunName"/>-typed view over the <see cref="LastCompletedRun"/> resource name property.
        /// </summary>
        public EvaluationRunName LastCompletedRunAsEvaluationRunName
        {
            get => string.IsNullOrEmpty(LastCompletedRun) ? null : EvaluationRunName.Parse(LastCompletedRun, allowUnparsed: true);
            set => LastCompletedRun = value?.ToString() ?? "";
        }
    }
}
