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
using gcvv = Google.Cloud.VisionAI.V1;
using sys = System;

namespace Google.Cloud.VisionAI.V1
{
    /// <summary>Resource name for the <c>Operator</c> resource.</summary>
    public sealed partial class OperatorName : gax::IResourceName, sys::IEquatable<OperatorName>
    {
        /// <summary>The possible contents of <see cref="OperatorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/operators/{operator}</c>.
            /// </summary>
            ProjectLocationOperator = 1,
        }

        private static gax::PathTemplate s_projectLocationOperator = new gax::PathTemplate("projects/{project}/locations/{location}/operators/{operator}");

        /// <summary>Creates a <see cref="OperatorName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OperatorName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static OperatorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OperatorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OperatorName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/operators/{operator}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operatorId">The <c>Operator</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OperatorName"/> constructed from the provided ids.</returns>
        public static OperatorName FromProjectLocationOperator(string projectId, string locationId, string operatorId) =>
            new OperatorName(ResourceNameType.ProjectLocationOperator, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), operatorId: gax::GaxPreconditions.CheckNotNullOrEmpty(operatorId, nameof(operatorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OperatorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/operators/{operator}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operatorId">The <c>Operator</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OperatorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/operators/{operator}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string operatorId) =>
            FormatProjectLocationOperator(projectId, locationId, operatorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OperatorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/operators/{operator}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operatorId">The <c>Operator</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OperatorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/operators/{operator}</c>.
        /// </returns>
        public static string FormatProjectLocationOperator(string projectId, string locationId, string operatorId) =>
            s_projectLocationOperator.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(operatorId, nameof(operatorId)));

        /// <summary>Parses the given resource name string into a new <see cref="OperatorName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/operators/{operator}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="operatorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OperatorName"/> if successful.</returns>
        public static OperatorName Parse(string operatorName) => Parse(operatorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OperatorName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/operators/{operator}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="operatorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OperatorName"/> if successful.</returns>
        public static OperatorName Parse(string operatorName, bool allowUnparsed) =>
            TryParse(operatorName, allowUnparsed, out OperatorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OperatorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/operators/{operator}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="operatorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OperatorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string operatorName, out OperatorName result) => TryParse(operatorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OperatorName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/operators/{operator}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="operatorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OperatorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string operatorName, bool allowUnparsed, out OperatorName result)
        {
            gax::GaxPreconditions.CheckNotNull(operatorName, nameof(operatorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationOperator.TryParseName(operatorName, out resourceName))
            {
                result = FromProjectLocationOperator(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(operatorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OperatorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string operatorId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OperatorId = operatorId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OperatorName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/operators/{operator}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operatorId">The <c>Operator</c> ID. Must not be <c>null</c> or empty.</param>
        public OperatorName(string projectId, string locationId, string operatorId) : this(ResourceNameType.ProjectLocationOperator, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), operatorId: gax::GaxPreconditions.CheckNotNullOrEmpty(operatorId, nameof(operatorId)))
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
        /// The <c>Operator</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OperatorId { get; }

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
                case ResourceNameType.ProjectLocationOperator: return s_projectLocationOperator.Expand(ProjectId, LocationId, OperatorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OperatorName);

        /// <inheritdoc/>
        public bool Equals(OperatorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OperatorName a, OperatorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OperatorName a, OperatorName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Analysis</c> resource.</summary>
    public sealed partial class AnalysisName : gax::IResourceName, sys::IEquatable<AnalysisName>
    {
        /// <summary>The possible contents of <see cref="AnalysisName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}</c>.
            /// </summary>
            ProjectLocationClusterAnalysis = 1,
        }

        private static gax::PathTemplate s_projectLocationClusterAnalysis = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}");

        /// <summary>Creates a <see cref="AnalysisName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnalysisName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static AnalysisName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnalysisName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnalysisName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnalysisName"/> constructed from the provided ids.</returns>
        public static AnalysisName FromProjectLocationClusterAnalysis(string projectId, string locationId, string clusterId, string analysisId) =>
            new AnalysisName(ResourceNameType.ProjectLocationClusterAnalysis, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), analysisId: gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clusterId, string analysisId) =>
            FormatProjectLocationClusterAnalysis(projectId, locationId, clusterId, analysisId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnalysisName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}</c>.
        /// </returns>
        public static string FormatProjectLocationClusterAnalysis(string projectId, string locationId, string clusterId, string analysisId) =>
            s_projectLocationClusterAnalysis.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)));

        /// <summary>Parses the given resource name string into a new <see cref="AnalysisName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnalysisName"/> if successful.</returns>
        public static AnalysisName Parse(string analysisName) => Parse(analysisName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnalysisName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnalysisName"/> if successful.</returns>
        public static AnalysisName Parse(string analysisName, bool allowUnparsed) =>
            TryParse(analysisName, allowUnparsed, out AnalysisName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalysisName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalysisName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analysisName, out AnalysisName result) => TryParse(analysisName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalysisName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analysisName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalysisName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analysisName, bool allowUnparsed, out AnalysisName result)
        {
            gax::GaxPreconditions.CheckNotNull(analysisName, nameof(analysisName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationClusterAnalysis.TryParseName(analysisName, out resourceName))
            {
                result = FromProjectLocationClusterAnalysis(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(analysisName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnalysisName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string analysisId = null, string clusterId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnalysisId = analysisId;
            ClusterId = clusterId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnalysisName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/analyses/{analysis}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analysisId">The <c>Analysis</c> ID. Must not be <c>null</c> or empty.</param>
        public AnalysisName(string projectId, string locationId, string clusterId, string analysisId) : this(ResourceNameType.ProjectLocationClusterAnalysis, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), analysisId: gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)))
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
        /// The <c>Analysis</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AnalysisId { get; }

        /// <summary>
        /// The <c>Cluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClusterId { get; }

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
                case ResourceNameType.ProjectLocationClusterAnalysis: return s_projectLocationClusterAnalysis.Expand(ProjectId, LocationId, ClusterId, AnalysisId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnalysisName);

        /// <inheritdoc/>
        public bool Equals(AnalysisName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AnalysisName a, AnalysisName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AnalysisName a, AnalysisName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Process</c> resource.</summary>
    public sealed partial class ProcessName : gax::IResourceName, sys::IEquatable<ProcessName>
    {
        /// <summary>The possible contents of <see cref="ProcessName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}</c>.
            /// </summary>
            ProjectLocationClusterProcess = 1,
        }

        private static gax::PathTemplate s_projectLocationClusterProcess = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}");

        /// <summary>Creates a <see cref="ProcessName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProcessName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProcessName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProcessName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProcessName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProcessName"/> constructed from the provided ids.</returns>
        public static ProcessName FromProjectLocationClusterProcess(string projectId, string locationId, string clusterId, string processId) =>
            new ProcessName(ResourceNameType.ProjectLocationClusterProcess, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), processId: gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clusterId, string processId) =>
            FormatProjectLocationClusterProcess(projectId, locationId, clusterId, processId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProcessName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProcessName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}</c>.
        /// </returns>
        public static string FormatProjectLocationClusterProcess(string projectId, string locationId, string clusterId, string processId) =>
            s_projectLocationClusterProcess.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProcessName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="processName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProcessName"/> if successful.</returns>
        public static ProcessName Parse(string processName) => Parse(processName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProcessName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProcessName"/> if successful.</returns>
        public static ProcessName Parse(string processName, bool allowUnparsed) =>
            TryParse(processName, allowUnparsed, out ProcessName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="processName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processName, out ProcessName result) => TryParse(processName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProcessName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="processName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProcessName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string processName, bool allowUnparsed, out ProcessName result)
        {
            gax::GaxPreconditions.CheckNotNull(processName, nameof(processName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationClusterProcess.TryParseName(processName, out resourceName))
            {
                result = FromProjectLocationClusterProcess(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(processName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProcessName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string locationId = null, string processId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            LocationId = locationId;
            ProcessId = processId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProcessName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/processes/{process}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="processId">The <c>Process</c> ID. Must not be <c>null</c> or empty.</param>
        public ProcessName(string projectId, string locationId, string clusterId, string processId) : this(ResourceNameType.ProjectLocationClusterProcess, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), processId: gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)))
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
        /// The <c>Cluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClusterId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Process</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProcessId { get; }

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
                case ResourceNameType.ProjectLocationClusterProcess: return s_projectLocationClusterProcess.Expand(ProjectId, LocationId, ClusterId, ProcessId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProcessName);

        /// <inheritdoc/>
        public bool Equals(ProcessName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProcessName a, ProcessName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProcessName a, ProcessName b) => !(a == b);
    }

    public partial class Operator
    {
        /// <summary>
        /// <see cref="gcvv::OperatorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::OperatorName OperatorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::OperatorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Analysis
    {
        /// <summary>
        /// <see cref="gcvv::AnalysisName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::AnalysisName AnalysisName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::AnalysisName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Process
    {
        /// <summary>
        /// <see cref="gcvv::ProcessName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ProcessName ProcessName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ProcessName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AnalysisName"/>-typed view over the <see cref="Analysis"/> resource name property.
        /// </summary>
        public AnalysisName AnalysisAsAnalysisName
        {
            get => string.IsNullOrEmpty(Analysis) ? null : AnalysisName.Parse(Analysis, allowUnparsed: true);
            set => Analysis = value?.ToString() ?? "";
        }
    }
}
